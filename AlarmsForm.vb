Public Class AlarmsForm

    Private Sub FryerCloseButton_Click(sender As Object, e As EventArgs) Handles FryerCloseButton.Click

        Me.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Fryer.AlarmFlag = False
        My.Computer.Audio.Stop()

    End Sub

    Private Sub TextBox27_TextChanged(sender As Object, e As EventArgs) Handles Alarm2TimeText.TextChanged

    End Sub

    Private Sub AlarmsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class