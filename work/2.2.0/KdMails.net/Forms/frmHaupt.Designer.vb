<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHaupt
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHaupt))
        Me.picMail = New System.Windows.Forms.PictureBox()
        Me.btnLos = New System.Windows.Forms.Button()
        Me.btnOptionen = New System.Windows.Forms.Button()
        Me.frmHauptStatus = New System.Windows.Forms.StatusStrip()
        Me.stOutlook = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stLDAP = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stDB = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picMail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmHauptStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'picMail
        '
        Me.picMail.BackgroundImage = Global.KdMails.net.My.Resources.Resources.Hint
        Me.picMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMail.Location = New System.Drawing.Point(0, 0)
        Me.picMail.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.picMail.Name = "picMail"
        Me.picMail.Size = New System.Drawing.Size(78, 75)
        Me.picMail.TabIndex = 0
        Me.picMail.TabStop = False
        '
        'btnLos
        '
        Me.btnLos.Enabled = False
        Me.btnLos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLos.Location = New System.Drawing.Point(83, 0)
        Me.btnLos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnLos.Name = "btnLos"
        Me.btnLos.Size = New System.Drawing.Size(284, 37)
        Me.btnLos.TabIndex = 1
        Me.btnLos.Text = "Lo&s"
        Me.btnLos.UseVisualStyleBackColor = True
        '
        'btnOptionen
        '
        Me.btnOptionen.Enabled = False
        Me.btnOptionen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOptionen.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOptionen.Location = New System.Drawing.Point(83, 38)
        Me.btnOptionen.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnOptionen.Name = "btnOptionen"
        Me.btnOptionen.Size = New System.Drawing.Size(284, 37)
        Me.btnOptionen.TabIndex = 2
        Me.btnOptionen.Text = "&Optionen"
        Me.btnOptionen.UseVisualStyleBackColor = True
        '
        'frmHauptStatus
        '
        Me.frmHauptStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.frmHauptStatus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.frmHauptStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stOutlook, Me.stLDAP, Me.stDB, Me.stStatus})
        Me.frmHauptStatus.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.frmHauptStatus.Location = New System.Drawing.Point(0, 75)
        Me.frmHauptStatus.Name = "frmHauptStatus"
        Me.frmHauptStatus.Padding = New System.Windows.Forms.Padding(1, 0, 12, 0)
        Me.frmHauptStatus.Size = New System.Drawing.Size(368, 21)
        Me.frmHauptStatus.SizingGrip = False
        Me.frmHauptStatus.TabIndex = 3
        '
        'stOutlook
        '
        Me.stOutlook.AutoSize = False
        Me.stOutlook.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stOutlook.Image = Global.KdMails.net.My.Resources.Resources.Status_UK
        Me.stOutlook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.stOutlook.Name = "stOutlook"
        Me.stOutlook.Size = New System.Drawing.Size(66, 16)
        Me.stOutlook.Text = "Outlook"
        Me.stOutlook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'stLDAP
        '
        Me.stLDAP.AutoSize = False
        Me.stLDAP.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stLDAP.Image = Global.KdMails.net.My.Resources.Resources.Status_UK
        Me.stLDAP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.stLDAP.Name = "stLDAP"
        Me.stLDAP.Size = New System.Drawing.Size(52, 16)
        Me.stLDAP.Text = "LDAP"
        Me.stLDAP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'stDB
        '
        Me.stDB.AutoSize = False
        Me.stDB.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stDB.Image = Global.KdMails.net.My.Resources.Resources.Status_UK
        Me.stDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.stDB.Name = "stDB"
        Me.stDB.Size = New System.Drawing.Size(38, 16)
        Me.stDB.Text = "DB"
        Me.stDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'stStatus
        '
        Me.stStatus.AutoSize = False
        Me.stStatus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stStatus.Name = "stStatus"
        Me.stStatus.Size = New System.Drawing.Size(160, 16)
        Me.stStatus.Text = "|Lade Einstellungen"
        Me.stStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'frmHaupt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(368, 96)
        Me.Controls.Add(Me.frmHauptStatus)
        Me.Controls.Add(Me.btnOptionen)
        Me.Controls.Add(Me.btnLos)
        Me.Controls.Add(Me.picMail)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHaupt"
        Me.Text = "KdMails.net - Kundenmails kopieren"
        CType(Me.picMail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmHauptStatus.ResumeLayout(False)
        Me.frmHauptStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picMail As System.Windows.Forms.PictureBox
    Friend WithEvents btnLos As System.Windows.Forms.Button
    Friend WithEvents btnOptionen As System.Windows.Forms.Button
    Friend WithEvents frmHauptStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents stStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents stOutlook As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stLDAP As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stDB As System.Windows.Forms.ToolStripStatusLabel

End Class
