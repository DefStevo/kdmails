﻿Imports KdMails.net.clsOutlook
Imports KdMails.net.clsDatenbank
Imports KdMails.net.clsConfig

Public Class frmHaupt
#Region "Deklarationen"
    Public Shared cOutlook As New clsOutlook
    Public cDatenbank As New clsDatenbank
    Public cConfig As New clsConfig
#End Region

#Region "Subs"
    Private Sub frmHaupt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        cConfig.InitConfig(True, True)

        stStatus.Text = "Outlook wird Initialisiert"
        Me.Refresh()
        cOutlook.InitOutlook()

        stStatus.Text = "Verbindung zur Datenbank wird hergestellt"
        Me.Refresh()
        cDatenbank.SetConnectionInfo(My.Settings.strServer, My.Settings.strDatenbank, My.Settings.strBenutzer, My.Settings.strKennwort)
        cDatenbank.ConnectDB()
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
