<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnmeldung
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
        Me.txtBenutzer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKennwort = New System.Windows.Forms.TextBox()
        Me.txtDomäne = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.cbAnmeldungSpeichern = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtBenutzer
        '
        Me.txtBenutzer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBenutzer.Location = New System.Drawing.Point(66, 29)
        Me.txtBenutzer.Name = "txtBenutzer"
        Me.txtBenutzer.Size = New System.Drawing.Size(225, 20)
        Me.txtBenutzer.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Benutzer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Kennwort"
        '
        'txtKennwort
        '
        Me.txtKennwort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKennwort.Location = New System.Drawing.Point(66, 51)
        Me.txtKennwort.Name = "txtKennwort"
        Me.txtKennwort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtKennwort.Size = New System.Drawing.Size(225, 20)
        Me.txtKennwort.TabIndex = 7
        '
        'txtDomäne
        '
        Me.txtDomäne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDomäne.Location = New System.Drawing.Point(66, 7)
        Me.txtDomäne.Name = "txtDomäne"
        Me.txtDomäne.ReadOnly = True
        Me.txtDomäne.Size = New System.Drawing.Size(225, 20)
        Me.txtDomäne.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Domäne"
        '
        'btnOK
        '
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOK.Location = New System.Drawing.Point(216, 74)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 10
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'cbAnmeldungSpeichern
        '
        Me.cbAnmeldungSpeichern.AutoSize = True
        Me.cbAnmeldungSpeichern.Checked = True
        Me.cbAnmeldungSpeichern.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAnmeldungSpeichern.Location = New System.Drawing.Point(66, 78)
        Me.cbAnmeldungSpeichern.Name = "cbAnmeldungSpeichern"
        Me.cbAnmeldungSpeichern.Size = New System.Drawing.Size(143, 17)
        Me.cbAnmeldungSpeichern.TabIndex = 11
        Me.cbAnmeldungSpeichern.Text = "Anmeldedaten speichern"
        Me.cbAnmeldungSpeichern.UseVisualStyleBackColor = True
        '
        'frmAnmeldung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(296, 104)
        Me.Controls.Add(Me.cbAnmeldungSpeichern)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDomäne)
        Me.Controls.Add(Me.txtKennwort)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBenutzer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAnmeldung"
        Me.Text = "KdMails.net - Kundenmails kopieren - Anmeldung"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBenutzer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKennwort As System.Windows.Forms.TextBox
    Friend WithEvents txtDomäne As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents cbAnmeldungSpeichern As System.Windows.Forms.CheckBox
End Class
