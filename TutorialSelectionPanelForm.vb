Public Class TutorialSelectionPanelForm


    Private Sub FOITStart_Click(sender As Object, e As EventArgs) Handles FOITStart.Click

        ControlScreenForm.ButtonSelectedFlag = FryerHMITutForm.BASICS

        Fryer.Visible = True
        Fryer.Enabled = True
        FryerHMITutForm.Visible = True
        FryerHMITutForm.TopMost = True
        Me.Close()

    End Sub

    Private Sub FOHMIStart_Click(sender As Object, e As EventArgs) Handles FOHMIStart.Click

        ControlScreenForm.ButtonSelectedFlag = FryerHMITutForm.HMITUT

        Fryer.Visible = True
        Fryer.Enabled = True
        FryerHMITutForm.Visible = True
        FryerHMITutForm.TopMost = True
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles TutorialSelectExitButton.Click

        My.Application.OpenForms.Cast(Of Form)() _
              .Except({ControlScreenForm, SplashScreen}) _
              .ToList() _
              .ForEach(Sub(form) form.Close())

        ControlScreenForm.Visible = True

    End Sub

    Private Sub FryerHMIINtroButton_Click(sender As Object, e As EventArgs) Handles FryerHMIINtroButton.Click

        ControlScreenForm.ButtonSelectedFlag = FryerHMITutForm.HMITUT

        Fryer.Visible = True
        Fryer.Enabled = True
        FryerHMITutForm.Visible = True
        FryerHMITutForm.TopMost = True
        Me.Close()

    End Sub

    Private Sub FryerOpsIntroButton_Click(sender As Object, e As EventArgs) Handles FryerOpsIntroButton.Click

        ControlScreenForm.ButtonSelectedFlag = FryerHMITutForm.BASICS

        Fryer.Visible = True
        Fryer.Enabled = True
        FryerHMITutForm.Visible = True
        FryerHMITutForm.TopMost = True
        Me.Close()

    End Sub

    Private Sub Label97_Click(sender As Object, e As EventArgs) Handles Label97.Click

        ControlScreenForm.ButtonSelectedFlag = FryerHMITutForm.BASICS

        Fryer.Visible = True
        Fryer.Enabled = True
        FryerHMITutForm.Visible = True
        FryerHMITutForm.TopMost = True
        Me.Close()

    End Sub

    Private Sub Label107_Click(sender As Object, e As EventArgs) Handles Label107.Click

        ControlScreenForm.ButtonSelectedFlag = FryerHMITutForm.HMITUT

        Fryer.Visible = True
        Fryer.Enabled = True
        FryerHMITutForm.Visible = True
        FryerHMITutForm.TopMost = True
        Me.Close()

    End Sub

    Private Sub CFSTStart_Click(sender As Object, e As EventArgs) Handles CFSTStart.Click

        ControlScreenForm.ButtonSelectedFlag = FryerHMITutForm.SIMTUT

        Fryer.Visible = True
        Fryer.Enabled = True
        FryerHMITutForm.Visible = True
        FryerHMITutForm.TopMost = True
        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        ControlScreenForm.ButtonSelectedFlag = FryerHMITutForm.SIMTUT

        Fryer.Visible = True
        Fryer.Enabled = True
        FryerHMITutForm.Visible = True
        FryerHMITutForm.TopMost = True
        Me.Close()

    End Sub

    Private Sub ContFryerSimButton_Click(sender As Object, e As EventArgs) Handles ContFryerSimButton.Click

        ControlScreenForm.ButtonSelectedFlag = FryerHMITutForm.SIMTUT

        Fryer.Visible = True
        Fryer.Enabled = True
        FryerHMITutForm.Visible = True
        FryerHMITutForm.TopMost = True
        Me.Close()

    End Sub
End Class