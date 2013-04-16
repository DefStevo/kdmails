Public Class clsConfig

#Region "Const"
    Private Const _strNone = "Kein"

#End Region

#Region "Strukturen"
    Structure sOrdner
        Dim strName As String
        Dim strEID As String
        Dim strSID As String

        Sub New(ByVal Name As String, ByVal EID As String, ByVal SID As String)
            strName = Name
            strEID = EID
            strSID = SID
        End Sub
    End Structure

    Structure sDomäne
        Dim strDomäne As String
        Dim strKunde As String
        Dim strOrdner As sOrdner

        Sub New(ByVal Domäne As String, ByVal Kunde As String, ByVal Ordner As String, ByVal EID As String, ByVal SID As String)
            strDomäne = Domäne
            strKunde = Kunde
            strOrdner.strName = Ordner
            strOrdner.strEID = EID
            strOrdner.strSID = SID
        End Sub
    End Structure

    Structure sIgnore
        Dim strDomäne As String

        Sub New(ByVal Domäne As String)
            strDomäne = Domäne
        End Sub
    End Structure
#End Region

#Region "Deklarationen"
    Private _strDateiOrdner As String = My.Application.Info.DirectoryPath & "\Config\KdMails.Ordner.cfg"
    Private _strDateiDomäne As String = My.Application.Info.DirectoryPath & "\Config\KdMails.Domänen.cfg"
    Private _strDateiIgnore As String = My.Application.Info.DirectoryPath & "\Config\KdMails.Ignore.cfg"
    Private _srOrdner As System.IO.StreamReader
    Private _swOrdner As System.IO.StreamWriter
    Private _srDomäne As System.IO.StreamReader
    Private _swDomäne As System.IO.StreamWriter
    Private _srIgnore As System.IO.StreamReader
    Private _swIgnore As System.IO.StreamWriter

    Private _bInitStatus As Boolean

    Public oOrdnerL As List(Of sOrdner)
    Private oOrdnerZ As sOrdner
    Public oDomänenL As List(Of sDomäne)
    Private oDomänenZ As sDomäne
    Public oIgnoreL As List(Of sIgnore)
    Private oIgnoreZ As sIgnore

#End Region

#Region "Funktionen"
    Function InitConfig(ByVal Ordner As Boolean, ByVal Domänen As Boolean, ByVal IgnoreList As Boolean) As Boolean
        If Ordner = True Then
            oOrdnerL = New List(Of sOrdner)
            If ReadConfigFolder() = False Then
                MsgBox("Datei kann nicht gelesen werden" & vbCrLf & _
                       _strDateiOrdner, MsgBoxStyle.Critical, "Fehler beim Lesen der Konfiguration")
            End If

        End If

        If Domänen = True Then
            oDomänenL = New List(Of sDomäne)
            If ReadConfigDomain() = False Then
                MsgBox("Datei kann nicht gelesen werden" & vbCrLf & _
                       _strDateiDomäne, MsgBoxStyle.Critical, "Fehler beim Lesen der Konfiguration")
            End If

        End If

        If IgnoreList = True Then
            oIgnoreL = New List(Of sIgnore)
            If ReadConfigIgnore() = False Then
                MsgBox("Datei kann nicht gelesen werden" & vbCrLf & _
                       _strDateiIgnore, MsgBoxStyle.Critical, "Fehler beim Lesen der Konfiguration")
            End If

        End If

        _bInitStatus = True

        Return True
    End Function

    Function UnloadConfig() As Boolean
        If _bInitStatus = True Then
            _strDateiOrdner = Nothing
            _strDateiDomäne = Nothing
            _strDateiIgnore = Nothing
            _srDomäne = Nothing
            _srOrdner = Nothing
            _swDomäne = Nothing
            _swOrdner = Nothing
            _srIgnore = Nothing
            _swIgnore = Nothing
            oOrdnerL = Nothing
            oOrdnerZ = Nothing
            oDomänenL = Nothing
            oDomänenZ = Nothing
            oIgnoreL = Nothing
            oIgnoreZ = Nothing
            _bInitStatus = False
            Return True
        End If
    End Function

#Region "Datei Funktionen"
    Private Function ReadConfigFolder() As Boolean
        Dim strBuffer As String

        If System.IO.File.Exists(_strDateiOrdner) Then
            _srOrdner = New System.IO.StreamReader(_strDateiOrdner)

            strBuffer = _srOrdner.ReadLine

            While Not strBuffer Is Nothing
                AddFolder(strBuffer.Split(";")(0).ToString, strBuffer.Split(";")(1).ToString, strBuffer.Split(";")(2).ToString)
                strBuffer = _srOrdner.ReadLine
            End While

            _srOrdner.Close()

            Return True
        Else
            Return False
        End If
    End Function

    Private Function ReadConfigDomain() As Boolean
        Dim strBuffer As String

        If System.IO.File.Exists(_strDateiDomäne) Then
            _srDomäne = New System.IO.StreamReader(_strDateiDomäne)

            strBuffer = _srDomäne.ReadLine

            While Not strBuffer Is Nothing
                AddDomain(strBuffer.Split(";")(0).ToString, strBuffer.Split(";")(1).ToString, strBuffer.Split(";")(2).ToString, strBuffer.Split(";")(3).ToString, strBuffer.Split(";")(4).ToString)
                strBuffer = _srDomäne.ReadLine
            End While

            _srDomäne.Close()

            Return True
        Else
            Return False
        End If

    End Function

    Private Function ReadConfigIgnore() As Boolean
        Dim strBuffer As String

        If System.IO.File.Exists(_strDateiIgnore) Then
            _srIgnore = New System.IO.StreamReader(_strDateiIgnore)

            strBuffer = _srIgnore.ReadLine

            While Not strBuffer Is Nothing
                AddIgnoreList(strBuffer)
                strBuffer = _srIgnore.ReadLine
            End While

            _srIgnore.Close()

            Return True

        Else
            Return False
        End If
    End Function

    Function WriteConfigFolder() As Boolean
        Dim strBuffer As String = ""

        If Not System.IO.File.Exists(_strDateiOrdner) Then
            System.IO.File.Create(_strDateiOrdner)
        End If

        _swOrdner = New System.IO.StreamWriter(_strDateiOrdner, False)

        For i As Integer = 0 To oOrdnerL.Count - 1
            strBuffer = strBuffer & _
                        oOrdnerL(i).strName & ";" & _
                        oOrdnerL(i).strEID & ";" & _
                        oOrdnerL(i).strSID & vbCrLf
        Next

        _swOrdner.Write(strBuffer)
        _swOrdner.Flush()
        _swOrdner.Close()

        Return True
    End Function

    Function WriteConfigDomain() As Boolean
        Dim strBuffer As String = ""

        If Not System.IO.File.Exists(_strDateiDomäne) Then
            System.IO.File.Create(_strDateiDomäne)
        End If

        _swDomäne = New System.IO.StreamWriter(_strDateiDomäne, False)

        For i As Integer = 0 To oDomänenL.Count - 1
            If Not oDomänenL(i).strOrdner.strName = _strNone Then
                strBuffer = strBuffer & _
                            oDomänenL(i).strDomäne & ";" & _
                            oDomänenL(i).strKunde & ";" & _
                            oDomänenL(i).strOrdner.strName & ";" & _
                            oDomänenL(i).strOrdner.strEID & ";" & _
                            oDomänenL(i).strOrdner.strSID & vbCrLf

            End If
        Next

        _swDomäne.Write(strBuffer)
        _swDomäne.Flush()
        _swDomäne.Close()

        Return True
    End Function

    Function WriteConfigIgnore() As Boolean
        Dim strBuffer As String = ""

        If Not System.IO.File.Exists(_strDateiIgnore) Then
            System.IO.File.Create(_strDateiIgnore)
        End If

        _swIgnore = New System.IO.StreamWriter(_strDateiIgnore, False)

        For i As Integer = 0 To oIgnoreL.Count - 1
            strBuffer = strBuffer & _
                        oIgnoreL(i).strDomäne & vbCrLf
        Next

        _swIgnore.Write(strBuffer)
        _swIgnore.Flush()
        _swIgnore.Close()

        Return True
    End Function
#End Region

#Region "Ordner Funktionen"
    Function AddFolder(ByVal Name As String, ByVal EID As String, ByVal SID As String) As Boolean
        'Prüfen ob der Ordner bereits in der Liste vorhanden ist
        If SearchFolder(Name, EID, SID) > -1 Then
            Return False
            Exit Function
        End If

        'Objekt in Liste aufnehmen
        oOrdnerZ = New sOrdner(Name, EID, SID)
        oOrdnerL.Add(oOrdnerZ)

        Return True
    End Function

    Function AddFolderToDomain(ByVal Name As String, ByVal EID As String, ByVal SID As String) As Boolean
        If SearchDomain(, Name.Split(" - ")(0).ToString) = -1 Then
            Return False
        End If

        For i As Integer = 0 To oDomänenL.Count - 1
            If oDomänenL(i).strKunde = Name.Split(" - ")(0).ToString Then 'Übereinstimmung gefunden
                EditDomain(i, , Name.Split(" - ")(0).ToString, Name, EID, SID)
            End If
        Next

        Return True
    End Function

    Function RemoveFolder(Optional ByVal Index As Integer = -1, Optional ByVal Name As String = Nothing, Optional ByVal EID As String = Nothing, Optional ByVal SID As String = Nothing) As Boolean
        If Index = -1 Then 'Ordner muss gesucht werden
            Index = SearchFolder(Name, EID, SID)
        End If

        oOrdnerL.RemoveRange(Index, 1)

        Return True
    End Function

    Function GetFolder(ByVal Index As Integer, ByRef Name As String, ByRef EID As String, ByRef SID As String)
        Name = oOrdnerL(Index).strName
        EID = oOrdnerL(Index).strEID
        SID = oOrdnerL(Index).strSID
        Return True
    End Function

    Function SearchFolder(Optional ByVal Name As String = Nothing, Optional ByVal EID As String = Nothing, Optional ByVal SID As String = Nothing) As Integer
        Dim bMatchName As Boolean
        Dim bMatchEID As Boolean
        Dim bMatchSID As Boolean
        'Mindestens 1 Paramter muss angegeben werden
        If Not Name Is Nothing Or _
           Not EID Is Nothing Or _
           Not SID Is Nothing Then
            For i As Integer = 0 To oOrdnerL.Count - 1
                bMatchName = True
                bMatchEID = True
                bMatchSID = True

                If Not Name Is Nothing Then 'Suche nach Name
                    If Not oOrdnerL(i).strName = Name Then
                        bMatchName = False
                    End If
                End If

                If Not EID Is Nothing Then 'Suche nach EID
                    If Not oOrdnerL(i).strEID = EID Then
                        bMatchEID = False
                    End If
                End If

                If Not SID Is Nothing Then 'Suche nach SID
                    If Not oOrdnerL(i).strSID = SID Then
                        bMatchSID = False
                    End If
                End If

                If bMatchName = True And bMatchEID = True And bMatchSID = True Then
                    Return i
                    Exit Function
                End If
            Next

        End If
        Return -1
    End Function

#End Region

#Region "Domänen Funktionn"
    Function AddDomain(ByVal Domäne As String, ByVal Kunde As String, ByVal Ordner As String, ByVal EID As String, ByVal SID As String)
        'Prüfen ob die Domäne bereits in der Liste vorhanden ist
        If SearchDomain(Domäne, Kunde, Ordner, EID, SID) > -1 Then
            Return False
            Exit Function
        End If

        'Objekt in Liste aufnehmen
        oDomänenZ = New sDomäne(Domäne, Kunde, Ordner, EID, SID)
        oDomänenL.Add(oDomänenZ)
        Return True
    End Function

    Function EditDomain(ByVal Index As Integer, Optional ByVal Domäne As String = Nothing, Optional ByVal Kunde As String = Nothing, Optional ByVal Ordner As String = Nothing, Optional ByVal EID As String = Nothing, Optional ByVal SID As String = Nothing) As Boolean
        oDomänenZ.strDomäne = oDomänenL(Index).strDomäne
        oDomänenZ.strKunde = oDomänenL(Index).strKunde
        oDomänenZ.strOrdner.strName = oDomänenL(Index).strOrdner.strName
        oDomänenZ.strOrdner.strEID = oDomänenL(Index).strOrdner.strEID
        oDomänenZ.strOrdner.strSID = oDomänenL(Index).strOrdner.strSID

        If Not Domäne = Nothing Then
            oDomänenZ.strDomäne = Domäne
        End If

        If Not Kunde = Nothing Then
            oDomänenZ.strKunde = Kunde
        End If

        If Not Ordner = Nothing Then
            oDomänenZ.strOrdner.strName = Ordner
        End If

        If Not EID = Nothing Then
            oDomänenZ.strOrdner.strEID = EID
        End If

        If Not SID = Nothing Then
            oDomänenZ.strOrdner.strSID = SID
        End If

        oDomänenL(Index) = oDomänenZ

        Return True
    End Function

    Function RemoveDomain(Optional ByVal Index As Integer = -1, Optional ByVal Domäne As String = Nothing, Optional ByVal Kunde As String = Nothing, Optional ByVal Ordner As String = Nothing, Optional ByVal EID As String = Nothing, Optional ByVal SID As String = Nothing) As Boolean
        If Index = -1 Then 'Ordner muss gesucht werden
            Index = SearchDomain(Domäne, Kunde, Ordner, EID, SID)
        End If

        oDomänenL.RemoveRange(Index, 1)

        Return True
    End Function

    Function GetDomain(ByVal Index As String, ByRef Domäne As String, ByRef Kunde As String, ByRef Ordner As String, ByRef EID As String, ByRef SID As String)
        If Not Index = -1 Then
            Domäne = oDomänenL(Index).strDomäne
            Kunde = oDomänenL(Index).strKunde
            Ordner = oDomänenL(Index).strOrdner.strName
            EID = oDomänenL(Index).strOrdner.strEID
            SID = oDomänenL(Index).strOrdner.strSID
            Return True
        Else
            Domäne = Nothing
            Kunde = Nothing
            Ordner = Nothing
            EID = Nothing
            SID = Nothing
            Return False
        End If

    End Function

    Function SearchDomain(Optional ByVal Domäne As String = Nothing, Optional ByVal Kunde As String = Nothing, Optional ByVal Ordner As String = Nothing, Optional ByVal EID As String = Nothing, Optional ByVal SID As String = Nothing) As Integer
        Dim bMatchDomäne As Boolean
        Dim bMatchKunde As Boolean
        Dim bMatchOrdner As Boolean
        Dim bMatchEID As Boolean
        Dim bMatchSID As Boolean
        'Mindestens 1 Paramter muss angegeben werden
        If Not Domäne Is Nothing Or _
           Not Kunde Is Nothing Or _
           Not Ordner Is Nothing Or _
           Not EID Is Nothing Or _
           Not SID Is Nothing Then
            For i As Integer = 0 To oDomänenL.Count - 1
                bMatchDomäne = True
                bMatchKunde = True
                bMatchOrdner = True
                bMatchEID = True
                bMatchSID = True

                If Not Domäne Is Nothing Then 'Suche nach Domäne
                    If Not oDomänenL(i).strDomäne = Domäne Then
                        bMatchDomäne = False
                    End If
                End If

                If Not Kunde Is Nothing Then 'Suche nach Kunde
                    If Not oDomänenL(i).strKunde = Kunde Then
                        bMatchKunde = False
                    End If
                End If

                If Not Ordner Is Nothing Then 'Suche nach Ordner
                    If Not oDomänenL(i).strOrdner.strName = Ordner Then
                        bMatchOrdner = False
                    End If
                End If

                If Not EID Is Nothing Then 'Suche nach EID
                    If Not oDomänenL(i).strOrdner.strEID = EID Then
                        bMatchEID = False
                    End If
                End If

                If Not SID Is Nothing Then 'Suche nach SID
                    If Not oDomänenL(i).strOrdner.strSID = SID Then
                        bMatchSID = False
                    End If
                End If

                If bMatchDomäne = True And bMatchKunde = True And bMatchOrdner = True And bMatchEID = True And bMatchSID = True Then
                    Return i
                    Exit Function
                End If
            Next

        End If
        Return -1
    End Function
#End Region

#Region "IgnoreListe Funktionen"
    Function AddIgnoreList(ByVal Domäne As String)
        'Prüfen ob die Domäne bereits in der Liste vorhanden ist

        If Domäne Is Nothing Then
            Return False
            Exit Function
        End If

        If SearchIgnoreList(Domäne) > -1 Then
            Return False
            Exit Function
        End If

        'Objeckt in Liste aufnehmen
        oIgnoreZ = New sIgnore(Domäne)
        oIgnoreL.Add(oIgnoreZ)
        Return True
    End Function

    Function SearchIgnoreList(ByVal Domäne As String) As Integer
        Dim bMatchDomäne As Boolean

        If Not Domäne Is Nothing Then
            For i As Integer = 0 To oIgnoreL.Count - 1
                bMatchDomäne = True

                If Not Domäne Is Nothing Then
                    If Not oIgnoreL(i).strDomäne = Domäne Then
                        bMatchDomäne = False
                    End If
                End If

                If bMatchDomäne = True Then
                    Return i
                    Exit Function
                End If
            Next

        End If

        Return -1
    End Function

    Function GetIgnoreList(ByVal Index As Integer, ByRef Domäne As String)
        Domäne = oIgnoreL(Index).strDomäne
        Return True
    End Function

    Function RemoveIgnoreList(Optional ByVal Index As Integer = -1, Optional ByVal Domäne As String = Nothing)
        If Index = -1 Then 'Eintrag muss gesucht werden
            Index = SearchIgnoreList(Domäne)
        End If

        oIgnoreL.RemoveRange(Index, 1)
        Return True
    End Function

#End Region

#End Region


End Class
