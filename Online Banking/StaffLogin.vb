Imports MySql.Data.MySqlClient
Public Class StaffLogin
    Dim conn As New MySqlConnection
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Personal_Logincnf.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Welcome.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim reader As MySqlDataReader

        Dim i As Integer
        Try
            conn.Open()
            Query = "select count(*) from Staff_login where Staff_id = '" & Username.Text & "' and Password = '" & Password.Text & "'"
            comm = New MySqlCommand(Query, conn)
            i = Convert.ToInt32(comm.ExecuteScalar())
            conn.Dispose()
            If i = 0 Then
                MsgBox("Invalid Username ID or Password!", MsgBoxStyle.Critical, "Error")
                Username.Text = ""
                Password.Text = ""
            ElseIf i = 1 Then

                Welcome_staff.Show()
                conn.Open()
                Query = "select Staff_name from Staff_login where Staff_id='" & Username.Text & "'"
                comm = New MySqlCommand(Query, conn)
                reader = comm.ExecuteReader()
                While reader.Read
                    Welcome_staff.Label2.Text = reader.GetString("Staff_name")
                End While


                Me.Hide()
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub StaffLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=Suraj957;database=bank"
    End Sub
End Class

