Public Class Admin_page

    Private Sub btn_registersta_Click(sender As Object, e As EventArgs) Handles btn_registersta.Click
        Me.Hide()

        register.ShowDialog()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Hide()
        Form1.Show()


    End Sub

    Private Sub btn_record_Click(sender As Object, e As EventArgs) Handles btn_record.Click
        Me.Hide()
        Starecord.ShowDialog()

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Hide()
        inforeg.ShowDialog()



    End Sub
End Class