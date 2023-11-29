Public Class logon
    Private Sub BtnLogon_Click(sender As Object, e As EventArgs) Handles BtnLogon.Click
        'Form1.Show()

        If Me.TxtUserName.Text = "kevin" And Me.TxtPassword.Text = "password" Then
            stUser = "kevin"
            Form1.Show()
        Else
            MsgBox("You are not authorised")
        End If
    End Sub

End Class