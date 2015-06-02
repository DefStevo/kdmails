<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptionen
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptionen))
        Me.btnSpeichern = New System.Windows.Forms.Button()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.grpDatenbank = New System.Windows.Forms.GroupBox()
        Me.btnMailDom = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKennwort = New System.Windows.Forms.TextBox()
        Me.txtBenutzer = New System.Windows.Forms.TextBox()
        Me.txtDatenbank = New System.Windows.Forms.TextBox()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.dgDomain = New System.Windows.Forms.DataGridView()
        Me.cDomäne = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cKunde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cOutlookOrdner = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cOutlookEID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cOutlookSID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpOutlook = New System.Windows.Forms.GroupBox()
        Me.txtOrdnerEingangSID = New System.Windows.Forms.TextBox()
        Me.btnOrdnerEingang = New System.Windows.Forms.Button()
        Me.txtOrdnerEingangEID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOrdnerEingang = New System.Windows.Forms.TextBox()
        Me.btnMarkMails = New System.Windows.Forms.Button()
        Me.txtOrdnerZielSID = New System.Windows.Forms.TextBox()
        Me.txtOrdnerAusgangSID = New System.Windows.Forms.TextBox()
        Me.btnOrdnerDB = New System.Windows.Forms.Button()
        Me.btnOrdnerZiel = New System.Windows.Forms.Button()
        Me.btnOrdnerAusgang = New System.Windows.Forms.Button()
        Me.optVerschieben = New System.Windows.Forms.RadioButton()
        Me.optKopieren = New System.Windows.Forms.RadioButton()
        Me.txtOrdnerZielEID = New System.Windows.Forms.TextBox()
        Me.txtOrdnerAusgangEID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOrdnerZiel = New System.Windows.Forms.TextBox()
        Me.txtOrdnerAusgang = New System.Windows.Forms.TextBox()
        Me.dgOrdner = New System.Windows.Forms.DataGridView()
        Me.cOrdnerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cOrdnerEID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cOrdnerSID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDebug = New System.Windows.Forms.Button()
        Me.grpIgnore = New System.Windows.Forms.GroupBox()
        Me.dgIgnoreList = New System.Windows.Forms.DataGridView()
        Me.cIgnoreDomäne = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpLDAP = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLDAP = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.grpAutoUpdate = New System.Windows.Forms.GroupBox()
        Me.btnUpdatePfad = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUpdatePfad = New System.Windows.Forms.TextBox()
        Me.txtLDAP_Benutzer = New System.Windows.Forms.TextBox()
        Me.txtLDAP_Kennwort = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grpDatenbank.SuspendLayout()
        CType(Me.dgDomain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOutlook.SuspendLayout()
        CType(Me.dgOrdner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpIgnore.SuspendLayout()
        CType(Me.dgIgnoreList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLDAP.SuspendLayout()
        Me.grpAutoUpdate.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSpeichern
        '
        Me.btnSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSpeichern.Location = New System.Drawing.Point(1, 387)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(140, 21)
        Me.btnSpeichern.TabIndex = 2
        Me.btnSpeichern.Text = "&Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAbbrechen.Location = New System.Drawing.Point(161, 387)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(140, 21)
        Me.btnAbbrechen.TabIndex = 3
        Me.btnAbbrechen.Text = "A&bbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'grpDatenbank
        '
        Me.grpDatenbank.Controls.Add(Me.btnMailDom)
        Me.grpDatenbank.Controls.Add(Me.Label4)
        Me.grpDatenbank.Controls.Add(Me.Label3)
        Me.grpDatenbank.Controls.Add(Me.Label2)
        Me.grpDatenbank.Controls.Add(Me.Label1)
        Me.grpDatenbank.Controls.Add(Me.txtKennwort)
        Me.grpDatenbank.Controls.Add(Me.txtBenutzer)
        Me.grpDatenbank.Controls.Add(Me.txtDatenbank)
        Me.grpDatenbank.Controls.Add(Me.txtServer)
        Me.grpDatenbank.Location = New System.Drawing.Point(0, 0)
        Me.grpDatenbank.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpDatenbank.Name = "grpDatenbank"
        Me.grpDatenbank.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpDatenbank.Size = New System.Drawing.Size(161, 128)
        Me.grpDatenbank.TabIndex = 7
        Me.grpDatenbank.TabStop = False
        Me.grpDatenbank.Text = "Datenbank"
        '
        'btnMailDom
        '
        Me.btnMailDom.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMailDom.Location = New System.Drawing.Point(3, 104)
        Me.btnMailDom.Name = "btnMailDom"
        Me.btnMailDom.Size = New System.Drawing.Size(154, 21)
        Me.btnMailDom.TabIndex = 15
        Me.btnMailDom.Text = "Mail &Domänen ermitteln"
        Me.btnMailDom.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Kennwort"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Benutzer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Datenbank"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Server"
        '
        'txtKennwort
        '
        Me.txtKennwort.Location = New System.Drawing.Point(67, 80)
        Me.txtKennwort.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKennwort.Name = "txtKennwort"
        Me.txtKennwort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtKennwort.Size = New System.Drawing.Size(90, 22)
        Me.txtKennwort.TabIndex = 3
        '
        'txtBenutzer
        '
        Me.txtBenutzer.Location = New System.Drawing.Point(67, 57)
        Me.txtBenutzer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBenutzer.Name = "txtBenutzer"
        Me.txtBenutzer.Size = New System.Drawing.Size(90, 22)
        Me.txtBenutzer.TabIndex = 2
        '
        'txtDatenbank
        '
        Me.txtDatenbank.Location = New System.Drawing.Point(67, 34)
        Me.txtDatenbank.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDatenbank.Name = "txtDatenbank"
        Me.txtDatenbank.Size = New System.Drawing.Size(90, 22)
        Me.txtDatenbank.TabIndex = 1
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(67, 11)
        Me.txtServer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(90, 22)
        Me.txtServer.TabIndex = 0
        '
        'dgDomain
        '
        Me.dgDomain.AllowUserToAddRows = False
        Me.dgDomain.AllowUserToDeleteRows = False
        Me.dgDomain.AllowUserToResizeRows = False
        Me.dgDomain.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgDomain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgDomain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDomain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cDomäne, Me.cKunde, Me.cOutlookOrdner, Me.cOutlookEID, Me.cOutlookSID})
        Me.dgDomain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgDomain.Location = New System.Drawing.Point(306, 1)
        Me.dgDomain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgDomain.MultiSelect = False
        Me.dgDomain.Name = "dgDomain"
        Me.dgDomain.ReadOnly = True
        Me.dgDomain.RowHeadersWidth = 10
        Me.dgDomain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgDomain.RowTemplate.Height = 20
        Me.dgDomain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgDomain.Size = New System.Drawing.Size(531, 190)
        Me.dgDomain.TabIndex = 8
        Me.dgDomain.Visible = False
        '
        'cDomäne
        '
        Me.cDomäne.HeaderText = "Domäne"
        Me.cDomäne.Name = "cDomäne"
        Me.cDomäne.ReadOnly = True
        '
        'cKunde
        '
        Me.cKunde.HeaderText = "Kunde"
        Me.cKunde.Name = "cKunde"
        Me.cKunde.ReadOnly = True
        '
        'cOutlookOrdner
        '
        Me.cOutlookOrdner.HeaderText = "Outlook-Ordner"
        Me.cOutlookOrdner.Name = "cOutlookOrdner"
        Me.cOutlookOrdner.ReadOnly = True
        '
        'cOutlookEID
        '
        Me.cOutlookEID.HeaderText = "Outlook-EntryID"
        Me.cOutlookEID.Name = "cOutlookEID"
        Me.cOutlookEID.ReadOnly = True
        '
        'cOutlookSID
        '
        Me.cOutlookSID.HeaderText = "Outlook-StoreID"
        Me.cOutlookSID.Name = "cOutlookSID"
        Me.cOutlookSID.ReadOnly = True
        '
        'grpOutlook
        '
        Me.grpOutlook.Controls.Add(Me.txtOrdnerEingangSID)
        Me.grpOutlook.Controls.Add(Me.btnOrdnerEingang)
        Me.grpOutlook.Controls.Add(Me.txtOrdnerEingangEID)
        Me.grpOutlook.Controls.Add(Me.Label5)
        Me.grpOutlook.Controls.Add(Me.txtOrdnerEingang)
        Me.grpOutlook.Controls.Add(Me.btnMarkMails)
        Me.grpOutlook.Controls.Add(Me.txtOrdnerZielSID)
        Me.grpOutlook.Controls.Add(Me.txtOrdnerAusgangSID)
        Me.grpOutlook.Controls.Add(Me.btnOrdnerDB)
        Me.grpOutlook.Controls.Add(Me.btnOrdnerZiel)
        Me.grpOutlook.Controls.Add(Me.btnOrdnerAusgang)
        Me.grpOutlook.Controls.Add(Me.optVerschieben)
        Me.grpOutlook.Controls.Add(Me.optKopieren)
        Me.grpOutlook.Controls.Add(Me.txtOrdnerZielEID)
        Me.grpOutlook.Controls.Add(Me.txtOrdnerAusgangEID)
        Me.grpOutlook.Controls.Add(Me.Label6)
        Me.grpOutlook.Controls.Add(Me.Label8)
        Me.grpOutlook.Controls.Add(Me.txtOrdnerZiel)
        Me.grpOutlook.Controls.Add(Me.txtOrdnerAusgang)
        Me.grpOutlook.Location = New System.Drawing.Point(1, 229)
        Me.grpOutlook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpOutlook.Name = "grpOutlook"
        Me.grpOutlook.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpOutlook.Size = New System.Drawing.Size(300, 153)
        Me.grpOutlook.TabIndex = 9
        Me.grpOutlook.TabStop = False
        Me.grpOutlook.Text = "Outlook"
        '
        'txtOrdnerEingangSID
        '
        Me.txtOrdnerEingangSID.Enabled = False
        Me.txtOrdnerEingangSID.Location = New System.Drawing.Point(318, 16)
        Me.txtOrdnerEingangSID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOrdnerEingangSID.Name = "txtOrdnerEingangSID"
        Me.txtOrdnerEingangSID.Size = New System.Drawing.Size(19, 22)
        Me.txtOrdnerEingangSID.TabIndex = 23
        Me.txtOrdnerEingangSID.Visible = False
        '
        'btnOrdnerEingang
        '
        Me.btnOrdnerEingang.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOrdnerEingang.Location = New System.Drawing.Point(76, 17)
        Me.btnOrdnerEingang.Name = "btnOrdnerEingang"
        Me.btnOrdnerEingang.Size = New System.Drawing.Size(24, 19)
        Me.btnOrdnerEingang.TabIndex = 22
        Me.btnOrdnerEingang.Text = "..."
        Me.btnOrdnerEingang.UseVisualStyleBackColor = True
        '
        'txtOrdnerEingangEID
        '
        Me.txtOrdnerEingangEID.Enabled = False
        Me.txtOrdnerEingangEID.Location = New System.Drawing.Point(298, 16)
        Me.txtOrdnerEingangEID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOrdnerEingangEID.Name = "txtOrdnerEingangEID"
        Me.txtOrdnerEingangEID.Size = New System.Drawing.Size(19, 22)
        Me.txtOrdnerEingangEID.TabIndex = 21
        Me.txtOrdnerEingangEID.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Posteingang"
        '
        'txtOrdnerEingang
        '
        Me.txtOrdnerEingang.Location = New System.Drawing.Point(101, 16)
        Me.txtOrdnerEingang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOrdnerEingang.Name = "txtOrdnerEingang"
        Me.txtOrdnerEingang.ReadOnly = True
        Me.txtOrdnerEingang.Size = New System.Drawing.Size(196, 22)
        Me.txtOrdnerEingang.TabIndex = 19
        '
        'btnMarkMails
        '
        Me.btnMarkMails.Enabled = False
        Me.btnMarkMails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMarkMails.Location = New System.Drawing.Point(3, 129)
        Me.btnMarkMails.Name = "btnMarkMails"
        Me.btnMarkMails.Size = New System.Drawing.Size(294, 21)
        Me.btnMarkMails.TabIndex = 18
        Me.btnMarkMails.Text = "Markierte Mails &zurücksetzen"
        Me.btnMarkMails.UseVisualStyleBackColor = True
        '
        'txtOrdnerZielSID
        '
        Me.txtOrdnerZielSID.Enabled = False
        Me.txtOrdnerZielSID.Location = New System.Drawing.Point(318, 62)
        Me.txtOrdnerZielSID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOrdnerZielSID.Name = "txtOrdnerZielSID"
        Me.txtOrdnerZielSID.Size = New System.Drawing.Size(19, 22)
        Me.txtOrdnerZielSID.TabIndex = 17
        Me.txtOrdnerZielSID.Visible = False
        '
        'txtOrdnerAusgangSID
        '
        Me.txtOrdnerAusgangSID.Enabled = False
        Me.txtOrdnerAusgangSID.Location = New System.Drawing.Point(318, 39)
        Me.txtOrdnerAusgangSID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOrdnerAusgangSID.Name = "txtOrdnerAusgangSID"
        Me.txtOrdnerAusgangSID.Size = New System.Drawing.Size(19, 22)
        Me.txtOrdnerAusgangSID.TabIndex = 16
        Me.txtOrdnerAusgangSID.Visible = False
        '
        'btnOrdnerDB
        '
        Me.btnOrdnerDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOrdnerDB.Location = New System.Drawing.Point(3, 107)
        Me.btnOrdnerDB.Name = "btnOrdnerDB"
        Me.btnOrdnerDB.Size = New System.Drawing.Size(294, 21)
        Me.btnOrdnerDB.TabIndex = 14
        Me.btnOrdnerDB.Text = "Ordner Datenbank &aktualisieren"
        Me.btnOrdnerDB.UseVisualStyleBackColor = True
        '
        'btnOrdnerZiel
        '
        Me.btnOrdnerZiel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOrdnerZiel.Location = New System.Drawing.Point(76, 63)
        Me.btnOrdnerZiel.Name = "btnOrdnerZiel"
        Me.btnOrdnerZiel.Size = New System.Drawing.Size(24, 19)
        Me.btnOrdnerZiel.TabIndex = 13
        Me.btnOrdnerZiel.Text = "..."
        Me.btnOrdnerZiel.UseVisualStyleBackColor = True
        '
        'btnOrdnerAusgang
        '
        Me.btnOrdnerAusgang.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOrdnerAusgang.Location = New System.Drawing.Point(76, 40)
        Me.btnOrdnerAusgang.Name = "btnOrdnerAusgang"
        Me.btnOrdnerAusgang.Size = New System.Drawing.Size(24, 19)
        Me.btnOrdnerAusgang.TabIndex = 10
        Me.btnOrdnerAusgang.Text = "..."
        Me.btnOrdnerAusgang.UseVisualStyleBackColor = True
        '
        'optVerschieben
        '
        Me.optVerschieben.Location = New System.Drawing.Point(182, 85)
        Me.optVerschieben.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.optVerschieben.Name = "optVerschieben"
        Me.optVerschieben.Size = New System.Drawing.Size(90, 17)
        Me.optVerschieben.TabIndex = 11
        Me.optVerschieben.Text = "Verschieben"
        Me.optVerschieben.UseVisualStyleBackColor = True
        '
        'optKopieren
        '
        Me.optKopieren.Location = New System.Drawing.Point(102, 85)
        Me.optKopieren.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.optKopieren.Name = "optKopieren"
        Me.optKopieren.Size = New System.Drawing.Size(75, 17)
        Me.optKopieren.TabIndex = 10
        Me.optKopieren.Text = "Kopieren"
        Me.optKopieren.UseVisualStyleBackColor = True
        '
        'txtOrdnerZielEID
        '
        Me.txtOrdnerZielEID.Enabled = False
        Me.txtOrdnerZielEID.Location = New System.Drawing.Point(298, 62)
        Me.txtOrdnerZielEID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOrdnerZielEID.Name = "txtOrdnerZielEID"
        Me.txtOrdnerZielEID.Size = New System.Drawing.Size(19, 22)
        Me.txtOrdnerZielEID.TabIndex = 9
        Me.txtOrdnerZielEID.Visible = False
        '
        'txtOrdnerAusgangEID
        '
        Me.txtOrdnerAusgangEID.Enabled = False
        Me.txtOrdnerAusgangEID.Location = New System.Drawing.Point(298, 39)
        Me.txtOrdnerAusgangEID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOrdnerAusgangEID.Name = "txtOrdnerAusgangEID"
        Me.txtOrdnerAusgangEID.Size = New System.Drawing.Size(19, 22)
        Me.txtOrdnerAusgangEID.TabIndex = 7
        Me.txtOrdnerAusgangEID.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Ziel Ordner"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Gesendet"
        '
        'txtOrdnerZiel
        '
        Me.txtOrdnerZiel.Location = New System.Drawing.Point(101, 62)
        Me.txtOrdnerZiel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOrdnerZiel.Name = "txtOrdnerZiel"
        Me.txtOrdnerZiel.ReadOnly = True
        Me.txtOrdnerZiel.Size = New System.Drawing.Size(196, 22)
        Me.txtOrdnerZiel.TabIndex = 2
        '
        'txtOrdnerAusgang
        '
        Me.txtOrdnerAusgang.Location = New System.Drawing.Point(101, 39)
        Me.txtOrdnerAusgang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOrdnerAusgang.Name = "txtOrdnerAusgang"
        Me.txtOrdnerAusgang.ReadOnly = True
        Me.txtOrdnerAusgang.Size = New System.Drawing.Size(196, 22)
        Me.txtOrdnerAusgang.TabIndex = 0
        '
        'dgOrdner
        '
        Me.dgOrdner.AllowUserToAddRows = False
        Me.dgOrdner.AllowUserToDeleteRows = False
        Me.dgOrdner.AllowUserToResizeRows = False
        Me.dgOrdner.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgOrdner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgOrdner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOrdner.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cOrdnerName, Me.cOrdnerEID, Me.cOrdnerSID})
        Me.dgOrdner.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgOrdner.Location = New System.Drawing.Point(307, 192)
        Me.dgOrdner.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgOrdner.MultiSelect = False
        Me.dgOrdner.Name = "dgOrdner"
        Me.dgOrdner.ReadOnly = True
        Me.dgOrdner.RowHeadersWidth = 10
        Me.dgOrdner.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgOrdner.RowTemplate.Height = 20
        Me.dgOrdner.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgOrdner.Size = New System.Drawing.Size(530, 190)
        Me.dgOrdner.TabIndex = 11
        Me.dgOrdner.Visible = False
        '
        'cOrdnerName
        '
        Me.cOrdnerName.HeaderText = "Name"
        Me.cOrdnerName.Name = "cOrdnerName"
        Me.cOrdnerName.ReadOnly = True
        '
        'cOrdnerEID
        '
        Me.cOrdnerEID.HeaderText = "EntryId"
        Me.cOrdnerEID.Name = "cOrdnerEID"
        Me.cOrdnerEID.ReadOnly = True
        '
        'cOrdnerSID
        '
        Me.cOrdnerSID.HeaderText = "StoreId"
        Me.cOrdnerSID.Name = "cOrdnerSID"
        Me.cOrdnerSID.ReadOnly = True
        '
        'btnDebug
        '
        Me.btnDebug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDebug.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDebug.FlatAppearance.BorderSize = 0
        Me.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDebug.Location = New System.Drawing.Point(143, 387)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(15, 19)
        Me.btnDebug.TabIndex = 12
        Me.btnDebug.UseVisualStyleBackColor = True
        '
        'grpIgnore
        '
        Me.grpIgnore.Controls.Add(Me.dgIgnoreList)
        Me.grpIgnore.Location = New System.Drawing.Point(162, 0)
        Me.grpIgnore.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpIgnore.Name = "grpIgnore"
        Me.grpIgnore.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpIgnore.Size = New System.Drawing.Size(139, 128)
        Me.grpIgnore.TabIndex = 13
        Me.grpIgnore.TabStop = False
        Me.grpIgnore.Text = "Ignore Liste"
        '
        'dgIgnoreList
        '
        Me.dgIgnoreList.AllowUserToResizeColumns = False
        Me.dgIgnoreList.AllowUserToResizeRows = False
        Me.dgIgnoreList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgIgnoreList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgIgnoreList.ColumnHeadersHeight = 20
        Me.dgIgnoreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgIgnoreList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cIgnoreDomäne})
        Me.dgIgnoreList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgIgnoreList.Location = New System.Drawing.Point(3, 12)
        Me.dgIgnoreList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgIgnoreList.MultiSelect = False
        Me.dgIgnoreList.Name = "dgIgnoreList"
        Me.dgIgnoreList.RowHeadersWidth = 10
        Me.dgIgnoreList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgIgnoreList.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgIgnoreList.RowTemplate.Height = 20
        Me.dgIgnoreList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgIgnoreList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgIgnoreList.Size = New System.Drawing.Size(134, 112)
        Me.dgIgnoreList.TabIndex = 9
        '
        'cIgnoreDomäne
        '
        Me.cIgnoreDomäne.HeaderText = "Domäne"
        Me.cIgnoreDomäne.Name = "cIgnoreDomäne"
        Me.cIgnoreDomäne.Width = 105
        '
        'grpLDAP
        '
        Me.grpLDAP.Controls.Add(Me.Label9)
        Me.grpLDAP.Controls.Add(Me.txtLDAP_Kennwort)
        Me.grpLDAP.Controls.Add(Me.txtLDAP_Benutzer)
        Me.grpLDAP.Controls.Add(Me.Label11)
        Me.grpLDAP.Controls.Add(Me.txtLDAP)
        Me.grpLDAP.Location = New System.Drawing.Point(1, 129)
        Me.grpLDAP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpLDAP.Name = "grpLDAP"
        Me.grpLDAP.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpLDAP.Size = New System.Drawing.Size(300, 62)
        Me.grpLDAP.TabIndex = 17
        Me.grpLDAP.TabStop = False
        Me.grpLDAP.Text = "LDAP (AD)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Server"
        '
        'txtLDAP
        '
        Me.txtLDAP.Location = New System.Drawing.Point(67, 11)
        Me.txtLDAP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLDAP.Name = "txtLDAP"
        Me.txtLDAP.Size = New System.Drawing.Size(230, 22)
        Me.txtLDAP.TabIndex = 0
        '
        'grpAutoUpdate
        '
        Me.grpAutoUpdate.Controls.Add(Me.btnUpdatePfad)
        Me.grpAutoUpdate.Controls.Add(Me.Label7)
        Me.grpAutoUpdate.Controls.Add(Me.txtUpdatePfad)
        Me.grpAutoUpdate.Location = New System.Drawing.Point(1, 192)
        Me.grpAutoUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpAutoUpdate.Name = "grpAutoUpdate"
        Me.grpAutoUpdate.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpAutoUpdate.Size = New System.Drawing.Size(300, 36)
        Me.grpAutoUpdate.TabIndex = 18
        Me.grpAutoUpdate.TabStop = False
        Me.grpAutoUpdate.Text = "Auto Update"
        '
        'btnUpdatePfad
        '
        Me.btnUpdatePfad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdatePfad.Location = New System.Drawing.Point(270, 11)
        Me.btnUpdatePfad.Name = "btnUpdatePfad"
        Me.btnUpdatePfad.Size = New System.Drawing.Size(27, 21)
        Me.btnUpdatePfad.TabIndex = 16
        Me.btnUpdatePfad.Text = "..."
        Me.btnUpdatePfad.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Pfad"
        '
        'txtUpdatePfad
        '
        Me.txtUpdatePfad.Location = New System.Drawing.Point(67, 11)
        Me.txtUpdatePfad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUpdatePfad.Name = "txtUpdatePfad"
        Me.txtUpdatePfad.ReadOnly = True
        Me.txtUpdatePfad.Size = New System.Drawing.Size(202, 22)
        Me.txtUpdatePfad.TabIndex = 0
        '
        'txtLDAP_Benutzer
        '
        Me.txtLDAP_Benutzer.Location = New System.Drawing.Point(67, 35)
        Me.txtLDAP_Benutzer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLDAP_Benutzer.Name = "txtLDAP_Benutzer"
        Me.txtLDAP_Benutzer.Size = New System.Drawing.Size(114, 22)
        Me.txtLDAP_Benutzer.TabIndex = 5
        '
        'txtLDAP_Kennwort
        '
        Me.txtLDAP_Kennwort.Location = New System.Drawing.Point(182, 35)
        Me.txtLDAP_Kennwort.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLDAP_Kennwort.Name = "txtLDAP_Kennwort"
        Me.txtLDAP_Kennwort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLDAP_Kennwort.Size = New System.Drawing.Size(114, 22)
        Me.txtLDAP_Kennwort.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(0, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "User/Pass"
        '
        'frmOptionen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(838, 412)
        Me.Controls.Add(Me.grpAutoUpdate)
        Me.Controls.Add(Me.grpLDAP)
        Me.Controls.Add(Me.grpIgnore)
        Me.Controls.Add(Me.btnDebug)
        Me.Controls.Add(Me.dgOrdner)
        Me.Controls.Add(Me.grpOutlook)
        Me.Controls.Add(Me.dgDomain)
        Me.Controls.Add(Me.grpDatenbank)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.btnSpeichern)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOptionen"
        Me.Text = "KdMails.net - Kundenmails kopieren - Optionen"
        Me.grpDatenbank.ResumeLayout(False)
        Me.grpDatenbank.PerformLayout()
        CType(Me.dgDomain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOutlook.ResumeLayout(False)
        Me.grpOutlook.PerformLayout()
        CType(Me.dgOrdner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpIgnore.ResumeLayout(False)
        CType(Me.dgIgnoreList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLDAP.ResumeLayout(False)
        Me.grpLDAP.PerformLayout()
        Me.grpAutoUpdate.ResumeLayout(False)
        Me.grpAutoUpdate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSpeichern As System.Windows.Forms.Button
    Friend WithEvents btnAbbrechen As System.Windows.Forms.Button
    Friend WithEvents grpDatenbank As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKennwort As System.Windows.Forms.TextBox
    Friend WithEvents txtBenutzer As System.Windows.Forms.TextBox
    Friend WithEvents txtDatenbank As System.Windows.Forms.TextBox
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents dgDomain As System.Windows.Forms.DataGridView
    Friend WithEvents grpOutlook As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtOrdnerZiel As System.Windows.Forms.TextBox
    Friend WithEvents txtOrdnerAusgang As System.Windows.Forms.TextBox
    Friend WithEvents txtOrdnerAusgangEID As System.Windows.Forms.TextBox
    Friend WithEvents optVerschieben As System.Windows.Forms.RadioButton
    Friend WithEvents optKopieren As System.Windows.Forms.RadioButton
    Friend WithEvents txtOrdnerZielEID As System.Windows.Forms.TextBox
    Friend WithEvents btnOrdnerAusgang As System.Windows.Forms.Button
    Friend WithEvents btnOrdnerZiel As System.Windows.Forms.Button
    Friend WithEvents btnOrdnerDB As System.Windows.Forms.Button
    Friend WithEvents dgOrdner As System.Windows.Forms.DataGridView
    Friend WithEvents txtOrdnerZielSID As System.Windows.Forms.TextBox
    Friend WithEvents txtOrdnerAusgangSID As System.Windows.Forms.TextBox
    Friend WithEvents btnMailDom As System.Windows.Forms.Button
    Friend WithEvents btnDebug As System.Windows.Forms.Button
    Friend WithEvents cDomäne As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cKunde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cOutlookOrdner As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cOutlookEID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cOutlookSID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnMarkMails As System.Windows.Forms.Button
    Friend WithEvents txtOrdnerEingangSID As System.Windows.Forms.TextBox
    Friend WithEvents btnOrdnerEingang As System.Windows.Forms.Button
    Friend WithEvents txtOrdnerEingangEID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOrdnerEingang As System.Windows.Forms.TextBox
    Friend WithEvents grpIgnore As System.Windows.Forms.GroupBox
    Friend WithEvents dgIgnoreList As System.Windows.Forms.DataGridView
    Friend WithEvents cIgnoreDomäne As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cOrdnerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cOrdnerEID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cOrdnerSID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpLDAP As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtLDAP As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents grpAutoUpdate As System.Windows.Forms.GroupBox
    Friend WithEvents btnUpdatePfad As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUpdatePfad As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtLDAP_Kennwort As System.Windows.Forms.TextBox
    Friend WithEvents txtLDAP_Benutzer As System.Windows.Forms.TextBox

End Class
