Public Class FormClosingPrevent
    Public IsTrueClose As Boolean
    Dim LoreClose As Boolean = False

    Private Sub FormClosingPrevent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormClosingPrevention(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If LoreClose = True Then
            e.Cancel = 0
        Else
            e.Cancel = 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "AlAkhAlif" Then
            IsTrueClose = True
        Else
            IsTrueClose = False
        End If
        LoreClose = True
        Close()
    End Sub
End Class