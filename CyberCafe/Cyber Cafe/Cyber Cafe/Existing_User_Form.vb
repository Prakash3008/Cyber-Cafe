Imports System.Data.SqlClient

Public Class Existing_User_Form
    Dim connection As New SqlConnection("Server=PRAKASH\SQLEXPRESS;Database=icafe;Trusted_Connection=True")

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Dim command As New SqlCommand("select * from subscribers where username = @username and passwd = @passwd", connection)
        command.Parameters.Add("@username", SqlDbType.VarChar).Value = uname.Text
        command.Parameters.Add("@passwd", SqlDbType.VarChar).Value = pwd.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Username or Password is Invalid")
        Else
            MsgBox("Logged in Successfully")
            Dim comm As New SqlCommand("Insert into logininfo(loginid,passwd,dateandtime) values('" & uname.Text & "','" & pwd.Text & "','" & DateTime.Now & "')", connection)
            comm.ExecuteNonQuery()
            Me.Hide()
            SystemsList.Show()

        End If


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
