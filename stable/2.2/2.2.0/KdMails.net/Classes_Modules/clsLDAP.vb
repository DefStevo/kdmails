#Region "Imports"
Imports System.Security
Imports System.DirectoryServices
Imports System.DirectoryServices.ActiveDirectory

#End Region

Public Class clsLDAP

#Region "Deklaration"
    Private _Entry As DirectoryEntry
    Private _Searcher As DirectorySearcher
    Private _ResultColl As SearchResultCollection
    Private _Result As SearchResult

    Private _strDomäne As String = ""
    Private _strBenutzer As String = ""
    Private _strKennwort As String = ""
    Private _bInitStatus As Boolean = False

    Private cAnmeldung As New frmAnmeldung

#End Region

#Region "Properties"
    Property Domäne() As String
        Get
            Return _strDomäne
        End Get
        Set(ByVal value As String)
            _strDomäne = value
        End Set
    End Property

    ReadOnly Property Status As Boolean
        Get
            Return _bInitStatus
        End Get
    End Property

#End Region

#Region "Funktionen"
    Function InitLDAP(Optional ByVal Domäne As String = Nothing, Optional ByVal Benutzer As String = Nothing, Optional ByVal Kennwort As String = Nothing) As Boolean
        Dim _Retry As Boolean = True

        If Not Domäne = Nothing Then
            _strDomäne = Domäne
        End If

        If Not Benutzer = Nothing Then
            _strBenutzer = Benutzer
        End If

        If Not Kennwort = Nothing Then
            _strKennwort = Kennwort
        End If

        If _strDomäne = "" Then
            Return False
        End If

        _Entry = New DirectoryEntry("LDAP://" + _strDomäne)

        If Not _strBenutzer = "" Then
            _Entry.Username = _strBenutzer
        End If

        If Not _strKennwort = "" Then
            _Entry.Password = _strKennwort
        End If

        _Searcher = New DirectorySearcher(_Entry)
        _Searcher.PropertiesToLoad.Add("Name")
        _Searcher.PropertiesToLoad.Add("Mail")
        _Searcher.PropertiesToLoad.Add("UserPrincipalName")

        While _Retry
            Try
                _Searcher.FindOne()
                _bInitStatus = True
                Return True

            Catch ex As System.Runtime.InteropServices.COMException
                _bInitStatus = False

                Select Case ex.ErrorCode
                    Case -2147016646
                        'LDAP-Server nicht verfügbar (falscher Server)
                        MsgBox("Server: " + _strDomäne + vbNewLine + _
                               ex.Message, MsgBoxStyle.Critical, "Fehler bei der Verbindung mit LDAP")
                        _Retry = False
                        Return False

                    Case -2147023570
                        'Benutzer/Kennwort falsch (Formular für Benutzer Kennwort öffnen)
                        cAnmeldung.txtDomäne.Text = _strDomäne
                        cAnmeldung.txtBenutzer.Text = _strBenutzer
                        cAnmeldung.txtKennwort.Text = _strKennwort
                        cAnmeldung.ShowDialog()

                        'Anmeldedaten aus Fenster verwenden
                        _Entry.Username = cAnmeldung.txtBenutzer.Text
                        _Entry.Password = cAnmeldung.txtKennwort.Text

                        'Anmeldedaten speichern
                        If cAnmeldung.cbAnmeldungSpeichern.Checked Then
                            frmHaupt.cConfig.SetSettings(clsConfig.ESettings.LDAP_Benutzer, cAnmeldung.txtBenutzer.Text)
                            frmHaupt.cConfig.SetSettings(clsConfig.ESettings.LDAP_Kennwort, cAnmeldung.txtKennwort.Text)
                        End If

                    Case Else
                        MsgBox("Server: " + _strDomäne + vbNewLine + _
                               ex.Message, MsgBoxStyle.Critical, "Fehler bei der Verbindung mit LDAP")
                        _Retry = False
                        Return False

                End Select
            End Try
        End While

    End Function

    Function SearchLDAPEMail(ByVal X400 As String) As String
        If _bInitStatus = False Then
            If InitLDAP() = False Then
                Return Nothing
            End If
        End If

        _Searcher.Filter = "(" + _
                              "&(ObjectClass=*)" + _
                              "(LegacyExchangeDN=" + X400 + ")" + _
                           ")"

        _Result = _Searcher.FindOne

        If Not _Result Is Nothing Then
            For i As Integer = 0 To _Result.Properties.Count - 1
                If _Result.Properties.PropertyNames(i).ToString = "mail" Or _Result.Properties.PropertyNames(i).ToString = "userprincipalname" Then
                    Return _Result.Properties(_Result.Properties.PropertyNames(i)).Item(0)

                End If
            Next

        End If

        Return Nothing

    End Function

#End Region

End Class
