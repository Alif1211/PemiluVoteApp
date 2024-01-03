Imports System.IO

Public Class Form1
    Dim DelaySend As Integer = 0
    Dim ShouldClose As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized
        Label8.Text = VarCentre.Userbase(1)
        Label9.Text = VarCentre.Userbase(2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Terima kasih karena sudah memilih calon ketua ISPA dengan Luberjurdil (Langsung, Bebas, Rahasia, Jujur, dan Adil)" & Environment.NewLine & Environment.NewLine & "(C) 2024, Alif Muhammad Mumtaaz", MsgBoxStyle.OkOnly, "Terima Kasih!")
        MsgBox("Check after message")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As DialogResult = MsgBox("Apakah anda yakin dengan pilihan anda?", MsgBoxStyle.YesNo, "Yakin?")
        If result = MsgBoxResult.Yes Then
            MsgBox("Yes!")
        End If
        If result = MsgBoxResult.No Then
            MsgBox("No!")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Error with : 69420", MsgBoxStyle.Critical, "Error!")
    End Sub

    Private Sub FormClosingPrevention(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If ShouldClose = True Then
            e.Cancel = 0
        Else
            Select Case e.CloseReason
                Case CloseReason.UserClosing
                    Dim AskPW As New FormClosingPrevent
                    AskPW.ShowDialog()
                    If AskPW.IsTrueClose = True Then
                        LoginForm.Show()
                        e.Cancel = 0
                    Else
                        e.Cancel = 1
                        MsgBox("Invalid password")
                    End If
                Case Else
                    e.Cancel = 0
            End Select
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Select Case ComboBox1.SelectedItem
                Case Nothing
                    Button1.Enabled = False
                Case "No. 1"
                    PictureBox1.BackgroundImage = Image.FromFile("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\1.jpg")
                    Label6.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\1.idb")
                    TextBox1.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\1.txt")
                    Button1.Enabled = True
                Case "No. 2"
                    PictureBox1.BackgroundImage = Image.FromFile("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\2.jpg")
                    Label6.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\2.idb")
                    TextBox1.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\2.txt")
                    Button1.Enabled = True
                Case "No. 3"
                    PictureBox1.BackgroundImage = Image.FromFile("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\3.jpg")
                    Label6.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\3.idb")
                    TextBox1.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\3.txt")
                    Button1.Enabled = True
                Case "No. 4"
                    PictureBox1.BackgroundImage = Image.FromFile("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\4.jpg")
                    Label6.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\4.idb")
                    TextBox1.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\4.txt")
                    Button1.Enabled = True
                Case "No. 5"
                    PictureBox1.BackgroundImage = Image.FromFile("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\5.jpg")
                    Label6.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\5.idb")
                    TextBox1.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\5.txt")
                    Button1.Enabled = True
            End Select
        Catch ex As Exception
            ErrHandler(ex.Message)
            Button1.Enabled = False
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = MsgBox("Apakah anda yakin dengan pilihan anda?", MsgBoxStyle.YesNo, "Yakin?")
        If result = MsgBoxResult.Yes Then
            Select Case ComboBox1.SelectedItem
                Case "No. 1"
                    VarCentre.Userbase(4) = 1
                Case "No. 2"
                    VarCentre.Userbase(4) = 2
                Case "No. 3"
                    VarCentre.Userbase(4) = 3
                Case "No. 4"
                    VarCentre.Userbase(4) = 4
                Case "No. 5"
                    VarCentre.Userbase(4) = 5
                Case Else
                    MsgBox("Pilihan tidak valid")
            End Select
            Timer1.Start()
        End If
        If result = MsgBoxResult.No Then

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If DelaySend = 10 Then
            Try
                Dim MasterData As String = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\masterdata.csv")
                Dim SingleData As String
                MasterData = MasterData & Environment.NewLine & TimeOfDay & "," & "'" & VarCentre.Userbase(0) & "," & VarCentre.Userbase(1) & "," & VarCentre.Userbase(2) & "," & VarCentre.Userbase(4)
                Select Case VarCentre.Userbase(4)
                    Case 1
                        SingleData = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\1.csv")
                        SingleData = SingleData & Environment.NewLine & TimeOfDay & "," & "'" & VarCentre.Userbase(0) & "," & VarCentre.Userbase(1) & "," & VarCentre.Userbase(2) & "," & VarCentre.Userbase(4)
                    Case 2
                        SingleData = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\2.csv")
                        SingleData = SingleData & Environment.NewLine & TimeOfDay & "," & "'" & VarCentre.Userbase(0) & "," & VarCentre.Userbase(1) & "," & VarCentre.Userbase(2) & "," & VarCentre.Userbase(4)
                    Case 3
                        SingleData = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\3.csv")
                        SingleData = SingleData & Environment.NewLine & TimeOfDay & "," & "'" & VarCentre.Userbase(0) & "," & VarCentre.Userbase(1) & "," & VarCentre.Userbase(2) & "," & VarCentre.Userbase(4)
                    Case 4
                        SingleData = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\4.csv")
                        SingleData = SingleData & Environment.NewLine & TimeOfDay & "," & "'" & VarCentre.Userbase(0) & "," & VarCentre.Userbase(1) & "," & VarCentre.Userbase(2) & "," & VarCentre.Userbase(4)
                    Case 5
                        SingleData = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\5.csv")
                        SingleData = SingleData & Environment.NewLine & TimeOfDay & "," & "'" & VarCentre.Userbase(0) & "," & VarCentre.Userbase(1) & "," & VarCentre.Userbase(2) & "," & VarCentre.Userbase(4)
                End Select
                File.WriteAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\masterdata.csv", MasterData)
                Select Case VarCentre.Userbase(4)
                    Case 1
                        File.WriteAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\1.csv", SingleData)
                    Case 2
                        File.WriteAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\2.csv", SingleData)
                    Case 3
                        File.WriteAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\3.csv", SingleData)
                    Case 4
                        File.WriteAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\4.csv", SingleData)
                    Case 5
                        File.WriteAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\5.csv", SingleData)
                End Select
                File.WriteAllLines("\\" & VarCentre.Hostname & "\PemiluEVote\userdata\" & VarCentre.Userbase(0) & ".udb", VarCentre.Userbase)
                DelaySend = 0
                Timer1.Stop()
                MsgBox("Terima kasih karena sudah memilih calon ketua ISPA dengan Luberjurdil (Langsung, Bebas, Rahasia, Jujur, dan Adil)" & Environment.NewLine & Environment.NewLine & "(C) 2024, Alif Muhammad Mumtaaz", MsgBoxStyle.OkOnly, "Terima Kasih!")
                TextBox1.Text = "Terima kasih telah menggunakan aplikasi e-Vote ini!

Apabila ada masalah atau kendala yang terjadi pada aplikasi ini, silakan salin (copy) kode yang muncul di peringatan yang ada dan kirim kode tersebut kepada Admin (Alif Muhammad Mumtaaz) melalui berikut :

WhatsApp : +6289661715192
Instagram : @alif_mumtaaz
Telegram : @AMM2112
Twitter/X : @alifmumtaaz"
                PictureBox1.BackgroundImage = Nothing
                Label6.Text = "Nama Calon"
                ComboBox1.SelectedItem = Nothing
                ComboBox1.Text = Nothing
                Button1.Enabled = False
                LoginForm.Show()
                Hide()
            Catch ex As Exception
                Timer1.Stop()
                ErrHandler(ex.Message)
                ShouldClose = True
                Close()
                LoginForm.Show()
            End Try
        Else
            DelaySend = DelaySend + 1
        End If
    End Sub
End Class