Public Class MainMenu

    Private Sub btnFalldown_Click(sender As Object, e As EventArgs) Handles btnFalldown.Click
        Dim box = New Falldown()
        box.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
