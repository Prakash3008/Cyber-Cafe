Imports System.Data.SqlClient
Public Class deluser
    Dim connection As New SqlConnection("Server=PRAKASH\SQLEXPRESS;Database=icafe;Trusted_Connection=True")
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
            'MsgBox("Connected")
        End If
        Dim command As New SqlCommand("delete from subscribers Where username = '" & nameu.Text & "'", connection)
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("User deleted")
        Else
            MessageBox.Show("User does Not exist")
        End If


    End Sub

    Private Sub Deluser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nameu.Text = ""
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles close.Click
        If connection.State = ConnectionState.Open Then
            connection.Close()
            ' MsgBox("Connected")
        End If
        Me.Hide()
        SystemsList.Show()
    End Sub
End Class