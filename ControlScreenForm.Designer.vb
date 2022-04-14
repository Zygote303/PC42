<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlScreenForm
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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FreeFryerButton = New System.Windows.Forms.Button()
        Me.BasicsButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PAEMemoryGame = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(249, 387)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(120, 39)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "EXIT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(6, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 27)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "FRYER TUTORIAL MODE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(315, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 27)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "FREE FRYER MODE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(417, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 27)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "PAE MEMORY GAME"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Gray
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(9, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 27)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "FFA TESTING"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Gray
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(213, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 27)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "PAE TESTING"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FreeFryerButton
        '
        Me.FreeFryerButton.BackgroundImage = Global.PC42VB.My.Resources.Resources.FryerHMITutPic3
        Me.FreeFryerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FreeFryerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FreeFryerButton.ForeColor = System.Drawing.Color.White
        Me.FreeFryerButton.Location = New System.Drawing.Point(312, 15)
        Me.FreeFryerButton.Name = "FreeFryerButton"
        Me.FreeFryerButton.Size = New System.Drawing.Size(306, 174)
        Me.FreeFryerButton.TabIndex = 1
        Me.FreeFryerButton.UseVisualStyleBackColor = True
        '
        'BasicsButton
        '
        Me.BasicsButton.BackgroundImage = Global.PC42VB.My.Resources.Resources.BurnerJetFlame
        Me.BasicsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BasicsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicsButton.ForeColor = System.Drawing.Color.White
        Me.BasicsButton.Location = New System.Drawing.Point(3, 15)
        Me.BasicsButton.Name = "BasicsButton"
        Me.BasicsButton.Size = New System.Drawing.Size(306, 174)
        Me.BasicsButton.TabIndex = 0
        Me.BasicsButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.PC42VB.My.Resources.Resources.images1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(6, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 174)
        Me.Button1.TabIndex = 14
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.PC42VB.My.Resources.Resources.fresh_fried_crisps
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(210, 192)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(201, 174)
        Me.Button2.TabIndex = 15
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PAEMemoryGame
        '
        Me.PAEMemoryGame.BackgroundImage = Global.PC42VB.My.Resources.Resources.ChipsInPile1
        Me.PAEMemoryGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PAEMemoryGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PAEMemoryGame.ForeColor = System.Drawing.Color.White
        Me.PAEMemoryGame.Location = New System.Drawing.Point(414, 192)
        Me.PAEMemoryGame.Name = "PAEMemoryGame"
        Me.PAEMemoryGame.Size = New System.Drawing.Size(201, 174)
        Me.PAEMemoryGame.TabIndex = 16
        Me.PAEMemoryGame.UseVisualStyleBackColor = True
        '
        'ControlScreenForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(621, 436)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.FreeFryerButton)
        Me.Controls.Add(Me.BasicsButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PAEMemoryGame)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ControlScreenForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BasicsButton As Button
    Friend WithEvents FreeFryerButton As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PAEMemoryGame As Button
End Class
