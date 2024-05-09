Public Class Form1
    Dim y As Integer
    Dim limit As Integer

    Function ChangeColours() As Boolean
        If Counter.BackColor = Color.Red Then
            Counter.BackColor = Color.Blue
        Else
            Counter.BackColor = Color.Red
        End If
        Return True
    End Function
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

        Counter.Location = New Point(695, 248)

        ChangeColours()

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

        Counter.Location = New Point(695, 248)

        ChangeColours()

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

        Counter.Location = New Point(695, 248)

        ChangeColours()

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

        Counter.Location = New Point(695, 248)

        ChangeColours()

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

        Counter.Location = New Point(695, 248)

        ChangeColours()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Button6.BackColor = Color.Red Or Button6.BackColor = Color.Blue Then
            Exit Sub
        ElseIf Button9.BackColor = Color.Red Or Button9.BackColor = Color.Blue Then
            limit = 29
        ElseIf Button16.BackColor = Color.Red Or Button16.BackColor = Color.Blue Then
            limit = 115
        ElseIf Button23.BackColor = Color.Red Or Button23.BackColor = Color.Blue Then
            limit = 201
        ElseIf Button30.BackColor = Color.Red Or Button30.BackColor = Color.Blue Then
            limit = 287
        ElseIf Button37.BackColor = Color.Red Or Button37.BackColor = Color.Blue Then
            limit = 373
        Else
            limit = 458
        End If

        Counter.Location = New Point(489, 29)
        y = Counter.Location.Y

        If limit = 29 Then
                Button6.BackColor = Counter.BackColor
            ElseIf limit = 115 Then
                Button9.BackColor = Counter.BackColor
            ElseIf limit = 201 Then
                Button16.BackColor = Counter.BackColor
            ElseIf limit = 287 Then
                Button23.BackColor = Counter.BackColor
            ElseIf limit = 373 Then
                Button30.BackColor = Counter.BackColor
            ElseIf limit = 458 Then
                Button37.BackColor = Counter.BackColor
            End If

            Counter.Location = New Point(695, 248)

        ChangeColours()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Button7.BackColor = Color.Red Or Button7.BackColor = Color.Blue Then
            Exit Sub
        ElseIf Button8.BackColor = Color.Red Or Button8.BackColor = Color.Blue Then
            limit = 29
        ElseIf Button15.BackColor = Color.Red Or Button15.BackColor = Color.Blue Then
            limit = 115
        ElseIf Button22.BackColor = Color.Red Or Button22.BackColor = Color.Blue Then
            limit = 201
        ElseIf Button29.BackColor = Color.Red Or Button29.BackColor = Color.Blue Then
            limit = 287
        ElseIf Button36.BackColor = Color.Red Or Button36.BackColor = Color.Blue Then
            limit = 373
        Else
            limit = 458
        End If

        Counter.Location = New Point(575, 29)
        y = Counter.Location.Y

        If limit = 29 Then
            Button7.BackColor = Counter.BackColor
        ElseIf limit = 115 Then
            Button8.BackColor = Counter.BackColor
        ElseIf limit = 201 Then
            Button15.BackColor = Counter.BackColor
        ElseIf limit = 287 Then
            Button22.BackColor = Counter.BackColor
        ElseIf limit = 373 Then
            Button29.BackColor = Counter.BackColor
        ElseIf limit = 458 Then
            Button36.BackColor = Counter.BackColor
        End If

        Counter.Location = New Point(695, 248)

        ChangeColours()

    End Sub
    Dim CountersPlaced(41) As String
    Function CheckCounters() As Boolean
        If Button1.BackColor = Color.Red Then
            CountersPlaced(0) = "R"
        ElseIf Button2.BackColor = Color.Red Then
            CountersPlaced(1) = "R"
        ElseIf Button3.BackColor = Color.Red Then
            CountersPlaced(2) = "R"
        ElseIf Button4.BackColor = Color.Red Then
            CountersPlaced(3) = "R"
        ElseIf Button5.BackColor = Color.Red Then
            CountersPlaced(4) = "R"
        ElseIf Button6.BackColor = Color.Red Then
            CountersPlaced(5) = "R"
        ElseIf Button7.BackColor = Color.Red Then
            CountersPlaced(6) = "R"
        ElseIf Button8.BackColor = Color.Red Then
            CountersPlaced(7) = "R"
        ElseIf Button9.BackColor = Color.Red Then
            CountersPlaced(8) = "R"
        ElseIf Button10.BackColor = Color.Red Then
            CountersPlaced(9) = "R"
        ElseIf Button11.BackColor = Color.Red Then
            CountersPlaced(10) = "R"
        ElseIf Button12.BackColor = Color.Red Then
            CountersPlaced(11) = "R"
        ElseIf Button13.BackColor = Color.Red Then
            CountersPlaced(12) = "R"
        ElseIf Button14.BackColor = Color.Red Then
            CountersPlaced(13) = "R"
        ElseIf Button15.BackColor = Color.Red Then
            CountersPlaced(14) = "R"
        ElseIf Button16.BackColor = Color.Red Then
            CountersPlaced(15) = "R"
        ElseIf Button17.BackColor = Color.Red Then
            CountersPlaced(16) = "R"
        ElseIf Button18.BackColor = Color.Red Then
            CountersPlaced(17) = "R"
        ElseIf Button19.BackColor = Color.Red Then
            CountersPlaced(18) = "R"
        ElseIf Button20.BackColor = Color.Red Then
            CountersPlaced(19) = "R"
        ElseIf Button21.BackColor = Color.Red Then
            CountersPlaced(20) = "R"
        ElseIf Button22.BackColor = Color.Red Then
            CountersPlaced(21) = "R"
        ElseIf Button23.BackColor = Color.Red Then
            CountersPlaced(22) = "R"
        ElseIf Button24.BackColor = Color.Red Then
            CountersPlaced(23) = "R"
        ElseIf Button25.BackColor = Color.Red Then
            CountersPlaced(24) = "R"
        ElseIf Button26.BackColor = Color.Red Then
            CountersPlaced(25) = "R"
        ElseIf Button27.BackColor = Color.Red Then
            CountersPlaced(26) = "R"
        ElseIf Button28.BackColor = Color.Red Then
            CountersPlaced(27) = "R"
        ElseIf Button29.BackColor = Color.Red Then
            CountersPlaced(28) = "R"
        ElseIf Button30.BackColor = Color.Red Then
            CountersPlaced(29) = "R"
        ElseIf Button31.BackColor = Color.Red Then
            CountersPlaced(30) = "R"
        ElseIf Button32.BackColor = Color.Red Then
            CountersPlaced(31) = "R"
        ElseIf Button33.BackColor = Color.Red Then
            CountersPlaced(32) = "R"
        ElseIf Button34.BackColor = Color.Red Then
            CountersPlaced(33) = "R"
        ElseIf Button35.BackColor = Color.Red Then
            CountersPlaced(34) = "R"
        ElseIf Button36.BackColor = Color.Red Then
            CountersPlaced(35) = "R"
        ElseIf Button37.BackColor = Color.Red Then
            CountersPlaced(36) = "R"
        ElseIf Button38.BackColor = Color.Red Then
            CountersPlaced(37) = "R"
        ElseIf Button39.BackColor = Color.Red Then
            CountersPlaced(38) = "R"
        ElseIf Button40.BackColor = Color.Red Then
            CountersPlaced(39) = "R"
        ElseIf Button41.BackColor = Color.Red Then
            CountersPlaced(40) = "R"
        ElseIf Button42.BackColor = Color.Red Then
            CountersPlaced(41) = "R"
        ElseIf Button1.BackColor = Color.Blue Then
            CountersPlaced(0) = "B"
        ElseIf Button2.BackColor = Color.Blue Then
            CountersPlaced(1) = "B"
        ElseIf Button3.BackColor = Color.Blue Then
            CountersPlaced(2) = "B"
        ElseIf Button4.BackColor = Color.Blue Then
            CountersPlaced(3) = "B"
        ElseIf Button5.BackColor = Color.Blue Then
            CountersPlaced(4) = "B"
        ElseIf Button6.BackColor = Color.Blue Then
            CountersPlaced(5) = "B"
        ElseIf Button7.BackColor = Color.Blue Then
            CountersPlaced(6) = "B"
        ElseIf Button8.BackColor = Color.Blue Then
            CountersPlaced(7) = "B"
        ElseIf Button9.BackColor = Color.Blue Then
            CountersPlaced(8) = "B"
        ElseIf Button10.BackColor = Color.Blue Then
            CountersPlaced(9) = "B"
        ElseIf Button11.BackColor = Color.Blue Then
            CountersPlaced(10) = "B"
        ElseIf Button12.BackColor = Color.Blue Then
            CountersPlaced(11) = "B"
        ElseIf Button13.BackColor = Color.Blue Then
            CountersPlaced(12) = "B"
        ElseIf Button14.BackColor = Color.Blue Then
            CountersPlaced(13) = "B"
        ElseIf Button15.BackColor = Color.Blue Then
            CountersPlaced(14) = "B"
        ElseIf Button16.BackColor = Color.Blue Then
            CountersPlaced(15) = "B"
        ElseIf Button17.BackColor = Color.Blue Then
            CountersPlaced(16) = "B"
        ElseIf Button18.BackColor = Color.Blue Then
            CountersPlaced(17) = "B"
        ElseIf Button19.BackColor = Color.Blue Then
            CountersPlaced(18) = "B"
        ElseIf Button20.BackColor = Color.Blue Then
            CountersPlaced(19) = "B"
        ElseIf Button21.BackColor = Color.Blue Then
            CountersPlaced(20) = "B"
        ElseIf Button22.BackColor = Color.Blue Then
            CountersPlaced(21) = "B"
        ElseIf Button23.BackColor = Color.Blue Then
            CountersPlaced(22) = "B"
        ElseIf Button24.BackColor = Color.Blue Then
            CountersPlaced(23) = "B"
        ElseIf Button25.BackColor = Color.Blue Then
            CountersPlaced(24) = "B"
        ElseIf Button26.BackColor = Color.Blue Then
            CountersPlaced(25) = "B"
        ElseIf Button27.BackColor = Color.Blue Then
            CountersPlaced(26) = "B"
        ElseIf Button28.BackColor = Color.Blue Then
            CountersPlaced(27) = "B"
        ElseIf Button29.BackColor = Color.Blue Then
            CountersPlaced(28) = "B"
        ElseIf Button30.BackColor = Color.Blue Then
            CountersPlaced(29) = "B"
        ElseIf Button31.BackColor = Color.Blue Then
            CountersPlaced(30) = "B"
        ElseIf Button32.BackColor = Color.Blue Then
            CountersPlaced(31) = "B"
        ElseIf Button33.BackColor = Color.Blue Then
            CountersPlaced(32) = "B"
        ElseIf Button34.BackColor = Color.Blue Then
            CountersPlaced(33) = "B"
        ElseIf Button35.BackColor = Color.Blue Then
            CountersPlaced(34) = "B"
        ElseIf Button36.BackColor = Color.Blue Then
            CountersPlaced(35) = "B"
        ElseIf Button37.BackColor = Color.Blue Then
            CountersPlaced(36) = "B"
        ElseIf Button38.BackColor = Color.Blue Then
            CountersPlaced(37) = "B"
        ElseIf Button39.BackColor = Color.Blue Then
            CountersPlaced(38) = "B"
        ElseIf Button40.BackColor = Color.Blue Then
            CountersPlaced(39) = "B"
        ElseIf Button41.BackColor = Color.Blue Then
            CountersPlaced(40) = "B"
        ElseIf Button42.BackColor = Color.Blue Then
            CountersPlaced(41) = "B"
        End If
        Return True
    End Function

    Private Sub OnevOneButton_Click(sender As Object, e As EventArgs) Handles OnevOneButton.Click
        OnevOneButton.Hide()
        PictureBox2.Hide()
        AiButton.Hide()

    End Sub

    Private Sub AiButton_Click(sender As Object, e As EventArgs) Handles AiButton.Click
        OnevOneButton.Hide()
        PictureBox2.Hide()
        AiButton.Hide()

    End Sub
End Class
