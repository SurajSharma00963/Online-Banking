Imports MySql.Data.MySqlClient

Public Class EditAccount
    Dim conn As New MySqlConnection
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub EditAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=Suraj957;database=bank"

        Accountno.Text = ""
        CName.Text = ""
        Phone.Text = ""
        Nominee.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim Reader As MySqlDataReader

        Dim i As Integer
        Try
            conn.Open()
            Query = "select customer_name,Phone_no,EMail_id,nominee from Customer_Database where account_no = '" & Accountno.Text & "' "
            comm = New MySqlCommand(Query, conn)


                Reader = comm.ExecuteReader()
                While Reader.Read
                    Me.CName.Text = Reader.GetString("customer_name")
                    Me.Phone.Text = Reader.GetString("Phone_no")
                    Me.Email.Text = Reader.GetString("EMail_id")
                    Me.Nominee.Text = Reader.GetString("nominee")
                    CName.Show()
                    Phone.Show()
                    Nominee.Show()
                    Email.Show()
                    Label1.Show()
                    Label3.Show()
                    Label4.Show()
                    Label5.Show()
                    Update1.Show()

              
            End While
            conn.Dispose()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Welcome_staff.Show()
        Me.Close()

    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update1.Click, Update1.Click
        Dim comm As New MySqlCommand
        Dim Query, mail As String
        mail = Email.Text
        Dim Reader As MySqlDataReader
        Try
            conn.Open()
            Query = "update Customer_Database set customer_name  = '" & CName.Text & "', phone_no ='" & Phone.Text & "', nominee='" & Nominee.Text & "', EMail_id ='" & mail & "' where Account_no='" & Accountno.Text & "' "
            comm = New MySqlCommand(Query, conn)
            Reader = comm.ExecuteReader
            MsgBox("Account updated successfully")
            CName.Hide()
            Phone.Hide()
            Nominee.Hide()
            Email.Hide()
            Label1.Hide()
            Label3.Hide()
            Label4.Hide()
            Label5.Hide()
            Update1.Hide()
            conn.Dispose()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Accountno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Accountno.KeyPress
        Accountno.MaxLength = 8
        If e.KeyChar > "10" And (e.KeyChar < "0" Or e.KeyChar > "9") Then
            e.Handled = True
        End If
    End Sub

    

    Private Sub Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Phone.KeyPress
        Phone.MaxLength = 10
        If e.KeyChar > "10" And (e.KeyChar < "0" Or e.KeyChar > "9") Then
            e.Handled = True
        End If
    End Sub


    Private Sub Phone_TextChanged(sender As Object, e As EventArgs) Handles Phone.TextChanged

    End Sub

    Private Sub CName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CName.KeyPress
        If Char.IsLower(e.KeyChar) Then
            CName.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub CName_TextChanged(sender As Object, e As EventArgs) Handles CName.TextChanged

    End Sub

    Private Sub Nominee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nominee.KeyPress
        If Char.IsLower(e.KeyChar) Then
            Nominee.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub Nominee_TextChanged(sender As Object, e As EventArgs) Handles Nominee.TextChanged

    End Sub

    Private Sub Email_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Email.KeyPress
        If Char.IsUpper(e.KeyChar) Then
            Email.SelectedText = Char.ToLower(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub Email_TextChanged(sender As Object, e As EventArgs) Handles Email.TextChanged

    End Sub
End Class