Imports System.IO

Public Class ServerSetup
    Dim Foto1Source As String
    Dim Foto2Source As String
    Dim Foto3Source As String
    Dim Foto4Source As String
    Dim Foto5Source As String
    Dim VM1Source As String
    Dim VM2Source As String
    Dim VM3Source As String
    Dim VM4Source As String
    Dim VM5Source As String
    Dim ChosenResource As Integer = 0
    Dim ShouldClose As Boolean = False


    Private Sub ServerSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChosenResource = 0
        Label7.Text = "Nama server : " & Environment.MachineName
        Timer1.Start()
        'CheckFile()
    End Sub

    Private Sub FormClosingPrevention(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If ShouldClose = False Then
            e.Cancel = 1
        Else
            e.Cancel = 0
        End If
    End Sub

    Public Sub CheckFile()
        If Directory.Exists("\\" & Environment.MachineName & "\PemiluEVote") = True Then
            If Directory.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata") = True Then
                'Later have to isolate each filegrab to see if it exists or not
                Try
                    If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\1.jpg") = True Then
                        Foto1Source = "\\" & Environment.MachineName & "\PemiluEVote\candidatedata\1.jpg"
                        PictureBox1.BackgroundImage = Image.FromFile(Foto1Source)
                        ChosenResource = ChosenResource + 1
                        Button1.Enabled = False
                    End If
                    If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\2.jpg") = True Then
                        Foto2Source = "\\" & Environment.MachineName & "\PemiluEVote\candidatedata\2.jpg"
                        PictureBox2.BackgroundImage = Image.FromFile(Foto2Source)
                        ChosenResource = ChosenResource + 1
                        Button2.Enabled = False
                    End If
                    If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\3.jpg") = True Then
                        Foto3Source = "\\" & Environment.MachineName & "\PemiluEVote\candidatedata\3.jpg"
                        PictureBox3.BackgroundImage = Image.FromFile(Foto3Source)
                        ChosenResource = ChosenResource + 1
                        Button3.Enabled = False
                    End If
                    If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\4.jpg") = True Then
                        Foto4Source = "\\" & Environment.MachineName & "\PemiluEVote\candidatedata\4.jpg"
                        PictureBox4.BackgroundImage = Image.FromFile(Foto4Source)
                        ChosenResource = ChosenResource + 1
                        Button4.Enabled = False
                    End If
                    If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\5.jpg") = True Then
                        Foto5Source = "\\" & Environment.MachineName & "\PemiluEVote\candidatedata\5.jpg"
                        PictureBox5.BackgroundImage = Image.FromFile(Foto5Source)
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
                    If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\1.txt") = True Then
                        VM1Source = "\\" & Environment.MachineName & "\PemiluEVote\candidatedata\1.txt"
                        ChosenResource = ChosenResource + 1
                        Button6.Enabled = False
                    End If
                    If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\2.txt") = True Then
                        VM2Source = "\\" & Environment.MachineName & "\PemiluEVote\candidatedata\2.txt"
                        ChosenResource = ChosenResource + 1
                        Button7.Enabled = False
                    End If
                    If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\3.txt") = True Then
                        VM3Source = "\\" & Environment.MachineName & "\PemiluEVote\candidatedata\3.txt"
                        ChosenResource = ChosenResource + 1
                        Button8.Enabled = False
                    End If
                    If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\4.txt") = True Then
                        VM4Source = "\\" & Environment.MachineName & "\PemiluEVote\candidatedata\4.txt"
                        ChosenResource = ChosenResource + 1
                        Button9.Enabled = False
                    End If
                    If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\5.txt") = True Then
                        VM5Source = "\\" & Environment.MachineName & "\PemiluEVote\candidatedata\5.txt"
                        ChosenResource = ChosenResource + 1
                        Button10.Enabled = False
                    End If
                    If ChosenResource = 15 Then
                        Dim yeornah As DialogResult = MsgBox("Apakah anda ingin melanjutkan sesi sebelumnya?", MsgBoxStyle.YesNo)
                        If yeornah = DialogResult.Yes Then
                            ShouldClose = True
                            ServerDashboard.Show()
                            Close()
                        End If
                    Else
                        MsgBox(ChosenResource & " sumber telah ditemukan!")
                    End If
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        StartPage.Show()
        ShouldClose = True
        Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ServerSetupDoing.Show()
        If Directory.Exists("\\" & Environment.MachineName & "\PemiluEVote\resultdata") = False Then
            Directory.CreateDirectory("\\" & Environment.MachineName & "\PemiluEVote\resultdata")
        End If
        If Directory.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata") = False Then
            Directory.CreateDirectory("\\" & Environment.MachineName & "\PemiluEVote\candidatedata")
        End If
        PictureBox1.BackgroundImage = Nothing
        PictureBox2.BackgroundImage = Nothing
        PictureBox3.BackgroundImage = Nothing
        PictureBox4.BackgroundImage = Nothing
        PictureBox5.BackgroundImage = Nothing
        File.Copy(Foto1Source, "\\" & Environment.MachineName & "\PemiluEVote\candidatedata\1.jpg")
        File.Copy(Foto2Source, "\\" & Environment.MachineName & "\PemiluEVote\candidatedata\2.jpg")
        File.Copy(Foto3Source, "\\" & Environment.MachineName & "\PemiluEVote\candidatedata\3.jpg")
        File.Copy(Foto4Source, "\\" & Environment.MachineName & "\PemiluEVote\candidatedata\4.jpg")
        File.Copy(Foto5Source, "\\" & Environment.MachineName & "\PemiluEVote\candidatedata\5.jpg")
        File.Copy(VM1Source, "\\" & Environment.MachineName & "\PemiluEVote\candidatedata\1.txt")
        File.Copy(VM2Source, "\\" & Environment.MachineName & "\PemiluEVote\candidatedata\2.txt")
        File.Copy(VM3Source, "\\" & Environment.MachineName & "\PemiluEVote\candidatedata\3.txt")
        File.Copy(VM4Source, "\\" & Environment.MachineName & "\PemiluEVote\candidatedata\4.txt")
        File.Copy(VM5Source, "\\" & Environment.MachineName & "\PemiluEVote\candidatedata\5.txt")
        File.WriteAllText("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\1.idb", TextBox1.Text)
        File.WriteAllText("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\2.idb", TextBox2.Text)
        File.WriteAllText("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\3.idb", TextBox3.Text)
        File.WriteAllText("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\4.idb", TextBox4.Text)
        File.WriteAllText("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\5.idb", TextBox5.Text)
        File.WriteAllText("\\" & Environment.MachineName & "\PemiluEVote\resultdata\masterdata.csv", My.Resources.masterdata)
        File.WriteAllText("\\" & Environment.MachineName & "\PemiluEVote\resultdata\1.csv", My.Resources._1csv)
        File.WriteAllText("\\" & Environment.MachineName & "\PemiluEVote\resultdata\2.csv", My.Resources._2csv)
        File.WriteAllText("\\" & Environment.MachineName & "\PemiluEVote\resultdata\3.csv", My.Resources._3csv)
        File.WriteAllText("\\" & Environment.MachineName & "\PemiluEVote\resultdata\4.csv", My.Resources._4csv)
        File.WriteAllText("\\" & Environment.MachineName & "\PemiluEVote\resultdata\5.csv", My.Resources._5csv)
        File.WriteAllBytes("\\" & Environment.MachineName & "\PemiluEVote\resultdata\1.rst", My.Resources._1rst)
        File.WriteAllBytes("\\" & Environment.MachineName & "\PemiluEVote\resultdata\2.rst", My.Resources._2rst)
        File.WriteAllBytes("\\" & Environment.MachineName & "\PemiluEVote\resultdata\3.rst", My.Resources._3rst)
        File.WriteAllBytes("\\" & Environment.MachineName & "\PemiluEVote\resultdata\4.rst", My.Resources._4rst)
        File.WriteAllBytes("\\" & Environment.MachineName & "\PemiluEVote\resultdata\5.rst", My.Resources._5rst)
        ServerSetupDoing.Close()
        StatForm.Show()
        ShouldClose = True
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim AskFoto1 As New OpenFileDialog With {.Title = "Pilihlah foto calon No. 1", .DefaultExt = "C:\", .Filter = "File Gambar/Foto (JPG)|*.jpg"}
        If AskFoto1.ShowDialog = DialogResult.OK Then
            Foto1Source = AskFoto1.FileName
            PictureBox1.BackgroundImage = Image.FromFile(Foto1Source)
            ChosenResource = ChosenResource + 1
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim AskFoto2 As New OpenFileDialog With {.Title = "Pilihlah foto calon No. 2", .DefaultExt = "C:\", .Filter = "File Gambar/Foto (JPG)|*.jpg"}
        If AskFoto2.ShowDialog = DialogResult.OK Then
            Foto2Source = AskFoto2.FileName
            PictureBox2.BackgroundImage = Image.FromFile(Foto2Source)
            ChosenResource = ChosenResource + 1
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim AskFoto3 As New OpenFileDialog With {.Title = "Pilihlah foto calon No. 3", .DefaultExt = "C:\", .Filter = "File Gambar/Foto (JPG)|*.jpg"}
        If AskFoto3.ShowDialog = DialogResult.OK Then
            Foto3Source = AskFoto3.FileName
            PictureBox3.BackgroundImage = Image.FromFile(Foto3Source)
            ChosenResource = ChosenResource + 1
            Button3.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim AskFoto4 As New OpenFileDialog With {.Title = "Pilihlah foto calon No. 4", .DefaultExt = "C:\", .Filter = "File Gambar/Foto (JPG)|*.jpg"}
        If AskFoto4.ShowDialog = DialogResult.OK Then
            Foto4Source = AskFoto4.FileName
            PictureBox4.BackgroundImage = Image.FromFile(Foto4Source)
            ChosenResource = ChosenResource + 1
            Button4.Enabled = False
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim AskFoto5 As New OpenFileDialog With {.Title = "Pilihlah foto calon No. 5", .DefaultExt = "C:\", .Filter = "File Gambar/Foto (JPG)|*.jpg"}
        If AskFoto5.ShowDialog = DialogResult.OK Then
            Foto5Source = AskFoto5.FileName
            PictureBox5.BackgroundImage = Image.FromFile(Foto5Source)
            ChosenResource = ChosenResource + 1
            Button5.Enabled = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim AskVM1 As New OpenFileDialog With {.Title = "Pilihlah visi misi calon No. 1", .DefaultExt = "C:\", .Filter = "Teks (TXT)|*.txt"}
        If AskVM1.ShowDialog = DialogResult.OK Then
            VM1Source = AskVM1.FileName
            ChosenResource = ChosenResource + 1
            Button6.Enabled = False
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim AskVM2 As New OpenFileDialog With {.Title = "Pilihlah visi misi calon No. 2", .DefaultExt = "C:\", .Filter = "Teks (TXT)|*.txt"}
        If AskVM2.ShowDialog = DialogResult.OK Then
            VM2Source = AskVM2.FileName
            ChosenResource = ChosenResource + 1
            Button7.Enabled = False
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim AskVM3 As New OpenFileDialog With {.Title = "Pilihlah visi misi calon No. 3", .DefaultExt = "C:\", .Filter = "Teks (TXT)|*.txt"}
        If AskVM3.ShowDialog = DialogResult.OK Then
            VM3Source = AskVM3.FileName
            ChosenResource = ChosenResource + 1
            Button8.Enabled = False
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim AskVM4 As New OpenFileDialog With {.Title = "Pilihlah visi misi calon No. 4", .DefaultExt = "C:\", .Filter = "Teks (TXT)|*.txt"}
        If AskVM4.ShowDialog = DialogResult.OK Then
            VM4Source = AskVM4.FileName
            ChosenResource = ChosenResource + 1
            Button9.Enabled = False
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim AskVM5 As New OpenFileDialog With {.Title = "Pilihlah visi misi calon No. 5", .DefaultExt = "C:\", .Filter = "Teks (TXT)|*.txt"}
        If AskVM5.ShowDialog = DialogResult.OK Then
            VM5Source = AskVM5.FileName
            ChosenResource = ChosenResource + 1
            Button10.Enabled = False
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim result As DialogResult = MsgBox("Apakah anda yakin?" & Environment.NewLine & "Apabila ada data yang sudah anda, data tersebut akan terhapus dari folder admin", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            If IsNothing(PictureBox1.BackgroundImage) = False Then
                PictureBox1.BackgroundImage = My.Resources._nothing
                Foto1Source = Nothing
                Button1.Enabled = True
                ChosenResource = ChosenResource - 1
            End If
            If TextBox1.Enabled = False Then
                TextBox1.Text = Nothing
                TextBox1.Enabled = True
                ChosenResource = ChosenResource - 1
            End If
            If Not VM1Source = Nothing Then
                VM1Source = Nothing
                Button6.Enabled = True
                ChosenResource = ChosenResource - 1
            End If
            DeleteTheDamnFile(1)
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim result As DialogResult = MsgBox("Apakah anda yakin?" & Environment.NewLine & "Apabila ada data yang sudah anda, data tersebut akan terhapus dari folder admin", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            If IsNothing(PictureBox2.BackgroundImage) = False Then
                PictureBox2.BackgroundImage = Nothing
                Foto2Source = Nothing
                Button2.Enabled = True
                ChosenResource = ChosenResource - 1
            End If
            If TextBox2.Enabled = False Then
                TextBox2.Text = Nothing
                TextBox2.Enabled = True
                ChosenResource = ChosenResource - 1
            End If
            If Not VM2Source = Nothing Then
                VM2Source = Nothing
                Button7.Enabled = True
                ChosenResource = ChosenResource - 1
            End If
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim result As DialogResult = MsgBox("Apakah anda yakin?" & Environment.NewLine & "Apabila ada data yang sudah anda, data tersebut akan terhapus dari folder admin", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            If IsNothing(PictureBox3.BackgroundImage) = False Then
                PictureBox3.BackgroundImage = Nothing
                Foto3Source = Nothing
                Button3.Enabled = True
                ChosenResource = ChosenResource - 1
            End If
            If TextBox3.Enabled = False Then
                TextBox3.Text = Nothing
                TextBox3.Enabled = True
                ChosenResource = ChosenResource - 1
            End If
            If Not VM3Source = Nothing Then
                VM3Source = Nothing
                Button8.Enabled = True
                ChosenResource = ChosenResource - 1
            End If
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim result As DialogResult = MsgBox("Apakah anda yakin?" & Environment.NewLine & "Apabila ada data yang sudah anda, data tersebut akan terhapus dari folder admin", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            If IsNothing(PictureBox4.BackgroundImage) = False Then
                PictureBox4.BackgroundImage = Nothing
                Foto4Source = Nothing
                Button4.Enabled = True
                ChosenResource = ChosenResource - 1
            End If
            If TextBox4.Enabled = False Then
                TextBox4.Text = Nothing
                TextBox4.Enabled = True
                ChosenResource = ChosenResource - 1
            End If
            If Not VM4Source = Nothing Then
                VM4Source = Nothing
                Button9.Enabled = True
                ChosenResource = ChosenResource - 1
            End If
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim result As DialogResult = MsgBox("Apakah anda yakin?" & Environment.NewLine & "Apabila ada data yang sudah anda, data tersebut akan terhapus dari folder admin", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            If IsNothing(PictureBox5.BackgroundImage) = False Then
                PictureBox5.BackgroundImage = Nothing
                Foto5Source = Nothing
                Button5.Enabled = True
                ChosenResource = ChosenResource - 1
            End If
            If TextBox5.Enabled = False Then
                TextBox5.Text = Nothing
                TextBox5.Enabled = True
                ChosenResource = ChosenResource - 1
            End If
            If Not VM5Source = Nothing Then
                VM5Source = Nothing
                Button10.Enabled = True
                ChosenResource = ChosenResource - 1
            End If
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If Not TextBox1.Text = Nothing Then
            If TextBox1.Enabled = True Then
                TextBox1.Enabled = False
                ChosenResource = ChosenResource + 1
            Else
                TextBox1.Enabled = True
                ChosenResource = ChosenResource - 1
            End If
        Else
            MsgBox("Masukkan Nama!")
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If Not TextBox2.Text = Nothing Then
            If TextBox2.Enabled = True Then
                TextBox2.Enabled = False
                ChosenResource = ChosenResource + 1
            Else
                TextBox2.Enabled = True
                ChosenResource = ChosenResource - 1
            End If
        Else
            MsgBox("Masukkan Nama!")
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If Not TextBox3.Text = Nothing Then
            If TextBox3.Enabled = True Then
                TextBox3.Enabled = False
                ChosenResource = ChosenResource + 1
            Else
                TextBox3.Enabled = True
                ChosenResource = ChosenResource - 1
            End If
        Else
            MsgBox("Masukkan Nama!")
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If Not TextBox4.Text = Nothing Then
            If TextBox4.Enabled = True Then
                TextBox4.Enabled = False
                ChosenResource = ChosenResource + 1
            Else
                TextBox4.Enabled = True
                ChosenResource = ChosenResource - 1
            End If
        Else
            MsgBox("Masukkan Nama!")
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If Not TextBox5.Text = Nothing Then
            If TextBox5.Enabled = True Then
                TextBox5.Enabled = False
                ChosenResource = ChosenResource + 1
            Else
                TextBox5.Enabled = True
                ChosenResource = ChosenResource - 1
            End If
        Else
            MsgBox("Masukkan Nama!")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ChosenResource = 15 Then
            Button11.Enabled = True
        Else
            Button11.Enabled = False
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs)
        Dim result2 As DialogResult = MsgBox("Apakah anda yakin untuk menghapus file kandidat yang sudah ada?", MsgBoxStyle.YesNo)
        If result2 = MsgBoxResult.Yes Then
            ShouldClose = True
            ServerSetupDelete.Show()
            Close()
            DeleteTheDamnFile(1)
        End If
    End Sub
End Class