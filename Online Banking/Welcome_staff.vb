Imports MySql.Data.MySqlClient
Public Class Welcome_staff
    Dim conn As New MySqlConnection
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Welcome_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=Suraj957;database=bank"
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        StaffLogin.Show()
        Me.Close()
        StaffLogin.Username.Text = ""
        StaffLogin.Password.Text = ""

    End Sub



    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        EditAccount.Show()
        Me.Hide()
    End Sub



    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Add_Balance.Show()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Delete_Account.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

        Add_Account.Show()
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim Reader As MySqlDataReader
        Dim i As Integer
        Try
            conn.Open()
            Query = "select account_no from Bank.customer_Database"
            comm = New MySqlCommand(Query, conn)
            i = Convert.ToInt32(comm.ExecuteScalar())
            Reader = comm.ExecuteReader()

            While Reader.Read
                Add_Account.Accountno.Text = Reader.GetString("Account_no")

            End While
            conn.Dispose()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        AddCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Withdraw.Show()
        Me.Hide()
    End Sub
End Class