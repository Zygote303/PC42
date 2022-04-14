Public Class FryerArrayData
    Private Sub RecordButtonMinus1_Click(sender As Object, e As EventArgs) Handles RecordButtonMinus1.Click

        If CDec(Val(RecordText1Text.Text)) > 0 Then RecordText1Text.Text = CDec(Val(RecordText1Text.Text)) - 1

    End Sub

    Private Sub RecordButtonMinus2_Click(sender As Object, e As EventArgs) Handles RecordButtonMinus2.Click

        If CDec(Val(RecordText2Text.Text)) > 0 Then RecordText2Text.Text = CDec(Val(RecordText2Text.Text)) - 1


    End Sub

    Private Sub RecordButtonMinus3_Click(sender As Object, e As EventArgs) Handles RecordButtonMinus3.Click

        If CDec(Val(RecordText3Text.Text)) > 0 Then RecordText3Text.Text = CDec(Val(RecordText3Text.Text)) - 1

    End Sub

    Private Sub RecordButtonPlus1_Click(sender As Object, e As EventArgs) Handles RecordButtonPlus1.Click

        If CDec(Val(RecordText1Text.Text)) < 160 Then RecordText1Text.Text = CDec(Val(RecordText1Text.Text)) + 1

    End Sub

    Private Sub RecordButtonPlus2_Click(sender As Object, e As EventArgs) Handles RecordButtonPlus2.Click

        If CDec(Val(RecordText2Text.Text)) < 160 Then RecordText2Text.Text = CDec(Val(RecordText2Text.Text)) + 1

    End Sub

    Private Sub RecordButtonPlus3_Click(sender As Object, e As EventArgs) Handles RecordButtonPlus3.Click

        If CDec(Val(RecordText3Text.Text)) < 160 Then RecordText3Text.Text = CDec(Val(RecordText3Text.Text)) + 1

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CloseFryerArrayCBButton.Click

        Fryer.FryerArrayCB.Checked = False


    End Sub
End Class