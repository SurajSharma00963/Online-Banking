Imports MySql.Data.MySqlClient
Public Class Welcome_Admin
    Dim conn As New MySqlConnection
    Private Sub Welcome_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=Suraj957;database=bank"
        'TODO: This line of code loads data into the 'BankDataSet1.customer_database' table. You can move, or remove it, as needed.
        Me.Customer_databaseTableAdapter.Fill(Me.BankDataSet1.customer_database)
        'TODO: This line of code loads data into the 'BankDataSet.staff_login' table. You can move, or remove it, as needed.
        Me.Staff_loginTableAdapter.Fill(Me.BankDataSet.staff_login)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        

        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim Query As String = "select * from Staff_login"
        da.SelectCommand = New MySqlCommand(Query, conn)
        da.Fill(ds)
        conn.Close()
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Show()
        Button1.Show()
        Name1.Hide()
        Staff_id.Hide()
        Password.Hide()
        TextBox1.Hide()
        TextBox2.Hide()
        TextBox3.Hide()
        Button4.Hide()
        Button3.Hide()
        DataGridView2.Hide()
        Button2.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Hide()
        Button1.Hide()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim Query As String = "select * from Customer_database"
        da.SelectCommand = New MySqlCommand(Query, conn)
        da.Fill(ds)
        conn.Close()
        DataGridView2.DataSource = ds.Tables(0)
        DataGridView2.Show()
        Button2.Show()
        Name1.Hide()
        Staff_id.Hide()
        Password.Hide()
        TextBox1.Hide()
        TextBox2.Hide()
        TextBox3.Hide()
        Button4.Hide()
        Button3.Hide()
        DataGridView1.Hide()
        Button1.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView2.Hide()
        Button2.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Name1.Show()
        Staff_id.Show()
        Password.Show()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Show()
        TextBox2.Show()
        TextBox3.Show()
        Button4.Show()
        Button3.Show()
        DataGridView1.Hide()
        Button1.Hide()
        DataGridView2.Hide()
        Button2.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Name1.Hide()
        Staff_id.Hide()
        Password.Hide()
        TextBox1.Hide()
        TextBox2.Hide()
        TextBox3.Hide()
        Button4.Hide()
        Button3.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Query = "Insert into bank.staff_login values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "' )"
            comm = New MySqlCommand(Query, conn)
            reader = comm.ExecuteReader()
            conn.Dispose()
            MsgBox("Staff Added SuccessFully")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim Reader As MySqlDataReader

        Try
            conn.Open()
            Query = "select staff_name, staff_id from Staff_login"
            comm = New MySqlCommand(Query, conn)

            Reader = comm.ExecuteReader()
            conn.Dispose()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally

        End Try
        conn.Dispose()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Logout2.Show()
        Me.Close()

    End Sub
End Class