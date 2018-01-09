<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicTacToeVsComputer
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTurns = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStartNewGame = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblOWins = New System.Windows.Forms.Label()
        Me.lblXWins = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSquare9 = New System.Windows.Forms.Button()
        Me.btnSquare8 = New System.Windows.Forms.Button()
        Me.btnSquare7 = New System.Windows.Forms.Button()
        Me.btnSquare6 = New System.Windows.Forms.Button()
        Me.btnSquare5 = New System.Windows.Forms.Button()
        Me.btnSquare4 = New System.Windows.Forms.Button()
        Me.btnSquare3 = New System.Windows.Forms.Button()
        Me.btnSquare2 = New System.Windows.Forms.Button()
        Me.btnSquare1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(129, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 20)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Turn"
        '
        'lblTurns
        '
        Me.lblTurns.AutoSize = True
        Me.lblTurns.Location = New System.Drawing.Point(104, 52)
        Me.lblTurns.Name = "lblTurns"
        Me.lblTurns.Size = New System.Drawing.Size(20, 20)
        Me.lblTurns.TabIndex = 29
        Me.lblTurns.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "It's"
        '
        'btnStartNewGame
        '
        Me.btnStartNewGame.Location = New System.Drawing.Point(18, 508)
        Me.btnStartNewGame.Name = "btnStartNewGame"
        Me.btnStartNewGame.Size = New System.Drawing.Size(602, 35)
        Me.btnStartNewGame.TabIndex = 27
        Me.btnStartNewGame.Text = "New Game"
        Me.btnStartNewGame.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(18, 466)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(602, 35)
        Me.btnReset.TabIndex = 26
        Me.btnReset.Text = "Restart"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblOWins)
        Me.GroupBox1.Controls.Add(Me.lblXWins)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(394, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 209)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Score"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "O:"
        '
        'lblOWins
        '
        Me.lblOWins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOWins.Location = New System.Drawing.Point(52, 91)
        Me.lblOWins.Name = "lblOWins"
        Me.lblOWins.Size = New System.Drawing.Size(57, 20)
        Me.lblOWins.TabIndex = 2
        '
        'lblXWins
        '
        Me.lblXWins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblXWins.Location = New System.Drawing.Point(51, 40)
        Me.lblXWins.Name = "lblXWins"
        Me.lblXWins.Size = New System.Drawing.Size(57, 20)
        Me.lblXWins.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "X:"
        '
        'btnSquare9
        '
        Me.btnSquare9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSquare9.Location = New System.Drawing.Point(274, 343)
        Me.btnSquare9.Name = "btnSquare9"
        Me.btnSquare9.Size = New System.Drawing.Size(100, 100)
        Me.btnSquare9.TabIndex = 24
        Me.btnSquare9.UseVisualStyleBackColor = True
        '
        'btnSquare8
        '
        Me.btnSquare8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSquare8.Location = New System.Drawing.Point(148, 343)
        Me.btnSquare8.Name = "btnSquare8"
        Me.btnSquare8.Size = New System.Drawing.Size(100, 100)
        Me.btnSquare8.TabIndex = 23
        Me.btnSquare8.UseVisualStyleBackColor = True
        '
        'btnSquare7
        '
        Me.btnSquare7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSquare7.Location = New System.Drawing.Point(18, 343)
        Me.btnSquare7.Name = "btnSquare7"
        Me.btnSquare7.Size = New System.Drawing.Size(100, 100)
        Me.btnSquare7.TabIndex = 22
        Me.btnSquare7.UseVisualStyleBackColor = True
        '
        'btnSquare6
        '
        Me.btnSquare6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSquare6.Location = New System.Drawing.Point(274, 218)
        Me.btnSquare6.Name = "btnSquare6"
        Me.btnSquare6.Size = New System.Drawing.Size(100, 100)
        Me.btnSquare6.TabIndex = 21
        Me.btnSquare6.UseVisualStyleBackColor = True
        '
        'btnSquare5
        '
        Me.btnSquare5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSquare5.Location = New System.Drawing.Point(148, 218)
        Me.btnSquare5.Name = "btnSquare5"
        Me.btnSquare5.Size = New System.Drawing.Size(100, 100)
        Me.btnSquare5.TabIndex = 20
        Me.btnSquare5.UseVisualStyleBackColor = True
        '
        'btnSquare4
        '
        Me.btnSquare4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSquare4.Location = New System.Drawing.Point(18, 218)
        Me.btnSquare4.Name = "btnSquare4"
        Me.btnSquare4.Size = New System.Drawing.Size(100, 100)
        Me.btnSquare4.TabIndex = 19
        Me.btnSquare4.UseVisualStyleBackColor = True
        '
        'btnSquare3
        '
        Me.btnSquare3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSquare3.Location = New System.Drawing.Point(274, 92)
        Me.btnSquare3.Name = "btnSquare3"
        Me.btnSquare3.Size = New System.Drawing.Size(100, 100)
        Me.btnSquare3.TabIndex = 18
        Me.btnSquare3.UseVisualStyleBackColor = True
        '
        'btnSquare2
        '
        Me.btnSquare2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSquare2.Location = New System.Drawing.Point(148, 92)
        Me.btnSquare2.Name = "btnSquare2"
        Me.btnSquare2.Size = New System.Drawing.Size(100, 100)
        Me.btnSquare2.TabIndex = 17
        Me.btnSquare2.UseVisualStyleBackColor = True
        '
        'btnSquare1
        '
        Me.btnSquare1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSquare1.Location = New System.Drawing.Point(18, 92)
        Me.btnSquare1.Name = "btnSquare1"
        Me.btnSquare1.Size = New System.Drawing.Size(100, 100)
        Me.btnSquare1.TabIndex = 16
        Me.btnSquare1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(652, 33)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'TicTacToeVsComputer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(652, 554)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTurns)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStartNewGame)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSquare9)
        Me.Controls.Add(Me.btnSquare8)
        Me.Controls.Add(Me.btnSquare7)
        Me.Controls.Add(Me.btnSquare6)
        Me.Controls.Add(Me.btnSquare5)
        Me.Controls.Add(Me.btnSquare4)
        Me.Controls.Add(Me.btnSquare3)
        Me.Controls.Add(Me.btnSquare2)
        Me.Controls.Add(Me.btnSquare1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "TicTacToeVsComputer"
        Me.Text = "TicTacToeVsComputer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents lblTurns As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnStartNewGame As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblOWins As Label
    Friend WithEvents lblXWins As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSquare9 As Button
    Friend WithEvents btnSquare8 As Button
    Friend WithEvents btnSquare7 As Button
    Friend WithEvents btnSquare6 As Button
    Friend WithEvents btnSquare5 As Button
    Friend WithEvents btnSquare4 As Button
    Friend WithEvents btnSquare3 As Button
    Friend WithEvents btnSquare2 As Button
    Friend WithEvents btnSquare1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
End Class
