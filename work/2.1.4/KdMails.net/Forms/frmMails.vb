﻿#Region "Imports"
Imports Microsoft.Office.Interop

#End Region

Public Class frmMails

#Region "Enum"
    Private Enum _Konstante
        Kopieren
        Verschieben
        E
        A
        U
        IGNORE
        EX
        UNGELESEN
    End Enum

    Private Enum _MailInfos As Integer
        EMailFrom = 0
        EMailTo = 1
        ReceivedTime = 2
        Subject = 3
        EntryID = 4
        Unread = 5
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

    Private Enum _UnreadMailInfos As Integer
        EntryId = 0
        Adresse = 1
    End Enum

#End Region

#Region "Properties"
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
                        Return .Recipients(1).Address

                    Case 2
                        Return .ReceivedTime.ToString

                    Case 3
                        Return .Subject

                    Case 4
                        Return .EntryID

                    Case 5
                        Return .UnRead

                End Select
            End With

            Return Nothing

        End Get
    End Property

    Private ReadOnly Property _GetUnreadMailInfo(ByVal Info As _UnreadMailInfos, ByVal Index As Integer) As Object
        Get
            With frmHaupt.cConfig.oUnreadMailL(Index)
                Select Case Info
                    Case 0
                        Return .strEntryId
                    Case 1
                        Return .strAdresse
                End Select
            End With
            Return Nothing
        End Get
    End Property

    Private ReadOnly Property _GetUnreadMailCount() As Integer
        Get
            Return frmHaupt.cConfig.oUnreadMailL.Count
        End Get
    End Property



#End Region

#Region "Subs"
    Private Sub frmMails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Show()

        Cursor.Current = Cursors.WaitCursor

        Dim i As Integer = 0
        Dim strDomain As String = ""
        Dim strAdresse As String = ""
        Dim bIgnoreListe As Boolean = False
        Dim bIgnoreListeKomplett As Boolean = False

        'Datagrid leeren
        Do While dgMails.Rows.Count > 0
            dgMails.Rows.Remove(dgMails.Rows(0))
        Loop

        'Bezeichnungen setzen (Kopieren/Verschieben)
        If frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Mail_KopierenVerschieben) = 0 Then
            _dgSetHeader(_GetdgColumnNameByEnum(_dgMailColumns.cKopieren)) = _Konstante.Kopieren.ToString
            btnKopieren.Text = _Konstante.Kopieren.ToString
        ElseIf frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Mail_KopierenVerschieben) = 1 Then
            _dgSetHeader(_GetdgColumnNameByEnum(_dgMailColumns.cKopieren)) = _Konstante.Verschieben.ToString
            btnKopieren.Text = _Konstante.Verschieben.ToString
        End If


        'Durchlauf für 
        'Posteingang x = 0, 
        'Gesendete Objekte x = 1
        For x As Integer = 0 To 1

            'E-Mails laden
            If x = 0 Then
                'Gespeicherte Ungelesenen Nachrichten Laden
                For y As Integer = 0 To _GetUnReadMailCount - 1
                    frmHaupt.cOutlook.oMail = frmHaupt.cOutlook.GetMailById(_GetUnreadMailInfo(_UnreadMailInfos.EntryId, y))
                    'frmHaupt.cConfig.oUnreadMailL(y).strEntryId)

                    If Not frmHaupt.cOutlook.oMail Is Nothing Then
                        dgMails.Rows.Add()

                        _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cKopieren), i) = True

                        _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cEA), i) = _Konstante.U.ToString

                        strAdresse = _GetMailInfo(_MailInfos.EMailFrom)

                        Try
                            'Abfrage auf LDAP kann Fehler zurückmelden (zb Ex-Kollege)
                            GetDomainFromLDAP(strAdresse, strDomain)

                        Catch ex As Exception
                            Dim strFText As String = ""

                            If strAdresse Is Nothing Then
                                strAdresse = "???"
                                strDomain = ""
                            End If

                            strFText = "!Posteingang - Ungelesene Nachricht" & vbNewLine & _
                                       "Adresse: " & strAdresse & vbNewLine & _
                                       "Domäne: " & strDomain & vbNewLine & _
                                       "Datum/Uhrzeit: " & _GetMailInfo(_MailInfos.ReceivedTime) & vbNewLine & _
                                       "Betreff: " & _GetMailInfo(_MailInfos.Subject) & vbNewLine & vbNewLine & _
                                       ex.Message

                            'MsgBox(strFText, vbOKOnly, "Fehler")

                        End Try

                        _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMail), i) = strAdresse & ": " & _
                                                                                   _GetMailInfo(_MailInfos.ReceivedTime) & vbNewLine & _
                                                                                   _GetMailInfo(_MailInfos.Subject)

                        _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMailAdr), i) = strAdresse

                        _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMailEID), i) = _GetMailInfo(_MailInfos.EntryID)

                        'Mail ist nun gelesen
                        If _GetMailInfo(_MailInfos.Unread) = False Then
                            frmHaupt.cConfig.GetDomain(frmHaupt.cConfig.SearchDomain(_GetUnreadMailInfo(_UnreadMailInfos.Adresse, y)), _
                                                       Nothing, _
                                                       Nothing, _
                                                       _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), i), _
                                                       _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerEID), i), _
                                                       _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerSID), i))

                        Else
                            'Eintrag ist weiterhin ungelesen
                            _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), i) = "--- " + _Konstante.UNGELESEN.ToString + " ---"
                        End If

                        i += 1
                    Else
                        'E-Mail wurde bereits gelöscht verschoben

                    End If

                Next

                frmHaupt.cOutlook.oMail = frmHaupt.cOutlook.GetMails(frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Ordner_Eingang, 2), _
                                                                     frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Ordner_Eingang, 3))
            ElseIf x = 1 Then
                frmHaupt.cOutlook.oMail = frmHaupt.cOutlook.GetMails(frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Ordner_Gesendet, 2), _
                                                                     frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Ordner_Gesendet, 3))
            End If

            'Schleife über alle E-Mails des Ordners
            Do While Not frmHaupt.cOutlook.oMail Is Nothing
                Me.Refresh()

                dgMails.Rows.Add()

                _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cKopieren), i) = True

                If x = 0 Then 'Posteingang
                    _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cEA), i) = _Konstante.E.ToString

                    'E-Mail Adresse setzen
                    strAdresse = _GetMailInfo(_MailInfos.EMailFrom)

                ElseIf x = 1 Then 'Gesendet Objekte
                    _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cEA), i) = _Konstante.A.ToString

                    'E-Mail Adresse setzen
                    strAdresse = _GetMailInfo(_MailInfos.EMailTo)

                End If

                'Adresse per LDAP ermitteln
                Try
                    'Abfrage auf LDAP kann Fehler zurückmelden (zb Ex-Kollege)
                    GetDomainFromLDAP(strAdresse, strDomain)

                Catch ex As Exception
                    Dim strFText As String = ""

                    If strAdresse Is Nothing Then
                        strAdresse = "???"
                        strDomain = ""
                    End If

                    If x = 0 Then
                        strFText = "!Posteingang: " & vbNewLine
                    ElseIf x = 1 Then
                        strFText = "!Gesendete: " & vbNewLine
                    End If

                    strFText = strFText & "Adresse: " & strAdresse & vbNewLine & _
                               "Domäne: " & strDomain & vbNewLine & _
                               "Datum/Uhrzeit: " & _GetMailInfo(_MailInfos.ReceivedTime) & vbNewLine & _
                               "Betreff: " & _GetMailInfo(_MailInfos.Subject) & vbNewLine & vbNewLine & _
                               ex.Message

                    'MsgBox(strFText, vbOKOnly, "Fehler")

                End Try

                _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMail), i) = strAdresse & ": " & _
                                                                           _GetMailInfo(_MailInfos.ReceivedTime) & vbNewLine & _
                                                                           _GetMailInfo(_MailInfos.Subject)

                _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMailAdr), i) = strAdresse

                _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMailEID), i) = _GetMailInfo(_MailInfos.EntryID)

                bIgnoreListe = False
                bIgnoreListeKomplett = False

                'Ignore Liste durchsuchen
                GetIgnoreList(bIgnoreListe, bIgnoreListeKomplett, strAdresse, strDomain)

                'Adresse nicht in IgnoreListe
                If bIgnoreListe = False Then

                    'Komplette E-Mail Adresse in Domäne
                    If bIgnoreListeKomplett = True Then

                        'Suche nach Ordner anhand der E-Mail Adresse
                        If _GetMailInfo(_MailInfos.Unread) = False Then
                            frmHaupt.cConfig.GetDomain(frmHaupt.cConfig.SearchDomain(strAdresse), _
                                                  Nothing, _
                                                  Nothing, _
                                                  _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), i), _
                                                  _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerEID), i), _
                                                  _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerSID), i))
                        Else
                            frmHaupt.cConfig.AddUnreadMail(strAdresse, _GetMailInfo(_MailInfos.EntryID))

                            _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cEA), i) = _Konstante.U.ToString

                            _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), i) = "--- " + _Konstante.UNGELESEN.ToString + " ---"
                        End If


                    Else 'Suche nach Ordner anhand der Domäne

                        If _GetMailInfo(_MailInfos.Unread) = False Then
                            frmHaupt.cConfig.GetDomain(frmHaupt.cConfig.SearchDomain("@" & strDomain), _
                                                   Nothing, _
                                                   Nothing, _
                                                   _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), i), _
                                                   _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerEID), i), _
                                                   _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerSID), i))
                        Else
                            frmHaupt.cConfig.AddUnreadMail("@" & strDomain, _GetMailInfo(_MailInfos.EntryID))

                            _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cEA), i) = _Konstante.U.ToString

                            _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), i) = "--- " + _Konstante.UNGELESEN.ToString + " ---"
                        End If

                    End If

                Else 'Eintrag ist in IgnoreList
                    _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), i) = "--- " + _Konstante.IGNORE.ToString + " ---"

                End If

                'Nächste Mail laden
                frmHaupt.cOutlook.oMail = frmHaupt.cOutlook.GetNextMail
                i += 1

            Loop

        Next

        'Button Enablen
        btnKopieren.Enabled = True

        Cursor.Current = Cursors.Default

    End Sub

    Private Sub GetDomainFromLDAP(ByRef Adresse As String, ByRef Domain As String)
        'Korrekte Adresse Ermitteln
        If Not Adresse = Nothing Then
            If Not Adresse.ToUpper.IndexOf("/O=RSC") = -1 Then
                'Wenn LDAP verfügbar
                If frmHaupt.cLDAP.Status = True Then
                    'Umschlüsselung X400 über LDAP
                    Adresse = frmHaupt.cLDAP.SearchLDAPEMail(Adresse)

                End If
            End If

            'Domäne aus Adresse ermtteln
            If Not Adresse.IndexOf("@") - 1 Then
                Domain = Adresse.Split("@")(1).ToString

            Else
                'Wenn LDAP nicht verfügbar mit X400 Adresse weiterarbeiten
                Domain = Adresse

            End If

        End If

    End Sub

    Private Sub GetIgnoreList(ByRef IgnoreListe As Boolean, ByRef IgnoreListeKomplett As Boolean, ByVal Adresse As String, ByVal Domain As String)
        'Adresse ist leer daher ignorieren
        If Adresse = "???" Then
            IgnoreListe = True
            Exit Sub
        End If

        'IgnoreList nach Domäne durchsuchen
        If Not frmHaupt.cConfig.SearchIgnoreList("@" & Domain) = -1 Then
            'Domäne in IgnoreList gefunden (bIgnore wird Temporär auf True gesetzt)
            IgnoreListe = True

            'Durchsuche ob für die Komplette E-Mail Adresse ein Eintrag in den Domänen vorhanden ist
            If Not frmHaupt.cConfig.SearchDomain(Adresse) = -1 Then
                IgnoreListe = False
                IgnoreListeKomplett = True

            End If

        Else 'Domäne nicht in IgnoreList gefunden (Suche nach kompletter Adresse)
            If Not frmHaupt.cConfig.SearchIgnoreList(Adresse) = -1 Then
                IgnoreListe = True

            End If

        End If
    End Sub

    Private Sub dgMails_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMails.CellDoubleClick
        'Temp-String deklarieren
        Dim strTemp As String = ""

        'Doppelklick auf Spalte 1 (MSGBOX)
        If _dgSelectedColumn = 1 Then
            MsgBox(_dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMail), _dgSelected), _
                   MsgBoxStyle.OkOnly, _
                   _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMailAdr), _dgSelected))

        ElseIf _dgSelectedColumn = 3 Then 'Doppelklick auf Spalte Ordner (Ordner Auswahl)
            'String merken (falls ---IGNORE---)
            strTemp = _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), _dgSelected)

            'Ordnerauswahl anzeigen
            frmHaupt.cOutlook.FolderSelection(_dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), _dgSelected), _
                                              _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerEID), _dgSelected), _
                                              _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerSID), _dgSelected))

            'Wenn Ordner ausgewählt wurde
            If Not _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), _dgSelected) = Nothing Then

                'Wenn nicht IgnoreListe vorhanden
                If Not strTemp = "--- " + _Konstante.IGNORE.ToString + " ---" Then

                    'E-Mail Adresse enthält ein @ Zeichen
                    If Not _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMailAdr), _dgSelected) = Nothing Then

                        If Not _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMailAdr), _dgSelected).ToString.IndexOf("@") = -1 Then
                            frmHaupt.cConfig.AddDomain("@" + _
                                                       _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMailAdr), _dgSelected).ToString.Split("@")(1).ToString, _
                                                       _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), _dgSelected).ToString.Split(" - ")(0).ToString, _
                                                       _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), _dgSelected), _
                                                       _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerEID), _dgSelected), _
                                                       _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerSID), _dgSelected))

                        Else 'E-Mail Adresse enhält kein @ Zeichen (X400 Adresse)
                            frmHaupt.cConfig.AddDomain("@" + _
                                                       _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMailAdr), _dgSelected).ToString, _
                                                       _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), _dgSelected).ToString.Split(" - ")(0).ToString, _
                                                       _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), _dgSelected), _
                                                       _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerEID), _dgSelected), _
                                                       _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerSID), _dgSelected))

                        End If
                    End If

                Else 'Domäne ist auf IgnoreList (Eintragen der kompletten E-Mail Adresse)
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

        'Alle E-Mail kopieren/verschieben
        Do While dgMails.Rows.Count > 0
            'E-Mail ist zum kopieren/verschieben markiert
            If _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cKopieren), i) = True Then
                frmHaupt.cOutlook.CopyMail(_dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMailEID), i), _
                                           _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerEID), i), _
                                           _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdnerSID), i), _
                                           frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Mail_KopierenVerschieben))

                If _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cEA), i) = "U" _
                    And Not _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cOrdner), i) = "--- " + _Konstante.UNGELESEN.ToString + " ---" Then
                    'Ungelesenen Nachricht kann aus Liste entfernt werden
                    frmHaupt.cConfig.RemoveUnreadMails(-1, _dgItem(_GetdgColumnNameByEnum(_dgMailColumns.cMailEID), i))
                End If
            End If

            'Zeile aus Datagrid entfernen
            dgMails.Rows.Remove(dgMails.Rows(i))
            Me.Refresh()

        Loop

        'Schreiben des Zeitpunkt Letzer Lauf (Datum/Uhrzeit des Programmstart)
        frmHaupt.cConfig.SetSettings(clsConfig.ESettings.LetzerLauf_Datum, frmHaupt.strDate)
        frmHaupt.cConfig.SetSettings(clsConfig.ESettings.LetzerLauf_Zeit, frmHaupt.strTime)
        frmHaupt.cConfig.WriteConfigSettings()
        frmHaupt.cConfig.WriteConfigUnreadMails()

        Cursor.Current = Cursors.Default
    End Sub

#End Region

End Class
