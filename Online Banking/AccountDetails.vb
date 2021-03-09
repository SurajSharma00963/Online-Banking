Imports MySql.Data.MySqlClient
Public Class AccountDetails
    Dim conn As New MySqlConnection
    Private Sub WelcomeUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=Suraj957;database=bank"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        FundTransfer.Show()
        Me.Close()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Enquiry.Show()
    End Sub



    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        E_cards.Show()

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Personal_Logincnf.Show()
        Me.Close()
    End Sub

    

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    

    Private Sub Balance_LinkClicked_2(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Balance.LinkClicked
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim Reader As MySqlDataReader
        Try
            conn.Open()
            Query = "select Balance from Customer_Database where Username='" & PersonalLogin.Username.Text & "'"
            comm = New MySqlCommand(Query, conn)
            Reader = comm.ExecuteReader()
            While Reader.Read
                Me.Label13.Text = Reader.GetString("Balance")
                Label13.Show()
                Balance.Hide()
            End While
            conn.Dispose()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Profile.Show()

        Dim comm As New MySqlCommand
        Dim Query As String
        Dim Reader As MySqlDataReader
        Dim i As Integer
        Try
            conn.Open()
            Query = "select account_no,customer_name,phone_no,Type_of_Account,DOB,Email_id,Nominee,Pan_card from Customer_Database where Username = '" & PersonalLogin.Username.Text & "' and Password = '" & PersonalLogin.Password.Text & "'"
            comm = New MySqlCommand(Query, conn)
            i = Convert.ToInt32(comm.ExecuteScalar())
            Reader = comm.ExecuteReader()
            While Reader.Read
                Profile.Accountno.Text = Reader.GetString("Account_no")
                Profile.Cname.Text = Reader.GetString("customer_name")
                Profile.Phoneno.Text = Reader.GetString("Phone_no")
                Profile.TOA.Text = Reader.GetString("Type_of_account")
                Profile.DOB.Text = Reader.GetString("Dob")
                Profile.Email.Text = Reader.GetString("EMail_id")
                Profile.Nominee.Text = Reader.GetString("nominee")
                Profile.PAN.Text = Reader.GetString("Pan_card")
            End While
            Me.Hide()
            conn.Dispose()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        Me.Close()
    End Sub
End Class