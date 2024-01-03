Imports System.IO

Public Class ServerSetup
    Dim Foto1Source As String
    Dim Foto2Source As String
    Dim Foto3Source As String
    Dim Foto4Source As String
    Dim Foto5Source As String
    Dim ChosenResource As Integer = 0


    Private Sub ServerSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChosenResource = 0
        Label7.Text = "Nama server : " & Environment.MachineName
        CheckFile()
    End Sub

    Private Sub CheckFile()
        If Directory.Exists("\\" & Environment.MachineName & "\PemiluEVote") = True Then
            If Directory.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata") = True Then
                'Later have to isolate each filegrab to see if it exists or not
                Try
                    If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\1.jpg") = True Then
                        PictureBox1.BackgroundImage = Image.FromFile("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\1.jpg")
                        ChosenResource = ChosenResource + 1
                        Button1.Enabled = False
                    End If
                    If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\2.jpg") = True Then
                        PictureBox2.BackgroundImage = Image.FromFile("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\2.jpg")
                        ChosenResource = ChosenResource + 1
                        Button2.Enabled = False
                    End If
                    If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\3.jpg") = True Then
                        PictureBox3.BackgroundImage = Image.FromFile("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\3.jpg")
                        ChosenResource = ChosenResource + 1
                        Button3.Enabled = False
                    End If
                    If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\4.jpg") = True Then
                        PictureBox4.BackgroundImage = Image.FromFile("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\4.jpg")
                        ChosenResource = ChosenResource + 1
                        Button4.Enabled = False
                    End If
                    If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\5.jpg") = True Then
                        PictureBox5.BackgroundImage = Image.FromFile("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\5.jpg")
                        ChosenResource = ChosenResource + 1
                        Button5.Enabled = False
                    End If
                    If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\1.idb") = True Then
                        TextBox1.Text = File.ReadAllText("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\1.idb")
                        ChosenResource = ChosenResource + 1
                        TextBox1.Enabled = False
                    End If
                    If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\2.idb") = True Then
                        TextBox2.Text = File.ReadAllText("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\2.idb")
                        ChosenResource = ChosenResource + 1
                        TextBox2.Enabled = False
                    End If
                    If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\3.idb") = True Then
                        TextBox3.Text = File.ReadAllText("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\3.idb")
                        ChosenResource = ChosenResource + 1
                        TextBox3.Enabled = False
                    End If
                    If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\4.idb") = True Then
                        TextBox4.Text = File.ReadAllText("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\4.idb")
                        ChosenResource = ChosenResource + 1
                        TextBox4.Enabled = False
                    End If
                    If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\5.idb") = True Then
                        TextBox5.Text = File.ReadAllText("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\5.idb")
                        ChosenResource = ChosenResource + 1
                        TextBox5.Enabled = False
                    End If
                    MsgBox(ChosenResource & " sumber telah ditemukan!")
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MsgBox("bingo!")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Hati hati! Pemilihan foto ini hanya bisa dilakukan satu kali!", MsgBoxStyle.OkOnly, "Perhatian!")
        Dim AskFoto1 As New OpenFileDialog With {.Title = "Pilihlah foto calon No. 1", .DefaultExt = "C:\", .Filter = "File Gambar/Foto (JPG)|*.jpg"}
        If AskFoto1.ShowDialog = DialogResult.OK Then
            Foto1Source = AskFoto1.FileName
            PictureBox1.BackgroundImage = Image.FromFile(Foto1Source)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Hati hati! Pemilihan foto ini hanya bisa dilakukan satu kali!", MsgBoxStyle.OkOnly, "Perhatian!")
        Dim AskFoto2 As New OpenFileDialog With {.Title = "Pilihlah foto calon No. 2", .DefaultExt = "C:\", .Filter = "File Gambar/Foto (JPG)|*.jpg"}
        If AskFoto2.ShowDialog = DialogResult.OK Then
            Foto2Source = AskFoto2.FileName
            PictureBox2.BackgroundImage = Image.FromFile(Foto2Source)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Hati hati! Pemilihan foto ini hanya bisa dilakukan satu kali!", MsgBoxStyle.OkOnly, "Perhatian!")
        Dim AskFoto3 As New OpenFileDialog With {.Title = "Pilihlah foto calon No. 3", .DefaultExt = "C:\", .Filter = "File Gambar/Foto (JPG)|*.jpg"}
        If AskFoto3.ShowDialog = DialogResult.OK Then
            Foto3Source = AskFoto3.FileName
            PictureBox3.BackgroundImage = Image.FromFile(Foto3Source)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Hati hati! Pemilihan foto ini hanya bisa dilakukan satu kali!", MsgBoxStyle.OkOnly, "Perhatian!")
        Dim AskFoto4 As New OpenFileDialog With {.Title = "Pilihlah foto calon No. 4", .DefaultExt = "C:\", .Filter = "File Gambar/Foto (JPG)|*.jpg"}
        If AskFoto4.ShowDialog = DialogResult.OK Then
            Foto4Source = AskFoto4.FileName
            PictureBox4.BackgroundImage = Image.FromFile(Foto4Source)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("Hati hati! Pemilihan foto ini hanya bisa dilakukan satu kali!", MsgBoxStyle.OkOnly, "Perhatian!")
        Dim AskFoto5 As New OpenFileDialog With {.Title = "Pilihlah foto calon No. 5", .DefaultExt = "C:\", .Filter = "File Gambar/Foto (JPG)|*.jpg"}
        If AskFoto5.ShowDialog = DialogResult.OK Then
            Foto5Source = AskFoto5.FileName
            PictureBox5.BackgroundImage = Image.FromFile(Foto5Source)
        End If
    End Sub
End Class