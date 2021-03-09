Imports MySql.Data.MySqlClient
Public Class AddCustomer
    Dim conn As New MySqlConnection
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim d, b, c, d1 As String
        Dim a As Integer


        Try
            conn.Open()
            a = "0"
            b = ""
            c = ""
            d1 = ""

            If Len(Phone.Text) < 10 Then
                MsgBox("Check Contact number", MsgBoxStyle.Critical, "WARNING")
                Exit Sub
            End If

            d = Dob.Text
            Query = "Insert into bank.Customer_Database values('" & a & "','" & Customername.Text & "','" & Gender.SelectedItem & "','" & d & "','" & Addresstxt.Text & "','" & b & "','" & c & "','" & Phone.Text & "','" & Pan.Text & "','" & d1 & "','" & Email.Text & "','" & 0 & "','" & a & "','" & b & "' )"
            comm = New MySqlCommand(Query, conn)
            comm.ExecuteNonQuery()
            conn.Dispose()
            MsgBox("Account Added SuccessFully")
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
        Welcome_staff.Show()
        Me.Close()
    End Sub
    Private Sub Customername_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLower(e.KeyChar) Then
            Customername.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub Customername_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Pan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Pan.KeyPress
        Pan.MaxLength = 10
        If Char.IsLower(e.KeyChar) Then
            Pan.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub Pan_TextChanged(sender As Object, e As EventArgs) Handles Pan.TextChanged

    End Sub

    Private Sub Email_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Email.KeyPress
        If Char.IsUpper(e.KeyChar) Then
            Email.SelectedText = Char.ToLower(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub Email_TextChanged(sender As Object, e As EventArgs) Handles Email.TextChanged

    End Sub

    Private Sub Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Phone.KeyPress
        Phone.MaxLength = 10
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            
            e.Handled = True
        End If
    End Sub

    Private Sub Phone_TextChanged(sender As Object, e As EventArgs) Handles Phone.TextChanged

    End Sub

    Private Sub Customername_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles Customername.KeyPress
        If Char.IsLower(e.KeyChar) Then
            Customername.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub Customername_TextChanged_1(sender As Object, e As EventArgs) Handles Customername.TextChanged

    End Sub

    Private Sub Dob_ValueChanged(sender As Object, e As EventArgs) Handles Dob.ValueChanged

    End Sub
End Class