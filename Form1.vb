Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Form1


    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            txt_password.PasswordChar = ""

        Else
            txt_password.PasswordChar = "*"
        End If
    End Sub

    'Private Sub btn_adminlog_Click(sender As Object, e As EventArgs) Handles btn_adminlog.Click
    '    Dim username, password As String

    '    username = txt_username.Text
    '    password = txt_password.Text


    '    Try
    '        con.Open()
    '        Dim command_handler As New MySqlCommand("SELECT * FROM `tbl_studentreg` WHERE `username`=@username AND `password`=@password", con)
    '        command_handler.Parameters.Clear()
    '        command_handler.Parameters.AddWithValue("@username", txt_username.Text)
    '        command_handler.Parameters.AddWithValue("@password", txt_password.Text)
    '        Dim count As Integer = command_handler.ExecuteScalar()

    '        If count > 0 Then
    '            MsgBox("Login successful!", vbInformation)
    '            Me.Hide()
    '            form2.Show()
    '        ElseIf username = "admin" And password = "admin123" Then
    '            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Me.Hide()
    '            Admin_page.Show()

    '        Else
    '            MsgBox("Invalid username or password.", vbExclamation)
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    con.Close()


    'End Sub

    Private Sub btn_adminlog_Click(sender As Object, e As EventArgs) Handles btn_adminlog.Click
        Dim username, password As String

        username = txt_username.Text
        password = txt_password.Text

        Try
            con.Open()
            Dim command_handler As New MySqlCommand("SELECT * FROM `tbl_studentreg` WHERE `username`=@username AND `password`=@password", con)
            command_handler.Parameters.Clear()
            command_handler.Parameters.AddWithValue("@username", txt_username.Text)
            command_handler.Parameters.AddWithValue("@password", txt_password.Text)
            Dim reader As MySqlDataReader = command_handler.ExecuteReader()

            If reader.Read() Then
                If reader("status") = "Active" Then
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txt_username.Text = ""
                    txt_password.Text = ""
                    Me.Hide()
                    form2.Show()
                Else
                    MsgBox("Sorry you're account is Inactive!", vbExclamation)
                End If
            ElseIf username = "admin" And password = "admin123" Then
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Admin_page.Show()
                txt_username.Text = ""
                txt_password.Text = ""
            Else
                MsgBox("Invalid username or password.", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbcon()

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()

    End Sub


End Class
