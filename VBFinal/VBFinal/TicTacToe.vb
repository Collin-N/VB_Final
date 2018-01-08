Public Class TicTacToe
    Dim Xtotal As Integer = 0
    Dim Ototal As Integer = 0
    Dim intZet As Integer = 0

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        ' Resets the buttons to start another game.
        btn1.Text = ""
        btn1.Enabled = True

        btn2.Text = ""
        btn2.Enabled = True

        btn3.Text = ""
        btn3.Enabled = True

        btn4.Text = ""
        btn4.Enabled = True

        btn5.Text = ""
        btn5.Enabled = True

        btn6.Text = ""
        btn6.Enabled = True

        btn7.Text = ""
        btn7.Enabled = True

        btn8.Text = ""
        btn8.Enabled = True

        btn9.Text = ""
        btn9.Enabled = True

        intZet = 0

    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        ' Resets the buttons for a New Game
        btn1.Text = ""
        btn1.Enabled = True

        btn2.Text = ""
        btn2.Enabled = True

        btn3.Text = ""
        btn3.Enabled = True

        btn4.Text = ""
        btn4.Enabled = True

        btn5.Text = ""
        btn5.Enabled = True

        btn6.Text = ""
        btn6.Enabled = True

        btn7.Text = ""
        btn7.Enabled = True

        btn8.Text = ""
        btn8.Enabled = True

        btn9.Text = ""
        btn9.Enabled = True

        ' Clears the Score for a New Game.
        lblWinsX.Text = ""
        lblWinsO.Text = ""


    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        ' Displays X or O when a button is selected.
        If lblTurn.Text = "X" Then
            btn1.Text = "X"
            lblTurn.Text = "O"
        Else
            btn1.Text = "O"
            lblTurn.Text = "X"
        End If
        btn1.Enabled = False
        ' Win conditions for X.
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If

        ' Win conditions for O.
        If btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If

        lblWinsX.Text = Xtotal.ToString("n")
        lblWinsO.Text = Ototal.ToString("n")

    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        ' Displays X or O when a button is selected.
        If lblTurn.Text = "X" Then
            btn2.Text = "X"
            lblTurn.Text = "O"
        Else
            btn2.Text = "O"
            lblTurn.Text = "X"
        End If
        btn2.Enabled = False
        ' Win conditions for X.
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If

        ' Win conditions for O.
        If btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If

        lblWinsX.Text = Xtotal.ToString("n")
        lblWinsO.Text = Ototal.ToString("n")
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        ' Displays X or O when a button is selected.
        If lblTurn.Text = "X" Then
            btn3.Text = "X"
            lblTurn.Text = "O"
        Else
            btn3.Text = "O"
            lblTurn.Text = "X"
        End If
        btn3.Enabled = False
        ' Win conditions for X.
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If

        ' Win conditions for O.
        If btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If

        lblWinsX.Text = Xtotal.ToString("n")
        lblWinsO.Text = Ototal.ToString("n")
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        ' Displays X or O when a button is selected.
        If lblTurn.Text = "X" Then
            btn4.Text = "X"
            lblTurn.Text = "O"
        Else
            btn4.Text = "O"
            lblTurn.Text = "X"
        End If
        btn4.Enabled = False
        ' Win conditions for X.
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If

        ' Win conditions for O.
        If btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If

        lblWinsX.Text = Xtotal.ToString("n")
        lblWinsO.Text = Ototal.ToString("n")
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        ' Displays X or O when a button is selected.
        If lblTurn.Text = "X" Then
            btn5.Text = "X"
            lblTurn.Text = "O"
        Else
            btn5.Text = "O"
            lblTurn.Text = "X"
        End If
        btn5.Enabled = False
        ' Win conditions for X.
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If

        ' Win conditions for O.
        If btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If

        lblWinsX.Text = Xtotal.ToString("n")
        lblWinsO.Text = Ototal.ToString("n")
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        ' Displays X or O when a button is selected.
        If lblTurn.Text = "X" Then
            btn6.Text = "X"
            lblTurn.Text = "O"
        Else
            btn6.Text = "O"
            lblTurn.Text = "X"
        End If
        btn6.Enabled = False
        ' Win conditions for X.
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If

        ' Win conditions for O.
        If btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If

        lblWinsX.Text = Xtotal.ToString("n")
        lblWinsO.Text = Ototal.ToString("n")
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        ' Displays X or O when a button is selected.
        If lblTurn.Text = "X" Then
            btn7.Text = "X"
            lblTurn.Text = "O"
        Else
            btn7.Text = "O"
            lblTurn.Text = "X"
        End If
        btn7.Enabled = False
        ' Win conditions for X.
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If

        ' Win conditions for O.
        If btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If

        lblWinsX.Text = Xtotal.ToString("n")
        lblWinsO.Text = Ototal.ToString("n")
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        ' Displays X or O when a button is selected.
        If lblTurn.Text = "X" Then
            btn8.Text = "X"
            lblTurn.Text = "O"
        Else
            btn8.Text = "O"
            lblTurn.Text = "X"
        End If
        btn8.Enabled = False
        ' Win conditions for X.
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If

        ' Win conditions for O.
        If btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If

        lblWinsX.Text = Xtotal.ToString("n")
        lblWinsO.Text = Ototal.ToString("n")
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        ' Displays X or O when a button is selected.
        If lblTurn.Text = "X" Then
            btn9.Text = "X"
            lblTurn.Text = "O"
        Else
            btn9.Text = "O"
            lblTurn.Text = "X"
        End If
        btn9.Enabled = False
        ' Win conditions for X.
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If
        If btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            Xtotal = 1 + Xtotal
            MessageBox.Show("Player X Wins!")
        End If

        ' Win conditions for O.
        If btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If
        If btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
            Ototal = 1 + Ototal
            MessageBox.Show("Player O Wins!")
        End If

        lblWinsX.Text = Xtotal.ToString("n")
        lblWinsO.Text = Ototal.ToString("n")
    End Sub

    Private Sub TicTacToe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Please select a game mode, by clicking file.")

        btn1.Text = ""
        btn1.Enabled = True

        btn2.Text = ""
        btn2.Enabled = True

        btn3.Text = ""
        btn3.Enabled = True

        btn4.Text = ""
        btn4.Enabled = True

        btn5.Text = ""
        btn5.Enabled = True

        btn6.Text = ""
        btn6.Enabled = True

        btn7.Text = ""
        btn7.Enabled = True

        btn8.Text = ""
        btn8.Enabled = True

        btn9.Text = ""
        btn9.Enabled = True

        intZet = 0
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ComputerPlays()
        Dim objRandom As New Random
        Dim intRandom As Integer

        intRandom = objRandom.Next(1, 10)

        If intRandom = 1 And btn1.Enabled = True Then
            btn1.Text = "O"
            btn1.Enabled = False
            Exit Sub
        End If

        If intRandom = 2 And btn2.Enabled = True Then
            btn2.Text = "O"
            btn2.Enabled = False
            Exit Sub
        End If

        If intRandom = 3 And btn3.Enabled = True Then
            btn3.Text = "O"
            btn3.Enabled = False
            Exit Sub
        End If

        If intRandom = 4 And btn4.Enabled = True Then
            btn4.Text = "O"
            btn4.Enabled = False
            Exit Sub
        End If

        If intRandom = 5 And btn5.Enabled = True Then
            btn5.Text = "O"
            btn5.Enabled = False
            Exit Sub
        End If

        If intRandom = 6 And btn6.Enabled = True Then
            btn6.Text = "O"
            btn6.Enabled = False
            Exit Sub
        End If

        If intRandom = 7 And btn7.Enabled = True Then
            btn7.Text = "O"
            btn7.Enabled = False
            Exit Sub
        End If

        If intRandom = 8 And btn8.Enabled = True Then
            btn8.Text = "O"
            btn8.Enabled = False
            Exit Sub
        End If

        If intRandom = 9 And btn9.Enabled = True Then
            btn9.Text = "O"
            btn9.Enabled = False
            Exit Sub
        End If

        ComputerPlays()

    End Sub

    Private Sub PlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayerToolStripMenuItem.Click
        ComputerPlays()
    End Sub
End Class