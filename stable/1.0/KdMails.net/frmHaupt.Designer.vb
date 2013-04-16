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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHaupt))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnLos = New System.Windows.Forms.Button
        Me.btnOptionen = New System.Windows.Forms.Button
        Me.frmHauptStatus = New System.Windows.Forms.StatusStrip
        Me.stStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmHauptStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.KdMails.net.My.Resources.Resources.Hint
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 188)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnLos
        '
        Me.btnLos.Enabled = False
        Me.btnLos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLos.Location = New System.Drawing.Point(215, 15)
        Me.btnLos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLos.Name = "btnLos"
        Me.btnLos.Size = New System.Drawing.Size(331, 65)
        Me.btnLos.TabIndex = 1
        Me.btnLos.Text = "Los"
        Me.btnLos.UseVisualStyleBackColor = True
        '
        'btnOptionen
        '
        Me.btnOptionen.Enabled = False
        Me.btnOptionen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOptionen.Location = New System.Drawing.Point(215, 108)
        Me.btnOptionen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOptionen.Name = "btnOptionen"
        Me.btnOptionen.Size = New System.Drawing.Size(331, 65)
        Me.btnOptionen.TabIndex = 2
        Me.btnOptionen.Text = "Optionen"
        Me.btnOptionen.UseVisualStyleBackColor = True
        '
        'frmHauptStatus
        '
        Me.frmHauptStatus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.frmHauptStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stStatus})
        Me.frmHauptStatus.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.frmHauptStatus.Location = New System.Drawing.Point(0, 191)
        Me.frmHauptStatus.Name = "frmHauptStatus"
        Me.frmHauptStatus.Size = New System.Drawing.Size(560, 24)
        Me.frmHauptStatus.TabIndex = 3
        '
        'stStatus
        '
        Me.stStatus.AutoSize = False
        Me.stStatus.Name = "stStatus"
        Me.stStatus.Size = New System.Drawing.Size(560, 19)
        Me.stStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'frmHaupt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(560, 215)
        Me.Controls.Add(Me.frmHauptStatus)
        Me.Controls.Add(Me.btnOptionen)
        Me.Controls.Add(Me.btnLos)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHaupt"
        Me.Text = "Kundenmails kopieren"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmHauptStatus.ResumeLayout(False)
        Me.frmHauptStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnLos As System.Windows.Forms.Button
    Friend WithEvents btnOptionen As System.Windows.Forms.Button
    Friend WithEvents frmHauptStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents stStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
