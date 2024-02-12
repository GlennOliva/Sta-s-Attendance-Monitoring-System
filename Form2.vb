Imports MySql.Data.MySqlClient
Imports System.IO

Public Class form2
    Dim dt As DataTable



    Private Sub btn_backlog_Click(sender As Object, e As EventArgs) Handles btn_backlog.Click
        Me.Hide()
        Form1.Show()
        lbl_staid.Text = ""
        lbl_studentname.Text = ""
        image_display.Image = My.Resources.University_of_Mindanao_Logo1
        txt_studentID.Clear()
        txt_studentID.Focus()
        Label2.Text = ""
    End Sub

    Private Sub form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbcon()
        txt_studentID.Focus()

    End Sub

    Private Sub btn_timeinout_Click(sender As Object, e As EventArgs) Handles btn_timeinout.Click

        con.Open()
        Try

            ' Check if student ID is entered
            If txt_studentID.Text = String.Empty Then
                Label2.Text = "Enter Student ID"
                Label2.ForeColor = Color.Orange
            Else
                ' Check if student exists in database
                command_handler = New MySqlCommand("SELECT * FROM tbl_studentreg WHERE student_id = @student_id", con)
                command_handler.Parameters.Clear()
                command_handler.Parameters.AddWithValue("@student_id", txt_studentID.Text)
                datadapter = New MySqlDataAdapter
                dt = New DataTable
                datadapter.SelectCommand = command_handler
                datadapter.Fill(dt)

                ' If student exists, check if they have already timed in/out for the day
                If dt.Rows.Count > 0 Then
                    command_handler = New MySqlCommand("SELECT * FROM tbl_starecord where student_id = @student_id AND attendate=@attendate AND outstatus=@outstatus AND instatus=@instatus", con)
                    command_handler.Parameters.Clear()
                    command_handler.Parameters.AddWithValue("@student_id", txt_studentID.Text)
                    command_handler.Parameters.AddWithValue("@attendate", Date.Now.ToString("dd/MM/yyyy"))
                    command_handler.Parameters.AddWithValue("@outstatus", "TIME OUT")
                    command_handler.Parameters.AddWithValue("@instatus", "TIME IN")
                    datadapter = New MySqlDataAdapter
                    dt = New DataTable
                    datadapter.SelectCommand = command_handler
                    datadapter.Fill(dt)

                    ' If student has already timed in/out for the day, display message
                    If dt.Rows.Count > 0 Then
                        Label2.Text = "Already Time IN/OUT!"
                        Label2.ForeColor = Color.Orange


                        ' If student has not timed in/out for the day, check if they have timed in
                    Else
                        command_handler = New MySqlCommand("SELECT * FROM tbl_starecord WHERE student_id=@student_id AND attendate = @attendate AND instatus = @instatus", con)
                        command_handler.Parameters.Clear()
                        command_handler.Parameters.AddWithValue("@student_id", txt_studentID.Text)
                        command_handler.Parameters.AddWithValue("@attendate", Date.Now.ToString("dd/MM/yyyy"))
                        command_handler.Parameters.AddWithValue("@instatus", "TIME IN")
                        datadapter = New MySqlDataAdapter
                        dt = New DataTable
                        datadapter.SelectCommand = command_handler
                        datadapter.Fill(dt)

                        ' If student has timed in, update their time out and work hours
                        If dt.Rows.Count > 0 Then
                            command_handler = New MySqlCommand("UPDATE tbl_starecord SET timeout=@timeout,`outstatus`=@outstatus , workhours=@workhours WHERE student_id = @student_id AND attendate = @attendate", con)
                            command_handler.Parameters.Clear()
                            command_handler.Parameters.AddWithValue("@timeout", Date.Now.ToString("hh:mm:ss tt"))
                            command_handler.Parameters.AddWithValue("@outstatus", "TIME OUT")
                            command_handler.Parameters.AddWithValue("@student_id", txt_studentID.Text)
                            command_handler.Parameters.AddWithValue("@attendate", Date.Now.ToString("dd/MM/yyyy"))
                            Dim timeIn As DateTime = DateTime.Parse(dt.Rows(0)("time_in").ToString())
                            Dim timeOut As DateTime = DateTime.Parse(Date.Now.ToString("hh:mm:ss tt"))
                            Dim workHours As TimeSpan = timeOut - timeIn
                            command_handler.Parameters.AddWithValue("@workhours", workHours.ToString("hh\:mm\:ss"))

                            ' If update is successful, display success message
                            i = command_handler.ExecuteNonQuery
                            If i > 0 Then
                                Label2.Text = "Time Out Success"
                                Label2.ForeColor = Color.LimeGreen


                            Else
                                Label2.Text = "Time Out Failed"
                                Label2.ForeColor = Color.DarkRed
                            End If


                            ' If the student ID is found in the database
                            ' Create a new SQL command to insert the student's attendance record into the database

                        Else
                            command_handler = New MySqlCommand("INSERT INTO `tbl_starecord`( `student_id`,  `attendate`, `time_in`, `instatus` ) VALUES (@student_id,@attendate,@time_in,@instatus) ", con)
                            command_handler.Parameters.Clear()
                            command_handler.Parameters.AddWithValue("@student_id", txt_studentID.Text)
                            command_handler.Parameters.AddWithValue("@attendate", Date.Now.ToString("dd/MM/yyyy"))
                            command_handler.Parameters.AddWithValue("@time_in", Date.Now.ToString("hh:mm:ss tt"))
                            command_handler.Parameters.AddWithValue("@instatus", "TIME IN")

                            ' Execute the SQL command and get the number of rows affected
                            i = command_handler.ExecuteNonQuery

                            ' If at least one row is affected, display a success message and change the label color to green
                            If i > 0 Then
                                Label2.Text = "Time In Success"
                                Label2.ForeColor = Color.LimeGreen

                            Else
                                Label2.Text = "Time In Failed"
                                Label2.ForeColor = Color.DarkRed
                            End If

                            ' Call the imageload function to update the image display
                            imageload()

                        End If

                    End If


                Else
                    Label2.Text = "STA'S NOT FOUND"
                    Label2.ForeColor = Color.Orange


                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        txt_studentID.Clear()
        txt_studentID.Focus()

    End Sub

    Public Sub imageload()


        Dim picture() As Byte ' Change the data type from Byte to Byte()
        image_display.Image = Nothing
        Try
            Dim command_handler As New MySqlCommand("SELECT * FROM tbl_studentreg WHERE student_id = @student_id", con)
            command_handler.Parameters.Clear()
            command_handler.Parameters.AddWithValue("@student_id", txt_studentID.Text)
            datadapter = New MySqlDataAdapter
            dt = New DataTable
            datadapter.SelectCommand = command_handler
            datadapter.Fill(dt)

            lbl_staid.Text = "STA'S NO: " & dt.Rows(0).Item("student_id")
            lbl_studentname.Text = "STA'S NAME  : " & dt.Rows(0).Item("name")
            picture = dt.Rows(0).Item("img")
            Dim mstream As New System.IO.MemoryStream(picture)
            image_display.Image = Image.FromStream(mstream)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_time.Text = Date.Now.ToString("hh:mm:ss tt  dd-MMMM-yyyy")
    End Sub


End Class