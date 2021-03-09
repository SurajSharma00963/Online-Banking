Imports MySql.Data.MySqlClient
Public Class Withdraw
    Dim conn As New MySqlConnection

    Private Sub Withdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=Suraj957;database=bank"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Account_no.Enabled = False

        Button1.Hide()
        cname.Show()
        Amountlbl.Show()
        CustomerName.Show()
        amount.Show()
        withdraw_but.Show()
        Back.Show()
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim Reader As MySqlDataReader
        Try
            conn.Open()
            Query = "select customer_name from Customer_Database where Account_no = '" & Account_no.Text & "' "
            comm = New MySqlCommand(Query, conn)

            Reader = comm.ExecuteReader()
            While Reader.Read
                Me.CustomerName.Text = Reader.GetString("Customer_name")
            End While

            conn.Dispose()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub Deposit_but_Click(sender As Object, e As EventArgs) Handles withdraw_but.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Query = "update bank.Customer_Database set balance = (customer_database.balance) - '" & amount.Text & "' where Customer_name='" & CustomerName.Text & "' and Account_no='" & Account_no.Text & "' "
            comm = New MySqlCommand(Query, conn)
            reader = comm.ExecuteReader()
            conn.Dispose()

            MsgBox("Amount withdrawn Successfully And details Have been Sent to your Mail")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Welcome_staff.Show()
        Me.Close()
    End Sub

    Private Sub Account_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Account_no.KeyPress
        Account_no.MaxLength = 8
        If e.KeyChar > "10" And (e.KeyChar < "0" Or e.KeyChar > "9") Then
            e.Handled = True
        End If
    End Sub


End Class