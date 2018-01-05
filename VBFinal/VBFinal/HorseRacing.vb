Public Class HorseRacing
    Dim intHorse1Count As Integer
    Dim intHorse2Count As Integer
    Dim intHorse3Count As Integer
    Dim intHorse4Count As Integer
    Dim intHorse5Count As Integer
    Private Sub btnRace_Click(sender As Object, e As EventArgs) Handles btnRace.Click
        Dim intCount1, intCount2, intCount3, intCount4, intCount5 As Integer
        Dim rand As New Random
        Dim totalMoney As Double
        Dim totalBet As Double
        Dim SecretariatWon As Integer
        Dim ManOWarWon As Integer
        Dim SeabiscutWon As Integer
        Dim ExterminatorWon As Integer
        Dim CaliforniaChromeWon As Integer
        Dim intScore As Integer = 1
        Dim intWin As Integer = 10

        For intCount1 = 25 To rand.Next(250) + 450
            picHorse1.Left = intCount1
        Next
        For intCount2 = 25 To rand.Next(250) + 450
            picHorse2.Left = intCount2
        Next
        For intCount3 = 25 To rand.Next(250) + 450
            picHorse3.Left = intCount3
        Next
        For intCount4 = 25 To rand.Next(250) + 450
            picHorse4.Left = intCount4
        Next
        For intCount5 = 25 To rand.Next(250) + 450
            picHorse5.Left = intCount5
        Next
        If intCount1 > intCount2 And intCount1 > intCount3 And intCount1 > intCount4 And intCount1 > intCount5 Then
            intHorse1Count = intHorse1Count + 1
            lblHorse1Wins.Text = intHorse1Count
        End If
        If intCount2 > intCount1 And intCount2 > intCount3 And intCount2 > intCount4 And intCount2 > intCount5 Then
            intHorse2Count = intHorse2Count + 1
            lblHorse2Wins.Text = intHorse2Count
        End If
        If intCount3 > intCount4 And intCount3 > intCount1 And intCount3 > intCount2 And intCount3 > intCount5 Then
            intHorse3Count = intHorse3Count + 1
            lblHorse3Wins.Text = intHorse3Count
        End If
        If intCount4 > intCount3 And intCount4 > intCount2 And intCount4 > intCount1 And intCount4 > intCount5 Then
            intHorse4Count = intHorse4Count + 1
            lblHorse4Wins.Text = intHorse4Count
        End If
        If intCount5 > intCount4 And intCount5 > intCount3 And intCount5 > intCount2 And intCount5 > intCount1 Then
            intHorse5Count = intHorse5Count + 1
            lblHorse5Wins.Text = intHorse5Count
            If intHorse1Count = intWin Then
                MessageBox.Show("Horse 1 Wins!")
            End If
            If intHorse2Count = intWin Then
                MessageBox.Show("Horse 2 Wins!")
            End If
            If intHorse3Count = intWin Then
                MessageBox.Show("Horse 3 Wins!")
            End If
            If intHorse4Count = intWin Then
                MessageBox.Show("Horse 4 Wins!")
            End If
            If intHorse5Count = intWin Then
                MessageBox.Show("Horse 5 Wins!")
            End If
        End If

        If SecretariatWon = True And radHorse1.Checked = True Then
            totalMoney += totalBet
        Else
            totalMoney -= totalBet
        End If
        If ManOWarWon = True And radHorse2.Checked = True Then
            totalMoney += totalBet
        Else
            totalMoney -= totalBet
        End If
        If SeabiscutWon = True And radHorse3.Checked = True Then
            totalMoney += totalBet
        Else
            totalMoney -= totalBet
        End If
        If ExterminatorWon = True And radHorse4.Checked = True Then
            totalMoney += totalBet
        Else
            totalMoney -= totalBet
        End If
        If CaliforniaChromeWon = True And radHorse5.Checked = True Then
            totalMoney += totalBet
        Else
            totalMoney -= totalBet
        End If
        If totalMoney < 0 Then
            MessageBox.Show("You ran out of money! Please leave the track!")
            Me.Close()
        ElseIf totalMoney >= 10000 Then
            MessageBox.Show("You took all of our money! Please leave the track!")
            Me.Close()
        End If
        lblMoney.Text = totalMoney.ToString("c")
        txtBet.Text = totalBet.ToString("c")
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        lblMoney.Text = ""
        txtBet.Text = ""
        lblHorse1Wins.Text = ""
        lblHorse2Wins.Text = ""
        lblHorse3Wins.Text = ""
        lblHorse4Wins.Text = ""
        lblHorse5Wins.Text = ""
        picHorse1.Location = New Point(12, 12)
        picHorse2.Location = New Point(12, 80)
        picHorse3.Location = New Point(12, 145)
        picHorse4.Location = New Point(12, 210)
        picHorse5.Location = New Point(12, 278)
    End Sub
End Class