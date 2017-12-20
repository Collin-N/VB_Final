Imports System.IO
Public Class LoginPage

    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not File.Exists(C) Then
            Dim D As FileStream
            D = File.Create(C)
            D.Close()
        End If
    End Sub
End Class