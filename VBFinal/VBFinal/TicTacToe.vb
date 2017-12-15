Public Class TicTacToe
   
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


    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click, btn1_click(sender As Object, e As EventArgs) Handles  btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        If lblTurn.Text = "X" Then
            btn1.Text, btn2.Text, btn3.Text, btn4.Text, btn5.Text, btn6.Text, btn7.Text, btn8.Text, btn9.Text = "X"
            lblTurn.Text = "O"
        Else
            btn1.Text, btn2.Text, btn3.Text, btn4.Text, btn5.Text, btn6.Text, btn7.Text, btn8.Text, btn9.Text = "O"
            lblTurn.Text = "X"
        End If
    End Sub
End Class