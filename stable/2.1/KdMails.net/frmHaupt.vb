#Region "Imports"
Imports KdMails.net.clsOutlook
Imports KdMails.net.clsDatenbank
Imports KdMails.net.clsConfig
Imports KdMails.net.clsLDAP

#End Region

Public Class frmHaupt

#Region "Deklarationen"
    Public Shared cOutlook As New clsOutlook
    Public Shared cDatenbank As New clsDatenbank
    Public Shared cConfig As New clsConfig
    Public Shared cLDAP As New clsLDAP

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

        'Einstellung lesen (Settings, IgnoreList, Domänen, Ordner)
        My.Settings.Upgrade()
        cConfig.InitConfig(True, True, True, True)

        InitOutlook()

        InitLDAP()

        InitDB()

        'Status anzeigen
        stStatus.Text = "|Letzer Lauf: " + cConfig.GetSettings(ESettings.LetzerLauf_Datum) + " " + cConfig.GetSettings(ESettings.LetzerLauf_Zeit)

        'Fertig (Fenster freigeben)
        btnLos.Enabled = True
        btnOptionen.Enabled = True
        Cursor.Current = Cursors.Default
    End Sub

    Sub InitOutlook()
        'Outlook Initialisieren
        stOutlook.Image = My.Resources.Status_CO
        Me.Refresh()
        cOutlook.InitOutlook()
        If cOutlook.Status = True Then
            stOutlook.Image = My.Resources.Status_OK
        Else
            stOutlook.Image = My.Resources.Status_NA
        End If
        Me.Refresh()
    End Sub

    Sub InitLDAP()
        'Verbindung zu LDAP herstellen
        If Not cConfig.GetSettings(ESettings.LDAP_Domain) = Nothing Then
            stLDAP.Image = My.Resources.Status_CO
            Me.Refresh()

            cLDAP.InitLDAP(cConfig.GetSettings(ESettings.LDAP_Domain))

            If cLDAP.Status = True Then
                stLDAP.Image = My.Resources.Status_OK
            Else
                stLDAP.Image = My.Resources.Status_NA()
            End If

            Me.Refresh()
        End If
    End Sub

    Sub InitDB()
        'Verbindung zu Datenbank herstellen
        stDB.Image = My.Resources.Status_CO
        Me.Refresh()
        cDatenbank.SetConnectionInfo(cConfig.GetSettings(ESettings.DB_Server), _
                                     cConfig.GetSettings(ESettings.DB_Datenbank), _
                                     cConfig.GetSettings(ESettings.DB_Benutzer), _
                                     cConfig.GetSettings(ESettings.DB_Kennwort))
        cDatenbank.ConnectDB()

        If cDatenbank.Status = True Then
            stDB.Image = My.Resources.Status_OK
        Else
            stDB.Image = My.Resources.Status_NA
        End If
        Me.Refresh()
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

        Cursor.Current = Cursors.WaitCursor
        If Not cConfig.GetSettings(ESettings.LDAP_Domain) = cLDAP.Domäne Then
            InitLDAP()
        End If

        If cConfig.GetSettings(ESettings.DB_Server) <> cDatenbank.Server Or _
        cConfig.GetSettings(ESettings.DB_Datenbank) <> cDatenbank.DB Or _
        cConfig.GetSettings(ESettings.DB_Benutzer) <> cDatenbank.User Or _
        cConfig.GetSettings(ESettings.DB_Kennwort) <> cDatenbank.Pass Then
            InitDB()
        End If
        Cursor.Current = Cursors.Default

    End Sub

#End Region

End Class
