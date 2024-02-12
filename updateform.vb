Imports System.Drawing.Imaging
Imports System.IO
Imports ClosedXML.Excel.XLPredefinedFormat
Imports DocumentFormat.OpenXml.Office2010.Excel
Imports MySql.Data.MySqlClient


Public Class updateform
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Hide()
        Admin_page.Show()

    End Sub

    Private Sub updateform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbcon()


    End Sub

    'Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
    '    Try
    '        con.Open()
    '        Dim command_handler As New MySqlCommand("UPDATE `tbl_studentreg` SET `student_id` = @student_id, `name` = @name, `department` = @department, `course` = @course, `username` = @username, `password` = @password, `dob` = @dob, `doj` = @doj, `address` = @address, `img` = @img, `status` = @status WHERE `id` = @id", con)
    '        command_handler.Parameters.AddWithValue("@student_id", txt_staid.Text)
    '        command_handler.Parameters.AddWithValue("@name", txt_name.Text)
    '        command_handler.Parameters.AddWithValue("@department", txt_dept.Text)
    '        command_handler.Parameters.AddWithValue("@course", txt_course.Text)
    '        command_handler.Parameters.AddWithValue("@username", txt_username.Text)
    '        command_handler.Parameters.AddWithValue("@password", txt_password.Text)
    '        command_handler.Parameters.AddWithValue("@dob", CDate(txt_dob.Text))
    '        command_handler.Parameters.AddWithValue("@doj", CDate(txt_doj.Text))
    '        command_handler.Parameters.AddWithValue("@address", txt_address.Text)
    '        command_handler.Parameters.AddWithValue("@status", txt_status.Text)
    '        command_handler.Parameters.AddWithValue("@id", CInt(txt_id.Text))


    '        Dim Filesize As New UInt32
    '        Dim mstream As New System.IO.MemoryStream
    '        update_pic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
    '        Dim picture() As Byte = mstream.GetBuffer
    '        Filesize = mstream.Length
    '        mstream.Close()

    '        command_handler.Parameters.AddWithValue("@img", picture)
    '        i = command_handler.ExecuteNonQuery()
    '        If i > 0 Then
    '            MsgBox("Successfully  Update!", vbInformation)
    '        Else
    '            MsgBox("Failed to   Update!", vbExclamation)
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)

    '    End Try
    '    con.Close()
    '    Clear()



    'End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            con.Open()

            ' Check if the new student_id already exists in the database
            Dim checkCommand As New MySqlCommand("SELECT COUNT(*) FROM `tbl_studentreg` WHERE `student_id` = @student_id AND `id` <> @id", con)
            checkCommand.Parameters.AddWithValue("@student_id", txt_staid.Text)
            checkCommand.Parameters.AddWithValue("@id", CInt(txt_id.Text))
            Dim count As Integer = CInt(checkCommand.ExecuteScalar())
            If count > 0 Then
                MsgBox("The student ID already exists in the database. Please choose a unique ID.", vbExclamation)
                Return
            End If

            ' If the new student ID is unique, update the record
            Dim updateCommand As New MySqlCommand("UPDATE `tbl_studentreg` SET `student_id` = @student_id, `name` = @name, `department` = @department, `course` = @course, `username` = @username, `password` = @password, `dob` = @dob, `doj` = @doj, `address` = @address, `img` = @img, `status` = @status WHERE `id` = @id", con)
            updateCommand.Parameters.AddWithValue("@student_id", txt_staid.Text)
            updateCommand.Parameters.AddWithValue("@name", txt_name.Text)
            updateCommand.Parameters.AddWithValue("@department", txt_dept.Text)
            updateCommand.Parameters.AddWithValue("@course", txt_course.Text)
            updateCommand.Parameters.AddWithValue("@username", txt_username.Text)
            updateCommand.Parameters.AddWithValue("@password", txt_password.Text)
            updateCommand.Parameters.AddWithValue("@dob", CDate(txt_dob.Text))
            updateCommand.Parameters.AddWithValue("@doj", CDate(txt_doj.Text))
            updateCommand.Parameters.AddWithValue("@address", txt_address.Text)
            updateCommand.Parameters.AddWithValue("@status", txt_status.Text)
            updateCommand.Parameters.AddWithValue("@id", CInt(txt_id.Text))

            Dim Filesize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            update_pic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            Filesize = mstream.Length
            mstream.Close()

            updateCommand.Parameters.AddWithValue("@img", picture)

            Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MsgBox("Record updated successfully!", vbInformation)
            Else
                MsgBox("Failed to update record!", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        Clear()
    End Sub




    Public Sub Clear()
        txt_staid.Clear()
        txt_name.Clear()
        txt_dept.Clear()
        txt_username.Clear()
        txt_password.Clear()
        txt_address.Clear()
        txt_course.Clear()
        txt_dob.Text = Now
        txt_doj.Text = Now
        txt_status.Clear()


    End Sub

    Private Sub update_pic_Click(sender As Object, e As EventArgs) Handles update_pic.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            update_pic.Image = Image.FromFile(pop.FileName)
        End If
    End Sub
End Class