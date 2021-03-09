Imports MySql.Data.MySqlClient
Public Class Add_Account
    Dim conn As New MySqlConnection
    

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Welcome_staff.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim a As String



        Dim reader As MySqlDataReader
        Try
            conn.Open()

            Query = "update bank.Customer_Database set Account_no= '" & Accountno.Text & "',type_of_account= '" & Typeofaccount.SelectedItem & "',atm='" & ATM.SelectedItem & "', nominee='" & Nominee.Text & "',username='" & Username.Text & "', password='" & Password.Text & "' where Customer_name='" & Customername.Text & "' "

            comm = New MySqlCommand(Query, conn)
            reader = comm.ExecuteReader()
            conn.Dispose()

            MsgBox("Account No Added Sucessfully")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Add_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=Suraj957;database=bank"
        Me.Refresh()
    End Sub
    Private Sub Pan_TextChanged(sender As Object, e As EventArgs)
        Text.ToUpper()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs)
        WelcomeUser.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Product_and_Services.Show()
    End Sub

    Private Sub Accountno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Accountno.KeyPress
        Accountno.MaxLength = 8
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If

        'If e.KeyChar > "10" And (e.KeyChar < "0" Or e.KeyChar > "9") Then
        'e.Handled = True
        'End If

    End Sub
    Private Sub Nominee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nominee.KeyPress
        If Char.IsLower(e.KeyChar) Then
            Nominee.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub Customername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Customername.KeyPress
        If Char.IsLower(e.KeyChar) Then
            Customername.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

End Class