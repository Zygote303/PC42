Public Class SubmergerForm
    Private Sub SubMergerStopButton_Click(sender As Object, e As EventArgs) Handles SubMergerStopButton.Click
        SIND1.BackColor = Color.Red
        SIND2.BackColor = Color.Red
        SIND3.BackColor = Color.Red
        SIND4.BackColor = Color.Red
        Fryer.FSubOffImage.Visible = True
        Fryer.FSubOnImage.Visible = False
        FryerButtonScreen.SubMergOffButton.Visible = True
        FryerButtonScreen.SubMergOnButton.Visible = False

    End Sub

    Private Sub SubmergerStartButton_Click(sender As Object, e As EventArgs) Handles SubmergerStartButton.Click

        SIND1.BackColor = Color.Lime
        SIND2.BackColor = Color.Lime
        SIND3.BackColor = Color.Lime
        SIND4.BackColor = Color.Lime
        Fryer.FSubOffImage.Visible = False
        Fryer.FSubOnImage.Visible = True
        FryerButtonScreen.SubMergOffButton.Visible = False
        FryerButtonScreen.SubMergOnButton.Visible = True

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click

        Me.Visible = False

    End Sub

    Private Sub SubmergerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Location = Windows.Forms.Cursor.Position
        Me.Top = Me.Top - (Me.Height / 1.1)
        Me.Left = Me.Left - (Me.Width / 2)



    End Sub
End Class