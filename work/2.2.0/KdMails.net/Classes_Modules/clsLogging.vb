#Region "Imports"
Imports System.Xml

#End Region

Public Class clsLogging

#Region "Strukturen"
    Structure sLogHDRInfos
        Const iAttributCount As Integer = 7
        Dim strVersion As String
        Dim strAktueller_Lauf As String
        Dim strLetzter_Lauf As String
        Dim strAnzahl_Ungelesen As String
        Dim strAnzahl_Ungelesen_Neu As String
        Dim strAnzahl_Posteingang As String
        Dim strAnzahl_Postausgang As String

        Sub New(ByVal eName As ELogHDRInfos)
            If eName = ELogPOSInfos.None Then
                strVersion = ""
                strAktueller_Lauf = ""
                strLetzter_Lauf = ""
                strAnzahl_Ungelesen = ""
                strAnzahl_Ungelesen_Neu = ""
                strAnzahl_Posteingang = ""
                strAnzahl_Postausgang = ""
            End If
        End Sub

        Sub SetInfo(ByVal eName As ELogHDRInfos, ByVal value As String)
            Select Case eName
                Case ELogHDRInfos.Version
                    strVersion = value
                Case ELogHDRInfos.Aktueller_Lauf
                    strAktueller_Lauf = value
                Case ELogHDRInfos.Letzter_Lauf
                    strLetzter_Lauf = value
                Case ELogHDRInfos.Anzahl_Ungelesen
                    strAnzahl_Ungelesen = value
                Case ELogHDRInfos.Anzahl_Ungelesen_Neu
                    strAnzahl_Ungelesen_Neu = value
                Case ELogHDRInfos.Anzahl_Posteingang
                    strAnzahl_Posteingang = value
                Case ELogHDRInfos.Anzahl_Postausgang
                    strAnzahl_Postausgang = value
            End Select

        End Sub

        Sub SetInfo(ByVal Name As String, ByVal Value As String)
            Select Case Name
                Case ELogHDRInfos.Version.ToString
                    strVersion = Value
                Case ELogHDRInfos.Aktueller_Lauf.ToString
                    strAktueller_Lauf = Value
                Case ELogHDRInfos.Letzter_Lauf.ToString
                    strLetzter_Lauf = Value
                Case ELogHDRInfos.Anzahl_Ungelesen.ToString
                    strAnzahl_Ungelesen = Value
                Case ELogHDRInfos.Anzahl_Ungelesen_Neu.ToString
                    strAnzahl_Ungelesen_Neu = Value
                Case ELogHDRInfos.Anzahl_Posteingang.ToString
                    strAnzahl_Posteingang = Value
                Case ELogHDRInfos.Anzahl_Postausgang.ToString
                    strAnzahl_Postausgang = Value
            End Select

        End Sub

        Function GetInfo(ByVal eName As ELogHDRInfos) As String
            Select Case eName
                Case ELogHDRInfos.Version
                    Return strVersion
                Case ELogHDRInfos.Aktueller_Lauf
                    Return strAktueller_Lauf
                Case ELogHDRInfos.Letzter_Lauf
                    Return strLetzter_Lauf
                Case ELogHDRInfos.Anzahl_Ungelesen
                    Return strAnzahl_Ungelesen
                Case ELogHDRInfos.Anzahl_Ungelesen_Neu
                    Return strAnzahl_Ungelesen_Neu
                Case ELogHDRInfos.Anzahl_Posteingang
                    Return strAnzahl_Posteingang
                Case ELogHDRInfos.Anzahl_Postausgang
                    Return strAnzahl_Postausgang
                Case Else
                    Return Nothing
            End Select
        End Function
    End Structure

    Structure sLogPOSInfos
        Const iAttributCount As Integer = 10
        Dim strZeit As String
        Dim strEA As String
        Dim strMail As String
        Dim strMailADR As String
        Dim strMailEID As String
        Dim strOrdner As String
        Dim strOrdnerEID As String
        Dim strOrdnerSID As String
        Dim strKopieren As String
        Dim strIgnorieren As String

        Sub New(ByVal eName As ELogPOSInfos)
            If eName = ELogPOSInfos.None Then
                strZeit = Nothing
                strEA = Nothing
                strMail = Nothing
                strMailADR = Nothing
                strMailEID = Nothing
                strOrdner = Nothing
                strOrdnerEID = Nothing
                strOrdnerSID = Nothing
                strKopieren = Nothing
                strIgnorieren = Nothing
            End If
        End Sub

        Sub SetInfo(ByVal eName As ELogPOSInfos, ByVal Value As String)
            Select Case eName
                Case ELogPOSInfos.Zeit
                    strZeit = Value
                Case ELogPOSInfos.EA
                    strEA = Value
                Case ELogPOSInfos.Mail
                    strMail = Value
                Case ELogPOSInfos.MailADR
                    strMailADR = Value
                Case ELogPOSInfos.MailEID
                    strMailEID = Value
                Case ELogPOSInfos.Ordner
                    strOrdner = Value
                Case ELogPOSInfos.OrdnerEID
                    strOrdnerEID = Value
                Case ELogPOSInfos.OrdnerSID
                    strOrdnerSID = Value
                Case ELogPOSInfos.Kopieren
                    strKopieren = Value
                Case ELogPOSInfos.Ignorieren
                    strIgnorieren = Value
            End Select
        End Sub

        Sub SetInfo(ByVal eName As String, ByVal Value As String)
            Select Case eName
                Case ELogPOSInfos.Zeit.ToString
                    strZeit = Value
                Case ELogPOSInfos.EA.ToString
                    strEA = Value
                Case ELogPOSInfos.Mail.ToString
                    strMail = Value
                Case ELogPOSInfos.MailADR.ToString
                    strMailADR = Value
                Case ELogPOSInfos.MailEID.ToString
                    strMailEID = Value
                Case ELogPOSInfos.Ordner.ToString
                    strOrdner = Value
                Case ELogPOSInfos.OrdnerEID.ToString
                    strOrdnerEID = Value
                Case ELogPOSInfos.OrdnerSID.ToString
                    strOrdnerSID = Value
                Case ELogPOSInfos.Kopieren.ToString
                    strKopieren = Value
                Case ELogPOSInfos.Ignorieren.ToString
                    strIgnorieren = Value
            End Select
        End Sub

        Function GetInfo(ByVal eName As ELogPOSInfos) As String
            Select Case eName
                Case ELogPOSInfos.Zeit
                    Return strZeit
                Case ELogPOSInfos.EA
                    Return strEA
                Case ELogPOSInfos.Mail
                    Return strMail
                Case ELogPOSInfos.MailADR
                    Return strMailADR
                Case ELogPOSInfos.MailEID
                    Return strMailEID
                Case ELogPOSInfos.Ordner
                    Return strOrdner
                Case ELogPOSInfos.OrdnerEID
                    Return strOrdnerEID
                Case ELogPOSInfos.OrdnerSID
                    Return strOrdnerSID
                Case ELogPOSInfos.Kopieren
                    Return strKopieren
                Case ELogPOSInfos.Ignorieren
                    Return strIgnorieren
                Case Else
                    Return Nothing
            End Select
        End Function

    End Structure

#End Region

#Region "Enum"
    Public Enum ELogHDRInfos
        None = 0
        Version = 1
        Aktueller_Lauf = 2
        Letzter_Lauf = 3
        Anzahl_Ungelesen = 4
        Anzahl_Ungelesen_Neu = 5
        Anzahl_Posteingang = 6
        Anzahl_Postausgang = 7
    End Enum

    Public Enum ELogPOSInfos
        None = 0
        Zeit = 1
        EA = 2
        Mail = 3
        MailADR = 4
        MailEID = 5
        Ordner = 6
        OrdnerEID = 7
        OrdnerSID = 8
        Kopieren = 9
        Ignorieren = 10
    End Enum

#End Region

#Region "Deklarationen"
    Private _strLogPfad As String = My.Application.Info.DirectoryPath & "\LOG\"
    Private _strLogdatei As String = ""

    Private _XMLReader As XmlReader
    Private _XMLWriter As XmlTextWriter

    Public oLogHDRInfosL As List(Of sLogHDRInfos)
    Private oLogHDRInfosZ As sLogHDRInfos

    Public oLogPOSInfosL As List(Of sLogPOSInfos)
    Private oLogPOSInfosZ As sLogPOSInfos

    Private _bInitStatus As Boolean

#End Region

#Region "Funktionen"
    Function InitLOG() As Boolean
        If Not _bInitStatus Then
            oLogHDRInfosL = New List(Of sLogHDRInfos)
            oLogHDRInfosZ = Nothing
            oLogPOSInfosL = New List(Of sLogPOSInfos)
            oLogPOSInfosZ = Nothing
            _bInitStatus = True

        End If

        Return True

    End Function

#Region "Datei Funktionen"
    Function ReadLog(ByVal LogDatei As String) As Boolean
        InitLOG()

        'Prüfen ob Datei vorhanden
        If System.IO.File.Exists(LogDatei) Then
            '_XMLReader zum Auslesen verwenden
            _XMLReader = New XmlTextReader(LogDatei)

            With _XMLReader
                Do While .Read 'Es sind Daten zum Lesen vorhanden
                    Select Case .NodeType 'Welche Art von Node wird gelesen
                        Case XmlNodeType.Element
                            If .Name = "HEADER" Then 'Protokollkopfeintrag
                                'Neuer Protokollkopfeintrag
                                oLogHDRInfosZ = New sLogHDRInfos(ELogHDRInfos.None)
                            ElseIf .Name = "INFOS" Then 'Protokolleintrag
                                'Neue Log Zeile
                                oLogPOSInfosZ = New sLogPOSInfos(ELogPOSInfos.None)
                            End If

                            If .Name = "HDR" Then 'Header Informationen lesen
                                If .AttributeCount > 0 Then 'Element hat mehrere Attribute
                                    While .MoveToNextAttribute 'Attribute lesen
                                        oLogHDRInfosZ.SetInfo(.Name, .Value) 'Attribute hinzufügen
                                    End While

                                End If
                            ElseIf .Name = "POS" Then 'Details zu ProtokollEinträge
                                If .AttributeCount > 0 Then 'Element hat mehrere Attribute
                                    While .MoveToNextAttribute 'Attribute lesen
                                        oLogPOSInfosZ.SetInfo(.Name, .Value)
                                    End While
                                End If
                            End If

                        Case XmlNodeType.EndElement
                            If .Name = "HEADER" Then 'Ende Protokollkopfeintrag
                                'Objekt in Auflistung übernehmen
                                oLogHDRInfosL.Add(oLogHDRInfosZ)
                            ElseIf .Name = "INFOS" Then 'Ende Protokolleintrag
                                'Objekt in Auflistung übernehmen
                                oLogPOSInfosL.Add(oLogPOSInfosZ)
                            End If
                    End Select

                Loop

                .Close()

            End With

        Else
            Return False

        End If
    End Function

    Function WriteLog(ByVal LogDatei As String) As Boolean
        'Prüfen ob Datei vorhanden
        If System.IO.File.Exists(_strLogPfad & LogDatei) Then
            System.IO.File.Delete(_strLogPfad & LogDatei)
        End If

        '_XMLReader zum Auslesen verwenden
        Dim enc As New System.Text.UnicodeEncoding
        _XMLWriter = New XmlTextWriter(_strLogPfad & LogDatei, enc)

        With _XMLWriter
            ' Formatierung: 4er-Einzüge verwenden 
            .Formatting = Xml.Formatting.Indented
            .Indentation = 4

            ' Dann fangen wir mal an: 
            .WriteStartDocument()

            'Element für LOG Eintrag schreiben
            .WriteStartElement("LOG")

            For i As Integer = 0 To oLogHDRInfosL.Count - 1
                oLogHDRInfosZ = New sLogHDRInfos
                oLogHDRInfosZ = oLogHDRInfosL(i)

                'Element für HEADER Eintrag schreiben
                .WriteStartElement("HEADER")

                'Element für HEADER Eintrag schreiben
                .WriteStartElement("HDR")

                'Einträg Schreiben
                For i2 As Integer = 1 To sLogHDRInfos.iAttributCount
                    'Attribute für HDR schreiben
                    .WriteAttributeString([Enum].GetName(GetType(ELogHDRInfos), i2), oLogHDRInfosZ.GetInfo(i2))
                Next

                'HDR Element schließen
                .WriteEndElement()

                'HEADER Element schließen
                .WriteEndElement()
            Next

            For i As Integer = 0 To oLogPOSInfosL.Count - 1
                oLogPOSInfosZ = New sLogPOSInfos
                oLogPOSInfosZ = oLogPOSInfosL(i)

                'Element für INFOS Eintrag schreiben
                .WriteStartElement("INFOS")

                'Element für HEADER Eintrag schreiben
                .WriteStartElement("POS")

                For i2 As Integer = 1 To sLogPOSInfos.iAttributCount
                    'Attribute für HDR schreiben
                    .WriteAttributeString([Enum].GetName(GetType(ELogPOSInfos), i2), oLogPOSInfosZ.GetInfo(i2))
                Next

                'POS Element schließen
                .WriteEndElement()

                'INFOS Element schließen
                .WriteEndElement()

            Next

            'LOG Element schließen
            .WriteEndElement()


            'Schreibvorgang abschließen
            .Close()

        End With


    End Function

#End Region

#End Region

End Class
