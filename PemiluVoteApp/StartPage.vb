Public Class StartPage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ServerSetup.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClientSetup.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub FormClosingPrevention(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = 1
    End Sub
End Class