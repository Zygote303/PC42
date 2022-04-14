Public Class MainOilPumpDialog
    Private Sub MainOilPumpStopButton_Click(sender As Object, e As EventArgs) Handles MainOilPumpStopButton.Click

        MOPIND1.BackColor = Color.Red
        MOPIND2.BackColor = Color.Red
        MOPIND3.BackColor = Color.Red
        MOPIND4.BackColor = Color.Red
        FryerButtonScreen.MainOilPumpOn.Visible = False
        FryerButtonScreen.MainOilPumpStandby.Visible = True
        Fryer.MPumpOffImage.Visible = True
        Fryer.MPumpOnImage.Visible = False


    End Sub

    Private Sub MainOilPumpStartButton_Click(sender As Object, e As EventArgs) Handles MainOilPumpStartButton.Click

        MOPIND1.BackColor = Color.Lime
        MOPIND2.BackColor = Color.Lime
        MOPIND3.BackColor = Color.Lime
        MOPIND4.BackColor = Color.Lime

        FryerButtonScreen.MainOilPumpOn.Visible = True
        FryerButtonScreen.MainOilPumpStandby.Visible = False
        Fryer.MPumpOffImage.Visible = False
        Fryer.MPumpOnImage.Visible = True

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click

        Me.Visible = False

    End Sub

    Private Sub MainOilPumpDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Location = Windows.Forms.Cursor.Position
        Me.Left = Me.Left - (Me.Width / 2)
        Me.Top = Me.Top - (Me.Height / 1.1)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles MOPIND4.Paint

    End Sub
End Class