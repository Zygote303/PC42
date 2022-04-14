Public Class ControlScreenForm

    Friend ButtonSelectedFlag As Integer = True ' Indicates which button was pressed on control form

    Friend Const FREEFRYER = 1
    Friend Const BASICS = 2
    Friend Const TITRATION = 3
    Friend Const SLICERS = 4
    Friend Const PAETESTING = 5


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles FreeFryerButton.Click


        ButtonSelectedFlag = FREEFRYER
        Me.Visible = False
        Fryer.Visible = True

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BasicsButton.Click

        Me.Visible = False
        Fryer.Visible = True
        Fryer.Enabled = False
        TutorialSelectionPanelForm.Visible = True
        TutorialSelectionPanelForm.TopMost = True

    End Sub

    Private Sub TitrationButton_Click(sender As Object, e As EventArgs)

        ButtonSelectedFlag = TITRATION
        Me.Visible = False
        TitrationForm.Visible = True


    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

        ButtonSelectedFlag = PAETESTING
        Me.Visible = False
        PAETestingForm.Visible = True

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click

        ButtonSelectedFlag = TITRATION
        Me.Visible = False
        TitrationForm.Visible = True

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        ButtonSelectedFlag = PAETESTING
        Me.Visible = False
        PAETestingForm.Visible = True

    End Sub

    Private Sub PAEMemoryGame_Click(sender As Object, e As EventArgs) Handles PAEMemoryGame.Click

        ButtonSelectedFlag = SLICERS
        Me.Visible = False
        SlicersForm.Visible = True

    End Sub
End Class