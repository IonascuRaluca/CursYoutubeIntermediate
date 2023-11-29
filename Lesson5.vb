Public Class Lesson5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim decResult As Decimal
        'decResult = TotalPay(9.57, 20)
        'MsgBox(decResult)

        'MsgBox(TotalPay(9.57, 20))

        'Dim dblArea As Double
        'dblArea = TriangleArea(12, 20)
        'MsgBox(dblArea)      ' sau MsgBox(TriangleArea(12,20))

        MsgBox(TemperatureChecker(12))

    End Sub

    Function TotalPay(HourlyRate As Decimal, HoursWorked As Integer) As Decimal

        Dim decTotalPay As Decimal
        decTotalPay = HourlyRate * HoursWorked
        Return decTotalPay

    End Function

    Function TriangleArea(Base As Double, Height As Double) As Double

        Dim dblResult As Double
        dblResult = (Base * Height) / 2
        Return dblResult

    End Function

    Function TemperatureChecker(Temperature As Integer) As String

        If Temperature < 10 Then
            Return "Cold"
        ElseIf Temperature >= 10 And Temperature < 25 Then
            Return "Warm"
        Else
            Return "Hot"
        End If

    End Function
End Class

'costul unei comenzi depinzand de numarul de articole si cat costa fiecare
' aria unui cerc pe baza razei

