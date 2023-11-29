Public Class Lesson4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim price As String
        'price = "27.30"

        Dim i As Integer

        'i = Len("Kevin Drumm")
        'MsgBox(i)

        'i = Asc("B")
        'MsgBox(i)

        'Dim c As String
        'c = Chr(66)
        ''MsgBox(c)

        'Dim check As Boolean
        'check = IsNumeric(price)
        'MsgBox(check)

        'Dim decprice As Decimal
        'If check = True Then
        '    decprice = CDec(price)
        '    MsgBox(decprice)
        'Else
        '    MsgBox("cannot convert")
        'End If

        ''decprice = CType(price, decimal)

        'Dim displayPrice As String
        'displayPrice = Format(decprice, "Currency")
        'MsgBox(displayPrice)

        price = "Twenty Seven Pounds and Thirty Pence"

        Dim st As String

        'st = UCase(price)
        'MsgBox(st)

        'st = LCase(price)
        'MsgBox(st)

        'st = Mid(price, 9, 4)
        'MsgBox(st)

        'st = Strings.Right(price, 4)
        'MsgBox(st)

        'st = Strings.Replace(price, "P", "X")
        'MsgBox(st)

        'i = InStr(price, "P")
        'MsgBox(i)

        'Dim decWeight As Decimal
        'decWeight = 78.678

        'Dim d As Decimal
        ''d = Math.Ceiling(decWeight)
        ''d = Math.Floor(decWeight)
        ''d = CInt(decWeight)
        'd = Math.Round(decWeight, 2)

        'MsgBox(d)

        'Dim p As Decimal
        'p = Math.PI
        'MsgBox(p)

        'Dim dt As Date
        'dt = Now()
        'MsgBox(dt)

        'Dim name As String
        'name = InputBox("enter your name please", "Name please", "type here")
        'MsgBox(name)

        'i = MsgBox("Do you want to continue?", MsgBoxStyle.AbortRetryIgnore)  'YesNoCancel

        'If i = 5 Then
        '    MsgBox("ignoring")
        'End If

        'MsgBox(i)

        'If Len(price) = 36 Then
        '    MsgBox("It it thirty six")
        'End If

        'If IsNumeric(price) = True Then
        '    MsgBox("Ok to convert")
        'End If

        'If InStr(price, "P") > 0 Then
        '    MsgBox("it contains a P")
        'End If

        'st = UCase(Mid(price, 9, 4))
        'MsgBox(st)

        'st = UCase(InputBox("what is your name"))
        'MsgBox(st)

        i = CInt(Math.Ceiling(Rnd() * 6))
        MsgBox(i)

















    End Sub
End Class