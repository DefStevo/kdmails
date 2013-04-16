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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMails))
        Me.dgMails = New System.Windows.Forms.DataGridView
        Me.cMail = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cMailEID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cOrdner = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cOrdnerEID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cOrdnerSID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cCopy = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.cMailAdress = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnKopieren = New System.Windows.Forms.Button
        Me.btnAbbrechen = New System.Windows.Forms.Button
        CType(Me.dgMails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgMails
        '
        Me.dgMails.AllowUserToAddRows = False
        Me.dgMails.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgMails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgMails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cMail, Me.cMailEID, Me.cOrdner, Me.cOrdnerEID, Me.cOrdnerSID, Me.cCopy, Me.cMailAdress})
        Me.dgMails.Location = New System.Drawing.Point(12, 12)
        Me.dgMails.MultiSelect = False
        Me.dgMails.Name = "dgMails"
        Me.dgMails.RowTemplate.Height = 44
        Me.dgMails.ShowCellToolTips = False
        Me.dgMails.ShowEditingIcon = False
        Me.dgMails.Size = New System.Drawing.Size(810, 322)
        Me.dgMails.TabIndex = 1
        '
        'cMail
        '
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cMail.DefaultCellStyle = DataGridViewCellStyle1
        Me.cMail.HeaderText = "E-Mail"
        Me.cMail.Name = "cMail"
        Me.cMail.ReadOnly = True
        Me.cMail.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cMail.Width = 400
        '
        'cMailEID
        '
        Me.cMailEID.HeaderText = "E-Mail EID"
        Me.cMailEID.Name = "cMailEID"
        Me.cMailEID.ReadOnly = True
        Me.cMailEID.Width = 5
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
        Me.cOrdnerEID.Width = 5
        '
        'cOrdnerSID
        '
        Me.cOrdnerSID.HeaderText = "Ordner SID"
        Me.cOrdnerSID.Name = "cOrdnerSID"
        Me.cOrdnerSID.ReadOnly = True
        Me.cOrdnerSID.Width = 5
        '
        'cCopy
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.NullValue = False
        Me.cCopy.DefaultCellStyle = DataGridViewCellStyle3
        Me.cCopy.HeaderText = "Kopieren"
        Me.cCopy.Name = "cCopy"
        Me.cCopy.Width = 50
        '
        'cMailAdress
        '
        Me.cMailAdress.HeaderText = "E-Mail Adresse"
        Me.cMailAdress.Name = "cMailAdress"
        Me.cMailAdress.Width = 5
        '
        'btnKopieren
        '
        Me.btnKopieren.Enabled = False
        Me.btnKopieren.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnKopieren.Location = New System.Drawing.Point(12, 340)
        Me.btnKopieren.Name = "btnKopieren"
        Me.btnKopieren.Size = New System.Drawing.Size(300, 19)
        Me.btnKopieren.TabIndex = 2
        Me.btnKopieren.Text = "Kopieren"
        Me.btnKopieren.UseVisualStyleBackColor = True
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAbbrechen.Location = New System.Drawing.Point(522, 340)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(300, 19)
        Me.btnAbbrechen.TabIndex = 3
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'frmMails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(829, 366)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.btnKopieren)
        Me.Controls.Add(Me.dgMails)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMails"
        Me.ShowInTaskbar = False
        Me.Text = "Kundenmails kopieren"
        CType(Me.dgMails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgMails As System.Windows.Forms.DataGridView
    Friend WithEvents btnKopieren As System.Windows.Forms.Button
    Friend WithEvents btnAbbrechen As System.Windows.Forms.Button
    Friend WithEvents cMail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMailEID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cOrdner As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cOrdnerEID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cOrdnerSID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCopy As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cMailAdress As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
