Imports System.Data.SqlClient


Public Class LogInDetails
    Dim connection As New SqlConnection("Server=PRAKASH\SQLEXPRESS;Database=icafe;Trusted_Connection=True")

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles login.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
            'MsgBox("Connected with database")
        End If

        If nam.Text = "" Or phno.Text = "" Or uname.Text = "" Or pass.Text = "" Then
            MsgBox("Please Enter all the Credentials.")
        Else
            Dim command As New SqlCommand("Insert into subscribers(SubscriberName,phoneno,username,passwd) values('" & nam.Text & "','" & phno.Text & "','" & uname.Text & "','" & pass.Text & "')", connection)
            If command.ExecuteNonQuery() = 1 Then
                MsgBox("New user Added")
            Else
                MsgBox("New user was not Added")
            End If
            connection.Close()
            Me.Close()
            choiceuser.Show()
        End If

    End Sub
    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        nam.Text = ""
        phno.Text = ""
        uname.Text = ""
        pass.Text = ""
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Nam_TextChanged(sender As Object, e As EventArgs) Handles nam.LostFocus
        If Not Char.IsLetter(nam.Text) Then
            MsgBox("Enter a valid name")
        End If

    End Sub

    Private Sub Phno_TextChanged(sender As Object, e As EventArgs) Handles phno.LostFocus
        If Not IsNumeric(phno.Text) Then
            MsgBox("Enter a valid number")
        End If

    End Sub
End Class