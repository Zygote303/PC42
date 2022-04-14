<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculatorForm
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
        Me.CalcScreen = New System.Windows.Forms.Label()
        Me.SevenButton = New System.Windows.Forms.Button()
        Me.EightButton = New System.Windows.Forms.Button()
        Me.NineButton = New System.Windows.Forms.Button()
        Me.FourButton = New System.Windows.Forms.Button()
        Me.FiveButton = New System.Windows.Forms.Button()
        Me.SixButton = New System.Windows.Forms.Button()
        Me.OneButton = New System.Windows.Forms.Button()
        Me.TwoButton = New System.Windows.Forms.Button()
        Me.ThreeButton = New System.Windows.Forms.Button()
        Me.DivideButton = New System.Windows.Forms.Button()
        Me.MultiplyButton = New System.Windows.Forms.Button()
        Me.PlusButton = New System.Windows.Forms.Button()
        Me.ZeroButton = New System.Windows.Forms.Button()
        Me.EqualButton = New System.Windows.Forms.Button()
        Me.MemoryButton = New System.Windows.Forms.Button()
        Me.PeriodButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CalcScreen
        '
        Me.CalcScreen.BackColor = System.Drawing.Color.RosyBrown
        Me.CalcScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalcScreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CalcScreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalcScreen.Location = New System.Drawing.Point(6, 6)
        Me.CalcScreen.Name = "CalcScreen"
        Me.CalcScreen.Size = New System.Drawing.Size(108, 23)
        Me.CalcScreen.TabIndex = 0
        Me.CalcScreen.Text = "0"
        Me.CalcScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SevenButton
        '
        Me.SevenButton.Location = New System.Drawing.Point(6, 33)
        Me.SevenButton.Name = "SevenButton"
        Me.SevenButton.Size = New System.Drawing.Size(27, 23)
        Me.SevenButton.TabIndex = 1
        Me.SevenButton.Text = "7"
        Me.SevenButton.UseVisualStyleBackColor = True
        '
        'EightButton
        '
        Me.EightButton.Location = New System.Drawing.Point(33, 33)
        Me.EightButton.Name = "EightButton"
        Me.EightButton.Size = New System.Drawing.Size(27, 23)
        Me.EightButton.TabIndex = 2
        Me.EightButton.Text = "8"
        Me.EightButton.UseVisualStyleBackColor = True
        '
        'NineButton
        '
        Me.NineButton.Location = New System.Drawing.Point(60, 33)
        Me.NineButton.Name = "NineButton"
        Me.NineButton.Size = New System.Drawing.Size(27, 23)
        Me.NineButton.TabIndex = 3
        Me.NineButton.Text = "9"
        Me.NineButton.UseVisualStyleBackColor = True
        '
        'FourButton
        '
        Me.FourButton.Location = New System.Drawing.Point(6, 57)
        Me.FourButton.Name = "FourButton"
        Me.FourButton.Size = New System.Drawing.Size(27, 23)
        Me.FourButton.TabIndex = 4
        Me.FourButton.Text = "4"
        Me.FourButton.UseVisualStyleBackColor = True
        '
        'FiveButton
        '
        Me.FiveButton.Location = New System.Drawing.Point(33, 57)
        Me.FiveButton.Name = "FiveButton"
        Me.FiveButton.Size = New System.Drawing.Size(27, 23)
        Me.FiveButton.TabIndex = 5
        Me.FiveButton.Text = "5"
        Me.FiveButton.UseVisualStyleBackColor = True
        '
        'SixButton
        '
        Me.SixButton.Location = New System.Drawing.Point(60, 57)
        Me.SixButton.Name = "SixButton"
        Me.SixButton.Size = New System.Drawing.Size(27, 23)
        Me.SixButton.TabIndex = 6
        Me.SixButton.Text = "6"
        Me.SixButton.UseVisualStyleBackColor = True
        '
        'OneButton
        '
        Me.OneButton.Location = New System.Drawing.Point(6, 81)
        Me.OneButton.Name = "OneButton"
        Me.OneButton.Size = New System.Drawing.Size(27, 23)
        Me.OneButton.TabIndex = 7
        Me.OneButton.Text = "1"
        Me.OneButton.UseVisualStyleBackColor = True
        '
        'TwoButton
        '
        Me.TwoButton.Location = New System.Drawing.Point(33, 81)
        Me.TwoButton.Name = "TwoButton"
        Me.TwoButton.Size = New System.Drawing.Size(27, 23)
        Me.TwoButton.TabIndex = 8
        Me.TwoButton.Text = "2"
        Me.TwoButton.UseVisualStyleBackColor = True
        '
        'ThreeButton
        '
        Me.ThreeButton.Location = New System.Drawing.Point(60, 81)
        Me.ThreeButton.Name = "ThreeButton"
        Me.ThreeButton.Size = New System.Drawing.Size(27, 23)
        Me.ThreeButton.TabIndex = 9
        Me.ThreeButton.Text = "3"
        Me.ThreeButton.UseVisualStyleBackColor = True
        '
        'DivideButton
        '
        Me.DivideButton.Location = New System.Drawing.Point(87, 33)
        Me.DivideButton.Name = "DivideButton"
        Me.DivideButton.Size = New System.Drawing.Size(27, 23)
        Me.DivideButton.TabIndex = 10
        Me.DivideButton.Text = "/"
        Me.DivideButton.UseVisualStyleBackColor = True
        '
        'MultiplyButton
        '
        Me.MultiplyButton.Location = New System.Drawing.Point(87, 57)
        Me.MultiplyButton.Name = "MultiplyButton"
        Me.MultiplyButton.Size = New System.Drawing.Size(27, 23)
        Me.MultiplyButton.TabIndex = 11
        Me.MultiplyButton.Text = "x"
        Me.MultiplyButton.UseVisualStyleBackColor = True
        '
        'PlusButton
        '
        Me.PlusButton.Location = New System.Drawing.Point(87, 81)
        Me.PlusButton.Name = "PlusButton"
        Me.PlusButton.Size = New System.Drawing.Size(27, 23)
        Me.PlusButton.TabIndex = 12
        Me.PlusButton.Text = "+"
        Me.PlusButton.UseVisualStyleBackColor = True
        '
        'ZeroButton
        '
        Me.ZeroButton.Location = New System.Drawing.Point(6, 105)
        Me.ZeroButton.Name = "ZeroButton"
        Me.ZeroButton.Size = New System.Drawing.Size(27, 23)
        Me.ZeroButton.TabIndex = 14
        Me.ZeroButton.Text = "0"
        Me.ZeroButton.UseVisualStyleBackColor = True
        '
        'EqualButton
        '
        Me.EqualButton.Location = New System.Drawing.Point(60, 105)
        Me.EqualButton.Name = "EqualButton"
        Me.EqualButton.Size = New System.Drawing.Size(27, 23)
        Me.EqualButton.TabIndex = 15
        Me.EqualButton.Text = "="
        Me.EqualButton.UseVisualStyleBackColor = True
        '
        'MemoryButton
        '
        Me.MemoryButton.Location = New System.Drawing.Point(87, 105)
        Me.MemoryButton.Name = "MemoryButton"
        Me.MemoryButton.Size = New System.Drawing.Size(27, 23)
        Me.MemoryButton.TabIndex = 16
        Me.MemoryButton.Text = "C"
        Me.MemoryButton.UseVisualStyleBackColor = True
        '
        'PeriodButton
        '
        Me.PeriodButton.Location = New System.Drawing.Point(33, 105)
        Me.PeriodButton.Name = "PeriodButton"
        Me.PeriodButton.Size = New System.Drawing.Size(27, 23)
        Me.PeriodButton.TabIndex = 17
        Me.PeriodButton.Text = "."
        Me.PeriodButton.UseVisualStyleBackColor = True
        '
        'CalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(121, 134)
        Me.ControlBox = False
        Me.Controls.Add(Me.PeriodButton)
        Me.Controls.Add(Me.MemoryButton)
        Me.Controls.Add(Me.EqualButton)
        Me.Controls.Add(Me.ZeroButton)
        Me.Controls.Add(Me.PlusButton)
        Me.Controls.Add(Me.MultiplyButton)
        Me.Controls.Add(Me.DivideButton)
        Me.Controls.Add(Me.ThreeButton)
        Me.Controls.Add(Me.TwoButton)
        Me.Controls.Add(Me.OneButton)
        Me.Controls.Add(Me.SixButton)
        Me.Controls.Add(Me.FiveButton)
        Me.Controls.Add(Me.FourButton)
        Me.Controls.Add(Me.NineButton)
        Me.Controls.Add(Me.EightButton)
        Me.Controls.Add(Me.SevenButton)
        Me.Controls.Add(Me.CalcScreen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(474, 400)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CalculatorForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Calculator"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CalcScreen As Label
    Friend WithEvents SevenButton As Button
    Friend WithEvents EightButton As Button
    Friend WithEvents NineButton As Button
    Friend WithEvents FourButton As Button
    Friend WithEvents FiveButton As Button
    Friend WithEvents SixButton As Button
    Friend WithEvents OneButton As Button
    Friend WithEvents TwoButton As Button
    Friend WithEvents ThreeButton As Button
    Friend WithEvents DivideButton As Button
    Friend WithEvents MultiplyButton As Button
    Friend WithEvents PlusButton As Button
    Friend WithEvents ZeroButton As Button
    Friend WithEvents EqualButton As Button
    Friend WithEvents MemoryButton As Button
    Friend WithEvents PeriodButton As Button
End Class
