#Region "Imports"
Imports System.Data.OleDb

#End Region

Public Class frmOptionen
#Region "Deklarationen"

    Private _strTemp As String = ""

    Private _iWidthNormal As Integer = 309
    Private _iWidthDebug As Integer = 844

    Private _strSQL As String = "Select I.INTADR_FELD02 KUNDE, SUBSTR(T.TEL_RUFNR, INSTR(T.TEL_RUFNR,'@')) MAIL" & vbNewLine & _
                               "from S_INTADR I, S_ANSP P, S_TEL T" & vbNewLine & _
                               "where(I.FIRM_NR = P.FIRM_NR)" & vbNewLine & _
                               "and I.INTADR_NR=P.INTADR_NR" & vbNewLine & _
                               "and NOT I.INTADR_FELD02='RS'" & vbNewLine & _
                               "and P.FIRM_NR=T.FIRM_NR" & vbNewLine & _
                               "and P.INTADR_NR=T.INTADR_NR" & vbNewLine & _
                               "and P.ANSP_NR=T.ANSP_NR" & vbNewLine & _
                               "and P.ANSP_STATUS=0" & vbNewLine & _
                               "and T.TEL_CODE like 'E-MAIL%'" & vbNewLine & _
                               "and NOT I.INTADR_FELD02 IS NULL" & vbNewLine & _
                               "group by I.INTADR_FELD02, SUBSTR(T.TEL_RUFNR, INSTR(T.TEL_RUFNR,'@'))" & vbNewLine & _
                               "order by 1,2"

#End Region

#Region "Sub"
    Private Sub frmMails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Width = _iWidthDebug

        btnDebug_Click(sender, e)

        'Einstellungen einlesen
        txtServer.Text = frmHaupt.cConfig.GetSettings(clsConfig.ESettings.DB_Server)
        txtDatenbank.Text = frmHaupt.cConfig.GetSettings(clsConfig.ESettings.DB_Datenbank)
        txtBenutzer.Text = frmHaupt.cConfig.GetSettings(clsConfig.ESettings.DB_Benutzer)
        txtKennwort.Text = frmHaupt.cConfig.GetSettings(clsConfig.ESettings.DB_Kennwort)

        txtOrdnerEingang.Text = frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Ordner_Eingang, 1)
        txtOrdnerEingangEID.Text = frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Ordner_Eingang, 2)
        txtOrdnerEingangSID.Text = frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Ordner_Eingang, 3)

        txtOrdnerAusgang.Text = frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Ordner_Gesendet, 1)
        txtOrdnerAusgangEID.Text = frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Ordner_Gesendet, 2)
        txtOrdnerAusgangSID.Text = frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Ordner_Gesendet, 3)

        txtOrdnerZiel.Text = frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Ordner_Ziel, 1)
        txtOrdnerZielEID.Text = frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Ordner_Ziel, 2)
        txtOrdnerZielSID.Text = frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Ordner_Ziel, 3)

        If frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Mail_KopierenVerschieben) = 0 Then
            optKopieren.Checked = True
        ElseIf frmHaupt.cConfig.GetSettings(clsConfig.ESettings.Mail_KopierenVerschieben) = 1 Then
            optVerschieben.Checked = True
        End If

        btnMailDom.Enabled = frmHaupt.cDatenbank.Status

        dgIgnoreList.AllowUserToAddRows = False

        FillDGFolder()
        FillDGDomain()
        FillDgIgnoreList()

        dgIgnoreList.AllowUserToAddRows = True
    End Sub

#End Region

#Region "Funktionen"
    Private Function FillDGFolder() As Boolean
        'DataGrid Ordner leeren
        Do While dgOrdner.Rows.Count > 0
            dgOrdner.Rows.Remove(dgOrdner.Rows(0))
        Loop

        For i As Integer = 0 To frmHaupt.cConfig.oOrdnerL.Count - 1
            dgOrdner.Rows.Add()
            frmHaupt.cConfig.GetFolder(i, dgOrdner.Rows(i).Cells("cOrdnerName").Value, dgOrdner.Rows(i).Cells("cOrdnerEID").Value, dgOrdner.Rows(i).Cells("cOrdnerSID").Value)
        Next i
    End Function

    Private Function FillDGDomain() As Boolean
        'DataGrid Domänen leeren
        Do While dgDomain.Rows.Count > 0
            dgDomain.Rows.Remove(dgDomain.Rows(0))
        Loop

        For i As Integer = 0 To frmHaupt.cConfig.oDomänenL.Count - 1
            dgDomain.Rows.Add()
            frmHaupt.cConfig.GetDomain(i, dgDomain.Rows(i).Cells("cDomäne").Value, dgDomain.Rows(i).Cells("cKunde").Value, dgDomain.Rows(i).Cells("cOutlookOrdner").Value, dgDomain.Rows(i).Cells("cOutlookEID").Value, dgDomain.Rows(i).Cells("cOutlookSID").Value)
        Next
    End Function

    Private Function FillDGIgnoreList() As Boolean
        'DataGrid IgnoreList leeren
        Do While dgIgnoreList.Rows.Count > 0
            dgIgnoreList.Rows.Remove(dgIgnoreList.Rows(0))
        Loop

        For i As Integer = 0 To frmHaupt.cConfig.oIgnoreL.Count - 1
            dgIgnoreList.Rows.Add()
            frmHaupt.cConfig.GetIgnoreList(i, dgIgnoreList.Rows(i).Cells("cIgnoreDomäne").Value)
        Next
    End Function

    Private Function AddDGToIgnoreList() As Boolean

        For i As Integer = 0 To frmHaupt.cConfig.oIgnoreL.Count - 1
            frmHaupt.cConfig.RemoveIgnoreList(0)
        Next

        For i As Integer = 0 To dgIgnoreList.Rows.Count - 1
            frmHaupt.cConfig.AddIgnoreList(dgIgnoreList.Rows(i).Cells("cIgnoreDomäne").Value)
        Next
    End Function

#End Region

#Region "Buttons"
#Region "Standard"
    Private Sub btnSpeichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpeichern.Click
        'Einstellungen Speichern
        frmHaupt.cConfig.SetSettings(clsConfig.ESettings.DB_Server, txtServer.Text)
        frmHaupt.cConfig.SetSettings(clsConfig.ESettings.DB_Datenbank, txtDatenbank.Text)
        frmHaupt.cConfig.SetSettings(clsConfig.ESettings.DB_Benutzer, txtBenutzer.Text)
        frmHaupt.cConfig.SetSettings(clsConfig.ESettings.DB_Kennwort, txtKennwort.Text)
        frmHaupt.cConfig.SetSettings(clsConfig.ESettings.Ordner_Eingang, txtOrdnerEingang.Text, txtOrdnerEingangEID.Text, txtOrdnerEingangSID.Text)
        frmHaupt.cConfig.SetSettings(clsConfig.ESettings.Ordner_Gesendet, txtOrdnerAusgang.Text, txtOrdnerAusgangEID.Text, txtOrdnerAusgangSID.Text)
        frmHaupt.cConfig.SetSettings(clsConfig.ESettings.Ordner_Ziel, txtOrdnerZiel.Text, txtOrdnerZielEID.Text, txtOrdnerZielSID.Text)
        If optKopieren.Checked = True Then
            frmHaupt.cConfig.SetSettings(clsConfig.ESettings.Mail_KopierenVerschieben, 0)
        ElseIf optVerschieben.Checked = True Then
            frmHaupt.cConfig.SetSettings(clsConfig.ESettings.Mail_KopierenVerschieben, 1)
        End If

        AddDGToIgnoreList()

        frmHaupt.cConfig.WriteConfigIgnore()
        frmHaupt.cConfig.WriteConfigDomain()
        frmHaupt.cConfig.WriteConfigFolder()
        frmHaupt.cConfig.WriteConfigSettings()
    End Sub

    Private Sub btnAbbrechen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbbrechen.Click
        Me.Close()
    End Sub

    Private Sub btnDebug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDebug.Click
        If Me.Width = _iWidthNormal Then
            Me.Width = _iWidthDebug
            dgDomain.Visible = True
            dgOrdner.Visible = True
            btnMarkMails.Enabled = True
        Else
            Me.Width = _iWidthNormal
            dgDomain.Visible = False
            dgOrdner.Visible = False
            btnMarkMails.Enabled = False
        End If

    End Sub

#End Region

#Region "Outlook-Ordner"
    Private Sub btnOrdnerEingang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdnerEingang.Click
        'Outlook Ordner auswählen
        frmHaupt.cOutlook.FolderSelection(txtOrdnerEingang.Text, _
                                          txtOrdnerEingangEID.Text, _
                                          txtOrdnerEingangSID.Text)
    End Sub

    Private Sub btnOrdnerAusgang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdnerAusgang.Click
        'Outlook Ordner auswählen
        frmHaupt.cOutlook.FolderSelection(txtOrdnerAusgang.Text, _
                                          txtOrdnerAusgangEID.Text, _
                                          txtOrdnerAusgangSID.Text)

    End Sub

    Private Sub btnOrdnerZiel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdnerZiel.Click
        'Outlook Ordner auswählen
        frmHaupt.cOutlook.FolderSelection(txtOrdnerZiel.Text, _
                                          txtOrdnerZielEID.Text, _
                                          txtOrdnerZielSID.Text)

    End Sub

#End Region

#Region "Funtkionen"
    Private Sub btnOrdnerDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdnerDB.Click
        Cursor.Current = Cursors.WaitCursor

        If Not txtOrdnerZielEID.Text = "00" Then

            frmHaupt.cOutlook.oOrdner = frmHaupt.cOutlook.GetFolders(txtOrdnerZielEID.Text, txtOrdnerZielSID.Text)

            Do While Not frmHaupt.cOutlook.oOrdner Is Nothing
                frmHaupt.cConfig.AddFolder(frmHaupt.cOutlook.oOrdner.Name, frmHaupt.cOutlook.oOrdner.EntryID, frmHaupt.cOutlook.oOrdner.StoreID)
                frmHaupt.cConfig.AddFolderToDomain(frmHaupt.cOutlook.oOrdner.Name, frmHaupt.cOutlook.oOrdner.EntryID, frmHaupt.cOutlook.oOrdner.StoreID)
                frmHaupt.cOutlook.oOrdner = frmHaupt.cOutlook.GetNextFolder
            Loop

            FillDGDomain()
            FillDGFolder()

        End If

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnMailDom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMailDom.Click

        Cursor.Current = Cursors.WaitCursor

        frmHaupt.cDatenbank.oReader = frmHaupt.cDatenbank.OpenRS(_strSQL)

        If Not frmHaupt.cDatenbank.oReader Is Nothing Then


            While frmHaupt.cDatenbank.oReader.Read
                frmHaupt.cConfig.AddDomain(frmHaupt.cDatenbank.oReader.GetValue(1).ToString, frmHaupt.cDatenbank.oReader.GetValue(0).ToString, Nothing, Nothing, Nothing)

            End While

            FillDGDomain()
        End If

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnMarkMails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkMails.Click
        Cursor.Current = Cursors.WaitCursor
        frmHaupt.cOutlook.ResetAllMails(txtOrdnerZielEID.Text, txtOrdnerZielSID.Text)
        Cursor.Current = Cursors.Default
    End Sub

#End Region

#End Region

#Region "DebugMode"

    Private Sub dgDomain_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDomain.CellDoubleClick
        MsgBox("Inhalt des Feldes: " & vbNewLine & dgDomain.SelectedCells.Item(0).Value & vbNewLine & vbNewLine & _
               "Inhalt der Zeile:" & vbNewLine & _
               "   Domäne: " & dgDomain.Rows(dgDomain.SelectedCells.Item(0).RowIndex).Cells("cDomäne").Value & vbNewLine & _
               "   Kunden: " & dgDomain.Rows(dgDomain.SelectedCells.Item(0).RowIndex).Cells("cKunde").Value & vbNewLine & _
               "   Ordern: " & dgDomain.Rows(dgDomain.SelectedCells.Item(0).RowIndex).Cells("cOutlookOrdner").Value & vbNewLine & _
               "   EID: " & dgDomain.Rows(dgDomain.SelectedCells.Item(0).RowIndex).Cells("cOutlookEID").Value & vbNewLine & _
               "   SID wird nur bei Doppelklick auf die Spalte angezeigt", MsgBoxStyle.Information, "KdMails.net - Domänen")
    End Sub

    Private Sub dgOrdner_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgOrdner.CellDoubleClick
        MsgBox("Inhalt des Feldes: " & vbNewLine & dgOrdner.SelectedCells.Item(0).Value & vbNewLine & vbNewLine & _
               "Inhalt der Zeile:" & vbNewLine & _
               "   Name: " & dgOrdner.Rows(dgOrdner.SelectedCells.Item(0).RowIndex).Cells("cOrdnerName").Value & vbNewLine & _
               "   EID: " & dgOrdner.Rows(dgOrdner.SelectedCells.Item(0).RowIndex).Cells("cOrdnerEID").Value & vbNewLine & _
               "   SID wird nur bei Doppelklick auf die Spalte angezeigt", MsgBoxStyle.Information, "KdMails.net - Ordner")
    End Sub

#End Region

End Class
