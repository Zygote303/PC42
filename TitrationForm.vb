Public Class TitrationForm

    Dim TargetEP As Integer
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Me.Close()
        ControlScreenForm.Visible = True

    End Sub

    Private Sub AddOilButton1_Click(sender As Object, e As EventArgs) Handles AddOilButton1.Click

        Dim MyMin As Decimal
        Dim MyMax As Decimal
        Dim Generator As System.Random = New System.Random()
        Dim Pour As Decimal
        Dim DecPar As Decimal


        ' Get a random number >= MyMin and <= MyMax

        MyMin = 28.1
        MyMax = 28.4
        Pour = Generator.Next(MyMin, MyMax + 1)

        MyMin = 1
        MyMax = 3
        DecPar = Generator.Next(MyMin, MyMax + 1)

        DecPar /= 9

        Pour += DecPar

        If CDec(Val(ScalesOutputLabel.Text)) > 0 Then Return

        ScalesOutputLabel.Text = Format(Pour, "0.00 g.")

        Flasks()

    End Sub

    Private Sub ZeroScalesButton_Click(sender As Object, e As EventArgs) Handles ZeroScalesButton.Click

        ScalesOutputLabel.Text = Format(0, "0.0 g.")
        AddOilButton1.Enabled = True
        AddDropButton1.Enabled = True
        RemoveDropButton1.Enabled = True
        ZeroScalesButton.Enabled = False

        Flasks()

        InstructionText.Text = "Now that we have zeroed the scales we can add some oil to the flask.

We will be adding exactly 28.20 ml of oil to the flask and will do so using a jug and pipettes.

Step 1 - Click the jug icon next to the scales to add some oil to the flask.

Step 2 - Using the Pipettes buttons under the Jug will allow you to add and remove small amounts of oil.

Step 3 - When the scales turn green we have completed our task and can move to the next stage by clicking the Go to Step 2 Button."

    End Sub

    Private Sub AddDropButton1_Click(sender As Object, e As EventArgs) Handles AddDropButton1.Click

        If Step2Button.Enabled = True Then Return

        If CDec(Val(ScalesOutputLabel.Text)) <= 0 Then Return

        ScalesOutputLabel.Text = Format(CDec(Val(ScalesOutputLabel.Text)) + 0.01, "0.00 g.")

        If CDec(Val(ScalesOutputLabel.Text)) = 28.2 Then
            Step2Button.Enabled = True
            ScalesOutputLabel.ForeColor = Color.LimeGreen
        End If

        Flasks()




    End Sub

    Private Sub Flasks()

        If CDec(Val(ScalesOutputLabel.Text)) < 28.2 Then

            EmptyFlask.Visible = False
            FillingFlask2.Visible = False
            FillingFlask1.Visible = True
            FullFlask.Visible = False

        End If

        If CDec(Val(ScalesOutputLabel.Text)) > 28.2 Then

            EmptyFlask.Visible = False
            FillingFlask2.Visible = False
            FillingFlask1.Visible = True
            FullFlask.Visible = True

        End If

        If CDec(Val(ScalesOutputLabel.Text)) = 28.2 Then

            EmptyFlask.Visible = False
            FillingFlask2.Visible = True
            FillingFlask1.Visible = False
            FullFlask.Visible = False

        End If

        If CDec(Val(ScalesOutputLabel.Text)) = 0 Then

            EmptyFlask.Visible = True
            FillingFlask2.Visible = False
            FillingFlask1.Visible = False
            FullFlask.Visible = False

        End If


    End Sub

    Private Sub RemoveDropButton1_Click(sender As Object, e As EventArgs) Handles RemoveDropButton1.Click

        If Step2Button.Enabled = True Then Return

        If CDec(Val(ScalesOutputLabel.Text)) <= 0 Then Return

        If CDec(Val(ScalesOutputLabel.Text)) > 0.01 Then ScalesOutputLabel.Text = Format(CDec(Val(ScalesOutputLabel.Text)) - 0.01, "0.00 g.")

        If CDec(Val(ScalesOutputLabel.Text)) = 28.2 Then
            Step2Button.Enabled = True
            ScalesOutputLabel.ForeColor = Color.LimeGreen
        End If

        Flasks()

    End Sub

    Private Sub Step2Button_Click(sender As Object, e As EventArgs) Handles Step2Button.Click


        TitrationTabControl.SelectedIndex = 1

        GB1.Enabled = False
        GB2.Enabled = True
        GB3.Enabled = False

        InstructionText.Text = "Now that we have 28.20 ml of test oil in our flask we need to run the flask under cool water until the temperature of the oil is reduced to between 25 to 30 degrees C.

1. Click the thermometer icon first to get the current temperature of the oil.

2. Click the Run Water button to cool the oil down to the proper temperature for the FFA test.

3. Click the Go to Step 3 button to go to the next step in the process once the temperature is in the green"



    End Sub

    Private Sub TitrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GB1.Enabled = True
        GB2.Enabled = False
        GB3.Enabled = False

        SITEMP.Text = TemperatureOutputLabel.Text

        InstructionText.Text = "The first step in the process of determining the free fatty acid concentration of our oil is to weigh the correct amount of oil in a chemical flask.

As our flask itself has some weight to it we first need to Zero the scales after placing the flask on the scales.  

Click the Zero button to Zero the scales and remove the weight of the flask from the final result."

    End Sub

    Private Sub TitrateButton_Click(sender As Object, e As EventArgs) Handles Step3Button.Click

        TitrationTabControl.SelectedIndex = 2
        SITEMP.Text = TemperatureOutputLabel.Text
        GB1.Enabled = False
        GB2.Enabled = False
        GB3.Enabled = True

        InstructionText.Text = "Ok now we have 28.20 ml of test oil cooled down to between 25 to 30 degrees C.   Lets now add the chemicals to our oil that we need to perform our FFA test.

1. Click the NUETRALIZED METHYLATED SPIRITS button to add Nuetralized Methylated Spirits - Reagent Grade 95% alcohol to the oil in the flask.

2. Click the PENOLPHTHALEIN 1% button to add penolphthalein to the oil in the flask.

3. Click the Go to Step 4 button to move to the Titration step so we can find out how much FFA's are in our oil."


    End Sub

    Private Sub ThermometreButton_Click(sender As Object, e As EventArgs) Handles ThermometreButton.Click

        Static Dim StartFlag As Boolean = False
        Static Dim MyMin As Decimal = 60
        Static Dim MyMax As Decimal = 90
        Dim MyDecMin As Decimal
        Dim MyDecMax As Decimal
        Dim Generator As System.Random = New System.Random()
        Static Dim Temp As Decimal
        Dim DecPar As Decimal

        If StartFlag = True Then Return

        ' Get a random number >= MyMin and <= MyMax

        Temp = Generator.Next(MyMin, MyMax + 1)


        MyDecMin = 1
        MyDecMax = 9
        DecPar = Generator.Next(MyDecMin, MyDecMax + 1)

        DecPar /= 9

        Temp += DecPar

        TemperatureOutputLabel.Text = Format(Temp, "0.00 C")

        StartFlag = True

    End Sub

    Private Sub CoolTimer_Tick(sender As Object, e As EventArgs) Handles CoolTimer.Tick

        If CDec(Val(TemperatureOutputLabel.Text)) < 30 And CDec(Val(TemperatureOutputLabel.Text)) > 25 Then
            TemperatureOutputLabel.ForeColor = Color.LimeGreen
            Step3Button.Enabled = True
            CoolTimer.Enabled = False
            Return
        End If

        TemperatureOutputLabel.Text = Format(CDec(Val(TemperatureOutputLabel.Text)) - 0.4, "0.0 C")



    End Sub

    Private Sub RWButton_Click(sender As Object, e As EventArgs) Handles RWButton.Click

        Static Dim CoolingFlag As Boolean = False

        If CoolingFlag = False Then
            CoolTimer.Enabled = True
            CoolingFlag = True
        Else
            CoolTimer.Enabled = False
            CoolingFlag = False
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        SHTick.Visible = True
        Button2.Enabled = False
        Button4.Enabled = True
        If SHTick.Visible = True And PTick.Visible = True Then Step4Button.Enabled = True

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        PTick.Visible = True
        Button4.Enabled = False
        If SHTick.Visible = True And PTick.Visible = True Then Step4Button.Enabled = True

    End Sub

    Private Sub Step4Button_Click(sender As Object, e As EventArgs) Handles Step4Button.Click

        TitrationTabControl.SelectedIndex = 3

        GB1.Enabled = False
        GB2.Enabled = False
        GB3.Enabled = False
        GB4.Enabled = True

        InstructionText.Text = "Titration requires you to agitate flask in your hand while turning the stopcock on the burette slowly to allow the solution to mix into the flask.  You must then watch closely for the solution to turn pink and then close the stopcock to end the titration.

1. Start agitating the flask by clicking the Agitate button.

2. Start the titration by clicking the Start button.

3. Watch the flask very closely and click the Stop button when the flask turns pink."



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Static Dim RotateFlag As Boolean = False

        If RotateFlag = False Then
            AgitateTimer.Enabled = True
            RotateFlag = True
            Button1.Enabled = False
            Button3.Enabled = True
        End If


    End Sub

    Private Sub AgitateTimer_Tick(sender As Object, e As EventArgs) Handles AgitateTimer.Tick

        Static Dim RFlag As Integer = 0

        Select Case RFlag
            Case 0

                RFillingFlask1.Visible = False
                RFillingFlask2.Visible = False
                RFillingFlask3.Visible = True

                RFlag = 1


            Case 1

                RFillingFlask1.Visible = False
                RFillingFlask2.Visible = True
                RFillingFlask3.Visible = False

                RFlag = 2

            Case 2

                RFillingFlask1.Visible = True
                RFillingFlask2.Visible = False
                RFillingFlask3.Visible = False

                RFlag = 0

        End Select

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Static Dim TFlag As Boolean = False

        If TFlag = False Then

            TitrationTimer.Enabled = True
            TFlag = True
            Button3.Text = "STOP"

        Else
            TitrationTimer.Enabled = False
            TFlag = False
            Button3.Text = "START"


            YourEndpoint.Text = FFAResult.Text
            TargetEndpoint.Text = TargetEP
            If Int(FFAResult.Text) = Int(TargetEndpoint.Text) Then YourEndpoint.ForeColor = Color.LimeGreen
            If Int(FFAResult.Text) = Int(TargetEndpoint.Text) + 1 Then YourEndpoint.ForeColor = Color.LightYellow
            If Int(FFAResult.Text) = Int(TargetEndpoint.Text) - 1 Then YourEndpoint.ForeColor = Color.LightYellow
            If Int(FFAResult.Text) < Int(TargetEndpoint.Text) - 1 Then YourEndpoint.ForeColor = Color.Red
            If Int(FFAResult.Text) > Int(TargetEndpoint.Text) + 1 Then YourEndpoint.ForeColor = Color.Red



            InstructionText.Text = "And that's the basic method used for determining FFA with Titration.  


Some interesting facts about the process:

1. Oliec Acid (the predominant acid formed in frying) has a molecular weight of 282.47 g/mole.  Divide by 10 and you get 28.20

2. The lightest pink colour that lasts for more than 10 seconds is the End Point (most accurate measurement) of a titration.

3. Phenolpthalein is pink in basic solutions and clear in acidic solutions."


        End If


    End Sub

    Private Sub TitrationTimer_Tick(sender As Object, e As EventArgs) Handles TitrationTimer.Tick

        Static StartFlag As Boolean = False
        Static Dim RFlag As Integer = 0
        Dim Generator As Random
        Static Dim FFA As Integer
        Static Dim Counter As Integer = 0

        Generator = New System.Random()

        AgitateTimer.Enabled = False

        If Counter >= 200 Then Return

        If StartFlag = False Then
            StartFlag = True
            FFA = Generator.Next(14, 39)
            TargetEndpoint.Text = "?"
            TargetEP = FFA
        End If

        If (Counter / 4.3) >= FFA Then

            RTFillingFlask3.Visible = False
            RTFillingFlask4.Visible = False
            RTFillingFlask5.Visible = False

            Select Case RFlag
                Case 0

                    EPFillingFlask1.Visible = False
                    EPFillingFlask2.Visible = False
                    EPFillingFlask3.Visible = True

                    RFlag = 1


                Case 1

                    EPFillingFlask1.Visible = False
                    EPFillingFlask2.Visible = True
                    EPFillingFlask3.Visible = False


                    RFlag = 2

                Case 2

                    EPFillingFlask1.Visible = True
                    EPFillingFlask2.Visible = False
                    EPFillingFlask3.Visible = False

                    RFlag = 0

            End Select


        Else


            Select Case RFlag
                Case 0

                    RTFillingFlask3.Visible = False
                    RTFillingFlask4.Visible = False
                    RTFillingFlask5.Visible = True

                    RFlag = 1


                Case 1

                    RTFillingFlask3.Visible = False
                    RTFillingFlask4.Visible = True
                    RTFillingFlask5.Visible = False

                    RFlag = 2

                Case 2

                    RTFillingFlask3.Visible = True
                    RTFillingFlask4.Visible = False
                    RTFillingFlask5.Visible = False

                    RFlag = 0

            End Select

        End If

        Miniscus.Top = Miniscus.Top + 1
        Counter += 1

        Chem3Text.Text = Int(Counter / 4.3) & " ml 0.1N Sodium Hydroxide"
        FFAResult.Text = Int(Counter / 4.3)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles FFAResult.Click


    End Sub

    Private Sub TargetEndpoint_Click(sender As Object, e As EventArgs) Handles TargetEndpoint.Click

    End Sub
End Class