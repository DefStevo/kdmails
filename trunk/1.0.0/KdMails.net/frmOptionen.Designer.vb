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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptionen))
        Me.btnSpeichern = New System.Windows.Forms.Button
        Me.btnAbbrechen = New System.Windows.Forms.Button
        Me.grpDatenbank = New System.Windows.Forms.GroupBox
        Me.btnMailDom = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtKennwort = New System.Windows.Forms.TextBox
        Me.txtBenutzer = New System.Windows.Forms.TextBox
        Me.txtDatenbank = New System.Windows.Forms.TextBox
        Me.txtServer = New System.Windows.Forms.TextBox
        Me.dgDomain = New System.Windows.Forms.DataGridView
        Me.cDomäne = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cKunde = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cOutlookOrdner = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cOutlookEID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cOutlookSID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grpOutlook = New System.Windows.Forms.GroupBox
        Me.btnMarkMails = New System.Windows.Forms.Button
        Me.txtOrdnerÜberwachungSID = New System.Windows.Forms.TextBox
        Me.txtOrdnerSID = New System.Windows.Forms.TextBox
        Me.btnOrdnerDB = New System.Windows.Forms.Button
        Me.btnOrdnerÜberwachung = New System.Windows.Forms.Button
        Me.btnOrdner = New System.Windows.Forms.Button
        Me.optVerschieben = New System.Windows.Forms.RadioButton
        Me.optKopieren = New System.Windows.Forms.RadioButton
        Me.txtOrdnerÜberwachungEID = New System.Windows.Forms.TextBox
        Me.txtOrdnerEID = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtOrdnerÜberwachung = New System.Windows.Forms.TextBox
        Me.txtOrdner = New System.Windows.Forms.TextBox
        Me.dgOrdner = New System.Windows.Forms.DataGridView
        Me.cOrdnerName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cOrdnerEID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cOrdnerSID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnDebug = New System.Windows.Forms.Button
        Me.grpDatenbank.SuspendLayout()
        CType(Me.dgDomain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOutlook.SuspendLayout()
        CType(Me.dgOrdner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSpeichern
        '
        Me.btnSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSpeichern.Location = New System.Drawing.Point(12, 337)
        Me.btnSpeichern.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(170, 23)
        Me.btnSpeichern.TabIndex = 2
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAbbrechen.Location = New System.Drawing.Point(204, 337)
        Me.btnAbbrechen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(170, 23)
        Me.btnAbbrechen.TabIndex = 3
        Me.btnAbbrechen.Text = "Abbrechen"
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
        Me.grpDatenbank.Location = New System.Drawing.Point(12, 12)
        Me.grpDatenbank.Name = "grpDatenbank"
        Me.grpDatenbank.Size = New System.Drawing.Size(362, 159)
        Me.grpDatenbank.TabIndex = 7
        Me.grpDatenbank.TabStop = False
        Me.grpDatenbank.Text = "Datenbank"
        '
        'btnMailDom
        '
        Me.btnMailDom.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMailDom.Location = New System.Drawing.Point(10, 128)
        Me.btnMailDom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMailDom.Name = "btnMailDom"
        Me.btnMailDom.Size = New System.Drawing.Size(342, 21)
        Me.btnMailDom.TabIndex = 15
        Me.btnMailDom.Text = "Mail Domänen ermitteln"
        Me.btnMailDom.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Kennwort"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Benutzer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Datenbank"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Server"
        '
        'txtKennwort
        '
        Me.txtKennwort.Location = New System.Drawing.Point(124, 100)
        Me.txtKennwort.Name = "txtKennwort"
        Me.txtKennwort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtKennwort.Size = New System.Drawing.Size(228, 21)
        Me.txtKennwort.TabIndex = 3
        '
        'txtBenutzer
        '
        Me.txtBenutzer.Location = New System.Drawing.Point(124, 74)
        Me.txtBenutzer.Name = "txtBenutzer"
        Me.txtBenutzer.Size = New System.Drawing.Size(228, 21)
        Me.txtBenutzer.TabIndex = 2
        '
        'txtDatenbank
        '
        Me.txtDatenbank.Location = New System.Drawing.Point(124, 47)
        Me.txtDatenbank.Name = "txtDatenbank"
        Me.txtDatenbank.Size = New System.Drawing.Size(228, 21)
        Me.txtDatenbank.TabIndex = 1
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(124, 20)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(228, 21)
        Me.txtServer.TabIndex = 0
        '
        'dgDomain
        '
        Me.dgDomain.AllowUserToAddRows = False
        Me.dgDomain.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgDomain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgDomain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDomain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cDomäne, Me.cKunde, Me.cOutlookOrdner, Me.cOutlookEID, Me.cOutlookSID})
        Me.dgDomain.Location = New System.Drawing.Point(380, 12)
        Me.dgDomain.MultiSelect = False
        Me.dgDomain.Name = "dgDomain"
        Me.dgDomain.Size = New System.Drawing.Size(553, 159)
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
        '
        'cOutlookEID
        '
        Me.cOutlookEID.HeaderText = "Outlook-EntryID"
        Me.cOutlookEID.Name = "cOutlookEID"
        '
        'cOutlookSID
        '
        Me.cOutlookSID.HeaderText = "Outlook-StoreID"
        Me.cOutlookSID.Name = "cOutlookSID"
        '
        'grpOutlook
        '
        Me.grpOutlook.Controls.Add(Me.btnMarkMails)
        Me.grpOutlook.Controls.Add(Me.txtOrdnerÜberwachungSID)
        Me.grpOutlook.Controls.Add(Me.txtOrdnerSID)
        Me.grpOutlook.Controls.Add(Me.btnOrdnerDB)
        Me.grpOutlook.Controls.Add(Me.btnOrdnerÜberwachung)
        Me.grpOutlook.Controls.Add(Me.btnOrdner)
        Me.grpOutlook.Controls.Add(Me.optVerschieben)
        Me.grpOutlook.Controls.Add(Me.optKopieren)
        Me.grpOutlook.Controls.Add(Me.txtOrdnerÜberwachungEID)
        Me.grpOutlook.Controls.Add(Me.txtOrdnerEID)
        Me.grpOutlook.Controls.Add(Me.Label6)
        Me.grpOutlook.Controls.Add(Me.Label8)
        Me.grpOutlook.Controls.Add(Me.txtOrdnerÜberwachung)
        Me.grpOutlook.Controls.Add(Me.txtOrdner)
        Me.grpOutlook.Location = New System.Drawing.Point(12, 177)
        Me.grpOutlook.Name = "grpOutlook"
        Me.grpOutlook.Size = New System.Drawing.Size(362, 153)
        Me.grpOutlook.TabIndex = 9
        Me.grpOutlook.TabStop = False
        Me.grpOutlook.Text = "Outlook"
        '
        'btnMarkMails
        '
        Me.btnMarkMails.Enabled = False
        Me.btnMarkMails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMarkMails.Location = New System.Drawing.Point(9, 125)
        Me.btnMarkMails.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMarkMails.Name = "btnMarkMails"
        Me.btnMarkMails.Size = New System.Drawing.Size(343, 21)
        Me.btnMarkMails.TabIndex = 18
        Me.btnMarkMails.Text = "Markierte Mails zurücksetzen"
        Me.btnMarkMails.UseVisualStyleBackColor = True
        '
        'txtOrdnerÜberwachungSID
        '
        Me.txtOrdnerÜberwachungSID.Enabled = False
        Me.txtOrdnerÜberwachungSID.Location = New System.Drawing.Point(385, 47)
        Me.txtOrdnerÜberwachungSID.Name = "txtOrdnerÜberwachungSID"
        Me.txtOrdnerÜberwachungSID.Size = New System.Drawing.Size(21, 21)
        Me.txtOrdnerÜberwachungSID.TabIndex = 17
        Me.txtOrdnerÜberwachungSID.Visible = False
        '
        'txtOrdnerSID
        '
        Me.txtOrdnerSID.Enabled = False
        Me.txtOrdnerSID.Location = New System.Drawing.Point(385, 20)
        Me.txtOrdnerSID.Name = "txtOrdnerSID"
        Me.txtOrdnerSID.Size = New System.Drawing.Size(21, 21)
        Me.txtOrdnerSID.TabIndex = 16
        Me.txtOrdnerSID.Visible = False
        '
        'btnOrdnerDB
        '
        Me.btnOrdnerDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOrdnerDB.Location = New System.Drawing.Point(9, 101)
        Me.btnOrdnerDB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOrdnerDB.Name = "btnOrdnerDB"
        Me.btnOrdnerDB.Size = New System.Drawing.Size(343, 21)
        Me.btnOrdnerDB.TabIndex = 14
        Me.btnOrdnerDB.Text = "Ordner Datenbank aktualisieren"
        Me.btnOrdnerDB.UseVisualStyleBackColor = True
        '
        'btnOrdnerÜberwachung
        '
        Me.btnOrdnerÜberwachung.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOrdnerÜberwachung.Location = New System.Drawing.Point(93, 47)
        Me.btnOrdnerÜberwachung.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOrdnerÜberwachung.Name = "btnOrdnerÜberwachung"
        Me.btnOrdnerÜberwachung.Size = New System.Drawing.Size(25, 21)
        Me.btnOrdnerÜberwachung.TabIndex = 13
        Me.btnOrdnerÜberwachung.Text = "..."
        Me.btnOrdnerÜberwachung.UseVisualStyleBackColor = True
        '
        'btnOrdner
        '
        Me.btnOrdner.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOrdner.Location = New System.Drawing.Point(93, 20)
        Me.btnOrdner.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOrdner.Name = "btnOrdner"
        Me.btnOrdner.Size = New System.Drawing.Size(25, 21)
        Me.btnOrdner.TabIndex = 10
        Me.btnOrdner.Text = "..."
        Me.btnOrdner.UseVisualStyleBackColor = True
        '
        'optVerschieben
        '
        Me.optVerschieben.AutoSize = True
        Me.optVerschieben.Location = New System.Drawing.Point(260, 74)
        Me.optVerschieben.Name = "optVerschieben"
        Me.optVerschieben.Size = New System.Drawing.Size(92, 20)
        Me.optVerschieben.TabIndex = 11
        Me.optVerschieben.Text = "Verschieben"
        Me.optVerschieben.UseVisualStyleBackColor = True
        '
        'optKopieren
        '
        Me.optKopieren.AutoSize = True
        Me.optKopieren.Location = New System.Drawing.Point(125, 74)
        Me.optKopieren.Name = "optKopieren"
        Me.optKopieren.Size = New System.Drawing.Size(74, 20)
        Me.optKopieren.TabIndex = 10
        Me.optKopieren.Text = "Kopieren"
        Me.optKopieren.UseVisualStyleBackColor = True
        '
        'txtOrdnerÜberwachungEID
        '
        Me.txtOrdnerÜberwachungEID.Enabled = False
        Me.txtOrdnerÜberwachungEID.Location = New System.Drawing.Point(358, 47)
        Me.txtOrdnerÜberwachungEID.Name = "txtOrdnerÜberwachungEID"
        Me.txtOrdnerÜberwachungEID.Size = New System.Drawing.Size(21, 21)
        Me.txtOrdnerÜberwachungEID.TabIndex = 9
        Me.txtOrdnerÜberwachungEID.Visible = False
        '
        'txtOrdnerEID
        '
        Me.txtOrdnerEID.Enabled = False
        Me.txtOrdnerEID.Location = New System.Drawing.Point(358, 20)
        Me.txtOrdnerEID.Name = "txtOrdnerEID"
        Me.txtOrdnerEID.Size = New System.Drawing.Size(21, 21)
        Me.txtOrdnerEID.TabIndex = 7
        Me.txtOrdnerEID.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Überwachung"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Ordner"
        '
        'txtOrdnerÜberwachung
        '
        Me.txtOrdnerÜberwachung.Location = New System.Drawing.Point(124, 47)
        Me.txtOrdnerÜberwachung.Name = "txtOrdnerÜberwachung"
        Me.txtOrdnerÜberwachung.ReadOnly = True
        Me.txtOrdnerÜberwachung.Size = New System.Drawing.Size(228, 21)
        Me.txtOrdnerÜberwachung.TabIndex = 2
        '
        'txtOrdner
        '
        Me.txtOrdner.Location = New System.Drawing.Point(124, 20)
        Me.txtOrdner.Name = "txtOrdner"
        Me.txtOrdner.ReadOnly = True
        Me.txtOrdner.Size = New System.Drawing.Size(228, 21)
        Me.txtOrdner.TabIndex = 0
        '
        'dgOrdner
        '
        Me.dgOrdner.AllowUserToAddRows = False
        Me.dgOrdner.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgOrdner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgOrdner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOrdner.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cOrdnerName, Me.cOrdnerEID, Me.cOrdnerSID})
        Me.dgOrdner.Location = New System.Drawing.Point(380, 177)
        Me.dgOrdner.MultiSelect = False
        Me.dgOrdner.Name = "dgOrdner"
        Me.dgOrdner.Size = New System.Drawing.Size(553, 128)
        Me.dgOrdner.TabIndex = 11
        Me.dgOrdner.Visible = False
        '
        'cOrdnerName
        '
        Me.cOrdnerName.HeaderText = "Name"
        Me.cOrdnerName.Name = "cOrdnerName"
        '
        'cOrdnerEID
        '
        Me.cOrdnerEID.HeaderText = "EntryId"
        Me.cOrdnerEID.Name = "cOrdnerEID"
        Me.cOrdnerEID.ReadOnly = True
        Me.cOrdnerEID.Width = 50
        '
        'cOrdnerSID
        '
        Me.cOrdnerSID.HeaderText = "StoreId"
        Me.cOrdnerSID.Name = "cOrdnerSID"
        '
        'btnDebug
        '
        Me.btnDebug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDebug.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDebug.FlatAppearance.BorderSize = 0
        Me.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDebug.Location = New System.Drawing.Point(187, 337)
        Me.btnDebug.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(11, 23)
        Me.btnDebug.TabIndex = 12
        Me.btnDebug.UseVisualStyleBackColor = True
        '
        'frmOptionen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(943, 371)
        Me.Controls.Add(Me.btnDebug)
        Me.Controls.Add(Me.dgOrdner)
        Me.Controls.Add(Me.grpOutlook)
        Me.Controls.Add(Me.dgDomain)
        Me.Controls.Add(Me.grpDatenbank)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.btnSpeichern)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOptionen"
        Me.ShowInTaskbar = False
        Me.Text = "Kundenmails kopieren - Optionen"
        Me.grpDatenbank.ResumeLayout(False)
        Me.grpDatenbank.PerformLayout()
        CType(Me.dgDomain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOutlook.ResumeLayout(False)
        Me.grpOutlook.PerformLayout()
        CType(Me.dgOrdner, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtOrdnerÜberwachung As System.Windows.Forms.TextBox
    Friend WithEvents txtOrdner As System.Windows.Forms.TextBox
    Friend WithEvents txtOrdnerEID As System.Windows.Forms.TextBox
    Friend WithEvents optVerschieben As System.Windows.Forms.RadioButton
    Friend WithEvents optKopieren As System.Windows.Forms.RadioButton
    Friend WithEvents txtOrdnerÜberwachungEID As System.Windows.Forms.TextBox
    Friend WithEvents btnOrdner As System.Windows.Forms.Button
    Friend WithEvents btnOrdnerÜberwachung As System.Windows.Forms.Button
    Friend WithEvents btnOrdnerDB As System.Windows.Forms.Button
    Friend WithEvents dgOrdner As System.Windows.Forms.DataGridView
    Friend WithEvents txtOrdnerÜberwachungSID As System.Windows.Forms.TextBox
    Friend WithEvents txtOrdnerSID As System.Windows.Forms.TextBox
    Friend WithEvents btnMailDom As System.Windows.Forms.Button
    Friend WithEvents btnDebug As System.Windows.Forms.Button
    Friend WithEvents cOrdnerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cOrdnerEID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cOrdnerSID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDomäne As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cKunde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cOutlookOrdner As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cOutlookEID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cOutlookSID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnMarkMails As System.Windows.Forms.Button

End Class
