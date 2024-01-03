Public Class StartPage
    Dim ShouldClose As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShouldClose = True
        ServerSetup.Show()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ShouldClose = True
        ClientSetup.Show()
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub FormClosingPrevention(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If ShouldClose = True Then
            e.Cancel = 0
        Else
            e.Cancel = 1
        End If
    End Sub
End Class