Public Class CalculatorForm

    Dim Number1 As Decimal = NULL
    Dim Number2 As Decimal = NULL
    Dim Operator1 As Decimal = NULL
    Dim ClearFlag As Boolean = False
    Dim DecFlag As Boolean = False

    Const DIVIDE = 6
    Const ADDITION = 1
    Const MULTIPLY = 2
    Const SUBTRACT = 4
    Const COMPUTE = 5
    Const NULL = -0.00001

    Private Sub CalculatorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SevenButton_Click(sender As Object, e As EventArgs) Handles SevenButton.Click

        If ClearFlag = True Then

            CalcScreen.Text = "0"
            ClearFlag = False
            DecFlag = False

        End If

        If CalcScreen.Text <> "0" Then
            CalcScreen.Text = CalcScreen.Text & "7"
        Else
            CalcScreen.Text = "7"
        End If

    End Sub

    Private Sub EightButton_Click(sender As Object, e As EventArgs) Handles EightButton.Click

        If ClearFlag = True Then

            CalcScreen.Text = 0
            ClearFlag = False
            DecFlag = False

        End If

        If CalcScreen.Text <> "0" Then
            CalcScreen.Text = CalcScreen.Text & "8"
        Else
            CalcScreen.Text = "8"
        End If


    End Sub

    Private Sub NineButton_Click(sender As Object, e As EventArgs) Handles NineButton.Click

        If ClearFlag = True Then

            CalcScreen.Text = 0
            ClearFlag = False
            DecFlag = False

        End If

        If CalcScreen.Text <> "0" Then
            CalcScreen.Text = CalcScreen.Text & "9"
        Else
            CalcScreen.Text = "9"
        End If

    End Sub

    Private Sub FourButton_Click(sender As Object, e As EventArgs) Handles FourButton.Click

        If ClearFlag = True Then

            CalcScreen.Text = 0
            ClearFlag = False
            DecFlag = False

        End If

        If CalcScreen.Text <> "0" Then
            CalcScreen.Text = CalcScreen.Text & "4"
        Else
            CalcScreen.Text = "4"
        End If

    End Sub

    Private Sub FiveButton_Click(sender As Object, e As EventArgs) Handles FiveButton.Click

        If ClearFlag = True Then

            CalcScreen.Text = 0
            ClearFlag = False
            DecFlag = False

        End If

        If CalcScreen.Text <> "0" Then
            CalcScreen.Text = CalcScreen.Text & "5"
        Else
            CalcScreen.Text = "5"
        End If

    End Sub

    Private Sub SixButton_Click(sender As Object, e As EventArgs) Handles SixButton.Click

        If ClearFlag = True Then

            CalcScreen.Text = 0
            ClearFlag = False
            DecFlag = False

        End If

        If CalcScreen.Text <> "0" Then
            CalcScreen.Text = CalcScreen.Text & "6"
        Else
            CalcScreen.Text = "6"
        End If

    End Sub

    Private Sub OneButton_Click(sender As Object, e As EventArgs) Handles OneButton.Click

        If ClearFlag = True Then

            CalcScreen.Text = 0
            ClearFlag = False
            DecFlag = False

        End If

        If CalcScreen.Text <> "0" Then
            CalcScreen.Text = CalcScreen.Text & "1"
        Else
            CalcScreen.Text = "1"
        End If

    End Sub

    Private Sub TwoButton_Click(sender As Object, e As EventArgs) Handles TwoButton.Click

        If ClearFlag = True Then

            CalcScreen.Text = 0
            ClearFlag = False
            DecFlag = False

        End If

        If CalcScreen.Text <> "0" Then
            CalcScreen.Text = CalcScreen.Text & "2"
        Else
            CalcScreen.Text = "2"
        End If

    End Sub

    Private Sub ThreeButton_Click(sender As Object, e As EventArgs) Handles ThreeButton.Click

        If ClearFlag = True Then

            CalcScreen.Text = 0
            ClearFlag = False
            DecFlag = False

        End If

        If CalcScreen.Text <> "0" Then
            CalcScreen.Text = CalcScreen.Text & "3"
        Else
            CalcScreen.Text = "3"
        End If

    End Sub

    Private Sub ZeroButton_Click(sender As Object, e As EventArgs) Handles ZeroButton.Click

        If ClearFlag = True Then

            CalcScreen.Text = 0
            ClearFlag = False
            DecFlag = False

        End If

        If CalcScreen.Text <> "0" Then
            CalcScreen.Text = CalcScreen.Text & "0"
        Else
            CalcScreen.Text = "0"
        End If

    End Sub

    Private Sub DivideButton_Click(sender As Object, e As EventArgs) Handles DivideButton.Click

        If CDec(CalcScreen.Text) <> 0 And Number2 = NULL And Operator1 = NULL Then

            ClearFlag = True
            Number1 = CDec(CalcScreen.Text)
        Else

            ComputeIt()

        End If

        Operator1 = DIVIDE


    End Sub

    Sub ComputeIt()

        Number2 = CDec(CalcScreen.Text)

        If Number1 > 10000000 Or Number2 > 1000000 Then

            Number1 = NULL
            Number2 = NULL
            Operator1 = NULL
            ClearFlag = True
            CalcScreen.Text = "Size - Error"
            Return

        End If

        If Operator1 = DIVIDE Then


            If Number2 = 0 Then

                CalcScreen.Text = "Div 0 - Error"
                ClearFlag = True
                Return

            Else CalcScreen.Text = Format(Number1 / Number2, "0.000")
            End If
        End If

        If Operator1 = MULTIPLY Then CalcScreen.Text = Format(Number1 * Number2, "0.000")

        If Operator1 = ADDITION Then CalcScreen.Text = Format(Number1 + Number2, "0.000")

        If Operator1 = SUBTRACT Then CalcScreen.Text = Format(Number1 - Number2, "0.000")

        Number1 = CDec(CalcScreen.Text)
        Number2 = NULL
        Operator1 = NULL
        ClearFlag = True


    End Sub


    Friend Sub EqualButton_Click(sender As Object, e As EventArgs) Handles EqualButton.Click

        ComputeIt()

    End Sub

    Private Sub MultiplyButton_Click(sender As Object, e As EventArgs) Handles MultiplyButton.Click

        If CDec(CalcScreen.Text) <> 0 And Number2 = NULL And Operator1 = NULL Then

            ClearFlag = True
            Number1 = CDec(CalcScreen.Text)
        Else

            ComputeIt()

        End If

        Operator1 = MULTIPLY


    End Sub

    Private Sub PlusButton_Click(sender As Object, e As EventArgs) Handles PlusButton.Click

        If CDec(CalcScreen.Text) <> 0 And Number2 = NULL And Operator1 = NULL Then

            ClearFlag = True
            Number1 = CDec(CalcScreen.Text)
        Else

            ComputeIt()

        End If

        Operator1 = ADDITION


    End Sub

    Private Sub MinusButton_Click(sender As Object, e As EventArgs)

        If CDec(CalcScreen.Text) <> 0 And Number2 = NULL And Operator1 = NULL Then

            ClearFlag = True
            Number1 = CDec(CalcScreen.Text)
        Else

            ComputeIt()

        End If

        Operator1 = SUBTRACT

    End Sub

    Private Sub MemoryButton_Click(sender As Object, e As EventArgs) Handles MemoryButton.Click

        CalcScreen.Text = 0
        ClearFlag = False
        Number1 = NULL
        Number2 = NULL
        Operator1 = NULL
        DecFlag = False

    End Sub

    Private Sub PeriodButton_Click(sender As Object, e As EventArgs) Handles PeriodButton.Click

        If ClearFlag = True Then

            CalcScreen.Text = 0
            ClearFlag = False
            DecFlag = False

        End If

        If DecFlag = False Then
            CalcScreen.Text = CalcScreen.Text & "."
            DecFlag = True
        End If

    End Sub
End Class