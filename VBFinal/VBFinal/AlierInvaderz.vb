Public Class AlienInvaderz
    Dim TRight As Boolean
    Dim TLeft As Boolean
    Dim TankSpeed As Integer
    Dim ShotSpeed As Integer
    Dim InvaderSpeed As Integer
    Dim InvaderDrop As Integer
    Dim x As Integer
    Dim ShotDown As Integer
    Const NumOfInvaders As Integer = 10
    Dim IRight(NumOfInvaders) As Boolean
    Dim Invaderz(NumOfInvaders) As PictureBox


    Private Sub TimerMain_Tick(sender As Object, e As EventArgs) Handles TimerMain.Tick
        MoveTanK()
        FireMissile()
        MoveInvader()
        CheckHit()
        CheckGameOver()
    End Sub

    Private Sub AlierInvaderz_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub AlierInvaderz_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        ' Helps from tank moving on own.
        If e.KeyValue = Keys.Right Then
            TRight = False
        End If
        ' Helps from tank moving on own.
        If e.KeyValue = Keys.Left Then
            TLeft = False
        End If
    End Sub

    Private Sub AlierInvaderz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
        LoadInvaders()
    End Sub

    Private Sub LoadSettings()
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
                Invaderz(x).Left += InvaderSpeed
            Else
                Invaderz(x).Left -= InvaderSpeed
            End If
            ' Moves the Alien left and right.
            If Invaderz(x).Left + Invaderz(x).Width > Me.ClientRectangle.Width Then
                IRight(x) = False
                Invaderz(x).Top += InvaderDrop
            End If
            If Invaderz(x).Left < Me.ClientRectangle.Left Then
                IRight(x) = True
                Invaderz(x).Top += InvaderDrop
            End If
        Next
    End Sub

    Private Sub CheckGameOver()
        ' Notifies the program to stop and show message that you failed, game over
        For Me.x = 1 To NumOfInvaders
            If Invaderz(x).Top + Invaderz(x).Height >= picTank.Top And (Invaderz(x).Visible = True) Then
                TimerMain.Enabled = False
                MessageBox.Show("GAME OVER - Earth was Invaded!!!
            Mission Failed Soldier.")
            End If
        Next
        If ShotDown = NumOfInvaders Then
            TimerMain.Enabled = False
            MessageBox.Show("Good Job Soldier - Earth is Saved!")
        End If
    End Sub

    Private Sub CheckHit()
        For Me.x = 1 To NumOfInvaders
            If (picMissile.Top + picMissile.Height >= Invaderz(x).Top) And (picMissile.Top <= Invaderz(x).Top + Invaderz(x).Height) And (picMissile.Left + picMissile.Width >= Invaderz(x).Left) And (picMissile.Left <= Invaderz(x).Left + Invaderz(x).Width) And (picMissile.Visible = True) And Invaderz(x).Visible = True Then
                Invaderz(x).Visible = False
                picMissile.Visible = False
                ShotDown += 1
            End If
        Next
    End Sub

    Private Sub LoadInvaders()
        ' Loads Aliens into the form
        Invaderz(1) = picInvader1
        Invaderz(2) = picInvader2
        Invaderz(3) = picInvader3
        Invaderz(4) = picInvader4
        Invaderz(5) = picInvader5
        Invaderz(6) = picInvader6
        Invaderz(7) = picInvader7
        Invaderz(8) = picInvader8
        Invaderz(9) = picInvader9
        Invaderz(10) = picInvader10
    End Sub
End Class