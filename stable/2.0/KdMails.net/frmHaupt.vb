Imports KdMails.net.clsOutlook
Imports KdMails.net.clsDatenbank
Imports KdMails.net.clsConfig

Public Class frmHaupt
#Region "Deklarationen"
    Public Shared cOutlook As New clsOutlook
    Public Shared cDatenbank As New clsDatenbank
    Public Shared cConfig As New clsConfig

    Public strDate As String = Format(Now, "dd.MM.yyyy")
    Public strTime As String = Format(Now, "HH:mm")
#End Region

#Region "Subs"
    Private Sub frmHaupt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & _
                  " (v. " & _
                  My.Application.Info.Version.Major.ToString & "." & _
                  My.Application.Info.Version.Minor.ToString & "." & _
                  My.Application.Info.Version.Build.ToString & ")"

        Timer1.Interval = 1
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False

        Cursor.Current = Cursors.WaitCursor
        Me.Focus()
        Me.Refresh()
        stStatus.Text = "Einstellungen werden gelesen"
        Me.Refresh()

        My.Settings.Upgrade()
        cConfig.InitConfig(True, True, True, True)

        stStatus.Text = "Outlook wird Initialisiert"
        Me.Refresh()
        cOutlook.InitOutlook()

        stStatus.Text = "Verbindung zur Datenbank wird hergestellt"
        Me.Refresh()
        cDatenbank.SetConnectionInfo(cConfig.GetSettings(ESettings.DB_Server), _
                                     cConfig.GetSettings(ESettings.DB_Datenbank), _
                                     cConfig.GetSettings(ESettings.DB_Benutzer), _
                                     cConfig.GetSettings(ESettings.DB_Kennwort))

        stStatus.Text = cDatenbank.ConnectDB()
        btnLos.Enabled = True
        btnOptionen.Enabled = True
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub frmHaupt_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        cOutlook.UnloadOutlook()
        cDatenbank.DisconnectDB()
        cConfig.WriteConfigFolder()
        cConfig.WriteConfigDomain()
        cConfig.UnloadConfig()
        Application.Exit()
    End Sub
#End Region

#Region "Buttons"
    Private Sub btnVerschieben_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLos.Click
        frmMails.ShowDialog()
    End Sub

    Private Sub btnOptionen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptionen.Click
        frmOptionen.ShowDialog()
    End Sub

#End Region


End Class
