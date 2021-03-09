Imports MySql.Data.MySqlClient

Public Class AdminLogin
    Dim conn As New MySqlConnection
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Personal_Logincnf.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Welcome.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim comm As New MySqlCommand
        Dim Query As String

        Dim i As Integer
        Try
            conn.Open()
            Query = "select count(*) from admin_login where Username = '" & Username.Text & "' and Password = '" & Password.Text & "'"
            comm = New MySqlCommand(Query, conn)
            i = Convert.ToInt32(comm.ExecuteScalar())
            conn.Dispose()
            If i = 0 Then
                MsgBox("Invalid Username ID or Password!", MsgBoxStyle.Critical, "Error")
                Username.Text = ""
                Password.Text = ""
            ElseIf i = 1 Then
                Welcome_Admin.Show()
                Welcome_Admin.Label2.Text = "'" & Username.Text & "'"
                Me.Hide()
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=Suraj957;database=bank"
        Me.Refresh()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Username.Text = ""
        Password.Text = ""
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class
