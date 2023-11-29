Public Class Form1
    Dim x As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(x)
        For i As Integer = 1 To 3
            MsgBox(i)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        x = 5
        MsgBox(x)
        x = 7
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        logon.Hide()
        MsgBox("Welcome " & stUser)
        Me.LblWelcome.Text = "Welcome " & stUser
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        logon.Show()
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class
