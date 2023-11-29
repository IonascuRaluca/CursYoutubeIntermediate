Public Class Lesson3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim x As Integer
        Dim y As Integer
        Dim z As Integer
        Dim myArray(4) As String

        myArray(0) = "apple"
        myArray(1) = "pear"
        myArray(2) = "orange"
        myArray(3) = "banana"
        myArray(4) = "cherry"

        x = 5
        y = 15
        z = 20

        'Call doSomething(59, 21, 7)
        Call doSomething(x, y, z, myArray)

        MsgBox("button code is running again")
        MsgBox("the value of x, y, z are " & x & " " & y & " " & z)

    End Sub
    Sub doSomething(p As Integer, q As Integer, r As Integer, anArray() As String)

        MsgBox("doSomething is running")
        MsgBox("i was passed the value " & r & " " & q & " " & p)

        p = 100
        q = 200
        r = 300

        MsgBox(anArray(3))

    End Sub
End Class