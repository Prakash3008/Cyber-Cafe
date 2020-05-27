Public Class adminlogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If uname.Text = "Admin" And pass.Text = "Admin" Then
            Me.Hide()
            SystemsList.Show()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        uname.Text = ""
        pass.Text = ""
    End Sub
End Class
