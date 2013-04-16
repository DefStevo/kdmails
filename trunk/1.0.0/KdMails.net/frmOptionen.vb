#Region "Imports"
Imports System.Data.OleDb

#End Region

Public Class frmOptionen
#Region "Deklarationen"
    Private strSQL As String = "Select I.INTADR_FELD02 KUNDE, SUBSTR(T.TEL_RUFNR, INSTR(T.TEL_RUFNR,'@')) MAIL" & vbNewLine & _
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

    Private FileOrdner As String = My.Application.Info.DirectoryPath & "\KdMails.Ordner.cfg"
    Private FileMail As String = My.Application.Info.DirectoryPath & "\KdMails.Mails.cfg"

#End Region

#Region "Sub"
    Private Sub frmMails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Width = 391

        'Einstellungen einlesen
        txtServer.Text = My.Settings.strServer
        txtDatenbank.Text = My.Settings.strDatenbank
        txtBenutzer.Text = My.Settings.strBenutzer
        txtKennwort.Text = My.Settings.strKennwort
        txtOrdner.Text = My.Settings.strOrdner.Split(";")(0).ToString
        txtOrdnerEID.Text = My.Settings.strOrdner.Split(";")(1).ToString
        txtOrdnerSID.Text = My.Settings.strOrdner.Split(";")(2).ToString
        txtOrdnerÜberwachung.Text = My.Settings.strOrdnerÜberwachung.Split(";")(0).ToString
        txtOrdnerÜberwachungEID.Text = My.Settings.strOrdnerÜberwachung.Split(";")(1).ToString
        txtOrdnerÜberwachungSID.Text = My.Settings.strOrdnerÜberwachung.Split(";")(2).ToString

        If My.Settings.nOptionKopierenVerschieben = 0 Then
            optKopieren.Checked = True
        ElseIf My.Settings.nOptionKopierenVerschieben = 1 Then
            optVerschieben.Checked = True
        End If

        FillDGFolder()
        FillDGDomain()

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

#End Region

#Region "Buttons"
#Region "Standard"
    Private Sub btnSpeichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpeichern.Click
        'Einstellungen Speichern
        My.Settings.strServer = txtServer.Text
        My.Settings.strDatenbank = txtDatenbank.Text
        My.Settings.strBenutzer = txtBenutzer.Text
        My.Settings.strKennwort = txtKennwort.Text
        My.Settings.strOrdner = txtOrdner.Text & ";" & txtOrdnerEID.Text & ";" & txtOrdnerSID.Text
        My.Settings.strOrdnerÜberwachung = txtOrdnerÜberwachung.Text & ";" & txtOrdnerÜberwachungEID.Text & ";" & txtOrdnerÜberwachungSID.Text
        If optKopieren.Checked = True Then
            My.Settings.nOptionKopierenVerschieben = 0
        ElseIf optVerschieben.Checked = True Then
            My.Settings.nOptionKopierenVerschieben = 1
        End If
        My.Settings.Save()

        frmHaupt.cConfig.WriteConfigDomain()
        frmHaupt.cConfig.WriteConfigFolder()
    End Sub

    Private Sub btnAbbrechen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbbrechen.Click
        Me.Close()
    End Sub

    Private Sub btnDebug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDebug.Click
        Me.Width = 953
        dgDomain.Visible = True
        dgOrdner.Visible = True
        btnMarkMails.Enabled = True
    End Sub

#End Region

#Region "Outlook-Ordner"
    Private Sub btnOrdner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdner.Click
        'Outlook Ordner auswählen
        frmHaupt.cOutlook.FolderSelection(txtOrdner.Text, _
                                          txtOrdnerEID.Text, _
                                          txtOrdnerSID.Text)

    End Sub

    Private Sub btnOrdnerÜberwachung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdnerÜberwachung.Click
        'Outlook Ordner auswählen
        frmHaupt.cOutlook.FolderSelection(txtOrdnerÜberwachung.Text, _
                                          txtOrdnerÜberwachungEID.Text, _
                                          txtOrdnerÜberwachungSID.Text)

    End Sub

#End Region

#Region "Funtkionen"
    Private Sub btnOrdnerDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdnerDB.Click
        Cursor.Current = Cursors.WaitCursor

        If Not txtOrdnerEID.Text = "00" Then

            frmHaupt.cOutlook.oOrdner = frmHaupt.cOutlook.GetFolders(txtOrdnerEID.Text, txtOrdnerSID.Text)

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

        frmHaupt.cDatenbank.oReader = frmHaupt.cDatenbank.OpenRS(strSQL)

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
        frmHaupt.cOutlook.ResetAllMails(txtOrdnerÜberwachungEID.Text, txtOrdnerÜberwachungSID.Text)
        Cursor.Current = Cursors.Default
    End Sub

#End Region

#End Region
End Class
