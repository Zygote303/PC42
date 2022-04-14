<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fryer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fryer))
        Me.button9 = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.MainOverviewButton = New System.Windows.Forms.Button()
        Me.ProductSelectButton = New System.Windows.Forms.Button()
        Me.DataLogsButton = New System.Windows.Forms.Button()
        Me.CleaningButton = New System.Windows.Forms.Button()
        Me.FryerOutfeedButton = New System.Windows.Forms.Button()
        Me.FryerButton = New System.Windows.Forms.Button()
        Me.FryerInfeedMenuButton = New System.Windows.Forms.Button()
        Me.panel10 = New System.Windows.Forms.Panel()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.EGMCLabel = New System.Windows.Forms.Label()
        Me.RejectProductLabel = New System.Windows.Forms.Label()
        Me.RGManualOpenImage = New System.Windows.Forms.PictureBox()
        Me.RGManualCloseButton = New System.Windows.Forms.Button()
        Me.RGManualOpenButton = New System.Windows.Forms.Button()
        Me.RejectManualOnImage = New System.Windows.Forms.PictureBox()
        Me.PictureBox56 = New System.Windows.Forms.PictureBox()
        Me.PictureBox57 = New System.Windows.Forms.PictureBox()
        Me.HCV2OnImage = New System.Windows.Forms.PictureBox()
        Me.HCV2OffImage = New System.Windows.Forms.PictureBox()
        Me.VBOnImage = New System.Windows.Forms.PictureBox()
        Me.VBOffImage = New System.Windows.Forms.PictureBox()
        Me.OCVOnImage = New System.Windows.Forms.PictureBox()
        Me.OCVOffImage = New System.Windows.Forms.PictureBox()
        Me.HCV1OnImage = New System.Windows.Forms.PictureBox()
        Me.HCV1OffImage = New System.Windows.Forms.PictureBox()
        Me.HCOnImage = New System.Windows.Forms.PictureBox()
        Me.HCOffImage = New System.Windows.Forms.PictureBox()
        Me.AFOnImage = New System.Windows.Forms.PictureBox()
        Me.AFOffImage = New System.Windows.Forms.PictureBox()
        Me.PictureBox48 = New System.Windows.Forms.PictureBox()
        Me.PictureBox49 = New System.Windows.Forms.PictureBox()
        Me.ITOnImage = New System.Windows.Forms.PictureBox()
        Me.ITOffImage = New System.Windows.Forms.PictureBox()
        Me.RGConOnImage = New System.Windows.Forms.PictureBox()
        Me.RGCONOffImage = New System.Windows.Forms.PictureBox()
        Me.AccumulationOffImage = New System.Windows.Forms.PictureBox()
        Me.OutfeedOffImage = New System.Windows.Forms.PictureBox()
        Me.RejectAutoOnImage = New System.Windows.Forms.PictureBox()
        Me.OutfeedOnImage = New System.Windows.Forms.PictureBox()
        Me.AccumulationOnImage = New System.Windows.Forms.PictureBox()
        Me.Zone4EmptyImage = New System.Windows.Forms.PictureBox()
        Me.Zone3EmptyImage = New System.Windows.Forms.PictureBox()
        Me.Zone2EmptyImage = New System.Windows.Forms.PictureBox()
        Me.Zone4FullImage = New System.Windows.Forms.PictureBox()
        Me.Zone3FullImage = New System.Windows.Forms.PictureBox()
        Me.Zone2FullImage = New System.Windows.Forms.PictureBox()
        Me.Zone1FullImage = New System.Windows.Forms.PictureBox()
        Me.PackagingOffImage = New System.Windows.Forms.PictureBox()
        Me.PackagingOnImage = New System.Windows.Forms.PictureBox()
        Me.TextBox32 = New System.Windows.Forms.TextBox()
        Me.TextBox31 = New System.Windows.Forms.TextBox()
        Me.TextBox30 = New System.Windows.Forms.TextBox()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.AccumulationStopButton = New System.Windows.Forms.Button()
        Me.AccumulationStartButton = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.RejectGateManualButton = New System.Windows.Forms.Button()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.RejectGateAutoButton = New System.Windows.Forms.Button()
        Me.OutfeedStopButton = New System.Windows.Forms.Button()
        Me.OutfeedStartButton = New System.Windows.Forms.Button()
        Me.panel7 = New System.Windows.Forms.Panel()
        Me.label4 = New System.Windows.Forms.Label()
        Me.panel6 = New System.Windows.Forms.Panel()
        Me.label3 = New System.Windows.Forms.Label()
        Me.panel5 = New System.Windows.Forms.Panel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.MainTimerTick = New System.Windows.Forms.Timer(Me.components)
        Me.BurnerStartupTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FryerMimicTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CookTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MasterSpeedTimer = New System.Windows.Forms.Timer(Me.components)
        Me.OilCoolDownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BurnerShutDownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.InletSetpointMinus = New System.Windows.Forms.Button()
        Me.InletSetpointPlus = New System.Windows.Forms.Button()
        Me.InletSetpointButton = New System.Windows.Forms.Button()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.SpeedControlModeButton = New System.Windows.Forms.Button()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.KHXStopButton = New System.Windows.Forms.Button()
        Me.KHXStartButton = New System.Windows.Forms.Button()
        Me.TextBox49 = New System.Windows.Forms.TextBox()
        Me.DischargeConveyorStopButton = New System.Windows.Forms.Button()
        Me.DischargeConveyorStartButton = New System.Windows.Forms.Button()
        Me.BiasMinusButton = New System.Windows.Forms.Button()
        Me.BiasPlusButton = New System.Windows.Forms.Button()
        Me.TextBox58 = New System.Windows.Forms.TextBox()
        Me.TextBox59 = New System.Windows.Forms.TextBox()
        Me.BurnerStatusTextLabel = New System.Windows.Forms.TextBox()
        Me.TextBox62 = New System.Windows.Forms.TextBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.MasterSpeedManual = New System.Windows.Forms.Button()
        Me.MasterSpeedPlus = New System.Windows.Forms.Button()
        Me.MasterSpeedMinus = New System.Windows.Forms.Button()
        Me.OMUVOnImage = New System.Windows.Forms.PictureBox()
        Me.OMUVOffImage = New System.Windows.Forms.PictureBox()
        Me.HDHSTOnImage = New System.Windows.Forms.PictureBox()
        Me.HDHSTOffImage = New System.Windows.Forms.PictureBox()
        Me.FDrainOnImage = New System.Windows.Forms.PictureBox()
        Me.FDrainOffImage = New System.Windows.Forms.PictureBox()
        Me.MPumpOnImage = New System.Windows.Forms.PictureBox()
        Me.MPumpOffImage = New System.Windows.Forms.PictureBox()
        Me.FCtchOnImage = New System.Windows.Forms.PictureBox()
        Me.FCtchOffImage = New System.Windows.Forms.PictureBox()
        Me.FDISOnImage = New System.Windows.Forms.PictureBox()
        Me.FDISOffImage = New System.Windows.Forms.PictureBox()
        Me.FSubOnImage = New System.Windows.Forms.PictureBox()
        Me.FSubOffImage = New System.Windows.Forms.PictureBox()
        Me.FPLDOnImage = New System.Windows.Forms.PictureBox()
        Me.FPLDOffImage = New System.Windows.Forms.PictureBox()
        Me.FlameBar = New System.Windows.Forms.TextBox()
        Me.PictureBox22 = New System.Windows.Forms.PictureBox()
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.BiasDisplayText = New System.Windows.Forms.TextBox()
        Me.DeltaTText = New System.Windows.Forms.TextBox()
        Me.TextBox67 = New System.Windows.Forms.TextBox()
        Me.DischargeConveyorOffImage = New System.Windows.Forms.PictureBox()
        Me.KHXBurnerOffImage = New System.Windows.Forms.PictureBox()
        Me.DischargeConveyorOnImage = New System.Windows.Forms.PictureBox()
        Me.KHXBurnerOnImage = New System.Windows.Forms.PictureBox()
        Me.MainFlameOffImage = New System.Windows.Forms.PictureBox()
        Me.BurnerStartedOffImage = New System.Windows.Forms.PictureBox()
        Me.BurnerStartedOnImage = New System.Windows.Forms.PictureBox()
        Me.MainFlameOnImage = New System.Windows.Forms.PictureBox()
        Me.MM55PowerOff = New System.Windows.Forms.PictureBox()
        Me.CoolantAirImageOff = New System.Windows.Forms.PictureBox()
        Me.CoolantAirImageOn = New System.Windows.Forms.PictureBox()
        Me.MM55PowerOn = New System.Windows.Forms.PictureBox()
        Me.MM55On = New System.Windows.Forms.PictureBox()
        Me.HighLimitOutput = New System.Windows.Forms.TextBox()
        Me.LowLimitOutput = New System.Windows.Forms.TextBox()
        Me.SetPointOutput = New System.Windows.Forms.TextBox()
        Me.MoistureOutput = New System.Windows.Forms.TextBox()
        Me.MasterSpeedOutput = New System.Windows.Forms.TextBox()
        Me.OilFlowTextbox = New System.Windows.Forms.TextBox()
        Me.OutletTempText = New System.Windows.Forms.TextBox()
        Me.InletTemperature = New System.Windows.Forms.TextBox()
        Me.InletSetpoint = New System.Windows.Forms.TextBox()
        Me.SlicerStopButton = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.LaningConveyorLabel = New System.Windows.Forms.TextBox()
        Me.SlicerFeedMinusButton = New System.Windows.Forms.Button()
        Me.SlicerFeedPlusButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.MMMenu = New System.Windows.Forms.Label()
        Me.CPMenu = New System.Windows.Forms.Label()
        Me.SCMenu = New System.Windows.Forms.Label()
        Me.PPRunningOffImage = New System.Windows.Forms.PictureBox()
        Me.SlicersLabel = New System.Windows.Forms.TextBox()
        Me.GatesLabel = New System.Windows.Forms.TextBox()
        Me.DelayedSpeedChange = New System.Windows.Forms.Label()
        Me.SlicerFeedSpeedButton = New System.Windows.Forms.Button()
        Me.KMOn = New System.Windows.Forms.PictureBox()
        Me.AirMOn = New System.Windows.Forms.PictureBox()
        Me.SWCBMOn = New System.Windows.Forms.PictureBox()
        Me.SWPMOn = New System.Windows.Forms.PictureBox()
        Me.SCMOn = New System.Windows.Forms.PictureBox()
        Me.S3MOn = New System.Windows.Forms.PictureBox()
        Me.S2MOn = New System.Windows.Forms.PictureBox()
        Me.S1MOn = New System.Windows.Forms.PictureBox()
        Me.LCMOn = New System.Windows.Forms.PictureBox()
        Me.SFCMOn = New System.Windows.Forms.PictureBox()
        Me.KMOff = New System.Windows.Forms.PictureBox()
        Me.AirMOff = New System.Windows.Forms.PictureBox()
        Me.SWCBMOff = New System.Windows.Forms.PictureBox()
        Me.SWPMOff = New System.Windows.Forms.PictureBox()
        Me.SWCMOff = New System.Windows.Forms.PictureBox()
        Me.S3CMOff = New System.Windows.Forms.PictureBox()
        Me.S2CMOff = New System.Windows.Forms.PictureBox()
        Me.S1CMOff = New System.Windows.Forms.PictureBox()
        Me.LCMOff = New System.Windows.Forms.PictureBox()
        Me.SFCMOff = New System.Windows.Forms.PictureBox()
        Me.LaningConveyorStartButton = New System.Windows.Forms.Button()
        Me.LaningConveyorStopButton = New System.Windows.Forms.Button()
        Me.SlicerStartButton = New System.Windows.Forms.Button()
        Me.SlicerOff2 = New System.Windows.Forms.PictureBox()
        Me.SlicerOff3 = New System.Windows.Forms.PictureBox()
        Me.SlicerOn3 = New System.Windows.Forms.PictureBox()
        Me.SlicerOn2 = New System.Windows.Forms.PictureBox()
        Me.SlicerOff1 = New System.Windows.Forms.PictureBox()
        Me.DTMenu = New System.Windows.Forms.Label()
        Me.PPRLabel = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AlarmButton = New System.Windows.Forms.Button()
        Me.LaningConveyorOffImage = New System.Windows.Forms.PictureBox()
        Me.LaningConveyorOnImage = New System.Windows.Forms.PictureBox()
        Me.SlicerFeedOffImage = New System.Windows.Forms.PictureBox()
        Me.SlicerFeedOnImage = New System.Windows.Forms.PictureBox()
        Me.PPRunningOnImage = New System.Windows.Forms.PictureBox()
        Me.SlicerOn1 = New System.Windows.Forms.PictureBox()
        Me.SystemData = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.MasterSpeedXImage = New System.Windows.Forms.PictureBox()
        Me.DeltaTXImage = New System.Windows.Forms.PictureBox()
        Me.InletXImage = New System.Windows.Forms.PictureBox()
        Me.MoistureXImage = New System.Windows.Forms.PictureBox()
        Me.MasterSpeedExclImage = New System.Windows.Forms.PictureBox()
        Me.InletExclImage = New System.Windows.Forms.PictureBox()
        Me.MoistureExclImage = New System.Windows.Forms.PictureBox()
        Me.MasterSpeedTickImage = New System.Windows.Forms.PictureBox()
        Me.DeltaTTickImage = New System.Windows.Forms.PictureBox()
        Me.InletTickImage = New System.Windows.Forms.PictureBox()
        Me.MoistureTickImage = New System.Windows.Forms.PictureBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SpeedLabel = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BurnerResetButton = New System.Windows.Forms.PictureBox()
        Me.BurnerStopButton = New System.Windows.Forms.PictureBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.LowOilPressureFaultOff = New System.Windows.Forms.PictureBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.PictureBox26 = New System.Windows.Forms.PictureBox()
        Me.PictureBox27 = New System.Windows.Forms.PictureBox()
        Me.PictureBox28 = New System.Windows.Forms.PictureBox()
        Me.PictureBox29 = New System.Windows.Forms.PictureBox()
        Me.PictureBox31 = New System.Windows.Forms.PictureBox()
        Me.PictureBox32 = New System.Windows.Forms.PictureBox()
        Me.PictureBox33 = New System.Windows.Forms.PictureBox()
        Me.FryerTempFaultOff = New System.Windows.Forms.PictureBox()
        Me.BurnerFaultOff = New System.Windows.Forms.PictureBox()
        Me.BCBBurnerOffLight = New System.Windows.Forms.PictureBox()
        Me.BurnerFaultOn = New System.Windows.Forms.PictureBox()
        Me.FryerTempFaultOn = New System.Windows.Forms.PictureBox()
        Me.LowOilPressureFaultOn = New System.Windows.Forms.PictureBox()
        Me.BCBBurnerOnLight = New System.Windows.Forms.PictureBox()
        Me.BCBStartButtonOn = New System.Windows.Forms.PictureBox()
        Me.BCBBurnerStartButtonOff = New System.Windows.Forms.PictureBox()
        Me.SkipStartup = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.OnImage1 = New System.Windows.Forms.PictureBox()
        Me.BurnerInfoText = New System.Windows.Forms.Label()
        Me.EmptyFryer1Pic = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.InfeedVariancePlus = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.InfeedVarianceMinus = New System.Windows.Forms.Button()
        Me.InfeedVarianceText = New System.Windows.Forms.TextBox()
        Me.InfeedVarianceOn = New System.Windows.Forms.PictureBox()
        Me.InfeedVarianceOff = New System.Windows.Forms.PictureBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.WoQMSXSettingHighText = New System.Windows.Forms.TextBox()
        Me.WoQDeltaXSettingHighText = New System.Windows.Forms.TextBox()
        Me.WoQInletXSettingHighText = New System.Windows.Forms.TextBox()
        Me.WoQMoistureXSettingHighText = New System.Windows.Forms.TextBox()
        Me.WoQMSXSettingLowText = New System.Windows.Forms.TextBox()
        Me.WoQDeltaXSettingLowText = New System.Windows.Forms.TextBox()
        Me.WoQInletXSettingLowText = New System.Windows.Forms.TextBox()
        Me.WoQMoistureXSettingLowText = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.WoQMSExclSettingHighText = New System.Windows.Forms.TextBox()
        Me.WoQDeltaExclSettingHighText = New System.Windows.Forms.TextBox()
        Me.WoQInletExclSettingHighText = New System.Windows.Forms.TextBox()
        Me.WoQMoistureExclSettingHighText = New System.Windows.Forms.TextBox()
        Me.WoQMSExclSettingLowText = New System.Windows.Forms.TextBox()
        Me.WoQDeltaExclSettingLowText = New System.Windows.Forms.TextBox()
        Me.WoQInletExclSettingLowText = New System.Windows.Forms.TextBox()
        Me.WoQMoistureExclSettingLowText = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.WoQMSTickLowSettingHighText = New System.Windows.Forms.TextBox()
        Me.WoQDeltaTTickSettingHighText = New System.Windows.Forms.TextBox()
        Me.WoQInletTickSettingHighText = New System.Windows.Forms.TextBox()
        Me.WoQMoistureTickSettingHighText = New System.Windows.Forms.TextBox()
        Me.WoQMSTickLowSettingLowText = New System.Windows.Forms.TextBox()
        Me.WoQDeltaTTickSettingLowText = New System.Windows.Forms.TextBox()
        Me.WoQInletTickSettingLowText = New System.Windows.Forms.TextBox()
        Me.WoQMoistureTickSettingLowText = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.RelRadioButton = New System.Windows.Forms.RadioButton()
        Me.QABF101RadioButton = New System.Windows.Forms.RadioButton()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DerivativePlus = New System.Windows.Forms.Button()
        Me.DerivativeMinus = New System.Windows.Forms.Button()
        Me.DerivativeText = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.IntegralPlus = New System.Windows.Forms.Button()
        Me.IntegralMinus = New System.Windows.Forms.Button()
        Me.IntegralText = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ProportionalPlus = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ProportionalMinus = New System.Windows.Forms.Button()
        Me.ProportionalText = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.AllOnSwitchON = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.AllOnSwitchOff = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SlicerAdjustPlus = New System.Windows.Forms.Button()
        Me.SlicerAdjustMinus = New System.Windows.Forms.Button()
        Me.SlicerAdjustText = New System.Windows.Forms.TextBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.FryFactor2Plus = New System.Windows.Forms.Button()
        Me.FryFactor2Minus = New System.Windows.Forms.Button()
        Me.FryFactor2Text = New System.Windows.Forms.TextBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.FryFactorPlus = New System.Windows.Forms.Button()
        Me.FryFactorMinus = New System.Windows.Forms.Button()
        Me.FryFactorText = New System.Windows.Forms.TextBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.SlicerVariance2Plus = New System.Windows.Forms.Button()
        Me.SlicerVariance2Minus = New System.Windows.Forms.Button()
        Me.FryFactor3Text = New System.Windows.Forms.TextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.SlicerVariancePlus = New System.Windows.Forms.Button()
        Me.SlicerVarianceMinus = New System.Windows.Forms.Button()
        Me.SlicerVarianceText = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BulkMoisturePlus = New System.Windows.Forms.Button()
        Me.BulkMoistureMinus = New System.Windows.Forms.Button()
        Me.MoistureBulkText = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.SlicerRatioPlus = New System.Windows.Forms.Button()
        Me.SlicerRatioMinus = New System.Windows.Forms.Button()
        Me.SlicerRatioText = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CCMasterSpeedPlus = New System.Windows.Forms.Button()
        Me.CCMasterSpeedMinus = New System.Windows.Forms.Button()
        Me.MasterSpeedRatioText = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.TempVariancePlus = New System.Windows.Forms.Button()
        Me.TempVarianceMinus = New System.Windows.Forms.Button()
        Me.TempVarianceText = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.MoistureVariancePlus = New System.Windows.Forms.Button()
        Me.MoistureVarianceMinus = New System.Windows.Forms.Button()
        Me.MoistureVarianceText = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SystemDataTab = New System.Windows.Forms.TabPage()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.InitMoistureHigh = New System.Windows.Forms.TextBox()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.InitMoistureLow = New System.Windows.Forms.TextBox()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.InitMoistureSP = New System.Windows.Forms.TextBox()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.InitSetPoint = New System.Windows.Forms.TextBox()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.InitMasterSpeed = New System.Windows.Forms.TextBox()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.InitBurnerOn = New System.Windows.Forms.TextBox()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.InitSlicerSpeed = New System.Windows.Forms.TextBox()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.InitInletTemp = New System.Windows.Forms.TextBox()
        Me.FryerArrayCB = New System.Windows.Forms.CheckBox()
        Me.Randomize = New System.Windows.Forms.Timer(Me.components)
        Me.MasterSpeedChangeDelay = New System.Windows.Forms.Timer(Me.components)
        Me.SlicerFeedAdjustmentDelay = New System.Windows.Forms.Timer(Me.components)
        Me.SlicerFeedChangeDelay = New System.Windows.Forms.Timer(Me.components)
        Me.RandomFryerInputs = New System.Windows.Forms.Timer(Me.components)
        Me.MoistureValueUpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SmoothTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TutorialTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PoliteTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SlicerGradualChange = New System.Windows.Forms.Timer(Me.components)
        Me.PIDTimer = New System.Windows.Forms.Timer(Me.components)
        Me.panel10.SuspendLayout()
        CType(Me.RGManualOpenImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RejectManualOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCV2OnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCV2OffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VBOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VBOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OCVOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OCVOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCV1OnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCV1OffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AFOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AFOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ITOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ITOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGConOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGCONOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccumulationOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutfeedOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RejectAutoOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutfeedOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccumulationOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Zone4EmptyImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Zone3EmptyImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Zone2EmptyImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Zone4FullImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Zone3FullImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Zone2FullImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Zone1FullImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackagingOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackagingOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel7.SuspendLayout()
        Me.panel6.SuspendLayout()
        Me.panel5.SuspendLayout()
        Me.panel4.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me.OMUVOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMUVOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HDHSTOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HDHSTOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FDrainOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FDrainOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MPumpOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MPumpOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FCtchOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FCtchOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FDISOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FDISOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FSubOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FSubOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FPLDOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FPLDOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DischargeConveyorOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KHXBurnerOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DischargeConveyorOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KHXBurnerOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainFlameOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BurnerStartedOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BurnerStartedOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainFlameOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MM55PowerOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoolantAirImageOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoolantAirImageOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MM55PowerOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MM55On, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.PPRunningOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KMOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AirMOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SWCBMOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SWPMOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCMOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.S3MOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.S2MOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.S1MOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCMOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SFCMOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KMOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AirMOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SWCBMOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SWPMOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SWCMOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.S3CMOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.S2CMOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.S1CMOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCMOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SFCMOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlicerOff2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlicerOff3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlicerOn3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlicerOn2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlicerOff1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaningConveyorOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaningConveyorOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlicerFeedOffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlicerFeedOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPRunningOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlicerOn1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SystemData.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.MasterSpeedXImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeltaTXImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InletXImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoistureXImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterSpeedExclImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InletExclImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoistureExclImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterSpeedTickImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeltaTTickImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InletTickImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoistureTickImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.BurnerResetButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BurnerStopButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LowOilPressureFaultOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FryerTempFaultOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BurnerFaultOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BCBBurnerOffLight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BurnerFaultOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FryerTempFaultOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LowOilPressureFaultOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BCBBurnerOnLight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BCBStartButtonOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BCBBurnerStartButtonOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.OnImage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptyFryer1Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.InfeedVarianceOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InfeedVarianceOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.AllOnSwitchON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllOnSwitchOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SystemDataTab.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'button9
        '
        Me.button9.Location = New System.Drawing.Point(798, -56)
        Me.button9.Name = "button9"
        Me.button9.Size = New System.Drawing.Size(52, 41)
        Me.button9.TabIndex = 29
        Me.button9.Text = "S"
        Me.button9.UseVisualStyleBackColor = True
        '
        'button8
        '
        Me.button8.Location = New System.Drawing.Point(740, -56)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(52, 41)
        Me.button8.TabIndex = 28
        Me.button8.Text = "A"
        Me.button8.UseVisualStyleBackColor = True
        '
        'MainOverviewButton
        '
        Me.MainOverviewButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MainOverviewButton.Enabled = False
        Me.MainOverviewButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MainOverviewButton.Location = New System.Drawing.Point(882, 678)
        Me.MainOverviewButton.Name = "MainOverviewButton"
        Me.MainOverviewButton.Size = New System.Drawing.Size(103, 60)
        Me.MainOverviewButton.TabIndex = 16
        Me.MainOverviewButton.Text = "Main Overview"
        Me.MainOverviewButton.UseVisualStyleBackColor = False
        '
        'ProductSelectButton
        '
        Me.ProductSelectButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ProductSelectButton.Enabled = False
        Me.ProductSelectButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ProductSelectButton.Location = New System.Drawing.Point(732, 678)
        Me.ProductSelectButton.Name = "ProductSelectButton"
        Me.ProductSelectButton.Size = New System.Drawing.Size(103, 60)
        Me.ProductSelectButton.TabIndex = 27
        Me.ProductSelectButton.Text = "Product Select"
        Me.ProductSelectButton.UseVisualStyleBackColor = False
        '
        'DataLogsButton
        '
        Me.DataLogsButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.DataLogsButton.Enabled = False
        Me.DataLogsButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DataLogsButton.Location = New System.Drawing.Point(588, 678)
        Me.DataLogsButton.Name = "DataLogsButton"
        Me.DataLogsButton.Size = New System.Drawing.Size(103, 60)
        Me.DataLogsButton.TabIndex = 26
        Me.DataLogsButton.Text = "Data Logs"
        Me.DataLogsButton.UseVisualStyleBackColor = False
        '
        'CleaningButton
        '
        Me.CleaningButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CleaningButton.Enabled = False
        Me.CleaningButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CleaningButton.Location = New System.Drawing.Point(441, 678)
        Me.CleaningButton.Name = "CleaningButton"
        Me.CleaningButton.Size = New System.Drawing.Size(103, 60)
        Me.CleaningButton.TabIndex = 25
        Me.CleaningButton.Text = "Cleaning"
        Me.CleaningButton.UseVisualStyleBackColor = False
        '
        'FryerOutfeedButton
        '
        Me.FryerOutfeedButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.FryerOutfeedButton.Enabled = False
        Me.FryerOutfeedButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FryerOutfeedButton.Location = New System.Drawing.Point(297, 678)
        Me.FryerOutfeedButton.Name = "FryerOutfeedButton"
        Me.FryerOutfeedButton.Size = New System.Drawing.Size(103, 60)
        Me.FryerOutfeedButton.TabIndex = 24
        Me.FryerOutfeedButton.Text = "Fryer Outfeed"
        Me.FryerOutfeedButton.UseVisualStyleBackColor = False
        '
        'FryerButton
        '
        Me.FryerButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.FryerButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FryerButton.Location = New System.Drawing.Point(153, 678)
        Me.FryerButton.Name = "FryerButton"
        Me.FryerButton.Size = New System.Drawing.Size(103, 60)
        Me.FryerButton.TabIndex = 23
        Me.FryerButton.Text = "Fryer"
        Me.FryerButton.UseVisualStyleBackColor = False
        '
        'FryerInfeedMenuButton
        '
        Me.FryerInfeedMenuButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.FryerInfeedMenuButton.Enabled = False
        Me.FryerInfeedMenuButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FryerInfeedMenuButton.Location = New System.Drawing.Point(12, 677)
        Me.FryerInfeedMenuButton.Name = "FryerInfeedMenuButton"
        Me.FryerInfeedMenuButton.Size = New System.Drawing.Size(103, 60)
        Me.FryerInfeedMenuButton.TabIndex = 14
        Me.FryerInfeedMenuButton.Text = "Fryer Infeed"
        Me.FryerInfeedMenuButton.UseVisualStyleBackColor = False
        '
        'panel10
        '
        Me.panel10.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel10.Controls.Add(Me.Label87)
        Me.panel10.Controls.Add(Me.Label82)
        Me.panel10.Controls.Add(Me.Label83)
        Me.panel10.Controls.Add(Me.Label84)
        Me.panel10.Controls.Add(Me.Label85)
        Me.panel10.Controls.Add(Me.Label86)
        Me.panel10.Controls.Add(Me.Label88)
        Me.panel10.Controls.Add(Me.Label89)
        Me.panel10.Controls.Add(Me.TextBox17)
        Me.panel10.Controls.Add(Me.TextBox14)
        Me.panel10.Controls.Add(Me.EGMCLabel)
        Me.panel10.Controls.Add(Me.RejectProductLabel)
        Me.panel10.Controls.Add(Me.RGManualOpenImage)
        Me.panel10.Controls.Add(Me.RGManualCloseButton)
        Me.panel10.Controls.Add(Me.RGManualOpenButton)
        Me.panel10.Controls.Add(Me.RejectManualOnImage)
        Me.panel10.Controls.Add(Me.PictureBox56)
        Me.panel10.Controls.Add(Me.PictureBox57)
        Me.panel10.Controls.Add(Me.HCV2OnImage)
        Me.panel10.Controls.Add(Me.HCV2OffImage)
        Me.panel10.Controls.Add(Me.VBOnImage)
        Me.panel10.Controls.Add(Me.VBOffImage)
        Me.panel10.Controls.Add(Me.OCVOnImage)
        Me.panel10.Controls.Add(Me.OCVOffImage)
        Me.panel10.Controls.Add(Me.HCV1OnImage)
        Me.panel10.Controls.Add(Me.HCV1OffImage)
        Me.panel10.Controls.Add(Me.HCOnImage)
        Me.panel10.Controls.Add(Me.HCOffImage)
        Me.panel10.Controls.Add(Me.AFOnImage)
        Me.panel10.Controls.Add(Me.AFOffImage)
        Me.panel10.Controls.Add(Me.PictureBox48)
        Me.panel10.Controls.Add(Me.PictureBox49)
        Me.panel10.Controls.Add(Me.ITOnImage)
        Me.panel10.Controls.Add(Me.ITOffImage)
        Me.panel10.Controls.Add(Me.RGConOnImage)
        Me.panel10.Controls.Add(Me.RGCONOffImage)
        Me.panel10.Controls.Add(Me.AccumulationOffImage)
        Me.panel10.Controls.Add(Me.OutfeedOffImage)
        Me.panel10.Controls.Add(Me.RejectAutoOnImage)
        Me.panel10.Controls.Add(Me.OutfeedOnImage)
        Me.panel10.Controls.Add(Me.AccumulationOnImage)
        Me.panel10.Controls.Add(Me.Zone4EmptyImage)
        Me.panel10.Controls.Add(Me.Zone3EmptyImage)
        Me.panel10.Controls.Add(Me.Zone2EmptyImage)
        Me.panel10.Controls.Add(Me.Zone4FullImage)
        Me.panel10.Controls.Add(Me.Zone3FullImage)
        Me.panel10.Controls.Add(Me.Zone2FullImage)
        Me.panel10.Controls.Add(Me.Zone1FullImage)
        Me.panel10.Controls.Add(Me.PackagingOffImage)
        Me.panel10.Controls.Add(Me.PackagingOnImage)
        Me.panel10.Controls.Add(Me.TextBox32)
        Me.panel10.Controls.Add(Me.TextBox31)
        Me.panel10.Controls.Add(Me.TextBox30)
        Me.panel10.Controls.Add(Me.TextBox27)
        Me.panel10.Controls.Add(Me.AccumulationStopButton)
        Me.panel10.Controls.Add(Me.AccumulationStartButton)
        Me.panel10.Controls.Add(Me.Button22)
        Me.panel10.Controls.Add(Me.Button26)
        Me.panel10.Controls.Add(Me.Button27)
        Me.panel10.Controls.Add(Me.TextBox15)
        Me.panel10.Controls.Add(Me.RejectGateManualButton)
        Me.panel10.Controls.Add(Me.TextBox26)
        Me.panel10.Controls.Add(Me.TextBox24)
        Me.panel10.Controls.Add(Me.RejectGateAutoButton)
        Me.panel10.Controls.Add(Me.OutfeedStopButton)
        Me.panel10.Controls.Add(Me.OutfeedStartButton)
        Me.panel10.ForeColor = System.Drawing.Color.Red
        Me.panel10.Location = New System.Drawing.Point(12, 496)
        Me.panel10.Name = "panel10"
        Me.panel10.Size = New System.Drawing.Size(974, 175)
        Me.panel10.TabIndex = 22
        '
        'Label87
        '
        Me.Label87.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.Label87.ForeColor = System.Drawing.Color.Black
        Me.Label87.Location = New System.Drawing.Point(750, 15)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(164, 12)
        Me.Label87.TabIndex = 348
        Me.Label87.Text = "OUTFEED DRIVE STATUS"
        Me.Label87.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label82
        '
        Me.Label82.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label82.ForeColor = System.Drawing.Color.Black
        Me.Label82.Location = New System.Drawing.Point(750, 39)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(164, 12)
        Me.Label82.TabIndex = 347
        Me.Label82.Text = "Reject Conveyor"
        Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label83
        '
        Me.Label83.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label83.ForeColor = System.Drawing.Color.Black
        Me.Label83.Location = New System.Drawing.Point(750, 57)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(164, 12)
        Me.Label83.TabIndex = 346
        Me.Label83.Text = "Inspection Table"
        Me.Label83.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label84
        '
        Me.Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label84.ForeColor = System.Drawing.Color.Black
        Me.Label84.Location = New System.Drawing.Point(750, 75)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(165, 12)
        Me.Label84.TabIndex = 345
        Me.Label84.Text = "Salter, Salter Beater"
        Me.Label84.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label85
        '
        Me.Label85.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label85.ForeColor = System.Drawing.Color.Black
        Me.Label85.Location = New System.Drawing.Point(750, 93)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(164, 12)
        Me.Label85.TabIndex = 344
        Me.Label85.Text = "Accumuveyor Infeed"
        Me.Label85.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label86
        '
        Me.Label86.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label86.ForeColor = System.Drawing.Color.Black
        Me.Label86.Location = New System.Drawing.Point(750, 111)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(164, 12)
        Me.Label86.TabIndex = 343
        Me.Label86.Text = "Hopper Conveyor"
        Me.Label86.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label88
        '
        Me.Label88.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label88.ForeColor = System.Drawing.Color.Black
        Me.Label88.Location = New System.Drawing.Point(750, 129)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(164, 12)
        Me.Label88.TabIndex = 341
        Me.Label88.Text = "Vibe Motors 1 & 2"
        Me.Label88.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label89
        '
        Me.Label89.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label89.ForeColor = System.Drawing.Color.Black
        Me.Label89.Location = New System.Drawing.Point(750, 147)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(164, 12)
        Me.Label89.TabIndex = 340
        Me.Label89.Text = "Outfeed Conveyor & Vibe"
        Me.Label89.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox17
        '
        Me.TextBox17.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox17.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox17.Location = New System.Drawing.Point(483, 85)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(107, 11)
        Me.TextBox17.TabIndex = 209
        Me.TextBox17.Text = "ZONE 1 CAPACITY"
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(483, 96)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(107, 11)
        Me.TextBox14.TabIndex = 208
        Me.TextBox14.Text = "ZONE 2 CAPACITY"
        '
        'EGMCLabel
        '
        Me.EGMCLabel.AutoSize = True
        Me.EGMCLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!)
        Me.EGMCLabel.ForeColor = System.Drawing.Color.Black
        Me.EGMCLabel.Location = New System.Drawing.Point(46, 117)
        Me.EGMCLabel.Name = "EGMCLabel"
        Me.EGMCLabel.Size = New System.Drawing.Size(125, 7)
        Me.EGMCLabel.TabIndex = 207
        Me.EGMCLabel.Text = "REJECT GATE MANUAL CONTROLS"
        Me.EGMCLabel.Visible = False
        '
        'RejectProductLabel
        '
        Me.RejectProductLabel.AutoSize = True
        Me.RejectProductLabel.Location = New System.Drawing.Point(39, 94)
        Me.RejectProductLabel.Name = "RejectProductLabel"
        Me.RejectProductLabel.Size = New System.Drawing.Size(123, 13)
        Me.RejectProductLabel.TabIndex = 206
        Me.RejectProductLabel.Text = "REJECTING PRODUCT"
        Me.RejectProductLabel.Visible = False
        '
        'RGManualOpenImage
        '
        Me.RGManualOpenImage.BackgroundImage = CType(resources.GetObject("RGManualOpenImage.BackgroundImage"), System.Drawing.Image)
        Me.RGManualOpenImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RGManualOpenImage.Location = New System.Drawing.Point(42, 158)
        Me.RGManualOpenImage.Name = "RGManualOpenImage"
        Me.RGManualOpenImage.Size = New System.Drawing.Size(63, 4)
        Me.RGManualOpenImage.TabIndex = 205
        Me.RGManualOpenImage.TabStop = False
        Me.RGManualOpenImage.Visible = False
        '
        'RGManualCloseButton
        '
        Me.RGManualCloseButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.RGManualCloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.RGManualCloseButton.ForeColor = System.Drawing.Color.Black
        Me.RGManualCloseButton.Location = New System.Drawing.Point(107, 129)
        Me.RGManualCloseButton.Name = "RGManualCloseButton"
        Me.RGManualCloseButton.Size = New System.Drawing.Size(59, 29)
        Me.RGManualCloseButton.TabIndex = 204
        Me.RGManualCloseButton.Text = "CLOSE"
        Me.RGManualCloseButton.UseVisualStyleBackColor = False
        Me.RGManualCloseButton.Visible = False
        '
        'RGManualOpenButton
        '
        Me.RGManualOpenButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.RGManualOpenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.RGManualOpenButton.ForeColor = System.Drawing.Color.Black
        Me.RGManualOpenButton.Location = New System.Drawing.Point(42, 128)
        Me.RGManualOpenButton.Name = "RGManualOpenButton"
        Me.RGManualOpenButton.Size = New System.Drawing.Size(59, 29)
        Me.RGManualOpenButton.TabIndex = 203
        Me.RGManualOpenButton.Text = "OPEN"
        Me.RGManualOpenButton.UseVisualStyleBackColor = False
        Me.RGManualOpenButton.Visible = False
        '
        'RejectManualOnImage
        '
        Me.RejectManualOnImage.BackgroundImage = CType(resources.GetObject("RejectManualOnImage.BackgroundImage"), System.Drawing.Image)
        Me.RejectManualOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RejectManualOnImage.Location = New System.Drawing.Point(109, 78)
        Me.RejectManualOnImage.Name = "RejectManualOnImage"
        Me.RejectManualOnImage.Size = New System.Drawing.Size(74, 4)
        Me.RejectManualOnImage.TabIndex = 202
        Me.RejectManualOnImage.TabStop = False
        Me.RejectManualOnImage.Visible = False
        '
        'PictureBox56
        '
        Me.PictureBox56.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.PictureBox56.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox56.Location = New System.Drawing.Point(930, 72)
        Me.PictureBox56.Name = "PictureBox56"
        Me.PictureBox56.Size = New System.Drawing.Size(10, 15)
        Me.PictureBox56.TabIndex = 201
        Me.PictureBox56.TabStop = False
        Me.PictureBox56.Visible = False
        '
        'PictureBox57
        '
        Me.PictureBox57.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.PictureBox57.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox57.InitialImage = CType(resources.GetObject("PictureBox57.InitialImage"), System.Drawing.Image)
        Me.PictureBox57.Location = New System.Drawing.Point(930, 72)
        Me.PictureBox57.Name = "PictureBox57"
        Me.PictureBox57.Size = New System.Drawing.Size(10, 15)
        Me.PictureBox57.TabIndex = 200
        Me.PictureBox57.TabStop = False
        '
        'HCV2OnImage
        '
        Me.HCV2OnImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.HCV2OnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HCV2OnImage.Location = New System.Drawing.Point(930, 126)
        Me.HCV2OnImage.Name = "HCV2OnImage"
        Me.HCV2OnImage.Size = New System.Drawing.Size(10, 15)
        Me.HCV2OnImage.TabIndex = 199
        Me.HCV2OnImage.TabStop = False
        Me.HCV2OnImage.Visible = False
        '
        'HCV2OffImage
        '
        Me.HCV2OffImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.HCV2OffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HCV2OffImage.InitialImage = CType(resources.GetObject("HCV2OffImage.InitialImage"), System.Drawing.Image)
        Me.HCV2OffImage.Location = New System.Drawing.Point(930, 126)
        Me.HCV2OffImage.Name = "HCV2OffImage"
        Me.HCV2OffImage.Size = New System.Drawing.Size(10, 15)
        Me.HCV2OffImage.TabIndex = 198
        Me.HCV2OffImage.TabStop = False
        '
        'VBOnImage
        '
        Me.VBOnImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.VBOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VBOnImage.Location = New System.Drawing.Point(930, 144)
        Me.VBOnImage.Name = "VBOnImage"
        Me.VBOnImage.Size = New System.Drawing.Size(10, 15)
        Me.VBOnImage.TabIndex = 197
        Me.VBOnImage.TabStop = False
        Me.VBOnImage.Visible = False
        '
        'VBOffImage
        '
        Me.VBOffImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.VBOffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VBOffImage.InitialImage = CType(resources.GetObject("VBOffImage.InitialImage"), System.Drawing.Image)
        Me.VBOffImage.Location = New System.Drawing.Point(930, 144)
        Me.VBOffImage.Name = "VBOffImage"
        Me.VBOffImage.Size = New System.Drawing.Size(10, 15)
        Me.VBOffImage.TabIndex = 196
        Me.VBOffImage.TabStop = False
        '
        'OCVOnImage
        '
        Me.OCVOnImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.OCVOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OCVOnImage.Location = New System.Drawing.Point(915, 144)
        Me.OCVOnImage.Name = "OCVOnImage"
        Me.OCVOnImage.Size = New System.Drawing.Size(10, 15)
        Me.OCVOnImage.TabIndex = 195
        Me.OCVOnImage.TabStop = False
        Me.OCVOnImage.Visible = False
        '
        'OCVOffImage
        '
        Me.OCVOffImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.OCVOffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OCVOffImage.InitialImage = CType(resources.GetObject("OCVOffImage.InitialImage"), System.Drawing.Image)
        Me.OCVOffImage.Location = New System.Drawing.Point(915, 144)
        Me.OCVOffImage.Name = "OCVOffImage"
        Me.OCVOffImage.Size = New System.Drawing.Size(10, 15)
        Me.OCVOffImage.TabIndex = 194
        Me.OCVOffImage.TabStop = False
        '
        'HCV1OnImage
        '
        Me.HCV1OnImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.HCV1OnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HCV1OnImage.Location = New System.Drawing.Point(915, 126)
        Me.HCV1OnImage.Name = "HCV1OnImage"
        Me.HCV1OnImage.Size = New System.Drawing.Size(10, 15)
        Me.HCV1OnImage.TabIndex = 193
        Me.HCV1OnImage.TabStop = False
        Me.HCV1OnImage.Visible = False
        '
        'HCV1OffImage
        '
        Me.HCV1OffImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.HCV1OffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HCV1OffImage.InitialImage = CType(resources.GetObject("HCV1OffImage.InitialImage"), System.Drawing.Image)
        Me.HCV1OffImage.Location = New System.Drawing.Point(915, 126)
        Me.HCV1OffImage.Name = "HCV1OffImage"
        Me.HCV1OffImage.Size = New System.Drawing.Size(10, 15)
        Me.HCV1OffImage.TabIndex = 192
        Me.HCV1OffImage.TabStop = False
        '
        'HCOnImage
        '
        Me.HCOnImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.HCOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HCOnImage.Location = New System.Drawing.Point(915, 108)
        Me.HCOnImage.Name = "HCOnImage"
        Me.HCOnImage.Size = New System.Drawing.Size(10, 15)
        Me.HCOnImage.TabIndex = 191
        Me.HCOnImage.TabStop = False
        Me.HCOnImage.Visible = False
        '
        'HCOffImage
        '
        Me.HCOffImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.HCOffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HCOffImage.InitialImage = CType(resources.GetObject("HCOffImage.InitialImage"), System.Drawing.Image)
        Me.HCOffImage.Location = New System.Drawing.Point(915, 108)
        Me.HCOffImage.Name = "HCOffImage"
        Me.HCOffImage.Size = New System.Drawing.Size(10, 15)
        Me.HCOffImage.TabIndex = 190
        Me.HCOffImage.TabStop = False
        '
        'AFOnImage
        '
        Me.AFOnImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.AFOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AFOnImage.Location = New System.Drawing.Point(915, 90)
        Me.AFOnImage.Name = "AFOnImage"
        Me.AFOnImage.Size = New System.Drawing.Size(10, 15)
        Me.AFOnImage.TabIndex = 189
        Me.AFOnImage.TabStop = False
        Me.AFOnImage.Visible = False
        '
        'AFOffImage
        '
        Me.AFOffImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.AFOffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AFOffImage.InitialImage = CType(resources.GetObject("AFOffImage.InitialImage"), System.Drawing.Image)
        Me.AFOffImage.Location = New System.Drawing.Point(915, 90)
        Me.AFOffImage.Name = "AFOffImage"
        Me.AFOffImage.Size = New System.Drawing.Size(10, 15)
        Me.AFOffImage.TabIndex = 188
        Me.AFOffImage.TabStop = False
        '
        'PictureBox48
        '
        Me.PictureBox48.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.PictureBox48.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox48.Location = New System.Drawing.Point(915, 72)
        Me.PictureBox48.Name = "PictureBox48"
        Me.PictureBox48.Size = New System.Drawing.Size(10, 15)
        Me.PictureBox48.TabIndex = 187
        Me.PictureBox48.TabStop = False
        Me.PictureBox48.Visible = False
        '
        'PictureBox49
        '
        Me.PictureBox49.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.PictureBox49.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox49.InitialImage = CType(resources.GetObject("PictureBox49.InitialImage"), System.Drawing.Image)
        Me.PictureBox49.Location = New System.Drawing.Point(915, 72)
        Me.PictureBox49.Name = "PictureBox49"
        Me.PictureBox49.Size = New System.Drawing.Size(10, 15)
        Me.PictureBox49.TabIndex = 186
        Me.PictureBox49.TabStop = False
        '
        'ITOnImage
        '
        Me.ITOnImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.ITOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ITOnImage.Location = New System.Drawing.Point(915, 54)
        Me.ITOnImage.Name = "ITOnImage"
        Me.ITOnImage.Size = New System.Drawing.Size(10, 15)
        Me.ITOnImage.TabIndex = 185
        Me.ITOnImage.TabStop = False
        Me.ITOnImage.Visible = False
        '
        'ITOffImage
        '
        Me.ITOffImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.ITOffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ITOffImage.InitialImage = CType(resources.GetObject("ITOffImage.InitialImage"), System.Drawing.Image)
        Me.ITOffImage.Location = New System.Drawing.Point(915, 54)
        Me.ITOffImage.Name = "ITOffImage"
        Me.ITOffImage.Size = New System.Drawing.Size(10, 15)
        Me.ITOffImage.TabIndex = 184
        Me.ITOffImage.TabStop = False
        '
        'RGConOnImage
        '
        Me.RGConOnImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.RGConOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RGConOnImage.Location = New System.Drawing.Point(915, 36)
        Me.RGConOnImage.Name = "RGConOnImage"
        Me.RGConOnImage.Size = New System.Drawing.Size(10, 15)
        Me.RGConOnImage.TabIndex = 183
        Me.RGConOnImage.TabStop = False
        Me.RGConOnImage.Visible = False
        '
        'RGCONOffImage
        '
        Me.RGCONOffImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.RGCONOffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RGCONOffImage.InitialImage = CType(resources.GetObject("RGCONOffImage.InitialImage"), System.Drawing.Image)
        Me.RGCONOffImage.Location = New System.Drawing.Point(915, 36)
        Me.RGCONOffImage.Name = "RGCONOffImage"
        Me.RGCONOffImage.Size = New System.Drawing.Size(10, 15)
        Me.RGCONOffImage.TabIndex = 182
        Me.RGCONOffImage.TabStop = False
        '
        'AccumulationOffImage
        '
        Me.AccumulationOffImage.BackgroundImage = CType(resources.GetObject("AccumulationOffImage.BackgroundImage"), System.Drawing.Image)
        Me.AccumulationOffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AccumulationOffImage.Image = CType(resources.GetObject("AccumulationOffImage.Image"), System.Drawing.Image)
        Me.AccumulationOffImage.Location = New System.Drawing.Point(482, 76)
        Me.AccumulationOffImage.Name = "AccumulationOffImage"
        Me.AccumulationOffImage.Size = New System.Drawing.Size(144, 4)
        Me.AccumulationOffImage.TabIndex = 133
        Me.AccumulationOffImage.TabStop = False
        '
        'OutfeedOffImage
        '
        Me.OutfeedOffImage.BackgroundImage = CType(resources.GetObject("OutfeedOffImage.BackgroundImage"), System.Drawing.Image)
        Me.OutfeedOffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OutfeedOffImage.Image = CType(resources.GetObject("OutfeedOffImage.Image"), System.Drawing.Image)
        Me.OutfeedOffImage.Location = New System.Drawing.Point(280, 79)
        Me.OutfeedOffImage.Name = "OutfeedOffImage"
        Me.OutfeedOffImage.Size = New System.Drawing.Size(147, 4)
        Me.OutfeedOffImage.TabIndex = 132
        Me.OutfeedOffImage.TabStop = False
        '
        'RejectAutoOnImage
        '
        Me.RejectAutoOnImage.BackgroundImage = CType(resources.GetObject("RejectAutoOnImage.BackgroundImage"), System.Drawing.Image)
        Me.RejectAutoOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RejectAutoOnImage.Location = New System.Drawing.Point(28, 78)
        Me.RejectAutoOnImage.Name = "RejectAutoOnImage"
        Me.RejectAutoOnImage.Size = New System.Drawing.Size(74, 4)
        Me.RejectAutoOnImage.TabIndex = 131
        Me.RejectAutoOnImage.TabStop = False
        '
        'OutfeedOnImage
        '
        Me.OutfeedOnImage.BackgroundImage = CType(resources.GetObject("OutfeedOnImage.BackgroundImage"), System.Drawing.Image)
        Me.OutfeedOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OutfeedOnImage.Location = New System.Drawing.Point(280, 79)
        Me.OutfeedOnImage.Name = "OutfeedOnImage"
        Me.OutfeedOnImage.Size = New System.Drawing.Size(147, 4)
        Me.OutfeedOnImage.TabIndex = 130
        Me.OutfeedOnImage.TabStop = False
        '
        'AccumulationOnImage
        '
        Me.AccumulationOnImage.BackgroundImage = CType(resources.GetObject("AccumulationOnImage.BackgroundImage"), System.Drawing.Image)
        Me.AccumulationOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AccumulationOnImage.Location = New System.Drawing.Point(482, 76)
        Me.AccumulationOnImage.Name = "AccumulationOnImage"
        Me.AccumulationOnImage.Size = New System.Drawing.Size(144, 4)
        Me.AccumulationOnImage.TabIndex = 129
        Me.AccumulationOnImage.TabStop = False
        '
        'Zone4EmptyImage
        '
        Me.Zone4EmptyImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.Accum_Capacity_Empty
        Me.Zone4EmptyImage.ErrorImage = Nothing
        Me.Zone4EmptyImage.InitialImage = Nothing
        Me.Zone4EmptyImage.Location = New System.Drawing.Point(618, 120)
        Me.Zone4EmptyImage.Name = "Zone4EmptyImage"
        Me.Zone4EmptyImage.Size = New System.Drawing.Size(10, 10)
        Me.Zone4EmptyImage.TabIndex = 127
        Me.Zone4EmptyImage.TabStop = False
        '
        'Zone3EmptyImage
        '
        Me.Zone3EmptyImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.Accum_Capacity_Empty
        Me.Zone3EmptyImage.ErrorImage = Nothing
        Me.Zone3EmptyImage.InitialImage = Nothing
        Me.Zone3EmptyImage.Location = New System.Drawing.Point(618, 108)
        Me.Zone3EmptyImage.Name = "Zone3EmptyImage"
        Me.Zone3EmptyImage.Size = New System.Drawing.Size(10, 10)
        Me.Zone3EmptyImage.TabIndex = 126
        Me.Zone3EmptyImage.TabStop = False
        '
        'Zone2EmptyImage
        '
        Me.Zone2EmptyImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.Accum_Capacity_Empty
        Me.Zone2EmptyImage.ErrorImage = Nothing
        Me.Zone2EmptyImage.InitialImage = Nothing
        Me.Zone2EmptyImage.Location = New System.Drawing.Point(618, 96)
        Me.Zone2EmptyImage.Name = "Zone2EmptyImage"
        Me.Zone2EmptyImage.Size = New System.Drawing.Size(10, 10)
        Me.Zone2EmptyImage.TabIndex = 125
        Me.Zone2EmptyImage.TabStop = False
        '
        'Zone4FullImage
        '
        Me.Zone4FullImage.BackgroundImage = CType(resources.GetObject("Zone4FullImage.BackgroundImage"), System.Drawing.Image)
        Me.Zone4FullImage.ErrorImage = Nothing
        Me.Zone4FullImage.Image = CType(resources.GetObject("Zone4FullImage.Image"), System.Drawing.Image)
        Me.Zone4FullImage.InitialImage = Nothing
        Me.Zone4FullImage.Location = New System.Drawing.Point(618, 120)
        Me.Zone4FullImage.Name = "Zone4FullImage"
        Me.Zone4FullImage.Size = New System.Drawing.Size(10, 10)
        Me.Zone4FullImage.TabIndex = 124
        Me.Zone4FullImage.TabStop = False
        '
        'Zone3FullImage
        '
        Me.Zone3FullImage.BackgroundImage = CType(resources.GetObject("Zone3FullImage.BackgroundImage"), System.Drawing.Image)
        Me.Zone3FullImage.ErrorImage = Nothing
        Me.Zone3FullImage.Image = CType(resources.GetObject("Zone3FullImage.Image"), System.Drawing.Image)
        Me.Zone3FullImage.InitialImage = Nothing
        Me.Zone3FullImage.Location = New System.Drawing.Point(618, 108)
        Me.Zone3FullImage.Name = "Zone3FullImage"
        Me.Zone3FullImage.Size = New System.Drawing.Size(10, 10)
        Me.Zone3FullImage.TabIndex = 123
        Me.Zone3FullImage.TabStop = False
        '
        'Zone2FullImage
        '
        Me.Zone2FullImage.BackgroundImage = CType(resources.GetObject("Zone2FullImage.BackgroundImage"), System.Drawing.Image)
        Me.Zone2FullImage.ErrorImage = Nothing
        Me.Zone2FullImage.Image = CType(resources.GetObject("Zone2FullImage.Image"), System.Drawing.Image)
        Me.Zone2FullImage.InitialImage = Nothing
        Me.Zone2FullImage.Location = New System.Drawing.Point(618, 96)
        Me.Zone2FullImage.Name = "Zone2FullImage"
        Me.Zone2FullImage.Size = New System.Drawing.Size(10, 10)
        Me.Zone2FullImage.TabIndex = 122
        Me.Zone2FullImage.TabStop = False
        '
        'Zone1FullImage
        '
        Me.Zone1FullImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.Accum_Capacity_Full
        Me.Zone1FullImage.ErrorImage = Nothing
        Me.Zone1FullImage.InitialImage = Nothing
        Me.Zone1FullImage.Location = New System.Drawing.Point(618, 85)
        Me.Zone1FullImage.Name = "Zone1FullImage"
        Me.Zone1FullImage.Size = New System.Drawing.Size(10, 10)
        Me.Zone1FullImage.TabIndex = 121
        Me.Zone1FullImage.TabStop = False
        '
        'PackagingOffImage
        '
        Me.PackagingOffImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.Accum_Capacity_Full
        Me.PackagingOffImage.ErrorImage = Nothing
        Me.PackagingOffImage.Location = New System.Drawing.Point(714, 24)
        Me.PackagingOffImage.Name = "PackagingOffImage"
        Me.PackagingOffImage.Size = New System.Drawing.Size(10, 10)
        Me.PackagingOffImage.TabIndex = 120
        Me.PackagingOffImage.TabStop = False
        '
        'PackagingOnImage
        '
        Me.PackagingOnImage.Image = CType(resources.GetObject("PackagingOnImage.Image"), System.Drawing.Image)
        Me.PackagingOnImage.Location = New System.Drawing.Point(714, 24)
        Me.PackagingOnImage.Name = "PackagingOnImage"
        Me.PackagingOnImage.Size = New System.Drawing.Size(10, 10)
        Me.PackagingOnImage.TabIndex = 118
        Me.PackagingOnImage.TabStop = False
        '
        'TextBox32
        '
        Me.TextBox32.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox32.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox32.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Bold)
        Me.TextBox32.Location = New System.Drawing.Point(651, 24)
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New System.Drawing.Size(62, 10)
        Me.TextBox32.TabIndex = 94
        Me.TextBox32.Text = "PACKAGING"
        '
        'TextBox31
        '
        Me.TextBox31.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox31.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox31.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox31.Location = New System.Drawing.Point(483, 120)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(107, 11)
        Me.TextBox31.TabIndex = 93
        Me.TextBox31.Text = "ZONE 4 CAPACITY"
        '
        'TextBox30
        '
        Me.TextBox30.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox30.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox30.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox30.Location = New System.Drawing.Point(483, 107)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(107, 11)
        Me.TextBox30.TabIndex = 92
        Me.TextBox30.Text = "ZONE 3 CAPACITY"
        '
        'TextBox27
        '
        Me.TextBox27.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox27.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox27.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.TextBox27.Location = New System.Drawing.Point(486, 24)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(138, 10)
        Me.TextBox27.TabIndex = 85
        Me.TextBox27.Text = "ACCUMULATION"
        Me.TextBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AccumulationStopButton
        '
        Me.AccumulationStopButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.AccumulationStopButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.AccumulationStopButton.ForeColor = System.Drawing.Color.Red
        Me.AccumulationStopButton.Location = New System.Drawing.Point(482, 40)
        Me.AccumulationStopButton.Name = "AccumulationStopButton"
        Me.AccumulationStopButton.Size = New System.Drawing.Size(65, 35)
        Me.AccumulationStopButton.TabIndex = 82
        Me.AccumulationStopButton.Text = "STOP"
        Me.AccumulationStopButton.UseVisualStyleBackColor = False
        '
        'AccumulationStartButton
        '
        Me.AccumulationStartButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.AccumulationStartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.AccumulationStartButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AccumulationStartButton.Location = New System.Drawing.Point(566, 40)
        Me.AccumulationStartButton.Name = "AccumulationStartButton"
        Me.AccumulationStartButton.Size = New System.Drawing.Size(61, 35)
        Me.AccumulationStartButton.TabIndex = 83
        Me.AccumulationStartButton.Text = "START"
        Me.AccumulationStartButton.UseVisualStyleBackColor = False
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button22.Location = New System.Drawing.Point(311, 87)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(82, 25)
        Me.Button22.TabIndex = 81
        Me.Button22.Text = " "
        Me.Button22.UseVisualStyleBackColor = False
        '
        'Button26
        '
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button26.Location = New System.Drawing.Point(398, 86)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(30, 25)
        Me.Button26.TabIndex = 80
        Me.Button26.Text = "+"
        Me.Button26.UseVisualStyleBackColor = True
        '
        'Button27
        '
        Me.Button27.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button27.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button27.Location = New System.Drawing.Point(278, 86)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(30, 25)
        Me.Button27.TabIndex = 79
        Me.Button27.Text = "-"
        Me.Button27.UseVisualStyleBackColor = False
        '
        'TextBox15
        '
        Me.TextBox15.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox15.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.TextBox15.Location = New System.Drawing.Point(283, 26)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(145, 10)
        Me.TextBox15.TabIndex = 78
        Me.TextBox15.Text = "OUTFEED"
        Me.TextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RejectGateManualButton
        '
        Me.RejectGateManualButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.RejectGateManualButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.RejectGateManualButton.ForeColor = System.Drawing.Color.Black
        Me.RejectGateManualButton.Location = New System.Drawing.Point(105, 42)
        Me.RejectGateManualButton.Name = "RejectGateManualButton"
        Me.RejectGateManualButton.Size = New System.Drawing.Size(75, 35)
        Me.RejectGateManualButton.TabIndex = 77
        Me.RejectGateManualButton.Text = "MANUAL"
        Me.RejectGateManualButton.UseVisualStyleBackColor = False
        '
        'TextBox26
        '
        Me.TextBox26.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox26.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox26.Location = New System.Drawing.Point(12, 3)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(134, 15)
        Me.TextBox26.TabIndex = 73
        Me.TextBox26.Text = "FRYER OUTFEED"
        '
        'TextBox24
        '
        Me.TextBox24.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox24.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox24.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.TextBox24.Location = New System.Drawing.Point(31, 26)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(147, 10)
        Me.TextBox24.TabIndex = 74
        Me.TextBox24.Text = "REJECT GATE"
        Me.TextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RejectGateAutoButton
        '
        Me.RejectGateAutoButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.RejectGateAutoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.RejectGateAutoButton.ForeColor = System.Drawing.Color.Black
        Me.RejectGateAutoButton.Location = New System.Drawing.Point(26, 42)
        Me.RejectGateAutoButton.Name = "RejectGateAutoButton"
        Me.RejectGateAutoButton.Size = New System.Drawing.Size(75, 35)
        Me.RejectGateAutoButton.TabIndex = 76
        Me.RejectGateAutoButton.Text = "AUTO"
        Me.RejectGateAutoButton.UseVisualStyleBackColor = False
        '
        'OutfeedStopButton
        '
        Me.OutfeedStopButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.OutfeedStopButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.OutfeedStopButton.ForeColor = System.Drawing.Color.Red
        Me.OutfeedStopButton.Location = New System.Drawing.Point(279, 42)
        Me.OutfeedStopButton.Name = "OutfeedStopButton"
        Me.OutfeedStopButton.Size = New System.Drawing.Size(65, 35)
        Me.OutfeedStopButton.TabIndex = 48
        Me.OutfeedStopButton.Text = "STOP"
        Me.OutfeedStopButton.UseVisualStyleBackColor = False
        '
        'OutfeedStartButton
        '
        Me.OutfeedStartButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.OutfeedStartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.OutfeedStartButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.OutfeedStartButton.Location = New System.Drawing.Point(365, 42)
        Me.OutfeedStartButton.Name = "OutfeedStartButton"
        Me.OutfeedStartButton.Size = New System.Drawing.Size(63, 35)
        Me.OutfeedStartButton.TabIndex = 49
        Me.OutfeedStartButton.Text = "START"
        Me.OutfeedStartButton.UseVisualStyleBackColor = False
        '
        'panel7
        '
        Me.panel7.BackColor = System.Drawing.SystemColors.ControlDark
        Me.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel7.Controls.Add(Me.label4)
        Me.panel7.Location = New System.Drawing.Point(532, -56)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(188, 41)
        Me.panel7.TabIndex = 21
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(43, 11)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(97, 17)
        Me.label4.TabIndex = 1
        Me.label4.Text = "AUTOMATIC"
        '
        'panel6
        '
        Me.panel6.BackColor = System.Drawing.SystemColors.ControlDark
        Me.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel6.Controls.Add(Me.label3)
        Me.panel6.Location = New System.Drawing.Point(338, -56)
        Me.panel6.Name = "panel6"
        Me.panel6.Size = New System.Drawing.Size(188, 41)
        Me.panel6.TabIndex = 20
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(39, 11)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(109, 17)
        Me.label3.TabIndex = 1
        Me.label3.Text = "CRINKLE CUT"
        '
        'panel5
        '
        Me.panel5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel5.Controls.Add(Me.label2)
        Me.panel5.Location = New System.Drawing.Point(144, -56)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New System.Drawing.Size(188, 41)
        Me.panel5.TabIndex = 19
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Lime
        Me.label2.Location = New System.Drawing.Point(31, 11)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(125, 17)
        Me.label2.TabIndex = 1
        Me.label2.Text = "PLC COMMS OK"
        '
        'panel4
        '
        Me.panel4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel4.Controls.Add(Me.label1)
        Me.panel4.Location = New System.Drawing.Point(-50, -56)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(188, 41)
        Me.panel4.TabIndex = 18
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(-1, 11)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(186, 17)
        Me.label1.TabIndex = 0
        Me.label1.Text = "10/13/202 15:59:355 PM"
        '
        'MainTimerTick
        '
        Me.MainTimerTick.Enabled = True
        Me.MainTimerTick.Interval = 1000
        '
        'BurnerStartupTimer
        '
        Me.BurnerStartupTimer.Interval = 1000
        '
        'FryerMimicTimer
        '
        Me.FryerMimicTimer.Enabled = True
        Me.FryerMimicTimer.Interval = 200
        '
        'CookTimer
        '
        Me.CookTimer.Enabled = True
        Me.CookTimer.Interval = 1000
        '
        'MasterSpeedTimer
        '
        Me.MasterSpeedTimer.Enabled = True
        Me.MasterSpeedTimer.Interval = 1000
        '
        'OilCoolDownTimer
        '
        Me.OilCoolDownTimer.Enabled = True
        Me.OilCoolDownTimer.Interval = 1000
        '
        'BurnerShutDownTimer
        '
        Me.BurnerShutDownTimer.Interval = 1000
        '
        'panel3
        '
        Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel3.Location = New System.Drawing.Point(11, -169)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(189, 25)
        Me.panel3.TabIndex = 0
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(20, 3)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 14)
        Me.TextBox6.TabIndex = 16
        Me.TextBox6.Text = "FRYER"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Bold)
        Me.TextBox5.Location = New System.Drawing.Point(48, 23)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(136, 10)
        Me.TextBox5.TabIndex = 17
        Me.TextBox5.Text = "OIL TEMP & FLOW"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Bold)
        Me.TextBox7.Location = New System.Drawing.Point(21, 44)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(90, 10)
        Me.TextBox7.TabIndex = 18
        Me.TextBox7.Text = "INLET SETPOINT"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Bold)
        Me.TextBox8.Location = New System.Drawing.Point(135, 44)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(90, 10)
        Me.TextBox8.TabIndex = 19
        Me.TextBox8.Text = "INLET TEMP."
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'InletSetpointMinus
        '
        Me.InletSetpointMinus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.InletSetpointMinus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.InletSetpointMinus.Location = New System.Drawing.Point(9, 87)
        Me.InletSetpointMinus.Name = "InletSetpointMinus"
        Me.InletSetpointMinus.Size = New System.Drawing.Size(22, 22)
        Me.InletSetpointMinus.TabIndex = 35
        Me.InletSetpointMinus.Text = "-"
        Me.InletSetpointMinus.UseVisualStyleBackColor = False
        '
        'InletSetpointPlus
        '
        Me.InletSetpointPlus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.InletSetpointPlus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.InletSetpointPlus.Location = New System.Drawing.Point(99, 87)
        Me.InletSetpointPlus.Name = "InletSetpointPlus"
        Me.InletSetpointPlus.Size = New System.Drawing.Size(22, 22)
        Me.InletSetpointPlus.TabIndex = 36
        Me.InletSetpointPlus.Text = "+"
        Me.InletSetpointPlus.UseVisualStyleBackColor = False
        '
        'InletSetpointButton
        '
        Me.InletSetpointButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.InletSetpointButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.InletSetpointButton.Location = New System.Drawing.Point(37, 87)
        Me.InletSetpointButton.Name = "InletSetpointButton"
        Me.InletSetpointButton.Size = New System.Drawing.Size(56, 22)
        Me.InletSetpointButton.TabIndex = 37
        Me.InletSetpointButton.Text = " "
        Me.InletSetpointButton.UseVisualStyleBackColor = False
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.TextBox9.Location = New System.Drawing.Point(21, 123)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(66, 10)
        Me.TextBox9.TabIndex = 38
        Me.TextBox9.Text = "OUTLET TEMP"
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.TextBox10.Location = New System.Drawing.Point(21, 167)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(66, 10)
        Me.TextBox10.TabIndex = 40
        Me.TextBox10.Text = "OIL FLOW"
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Bold)
        Me.TextBox12.Location = New System.Drawing.Point(310, 22)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(99, 10)
        Me.TextBox12.TabIndex = 42
        Me.TextBox12.Text = "SPEED CONTROL"
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.TextBox11.Location = New System.Drawing.Point(311, 39)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(95, 10)
        Me.TextBox11.TabIndex = 43
        Me.TextBox11.Text = "MASTER SPEED"
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.TextBox13.Location = New System.Drawing.Point(410, 40)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(96, 10)
        Me.TextBox13.TabIndex = 44
        Me.TextBox13.Text = "CONTROL MODE"
        Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SpeedControlModeButton
        '
        Me.SpeedControlModeButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SpeedControlModeButton.Location = New System.Drawing.Point(444, 51)
        Me.SpeedControlModeButton.Name = "SpeedControlModeButton"
        Me.SpeedControlModeButton.Size = New System.Drawing.Size(31, 33)
        Me.SpeedControlModeButton.TabIndex = 46
        Me.SpeedControlModeButton.UseVisualStyleBackColor = False
        '
        'TextBox16
        '
        Me.TextBox16.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox16.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(300, 189)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(149, 13)
        Me.TextBox16.TabIndex = 47
        Me.TextBox16.Text = "KHX BURNER"
        Me.TextBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox21
        '
        Me.TextBox21.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox21.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox21.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Bold)
        Me.TextBox21.Location = New System.Drawing.Point(513, 22)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(100, 10)
        Me.TextBox21.TabIndex = 66
        Me.TextBox21.Text = "MOISTURE"
        '
        'TextBox20
        '
        Me.TextBox20.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox20.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox20.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.TextBox20.Location = New System.Drawing.Point(512, 38)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(99, 10)
        Me.TextBox20.TabIndex = 67
        Me.TextBox20.Text = "CURRENT VALUE"
        Me.TextBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox22
        '
        Me.TextBox22.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox22.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox22.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.TextBox22.Location = New System.Drawing.Point(633, 38)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(69, 10)
        Me.TextBox22.TabIndex = 68
        Me.TextBox22.Text = "SET POINT"
        '
        'TextBox23
        '
        Me.TextBox23.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox23.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox23.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.TextBox23.Location = New System.Drawing.Point(633, 77)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(71, 10)
        Me.TextBox23.TabIndex = 70
        Me.TextBox23.Text = "LOW LIMIT"
        '
        'TextBox25
        '
        Me.TextBox25.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox25.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox25.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.TextBox25.Location = New System.Drawing.Point(633, 113)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(71, 10)
        Me.TextBox25.TabIndex = 72
        Me.TextBox25.Text = "HIGH LIMIT"
        '
        'KHXStopButton
        '
        Me.KHXStopButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.KHXStopButton.ForeColor = System.Drawing.Color.Red
        Me.KHXStopButton.Location = New System.Drawing.Point(297, 207)
        Me.KHXStopButton.Name = "KHXStopButton"
        Me.KHXStopButton.Size = New System.Drawing.Size(57, 35)
        Me.KHXStopButton.TabIndex = 92
        Me.KHXStopButton.Text = "STOP"
        Me.KHXStopButton.UseVisualStyleBackColor = False
        '
        'KHXStartButton
        '
        Me.KHXStartButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.KHXStartButton.ForeColor = System.Drawing.Color.Green
        Me.KHXStartButton.Location = New System.Drawing.Point(393, 207)
        Me.KHXStartButton.Name = "KHXStartButton"
        Me.KHXStartButton.Size = New System.Drawing.Size(57, 35)
        Me.KHXStartButton.TabIndex = 93
        Me.KHXStartButton.Text = "START"
        Me.KHXStartButton.UseVisualStyleBackColor = False
        '
        'TextBox49
        '
        Me.TextBox49.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox49.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox49.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox49.Location = New System.Drawing.Point(525, 192)
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.Size = New System.Drawing.Size(154, 10)
        Me.TextBox49.TabIndex = 94
        Me.TextBox49.Text = "DISCHARGE CONVEYOR"
        Me.TextBox49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DischargeConveyorStopButton
        '
        Me.DischargeConveyorStopButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.DischargeConveyorStopButton.ForeColor = System.Drawing.Color.Red
        Me.DischargeConveyorStopButton.Location = New System.Drawing.Point(525, 207)
        Me.DischargeConveyorStopButton.Name = "DischargeConveyorStopButton"
        Me.DischargeConveyorStopButton.Size = New System.Drawing.Size(57, 35)
        Me.DischargeConveyorStopButton.TabIndex = 96
        Me.DischargeConveyorStopButton.Text = "STOP"
        Me.DischargeConveyorStopButton.UseVisualStyleBackColor = False
        '
        'DischargeConveyorStartButton
        '
        Me.DischargeConveyorStartButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.DischargeConveyorStartButton.ForeColor = System.Drawing.Color.Green
        Me.DischargeConveyorStartButton.Location = New System.Drawing.Point(627, 207)
        Me.DischargeConveyorStartButton.Name = "DischargeConveyorStartButton"
        Me.DischargeConveyorStartButton.Size = New System.Drawing.Size(57, 35)
        Me.DischargeConveyorStartButton.TabIndex = 97
        Me.DischargeConveyorStartButton.Text = "START"
        Me.DischargeConveyorStartButton.UseVisualStyleBackColor = False
        '
        'BiasMinusButton
        '
        Me.BiasMinusButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BiasMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BiasMinusButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BiasMinusButton.Location = New System.Drawing.Point(528, 255)
        Me.BiasMinusButton.Name = "BiasMinusButton"
        Me.BiasMinusButton.Size = New System.Drawing.Size(33, 26)
        Me.BiasMinusButton.TabIndex = 99
        Me.BiasMinusButton.Text = "-"
        Me.BiasMinusButton.UseVisualStyleBackColor = False
        '
        'BiasPlusButton
        '
        Me.BiasPlusButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BiasPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BiasPlusButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BiasPlusButton.Location = New System.Drawing.Point(648, 255)
        Me.BiasPlusButton.Name = "BiasPlusButton"
        Me.BiasPlusButton.Size = New System.Drawing.Size(35, 26)
        Me.BiasPlusButton.TabIndex = 100
        Me.BiasPlusButton.Text = "+"
        Me.BiasPlusButton.UseVisualStyleBackColor = False
        '
        'TextBox58
        '
        Me.TextBox58.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox58.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox58.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.TextBox58.Location = New System.Drawing.Point(552, 116)
        Me.TextBox58.Name = "TextBox58"
        Me.TextBox58.Size = New System.Drawing.Size(66, 10)
        Me.TextBox58.TabIndex = 106
        Me.TextBox58.Text = "COOLING AIR"
        '
        'TextBox59
        '
        Me.TextBox59.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox59.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox59.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.TextBox59.Location = New System.Drawing.Point(552, 128)
        Me.TextBox59.Name = "TextBox59"
        Me.TextBox59.Size = New System.Drawing.Size(56, 10)
        Me.TextBox59.TabIndex = 107
        Me.TextBox59.Text = "POWER"
        '
        'BurnerStatusTextLabel
        '
        Me.BurnerStatusTextLabel.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BurnerStatusTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BurnerStatusTextLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.BurnerStatusTextLabel.Location = New System.Drawing.Point(393, 256)
        Me.BurnerStatusTextLabel.Name = "BurnerStatusTextLabel"
        Me.BurnerStatusTextLabel.Size = New System.Drawing.Size(96, 10)
        Me.BurnerStatusTextLabel.TabIndex = 114
        Me.BurnerStatusTextLabel.Text = "BURNER STARTED"
        '
        'TextBox62
        '
        Me.TextBox62.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox62.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox62.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.TextBox62.Location = New System.Drawing.Point(393, 271)
        Me.TextBox62.Name = "TextBox62"
        Me.TextBox62.Size = New System.Drawing.Size(69, 10)
        Me.TextBox62.TabIndex = 115
        Me.TextBox62.Text = "MAIN FLAME"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel2.Controls.Add(Me.Label81)
        Me.panel2.Controls.Add(Me.Label80)
        Me.panel2.Controls.Add(Me.Label79)
        Me.panel2.Controls.Add(Me.Label78)
        Me.panel2.Controls.Add(Me.Label77)
        Me.panel2.Controls.Add(Me.Label76)
        Me.panel2.Controls.Add(Me.Label75)
        Me.panel2.Controls.Add(Me.Label74)
        Me.panel2.Controls.Add(Me.Label73)
        Me.panel2.Controls.Add(Me.MasterSpeedManual)
        Me.panel2.Controls.Add(Me.MasterSpeedPlus)
        Me.panel2.Controls.Add(Me.MasterSpeedMinus)
        Me.panel2.Controls.Add(Me.OMUVOnImage)
        Me.panel2.Controls.Add(Me.OMUVOffImage)
        Me.panel2.Controls.Add(Me.HDHSTOnImage)
        Me.panel2.Controls.Add(Me.HDHSTOffImage)
        Me.panel2.Controls.Add(Me.FDrainOnImage)
        Me.panel2.Controls.Add(Me.FDrainOffImage)
        Me.panel2.Controls.Add(Me.MPumpOnImage)
        Me.panel2.Controls.Add(Me.MPumpOffImage)
        Me.panel2.Controls.Add(Me.FCtchOnImage)
        Me.panel2.Controls.Add(Me.FCtchOffImage)
        Me.panel2.Controls.Add(Me.FDISOnImage)
        Me.panel2.Controls.Add(Me.FDISOffImage)
        Me.panel2.Controls.Add(Me.FSubOnImage)
        Me.panel2.Controls.Add(Me.FSubOffImage)
        Me.panel2.Controls.Add(Me.FPLDOnImage)
        Me.panel2.Controls.Add(Me.FPLDOffImage)
        Me.panel2.Controls.Add(Me.FlameBar)
        Me.panel2.Controls.Add(Me.PictureBox22)
        Me.panel2.Controls.Add(Me.PictureBox23)
        Me.panel2.Controls.Add(Me.BiasDisplayText)
        Me.panel2.Controls.Add(Me.DeltaTText)
        Me.panel2.Controls.Add(Me.TextBox67)
        Me.panel2.Controls.Add(Me.DischargeConveyorOffImage)
        Me.panel2.Controls.Add(Me.KHXBurnerOffImage)
        Me.panel2.Controls.Add(Me.DischargeConveyorOnImage)
        Me.panel2.Controls.Add(Me.KHXBurnerOnImage)
        Me.panel2.Controls.Add(Me.MainFlameOffImage)
        Me.panel2.Controls.Add(Me.BurnerStartedOffImage)
        Me.panel2.Controls.Add(Me.TextBox62)
        Me.panel2.Controls.Add(Me.BurnerStatusTextLabel)
        Me.panel2.Controls.Add(Me.BurnerStartedOnImage)
        Me.panel2.Controls.Add(Me.MainFlameOnImage)
        Me.panel2.Controls.Add(Me.MM55PowerOff)
        Me.panel2.Controls.Add(Me.CoolantAirImageOff)
        Me.panel2.Controls.Add(Me.TextBox59)
        Me.panel2.Controls.Add(Me.TextBox58)
        Me.panel2.Controls.Add(Me.CoolantAirImageOn)
        Me.panel2.Controls.Add(Me.MM55PowerOn)
        Me.panel2.Controls.Add(Me.MM55On)
        Me.panel2.Controls.Add(Me.BiasPlusButton)
        Me.panel2.Controls.Add(Me.BiasMinusButton)
        Me.panel2.Controls.Add(Me.DischargeConveyorStartButton)
        Me.panel2.Controls.Add(Me.DischargeConveyorStopButton)
        Me.panel2.Controls.Add(Me.KHXStopButton)
        Me.panel2.Controls.Add(Me.TextBox49)
        Me.panel2.Controls.Add(Me.KHXStartButton)
        Me.panel2.Controls.Add(Me.TextBox25)
        Me.panel2.Controls.Add(Me.HighLimitOutput)
        Me.panel2.Controls.Add(Me.TextBox23)
        Me.panel2.Controls.Add(Me.LowLimitOutput)
        Me.panel2.Controls.Add(Me.TextBox22)
        Me.panel2.Controls.Add(Me.TextBox20)
        Me.panel2.Controls.Add(Me.TextBox21)
        Me.panel2.Controls.Add(Me.SetPointOutput)
        Me.panel2.Controls.Add(Me.MoistureOutput)
        Me.panel2.Controls.Add(Me.MasterSpeedOutput)
        Me.panel2.Controls.Add(Me.OilFlowTextbox)
        Me.panel2.Controls.Add(Me.OutletTempText)
        Me.panel2.Controls.Add(Me.InletTemperature)
        Me.panel2.Controls.Add(Me.InletSetpoint)
        Me.panel2.Controls.Add(Me.TextBox16)
        Me.panel2.Controls.Add(Me.SpeedControlModeButton)
        Me.panel2.Controls.Add(Me.TextBox13)
        Me.panel2.Controls.Add(Me.TextBox11)
        Me.panel2.Controls.Add(Me.TextBox12)
        Me.panel2.Controls.Add(Me.TextBox10)
        Me.panel2.Controls.Add(Me.TextBox9)
        Me.panel2.Controls.Add(Me.InletSetpointButton)
        Me.panel2.Controls.Add(Me.InletSetpointPlus)
        Me.panel2.Controls.Add(Me.InletSetpointMinus)
        Me.panel2.Controls.Add(Me.TextBox8)
        Me.panel2.Controls.Add(Me.TextBox7)
        Me.panel2.Controls.Add(Me.TextBox5)
        Me.panel2.Controls.Add(Me.TextBox6)
        Me.panel2.Controls.Add(Me.panel3)
        Me.panel2.ForeColor = System.Drawing.SystemColors.Info
        Me.panel2.Location = New System.Drawing.Point(12, 204)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(974, 290)
        Me.panel2.TabIndex = 17
        '
        'Label81
        '
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.Label81.ForeColor = System.Drawing.Color.Black
        Me.Label81.Location = New System.Drawing.Point(753, 24)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(164, 12)
        Me.Label81.TabIndex = 340
        Me.Label81.Text = "FRYER DRIVE STATUS"
        Me.Label81.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label80
        '
        Me.Label80.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label80.ForeColor = System.Drawing.Color.Black
        Me.Label80.Location = New System.Drawing.Point(753, 45)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(164, 12)
        Me.Label80.TabIndex = 339
        Me.Label80.Text = "Fryer Paddles"
        Me.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label79
        '
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label79.ForeColor = System.Drawing.Color.Black
        Me.Label79.Location = New System.Drawing.Point(753, 63)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(164, 12)
        Me.Label79.TabIndex = 338
        Me.Label79.Text = "Fryer Submerger"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label78
        '
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label78.ForeColor = System.Drawing.Color.Black
        Me.Label78.Location = New System.Drawing.Point(753, 81)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(165, 12)
        Me.Label78.TabIndex = 337
        Me.Label78.Text = "Fryer Discharge Conveyor"
        Me.Label78.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label77
        '
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label77.ForeColor = System.Drawing.Color.Black
        Me.Label77.Location = New System.Drawing.Point(753, 99)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(164, 12)
        Me.Label77.TabIndex = 336
        Me.Label77.Text = "Fryer Catchbox"
        Me.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label76
        '
        Me.Label76.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label76.ForeColor = System.Drawing.Color.Black
        Me.Label76.Location = New System.Drawing.Point(753, 117)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(164, 12)
        Me.Label76.TabIndex = 335
        Me.Label76.Text = "Main Oil Pump"
        Me.Label76.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label75
        '
        Me.Label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label75.ForeColor = System.Drawing.Color.Black
        Me.Label75.Location = New System.Drawing.Point(756, 198)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(147, 12)
        Me.Label75.TabIndex = 334
        Me.Label75.Text = "Oil Make Up Valve"
        Me.Label75.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label74
        '
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label74.ForeColor = System.Drawing.Color.Black
        Me.Label74.Location = New System.Drawing.Point(753, 135)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(164, 12)
        Me.Label74.TabIndex = 333
        Me.Label74.Text = "Fryer Drain Pump"
        Me.Label74.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label73
        '
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label73.ForeColor = System.Drawing.Color.Black
        Me.Label73.Location = New System.Drawing.Point(753, 153)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(164, 12)
        Me.Label73.TabIndex = 332
        Me.Label73.Text = "Hood Hoist"
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MasterSpeedManual
        '
        Me.MasterSpeedManual.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MasterSpeedManual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MasterSpeedManual.Location = New System.Drawing.Point(330, 87)
        Me.MasterSpeedManual.Name = "MasterSpeedManual"
        Me.MasterSpeedManual.Size = New System.Drawing.Size(56, 22)
        Me.MasterSpeedManual.TabIndex = 185
        Me.MasterSpeedManual.Text = "0"
        Me.MasterSpeedManual.UseVisualStyleBackColor = False
        Me.MasterSpeedManual.Visible = False
        '
        'MasterSpeedPlus
        '
        Me.MasterSpeedPlus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MasterSpeedPlus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MasterSpeedPlus.Location = New System.Drawing.Point(392, 87)
        Me.MasterSpeedPlus.Name = "MasterSpeedPlus"
        Me.MasterSpeedPlus.Size = New System.Drawing.Size(22, 22)
        Me.MasterSpeedPlus.TabIndex = 184
        Me.MasterSpeedPlus.Text = "+"
        Me.MasterSpeedPlus.UseVisualStyleBackColor = False
        Me.MasterSpeedPlus.Visible = False
        '
        'MasterSpeedMinus
        '
        Me.MasterSpeedMinus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MasterSpeedMinus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MasterSpeedMinus.Location = New System.Drawing.Point(302, 87)
        Me.MasterSpeedMinus.Name = "MasterSpeedMinus"
        Me.MasterSpeedMinus.Size = New System.Drawing.Size(22, 22)
        Me.MasterSpeedMinus.TabIndex = 183
        Me.MasterSpeedMinus.Text = "-"
        Me.MasterSpeedMinus.UseVisualStyleBackColor = False
        Me.MasterSpeedMinus.Visible = False
        '
        'OMUVOnImage
        '
        Me.OMUVOnImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.pngwingON1
        Me.OMUVOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OMUVOnImage.Location = New System.Drawing.Point(909, 189)
        Me.OMUVOnImage.Name = "OMUVOnImage"
        Me.OMUVOnImage.Size = New System.Drawing.Size(30, 30)
        Me.OMUVOnImage.TabIndex = 181
        Me.OMUVOnImage.TabStop = False
        Me.OMUVOnImage.Visible = False
        '
        'OMUVOffImage
        '
        Me.OMUVOffImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.pngwingStandby1
        Me.OMUVOffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OMUVOffImage.InitialImage = Nothing
        Me.OMUVOffImage.Location = New System.Drawing.Point(909, 189)
        Me.OMUVOffImage.Name = "OMUVOffImage"
        Me.OMUVOffImage.Size = New System.Drawing.Size(30, 30)
        Me.OMUVOffImage.TabIndex = 180
        Me.OMUVOffImage.TabStop = False
        '
        'HDHSTOnImage
        '
        Me.HDHSTOnImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.HDHSTOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HDHSTOnImage.Location = New System.Drawing.Point(918, 150)
        Me.HDHSTOnImage.Name = "HDHSTOnImage"
        Me.HDHSTOnImage.Size = New System.Drawing.Size(10, 15)
        Me.HDHSTOnImage.TabIndex = 179
        Me.HDHSTOnImage.TabStop = False
        Me.HDHSTOnImage.Visible = False
        '
        'HDHSTOffImage
        '
        Me.HDHSTOffImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.HDHSTOffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HDHSTOffImage.InitialImage = CType(resources.GetObject("HDHSTOffImage.InitialImage"), System.Drawing.Image)
        Me.HDHSTOffImage.Location = New System.Drawing.Point(918, 150)
        Me.HDHSTOffImage.Name = "HDHSTOffImage"
        Me.HDHSTOffImage.Size = New System.Drawing.Size(10, 15)
        Me.HDHSTOffImage.TabIndex = 178
        Me.HDHSTOffImage.TabStop = False
        '
        'FDrainOnImage
        '
        Me.FDrainOnImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.FDrainOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FDrainOnImage.Location = New System.Drawing.Point(918, 132)
        Me.FDrainOnImage.Name = "FDrainOnImage"
        Me.FDrainOnImage.Size = New System.Drawing.Size(10, 15)
        Me.FDrainOnImage.TabIndex = 177
        Me.FDrainOnImage.TabStop = False
        Me.FDrainOnImage.Visible = False
        '
        'FDrainOffImage
        '
        Me.FDrainOffImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.FDrainOffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FDrainOffImage.InitialImage = CType(resources.GetObject("FDrainOffImage.InitialImage"), System.Drawing.Image)
        Me.FDrainOffImage.Location = New System.Drawing.Point(918, 132)
        Me.FDrainOffImage.Name = "FDrainOffImage"
        Me.FDrainOffImage.Size = New System.Drawing.Size(10, 15)
        Me.FDrainOffImage.TabIndex = 176
        Me.FDrainOffImage.TabStop = False
        '
        'MPumpOnImage
        '
        Me.MPumpOnImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.MPumpOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MPumpOnImage.Location = New System.Drawing.Point(918, 114)
        Me.MPumpOnImage.Name = "MPumpOnImage"
        Me.MPumpOnImage.Size = New System.Drawing.Size(10, 15)
        Me.MPumpOnImage.TabIndex = 175
        Me.MPumpOnImage.TabStop = False
        Me.MPumpOnImage.Visible = False
        '
        'MPumpOffImage
        '
        Me.MPumpOffImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.MPumpOffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MPumpOffImage.InitialImage = CType(resources.GetObject("MPumpOffImage.InitialImage"), System.Drawing.Image)
        Me.MPumpOffImage.Location = New System.Drawing.Point(918, 114)
        Me.MPumpOffImage.Name = "MPumpOffImage"
        Me.MPumpOffImage.Size = New System.Drawing.Size(10, 15)
        Me.MPumpOffImage.TabIndex = 174
        Me.MPumpOffImage.TabStop = False
        '
        'FCtchOnImage
        '
        Me.FCtchOnImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.FCtchOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FCtchOnImage.Location = New System.Drawing.Point(918, 96)
        Me.FCtchOnImage.Name = "FCtchOnImage"
        Me.FCtchOnImage.Size = New System.Drawing.Size(10, 15)
        Me.FCtchOnImage.TabIndex = 173
        Me.FCtchOnImage.TabStop = False
        Me.FCtchOnImage.Visible = False
        '
        'FCtchOffImage
        '
        Me.FCtchOffImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.FCtchOffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FCtchOffImage.InitialImage = CType(resources.GetObject("FCtchOffImage.InitialImage"), System.Drawing.Image)
        Me.FCtchOffImage.Location = New System.Drawing.Point(918, 96)
        Me.FCtchOffImage.Name = "FCtchOffImage"
        Me.FCtchOffImage.Size = New System.Drawing.Size(10, 15)
        Me.FCtchOffImage.TabIndex = 172
        Me.FCtchOffImage.TabStop = False
        '
        'FDISOnImage
        '
        Me.FDISOnImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.FDISOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FDISOnImage.Location = New System.Drawing.Point(918, 78)
        Me.FDISOnImage.Name = "FDISOnImage"
        Me.FDISOnImage.Size = New System.Drawing.Size(10, 15)
        Me.FDISOnImage.TabIndex = 171
        Me.FDISOnImage.TabStop = False
        Me.FDISOnImage.Visible = False
        '
        'FDISOffImage
        '
        Me.FDISOffImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.FDISOffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FDISOffImage.InitialImage = CType(resources.GetObject("FDISOffImage.InitialImage"), System.Drawing.Image)
        Me.FDISOffImage.Location = New System.Drawing.Point(918, 78)
        Me.FDISOffImage.Name = "FDISOffImage"
        Me.FDISOffImage.Size = New System.Drawing.Size(10, 15)
        Me.FDISOffImage.TabIndex = 170
        Me.FDISOffImage.TabStop = False
        '
        'FSubOnImage
        '
        Me.FSubOnImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.FSubOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FSubOnImage.Location = New System.Drawing.Point(918, 60)
        Me.FSubOnImage.Name = "FSubOnImage"
        Me.FSubOnImage.Size = New System.Drawing.Size(10, 15)
        Me.FSubOnImage.TabIndex = 169
        Me.FSubOnImage.TabStop = False
        Me.FSubOnImage.Visible = False
        '
        'FSubOffImage
        '
        Me.FSubOffImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.FSubOffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FSubOffImage.InitialImage = CType(resources.GetObject("FSubOffImage.InitialImage"), System.Drawing.Image)
        Me.FSubOffImage.Location = New System.Drawing.Point(918, 60)
        Me.FSubOffImage.Name = "FSubOffImage"
        Me.FSubOffImage.Size = New System.Drawing.Size(10, 15)
        Me.FSubOffImage.TabIndex = 168
        Me.FSubOffImage.TabStop = False
        '
        'FPLDOnImage
        '
        Me.FPLDOnImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.FPLDOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FPLDOnImage.Location = New System.Drawing.Point(918, 42)
        Me.FPLDOnImage.Name = "FPLDOnImage"
        Me.FPLDOnImage.Size = New System.Drawing.Size(10, 15)
        Me.FPLDOnImage.TabIndex = 167
        Me.FPLDOnImage.TabStop = False
        Me.FPLDOnImage.Visible = False
        '
        'FPLDOffImage
        '
        Me.FPLDOffImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.FPLDOffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FPLDOffImage.InitialImage = CType(resources.GetObject("FPLDOffImage.InitialImage"), System.Drawing.Image)
        Me.FPLDOffImage.Location = New System.Drawing.Point(918, 42)
        Me.FPLDOffImage.Name = "FPLDOffImage"
        Me.FPLDOffImage.Size = New System.Drawing.Size(10, 15)
        Me.FPLDOffImage.TabIndex = 166
        Me.FPLDOffImage.TabStop = False
        '
        'FlameBar
        '
        Me.FlameBar.BackColor = System.Drawing.Color.Silver
        Me.FlameBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.FlameBar.ForeColor = System.Drawing.Color.Red
        Me.FlameBar.Location = New System.Drawing.Point(300, 256)
        Me.FlameBar.Name = "FlameBar"
        Me.FlameBar.Size = New System.Drawing.Size(72, 27)
        Me.FlameBar.TabIndex = 165
        Me.FlameBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox22
        '
        Me.PictureBox22.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox22.ErrorImage = Nothing
        Me.PictureBox22.Image = CType(resources.GetObject("PictureBox22.Image"), System.Drawing.Image)
        Me.PictureBox22.InitialImage = Nothing
        Me.PictureBox22.Location = New System.Drawing.Point(410, 67)
        Me.PictureBox22.Name = "PictureBox22"
        Me.PictureBox22.Size = New System.Drawing.Size(30, 4)
        Me.PictureBox22.TabIndex = 164
        Me.PictureBox22.TabStop = False
        '
        'PictureBox23
        '
        Me.PictureBox23.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox23.ErrorImage = Nothing
        Me.PictureBox23.Image = CType(resources.GetObject("PictureBox23.Image"), System.Drawing.Image)
        Me.PictureBox23.InitialImage = Nothing
        Me.PictureBox23.Location = New System.Drawing.Point(476, 67)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(30, 4)
        Me.PictureBox23.TabIndex = 163
        Me.PictureBox23.TabStop = False
        '
        'BiasDisplayText
        '
        Me.BiasDisplayText.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BiasDisplayText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.BiasDisplayText.ForeColor = System.Drawing.Color.Cyan
        Me.BiasDisplayText.Location = New System.Drawing.Point(567, 258)
        Me.BiasDisplayText.Name = "BiasDisplayText"
        Me.BiasDisplayText.Size = New System.Drawing.Size(75, 20)
        Me.BiasDisplayText.TabIndex = 126
        Me.BiasDisplayText.Text = "BIAS: 8"
        Me.BiasDisplayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DeltaTText
        '
        Me.DeltaTText.BackColor = System.Drawing.SystemColors.MenuText
        Me.DeltaTText.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeltaTText.ForeColor = System.Drawing.Color.Cyan
        Me.DeltaTText.Location = New System.Drawing.Point(135, 101)
        Me.DeltaTText.Name = "DeltaTText"
        Me.DeltaTText.Size = New System.Drawing.Size(92, 29)
        Me.DeltaTText.TabIndex = 125
        Me.DeltaTText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox67
        '
        Me.TextBox67.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox67.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox67.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Bold)
        Me.TextBox67.Location = New System.Drawing.Point(135, 91)
        Me.TextBox67.Name = "TextBox67"
        Me.TextBox67.Size = New System.Drawing.Size(99, 10)
        Me.TextBox67.TabIndex = 124
        Me.TextBox67.Text = "DELTA T."
        Me.TextBox67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DischargeConveyorOffImage
        '
        Me.DischargeConveyorOffImage.BackgroundImage = CType(resources.GetObject("DischargeConveyorOffImage.BackgroundImage"), System.Drawing.Image)
        Me.DischargeConveyorOffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DischargeConveyorOffImage.Image = CType(resources.GetObject("DischargeConveyorOffImage.Image"), System.Drawing.Image)
        Me.DischargeConveyorOffImage.Location = New System.Drawing.Point(528, 246)
        Me.DischargeConveyorOffImage.Name = "DischargeConveyorOffImage"
        Me.DischargeConveyorOffImage.Size = New System.Drawing.Size(154, 4)
        Me.DischargeConveyorOffImage.TabIndex = 123
        Me.DischargeConveyorOffImage.TabStop = False
        '
        'KHXBurnerOffImage
        '
        Me.KHXBurnerOffImage.BackgroundImage = CType(resources.GetObject("KHXBurnerOffImage.BackgroundImage"), System.Drawing.Image)
        Me.KHXBurnerOffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.KHXBurnerOffImage.Image = CType(resources.GetObject("KHXBurnerOffImage.Image"), System.Drawing.Image)
        Me.KHXBurnerOffImage.Location = New System.Drawing.Point(302, 245)
        Me.KHXBurnerOffImage.Name = "KHXBurnerOffImage"
        Me.KHXBurnerOffImage.Size = New System.Drawing.Size(147, 4)
        Me.KHXBurnerOffImage.TabIndex = 122
        Me.KHXBurnerOffImage.TabStop = False
        '
        'DischargeConveyorOnImage
        '
        Me.DischargeConveyorOnImage.BackgroundImage = CType(resources.GetObject("DischargeConveyorOnImage.BackgroundImage"), System.Drawing.Image)
        Me.DischargeConveyorOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DischargeConveyorOnImage.Location = New System.Drawing.Point(528, 246)
        Me.DischargeConveyorOnImage.Name = "DischargeConveyorOnImage"
        Me.DischargeConveyorOnImage.Size = New System.Drawing.Size(154, 4)
        Me.DischargeConveyorOnImage.TabIndex = 121
        Me.DischargeConveyorOnImage.TabStop = False
        '
        'KHXBurnerOnImage
        '
        Me.KHXBurnerOnImage.BackgroundImage = CType(resources.GetObject("KHXBurnerOnImage.BackgroundImage"), System.Drawing.Image)
        Me.KHXBurnerOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.KHXBurnerOnImage.Location = New System.Drawing.Point(303, 245)
        Me.KHXBurnerOnImage.Name = "KHXBurnerOnImage"
        Me.KHXBurnerOnImage.Size = New System.Drawing.Size(148, 4)
        Me.KHXBurnerOnImage.TabIndex = 120
        Me.KHXBurnerOnImage.TabStop = False
        '
        'MainFlameOffImage
        '
        Me.MainFlameOffImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.Accum_Capacity_Full
        Me.MainFlameOffImage.Location = New System.Drawing.Point(376, 271)
        Me.MainFlameOffImage.Name = "MainFlameOffImage"
        Me.MainFlameOffImage.Size = New System.Drawing.Size(11, 10)
        Me.MainFlameOffImage.TabIndex = 117
        Me.MainFlameOffImage.TabStop = False
        '
        'BurnerStartedOffImage
        '
        Me.BurnerStartedOffImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.Accum_Capacity_Full
        Me.BurnerStartedOffImage.Image = CType(resources.GetObject("BurnerStartedOffImage.Image"), System.Drawing.Image)
        Me.BurnerStartedOffImage.Location = New System.Drawing.Point(376, 256)
        Me.BurnerStartedOffImage.Name = "BurnerStartedOffImage"
        Me.BurnerStartedOffImage.Size = New System.Drawing.Size(11, 10)
        Me.BurnerStartedOffImage.TabIndex = 116
        Me.BurnerStartedOffImage.TabStop = False
        '
        'BurnerStartedOnImage
        '
        Me.BurnerStartedOnImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.Accum_Capacity_Empty
        Me.BurnerStartedOnImage.Location = New System.Drawing.Point(376, 256)
        Me.BurnerStartedOnImage.Name = "BurnerStartedOnImage"
        Me.BurnerStartedOnImage.Size = New System.Drawing.Size(11, 10)
        Me.BurnerStartedOnImage.TabIndex = 113
        Me.BurnerStartedOnImage.TabStop = False
        '
        'MainFlameOnImage
        '
        Me.MainFlameOnImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.Accum_Capacity_Empty
        Me.MainFlameOnImage.Location = New System.Drawing.Point(376, 271)
        Me.MainFlameOnImage.Name = "MainFlameOnImage"
        Me.MainFlameOnImage.Size = New System.Drawing.Size(11, 10)
        Me.MainFlameOnImage.TabIndex = 112
        Me.MainFlameOnImage.TabStop = False
        Me.MainFlameOnImage.Visible = False
        '
        'MM55PowerOff
        '
        Me.MM55PowerOff.BackgroundImage = Global.PC42VB.My.Resources.Resources.Accum_Capacity_Empty
        Me.MM55PowerOff.ErrorImage = Nothing
        Me.MM55PowerOff.Location = New System.Drawing.Point(536, 128)
        Me.MM55PowerOff.Name = "MM55PowerOff"
        Me.MM55PowerOff.Size = New System.Drawing.Size(10, 10)
        Me.MM55PowerOff.TabIndex = 109
        Me.MM55PowerOff.TabStop = False
        Me.MM55PowerOff.Visible = False
        '
        'CoolantAirImageOff
        '
        Me.CoolantAirImageOff.BackgroundImage = Global.PC42VB.My.Resources.Resources.Accum_Capacity_Empty
        Me.CoolantAirImageOff.ErrorImage = Nothing
        Me.CoolantAirImageOff.Location = New System.Drawing.Point(536, 116)
        Me.CoolantAirImageOff.Name = "CoolantAirImageOff"
        Me.CoolantAirImageOff.Size = New System.Drawing.Size(10, 10)
        Me.CoolantAirImageOff.TabIndex = 108
        Me.CoolantAirImageOff.TabStop = False
        Me.CoolantAirImageOff.Visible = False
        '
        'CoolantAirImageOn
        '
        Me.CoolantAirImageOn.BackgroundImage = CType(resources.GetObject("CoolantAirImageOn.BackgroundImage"), System.Drawing.Image)
        Me.CoolantAirImageOn.ErrorImage = Nothing
        Me.CoolantAirImageOn.Image = CType(resources.GetObject("CoolantAirImageOn.Image"), System.Drawing.Image)
        Me.CoolantAirImageOn.Location = New System.Drawing.Point(536, 116)
        Me.CoolantAirImageOn.Name = "CoolantAirImageOn"
        Me.CoolantAirImageOn.Size = New System.Drawing.Size(11, 10)
        Me.CoolantAirImageOn.TabIndex = 105
        Me.CoolantAirImageOn.TabStop = False
        '
        'MM55PowerOn
        '
        Me.MM55PowerOn.BackgroundImage = CType(resources.GetObject("MM55PowerOn.BackgroundImage"), System.Drawing.Image)
        Me.MM55PowerOn.ErrorImage = Nothing
        Me.MM55PowerOn.Image = CType(resources.GetObject("MM55PowerOn.Image"), System.Drawing.Image)
        Me.MM55PowerOn.Location = New System.Drawing.Point(536, 129)
        Me.MM55PowerOn.Name = "MM55PowerOn"
        Me.MM55PowerOn.Size = New System.Drawing.Size(10, 10)
        Me.MM55PowerOn.TabIndex = 104
        Me.MM55PowerOn.TabStop = False
        '
        'MM55On
        '
        Me.MM55On.BackgroundImage = Global.PC42VB.My.Resources.Resources.MM55
        Me.MM55On.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MM55On.ErrorImage = Nothing
        Me.MM55On.Location = New System.Drawing.Point(477, 93)
        Me.MM55On.Name = "MM55On"
        Me.MM55On.Size = New System.Drawing.Size(53, 48)
        Me.MM55On.TabIndex = 103
        Me.MM55On.TabStop = False
        '
        'HighLimitOutput
        '
        Me.HighLimitOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.HighLimitOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighLimitOutput.ForeColor = System.Drawing.Color.Cyan
        Me.HighLimitOutput.Location = New System.Drawing.Point(633, 123)
        Me.HighLimitOutput.Name = "HighLimitOutput"
        Me.HighLimitOutput.Size = New System.Drawing.Size(70, 20)
        Me.HighLimitOutput.TabIndex = 71
        Me.HighLimitOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LowLimitOutput
        '
        Me.LowLimitOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.LowLimitOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LowLimitOutput.ForeColor = System.Drawing.Color.Cyan
        Me.LowLimitOutput.Location = New System.Drawing.Point(632, 87)
        Me.LowLimitOutput.Name = "LowLimitOutput"
        Me.LowLimitOutput.Size = New System.Drawing.Size(70, 20)
        Me.LowLimitOutput.TabIndex = 69
        Me.LowLimitOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SetPointOutput
        '
        Me.SetPointOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.SetPointOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetPointOutput.ForeColor = System.Drawing.Color.Cyan
        Me.SetPointOutput.Location = New System.Drawing.Point(632, 50)
        Me.SetPointOutput.Name = "SetPointOutput"
        Me.SetPointOutput.Size = New System.Drawing.Size(70, 20)
        Me.SetPointOutput.TabIndex = 65
        Me.SetPointOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MoistureOutput
        '
        Me.MoistureOutput.BackColor = System.Drawing.Color.Black
        Me.MoistureOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.MoistureOutput.ForeColor = System.Drawing.Color.Cyan
        Me.MoistureOutput.Location = New System.Drawing.Point(511, 55)
        Me.MoistureOutput.Name = "MoistureOutput"
        Me.MoistureOutput.Size = New System.Drawing.Size(99, 29)
        Me.MoistureOutput.TabIndex = 60
        Me.MoistureOutput.Text = "1.87"
        Me.MoistureOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MasterSpeedOutput
        '
        Me.MasterSpeedOutput.BackColor = System.Drawing.SystemColors.MenuText
        Me.MasterSpeedOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterSpeedOutput.ForeColor = System.Drawing.Color.Cyan
        Me.MasterSpeedOutput.Location = New System.Drawing.Point(308, 55)
        Me.MasterSpeedOutput.Name = "MasterSpeedOutput"
        Me.MasterSpeedOutput.Size = New System.Drawing.Size(99, 29)
        Me.MasterSpeedOutput.TabIndex = 54
        Me.MasterSpeedOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OilFlowTextbox
        '
        Me.OilFlowTextbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.OilFlowTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OilFlowTextbox.ForeColor = System.Drawing.Color.Cyan
        Me.OilFlowTextbox.Location = New System.Drawing.Point(20, 176)
        Me.OilFlowTextbox.Name = "OilFlowTextbox"
        Me.OilFlowTextbox.Size = New System.Drawing.Size(68, 20)
        Me.OilFlowTextbox.TabIndex = 30
        Me.OilFlowTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OutletTempText
        '
        Me.OutletTempText.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.OutletTempText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutletTempText.ForeColor = System.Drawing.Color.Cyan
        Me.OutletTempText.Location = New System.Drawing.Point(20, 133)
        Me.OutletTempText.Name = "OutletTempText"
        Me.OutletTempText.Size = New System.Drawing.Size(68, 20)
        Me.OutletTempText.TabIndex = 31
        Me.OutletTempText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'InletTemperature
        '
        Me.InletTemperature.BackColor = System.Drawing.SystemColors.MenuText
        Me.InletTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InletTemperature.ForeColor = System.Drawing.Color.Cyan
        Me.InletTemperature.Location = New System.Drawing.Point(134, 56)
        Me.InletTemperature.Name = "InletTemperature"
        Me.InletTemperature.Size = New System.Drawing.Size(93, 29)
        Me.InletTemperature.TabIndex = 53
        Me.InletTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'InletSetpoint
        '
        Me.InletSetpoint.BackColor = System.Drawing.SystemColors.MenuText
        Me.InletSetpoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InletSetpoint.ForeColor = System.Drawing.Color.Cyan
        Me.InletSetpoint.Location = New System.Drawing.Point(19, 56)
        Me.InletSetpoint.Name = "InletSetpoint"
        Me.InletSetpoint.Size = New System.Drawing.Size(93, 29)
        Me.InletSetpoint.TabIndex = 52
        Me.InletSetpoint.Text = " "
        Me.InletSetpoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InletSetpoint.WordWrap = False
        '
        'SlicerStopButton
        '
        Me.SlicerStopButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SlicerStopButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlicerStopButton.ForeColor = System.Drawing.Color.Red
        Me.SlicerStopButton.Location = New System.Drawing.Point(282, 102)
        Me.SlicerStopButton.Name = "SlicerStopButton"
        Me.SlicerStopButton.Size = New System.Drawing.Size(57, 35)
        Me.SlicerStopButton.TabIndex = 145
        Me.SlicerStopButton.Text = "STOP"
        Me.SlicerStopButton.UseVisualStyleBackColor = False
        '
        'textBox1
        '
        Me.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(24, 63)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(178, 15)
        Me.textBox1.TabIndex = 14
        Me.textBox1.Text = "FRYER INFEED"
        '
        'textBox2
        '
        Me.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Bold)
        Me.textBox2.Location = New System.Drawing.Point(63, 84)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(174, 10)
        Me.textBox2.TabIndex = 15
        Me.textBox2.Text = "POTATO PREPARATION"
        '
        'textBox3
        '
        Me.textBox3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.textBox3.Location = New System.Drawing.Point(285, 85)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(141, 11)
        Me.textBox3.TabIndex = 18
        Me.textBox3.Text = "SLICER FEED"
        Me.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LaningConveyorLabel
        '
        Me.LaningConveyorLabel.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.LaningConveyorLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LaningConveyorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.LaningConveyorLabel.Location = New System.Drawing.Point(528, 85)
        Me.LaningConveyorLabel.Name = "LaningConveyorLabel"
        Me.LaningConveyorLabel.Size = New System.Drawing.Size(140, 11)
        Me.LaningConveyorLabel.TabIndex = 19
        Me.LaningConveyorLabel.Text = "LANING CONVEYOR"
        Me.LaningConveyorLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SlicerFeedMinusButton
        '
        Me.SlicerFeedMinusButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SlicerFeedMinusButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SlicerFeedMinusButton.Location = New System.Drawing.Point(282, 147)
        Me.SlicerFeedMinusButton.Name = "SlicerFeedMinusButton"
        Me.SlicerFeedMinusButton.Size = New System.Drawing.Size(33, 25)
        Me.SlicerFeedMinusButton.TabIndex = 29
        Me.SlicerFeedMinusButton.Text = "-"
        Me.SlicerFeedMinusButton.UseVisualStyleBackColor = False
        '
        'SlicerFeedPlusButton
        '
        Me.SlicerFeedPlusButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SlicerFeedPlusButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SlicerFeedPlusButton.Location = New System.Drawing.Point(402, 147)
        Me.SlicerFeedPlusButton.Name = "SlicerFeedPlusButton"
        Me.SlicerFeedPlusButton.Size = New System.Drawing.Size(30, 25)
        Me.SlicerFeedPlusButton.TabIndex = 30
        Me.SlicerFeedPlusButton.Text = "+"
        Me.SlicerFeedPlusButton.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label6.Location = New System.Drawing.Point(53, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "DATE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label7.Location = New System.Drawing.Point(149, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 123
        Me.Label7.Text = "TIME"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label8.Location = New System.Drawing.Point(282, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 13)
        Me.Label8.TabIndex = 124
        Me.Label8.Text = "SYSTEM COMMS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label9.Location = New System.Drawing.Point(477, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 13)
        Me.Label9.TabIndex = 125
        Me.Label9.Text = "CURRENT PRODUCT"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label10.Location = New System.Drawing.Point(681, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 13)
        Me.Label10.TabIndex = 126
        Me.Label10.Text = "MOISTURE MODE"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel1.Controls.Add(Me.Label96)
        Me.panel1.Controls.Add(Me.Label90)
        Me.panel1.Controls.Add(Me.Label91)
        Me.panel1.Controls.Add(Me.Label92)
        Me.panel1.Controls.Add(Me.Label93)
        Me.panel1.Controls.Add(Me.Label94)
        Me.panel1.Controls.Add(Me.Label95)
        Me.panel1.Controls.Add(Me.MMMenu)
        Me.panel1.Controls.Add(Me.CPMenu)
        Me.panel1.Controls.Add(Me.SCMenu)
        Me.panel1.Controls.Add(Me.PPRunningOffImage)
        Me.panel1.Controls.Add(Me.SlicersLabel)
        Me.panel1.Controls.Add(Me.GatesLabel)
        Me.panel1.Controls.Add(Me.DelayedSpeedChange)
        Me.panel1.Controls.Add(Me.SlicerFeedSpeedButton)
        Me.panel1.Controls.Add(Me.KMOn)
        Me.panel1.Controls.Add(Me.AirMOn)
        Me.panel1.Controls.Add(Me.SWCBMOn)
        Me.panel1.Controls.Add(Me.SWPMOn)
        Me.panel1.Controls.Add(Me.SCMOn)
        Me.panel1.Controls.Add(Me.S3MOn)
        Me.panel1.Controls.Add(Me.S2MOn)
        Me.panel1.Controls.Add(Me.S1MOn)
        Me.panel1.Controls.Add(Me.LCMOn)
        Me.panel1.Controls.Add(Me.SFCMOn)
        Me.panel1.Controls.Add(Me.KMOff)
        Me.panel1.Controls.Add(Me.AirMOff)
        Me.panel1.Controls.Add(Me.SWCBMOff)
        Me.panel1.Controls.Add(Me.SWPMOff)
        Me.panel1.Controls.Add(Me.SWCMOff)
        Me.panel1.Controls.Add(Me.S3CMOff)
        Me.panel1.Controls.Add(Me.S2CMOff)
        Me.panel1.Controls.Add(Me.S1CMOff)
        Me.panel1.Controls.Add(Me.LCMOff)
        Me.panel1.Controls.Add(Me.SFCMOff)
        Me.panel1.Controls.Add(Me.LaningConveyorStartButton)
        Me.panel1.Controls.Add(Me.LaningConveyorStopButton)
        Me.panel1.Controls.Add(Me.SlicerStartButton)
        Me.panel1.Controls.Add(Me.SlicerStopButton)
        Me.panel1.Controls.Add(Me.SlicerOff2)
        Me.panel1.Controls.Add(Me.SlicerOff3)
        Me.panel1.Controls.Add(Me.SlicerOn3)
        Me.panel1.Controls.Add(Me.SlicerOn2)
        Me.panel1.Controls.Add(Me.SlicerOff1)
        Me.panel1.Controls.Add(Me.DTMenu)
        Me.panel1.Controls.Add(Me.PPRLabel)
        Me.panel1.Controls.Add(Me.Button2)
        Me.panel1.Controls.Add(Me.AlarmButton)
        Me.panel1.Controls.Add(Me.Label10)
        Me.panel1.Controls.Add(Me.Label9)
        Me.panel1.Controls.Add(Me.Label8)
        Me.panel1.Controls.Add(Me.Label7)
        Me.panel1.Controls.Add(Me.Label6)
        Me.panel1.Controls.Add(Me.LaningConveyorOffImage)
        Me.panel1.Controls.Add(Me.LaningConveyorOnImage)
        Me.panel1.Controls.Add(Me.SlicerFeedOffImage)
        Me.panel1.Controls.Add(Me.SlicerFeedOnImage)
        Me.panel1.Controls.Add(Me.PPRunningOnImage)
        Me.panel1.Controls.Add(Me.SlicerOn1)
        Me.panel1.Controls.Add(Me.SlicerFeedPlusButton)
        Me.panel1.Controls.Add(Me.SlicerFeedMinusButton)
        Me.panel1.Controls.Add(Me.LaningConveyorLabel)
        Me.panel1.Controls.Add(Me.textBox3)
        Me.panel1.Controls.Add(Me.textBox2)
        Me.panel1.Controls.Add(Me.textBox1)
        Me.panel1.ForeColor = System.Drawing.SystemColors.Info
        Me.panel1.Location = New System.Drawing.Point(12, 7)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(974, 196)
        Me.panel1.TabIndex = 15
        '
        'Label96
        '
        Me.Label96.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label96.ForeColor = System.Drawing.Color.Black
        Me.Label96.Location = New System.Drawing.Point(753, 174)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(164, 12)
        Me.Label96.TabIndex = 354
        Me.Label96.Text = "Air, Knife and Sweep"
        Me.Label96.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label90
        '
        Me.Label90.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.Label90.ForeColor = System.Drawing.Color.Black
        Me.Label90.Location = New System.Drawing.Point(753, 63)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(164, 12)
        Me.Label90.TabIndex = 353
        Me.Label90.Text = "INFEED DRIVE STATUS"
        Me.Label90.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label91
        '
        Me.Label91.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label91.ForeColor = System.Drawing.Color.Black
        Me.Label91.Location = New System.Drawing.Point(753, 84)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(164, 12)
        Me.Label91.TabIndex = 352
        Me.Label91.Text = "Slicer Feed Conveyor"
        Me.Label91.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label92
        '
        Me.Label92.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label92.ForeColor = System.Drawing.Color.Black
        Me.Label92.Location = New System.Drawing.Point(753, 102)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(164, 12)
        Me.Label92.TabIndex = 351
        Me.Label92.Text = "Laning Conveyor"
        Me.Label92.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label93
        '
        Me.Label93.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label93.ForeColor = System.Drawing.Color.Black
        Me.Label93.Location = New System.Drawing.Point(753, 120)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(165, 12)
        Me.Label93.TabIndex = 350
        Me.Label93.Text = "Slicers"
        Me.Label93.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label94
        '
        Me.Label94.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label94.ForeColor = System.Drawing.Color.Black
        Me.Label94.Location = New System.Drawing.Point(753, 138)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(164, 12)
        Me.Label94.TabIndex = 349
        Me.Label94.Text = "SpeedWash:"
        Me.Label94.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label95
        '
        Me.Label95.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label95.ForeColor = System.Drawing.Color.Black
        Me.Label95.Location = New System.Drawing.Point(753, 156)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(164, 12)
        Me.Label95.TabIndex = 348
        Me.Label95.Text = "Conv, Pump, Catchbox"
        Me.Label95.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MMMenu
        '
        Me.MMMenu.BackColor = System.Drawing.Color.Blue
        Me.MMMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MMMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MMMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MMMenu.ForeColor = System.Drawing.Color.Cyan
        Me.MMMenu.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.MMMenu.Location = New System.Drawing.Point(647, 28)
        Me.MMMenu.Name = "MMMenu"
        Me.MMMenu.Size = New System.Drawing.Size(201, 28)
        Me.MMMenu.TabIndex = 185
        Me.MMMenu.Text = "AUTOMATIC"
        Me.MMMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CPMenu
        '
        Me.CPMenu.BackColor = System.Drawing.Color.Blue
        Me.CPMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CPMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CPMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPMenu.ForeColor = System.Drawing.Color.Yellow
        Me.CPMenu.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CPMenu.Location = New System.Drawing.Point(438, 28)
        Me.CPMenu.Name = "CPMenu"
        Me.CPMenu.Size = New System.Drawing.Size(201, 28)
        Me.CPMenu.TabIndex = 184
        Me.CPMenu.Text = "CRINKLE CUT"
        Me.CPMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SCMenu
        '
        Me.SCMenu.BackColor = System.Drawing.Color.Blue
        Me.SCMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SCMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SCMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SCMenu.ForeColor = System.Drawing.Color.Lime
        Me.SCMenu.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.SCMenu.Location = New System.Drawing.Point(230, 28)
        Me.SCMenu.Name = "SCMenu"
        Me.SCMenu.Size = New System.Drawing.Size(201, 28)
        Me.SCMenu.TabIndex = 183
        Me.SCMenu.Text = "PLC COMMS OK"
        Me.SCMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PPRunningOffImage
        '
        Me.PPRunningOffImage.BackgroundImage = CType(resources.GetObject("PPRunningOffImage.BackgroundImage"), System.Drawing.Image)
        Me.PPRunningOffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PPRunningOffImage.Location = New System.Drawing.Point(21, 111)
        Me.PPRunningOffImage.Name = "PPRunningOffImage"
        Me.PPRunningOffImage.Size = New System.Drawing.Size(183, 4)
        Me.PPRunningOffImage.TabIndex = 182
        Me.PPRunningOffImage.TabStop = False
        Me.PPRunningOffImage.Visible = False
        '
        'SlicersLabel
        '
        Me.SlicersLabel.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.SlicersLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SlicersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.SlicersLabel.Location = New System.Drawing.Point(466, 163)
        Me.SlicersLabel.Name = "SlicersLabel"
        Me.SlicersLabel.Size = New System.Drawing.Size(56, 11)
        Me.SlicersLabel.TabIndex = 172
        Me.SlicersLabel.Text = "SLICERS"
        '
        'GatesLabel
        '
        Me.GatesLabel.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GatesLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GatesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.GatesLabel.Location = New System.Drawing.Point(467, 150)
        Me.GatesLabel.Name = "GatesLabel"
        Me.GatesLabel.Size = New System.Drawing.Size(56, 11)
        Me.GatesLabel.TabIndex = 171
        Me.GatesLabel.Text = "GATES"
        '
        'DelayedSpeedChange
        '
        Me.DelayedSpeedChange.AutoSize = True
        Me.DelayedSpeedChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelayedSpeedChange.ForeColor = System.Drawing.Color.Cyan
        Me.DelayedSpeedChange.Location = New System.Drawing.Point(348, 174)
        Me.DelayedSpeedChange.Name = "DelayedSpeedChange"
        Me.DelayedSpeedChange.Size = New System.Drawing.Size(23, 15)
        Me.DelayedSpeedChange.TabIndex = 170
        Me.DelayedSpeedChange.Text = "70"
        '
        'SlicerFeedSpeedButton
        '
        Me.SlicerFeedSpeedButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SlicerFeedSpeedButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlicerFeedSpeedButton.ForeColor = System.Drawing.Color.Black
        Me.SlicerFeedSpeedButton.Location = New System.Drawing.Point(324, 147)
        Me.SlicerFeedSpeedButton.Name = "SlicerFeedSpeedButton"
        Me.SlicerFeedSpeedButton.Size = New System.Drawing.Size(72, 25)
        Me.SlicerFeedSpeedButton.TabIndex = 169
        Me.SlicerFeedSpeedButton.Text = "70"
        Me.SlicerFeedSpeedButton.UseVisualStyleBackColor = False
        '
        'KMOn
        '
        Me.KMOn.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.KMOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.KMOn.Location = New System.Drawing.Point(933, 171)
        Me.KMOn.Name = "KMOn"
        Me.KMOn.Size = New System.Drawing.Size(10, 15)
        Me.KMOn.TabIndex = 168
        Me.KMOn.TabStop = False
        Me.KMOn.Visible = False
        '
        'AirMOn
        '
        Me.AirMOn.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.AirMOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AirMOn.Location = New System.Drawing.Point(918, 171)
        Me.AirMOn.Name = "AirMOn"
        Me.AirMOn.Size = New System.Drawing.Size(10, 15)
        Me.AirMOn.TabIndex = 167
        Me.AirMOn.TabStop = False
        Me.AirMOn.Visible = False
        '
        'SWCBMOn
        '
        Me.SWCBMOn.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.SWCBMOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SWCBMOn.Location = New System.Drawing.Point(948, 150)
        Me.SWCBMOn.Name = "SWCBMOn"
        Me.SWCBMOn.Size = New System.Drawing.Size(10, 15)
        Me.SWCBMOn.TabIndex = 166
        Me.SWCBMOn.TabStop = False
        Me.SWCBMOn.Visible = False
        '
        'SWPMOn
        '
        Me.SWPMOn.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.SWPMOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SWPMOn.Location = New System.Drawing.Point(933, 150)
        Me.SWPMOn.Name = "SWPMOn"
        Me.SWPMOn.Size = New System.Drawing.Size(10, 15)
        Me.SWPMOn.TabIndex = 165
        Me.SWPMOn.TabStop = False
        Me.SWPMOn.Visible = False
        '
        'SCMOn
        '
        Me.SCMOn.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.SCMOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SCMOn.Location = New System.Drawing.Point(918, 150)
        Me.SCMOn.Name = "SCMOn"
        Me.SCMOn.Size = New System.Drawing.Size(10, 15)
        Me.SCMOn.TabIndex = 164
        Me.SCMOn.TabStop = False
        Me.SCMOn.Visible = False
        '
        'S3MOn
        '
        Me.S3MOn.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.S3MOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.S3MOn.Location = New System.Drawing.Point(948, 117)
        Me.S3MOn.Name = "S3MOn"
        Me.S3MOn.Size = New System.Drawing.Size(10, 15)
        Me.S3MOn.TabIndex = 163
        Me.S3MOn.TabStop = False
        Me.S3MOn.Visible = False
        '
        'S2MOn
        '
        Me.S2MOn.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.S2MOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.S2MOn.Location = New System.Drawing.Point(933, 117)
        Me.S2MOn.Name = "S2MOn"
        Me.S2MOn.Size = New System.Drawing.Size(10, 15)
        Me.S2MOn.TabIndex = 162
        Me.S2MOn.TabStop = False
        Me.S2MOn.Visible = False
        '
        'S1MOn
        '
        Me.S1MOn.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.S1MOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.S1MOn.Location = New System.Drawing.Point(918, 117)
        Me.S1MOn.Name = "S1MOn"
        Me.S1MOn.Size = New System.Drawing.Size(10, 15)
        Me.S1MOn.TabIndex = 161
        Me.S1MOn.TabStop = False
        Me.S1MOn.Visible = False
        '
        'LCMOn
        '
        Me.LCMOn.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.LCMOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LCMOn.Location = New System.Drawing.Point(918, 99)
        Me.LCMOn.Name = "LCMOn"
        Me.LCMOn.Size = New System.Drawing.Size(10, 15)
        Me.LCMOn.TabIndex = 160
        Me.LCMOn.TabStop = False
        Me.LCMOn.Visible = False
        '
        'SFCMOn
        '
        Me.SFCMOn.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorON
        Me.SFCMOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SFCMOn.Location = New System.Drawing.Point(918, 81)
        Me.SFCMOn.Name = "SFCMOn"
        Me.SFCMOn.Size = New System.Drawing.Size(10, 15)
        Me.SFCMOn.TabIndex = 159
        Me.SFCMOn.TabStop = False
        Me.SFCMOn.Visible = False
        '
        'KMOff
        '
        Me.KMOff.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.KMOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.KMOff.InitialImage = CType(resources.GetObject("KMOff.InitialImage"), System.Drawing.Image)
        Me.KMOff.Location = New System.Drawing.Point(933, 171)
        Me.KMOff.Name = "KMOff"
        Me.KMOff.Size = New System.Drawing.Size(10, 15)
        Me.KMOff.TabIndex = 158
        Me.KMOff.TabStop = False
        '
        'AirMOff
        '
        Me.AirMOff.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.AirMOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AirMOff.InitialImage = CType(resources.GetObject("AirMOff.InitialImage"), System.Drawing.Image)
        Me.AirMOff.Location = New System.Drawing.Point(918, 171)
        Me.AirMOff.Name = "AirMOff"
        Me.AirMOff.Size = New System.Drawing.Size(10, 15)
        Me.AirMOff.TabIndex = 157
        Me.AirMOff.TabStop = False
        '
        'SWCBMOff
        '
        Me.SWCBMOff.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.SWCBMOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SWCBMOff.InitialImage = CType(resources.GetObject("SWCBMOff.InitialImage"), System.Drawing.Image)
        Me.SWCBMOff.Location = New System.Drawing.Point(948, 150)
        Me.SWCBMOff.Name = "SWCBMOff"
        Me.SWCBMOff.Size = New System.Drawing.Size(10, 15)
        Me.SWCBMOff.TabIndex = 156
        Me.SWCBMOff.TabStop = False
        '
        'SWPMOff
        '
        Me.SWPMOff.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.SWPMOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SWPMOff.InitialImage = CType(resources.GetObject("SWPMOff.InitialImage"), System.Drawing.Image)
        Me.SWPMOff.Location = New System.Drawing.Point(933, 150)
        Me.SWPMOff.Name = "SWPMOff"
        Me.SWPMOff.Size = New System.Drawing.Size(10, 15)
        Me.SWPMOff.TabIndex = 155
        Me.SWPMOff.TabStop = False
        '
        'SWCMOff
        '
        Me.SWCMOff.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.SWCMOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SWCMOff.InitialImage = CType(resources.GetObject("SWCMOff.InitialImage"), System.Drawing.Image)
        Me.SWCMOff.Location = New System.Drawing.Point(918, 150)
        Me.SWCMOff.Name = "SWCMOff"
        Me.SWCMOff.Size = New System.Drawing.Size(10, 15)
        Me.SWCMOff.TabIndex = 154
        Me.SWCMOff.TabStop = False
        '
        'S3CMOff
        '
        Me.S3CMOff.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.S3CMOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.S3CMOff.InitialImage = CType(resources.GetObject("S3CMOff.InitialImage"), System.Drawing.Image)
        Me.S3CMOff.Location = New System.Drawing.Point(948, 117)
        Me.S3CMOff.Name = "S3CMOff"
        Me.S3CMOff.Size = New System.Drawing.Size(10, 15)
        Me.S3CMOff.TabIndex = 153
        Me.S3CMOff.TabStop = False
        '
        'S2CMOff
        '
        Me.S2CMOff.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.S2CMOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.S2CMOff.Location = New System.Drawing.Point(933, 117)
        Me.S2CMOff.Name = "S2CMOff"
        Me.S2CMOff.Size = New System.Drawing.Size(10, 15)
        Me.S2CMOff.TabIndex = 152
        Me.S2CMOff.TabStop = False
        '
        'S1CMOff
        '
        Me.S1CMOff.BackgroundImage = CType(resources.GetObject("S1CMOff.BackgroundImage"), System.Drawing.Image)
        Me.S1CMOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.S1CMOff.ErrorImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.S1CMOff.Location = New System.Drawing.Point(918, 117)
        Me.S1CMOff.Name = "S1CMOff"
        Me.S1CMOff.Size = New System.Drawing.Size(10, 15)
        Me.S1CMOff.TabIndex = 151
        Me.S1CMOff.TabStop = False
        '
        'LCMOff
        '
        Me.LCMOff.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.LCMOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LCMOff.ErrorImage = CType(resources.GetObject("LCMOff.ErrorImage"), System.Drawing.Image)
        Me.LCMOff.InitialImage = CType(resources.GetObject("LCMOff.InitialImage"), System.Drawing.Image)
        Me.LCMOff.Location = New System.Drawing.Point(918, 99)
        Me.LCMOff.Name = "LCMOff"
        Me.LCMOff.Size = New System.Drawing.Size(10, 15)
        Me.LCMOff.TabIndex = 150
        Me.LCMOff.TabStop = False
        '
        'SFCMOff
        '
        Me.SFCMOff.BackgroundImage = Global.PC42VB.My.Resources.Resources.StatusMotorSTANDBY
        Me.SFCMOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SFCMOff.InitialImage = CType(resources.GetObject("SFCMOff.InitialImage"), System.Drawing.Image)
        Me.SFCMOff.Location = New System.Drawing.Point(918, 81)
        Me.SFCMOff.Name = "SFCMOff"
        Me.SFCMOff.Size = New System.Drawing.Size(10, 15)
        Me.SFCMOff.TabIndex = 149
        Me.SFCMOff.TabStop = False
        '
        'LaningConveyorStartButton
        '
        Me.LaningConveyorStartButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LaningConveyorStartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaningConveyorStartButton.ForeColor = System.Drawing.Color.Green
        Me.LaningConveyorStartButton.Location = New System.Drawing.Point(615, 102)
        Me.LaningConveyorStartButton.Name = "LaningConveyorStartButton"
        Me.LaningConveyorStartButton.Size = New System.Drawing.Size(57, 35)
        Me.LaningConveyorStartButton.TabIndex = 148
        Me.LaningConveyorStartButton.Text = "START"
        Me.LaningConveyorStartButton.UseVisualStyleBackColor = False
        '
        'LaningConveyorStopButton
        '
        Me.LaningConveyorStopButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LaningConveyorStopButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaningConveyorStopButton.ForeColor = System.Drawing.Color.Red
        Me.LaningConveyorStopButton.Location = New System.Drawing.Point(525, 102)
        Me.LaningConveyorStopButton.Name = "LaningConveyorStopButton"
        Me.LaningConveyorStopButton.Size = New System.Drawing.Size(57, 35)
        Me.LaningConveyorStopButton.TabIndex = 147
        Me.LaningConveyorStopButton.Text = "STOP"
        Me.LaningConveyorStopButton.UseVisualStyleBackColor = False
        '
        'SlicerStartButton
        '
        Me.SlicerStartButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SlicerStartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlicerStartButton.ForeColor = System.Drawing.Color.Green
        Me.SlicerStartButton.Location = New System.Drawing.Point(372, 102)
        Me.SlicerStartButton.Name = "SlicerStartButton"
        Me.SlicerStartButton.Size = New System.Drawing.Size(57, 35)
        Me.SlicerStartButton.TabIndex = 146
        Me.SlicerStartButton.Text = "START"
        Me.SlicerStartButton.UseVisualStyleBackColor = False
        '
        'SlicerOff2
        '
        Me.SlicerOff2.BackgroundImage = Global.PC42VB.My.Resources.Resources.SlicerOffImage
        Me.SlicerOff2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SlicerOff2.InitialImage = Nothing
        Me.SlicerOff2.Location = New System.Drawing.Point(584, 150)
        Me.SlicerOff2.Name = "SlicerOff2"
        Me.SlicerOff2.Size = New System.Drawing.Size(31, 39)
        Me.SlicerOff2.TabIndex = 144
        Me.SlicerOff2.TabStop = False
        '
        'SlicerOff3
        '
        Me.SlicerOff3.BackgroundImage = Global.PC42VB.My.Resources.Resources.SlicerOffImage
        Me.SlicerOff3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SlicerOff3.InitialImage = Nothing
        Me.SlicerOff3.Location = New System.Drawing.Point(631, 150)
        Me.SlicerOff3.Name = "SlicerOff3"
        Me.SlicerOff3.Size = New System.Drawing.Size(31, 39)
        Me.SlicerOff3.TabIndex = 143
        Me.SlicerOff3.TabStop = False
        '
        'SlicerOn3
        '
        Me.SlicerOn3.BackgroundImage = Global.PC42VB.My.Resources.Resources.SlicerOnImage
        Me.SlicerOn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SlicerOn3.InitialImage = Nothing
        Me.SlicerOn3.Location = New System.Drawing.Point(631, 150)
        Me.SlicerOn3.Name = "SlicerOn3"
        Me.SlicerOn3.Size = New System.Drawing.Size(31, 39)
        Me.SlicerOn3.TabIndex = 142
        Me.SlicerOn3.TabStop = False
        '
        'SlicerOn2
        '
        Me.SlicerOn2.BackgroundImage = Global.PC42VB.My.Resources.Resources.SlicerOnImage
        Me.SlicerOn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SlicerOn2.InitialImage = Nothing
        Me.SlicerOn2.Location = New System.Drawing.Point(584, 150)
        Me.SlicerOn2.Name = "SlicerOn2"
        Me.SlicerOn2.Size = New System.Drawing.Size(31, 39)
        Me.SlicerOn2.TabIndex = 141
        Me.SlicerOn2.TabStop = False
        '
        'SlicerOff1
        '
        Me.SlicerOff1.BackgroundImage = Global.PC42VB.My.Resources.Resources.SlicerOffImage
        Me.SlicerOff1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SlicerOff1.InitialImage = Nothing
        Me.SlicerOff1.Location = New System.Drawing.Point(536, 150)
        Me.SlicerOff1.Name = "SlicerOff1"
        Me.SlicerOff1.Size = New System.Drawing.Size(31, 39)
        Me.SlicerOff1.TabIndex = 140
        Me.SlicerOff1.TabStop = False
        '
        'DTMenu
        '
        Me.DTMenu.BackColor = System.Drawing.Color.Blue
        Me.DTMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DTMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DTMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTMenu.ForeColor = System.Drawing.Color.Yellow
        Me.DTMenu.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.DTMenu.Location = New System.Drawing.Point(22, 28)
        Me.DTMenu.Name = "DTMenu"
        Me.DTMenu.Size = New System.Drawing.Size(201, 28)
        Me.DTMenu.TabIndex = 134
        Me.DTMenu.Text = "Date.now"
        Me.DTMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PPRLabel
        '
        Me.PPRLabel.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PPRLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PPRLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.PPRLabel.Location = New System.Drawing.Point(23, 101)
        Me.PPRLabel.Name = "PPRLabel"
        Me.PPRLabel.Size = New System.Drawing.Size(136, 10)
        Me.PPRLabel.TabIndex = 132
        Me.PPRLabel.Text = "POTATO PREPARATION RUNNING"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(906, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(54, 47)
        Me.Button2.TabIndex = 131
        Me.Button2.Text = "S"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'AlarmButton
        '
        Me.AlarmButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.AlarmButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AlarmButton.Location = New System.Drawing.Point(852, 9)
        Me.AlarmButton.Name = "AlarmButton"
        Me.AlarmButton.Size = New System.Drawing.Size(54, 47)
        Me.AlarmButton.TabIndex = 65
        Me.AlarmButton.Text = "A"
        Me.AlarmButton.UseVisualStyleBackColor = False
        '
        'LaningConveyorOffImage
        '
        Me.LaningConveyorOffImage.BackgroundImage = CType(resources.GetObject("LaningConveyorOffImage.BackgroundImage"), System.Drawing.Image)
        Me.LaningConveyorOffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LaningConveyorOffImage.Image = CType(resources.GetObject("LaningConveyorOffImage.Image"), System.Drawing.Image)
        Me.LaningConveyorOffImage.Location = New System.Drawing.Point(525, 141)
        Me.LaningConveyorOffImage.Name = "LaningConveyorOffImage"
        Me.LaningConveyorOffImage.Size = New System.Drawing.Size(144, 4)
        Me.LaningConveyorOffImage.TabIndex = 122
        Me.LaningConveyorOffImage.TabStop = False
        '
        'LaningConveyorOnImage
        '
        Me.LaningConveyorOnImage.BackgroundImage = CType(resources.GetObject("LaningConveyorOnImage.BackgroundImage"), System.Drawing.Image)
        Me.LaningConveyorOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LaningConveyorOnImage.Location = New System.Drawing.Point(525, 141)
        Me.LaningConveyorOnImage.Name = "LaningConveyorOnImage"
        Me.LaningConveyorOnImage.Size = New System.Drawing.Size(144, 4)
        Me.LaningConveyorOnImage.TabIndex = 121
        Me.LaningConveyorOnImage.TabStop = False
        '
        'SlicerFeedOffImage
        '
        Me.SlicerFeedOffImage.BackgroundImage = CType(resources.GetObject("SlicerFeedOffImage.BackgroundImage"), System.Drawing.Image)
        Me.SlicerFeedOffImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SlicerFeedOffImage.Image = CType(resources.GetObject("SlicerFeedOffImage.Image"), System.Drawing.Image)
        Me.SlicerFeedOffImage.Location = New System.Drawing.Point(282, 140)
        Me.SlicerFeedOffImage.Name = "SlicerFeedOffImage"
        Me.SlicerFeedOffImage.Size = New System.Drawing.Size(146, 4)
        Me.SlicerFeedOffImage.TabIndex = 120
        Me.SlicerFeedOffImage.TabStop = False
        '
        'SlicerFeedOnImage
        '
        Me.SlicerFeedOnImage.BackgroundImage = CType(resources.GetObject("SlicerFeedOnImage.BackgroundImage"), System.Drawing.Image)
        Me.SlicerFeedOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SlicerFeedOnImage.Location = New System.Drawing.Point(282, 140)
        Me.SlicerFeedOnImage.Name = "SlicerFeedOnImage"
        Me.SlicerFeedOnImage.Size = New System.Drawing.Size(147, 4)
        Me.SlicerFeedOnImage.TabIndex = 119
        Me.SlicerFeedOnImage.TabStop = False
        '
        'PPRunningOnImage
        '
        Me.PPRunningOnImage.BackgroundImage = CType(resources.GetObject("PPRunningOnImage.BackgroundImage"), System.Drawing.Image)
        Me.PPRunningOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PPRunningOnImage.Location = New System.Drawing.Point(20, 110)
        Me.PPRunningOnImage.Name = "PPRunningOnImage"
        Me.PPRunningOnImage.Size = New System.Drawing.Size(183, 4)
        Me.PPRunningOnImage.TabIndex = 118
        Me.PPRunningOnImage.TabStop = False
        '
        'SlicerOn1
        '
        Me.SlicerOn1.BackgroundImage = Global.PC42VB.My.Resources.Resources.SlicerOnImage
        Me.SlicerOn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SlicerOn1.InitialImage = Nothing
        Me.SlicerOn1.Location = New System.Drawing.Point(536, 150)
        Me.SlicerOn1.Name = "SlicerOn1"
        Me.SlicerOn1.Size = New System.Drawing.Size(31, 39)
        Me.SlicerOn1.TabIndex = 75
        Me.SlicerOn1.TabStop = False
        '
        'SystemData
        '
        Me.SystemData.Controls.Add(Me.TabPage1)
        Me.SystemData.Controls.Add(Me.TabPage3)
        Me.SystemData.Controls.Add(Me.TabPage2)
        Me.SystemData.Controls.Add(Me.TabPage4)
        Me.SystemData.Controls.Add(Me.SystemDataTab)
        Me.SystemData.Location = New System.Drawing.Point(987, 6)
        Me.SystemData.Name = "SystemData"
        Me.SystemData.SelectedIndex = 0
        Me.SystemData.Size = New System.Drawing.Size(389, 732)
        Me.SystemData.TabIndex = 150
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button23)
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.SkipStartup)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.OnImage1)
        Me.TabPage1.Controls.Add(Me.BurnerInfoText)
        Me.TabPage1.Controls.Add(Me.EmptyFryer1Pic)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(381, 706)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Fryer"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(201, 675)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 23)
        Me.Button3.TabIndex = 331
        Me.Button3.Text = "EXIT SIMULATION"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button23
        '
        Me.Button23.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button23.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.Button23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.ForeColor = System.Drawing.Color.Black
        Me.Button23.Location = New System.Drawing.Point(69, 675)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(116, 23)
        Me.Button23.TabIndex = 330
        Me.Button23.Text = "SYSTEM RESET"
        Me.Button23.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.MasterSpeedXImage)
        Me.GroupBox7.Controls.Add(Me.DeltaTXImage)
        Me.GroupBox7.Controls.Add(Me.InletXImage)
        Me.GroupBox7.Controls.Add(Me.MoistureXImage)
        Me.GroupBox7.Controls.Add(Me.MasterSpeedExclImage)
        Me.GroupBox7.Controls.Add(Me.InletExclImage)
        Me.GroupBox7.Controls.Add(Me.MoistureExclImage)
        Me.GroupBox7.Controls.Add(Me.MasterSpeedTickImage)
        Me.GroupBox7.Controls.Add(Me.DeltaTTickImage)
        Me.GroupBox7.Controls.Add(Me.InletTickImage)
        Me.GroupBox7.Controls.Add(Me.MoistureTickImage)
        Me.GroupBox7.Controls.Add(Me.Label30)
        Me.GroupBox7.Controls.Add(Me.Label26)
        Me.GroupBox7.Controls.Add(Me.Label25)
        Me.GroupBox7.Controls.Add(Me.Label24)
        Me.GroupBox7.Location = New System.Drawing.Point(16, 266)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(145, 123)
        Me.GroupBox7.TabIndex = 329
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "WoQ"
        '
        'MasterSpeedXImage
        '
        Me.MasterSpeedXImage.BackgroundImage = CType(resources.GetObject("MasterSpeedXImage.BackgroundImage"), System.Drawing.Image)
        Me.MasterSpeedXImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MasterSpeedXImage.Image = CType(resources.GetObject("MasterSpeedXImage.Image"), System.Drawing.Image)
        Me.MasterSpeedXImage.Location = New System.Drawing.Point(105, 93)
        Me.MasterSpeedXImage.Name = "MasterSpeedXImage"
        Me.MasterSpeedXImage.Size = New System.Drawing.Size(19, 18)
        Me.MasterSpeedXImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MasterSpeedXImage.TabIndex = 341
        Me.MasterSpeedXImage.TabStop = False
        Me.MasterSpeedXImage.Visible = False
        '
        'DeltaTXImage
        '
        Me.DeltaTXImage.BackgroundImage = CType(resources.GetObject("DeltaTXImage.BackgroundImage"), System.Drawing.Image)
        Me.DeltaTXImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DeltaTXImage.Image = CType(resources.GetObject("DeltaTXImage.Image"), System.Drawing.Image)
        Me.DeltaTXImage.Location = New System.Drawing.Point(105, 66)
        Me.DeltaTXImage.Name = "DeltaTXImage"
        Me.DeltaTXImage.Size = New System.Drawing.Size(19, 18)
        Me.DeltaTXImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DeltaTXImage.TabIndex = 340
        Me.DeltaTXImage.TabStop = False
        Me.DeltaTXImage.Visible = False
        '
        'InletXImage
        '
        Me.InletXImage.BackgroundImage = CType(resources.GetObject("InletXImage.BackgroundImage"), System.Drawing.Image)
        Me.InletXImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InletXImage.Image = CType(resources.GetObject("InletXImage.Image"), System.Drawing.Image)
        Me.InletXImage.Location = New System.Drawing.Point(105, 41)
        Me.InletXImage.Name = "InletXImage"
        Me.InletXImage.Size = New System.Drawing.Size(19, 18)
        Me.InletXImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.InletXImage.TabIndex = 340
        Me.InletXImage.TabStop = False
        Me.InletXImage.Visible = False
        '
        'MoistureXImage
        '
        Me.MoistureXImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.Red_Cross
        Me.MoistureXImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MoistureXImage.Location = New System.Drawing.Point(105, 17)
        Me.MoistureXImage.Name = "MoistureXImage"
        Me.MoistureXImage.Size = New System.Drawing.Size(19, 18)
        Me.MoistureXImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MoistureXImage.TabIndex = 339
        Me.MoistureXImage.TabStop = False
        Me.MoistureXImage.Visible = False
        '
        'MasterSpeedExclImage
        '
        Me.MasterSpeedExclImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.Yellow_Excl
        Me.MasterSpeedExclImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MasterSpeedExclImage.Location = New System.Drawing.Point(105, 93)
        Me.MasterSpeedExclImage.Name = "MasterSpeedExclImage"
        Me.MasterSpeedExclImage.Size = New System.Drawing.Size(19, 18)
        Me.MasterSpeedExclImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MasterSpeedExclImage.TabIndex = 338
        Me.MasterSpeedExclImage.TabStop = False
        Me.MasterSpeedExclImage.Visible = False
        '
        'InletExclImage
        '
        Me.InletExclImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.Yellow_Excl
        Me.InletExclImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InletExclImage.Location = New System.Drawing.Point(105, 41)
        Me.InletExclImage.Name = "InletExclImage"
        Me.InletExclImage.Size = New System.Drawing.Size(19, 18)
        Me.InletExclImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.InletExclImage.TabIndex = 337
        Me.InletExclImage.TabStop = False
        Me.InletExclImage.Visible = False
        '
        'MoistureExclImage
        '
        Me.MoistureExclImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.Yellow_Excl
        Me.MoistureExclImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MoistureExclImage.Location = New System.Drawing.Point(105, 17)
        Me.MoistureExclImage.Name = "MoistureExclImage"
        Me.MoistureExclImage.Size = New System.Drawing.Size(19, 18)
        Me.MoistureExclImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MoistureExclImage.TabIndex = 331
        Me.MoistureExclImage.TabStop = False
        Me.MoistureExclImage.Visible = False
        '
        'MasterSpeedTickImage
        '
        Me.MasterSpeedTickImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.Green_Tick
        Me.MasterSpeedTickImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MasterSpeedTickImage.Location = New System.Drawing.Point(105, 93)
        Me.MasterSpeedTickImage.Name = "MasterSpeedTickImage"
        Me.MasterSpeedTickImage.Size = New System.Drawing.Size(19, 18)
        Me.MasterSpeedTickImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MasterSpeedTickImage.TabIndex = 336
        Me.MasterSpeedTickImage.TabStop = False
        Me.MasterSpeedTickImage.Visible = False
        '
        'DeltaTTickImage
        '
        Me.DeltaTTickImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.GreenTick
        Me.DeltaTTickImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DeltaTTickImage.Location = New System.Drawing.Point(105, 66)
        Me.DeltaTTickImage.Name = "DeltaTTickImage"
        Me.DeltaTTickImage.Size = New System.Drawing.Size(19, 18)
        Me.DeltaTTickImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DeltaTTickImage.TabIndex = 335
        Me.DeltaTTickImage.TabStop = False
        Me.DeltaTTickImage.Visible = False
        '
        'InletTickImage
        '
        Me.InletTickImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.GreenTick
        Me.InletTickImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InletTickImage.Location = New System.Drawing.Point(105, 41)
        Me.InletTickImage.Name = "InletTickImage"
        Me.InletTickImage.Size = New System.Drawing.Size(19, 18)
        Me.InletTickImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.InletTickImage.TabIndex = 334
        Me.InletTickImage.TabStop = False
        Me.InletTickImage.Visible = False
        '
        'MoistureTickImage
        '
        Me.MoistureTickImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.GreenTick
        Me.MoistureTickImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MoistureTickImage.Location = New System.Drawing.Point(105, 17)
        Me.MoistureTickImage.Name = "MoistureTickImage"
        Me.MoistureTickImage.Size = New System.Drawing.Size(19, 18)
        Me.MoistureTickImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MoistureTickImage.TabIndex = 330
        Me.MoistureTickImage.TabStop = False
        Me.MoistureTickImage.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(14, 96)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(73, 13)
        Me.Label30.TabIndex = 333
        Me.Label30.Text = "Master Speed"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(14, 71)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(42, 13)
        Me.Label26.TabIndex = 332
        Me.Label26.Text = "Delta T"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(14, 45)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(57, 13)
        Me.Label25.TabIndex = 331
        Me.Label25.Text = "Inlet Temp"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(14, 20)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(47, 13)
        Me.Label24.TabIndex = 330
        Me.Label24.Text = "Moisture"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SpeedLabel)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.Button12)
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Location = New System.Drawing.Point(178, 265)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(103, 122)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Simulation Speed"
        '
        'SpeedLabel
        '
        Me.SpeedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SpeedLabel.Location = New System.Drawing.Point(10, 91)
        Me.SpeedLabel.Name = "SpeedLabel"
        Me.SpeedLabel.Size = New System.Drawing.Size(83, 23)
        Me.SpeedLabel.TabIndex = 329
        Me.SpeedLabel.Text = "X1"
        Me.SpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button10.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button10.Location = New System.Drawing.Point(13, 65)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(76, 22)
        Me.Button10.TabIndex = 97
        Me.Button10.Text = "PAUSE"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button12.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button12.Location = New System.Drawing.Point(13, 20)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(76, 22)
        Me.Button12.TabIndex = 99
        Me.Button12.Text = "FAST"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button11.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button11.Location = New System.Drawing.Point(13, 43)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(76, 22)
        Me.Button11.TabIndex = 98
        Me.Button11.Text = "NORMAL"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BurnerResetButton)
        Me.GroupBox3.Controls.Add(Me.BurnerStopButton)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.LowOilPressureFaultOff)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Controls.Add(Me.Label38)
        Me.GroupBox3.Controls.Add(Me.Label39)
        Me.GroupBox3.Controls.Add(Me.Label40)
        Me.GroupBox3.Controls.Add(Me.Label41)
        Me.GroupBox3.Controls.Add(Me.PictureBox26)
        Me.GroupBox3.Controls.Add(Me.PictureBox27)
        Me.GroupBox3.Controls.Add(Me.PictureBox28)
        Me.GroupBox3.Controls.Add(Me.PictureBox29)
        Me.GroupBox3.Controls.Add(Me.PictureBox31)
        Me.GroupBox3.Controls.Add(Me.PictureBox32)
        Me.GroupBox3.Controls.Add(Me.PictureBox33)
        Me.GroupBox3.Controls.Add(Me.FryerTempFaultOff)
        Me.GroupBox3.Controls.Add(Me.BurnerFaultOff)
        Me.GroupBox3.Controls.Add(Me.BCBBurnerOffLight)
        Me.GroupBox3.Controls.Add(Me.BurnerFaultOn)
        Me.GroupBox3.Controls.Add(Me.FryerTempFaultOn)
        Me.GroupBox3.Controls.Add(Me.LowOilPressureFaultOn)
        Me.GroupBox3.Controls.Add(Me.BCBBurnerOnLight)
        Me.GroupBox3.Controls.Add(Me.BCBStartButtonOn)
        Me.GroupBox3.Controls.Add(Me.BCBBurnerStartButtonOff)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 485)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(356, 184)
        Me.GroupBox3.TabIndex = 328
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Burner Controls"
        '
        'BurnerResetButton
        '
        Me.BurnerResetButton.BackgroundImage = Global.PC42VB.My.Resources.Resources._3D_button
        Me.BurnerResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BurnerResetButton.Location = New System.Drawing.Point(285, 57)
        Me.BurnerResetButton.Name = "BurnerResetButton"
        Me.BurnerResetButton.Size = New System.Drawing.Size(39, 33)
        Me.BurnerResetButton.TabIndex = 0
        Me.BurnerResetButton.TabStop = False
        '
        'BurnerStopButton
        '
        Me.BurnerStopButton.BackgroundImage = Global.PC42VB.My.Resources.Resources._3D_button
        Me.BurnerStopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BurnerStopButton.Location = New System.Drawing.Point(246, 138)
        Me.BurnerStopButton.Name = "BurnerStopButton"
        Me.BurnerStopButton.Size = New System.Drawing.Size(39, 33)
        Me.BurnerStopButton.TabIndex = 1
        Me.BurnerStopButton.TabStop = False
        '
        'Label27
        '
        Me.Label27.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label27.Location = New System.Drawing.Point(291, 105)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(44, 28)
        Me.Label27.TabIndex = 340
        Me.Label27.Text = "Burner On"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label28.Location = New System.Drawing.Point(245, 103)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(48, 33)
        Me.Label28.TabIndex = 339
        Me.Label28.Text = "Burner Stop"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label29.Location = New System.Drawing.Point(187, 103)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(48, 33)
        Me.Label29.TabIndex = 338
        Me.Label29.Text = "Cooling Air Fan"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label31.Location = New System.Drawing.Point(144, 103)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(48, 33)
        Me.Label31.TabIndex = 337
        Me.Label31.Text = "Pollution Fan Drive"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label32.Location = New System.Drawing.Point(101, 103)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(48, 33)
        Me.Label32.TabIndex = 336
        Me.Label32.Text = "Low Gas Pressure"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label33.Location = New System.Drawing.Point(58, 101)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(48, 33)
        Me.Label33.TabIndex = 335
        Me.Label33.Text = "HX Stack Temp"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label34.Location = New System.Drawing.Point(18, 99)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(48, 33)
        Me.Label34.TabIndex = 334
        Me.Label34.Text = "Fryer Oil Low PSI"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label35.Location = New System.Drawing.Point(288, 22)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(48, 33)
        Me.Label35.TabIndex = 333
        Me.Label35.Text = "Burner Reset"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LowOilPressureFaultOff
        '
        Me.LowOilPressureFaultOff.BackgroundImage = Global.PC42VB.My.Resources.Resources.RedButtonNotLit
        Me.LowOilPressureFaultOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LowOilPressureFaultOff.InitialImage = Nothing
        Me.LowOilPressureFaultOff.Location = New System.Drawing.Point(18, 135)
        Me.LowOilPressureFaultOff.Name = "LowOilPressureFaultOff"
        Me.LowOilPressureFaultOff.Size = New System.Drawing.Size(37, 36)
        Me.LowOilPressureFaultOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LowOilPressureFaultOff.TabIndex = 345
        Me.LowOilPressureFaultOff.TabStop = False
        '
        'Label36
        '
        Me.Label36.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label36.Location = New System.Drawing.Point(245, 22)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(48, 33)
        Me.Label36.TabIndex = 332
        Me.Label36.Text = "Burner Start"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label37.Location = New System.Drawing.Point(187, 22)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(48, 33)
        Me.Label37.TabIndex = 331
        Me.Label37.Text = "Combust Intake"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label38
        '
        Me.Label38.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label38.Location = New System.Drawing.Point(144, 22)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(48, 33)
        Me.Label38.TabIndex = 330
        Me.Label38.Text = "Mix Chamber "
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label39
        '
        Me.Label39.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label39.Location = New System.Drawing.Point(101, 22)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(48, 33)
        Me.Label39.TabIndex = 329
        Me.Label39.Text = "Hi Gas Pressure"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label40
        '
        Me.Label40.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label40.Location = New System.Drawing.Point(58, 22)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(48, 33)
        Me.Label40.TabIndex = 328
        Me.Label40.Text = "Fryer Temp"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label41
        '
        Me.Label41.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label41.Location = New System.Drawing.Point(18, 22)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(48, 33)
        Me.Label41.TabIndex = 327
        Me.Label41.Text = "Burner Fault"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox26
        '
        Me.PictureBox26.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox26.BackgroundImage = Global.PC42VB.My.Resources.Resources.RedButtonNotLit
        Me.PictureBox26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox26.InitialImage = Nothing
        Me.PictureBox26.Location = New System.Drawing.Point(187, 135)
        Me.PictureBox26.Name = "PictureBox26"
        Me.PictureBox26.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox26.TabIndex = 349
        Me.PictureBox26.TabStop = False
        '
        'PictureBox27
        '
        Me.PictureBox27.BackgroundImage = Global.PC42VB.My.Resources.Resources.RedButtonNotLit
        Me.PictureBox27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox27.InitialImage = Nothing
        Me.PictureBox27.Location = New System.Drawing.Point(144, 135)
        Me.PictureBox27.Name = "PictureBox27"
        Me.PictureBox27.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox27.TabIndex = 348
        Me.PictureBox27.TabStop = False
        '
        'PictureBox28
        '
        Me.PictureBox28.BackgroundImage = Global.PC42VB.My.Resources.Resources.RedButtonNotLit
        Me.PictureBox28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox28.InitialImage = Nothing
        Me.PictureBox28.Location = New System.Drawing.Point(101, 135)
        Me.PictureBox28.Name = "PictureBox28"
        Me.PictureBox28.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox28.TabIndex = 347
        Me.PictureBox28.TabStop = False
        '
        'PictureBox29
        '
        Me.PictureBox29.BackgroundImage = Global.PC42VB.My.Resources.Resources.RedButtonNotLit
        Me.PictureBox29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox29.InitialImage = Nothing
        Me.PictureBox29.Location = New System.Drawing.Point(58, 135)
        Me.PictureBox29.Name = "PictureBox29"
        Me.PictureBox29.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox29.TabIndex = 346
        Me.PictureBox29.TabStop = False
        '
        'PictureBox31
        '
        Me.PictureBox31.BackgroundImage = Global.PC42VB.My.Resources.Resources.RedButtonNotLit
        Me.PictureBox31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox31.InitialImage = Nothing
        Me.PictureBox31.Location = New System.Drawing.Point(187, 58)
        Me.PictureBox31.Name = "PictureBox31"
        Me.PictureBox31.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox31.TabIndex = 344
        Me.PictureBox31.TabStop = False
        '
        'PictureBox32
        '
        Me.PictureBox32.BackgroundImage = Global.PC42VB.My.Resources.Resources.RedButtonNotLit
        Me.PictureBox32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox32.InitialImage = Nothing
        Me.PictureBox32.Location = New System.Drawing.Point(144, 59)
        Me.PictureBox32.Name = "PictureBox32"
        Me.PictureBox32.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox32.TabIndex = 343
        Me.PictureBox32.TabStop = False
        '
        'PictureBox33
        '
        Me.PictureBox33.BackgroundImage = Global.PC42VB.My.Resources.Resources.RedButtonNotLit
        Me.PictureBox33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox33.InitialImage = Nothing
        Me.PictureBox33.Location = New System.Drawing.Point(101, 58)
        Me.PictureBox33.Name = "PictureBox33"
        Me.PictureBox33.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox33.TabIndex = 342
        Me.PictureBox33.TabStop = False
        '
        'FryerTempFaultOff
        '
        Me.FryerTempFaultOff.BackgroundImage = Global.PC42VB.My.Resources.Resources.RedButtonNotLit
        Me.FryerTempFaultOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FryerTempFaultOff.InitialImage = Nothing
        Me.FryerTempFaultOff.Location = New System.Drawing.Point(57, 57)
        Me.FryerTempFaultOff.Name = "FryerTempFaultOff"
        Me.FryerTempFaultOff.Size = New System.Drawing.Size(37, 36)
        Me.FryerTempFaultOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FryerTempFaultOff.TabIndex = 341
        Me.FryerTempFaultOff.TabStop = False
        '
        'BurnerFaultOff
        '
        Me.BurnerFaultOff.BackgroundImage = Global.PC42VB.My.Resources.Resources.RedButtonNotLit
        Me.BurnerFaultOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BurnerFaultOff.InitialImage = Nothing
        Me.BurnerFaultOff.Location = New System.Drawing.Point(18, 57)
        Me.BurnerFaultOff.Name = "BurnerFaultOff"
        Me.BurnerFaultOff.Size = New System.Drawing.Size(37, 36)
        Me.BurnerFaultOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BurnerFaultOff.TabIndex = 326
        Me.BurnerFaultOff.TabStop = False
        '
        'BCBBurnerOffLight
        '
        Me.BCBBurnerOffLight.BackgroundImage = Global.PC42VB.My.Resources.Resources.RedButtonNotLit
        Me.BCBBurnerOffLight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCBBurnerOffLight.InitialImage = Nothing
        Me.BCBBurnerOffLight.Location = New System.Drawing.Point(288, 135)
        Me.BCBBurnerOffLight.Name = "BCBBurnerOffLight"
        Me.BCBBurnerOffLight.Size = New System.Drawing.Size(37, 36)
        Me.BCBBurnerOffLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BCBBurnerOffLight.TabIndex = 353
        Me.BCBBurnerOffLight.TabStop = False
        '
        'BurnerFaultOn
        '
        Me.BurnerFaultOn.BackgroundImage = Global.PC42VB.My.Resources.Resources.RedLitButton
        Me.BurnerFaultOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BurnerFaultOn.InitialImage = Nothing
        Me.BurnerFaultOn.Location = New System.Drawing.Point(18, 58)
        Me.BurnerFaultOn.Name = "BurnerFaultOn"
        Me.BurnerFaultOn.Size = New System.Drawing.Size(40, 36)
        Me.BurnerFaultOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BurnerFaultOn.TabIndex = 356
        Me.BurnerFaultOn.TabStop = False
        Me.BurnerFaultOn.Visible = False
        '
        'FryerTempFaultOn
        '
        Me.FryerTempFaultOn.BackgroundImage = Global.PC42VB.My.Resources.Resources.RedLitButton
        Me.FryerTempFaultOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FryerTempFaultOn.InitialImage = Nothing
        Me.FryerTempFaultOn.Location = New System.Drawing.Point(58, 58)
        Me.FryerTempFaultOn.Name = "FryerTempFaultOn"
        Me.FryerTempFaultOn.Size = New System.Drawing.Size(40, 36)
        Me.FryerTempFaultOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FryerTempFaultOn.TabIndex = 358
        Me.FryerTempFaultOn.TabStop = False
        Me.FryerTempFaultOn.Visible = False
        '
        'LowOilPressureFaultOn
        '
        Me.LowOilPressureFaultOn.BackgroundImage = Global.PC42VB.My.Resources.Resources.RedLitButton
        Me.LowOilPressureFaultOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LowOilPressureFaultOn.InitialImage = Nothing
        Me.LowOilPressureFaultOn.Location = New System.Drawing.Point(18, 135)
        Me.LowOilPressureFaultOn.Name = "LowOilPressureFaultOn"
        Me.LowOilPressureFaultOn.Size = New System.Drawing.Size(40, 36)
        Me.LowOilPressureFaultOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LowOilPressureFaultOn.TabIndex = 357
        Me.LowOilPressureFaultOn.TabStop = False
        Me.LowOilPressureFaultOn.Visible = False
        '
        'BCBBurnerOnLight
        '
        Me.BCBBurnerOnLight.BackgroundImage = Global.PC42VB.My.Resources.Resources.RedLitButton
        Me.BCBBurnerOnLight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCBBurnerOnLight.Location = New System.Drawing.Point(288, 135)
        Me.BCBBurnerOnLight.Name = "BCBBurnerOnLight"
        Me.BCBBurnerOnLight.Size = New System.Drawing.Size(40, 36)
        Me.BCBBurnerOnLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BCBBurnerOnLight.TabIndex = 354
        Me.BCBBurnerOnLight.TabStop = False
        Me.BCBBurnerOnLight.Visible = False
        '
        'BCBStartButtonOn
        '
        Me.BCBStartButtonOn.BackColor = System.Drawing.Color.Transparent
        Me.BCBStartButtonOn.BackgroundImage = Global.PC42VB.My.Resources.Resources.GreenLitButton
        Me.BCBStartButtonOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCBStartButtonOn.Location = New System.Drawing.Point(247, 57)
        Me.BCBStartButtonOn.Name = "BCBStartButtonOn"
        Me.BCBStartButtonOn.Size = New System.Drawing.Size(38, 33)
        Me.BCBStartButtonOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BCBStartButtonOn.TabIndex = 355
        Me.BCBStartButtonOn.TabStop = False
        Me.BCBStartButtonOn.Visible = False
        '
        'BCBBurnerStartButtonOff
        '
        Me.BCBBurnerStartButtonOff.BackgroundImage = Global.PC42VB.My.Resources.Resources.GreenUnlitButton
        Me.BCBBurnerStartButtonOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCBBurnerStartButtonOff.Location = New System.Drawing.Point(247, 57)
        Me.BCBBurnerStartButtonOff.Name = "BCBBurnerStartButtonOff"
        Me.BCBBurnerStartButtonOff.Size = New System.Drawing.Size(38, 33)
        Me.BCBBurnerStartButtonOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BCBBurnerStartButtonOff.TabIndex = 352
        Me.BCBBurnerStartButtonOff.TabStop = False
        '
        'SkipStartup
        '
        Me.SkipStartup.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SkipStartup.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.SkipStartup.ForeColor = System.Drawing.Color.DarkBlue
        Me.SkipStartup.Location = New System.Drawing.Point(129, 450)
        Me.SkipStartup.Name = "SkipStartup"
        Me.SkipStartup.Size = New System.Drawing.Size(121, 23)
        Me.SkipStartup.TabIndex = 327
        Me.SkipStartup.Text = "SKIP TIMER "
        Me.SkipStartup.UseVisualStyleBackColor = False
        Me.SkipStartup.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(301, 265)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(57, 124)
        Me.GroupBox2.TabIndex = 101
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SG"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"1.100", "1.099", "1.090", "1.080", "1.070"})
        Me.ListBox1.Location = New System.Drawing.Point(7, 20)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(43, 95)
        Me.ListBox1.TabIndex = 60
        '
        'OnImage1
        '
        Me.OnImage1.BackColor = System.Drawing.Color.Transparent
        Me.OnImage1.BackgroundImage = Global.PC42VB.My.Resources.Resources.Fryer_Off
        Me.OnImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OnImage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OnImage1.Location = New System.Drawing.Point(16, 9)
        Me.OnImage1.Name = "OnImage1"
        Me.OnImage1.Size = New System.Drawing.Size(341, 95)
        Me.OnImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OnImage1.TabIndex = 56
        Me.OnImage1.TabStop = False
        '
        'BurnerInfoText
        '
        Me.BurnerInfoText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BurnerInfoText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BurnerInfoText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BurnerInfoText.Location = New System.Drawing.Point(16, 401)
        Me.BurnerInfoText.Name = "BurnerInfoText"
        Me.BurnerInfoText.Size = New System.Drawing.Size(342, 75)
        Me.BurnerInfoText.TabIndex = 32
        Me.BurnerInfoText.Text = "PC 42 Fryer Simulation"
        Me.BurnerInfoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmptyFryer1Pic
        '
        Me.EmptyFryer1Pic.BackColor = System.Drawing.Color.Transparent
        Me.EmptyFryer1Pic.BackgroundImage = Global.PC42VB.My.Resources.Resources.Empty_Fryer_2_Grey
        Me.EmptyFryer1Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EmptyFryer1Pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EmptyFryer1Pic.Location = New System.Drawing.Point(16, 109)
        Me.EmptyFryer1Pic.Name = "EmptyFryer1Pic"
        Me.EmptyFryer1Pic.Size = New System.Drawing.Size(342, 147)
        Me.EmptyFryer1Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EmptyFryer1Pic.TabIndex = 102
        Me.EmptyFryer1Pic.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TabPage3.Controls.Add(Me.GroupBox9)
        Me.TabPage3.Controls.Add(Me.GroupBox8)
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(381, 706)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Fryer Variables"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label53)
        Me.GroupBox9.Controls.Add(Me.InfeedVariancePlus)
        Me.GroupBox9.Controls.Add(Me.Label14)
        Me.GroupBox9.Controls.Add(Me.InfeedVarianceMinus)
        Me.GroupBox9.Controls.Add(Me.InfeedVarianceText)
        Me.GroupBox9.Controls.Add(Me.InfeedVarianceOn)
        Me.GroupBox9.Controls.Add(Me.InfeedVarianceOff)
        Me.GroupBox9.Location = New System.Drawing.Point(10, 74)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(360, 55)
        Me.GroupBox9.TabIndex = 4
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Misc"
        '
        'Label53
        '
        Me.Label53.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label53.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label53.Location = New System.Drawing.Point(210, 19)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(136, 22)
        Me.Label53.TabIndex = 123
        Me.Label53.Text = "Variable Potato Mass"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InfeedVariancePlus
        '
        Me.InfeedVariancePlus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.InfeedVariancePlus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.InfeedVariancePlus.Location = New System.Drawing.Point(172, 19)
        Me.InfeedVariancePlus.Name = "InfeedVariancePlus"
        Me.InfeedVariancePlus.Size = New System.Drawing.Size(24, 23)
        Me.InfeedVariancePlus.TabIndex = 122
        Me.InfeedVariancePlus.Text = "+"
        Me.InfeedVariancePlus.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(11, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 19)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "INFEED"
        '
        'InfeedVarianceMinus
        '
        Me.InfeedVarianceMinus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.InfeedVarianceMinus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.InfeedVarianceMinus.Location = New System.Drawing.Point(111, 18)
        Me.InfeedVarianceMinus.Name = "InfeedVarianceMinus"
        Me.InfeedVarianceMinus.Size = New System.Drawing.Size(24, 23)
        Me.InfeedVarianceMinus.TabIndex = 117
        Me.InfeedVarianceMinus.Text = "-"
        Me.InfeedVarianceMinus.UseVisualStyleBackColor = False
        '
        'InfeedVarianceText
        '
        Me.InfeedVarianceText.BackColor = System.Drawing.SystemColors.MenuText
        Me.InfeedVarianceText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfeedVarianceText.ForeColor = System.Drawing.Color.Yellow
        Me.InfeedVarianceText.Location = New System.Drawing.Point(136, 20)
        Me.InfeedVarianceText.Name = "InfeedVarianceText"
        Me.InfeedVarianceText.Size = New System.Drawing.Size(35, 20)
        Me.InfeedVarianceText.TabIndex = 118
        Me.InfeedVarianceText.Text = "8"
        Me.InfeedVarianceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InfeedVarianceText.WordWrap = False
        '
        'InfeedVarianceOn
        '
        Me.InfeedVarianceOn.BackgroundImage = Global.PC42VB.My.Resources.Resources.On_Button_Slider
        Me.InfeedVarianceOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InfeedVarianceOn.Location = New System.Drawing.Point(59, 18)
        Me.InfeedVarianceOn.Name = "InfeedVarianceOn"
        Me.InfeedVarianceOn.Size = New System.Drawing.Size(46, 21)
        Me.InfeedVarianceOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.InfeedVarianceOn.TabIndex = 119
        Me.InfeedVarianceOn.TabStop = False
        '
        'InfeedVarianceOff
        '
        Me.InfeedVarianceOff.BackgroundImage = Global.PC42VB.My.Resources.Resources.Off_Button_Slider
        Me.InfeedVarianceOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InfeedVarianceOff.Location = New System.Drawing.Point(59, 18)
        Me.InfeedVarianceOff.Name = "InfeedVarianceOff"
        Me.InfeedVarianceOff.Size = New System.Drawing.Size(46, 21)
        Me.InfeedVarianceOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.InfeedVarianceOff.TabIndex = 120
        Me.InfeedVarianceOff.TabStop = False
        Me.InfeedVarianceOff.Visible = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label58)
        Me.GroupBox8.Controls.Add(Me.Label51)
        Me.GroupBox8.Controls.Add(Me.Label52)
        Me.GroupBox8.Controls.Add(Me.WoQMSXSettingHighText)
        Me.GroupBox8.Controls.Add(Me.WoQDeltaXSettingHighText)
        Me.GroupBox8.Controls.Add(Me.WoQInletXSettingHighText)
        Me.GroupBox8.Controls.Add(Me.WoQMoistureXSettingHighText)
        Me.GroupBox8.Controls.Add(Me.WoQMSXSettingLowText)
        Me.GroupBox8.Controls.Add(Me.WoQDeltaXSettingLowText)
        Me.GroupBox8.Controls.Add(Me.WoQInletXSettingLowText)
        Me.GroupBox8.Controls.Add(Me.WoQMoistureXSettingLowText)
        Me.GroupBox8.Controls.Add(Me.Label49)
        Me.GroupBox8.Controls.Add(Me.Label50)
        Me.GroupBox8.Controls.Add(Me.WoQMSExclSettingHighText)
        Me.GroupBox8.Controls.Add(Me.WoQDeltaExclSettingHighText)
        Me.GroupBox8.Controls.Add(Me.WoQInletExclSettingHighText)
        Me.GroupBox8.Controls.Add(Me.WoQMoistureExclSettingHighText)
        Me.GroupBox8.Controls.Add(Me.WoQMSExclSettingLowText)
        Me.GroupBox8.Controls.Add(Me.WoQDeltaExclSettingLowText)
        Me.GroupBox8.Controls.Add(Me.WoQInletExclSettingLowText)
        Me.GroupBox8.Controls.Add(Me.WoQMoistureExclSettingLowText)
        Me.GroupBox8.Controls.Add(Me.Label48)
        Me.GroupBox8.Controls.Add(Me.Label47)
        Me.GroupBox8.Controls.Add(Me.WoQMSTickLowSettingHighText)
        Me.GroupBox8.Controls.Add(Me.WoQDeltaTTickSettingHighText)
        Me.GroupBox8.Controls.Add(Me.WoQInletTickSettingHighText)
        Me.GroupBox8.Controls.Add(Me.WoQMoistureTickSettingHighText)
        Me.GroupBox8.Controls.Add(Me.WoQMSTickLowSettingLowText)
        Me.GroupBox8.Controls.Add(Me.WoQDeltaTTickSettingLowText)
        Me.GroupBox8.Controls.Add(Me.WoQInletTickSettingLowText)
        Me.GroupBox8.Controls.Add(Me.WoQMoistureTickSettingLowText)
        Me.GroupBox8.Controls.Add(Me.Label43)
        Me.GroupBox8.Controls.Add(Me.Label44)
        Me.GroupBox8.Controls.Add(Me.Label45)
        Me.GroupBox8.Controls.Add(Me.Label46)
        Me.GroupBox8.Controls.Add(Me.RelRadioButton)
        Me.GroupBox8.Controls.Add(Me.QABF101RadioButton)
        Me.GroupBox8.Controls.Add(Me.PictureBox8)
        Me.GroupBox8.Controls.Add(Me.Label42)
        Me.GroupBox8.Controls.Add(Me.PictureBox14)
        Me.GroupBox8.Controls.Add(Me.PictureBox11)
        Me.GroupBox8.Location = New System.Drawing.Point(11, 140)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(360, 254)
        Me.GroupBox8.TabIndex = 3
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "WoQ Settings"
        '
        'Label58
        '
        Me.Label58.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label58.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label58.Location = New System.Drawing.Point(6, 204)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(348, 43)
        Me.Label58.TabIndex = 392
        Me.Label58.Text = resources.GetString("Label58.Text")
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label51
        '
        Me.Label51.ForeColor = System.Drawing.Color.Red
        Me.Label51.Location = New System.Drawing.Point(317, 60)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(34, 14)
        Me.Label51.TabIndex = 391
        Me.Label51.Text = "MAX"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.ForeColor = System.Drawing.Color.Red
        Me.Label52.Location = New System.Drawing.Point(278, 60)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(34, 14)
        Me.Label52.TabIndex = 390
        Me.Label52.Text = "MIN"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WoQMSXSettingHighText
        '
        Me.WoQMSXSettingHighText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQMSXSettingHighText.ForeColor = System.Drawing.Color.Red
        Me.WoQMSXSettingHighText.Location = New System.Drawing.Point(319, 177)
        Me.WoQMSXSettingHighText.Name = "WoQMSXSettingHighText"
        Me.WoQMSXSettingHighText.Size = New System.Drawing.Size(34, 20)
        Me.WoQMSXSettingHighText.TabIndex = 389
        Me.WoQMSXSettingHighText.Text = "-"
        Me.WoQMSXSettingHighText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WoQDeltaXSettingHighText
        '
        Me.WoQDeltaXSettingHighText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQDeltaXSettingHighText.ForeColor = System.Drawing.Color.Red
        Me.WoQDeltaXSettingHighText.Location = New System.Drawing.Point(319, 146)
        Me.WoQDeltaXSettingHighText.Name = "WoQDeltaXSettingHighText"
        Me.WoQDeltaXSettingHighText.Size = New System.Drawing.Size(34, 20)
        Me.WoQDeltaXSettingHighText.TabIndex = 388
        Me.WoQDeltaXSettingHighText.Text = "-"
        Me.WoQDeltaXSettingHighText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WoQInletXSettingHighText
        '
        Me.WoQInletXSettingHighText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQInletXSettingHighText.ForeColor = System.Drawing.Color.Red
        Me.WoQInletXSettingHighText.Location = New System.Drawing.Point(319, 116)
        Me.WoQInletXSettingHighText.Name = "WoQInletXSettingHighText"
        Me.WoQInletXSettingHighText.Size = New System.Drawing.Size(34, 20)
        Me.WoQInletXSettingHighText.TabIndex = 387
        Me.WoQInletXSettingHighText.Text = "181"
        Me.WoQInletXSettingHighText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WoQMoistureXSettingHighText
        '
        Me.WoQMoistureXSettingHighText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQMoistureXSettingHighText.ForeColor = System.Drawing.Color.Red
        Me.WoQMoistureXSettingHighText.Location = New System.Drawing.Point(318, 86)
        Me.WoQMoistureXSettingHighText.Name = "WoQMoistureXSettingHighText"
        Me.WoQMoistureXSettingHighText.Size = New System.Drawing.Size(34, 20)
        Me.WoQMoistureXSettingHighText.TabIndex = 386
        Me.WoQMoistureXSettingHighText.Text = "1.66"
        Me.WoQMoistureXSettingHighText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WoQMSXSettingLowText
        '
        Me.WoQMSXSettingLowText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQMSXSettingLowText.ForeColor = System.Drawing.Color.Red
        Me.WoQMSXSettingLowText.Location = New System.Drawing.Point(280, 177)
        Me.WoQMSXSettingLowText.Name = "WoQMSXSettingLowText"
        Me.WoQMSXSettingLowText.Size = New System.Drawing.Size(34, 20)
        Me.WoQMSXSettingLowText.TabIndex = 385
        Me.WoQMSXSettingLowText.Text = "-"
        Me.WoQMSXSettingLowText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WoQDeltaXSettingLowText
        '
        Me.WoQDeltaXSettingLowText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQDeltaXSettingLowText.ForeColor = System.Drawing.Color.Red
        Me.WoQDeltaXSettingLowText.Location = New System.Drawing.Point(280, 146)
        Me.WoQDeltaXSettingLowText.Name = "WoQDeltaXSettingLowText"
        Me.WoQDeltaXSettingLowText.Size = New System.Drawing.Size(34, 20)
        Me.WoQDeltaXSettingLowText.TabIndex = 384
        Me.WoQDeltaXSettingLowText.Text = "-"
        Me.WoQDeltaXSettingLowText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WoQInletXSettingLowText
        '
        Me.WoQInletXSettingLowText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQInletXSettingLowText.ForeColor = System.Drawing.Color.Red
        Me.WoQInletXSettingLowText.Location = New System.Drawing.Point(280, 116)
        Me.WoQInletXSettingLowText.Name = "WoQInletXSettingLowText"
        Me.WoQInletXSettingLowText.Size = New System.Drawing.Size(34, 20)
        Me.WoQInletXSettingLowText.TabIndex = 383
        Me.WoQInletXSettingLowText.Text = "175"
        Me.WoQInletXSettingLowText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WoQMoistureXSettingLowText
        '
        Me.WoQMoistureXSettingLowText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQMoistureXSettingLowText.ForeColor = System.Drawing.Color.Red
        Me.WoQMoistureXSettingLowText.Location = New System.Drawing.Point(279, 86)
        Me.WoQMoistureXSettingLowText.Name = "WoQMoistureXSettingLowText"
        Me.WoQMoistureXSettingLowText.Size = New System.Drawing.Size(34, 20)
        Me.WoQMoistureXSettingLowText.TabIndex = 382
        Me.WoQMoistureXSettingLowText.Text = "0.99"
        Me.WoQMoistureXSettingLowText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label49
        '
        Me.Label49.ForeColor = System.Drawing.Color.Yellow
        Me.Label49.Location = New System.Drawing.Point(226, 60)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(34, 14)
        Me.Label49.TabIndex = 381
        Me.Label49.Text = "MAX"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label50
        '
        Me.Label50.ForeColor = System.Drawing.Color.Yellow
        Me.Label50.Location = New System.Drawing.Point(187, 60)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(34, 14)
        Me.Label50.TabIndex = 380
        Me.Label50.Text = "MIN"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WoQMSExclSettingHighText
        '
        Me.WoQMSExclSettingHighText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQMSExclSettingHighText.ForeColor = System.Drawing.Color.Yellow
        Me.WoQMSExclSettingHighText.Location = New System.Drawing.Point(228, 177)
        Me.WoQMSExclSettingHighText.Name = "WoQMSExclSettingHighText"
        Me.WoQMSExclSettingHighText.Size = New System.Drawing.Size(34, 20)
        Me.WoQMSExclSettingHighText.TabIndex = 379
        Me.WoQMSExclSettingHighText.Text = "-"
        Me.WoQMSExclSettingHighText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WoQDeltaExclSettingHighText
        '
        Me.WoQDeltaExclSettingHighText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQDeltaExclSettingHighText.ForeColor = System.Drawing.Color.Yellow
        Me.WoQDeltaExclSettingHighText.Location = New System.Drawing.Point(228, 146)
        Me.WoQDeltaExclSettingHighText.Name = "WoQDeltaExclSettingHighText"
        Me.WoQDeltaExclSettingHighText.Size = New System.Drawing.Size(34, 20)
        Me.WoQDeltaExclSettingHighText.TabIndex = 378
        Me.WoQDeltaExclSettingHighText.Text = "-"
        Me.WoQDeltaExclSettingHighText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WoQInletExclSettingHighText
        '
        Me.WoQInletExclSettingHighText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQInletExclSettingHighText.ForeColor = System.Drawing.Color.Yellow
        Me.WoQInletExclSettingHighText.Location = New System.Drawing.Point(228, 116)
        Me.WoQInletExclSettingHighText.Name = "WoQInletExclSettingHighText"
        Me.WoQInletExclSettingHighText.Size = New System.Drawing.Size(34, 20)
        Me.WoQInletExclSettingHighText.TabIndex = 377
        Me.WoQInletExclSettingHighText.Text = "-"
        Me.WoQInletExclSettingHighText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WoQMoistureExclSettingHighText
        '
        Me.WoQMoistureExclSettingHighText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQMoistureExclSettingHighText.ForeColor = System.Drawing.Color.Yellow
        Me.WoQMoistureExclSettingHighText.Location = New System.Drawing.Point(227, 86)
        Me.WoQMoistureExclSettingHighText.Name = "WoQMoistureExclSettingHighText"
        Me.WoQMoistureExclSettingHighText.Size = New System.Drawing.Size(34, 20)
        Me.WoQMoistureExclSettingHighText.TabIndex = 376
        Me.WoQMoistureExclSettingHighText.Text = "1.65"
        Me.WoQMoistureExclSettingHighText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WoQMSExclSettingLowText
        '
        Me.WoQMSExclSettingLowText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQMSExclSettingLowText.ForeColor = System.Drawing.Color.Yellow
        Me.WoQMSExclSettingLowText.Location = New System.Drawing.Point(189, 177)
        Me.WoQMSExclSettingLowText.Name = "WoQMSExclSettingLowText"
        Me.WoQMSExclSettingLowText.Size = New System.Drawing.Size(34, 20)
        Me.WoQMSExclSettingLowText.TabIndex = 375
        Me.WoQMSExclSettingLowText.Text = "-"
        Me.WoQMSExclSettingLowText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WoQDeltaExclSettingLowText
        '
        Me.WoQDeltaExclSettingLowText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQDeltaExclSettingLowText.ForeColor = System.Drawing.Color.Yellow
        Me.WoQDeltaExclSettingLowText.Location = New System.Drawing.Point(189, 146)
        Me.WoQDeltaExclSettingLowText.Name = "WoQDeltaExclSettingLowText"
        Me.WoQDeltaExclSettingLowText.Size = New System.Drawing.Size(34, 20)
        Me.WoQDeltaExclSettingLowText.TabIndex = 374
        Me.WoQDeltaExclSettingLowText.Text = "-"
        Me.WoQDeltaExclSettingLowText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WoQInletExclSettingLowText
        '
        Me.WoQInletExclSettingLowText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQInletExclSettingLowText.ForeColor = System.Drawing.Color.Yellow
        Me.WoQInletExclSettingLowText.Location = New System.Drawing.Point(189, 116)
        Me.WoQInletExclSettingLowText.Name = "WoQInletExclSettingLowText"
        Me.WoQInletExclSettingLowText.Size = New System.Drawing.Size(34, 20)
        Me.WoQInletExclSettingLowText.TabIndex = 373
        Me.WoQInletExclSettingLowText.Text = "176"
        Me.WoQInletExclSettingLowText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WoQMoistureExclSettingLowText
        '
        Me.WoQMoistureExclSettingLowText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQMoistureExclSettingLowText.ForeColor = System.Drawing.Color.Yellow
        Me.WoQMoistureExclSettingLowText.Location = New System.Drawing.Point(188, 86)
        Me.WoQMoistureExclSettingLowText.Name = "WoQMoistureExclSettingLowText"
        Me.WoQMoistureExclSettingLowText.Size = New System.Drawing.Size(34, 20)
        Me.WoQMoistureExclSettingLowText.TabIndex = 372
        Me.WoQMoistureExclSettingLowText.Text = "1.00"
        Me.WoQMoistureExclSettingLowText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label48
        '
        Me.Label48.ForeColor = System.Drawing.Color.Green
        Me.Label48.Location = New System.Drawing.Point(138, 60)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(34, 14)
        Me.Label48.TabIndex = 371
        Me.Label48.Text = "MAX"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label47
        '
        Me.Label47.ForeColor = System.Drawing.Color.Green
        Me.Label47.Location = New System.Drawing.Point(99, 60)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(34, 14)
        Me.Label47.TabIndex = 370
        Me.Label47.Text = "MIN"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WoQMSTickLowSettingHighText
        '
        Me.WoQMSTickLowSettingHighText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQMSTickLowSettingHighText.ForeColor = System.Drawing.Color.LawnGreen
        Me.WoQMSTickLowSettingHighText.Location = New System.Drawing.Point(140, 176)
        Me.WoQMSTickLowSettingHighText.Name = "WoQMSTickLowSettingHighText"
        Me.WoQMSTickLowSettingHighText.Size = New System.Drawing.Size(34, 20)
        Me.WoQMSTickLowSettingHighText.TabIndex = 369
        Me.WoQMSTickLowSettingHighText.Text = "76"
        Me.WoQMSTickLowSettingHighText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WoQDeltaTTickSettingHighText
        '
        Me.WoQDeltaTTickSettingHighText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQDeltaTTickSettingHighText.ForeColor = System.Drawing.Color.LawnGreen
        Me.WoQDeltaTTickSettingHighText.Location = New System.Drawing.Point(140, 145)
        Me.WoQDeltaTTickSettingHighText.Name = "WoQDeltaTTickSettingHighText"
        Me.WoQDeltaTTickSettingHighText.Size = New System.Drawing.Size(34, 20)
        Me.WoQDeltaTTickSettingHighText.TabIndex = 368
        Me.WoQDeltaTTickSettingHighText.Text = "26"
        Me.WoQDeltaTTickSettingHighText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WoQInletTickSettingHighText
        '
        Me.WoQInletTickSettingHighText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQInletTickSettingHighText.ForeColor = System.Drawing.Color.LawnGreen
        Me.WoQInletTickSettingHighText.Location = New System.Drawing.Point(140, 115)
        Me.WoQInletTickSettingHighText.Name = "WoQInletTickSettingHighText"
        Me.WoQInletTickSettingHighText.Size = New System.Drawing.Size(34, 20)
        Me.WoQInletTickSettingHighText.TabIndex = 367
        Me.WoQInletTickSettingHighText.Text = "180"
        Me.WoQInletTickSettingHighText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WoQMoistureTickSettingHighText
        '
        Me.WoQMoistureTickSettingHighText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQMoistureTickSettingHighText.ForeColor = System.Drawing.Color.LawnGreen
        Me.WoQMoistureTickSettingHighText.Location = New System.Drawing.Point(139, 85)
        Me.WoQMoistureTickSettingHighText.Name = "WoQMoistureTickSettingHighText"
        Me.WoQMoistureTickSettingHighText.Size = New System.Drawing.Size(34, 20)
        Me.WoQMoistureTickSettingHighText.TabIndex = 366
        Me.WoQMoistureTickSettingHighText.Text = "1.55"
        Me.WoQMoistureTickSettingHighText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WoQMSTickLowSettingLowText
        '
        Me.WoQMSTickLowSettingLowText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQMSTickLowSettingLowText.ForeColor = System.Drawing.Color.LawnGreen
        Me.WoQMSTickLowSettingLowText.Location = New System.Drawing.Point(101, 176)
        Me.WoQMSTickLowSettingLowText.Name = "WoQMSTickLowSettingLowText"
        Me.WoQMSTickLowSettingLowText.Size = New System.Drawing.Size(34, 20)
        Me.WoQMSTickLowSettingLowText.TabIndex = 357
        Me.WoQMSTickLowSettingLowText.Text = "64"
        Me.WoQMSTickLowSettingLowText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WoQDeltaTTickSettingLowText
        '
        Me.WoQDeltaTTickSettingLowText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQDeltaTTickSettingLowText.ForeColor = System.Drawing.Color.LawnGreen
        Me.WoQDeltaTTickSettingLowText.Location = New System.Drawing.Point(101, 145)
        Me.WoQDeltaTTickSettingLowText.Name = "WoQDeltaTTickSettingLowText"
        Me.WoQDeltaTTickSettingLowText.Size = New System.Drawing.Size(34, 20)
        Me.WoQDeltaTTickSettingLowText.TabIndex = 356
        Me.WoQDeltaTTickSettingLowText.Text = "18"
        Me.WoQDeltaTTickSettingLowText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WoQInletTickSettingLowText
        '
        Me.WoQInletTickSettingLowText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQInletTickSettingLowText.ForeColor = System.Drawing.Color.LawnGreen
        Me.WoQInletTickSettingLowText.Location = New System.Drawing.Point(101, 115)
        Me.WoQInletTickSettingLowText.Name = "WoQInletTickSettingLowText"
        Me.WoQInletTickSettingLowText.Size = New System.Drawing.Size(34, 20)
        Me.WoQInletTickSettingLowText.TabIndex = 355
        Me.WoQInletTickSettingLowText.Text = "170"
        Me.WoQInletTickSettingLowText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WoQMoistureTickSettingLowText
        '
        Me.WoQMoistureTickSettingLowText.BackColor = System.Drawing.SystemColors.InfoText
        Me.WoQMoistureTickSettingLowText.ForeColor = System.Drawing.Color.LawnGreen
        Me.WoQMoistureTickSettingLowText.Location = New System.Drawing.Point(100, 85)
        Me.WoQMoistureTickSettingLowText.Name = "WoQMoistureTickSettingLowText"
        Me.WoQMoistureTickSettingLowText.Size = New System.Drawing.Size(34, 20)
        Me.WoQMoistureTickSettingLowText.TabIndex = 354
        Me.WoQMoistureTickSettingLowText.Text = "1.15"
        Me.WoQMoistureTickSettingLowText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(12, 179)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(73, 13)
        Me.Label43.TabIndex = 347
        Me.Label43.Text = "Master Speed"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(12, 149)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(42, 13)
        Me.Label44.TabIndex = 346
        Me.Label44.Text = "Delta T"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(12, 119)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(57, 13)
        Me.Label45.TabIndex = 345
        Me.Label45.Text = "Inlet Temp"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(12, 89)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(47, 13)
        Me.Label46.TabIndex = 343
        Me.Label46.Text = "Moisture"
        '
        'RelRadioButton
        '
        Me.RelRadioButton.AutoSize = True
        Me.RelRadioButton.Checked = True
        Me.RelRadioButton.Location = New System.Drawing.Point(7, 56)
        Me.RelRadioButton.Name = "RelRadioButton"
        Me.RelRadioButton.Size = New System.Drawing.Size(84, 17)
        Me.RelRadioButton.TabIndex = 7
        Me.RelRadioButton.TabStop = True
        Me.RelRadioButton.Text = "SIMPLIFIED"
        Me.RelRadioButton.UseVisualStyleBackColor = True
        '
        'QABF101RadioButton
        '
        Me.QABF101RadioButton.AutoSize = True
        Me.QABF101RadioButton.Location = New System.Drawing.Point(7, 27)
        Me.QABF101RadioButton.Name = "QABF101RadioButton"
        Me.QABF101RadioButton.Size = New System.Drawing.Size(74, 17)
        Me.QABF101RadioButton.TabIndex = 6
        Me.QABF101RadioButton.Text = "QAB-F101"
        Me.QABF101RadioButton.UseVisualStyleBackColor = True
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = Global.PC42VB.My.Resources.Resources.Red_Cross
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox8.Location = New System.Drawing.Point(301, 30)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 353
        Me.PictureBox8.TabStop = False
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(12, 32)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(0, 13)
        Me.Label42.TabIndex = 4
        '
        'PictureBox14
        '
        Me.PictureBox14.BackgroundImage = Global.PC42VB.My.Resources.Resources.GreenTick
        Me.PictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox14.Location = New System.Drawing.Point(125, 30)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 348
        Me.PictureBox14.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackgroundImage = Global.PC42VB.My.Resources.Resources.Yellow_Excl
        Me.PictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox11.Location = New System.Drawing.Point(214, 30)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 344
        Me.PictureBox11.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label56)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.DerivativePlus)
        Me.GroupBox6.Controls.Add(Me.DerivativeMinus)
        Me.GroupBox6.Controls.Add(Me.DerivativeText)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.IntegralPlus)
        Me.GroupBox6.Controls.Add(Me.IntegralMinus)
        Me.GroupBox6.Controls.Add(Me.IntegralText)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.ProportionalPlus)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.ProportionalMinus)
        Me.GroupBox6.Controls.Add(Me.ProportionalText)
        Me.GroupBox6.Location = New System.Drawing.Point(11, 408)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(355, 204)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "PID LOOP"
        '
        'Label56
        '
        Me.Label56.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label56.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label56.Location = New System.Drawing.Point(206, 79)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(136, 22)
        Me.Label56.TabIndex = 133
        Me.Label56.Text = "Loop Braking / Stability"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(206, 53)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(136, 22)
        Me.Label23.TabIndex = 132
        Me.Label23.Text = "Addition Force / Overshoot"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(206, 26)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(136, 22)
        Me.Label22.TabIndex = 131
        Me.Label22.Text = "Acceleration to Setpoint"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(6, 108)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(336, 88)
        Me.Label21.TabIndex = 130
        Me.Label21.Text = resources.GetString("Label21.Text")
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DerivativePlus
        '
        Me.DerivativePlus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.DerivativePlus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DerivativePlus.Location = New System.Drawing.Point(171, 79)
        Me.DerivativePlus.Name = "DerivativePlus"
        Me.DerivativePlus.Size = New System.Drawing.Size(24, 23)
        Me.DerivativePlus.TabIndex = 129
        Me.DerivativePlus.Text = "+"
        Me.DerivativePlus.UseVisualStyleBackColor = False
        '
        'DerivativeMinus
        '
        Me.DerivativeMinus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.DerivativeMinus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DerivativeMinus.Location = New System.Drawing.Point(110, 78)
        Me.DerivativeMinus.Name = "DerivativeMinus"
        Me.DerivativeMinus.Size = New System.Drawing.Size(24, 23)
        Me.DerivativeMinus.TabIndex = 127
        Me.DerivativeMinus.Text = "-"
        Me.DerivativeMinus.UseVisualStyleBackColor = False
        '
        'DerivativeText
        '
        Me.DerivativeText.BackColor = System.Drawing.SystemColors.MenuText
        Me.DerivativeText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DerivativeText.ForeColor = System.Drawing.Color.Yellow
        Me.DerivativeText.Location = New System.Drawing.Point(135, 80)
        Me.DerivativeText.Name = "DerivativeText"
        Me.DerivativeText.Size = New System.Drawing.Size(35, 20)
        Me.DerivativeText.TabIndex = 128
        Me.DerivativeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DerivativeText.WordWrap = False
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(9, 84)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(93, 16)
        Me.Label18.TabIndex = 126
        Me.Label18.Text = "DERIVATIVE"
        '
        'IntegralPlus
        '
        Me.IntegralPlus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.IntegralPlus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.IntegralPlus.Location = New System.Drawing.Point(171, 51)
        Me.IntegralPlus.Name = "IntegralPlus"
        Me.IntegralPlus.Size = New System.Drawing.Size(24, 23)
        Me.IntegralPlus.TabIndex = 125
        Me.IntegralPlus.Text = "+"
        Me.IntegralPlus.UseVisualStyleBackColor = False
        '
        'IntegralMinus
        '
        Me.IntegralMinus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.IntegralMinus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.IntegralMinus.Location = New System.Drawing.Point(110, 50)
        Me.IntegralMinus.Name = "IntegralMinus"
        Me.IntegralMinus.Size = New System.Drawing.Size(24, 23)
        Me.IntegralMinus.TabIndex = 123
        Me.IntegralMinus.Text = "-"
        Me.IntegralMinus.UseVisualStyleBackColor = False
        '
        'IntegralText
        '
        Me.IntegralText.BackColor = System.Drawing.SystemColors.MenuText
        Me.IntegralText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntegralText.ForeColor = System.Drawing.Color.Yellow
        Me.IntegralText.Location = New System.Drawing.Point(135, 52)
        Me.IntegralText.Name = "IntegralText"
        Me.IntegralText.Size = New System.Drawing.Size(35, 20)
        Me.IntegralText.TabIndex = 124
        Me.IntegralText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IntegralText.WordWrap = False
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 56)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(79, 16)
        Me.Label19.TabIndex = 122
        Me.Label19.Text = "INTEGRAL"
        '
        'ProportionalPlus
        '
        Me.ProportionalPlus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ProportionalPlus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ProportionalPlus.Location = New System.Drawing.Point(171, 26)
        Me.ProportionalPlus.Name = "ProportionalPlus"
        Me.ProportionalPlus.Size = New System.Drawing.Size(24, 23)
        Me.ProportionalPlus.TabIndex = 121
        Me.ProportionalPlus.Text = "+"
        Me.ProportionalPlus.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(9, 29)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(98, 19)
        Me.Label20.TabIndex = 120
        Me.Label20.Text = "PROPORTIONAL"
        '
        'ProportionalMinus
        '
        Me.ProportionalMinus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ProportionalMinus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ProportionalMinus.Location = New System.Drawing.Point(110, 25)
        Me.ProportionalMinus.Name = "ProportionalMinus"
        Me.ProportionalMinus.Size = New System.Drawing.Size(24, 23)
        Me.ProportionalMinus.TabIndex = 116
        Me.ProportionalMinus.Text = "-"
        Me.ProportionalMinus.UseVisualStyleBackColor = False
        '
        'ProportionalText
        '
        Me.ProportionalText.BackColor = System.Drawing.SystemColors.MenuText
        Me.ProportionalText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProportionalText.ForeColor = System.Drawing.Color.Yellow
        Me.ProportionalText.Location = New System.Drawing.Point(135, 27)
        Me.ProportionalText.Name = "ProportionalText"
        Me.ProportionalText.Size = New System.Drawing.Size(35, 20)
        Me.ProportionalText.TabIndex = 117
        Me.ProportionalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ProportionalText.WordWrap = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label57)
        Me.GroupBox5.Controls.Add(Me.AllOnSwitchON)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.AllOnSwitchOff)
        Me.GroupBox5.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(360, 55)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Fryer Controls"
        '
        'Label57
        '
        Me.Label57.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label57.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label57.Location = New System.Drawing.Point(124, 16)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(223, 30)
        Me.Label57.TabIndex = 119
        Me.Label57.Text = "Toggle On Off Supplementary Systems"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AllOnSwitchON
        '
        Me.AllOnSwitchON.BackgroundImage = Global.PC42VB.My.Resources.Resources.On_Button_Slider
        Me.AllOnSwitchON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AllOnSwitchON.Location = New System.Drawing.Point(59, 21)
        Me.AllOnSwitchON.Name = "AllOnSwitchON"
        Me.AllOnSwitchON.Size = New System.Drawing.Size(46, 21)
        Me.AllOnSwitchON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AllOnSwitchON.TabIndex = 109
        Me.AllOnSwitchON.TabStop = False
        Me.AllOnSwitchON.Visible = False
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(11, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 20)
        Me.Label17.TabIndex = 108
        Me.Label17.Text = "ON ALL"
        '
        'AllOnSwitchOff
        '
        Me.AllOnSwitchOff.BackgroundImage = Global.PC42VB.My.Resources.Resources.Off_Button_Slider
        Me.AllOnSwitchOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AllOnSwitchOff.Location = New System.Drawing.Point(59, 21)
        Me.AllOnSwitchOff.Name = "AllOnSwitchOff"
        Me.AllOnSwitchOff.Size = New System.Drawing.Size(46, 21)
        Me.AllOnSwitchOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AllOnSwitchOff.TabIndex = 107
        Me.AllOnSwitchOff.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(381, 706)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "Cook Variables"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.SlicerAdjustPlus)
        Me.GroupBox4.Controls.Add(Me.SlicerAdjustMinus)
        Me.GroupBox4.Controls.Add(Me.SlicerAdjustText)
        Me.GroupBox4.Controls.Add(Me.Label72)
        Me.GroupBox4.Controls.Add(Me.Label70)
        Me.GroupBox4.Controls.Add(Me.FryFactor2Plus)
        Me.GroupBox4.Controls.Add(Me.FryFactor2Minus)
        Me.GroupBox4.Controls.Add(Me.FryFactor2Text)
        Me.GroupBox4.Controls.Add(Me.Label71)
        Me.GroupBox4.Controls.Add(Me.Label68)
        Me.GroupBox4.Controls.Add(Me.FryFactorPlus)
        Me.GroupBox4.Controls.Add(Me.FryFactorMinus)
        Me.GroupBox4.Controls.Add(Me.FryFactorText)
        Me.GroupBox4.Controls.Add(Me.Label69)
        Me.GroupBox4.Controls.Add(Me.Label66)
        Me.GroupBox4.Controls.Add(Me.SlicerVariance2Plus)
        Me.GroupBox4.Controls.Add(Me.SlicerVariance2Minus)
        Me.GroupBox4.Controls.Add(Me.FryFactor3Text)
        Me.GroupBox4.Controls.Add(Me.Label67)
        Me.GroupBox4.Controls.Add(Me.Label64)
        Me.GroupBox4.Controls.Add(Me.SlicerVariancePlus)
        Me.GroupBox4.Controls.Add(Me.SlicerVarianceMinus)
        Me.GroupBox4.Controls.Add(Me.SlicerVarianceText)
        Me.GroupBox4.Controls.Add(Me.Label65)
        Me.GroupBox4.Controls.Add(Me.Label63)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.BulkMoisturePlus)
        Me.GroupBox4.Controls.Add(Me.BulkMoistureMinus)
        Me.GroupBox4.Controls.Add(Me.MoistureBulkText)
        Me.GroupBox4.Controls.Add(Me.Label59)
        Me.GroupBox4.Controls.Add(Me.Label61)
        Me.GroupBox4.Controls.Add(Me.SlicerRatioPlus)
        Me.GroupBox4.Controls.Add(Me.SlicerRatioMinus)
        Me.GroupBox4.Controls.Add(Me.SlicerRatioText)
        Me.GroupBox4.Controls.Add(Me.Label62)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.CCMasterSpeedPlus)
        Me.GroupBox4.Controls.Add(Me.CCMasterSpeedMinus)
        Me.GroupBox4.Controls.Add(Me.MasterSpeedRatioText)
        Me.GroupBox4.Controls.Add(Me.Label60)
        Me.GroupBox4.Controls.Add(Me.Label55)
        Me.GroupBox4.Controls.Add(Me.Label54)
        Me.GroupBox4.Controls.Add(Me.TempVariancePlus)
        Me.GroupBox4.Controls.Add(Me.TempVarianceMinus)
        Me.GroupBox4.Controls.Add(Me.TempVarianceText)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.MoistureVariancePlus)
        Me.GroupBox4.Controls.Add(Me.MoistureVarianceMinus)
        Me.GroupBox4.Controls.Add(Me.MoistureVarianceText)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(366, 390)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(216, 210)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 15)
        Me.Label11.TabIndex = 165
        Me.Label11.Text = "Addition Moist. Slicer"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(5, 210)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 15)
        Me.Label13.TabIndex = 164
        Me.Label13.Text = "Add. Slicer Reduct."
        '
        'SlicerAdjustPlus
        '
        Me.SlicerAdjustPlus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SlicerAdjustPlus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SlicerAdjustPlus.Location = New System.Drawing.Point(184, 207)
        Me.SlicerAdjustPlus.Name = "SlicerAdjustPlus"
        Me.SlicerAdjustPlus.Size = New System.Drawing.Size(25, 20)
        Me.SlicerAdjustPlus.TabIndex = 163
        Me.SlicerAdjustPlus.Text = "+"
        Me.SlicerAdjustPlus.UseVisualStyleBackColor = False
        '
        'SlicerAdjustMinus
        '
        Me.SlicerAdjustMinus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SlicerAdjustMinus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SlicerAdjustMinus.Location = New System.Drawing.Point(108, 207)
        Me.SlicerAdjustMinus.Name = "SlicerAdjustMinus"
        Me.SlicerAdjustMinus.Size = New System.Drawing.Size(25, 20)
        Me.SlicerAdjustMinus.TabIndex = 161
        Me.SlicerAdjustMinus.Text = "-"
        Me.SlicerAdjustMinus.UseVisualStyleBackColor = False
        '
        'SlicerAdjustText
        '
        Me.SlicerAdjustText.BackColor = System.Drawing.SystemColors.MenuText
        Me.SlicerAdjustText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlicerAdjustText.ForeColor = System.Drawing.Color.Yellow
        Me.SlicerAdjustText.Location = New System.Drawing.Point(133, 207)
        Me.SlicerAdjustText.Name = "SlicerAdjustText"
        Me.SlicerAdjustText.Size = New System.Drawing.Size(50, 20)
        Me.SlicerAdjustText.TabIndex = 162
        Me.SlicerAdjustText.Text = "0.97"
        Me.SlicerAdjustText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SlicerAdjustText.WordWrap = False
        '
        'Label72
        '
        Me.Label72.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(3, 20)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(352, 23)
        Me.Label72.TabIndex = 160
        Me.Label72.Text = "Dehydration"
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label70
        '
        Me.Label70.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label70.ForeColor = System.Drawing.Color.Black
        Me.Label70.Location = New System.Drawing.Point(216, 150)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(136, 15)
        Me.Label70.TabIndex = 159
        Me.Label70.Text = "Reduces large moisture spiking on temp. change"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FryFactor2Plus
        '
        Me.FryFactor2Plus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.FryFactor2Plus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.FryFactor2Plus.Location = New System.Drawing.Point(184, 147)
        Me.FryFactor2Plus.Name = "FryFactor2Plus"
        Me.FryFactor2Plus.Size = New System.Drawing.Size(25, 20)
        Me.FryFactor2Plus.TabIndex = 158
        Me.FryFactor2Plus.Text = "+"
        Me.FryFactor2Plus.UseVisualStyleBackColor = False
        '
        'FryFactor2Minus
        '
        Me.FryFactor2Minus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.FryFactor2Minus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.FryFactor2Minus.Location = New System.Drawing.Point(108, 147)
        Me.FryFactor2Minus.Name = "FryFactor2Minus"
        Me.FryFactor2Minus.Size = New System.Drawing.Size(25, 20)
        Me.FryFactor2Minus.TabIndex = 156
        Me.FryFactor2Minus.Text = "-"
        Me.FryFactor2Minus.UseVisualStyleBackColor = False
        '
        'FryFactor2Text
        '
        Me.FryFactor2Text.BackColor = System.Drawing.SystemColors.MenuText
        Me.FryFactor2Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FryFactor2Text.ForeColor = System.Drawing.Color.Yellow
        Me.FryFactor2Text.Location = New System.Drawing.Point(133, 147)
        Me.FryFactor2Text.Name = "FryFactor2Text"
        Me.FryFactor2Text.Size = New System.Drawing.Size(50, 20)
        Me.FryFactor2Text.TabIndex = 157
        Me.FryFactor2Text.Text = "0.460"
        Me.FryFactor2Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FryFactor2Text.WordWrap = False
        '
        'Label71
        '
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(5, 150)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(105, 15)
        Me.Label71.TabIndex = 155
        Me.Label71.Text = "Spike Damper"
        '
        'Label68
        '
        Me.Label68.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label68.ForeColor = System.Drawing.Color.Black
        Me.Label68.Location = New System.Drawing.Point(216, 120)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(136, 15)
        Me.Label68.TabIndex = 154
        Me.Label68.Text = "Large Change"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FryFactorPlus
        '
        Me.FryFactorPlus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.FryFactorPlus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.FryFactorPlus.Location = New System.Drawing.Point(184, 117)
        Me.FryFactorPlus.Name = "FryFactorPlus"
        Me.FryFactorPlus.Size = New System.Drawing.Size(25, 20)
        Me.FryFactorPlus.TabIndex = 153
        Me.FryFactorPlus.Text = "+"
        Me.FryFactorPlus.UseVisualStyleBackColor = False
        '
        'FryFactorMinus
        '
        Me.FryFactorMinus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.FryFactorMinus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.FryFactorMinus.Location = New System.Drawing.Point(108, 117)
        Me.FryFactorMinus.Name = "FryFactorMinus"
        Me.FryFactorMinus.Size = New System.Drawing.Size(25, 20)
        Me.FryFactorMinus.TabIndex = 151
        Me.FryFactorMinus.Text = "-"
        Me.FryFactorMinus.UseVisualStyleBackColor = False
        '
        'FryFactorText
        '
        Me.FryFactorText.BackColor = System.Drawing.SystemColors.MenuText
        Me.FryFactorText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FryFactorText.ForeColor = System.Drawing.Color.Yellow
        Me.FryFactorText.Location = New System.Drawing.Point(133, 117)
        Me.FryFactorText.Name = "FryFactorText"
        Me.FryFactorText.Size = New System.Drawing.Size(50, 20)
        Me.FryFactorText.TabIndex = 152
        Me.FryFactorText.Text = "0.00303"
        Me.FryFactorText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FryFactorText.WordWrap = False
        '
        'Label69
        '
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(5, 120)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(105, 15)
        Me.Label69.TabIndex = 150
        Me.Label69.Text = "Dehyration %"
        '
        'Label66
        '
        Me.Label66.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label66.ForeColor = System.Drawing.Color.Black
        Me.Label66.Location = New System.Drawing.Point(216, 360)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(136, 15)
        Me.Label66.TabIndex = 149
        Me.Label66.Text = "Speed of Temp. Change"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SlicerVariance2Plus
        '
        Me.SlicerVariance2Plus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SlicerVariance2Plus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SlicerVariance2Plus.Location = New System.Drawing.Point(183, 357)
        Me.SlicerVariance2Plus.Name = "SlicerVariance2Plus"
        Me.SlicerVariance2Plus.Size = New System.Drawing.Size(25, 20)
        Me.SlicerVariance2Plus.TabIndex = 148
        Me.SlicerVariance2Plus.Text = "+"
        Me.SlicerVariance2Plus.UseVisualStyleBackColor = False
        '
        'SlicerVariance2Minus
        '
        Me.SlicerVariance2Minus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SlicerVariance2Minus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SlicerVariance2Minus.Location = New System.Drawing.Point(108, 357)
        Me.SlicerVariance2Minus.Name = "SlicerVariance2Minus"
        Me.SlicerVariance2Minus.Size = New System.Drawing.Size(25, 20)
        Me.SlicerVariance2Minus.TabIndex = 146
        Me.SlicerVariance2Minus.Text = "-"
        Me.SlicerVariance2Minus.UseVisualStyleBackColor = False
        '
        'FryFactor3Text
        '
        Me.FryFactor3Text.BackColor = System.Drawing.SystemColors.MenuText
        Me.FryFactor3Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FryFactor3Text.ForeColor = System.Drawing.Color.Yellow
        Me.FryFactor3Text.Location = New System.Drawing.Point(133, 357)
        Me.FryFactor3Text.Name = "FryFactor3Text"
        Me.FryFactor3Text.Size = New System.Drawing.Size(50, 20)
        Me.FryFactor3Text.TabIndex = 147
        Me.FryFactor3Text.Text = "0.01"
        Me.FryFactor3Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FryFactor3Text.WordWrap = False
        '
        'Label67
        '
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(5, 360)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(105, 15)
        Me.Label67.TabIndex = 145
        Me.Label67.Text = "Temp. Speed "
        '
        'Label64
        '
        Me.Label64.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label64.ForeColor = System.Drawing.Color.Black
        Me.Label64.Location = New System.Drawing.Point(216, 180)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(136, 15)
        Me.Label64.TabIndex = 144
        Me.Label64.Text = "Moisture in load"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SlicerVariancePlus
        '
        Me.SlicerVariancePlus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SlicerVariancePlus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SlicerVariancePlus.Location = New System.Drawing.Point(184, 297)
        Me.SlicerVariancePlus.Name = "SlicerVariancePlus"
        Me.SlicerVariancePlus.Size = New System.Drawing.Size(25, 20)
        Me.SlicerVariancePlus.TabIndex = 143
        Me.SlicerVariancePlus.Text = "+"
        Me.SlicerVariancePlus.UseVisualStyleBackColor = False
        '
        'SlicerVarianceMinus
        '
        Me.SlicerVarianceMinus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SlicerVarianceMinus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SlicerVarianceMinus.Location = New System.Drawing.Point(108, 297)
        Me.SlicerVarianceMinus.Name = "SlicerVarianceMinus"
        Me.SlicerVarianceMinus.Size = New System.Drawing.Size(25, 20)
        Me.SlicerVarianceMinus.TabIndex = 141
        Me.SlicerVarianceMinus.Text = "-"
        Me.SlicerVarianceMinus.UseVisualStyleBackColor = False
        '
        'SlicerVarianceText
        '
        Me.SlicerVarianceText.BackColor = System.Drawing.SystemColors.MenuText
        Me.SlicerVarianceText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlicerVarianceText.ForeColor = System.Drawing.Color.Yellow
        Me.SlicerVarianceText.Location = New System.Drawing.Point(133, 297)
        Me.SlicerVarianceText.Name = "SlicerVarianceText"
        Me.SlicerVarianceText.Size = New System.Drawing.Size(50, 20)
        Me.SlicerVarianceText.TabIndex = 142
        Me.SlicerVarianceText.Text = "0.06"
        Me.SlicerVarianceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SlicerVarianceText.WordWrap = False
        '
        'Label65
        '
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(5, 180)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(105, 15)
        Me.Label65.TabIndex = 140
        Me.Label65.Text = "Moisture Load"
        '
        'Label63
        '
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(6, 240)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(352, 15)
        Me.Label63.TabIndex = 139
        Me.Label63.Text = "Oil Temperature"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(216, 270)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 15)
        Me.Label12.TabIndex = 138
        Me.Label12.Text = "Total Moisture Per Slice"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BulkMoisturePlus
        '
        Me.BulkMoisturePlus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BulkMoisturePlus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BulkMoisturePlus.Location = New System.Drawing.Point(184, 267)
        Me.BulkMoisturePlus.Name = "BulkMoisturePlus"
        Me.BulkMoisturePlus.Size = New System.Drawing.Size(25, 20)
        Me.BulkMoisturePlus.TabIndex = 137
        Me.BulkMoisturePlus.Text = "+"
        Me.BulkMoisturePlus.UseVisualStyleBackColor = False
        '
        'BulkMoistureMinus
        '
        Me.BulkMoistureMinus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BulkMoistureMinus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BulkMoistureMinus.Location = New System.Drawing.Point(108, 267)
        Me.BulkMoistureMinus.Name = "BulkMoistureMinus"
        Me.BulkMoistureMinus.Size = New System.Drawing.Size(25, 20)
        Me.BulkMoistureMinus.TabIndex = 135
        Me.BulkMoistureMinus.Text = "-"
        Me.BulkMoistureMinus.UseVisualStyleBackColor = False
        '
        'MoistureBulkText
        '
        Me.MoistureBulkText.BackColor = System.Drawing.SystemColors.MenuText
        Me.MoistureBulkText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoistureBulkText.ForeColor = System.Drawing.Color.Yellow
        Me.MoistureBulkText.Location = New System.Drawing.Point(133, 267)
        Me.MoistureBulkText.Name = "MoistureBulkText"
        Me.MoistureBulkText.Size = New System.Drawing.Size(50, 20)
        Me.MoistureBulkText.TabIndex = 136
        Me.MoistureBulkText.Text = "0.2"
        Me.MoistureBulkText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MoistureBulkText.WordWrap = False
        '
        'Label59
        '
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(5, 270)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(105, 15)
        Me.Label59.TabIndex = 134
        Me.Label59.Text = "Bulk Moisture"
        '
        'Label61
        '
        Me.Label61.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label61.ForeColor = System.Drawing.Color.Black
        Me.Label61.Location = New System.Drawing.Point(216, 90)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(136, 15)
        Me.Label61.TabIndex = 133
        Me.Label61.Text = "Slicer Moisture Adjustment"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SlicerRatioPlus
        '
        Me.SlicerRatioPlus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SlicerRatioPlus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SlicerRatioPlus.Location = New System.Drawing.Point(184, 87)
        Me.SlicerRatioPlus.Name = "SlicerRatioPlus"
        Me.SlicerRatioPlus.Size = New System.Drawing.Size(25, 20)
        Me.SlicerRatioPlus.TabIndex = 132
        Me.SlicerRatioPlus.Text = "+"
        Me.SlicerRatioPlus.UseVisualStyleBackColor = False
        '
        'SlicerRatioMinus
        '
        Me.SlicerRatioMinus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SlicerRatioMinus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SlicerRatioMinus.Location = New System.Drawing.Point(108, 87)
        Me.SlicerRatioMinus.Name = "SlicerRatioMinus"
        Me.SlicerRatioMinus.Size = New System.Drawing.Size(25, 20)
        Me.SlicerRatioMinus.TabIndex = 130
        Me.SlicerRatioMinus.Text = "-"
        Me.SlicerRatioMinus.UseVisualStyleBackColor = False
        '
        'SlicerRatioText
        '
        Me.SlicerRatioText.BackColor = System.Drawing.SystemColors.MenuText
        Me.SlicerRatioText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlicerRatioText.ForeColor = System.Drawing.Color.Yellow
        Me.SlicerRatioText.Location = New System.Drawing.Point(133, 87)
        Me.SlicerRatioText.Name = "SlicerRatioText"
        Me.SlicerRatioText.Size = New System.Drawing.Size(50, 20)
        Me.SlicerRatioText.TabIndex = 131
        Me.SlicerRatioText.Text = "0.01"
        Me.SlicerRatioText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SlicerRatioText.WordWrap = False
        '
        'Label62
        '
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(5, 90)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(105, 15)
        Me.Label62.TabIndex = 129
        Me.Label62.Text = "Slicer Offset"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(216, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 15)
        Me.Label5.TabIndex = 128
        Me.Label5.Text = "Moisture Removed x MSpeed"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CCMasterSpeedPlus
        '
        Me.CCMasterSpeedPlus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CCMasterSpeedPlus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CCMasterSpeedPlus.Location = New System.Drawing.Point(184, 57)
        Me.CCMasterSpeedPlus.Name = "CCMasterSpeedPlus"
        Me.CCMasterSpeedPlus.Size = New System.Drawing.Size(25, 20)
        Me.CCMasterSpeedPlus.TabIndex = 127
        Me.CCMasterSpeedPlus.Text = "+"
        Me.CCMasterSpeedPlus.UseVisualStyleBackColor = False
        '
        'CCMasterSpeedMinus
        '
        Me.CCMasterSpeedMinus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CCMasterSpeedMinus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CCMasterSpeedMinus.Location = New System.Drawing.Point(108, 57)
        Me.CCMasterSpeedMinus.Name = "CCMasterSpeedMinus"
        Me.CCMasterSpeedMinus.Size = New System.Drawing.Size(25, 20)
        Me.CCMasterSpeedMinus.TabIndex = 125
        Me.CCMasterSpeedMinus.Text = "-"
        Me.CCMasterSpeedMinus.UseVisualStyleBackColor = False
        '
        'MasterSpeedRatioText
        '
        Me.MasterSpeedRatioText.BackColor = System.Drawing.SystemColors.MenuText
        Me.MasterSpeedRatioText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterSpeedRatioText.ForeColor = System.Drawing.Color.Yellow
        Me.MasterSpeedRatioText.Location = New System.Drawing.Point(133, 57)
        Me.MasterSpeedRatioText.Name = "MasterSpeedRatioText"
        Me.MasterSpeedRatioText.Size = New System.Drawing.Size(50, 20)
        Me.MasterSpeedRatioText.TabIndex = 126
        Me.MasterSpeedRatioText.Text = "0.0002"
        Me.MasterSpeedRatioText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MasterSpeedRatioText.WordWrap = False
        '
        'Label60
        '
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(5, 60)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(105, 15)
        Me.Label60.TabIndex = 124
        Me.Label60.Text = "Master Speed Ratio"
        '
        'Label55
        '
        Me.Label55.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.Location = New System.Drawing.Point(216, 330)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(136, 15)
        Me.Label55.TabIndex = 118
        Me.Label55.Text = "Adjust Outlet Temp"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label54
        '
        Me.Label54.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.Location = New System.Drawing.Point(216, 300)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(136, 15)
        Me.Label54.TabIndex = 117
        Me.Label54.Text = "Moisture Balance"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TempVariancePlus
        '
        Me.TempVariancePlus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TempVariancePlus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.TempVariancePlus.Location = New System.Drawing.Point(184, 327)
        Me.TempVariancePlus.Name = "TempVariancePlus"
        Me.TempVariancePlus.Size = New System.Drawing.Size(25, 20)
        Me.TempVariancePlus.TabIndex = 115
        Me.TempVariancePlus.Text = "+"
        Me.TempVariancePlus.UseVisualStyleBackColor = False
        '
        'TempVarianceMinus
        '
        Me.TempVarianceMinus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TempVarianceMinus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.TempVarianceMinus.Location = New System.Drawing.Point(108, 327)
        Me.TempVarianceMinus.Name = "TempVarianceMinus"
        Me.TempVarianceMinus.Size = New System.Drawing.Size(25, 20)
        Me.TempVarianceMinus.TabIndex = 113
        Me.TempVarianceMinus.Text = "-"
        Me.TempVarianceMinus.UseVisualStyleBackColor = False
        '
        'TempVarianceText
        '
        Me.TempVarianceText.BackColor = System.Drawing.SystemColors.MenuText
        Me.TempVarianceText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempVarianceText.ForeColor = System.Drawing.Color.Yellow
        Me.TempVarianceText.Location = New System.Drawing.Point(133, 327)
        Me.TempVarianceText.Name = "TempVarianceText"
        Me.TempVarianceText.Size = New System.Drawing.Size(50, 20)
        Me.TempVarianceText.TabIndex = 114
        Me.TempVarianceText.Text = "0.065"
        Me.TempVarianceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TempVarianceText.WordWrap = False
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(5, 330)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(105, 15)
        Me.Label16.TabIndex = 112
        Me.Label16.Text = "Outlet Ratio"
        '
        'MoistureVariancePlus
        '
        Me.MoistureVariancePlus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MoistureVariancePlus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MoistureVariancePlus.Location = New System.Drawing.Point(184, 177)
        Me.MoistureVariancePlus.Name = "MoistureVariancePlus"
        Me.MoistureVariancePlus.Size = New System.Drawing.Size(25, 20)
        Me.MoistureVariancePlus.TabIndex = 111
        Me.MoistureVariancePlus.Text = "+"
        Me.MoistureVariancePlus.UseVisualStyleBackColor = False
        '
        'MoistureVarianceMinus
        '
        Me.MoistureVarianceMinus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MoistureVarianceMinus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MoistureVarianceMinus.Location = New System.Drawing.Point(108, 177)
        Me.MoistureVarianceMinus.Name = "MoistureVarianceMinus"
        Me.MoistureVarianceMinus.Size = New System.Drawing.Size(25, 20)
        Me.MoistureVarianceMinus.TabIndex = 109
        Me.MoistureVarianceMinus.Text = "-"
        Me.MoistureVarianceMinus.UseVisualStyleBackColor = False
        '
        'MoistureVarianceText
        '
        Me.MoistureVarianceText.BackColor = System.Drawing.SystemColors.MenuText
        Me.MoistureVarianceText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoistureVarianceText.ForeColor = System.Drawing.Color.Yellow
        Me.MoistureVarianceText.Location = New System.Drawing.Point(133, 177)
        Me.MoistureVarianceText.Name = "MoistureVarianceText"
        Me.MoistureVarianceText.Size = New System.Drawing.Size(50, 20)
        Me.MoistureVarianceText.TabIndex = 110
        Me.MoistureVarianceText.Text = "31.3"
        Me.MoistureVarianceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MoistureVarianceText.WordWrap = False
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 300)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 15)
        Me.Label15.TabIndex = 108
        Me.Label15.Text = "Slicer Offset"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage4.Controls.Add(Me.Label107)
        Me.TabPage4.Controls.Add(Me.Label97)
        Me.TabPage4.Controls.Add(Me.Button1)
        Me.TabPage4.Controls.Add(Me.Button4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(381, 706)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "Tutorials"
        '
        'Label107
        '
        Me.Label107.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label107.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label107.Location = New System.Drawing.Point(147, 99)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(120, 18)
        Me.Label107.TabIndex = 3
        Me.Label107.Text = "Operating Basics"
        Me.Label107.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label97
        '
        Me.Label97.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label97.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label97.Location = New System.Drawing.Point(15, 99)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(120, 18)
        Me.Label97.TabIndex = 1
        Me.Label97.Text = "Introductory Tutorial"
        Me.Label97.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.PC42VB.My.Resources.Resources.ImageOfHMIScreen
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(15, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 99)
        Me.Button1.TabIndex = 0
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.PC42VB.My.Resources.Resources.ImageOfHMIScreen
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(147, 18)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(121, 99)
        Me.Button4.TabIndex = 2
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SystemDataTab
        '
        Me.SystemDataTab.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.SystemDataTab.Controls.Add(Me.GroupBox10)
        Me.SystemDataTab.Controls.Add(Me.FryerArrayCB)
        Me.SystemDataTab.Location = New System.Drawing.Point(4, 22)
        Me.SystemDataTab.Name = "SystemDataTab"
        Me.SystemDataTab.Padding = New System.Windows.Forms.Padding(3)
        Me.SystemDataTab.Size = New System.Drawing.Size(381, 706)
        Me.SystemDataTab.TabIndex = 5
        Me.SystemDataTab.Text = "System Data"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Label102)
        Me.GroupBox10.Controls.Add(Me.InitMoistureHigh)
        Me.GroupBox10.Controls.Add(Me.Label103)
        Me.GroupBox10.Controls.Add(Me.InitMoistureLow)
        Me.GroupBox10.Controls.Add(Me.Label104)
        Me.GroupBox10.Controls.Add(Me.InitMoistureSP)
        Me.GroupBox10.Controls.Add(Me.Label105)
        Me.GroupBox10.Controls.Add(Me.InitSetPoint)
        Me.GroupBox10.Controls.Add(Me.Label101)
        Me.GroupBox10.Controls.Add(Me.InitMasterSpeed)
        Me.GroupBox10.Controls.Add(Me.Label100)
        Me.GroupBox10.Controls.Add(Me.InitBurnerOn)
        Me.GroupBox10.Controls.Add(Me.Label99)
        Me.GroupBox10.Controls.Add(Me.InitSlicerSpeed)
        Me.GroupBox10.Controls.Add(Me.Label98)
        Me.GroupBox10.Controls.Add(Me.InitInletTemp)
        Me.GroupBox10.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(354, 120)
        Me.GroupBox10.TabIndex = 1
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Initialization Settings"
        '
        'Label102
        '
        Me.Label102.Location = New System.Drawing.Point(192, 87)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(100, 15)
        Me.Label102.TabIndex = 15
        Me.Label102.Text = "MOISTURE HIGH"
        '
        'InitMoistureHigh
        '
        Me.InitMoistureHigh.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.InitMoistureHigh.Location = New System.Drawing.Point(297, 84)
        Me.InitMoistureHigh.Name = "InitMoistureHigh"
        Me.InitMoistureHigh.Size = New System.Drawing.Size(48, 20)
        Me.InitMoistureHigh.TabIndex = 14
        Me.InitMoistureHigh.Text = "1.65"
        Me.InitMoistureHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label103
        '
        Me.Label103.Location = New System.Drawing.Point(192, 66)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(100, 15)
        Me.Label103.TabIndex = 13
        Me.Label103.Text = "MOISTURE LOW "
        '
        'InitMoistureLow
        '
        Me.InitMoistureLow.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.InitMoistureLow.Location = New System.Drawing.Point(297, 63)
        Me.InitMoistureLow.Name = "InitMoistureLow"
        Me.InitMoistureLow.Size = New System.Drawing.Size(48, 20)
        Me.InitMoistureLow.TabIndex = 12
        Me.InitMoistureLow.Text = "1.0"
        Me.InitMoistureLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label104
        '
        Me.Label104.Location = New System.Drawing.Point(192, 45)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(100, 15)
        Me.Label104.TabIndex = 11
        Me.Label104.Text = "MOISTURE SP."
        '
        'InitMoistureSP
        '
        Me.InitMoistureSP.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.InitMoistureSP.Location = New System.Drawing.Point(297, 42)
        Me.InitMoistureSP.Name = "InitMoistureSP"
        Me.InitMoistureSP.Size = New System.Drawing.Size(48, 20)
        Me.InitMoistureSP.TabIndex = 10
        Me.InitMoistureSP.Text = "1.35"
        Me.InitMoistureSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label105
        '
        Me.Label105.Location = New System.Drawing.Point(192, 24)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(100, 15)
        Me.Label105.TabIndex = 9
        Me.Label105.Text = "INLET SETPOINT"
        '
        'InitSetPoint
        '
        Me.InitSetPoint.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.InitSetPoint.Location = New System.Drawing.Point(297, 21)
        Me.InitSetPoint.Name = "InitSetPoint"
        Me.InitSetPoint.Size = New System.Drawing.Size(48, 20)
        Me.InitSetPoint.TabIndex = 8
        Me.InitSetPoint.Text = "170"
        Me.InitSetPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label101
        '
        Me.Label101.Location = New System.Drawing.Point(12, 90)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(100, 15)
        Me.Label101.TabIndex = 7
        Me.Label101.Text = "MASTER SPEED"
        '
        'InitMasterSpeed
        '
        Me.InitMasterSpeed.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.InitMasterSpeed.Location = New System.Drawing.Point(117, 87)
        Me.InitMasterSpeed.Name = "InitMasterSpeed"
        Me.InitMasterSpeed.Size = New System.Drawing.Size(48, 20)
        Me.InitMasterSpeed.TabIndex = 6
        Me.InitMasterSpeed.Text = "70"
        Me.InitMasterSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label100
        '
        Me.Label100.Location = New System.Drawing.Point(12, 69)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(100, 15)
        Me.Label100.TabIndex = 5
        Me.Label100.Text = "BURNER ON"
        '
        'InitBurnerOn
        '
        Me.InitBurnerOn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.InitBurnerOn.Location = New System.Drawing.Point(117, 66)
        Me.InitBurnerOn.Name = "InitBurnerOn"
        Me.InitBurnerOn.Size = New System.Drawing.Size(48, 20)
        Me.InitBurnerOn.TabIndex = 4
        Me.InitBurnerOn.Text = "FALSE"
        Me.InitBurnerOn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label99
        '
        Me.Label99.Location = New System.Drawing.Point(12, 48)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(100, 15)
        Me.Label99.TabIndex = 3
        Me.Label99.Text = "SLICER SPEED"
        '
        'InitSlicerSpeed
        '
        Me.InitSlicerSpeed.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.InitSlicerSpeed.Location = New System.Drawing.Point(117, 45)
        Me.InitSlicerSpeed.Name = "InitSlicerSpeed"
        Me.InitSlicerSpeed.Size = New System.Drawing.Size(48, 20)
        Me.InitSlicerSpeed.TabIndex = 2
        Me.InitSlicerSpeed.Text = "62"
        Me.InitSlicerSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label98
        '
        Me.Label98.Location = New System.Drawing.Point(12, 27)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(100, 15)
        Me.Label98.TabIndex = 1
        Me.Label98.Text = "INLET TEMP."
        '
        'InitInletTemp
        '
        Me.InitInletTemp.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.InitInletTemp.Location = New System.Drawing.Point(117, 24)
        Me.InitInletTemp.Name = "InitInletTemp"
        Me.InitInletTemp.Size = New System.Drawing.Size(48, 20)
        Me.InitInletTemp.TabIndex = 0
        Me.InitInletTemp.Text = "142"
        Me.InitInletTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FryerArrayCB
        '
        Me.FryerArrayCB.AutoSize = True
        Me.FryerArrayCB.Location = New System.Drawing.Point(9, 135)
        Me.FryerArrayCB.Name = "FryerArrayCB"
        Me.FryerArrayCB.Size = New System.Drawing.Size(102, 17)
        Me.FryerArrayCB.TabIndex = 0
        Me.FryerArrayCB.Text = "Fryer Array Data"
        Me.FryerArrayCB.UseVisualStyleBackColor = True
        '
        'Randomize
        '
        Me.Randomize.Enabled = True
        Me.Randomize.Interval = 2000
        '
        'MasterSpeedChangeDelay
        '
        Me.MasterSpeedChangeDelay.Interval = 1000
        '
        'SlicerFeedAdjustmentDelay
        '
        Me.SlicerFeedAdjustmentDelay.Interval = 1000
        '
        'SlicerFeedChangeDelay
        '
        Me.SlicerFeedChangeDelay.Interval = 1000
        '
        'RandomFryerInputs
        '
        Me.RandomFryerInputs.Interval = 1000
        '
        'MoistureValueUpdateTimer
        '
        Me.MoistureValueUpdateTimer.Enabled = True
        Me.MoistureValueUpdateTimer.Interval = 1000
        '
        'SmoothTimer
        '
        Me.SmoothTimer.Enabled = True
        Me.SmoothTimer.Interval = 5
        '
        'TutorialTimer
        '
        Me.TutorialTimer.Interval = 2000
        '
        'PoliteTimer
        '
        Me.PoliteTimer.Enabled = True
        '
        'SlicerGradualChange
        '
        Me.SlicerGradualChange.Interval = 1000
        '
        'PIDTimer
        '
        Me.PIDTimer.Enabled = True
        '
        'Fryer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(1365, 749)
        Me.ControlBox = False
        Me.Controls.Add(Me.SystemData)
        Me.Controls.Add(Me.button9)
        Me.Controls.Add(Me.button8)
        Me.Controls.Add(Me.MainOverviewButton)
        Me.Controls.Add(Me.ProductSelectButton)
        Me.Controls.Add(Me.DataLogsButton)
        Me.Controls.Add(Me.CleaningButton)
        Me.Controls.Add(Me.FryerOutfeedButton)
        Me.Controls.Add(Me.FryerButton)
        Me.Controls.Add(Me.FryerInfeedMenuButton)
        Me.Controls.Add(Me.panel10)
        Me.Controls.Add(Me.panel7)
        Me.Controls.Add(Me.panel6)
        Me.Controls.Add(Me.panel5)
        Me.Controls.Add(Me.panel4)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Fryer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PC42 Fryer Simulation"
        Me.TransparencyKey = System.Drawing.Color.IndianRed
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel10.ResumeLayout(False)
        Me.panel10.PerformLayout()
        CType(Me.RGManualOpenImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RejectManualOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCV2OnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCV2OffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VBOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VBOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OCVOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OCVOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCV1OnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCV1OffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AFOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AFOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ITOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ITOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGConOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGCONOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccumulationOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutfeedOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RejectAutoOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutfeedOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccumulationOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Zone4EmptyImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Zone3EmptyImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Zone2EmptyImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Zone4FullImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Zone3FullImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Zone2FullImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Zone1FullImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackagingOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackagingOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel7.ResumeLayout(False)
        Me.panel7.PerformLayout()
        Me.panel6.ResumeLayout(False)
        Me.panel6.PerformLayout()
        Me.panel5.ResumeLayout(False)
        Me.panel5.PerformLayout()
        Me.panel4.ResumeLayout(False)
        Me.panel4.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.OMUVOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMUVOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HDHSTOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HDHSTOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FDrainOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FDrainOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MPumpOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MPumpOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FCtchOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FCtchOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FDISOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FDISOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FSubOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FSubOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FPLDOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FPLDOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DischargeConveyorOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KHXBurnerOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DischargeConveyorOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KHXBurnerOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainFlameOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BurnerStartedOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BurnerStartedOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainFlameOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MM55PowerOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoolantAirImageOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoolantAirImageOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MM55PowerOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MM55On, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.PPRunningOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KMOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AirMOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SWCBMOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SWPMOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCMOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.S3MOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.S2MOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.S1MOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCMOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SFCMOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KMOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AirMOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SWCBMOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SWPMOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SWCMOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.S3CMOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.S2CMOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.S1CMOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCMOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SFCMOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlicerOff2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlicerOff3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlicerOn3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlicerOn2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlicerOff1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaningConveyorOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaningConveyorOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlicerFeedOffImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlicerFeedOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPRunningOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlicerOn1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SystemData.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.MasterSpeedXImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeltaTXImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InletXImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoistureXImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterSpeedExclImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InletExclImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoistureExclImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterSpeedTickImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeltaTTickImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InletTickImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoistureTickImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.BurnerResetButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BurnerStopButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LowOilPressureFaultOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FryerTempFaultOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BurnerFaultOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BCBBurnerOffLight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BurnerFaultOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FryerTempFaultOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LowOilPressureFaultOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BCBBurnerOnLight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BCBStartButtonOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BCBBurnerStartButtonOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.OnImage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptyFryer1Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.InfeedVarianceOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InfeedVarianceOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.AllOnSwitchON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllOnSwitchOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.SystemDataTab.ResumeLayout(False)
        Me.SystemDataTab.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents button9 As Button
    Private WithEvents button8 As Button
    Private WithEvents panel7 As Panel
    Private WithEvents label4 As Label
    Private WithEvents panel6 As Panel
    Private WithEvents label3 As Label
    Private WithEvents panel5 As Panel
    Private WithEvents label2 As Label
    Private WithEvents panel4 As Panel
    Private WithEvents label1 As Label
    Friend WithEvents MainTimerTick As Timer
    Friend WithEvents OutfeedStartButton As Button
    Friend WithEvents OutfeedStopButton As Button
    Friend WithEvents BurnerStartupTimer As Timer
    Friend WithEvents FryerMimicTimer As Timer
    Friend WithEvents CookTimer As Timer
    Friend WithEvents MasterSpeedTimer As Timer
    Friend WithEvents OilCoolDownTimer As Timer
    Private WithEvents TextBox32 As TextBox
    Private WithEvents TextBox31 As TextBox
    Private WithEvents TextBox30 As TextBox
    Private WithEvents TextBox27 As TextBox
    Friend WithEvents AccumulationStopButton As Button
    Friend WithEvents AccumulationStartButton As Button
    Private WithEvents Button22 As Button
    Private WithEvents Button26 As Button
    Private WithEvents Button27 As Button
    Private WithEvents TextBox15 As TextBox
    Friend WithEvents RejectGateManualButton As Button
    Private WithEvents TextBox26 As TextBox
    Private WithEvents TextBox24 As TextBox
    Friend WithEvents RejectGateAutoButton As Button
    Friend WithEvents AccumulationOffImage As PictureBox
    Friend WithEvents OutfeedOffImage As PictureBox
    Friend WithEvents RejectAutoOnImage As PictureBox
    Friend WithEvents OutfeedOnImage As PictureBox
    Friend WithEvents AccumulationOnImage As PictureBox
    Friend WithEvents Zone2EmptyImage As PictureBox
    Friend WithEvents Zone4FullImage As PictureBox
    Friend WithEvents Zone3FullImage As PictureBox
    Friend WithEvents Zone2FullImage As PictureBox
    Friend WithEvents Zone1FullImage As PictureBox
    Friend WithEvents PackagingOffImage As PictureBox
    Friend WithEvents PackagingOnImage As PictureBox
    Friend WithEvents BurnerShutDownTimer As Timer
    Private WithEvents panel3 As Panel
    Private WithEvents TextBox6 As TextBox
    Private WithEvents TextBox5 As TextBox
    Private WithEvents TextBox7 As TextBox
    Private WithEvents TextBox8 As TextBox
    Private WithEvents TextBox9 As TextBox
    Private WithEvents TextBox10 As TextBox
    Private WithEvents TextBox12 As TextBox
    Private WithEvents TextBox11 As TextBox
    Private WithEvents TextBox13 As TextBox
    Private WithEvents TextBox16 As TextBox
    Private WithEvents TextBox21 As TextBox
    Private WithEvents TextBox20 As TextBox
    Private WithEvents TextBox22 As TextBox
    Private WithEvents TextBox23 As TextBox
    Private WithEvents TextBox25 As TextBox
    Friend WithEvents KHXStopButton As Button
    Friend WithEvents KHXStartButton As Button
    Private WithEvents TextBox49 As TextBox
    Friend WithEvents DischargeConveyorStopButton As Button
    Friend WithEvents DischargeConveyorStartButton As Button
    Friend WithEvents MM55On As PictureBox
    Friend WithEvents MM55PowerOn As PictureBox
    Friend WithEvents CoolantAirImageOn As PictureBox
    Private WithEvents TextBox58 As TextBox
    Private WithEvents TextBox59 As TextBox
    Friend WithEvents CoolantAirImageOff As PictureBox
    Friend WithEvents MM55PowerOff As PictureBox
    Friend WithEvents MainFlameOnImage As PictureBox
    Friend WithEvents BurnerStartedOnImage As PictureBox
    Private WithEvents TextBox62 As TextBox
    Friend WithEvents BurnerStartedOffImage As PictureBox
    Friend WithEvents MainFlameOffImage As PictureBox
    Friend WithEvents KHXBurnerOnImage As PictureBox
    Friend WithEvents DischargeConveyorOnImage As PictureBox
    Friend WithEvents KHXBurnerOffImage As PictureBox
    Friend WithEvents DischargeConveyorOffImage As PictureBox
    Friend WithEvents HighLimitOutput As TextBox
    Friend WithEvents LowLimitOutput As TextBox
    Friend WithEvents SetPointOutput As TextBox
    Friend WithEvents MoistureOutput As TextBox
    Friend WithEvents MasterSpeedOutput As TextBox
    Friend WithEvents OilFlowTextbox As TextBox
    Friend WithEvents OutletTempText As TextBox
    Friend WithEvents InletTemperature As TextBox
    Friend WithEvents InletSetpoint As TextBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents textBox2 As TextBox
    Private WithEvents textBox3 As TextBox
    Private WithEvents LaningConveyorLabel As TextBox
    Friend WithEvents SlicerOn1 As PictureBox
    Friend WithEvents PPRunningOnImage As PictureBox
    Friend WithEvents SlicerFeedOnImage As PictureBox
    Friend WithEvents SlicerFeedOffImage As PictureBox
    Friend WithEvents LaningConveyorOnImage As PictureBox
    Friend WithEvents LaningConveyorOffImage As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents AlarmButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DTMenu As Label
    Friend WithEvents SlicerOff1 As PictureBox
    Friend WithEvents SlicerOff2 As PictureBox
    Friend WithEvents SlicerOff3 As PictureBox
    Friend WithEvents SlicerOn3 As PictureBox
    Friend WithEvents SlicerOn2 As PictureBox
    Friend WithEvents LaningConveyorStartButton As Button
    Friend WithEvents LaningConveyorStopButton As Button
    Friend WithEvents SlicerStartButton As Button
    Friend WithEvents SlicerStopButton As Button
    Friend WithEvents SystemData As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents OnImage1 As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents BurnerInfoText As Label
    Private WithEvents TextBox67 As TextBox
    Friend WithEvents KMOff As PictureBox
    Friend WithEvents AirMOff As PictureBox
    Friend WithEvents SWCBMOff As PictureBox
    Friend WithEvents SWPMOff As PictureBox
    Friend WithEvents SWCMOff As PictureBox
    Friend WithEvents S3CMOff As PictureBox
    Friend WithEvents S2CMOff As PictureBox
    Friend WithEvents S1CMOff As PictureBox
    Friend WithEvents LCMOff As PictureBox
    Friend WithEvents SFCMOff As PictureBox
    Friend WithEvents KMOn As PictureBox
    Friend WithEvents AirMOn As PictureBox
    Friend WithEvents SWCBMOn As PictureBox
    Friend WithEvents SWPMOn As PictureBox
    Friend WithEvents SCMOn As PictureBox
    Friend WithEvents S3MOn As PictureBox
    Friend WithEvents S2MOn As PictureBox
    Friend WithEvents S1MOn As PictureBox
    Friend WithEvents LCMOn As PictureBox
    Friend WithEvents SFCMOn As PictureBox
    Friend WithEvents DelayedSpeedChange As Label
    Friend WithEvents SlicerFeedSpeedButton As Button
    Friend WithEvents DeltaTText As TextBox
    Friend WithEvents BiasDisplayText As TextBox
    Friend WithEvents PictureBox22 As PictureBox
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents FlameBar As TextBox
    Friend WithEvents Randomize As Timer
    Friend WithEvents PictureBox56 As PictureBox
    Friend WithEvents PictureBox57 As PictureBox
    Friend WithEvents HCV2OnImage As PictureBox
    Friend WithEvents HCV2OffImage As PictureBox
    Friend WithEvents VBOnImage As PictureBox
    Friend WithEvents VBOffImage As PictureBox
    Friend WithEvents OCVOnImage As PictureBox
    Friend WithEvents OCVOffImage As PictureBox
    Friend WithEvents HCV1OnImage As PictureBox
    Friend WithEvents HCV1OffImage As PictureBox
    Friend WithEvents HCOnImage As PictureBox
    Friend WithEvents HCOffImage As PictureBox
    Friend WithEvents AFOnImage As PictureBox
    Friend WithEvents AFOffImage As PictureBox
    Friend WithEvents PictureBox48 As PictureBox
    Friend WithEvents PictureBox49 As PictureBox
    Friend WithEvents ITOnImage As PictureBox
    Friend WithEvents ITOffImage As PictureBox
    Friend WithEvents RGConOnImage As PictureBox
    Friend WithEvents RGCONOffImage As PictureBox
    Friend WithEvents OMUVOnImage As PictureBox
    Friend WithEvents OMUVOffImage As PictureBox
    Friend WithEvents HDHSTOnImage As PictureBox
    Friend WithEvents HDHSTOffImage As PictureBox
    Friend WithEvents FDrainOnImage As PictureBox
    Friend WithEvents FDrainOffImage As PictureBox
    Friend WithEvents MPumpOnImage As PictureBox
    Friend WithEvents MPumpOffImage As PictureBox
    Friend WithEvents FCtchOnImage As PictureBox
    Friend WithEvents FCtchOffImage As PictureBox
    Friend WithEvents FDISOnImage As PictureBox
    Friend WithEvents FDISOffImage As PictureBox
    Friend WithEvents FSubOnImage As PictureBox
    Friend WithEvents FSubOffImage As PictureBox
    Friend WithEvents FPLDOnImage As PictureBox
    Friend WithEvents FPLDOffImage As PictureBox
    Friend WithEvents RejectManualOnImage As PictureBox
    Friend WithEvents EGMCLabel As Label
    Friend WithEvents RejectProductLabel As Label
    Friend WithEvents RGManualOpenImage As PictureBox
    Friend WithEvents RGManualCloseButton As Button
    Friend WithEvents RGManualOpenButton As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents EmptyFryer1Pic As PictureBox
    Friend WithEvents SkipStartup As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents FryerTempFaultOn As PictureBox
    Friend WithEvents LowOilPressureFaultOn As PictureBox
    Friend WithEvents BurnerFaultOn As PictureBox
    Friend WithEvents BCBStartButtonOn As PictureBox
    Friend WithEvents BCBBurnerOnLight As PictureBox
    Friend WithEvents BCBBurnerOffLight As PictureBox
    Friend WithEvents BCBBurnerStartButtonOff As PictureBox
    Friend WithEvents BurnerResetButton As PictureBox
    Friend WithEvents BurnerStopButton As PictureBox
    Friend WithEvents PictureBox26 As PictureBox
    Friend WithEvents PictureBox27 As PictureBox
    Friend WithEvents PictureBox28 As PictureBox
    Friend WithEvents PictureBox29 As PictureBox
    Friend WithEvents LowOilPressureFaultOff As PictureBox
    Friend WithEvents PictureBox31 As PictureBox
    Friend WithEvents PictureBox32 As PictureBox
    Friend WithEvents PictureBox33 As PictureBox
    Friend WithEvents FryerTempFaultOff As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents BurnerFaultOff As PictureBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents AllOnSwitchON As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents AllOnSwitchOff As PictureBox
    Friend WithEvents PPRunningOffImage As PictureBox
    Friend WithEvents GroupBox6 As GroupBox
    Private WithEvents DerivativePlus As Button
    Private WithEvents DerivativeMinus As Button
    Friend WithEvents DerivativeText As TextBox
    Friend WithEvents Label18 As Label
    Private WithEvents IntegralPlus As Button
    Private WithEvents IntegralMinus As Button
    Friend WithEvents IntegralText As TextBox
    Friend WithEvents Label19 As Label
    Private WithEvents ProportionalPlus As Button
    Friend WithEvents Label20 As Label
    Private WithEvents ProportionalMinus As Button
    Friend WithEvents ProportionalText As TextBox
    Friend WithEvents SpeedLabel As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents MasterSpeedXImage As PictureBox
    Friend WithEvents DeltaTXImage As PictureBox
    Friend WithEvents InletXImage As PictureBox
    Friend WithEvents MoistureXImage As PictureBox
    Friend WithEvents MasterSpeedExclImage As PictureBox
    Friend WithEvents InletExclImage As PictureBox
    Friend WithEvents MoistureExclImage As PictureBox
    Friend WithEvents MasterSpeedTickImage As PictureBox
    Friend WithEvents DeltaTTickImage As PictureBox
    Friend WithEvents InletTickImage As PictureBox
    Friend WithEvents MoistureTickImage As PictureBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents RelRadioButton As RadioButton
    Friend WithEvents QABF101RadioButton As RadioButton
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label42 As Label
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents WoQMoistureTickSettingLowText As TextBox
    Friend WithEvents WoQInletTickSettingLowText As TextBox
    Friend WithEvents WoQMSTickLowSettingLowText As TextBox
    Friend WithEvents WoQDeltaTTickSettingLowText As TextBox
    Friend WithEvents WoQMSTickLowSettingHighText As TextBox
    Friend WithEvents WoQDeltaTTickSettingHighText As TextBox
    Friend WithEvents WoQInletTickSettingHighText As TextBox
    Friend WithEvents WoQMoistureTickSettingHighText As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents WoQMSXSettingHighText As TextBox
    Friend WithEvents WoQDeltaXSettingHighText As TextBox
    Friend WithEvents WoQInletXSettingHighText As TextBox
    Friend WithEvents WoQMoistureXSettingHighText As TextBox
    Friend WithEvents WoQMSXSettingLowText As TextBox
    Friend WithEvents WoQDeltaXSettingLowText As TextBox
    Friend WithEvents WoQInletXSettingLowText As TextBox
    Friend WithEvents WoQMoistureXSettingLowText As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents WoQMSExclSettingHighText As TextBox
    Friend WithEvents WoQDeltaExclSettingHighText As TextBox
    Friend WithEvents WoQInletExclSettingHighText As TextBox
    Friend WithEvents WoQMoistureExclSettingHighText As TextBox
    Friend WithEvents WoQMSExclSettingLowText As TextBox
    Friend WithEvents WoQDeltaExclSettingLowText As TextBox
    Friend WithEvents WoQInletExclSettingLowText As TextBox
    Friend WithEvents WoQMoistureExclSettingLowText As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents MMMenu As Label
    Friend WithEvents CPMenu As Label
    Friend WithEvents SCMenu As Label
    Friend WithEvents MasterSpeedChangeDelay As Timer
    Friend WithEvents SlicerFeedAdjustmentDelay As Timer
    Friend WithEvents SlicerFeedChangeDelay As Timer
    Friend WithEvents RandomFryerInputs As Timer
    Friend WithEvents MoistureValueUpdateTimer As Timer
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label53 As Label
    Private WithEvents InfeedVariancePlus As Button
    Friend WithEvents Label14 As Label
    Private WithEvents InfeedVarianceMinus As Button
    Friend WithEvents InfeedVarianceText As TextBox
    Friend WithEvents InfeedVarianceOff As PictureBox
    Friend WithEvents InfeedVarianceOn As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label55 As Label
    Friend WithEvents Label54 As Label
    Private WithEvents TempVariancePlus As Button
    Private WithEvents TempVarianceMinus As Button
    Friend WithEvents TempVarianceText As TextBox
    Friend WithEvents Label16 As Label
    Private WithEvents MoistureVariancePlus As Button
    Private WithEvents MoistureVarianceMinus As Button
    Friend WithEvents MoistureVarianceText As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label5 As Label
    Private WithEvents CCMasterSpeedPlus As Button
    Private WithEvents CCMasterSpeedMinus As Button
    Friend WithEvents MasterSpeedRatioText As TextBox
    Friend WithEvents Label60 As Label
    Friend WithEvents Label61 As Label
    Private WithEvents SlicerRatioPlus As Button
    Private WithEvents SlicerRatioMinus As Button
    Friend WithEvents SlicerRatioText As TextBox
    Friend WithEvents Label62 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents Label12 As Label
    Private WithEvents BulkMoisturePlus As Button
    Private WithEvents BulkMoistureMinus As Button
    Friend WithEvents MoistureBulkText As TextBox
    Friend WithEvents Label59 As Label
    Friend WithEvents Label64 As Label
    Private WithEvents SlicerVariancePlus As Button
    Private WithEvents SlicerVarianceMinus As Button
    Friend WithEvents SlicerVarianceText As TextBox
    Friend WithEvents Label65 As Label
    Friend WithEvents Label66 As Label
    Private WithEvents SlicerVariance2Plus As Button
    Private WithEvents SlicerVariance2Minus As Button
    Friend WithEvents FryFactor3Text As TextBox
    Friend WithEvents Label67 As Label
    Friend WithEvents Label68 As Label
    Private WithEvents FryFactorPlus As Button
    Private WithEvents FryFactorMinus As Button
    Friend WithEvents FryFactorText As TextBox
    Friend WithEvents Label69 As Label
    Friend WithEvents Label70 As Label
    Private WithEvents FryFactor2Plus As Button
    Private WithEvents FryFactor2Minus As Button
    Friend WithEvents FryFactor2Text As TextBox
    Friend WithEvents Label71 As Label
    Friend WithEvents Label72 As Label
    Friend WithEvents SmoothTimer As Timer
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TutorialTimer As Timer
    Friend WithEvents PoliteTimer As Timer
    Friend WithEvents Button23 As Button
    Private WithEvents TextBox17 As TextBox
    Private WithEvents TextBox14 As TextBox
    Friend WithEvents Label81 As Label
    Friend WithEvents Label80 As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents Label76 As Label
    Friend WithEvents Label75 As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents Label84 As Label
    Friend WithEvents Label85 As Label
    Friend WithEvents Label86 As Label
    Friend WithEvents Label88 As Label
    Friend WithEvents Label89 As Label
    Friend WithEvents Label87 As Label
    Friend WithEvents Label96 As Label
    Friend WithEvents Label90 As Label
    Friend WithEvents Label91 As Label
    Friend WithEvents Label92 As Label
    Friend WithEvents Label93 As Label
    Friend WithEvents Label94 As Label
    Friend WithEvents Label95 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label97 As Label
    Friend WithEvents SlicerGradualChange As Timer
    Friend WithEvents SystemDataTab As TabPage
    Friend WithEvents FryerArrayCB As CheckBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Label98 As Label
    Friend WithEvents InitInletTemp As TextBox
    Friend WithEvents Label99 As Label
    Friend WithEvents InitSlicerSpeed As TextBox
    Friend WithEvents Label101 As Label
    Friend WithEvents InitMasterSpeed As TextBox
    Friend WithEvents Label100 As Label
    Friend WithEvents InitBurnerOn As TextBox
    Friend WithEvents Label102 As Label
    Friend WithEvents InitMoistureHigh As TextBox
    Friend WithEvents Label103 As Label
    Friend WithEvents InitMoistureLow As TextBox
    Friend WithEvents Label104 As Label
    Friend WithEvents InitMoistureSP As TextBox
    Friend WithEvents Label105 As Label
    Friend WithEvents InitSetPoint As TextBox
    Friend WithEvents PIDTimer As Timer
    Friend WithEvents panel10 As Panel
    Friend WithEvents panel2 As Panel
    Friend WithEvents panel1 As Panel
    Friend WithEvents MainOverviewButton As Button
    Friend WithEvents ProductSelectButton As Button
    Friend WithEvents DataLogsButton As Button
    Friend WithEvents CleaningButton As Button
    Friend WithEvents FryerOutfeedButton As Button
    Friend WithEvents FryerButton As Button
    Friend WithEvents FryerInfeedMenuButton As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Private WithEvents SlicerAdjustPlus As Button
    Private WithEvents SlicerAdjustMinus As Button
    Friend WithEvents SlicerAdjustText As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label107 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents BurnerStatusTextLabel As TextBox
    Friend WithEvents SlicersLabel As TextBox
    Friend WithEvents GatesLabel As TextBox
    Friend WithEvents PPRLabel As TextBox
    Friend WithEvents SpeedControlModeButton As Button
    Friend WithEvents SlicerFeedMinusButton As Button
    Friend WithEvents SlicerFeedPlusButton As Button
    Friend WithEvents InletSetpointMinus As Button
    Friend WithEvents InletSetpointPlus As Button
    Friend WithEvents InletSetpointButton As Button
    Friend WithEvents MasterSpeedManual As Button
    Friend WithEvents MasterSpeedPlus As Button
    Friend WithEvents MasterSpeedMinus As Button
    Friend WithEvents BiasMinusButton As Button
    Friend WithEvents BiasPlusButton As Button
    Friend WithEvents Zone4EmptyImage As PictureBox
    Friend WithEvents Zone3EmptyImage As PictureBox
End Class
