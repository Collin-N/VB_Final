

Public Class AlienInvaderz

    Dim TRight As Boolean
    Dim TLeft As Boolean
    Dim TankSpeed As Integer
    Dim ShotSpeed As Integer
    Dim InvaderSpeed As Integer = 2
    Dim InvaderDrop As Integer
    Dim x As Integer
    Dim ShotDown As Integer
    Const NumOfInvaders As Integer = 10
    Dim intScore As Integer
    Dim IRight(NumOfInvaders) As Boolean
    Dim Invaders(NumOfInvaders) As PictureBox

        Private Sub TimerMain_Tick(sender As Object, e As EventArgs) Handles TimerMain.Tick
        MoveTanK()
        FireMissile()
        MoveInvader()
        CheckHit()
        CheckGameOver()
    End Sub

        Private Sub AlierInvaders_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
            ' Move the tank Right
            If e.KeyValue = Keys.Right Then
                TRight = True
                TLeft = False
            End If
            ' Moves the tank Left.
            If e.KeyValue = Keys.Left Then
                TLeft = True
                TRight = False
            End If
            ' Make the rocket Fire.
            If e.KeyValue = Keys.Space And picMissile.Visible = False Then
                picMissile.Top = picTank.Top
                picMissile.Left = picTank.Left + (picTank.Width / 2.25) - (picMissile.Width / 2.25)
                picMissile.Visible = True
            End If
        End Sub

        Private Sub MoveTanK()
            ' Moves the tank left and doesn't allow to leave the form.
            If TRight = True And picTank.Left + picTank.Width < Me.ClientRectangle.Width Then
                picTank.Left += TankSpeed
            End If
            ' Moves the tank right and doens't allow to leave the form.
            If TLeft = True And picTank.Left > Me.ClientRectangle.Left Then
                picTank.Left -= TankSpeed
            End If
        End Sub

        Private Sub AlierInvaders_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
            ' Helps from tank moving on own.
            If e.KeyValue = Keys.Right Then
                TRight = False
            End If
            ' Helps from tank moving on own.
            If e.KeyValue = Keys.Left Then
                TLeft = False
            End If
        End Sub

    Private Sub AlierInvaders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
        LoadInvaders()
        MessageBox.Show("Welcome to the Amry Soldier! Do you have what it takes to save the World?")
        CountUpTimer.Enabled = True
    End Sub

    Public Sub LoadSettings()
        ' Sets the Missile's speed and the tank's speed.
        ShotSpeed = 6
        TankSpeed = 5
        picMissile.Visible = False
        For Me.x = 1 To NumOfInvaders
            IRight(x) = True
        Next

        InvaderSpeed = 2
        InvaderDrop = 50
    End Sub

        Private Sub FireMissile()
            ' Moves Missile to top of form.
            If picMissile.Visible = True Then
                picMissile.Top -= ShotSpeed
            End If
            If picMissile.Top + picMissile.Height < Me.ClientRectangle.Top Then
                picMissile.Visible = False
            End If
        End Sub

        Private Sub MoveInvader()
            ' Moves the Alien right and Left.
            For Me.x = 1 To NumOfInvaders
                If IRight(x) = True Then
                    Invaders(x).Left += InvaderSpeed
            Else
                Invaders(x).Left -= InvaderSpeed
                End If
                ' Moves the Alien left and right.
                If Invaders(x).Left + Invaders(x).Width > Me.ClientRectangle.Width Then
                    IRight(x) = False
                    Invaders(x).Top += InvaderDrop
                End If
                If Invaders(x).Left < Me.ClientRectangle.Left Then
                    IRight(x) = True
                    Invaders(x).Top += InvaderDrop
                End If
            Next

        End Sub

        Private Sub CheckGameOver()
            ' Notifies the program to stop and show message that you failed, game over
            For Me.x = 1 To NumOfInvaders
                If Invaders(x).Top + Invaders(x).Height >= picTank.Top And (Invaders(x).Visible = True) Then
                TimerMain.Enabled = False
                CountUpTimer.Enabled = False
                MessageBox.Show("GAME OVER - Earth was Invaded!!! Mission Failed Soldier.")
                End If
            Next
            If ShotDown = NumOfInvaders Then
            TimerMain.Enabled = False
            CountUpTimer.Enabled = False
            MessageBox.Show("Good Job Soldier - Earth is Saved!")
            End If
        End Sub

        Private Sub CheckHit()
            For Me.x = 1 To NumOfInvaders
                If (picMissile.Top + picMissile.Height >= Invaders(x).Top) And (picMissile.Top <= Invaders(x).Top + Invaders(x).Height) And (picMissile.Left + picMissile.Width >= Invaders(x).Left) And (picMissile.Left <= Invaders(x).Left + Invaders(x).Width) And (picMissile.Visible = True) And Invaders(x).Visible = True Then
                    Invaders(x).Visible = False
                    picMissile.Visible = False
                    ShotDown += 1
                End If
            Next

        End Sub

        Private Sub LoadInvaders()
            ' Loads Aliens into the form
            Invaders(1) = picInvader1
            Invaders(2) = picInvader2
            Invaders(3) = picInvader3
            Invaders(4) = picInvader4
            Invaders(5) = picInvader5
            Invaders(6) = picInvader6
            Invaders(7) = picInvader7
            Invaders(8) = picInvader8
            Invaders(9) = picInvader9
            Invaders(10) = picInvader10
        End Sub

    Private Sub TimerScore_Tick(sender As Object, e As EventArgs)
        picInvader1.Visible = False

        picInvader1.Visible = False

        picInvader3.Visible = False

        picInvader4.Visible = False

        picInvader5.Visible = False

        picInvader6.Visible = False

        picInvader7.Visible = False

        picInvader8.Visible = False

        picInvader9.Visible = False

        picInvader10.Visible = False


    End Sub

    Private Sub CountUpTimer_Tick(sender As Object, e As EventArgs) Handles CountUpTimer.Tick
        lblSeconds.Text = lblSeconds.Text + 1
        CountUpTimer.Interval = 1000
        If lblHours.Text = "" Then
            lblHours.Text = "0"
        End If
        If lblMinutes.Text = "" Then
            lblMinutes.Text = "0"
        End If
        If lblSeconds.Text = "" Then
            lblSeconds.Text = "0"
        End If
        If lblHours.Text = "00" Then
            lblHours.Text = "0"
        End If
        If lblMinutes.Text = "00" Then
            lblMinutes.Text = "0"
        End If
        If lblSeconds.Text = "00" Then
            lblSeconds.Text = "0"
        End If
        If lblSeconds.Text = "60" Then
            lblMinutes.Text = lblMinutes.Text + 1
            lblSeconds.Text = "0"
        End If
        If lblMinutes.Text = "60" Then
            lblHours.Text = lblHours.Text + 1
            lblMinutes.Text = "0"
        End If
        If lblHours.Text = "59" Then
            If lblMinutes.Text = "59" Then
                If lblSeconds.Text = "59" Then
                    CountUpTimer.Enabled = False
                End If
            End If
        End If
    End Sub
End Class
