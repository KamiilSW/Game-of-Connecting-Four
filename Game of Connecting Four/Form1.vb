﻿Public Class Form1
    Dim y As Integer
    Dim limit As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.BackColor = Color.Red Or Button1.BackColor = Color.Blue Then
            Exit Sub
        ElseIf Button14.BackColor = Color.Red Or Button14.BackColor = Color.Blue Then
            limit = 29
        ElseIf Button21.BackColor = Color.Red Or Button21.BackColor = Color.Blue Then
            limit = 115
        ElseIf Button28.BackColor = Color.Red Or Button28.BackColor = Color.Blue Then
            limit = 201
        ElseIf Button35.BackColor = Color.Red Or Button35.BackColor = Color.Blue Then
            limit = 287
        ElseIf Button42.BackColor = Color.Red Or Button42.BackColor = Color.Blue Then
            limit = 373
        Else
            limit = 458
        End If

        Counter.Location = New Point(59, 29)
        y = Counter.Location.Y

        Do
            y += 3
            Counter.Location = New Point(59, y)
            System.Threading.Thread.Sleep(7)
            If limit = 29 Then
                Button1.BackColor = Counter.BackColor
            ElseIf limit = 115 Then
                Button14.BackColor = Counter.BackColor
            ElseIf limit = 201 Then
                Button21.BackColor = Counter.BackColor
            ElseIf limit = 287 Then
                Button28.BackColor = Counter.BackColor
            ElseIf limit = 373 Then
                Button35.BackColor = Counter.BackColor
            ElseIf limit = 458 Then
                Button42.BackColor = Counter.BackColor
            End If
        Loop Until Counter.Location.Y >= limit

        Counter.Location = New Point(695, 248)

            If Counter.BackColor = Color.Red Then
                Counter.BackColor = Color.Blue
            Else
                Counter.BackColor = Color.Red
            End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.BackColor = Color.Red Or Button2.BackColor = Color.Blue Then
            Exit Sub
        ElseIf Button13.BackColor = Color.Red Or Button13.BackColor = Color.Blue Then
            limit = 29
        ElseIf Button20.BackColor = Color.Red Or Button20.BackColor = Color.Blue Then
            limit = 115
        ElseIf Button27.BackColor = Color.Red Or Button27.BackColor = Color.Blue Then
            limit = 201
        ElseIf Button34.BackColor = Color.Red Or Button34.BackColor = Color.Blue Then
            limit = 287
        ElseIf Button41.BackColor = Color.Red Or Button41.BackColor = Color.Blue Then
            limit = 373
        Else
            limit = 458
        End If

        Counter.Location = New Point(145, 29)
        y = Counter.Location.Y

        Do
            y += 3
            Counter.Location = New Point(145, y)
            System.Threading.Thread.Sleep(7)
            If limit = 29 Then
                Button2.BackColor = Counter.BackColor
            ElseIf limit = 115 Then
                Button13.BackColor = Counter.BackColor
            ElseIf limit = 201 Then
                Button20.BackColor = Counter.BackColor
            ElseIf limit = 287 Then
                Button27.BackColor = Counter.BackColor
            ElseIf limit = 373 Then
                Button34.BackColor = Counter.BackColor
            ElseIf limit = 458 Then
                Button41.BackColor = Counter.BackColor
            End If
        Loop Until Counter.Location.Y >= limit

        Counter.Location = New Point(695, 248)

        If Counter.BackColor = Color.Red Then
            Counter.BackColor = Color.Blue
        Else
            Counter.BackColor = Color.Red
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.BackColor = Color.Red Or Button3.BackColor = Color.Blue Then
            Exit Sub
        ElseIf Button12.BackColor = Color.Red Or Button12.BackColor = Color.Blue Then
            limit = 29
        ElseIf Button19.BackColor = Color.Red Or Button19.BackColor = Color.Blue Then
            limit = 115
        ElseIf Button26.BackColor = Color.Red Or Button26.BackColor = Color.Blue Then
            limit = 201
        ElseIf Button33.BackColor = Color.Red Or Button33.BackColor = Color.Blue Then
            limit = 287
        ElseIf Button40.BackColor = Color.Red Or Button40.BackColor = Color.Blue Then
            limit = 373
        Else
            limit = 458
        End If

        Counter.Location = New Point(231, 29)
        y = Counter.Location.Y

        Do
            Counter.Top += 3
            System.Threading.Thread.Sleep(7)
            If limit = 29 Then
                Button3.BackColor = Counter.BackColor
            ElseIf limit = 115 Then
                Button12.BackColor = Counter.BackColor
            ElseIf limit = 201 Then
                Button19.BackColor = Counter.BackColor
            ElseIf limit = 287 Then
                Button26.BackColor = Counter.BackColor
            ElseIf limit = 373 Then
                Button33.BackColor = Counter.BackColor
            ElseIf limit = 458 Then
                Button40.BackColor = Counter.BackColor
            End If
        Loop Until Counter.Location.Y >= limit

        Counter.Location = New Point(695, 248)

        If Counter.BackColor = Color.Red Then
            Counter.BackColor = Color.Blue
        Else
            Counter.BackColor = Color.Red
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.BackColor = Color.Red Or Button4.BackColor = Color.Blue Then
            Exit Sub
        ElseIf Button11.BackColor = Color.Red Or Button11.BackColor = Color.Blue Then
            limit = 29
        ElseIf Button18.BackColor = Color.Red Or Button18.BackColor = Color.Blue Then
            limit = 115
        ElseIf Button25.BackColor = Color.Red Or Button25.BackColor = Color.Blue Then
            limit = 201
        ElseIf Button32.BackColor = Color.Red Or Button32.BackColor = Color.Blue Then
            limit = 287
        ElseIf Button39.BackColor = Color.Red Or Button39.BackColor = Color.Blue Then
            limit = 373
        Else
            limit = 458
        End If

        Counter.Location = New Point(317, 29)
        y = Counter.Location.Y

        Do
            Counter.Top += 3
            System.Threading.Thread.Sleep(7)
            If limit = 29 Then
                Button4.BackColor = Counter.BackColor
            ElseIf limit = 115 Then
                Button11.BackColor = Counter.BackColor
            ElseIf limit = 201 Then
                Button18.BackColor = Counter.BackColor
            ElseIf limit = 287 Then
                Button25.BackColor = Counter.BackColor
            ElseIf limit = 373 Then
                Button32.BackColor = Counter.BackColor
            ElseIf limit = 458 Then
                Button39.BackColor = Counter.BackColor
            End If
        Loop Until Counter.Location.Y >= limit

        Counter.Location = New Point(695, 248)

        If Counter.BackColor = Color.Red Then
            Counter.BackColor = Color.Blue
        Else
            Counter.BackColor = Color.Red
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button5.BackColor = Color.Red Or Button5.BackColor = Color.Blue Then
            Exit Sub
        ElseIf Button10.BackColor = Color.Red Or Button10.BackColor = Color.Blue Then
            limit = 29
        ElseIf Button17.BackColor = Color.Red Or Button17.BackColor = Color.Blue Then
            limit = 115
        ElseIf Button24.BackColor = Color.Red Or Button24.BackColor = Color.Blue Then
            limit = 201
        ElseIf Button31.BackColor = Color.Red Or Button31.BackColor = Color.Blue Then
            limit = 287
        ElseIf Button38.BackColor = Color.Red Or Button38.BackColor = Color.Blue Then
            limit = 373
        Else
            limit = 458
        End If

        Counter.Location = New Point(403, 29)
        y = Counter.Location.Y

        Do
            Counter.Top += 3
            System.Threading.Thread.Sleep(7)
            If limit = 29 Then
                Button5.BackColor = Counter.BackColor
            ElseIf limit = 115 Then
                Button10.BackColor = Counter.BackColor
            ElseIf limit = 201 Then
                Button17.BackColor = Counter.BackColor
            ElseIf limit = 287 Then
                Button24.BackColor = Counter.BackColor
            ElseIf limit = 373 Then
                Button31.BackColor = Counter.BackColor
            ElseIf limit = 458 Then
                Button38.BackColor = Counter.BackColor
            End If
        Loop Until Counter.Location.Y >= limit

        Counter.Location = New Point(695, 248)

        If Counter.BackColor = Color.Red Then
            Counter.BackColor = Color.Blue
        Else
            Counter.BackColor = Color.Red
        End If

    End Sub
End Class
