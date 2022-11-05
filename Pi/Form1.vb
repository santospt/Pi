Imports System.Drawing.Text

Public Class Form1
    Private Sub CheckBoxShowHide_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowHide.CheckedChanged
        If LabelPi.Visible Then
            LabelPi.Visible = False
            LabelPi.SendToBack()
            CheckBoxShowHide.Text = "&Display"
            TextBoxCurrentDigit.Enabled = True
            TextBoxCurrentDigit.Select()
        Else
            LabelPi.Visible = True
            LabelPi.BringToFront()
            CheckBoxShowHide.Text = "&Hide"
            TextBoxCurrentDigit.Enabled = False
        End If
    End Sub

    Private Sub TextBoxCurrentDigit_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCurrentDigit.TextChanged
        With TextBoxCurrentDigit
            If IsNumeric(.Text) Then
                If Len(LabelCurrentPi.Text) = 2 Then StartStopwatch()

                If LabelCurrentPi.Text & .Text = LabelPi.Text.Substring(0, Len(LabelCurrentPi.Text & .Text)) Then
                    LabelCurrentPi.Text &= .Text
                    LabelDigitCount.Text += 1
                Else
                    LabelWrongs.Text += 1
                End If
            End If
            .Text = vbNullString
        End With
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        LabelCurrentPi.Text = "3."
        LabelWrongs.Text = 0
        LabelDigitCount.Text = 0
        stopwatch.Reset()
        TextBoxCurrentDigit.Select()
    End Sub
    Private stopwatch As New Stopwatch
    Private Sub TimerPi_Tick(sender As Object, e As EventArgs) Handles TimerPi.Tick
        Dim TimeSpanElapsed As TimeSpan = stopwatch.Elapsed
        LabelElapsed.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:000}",
                                          Math.Floor(stopwatch.Elapsed.TotalHours),
                                          stopwatch.Elapsed.Minutes,
                                          stopwatch.Elapsed.Seconds,
                                          stopwatch.Elapsed.Milliseconds)
    End Sub

    Private Sub StartStopwatch()
        TimerPi.Start()
        stopwatch.Start()
    End Sub

    Private Sub ButtonStop_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click
        TimerPi.Stop()
        stopwatch.Stop()
        stopwatch.Reset()
        MsgBox("Good Job!" & vbCrLf &
               "You did " & LabelDigitCount.Text & " digits" & vbCrLf &
               "With " & LabelWrongs.Text & " wrong(s)" & vbCrLf &
               "In " & LabelElapsed.Text, Title:="Congrats")
        ButtonReset_Click(Nothing, Nothing)
        TextBoxCurrentDigit.Select()
    End Sub
End Class
