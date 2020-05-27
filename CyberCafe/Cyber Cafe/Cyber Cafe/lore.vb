Imports System.Data.SqlClient
Public Class lore
    Dim connection As New SqlConnection("Server=PRAKASH\SQLEXPRESS;Database=icafe;Trusted_Connection=True")

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles close.Click
        If connection.State = ConnectionState.Open Then
            connection.Close()
            ' MsgBox("Connected")
        End If
        Me.Hide()
        SystemsList.Show()
    End Sub

    Private Sub Reports_Click(sender As Object, e As EventArgs) Handles reports.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
            ' MsgBox("Connected")
        End If
        Dim adapter As New SqlDataAdapter("Select * from logininfo", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
End Class