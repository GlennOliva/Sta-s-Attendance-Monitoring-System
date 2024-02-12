Imports System.IO
Imports System.Windows.Controls
Imports DocumentFormat.OpenXml.Bibliography
Imports System.Drawing
Imports MySql.Data.MySqlClient

Public Class inforeg
    Private Sub inforeg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dbcon()
        DataGridView2.RowTemplate.Height = 30
        loadata1()
    End Sub

    'Public Sub loadata1()
    '    DataGridView2.Rows.Clear()
    '    Try
    '        con.Open()
    '        Dim command_handler As New MySqlCommand("SELECT  `student_id`, `name`, `department`, `course`, `username`, `password` , `dob` , `doj` , `address` ,  `img` , `status`  FROM `tbl_studentreg`", con)
    '        datareader = command_handler.ExecuteReader
    '        While datareader.Read = True
    '            DataGridView2.Rows.Add(DataGridView2.Rows.Count + 1, datareader.Item("student_id").ToString, datareader.Item("name").ToString, datareader.Item("department").ToString,
    '            datareader.Item("course").ToString, datareader.Item("username").ToString, datareader.Item("password").ToString, datareader.Item("dob").ToString,
    '            datareader.Item("doj").ToString, datareader.Item("address").ToString, datareader.Item("img"), datareader.Item("status").ToString)
    '        End While

    '        For i = 0 To DataGridView2.Rows.Count - 1
    '            Dim r As DataGridViewRow = DataGridView2.Rows(i)
    '            r.Height = 80
    '        Next

    '        Dim imagecolumn = DirectCast(DataGridView2.Columns("Column12"), DataGridViewImageColumn)
    '        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    con.Close()

    'End Sub

    Public Sub loadata1()
        DataGridView2.Rows.Clear()
        Try
            con.Open()
            Dim command_handler As New MySqlCommand("SELECT  `student_id`, `name`, `department`, `course`, `username`, `password` , `dob` , `doj` , `address` ,  `img` , `status`  FROM `tbl_studentreg`", con)
            datareader = command_handler.ExecuteReader
            While datareader.Read = True
                Dim dob As DateTime
                DateTime.TryParse(datareader.Item("dob").ToString(), dob)
                Dim doj As DateTime
                DateTime.TryParse(datareader.Item("doj").ToString(), doj)
                DataGridView2.Rows.Add(DataGridView2.Rows.Count + 1, datareader.Item("student_id").ToString, datareader.Item("name").ToString, datareader.Item("department").ToString,
            datareader.Item("course").ToString, datareader.Item("username").ToString, datareader.Item("password").ToString, dob,
            doj, datareader.Item("address").ToString, datareader.Item("img"), datareader.Item("status").ToString)
            End While

            For i = 0 To DataGridView2.Rows.Count - 1
                Dim r As DataGridViewRow = DataGridView2.Rows(i)
                r.Height = 80
            Next

            Dim imagecolumn = DirectCast(DataGridView2.Columns("Column12"), DataGridViewImageColumn)
            imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub




    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Hide()
        Admin_page.Show()


    End Sub

    Private Sub txt_searchs_TextChanged(sender As Object, e As EventArgs) Handles txt_searchs.TextChanged
        DataGridView2.Rows.Clear()
        Try
            con.Open()
            Dim command_handler As New MySqlCommand("SELECT * FROM `tbl_studentreg` WHERE student_id like  '%" & txt_searchs.Text & "%'", con)
            datareader = command_handler.ExecuteReader
            While datareader.Read = True
                DataGridView2.Rows.Add(DataGridView2.Rows.Count + 1, datareader.Item("student_id").ToString, datareader.Item("name").ToString, datareader.Item("department").ToString, datareader.Item("course").ToString,
                datareader.Item("username").ToString, datareader.Item("password").ToString, datareader.Item("dob").ToString, datareader.Item("doj").ToString, datareader.Item("address").ToString, datareader.Item("img"), datareader.Item("status").ToString)
            End While
            For i = 0 To DataGridView2.Rows.Count - 1
                Dim r As DataGridViewRow = DataGridView2.Rows(i)
                r.Height = 80
            Next

            Dim imagecolumn = DirectCast(DataGridView2.Columns("Column12"), DataGridViewImageColumn)
            imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        con.Close()


    End Sub





    'Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
    '    updateform.txt_id.Text = DataGridView2.CurrentRow.Cells(0).Value.ToString()
    '    updateform.txt_staid.Text = DataGridView2.CurrentRow.Cells(1).Value.ToString()
    '    updateform.txt_name.Text = DataGridView2.CurrentRow.Cells(2).Value.ToString()
    '    updateform.txt_dept.Text = DataGridView2.CurrentRow.Cells(3).Value.ToString()
    '    updateform.txt_course.Text = DataGridView2.CurrentRow.Cells(4).Value.ToString()
    '    updateform.txt_username.Text = DataGridView2.CurrentRow.Cells(5).Value.ToString()
    '    updateform.txt_password.Text = DataGridView2.CurrentRow.Cells(6).Value.ToString()
    '    updateform.txt_dob.Text = DataGridView2.CurrentRow.Cells(7).Value.ToString()
    '    updateform.txt_doj.Text = DataGridView2.CurrentRow.Cells(8).Value.ToString()
    '    updateform.txt_address.Text = DataGridView2.CurrentRow.Cells(9).Value.ToString()
    '    updateform.update_pic.Image = DirectCast(DataGridView2.CurrentRow.Cells(10).Value
    '    updateform.txt_status.Text = DataGridView2.CurrentRow.Cells(11).Value.ToString()

    '    updateform.ShowDialog()

    'End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        updateform.txt_id.Text = DataGridView2.CurrentRow.Cells(0).Value.ToString()
        updateform.txt_staid.Text = DataGridView2.CurrentRow.Cells(1).Value.ToString()
        updateform.txt_name.Text = DataGridView2.CurrentRow.Cells(2).Value.ToString()
        updateform.txt_dept.Text = DataGridView2.CurrentRow.Cells(3).Value.ToString()
        updateform.txt_course.Text = DataGridView2.CurrentRow.Cells(4).Value.ToString()
        updateform.txt_username.Text = DataGridView2.CurrentRow.Cells(5).Value.ToString()
        updateform.txt_password.Text = DataGridView2.CurrentRow.Cells(6).Value.ToString()
        updateform.txt_dob.Text = DataGridView2.CurrentRow.Cells(7).Value.ToString()
        updateform.txt_doj.Text = DataGridView2.CurrentRow.Cells(8).Value.ToString()
        updateform.txt_address.Text = DataGridView2.CurrentRow.Cells(9).Value.ToString()

        ' Load the image from the DataGridView2 and display it in the PictureBox control
        Dim imgData As Byte() = DirectCast(DataGridView2.CurrentRow.Cells(10).Value, Byte())
        Dim ms As New MemoryStream(imgData)
        updateform.update_pic.Image = New Bitmap(ms)

        updateform.txt_status.Text = DataGridView2.CurrentRow.Cells(11).Value.ToString()

        updateform.ShowDialog()
    End Sub


End Class