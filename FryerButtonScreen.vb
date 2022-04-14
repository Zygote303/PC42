Public Class FryerButtonScreen
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles MainOilPumpStandby.Click

        MainOilPumpDialog.Visible = True
        MainOilPumpDialog.TopMost = True

    End Sub

    Private Sub MainOilPumpOn_Click(sender As Object, e As EventArgs) Handles MainOilPumpOn.Click

        MainOilPumpDialog.Visible = True
        MainOilPumpDialog.TopMost = True

    End Sub

    Private Sub MainOilPumpStartButton_Click(sender As Object, e As EventArgs) Handles FryerCloseButton.Click

        Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles PaddleButtonOn.Click

        PaddlesForm.Visible = True
        PaddlesForm.TopMost = True


    End Sub

    Private Sub PaddleButtonStandby_Click(sender As Object, e As EventArgs) Handles PaddleButtonStandby.Click

        PaddlesForm.Visible = True
        PaddlesForm.TopMost = True



    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub SubMergOffButton_Click(sender As Object, e As EventArgs) Handles SubMergOffButton.Click

        SubmergerForm.Visible = True
        SubmergerForm.TopMost = True

    End Sub

    Private Sub SubMergOnButton_Click(sender As Object, e As EventArgs) Handles SubMergOnButton.Click

        SubmergerForm.Visible = True
        SubmergerForm.TopMost = True

    End Sub



    Private Sub RejectGateManualButton_Click(sender As Object, e As EventArgs) Handles RejectGateManualButton.Click

        OilMakeupCloseButton.Visible = True
        OilMakeupCloseButton.Select()
        OilMakeupOpenButton.Visible = True
        OMMCLabel.Visible = True
        OMAutoOnImage.Visible = False


    End Sub

    Private Sub OilMakeupCloseButton_Click(sender As Object, e As EventArgs) Handles OilMakeupCloseButton.Click

        ValveOpenImage.Visible = False
        ValveCloseImage.Visible = True
        Fryer.OMUVOffImage.Visible = True
        Fryer.OMUVOnImage.Visible = False

    End Sub

    Private Sub OilMakeupOpenButton_Click(sender As Object, e As EventArgs) Handles OilMakeupOpenButton.Click

        ValveOpenImage.Visible = True
        ValveCloseImage.Visible = False
        Fryer.OMUVOffImage.Visible = False
        Fryer.OMUVOnImage.Visible = True


    End Sub

    Private Sub OilMakeupAutoButton_Click(sender As Object, e As EventArgs) Handles OilMakeupAutoButton.Click

        OilMakeupCloseButton.Visible = False
        OilMakeupOpenButton.Visible = False
        OMMCLabel.Visible = False
        OMAutoOnImage.Visible = True
        ValveOpenImage.Visible = False
        ValveCloseImage.Visible = True
        Fryer.OMUVOffImage.Visible = True
        Fryer.OMUVOnImage.Visible = False

    End Sub
End Class