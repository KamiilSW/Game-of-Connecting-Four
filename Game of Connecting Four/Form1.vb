Public Class Form1
    Dim y As Integer
    Dim limit As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.BackColor = Color.Red Or Button1.BackColor = Color.Blue Then

        ElseIf Button14.BackColor = Color.Red Or Button14.BackColor = Color.Blue Then
            limit = 27
        ElseIf Button21.BackColor = Color.Red Or Button21.BackColor = Color.Blue Then
            limit = 113
        ElseIf Button28.BackColor = Color.Red Or Button28.BackColor = Color.Blue Then
            limit = 199
        ElseIf Button35.BackColor = Color.Red Or Button35.BackColor = Color.Blue Then
            limit = 285
        ElseIf Button42.BackColor = Color.Red Or Button42.BackColor = Color.Blue Then
            limit = 371
        Else
            limit = 456
        End If

        Counter.Location = New Point(57, 27)
            y = Counter.Location.Y

        Do
            Counter.Top += 3
            System.Threading.Thread.Sleep(20)
        Loop Until Counter.Location.Y <= limit

        Button42.BackColor = Counter.BackColor
        Counter.Location = New Point(695, 248)

            If Counter.BackColor = Color.Red Then
                Counter.BackColor = Color.Blue
            Else
                Counter.BackColor = Color.Red
            End If

    End Sub
End Class
