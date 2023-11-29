Imports System.IO

Public Class Lesson6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnWrite.Click
        Dim myStreamWriter As StreamWriter

        myStreamWriter = New StreamWriter("d:\lesson6\mytextfile.txt", True)

        myStreamWriter.WriteLine("Kevin")
        myStreamWriter.WriteLine("Murvin")
        myStreamWriter.WriteLine("Beatrix")
        myStreamWriter.WriteLine("Sally")
        myStreamWriter.WriteLine("David")
        myStreamWriter.Write("Yabba")
        myStreamWriter.Write("Dabba")
        myStreamWriter.Write("Do")
        myStreamWriter.Close()

        MsgBox("all done")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnRead.Click
        Dim myStreamReader As StreamReader

        myStreamReader = New StreamReader("d:\lesson6\mytextfile.txt")

        Dim stOutput As String

        Do While Not myStreamReader.EndOfStream
            stOutput = stOutput & myStreamReader.ReadLine & vbNewLine
        Loop

        myStreamReader.Close()
        MsgBox(stOutput)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnReadAll.Click
        Dim myStreamReader As StreamReader
        myStreamReader = New StreamReader("d:\lesson6\mytextfile.txt")

        Dim stAll As String
        stAll = myStreamReader.ReadToEnd
        myStreamReader.Close()

        MsgBox(stAll)

    End Sub

    Private Sub BtnReadOne_Click(sender As Object, e As EventArgs) Handles BtnReadOne.Click

        Dim myStreamReader As StreamReader
        myStreamReader = New StreamReader("d:\lesson6\mytextfile.txt")

        Do While Not myStreamReader.EndOfStream
            MsgBox(Chr(myStreamReader.Read))
        Loop

        myStreamReader.Close()

    End Sub

    Private Sub BtnSaveScore_Click(sender As Object, e As EventArgs) Handles BtnWriteArray.Click
        'save scores
        Dim score(3) As Integer

        score(0) = 12
        score(1) = 22
        score(2) = 25
        score(3) = 38

        Dim scoreWriter As StreamWriter
        scoreWriter = New StreamWriter("d:\lesson6\score.txt", False)

        For i = 0 To 3
            scoreWriter.WriteLine(score(i))
        Next

        scoreWriter.Close()
        MsgBox("scores saved")

    End Sub

    Private Sub BtnReadArray_Click(sender As Object, e As EventArgs) Handles BtnReadArray.Click
        'read scores
        Dim score(3) As Integer

        Dim scoreReader As StreamReader
        scoreReader = New StreamReader("d:\lesson6\score.txt")

        For i = 0 To 3
            score(i) = scoreReader.ReadLine
        Next

        scoreReader.Close()

        MsgBox("scores retrieved")

        Dim stOut As String

        For i = 0 To 3
            stOut = stOut & score(i) & vbNewLine
        Next

        MsgBox(stOut)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnTwoDimensionalArrayW.Click
        ' write names and scores

        Dim score(1, 3) As String

        score(0, 0) = "David"
        score(1, 0) = 12
        score(0, 1) = "Sally"
        score(1, 1) = 20
        score(0, 2) = "Beatrix"
        score(1, 2) = 25
        score(0, 3) = "Murvin"
        score(1, 3) = 38

        Dim scorewriter As StreamWriter
        scorewriter = New StreamWriter("d:\lesson6\scoreandnames.txt", False)

        For y = 0 To 3
            scorewriter.WriteLine(score(0, y) & " " & score(1, y))
        Next

        scorewriter.Close()
        MsgBox("scores and names saved")

    End Sub

    Private Sub BtnTwoDimensionalArrayR_Click(sender As Object, e As EventArgs) Handles BtnTwoDimensionalArrayR.Click

        Dim score(1, 3) As String

        Dim scoreReader As StreamReader
        scoreReader = New StreamReader("d:\lesson6\scoreandnames.txt")

        Dim currentScore As String
        Dim temporarArray() As String

        For y = 0 To 3
            currentScore = scoreReader.ReadLine
            MsgBox(currentScore)
            temporarArray = currentScore.Split(" ")
            score(0, y) = temporarArray(0)
            score(1, y) = temporarArray(1)
        Next

        scoreReader.Close()
        MsgBox("scores and names retrieved")

    End Sub

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click
        Dim scoreReader As StreamReader
        Dim scoreWriter As StreamWriter

        scoreReader = New StreamReader("d:\lesson6\score.txt")
        scoreWriter = New StreamWriter("d:\lesson6\scorecopy.txt", False)

        'Dim allData As String
        'allData = scoreReader.ReadToEnd()
        'scoreWriter.WriteLine(allData)

        scoreWriter.WriteLine(scoreReader.ReadToEnd())

        scoreReader.Close()
        scoreWriter.Close()

        MsgBox("done")

    End Sub

    Private Sub BtnCopyConditionally_Click(sender As Object, e As EventArgs) Handles BtnCopyConditionally.Click
        Dim scoreReader As StreamReader
        Dim scoreWriter As StreamWriter

        scoreReader = New StreamReader("d:\lesson6\score.txt")
        scoreWriter = New StreamWriter("d:\lesson6\scorecopy.txt", False)

        Dim score As Integer

        Do While Not scoreReader.EndOfStream
            score = scoreReader.ReadLine
            If score >= 25 Then
                scoreWriter.WriteLine(score)
            End If
        Loop

        scoreReader.Close()
        scoreWriter.Close()

        MsgBox("done")

    End Sub
End Class

'*program pentru a lua date dintr-o variabila matrice si a scrie _
'fiecare articol intr-un fisier text
'* alt program care sa il citeasca intr-o matrice
'* citire dintr-un fisier text si copiere a datelor in altul