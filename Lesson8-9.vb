Imports System.Runtime.Remoting.Metadata.W3cXsd2001

Public Class Lesson8_9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnLesson8.Click
        Dim a1 As Integer = 5
        Dim a2 As Integer = -5
        Dim b As Double = 0
        Dim result1 As String
        Dim result2 As String

        result1 = (a1 / b)
        MsgBox(result1)

        result2 = (a2 / b)
        MsgBox(result2)

        If (a1 / b) > (a2 / b) Then
            MsgBox("Positive infinity is bigger than negative infinity")
        End If

        'result = (a / b)
        'If Double.IsInfinity(result) = True Then
        'MsgBox("the result is infinity")
        'End If

    End Sub

    Private Sub BtnLesson9_Click(sender As Object, e As EventArgs) Handles BtnLesson9.Click
        Dim x As Integer
        Dim y As Integer
        Dim z As Integer
        Dim age As Integer


        'Try
        '    x = Me.TxtNr1.Text
        'Catch ex As Exception
        '    MsgBox("Number one is required must be a number")
        'End Try

        'Try
        '    y = Me.TxtNr2.Text
        'Catch ex As Exception
        '    MsgBox("Number two is required must be a number")
        'End Try

        'Try
        '    age = Me.TxtAge.Text
        'Catch ex As Exception
        '    MsgBox("Age is required must be a number")
        'End Try

        'Try
        '    z = x \ y
        'Catch ex As Exception
        '    MsgBox("Number two mush be bigger than zero")
        'End Try

        'MsgBox(z)
        'MsgBox(age)


        Try
            x = Me.TxtNr1.Text
            y = Me.TxtNr2.Text
            age = Me.TxtAge.Text
            z = x \ y
        Catch ex As InvalidCastException
            MsgBox("You must only enter numbers")
        Catch ex As OverflowException
            MsgBox("Number two mush be bigger than zero")
        Finally
            MsgBox(z)
            MsgBox(age)
        End Try


    End Sub
End Class