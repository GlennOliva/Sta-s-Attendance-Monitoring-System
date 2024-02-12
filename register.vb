Imports MySql.Data.MySqlClient
Imports System.IO

Public Class register
    Private Sub btn_backad_Click(sender As Object, e As EventArgs) Handles btn_backad.Click
        Me.Hide()
        Admin_page.Show()
        Clear()

    End Sub

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbcon()

    End Sub

    Private Sub reg_pic_Click(sender As Object, e As EventArgs) Handles reg_pic.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            reg_pic.Image = Image.FromFile(pop.FileName)
        End If
    End Sub


    Private Sub btn_registersubmit_Click(sender As Object, e As EventArgs) Handles btn_registersubmit.Click
        If String.IsNullOrEmpty(txt_staid.Text) OrElse String.IsNullOrEmpty(txt_name.Text) OrElse String.IsNullOrEmpty(txt_dept.Text) OrElse String.IsNullOrEmpty(txt_course.Text) OrElse String.IsNullOrEmpty(txt_username.Text) OrElse String.IsNullOrEmpty(txt_password.Text) OrElse String.IsNullOrEmpty(datetime.Text) OrElse String.IsNullOrEmpty(datetime1.Text) OrElse String.IsNullOrEmpty(txt_address.Text) OrElse reg_pic.Image Is Nothing Then
            MsgBox("Please complete all details.", vbExclamation)
            Exit Sub
        End If
        Try
            con.Open()
            Dim command_handler As New MySqlCommand("INSERT INTO `tbl_studentreg`(`student_id`, `name`, `department`, `course`, `username`, `password`, `dob`, `doj`, `address`, `img` , `status`) VALUES
            (@student_id,@name,@department,@course,@username,@password,@dob,@doj,@address,@img , @status)", con)
            command_handler.Parameters.Clear()
            command_handler.Parameters.AddWithValue("@student_id", txt_staid.Text)
            command_handler.Parameters.AddWithValue("@name", txt_name.Text)
            command_handler.Parameters.AddWithValue("@department", txt_dept.Text)
            command_handler.Parameters.AddWithValue("@course", txt_course.Text)
            command_handler.Parameters.AddWithValue("@username", txt_username.Text)
            command_handler.Parameters.AddWithValue("@password", txt_password.Text)
            command_handler.Parameters.AddWithValue("@dob", CDate(datetime.Text))
            command_handler.Parameters.AddWithValue("@doj", CDate(datetime1.Text))
            command_handler.Parameters.AddWithValue("@address", txt_address.Text)
            command_handler.Parameters.AddWithValue("@status", "Active")


            Dim Filesize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            reg_pic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            Filesize = mstream.Length
            mstream.Close()

            command_handler.Parameters.AddWithValue("@img", picture)
            i = command_handler.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Successfully  Registered!", vbInformation)
            Else
                MsgBox("Failed to   Registered!", vbExclamation)
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
        datetime.Text = Now
        datetime1.Text = Now
        reg_pic.Image = My.Resources.developer

    End Sub


End Class