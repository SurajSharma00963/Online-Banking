Public Class Start_page

    
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(3)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Welcome.Show()
            Me.Hide()
            Timer1.Stop()
        End If
    End Sub

    Private Sub Start_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
   

    