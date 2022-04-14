<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainOilPumpDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MainOilPumpStopButton = New System.Windows.Forms.Button()
        Me.MainOilPumpStartButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.MOPIND4 = New System.Windows.Forms.Panel()
        Me.MOPIND3 = New System.Windows.Forms.Panel()
        Me.MOPIND2 = New System.Windows.Forms.Panel()
        Me.MOPIND1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'MainOilPumpStopButton
        '
        Me.MainOilPumpStopButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MainOilPumpStopButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.MainOilPumpStopButton.ForeColor = System.Drawing.Color.Red
        Me.MainOilPumpStopButton.Location = New System.Drawing.Point(6, 288)
        Me.MainOilPumpStopButton.Name = "MainOilPumpStopButton"
        Me.MainOilPumpStopButton.Size = New System.Drawing.Size(65, 35)
        Me.MainOilPumpStopButton.TabIndex = 50
        Me.MainOilPumpStopButton.Text = "STOP"
        Me.MainOilPumpStopButton.UseVisualStyleBackColor = False
        '
        'MainOilPumpStartButton
        '
        Me.MainOilPumpStartButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MainOilPumpStartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.MainOilPumpStartButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MainOilPumpStartButton.Location = New System.Drawing.Point(78, 288)
        Me.MainOilPumpStartButton.Name = "MainOilPumpStartButton"
        Me.MainOilPumpStartButton.Size = New System.Drawing.Size(63, 35)
        Me.MainOilPumpStartButton.TabIndex = 51
        Me.MainOilPumpStartButton.Text = "START"
        Me.MainOilPumpStartButton.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.CloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CloseButton.Location = New System.Drawing.Point(176, 288)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(63, 35)
        Me.CloseButton.TabIndex = 52
        Me.CloseButton.Text = "CLOSE"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'MOPIND4
        '
        Me.MOPIND4.BackColor = System.Drawing.Color.Red
        Me.MOPIND4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MOPIND4.Location = New System.Drawing.Point(6, 225)
        Me.MOPIND4.Name = "MOPIND4"
        Me.MOPIND4.Size = New System.Drawing.Size(234, 39)
        Me.MOPIND4.TabIndex = 53
        '
        'MOPIND3
        '
        Me.MOPIND3.BackColor = System.Drawing.Color.Red
        Me.MOPIND3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MOPIND3.Location = New System.Drawing.Point(6, 150)
        Me.MOPIND3.Name = "MOPIND3"
        Me.MOPIND3.Size = New System.Drawing.Size(234, 39)
        Me.MOPIND3.TabIndex = 54
        '
        'MOPIND2
        '
        Me.MOPIND2.BackColor = System.Drawing.Color.Red
        Me.MOPIND2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MOPIND2.Location = New System.Drawing.Point(8, 77)
        Me.MOPIND2.Name = "MOPIND2"
        Me.MOPIND2.Size = New System.Drawing.Size(234, 39)
        Me.MOPIND2.TabIndex = 55
        '
        'MOPIND1
        '
        Me.MOPIND1.BackColor = System.Drawing.Color.Red
        Me.MOPIND1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MOPIND1.Location = New System.Drawing.Point(8, 11)
        Me.MOPIND1.Name = "MOPIND1"
        Me.MOPIND1.Size = New System.Drawing.Size(234, 39)
        Me.MOPIND1.TabIndex = 56
        '
        'MainOilPumpDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 338)
        Me.ControlBox = False
        Me.Controls.Add(Me.MOPIND1)
        Me.Controls.Add(Me.MOPIND2)
        Me.Controls.Add(Me.MOPIND3)
        Me.Controls.Add(Me.MOPIND4)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.MainOilPumpStopButton)
        Me.Controls.Add(Me.MainOilPumpStartButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(100, 0)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainOilPumpDialog"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Oil Pump"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainOilPumpStopButton As Button
    Friend WithEvents MainOilPumpStartButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents MOPIND4 As Panel
    Friend WithEvents MOPIND3 As Panel
    Friend WithEvents MOPIND2 As Panel
    Friend WithEvents MOPIND1 As Panel
End Class
