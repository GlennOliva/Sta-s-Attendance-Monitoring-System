Public Class loadingscreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_percentprog.Text = pbloading.Value & "%"
        pbloading.Value += 1
        If pbloading.Value > 95 Then
            lbl_context.Text = "Please wait the loading"


        End If

        If pbloading.Value = 100 Then
            lbl_context.Text = "Launching Aplication"
            Form1.Show()
            Me.Hide()
            Timer1.Dispose()
        End If
    End Sub
End Class