<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdate))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLDatei = New System.Windows.Forms.TextBox()
        Me.txtRDatei = New System.Windows.Forms.TextBox()
        Me.txtLVersion = New System.Windows.Forms.TextBox()
        Me.txtRVersion = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lokal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Remote"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(42, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Datei"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(259, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Version"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLDatei
        '
        Me.txtLDatei.BackColor = System.Drawing.SystemColors.Control
        Me.txtLDatei.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLDatei.Location = New System.Drawing.Point(45, 18)
        Me.txtLDatei.Name = "txtLDatei"
        Me.txtLDatei.ReadOnly = True
        Me.txtLDatei.Size = New System.Drawing.Size(208, 20)
        Me.txtLDatei.TabIndex = 4
        Me.txtLDatei.Text = "C:\"
        '
        'txtRDatei
        '
        Me.txtRDatei.BackColor = System.Drawing.SystemColors.Control
        Me.txtRDatei.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRDatei.Location = New System.Drawing.Point(45, 44)
        Me.txtRDatei.Name = "txtRDatei"
        Me.txtRDatei.ReadOnly = True
        Me.txtRDatei.Size = New System.Drawing.Size(208, 20)
        Me.txtRDatei.TabIndex = 5
        Me.txtRDatei.Text = "C:\"
        '
        'txtLVersion
        '
        Me.txtLVersion.BackColor = System.Drawing.SystemColors.Control
        Me.txtLVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLVersion.Location = New System.Drawing.Point(259, 18)
        Me.txtLVersion.Name = "txtLVersion"
        Me.txtLVersion.ReadOnly = True
        Me.txtLVersion.Size = New System.Drawing.Size(50, 20)
        Me.txtLVersion.TabIndex = 6
        Me.txtLVersion.Text = "0.0.0.0"
        Me.txtLVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRVersion
        '
        Me.txtRVersion.BackColor = System.Drawing.SystemColors.Control
        Me.txtRVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRVersion.Location = New System.Drawing.Point(259, 44)
        Me.txtRVersion.Name = "txtRVersion"
        Me.txtRVersion.ReadOnly = True
        Me.txtRVersion.Size = New System.Drawing.Size(50, 20)
        Me.txtRVersion.TabIndex = 7
        Me.txtRVersion.Text = "0.0.0.0"
        Me.txtRVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'txtInfo
        '
        Me.txtInfo.BackColor = System.Drawing.SystemColors.Control
        Me.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInfo.Location = New System.Drawing.Point(0, 66)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ReadOnly = True
        Me.txtInfo.Size = New System.Drawing.Size(309, 81)
        Me.txtInfo.TabIndex = 8
        '
        'frmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 147)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.txtRVersion)
        Me.Controls.Add(Me.txtLVersion)
        Me.Controls.Add(Me.txtRDatei)
        Me.Controls.Add(Me.txtLDatei)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUpdate"
        Me.Text = "KdMails.net: Auto Update"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLDatei As System.Windows.Forms.TextBox
    Friend WithEvents txtRDatei As System.Windows.Forms.TextBox
    Friend WithEvents txtLVersion As System.Windows.Forms.TextBox
    Friend WithEvents txtRVersion As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox

End Class
