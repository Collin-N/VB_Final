<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInvaderz = New System.Windows.Forms.Button()
        Me.btnTicTacToe = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose a Game!"
        '
        'btnInvaderz
        '
        Me.btnInvaderz.Location = New System.Drawing.Point(126, 55)
        Me.btnInvaderz.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnInvaderz.Name = "btnInvaderz"
        Me.btnInvaderz.Size = New System.Drawing.Size(160, 35)
        Me.btnInvaderz.TabIndex = 1
        Me.btnInvaderz.Text = "Alien Invaderz"
        Me.btnInvaderz.UseVisualStyleBackColor = True
        '
        'btnTicTacToe
        '
        Me.btnTicTacToe.Location = New System.Drawing.Point(126, 100)
        Me.btnTicTacToe.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTicTacToe.Name = "btnTicTacToe"
        Me.btnTicTacToe.Size = New System.Drawing.Size(160, 35)
        Me.btnTicTacToe.TabIndex = 2
        Me.btnTicTacToe.Text = "Tic-Tac-Toe"
        Me.btnTicTacToe.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(126, 145)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(160, 35)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(148, 189)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 35)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 403)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnTicTacToe)
        Me.Controls.Add(Me.btnInvaderz)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainMenu"
        Me.Text = "Final Program Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnInvaderz As System.Windows.Forms.Button
    Friend WithEvents btnTicTacToe As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
