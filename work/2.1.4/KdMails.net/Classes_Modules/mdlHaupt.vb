#Region "Imports"
Imports Microsoft.Win32

#End Region

Module mdlHaupt

#Region "Deklartionen"
    Private _strApp_Pfad As String = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\"))
    Private _strUpdate_Pfad As String = ""
    Private _strVersion_Lokal As String = My.Application.Info.Version.Major.ToString & "." & _
                                          My.Application.Info.Version.Minor.ToString & "." & _
                                          My.Application.Info.Version.Build.ToString & "." & _
                                          My.Application.Info.Version.Revision.ToString
    Private _strVersion_Remote As String = ""
    Private _strVersion_Update_Lokal As String = ""
    Private _strVersion_Update_Remote As String = ""
    Public _FolderBrowser As FolderBrowserDialog

#End Region

#Region "Sub/Funktionen"
    Sub Main()
        _FolderBrowser = New FolderBrowserDialog
        _FolderBrowser.RootFolder = Environment.SpecialFolder.MyComputer

        If Not Auto_Update() = True Then

            For i As Integer = 0 To My.Application.CommandLineArgs.Count - 1
                Select Case My.Application.CommandLineArgs(i)
                    Case "/Neu"
                        'Prüfen ob Update.log existiert
                        If System.IO.File.Exists(_strUpdate_Pfad + "\Update.log") Then
                            FileCopy(_strUpdate_Pfad + "\Update.log", _
                                     _strApp_Pfad + "\Update.log")
                        End If

                        If System.IO.File.Exists(_strApp_Pfad + "\Update.log") Then
                            frmHistorie.ShowDialog()
                        End If

                End Select
            Next


            frmHaupt.ShowDialog()
        End If
    End Sub

    Function Auto_Update() As Boolean
        If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("KdMails.net") Is Nothing Then
            Registry.CurrentUser.OpenSubKey("Software", True).CreateSubKey("KdMails.net")
        End If

        Lese_Registry("Update_Pfad", _strUpdate_Pfad)

        'Update Pfad noch nicht definiert
        If _strUpdate_Pfad = "" Then
            If MsgBox("Update Verzeichnis noch nicht definiert" & vbNewLine & "Wollen Sie dies auswählen?", MsgBoxStyle.YesNo, "KdMails.net Auto Update") = vbYes Then
                _FolderBrowser.ShowDialog()
                _strUpdate_Pfad = _FolderBrowser.SelectedPath
                Schreibe_Registry("Update_Pfad", _strUpdate_Pfad)

            Else
                'Update Pfad nicht eingestellt
                Return False
            End If

        End If

        'Prüfen Version von Update.exe
        _strVersion_Update_Lokal = "0"
        _strVersion_Update_Remote = "0"

        If System.IO.File.Exists(_strApp_Pfad + "\KdMails.net.Update.exe") Then
            _strVersion_Update_Lokal = FileVersionInfo.GetVersionInfo(_strApp_Pfad + "\KdMails.net.Update.exe").FileVersion.ToString
        End If

        If System.IO.File.Exists(_strUpdate_Pfad + "\KdMails.net.Update.exe") Then
            _strVersion_Update_Remote = FileVersionInfo.GetVersionInfo(_strUpdate_Pfad + "\KdMails.net.Update.exe").FileVersion.ToString
        End If

        'Falls Version unterschiedlich Update durchführen
        If Not _strVersion_Update_Remote = "0" And Not _strVersion_Update_Lokal = _strVersion_Update_Remote Then
            'Sicherungskopie löschen
            If System.IO.File.Exists(_strApp_Pfad + "\KdMails.net.Update.exe.alt") Then
                System.IO.File.Delete(_strApp_Pfad + "\KdMails.net.Update.exe.alt")
            End If
            'Sicherungkopie erstellen
            If System.IO.File.Exists(_strApp_Pfad + "\KdMails.net.Update.exe") Then
                System.IO.File.Move(_strApp_Pfad + "\KdMails.net.Update.exe", _strApp_Pfad + "\KdMails.net.Update.exe.alt")
            End If

            FileCopy(_strUpdate_Pfad + "\KdMails.net.Update.exe", _
                     _strApp_Pfad + "\KdMails.net.Update.exe")
        End If

        'Prüfen Version von KdMails.net()
        _strVersion_Remote = "0"

        If System.IO.File.Exists(_strUpdate_Pfad + "\KdMails.net.exe") Then
            _strVersion_Remote = FileVersionInfo.GetVersionInfo(_strUpdate_Pfad + "\KdMails.net.exe").FileVersion.ToString
        End If

        'Falls Versoin unterschiedlich Update durchführen
        If Not _strVersion_Remote = "0" And Not _strVersion_Lokal = _strVersion_Remote Then

            If MsgBox("Es steht ein Update zur Verfügung!!!" & vbNewLine & _
                      "Aktuelle Version: " & _strVersion_Lokal & vbNewLine & _
                      "Neue Version: " & _strVersion_Remote & " (" & _strUpdate_Pfad & ")" & vbNewLine & _
                      vbNewLine & _
                      "Wollen Sie dies verwenden?", MsgBoxStyle.YesNo, "KdMails.net Auto Update") = vbYes Then

                Dim strCommand As String = ""

                strCommand = " /RDatei=""" & _strUpdate_Pfad & "\KdMails.net.exe""" & _
                           " /LDatei=""" & _strApp_Pfad & "\KdMails.net.exe""" & _
                           " /RVersion=""" & _strVersion_Remote & """" & _
                           " /LVersion=""" & _strVersion_Lokal & """"

                Shell(_strApp_Pfad + "\KdMails.net.Update.exe" + strCommand, AppWinStyle.NormalFocus, False)

                'Funktion mit True beenden
                Return True
            Else
                Return False
            End If

        End If

    End Function

#End Region

#Region "Registry"
    Public Sub Lese_Registry(ByVal name As String, ByRef Wert As String)
        Wert = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("KdMails.net").GetValue("Update_Pfad", "")
    End Sub

    Public Sub Schreibe_Registry(ByVal Name As String, ByVal Wert As String)
        Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("KdMails.net", True).SetValue(Name, Wert)
    End Sub
#End Region

End Module
