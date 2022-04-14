<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubmergerForm
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
        Me.SIND1 = New System.Windows.Forms.Panel()
        Me.SIND2 = New System.Windows.Forms.Panel()
        Me.SIND3 = New System.Windows.Forms.Panel()
        Me.SIND4 = New System.Windows.Forms.Panel()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SubMergerStopButton = New System.Windows.Forms.Button()
        Me.SubmergerStartButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SIND1
        '
        Me.SIND1.BackColor = System.Drawing.Color.Red
        Me.SIND1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SIND1.Location = New System.Drawing.Point(7, 13)
        Me.SIND1.Name = "SIND1"
        Me.SIND1.Size = New System.Drawing.Size(234, 39)
        Me.SIND1.TabIndex = 63
        '
        'SIND2
        '
        Me.SIND2.BackColor = System.Drawing.Color.Red
        Me.SIND2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SIND2.Location = New System.Drawing.Point(7, 79)
        Me.SIND2.Name = "SIND2"
        Me.SIND2.Size = New System.Drawing.Size(234, 39)
        Me.SIND2.TabIndex = 62
        '
        'SIND3
        '
        Me.SIND3.BackColor = System.Drawing.Color.Red
        Me.SIND3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SIND3.Location = New System.Drawing.Point(5, 152)
        Me.SIND3.Name = "SIND3"
        Me.SIND3.Size = New System.Drawing.Size(234, 39)
        Me.SIND3.TabIndex = 61
        '
        'SIND4
        '
        Me.SIND4.BackColor = System.Drawing.Color.Red
        Me.SIND4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SIND4.Location = New System.Drawing.Point(5, 227)
        Me.SIND4.Name = "SIND4"
        Me.SIND4.Size = New System.Drawing.Size(234, 39)
        Me.SIND4.TabIndex = 60
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.CloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CloseButton.Location = New System.Drawing.Point(175, 290)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(63, 35)
        Me.CloseButton.TabIndex = 59
        Me.CloseButton.Text = "CLOSE"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'SubMergerStopButton
        '
        Me.SubMergerStopButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SubMergerStopButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.SubMergerStopButton.ForeColor = System.Drawing.Color.Red
        Me.SubMergerStopButton.Location = New System.Drawing.Point(5, 290)
        Me.SubMergerStopButton.Name = "SubMergerStopButton"
        Me.SubMergerStopButton.Size = New System.Drawing.Size(65, 35)
        Me.SubMergerStopButton.TabIndex = 57
        Me.SubMergerStopButton.Text = "STOP"
        Me.SubMergerStopButton.UseVisualStyleBackColor = False
        '
        'SubmergerStartButton
        '
        Me.SubmergerStartButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SubmergerStartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.SubmergerStartButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SubmergerStartButton.Location = New System.Drawing.Point(77, 290)
        Me.SubmergerStartButton.Name = "SubmergerStartButton"
        Me.SubmergerStartButton.Size = New System.Drawing.Size(63, 35)
        Me.SubmergerStartButton.TabIndex = 58
        Me.SubmergerStartButton.Text = "START"
        Me.SubmergerStartButton.UseVisualStyleBackColor = False
        '
        'SubmergerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 338)
        Me.ControlBox = False
        Me.Controls.Add(Me.SIND1)
        Me.Controls.Add(Me.SIND2)
        Me.Controls.Add(Me.SIND3)
        Me.Controls.Add(Me.SIND4)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.SubMergerStopButton)
        Me.Controls.Add(Me.SubmergerStartButton)
        Me.Name = "SubmergerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Submerger"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SIND1 As Panel
    Friend WithEvents SIND2 As Panel
    Friend WithEvents SIND3 As Panel
    Friend WithEvents SIND4 As Panel
    Friend WithEvents CloseButton As Button
    Friend WithEvents SubMergerStopButton As Button
    Friend WithEvents SubmergerStartButton As Button
End Class
