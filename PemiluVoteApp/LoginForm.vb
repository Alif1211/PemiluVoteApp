Imports System.IO

Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized
        Label9.Text = Environment.MachineName
        Timer1.Start()
        'MsgBox(GroupBox2.Location.X & " and " & GroupBox2.Location.Y)
        'MsgBox("Break!")
        'MsgBox(GroupBox2.Location.X & " and " & (Height / 2) - GroupBox2.Height)
    End Sub

    Private Sub FormClosingPrevention(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Select Case e.CloseReason
            Case CloseReason.UserClosing
                Dim AskPW As New FormClosingPrevent
                AskPW.ShowDialog()
                If AskPW.IsTrueClose = True Then
                    StartPage.Show()
                    e.Cancel = 0
                Else
                    e.Cancel = 1
                    MsgBox("Invalid password")
                End If
            Case Else
                e.Cancel = 0
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label8.Text = TimeOfDay
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If File.Exists("\\" & VarCentre.Hostname & "\PemiluEVote\userdata\" & TextBox1.Text & ".udb") = True Then
            VarCentre.Userbase = File.ReadAllLines("\\" & VarCentre.Hostname & "\PemiluEVote\userdata\" & TextBox1.Text & ".udb")
            If TextBox2.Text = VarCentre.Userbase(3) Then
                If VarCentre.Userbase(4) = "0" Then
                    TextBox1.Text = Nothing
                    TextBox2.Text = Nothing
                    Form1.Show()
                    Hide()
                Else
                    TextBox1.Text = Nothing
                    TextBox2.Text = Nothing
                    MsgBox("Anda sudah memilih, jangan curang ya!")
                End If
            Else
                TextBox1.Text = Nothing
                TextBox2.Text = Nothing
                MsgBox("Password yang anda masukkan salah.")
            End If
        Else
            TextBox1.Text = Nothing
            TextBox2.Text = Nothing
            MsgBox("Username yang anda masukkan tidak ada di database.")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Close()
    End Sub
End Class