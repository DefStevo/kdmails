<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangeLog))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtDatum = New System.Windows.Forms.TextBox()
        Me.btnZuruck = New System.Windows.Forms.Button()
        Me.btnVor = New System.Windows.Forms.Button()
        Me.btnAnfang = New System.Windows.Forms.Button()
        Me.btnEnde = New System.Windows.Forms.Button()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.txtAnderung = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOK.Location = New System.Drawing.Point(425, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtDatum
        '
        Me.txtDatum.BackColor = System.Drawing.SystemColors.Control
        Me.txtDatum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDatum.Location = New System.Drawing.Point(161, 3)
        Me.txtDatum.Name = "txtDatum"
        Me.txtDatum.ReadOnly = True
        Me.txtDatum.Size = New System.Drawing.Size(67, 22)
        Me.txtDatum.TabIndex = 1
        '
        'btnZuruck
        '
        Me.btnZuruck.Enabled = False
        Me.btnZuruck.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnZuruck.Image = Global.KdMails.net.My.Resources.Resources.Zuruck
        Me.btnZuruck.Location = New System.Drawing.Point(27, 3)
        Me.btnZuruck.Name = "btnZuruck"
        Me.btnZuruck.Size = New System.Drawing.Size(15, 20)
        Me.btnZuruck.TabIndex = 2
        Me.btnZuruck.UseVisualStyleBackColor = True
        '
        'btnVor
        '
        Me.btnVor.Enabled = False
        Me.btnVor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVor.Image = Global.KdMails.net.My.Resources.Resources.Vor
        Me.btnVor.Location = New System.Drawing.Point(45, 3)
        Me.btnVor.Name = "btnVor"
        Me.btnVor.Size = New System.Drawing.Size(15, 20)
        Me.btnVor.TabIndex = 3
        Me.btnVor.UseVisualStyleBackColor = True
        '
        'btnAnfang
        '
        Me.btnAnfang.Enabled = False
        Me.btnAnfang.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAnfang.Image = Global.KdMails.net.My.Resources.Resources.Anfang
        Me.btnAnfang.Location = New System.Drawing.Point(1, 3)
        Me.btnAnfang.Name = "btnAnfang"
        Me.btnAnfang.Size = New System.Drawing.Size(25, 20)
        Me.btnAnfang.TabIndex = 4
        Me.btnAnfang.UseVisualStyleBackColor = True
        '
        'btnEnde
        '
        Me.btnEnde.Enabled = False
        Me.btnEnde.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnde.Image = Global.KdMails.net.My.Resources.Resources.Ende
        Me.btnEnde.Location = New System.Drawing.Point(61, 3)
        Me.btnEnde.Name = "btnEnde"
        Me.btnEnde.Size = New System.Drawing.Size(25, 20)
        Me.btnEnde.TabIndex = 5
        Me.btnEnde.UseVisualStyleBackColor = True
        '
        'txtVersion
        '
        Me.txtVersion.BackColor = System.Drawing.SystemColors.Control
        Me.txtVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVersion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVersion.Location = New System.Drawing.Point(101, 3)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.ReadOnly = True
        Me.txtVersion.Size = New System.Drawing.Size(54, 22)
        Me.txtVersion.TabIndex = 6
        '
        'txtAnderung
        '
        Me.txtAnderung.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAnderung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnderung.Location = New System.Drawing.Point(1, 28)
        Me.txtAnderung.Multiline = True
        Me.txtAnderung.Name = "txtAnderung"
        Me.txtAnderung.ReadOnly = True
        Me.txtAnderung.Size = New System.Drawing.Size(499, 221)
        Me.txtAnderung.TabIndex = 7
        '
        'frmChangeLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(502, 251)
        Me.Controls.Add(Me.txtAnderung)
        Me.Controls.Add(Me.txtVersion)
        Me.Controls.Add(Me.btnEnde)
        Me.Controls.Add(Me.btnAnfang)
        Me.Controls.Add(Me.btnVor)
        Me.Controls.Add(Me.btnZuruck)
        Me.Controls.Add(Me.txtDatum)
        Me.Controls.Add(Me.btnOK)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChangeLog"
        Me.Text = "KdMails.net - Kundenmails kopieren - Änderungshistorie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtDatum As System.Windows.Forms.TextBox
    Friend WithEvents btnZuruck As System.Windows.Forms.Button
    Friend WithEvents btnVor As System.Windows.Forms.Button
    Friend WithEvents btnAnfang As System.Windows.Forms.Button
    Friend WithEvents btnEnde As System.Windows.Forms.Button
    Friend WithEvents txtVersion As System.Windows.Forms.TextBox
    Friend WithEvents txtAnderung As System.Windows.Forms.TextBox
End Class
