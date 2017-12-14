Public Class TicTacToe
    Private Sub btnTicTacToe_Click(sender As Object, e As EventArgs) Handles btnTicTacToe.Click
        For btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 

    End Sub

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
End Class