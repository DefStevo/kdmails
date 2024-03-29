﻿#Region "Imports"
Imports System.Data.OleDb

#End Region

Public Class clsDatenbank

#Region "Deklarationen"
    Private _oraConn As OleDbConnection
    Private _oraCommand As OleDbCommand
    Private _oraDataReader As OleDbDataReader
    Private _bConnStatus As Boolean = False

    Private _strServer As String
    Private _strDB As String
    Private _strUser As String
    Private _strPass As String
    Private _strSQL As String

    Public oReader As OleDbDataReader
#End Region

#Region "Properties"
    Property Server() As String
        Get
            Return _strServer
        End Get
        Set(ByVal value As String)
            _strServer = value
        End Set
    End Property

    Property DB() As String
        Get
            Return _strDB
        End Get
        Set(ByVal value As String)
            _strDB = value
        End Set
    End Property

    Property User() As String
        Get
            Return _strUser
        End Get
        Set(ByVal value As String)
            _strUser = value
        End Set
    End Property

    Property Pass() As String
        Get
            Return _strPass
        End Get
        Set(ByVal value As String)
            _strPass = value
        End Set
    End Property

    ReadOnly Property RS() As OleDbDataReader
        Get
            Return _oraDataReader
        End Get
    End Property

    ReadOnly Property Status As Boolean
        Get
            Return _bConnStatus
        End Get
    End Property

#End Region

#Region "Funktionen"
    Function SetConnectionInfo(ByVal Server As String, ByVal Datenbank As String, ByVal Benutzer As String, ByVal Kennwort As String) As Boolean
        'Prüfen ob die Verbindung bereits besteht
        If _bConnStatus = True Then
            Return False
        End If
        _strServer = Server
        _strDB = Datenbank
        _strUser = Benutzer
        _strPass = Kennwort
        _bConnStatus = False
        Return True
    End Function

    Function GetConnectionInfo(ByRef Server As String, ByRef Datenbank As String, ByRef Benutzer As String, ByRef Kennwort As String, ByRef Status As Boolean) As Boolean
        Server = _strServer
        Datenbank = _strDB
        Benutzer = _strUser
        Kennwort = _strPass
        Status = _bConnStatus
    End Function

    Function ConnectDB() As String
        'Connection Status prüfen ob Verbindung bereits besteht
        If _bConnStatus = True Then
            DisconnectDB()
        End If

        'Prüfen ob alle Parameter vorhanden sind
        If _strServer = "" Or _strDB = "" Or _strUser = "" Or _strPass = "" Then
            Return False
        End If

        _oraConn = New OleDbConnection("Provider=MSDAORA.1" & _
                                       ";Data Source=" & _strServer & _
                                       ";Database=" & _strDB & _
                                       ";User ID=" & _strUser & _
                                       ";Password=" & _strPass)
        Try
            _oraConn.Open()
        Catch ex As System.Data.OleDb.OleDbException
            Select Case ex.ErrorCode
                Case -2147467259
                    'Provider nicht installiert

                Case Else
                    MsgBox("Fehler: " & ex.ToString & vbCrLf & vbCrLf & _
                   "Server: " & _strServer & vbCrLf & _
                   "Datebank: " & _strDB & vbCrLf & _
                   "Benutzer: " & _strUser, MsgBoxStyle.Critical, "Fehler bei der Verbindung zur Datenbank")
            End Select

            _bConnStatus = False
            Return "Keine Verbindung zur Datenbank " & _strDB & "@" & _strServer
        End Try

        _bConnStatus = True
        Return "Verbunden mit Datenbank " & _strDB & "@" & _strServer
    End Function

    Function DisconnectDB() As Boolean
        If _bConnStatus = True Then
            _oraConn.Close()
            _oraCommand = Nothing
            _oraDataReader = Nothing
            _oraConn = Nothing
            _strServer = Nothing
            _strDB = Nothing
            _strUser = Nothing
            _strPass = Nothing
            _strSQL = Nothing
            _bConnStatus = False
            Return True
        End If
    End Function

    Function OpenRS(ByVal SQL As String) As OleDbDataReader
        If _bConnStatus = True Then
            _oraCommand = New OleDbCommand(SQL, _oraConn)
            Return _oraCommand.ExecuteReader
        Else
            ConnectDB()
            If _bConnStatus = False Then
                Return Nothing
            Else
                Return OpenRS(SQL)
            End If
        End If
    End Function

#End Region

End Class
