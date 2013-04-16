Imports Microsoft.Office.Interop

Public Class frmMails

#Region "Properties/Enum/Const"

#Region "Const"
    Private Const _strCopy = "Kopieren"
    Private Const _strMove = "Verschieben"
    Private Const _strEingang = "E"
    Private Const _strAusgang = "A"
    Private Const _strIgnore = "--- IGNORE ---"

#End Region

    Private Enum _MailInfos As Integer
        SenderEMailAdress = 0
        ReceivedTime = 1
        Subject = 2
        EMailTo = 3
        Recipients = 4
        EntryID = 5
    End Enum

    Private Enum _dgMailColumns As Integer
        cEA = 0
        cMail = 1
        cMailEID = 2
        cOrdner = 3
        cOrdnerEID = 4
        cOrdnerSID = 5
        cKopieren = 6
        cMailAdr = 7
    End Enum

    Private Property _dgItem(ByVal Item As String, ByVal Index As Integer) As String
        Get
            Return dgMails.Item(Item, Index).Value
        End Get
        Set(ByVal value As String)
            dgMails.Item(Item, Index).Value = value
        End Set
    End Property

    Private ReadOnly Property _dgSelected As Integer
        Get
            Return dgMails.SelectedCells.Item(0).RowIndex
        End Get
    End Property

    Private ReadOnly Property _dgSelectedColumn As Integer
        Get
            Return dgMails.SelectedCells.Item(0).ColumnIndex
        End Get
    End Property

    Private WriteOnly Property _dgSetHeader(ByVal Item As String) As String
        Set(ByVal value As String)
            dgMails.Columns(Item).HeaderText = value
        End Set
    End Property

    Private Function _GetdgColumnNameByEnum(ByVal Item As _dgMailColumns) As String
        Select Case Item
            Case 0
                Return "cEA"
            Case 1
                Return "cMail"
            Case 2
                Return "cMailEID"
            Case 3
                Return "cOrdner"
            Case 4
                Return "cOrdnerEID"
            Case 5
                Return "cOrdnerSID"
            Case 6
                Return "cCopy"
            Case 7
                Return "cMailAdress"
            Case Else
                Return ""
        End Select
    End Function

    Private ReadOnly Property _GetMailInfo(ByVal Info As _MailInfos) As String
        Get
            With frmHaupt.cOutlook.oMail

                Select Case Info
                    Case 0
                        Return .SenderEmailAddress

                    Case 1
                        Return .ReceivedTime.ToString

                    Case 2
                        Return .Subject

                    Case 3
                        Return .To

                    Case 4
                        Return .Recipients(1).Address

                    Case 5
                        Return .EntryID

                End Select
            End With

            Return Nothing

        End Get
    End Property

#End Region

#Region "Subs"
    Private Sub frmMails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Show()

        Cursor.Current = Cursors.WaitCursor

        Dim i As Integer = 0
        Dim sDomain As String = ""
        Dim sAdresse As String = ""
        Dim bIgnoreListe As Boolean = False
        Dim bIgnoreListeKomplett As Boolean = False

        Do While dgMails.Rows.Count > 0
            dgMails.Rows.Remove(dgMails.Rows(0))
        Loop

        If frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Mail_KopierenVerschieben) = 0 Then
            _dgSetHeader(_GetdgColumnNameByEnum(_dgMailColumns.cKopieren)) = _strCopy
            btnKopieren.Text = _strCopy
        ElseIf frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Mail_KopierenVerschieben) = 1 Then
            _dgSetHeader(_GetdgColumnNameByEnum(_dgMailColumns.cKopieren)) = _strMove
            btnKopieren.Text = _strMove
        End If

        For x As Integer = 0 To 1

            If x = 0 Then
                frmHaupt.cOutlook.oMail = frmHaupt.cOutlook.GetMails(frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Ordner_Eingang, 2), _
                                                                     frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Ordner_Eingang, 3))
            ElseIf x = 1 Then
                frmHaupt.cOutlook.oMail = frmHaupt.cOutlook.GetMails(frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Ordner_Gesendet, 2), _
                                                                     frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Ordner_Gesendet, 3))
            End If

            Do While Not frmHaupt.cOutlook.oMail Is Nothing
                dgMails.Rows.Add()

                _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cKopieren), i) = True

                If x = 0 Then
                    _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cEA), i) = _strEingang

                    _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMail), i) = _GetMailInfo(_MailInfos.SenderEMailAdress) & ": " & _
                                                                               _GetMailInfo(_MailInfos.ReceivedTime) & vbNewLine & _
                                                                               _GetMailInfo(_MailInfos.Subject)

                    _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMailAdr), i) = _GetMailInfo(_MailInfos.SenderEMailAdress)

                    If Not _GetMailInfo(_MailInfos.SenderEMailAdress) = Nothing Then
                        sAdresse = _GetMailInfo(_MailInfos.SenderEMailAdress)

                        If Not _GetMailInfo(_MailInfos.SenderEMailAdress).IndexOf("@") = -1 Then
                            sDomain = _GetMailInfo(_MailInfos.SenderEMailAdress).Split("@")(1).ToString
                        Else
                            sDomain = sAdresse
                        End If
                    End If

                ElseIf x = 1 Then
                    _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cEA), i) = _strAusgang

                    _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMail), i) = _GetMailInfo(_MailInfos.EMailTo) & ": " & _
                                                                               _GetMailInfo(_MailInfos.ReceivedTime) & vbNewLine & _
                                                                               _GetMailInfo(_MailInfos.Subject)

                    _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMailAdr), i) = _GetMailInfo(_MailInfos.Recipients)

                    sAdresse = _GetMailInfo(_MailInfos.Recipients)

                    If Not _GetMailInfo(_MailInfos.Recipients).IndexOf("@") = -1 Then
                        sDomain = _GetMailInfo(_MailInfos.Recipients).Split("@")(1).ToString

                    Else
                        sDomain = sAdresse

                    End If
                End If

                _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMailEID), i) = _GetMailInfo(_MailInfos.EntryID)

                bIgnoreListe = False
                bIgnoreListeKomplett = False


                'IgnoreList nach Domäne durchsuchen
                If Not frmHaupt.cConfig.SearchIgnoreList("@" & sDomain) = -1 Then
                    'Domäne in IgnoreList gefunden (bIgnore wird Temporär auf True gesetzt)
                    bIgnoreListe = True

                    'Durchsuche ob für die Komplette E-Mail Adresse ein Eintrag in den Domänen vorhanden ist
                    If Not frmHaupt.cConfig.SearchDomain(sAdresse) = -1 Then
                        bIgnoreListe = False
                        bIgnoreListeKomplett = True
                    End If

                ElseIf x = 0 Then
                    'Domäne nicht in IgnoreList gefunden (Suche nach kompletter Adresse)
                    If Not frmHaupt.cConfig.SearchIgnoreList(_GetMailInfo(_MailInfos.SenderEMailAdress)) = -1 Then
                        bIgnoreListe = True

                    End If
                ElseIf x = 1 Then
                    'Domäne nicht in IgnoreList gefunden (Suche nach kompletter Adresse)
                    If Not frmHaupt.cConfig.SearchIgnoreList(_GetMailInfo(_MailInfos.EMailTo)) = -1 Then
                        bIgnoreListe = True

                    End If
                End If

                'Adresse nicht in IgnoreListe
                If bIgnoreListe = False Then

                    'Komplette E-Mail Adresse in Domäne
                    If bIgnoreListeKomplett = True Then

                        'Suche nach Ordner anhand der E-Mail Adresse
                        frmHaupt.cConfig.GetDomain(frmHaupt.cConfig.SearchDomain(sAdresse), _
                                                  Nothing, _
                                                  Nothing, _
                                                  _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), i), _
                                                  _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerEID), i), _
                                                  _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerSID), i))
                    Else
                        'Suche nach Ordner anhand der Domäne
                        frmHaupt.cConfig.GetDomain(frmHaupt.cConfig.SearchDomain("@" & sDomain), _
                                                   Nothing, _
                                                   Nothing, _
                                                   _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), i), _
                                                   _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerEID), i), _
                                                   _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerSID), i))
                    End If

                Else
                    _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), i) = _strIgnore
                End If

                frmHaupt.cOutlook.oMail = frmHaupt.cOutlook.GetNextMail
                i += 1

                btnKopieren.Enabled = True
            Loop

        Next

        Cursor.Current = Cursors.Default

    End Sub

    Private Sub dgMails_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMails.CellDoubleClick
        Dim strTemp As String = ""
        If _dgSelectedColumn = 1 Then
            MsgBox(_dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMail), _dgSelected), _
                   MsgBoxStyle.OkOnly, _
                   _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMailAdr), _dgSelected))

        ElseIf _dgSelectedColumn = 3 Then
            strTemp = _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), _dgSelected)
            frmHaupt.cOutlook.FolderSelection(_dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), _dgSelected), _
                                              _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerEID), _dgSelected), _
                                              _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerSID), _dgSelected))

            If Not _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), _dgSelected) = Nothing Then

                If Not strTemp = _strIgnore Then
                    'Domäne ist nicht auf IgnoreList
                    If Not _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMailAdr), _dgSelected).ToString.IndexOf("@") = -1 Then
                        frmHaupt.cConfig.AddDomain("@" + _
                                                   _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMailAdr), _dgSelected).ToString.Split("@")(1).ToString, _
                                                   _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), _dgSelected).ToString.Split(" - ")(0).ToString, _
                                                   _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), _dgSelected), _
                                                   _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerEID), _dgSelected), _
                                                   _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerSID), _dgSelected))

                    Else
                        frmHaupt.cConfig.AddDomain("@" + _
                                                   _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMailAdr), _dgSelected).ToString, _
                                                   _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), _dgSelected).ToString.Split(" - ")(0).ToString, _
                                                   _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), _dgSelected), _
                                                   _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerEID), _dgSelected), _
                                                   _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerSID), _dgSelected))

                    End If
                Else
                    'Domäne ist nicht auf IgnoreList (Eintragen der kompletten E-Mail Adresse)
                    frmHaupt.cConfig.AddDomain(_dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMailAdr), _dgSelected).ToString, _
                                               _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), _dgSelected).ToString.Split(" - ")(0).ToString, _
                                               _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), _dgSelected), _
                                               _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerEID), _dgSelected), _
                                               _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerSID), _dgSelected))
                End If

            End If
        End If
    End Sub

#End Region

#Region "Buttons"

    Private Sub btnAbbrechen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbbrechen.Click
        Me.Close()
    End Sub

    Private Sub btnKopieren_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKopieren.Click
        Cursor.Current = Cursors.WaitCursor
        Dim i As Integer = 0

        Do While dgMails.Rows.Count > 0
            If _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cKopieren), i) = True Then
                frmHaupt.cOutlook.CopyMail(_dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMailEID), i), _
                                           _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerEID), i), _
                                           _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerSID), i), _
                                           frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Mail_KopierenVerschieben))

            End If

            dgMails.Rows.Remove(dgMails.Rows(i))

        Loop

        frmHaupt.cConfig.SetSettings(clsConfig.ESettings.LetzerLauf_Datum, frmHaupt.strDate)
        frmHaupt.cConfig.SetSettings(clsConfig.ESettings.LetzerLauf_Zeit, frmHaupt.strTime)
        frmHaupt.cConfig.WriteConfigSettings()

        Cursor.Current = Cursors.Default
    End Sub

#End Region

End Class
