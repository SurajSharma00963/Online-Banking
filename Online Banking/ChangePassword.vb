Imports MySql.Data.MySqlClient
Public Class ChangePassword
    Dim conn As New MySqlConnection
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim comm As New MySqlCommand
        Dim Query As String


        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Query = "update bank.Customer_Database set password= '" & password.Text & "'  where account_no='" & AccountNo.Text & "' "
            comm = New MySqlCommand(Query, conn)
            reader = comm.ExecuteReader()
            conn.Dispose()
            Dim a, b As String
            a = password.Text
            b = rpassword.Text
            If (a = b) Then
                MsgBox("Password Successfully changed")
            Else
                MsgBox("password does not match")
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub AccountNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AccountNo.KeyPress
        AccountNo.MaxLength = 8
        If e.KeyChar > "10" And (e.KeyChar < "0" Or e.KeyChar > "9") Then
            e.Handled = True
        End If
    End Sub

    

    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=Suraj957;database=bank"
    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged

    End Sub
End Class