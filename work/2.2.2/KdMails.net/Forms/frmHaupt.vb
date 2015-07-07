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
    Public Shared cLogging As New clsLogging
    Public Shared cLoggingRead As New clsLogging

    Public Shared sHDRLog As New clsLogging.sLogHDRInfos

    Public strDate As String = Format(Now, "dd.MM.yyyy")
    Public strTime As String = Format(Now, "HH:mm")
    Public strLogFile As String = Format(Now, "yyyyMMdd_HHmmss") & ".log"

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
        'Fenster im Batchmodus nicht anzeigen
        If mdlHaupt._Batch Then
            Me.Visible = False
        End If

        Timer1.Enabled = False

        Cursor.Current = Cursors.WaitCursor
        Me.Focus()

        'Standardwerte für Logging setzen
        sHDRLog.SetInfo(clsLogging.ELogHDRInfos.Anzahl_Ungelesen, "0")
        sHDRLog.SetInfo(clsLogging.ELogHDRInfos.Anzahl_Ungelesen_Neu, "0")
        sHDRLog.SetInfo(clsLogging.ELogHDRInfos.Anzahl_Posteingang, "0")
        sHDRLog.SetInfo(clsLogging.ELogHDRInfos.Anzahl_Postausgang, "0")
        sHDRLog.SetInfo(clsLogging.ELogHDRInfos.Letzter_Lauf, "Kein Lauf durchgeführt")
        sHDRLog.SetInfo(clsLogging.ELogHDRInfos.Aktueller_Lauf, "Kein Lauf durchgeführt")
        sHDRLog.SetInfo(clsLogging.ELogHDRInfos.Version, _
                  My.Application.Info.Version.Major.ToString & "." & _
                  My.Application.Info.Version.Minor.ToString & "." & _
                  My.Application.Info.Version.Build.ToString)

        'Einstellung lesen (Settings, IgnoreList, Domänen, Ordner)
        My.Settings.Upgrade()
        cConfig.InitConfig(True, True, True, True, True)

        InitLog()

        InitOutlook()

        InitLDAP()

        InitDB()

        'Status anzeigen
        stStatus.Text = "|Letzer Lauf: " + cConfig.GetSettings(ESettings.LetzerLauf_Datum) + " " + cConfig.GetSettings(ESettings.LetzerLauf_Zeit)

        sHDRLog.SetInfo(clsLogging.ELogHDRInfos.Letzter_Lauf, cConfig.GetSettings(ESettings.LetzerLauf_Datum) + " " + cConfig.GetSettings(ESettings.LetzerLauf_Zeit))

        'Fertig (Fenster freigeben)
        btnLos.Enabled = True
        btnOptionen.Enabled = True
        btnProtokoll.Enabled = True
        Cursor.Current = Cursors.Default

        If mdlHaupt._Batch Then
            btnVerschieben_Click(sender, e)
            Me.Close()
        End If
    End Sub

    Sub InitLog()
        'Logging Initialisieren
        cLogging.InitLOG()

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

            cLDAP.InitLDAP(cConfig.GetSettings(ESettings.LDAP_Domain), cConfig.GetSettings(ESettings.LDAP_Benutzer), cConfig.GetSettings(ESettings.LDAP_Kennwort))

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

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMail.Click
        frmChangeLog.ShowDialog()
    End Sub

#End Region

#Region "Buttons"
    Private Sub btnVerschieben_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLos.Click
        cLoggingRead = New clsLogging
        frmMails.Protokoll = False
        frmMails.strProtokoll = ""
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

    Private Sub btnProtokoll_Click(sender As System.Object, e As System.EventArgs) Handles btnProtokoll.Click
        cLoggingRead = New clsLogging
        frmMails.Protokoll = True
        frmMails.strProtokoll = ""
        frmMails.ShowDialog()
    End Sub

#End Region



End Class
