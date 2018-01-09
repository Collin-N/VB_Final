<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AlienInvaderz
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlienInvaderz))
        Me.picTank = New System.Windows.Forms.PictureBox()
        Me.TimerMain = New System.Windows.Forms.Timer(Me.components)
        Me.picMissile = New System.Windows.Forms.PictureBox()
        Me.picInvader1 = New System.Windows.Forms.PictureBox()
        Me.picInvader2 = New System.Windows.Forms.PictureBox()
        Me.picInvader3 = New System.Windows.Forms.PictureBox()
        Me.picInvader4 = New System.Windows.Forms.PictureBox()
        Me.picInvader5 = New System.Windows.Forms.PictureBox()
        Me.picInvader6 = New System.Windows.Forms.PictureBox()
        Me.picInvader7 = New System.Windows.Forms.PictureBox()
        Me.picInvader8 = New System.Windows.Forms.PictureBox()
        Me.picInvader9 = New System.Windows.Forms.PictureBox()
        Me.picInvader10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.TimerScore = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picTank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMissile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvader1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvader2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvader3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvader4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvader5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvader6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvader7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvader8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvader9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvader10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picTank
        '
        Me.picTank.BackColor = System.Drawing.Color.Black
        Me.picTank.BackgroundImage = CType(resources.GetObject("picTank.BackgroundImage"), System.Drawing.Image)
        Me.picTank.Image = CType(resources.GetObject("picTank.Image"), System.Drawing.Image)
        Me.picTank.Location = New System.Drawing.Point(0, 466)
        Me.picTank.Name = "picTank"
        Me.picTank.Size = New System.Drawing.Size(172, 118)
        Me.picTank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTank.TabIndex = 0
        Me.picTank.TabStop = False
        '
        'TimerMain
        '
        Me.TimerMain.Enabled = True
        Me.TimerMain.Interval = 1
        '
        'picMissile
        '
        Me.picMissile.BackColor = System.Drawing.Color.Black
        Me.picMissile.BackgroundImage = CType(resources.GetObject("picMissile.BackgroundImage"), System.Drawing.Image)
        Me.picMissile.Image = CType(resources.GetObject("picMissile.Image"), System.Drawing.Image)
        Me.picMissile.Location = New System.Drawing.Point(51, 369)
        Me.picMissile.Name = "picMissile"
        Me.picMissile.Size = New System.Drawing.Size(30, 75)
        Me.picMissile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMissile.TabIndex = 1
        Me.picMissile.TabStop = False
        '
        'picInvader1
        '
        Me.picInvader1.BackColor = System.Drawing.SystemColors.WindowText
        Me.picInvader1.BackgroundImage = CType(resources.GetObject("picInvader1.BackgroundImage"), System.Drawing.Image)
        Me.picInvader1.Image = CType(resources.GetObject("picInvader1.Image"), System.Drawing.Image)
        Me.picInvader1.Location = New System.Drawing.Point(0, 2)
        Me.picInvader1.Name = "picInvader1"
        Me.picInvader1.Size = New System.Drawing.Size(80, 80)
        Me.picInvader1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInvader1.TabIndex = 2
        Me.picInvader1.TabStop = False
        '
        'picInvader2
        '
        Me.picInvader2.BackColor = System.Drawing.SystemColors.WindowText
        Me.picInvader2.BackgroundImage = CType(resources.GetObject("picInvader2.BackgroundImage"), System.Drawing.Image)
        Me.picInvader2.Image = CType(resources.GetObject("picInvader2.Image"), System.Drawing.Image)
        Me.picInvader2.Location = New System.Drawing.Point(87, 2)
        Me.picInvader2.Name = "picInvader2"
        Me.picInvader2.Size = New System.Drawing.Size(80, 80)
        Me.picInvader2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInvader2.TabIndex = 3
        Me.picInvader2.TabStop = False
        '
        'picInvader3
        '
        Me.picInvader3.BackColor = System.Drawing.SystemColors.WindowText
        Me.picInvader3.BackgroundImage = CType(resources.GetObject("picInvader3.BackgroundImage"), System.Drawing.Image)
        Me.picInvader3.Image = CType(resources.GetObject("picInvader3.Image"), System.Drawing.Image)
        Me.picInvader3.Location = New System.Drawing.Point(173, 2)
        Me.picInvader3.Name = "picInvader3"
        Me.picInvader3.Size = New System.Drawing.Size(80, 80)
        Me.picInvader3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInvader3.TabIndex = 4
        Me.picInvader3.TabStop = False
        '
        'picInvader4
        '
        Me.picInvader4.BackColor = System.Drawing.SystemColors.WindowText
        Me.picInvader4.BackgroundImage = CType(resources.GetObject("picInvader4.BackgroundImage"), System.Drawing.Image)
        Me.picInvader4.Image = CType(resources.GetObject("picInvader4.Image"), System.Drawing.Image)
        Me.picInvader4.Location = New System.Drawing.Point(260, 2)
        Me.picInvader4.Name = "picInvader4"
        Me.picInvader4.Size = New System.Drawing.Size(80, 80)
        Me.picInvader4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInvader4.TabIndex = 5
        Me.picInvader4.TabStop = False
        '
        'picInvader5
        '
        Me.picInvader5.BackColor = System.Drawing.SystemColors.WindowText
        Me.picInvader5.BackgroundImage = CType(resources.GetObject("picInvader5.BackgroundImage"), System.Drawing.Image)
        Me.picInvader5.Image = CType(resources.GetObject("picInvader5.Image"), System.Drawing.Image)
        Me.picInvader5.Location = New System.Drawing.Point(345, 2)
        Me.picInvader5.Name = "picInvader5"
        Me.picInvader5.Size = New System.Drawing.Size(80, 80)
        Me.picInvader5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInvader5.TabIndex = 6
        Me.picInvader5.TabStop = False
        '
        'picInvader6
        '
        Me.picInvader6.BackColor = System.Drawing.SystemColors.WindowText
        Me.picInvader6.BackgroundImage = CType(resources.GetObject("picInvader6.BackgroundImage"), System.Drawing.Image)
        Me.picInvader6.Image = CType(resources.GetObject("picInvader6.Image"), System.Drawing.Image)
        Me.picInvader6.Location = New System.Drawing.Point(430, 2)
        Me.picInvader6.Name = "picInvader6"
        Me.picInvader6.Size = New System.Drawing.Size(80, 80)
        Me.picInvader6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInvader6.TabIndex = 7
        Me.picInvader6.TabStop = False
        '
        'picInvader7
        '
        Me.picInvader7.BackColor = System.Drawing.SystemColors.WindowText
        Me.picInvader7.BackgroundImage = CType(resources.GetObject("picInvader7.BackgroundImage"), System.Drawing.Image)
        Me.picInvader7.Image = CType(resources.GetObject("picInvader7.Image"), System.Drawing.Image)
        Me.picInvader7.Location = New System.Drawing.Point(518, 2)
        Me.picInvader7.Name = "picInvader7"
        Me.picInvader7.Size = New System.Drawing.Size(80, 80)
        Me.picInvader7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInvader7.TabIndex = 8
        Me.picInvader7.TabStop = False
        '
        'picInvader8
        '
        Me.picInvader8.BackColor = System.Drawing.SystemColors.WindowText
        Me.picInvader8.BackgroundImage = CType(resources.GetObject("picInvader8.BackgroundImage"), System.Drawing.Image)
        Me.picInvader8.Image = CType(resources.GetObject("picInvader8.Image"), System.Drawing.Image)
        Me.picInvader8.Location = New System.Drawing.Point(603, 2)
        Me.picInvader8.Name = "picInvader8"
        Me.picInvader8.Size = New System.Drawing.Size(80, 80)
        Me.picInvader8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInvader8.TabIndex = 9
        Me.picInvader8.TabStop = False
        '
        'picInvader9
        '
        Me.picInvader9.BackColor = System.Drawing.SystemColors.WindowText
        Me.picInvader9.BackgroundImage = CType(resources.GetObject("picInvader9.BackgroundImage"), System.Drawing.Image)
        Me.picInvader9.Image = CType(resources.GetObject("picInvader9.Image"), System.Drawing.Image)
        Me.picInvader9.Location = New System.Drawing.Point(688, 2)
        Me.picInvader9.Name = "picInvader9"
        Me.picInvader9.Size = New System.Drawing.Size(80, 80)
        Me.picInvader9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInvader9.TabIndex = 10
        Me.picInvader9.TabStop = False
        '
        'picInvader10
        '
        Me.picInvader10.BackColor = System.Drawing.SystemColors.WindowText
        Me.picInvader10.BackgroundImage = CType(resources.GetObject("picInvader10.BackgroundImage"), System.Drawing.Image)
        Me.picInvader10.Image = CType(resources.GetObject("picInvader10.Image"), System.Drawing.Image)
        Me.picInvader10.Location = New System.Drawing.Point(774, 2)
        Me.picInvader10.Name = "picInvader10"
        Me.picInvader10.Size = New System.Drawing.Size(80, 80)
        Me.picInvader10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInvader10.TabIndex = 11
        Me.picInvader10.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 569)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(980, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 569)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(980, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(980, 583)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(18, 589)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 29)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Score:"
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.White
        Me.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.Lime
        Me.lblScore.Image = CType(resources.GetObject("lblScore.Image"), System.Drawing.Image)
        Me.lblScore.Location = New System.Drawing.Point(102, 589)
        Me.lblScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(174, 35)
        Me.lblScore.TabIndex = 16
        Me.lblScore.Text = "00:00:00:000"
        '
        'TimerScore
        '
        Me.TimerScore.Interval = 1
        '
        'AlienInvaderz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 634)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picInvader10)
        Me.Controls.Add(Me.picInvader9)
        Me.Controls.Add(Me.picInvader8)
        Me.Controls.Add(Me.picInvader7)
        Me.Controls.Add(Me.picInvader6)
        Me.Controls.Add(Me.picInvader5)
        Me.Controls.Add(Me.picInvader4)
        Me.Controls.Add(Me.picInvader3)
        Me.Controls.Add(Me.picInvader2)
        Me.Controls.Add(Me.picInvader1)
        Me.Controls.Add(Me.picMissile)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picTank)
        Me.Controls.Add(Me.PictureBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AlienInvaderz"
        Me.Text = "Alier Invaderz"
        CType(Me.picTank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMissile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvader1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvader2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvader3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvader4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvader5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvader6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvader7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvader8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvader9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvader10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picTank As PictureBox
    Friend WithEvents TimerMain As Timer
    Friend WithEvents picMissile As PictureBox
    Friend WithEvents picInvader1 As PictureBox
    Friend WithEvents picInvader2 As PictureBox
    Friend WithEvents picInvader3 As PictureBox
    Friend WithEvents picInvader4 As PictureBox
    Friend WithEvents picInvader5 As PictureBox
    Friend WithEvents picInvader6 As PictureBox
    Friend WithEvents picInvader7 As PictureBox
    Friend WithEvents picInvader8 As PictureBox
    Friend WithEvents picInvader9 As PictureBox
    Friend WithEvents picInvader10 As PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents TimerScore As System.Windows.Forms.Timer
End Class
