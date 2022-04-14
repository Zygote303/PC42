<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaddlesForm
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
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.PaddleStopButton = New System.Windows.Forms.Button()
        Me.PaddleStartButton = New System.Windows.Forms.Button()
        Me.PBIND1 = New System.Windows.Forms.Panel()
        Me.PBIND2 = New System.Windows.Forms.Panel()
        Me.PBIND3 = New System.Windows.Forms.Panel()
        Me.PBIND4 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.CloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CloseButton.Location = New System.Drawing.Point(174, 297)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(63, 35)
        Me.CloseButton.TabIndex = 55
        Me.CloseButton.Text = "CLOSE"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'PaddleStopButton
        '
        Me.PaddleStopButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PaddleStopButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.PaddleStopButton.ForeColor = System.Drawing.Color.Red
        Me.PaddleStopButton.Location = New System.Drawing.Point(8, 297)
        Me.PaddleStopButton.Name = "PaddleStopButton"
        Me.PaddleStopButton.Size = New System.Drawing.Size(65, 35)
        Me.PaddleStopButton.TabIndex = 53
        Me.PaddleStopButton.Text = "STOP"
        Me.PaddleStopButton.UseVisualStyleBackColor = False
        '
        'PaddleStartButton
        '
        Me.PaddleStartButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PaddleStartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.PaddleStartButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PaddleStartButton.Location = New System.Drawing.Point(80, 297)
        Me.PaddleStartButton.Name = "PaddleStartButton"
        Me.PaddleStartButton.Size = New System.Drawing.Size(63, 35)
        Me.PaddleStartButton.TabIndex = 54
        Me.PaddleStartButton.Text = "START"
        Me.PaddleStartButton.UseVisualStyleBackColor = False
        '
        'PBIND1
        '
        Me.PBIND1.BackColor = System.Drawing.Color.Red
        Me.PBIND1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PBIND1.Location = New System.Drawing.Point(6, 21)
        Me.PBIND1.Name = "PBIND1"
        Me.PBIND1.Size = New System.Drawing.Size(234, 39)
        Me.PBIND1.TabIndex = 60
        '
        'PBIND2
        '
        Me.PBIND2.BackColor = System.Drawing.Color.Red
        Me.PBIND2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PBIND2.Location = New System.Drawing.Point(6, 87)
        Me.PBIND2.Name = "PBIND2"
        Me.PBIND2.Size = New System.Drawing.Size(234, 39)
        Me.PBIND2.TabIndex = 59
        '
        'PBIND3
        '
        Me.PBIND3.BackColor = System.Drawing.Color.Red
        Me.PBIND3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PBIND3.Location = New System.Drawing.Point(4, 160)
        Me.PBIND3.Name = "PBIND3"
        Me.PBIND3.Size = New System.Drawing.Size(234, 39)
        Me.PBIND3.TabIndex = 58
        '
        'PBIND4
        '
        Me.PBIND4.BackColor = System.Drawing.Color.Red
        Me.PBIND4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PBIND4.Location = New System.Drawing.Point(4, 235)
        Me.PBIND4.Name = "PBIND4"
        Me.PBIND4.Size = New System.Drawing.Size(234, 39)
        Me.PBIND4.TabIndex = 57
        '
        'PaddlesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 338)
        Me.ControlBox = False
        Me.Controls.Add(Me.PBIND1)
        Me.Controls.Add(Me.PBIND2)
        Me.Controls.Add(Me.PBIND3)
        Me.Controls.Add(Me.PBIND4)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.PaddleStopButton)
        Me.Controls.Add(Me.PaddleStartButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PaddlesForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paddles"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CloseButton As Button
    Friend WithEvents PaddleStopButton As Button
    Friend WithEvents PaddleStartButton As Button
    Friend WithEvents PBIND1 As Panel
    Friend WithEvents PBIND2 As Panel
    Friend WithEvents PBIND3 As Panel
    Friend WithEvents PBIND4 As Panel
End Class
