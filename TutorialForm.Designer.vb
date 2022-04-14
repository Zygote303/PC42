<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FryerHMITutForm
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
        Me.FryerHMITutCloseButton = New System.Windows.Forms.Button()
        Me.FryerHMITutNextButton = New System.Windows.Forms.Button()
        Me.FryerHMITutPrevButton = New System.Windows.Forms.Button()
        Me.PageNumberText = New System.Windows.Forms.TextBox()
        Me.TutorialHeadingLabel = New System.Windows.Forms.Label()
        Me.TutorialText = New System.Windows.Forms.Label()
        Me.TutPicbox = New System.Windows.Forms.PictureBox()
        CType(Me.TutPicbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FryerHMITutCloseButton
        '
        Me.FryerHMITutCloseButton.Location = New System.Drawing.Point(231, 480)
        Me.FryerHMITutCloseButton.Name = "FryerHMITutCloseButton"
        Me.FryerHMITutCloseButton.Size = New System.Drawing.Size(75, 23)
        Me.FryerHMITutCloseButton.TabIndex = 0
        Me.FryerHMITutCloseButton.Text = "CLOSE"
        Me.FryerHMITutCloseButton.UseVisualStyleBackColor = True
        '
        'FryerHMITutNextButton
        '
        Me.FryerHMITutNextButton.Location = New System.Drawing.Point(147, 480)
        Me.FryerHMITutNextButton.Name = "FryerHMITutNextButton"
        Me.FryerHMITutNextButton.Size = New System.Drawing.Size(75, 23)
        Me.FryerHMITutNextButton.TabIndex = 1
        Me.FryerHMITutNextButton.Text = "NEXT"
        Me.FryerHMITutNextButton.UseVisualStyleBackColor = True
        '
        'FryerHMITutPrevButton
        '
        Me.FryerHMITutPrevButton.Location = New System.Drawing.Point(11, 480)
        Me.FryerHMITutPrevButton.Name = "FryerHMITutPrevButton"
        Me.FryerHMITutPrevButton.Size = New System.Drawing.Size(75, 23)
        Me.FryerHMITutPrevButton.TabIndex = 2
        Me.FryerHMITutPrevButton.Text = "PREVIOUS"
        Me.FryerHMITutPrevButton.UseVisualStyleBackColor = True
        '
        'PageNumberText
        '
        Me.PageNumberText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageNumberText.Location = New System.Drawing.Point(90, 480)
        Me.PageNumberText.Name = "PageNumberText"
        Me.PageNumberText.ReadOnly = True
        Me.PageNumberText.Size = New System.Drawing.Size(51, 22)
        Me.PageNumberText.TabIndex = 4
        Me.PageNumberText.Text = "1"
        Me.PageNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TutorialHeadingLabel
        '
        Me.TutorialHeadingLabel.BackColor = System.Drawing.Color.Gray
        Me.TutorialHeadingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TutorialHeadingLabel.ForeColor = System.Drawing.Color.Yellow
        Me.TutorialHeadingLabel.Location = New System.Drawing.Point(3, 1)
        Me.TutorialHeadingLabel.Name = "TutorialHeadingLabel"
        Me.TutorialHeadingLabel.Size = New System.Drawing.Size(313, 31)
        Me.TutorialHeadingLabel.TabIndex = 5
        Me.TutorialHeadingLabel.Text = "Label1"
        Me.TutorialHeadingLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'TutorialText
        '
        Me.TutorialText.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TutorialText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TutorialText.Location = New System.Drawing.Point(12, 138)
        Me.TutorialText.Name = "TutorialText"
        Me.TutorialText.Size = New System.Drawing.Size(294, 336)
        Me.TutorialText.TabIndex = 7
        '
        'TutPicbox
        '
        Me.TutPicbox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TutPicbox.Location = New System.Drawing.Point(75, 42)
        Me.TutPicbox.Name = "TutPicbox"
        Me.TutPicbox.Size = New System.Drawing.Size(171, 87)
        Me.TutPicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TutPicbox.TabIndex = 6
        Me.TutPicbox.TabStop = False
        '
        'FryerHMITutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(318, 507)
        Me.ControlBox = False
        Me.Controls.Add(Me.TutorialText)
        Me.Controls.Add(Me.TutPicbox)
        Me.Controls.Add(Me.PageNumberText)
        Me.Controls.Add(Me.FryerHMITutPrevButton)
        Me.Controls.Add(Me.FryerHMITutNextButton)
        Me.Controls.Add(Me.FryerHMITutCloseButton)
        Me.Controls.Add(Me.TutorialHeadingLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(950, 0)
        Me.Name = "FryerHMITutForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Continous Fryer Tutorial"
        Me.TopMost = True
        CType(Me.TutPicbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FryerHMITutCloseButton As Button
    Friend WithEvents FryerHMITutNextButton As Button
    Friend WithEvents FryerHMITutPrevButton As Button
    Friend WithEvents PageNumberText As TextBox
    Friend WithEvents TutorialHeadingLabel As Label
    Friend WithEvents TutPicbox As PictureBox
    Friend WithEvents TutorialText As Label
End Class
