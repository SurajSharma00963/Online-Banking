Imports MySql.Data.MySqlClient
Public Class PersonalLogin
    Dim conn As New MySqlConnection
    Private Sub PersonalLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=Suraj957;database=bank"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Welcome.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Product_and_Services.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        ChangePassword.Show

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim Reader As MySqlDataReader
        Dim i As Integer
        Try
            conn.Open()
            Query = "select count(*) from Customer_Database where Username = '" & Username.Text & "' and Password = '" & Password.Text & "'"

            comm = New MySqlCommand(Query, conn)

            i = Convert.ToInt32(comm.ExecuteScalar())
           
            Reader = comm.ExecuteReader
            conn.Dispose()
            If i = 0 Then
                MsgBox("Invalid Username ID or Password!", MsgBoxStyle.Critical, "Error")
                Username.Text = ""
                Password.Text = ""
            ElseIf i = 1 Then
                WelcomeUser.Show()
                conn.Open()
                Query = "select Customer_name from Customer_Database where Username='" & Username.Text & "'"
                comm = New MySqlCommand(Query, conn)
                Reader = comm.ExecuteReader()
                While Reader.Read
                    WelcomeUser.Label9.Text = Reader.GetString("customer_name")
                End While
                Me.Hide()
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Username.Text = ""
        Password.Text = ""
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)
        AddCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        MsgBox("Contact your Branch For Username", vbOK)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Welcome.Show()
        Me.Hide()
    End Sub
End Class