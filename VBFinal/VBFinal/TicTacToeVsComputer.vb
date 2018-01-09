Public Class TicTacToeVsComputer
    Dim UserTotalWins As Integer
    Dim ComputerTotalWins As Integer
    Dim intMove As Integer = 0
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub ComputerPlays()
        Dim objRandom As New Random
        Dim intRandom As Integer

        intRandom = objRandom.Next(1, 10)
        ' The Computer selects an unselected square 1-9.
        If intRandom = 1 And btnSquare1.Enabled = True Then
            btnSquare1.Text = "O"
            btnSquare1.Enabled = False
            Exit Sub
        End If

        If intRandom = 2 And btnSquare2.Enabled = True Then
            btnSquare2.Text = "O"
            btnSquare2.Enabled = False
            Exit Sub
        End If

        If intRandom = 3 And btnSquare3.Enabled = True Then
            btnSquare3.Text = "O"
            btnSquare3.Enabled = False
            Exit Sub
        End If

        If intRandom = 4 And btnSquare4.Enabled = True Then
            btnSquare4.Text = "O"
            btnSquare4.Enabled = False
            Exit Sub
        End If

        If intRandom = 5 And btnSquare5.Enabled = True Then
            btnSquare5.Text = "O"
            btnSquare5.Enabled = False
            Exit Sub
        End If

        If intRandom = 6 And btnSquare6.Enabled = True Then
            btnSquare6.Text = "O"
            btnSquare6.Enabled = False
            Exit Sub
        End If

        If intRandom = 7 And btnSquare7.Enabled = True Then
            btnSquare7.Text = "O"
            btnSquare7.Enabled = False
            Exit Sub
        End If

        If intRandom = 8 And btnSquare8.Enabled = True Then
            btnSquare8.Text = "O"
            btnSquare8.Enabled = False
            Exit Sub
        End If

        If intRandom = 9 And btnSquare9.Enabled = True Then
            btnSquare9.Text = "O"
            btnSquare9.Enabled = False
            Exit Sub
        End If

        ComputerPlays()

    End Sub

    Private Sub UserPlays(sender As Object, e As EventArgs) Handles btnSquare1.Click, btnSquare2.Click, btnSquare3.Click, btnSquare4.Click, btnSquare5.Click, btnSquare6.Click, btnSquare7.Click, btnSquare8.Click, btnSquare9.Click
        ' The user selects a square  1-9
        sender.Text = "X"
        sender.Enabled = False
        intMove += 1

        CheckWinner()
        ' The Computer selects an unselected square 1-9.
        ComputerPlays()

        intMove += 1

        CheckWinner()
    End Sub
    Private Sub CheckWinner()
        ' Determines whether or not it's a tie.
        If intMove >= 9 Then
            MessageBox.Show("It's a Tie!")
            ' Win conditions for the computer.
        ElseIf btnSquare1.Text = "O" And btnSquare2.Text = "O" And btnSquare3.Text = "O" _
            Or btnSquare1.Text = "O" And btnSquare4.Text = "O" And btnSquare7.Text = "O" _
            Or btnSquare1.Text = "O" And btnSquare5.Text = "O" And btnSquare9.Text = "O" _
            Or btnSquare2.Text = "O" And btnSquare5.Text = "O" And btnSquare8.Text = "O" _
            Or btnSquare3.Text = "O" And btnSquare6.Text = "O" And btnSquare9.Text = "O" _
            Or btnSquare3.Text = "O" And btnSquare5.Text = "O" And btnSquare7.Text = "O" _
            Or btnSquare4.Text = "O" And btnSquare5.Text = "O" And btnSquare6.Text = "O" _
            Or btnSquare7.Text = "O" And btnSquare8.Text = "O" And btnSquare9.Text = "O" Then
            MessageBox.Show("Computer Wins!")
            ComputerTotalWins += 1
        ElseIf btnSquare1.Text = "X" And btnSquare2.Text = "X" And btnSquare3.Text = "X" _
            Or btnSquare1.Text = "X" And btnSquare4.Text = "X" And btnSquare7.Text = "X" _
            Or btnSquare2.Text = "X" And btnSquare5.Text = "X" And btnSquare8.Text = "X" _
            Or btnSquare3.Text = "X" And btnSquare6.Text = "X" And btnSquare9.Text = "X" _
            Or btnSquare3.Text = "X" And btnSquare5.Text = "X" And btnSquare7.Text = "X" _
            Or btnSquare4.Text = "X" And btnSquare5.Text = "X" And btnSquare6.Text = "X" _
            Or btnSquare7.Text = "X" And btnSquare8.Text = "X" And btnSquare9.Text = "X" Then
            MessageBox.Show("You Win!")
            UserTotalWins += 1
        End If
        ' Converts to a string.
        lblXWins.Text = UserTotalWins.ToString("n")
        lblOWins.Text = ComputerTotalWins.ToString("n")
    End Sub
    Private Sub TicTacToeVsComputer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome to Tic Tac Toe vs Computer.")

        btnSquare1.Text = ""
        btnSquare1.Enabled = True

        btnSquare2.Text = ""
        btnSquare2.Enabled = True

        btnSquare3.Text = ""
        btnSquare3.Enabled = True

        btnSquare4.Text = ""
        btnSquare4.Enabled = True

        btnSquare5.Text = ""
        btnSquare5.Enabled = True

        btnSquare6.Text = ""
        btnSquare6.Enabled = True

        btnSquare7.Text = ""
        btnSquare7.Enabled = True

        btnSquare8.Text = ""
        btnSquare8.Enabled = True

        btnSquare9.Text = ""
        btnSquare9.Enabled = True

        intMove = 0

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Resets the buttons to start another game.
        btnSquare1.Text = ""
        btnSquare1.Enabled = True

        btnSquare2.Text = ""
        btnSquare2.Enabled = True

        btnSquare3.Text = ""
        btnSquare3.Enabled = True

        btnSquare4.Text = ""
        btnSquare4.Enabled = True

        btnSquare5.Text = ""
        btnSquare5.Enabled = True

        btnSquare6.Text = ""
        btnSquare6.Enabled = True

        btnSquare7.Text = ""
        btnSquare7.Enabled = True

        btnSquare8.Text = ""
        btnSquare8.Enabled = True

        btnSquare9.Text = ""
        btnSquare9.Enabled = True

    End Sub

    Private Sub btnStartNewGame_Click(sender As Object, e As EventArgs) Handles btnStartNewGame.Click
        ' Resets the buttons for a New Game
        btnSquare1.Text = ""
        btnSquare1.Enabled = True

        btnSquare2.Text = ""
        btnSquare2.Enabled = True

        btnSquare3.Text = ""
        btnSquare3.Enabled = True

        btnSquare4.Text = ""
        btnSquare4.Enabled = True

        btnSquare5.Text = ""
        btnSquare5.Enabled = True

        btnSquare6.Text = ""
        btnSquare6.Enabled = True

        btnSquare7.Text = ""
        btnSquare7.Enabled = True

        btnSquare8.Text = ""
        btnSquare8.Enabled = True

        btnSquare9.Text = ""
        btnSquare9.Enabled = True

        ' Clears the Score for a New Game.
        lblXWins.Text = ""
        lblOWins.Text = ""
    End Sub
End Class