Public Class Logout2

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        AdminLogin.Show()
        AdminLogin.Username.Text = ""
        AdminLogin.Password.Text = ""
        Me.Hide()
    End Sub
End Class