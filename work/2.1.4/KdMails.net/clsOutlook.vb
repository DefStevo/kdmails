#Region "Imports"
Imports Microsoft.Office.Interop

#End Region

Public Class clsOutlook

#Region "Deklarationen"
    Private _MSOutlook As Outlook._Application
    Private _MSNameSpace As Outlook.NameSpace
    Private _MSFolders As Outlook.Folders
    Private _MSFold As Outlook.MAPIFolder
    Private _MSItem As Outlook.Items
    Private _MSMailItems As Outlook.Items
    Private _MSMailItem As Outlook.MailItem
    Private _MSAdressList As Outlook.AddressList
    Private _MSAdress As Outlook.AddressEntries

    Public oOrdner As Outlook.MAPIFolder
    Public oMail As Outlook.MailItem

    Private _iMailID As Integer

    Private _bInitStatus As Boolean


#End Region

#Region "Properties"
    ReadOnly Property Status As Boolean
        Get
            Return _bInitStatus
        End Get
    End Property

#End Region

#Region "Funktionen"
#Region "Allgemein"
    Function InitOutlook() As Boolean
        Try
            _MSOutlook = New Outlook.Application
            _MSNameSpace = _MSOutlook.GetNamespace("MAPI")
            _MSAdressList = _MSNameSpace.GetGlobalAddressList()

        Catch ex As System.Runtime.InteropServices.COMException
            Select Case ex.ErrorCode
                Case -2147352567
                    'Kein Globales Adressbuch vorhanden
                    ' - Kein Exchange
                    ' - Offline Modus
                Case Else
                    MsgBox("Fehler: " & ex.ToString, MsgBoxStyle.Critical, "Fehler beim Initialisieren von Outlook")
            End Select
        End Try

        _bInitStatus = True
        Return True
    End Function

    Function UnloadOutlook() As Boolean
        If _bInitStatus = True Then
            _MSOutlook = Nothing
            _MSNameSpace = Nothing
            _MSFolders = Nothing
            _MSFold = Nothing
            _MSItem = Nothing
            _MSMailItem = Nothing
            _bInitStatus = False
        End If
    End Function

#End Region

#Region "OrdnerFunktionen"
    Function FolderSelection(ByRef OrdnerPfad As String, ByRef OrdnerEID As String, ByRef OrdnerSID As String) As Boolean
        'Outlook Initialisieren wenn noch nicht erfolgt
        If _bInitStatus = False Then
            InitOutlook()
        End If

        _MSFold = _MSNameSpace.PickFolder

        If Not _MSFold Is Nothing Then
            OrdnerPfad = _MSFold.Name
            OrdnerEID = _MSFold.EntryID
            OrdnerSID = _MSFold.StoreID
        End If

        Return True

    End Function

    Function GetFolders(ByVal OrdnerEID As String, ByVal OrdnerSID As String) As Outlook.MAPIFolder
        'Outlook Initialisieren wenn noch nicht erfolgt
        If _bInitStatus = False Then
            InitOutlook()
        End If

        _MSFolders = _MSNameSpace.GetFolderFromID(OrdnerEID, OrdnerSID).Folders

        Return _MSFolders.GetFirst
    End Function

    Function GetNextFolder() As Outlook.MAPIFolder
        'Funktion GetFolders muss zuvor aufgerufen werden
        If _bInitStatus = False Or _MSFolders Is Nothing Then
            Return Nothing
        End If

        Return _MSFolders.GetNext
    End Function
#End Region

#Region "Mail-Funktionen"
    Function GetMails(ByVal OrdnerEID As String, ByVal OrdnerSID As String) As Outlook.MailItem
        'Outlook Initialisieren wenn noch nicht erfolgt
        Try
            If _bInitStatus = False Then
                InitOutlook()
            End If

            _MSFold = _MSNameSpace.GetFolderFromID(OrdnerEID, OrdnerSID)

            Dim strDateLast As String = ""
            strDateLast = frmHaupt.cConfig.GetSettings(clsConfig.ESettings.LetzerLauf_Datum) & " " & _
                          frmHaupt.cConfig.GetSettings(clsConfig.ESettings.LetzerLauf_Zeit)

            _MSMailItems = _MSFold.Items.Restrict("[ReceivedTime] > '" & strDateLast & "'")

            If _MSMailItems.Count = 0 Then
                Return Nothing
            Else
                _iMailID = 1
                _MSMailItems.Sort("ReceivedTime", False)
            End If

            _MSMailItem = _MSMailItems.Item(_iMailID)

            Return _MSMailItem

        Catch ex As System.InvalidCastException
            'Terminbestätigung empfangen oder gesendet
            _MSMailItem = GetNextMail()

        Catch ex As Exception
            MsgBox("Fehler: " & ex.ToString, MsgBoxStyle.Critical, "Fehler beim ermitteln der E-Mails")
            _MSMailItem = GetNextMail()

        End Try
        Return _MSMailItem
    End Function

    Function GetNextMail() As Outlook.MailItem
        Try
            'Funktion GetMails muss zuvor aufgerufen werden
            If _bInitStatus = False Or _MSFold Is Nothing Then
                Return Nothing
            End If

            _iMailID += 1

            If _MSMailItems.Count >= _iMailID Then
                _MSMailItem = _MSMailItems(_iMailID)
            Else
                _MSMailItem = Nothing
            End If

            Return _MSMailItem

        Catch ex As System.InvalidCastException
            'Terminbestätigung empfangen oder gesendet
            _MSMailItem = GetNextMail()

        Catch ex As Exception
            MsgBox("Fehler: " & ex.ToString, MsgBoxStyle.Critical, "Fehler beim ermitteln der nächsten E-Mail")
            _MSMailItem = GetNextMail()

        End Try

        Return _MSMailItem
    End Function

    Function CopyMail(ByVal MailEID As String, ByVal OrdnerEID As String, ByVal OrdnerSID As String, ByVal Copy As Integer) As Boolean
        _MSMailItem = _MSNameSpace.GetItemFromID(MailEID)

        If Not OrdnerEID = Nothing And Not OrdnerSID = Nothing Then
            _MSFold = _MSNameSpace.GetFolderFromID(OrdnerEID, OrdnerSID)
            If Copy = 0 Then
                _MSMailItem.Copy()
            End If
            _MSMailItem.Move(_MSFold)
        Else
            _MSMailItem.Save()
        End If
    End Function

    Function ResetAllMails(ByVal OrdnerEID As String, ByVal OrdnerSID As String) As Boolean

        If _bInitStatus = False Then
            InitOutlook()
        End If

        If Not OrdnerEID Is Nothing And Not OrdnerSID Is Nothing Then
            _MSFold = _MSNameSpace.GetFolderFromID(OrdnerEID, OrdnerSID)

            For iMailID As Integer = 1 To _MSFold.Items.Count
                _MSMailItem = _MSFold.Items(iMailID)

                If Not _MSMailItem.UserProperties.Find("KDMailsNet") Is Nothing Then
                    _MSMailItem.UserProperties.Find("KDMailsNet").Delete()
                    _MSMailItem.Save()
                End If
            Next
        End If
    End Function

#End Region

#End Region

End Class
