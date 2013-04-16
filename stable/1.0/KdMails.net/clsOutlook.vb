Imports Microsoft.Office.Interop

Public Class clsOutlook
#Region "Deklarationen"
    Private _MSOutlook As Outlook._Application
    Private _MSNameSpace As Outlook.NameSpace
    Private _MSFolders As Outlook.Folders
    Private _MSFold As Outlook.MAPIFolder
    Private _MSItem As Outlook.Items
    Private _MSMailItem As Outlook.MailItem
    Private _MSAdressList As Outlook.AddressList
    Private _MSAdress As Outlook.AddressEntries

    Public oOrdner As Outlook.MAPIFolder
    Public oMail As Outlook.MailItem

    Private iMailID As Integer

    Private _bInitStatus As Boolean
#End Region

#Region "Funktionen"
    Function InitOutlook() As Boolean
        _MSOutlook = New Outlook.Application
        _MSNameSpace = _MSOutlook.GetNamespace("MAPI")
        _MSAdressList = _MSNameSpace.GetGlobalAddressList()
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
            Exit Function
        End If

        Return _MSFolders.GetNext
    End Function
#End Region

#Region "Mail-Funktionen"
    Function GetMails(ByVal OrdnerEID As String, ByVal OrdnerSID As String) As Outlook.MailItem
        'Outlook Initialisieren wenn noch nicht erfolgt
        If _bInitStatus = False Then
            InitOutlook()
        End If

        _MSFold = _MSNameSpace.GetFolderFromID(OrdnerEID, OrdnerSID)

        If _MSFold.Items.Count > 0 Then
            iMailID = 1
        End If

        _MSMailItem = _MSFold.Items(iMailID)

        If Not _MSMailItem.UserProperties.Find("KDMailsNet") Is Nothing Then
            _MSMailItem = GetNextMail()
        End If

            Return _MSMailItem
    End Function

    Function GetNextMail() As Outlook.MailItem
        'Funktion GetMails muss zuvor aufgerufen werden
        If _bInitStatus = False Or _MSFold Is Nothing Then
            Return Nothing
            Exit Function
        End If

        iMailID = iMailID + 1

        If _MSFold.Items.Count >= iMailID Then
            _MSMailItem = _MSFold.Items(iMailID)
        Else
            _MSMailItem = Nothing
            Return _MSMailItem
        End If

        If Not _MSMailItem.UserProperties.Find("KDMailsNet") Is Nothing Then
            _MSMailItem = GetNextMail()
        End If

        Return _MSMailItem

    End Function

    Function CopyMail(ByVal MailEID As String, ByVal OrdnerEID As String, ByVal OrdnerSID As String, ByVal Copy As Integer) As Boolean
        _MSMailItem = _MSNameSpace.GetItemFromID(MailEID)

        If Not OrdnerEID = Nothing And Not OrdnerSID = Nothing Then
            _MSFold = _MSNameSpace.GetFolderFromID(OrdnerEID, OrdnerSID)
            If Copy = 0 Then
                _MSMailItem.UserProperties.Add("KdMailsNet", Outlook.OlUserPropertyType.olText)
                _MSMailItem.UserProperties.Find("KdMailsNet").Value = "OK"
                _MSMailItem.Copy()
            End If
            _MSMailItem.Move(_MSFold)
        Else
            _MSMailItem.UserProperties.Add("KdMailsNet", Outlook.OlUserPropertyType.olText)
            _MSMailItem.UserProperties.Find("KdMailsNet").Value = "OK"
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

#Region "Adress-Funktionen"
    Function GetAdress(ByVal Name As String) As String

        Return " "
    End Function
#End Region

#End Region

End Class
