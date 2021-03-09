Imports MySql.Data.MySqlClient
Public Class Transfer
    Dim conn As New MySqlConnection
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Product_and_Services.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        About.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles close1.Click, close1.Click
        Me.Close()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles transfr.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Try
            conn.Open()
            Query = "update Beneficiary set balance  = (customer_database.balance) - '" & amount.Text & "' where account_no= '" & Accountno.Text & "' "
            MsgBox("Amount Transfered successfully")
            conn.Dispose()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Transfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=Suraj957;database=bank"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles go.Click
        Accountno.Enabled = False

        Go.Hide()
        Namelbl.Show()
        name1.Show()
        amountlbl.Show()
        amount.Show()
        banklbl.Show()
        bank.Show()
        amount.Show()
        transfr.Show()
        close1.Show()
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim Reader As MySqlDataReader
        Try
            conn.Open()
            Query = "select Name,Bank from Beneficiary where Account_no = '" & Accountno.Text & "' "
            comm = New MySqlCommand(Query, conn)

            Reader = comm.ExecuteReader()
            While Reader.Read
                Me.name1.Text = Reader.GetString("name")
                Me.bank.Text = Reader.GetString("Bank")
            End While

            conn.Dispose()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Accountno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Accountno.KeyPress
        Accountno.MaxLength = 8
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub
End Class
