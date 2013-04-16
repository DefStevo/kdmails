Imports Microsoft.Office.Interop



Public Class frmMails


#Region "Subs"
    Private Sub frmMails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        Dim sDomain As String

        Do While dgMails.Rows.Count > 0
            dgMails.Rows.Remove(dgMails.Rows(0))
        Loop

        If My.Settings.nOptionKopierenVerschieben = 0 Then
            dgMails.Columns("cCopy").HeaderText = "Kopieren"
            btnKopieren.Text = "Kopieren"
        ElseIf My.Settings.nOptionKopierenVerschieben = 1 Then
            dgMails.Columns("cCopy").HeaderText = "Verschieben"
            btnKopieren.Text = "Verschieben"
        End If

        frmHaupt.cOutlook.oMail = frmHaupt.cOutlook.GetMails(My.Settings.strOrdnerÜberwachung.Split(";")(1).ToString(), My.Settings.strOrdnerÜberwachung.Split(";")(2).ToString)

        Do While Not frmHaupt.cOutlook.oMail Is Nothing
            dgMails.Rows.Add()
            dgMails.Rows(i).Cells("cMail").Value = frmHaupt.cOutlook.oMail.To & vbNewLine & frmHaupt.cOutlook.oMail.ReceivedTime.ToString & vbNewLine & frmHaupt.cOutlook.oMail.Subject
            dgMails.Rows(i).Cells("cMailEID").Value = frmHaupt.cOutlook.oMail.EntryID

            dgMails.Rows(i).Cells("cMailAdress").Value = frmHaupt.cOutlook.oMail.Recipients(1).Address

            If Not frmHaupt.cOutlook.oMail.Recipients(1).Address.IndexOf("@") = -1 Then
                sDomain = frmHaupt.cOutlook.oMail.Recipients(1).Address.Split("@")(1).ToString
            Else
                sDomain = frmHaupt.cOutlook.oMail.Recipients(1).Address.ToString
            End If

            frmHaupt.cConfig.GetDomain(frmHaupt.cConfig.SearchDomain("@" & sDomain), _
                                       Nothing, _
                                       Nothing, _
                                       dgMails.Rows(i).Cells("cOrdner").Value, _
                                       dgMails.Rows(i).Cells("cOrdnerEID").Value, _
                                       dgMails.Rows(i).Cells("cOrdnerSID").Value)

            'If Not dgMails.Rows(i).Cells("cOrdner").Value = Nothing Then
            dgMails.Rows(i).Cells("cCopy").Value = True
            'End If

            frmHaupt.cOutlook.oMail = frmHaupt.cOutlook.GetNextMail
            i = i + 1

            btnKopieren.Enabled = True
        Loop

    End Sub

    Private Sub dgMails_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMails.CellDoubleClick
        If dgMails.SelectedCells.Item(0).ColumnIndex = 2 Then
            frmHaupt.cOutlook.FolderSelection(dgMails.Item("cOrdner", dgMails.SelectedCells.Item(0).RowIndex).Value, _
                                              dgMails.Item("cOrdnerEID", dgMails.SelectedCells.Item(0).RowIndex).Value, _
                                              dgMails.Item("cOrdnerSID", dgMails.SelectedCells.Item(0).RowIndex).Value)
            dgMails.Item("cCopy", dgMails.SelectedCells.Item(0).RowIndex).Value = True

            If Not dgMails.Item("cMailAdress", dgMails.SelectedCells.Item(0).RowIndex).Value.ToString.IndexOf("@") = -1 Then
                frmHaupt.cConfig.AddDomain("@" + dgMails.Item("cMailAdress", dgMails.SelectedCells.Item(0).RowIndex).Value.ToString.Split("@")(1).ToString, _
                                       dgMails.Item("cOrdner", dgMails.SelectedCells.Item(0).RowIndex).Value.ToString.Split(" - ")(0).ToString, _
                                       dgMails.Item("cOrdner", dgMails.SelectedCells.Item(0).RowIndex).Value, _
                                       dgMails.Item("cOrdnerEID", dgMails.SelectedCells.Item(0).RowIndex).Value, _
                                       dgMails.Item("cOrdnerSID", dgMails.SelectedCells.Item(0).RowIndex).Value)
            Else
                frmHaupt.cConfig.AddDomain("@" + dgMails.Item("cMailAdress", dgMails.SelectedCells.Item(0).RowIndex).Value.ToString, _
                                       dgMails.Item("cOrdner", dgMails.SelectedCells.Item(0).RowIndex).Value.ToString.Split(" - ")(0).ToString, _
                                       dgMails.Item("cOrdner", dgMails.SelectedCells.Item(0).RowIndex).Value, _
                                       dgMails.Item("cOrdnerEID", dgMails.SelectedCells.Item(0).RowIndex).Value, _
                                       dgMails.Item("cOrdnerSID", dgMails.SelectedCells.Item(0).RowIndex).Value)
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

        Do While i <= dgMails.Rows.Count - 1
            If dgMails.Rows(i).Cells("cCopy").Value = True Then
                frmHaupt.cOutlook.CopyMail(dgMails.Rows(i).Cells("cMailEID").Value, dgMails.Rows(i).Cells("cOrdnerEID").Value, dgMails.Rows(i).Cells("cOrdnerSID").Value, My.Settings.nOptionKopierenVerschieben)
                dgMails.Rows.Remove(dgMails.Rows(i))
                i = i - 1
            End If
            i = i + 1
        Loop

        Cursor.Current = Cursors.Default
    End Sub

#End Region

    Private Sub dgMails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMails.CellContentClick

    End Sub
End Class
