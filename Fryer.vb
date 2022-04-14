Public Class Fryer


    ' Global Slicer Variables

    Dim TutorialFlag As Integer             ' used to select tutorial to run

    Dim SlicerActualSpeed As Decimal        ' The speed of the slicer infeed, affected by random potato loading
    Dim SlicerActive As Boolean             ' Set to 0 when slicer not active, 1 when slicer active
    Dim SlicerCoolDown As Integer           ' Timer which activates after slicer is turned off.  Lasts default
    ' SLICERCOOLDOWNLEN = 160 seconds
    Dim SlicerAdjust As Decimal             ' Variable controlling cooling from slicer in Flame sub
    Dim SlicerCountdown = SLICERCHANGEDELAYLEN ' Controls change in timer to locked slicer up speed
    Dim SlicerSpeedUp As Decimal
    Dim SlicerAppendString As String        ' String to concatenate slicer change message to info display

    Dim Flame As Decimal                    ' the variable which controls the amount of burner heating required

    Dim InletTemp As Decimal                ' Temperature of oil entering fryer
    Dim InternalInletSetPoint As Decimal    ' Used to adjust setpoint internally distinct from displayed sp
    Dim BurnerOn As Boolean                 ' Burner Flag, 0 Burner is off, 1 Burner is on

    Dim InitFlag As Integer                 ' Intialization Flag, 0 after program starts, calls Initialize and sets to 1 

    Dim PotatoMoisture As Decimal           ' Variable which holds currently selected potato moisture


    ' Master Speed Variables

    Dim MasterSpeedRatio As Decimal         ' Unimplemented variable to change chronological masterspeed
    Dim MasterSpeedChange As Integer        ' Variable which flags that masterspeed requires value change
    Dim MasterSpeedOffset As Decimal        ' Variable holds value to reduce or increase frying dehydration


    ' Burner Variables

    Dim BurnerStartupCountdown = BURNERSTARTUPLEN       ' Delay Timer to control burner startup
    Dim BurnerShutdownCountdown = BURNERSHUTDOWNLEN     ' Delay Timer to control burner shutdown
    Dim BurnerStartingAppendString As String            ' Burner starting string to append to info display
    Dim BurnerShutDownAppendString As String            ' Burning stopping string to append to info display


    ' Misc Variables

    Dim ManualReject As Integer                 ' Set to 1 to indicate manual reject, 0 otherwise
    ' prevents autoreject from operating if set
    Dim PicIndex As Decimal                     ' Index into pictureboxes
    Dim Alarms() As TextBox                     ' Used to fill out alarm status grid in alarm panel
    Friend AlarmFlag As Boolean = False         ' Friend alarm, allows alarm to be turned off from alarm panel
    Dim MoistureValue As Decimal                ' Takes moisture from cooktimer and gives it to smoothtimer
    ' to update moisture values smoothly
    Dim LoadedValue As Boolean                  ' provides control to smoothtimer regarding value to display
    Dim DataLoadFlag As Boolean
    Dim SlicerPoliteFlag As Boolean             ' startup shutdown and slicer timers set this to ensure
    Dim BurnerStartupPoliteFlag As Boolean      ' their messages are displayed long enough to be seen
    Dim BurnerShutDownPoliteFlag As Boolean
    Dim SlicerVarianceSaved As Decimal
    Structure Fryer                         ' Fryer Structure 

        Dim OilTemp As Decimal              ' Temp of oil in each fryer compartment
        Dim Moisture As Decimal             ' Moisture component used to reduce oil temperature
        Dim TimeInFryer As Decimal          ' Bugged variable, now used as a slicer, dehydration control
        Dim TempLoaded As Boolean           ' Specifies whether the temperature code is working on loaded cell

        Dim Chips As Decimal                ' Dehydration component cell, used to get final moisture
        Dim ChipsLoaded As Boolean          ' Moisture cell, holds moisture of potato load and final product
        Dim OilFlow As Decimal              ' Speed of oil in fryer
        Dim OilViscosity As Decimal         ' Viscosity of oil in fryer

    End Structure

    Dim PIDFlag As Boolean = False

    Dim ProductStream(160) As Fryer         ' Virtual Fryer made up of 160 compartments, based on above strct

    Dim BlockArray() As TextBox = {
        FryerArrayData.T1, FryerArrayData.B1OT, FryerArrayData.B1M, FryerArrayData.B1T, FryerArrayData.B1OS,
        FryerArrayData.B1C, FryerArrayData.B1CS,
        FryerArrayData.T2, FryerArrayData.B2OT, FryerArrayData.B2M, FryerArrayData.B2T, FryerArrayData.B2OS,
        FryerArrayData.B2C, FryerArrayData.B2CS,
        FryerArrayData.T3, FryerArrayData.B3OT, FryerArrayData.B3M, FryerArrayData.B3T, FryerArrayData.B3OS,
        FryerArrayData.B3C, FryerArrayData.B3CS,
        FryerArrayData.T4, FryerArrayData.B4OT, FryerArrayData.B4M, FryerArrayData.B4T, FryerArrayData.B4OS,
        FryerArrayData.B4C, FryerArrayData.B4CS,
        FryerArrayData.T5, FryerArrayData.B5OT, FryerArrayData.B5M, FryerArrayData.B5T, FryerArrayData.B5OS,
        FryerArrayData.B5C, FryerArrayData.B5CS,
        FryerArrayData.T6, FryerArrayData.B6OT, FryerArrayData.B6M, FryerArrayData.B6T, FryerArrayData.B6OS,
        FryerArrayData.B6C, FryerArrayData.B6CS,
        FryerArrayData.T7, FryerArrayData.B7OT, FryerArrayData.B7M, FryerArrayData.B7T, FryerArrayData.B7OS,
        FryerArrayData.B7C, FryerArrayData.B7CS,
        FryerArrayData.T8, FryerArrayData.B8OT, FryerArrayData.B8M, FryerArrayData.B8T, FryerArrayData.B8OS,
        FryerArrayData.B8C, FryerArrayData.B8CS,
        FryerArrayData.T9, FryerArrayData.B9OT, FryerArrayData.B9M, FryerArrayData.B9T, FryerArrayData.B9OS,
        FryerArrayData.B9C, FryerArrayData.B9CS,
        FryerArrayData.T10, FryerArrayData.B10OT, FryerArrayData.B10M, FryerArrayData.B10T, FryerArrayData.B10OS,
        FryerArrayData.B10C, FryerArrayData.B10CS,
        FryerArrayData.T11, FryerArrayData.B11OT, FryerArrayData.B11M, FryerArrayData.B11T, FryerArrayData.B11OS,
        FryerArrayData.B11C, FryerArrayData.B11CS,
        FryerArrayData.T12, FryerArrayData.B12OT, FryerArrayData.B12M, FryerArrayData.B12T, FryerArrayData.B12OS,
        FryerArrayData.B12C, FryerArrayData.B12CS,
        FryerArrayData.T13, FryerArrayData.B13OT, FryerArrayData.B13M, FryerArrayData.B13T, FryerArrayData.B13OS,
        FryerArrayData.B13C, FryerArrayData.B13CS,
        FryerArrayData.T14, FryerArrayData.B14OT, FryerArrayData.B14M, FryerArrayData.B14T, FryerArrayData.B14OS,
        FryerArrayData.B14C, FryerArrayData.B14CS,
        FryerArrayData.T15, FryerArrayData.B15OT, FryerArrayData.B15M, FryerArrayData.B15T, FryerArrayData.B15OS,
        FryerArrayData.B15C, FryerArrayData.B15CS,
        FryerArrayData.T16, FryerArrayData.B16OT, FryerArrayData.B16M, FryerArrayData.B16T, FryerArrayData.B16OS,
        FryerArrayData.B16C, FryerArrayData.B16CS,
        FryerArrayData.T17, FryerArrayData.B17OT, FryerArrayData.B17M, FryerArrayData.B17T, FryerArrayData.B17OS,
        FryerArrayData.B17C, FryerArrayData.B17CS,
        FryerArrayData.T18, FryerArrayData.B18OT, FryerArrayData.B18M, FryerArrayData.B18T, FryerArrayData.B18OS,
        FryerArrayData.B18C, FryerArrayData.B18CS,
        FryerArrayData.T19, FryerArrayData.B19OT, FryerArrayData.B19M, FryerArrayData.B19T, FryerArrayData.B19OS,
        FryerArrayData.B19C, FryerArrayData.B19CS,
        FryerArrayData.T20, FryerArrayData.B20OT, FryerArrayData.B20M, FryerArrayData.B20T, FryerArrayData.B20OS,
        FryerArrayData.B20C, FryerArrayData.B20CS,
        FryerArrayData.T21, FryerArrayData.B21OT, FryerArrayData.B21M, FryerArrayData.B21T, FryerArrayData.B21OS,
        FryerArrayData.B21C, FryerArrayData.B21CS}



    ' Misc Constants

    Const CHIPS = 159                  ' The location in the array where the cooked chips are located
    Const BURNERSTARTUPLEN = 300       ' Timer value of startup delay
    Const BURNERSHUTDOWNLEN = 10       ' Timer value of shutdown delay
    Const SLICERCOOLLEN = 1000
    Const SLICERCHANGEDELAYLEN = 240    ' Seconds to wait for slicer up change
    Const DOWN = 0                      ' Used in Smooth Temp reduction - CookTimer Sub 
    Const UP = 1                        ' Used in Smooth Temp increment - CookTimer Sub


    ' Control Screen Constants

    Friend Const FREEFRYER = 1
    Friend Const BASICS = 2
    Friend Const TITRATION = 3
    Friend Const SLICERS = 4


    ' PID Constants

    Const PGAIN = 5                    ' Proportional Gain 
    Const IGAIN = 1                    ' Integral Gain
    Const DGAIN = 0                    ' Derivitive Gain





    ' Initialization subroutine, run once at startup

    Sub Initialize()

        Dim Counter As Integer = 0

        BurnerOn = False
        BCBStartButtonOn.Visible = False
        BCBBurnerStartButtonOff.Visible = True
        InletTemp = InitInletTemp.Text                             ' Temperature of oil before burner turns on
        InletTemperature.Text = Format(InletTemp, "0.00")          ' Load startup temperature into display
        InletTemperature.AppendText(" °C")
        SlicerFeedSpeedButton.Text = InitSlicerSpeed.Text          ' Sets initial slicerspeed
        DelayedSpeedChange.Text = InitSlicerSpeed.Text
        SlicerActualSpeed = InitSlicerSpeed.Text
        InletSetpoint.Text = Format(Val(InitSetPoint.Text), "0.0")     ' Initial Setpoint of fryer
        InletSetpoint.AppendText(" °C")
        InternalInletSetPoint = CDec(Val(InitSetPoint.Text))
        FlameBar.Text = Flame                                      ' Load startup flame into display
        MasterSpeedOutput.Text = InitMasterSpeed.Text              ' Load startup masterspeed into display

        SetPointOutput.Text = InitMoistureSP.Text
        LowLimitOutput.Text = InitMoistureLow.Text
        HighLimitOutput.Text = InitMoistureHigh.Text

        InitFlag = 1                                               ' Set to 1 to force initiation of system, sets to 0 afterwards

        ListBox1.SelectedIndex = 0                  ' Set default potato moisture

        MasterSpeedChange = 0                       ' Masterspeed change variable, 0 is no change, 1 is change
        ManualReject = 0                            ' Manual reject status, 0 is auto, 1 is manual
        SlicerActive = False                        ' Set slicer to off, 1 = on
        SlicerCoolDown = SLICERCOOLLEN
        PotatoMoisture = 31.33
        SlicerPoliteFlag = False
        BurnerStartupPoliteFlag = False
        BurnerShutDownPoliteFlag = False

        ProportionalText.Text = PGAIN
        IntegralText.Text = IGAIN
        DerivativeText.Text = DGAIN

        ' create string objects

        BurnerStartingAppendString = ""
        BurnerShutDownAppendString = ""
        SlicerAppendString = ""


        ' Format moisture vals into format 0.00
        SetPointOutput.Text = Format(CDec(Val(SetPointOutput.Text)), "0.00")
        LowLimitOutput.Text = Format(CDec(Val(LowLimitOutput.Text)), "0.00")
        HighLimitOutput.Text = Format(CDec(Val(HighLimitOutput.Text)), "0.00")

        ' Initialize Array, run through the array from 0 to 160 and load initial values
        Counter = 0
        While Counter < CHIPS + 1

            ProductStream(Counter).TempLoaded = False
            ProductStream(Counter).OilTemp = InletTemp
            ProductStream(Counter).Moisture = 0
            ProductStream(Counter).TimeInFryer = 0

            ProductStream(Counter).Chips = 0
            ProductStream(Counter).ChipsLoaded = False
            Counter += 1

        End While

        ' Set the initial speed settings of simulation

        SpeedLabel.Text = "X1"
        MainTimerTick.Interval = 1000
        BurnerStartupTimer.Interval = 1000
        FryerMimicTimer.Interval = 200
        CookTimer.Interval = 1000
        MasterSpeedTimer.Interval = 1000
        BurnerShutDownTimer.Interval = 1000
        Randomize.Interval = 1000
        OilCoolDownTimer.Interval = 1000
        MasterSpeedChangeDelay.Interval = 1000
        SlicerGradualChange.Interval = 1000


        ' Turn on supplementary systems

        Call InitializeSystems()

    End Sub

    Private Sub InitializeSystems()

        ' Turn on green activation images 

        SubmergerForm.SIND1.BackColor = Color.Lime
        SubmergerForm.SIND2.BackColor = Color.Lime
        SubmergerForm.SIND3.BackColor = Color.Lime
        SubmergerForm.SIND4.BackColor = Color.Lime

        MainOilPumpDialog.MOPIND1.BackColor = Color.Lime
        MainOilPumpDialog.MOPIND2.BackColor = Color.Lime
        MainOilPumpDialog.MOPIND3.BackColor = Color.Lime
        MainOilPumpDialog.MOPIND4.BackColor = Color.Lime

        PaddlesForm.PBIND1.BackColor = Color.Lime
        PaddlesForm.PBIND2.BackColor = Color.Lime
        PaddlesForm.PBIND3.BackColor = Color.Lime
        PaddlesForm.PBIND4.BackColor = Color.Lime

        ' Turn off Oil Makeup Valves

        FryerButtonScreen.ValveOpenImage.Visible = False
        FryerButtonScreen.ValveCloseImage.Visible = True
        OMUVOffImage.Visible = True
        OMUVOnImage.Visible = False


        AllOnSwitchON.Visible = True
        AllOnSwitchOff.Visible = False

        ' Turn On Potato Preparation

        PPRunningOffImage.Visible = False
        PPRunningOnImage.Visible = True

        ' Turn On Outfeed

        OutfeedOffImage.Visible = False
        OutfeedOnImage.Visible = True

        ' Turn On Accumulator 

        AccumulationOffImage.Visible = False
        AccumulationOnImage.Visible = True

        ' Turn on Inspection Table

        ITOnImage.Visible = True
        ITOffImage.Visible = False

        ' Turn on Accumuveyor Infeed

        AFOffImage.Visible = False
        AFOnImage.Visible = True

        ' Turn on Hopper Conveyor

        HCOnImage.Visible = True
        HCOffImage.Visible = False

        ' Turn on Vibe Motors 1 and 2

        HCV1OffImage.Visible = False
        HCV1OnImage.Visible = True
        HCV2OffImage.Visible = False
        HCV2OnImage.Visible = True

        ' Turn on Outfeed Conveyor and Vibe 

        OCVOffImage.Visible = False
        OCVOnImage.Visible = True

        VBOnImage.Visible = True
        VBOffImage.Visible = False


        ' Turn on Submerger

        FSubOffImage.Visible = False
        FSubOnImage.Visible = True

        ' Turn on Fryer Catchbox

        FCtchOffImage.Visible = False
        FCtchOnImage.Visible = True

        'Turn Air, Knife and Sweep on

        AirMOff.Visible = False
        AirMOn.Visible = True
        KMOn.Visible = True
        KMOff.Visible = False

        ' Turn On Conveyor, Pump, Catchbox

        SCMOn.Visible = True
        SWCMOff.Visible = False
        SWPMOn.Visible = True
        SWPMOff.Visible = False
        SWCBMOn.Visible = True
        SWCBMOff.Visible = False

        ' Turn on Laning Conveyor

        LaningConveyorOnImage.Visible = True
        LaningConveyorOffImage.Visible = False
        LCMOff.Visible = False
        LCMOn.Visible = True

        ' Turn on Discharge Conveyor
        DischargeConveyorOffImage.Visible = False
        DischargeConveyorOnImage.Visible = True
        FDISOffImage.Visible = False
        FDISOnImage.Visible = True

        ' Turn on Slicers


        SlicerOn1.Visible = True
        SlicerOn2.Visible = True
        SlicerOn3.Visible = True
        SlicerOff1.Visible = False
        SlicerOff2.Visible = False
        SlicerOff3.Visible = False
        S1CMOff.Visible = False
        S1MOn.Visible = True
        S2CMOff.Visible = False
        S2MOn.Visible = True
        S3CMOff.Visible = False
        S3MOn.Visible = True



        ' Turn on Main Oil Pump

        FryerButtonScreen.MainOilPumpOn.Visible = True
        FryerButtonScreen.MainOilPumpStandby.Visible = False
        Me.MPumpOffImage.Visible = False
        Me.MPumpOnImage.Visible = True

        ' Turn on Paddles

        Me.FPLDOffImage.Visible = False
        Me.FPLDOnImage.Visible = True
        FryerButtonScreen.PaddleButtonOn.Visible = True
        FryerButtonScreen.PaddleButtonStandby.Visible = False


        ' Turn on Burner Started

        BurnerStartedOffImage.Visible = False
        BurnerStartedOnImage.Visible = True

        ' Turn on Fryer Mimic pics

        EmptyFryer1Pic.Image = My.Resources.Empty_Fryer_2_Grey

    End Sub


    ' Routine to handle cooking of chips, on default 1 second repeat.
    Private Sub CookTimer_Tick(sender As Object, e As EventArgs) Handles CookTimer.Tick

        Dim ChipCounter As Integer      ' used to cycle through the chip dehydration code
        Dim OilCounter As Integer       ' used to cycle through the oil temperature code
        Dim FryerCounter As Integer     ' used to move all elements in fryer one compartment up
        Dim OilTempReduction As Decimal ' Combined amount of heat to reduce per cycle
        Dim ChipsMoistureReduction As Decimal ' Combined amount of moisture to reduce per cycle
        Dim MasterSpeedCurveRatio As Decimal ' used to reduce reduction of moisture in based on position
        Static Dim SmoothCounter As Integer ' used to cycle up and down temp changes
        Static Dim SmoothCounterFlag As Boolean = False ' used to flag a change in temp

        OilCounter = 0
        While OilCounter <= CHIPS


            If ProductStream(OilCounter).TempLoaded = True Then

                OilTempReduction = ProductStream(OilCounter).Moisture * CDec(Val(MoistureBulkText.Text)) ' Base Reduction
                OilTempReduction += (SlicerActualSpeed - 58) * CDec(Val(SlicerVarianceText.Text))        ' Slicer Reduction
                If OilCounter > 0 Then OilTempReduction /= OilCounter
                OilTempReduction += CDec(Val(TempVarianceText.Text))
                ProductStream(OilCounter).OilTemp = ProductStream(OilCounter).OilTemp - OilTempReduction

            End If


            OilCounter += 1

        End While

        MasterSpeedCurveRatio = 0.000000011
        ChipCounter = 1
        While ChipCounter <= CHIPS

            If ProductStream(ChipCounter).ChipsLoaded = True Then


                ChipsMoistureReduction = (CDec(Val(FryFactorText.Text) + MasterSpeedCurveRatio) * (ProductStream(ChipCounter).OilTemp / 2.5) + MasterSpeedOffset)
                ProductStream(ChipCounter).TimeInFryer += 1
                ProductStream(ChipCounter).Chips -= ChipsMoistureReduction


            End If

            MasterSpeedCurveRatio -= 0.000000001
            ChipCounter += 1

        End While

        FryerCounter = CHIPS
        While FryerCounter > 0



            ProductStream(FryerCounter).Chips = ProductStream(FryerCounter - 1).Chips
            ProductStream(FryerCounter).ChipsLoaded = ProductStream(FryerCounter - 1).ChipsLoaded
            ProductStream(FryerCounter).TimeInFryer = ProductStream(FryerCounter - 1).TimeInFryer


            ProductStream(FryerCounter).OilTemp = ProductStream(FryerCounter - 1).OilTemp
            ProductStream(FryerCounter).TempLoaded = ProductStream(FryerCounter - 1).TempLoaded


            FryerCounter -= 1

        End While

        If SlicerActive = True Then


            If CDec(Val(InletSetpoint.Text)) < InternalInletSetPoint Then

                ' if we haven't yet set the counter to 0 then set to 0

                If SmoothCounterFlag = False Then

                    SmoothCounter = 0
                    SmoothCounterFlag = True

                End If

                'adjust the temperature

                InternalInletSetPoint -= CDec(Val(FryFactor3Text.Text))

                'if we have reached the new temperature then set smooth counterflag to false
                If CDec(Val(InletSetpoint.Text)) = InternalInletSetPoint Then

                    SmoothCounterFlag = False

                End If

            ElseIf CDec(Val(InletSetpoint.Text)) > InternalInletSetPoint Then

                ' if we haven't yet set the counter to 0 then set to 0

                If SmoothCounterFlag = False Then

                    SmoothCounter = 0
                    SmoothCounterFlag = True

                End If

                'adjust the temperature

                InternalInletSetPoint += (CDec(Val(FryFactor3Text.Text)))

                'if we have reached the new temperature then set smooth counterflag to false
                If CDec(Val(InletSetpoint.Text)) = InternalInletSetPoint Then

                    SmoothCounterFlag = False

                End If

            End If

            ProductStream(0).TempLoaded = True
            ProductStream(0).OilTemp = InletTemp
            ProductStream(0).Moisture = PotatoMoisture
            ProductStream(0).TimeInFryer = 1
            ProductStream(0).Chips = PotatoMoisture + ((SlicerActualSpeed - 58) * CDec(Val(SlicerRatioText.Text)))
            ProductStream(0).ChipsLoaded = True


        Else

            ProductStream(0).TempLoaded = False
            ProductStream(0).OilTemp = InletTemp
            ProductStream(0).Moisture = 0
            ProductStream(0).TimeInFryer = 0
            ProductStream(0).Chips = 0
            ProductStream(0).ChipsLoaded = False

        End If



        ' if the chips are out of spec then we activate rejection display
        If ((CDec(Val(MoistureOutput.Text)) > CDec(Val(HighLimitOutput.Text)) Or CDec(Val(MoistureOutput.Text)) < CDec(Val(LowLimitOutput.Text))) And ManualReject = 0) Or ManualReject = 1 Then

            RejectProductLabel.Visible = True
            RGCONOffImage.Visible = False
            RGConOnImage.Visible = True


        Else

            RejectProductLabel.Visible = False
            RGCONOffImage.Visible = True
            RGConOnImage.Visible = False
            RGManualOpenImage.Visible = False

        End If

    End Sub


    ' This subroutine is on a 1 second default timer, adjusts for masterspeed
    Private Sub Timer2_Tick_1(sender As Object, e As EventArgs) Handles MasterSpeedTimer.Tick

        ' Temporary variables for the next group of code to make statements easier to read

        Dim PSMoisture As Decimal ' holds the productstream(59).moisture value

        Dim MoistLowRed As Decimal ' holds moisturesetpoint - 30 value
        Dim MoistLowYellow As Decimal ' Holds moisturesetpoint - 20 value
        Dim MoistLowGreen As Decimal ' Holds moisturesetpoint - 10 value

        Dim MoistHighRed As Decimal ' holds moisturesetpoint + 30 value
        Dim MoistHighYellow As Decimal ' holds moisturesetpoint + 20 value
        Dim MoistHighGreen As Decimal ' holds moisturesetpoint + 10 value

        ' Set the variable values to Crinkle (needs to be adjusted to load from textboxes)

        MoistLowRed = CDec(Val(SetPointOutput.Text)) - 0.3
        MoistLowYellow = CDec(Val(SetPointOutput.Text)) - 0.2
        MoistLowGreen = CDec(Val(SetPointOutput.Text)) - 0.1

        MoistHighRed = CDec(Val(SetPointOutput.Text)) + 0.3
        MoistHighYellow = CDec(Val(SetPointOutput.Text)) + 0.2
        MoistHighGreen = CDec(Val(SetPointOutput.Text)) + 0.1


        ' If masterspeed manual mode is not on then do the following

        If MasterSpeedManual.Visible = False Then


            ' load the last compartments moisture into MoistureValue to use as assessed masterspeed requirements
            PSMoisture = ProductStream(CHIPS).Chips ' Load the 159th element of the productstream in PSMoisture

            ' the following code calculates whether the moisture is high or low and sets change value
            ' and sets the masterspeed change flag to be used in the next select case code


            ' If moisture is in the low red and the master speed is not at maximum 76 
            If PSMoisture <= MoistLowRed Then

                If MasterSpeedChangeDelay.Enabled = False Then

                    'MasterSpeedOutput.Text = 76
                    MasterSpeedOutput.Text = CDec(Val(MasterSpeedOutput.Text)) + 1
                    MasterSpeedChangeDelay.Enabled = True

                End If

                ' or in the high red and not at minimum 64
            ElseIf PSMoisture >= MoistHighRed Then

                If MasterSpeedChangeDelay.Enabled = False Then

                    MasterSpeedOutput.Text = CDec(Val(MasterSpeedOutput.Text)) - 1
                    'MasterSpeedOutput.Text = 64
                    MasterSpeedChangeDelay.Enabled = True

                End If

                ' or if its between low red and low yellow
            ElseIf PSMoisture < MoistLowYellow And PSMoisture > MoistLowRed Then

                If MasterSpeedChangeDelay.Enabled = False Then

                    MasterSpeedOutput.Text = CDec(Val(MasterSpeedOutput.Text)) + 1
                    MasterSpeedChangeDelay.Enabled = True

                End If

                ' or high yellow and high red
            ElseIf PSMoisture > MoistHighYellow And PSMoisture < MoistHighRed Then

                If MasterSpeedChangeDelay.Enabled = False Then

                    MasterSpeedOutput.Text = CDec(Val(MasterSpeedOutput.Text)) - 1
                    MasterSpeedChangeDelay.Enabled = True

                End If

                ' if its in the low green 
            ElseIf PSMoisture < MoistLowGreen And PSMoisture > MoistLowYellow Then

                If MasterSpeedChangeDelay.Enabled = False Then

                    MasterSpeedOutput.Text = 70
                    MasterSpeedChangeDelay.Enabled = True

                End If

                ' or the high green
            ElseIf PSMoisture > MoistHighGreen And PSMoisture < MoistHighYellow Then

                If MasterSpeedChangeDelay.Enabled = False Then

                    MasterSpeedOutput.Text = 70
                    MasterSpeedChangeDelay.Enabled = True

                End If

            End If

            ' Check to make sure masterspeed has not exceeded bounds 64 to 76
            ' and adjust accordingly

            If CDec(Val(MasterSpeedOutput.Text)) < 64 Then MasterSpeedOutput.Text = 64
            If CDec(Val(MasterSpeedOutput.Text)) > 76 Then MasterSpeedOutput.Text = 76

        End If


        ' MasterspeedOffSet is the amount of moisture to deduct from each compartment - used in cooktimer

        MasterSpeedOffset = (CDec(Val(70 - MasterSpeedOutput.Text))) * CDec(Val(MasterSpeedRatioText.Text))


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        Select Case ListBox1.SelectedItem

            Case 1.1
                'MoistureBulkText.Text = 0.1
                PotatoMoisture = CDec(Val(MoistureVarianceText.Text))


            Case 1.099
                'MoistureBulkText.Text = 0.1025
                PotatoMoisture = CDec(Val(MoistureVarianceText.Text)) + 0.1


            Case 1.09
                'MoistureBulkText.Text = 0.105
                PotatoMoisture = CDec(Val(MoistureVarianceText.Text)) + 0.2


            Case 1.08
                'MoistureBulkText.Text = 0.1075
                PotatoMoisture = CDec(Val(MoistureVarianceText.Text)) + 0.3


            Case 1.07
                'MoistureBulkText.Text = 0.11
                PotatoMoisture = CDec(Val(MoistureVarianceText.Text)) + 0.4


        End Select

    End Sub


    Sub Flamefunction()

        SlicerAdjust = SlicerActualSpeed / 97

        If BurnerOn = True Then InletTemp = InletTemp + (Flame * CDec(Val(FryFactor3Text.Text)))
        If SlicerActive = True Then InletTemp = InletTemp - (SlicerAdjust * CDec(Val(SlicerAdjustText.Text)))
        If InletTemp < 0 Then InletTemp = 0


        InletTemperature.Text = Format(InletTemp, "0.0")
        InletTemperature.AppendText(" °C")

        OutletTempText.Text = Format(ProductStream(CHIPS).OilTemp, "0.0")
        OutletTempText.AppendText(" °C")

        DeltaTText.Text = Format((InletTemp - ProductStream(CHIPS).OilTemp), "0.0")
        DeltaTText.AppendText(" °C")

        If MPumpOnImage.Visible = True Then
            OilFlowTextbox.Text = Format(5262 - (SlicerActualSpeed * 2), "0")
            OilFlowTextbox.AppendText(" L/M")
        Else
            OilFlowTextbox.Text = Format(0, "0")
            OilFlowTextbox.AppendText(" L/M")
        End If

    End Sub

    Sub PID_output()

        Dim ErrorPID As Decimal
        Static Dim Proportional As Decimal
        Dim ProportionalGain As Decimal
        Static Dim Integral As Decimal
        Dim IntegralGain As Decimal
        Static Dim LastError As Decimal
        Static Dim Derivative As Decimal
        Dim DerivativeGain As Decimal
        Dim SaveFlame As Decimal


        SaveFlame = Flame

        If PIDFlag = True Then Return

        ProportionalGain = CDec(Val(ProportionalText.Text))
        IntegralGain = CDec(Val(IntegralText.Text))
        DerivativeGain = CDec(Val(DerivativeText.Text))

        ErrorPID = InternalInletSetPoint - InletTemp ' For reverse acting controls Like heating

        Proportional = ErrorPID * ProportionalGain ' Proportional

        Integral = Integral + (ErrorPID * IntegralGain) ' Integral

        If Integral > 100% Then Integral = 100% ' anti - windup

        If Integral < 0% Then Integral = 0%

        Derivative = (ErrorPID - LastError) * DerivativeGain ' differential

        LastError = ErrorPID

        Flame = Proportional + Integral + Derivative ' P + I + D

        PIDFlag = True

        If ErrorPID > -0.2 And ErrorPID < 0.2 Then
            If Flame > SaveFlame + 0.02 Then Flame = SaveFlame + 0.02
            If Flame < SaveFlame - 0.02 Then Flame = SaveFlame - 0.02
        ElseIf ErrorPID > -0.1 And ErrorPID < 0.1 Then
            If Flame > SaveFlame + 0.1 Then Flame = SaveFlame + 0.1
            If Flame < SaveFlame - 0.1 Then Flame = SaveFlame - 0.1


        End If

        If Flame > 100% Then Flame = 100% ' output limiting

        If Flame < 50% Then Flame = 50%

    End Sub

    Sub Sentinelfunction()

        If BurnerOn = True Then Call PID_output()

    End Sub

    Sub Burnerfunction()

        If BurnerOn = True Then

            FlameBar.Text = FormatPercent(Flame / 100, 2)

        Else

            Flame = 0.0
            FlameBar.Text = FormatPercent(Flame / 100, 2)

        End If

    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles SlicerFeedMinusButton.Click

        If SlicerFeedChangeDelay.Enabled = False Then

            If Int(SlicerFeedSpeedButton.Text) > 1 Then SlicerFeedSpeedButton.Text = Int(SlicerFeedSpeedButton.Text) - 1
            SlicerActualSpeed = Int(SlicerFeedSpeedButton.Text)

        End If

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles MainTimerTick.Tick

        Dim LoopIndex1, BlockIndex, RecordIndex1 As Integer
        Dim IndexPointer1, BlockOffset As Integer


        If FryerArrayCB.Checked Then

            FryerArrayData.Visible = True

            BlockIndex = 0
            While BlockIndex < 3

                Select Case BlockIndex
                    Case 0

                        IndexPointer1 = Int(Val(FryerArrayData.RecordText1Text.Text))
                        RecordIndex1 = Int(Val(FryerArrayData.RecordText1Text.Text))
                        BlockOffset = 0

                    Case 1

                        IndexPointer1 = Int(Val(FryerArrayData.RecordText2Text.Text))
                        RecordIndex1 = Int(Val(FryerArrayData.RecordText2Text.Text))
                        BlockOffset = 49

                    Case 2

                        IndexPointer1 = Int(Val(FryerArrayData.RecordText3Text.Text))
                        RecordIndex1 = Int(Val(FryerArrayData.RecordText3Text.Text))
                        BlockOffset = 98


                End Select

                LoopIndex1 = 0
                While LoopIndex1 < 48

                    BlockArray(LoopIndex1 + BlockOffset).Text = RecordIndex1
                    BlockArray(LoopIndex1 + 1 + BlockOffset).Text = ProductStream(IndexPointer1).OilTemp
                    BlockArray(LoopIndex1 + 2 + BlockOffset).Text = ProductStream(IndexPointer1).Chips
                    BlockArray(LoopIndex1 + 3 + BlockOffset).Text = ProductStream(IndexPointer1).TimeInFryer
                    BlockArray(LoopIndex1 + 5 + BlockOffset).Text = ProductStream(IndexPointer1).Chips
                    BlockArray(LoopIndex1 + 6 + BlockOffset).Text = ProductStream(IndexPointer1).ChipsLoaded

                    LoopIndex1 += 7
                    RecordIndex1 += 1
                    IndexPointer1 += 1

                End While

                BlockIndex += 1

            End While




        Else

            FryerArrayData.Visible = False

        End If






        ' Turn off Tutorial Timer if Tutorial window not open

        If FryerHMITutForm.Visible = False Then TutorialTimer.Enabled = False

        ' Display Date and Time on screen
        DTMenu.Text = Date.Now

        ' Enable CookTimer 
        CookTimer.Enabled = True

        ' If InitFlag not 0 then system not initialized, initialize the system startup variables, Set InitFlag 1
        If InitFlag = 0 Then Call Initialize()

        ' check if slicer is active and if so set visual image to show that
        If SlicerActive = True Then

            SlicerFeedOnImage.Visible = True
            SlicerFeedOffImage.Visible = False

        Else

            SlicerFeedOnImage.Visible = False
            SlicerFeedOffImage.Visible = True
            ''" End Cook code goes here "

        End If

        ' If the burner is active then call the burner specific subroutines to process 


        Call Flamefunction()
        Call Burnerfunction()
        Call Sentinelfunction()
        Call BurnerFaults()
        Call WOQ()

    End Sub



    Sub WOQ()

        ' Compares WOQ data against fryer parameters and then displays the result on the WOQ Group box


        ' Compare Moisture
        If ProductStream(CHIPS).Chips >= CDec(Val(WoQMoistureTickSettingLowText.Text)) And ProductStream(CHIPS).Chips <= CDec(Val(WoQMoistureTickSettingHighText.Text)) Then

            MoistureTickImage.Visible = True
            MoistureXImage.Visible = False
            MoistureExclImage.Visible = False
        ElseIf ProductStream(CHIPS).Chips <= CDec(Val(WoQMoistureTickSettingLowText.Text)) And ProductStream(CHIPS).Chips >= CDec(Val(WoQMoistureXSettingLowText.Text)) Then

            MoistureExclImage.Visible = True
            MoistureTickImage.Visible = False
            MoistureXImage.Visible = False

        ElseIf ProductStream(CHIPS).Chips <= CDec(Val(WoQMoistureExclSettingHighText.Text)) And ProductStream(CHIPS).Chips >= CDec(Val(WoQMoistureTickSettingHighText.Text)) Then

            MoistureExclImage.Visible = True
            MoistureTickImage.Visible = False
            MoistureXImage.Visible = False

        Else

            MoistureXImage.Visible = True
            MoistureExclImage.Visible = False
            MoistureTickImage.Visible = False

        End If


        ' Compare Inlet Temp

        If Math.Round(CDec(Val(InletTemp))) >= CDec(Val(WoQInletTickSettingLowText.Text)) And Math.Round(CDec(Val(InletTemp))) <= CDec(Val(WoQInletTickSettingHighText.Text)) - 0.04 Then

            InletTickImage.Visible = True
            InletXImage.Visible = False
            InletExclImage.Visible = False

        ElseIf Math.Round(CDec(Val(InletTemp))) >= CDec(Val(WoQInletExclSettingLowText.Text)) And Math.Round(CDec(Val(InletTemp))) <= CDec(Val(WoQInletExclSettingHighText.Text)) And RelRadioButton.Checked = True Then

            InletTickImage.Visible = False
            InletXImage.Visible = False
            InletExclImage.Visible = True

        Else

            InletTickImage.Visible = False
            InletXImage.Visible = True
            InletExclImage.Visible = False

        End If


        ' Compare Delta

        If CDec(Val(DeltaTText.Text)) >= 18 And CDec(Val(DeltaTText.Text)) <= 26 Then

            DeltaTTickImage.Visible = True
            DeltaTXImage.Visible = False

        Else

            DeltaTTickImage.Visible = False
            DeltaTXImage.Visible = True

        End If



        ' Compare MasterSpeed

        If CDec(Val(MasterSpeedOutput.Text)) >= 64 And CDec(Val(MasterSpeedOutput.Text)) <= 76 Then

            MasterSpeedTickImage.Visible = True
            MasterSpeedXImage.Visible = False

        Else

            MasterSpeedTickImage.Visible = False
            MasterSpeedXImage.Visible = True

        End If



    End Sub


    Sub BurnerFaults()

        Static Dim AlarmCounter As Integer = 0
        Alarms = New TextBox() {AlarmsForm.Alarm0DateText, AlarmsForm.Alarm0TimeText, AlarmsForm.Alarm0NameText, AlarmsForm.Alarm0ValueText, AlarmsForm.Alarm0LimitText, AlarmsForm.Alarm0CommentText, AlarmsForm.Alarm1DateText, AlarmsForm.Alarm1TimeText, AlarmsForm.Alarm1NameText, AlarmsForm.Alarm1ValueText, AlarmsForm.Alarm1LimitText, AlarmsForm.Alarm1CommentText, AlarmsForm.Alarm2DateText, AlarmsForm.Alarm2TimeText, AlarmsForm.Alarm2NameText, AlarmsForm.Alarm2ValueText, AlarmsForm.Alarm2LimitText, AlarmsForm.Alarm2CommentText, AlarmsForm.Alarm3DateText, AlarmsForm.Alarm3TimeText, AlarmsForm.Alarm3NameText, AlarmsForm.Alarm3ValueText, AlarmsForm.Alarm3LimitText, AlarmsForm.Alarm3CommentText, AlarmsForm.Alarm4DateText, AlarmsForm.Alarm4TimeText, AlarmsForm.Alarm4NameText, AlarmsForm.Alarm4ValueText, AlarmsForm.Alarm4LimitText, AlarmsForm.Alarm4CommentText, AlarmsForm.Alarm5DateText, AlarmsForm.Alarm5TimeText, AlarmsForm.Alarm5NameText, AlarmsForm.Alarm5ValueText, AlarmsForm.Alarm5LimitText, AlarmsForm.Alarm5CommentText}

        If AlarmFlag = False Then

            If MPumpOnImage.Visible = False Then

                BCBStartButtonOn.Visible = False
                BCBBurnerStartButtonOff.Visible = True
                BurnerFaultOn.Visible = True
                LowOilPressureFaultOn.Visible = True
                BurnerFaultOff.Visible = False
                LowOilPressureFaultOff.Visible = False
                BurnerStartedOnImage.Visible = False
                BurnerStartedOffImage.Visible = True
                KHXBurnerOffImage.Visible = True
                KHXBurnerOnImage.Visible = False

                If BurnerOn = True Then

                    Alarms(AlarmCounter).Text = Date.Today
                    Alarms(AlarmCounter + 1).Text = TimeOfDay
                    Alarms(AlarmCounter + 2).Text = "Sounder.Ack"
                    Alarms(AlarmCounter + 3).Text = "OFF"
                    Alarms(AlarmCounter + 4).Text = "ON"
                    Alarms(AlarmCounter + 5).Text = "Main Pump Off"
                    My.Computer.Audio.Play("C:\Users\drmci\Downloads\TF024.Wav", AudioPlayMode.BackgroundLoop)
                    BurnerShutdownCountdown = 0
                    BurnerShutDownTimer.Enabled = True
                    AlarmCounter += 6
                    AlarmFlag = True

                End If

            End If

            If InletTemp > 190 Then

                BurnerFaultOn.Visible = True
                FryerTempFaultOn.Visible = True
                FryerTempFaultOff.Visible = False
                BurnerStartedOnImage.Visible = False
                BurnerStartedOffImage.Visible = True
                BCBStartButtonOn.Visible = False
                BCBBurnerStartButtonOff.Visible = True
                KHXBurnerOffImage.Visible = True
                KHXBurnerOnImage.Visible = False

                If BurnerOn = True Then

                    My.Computer.Audio.Play("C:\Users\drmci\Downloads\TF024.Wav", AudioPlayMode.BackgroundLoop)
                    BurnerShutdownCountdown = 0
                    BurnerShutDownTimer.Enabled = True
                    Alarms(AlarmCounter).Text = Date.Today
                    Alarms(AlarmCounter + 1).Text = TimeOfDay
                    Alarms(AlarmCounter + 2).Text = "Sounder.Ack"
                    Alarms(AlarmCounter + 3).Text = "OFF"
                    Alarms(AlarmCounter + 4).Text = "ON"
                    Alarms(AlarmCounter + 5).Text = "Oil Temperature High"
                    AlarmCounter += 6
                    AlarmFlag = True

                End If

            End If
        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles SlicerFeedPlusButton.Click

        ' if the 5 second slicerfeedadjustment timer is off then load the slicerspeed into delayedspeedchange
        ' label and turn on the timer
        If SlicerFeedChangeDelay.Enabled = False Then


            If SlicerFeedAdjustmentDelay.Enabled = False Then

                DelayedSpeedChange.Text = Int(SlicerFeedSpeedButton.Text)
                SlicerFeedAdjustmentDelay.Enabled = True

            End If

            ' if the 4 minute slicerfeedchangedelay timer is off then increment the new slicer speed
            ' inside of delayedspeedchange for the timer to apply when the time is up

            If SlicerFeedChangeDelay.Enabled = False Then

                If Int(SlicerFeedSpeedButton.Text) < 100 Then SlicerFeedSpeedButton.Text = Int(SlicerFeedSpeedButton.Text) + 1

            End If
        End If


    End Sub

    Sub BurnerStartup()

        BurnerStartupTimer.Enabled = True

    End Sub


    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles InletSetpointPlus.Click

        InletSetpoint.Text = CDec(Val(InletSetpoint.Text)) + 1
        InletSetpoint.Text = Format(CDec(Val(InletSetpoint.Text)), "0.0")
        InletSetpoint.AppendText(" °C")

    End Sub


    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles InletSetpointMinus.Click

        InletSetpoint.Text = CDec(Val(InletSetpoint.Text)) - 1
        InletSetpoint.Text = Format(CDec(Val(InletSetpoint.Text)), "0.0")
        InletSetpoint.AppendText(" °C")

    End Sub


    Private Sub BurnerStartupTimer_Tick(sender As Object, e As EventArgs) Handles BurnerStartupTimer.Tick

        SkipStartup.Visible = True
        BurnerStartupCountdown -= 1


        BurnerStartingAppendString = " Burner will start in " & BurnerStartupCountdown.ToString & " Seconds"


        BurnerStartupPoliteFlag = True



        If BurnerStartupCountdown <= 1 Then

            SkipStartup.Visible = False
            BurnerOn = True
            BurnerStartupTimer.Enabled = False
            BurnerStartupPoliteFlag = False
            BurnerInfoText.Text = "PC 42 Fryer Simulation"
            BurnerStartupPoliteFlag = False
            KHXBurnerOffImage.Visible = False
            KHXBurnerOnImage.Visible = True
            MainFlameOffImage.Visible = False
            MainFlameOnImage.Visible = True

            BCBBurnerOffLight.Visible = False
            BCBStartButtonOn.Visible = True
            BCBBurnerOnLight.Visible = True
            BurnerStartedOnImage.Visible = True
            BurnerStartedOffImage.Visible = False

        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles FryerMimicTimer.Tick

        Static Dim MimicPicCounter1 As Integer = 0
        Static Dim MimicPicCounter2 As Integer = 0
        Static Dim ChipDelayOffset As Integer = 0
        Static Dim Pointer As Integer
        Static Dim Head As Integer = 158
        Static Dim Tail As Integer = 0
        Static Dim Pictures(160) As PictureBox
        Static Dim PictureboxFlag As Boolean = False
        Dim ChipPositionStepX As Integer = 0
        Dim ChipPositionStepY As Decimal = 0

        Dim Counter As Integer

        If PictureboxFlag = False Then

            Counter = 0
            While Counter < 160

                Pictures(Counter) = New PictureBox
                Pictures(Counter).Name = "Chip" & Counter
                Pictures(Counter).BackColor = Color.FromArgb(255, 255, 200 - Counter)
                Pictures(Counter).BackgroundImageLayout = ImageLayout.Stretch
                Pictures(Counter).Visible = False

                If Counter > 125 Then
                    Pictures(Counter).Top = 211 - ChipPositionStepY
                    ChipPositionStepY += 0.8
                ElseIf Counter > 92 Then

                    Pictures(Counter).Top = 211

                Else
                    Pictures(Counter).Top = 209
                End If

                Pictures(Counter).Left = 30 + ChipPositionStepX

                Pictures(Counter).Width = 3
                Pictures(Counter).Height = 3
                Pictures(Counter).BringToFront()
                TabPage1.Controls.Add(Pictures(Counter))
                EmptyFryer1Pic.SendToBack()

                ChipPositionStepX += 2
                Counter += 1

            End While

            PictureboxFlag = True

        End If

        Dim fryerimages1() As Bitmap = {My.Resources.Empty_Fryer_2_Grey,
                                    My.Resources.Empty_Fryer_2_Grey_1,
                                    My.Resources.Empty_Fryer_2_Grey_2,
                                    My.Resources.Empty_Fryer_2_Grey_3,
                                    My.Resources.Empty_Fryer_2_Grey_4,
                                    My.Resources.Empty_Fryer_2_Grey_5,
                                    My.Resources.Empty_Fryer_2_Grey_6,
                                    My.Resources.Empty_Fryer_2_Grey_7,
                                    My.Resources.Empty_Fryer_2_Grey_8,
                                    My.Resources.Empty_Fryer_2_Grey_9,
                                    My.Resources.Empty_Fryer_2_Grey_10,
                                    My.Resources.Empty_Fryer_2_Grey_11,
                                    My.Resources.Empty_Fryer_2_Grey_12}

        Dim fryerimages2() As Bitmap = {My.Resources.Fryer_Off,
                                    My.Resources.Fryer_On_1,
                                    My.Resources.Fryer_On_2,
                                    My.Resources.Fryer_On_Chips_1,
                                    My.Resources.Fryer_On_Chips_2}


        If SlicerActive = True Then

            Pictures(0).Visible = True

        End If


        If ChipDelayOffset = 6 Then

            ChipDelayOffset = 0

            Pointer = Head
            While Pointer >= Tail

                If SystemData.SelectedTab.Text = "Fryer" Then

                    Pictures(Pointer + 1).Visible = Pictures(Pointer).Visible
                    Pictures(Pointer).Visible = False

                End If

                Pointer -= 1

            End While

        End If

        If BurnerOn = True And Pictures(159).Visible = False Then

            OnImage1.Image = fryerimages2(MimicPicCounter2 + 1)

        ElseIf Pictures(159).Visible = True Then

            OnImage1.Image = fryerimages2(MimicPicCounter2 + 3)
        Else
            OnImage1.Image = fryerimages2(0)

        End If

        If FPLDOnImage.Visible = True Then

            EmptyFryer1Pic.Image = fryerimages1(MimicPicCounter1)

        End If

        If FPLDOnImage.Visible = True Then ChipDelayOffset += 1



        MimicPicCounter1 += 1
        MimicPicCounter2 += 1

        If MimicPicCounter1 > 12 Then MimicPicCounter1 = 0
        If MimicPicCounter2 > 1 Then MimicPicCounter2 = 0


    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles KHXStartButton.Click

        BurnerStartupCountdown = BURNERSTARTUPLEN

        If BurnerFaultOn.Visible = False And BurnerStartedOnImage.Visible = True Then


            BurnerStartedOnImage.Visible = True
            BurnerStartedOffImage.Visible = False

            If BurnerStartedOnImage.Visible = True Then BurnerStartupTimer.Enabled = True

            BCBBurnerStartButtonOff.Visible = False
            BCBStartButtonOn.Visible = True
            BCBBurnerStartButtonOff.Visible = True
        End If

    End Sub

    Private Sub KHXStopButton_Click(sender As Object, e As EventArgs) Handles KHXStopButton.Click

        If MainFlameOnImage.Visible = True Then


            BurnerShutdownCountdown = BURNERSHUTDOWNLEN

            If MainFlameOnImage.Visible = True Then BurnerShutDownTimer.Enabled = True

            BCBStartButtonOn.Visible = False
            BCBBurnerStartButtonOff.Visible = True

        Else
            BurnerStartedOffImage.Visible = True
            BurnerStartedOnImage.Visible = False
        End If
    End Sub

    Private Sub DischargeConveyorStopButton_Click(sender As Object, e As EventArgs) Handles DischargeConveyorStopButton.Click

        DischargeConveyorOffImage.Visible = True
        DischargeConveyorOnImage.Visible = False
        FDISOffImage.Visible = True
        FDISOnImage.Visible = False

    End Sub

    Private Sub DischargeConveyorStartButton_Click(sender As Object, e As EventArgs) Handles DischargeConveyorStartButton.Click

        DischargeConveyorOffImage.Visible = False
        DischargeConveyorOnImage.Visible = True
        FDISOffImage.Visible = False
        FDISOnImage.Visible = True

    End Sub

    Private Sub BurnerShutDownTimer_Tick(sender As Object, e As EventArgs) Handles BurnerShutDownTimer.Tick

        SkipStartup.Visible = True

        BurnerShutdownCountdown -= 1

        BurnerInfoText.Visible = True

        BurnerShutDownAppendString = "Burner will stop in " & BurnerShutdownCountdown.ToString & " Seconds"

        BurnerShutDownPoliteFlag = True



        If BurnerShutdownCountdown <= 1 Then

            SkipStartup.Visible = False
            BurnerOn = False
            BurnerShutDownTimer.Enabled = False

            BurnerInfoText.Text = "PC 42 Fryer Simulation"
            BurnerShutDownPoliteFlag = False
            KHXBurnerOffImage.Visible = False
            KHXBurnerOnImage.Visible = True
            MainFlameOffImage.Visible = True
            MainFlameOnImage.Visible = False
            BCBStartButtonOn.Visible = False
            BCBBurnerStartButtonOff.Visible = True
            BCBBurnerOffLight.Visible = True
            BCBBurnerOnLight.Visible = False


        End If

    End Sub


    Private Sub LaningConveyorStopButton_Click(sender As Object, e As EventArgs) Handles LaningConveyorStopButton.Click

        LaningConveyorOnImage.Visible = False
        LaningConveyorOffImage.Visible = True
        LCMOn.Visible = False
        LCMOff.Visible = True

    End Sub

    Private Sub LaningConveyorStartButton_Click(sender As Object, e As EventArgs) Handles LaningConveyorStartButton.Click

        LaningConveyorOnImage.Visible = True
        LaningConveyorOffImage.Visible = False
        LCMOff.Visible = False
        LCMOn.Visible = True

    End Sub

    Private Sub SlicerStopButton_Click(sender As Object, e As EventArgs) Handles SlicerStopButton.Click

        If SlicerActive = True Then

            SlicerActive = False
            SlicerCoolDown = SLICERCOOLLEN
            SlicerFeedOffImage.Visible = True
            SlicerFeedOnImage.Visible = False

        End If

        RandomFryerInputs.Enabled = False

    End Sub

    Private Sub SlicerStartButton_Click(sender As Object, e As EventArgs) Handles SlicerStartButton.Click

        If SlicerActive = False Then

            SlicerActive = True
            SlicerCoolDown = 0
            SlicerFeedOffImage.Visible = False
            SlicerFeedOnImage.Visible = True

        End If

        RandomFryerInputs.Enabled = True

    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs)

        If MainFlameOnImage.Visible = True Then BurnerShutDownTimer.Enabled = True

        BCBBurnerStartButtonOff.Visible = True
        BCBStartButtonOn.Visible = False

    End Sub

    Private Sub BCBBurnerStartButtonOff_Click(sender As Object, e As EventArgs)

        BurnerStartedOnImage.Visible = True
        BurnerStartedOffImage.Visible = False

        If BurnerStartedOnImage.Visible = True Then BurnerStartupTimer.Enabled = True

        BCBBurnerStartButtonOff.Visible = False
        BCBStartButtonOn.Visible = True

    End Sub

    Private Sub RejectGateAutoButton_Click(sender As Object, e As EventArgs) Handles RejectGateAutoButton.Click

        RejectAutoOnImage.Visible = True
        RejectManualOnImage.Visible = False
        EGMCLabel.Visible = False
        RGManualCloseButton.Visible = False
        RGManualOpenButton.Visible = False
        RGManualOpenImage.Visible = False
        ManualReject = 0

    End Sub

    Private Sub RejectGateManualButton_Click(sender As Object, e As EventArgs) Handles RejectGateManualButton.Click

        If RejectProductLabel.Visible = True Then RGManualOpenImage.Visible = True

        RejectAutoOnImage.Visible = False
        RejectManualOnImage.Visible = True
        EGMCLabel.Visible = True

        RGManualCloseButton.Visible = True
        RGManualOpenButton.Visible = True
        RGCONOffImage.Visible = False
        RGConOnImage.Visible = True

    End Sub

    Private Sub RGManualCloseButton_Click(sender As Object, e As EventArgs) Handles RGManualCloseButton.Click

        ManualReject = 3
        RGManualOpenImage.Visible = False

    End Sub

    Private Sub RGManualOpenButton_Click(sender As Object, e As EventArgs) Handles RGManualOpenButton.Click

        ManualReject = 1
        RGManualOpenImage.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AlarmButton.Click

        AlarmsForm.Visible = True

    End Sub

    Private Sub FryerButton_Click(sender As Object, e As EventArgs) Handles FryerButton.Click

        FryerButtonScreen.Visible = True

    End Sub

    Private Sub MainOverviewButton_Click(sender As Object, e As EventArgs) Handles MainOverviewButton.Click

        Form2.Visible = False
        FryerButtonScreen.Visible = False

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles OilCoolDownTimer.Tick

        If BurnerOn = False And InletTemp > 0 And SlicerActive = False And SlicerCoolDown > 0 Then

            InletTemp = InletTemp - (InletTemp * 0.0001)

            InletTemperature.Text = Format(InletTemp, "0.0")
            InletTemperature.AppendText(" °C")
            OutletTempText.Text = Format(InletTemp, "0.0")
            OutletTempText.AppendText(" °C")
            DeltaTText.Text = Format(InletTemp - InletTemp, "0.0")
            DeltaTText.AppendText(" °C")
            SlicerCoolDown = SlicerCoolDown - 1

        End If

    End Sub

    Private Sub Randomize_Tick(sender As Object, e As EventArgs) Handles Randomize.Tick

        Dim MyMin As Integer
        Dim MyMax As Integer
        Static Dim RandomEventFlag As Integer
        Static Dim RandomSlicer As Decimal
        Dim Generator As System.Random = New System.Random()
        Static Dim RandomCounter1 As Integer
        Static Dim InRandom As Boolean
        Static Dim ChangeFlag As Integer
        Static Dim SavedRandom As Decimal

        ' Get a random number >= MyMin and <= MyMax

        MyMin = 1
        MyMax = 3
        If InRandom = False Then RandomEventFlag = Generator.Next(MyMin, MyMax + 1) ' Note: Next function returns numbers _less than_ max, so pass in max + 1 to include max as a possible value

        MyMax = CDec(Val(InfeedVarianceText.Text))
        If InRandom = False Then RandomSlicer = Generator.Next(MyMin, MyMax + 1)
        If InRandom = False Then

            ChangeFlag = 0
            RandomCounter1 = 0
        End If

        If RandomEventFlag = 1 Then InRandom = True

        If InRandom = True Then

            SavedRandom = 0 - RandomSlicer

            If ChangeFlag = 3 Then

                RandomEventFlag = 0
                RandomSlicer = 0
                RandomCounter1 = 0
                InRandom = False
                ChangeFlag = 0
                SavedRandom = 0

            End If

            If ChangeFlag = 2 Then

                If RandomCounter1 < 0 Then
                    SlicerActualSpeed += 0.1
                    RandomCounter1 += 1
                Else
                    ChangeFlag = 3

                End If
            End If


            If ChangeFlag = 1 Then

                If RandomCounter1 > SavedRandom Then
                    SlicerActualSpeed -= 0.1
                    RandomCounter1 -= 1
                Else
                    ChangeFlag = 2

                End If
            End If

            If ChangeFlag = 0 Then

                If RandomCounter1 < RandomSlicer Then
                    SlicerActualSpeed += 0.1
                    RandomCounter1 += 1

                Else
                    ChangeFlag = 1
                End If

            End If
        End If

    End Sub




    Private Sub VarianceMinus(sender As Object, e As EventArgs)

        If CDec(Val(InfeedVarianceText.Text)) > 1 Then InfeedVarianceText.Text = CDec(Val(InfeedVarianceText.Text)) - 1

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

        Dim MORatio As Decimal

        MORatio = CDec(Val(InfeedVarianceText.Text))
        MORatio += 0.0001
        InfeedVarianceText.Text = MORatio

    End Sub


    Private Sub Button10_Click_2(sender As Object, e As EventArgs) Handles Button10.Click

        PauseSimulation()

    End Sub

    Friend Sub PauseSimulation()

        SpeedLabel.Text = "PAUSED"
        MainTimerTick.Interval = 100000
        BurnerStartupTimer.Interval = 100000
        FryerMimicTimer.Interval = 100000
        CookTimer.Interval = 100000
        MasterSpeedTimer.Interval = 100000
        BurnerShutDownTimer.Interval = 100000
        Randomize.Interval = 100000
        OilCoolDownTimer.Interval = 100000
        MasterSpeedChangeDelay.Interval = 100000
        SlicerGradualChange.Interval = 100000

    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click

        SpeedLabel.Text = "X1"
        MainTimerTick.Interval = 1000
        BurnerStartupTimer.Interval = 1000
        FryerMimicTimer.Interval = 200
        CookTimer.Interval = 1000
        MasterSpeedTimer.Interval = 1000
        BurnerShutDownTimer.Interval = 1000
        Randomize.Interval = 1000
        OilCoolDownTimer.Interval = 1000
        MasterSpeedChangeDelay.Interval = 1000
        SlicerGradualChange.Interval = 1000

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        SpeedLabel.Text = "X10"
        MainTimerTick.Interval = 100
        BurnerStartupTimer.Interval = 100
        FryerMimicTimer.Interval = 20
        CookTimer.Interval = 100
        MasterSpeedTimer.Interval = 100
        BurnerShutDownTimer.Interval = 100
        Randomize.Interval = 100
        OilCoolDownTimer.Interval = 100
        MasterSpeedChangeDelay.Interval = 100
        SlicerGradualChange.Interval = 100

    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs)

        BurnerFaultOn.Visible = False
        LowOilPressureFaultOn.Visible = False
        BurnerFaultOff.Visible = True
        LowOilPressureFaultOff.Visible = True
        FryerTempFaultOff.Visible = True
        FryerTempFaultOn.Visible = False


    End Sub

    Private Sub BCBBurnerStartButtonOff_Click_1(sender As Object, e As EventArgs)

        If BurnerFaultOn.Visible = False Then

            BCBBurnerStartButtonOff.Visible = False
            BCBStartButtonOn.Visible = True
            BurnerStartedOnImage.Visible = True
            BurnerStartedOffImage.Visible = False
            BurnerStartupTimer.Enabled = True

        End If

    End Sub

    Private Sub SkipBurnerStartup_Click(sender As Object, e As EventArgs) Handles SkipStartup.Click

        BurnerStartupCountdown = 0
        BurnerShutdownCountdown = 0
        SlicerCountdown = 0

    End Sub

    Private Sub BurnerResetButton_Click(sender As Object, e As EventArgs) Handles BurnerResetButton.Click

        If BurnerFaultOn.Visible = True Then

            BurnerFaultOn.Visible = False
            BurnerFaultOff.Visible = True
            FryerTempFaultOff.Visible = True
            FryerTempFaultOn.Visible = False
            LowOilPressureFaultOff.Visible = True
            LowOilPressureFaultOn.Visible = False

        End If

    End Sub


    Private Sub BCBBurnerStartButtonOff_Click_2(sender As Object, e As EventArgs) Handles BCBBurnerStartButtonOff.Click

        If LowOilPressureFaultOn.Visible = False And FryerTempFaultOn.Visible = False Then

            BurnerStartupCountdown = BURNERSTARTUPLEN
            BurnerStartupTimer.Enabled = True
            BCBStartButtonOn.Visible = True
            BCBBurnerStartButtonOff.Visible = False
        End If

    End Sub





    Private Sub VariancePlus(sender As Object, e As EventArgs)

        If CDec(Val(InfeedVarianceText.Text)) < 20 Then InfeedVarianceText.Text = CDec(Val(InfeedVarianceText.Text)) + 1

    End Sub

    Private Sub MoistureVarianceMinus_Click(sender As Object, e As EventArgs)

        If CDec(Val(MoistureVarianceText.Text)) > 0 Then MoistureVarianceText.Text = CDec(Val(MoistureVarianceText.Text)) - 0.01

    End Sub

    Private Sub MoistureVariancePlus_Click(sender As Object, e As EventArgs)

        If CDec(Val(MoistureVarianceText.Text)) < 1 Then MoistureVarianceText.Text = CDec(Val(MoistureVarianceText.Text)) + 0.01

    End Sub

    Private Sub TempVarianceMinus_Click(sender As Object, e As EventArgs)

        If CDec(Val(TempVarianceText.Text)) > 0 Then TempVarianceText.Text = CDec(Val(TempVarianceText.Text)) - 0.01

    End Sub

    Private Sub TempVariancePlus_Click(sender As Object, e As EventArgs)

        If CDec(Val(TempVarianceText.Text)) < 1 Then TempVarianceText.Text = CDec(Val(TempVarianceText.Text)) + 0.01

    End Sub



    Private Sub AllOnSwitchON_Click(sender As Object, e As EventArgs) Handles AllOnSwitchON.Click

        AllOnSwitchON.Visible = False
        AllOnSwitchOff.Visible = True

        ' Turn Off Submerger

        FSubOffImage.Visible = True
        FSubOnImage.Visible = False

        ' Turn off Fryer Catchbox

        FCtchOffImage.Visible = True
        FCtchOnImage.Visible = False

        'Turn Air, Knife and Sweep Off

        AirMOff.Visible = True
        AirMOn.Visible = False
        KMOn.Visible = False
        KMOff.Visible = True

        ' Turn Off Conveyor, Pump, Catchbox

        SCMOn.Visible = False
        SWCMOff.Visible = True
        SWPMOn.Visible = False
        SWPMOff.Visible = True
        SWCBMOn.Visible = False
        SWCBMOff.Visible = True

        ' Turn off Laning Conveyor

        LaningConveyorOnImage.Visible = False
        LaningConveyorOffImage.Visible = True
        LCMOff.Visible = True
        LCMOn.Visible = False

        ' Turn off Discharge Conveyor
        DischargeConveyorOffImage.Visible = True
        DischargeConveyorOnImage.Visible = False
        FDISOffImage.Visible = True
        FDISOnImage.Visible = False

        ' Turn off Slicers
        SlicerOn1.Visible = False
        SlicerOn2.Visible = False
        SlicerOn3.Visible = False
        SlicerOff1.Visible = True
        SlicerOff2.Visible = True
        SlicerOff3.Visible = True
        S1CMOff.Visible = True
        S1MOn.Visible = False
        S2CMOff.Visible = True
        S2MOn.Visible = False
        S3CMOff.Visible = True
        S3MOn.Visible = False

        ' Turn off Main Oil Pump

        FryerButtonScreen.MainOilPumpOn.Visible = False
        FryerButtonScreen.MainOilPumpStandby.Visible = True
        Me.MPumpOffImage.Visible = True
        Me.MPumpOnImage.Visible = False

        ' Turn off Paddles

        Me.FPLDOffImage.Visible = True
        Me.FPLDOnImage.Visible = False
        FryerButtonScreen.PaddleButtonOn.Visible = False
        FryerButtonScreen.PaddleButtonStandby.Visible = True

        ' Turn off Inspection Table

        ITOnImage.Visible = False
        ITOffImage.Visible = True

        ' Turn off Accumuveyor Infeed

        AFOffImage.Visible = True
        AFOnImage.Visible = False

        ' Turn off Hopper Conveyor

        HCOnImage.Visible = False
        HCOffImage.Visible = True

        ' Turn off Vibe Motors 1 and 2

        HCV1OffImage.Visible = True
        HCV1OnImage.Visible = False
        HCV2OffImage.Visible = True
        HCV2OnImage.Visible = False

        ' Turn of Outfeed Conveyor and Vibe 

        OCVOffImage.Visible = True
        OCVOnImage.Visible = False

        VBOnImage.Visible = False
        VBOffImage.Visible = True

        ' Turn off Accumulator 

        AccumulationOffImage.Visible = True
        AccumulationOnImage.Visible = False

        ' Turn off Outfeed

        OutfeedOffImage.Visible = True
        OutfeedOnImage.Visible = False

        ' Turn off Potato Preparation

        PPRunningOffImage.Visible = True
        PPRunningOnImage.Visible = False

        ' BurnerStarted pilot flame

        BurnerStartedOnImage.Visible = False
        BurnerStartedOffImage.Visible = True


    End Sub

    Private Sub AllOnSwitchOff_Click(sender As Object, e As EventArgs) Handles AllOnSwitchOff.Click

        AllOnSwitchON.Visible = True
        AllOnSwitchOff.Visible = False

        ' Turn On Potato Preparation

        PPRunningOffImage.Visible = False
        PPRunningOnImage.Visible = True

        ' Turn On Outfeed

        OutfeedOffImage.Visible = True
        OutfeedOnImage.Visible = False

        ' Turn On Accumulator 

        AccumulationOffImage.Visible = False
        AccumulationOnImage.Visible = True

        ' Turn on Inspection Table

        ITOnImage.Visible = True
        ITOffImage.Visible = False

        ' Turn on Accumuveyor Infeed

        AFOffImage.Visible = False
        AFOnImage.Visible = True

        ' Turn on Hopper Conveyor

        HCOnImage.Visible = True
        HCOffImage.Visible = False

        ' Turn on Vibe Motors 1 and 2

        HCV1OffImage.Visible = False
        HCV1OnImage.Visible = True
        HCV2OffImage.Visible = False
        HCV2OnImage.Visible = True

        ' Turn on Outfeed Conveyor and Vibe 

        OCVOffImage.Visible = False
        OCVOnImage.Visible = True

        VBOnImage.Visible = True
        VBOffImage.Visible = False


        ' Turn on Submerger

        FSubOffImage.Visible = False
        FSubOnImage.Visible = True

        ' Turn on Fryer Catchbox

        FCtchOffImage.Visible = False
        FCtchOnImage.Visible = True

        'Turn Air, Knife and Sweep Off

        AirMOff.Visible = False
        AirMOn.Visible = True
        KMOn.Visible = True
        KMOff.Visible = False

        ' Turn On Conveyor, Pump, Catchbox

        SCMOn.Visible = True
        SWCMOff.Visible = False
        SWPMOn.Visible = True
        SWPMOff.Visible = False
        SWCBMOn.Visible = True
        SWCBMOff.Visible = False

        ' Turn on Laning Conveyor

        LaningConveyorOnImage.Visible = True
        LaningConveyorOffImage.Visible = False
        LCMOff.Visible = False
        LCMOn.Visible = True

        ' Turn on Discharge Conveyor
        DischargeConveyorOffImage.Visible = False
        DischargeConveyorOnImage.Visible = True
        FDISOffImage.Visible = False
        FDISOnImage.Visible = True

        ' Turn on Slicers


        SlicerOn1.Visible = True
        SlicerOn2.Visible = True
        SlicerOn3.Visible = True
        SlicerOff1.Visible = False
        SlicerOff2.Visible = False
        SlicerOff3.Visible = False
        S1CMOff.Visible = False
        S1MOn.Visible = True
        S2CMOff.Visible = False
        S2MOn.Visible = True
        S3CMOff.Visible = False
        S3MOn.Visible = True



        ' Turn on Main Oil Pump

        FryerButtonScreen.MainOilPumpOn.Visible = True
        FryerButtonScreen.MainOilPumpStandby.Visible = False
        Me.MPumpOffImage.Visible = False
        Me.MPumpOnImage.Visible = True

        ' Turn on Paddles

        Me.FPLDOffImage.Visible = False
        Me.FPLDOnImage.Visible = True
        FryerButtonScreen.PaddleButtonOn.Visible = True
        FryerButtonScreen.PaddleButtonStandby.Visible = False

        ' BurnerStarted pilot flame

        BurnerStartedOnImage.Visible = True
        BurnerStartedOffImage.Visible = False

    End Sub



    Private Sub AccumulationStartButton_Click(sender As Object, e As EventArgs) Handles AccumulationStartButton.Click


        ' Turn On Accumulator 

        AccumulationOffImage.Visible = False
        AccumulationOnImage.Visible = True

        ' Turn on Accumuveyor Infeed

        AFOffImage.Visible = False
        AFOnImage.Visible = True

        ' Turn on Vibe Motors 1 and 2

        HCV1OffImage.Visible = False
        HCV1OnImage.Visible = True
        HCV2OffImage.Visible = False
        HCV2OnImage.Visible = True

    End Sub

    Private Sub AccumulationStopButton_Click(sender As Object, e As EventArgs) Handles AccumulationStopButton.Click

        ' Turn Off Accumulator 

        AccumulationOffImage.Visible = True
        AccumulationOnImage.Visible = False

        ' Turn off Accumuveyor Infeed

        AFOffImage.Visible = True
        AFOnImage.Visible = False

        ' Turn off Vibe Motors 1 and 2

        HCV1OffImage.Visible = True
        HCV1OnImage.Visible = False
        HCV2OffImage.Visible = True
        HCV2OnImage.Visible = False

    End Sub

    Private Sub OutfeedStartButton_Click(sender As Object, e As EventArgs) Handles OutfeedStartButton.Click

        ' Turn on reject conveyor

        RGConOnImage.Visible = True
        RGCONOffImage.Visible = False

        ' Turn on hoppy conveyor

        HCOnImage.Visible = True
        HCOffImage.Visible = False


        ' Turn On Outfeed

        OutfeedOffImage.Visible = False
        OutfeedOnImage.Visible = True

        ' Turn on Inspection Table

        ITOnImage.Visible = True
        ITOffImage.Visible = False

        ' Turn on Outfeed Conveyor and Vibe 

        OCVOffImage.Visible = False
        OCVOnImage.Visible = True

        VBOnImage.Visible = True
        VBOffImage.Visible = False


    End Sub

    Private Sub OutfeedStopButton_Click(sender As Object, e As EventArgs) Handles OutfeedStopButton.Click

        ' Turn on reject conveyor

        RGConOnImage.Visible = False
        RGCONOffImage.Visible = True

        ' Turn on hoppy conveyor

        HCOnImage.Visible = False
        HCOffImage.Visible = True

        ' Turn Off Outfeed

        OutfeedOffImage.Visible = True
        OutfeedOnImage.Visible = False

        ' Turn Off Inspection Table

        ITOnImage.Visible = False
        ITOffImage.Visible = True

        ' Turn Off Outfeed Conveyor and Vibe 

        OCVOffImage.Visible = True
        OCVOnImage.Visible = False

        VBOnImage.Visible = False
        VBOffImage.Visible = True

    End Sub

    Private Sub ProportionalMinus_Click(sender As Object, e As EventArgs) Handles ProportionalMinus.Click

        If CDec(Val(ProportionalText.Text)) > 0 Then ProportionalText.Text = CDec(Val(ProportionalText.Text)) - 1

    End Sub

    Private Sub ProportionalPlus_Click(sender As Object, e As EventArgs) Handles ProportionalPlus.Click

        If CDec(Val(ProportionalText.Text)) < 100 Then ProportionalText.Text = CDec(Val(ProportionalText.Text)) + 1

    End Sub

    Private Sub IntegralMinus_Click(sender As Object, e As EventArgs) Handles IntegralMinus.Click

        If CDec(Val(IntegralText.Text)) > 0 Then IntegralText.Text = CDec(Val(IntegralText.Text)) - 1

    End Sub

    Private Sub IntegralPlus_Click(sender As Object, e As EventArgs) Handles IntegralPlus.Click

        If CDec(Val(IntegralText.Text)) < 100 Then IntegralText.Text = CDec(Val(IntegralText.Text)) + 1

    End Sub

    Private Sub DerivativeMinus_Click(sender As Object, e As EventArgs) Handles DerivativeMinus.Click

        If CDec(Val(DerivativeText.Text)) > 0 Then DerivativeText.Text = CDec(Val(DerivativeText.Text)) - 1

    End Sub

    Private Sub DerivativePlus_Click(sender As Object, e As EventArgs) Handles DerivativePlus.Click

        If CDec(Val(DerivativeText.Text)) < 100 Then DerivativeText.Text = CDec(Val(DerivativeText.Text)) + 1

    End Sub

    Private Sub BurnerStopButton_Click(sender As Object, e As EventArgs) Handles BurnerStopButton.Click

        BurnerShutdownCountdown = BURNERSHUTDOWNLEN
        BurnerShutDownTimer.Enabled = True
        BurnerStartedOffImage.Visible = True
        BurnerStartedOnImage.Visible = False


    End Sub


    Private Sub SpeedControlModeButton_Click(sender As Object, e As EventArgs) Handles SpeedControlModeButton.Click

        If MasterSpeedManual.Visible = True Then

            MasterSpeedTimer.Enabled = True
            MasterSpeedManual.Visible = False
            MasterSpeedMinus.Visible = False
            MasterSpeedPlus.Visible = False
            MMMenu.Text = "AUTOMATIC"
            MMMenu.ForeColor = Color.Cyan

        Else

            MasterSpeedTimer.Enabled = False
            MasterSpeedManual.Visible = True
            MasterSpeedManual.Text = CDec(Val(MasterSpeedOutput.Text))
            MasterSpeedMinus.Visible = True
            MasterSpeedPlus.Visible = True
            MasterSpeedManual.Text = MasterSpeedOutput.Text
            MMMenu.Text = "MANUAL"
            MMMenu.ForeColor = Color.Yellow

        End If

        MasterSpeedOffset = (CDec(Val(MasterSpeedOutput.Text)) - 70) * CDec(Val(MasterSpeedRatioText.Text))



    End Sub

    Private Sub MasterSpeedMinus_Click(sender As Object, e As EventArgs) Handles MasterSpeedMinus.Click

        If Int(Val(MasterSpeedOutput.Text)) > 60 Then MasterSpeedOutput.Text = Int(Val(MasterSpeedOutput.Text)) - 1
        MasterSpeedOffset = (70 - CDec(Val(MasterSpeedOutput.Text))) * CDec(Val(MasterSpeedRatioText.Text))
        MasterSpeedManual.Text = CDec(Val(MasterSpeedOutput.Text))







    End Sub

    Private Sub MasterSpeedPlus_Click(sender As Object, e As EventArgs) Handles MasterSpeedPlus.Click

        If Int(Val(MasterSpeedOutput.Text)) < 90 Then MasterSpeedOutput.Text = Int(Val(MasterSpeedOutput.Text)) + 1
        MasterSpeedOffset = (70 - CDec(Val(MasterSpeedOutput.Text))) * CDec(Val(MasterSpeedRatioText.Text))
        MasterSpeedManual.Text = CDec(Val(MasterSpeedOutput.Text))



    End Sub


    Private Sub QABF101RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles QABF101RadioButton.CheckedChanged


        ' Load QAB-F101 values into system

        WoQMoistureTickSettingLowText.Text = "1.15"
        WoQMoistureTickSettingHighText.Text = "1.55"
        WoQMoistureExclSettingLowText.Text = "1.05"
        WoQMoistureExclSettingHighText.Text = "1.66"
        WoQMoistureXSettingLowText.Text = "1.04"
        WoQMoistureXSettingHighText.Text = "1.67"

        WoQInletTickSettingLowText.Text = "170"
        WoQInletTickSettingHighText.Text = "180"
        WoQInletExclSettingLowText.Text = "-"
        WoQInletExclSettingHighText.Text = "-"
        WoQInletXSettingLowText.Text = "169.99"
        WoQInletXSettingHighText.Text = "180.1"

        WoQDeltaTTickSettingLowText.Text = "18"
        WoQDeltaTTickSettingHighText.Text = "26"
        WoQDeltaExclSettingLowText.Text = "-"
        WoQDeltaExclSettingHighText.Text = "-"
        WoQDeltaXSettingLowText.Text = "17.99"
        WoQDeltaXSettingHighText.Text = "26.01"

        WoQMSTickLowSettingLowText.Text = "64"
        WoQMSTickLowSettingHighText.Text = "76"
        WoQMSExclSettingLowText.Text = "-"
        WoQMSExclSettingHighText.Text = "-"
        WoQMSXSettingLowText.Text = "63"
        WoQMSXSettingHighText.Text = "77"

    End Sub

    Private Sub RelRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RelRadioButton.CheckedChanged

        ' Load Realistic values into system

        WoQMoistureTickSettingLowText.Text = "1.15"
        WoQMoistureTickSettingHighText.Text = "1.55"
        WoQMoistureExclSettingLowText.Text = "1.05"
        WoQMoistureExclSettingHighText.Text = "1.66"
        WoQMoistureXSettingLowText.Text = "1.0"
        WoQMoistureXSettingHighText.Text = "1.67"

        WoQInletTickSettingLowText.Text = "170"
        WoQInletTickSettingHighText.Text = "180"
        WoQInletExclSettingLowText.Text = "166"
        WoQInletExclSettingHighText.Text = "169.9"
        WoQInletXSettingLowText.Text = "165.99"
        WoQInletXSettingHighText.Text = "180.1"

        WoQDeltaTTickSettingLowText.Text = "18"
        WoQDeltaTTickSettingHighText.Text = "26"
        WoQDeltaExclSettingLowText.Text = "-"
        WoQDeltaExclSettingHighText.Text = "-"
        WoQDeltaXSettingLowText.Text = "17.99"
        WoQDeltaXSettingHighText.Text = "26.01"

        WoQMSTickLowSettingLowText.Text = "64"
        WoQMSTickLowSettingHighText.Text = "76"
        WoQMSExclSettingLowText.Text = "-"
        WoQMSExclSettingHighText.Text = "-"
        WoQMSXSettingLowText.Text = "63"
        WoQMSXSettingHighText.Text = "77"

    End Sub

    Private Sub MasterSpeedChangeDelay_Tick(sender As Object, e As EventArgs) Handles MasterSpeedChangeDelay.Tick

        ' Changetimer increments every second till 5 then resets to 0 and turns off 
        ' Masterspeedchangedelay.  While the timer is active (enabled) no masterspeed change will occur
        ' This creates a 5 second delay between masterspeed changes.  Timer is enabled by masterspeed code
        ' after a masterspeed change and prevents masterspeed from incrementing and decrementing too quickly

        Static Dim ChangeTimer As Integer = 0

        ChangeTimer += 1

        If ChangeTimer > 5 Then
            MasterSpeedChangeDelay.Enabled = False
            ChangeTimer = 0
        End If

    End Sub

    Private Sub BulkMoistureMinus_Click(sender As Object, e As EventArgs)

        If CDec(Val(MoistureBulkText.Text)) > 0 Then MoistureBulkText.Text = CDec(Val(MoistureBulkText.Text)) - 0.1

    End Sub

    Private Sub BulkMoisturePlus_Click(sender As Object, e As EventArgs)

        If CDec(Val(MoistureBulkText.Text)) < 5 Then MoistureBulkText.Text = CDec(Val(MoistureBulkText.Text)) + 0.1

    End Sub

    Private Sub SlicerFeedAdjustmentDelay_Tick(sender As Object, e As EventArgs) Handles SlicerFeedAdjustmentDelay.Tick

        Static Dim DelayCounter = 0 ' delay from 0 to 5 seconds
        Static Dim LastChange As Integer = 0 ' valued of last change saved at end of routine to compare to new value

        If LastChange <> Int(Val(DelayedSpeedChange.Text)) Then DelayCounter = 0

        If DelayCounter = 2 Then
            DelayCounter = 0
            SlicerCountdown = SLICERCHANGEDELAYLEN
            SlicerFeedChangeDelay.Enabled = True
            SlicerFeedAdjustmentDelay.Enabled = False
        End If

        LastChange = Int(Val(DelayedSpeedChange.Text))
        DelayCounter += 1

    End Sub

    Private Sub SlicerFeedChangeDelay_Tick(sender As Object, e As EventArgs) Handles SlicerFeedChangeDelay.Tick

        BurnerInfoText.Visible = True



        SlicerAppendString = " Slicer Speed Will Change In " & SlicerCountdown & " seconds."

        SlicerPoliteFlag = True


        SkipStartup.Visible = True

        If SlicerCountdown <= 0 Then

            SlicerCountdown = 0
            SkipStartup.Visible = False
            SlicerPoliteFlag = False
            BurnerInfoText.Text = "PC 42 Fryer Simulation"
            SlicerFeedChangeDelay.Enabled = False
            SlicerGradualChange.Enabled = True
        End If

        SlicerCountdown -= 1

    End Sub

    Private Sub CCMasterSpeedMinus_Click(sender As Object, e As EventArgs) Handles CCMasterSpeedMinus.Click

        If CDec(Val(MasterSpeedRatioText.Text)) > 0 Then MasterSpeedRatioText.Text = CDec(Val(MasterSpeedRatioText.Text)) - 0.001

    End Sub

    Private Sub CCMasterSpeedPlus_Click(sender As Object, e As EventArgs) Handles CCMasterSpeedPlus.Click

        If CDec(Val(MasterSpeedRatioText.Text)) < 10 Then MasterSpeedRatioText.Text = CDec(Val(MasterSpeedRatioText.Text)) + 0.001

    End Sub

    Private Sub MoistureVarianceMinus_Click1(sender As Object, e As EventArgs) Handles MoistureVarianceMinus.Click

        If CDec(Val(MoistureVarianceText.Text)) > 0 Then MoistureVarianceText.Text = CDec(Val(MoistureVarianceText.Text)) - 0.1

    End Sub

    Private Sub MoistureVariancePlus_Click_1(sender As Object, e As EventArgs) Handles MoistureVariancePlus.Click

        If CDec(Val(MoistureVarianceText.Text)) < 100 Then MoistureVarianceText.Text = CDec(Val(MoistureVarianceText.Text)) + 0.1

    End Sub

    Private Sub TempVarianceMinus_Click_1(sender As Object, e As EventArgs) Handles TempVarianceMinus.Click

        If CDec(Val(TempVarianceText.Text)) > -1 Then TempVarianceText.Text = CDec(Val(TempVarianceText.Text)) - 0.0001

    End Sub

    Private Sub TempVariancePlus_Click_1(sender As Object, e As EventArgs) Handles TempVariancePlus.Click

        If CDec(Val(TempVarianceText.Text)) < 1 Then TempVarianceText.Text = CDec(Val(TempVarianceText.Text)) + 0.0001

    End Sub




    Private Sub SlicerRatioMinus_Click(sender As Object, e As EventArgs) Handles SlicerRatioMinus.Click

        If CDec(Val(SlicerRatioText.Text)) > -150 Then SlicerRatioText.Text = CDec(Val(SlicerRatioText.Text)) - 0.001

    End Sub

    Private Sub BulkMoistureMinus_Click_2(sender As Object, e As EventArgs) Handles BulkMoistureMinus.Click

        If CDec(Val(MoistureBulkText.Text)) > -150 Then MoistureBulkText.Text = CDec(Val(MoistureBulkText.Text)) - 0.1


    End Sub

    Private Sub BulkMoisturePlus_Click_2(sender As Object, e As EventArgs) Handles BulkMoisturePlus.Click

        If CDec(Val(MoistureBulkText.Text)) < 150 Then MoistureBulkText.Text = CDec(Val(MoistureBulkText.Text)) + 0.1

    End Sub

    Private Sub SlicerRatioPlus_Click_1(sender As Object, e As EventArgs) Handles SlicerRatioPlus.Click

        If CDec(Val(SlicerRatioText.Text)) < 150 Then SlicerRatioText.Text = CDec(Val(SlicerRatioText.Text)) + 0.001

    End Sub

    Friend Sub SlicerVarianceMinus_Click(sender As Object, e As EventArgs) Handles SlicerVarianceMinus.Click

        If CDec(Val(SlicerVarianceText.Text)) > -150 Then SlicerVarianceText.Text = CDec(Val(SlicerVarianceText.Text)) - 0.0001

    End Sub

    Friend Sub SlicerVariancePlus_Click(sender As Object, e As EventArgs) Handles SlicerVariancePlus.Click

        If CDec(Val(SlicerVarianceText.Text)) < 150 Then SlicerVarianceText.Text = CDec(Val(SlicerVarianceText.Text)) + 0.0001

    End Sub

    Private Sub SlicerVariance2Minus_Click(sender As Object, e As EventArgs) Handles SlicerVariance2Minus.Click

        If CDec(Val(FryFactor3Text.Text)) > -150 Then FryFactor3Text.Text = Format(CDec(Val(FryFactor3Text.Text)) - 0.001, "0.000")

    End Sub

    Private Sub SlicerVariance2Plus_Click(sender As Object, e As EventArgs) Handles SlicerVariance2Plus.Click

        If CDec(Val(FryFactor3Text.Text)) < 150 Then FryFactor3Text.Text = Format(CDec(Val(FryFactor3Text.Text)) + 0.001, "0.000")

    End Sub

    Private Sub FryFactorMinus_Click(sender As Object, e As EventArgs) Handles FryFactorMinus.Click

        If CDec(Val(FryFactorText.Text)) > -150 Then FryFactorText.Text = CDec(Val(FryFactorText.Text)) - 0.00001

    End Sub

    Private Sub FryFactorPlus_Click(sender As Object, e As EventArgs) Handles FryFactorPlus.Click

        If CDec(Val(FryFactorText.Text)) < 150 Then FryFactorText.Text = CDec(Val(FryFactorText.Text)) + 0.00001

    End Sub

    Private Sub FryFactor2Minus_Click(sender As Object, e As EventArgs) Handles FryFactor2Minus.Click

        If CDec(Val(FryFactor2Text.Text)) > -150 Then FryFactor2Text.Text = CDec(Val(FryFactor2Text.Text)) - 0.0001

    End Sub

    Private Sub FryFactor2Plus_Click(sender As Object, e As EventArgs) Handles FryFactor2Plus.Click

        If CDec(Val(FryFactor2Text.Text)) < 150 Then FryFactor2Text.Text = CDec(Val(FryFactor2Text.Text)) + 0.00001

    End Sub

    Private Sub InfeedVarianceOff_Click_1(sender As Object, e As EventArgs) Handles InfeedVarianceOff.Click

        Randomize.Enabled = True
        InfeedVarianceOn.Visible = True
        InfeedVarianceOff.Visible = False
        InfeedVarianceMinus.Enabled = True
        InfeedVarianceText.Enabled = True
        InfeedVariancePlus.Enabled = True

    End Sub

    Private Sub InfeedVarianceOn_Click_1(sender As Object, e As EventArgs) Handles InfeedVarianceOn.Click

        Randomize.Enabled = False
        InfeedVarianceOn.Visible = False
        InfeedVarianceOff.Visible = True
        InfeedVarianceMinus.Enabled = False
        InfeedVarianceText.Enabled = False
        InfeedVariancePlus.Enabled = False


    End Sub

    Private Sub InfeedVarianceMinus_Click(sender As Object, e As EventArgs) Handles InfeedVarianceMinus.Click

        If CDec(Val(InfeedVarianceText.Text)) > 0 Then InfeedVarianceText.Text = CDec(Val(InfeedVarianceText.Text)) - 1

    End Sub

    Private Sub InfeedVariancePlus_Click(sender As Object, e As EventArgs) Handles InfeedVariancePlus.Click

        If CDec(Val(InfeedVarianceText.Text)) < 10 Then InfeedVarianceText.Text = CDec(Val(InfeedVarianceText.Text)) + 1

    End Sub

    ' Randomly turns on and off events such as infeed and packaging
    Private Sub RandomFryerInputs_Tick(sender As Object, e As EventArgs) Handles RandomFryerInputs.Tick

        Dim MyMin As Integer                                        ' Minimum Random Number
        Dim MyMax As Integer                                        ' Maximum Random Number
        Dim Generator As System.Random = New System.Random()
        Static Dim RandomInfeedFlag As Integer                      ' If 1 then random event occurs
        Static Dim Counter As Integer                               ' Counter to end random event
        Static Dim InEvent As Boolean = False               ' If true then in a random event, run event code
        Static Dim InEventDuration As Integer               ' Duration of event, Controlled by Counter



        ' Set bounds, check for less then zero error and get a random if not in event already
        ' this number to be used to decide if we are going into an event = 1
        ' The lower the slicer speed the smaller the bounds and the more likely to enter event - conveyor stop

        MyMin = 0
        MyMax = (SlicerActualSpeed - 59) * (SlicerActualSpeed - 59)

        If MyMin < 0 Then MyMin = 0

        If InEvent = False Then RandomInfeedFlag = Generator.Next(MyMin, MyMax + 1)


        ' Set bounds, check for less then zero error and get a random if not in event already
        ' this number to be used to control the event duration
        ' The lower the slicer speed the longer the event - conveyor stop

        MyMin = 22 - (SlicerActualSpeed - 59)

        If MyMin < 0 Then MyMin = 0

        MyMax = 10 - (SlicerActualSpeed - 59)
        If MyMax < MyMin Then MyMax = MyMin + 1
        If InEvent = False Then InEventDuration = Generator.Next(MyMin, MyMax + 1)


        ' if the random number is 1 then in event otherwise not
        ' because its x times likely to be not the slicerfeed conveyor will intermittently turn off
        ' but usually wil be on.   Turn off feed conveyor if the number is 1 and enter the event = true 

        If RandomInfeedFlag = 1 And InEvent = False Then

            SFCMOff.Visible = True
            SFCMOn.Visible = False
            Counter = 0
            InEvent = True

        Else


            ' if we are in an event then check counter less than duration, if so increment counter
            ' if counter reaches event end then set event to false and leave event

            If InEvent = True And Counter < InEventDuration Then

                Counter += 1

                If Counter >= InEventDuration Then InEvent = False


            Else

                ' otherwise we are not in an event and we just turn on the feed conveyor in case we 
                ' have just previously left an event which turned it off

                SFCMOff.Visible = False
                SFCMOn.Visible = True


            End If

        End If

    End Sub

    Private Sub SmoothTimer_Tick(sender As Object, e As EventArgs) Handles SmoothTimer.Tick

        Static LastNumber As Decimal = MoistureValue ' holds last number displayed
        Static CurrentNumber As Decimal

        'If MoistureValue > 2 Or MoistureValue < 0 Then Return

        If LastNumber < CurrentNumber Then

            LastNumber += 0.001
            MoistureOutput.Text = Format(LastNumber, "0.00")

        End If

        If LastNumber > CurrentNumber Then

            LastNumber -= 0.001
            MoistureOutput.Text = Format(LastNumber, "0.00")

        End If


        If DataLoadFlag = True Then

            LastNumber = CurrentNumber
            CurrentNumber = MoistureValue
            DataLoadFlag = False

        End If



    End Sub

    Private Sub MoistureValueUpdateTimer_Tick(sender As Object, e As EventArgs) Handles MoistureValueUpdateTimer.Tick

        MoistureValue = ProductStream(CHIPS).Chips
        LoadedValue = ProductStream(CHIPS).ChipsLoaded
        DataLoadFlag = True

    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click

        TutorialFlag = FREEFRYER
        TutorialTimer.Enabled = True
        FryerHMITutForm.Visible = True
        FryerHMITutForm.TopMost = True
        SystemData.SelectedTab = TabPage1


    End Sub

    Private Sub TutorialTimer_Tick(sender As Object, e As EventArgs) Handles TutorialTimer.Tick

        FryerHMITutForm.TopMost = True

    End Sub

    Private Sub PoliteTimer_Tick(sender As Object, e As EventArgs) Handles PoliteTimer.Tick

        Static Dim Priority As Integer = 1
        Static Dim WaitCounter As Integer = 0

        If WaitCounter <= 0 Then
            If BurnerShutDownPoliteFlag = True Or BurnerStartupPoliteFlag = True Or SlicerPoliteFlag = True Then

                Select Case Priority

                    Case 1 ' Shutdown

                        Priority += 1

                        If BurnerShutDownPoliteFlag = True Then

                            BurnerInfoText.Text = BurnerShutDownAppendString
                            BurnerShutDownPoliteFlag = False
                            WaitCounter = 15
                        End If

                    Case 2 ' Startup

                        Priority += 1

                        If BurnerStartupPoliteFlag = True Then

                            BurnerInfoText.Text = BurnerStartingAppendString
                            BurnerStartupPoliteFlag = False
                            WaitCounter = 15

                        End If

                    Case 3 ' Slicer

                        Priority += 1

                        If SlicerPoliteFlag = True Then

                            BurnerInfoText.Text = SlicerAppendString
                            SlicerPoliteFlag = False
                            WaitCounter = 15

                        End If

                    Case Else

                        Priority = 1

                End Select

            End If

        Else

            WaitCounter -= 1

        End If

    End Sub


    Sub CloseOpenForms()

        My.Application.OpenForms.Cast(Of Form)() _
              .Except({ControlScreenForm, SplashScreen}) _
              .ToList() _
              .ForEach(Sub(form) form.Hide())

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click



        CloseOpenForms()
        Me.Show()

        Call Initialize()

    End Sub


    Private Sub Label97_Click(sender As Object, e As EventArgs) Handles Label97.Click

        TutorialTimer.Enabled = True
        FryerHMITutForm.Visible = True
        FryerHMITutForm.TopMost = True
        SystemData.SelectedTab = TabPage1

    End Sub

    Private Sub SlicerGradualChange_Tick(sender As Object, e As EventArgs) Handles SlicerGradualChange.Tick

        Static Dim InitFlag As Boolean = False
        Static Dim SpeedUp, VarianceSpeedup As Decimal


        ' if first time in timer after slicer speed change then initialize the slicer variables

        If InitFlag = False Then

            InitFlag = True
            SlicerSpeedUp = Int(Val(SlicerFeedSpeedButton.Text))
            SpeedUp = SlicerSpeedUp - Int(Val(DelayedSpeedChange.Text))
            VarianceSpeedup = SlicerSpeedUp - Int(Val(SlicerFeedSpeedButton.Text))
            DelayedSpeedChange.Text = CDec(Val(SlicerFeedSpeedButton.Text))

        End If


        SlicerActualSpeed += 0.25
        SpeedUp -= 0.25

        If SpeedUp < 0 Then

            SlicerGradualChange.Enabled = False
            SlicerActualSpeed = CDec(DelayedSpeedChange.Text)
            SlicerFeedSpeedButton.Text = CDec(DelayedSpeedChange.Text)
            SpeedUp = 0
            VarianceSpeedup = 0
            SlicerSpeedUp = 0
            InitFlag = False
        End If

    End Sub


    Private Sub PIDTimer_Tick(sender As Object, e As EventArgs) Handles PIDTimer.Tick

        PIDFlag = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles SlicerAdjustPlus.Click

        If CDec(Val(SlicerAdjustText.Text)) < 100 Then SlicerAdjustText.Text = CDec(Val(SlicerAdjustText.Text)) + 0.1


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles SlicerAdjustMinus.Click

        If CDec(Val(SlicerAdjustText.Text)) < 100 Then SlicerAdjustText.Text = CDec(Val(SlicerAdjustText.Text)) - 0.1

    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()
        ControlScreenForm.Visible = True

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click

        TutorialFlag = BASICS
        TutorialTimer.Enabled = True
        FryerHMITutForm.Visible = True
        FryerHMITutForm.TopMost = True
        SystemData.SelectedTab = TabPage1

    End Sub

    Private Sub EmptyFryer1Pic_Click(sender As Object, e As EventArgs) Handles EmptyFryer1Pic.Click

    End Sub

    Private Sub OnImage1_Click(sender As Object, e As EventArgs) Handles OnImage1.Click

    End Sub
End Class

