Imports MySql.Data.MySqlClient
Public Class Online_Registration
    Dim conn As New MySqlConnection
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim comm As New MySqlCommand
        Dim Query As String


        Dim reader As MySqlDataReader
        Try
            conn.Open()

            Query = "update bank.Customer_Database set Username= '" & Username.Text & "',password= '" & Password.Text & "' where account_no='" & Accountno.Text & "' "

            comm = New MySqlCommand(Query, conn)
            reader = comm.ExecuteReader()
            conn.Dispose()

            MsgBox("Successfully Registered  to online Banking")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Online_Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=Suraj957;database=bank"
        Me.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Personal_Logincnf.Show()
        Me.Hide()
    End Sub

    Private Sub Accountno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Accountno.KeyPress
        Accountno.MaxLength = 11
        If e.KeyChar > "10" And (e.KeyChar < "0" Or e.KeyChar > "9") Then
            e.Handled = True
        End If
    End Sub

    Private Sub Accountno_TextChanged(sender As Object, e As EventArgs) Handles Accountno.TextChanged

    End Sub

    Private Sub Customername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Customername.KeyPress
        If Char.IsLower(e.KeyChar) Then
            Customername.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub Customername_TextChanged(sender As Object, e As EventArgs) Handles Customername.TextChanged

    End Sub
End Class