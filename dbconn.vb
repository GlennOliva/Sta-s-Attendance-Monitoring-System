Imports MySql.Data.MySqlClient
Imports System.IO

Module dbconn

    Public con As New MySqlConnection
    Dim result As Boolean
    Public command_handler As New MySqlCommand
    Public datareader As MySqlDataReader
    Public datadapter As MySqlDataAdapter
    Public i As Integer

    Public Function dbcon() As Boolean
        Try
            If con.State = ConnectionState.Closed Then
                con.ConnectionString = "server = localhost;user= root; password =; port=3306; database= sta_attendance_monitoring;"
                result = True
            End If
        Catch ex As Exception
            result = False
            MsgBox("Server not connected ", vbExclamation)
        End Try
        Return result
    End Function



End Module
