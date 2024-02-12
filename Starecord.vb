Imports System.IO
Imports System.Threading
Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop.Excel
Imports System.Globalization

Public Class Starecord
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Hide()
        Admin_page.Show()

    End Sub

    Private Sub starecord_load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbcon()
        DataGridView1.RowTemplate.Height = 30
        loadata()



    End Sub


    'Public Sub loadata()
    '    DataGridView1.Rows.Clear()
    '    Try
    '        con.Open()
    '        Dim command_handler As New MySqlCommand("SELECT `student_id`, `attendate`, `time_in`, `instatus`, `timeout`, `outstatus`, `workhours` FROM `tbl_starecord`", con)
    '        datareader = command_handler.ExecuteReader
    '        While datareader.Read = True
    '            DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, datareader.Item("student_id").ToString, datareader.Item("attendate").ToString, datareader.Item("time_in").ToString, datareader.Item("instatus").ToString, datareader.Item("timeout").ToString, datareader.Item("outstatus").ToString, datareader.Item("workhours").ToString)
    '        End While

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    con.Close()
    'End Sub

    Public Sub loadata()
        DataGridView1.Rows.Clear()
        Try
            con.Open()
            Dim command_handler As New MySqlCommand("SELECT s.student_id, r.attendate, r.time_in, r.instatus, r.timeout, r.outstatus, r.workhours FROM tbl_starecord r JOIN tbl_studentreg s ON r.student_id = s.student_id", con)
            datareader = command_handler.ExecuteReader
            While datareader.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, datareader.Item("student_id").ToString, datareader.Item("attendate").ToString, datareader.Item("time_in").ToString, datareader.Item("instatus").ToString, datareader.Item("timeout").ToString, datareader.Item("outstatus").ToString, datareader.Item("workhours").ToString)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub



    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            con.Open()
            Dim command_handler As New MySqlCommand("SELECT * FROM `tbl_starecord` WHERE student_id like  '%" & txt_search.Text & "%'", con)
            datareader = command_handler.ExecuteReader
            While datareader.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, datareader.Item("student_id").ToString, datareader.Item("attendate").ToString, datareader.Item("time_in").ToString, datareader.Item("instatus").ToString, datareader.Item("timeout").ToString, datareader.Item("outstatus").ToString, datareader.Item("workhours").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        con.Close()
    End Sub

    Private Sub btn_excell_Click(sender As Object, e As EventArgs) Handles btn_excell.Click

        ' Create a new instance of Excel application
        Dim excel As New Application

        ' Declare workbook and worksheet variables
        Dim workbook As Workbook
        Dim worksheet As Worksheet

        ' Check if the file already exists
        If System.IO.File.Exists("D:\STA-records.xlsx") Then
            ' If the file exists, open it and add a new worksheet
            workbook = excel.Workbooks.Open("D:\STA-records1.xlsx")
            worksheet = workbook.Worksheets.Add(After:=workbook.Worksheets(workbook.Worksheets.Count))
        Else
            ' If the file doesn't exist, create a new workbook and worksheet
            workbook = excel.Workbooks.Add(Type.Missing)
            worksheet = workbook.Sheets("Sheet1")
        End If

        ' Set the header row text
        Dim headers() As String = {"id", "Student ID", "Attendate", "Time In", "In Status", "Time Out", "Out Status", "Work Hours"}
        For i As Integer = 0 To headers.Length - 1
            worksheet.Cells(1, i + 1) = headers(i)
        Next

        ' Copy DataGridView data to Excel worksheet
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            For j As Integer = 0 To DataGridView1.Columns.Count - 1
                If j = 2 Then ' column index 2 is the Time In column
                    Dim dt As DateTime
                    If DateTime.TryParseExact(DataGridView1(j, i).Value.ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, dt) Then
                        worksheet.Cells(i + 2, j + 1).NumberFormat = "MM/dd/yyyy hh:mm AM/PM"
                        worksheet.Cells(i + 2, j + 1) = dt.ToString("MM/dd/yyyy hh:mm tt")
                    Else
                        worksheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                    End If
                ElseIf j = 4 Then ' column index 4 is the Time Out column
                    Dim dt As DateTime
                    If DateTime.TryParseExact(DataGridView1(j, i).Value.ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, dt) Then
                        worksheet.Cells(i + 2, j + 1).NumberFormat = "MM/dd/yyyy hh:mm AM/PM"
                        worksheet.Cells(i + 2, j + 1) = dt.ToString("MM/dd/yyyy hh:mm tt")
                    Else
                        worksheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                    End If
                Else
                    worksheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                End If
            Next
        Next

        ' Save the workbook and close Excel application
        workbook.SaveAs("D:\STA-records.xlsx")
        workbook.Close()
        excel.Quit()

        MsgBox("Data exported to Excel successfully!")


    End Sub


End Class