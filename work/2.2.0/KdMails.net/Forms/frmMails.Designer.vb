<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMails
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMails))
        Me.dgMails = New System.Windows.Forms.DataGridView()
        Me.PanelUnten = New System.Windows.Forms.Panel()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.btnKopieren = New System.Windows.Forms.Button()
        Me.cEA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMailEID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cOrdner = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cOrdnerEID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cOrdnerSID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCopy = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cIgnore = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cMailAdress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelOben = New System.Windows.Forms.Panel()
        Me.PanelMitte = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.strVersion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.strAktLauf = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.strVorhLauf = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.strPosteingang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.strGesendet = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.strUngelesenNeu = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.strUngelesen = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.strDatei = New System.Windows.Forms.TextBox()
        CType(Me.dgMails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelUnten.SuspendLayout()
        Me.PanelOben.SuspendLayout()
        Me.PanelMitte.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgMails
        '
        Me.dgMails.AllowUserToAddRows = False
        Me.dgMails.AllowUserToDeleteRows = False
        Me.dgMails.AllowUserToOrderColumns = True
        Me.dgMails.AllowUserToResizeRows = False
        Me.dgMails.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgMails.ColumnHeadersHeight = 20
        Me.dgMails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cEA, Me.cMail, Me.cMailEID, Me.cOrdner, Me.cOrdnerEID, Me.cOrdnerSID, Me.cCopy, Me.cIgnore, Me.cMailAdress, Me.cTime})
        Me.dgMails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMails.Location = New System.Drawing.Point(0, 0)
        Me.dgMails.MultiSelect = False
        Me.dgMails.Name = "dgMails"
        Me.dgMails.RowHeadersWidth = 15
        Me.dgMails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgMails.RowTemplate.Height = 30
        Me.dgMails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgMails.ShowCellToolTips = False
        Me.dgMails.ShowEditingIcon = False
        Me.dgMails.Size = New System.Drawing.Size(1422, 513)
        Me.dgMails.TabIndex = 1
        '
        'PanelUnten
        '
        Me.PanelUnten.Controls.Add(Me.btnAbbrechen)
        Me.PanelUnten.Controls.Add(Me.btnKopieren)
        Me.PanelUnten.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelUnten.Location = New System.Drawing.Point(0, 623)
        Me.PanelUnten.Name = "PanelUnten"
        Me.PanelUnten.Size = New System.Drawing.Size(1422, 20)
        Me.PanelUnten.TabIndex = 2
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAbbrechen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAbbrechen.Location = New System.Drawing.Point(1122, 0)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(300, 20)
        Me.btnAbbrechen.TabIndex = 5
        Me.btnAbbrechen.Text = "A&bbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnKopieren
        '
        Me.btnKopieren.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnKopieren.Enabled = False
        Me.btnKopieren.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnKopieren.Location = New System.Drawing.Point(0, 0)
        Me.btnKopieren.Name = "btnKopieren"
        Me.btnKopieren.Size = New System.Drawing.Size(300, 20)
        Me.btnKopieren.TabIndex = 4
        Me.btnKopieren.Text = "&Kopieren"
        Me.btnKopieren.UseVisualStyleBackColor = True
        '
        'cEA
        '
        Me.cEA.HeaderText = "EA"
        Me.cEA.Name = "cEA"
        Me.cEA.ReadOnly = True
        Me.cEA.Width = 25
        '
        'cMail
        '
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cMail.DefaultCellStyle = DataGridViewCellStyle1
        Me.cMail.HeaderText = "E-Mail"
        Me.cMail.Name = "cMail"
        Me.cMail.ReadOnly = True
        Me.cMail.ToolTipText = "Doppelklick für Mail Informationen"
        Me.cMail.Width = 400
        '
        'cMailEID
        '
        Me.cMailEID.HeaderText = "E-Mail EID"
        Me.cMailEID.Name = "cMailEID"
        Me.cMailEID.ReadOnly = True
        '
        'cOrdner
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cOrdner.DefaultCellStyle = DataGridViewCellStyle2
        Me.cOrdner.HeaderText = "Ordner"
        Me.cOrdner.Name = "cOrdner"
        Me.cOrdner.ReadOnly = True
        Me.cOrdner.ToolTipText = "Doppelklick um Ordner auszuwählen"
        Me.cOrdner.Width = 250
        '
        'cOrdnerEID
        '
        Me.cOrdnerEID.HeaderText = "Ordner EID"
        Me.cOrdnerEID.Name = "cOrdnerEID"
        Me.cOrdnerEID.ReadOnly = True
        '
        'cOrdnerSID
        '
        Me.cOrdnerSID.HeaderText = "Ordner SID"
        Me.cOrdnerSID.Name = "cOrdnerSID"
        Me.cOrdnerSID.ReadOnly = True
        '
        'cCopy
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.NullValue = False
        Me.cCopy.DefaultCellStyle = DataGridViewCellStyle3
        Me.cCopy.HeaderText = "Kopieren"
        Me.cCopy.Name = "cCopy"
        Me.cCopy.Width = 80
        '
        'cIgnore
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.NullValue = False
        Me.cIgnore.DefaultCellStyle = DataGridViewCellStyle4
        Me.cIgnore.HeaderText = "Ignorieren"
        Me.cIgnore.Name = "cIgnore"
        Me.cIgnore.Width = 80
        '
        'cMailAdress
        '
        Me.cMailAdress.HeaderText = "E-Mail Adresse"
        Me.cMailAdress.Name = "cMailAdress"
        Me.cMailAdress.ReadOnly = True
        '
        'cTime
        '
        Me.cTime.HeaderText = "Zeit"
        Me.cTime.Name = "cTime"
        Me.cTime.Width = 150
        '
        'PanelOben
        '
        Me.PanelOben.Controls.Add(Me.Label8)
        Me.PanelOben.Controls.Add(Me.strDatei)
        Me.PanelOben.Controls.Add(Me.Label7)
        Me.PanelOben.Controls.Add(Me.strUngelesen)
        Me.PanelOben.Controls.Add(Me.Label6)
        Me.PanelOben.Controls.Add(Me.strUngelesenNeu)
        Me.PanelOben.Controls.Add(Me.Label5)
        Me.PanelOben.Controls.Add(Me.strGesendet)
        Me.PanelOben.Controls.Add(Me.Label4)
        Me.PanelOben.Controls.Add(Me.strPosteingang)
        Me.PanelOben.Controls.Add(Me.Label3)
        Me.PanelOben.Controls.Add(Me.strVorhLauf)
        Me.PanelOben.Controls.Add(Me.Label2)
        Me.PanelOben.Controls.Add(Me.strAktLauf)
        Me.PanelOben.Controls.Add(Me.Label1)
        Me.PanelOben.Controls.Add(Me.strVersion)
        Me.PanelOben.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelOben.Location = New System.Drawing.Point(0, 0)
        Me.PanelOben.Name = "PanelOben"
        Me.PanelOben.Size = New System.Drawing.Size(1422, 110)
        Me.PanelOben.TabIndex = 3
        '
        'PanelMitte
        '
        Me.PanelMitte.Controls.Add(Me.dgMails)
        Me.PanelMitte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMitte.Location = New System.Drawing.Point(0, 110)
        Me.PanelMitte.Name = "PanelMitte"
        Me.PanelMitte.Size = New System.Drawing.Size(1422, 513)
        Me.PanelMitte.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Version"
        '
        'strVersion
        '
        Me.strVersion.Location = New System.Drawing.Point(105, 32)
        Me.strVersion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.strVersion.Name = "strVersion"
        Me.strVersion.ReadOnly = True
        Me.strVersion.Size = New System.Drawing.Size(170, 22)
        Me.strVersion.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Aktueller Lauf"
        '
        'strAktLauf
        '
        Me.strAktLauf.Location = New System.Drawing.Point(105, 58)
        Me.strAktLauf.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.strAktLauf.Name = "strAktLauf"
        Me.strAktLauf.ReadOnly = True
        Me.strAktLauf.Size = New System.Drawing.Size(170, 22)
        Me.strAktLauf.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Verheriger Lauf"
        '
        'strVorhLauf
        '
        Me.strVorhLauf.Location = New System.Drawing.Point(105, 83)
        Me.strVorhLauf.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.strVorhLauf.Name = "strVorhLauf"
        Me.strVorhLauf.ReadOnly = True
        Me.strVorhLauf.Size = New System.Drawing.Size(170, 22)
        Me.strVorhLauf.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1224, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Posteingang"
        '
        'strPosteingang
        '
        Me.strPosteingang.Location = New System.Drawing.Point(1320, 6)
        Me.strPosteingang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.strPosteingang.Name = "strPosteingang"
        Me.strPosteingang.ReadOnly = True
        Me.strPosteingang.Size = New System.Drawing.Size(90, 22)
        Me.strPosteingang.TabIndex = 11
        Me.strPosteingang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1224, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Gesendete"
        '
        'strGesendet
        '
        Me.strGesendet.Location = New System.Drawing.Point(1320, 32)
        Me.strGesendet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.strGesendet.Name = "strGesendet"
        Me.strGesendet.ReadOnly = True
        Me.strGesendet.Size = New System.Drawing.Size(90, 22)
        Me.strGesendet.TabIndex = 13
        Me.strGesendet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1224, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Ungelesene neu"
        '
        'strUngelesenNeu
        '
        Me.strUngelesenNeu.Location = New System.Drawing.Point(1320, 84)
        Me.strUngelesenNeu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.strUngelesenNeu.Name = "strUngelesenNeu"
        Me.strUngelesenNeu.ReadOnly = True
        Me.strUngelesenNeu.Size = New System.Drawing.Size(90, 22)
        Me.strUngelesenNeu.TabIndex = 15
        Me.strUngelesenNeu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1224, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Ungelesene alt"
        '
        'strUngelesen
        '
        Me.strUngelesen.Location = New System.Drawing.Point(1320, 58)
        Me.strUngelesen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.strUngelesen.Name = "strUngelesen"
        Me.strUngelesen.ReadOnly = True
        Me.strUngelesen.Size = New System.Drawing.Size(90, 22)
        Me.strUngelesen.TabIndex = 17
        Me.strUngelesen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Datei"
        '
        'strDatei
        '
        Me.strDatei.Location = New System.Drawing.Point(105, 6)
        Me.strDatei.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.strDatei.Name = "strDatei"
        Me.strDatei.ReadOnly = True
        Me.strDatei.Size = New System.Drawing.Size(688, 22)
        Me.strDatei.TabIndex = 19
        '
        'frmMails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1422, 643)
        Me.Controls.Add(Me.PanelMitte)
        Me.Controls.Add(Me.PanelOben)
        Me.Controls.Add(Me.PanelUnten)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMails"
        Me.Text = "KdMails.net - Kundenmails kopieren - Übersicht"
        CType(Me.dgMails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelUnten.ResumeLayout(False)
        Me.PanelOben.ResumeLayout(False)
        Me.PanelOben.PerformLayout()
        Me.PanelMitte.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgMails As System.Windows.Forms.DataGridView
    Friend WithEvents PanelUnten As System.Windows.Forms.Panel
    Friend WithEvents btnAbbrechen As System.Windows.Forms.Button
    Friend WithEvents btnKopieren As System.Windows.Forms.Button
    Friend WithEvents cEA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMailEID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cOrdner As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cOrdnerEID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cOrdnerSID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCopy As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cIgnore As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cMailAdress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PanelOben As System.Windows.Forms.Panel
    Friend WithEvents PanelMitte As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents strDatei As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents strUngelesen As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents strUngelesenNeu As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents strGesendet As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents strPosteingang As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents strVorhLauf As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents strAktLauf As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents strVersion As System.Windows.Forms.TextBox

End Class
