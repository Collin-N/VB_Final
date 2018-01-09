Imports System.IO
Public Class MainMenu
    Dim A As StreamReader
    Dim B As String
    Dim C As String = "VB_Final/login.txt"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnTicTacToe_Click(sender As Object, e As EventArgs) Handles btnTicTacToe.Click
        Dim box = New TicTacToe()
        box.Show()
    End Sub

    Private Sub btnInvaderz_Click(sender As Object, e As EventArgs) Handles btnInvaderz.Click
        Dim box = New AlienInvaderz()
        box.Show()
    End Sub

    Private Sub btnHorseRacing_Click(sender As Object, e As EventArgs) Handles btnHorseRacing.Click

    Dim box = New HorseRacing()
        box.Show()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not File.Exists(C) Then
            Dim D As FileStream
            D = File.Create(C)
            D.Close()

        End If      
    End Sub

    Private Sub btnTicTacToeVsComputer_Click(sender As Object, e As EventArgs) Handles btnTicTacToeVsComputer.Click
        Dim box = New TicTacToeVsComputer()
        box.Show()
    End Sub
End Class
