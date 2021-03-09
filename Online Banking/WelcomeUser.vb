Imports MySql.Data.MySqlClient
Public Class WelcomeUser
    Dim conn As New MySqlConnection




    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        AccountDetails.Show()
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim Reader As MySqlDataReader
        Dim i As Integer
        Try
            conn.Open()
            Query = "select account_no,customer_name,Email_id from Customer_Database where Username = '" & PersonalLogin.Username.Text & "' and Password = '" & PersonalLogin.Password.Text & "'"
            comm = New MySqlCommand(Query, conn)
            i = Convert.ToInt32(comm.ExecuteScalar())
            Reader = comm.ExecuteReader()
            While Reader.Read
                AccountDetails.Accountno.Text = Reader.GetString("Account_no")
                AccountDetails.Cname.Text = Reader.GetString("customer_name")
                AccountDetails.Email.Text=Reader.GetString("EMail_id")
            End While
            Me.Hide()
            conn.Dispose()
            
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        About.Show()
    End Sub

    Private Sub WelcomeUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=Suraj957;database=bank"

        
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        FundTransfer.Show()
        Me.Hide()
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
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Enquiry.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        E_cards.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Product_and_Services.Show()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Personal_Logincnf.Show()
        PersonalLogin.Close()
        Me.Close()
    End Sub
End Class