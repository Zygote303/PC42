<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TutorialSelectionPanelForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TutorialSelectionPanelForm))
        Me.Label107 = New System.Windows.Forms.Label()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FOITStart = New System.Windows.Forms.Button()
        Me.FOHMIStart = New System.Windows.Forms.Button()
        Me.CFSTStart = New System.Windows.Forms.Button()
        Me.TutorialSelectExitButton = New System.Windows.Forms.Button()
        Me.ContFryerSimButton = New System.Windows.Forms.Button()
        Me.FryerHMIINtroButton = New System.Windows.Forms.Button()
        Me.FryerOpsIntroButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label107
        '
        Me.Label107.BackColor = System.Drawing.Color.Gray
        Me.Label107.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label107.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label107.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label107.ForeColor = System.Drawing.Color.Yellow
        Me.Label107.Location = New System.Drawing.Point(13, 91)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(114, 18)
        Me.Label107.TabIndex = 7
        Me.Label107.Text = "Fryer HMI Tutorial"
        Me.Label107.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label97
        '
        Me.Label97.BackColor = System.Drawing.Color.Gray
        Me.Label97.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label97.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label97.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.ForeColor = System.Drawing.Color.Yellow
        Me.Label97.Location = New System.Drawing.Point(154, 91)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(114, 18)
        Me.Label97.TabIndex = 5
        Me.Label97.Text = "Operator Tutorial"
        Me.Label97.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Enabled = False
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(298, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Simulation Tutorial"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FOITStart
        '
        Me.FOITStart.Location = New System.Drawing.Point(150, 111)
        Me.FOITStart.Name = "FOITStart"
        Me.FOITStart.Size = New System.Drawing.Size(121, 23)
        Me.FOITStart.TabIndex = 10
        Me.FOITStart.Text = "START"
        Me.FOITStart.UseVisualStyleBackColor = True
        '
        'FOHMIStart
        '
        Me.FOHMIStart.Location = New System.Drawing.Point(9, 111)
        Me.FOHMIStart.Name = "FOHMIStart"
        Me.FOHMIStart.Size = New System.Drawing.Size(121, 23)
        Me.FOHMIStart.TabIndex = 11
        Me.FOHMIStart.Text = "START"
        Me.FOHMIStart.UseVisualStyleBackColor = True
        '
        'CFSTStart
        '
        Me.CFSTStart.Enabled = False
        Me.CFSTStart.Location = New System.Drawing.Point(294, 111)
        Me.CFSTStart.Name = "CFSTStart"
        Me.CFSTStart.Size = New System.Drawing.Size(121, 23)
        Me.CFSTStart.TabIndex = 12
        Me.CFSTStart.Text = "START"
        Me.CFSTStart.UseVisualStyleBackColor = True
        '
        'TutorialSelectExitButton
        '
        Me.TutorialSelectExitButton.Location = New System.Drawing.Point(174, 147)
        Me.TutorialSelectExitButton.Name = "TutorialSelectExitButton"
        Me.TutorialSelectExitButton.Size = New System.Drawing.Size(69, 23)
        Me.TutorialSelectExitButton.TabIndex = 13
        Me.TutorialSelectExitButton.Text = "EXIT"
        Me.TutorialSelectExitButton.UseVisualStyleBackColor = True
        '
        'ContFryerSimButton
        '
        Me.ContFryerSimButton.BackgroundImage = CType(resources.GetObject("ContFryerSimButton.BackgroundImage"), System.Drawing.Image)
        Me.ContFryerSimButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ContFryerSimButton.Enabled = False
        Me.ContFryerSimButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ContFryerSimButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.ContFryerSimButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContFryerSimButton.ForeColor = System.Drawing.Color.Black
        Me.ContFryerSimButton.Location = New System.Drawing.Point(294, 12)
        Me.ContFryerSimButton.Name = "ContFryerSimButton"
        Me.ContFryerSimButton.Size = New System.Drawing.Size(121, 99)
        Me.ContFryerSimButton.TabIndex = 8
        Me.ContFryerSimButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ContFryerSimButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ContFryerSimButton.UseVisualStyleBackColor = True
        '
        'FryerHMIINtroButton
        '
        Me.FryerHMIINtroButton.BackColor = System.Drawing.Color.Transparent
        Me.FryerHMIINtroButton.BackgroundImage = CType(resources.GetObject("FryerHMIINtroButton.BackgroundImage"), System.Drawing.Image)
        Me.FryerHMIINtroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FryerHMIINtroButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.FryerHMIINtroButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.FryerHMIINtroButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FryerHMIINtroButton.ForeColor = System.Drawing.Color.Black
        Me.FryerHMIINtroButton.Location = New System.Drawing.Point(9, 12)
        Me.FryerHMIINtroButton.Name = "FryerHMIINtroButton"
        Me.FryerHMIINtroButton.Size = New System.Drawing.Size(121, 99)
        Me.FryerHMIINtroButton.TabIndex = 6
        Me.FryerHMIINtroButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FryerHMIINtroButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.FryerHMIINtroButton.UseVisualStyleBackColor = False
        '
        'FryerOpsIntroButton
        '
        Me.FryerOpsIntroButton.BackgroundImage = CType(resources.GetObject("FryerOpsIntroButton.BackgroundImage"), System.Drawing.Image)
        Me.FryerOpsIntroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FryerOpsIntroButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.FryerOpsIntroButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.FryerOpsIntroButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FryerOpsIntroButton.ForeColor = System.Drawing.Color.Black
        Me.FryerOpsIntroButton.Location = New System.Drawing.Point(150, 12)
        Me.FryerOpsIntroButton.Name = "FryerOpsIntroButton"
        Me.FryerOpsIntroButton.Size = New System.Drawing.Size(121, 99)
        Me.FryerOpsIntroButton.TabIndex = 4
        Me.FryerOpsIntroButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FryerOpsIntroButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.FryerOpsIntroButton.UseVisualStyleBackColor = True
        '
        'TutorialSelectionPanelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(422, 180)
        Me.ControlBox = False
        Me.Controls.Add(Me.TutorialSelectExitButton)
        Me.Controls.Add(Me.CFSTStart)
        Me.Controls.Add(Me.FOHMIStart)
        Me.Controls.Add(Me.FOITStart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ContFryerSimButton)
        Me.Controls.Add(Me.Label107)
        Me.Controls.Add(Me.FryerHMIINtroButton)
        Me.Controls.Add(Me.Label97)
        Me.Controls.Add(Me.FryerOpsIntroButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TutorialSelectionPanelForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SELECT TUTORIAL"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label107 As Label
    Friend WithEvents FryerHMIINtroButton As Button
    Friend WithEvents Label97 As Label
    Friend WithEvents FryerOpsIntroButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ContFryerSimButton As Button
    Friend WithEvents FOITStart As Button
    Friend WithEvents FOHMIStart As Button
    Friend WithEvents CFSTStart As Button
    Friend WithEvents TutorialSelectExitButton As Button
End Class
