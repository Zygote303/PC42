Public Class SplashScreen

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick



        If ProgressBar1.Value = 100 Then
            ControlScreenForm.Visible = True
            Timer1.Enabled = False
            Me.Visible = False

        End If

        ProgressBar1.PerformStep()

    End Sub


End Class