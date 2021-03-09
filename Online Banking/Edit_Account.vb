Public Class Edit_Account

    Private Property Customer_databaseTableAdapter1 As Object

    Private Property BankDataSet2 As Object

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        Welcome_admin.Show()
        Me.Hide()
    End Sub

    Private Sub Edit_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click
        Welcome_admin.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class