<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HorseRacing
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblHorse5Wins = New System.Windows.Forms.Label()
        Me.lblHorse4Wins = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblHorse3Wins = New System.Windows.Forms.Label()
        Me.lblHorse2Wins = New System.Windows.Forms.Label()
        Me.lblHorse1Wins = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnRace = New System.Windows.Forms.Button()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBet = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radHorse5 = New System.Windows.Forms.RadioButton()
        Me.radHorse4 = New System.Windows.Forms.RadioButton()
        Me.radHorse3 = New System.Windows.Forms.RadioButton()
        Me.radHorse2 = New System.Windows.Forms.RadioButton()
        Me.radHorse1 = New System.Windows.Forms.RadioButton()
        Me.picHorse1 = New System.Windows.Forms.PictureBox()
        Me.picHorse2 = New System.Windows.Forms.PictureBox()
        Me.picHorse3 = New System.Windows.Forms.PictureBox()
        Me.picHorse4 = New System.Windows.Forms.PictureBox()
        Me.picHorse5 = New System.Windows.Forms.PictureBox()
        Me.picBackrground = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picHorse1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHorse2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHorse3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHorse4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHorse5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackrground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.Controls.Add(Me.btnRestart)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.btnRace)
        Me.GroupBox1.Controls.Add(Me.lblMoney)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtBet)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 350)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(815, 108)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(15, 85)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(85, 23)
        Me.btnRestart.TabIndex = 7
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblHorse5Wins)
        Me.GroupBox3.Controls.Add(Me.lblHorse4Wins)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.lblHorse3Wins)
        Me.GroupBox3.Controls.Add(Me.lblHorse2Wins)
        Me.GroupBox3.Controls.Add(Me.lblHorse1Wins)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(396, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(223, 89)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total Wins:"
        '
        'lblHorse5Wins
        '
        Me.lblHorse5Wins.BackColor = System.Drawing.Color.White
        Me.lblHorse5Wins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHorse5Wins.Location = New System.Drawing.Point(194, 45)
        Me.lblHorse5Wins.Name = "lblHorse5Wins"
        Me.lblHorse5Wins.Size = New System.Drawing.Size(22, 16)
        Me.lblHorse5Wins.TabIndex = 9
        '
        'lblHorse4Wins
        '
        Me.lblHorse4Wins.BackColor = System.Drawing.Color.White
        Me.lblHorse4Wins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHorse4Wins.Location = New System.Drawing.Point(194, 20)
        Me.lblHorse4Wins.Name = "lblHorse4Wins"
        Me.lblHorse4Wins.Size = New System.Drawing.Size(22, 16)
        Me.lblHorse4Wins.TabIndex = 8
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(96, 45)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(92, 13)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "California Chrome:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(120, 22)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 13)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Exterminator:"
        '
        'lblHorse3Wins
        '
        Me.lblHorse3Wins.BackColor = System.Drawing.Color.White
        Me.lblHorse3Wins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHorse3Wins.Location = New System.Drawing.Point(68, 64)
        Me.lblHorse3Wins.Name = "lblHorse3Wins"
        Me.lblHorse3Wins.Size = New System.Drawing.Size(22, 15)
        Me.lblHorse3Wins.TabIndex = 5
        '
        'lblHorse2Wins
        '
        Me.lblHorse2Wins.BackColor = System.Drawing.Color.White
        Me.lblHorse2Wins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHorse2Wins.Location = New System.Drawing.Point(68, 42)
        Me.lblHorse2Wins.Name = "lblHorse2Wins"
        Me.lblHorse2Wins.Size = New System.Drawing.Size(22, 15)
        Me.lblHorse2Wins.TabIndex = 4
        '
        'lblHorse1Wins
        '
        Me.lblHorse1Wins.BackColor = System.Drawing.Color.White
        Me.lblHorse1Wins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHorse1Wins.Location = New System.Drawing.Point(68, 20)
        Me.lblHorse1Wins.Name = "lblHorse1Wins"
        Me.lblHorse1Wins.Size = New System.Drawing.Size(22, 16)
        Me.lblHorse1Wins.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Seabiscut:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 44)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Man o' War:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Secretariat:"
        '
        'btnRace
        '
        Me.btnRace.Location = New System.Drawing.Point(15, 61)
        Me.btnRace.Name = "btnRace"
        Me.btnRace.Size = New System.Drawing.Size(85, 23)
        Me.btnRace.TabIndex = 5
        Me.btnRace.Text = "Race!"
        Me.btnRace.UseVisualStyleBackColor = True
        '
        'lblMoney
        '
        Me.lblMoney.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMoney.Location = New System.Drawing.Point(50, 13)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(72, 19)
        Me.lblMoney.TabIndex = 4
        Me.lblMoney.Text = "50.0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Money:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bet:"
        '
        'txtBet
        '
        Me.txtBet.Location = New System.Drawing.Point(50, 35)
        Me.txtBet.Name = "txtBet"
        Me.txtBet.Size = New System.Drawing.Size(72, 20)
        Me.txtBet.TabIndex = 1
        Me.txtBet.Text = "0.00"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radHorse5)
        Me.GroupBox2.Controls.Add(Me.radHorse4)
        Me.GroupBox2.Controls.Add(Me.radHorse3)
        Me.GroupBox2.Controls.Add(Me.radHorse2)
        Me.GroupBox2.Controls.Add(Me.radHorse1)
        Me.GroupBox2.Location = New System.Drawing.Point(168, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(222, 89)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Place Your Bets!"
        '
        'radHorse5
        '
        Me.radHorse5.AutoSize = True
        Me.radHorse5.Location = New System.Drawing.Point(102, 43)
        Me.radHorse5.Name = "radHorse5"
        Me.radHorse5.Size = New System.Drawing.Size(107, 17)
        Me.radHorse5.TabIndex = 4
        Me.radHorse5.TabStop = True
        Me.radHorse5.Text = "California Chrome"
        Me.radHorse5.UseVisualStyleBackColor = True
        '
        'radHorse4
        '
        Me.radHorse4.AutoSize = True
        Me.radHorse4.Location = New System.Drawing.Point(102, 19)
        Me.radHorse4.Name = "radHorse4"
        Me.radHorse4.Size = New System.Drawing.Size(83, 17)
        Me.radHorse4.TabIndex = 3
        Me.radHorse4.TabStop = True
        Me.radHorse4.Text = "Exterminator"
        Me.radHorse4.UseVisualStyleBackColor = True
        '
        'radHorse3
        '
        Me.radHorse3.AutoSize = True
        Me.radHorse3.Location = New System.Drawing.Point(6, 66)
        Me.radHorse3.Name = "radHorse3"
        Me.radHorse3.Size = New System.Drawing.Size(72, 17)
        Me.radHorse3.TabIndex = 2
        Me.radHorse3.TabStop = True
        Me.radHorse3.Text = "Seabiscut"
        Me.radHorse3.UseVisualStyleBackColor = True
        '
        'radHorse2
        '
        Me.radHorse2.AutoSize = True
        Me.radHorse2.Location = New System.Drawing.Point(6, 44)
        Me.radHorse2.Name = "radHorse2"
        Me.radHorse2.Size = New System.Drawing.Size(80, 17)
        Me.radHorse2.TabIndex = 1
        Me.radHorse2.TabStop = True
        Me.radHorse2.Text = "Man o' War"
        Me.radHorse2.UseVisualStyleBackColor = True
        '
        'radHorse1
        '
        Me.radHorse1.AutoSize = True
        Me.radHorse1.Location = New System.Drawing.Point(6, 19)
        Me.radHorse1.Name = "radHorse1"
        Me.radHorse1.Size = New System.Drawing.Size(76, 17)
        Me.radHorse1.TabIndex = 0
        Me.radHorse1.TabStop = True
        Me.radHorse1.Text = "Secretariat"
        Me.radHorse1.UseVisualStyleBackColor = True
        '
        'picHorse1
        '
        Me.picHorse1.BackColor = System.Drawing.Color.White
        Me.picHorse1.Location = New System.Drawing.Point(12, 12)
        Me.picHorse1.Name = "picHorse1"
        Me.picHorse1.Size = New System.Drawing.Size(100, 50)
        Me.picHorse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHorse1.TabIndex = 1
        Me.picHorse1.TabStop = False
        '
        'picHorse2
        '
        Me.picHorse2.Location = New System.Drawing.Point(12, 80)
        Me.picHorse2.Name = "picHorse2"
        Me.picHorse2.Size = New System.Drawing.Size(100, 50)
        Me.picHorse2.TabIndex = 2
        Me.picHorse2.TabStop = False
        '
        'picHorse3
        '
        Me.picHorse3.Location = New System.Drawing.Point(12, 145)
        Me.picHorse3.Name = "picHorse3"
        Me.picHorse3.Size = New System.Drawing.Size(100, 50)
        Me.picHorse3.TabIndex = 3
        Me.picHorse3.TabStop = False
        '
        'picHorse4
        '
        Me.picHorse4.Location = New System.Drawing.Point(12, 210)
        Me.picHorse4.Name = "picHorse4"
        Me.picHorse4.Size = New System.Drawing.Size(100, 50)
        Me.picHorse4.TabIndex = 4
        Me.picHorse4.TabStop = False
        '
        'picHorse5
        '
        Me.picHorse5.Location = New System.Drawing.Point(12, 278)
        Me.picHorse5.Name = "picHorse5"
        Me.picHorse5.Size = New System.Drawing.Size(100, 50)
        Me.picHorse5.TabIndex = 5
        Me.picHorse5.TabStop = False
        '
        'picBackrground
        '
        Me.picBackrground.BackColor = System.Drawing.Color.DarkGreen
        Me.picBackrground.Location = New System.Drawing.Point(-1, 0)
        Me.picBackrground.Name = "picBackrground"
        Me.picBackrground.Size = New System.Drawing.Size(840, 479)
        Me.picBackrground.TabIndex = 6
        Me.picBackrground.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(-4, -1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(843, 10)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(-4, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(843, 10)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(-4, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(843, 10)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(-4, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(843, 10)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(-4, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(843, 10)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(-4, 331)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(843, 10)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(154, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 332)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Label9"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(166, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 31)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "1"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(166, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 31)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "2"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(166, 155)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 31)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "3"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(166, 219)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 31)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "4"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(166, 287)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 31)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "5"
        '
        'HorseRacing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 470)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picHorse5)
        Me.Controls.Add(Me.picHorse4)
        Me.Controls.Add(Me.picHorse3)
        Me.Controls.Add(Me.picHorse2)
        Me.Controls.Add(Me.picHorse1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.picBackrground)
        Me.Name = "HorseRacing"
        Me.Text = "HorseRacing"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picHorse1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHorse2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHorse3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHorse4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHorse5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackrground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMoney As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBet As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents picHorse1 As System.Windows.Forms.PictureBox
    Friend WithEvents picHorse2 As System.Windows.Forms.PictureBox
    Friend WithEvents picHorse3 As System.Windows.Forms.PictureBox
    Friend WithEvents picHorse4 As System.Windows.Forms.PictureBox
    Friend WithEvents picHorse5 As System.Windows.Forms.PictureBox
    Friend WithEvents picBackrground As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents radHorse5 As System.Windows.Forms.RadioButton
    Friend WithEvents radHorse4 As System.Windows.Forms.RadioButton
    Friend WithEvents radHorse3 As System.Windows.Forms.RadioButton
    Friend WithEvents radHorse2 As System.Windows.Forms.RadioButton
    Friend WithEvents radHorse1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnRace As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblHorse5Wins As System.Windows.Forms.Label
    Friend WithEvents lblHorse4Wins As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblHorse3Wins As System.Windows.Forms.Label
    Friend WithEvents lblHorse2Wins As System.Windows.Forms.Label
    Friend WithEvents lblHorse1Wins As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnRestart As System.Windows.Forms.Button
End Class
