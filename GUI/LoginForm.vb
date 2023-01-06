Imports System.Data.SqlClient

Public Class LoginForm

    Private Sub butlogin_Click(sender As Object, e As EventArgs) Handles butlogin.Click
        Dim connection As New SqlConnection("server= ROCKSTAR\ROCKSTAR; database=TJrestaurant;integrated security=true")
        Dim command As New SqlCommand("select *from logininfo where username=@username and password=@password", connection)
        command.Parameters.Add("@username", SqlDbType.VarChar).Value = txtuser.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = txtpass.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MessageBox.Show("username or password are invaild")
        Else
            homeForm.Show()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub
End Class
