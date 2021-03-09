Public Class Personal_Logincnf

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Product_and_Services.Show()
    End Sub

    Private Sub Personal_Logincnf_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Welcome.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PersonalLogin.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Welcome.Show()
        Me.Hide()
    End Sub
End Class