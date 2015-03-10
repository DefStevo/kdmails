Public Class frmChangeLog

#Region "Strukturen"
    Structure sAenderung
        Dim strVersion As String
        Dim strDatum As String
        Dim strAenderung As String

        Sub New(ByVal Version As String, Optional ByVal Datum As String = "", Optional ByVal Text As String = "")
            strVersion = Version
            strDatum = Datum
            strAenderung = Text
        End Sub
    End Structure
#End Region

#Region "Deklarationen"
    Private _strDateiAenderung As String = My.Application.Info.DirectoryPath & "\Update.log"
    Private _srAenderung As System.IO.StreamReader

    Private _i As Integer = 0

    Private oAenderungL As List(Of sAenderung)
    Private oAenderungZ As sAenderung

#End Region

#Region "Subs/Funktionen"
    Private Sub frmHistorie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Refresh()
        oAenderungL = New List(Of sAenderung)
        Read_Changelog()
    End Sub

    Private Sub Read_Changelog()
        Dim strBuffer As String = ""
        Dim strVersion As String = ""
        Dim strDatum As String = ""
        Dim strText As String = ""

        If System.IO.File.Exists(_strDateiAenderung) Then
            _srAenderung = New System.IO.StreamReader(_strDateiAenderung)

            strBuffer = _srAenderung.ReadLine

            While Not strBuffer Is Nothing
                'Neue Version
                If strBuffer.Substring(0, 1) = "!" Then

                    If Not strText = "" Then
                        oAenderungZ.strAenderung = strText
                        oAenderungL.Add(oAenderungZ)
                    End If

                    strVersion = strBuffer.Split("!")(1).Split("|")(0)
                    strDatum = strBuffer.Split("|")(1)

                    oAenderungZ = New sAenderung(strVersion, strDatum)

                    strVersion = ""
                    strDatum = ""
                    strText = ""

                    'Versionstext
                Else
                    strText = strText + strBuffer + vbNewLine
                End If

                strBuffer = _srAenderung.ReadLine
            End While

            oAenderungZ.strAenderung = strText
            oAenderungL.Add(oAenderungZ)

        End If

        'Buttons aktivieren
        Aenderung_anzeigen()
        Buttons_aktivieren()

    End Sub

    Private Sub Aenderung_anzeigen()
        If oAenderungL.Count > 0 Then
            txtVersion.Text = oAenderungL(_i).strVersion
            txtDatum.Text = oAenderungL(_i).strDatum
            txtAnderung.Text = oAenderungL(_i).strAenderung
        End If
    End Sub

    Private Sub Buttons_aktivieren()
        If oAenderungL.Count > 0 Then
            btnAnfang.Enabled = True
            btnEnde.Enabled = True
            btnVor.Enabled = True
            btnZuruck.Enabled = True
            If _i = 0 Then
                btnAnfang.Enabled = False
                btnZuruck.Enabled = False
            End If

            If _i = oAenderungL.Count - 1 Then
                btnEnde.Enabled = False
                btnVor.Enabled = False
            End If
        End If
    End Sub

#End Region

    Private Sub btnVor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVor.Click
        _i += 1
        Aenderung_anzeigen()
        Buttons_aktivieren()
    End Sub

    Private Sub btnZuruck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZuruck.Click
        _i -= 1
        Aenderung_anzeigen()
        Buttons_aktivieren()
    End Sub

    Private Sub btnEnde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnde.Click
        _i = oAenderungL.Count - 1
        Aenderung_anzeigen()
        Buttons_aktivieren()
    End Sub

    Private Sub btnAnfang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnfang.Click
        _i = 0
        Aenderung_anzeigen()
        Buttons_aktivieren()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub
End Class