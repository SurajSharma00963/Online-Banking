Imports MySql.Data.MySqlClient
Public Class Deposit
    Dim conn As New MySqlConnection
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Depositbtn.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim i As Integer
        Try
            conn.Open()
            Query = "update  customer_database set balance = balance + '" & amount.Text & "' where account_no = '" & Account_no.Text & "'"
            comm = New MySqlCommand(Query, conn)
            i = Convert.ToInt32(comm.ExecuteScalar())
            conn.Dispose()
            If MsgBox(" Deposited Succesfully!  ", MsgBoxResult.Ok, "Success") Then
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub Add_Balance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=Suraj957;database=bank"
    End Sub
    Private Sub close_but_Click(sender As Object, e As EventArgs) Handles Close_but.Click, Close_but.Click
        Me.Close()
    End Sub
    Private Sub Account_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Account_no.KeyPress
        Account_no.MaxLength = 11
        If e.KeyChar > "10" And (e.KeyChar < "0" Or e.KeyChar > "9") Then
            e.Handled = True
        End If
    End Sub
    Private Sub amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles amount.KeyPress
        amount.MaxLength = 8
        If e.KeyChar > "10" And (e.KeyChar < "0" Or e.KeyChar > "9") Then
            e.Handled = True
        End If
    End Sub
    Private Sub Go_Click(sender As Object, e As EventArgs) Handles Go.Click
        Account_no.Enabled = False
        Go.Hide()
        amountlbl.Show()
        amount.Show()
        Cname.Show()
        Customername.Show()
        amount.Show()
        Depositbtn.Show()
        Close_but.Show()
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim Reader As MySqlDataReader
        Try
            conn.Open()
            Query = "select customer_name from Customer_Database where Account_no = '" & Account_no.Text & "' "
            comm = New MySqlCommand(Query, conn)
            Reader = comm.ExecuteReader()
            While Reader.Read
                Me.Customername.Text = Reader.GetString("Customer_name")
            End While
            conn.Dispose()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
End Class