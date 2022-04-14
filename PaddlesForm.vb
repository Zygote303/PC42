Public Class PaddlesForm
    Private Sub PaddleStopButton_Click(sender As Object, e As EventArgs) Handles PaddleStopButton.Click

        PBIND1.BackColor = Color.Red
        PBIND2.BackColor = Color.Red
        PBIND3.BackColor = Color.Red
        PBIND4.BackColor = Color.Red
        Fryer.FPLDOffImage.Visible = True
        Fryer.FPLDOnImage.Visible = False
        FryerButtonScreen.PaddleButtonOn.Visible = False
        FryerButtonScreen.PaddleButtonStandby.Visible = True

    End Sub

    Private Sub PaddleStartButton_Click(sender As Object, e As EventArgs) Handles PaddleStartButton.Click

        PBIND1.BackColor = Color.Lime
        PBIND2.BackColor = Color.Lime
        PBIND3.BackColor = Color.Lime
        PBIND4.BackColor = Color.Lime
        Fryer.FPLDOffImage.Visible = False
        Fryer.FPLDOnImage.Visible = True
        FryerButtonScreen.PaddleButtonOn.Visible = True
        FryerButtonScreen.PaddleButtonStandby.Visible = False

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Visible = False
    End Sub

    Private Sub PaddlesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Location = Windows.Forms.Cursor.Position
        Me.Top = Me.Top - (Me.Height / 1.1)
        Me.Left = Me.Left - (Me.Width / 2)

    End Sub
End Class