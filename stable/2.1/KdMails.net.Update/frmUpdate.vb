#Region "Imports"
Imports Microsoft.Win32

#End Region

Public Class frmUpdate

#Region "Deklarationen"
    Private _strLDatei As String = ""
    Private _strRDatei As String = ""
    Private _strLVersion As String = ""
    Private _strRVersion As String = ""

    Private _bFehler As Boolean = False

#End Region

#Region "Sub"
    Private Sub frmUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Application.CommandLineArgs.Count < 4 Then
            MsgBox("Fehler beim Aufruf:" & vbNewLine & vbNewLine & _
                   "/LDatei=Lokale Datei" & vbNewLine & _
                   "/RDatei=Remote Datei" & vbNewLine & _
                   "/LVersion=Lokale Version" & vbNewLine & _
                   "/RVersion=Remote Version", vbOKOnly, "KdMails.net: Auto Update")

            Me.Close()
        End If

        For i As Integer = 0 To My.Application.CommandLineArgs.Count - 1
            Select Case My.Application.CommandLineArgs(i).Split("=")(0)
                Case "/LDatei"
                    _strLDatei = My.Application.CommandLineArgs(i).Split("=")(1)
                Case "/RDatei"
                    _strRDatei = My.Application.CommandLineArgs(i).Split("=")(1)
                Case "/LVersion"
                    _strLVersion = My.Application.CommandLineArgs(i).Split("=")(1)
                Case "/RVersion"
                    _strRVersion = My.Application.CommandLineArgs(i).Split("=")(1)

            End Select
        Next

        txtLDatei.Text = _strLDatei
        txtRDatei.Text = _strRDatei
        txtLVersion.Text = _strLVersion
        txtRVersion.Text = _strRVersion
        Info_Hinzufuegen("Update wird durchgeführt...", True)
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Info_Hinzufuegen("Prüfen ob Remote-Datei existiert ... ", False)

        If System.IO.File.Exists(_strRDatei) Then
            Info_Hinzufuegen("OK", True)

            If System.IO.File.Exists(_strLDatei) Then
                Info_Hinzufuegen("Auf Sicherungskopie prüfen ... ", False)

                If System.IO.File.Exists(_strLDatei & ".alt") Then
                    Info_Hinzufuegen("OK", True)

                    Info_Hinzufuegen("Sicherungskopie entfernen ... ", False)

                    Try
                        System.IO.File.Delete(_strLDatei & ".alt")
                        Info_Hinzufuegen("OK", True)
                    Catch ex As Exception
                        'Datei gesperrt
                        _bFehler = True
                        Info_Hinzufuegen("FEHLER Zugriff verweigert", True)
                    End Try

                Else
                    Info_Hinzufuegen("OK", True)

                End If
                Info_Hinzufuegen("Sicherungskopie erstellen ... ", False)
                Try
                    System.IO.File.Move(_strLDatei, _strLDatei & ".alt")
                    Info_Hinzufuegen("OK", True)
                Catch ex As Exception
                    'Datei gesperrt
                    _bFehler = True
                    Info_Hinzufuegen("FEHLER Zugriff verweigert", True)
                End Try


            End If
            Info_Hinzufuegen("Update durchführen ... ", False)
            Try
                System.IO.File.Copy(_strRDatei, _strLDatei)
                Info_Hinzufuegen("OK", True)
            Catch ex As Exception
                _bFehler = True
                Info_Hinzufuegen("FEHLER Zugriff verweigert", True)
            End Try


        End If
        If _bFehler = True Then
            MsgBox("Fehler beim Update", vbCritical, "KdMails.net: Auto Update")
        Else
            Info_Hinzufuegen("Programm starten ... ", False)
            Shell(_strLDatei, AppWinStyle.NormalFocus, False)
            Info_Hinzufuegen("OK", False)
        End If

    End Sub

    Private Sub Info_Hinzufuegen(ByVal Text As String, ByVal CRLF As Boolean)
        txtInfo.Text = txtInfo.Text & Text
        If CRLF = True Then
            txtInfo.Text = txtInfo.Text & vbNewLine
        End If
        Me.Refresh()
    End Sub

#End Region
End Class
