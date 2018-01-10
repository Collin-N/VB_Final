Imports System.IO
Public Class LoginPage
    Dim A As StreamReader
    Dim B As String
    Dim C As String = "C:\Users\GeneralGibbs\Desktop\Vb Final\VB_Final\Login.txt"
    Dim Findstring = File.ReadAllText("C:\Users\GeneralGibbs\Desktop\Vb Final\VB_Final\Login.txt")
    Dim Lookfor As String = " "
    Dim User As String
    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not File.Exists(C) Then
            Dim D As FileStream
            D = File.Create(C)
            D.Close()
        End If
        ReadFile()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If cbxUser.Text = Nothing Then

            If cbxUser.Text = Nothing Then
                MsgBox("Enter a User Name to be saved")
            Else
                File.AppendAllText(C, cbxUser.Text & vbCrLf)
                cbxUser.Text = ""
            End If
            ReadFile()
        Else
            Lookfor = cbxUser.Text
            User = cbxUser.Text
            If Not Findstring.Contains(Lookfor) Then
                File.AppendAllText(C, cbxUser.Text & vbCrLf)
                cbxUser.Text = ""
            End If
            MainMenu.Show()
            Hide()
        End If
        ReadFile()
    End Sub
    Private Sub ReadFile()
        Try
            cbxUser.Items.Clear()
            A = File.OpenText(C)
            While A.Peek <> -1
                B = A.ReadLine()
                cbxUser.Items.Add(B)
            End While
            A.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class