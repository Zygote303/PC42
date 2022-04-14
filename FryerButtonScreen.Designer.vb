<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FryerButtonScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FryerButtonScreen))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OMAutoOnImage = New System.Windows.Forms.PictureBox()
        Me.RejectGateManualButton = New System.Windows.Forms.Button()
        Me.OilMakeupAutoButton = New System.Windows.Forms.Button()
        Me.ValveCloseImage = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MainOilPumpOn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PaddleButtonOn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SubMergOnButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MainOilPumpStandby = New System.Windows.Forms.Button()
        Me.FryerCloseButton = New System.Windows.Forms.Button()
        Me.PaddleButtonStandby = New System.Windows.Forms.Button()
        Me.SubMergOffButton = New System.Windows.Forms.Button()
        Me.OMMCLabel = New System.Windows.Forms.Label()
        Me.OilMakeupCloseButton = New System.Windows.Forms.Button()
        Me.OilMakeupOpenButton = New System.Windows.Forms.Button()
        Me.ValveOpenImage = New System.Windows.Forms.PictureBox()
        CType(Me.OMAutoOnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValveCloseImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValveOpenImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(448, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FRYER"
        '
        'OMAutoOnImage
        '
        Me.OMAutoOnImage.BackgroundImage = CType(resources.GetObject("OMAutoOnImage.BackgroundImage"), System.Drawing.Image)
        Me.OMAutoOnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OMAutoOnImage.Location = New System.Drawing.Point(24, 384)
        Me.OMAutoOnImage.Name = "OMAutoOnImage"
        Me.OMAutoOnImage.Size = New System.Drawing.Size(74, 4)
        Me.OMAutoOnImage.TabIndex = 205
        Me.OMAutoOnImage.TabStop = False
        '
        'RejectGateManualButton
        '
        Me.RejectGateManualButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.RejectGateManualButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.RejectGateManualButton.ForeColor = System.Drawing.Color.Black
        Me.RejectGateManualButton.Location = New System.Drawing.Point(101, 348)
        Me.RejectGateManualButton.Name = "RejectGateManualButton"
        Me.RejectGateManualButton.Size = New System.Drawing.Size(75, 35)
        Me.RejectGateManualButton.TabIndex = 204
        Me.RejectGateManualButton.Text = "MANUAL"
        Me.RejectGateManualButton.UseVisualStyleBackColor = False
        '
        'OilMakeupAutoButton
        '
        Me.OilMakeupAutoButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.OilMakeupAutoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.OilMakeupAutoButton.ForeColor = System.Drawing.Color.Black
        Me.OilMakeupAutoButton.Location = New System.Drawing.Point(22, 348)
        Me.OilMakeupAutoButton.Name = "OilMakeupAutoButton"
        Me.OilMakeupAutoButton.Size = New System.Drawing.Size(75, 35)
        Me.OilMakeupAutoButton.TabIndex = 203
        Me.OilMakeupAutoButton.Text = "AUTO"
        Me.OilMakeupAutoButton.UseVisualStyleBackColor = False
        '
        'ValveCloseImage
        '
        Me.ValveCloseImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.pngwingStandby2
        Me.ValveCloseImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ValveCloseImage.Location = New System.Drawing.Point(183, 336)
        Me.ValveCloseImage.Name = "ValveCloseImage"
        Me.ValveCloseImage.Size = New System.Drawing.Size(48, 51)
        Me.ValveCloseImage.TabIndex = 207
        Me.ValveCloseImage.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 320)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 208
        Me.Label2.Text = "OIL MAKE UP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 479)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 209
        Me.Label3.Text = "DRAIN PUMP"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(78, 504)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 74)
        Me.Button1.TabIndex = 210
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MainOilPumpOn
        '
        Me.MainOilPumpOn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.MainOilPumpOn.BackgroundImage = CType(resources.GetObject("MainOilPumpOn.BackgroundImage"), System.Drawing.Image)
        Me.MainOilPumpOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MainOilPumpOn.Location = New System.Drawing.Point(297, 506)
        Me.MainOilPumpOn.Name = "MainOilPumpOn"
        Me.MainOilPumpOn.Size = New System.Drawing.Size(52, 74)
        Me.MainOilPumpOn.TabIndex = 212
        Me.MainOilPumpOn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(271, 480)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 211
        Me.Label4.Text = "MAIN OIL PUMP"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(359, 551)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 22)
        Me.Button4.TabIndex = 214
        Me.Button4.Text = "CLEANING"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(358, 527)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 22)
        Me.Button3.TabIndex = 215
        Me.Button3.Text = "PRODUCTION"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(382, 511)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 12)
        Me.Label5.TabIndex = 216
        Me.Label5.Text = "MODE"
        '
        'PaddleButtonOn
        '
        Me.PaddleButtonOn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PaddleButtonOn.BackgroundImage = CType(resources.GetObject("PaddleButtonOn.BackgroundImage"), System.Drawing.Image)
        Me.PaddleButtonOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PaddleButtonOn.Location = New System.Drawing.Point(375, 330)
        Me.PaddleButtonOn.Name = "PaddleButtonOn"
        Me.PaddleButtonOn.Size = New System.Drawing.Size(52, 74)
        Me.PaddleButtonOn.TabIndex = 218
        Me.PaddleButtonOn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(367, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 217
        Me.Label6.Text = "PADDLES"
        '
        'SubMergOnButton
        '
        Me.SubMergOnButton.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.SubMergOnButton.BackgroundImage = CType(resources.GetObject("SubMergOnButton.BackgroundImage"), System.Drawing.Image)
        Me.SubMergOnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SubMergOnButton.Location = New System.Drawing.Point(546, 330)
        Me.SubMergOnButton.Name = "SubMergOnButton"
        Me.SubMergOnButton.Size = New System.Drawing.Size(52, 74)
        Me.SubMergOnButton.TabIndex = 220
        Me.SubMergOnButton.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(529, 302)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 219
        Me.Label7.Text = "SUBMERGER"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button7.Enabled = False
        Me.Button7.Location = New System.Drawing.Point(718, 329)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(52, 74)
        Me.Button7.TabIndex = 222
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(685, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 13)
        Me.Label8.TabIndex = 221
        Me.Label8.Text = "DRAIN CONVEYOR"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button8.Enabled = False
        Me.Button8.Location = New System.Drawing.Point(719, 179)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(52, 74)
        Me.Button8.TabIndex = 224
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(704, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 223
        Me.Label9.Text = "HOOD HOIST"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button9.Enabled = False
        Me.Button9.Location = New System.Drawing.Point(720, 507)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(52, 74)
        Me.Button9.TabIndex = 226
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(709, 481)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 225
        Me.Label10.Text = "CATCHBOX"
        '
        'MainOilPumpStandby
        '
        Me.MainOilPumpStandby.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.MainOilPumpStandby.BackgroundImage = CType(resources.GetObject("MainOilPumpStandby.BackgroundImage"), System.Drawing.Image)
        Me.MainOilPumpStandby.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MainOilPumpStandby.Location = New System.Drawing.Point(297, 504)
        Me.MainOilPumpStandby.Name = "MainOilPumpStandby"
        Me.MainOilPumpStandby.Size = New System.Drawing.Size(52, 74)
        Me.MainOilPumpStandby.TabIndex = 227
        Me.MainOilPumpStandby.UseVisualStyleBackColor = False
        Me.MainOilPumpStandby.Visible = False
        '
        'FryerCloseButton
        '
        Me.FryerCloseButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.FryerCloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.FryerCloseButton.ForeColor = System.Drawing.Color.Black
        Me.FryerCloseButton.Location = New System.Drawing.Point(850, 18)
        Me.FryerCloseButton.Name = "FryerCloseButton"
        Me.FryerCloseButton.Size = New System.Drawing.Size(105, 35)
        Me.FryerCloseButton.TabIndex = 228
        Me.FryerCloseButton.Text = "CLOSE"
        Me.FryerCloseButton.UseVisualStyleBackColor = False
        '
        'PaddleButtonStandby
        '
        Me.PaddleButtonStandby.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PaddleButtonStandby.BackgroundImage = CType(resources.GetObject("PaddleButtonStandby.BackgroundImage"), System.Drawing.Image)
        Me.PaddleButtonStandby.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PaddleButtonStandby.Location = New System.Drawing.Point(375, 330)
        Me.PaddleButtonStandby.Name = "PaddleButtonStandby"
        Me.PaddleButtonStandby.Size = New System.Drawing.Size(52, 74)
        Me.PaddleButtonStandby.TabIndex = 229
        Me.PaddleButtonStandby.UseVisualStyleBackColor = False
        Me.PaddleButtonStandby.Visible = False
        '
        'SubMergOffButton
        '
        Me.SubMergOffButton.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.SubMergOffButton.BackgroundImage = CType(resources.GetObject("SubMergOffButton.BackgroundImage"), System.Drawing.Image)
        Me.SubMergOffButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SubMergOffButton.Enabled = False
        Me.SubMergOffButton.Location = New System.Drawing.Point(546, 330)
        Me.SubMergOffButton.Name = "SubMergOffButton"
        Me.SubMergOffButton.Size = New System.Drawing.Size(52, 74)
        Me.SubMergOffButton.TabIndex = 230
        Me.SubMergOffButton.UseVisualStyleBackColor = False
        Me.SubMergOffButton.Visible = False
        '
        'OMMCLabel
        '
        Me.OMMCLabel.AutoSize = True
        Me.OMMCLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!)
        Me.OMMCLabel.ForeColor = System.Drawing.Color.Black
        Me.OMMCLabel.Location = New System.Drawing.Point(42, 390)
        Me.OMMCLabel.Name = "OMMCLabel"
        Me.OMMCLabel.Size = New System.Drawing.Size(120, 7)
        Me.OMMCLabel.TabIndex = 233
        Me.OMMCLabel.Text = "OIL MAKEUP MANUAL CONTROLS"
        Me.OMMCLabel.Visible = False
        '
        'OilMakeupCloseButton
        '
        Me.OilMakeupCloseButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.OilMakeupCloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.OilMakeupCloseButton.ForeColor = System.Drawing.Color.Black
        Me.OilMakeupCloseButton.Location = New System.Drawing.Point(103, 402)
        Me.OilMakeupCloseButton.Name = "OilMakeupCloseButton"
        Me.OilMakeupCloseButton.Size = New System.Drawing.Size(59, 29)
        Me.OilMakeupCloseButton.TabIndex = 232
        Me.OilMakeupCloseButton.Text = "CLOSE"
        Me.OilMakeupCloseButton.UseVisualStyleBackColor = False
        Me.OilMakeupCloseButton.Visible = False
        '
        'OilMakeupOpenButton
        '
        Me.OilMakeupOpenButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.OilMakeupOpenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.OilMakeupOpenButton.ForeColor = System.Drawing.Color.Black
        Me.OilMakeupOpenButton.Location = New System.Drawing.Point(38, 401)
        Me.OilMakeupOpenButton.Name = "OilMakeupOpenButton"
        Me.OilMakeupOpenButton.Size = New System.Drawing.Size(59, 29)
        Me.OilMakeupOpenButton.TabIndex = 231
        Me.OilMakeupOpenButton.Text = "OPEN"
        Me.OilMakeupOpenButton.UseVisualStyleBackColor = False
        Me.OilMakeupOpenButton.Visible = False
        '
        'ValveOpenImage
        '
        Me.ValveOpenImage.BackgroundImage = Global.PC42VB.My.Resources.Resources.pngwingON1
        Me.ValveOpenImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ValveOpenImage.Location = New System.Drawing.Point(183, 336)
        Me.ValveOpenImage.Name = "ValveOpenImage"
        Me.ValveOpenImage.Size = New System.Drawing.Size(48, 51)
        Me.ValveOpenImage.TabIndex = 234
        Me.ValveOpenImage.TabStop = False
        '
        'FryerButtonScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(972, 663)
        Me.ControlBox = False
        Me.Controls.Add(Me.ValveOpenImage)
        Me.Controls.Add(Me.OMMCLabel)
        Me.Controls.Add(Me.OilMakeupCloseButton)
        Me.Controls.Add(Me.OilMakeupOpenButton)
        Me.Controls.Add(Me.SubMergOffButton)
        Me.Controls.Add(Me.FryerCloseButton)
        Me.Controls.Add(Me.MainOilPumpStandby)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PaddleButtonOn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.MainOilPumpOn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ValveCloseImage)
        Me.Controls.Add(Me.OMAutoOnImage)
        Me.Controls.Add(Me.RejectGateManualButton)
        Me.Controls.Add(Me.OilMakeupAutoButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PaddleButtonStandby)
        Me.Controls.Add(Me.SubMergOnButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(12, 32)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FryerButtonScreen"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        CType(Me.OMAutoOnImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValveCloseImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValveOpenImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents OMAutoOnImage As PictureBox
    Friend WithEvents RejectGateManualButton As Button
    Friend WithEvents OilMakeupAutoButton As Button
    Friend WithEvents ValveCloseImage As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents MainOilPumpOn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PaddleButtonOn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents SubMergOnButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents MainOilPumpStandby As Button
    Friend WithEvents FryerCloseButton As Button
    Friend WithEvents PaddleButtonStandby As Button
    Friend WithEvents SubMergOffButton As Button
    Friend WithEvents OMMCLabel As Label
    Friend WithEvents OilMakeupCloseButton As Button
    Friend WithEvents OilMakeupOpenButton As Button
    Friend WithEvents ValveOpenImage As PictureBox
End Class
