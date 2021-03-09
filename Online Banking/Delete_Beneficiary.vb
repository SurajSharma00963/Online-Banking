Imports MySql.Data.MySqlClient
Public Class Delete_Beneficiary
    Dim conn As New MySqlConnection
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Product_and_Services.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        About.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim i As Integer

        Try
            conn.Open()
            Query = "delete from Beneficiary where Account_no = '" & Account_no.Text & "' and name = '" & beneficiaryname.Text & "'"
            comm = New MySqlCommand(Query, conn)
            i = Convert.ToInt32(comm.ExecuteScalar())
            conn.Dispose()
            If MsgBox(" Beneficiary Deleted.. Succesfully!  ", MsgBoxResult.Ok, "Success") Then
                Account_no.Text = ""
                beneficiaryname.Text = ""
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

    Private Sub Delete_Beneficiary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=Suraj957;database=bank"

    End Sub

    Private Sub Account_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Account_no.KeyPress
        Account_no.MaxLength = 11
        If e.KeyChar > "10" And (e.KeyChar < "0" Or e.KeyChar > "9") Then
            e.Handled = True
        End If
    End Sub

    

    Private Sub beneficiaryname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles beneficiaryname.KeyPress
        If Char.IsLower(e.KeyChar) Then
            beneficiaryname.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    
End Class