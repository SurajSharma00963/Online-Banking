Imports MySql.Data.MySqlClient
Public Class Delete_Account
    Dim conn As New MySqlConnection
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim comm As New MySqlCommand
        Dim Query As String

        Dim i As Integer

        Try
            conn.Open()
            Query = "delete from Customer_Database where Account_no = '" & Account_no.Text & "' and Customer_name = '" & customername.Text & "'"
            comm = New MySqlCommand(Query, conn)
            i = Convert.ToInt32(comm.ExecuteScalar())
            conn.Dispose()
            

                If MsgBox(" Account No'" & Account_no.Text & "' Deleted..!  ", MsgBoxResult.Ok, "Success") Then
                    Query = "select count(*) from Customer_database"
                ' DataGridView1.Refresh()

                End If




        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    

    Private Sub Delete_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        conn.ConnectionString = "server=localhost;username=root;password=Suraj957;database=bank"

    End Sub

    

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        'DataGridView1.Refresh()
    End Sub

    Private Sub customername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles customername.KeyPress
        If Char.IsLower(e.KeyChar) Then
            customername.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub customername_TextChanged(sender As Object, e As EventArgs) Handles customername.TextChanged
      
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub cname_Click(sender As Object, e As EventArgs) Handles cname.Click

    End Sub

    Private Sub Account_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Account_no.KeyPress
        Account_no.MaxLength = 8
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

End Class