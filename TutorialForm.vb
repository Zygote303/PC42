Public Class FryerHMITutForm

    Dim FRYERHMIPAGEMAX As Integer = 40
    Dim FRYEROPSPAGEMAX As Integer = 22
    Dim PAGEMIN As Integer = 1

    Dim TutLength As Integer
    Dim PauseFlag As Boolean = False

    Dim HighLights(100) As Object
    Dim HighLights1() = {Fryer.panel1, Fryer.panel2, Fryer.panel10, Fryer.FryerInfeedMenuButton,
        Fryer.FryerButton, Fryer.FryerOutfeedButton, Fryer.CleaningButton, Fryer.DataLogsButton,
        Fryer.ProductSelectButton, Fryer.MainOverviewButton, Fryer.DTMenu, Fryer.SCMenu, Fryer.CPMenu,
        Fryer.MMMenu, Fryer.SpeedControlModeButton, Fryer.AlarmButton, Fryer.SlicerStopButton,
        Fryer.SlicerStartButton, Fryer.SlicerFeedMinusButton, Fryer.SlicerFeedSpeedButton,
        Fryer.SlicerFeedPlusButton, Fryer.LaningConveyorStopButton, Fryer.LaningConveyorStartButton,
        Fryer.InletSetpoint, Fryer.InletSetpointMinus, Fryer.InletSetpointButton, Fryer.InletSetpointPlus,
        Fryer.InletTemperature, Fryer.DeltaTText, Fryer.OutletTempText, Fryer.OilFlowTextbox,
        Fryer.MasterSpeedOutput, Fryer.SpeedControlModeButton, Fryer.MasterSpeedMinus,
        Fryer.MasterSpeedManual, Fryer.MasterSpeedPlus, Fryer.MoistureOutput, Fryer.SetPointOutput,
        Fryer.LowLimitOutput, Fryer.HighLimitOutput, Fryer.KHXStopButton, Fryer.KHXStartButton, Fryer.FlameBar,
        Fryer.DischargeConveyorStopButton, Fryer.DischargeConveyorStartButton, Fryer.BiasMinusButton,
        Fryer.BiasDisplayText, Fryer.BiasPlusButton, Fryer.RejectGateAutoButton, Fryer.RejectGateManualButton,
        Fryer.RGManualOpenButton, Fryer.RGManualCloseButton, Fryer.OutfeedStopButton, Fryer.OutfeedStartButton,
        Fryer.AccumulationStopButton, Fryer.AccumulationStartButton, Fryer.BurnerStatusTextLabel,
        Fryer.GatesLabel, Fryer.SlicersLabel, Fryer.PPRLabel, Fryer.Button10, Fryer.Button11, Fryer.Button12}

    Const INFEEDPANEL = 0
    Const FRYERPANEL = 1
    Const OUTFEEDPANEL = 2
    Const INFEEDBUTTON = 3
    Const FRYERBUTTON = 4
    Const OUTFEEDBUTTON = 5
    Const CLEANINGBUTTON = 6
    Const DATALOGBUTTON = 7
    Const PRODUCTSELECTBUTTON = 8
    Const MAINOVERVIEWBUTTON = 9
    Const DTMENU = 10
    Const SCMENU = 11
    Const CPMENU = 12
    Const MMMENU = 13
    Const SPEEDCONTROLBUTTON = 14
    Const ALARMBUTTON = 15
    Const SLICERSTOPBUTTON = 16
    Const SLICERSTARTBUTTON = 17
    Const SLICERFEEDMINUSBUTTON = 18
    Const SLICERSPEEDFEEDBUTTON = 19
    Const SLICERFEEDPLUSBUTTON = 20
    Const LANINGCONVEYORSTOP = 21
    Const LANINGCONVEYORSTART = 22
    Const INLETSETPOINT = 23
    Const INLETSETPOINTMINUS = 24
    Const INLETSETPOINTBUTTON = 25
    Const INLETSETPOINTPLUS = 26
    Const INLETTEMPERATURE = 27
    Const DELTAT = 28
    Const OUTLETTEMPTEXT = 29
    Const OILFLOW = 30
    Const MASTERSPEEDOUTPUT = 31
    Const MASTERSPEEDMODE = 32
    Const MASTERSPEEDMINUS = 33
    Const MASTERSPEEDMANUAL = 34
    Const MASTERSPEEDPLUS = 35
    Const MOISTUREDISPLAY = 36
    Const MOISTURESETPOINT = 37
    Const MOISTURELOW = 38
    Const MOISTUREHIGH = 39
    Const BURNERSTOPBUTTON = 40
    Const BURNERSTARTBUTTON = 41
    Const FLAMEBARDISPLAY = 42
    Const DISCHARGESTOPBUTTON = 43
    Const DISCHARGESTARTBUTTON = 44
    Const BIASMINUSBUTTON = 45
    Const BIASDISPLAY = 46
    Const BIASPLUSBUTTON = 47
    Const RGAUTO = 48
    Const RGMANUAL = 49
    Const RGMANUALOPEN = 50
    Const RGMANUALCLOSE = 51
    Const OUTFEEDSTOP = 52
    Const OUTFEEDSTART = 53
    Const ACCUMSTOP = 54
    Const ACCUMSTART = 55
    Const BURNERSTATUSLABEL = 56
    Const GATESLABEL = 57
    Const SLICERSLABEL = 58
    Const POTATOPREPLABEL = 59
    Const PAUSEBUTTON = 60
    Const NORMALBUTTON = 61
    Const FASTBUTTON = 62

    Dim HighLights2() = {Fryer.BurnerStatusTextLabel, Fryer.GatesLabel, Fryer.SlicersLabel, Fryer.PPRLabel,
        Fryer.InletSetpoint, Fryer.SlicerFeedSpeedButton, Fryer.SpeedControlModeButton, Fryer.RejectGateManualButton,
        Fryer.RGManualOpenButton, Fryer.KHXStartButton, Fryer.SlicerStartButton, Fryer.DischargeConveyorStartButton, Fryer.DischargeConveyorStopButton,
        Fryer.MMMenu, Fryer.panel1, Fryer.panel2, Fryer.panel10, Fryer.FryerInfeedMenuButton,
        Fryer.FryerButton, Fryer.FryerOutfeedButton, Fryer.CleaningButton, Fryer.DataLogsButton,
        Fryer.ProductSelectButton, Fryer.MainOverviewButton}

    Dim HighLights3() = {Fryer.panel1, Fryer.panel2, Fryer.panel10, Fryer.FryerInfeedMenuButton,
        Fryer.FryerButton, Fryer.FryerOutfeedButton, Fryer.CleaningButton, Fryer.DataLogsButton,
        Fryer.ProductSelectButton, Fryer.MainOverviewButton, Fryer.DTMenu, Fryer.SCMenu, Fryer.CPMenu,
        Fryer.MMMenu, Fryer.panel1, Fryer.panel2, Fryer.panel10, Fryer.FryerInfeedMenuButton,
        Fryer.FryerButton, Fryer.FryerOutfeedButton, Fryer.CleaningButton, Fryer.DataLogsButton,
        Fryer.ProductSelectButton, Fryer.MainOverviewButton}

    Dim HighLights4() = {Fryer.panel1, Fryer.panel2, Fryer.panel10, Fryer.FryerInfeedMenuButton,
        Fryer.FryerButton, Fryer.FryerOutfeedButton, Fryer.CleaningButton, Fryer.DataLogsButton,
        Fryer.ProductSelectButton, Fryer.MainOverviewButton, Fryer.DTMenu, Fryer.SCMenu, Fryer.CPMenu,
        Fryer.MMMenu, Fryer.panel1, Fryer.panel2, Fryer.panel10, Fryer.FryerInfeedMenuButton,
        Fryer.FryerButton, Fryer.FryerOutfeedButton, Fryer.CleaningButton, Fryer.DataLogsButton,
        Fryer.ProductSelectButton, Fryer.MainOverviewButton}

    Dim SavedHighLights(100, 2) As Color

    ' Control Screen Constants

    Friend Const FREEFRYER = 1
    Friend Const BASICS = 2
    Friend Const TITRATION = 3
    Friend Const SLICERS = 4
    Friend Const HMITUT = 5
    Friend Const SIMTUT = 6


    Dim FileStrings(100) As Image
    Dim FileStrings1() As Image = {My.Resources.FryerChipsEmerging, My.Resources.FryerChipsEmerging,
                                   My.Resources.ImageOfHMIScreen, My.Resources.HMIFullSS,
                                   My.Resources.FryerHMITutPic4, My.Resources.FryerHMITutPic5,
                                   My.Resources.FryerHMITutPic6, My.Resources.FryerHMITutPic7,
                                   My.Resources.FryerHMITutPic8, My.Resources.FryerHMITutPic9,
                                   My.Resources.HMIFryerInfeedSS, My.Resources.HMISlicerFeedSS1,
                                   My.Resources.HMISlicerFeedSS2, My.Resources.HMISlicerFeedSS3,
                                   My.Resources.HMISlicerFeedSS4, My.Resources.HMISlicerFeedSS5,
                                   My.Resources.LaningConveyor1, My.Resources.LaningConveyor2,
                                   My.Resources.HMILaningConvSS, My.Resources.HMIInfedDriveStatusSS,
                                   My.Resources.HMISetpointInletTempSS, My.Resources.HMISetpointInletTempSS,
                                   My.Resources.HMIDeltaTSS, My.Resources.HMIOutletTempSS,
                                   My.Resources.HMIOutletTempSS, My.Resources.HMIMasterSpeedSS,
                                   My.Resources.HMIMasterSpeedSS, My.Resources.HMIMasterSpeedManSS,
                                   My.Resources.HMIMoistureOutputSS, My.Resources.HMIMM55SS,
                                   My.Resources.HMIMoistureSetPointsSS, My.Resources.HMIMakeUPValveSS,
                                   My.Resources.HMIKHXSS, My.Resources.HMIKHXSS,
                                   My.Resources.HMIKHXSS, My.Resources.HMIDischargeConvSS,
                                   My.Resources.HMIRGAutoSS, My.Resources.HMIRGManualSS,
                                   My.Resources.HMIOutfeedSS, My.Resources.HMIAccumSS,
                                   My.Resources.Congratulations, My.Resources.HMIFryerScreenMakeUpValveSS,
                                   My.Resources.Congratulations, My.Resources.Congratulations}

    Dim FileStrings2() As Image = {My.Resources.FryerChipsEmerging, My.Resources.FryerChipsEmerging,
                                   My.Resources.ImageOfHMIScreen, My.Resources.HMIKHXSS,
                                   My.Resources.FryerHMITutPic4, My.Resources.HMILaningConvSS,
                                   My.Resources.OilSplash, My.Resources.Valve,
                                   My.Resources.Bubbler_Level_Measurement_System, My.Resources.Spuds,
                                   My.Resources.MathsEquation, My.Resources.HMISetpointInletTempSS,
                                   My.Resources.HMISlicerFeedSS2, My.Resources.HMIMasterSpeedSS,
                                   My.Resources.HMIMasterSpeedManSS, My.Resources.HMIRGAutoSS,
                                   My.Resources.FryerChipsEmerging2, My.Resources.BurnerJetFlame,
                                   My.Resources.HMISetpointInletTempSS, My.Resources.HMIDischargeConvSS,
                                   My.Resources.HMIRGAutoSS, My.Resources.HMIMasterSpeedSS,
                                   My.Resources.Congratulations}

    Dim FileStrings3() As String = {}

    Dim FileStrings4() As String = {}


    Dim HeadingStrings(100) As String

    Dim HeadingStrings1() As String = {"Filler", "Starting the fryer",
                                      "HMI",
                                      "HMI - Screen Elements",
                                      "HMI - Screen Elements",
                                      "HMI - Screen Elements",
                                      "HMI - Screen Elements",
                                      "HMI - Screen Elements",
                                      "HMI - Alarms Button",
                                      "HMI - Acknowledge an Alarm",
                                      "HMI - Infeed Panel",
                                      "HMI - Slicer Feed Control",
                                      "HMI - Slicer Feed Control",
                                      "HMI - Slicer Feed Control",
                                      "HMI - Slicer Feed Control",
                                      "HMI - Slicer Feed Control",
                                      "HMI - Laning Conveyor",
                                      "HMI - Laning Conveyor",
                                      "HMI - Gate and Slicer Indicators",
                                      "HMI - Infeed Drive Status Indicators",
                                      "HMI - Inlet Setpoint",
                                      "HMI - Inlet Temp.",
                                      "HMI - Delta T",
                                      "HMI - Outlet Temp.",
                                      "HMI - Oil Flow",
                                      "HMI - Master Speed System",
                                      "HMI - Master Speed System",
                                      "HMI - Master Speed System",
                                      "HMI - Moisture Indicator",
                                      "HMI - Moisture Sensor",
                                      "HMI - Moisture Limit Indicators",
                                      "HMI - Oil Make Up Valve",
                                      "HMI - KHX Burner System",
                                      "HMI - KHX Burner System",
                                      "HMI - KHX Burner System",
                                      "HMI - Discharge Conveyor",
                                      "HMI - Reject Gate",
                                      "HMI - Reject Gate",
                                      "HMI - Outfeed",
                                      "HMI - Accumulation",
                                      "You're Finished, Congratulations"}

    Dim HeadingStrings2() As String = {"Filler", "Welcome to the Basic Skills Tutorial",
                                      "Pre-Operational Check",
                                      "Pre-Operational Check - Burner",
                                      "Pre-Operational Check - Status Indicators",
                                      "Pre-Operational Check - Slicers",
                                      "Pre-Operational Check - Oil Selection",
                                      "Pre-Operational Check - Oil Makeup Valves",
                                      "Pre-Operational Check - Oil Level",
                                      "Pre-Operational Check - Potatos",
                                      "Pre-Operational Check - Fryer Settings",
                                      "Pre-Operational - Inlet Setpoint",
                                      "Pre-Operational - Slicer Feed",
                                      "Pre-Operational - Master Speed",
                                      "Pre-Operational - Master Speed",
                                      "Pre-Operational - Reject Gate",
                                      "Starting Production",
                                      "Starting the Burner",
                                      "Starting the Slicer Infeed",
                                      "Stop / Start the Discharge Conveyor",
                                      "Close the Reject Gate",
                                      "Set Master Speed to Automatic",
                                      "You're Finished, Congratulations"}

    Dim HeadingStrings3() As String = {"Filler", "PC42 Fryer Simulator",
                                      "HMI",
                                      "HMI - Screen Elements",
                                      "HMI - Screen Elements",
                                      "HMI - Screen Elements",
                                      "HMI - Screen Elements",
                                      "HMI - Screen Elements",
                                      "HMI - Alarms Button",
                                      "HMI - Acknowledge an Alarm",
                                      "HMI - Infeed Panel",
                                      "HMI - Slicer Feed Control",
                                      "HMI - Slicer Feed Control",
                                      "HMI - Slicer Feed Control",
                                      "HMI - Slicer Feed Control",
                                      "HMI - Slicer Feed Control",
                                      "HMI - Laning Conveyor",
                                      "HMI - Laning Conveyor",
                                      "HMI - Gate and Slicer Indicators",
                                      "Inlet Temp and Delta T",
                                      "Inlet Temp and Delta T"}

    Dim HeadingStrings4() As String = {"Filler", "PC42 Fryer Simulator",
                                      "HMI",
                                      "HMI - Screen Elements",
                                      "HMI - Screen Elements",
                                      "HMI - Screen Elements",
                                      "HMI - Screen Elements",
                                      "HMI - Screen Elements",
                                      "HMI - Alarms Button",
                                      "HMI - Acknowledge an Alarm",
                                      "HMI - Infeed Panel",
                                      "HMI - Slicer Feed Control",
                                      "HMI - Slicer Feed Control",
                                      "HMI - Slicer Feed Control",
                                      "HMI - Slicer Feed Control",
                                      "HMI - Slicer Feed Control",
                                      "HMI - Laning Conveyor",
                                      "HMI - Laning Conveyor",
                                      "HMI - Gate and Slicer Indicators",
                                      "Inle",
                                      "Inlet Temp and Delta T"}

    Dim Textstrings(100) As String
    Dim TextStrings1() As String = {"Filler", "Welcome to the PC42 Fryer Simulation Tutorial.  

This simulation models a continuous chip fryer and is based on the PC 42 Model.  The simulation will allow you to become familiar with the basic concepts of operating a similiar type system.   

However, because of the scalability and customization options available when designing and implementing fryer systems on site the simulation may not be identical to the system you use or intend on using in the future.",
"First we will discuss the fryer HMI or Human Machine Interface.  The green area highlighted on your screen is your fryer HMI.  HMI is just a fancy phrase for a computer screen or display input device.

The HMI allows you to view the status of the fryer and to issue commands and adjust settings. 

Click Next to start Exploring the PC42 Fryer's HMI.", "The Elements of the HMI Consists of the following major screen parts:

The Status Bar of the HMI (highlighted in green)which shows:

Date and Time

Fryer Communication Status

The currently loaded product recipe

The moisture mode the fryer is running in.",
"The Fryer Infeed panel (highlighted in green) contains controls and indicators for:

Monitoring the potato preparation area status.

Turning on and off the loading of product into the fryer.

Adjusting the amount of product loaded into the fryer.

Turning on or off the conveyor that splits the potatoes into streams to feed into the slicers.

Monitoring the equipment connected to the infeed system.",
"The Fryer Panel (highlighted in green) contains controls and indicators for:

Setting temperatures.

Monitoring fryer oil flow and temperature.

Monitoring Product moisture levels.

Adjusting the Masterspeed System

Starting and stopping the burner (oil heating system).",
"The last panel at the bottom of the screen is the Fryer Outfeed panel.  

This area contains controls for:

Rejecting poor quality chips.

Control of transport, storage and monitoring of finished product before it is packaged.
",
"The Moisture Mode heading indicates the Master Speed control mode.  Master Speed adjusts the time the chips spend inside the fryer.  

If the [Moisture Mode] indicates AUTOMATIC then the fryer is controlling the Master Speed.  If MANUAL then Master Speed is controlled by the fryer operator.  

We can toggle this setting by finding [Control Mode] in the FRYER section of the HMI and clicking it to change modes.
", "To the right of the Moisture Mode heading you will find two grey buttons, one labeled with an [A] - this is the Alarms Button.  

When the fryer encounters an error which requires human operator intervention it will sound a loud audible alarm.",
    "When this happens you must click the Alarms button and then click the [Acknowlege] button located here to stop the audible alarm. 

On the alarms screen you will also find a table with the alarms listed which triggered the siren.  You can then use the information listed here to decide which steps you might take to correct the problem.  

Go ahead and click the [A] and take a look inside.",
"Next we'll look at the Fryer Infeed Panel   

The first element on the Fryer Infeed Panel is the Potato Preparation Indicator located underneath the Date and Time heading.   

The indicator is either a green solid line or a red solid line and tells us whether or not the Potato Preparation system is operating so that it can feed the slicer system with potatoes to turn into product.",
"To the right of the Potato Preparation indicator are the Slicer Feed controls.  

The Slicer Feed [START] button causes an automated conveyor called the Infeed Conveyor to activate and carry potatoes from the potato preparation area up to the Laning Conveyor which then split the potatoes into lanes to feed potatoes into each of the slicer heads.   

The Slicer Feed [STOP] button stops the Infeed Conveyor.",
"When the Slicer Feed is active the Slicer Feed indicator will turn green.  When deactivated the indicator will turn red.


Below the Slicer Feed Indicator Line are 3 buttons [-] [#] and [+].

The [-] button will reduce the Infeed Conveyor speed to reduce the amount of potatoes carried up to and into the Laning Conveyor.   

The [+] button will increase the speed of the Infeed Conveyor.   
",
"Note that when the Slicer Infeed speed is increased there is a delay before the increase is applied.   You can test this now.   

Click the [+] button repeatedly until the speed changes to 66.   Wait a few seconds and then attempt to change the infeed again.  If you waited long enough the control will be locked.

The slicer speed is adjusted after an approximate 3 minute delay.  You will know this has occurred when the teal number below the button changes to match the number on the button.",
"Activity 1

1. Click the Slicer Feed [START] button to start the slicer infeed.  Pay attention to the Inlet Temp Gauge to the left and downwards of the Slicer Feed controls.

2.  You should see that the Inlet Temp Gauge is displaying a quickly decreasing number.     

3. Click the Slicer Feed [STOP] button to stop the Infeed Conveyor from activating.",
"Activity 1 (Continued)

When you activate the slicer and the burner is not turned on the oil in the fryer rapidly cools.  This is because the Infeed Conveyor is feeding potatoes into the slicers and cold moist potato slices are then being fed into the fryer.

If you accidentally activate the infeed without the burner on or the burner turns off due to fault, dump the chips immediately and restart the burner before continuing.",
"To the right of the Infeed Speed controls are the Laning Conveyor controls.  

The Laning Conveyor is a conveyor that the Infeed Conveyor supplies with potatoes.   

It is the Laning Conveyors job to split the stream of potatoes into multiple lanes and then feed those lanes of potatoes into individual slicer heads.",
"The slicer heads spin constantly and when potatoes fall into them the heads slice the potatoes into raw potato chips which are then washed and dried and fed into the oil at the end of the fryer.

The Laning Conveyor controls consist of a [STOP] and [START] button and a Indicator Line that is either green or red.

Take the time now to [STOP] and then [START] the Laning Conveyor.",
"The Gate and Slicer Indicators are below the Laning Conveyor controls.  

The Gate Indicators are small green or red horizontal strips while the Slicer Indicators are green or red rectangles with a picture of a slicer head on each one. 

When the slicers or gates are not active the indicators appear red and while active they appear green.",
"The last area we will talk about is the Infeed Drive Status on the Infeed Panel.  This area shows the status of the motors, pumps and other devices used to operate the Infeed system.

Each motor or pump is listed and has a status indicator that is either dark green (operating), light green (on standby), grey (switched off) or red (faulted).

Before operating the fryer always make sure that the indicators are either operating or on standby.  If any indicator is grey or red then they must either be switched on first or fixed by maintenance staff.",
"Lets now take a look at the Fryer Panel controls.  

The first control is the Inlet Setpoint control.   This control allows you to specify the temperature you would like the fryer to operate at.  

The Inlet Setpoint control displays the desired inlet setpoint and has 3 buttons underneath to adjust this setting.

Clicking on the [-] minus button lowers the temperature by 1 degree and the [+] button increases it by 1 degree.",
"To the right of the Inlet Setpoint control is the Inlet Temp. display.  

The Inlet Temp. displays the actual temperature of the oil as it enters the fryer.  The inlet is located at the end of the fryer where the raw potato slices enter the oil.

Its important to remember that the Inlet Setpoint is the temperature you would like to achieve at the inlet and the Inlet Temp. is the temperature you are actually achieving. ",
"Underneath the Inlet Temp. display you will find the Delta T. display.   

The Delta T is the temperature difference between the oil entering the fryer and the oil leaving at the other end of the fryer.

If the oil entering the fryer is 170 degrees C and the oil leaving the fryer is 150 degrees C then the Delta will be 170-150 = a Delta T of 20.",
"Underneath the Inlet Setpoint is another display called Outlet Temp. This display indicates the temperature of the oil leaving the fryer through the outlet.

The outlet is located at the front of the fryer where the cooked chips are taken out.

The oil leaves through the outlet and is pumped back to the burner system to be reheated and then returned to the inlet.",
"Underneath the Outlet Temp. display is the Oil Flow display.  

The Oil Flow display shows us per minute, how many litres of oil is being pumped from the outlet, through the burner systems heat exchanger and then back to the inlet.",
"Lets now investigate the fryers Master Speed system.  

The Masterspeed system is used by the fryer to increase and decrease the speed of the potato chips as they move through the fryer.  This allows the fryer to control the length of time the chips are inside the fryer and subsequently the amount of moisture they lose.

The fryer uses an infrared moisture sensor suspended above the emerging chips to detect the moisture level of the cooked chips.",
"The moisture result obtained by the fryer is then used to adjust a number of paddles and a submerger system inside the fryer which speeds up or slows down the rate at which the chips move through the fryer.

While the Master Speed system is usually automatically controlled by the fryer, we can use the Control Mode button to set the system to manual and select the speed ourselves.

This is especially important when starting the fryer before the moisture sensor can assess moisture content.",
"Activity 2:

Perform the following steps.

1. Click the Control Mode button.
2. You should see 3 new buttons appear underneath the masterspeed gauge.
3. Decrease the Master Speed by clicking on the [-] button until the Master Speed is set to 64.
4. Increase the Master Speed by clicking on the [+] button until the Master Speed is set to 76.
5. Reengage the Master Speed so the fryer takes over the operation of the system.",
"To the right of the Control Mode button you will find another display called Moisture.  This indicator displays the current moisture of the chips travelling underneath the moisture sensor.

Be sure to monitor this window frequently to ensure that the moisture is not becoming too high or too low.  

If the moisture does become too high or low the fryer will automatically reject the chips by opening a reject device and the produced chips will be dumped onto a reject conveyor and carried into a waste bin.",
"Underneath the Moisture display you will find the MM55 infrared moisture sensor indicator.

The MM55 sensor is suspended above the Outfeed Conveyor and uses infrared sensing to detect the moisture of the produced product. 

The indicator for this device displays the status of the devices cooling and its power supply.

If either is not green then the device will not function and a maintenance technician must be called.",
"To the right of the MM55 indicator you will see 3 display indicators called Setpoint, High Limit and Low Limit.

These 3 indicators show the desired, minimum and maximum moisture values required for the product being produced.

If the moisture exceeds the high limit or is below the low limit then the fryer will automatically open the reject gate and dump the chips. 

These limits are programmed into the recipe of the product being produced so they vary according to the product.",
"On the far right hand side of the Fryer Panel you will find the status indicators of the motors and pumps that control the functions of the Fryer Panel.

These status indicators should be dark green (operating) or light green (on standby) except for the last one, the Make Up Valve.

The Make Up Valve is usually grey but will periodically turn green when it adds new oil to the fryer to make up for lost oil absorbed by the finished product.",
"The KHX Burner controls are located on the bottom middle of the Fryer Panel.   These controls allow us to operate the fryers burner system.   

The burner is gas fired and has a 5 minute start up cycle before it activates the main flame.

When active and oil is pumped from the fryer outlet and into the burners heat exchanger, the burners heat is transferred to the oil.  The oil is then pumped back into the fryer via the inlet valve.",
"To Start the burner system requires that the main oil pump is active and no faults appear on the burner control panel.

You can check if the main oil pump is on by looking at its listing in the Fryer Drive Status on the far right of the Fryer Panel.

This simulation has the burner panel located outside the HMI on the right-hand bottom of the screen.

If the main oil pump is on and the panel shows no faults then the burner system is ready to be started.",
"To Start the burner system you can either click the Start button on the KHX Burner controls in the HMI or you can alternatively click the Burner Start icon on the Burner Control Panel.

To Stop the burner you can either click the Stop button on the KHX Burner controls or you can click the Burner Stop button on the Burner Control Panel.

To reset a fault on the Burner Control Panel click the Burner Reset button on the Burner Control Panel.",
"The Discharge Conveyor is located at the beginning of the fryer.  It is used to remove the cooked chips from the fryer oil and to drain excess oil from the chips as they travel up and under the moisture sensor.

The Discharge Conveyor Stop and Start controls allow us to stop and start the conveyor.",
"Lets now look at the Outfeed Panel located at the bottom of the screen.

The first set of controls are the Reject Gate controls.  These controls allow you to set the Reject Gate to Auto and to switch them to manual control.

The Reject Gate is located at the end of the Discharge Conveyor and opens up to allow out of specification chips to be dumped onto the Reject Conveyor and conveyed into a waste bin",
"When the Reject Gate is set to Manual, two new buttons [Open] and [Close] appear.  

Activity: 

1. Click the [Manual] button to set the Reject Gate to Manual control.

After setting the Reject Gate to Manual we can perform the following tasks:

1. Click [Open] to open the Reject gate.
2. Click [Close] to close the Reject Gate.
3. Click [Auto] to allow the computer to take control of the gate.",
"To the right of the Reject Gate controls are the Outfeed controls.  

These controls turn off and turn on the outfeed components such as the inspection table and conveyors which transport chips to the accumulation system.",
"The next set of controls are the Accumulation controls.  

These turn on and turn off the Accumulation system.  

The Accumulation system stores the finished product until it is required by the packaging section.",
"Congratulations.  

You have completed the fryers HMI tutorial and should now be familiar with the fryer HMI.

You can now undertake the Fryer Operator tutorial to learn how to start producing product.  You will learn:

1. How to perform the pre-operation checks required before starting the fryer.
2. How to start the fryer and begin producting product.
3. How to stop the fryer system once running.",
"",
"",
"",
""}

    Dim TextStrings2() As String = {"Filler",
"In this tutorial you will learn the following skills:

1. How to perform the pre-operational checks to ensure the fryer is ready to be started.
2. How to ensure the oil system is ready.
3. How to ensure the potato system is ready to serve potatoes to the fryer to produce product.
4. How to set up the initial parameters of the fryer.
5. How to start the fryer safely and efficiently.
6. How to stop the fryer safely and efficiently.

",
"Before Starting the PC42 Fryer you must ensure that the following systems are ready and checks are complete:

1. The Burner system is ready.
2. The screen status icons show green.
3. The slicer system is operational.
4. The correct oil has been selected on the oil management HMI.
5. The oil make up valves are open.
6. The oil level in the fryer is correct.
7. Potatoes are selected and Potato Preparation shows operational.
8. Inlet Setpoint, Slicer Speed, Master Speed rate and the Reject Gate are correctly set.",
"To check the status of the burner inspect the Burner Started indicator (highlighted in green) in the Fryer Panel.

If the Burner Started indicator is green then the burner is ready for operation.

If the Burner Started indicator is red you will need to manually inspect the Burner Panel for faults.

If the Burner Panel is clear of faults then the burner is ready for operation",
"On the right hand side of the 3 HMI Panels are lists of fryer components.

Check the lists and ensure that all components of all 3 panels show as dark green or light green.

The only exception to this will be the Oil Make Up Valve indicator in the Fryer Panel which will be grey.  

If any other component is grey or red then you will need to start or rectify that component before starting the fryer system.
",
"
Double check the slicer system is functioning by confirming the Gates and Slicers indicators (highlighted) in the Fryer Infeed Panel are all green.

If either are showing red status you will need to go to the Slicer Control Panel above the fryer and correct the issue.",
"To select the correct oil type you will need to go to the Oil Management Panel and select the oil to be supplied to the fryer.

The fryer may be using different types of oil in its weekly operational schedule so identifying the oil in the fryer and selecting the correct oil is extremely important.

Liase with your team leader to ensure you know what type of oil you are using and to ensure the correct oil type is selected.",
"Ensure the fryers Oil Make Up Valves are open so that periodically, new oil is able to enter the fryer and replace oil that leaves the fryer in the finished product.

Consult a colleague or your team leader for the location of the Oil Make Up Valve lever system and how to operate it.",
"It is essential that the oil level in the fryer is correct.  High or low oil levels will cause finished product to be out of specification.

To check the oil level, locate the bubble type oil level system installed on your fryer and ensure that the oil level is correct.  

If the level is correct bubbles should be observed leaving the end of the tube immersed in the oil. 

If the level is too high or too low, no bubbles will be visible.",
"Before we can produce potato products we need to first ensure that we have selected potatos to be fed into the fryer. 

Go to the potato preparation area and check the potato management system.

Be sure to write down the Bin Number, Grower Name, Lot or Batch Number, Tonnage and the specific gravity of the selected potato's for your log book.

Lastly check the Potato Preparation indicator on the Infeed Panel is a solid green line.",
"To correctly start the fryer you will need to select the initial startup parameters:

Inlet Setpoint - the temperature that we want the fryer to operate at.

Slicer Feed - The speed of the infeed conveyor which controls the amount of potatoes entering the fryer.

Master Speed - The speed of the paddles and submerger that move the product through the fryer.

Reject Gate - Set to manual initially.",
"Initially we will start the fryer with an Inlet Setpoint of 170 degrees Celcius.  

Check the Inlet Setpoint control (highlighted in green) and adjust it if necessary to 170 degrees.

Activity: Set the Inlet Setpoint Start Up Setting to: 170

",
"Next check the Slicer Feed control (highlighted in green).  If the control is not set to 62 then set this control to 62 now. 

Activity: Set the Slicer Feed Start Up Setting to: 62 

Take care when setting this control from a lower speed to a higher speed - it has a delay of approximately 4 minutes before it can be changed again, once changed.
",
"The Master Speed control is an automatic system that adjusts the speed of the paddles and submerger inside the fryer.

The slower the speed the slower the product moves through the fryer and the more moisture is removed.  Conversely the faster the speed the quicker the product moves and the less moisture is removed.

The system can be set to manual with the Control Mode toggle button (highlighted in green).

This allows you to manually selected the Master Speed.",
"Click the Control Mode toggle button to change the Master Speed mode to Manual then use the + and - buttons to change the Master Speed to 72.

Activity: Set the Master Speed Start Up Setting to: 72",
"Now we need to set the Reject Gate system to manual control and open the gate so any out of specification product which initially leaves the fryer is rejected.

The Reject Gate controls are located on the Fryer Outfeed panel at the bottom of the screen.  

Activity: Click the Manual control button (highlighted in green). Then click the Open button underneath (also highlighted) to open the Reject Gate.",
"Its now time to start up the fryer and begin producing product.  The steps required are:

1. Start the burner.
2. Heat the oil until the Inlet Temperature reaches 150 degrees.
3. Activate the Slicer Feed.
4. Stop the Discharge Conveyor for several seconds when product appears at the conveyor.
5. Restart the Discharge conveyor.  
6. When moisture levels are within product specifications, close the Reject conveyor",
"Activity: 

Click the [Start] button located on the KHX Burner controls.

The burner has a 5 minute start up cycle and will not start immediately.  This simulation allows you to skip the startup delay.

Activity:

Click the Skip Timer button that appears above the Burner Control Panel.",
"NOTE: The simulation has been Paused.

Activity:  

1. On the far right of the screen you will find the simulation speed buttons [Pause] [Normal] and [Fast].  Read the activity below carefully then click the [Normal] speed button to unpause.

2. Unpause the simulation and watch the Inlet Temp. Gauge.  When the gauge reads 150 C start the Slicer Infeed by clicking the [Start] button on its controls.",
"On the top right of the screen you will see a Fryer Mimic (picture of a fryer).  If you look carefully you will see chips slowly being added to the fryer and moving towards the exit.

In real life when the chips arrive at the discharge conveyor you would normally stop the discharge conveyor until the chips fill the entirety of the exit of the fryer then reactivate the discharge conveyor.  
",
"The Discharge conveyor will remove the product from the fryer oil and transport it up and under a moisture sensor suspended above the Discharge conveyor.

When this occurs the moisture reading on the screen will begin to report the average moisture of the cooked product.

When the moisture is less than 1.65 and greater than 1.0 click the [AUTO] button on the Reject Gate controls to allow the fryer to take back control of the rejecting product.

Activity: Click the [AUTO] button on the Reject Gate controls.",
"The Master Speed [Control Mode] button should now be clicked to allow the fryer to once again take control of Master Speed system.

Activity: Click the [Control Mode] button to engage the fryers automatic Master Speed mode.",
"Congratulations.  

You have completed the Fryer Operators tutorial and should now be able to successfully perform the necessary pre-operational checks and be able to safely start and stop the fryer system.

There is still a large amount of experience to gain on a real fryer system and many things to learn about operating a continuous fryer system however you are on your way to becoming a competent fryer operator."}

    Dim TextStrings3() As String = {"Filler",
"",
"",
"",
"",
"",
"",
"",
"",
"",
"",
"",
"",
"",
"",
"",
"",
"",
"",
""}

    Dim TextStrings4() As String = {"Filler",
"",
"",
"",
"",
"",
"",
"",
"",
"",
"",
"",
"",
"",
"",
"",
"",
"",
"",
""}

    Private Sub FryerHMITutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Counter As Integer

        Select Case ControlScreenForm.ButtonSelectedFlag

            Case HMITUT

                Textstrings = TextStrings1
                FileStrings = FileStrings1
                HeadingStrings = HeadingStrings1
                HighLights = HighLights1
                TutLength = FRYERHMIPAGEMAX

            Case BASICS

                Textstrings = TextStrings2
                FileStrings = FileStrings2
                HeadingStrings = HeadingStrings2
                HighLights = HighLights1
                TutLength = FRYEROPSPAGEMAX

            Case TITRATION

                Textstrings = TextStrings3
                'FileStrings = FileStrings3
                HeadingStrings = HeadingStrings3
                HighLights = HighLights3

            Case SLICERS

                Textstrings = TextStrings4
                'FileStrings = FileStrings4
                HeadingStrings = HeadingStrings4
                HighLights = HighLights4

        End Select

        Counter = 0
        While Counter < HighLights.Length

            SavedHighLights(Counter, 0) = HighLights(Counter).backcolor
            SavedHighLights(Counter, 1) = HighLights(Counter).forecolor

            Counter += 1

        End While

        TutPicbox.Image = FileStrings(Int(PageNumberText.Text))
        TutorialHeadingLabel.Text = HeadingStrings(Int(PageNumberText.Text))
        TutorialText.Text = TextStrings(Int(PageNumberText.Text))
        PageNumberText.Text = 1



    End Sub

    Private Sub FryerHMITutNextButton_Click(sender As Object, e As EventArgs) Handles FryerHMITutNextButton.Click

        Dim Counter As Integer

        If CDec(Val(PageNumberText.Text)) < TutLength Then PageNumberText.Text = CDec(Val(PageNumberText.Text)) + 1

        TutPicbox.Image = (FileStrings(Int(PageNumberText.Text)))
        TutorialHeadingLabel.Text = HeadingStrings(Int(PageNumberText.Text))
        TutorialText.Text = TextStrings(Int(PageNumberText.Text))



        Counter = 0
        While Counter < HighLights.Length

            HighLights(Counter).backcolor = SavedHighLights(Counter, 0)
            HighLights(Counter).forecolor = SavedHighLights(Counter, 1)

            Counter += 1

        End While

        Select Case ControlScreenForm.ButtonSelectedFlag
            Case HMITUT

                Select Case (Int(Val(PageNumberText.Text)))
                    Case 2

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = INFEEDPANEL To MAINOVERVIEWBUTTON
                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black

                        Next SelectIndex

                    Case 3

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = DTMENU To MMMENU
                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black
                        Next SelectIndex

                    Case 4

                        HighLights(Int(Val(INFEEDPANEL))).backcolor = Color.LightGreen
                        HighLights(Int(Val(INFEEDPANEL))).forecolor = Color.Black
                    Case 5

                        HighLights(Int(Val(FRYERPANEL))).backcolor = Color.LightGreen
                        HighLights(Int(Val(FRYERPANEL))).forecolor = Color.Black

                    Case 6

                        HighLights(Int(Val(OUTFEEDPANEL))).backcolor = Color.LightGreen
                        HighLights(Int(Val(OUTFEEDPANEL))).forecolor = Color.Black

                    Case 7

                        HighLights(Int(Val(MMMENU))).backcolor = Color.LightGreen
                        HighLights(Int(Val(MMMENU))).forecolor = Color.Black
                        HighLights(Int(Val(SPEEDCONTROLBUTTON))).backcolor = Color.LightGreen
                        HighLights(Int(Val(SPEEDCONTROLBUTTON))).forecolor = Color.Black


                    Case 8 To 9

                        HighLights(Int(Val(ALARMBUTTON))).backcolor = Color.LightGreen
                        HighLights(Int(Val(ALARMBUTTON))).forecolor = Color.Black

                    Case 11 To 15

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = SLICERSTOPBUTTON To SLICERFEEDPLUSBUTTON
                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black

                        Next SelectIndex

                    Case 16 To 18

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = LANINGCONVEYORSTOP To LANINGCONVEYORSTART
                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black

                        Next SelectIndex

                    Case 20


                        Dim SelectIndex As Integer = 0

                        For SelectIndex = INLETSETPOINT To INLETSETPOINTPLUS
                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black
                        Next SelectIndex

                    Case 21

                        HighLights(Int(Val(INLETTEMPERATURE))).backcolor = Color.LightGreen
                        HighLights(Int(Val(INLETTEMPERATURE))).forecolor = Color.Black
                    Case 22

                        HighLights(Int(Val(DELTAT))).backcolor = Color.LightGreen
                        HighLights(Int(Val(DELTAT))).forecolor = Color.Black

                    Case 23 To 24

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = OUTLETTEMPTEXT To OILFLOW

                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black

                        Next SelectIndex

                    Case 25 To 27

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = MASTERSPEEDOUTPUT To MASTERSPEEDPLUS

                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black
                        Next SelectIndex

                    Case 28

                        HighLights(Int(Val(MOISTUREDISPLAY))).backcolor = Color.LightGreen
                        HighLights(Int(Val(MOISTUREDISPLAY))).forecolor = Color.Black

                    Case 30

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = MOISTURESETPOINT To MOISTUREHIGH

                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black

                        Next SelectIndex

                    Case 32 To 34

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = BURNERSTOPBUTTON To FLAMEBARDISPLAY

                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black

                        Next SelectIndex


                    Case 35

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = DISCHARGESTOPBUTTON To DISCHARGESTARTBUTTON

                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black

                        Next SelectIndex

                    Case 36 To 37

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = RGAUTO To RGMANUALCLOSE

                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black

                        Next SelectIndex


                    Case 38

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = OUTFEEDSTOP To OUTFEEDSTART

                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black

                        Next SelectIndex

                    Case 39

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = ACCUMSTOP To ACCUMSTART

                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black

                        Next SelectIndex

                End Select



            Case BASICS

                Select Case (Int(Val(PageNumberText.Text)))
                    Case 3

                        HighLights(BURNERSTATUSLABEL).backcolor = Color.LightGreen


                    Case 5

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = GATESLABEL To SLICERSLABEL
                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen

                        Next SelectIndex

                    Case 9

                        HighLights(POTATOPREPLABEL).backcolor = Color.LightGreen

                    Case 10

                        HighLights(INLETSETPOINT).backcolor = Color.LightGreen
                        HighLights(SLICERSPEEDFEEDBUTTON).backcolor = Color.LightGreen
                        HighLights(MASTERSPEEDOUTPUT).backcolor = Color.LightGreen
                        HighLights(RGMANUAL).backcolor = Color.LightGreen


                    Case 11

                        HighLights(INLETSETPOINT).backcolor = Color.LightGreen

                    Case 12

                        HighLights(SLICERSPEEDFEEDBUTTON).backcolor = Color.LightGreen

                    Case 13

                        HighLights(MASTERSPEEDOUTPUT).backcolor = Color.LightGreen
                        HighLights(MASTERSPEEDMODE).backcolor = Color.LightGreen

                    Case 14

                        HighLights(MASTERSPEEDMODE).backcolor = Color.LightGreen

                    Case 15

                        HighLights(RGMANUAL).backcolor = Color.LightGreen
                        HighLights(RGMANUALOPEN).backcolor = Color.LightGreen


                    Case 17

                        HighLights(BURNERSTARTBUTTON).backcolor = Color.LightGreen

                        If PauseFlag = False Then

                            Me.Left = 650
                            Me.Top = 100

                        End If

                    Case 18

                        If PauseFlag = False Then

                            PauseFlag = True

                            Fryer.PauseSimulation()

                        End If

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = PAUSEBUTTON To FASTBUTTON
                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen

                        Next SelectIndex

                    Case 20

                        HighLights(RGAUTO).backcolor = Color.LightGreen

                    Case 21

                        HighLights(MASTERSPEEDMODE).backcolor = Color.LightGreen

                End Select

        End Select

    End Sub

    Private Sub FryerHMITutPrevButton_Click(sender As Object, e As EventArgs) Handles FryerHMITutPrevButton.Click

        Dim Counter As Integer

        If CDec(Val(PageNumberText.Text)) > PageMin Then PageNumberText.Text = CDec(Val(PageNumberText.Text)) - 1

        TutPicbox.Image = (FileStrings(Int(PageNumberText.Text)))
        TutorialHeadingLabel.Text = HeadingStrings(Int(PageNumberText.Text))
        TutorialText.Text = Textstrings(Int(PageNumberText.Text))

        Counter = 0
        While Counter < HighLights.Length

            HighLights(Counter).backcolor = SavedHighLights(Counter, 0)
            HighLights(Counter).forecolor = SavedHighLights(Counter, 1)

            Counter += 1

        End While


        Select Case ControlScreenForm.ButtonSelectedFlag
            Case HMITUT

                Select Case (Int(Val(PageNumberText.Text)))
                    Case 2

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = INFEEDPANEL To MAINOVERVIEWBUTTON
                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black

                        Next SelectIndex

                    Case 3

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = DTMENU To MMMENU
                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black
                        Next SelectIndex

                    Case 4

                        HighLights(Int(Val(INFEEDPANEL))).backcolor = Color.LightGreen
                        HighLights(Int(Val(INFEEDPANEL))).forecolor = Color.Black
                    Case 5

                        HighLights(Int(Val(FRYERPANEL))).backcolor = Color.LightGreen
                        HighLights(Int(Val(FRYERPANEL))).forecolor = Color.Black

                    Case 6

                        HighLights(Int(Val(OUTFEEDPANEL))).backcolor = Color.LightGreen
                        HighLights(Int(Val(OUTFEEDPANEL))).forecolor = Color.Black

                    Case 7

                        HighLights(Int(Val(MMMENU))).backcolor = Color.LightGreen
                        HighLights(Int(Val(MMMENU))).forecolor = Color.Black
                        HighLights(Int(Val(SPEEDCONTROLBUTTON))).backcolor = Color.LightGreen
                        HighLights(Int(Val(SPEEDCONTROLBUTTON))).forecolor = Color.Black


                    Case 8 To 9

                        HighLights(Int(Val(ALARMBUTTON))).backcolor = Color.LightGreen
                        HighLights(Int(Val(ALARMBUTTON))).forecolor = Color.Black

                    Case 11 To 15

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = SLICERSTOPBUTTON To SLICERFEEDPLUSBUTTON
                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black

                        Next SelectIndex

                    Case 16 To 18

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = LANINGCONVEYORSTOP To LANINGCONVEYORSTART
                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black

                        Next SelectIndex

                    Case 20


                        Dim SelectIndex As Integer = 0

                        For SelectIndex = INLETSETPOINT To INLETSETPOINTPLUS
                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black
                        Next SelectIndex

                    Case 21

                        HighLights(Int(Val(INLETTEMPERATURE))).backcolor = Color.LightGreen
                        HighLights(Int(Val(INLETTEMPERATURE))).forecolor = Color.Black
                    Case 22

                        HighLights(Int(Val(DELTAT))).backcolor = Color.LightGreen
                        HighLights(Int(Val(DELTAT))).forecolor = Color.Black

                    Case 23 To 24

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = OUTLETTEMPTEXT To OILFLOW

                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black

                        Next SelectIndex

                    Case 25 To 27

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = MASTERSPEEDOUTPUT To MASTERSPEEDPLUS

                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black
                        Next SelectIndex

                    Case 28

                        HighLights(Int(Val(MOISTUREDISPLAY))).backcolor = Color.LightGreen
                        HighLights(Int(Val(MOISTUREDISPLAY))).forecolor = Color.Black

                    Case 30

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = MOISTURESETPOINT To MOISTUREHIGH

                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black

                        Next SelectIndex

                    Case 32 To 34

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = BURNERSTOPBUTTON To FLAMEBARDISPLAY

                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black

                        Next SelectIndex


                    Case 35

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = DISCHARGESTOPBUTTON To DISCHARGESTARTBUTTON

                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black

                        Next SelectIndex

                    Case 36 To 37

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = RGAUTO To RGMANUALCLOSE

                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black

                        Next SelectIndex


                    Case 38

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = OUTFEEDSTOP To OUTFEEDSTART

                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black

                        Next SelectIndex

                    Case 39

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = ACCUMSTOP To ACCUMSTART

                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen
                            HighLights(Int(Val(SelectIndex))).forecolor = Color.Black

                        Next SelectIndex

                End Select


            Case BASICS

                Select Case (Int(Val(PageNumberText.Text)))
                    Case 3

                        HighLights(BURNERSTATUSLABEL).backcolor = Color.LightGreen


                    Case 5

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = GATESLABEL To SLICERSLABEL
                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen

                        Next SelectIndex

                    Case 9

                        HighLights(POTATOPREPLABEL).backcolor = Color.LightGreen

                    Case 10

                        HighLights(INLETSETPOINT).backcolor = Color.LightGreen
                        HighLights(SLICERSPEEDFEEDBUTTON).backcolor = Color.LightGreen
                        HighLights(MASTERSPEEDOUTPUT).backcolor = Color.LightGreen
                        HighLights(RGMANUAL).backcolor = Color.LightGreen


                    Case 11

                        HighLights(INLETSETPOINT).backcolor = Color.LightGreen

                    Case 12

                        HighLights(SLICERSPEEDFEEDBUTTON).backcolor = Color.LightGreen

                    Case 13

                        HighLights(MASTERSPEEDOUTPUT).backcolor = Color.LightGreen
                        HighLights(MASTERSPEEDMODE).backcolor = Color.LightGreen

                    Case 14

                        HighLights(MASTERSPEEDMODE).backcolor = Color.LightGreen

                    Case 15

                        HighLights(RGMANUAL).backcolor = Color.LightGreen
                        HighLights(RGMANUALOPEN).backcolor = Color.LightGreen


                    Case 17

                        HighLights(BURNERSTARTBUTTON).backcolor = Color.LightGreen

                        If PauseFlag = False Then

                            Me.Left = 650
                            Me.Top = 100

                        End If

                    Case 18

                        If PauseFlag = False Then

                            PauseFlag = True

                            Fryer.PauseSimulation()

                        End If

                        Dim SelectIndex As Integer = 0

                        For SelectIndex = PAUSEBUTTON To FASTBUTTON
                            HighLights(Int(Val(SelectIndex))).backcolor = Color.LightGreen

                        Next SelectIndex

                    Case 20

                        HighLights(RGAUTO).backcolor = Color.LightGreen

                    Case 21

                        HighLights(MASTERSPEEDMODE).backcolor = Color.LightGreen

                End Select


        End Select

    End Sub

    Sub CloseOpenForms()

        My.Application.OpenForms.Cast(Of Form)() _
              .Except({ControlScreenForm, SplashScreen}) _
              .ToList() _
              .ForEach(Sub(form) form.Visible = False)

    End Sub

    Private Sub FryerHMITutCloseButton_Click(sender As Object, e As EventArgs) Handles FryerHMITutCloseButton.Click

        Dim Counter As Integer

        Counter = 0
        While Counter < HighLights.Length

            HighLights(Counter).backcolor = SavedHighLights(Counter, 0)
            HighLights(Counter).forecolor = SavedHighLights(Counter, 1)

            Counter += 1

        End While

        If ControlScreenForm.ButtonSelectedFlag = BASICS Then


            CloseOpenForms()
            Me.Close()
            Fryer.Visible = True
            TutorialSelectionPanelForm.Visible = True
            TutorialSelectionPanelForm.TopMost = True

        End If

        If ControlScreenForm.ButtonSelectedFlag = HMITUT Then


            CloseOpenForms()
            Me.Close()
            Fryer.Visible = True
            TutorialSelectionPanelForm.Visible = True
            TutorialSelectionPanelForm.TopMost = True
        End If


    End Sub

    Private Sub TutorialHeadingLabel_Click(sender As Object, e As EventArgs) Handles TutorialHeadingLabel.Click

    End Sub
End Class