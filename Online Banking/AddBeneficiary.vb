Imports MySql.Data.MySqlClient
Public Class AddBeneficiary
    Dim conn As New MySqlConnection
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Product_and_Services.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        About.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Add.Click
        Dim comm As New MySqlCommand
        Dim Query As String


        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Query = "Insert into bank.Beneficiary values('" & Account.Text & "','" & BENname.Text & "','" & Bankname.Text & "','" & Branch.Text & "', '" & 0 & "')"


            comm = New MySqlCommand(Query, conn)
            reader = comm.ExecuteReader()
            conn.Dispose()

            MsgBox("Beneficiary Added SuccessFully")


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub AddBeneficiary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=Suraj957;database=bank"
    End Sub

    Private Sub Account_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Account.KeyPress
        Account.MaxLength = 8
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub


    Private Sub BENname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BENname.KeyPress
        If Char.IsLower(e.KeyChar) Then
            BENname.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub BENname_TextChanged(sender As Object, e As EventArgs) Handles BENname.TextChanged

    End Sub

    Private Sub Bankname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Bankname.KeyPress
        If Char.IsLower(e.KeyChar) Then
            Bankname.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub Bankname_TextChanged(sender As Object, e As EventArgs) Handles Bankname.TextChanged

    End Sub

    Private Sub Branch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Branch.KeyPress
        If Char.IsLower(e.KeyChar) Then
            Branch.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

   
End Class