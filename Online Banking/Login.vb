Public Class Login

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Admin.Click
        AdminLogin.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles User.Click
        Personal_Logincnf.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Welcome.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Welcome.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Welcome.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Product_and_Services.Show()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles Staff.Click
        StaffLogin.Show()
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "ADMIN LOGIN" Then
            Admin.Show()
            User.Hide()
            Staff.Hide()
        ElseIf ComboBox1.SelectedItem = "STAFF LOGIN" Then
            Staff.Show()
            User.Hide()
            Admin.Hide()
        ElseIf ComboBox1.SelectedItem = "USER LOGIN" Then
            User.Show()
            Admin.Hide()
            Staff.Hide()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class