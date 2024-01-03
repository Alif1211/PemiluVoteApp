Imports System.IO

Public Class ClientSetup
    Private DataCounter As Integer = 0
    Private MissingFiles As String = "Berikut ada file/folder yang tidak ada :"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.ScrollBars = ScrollBars.None
        If Directory.Exists("\\" & TextBox1.Text & "\PemiluEVote") = True Then
            TextBox2.Text = "[ ADA ] Folder Server"
        Else
            DataCounter = DataCounter - 25
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote"
            TextBox2.Text = "[NIHIL] Folder Server"
        End If
        If Directory.Exists("\\" & TextBox1.Text & "\PemiluEVote\userdata") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Folder Data Pemilih"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\userdata"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Folder Data Pemilih"
        End If
        If Directory.Exists("\\" & TextBox1.Text & "\PemiluEVote\candidatedata") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Folder Data Calon"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\candidatedata"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Folder Data Calon"
        End If
        If Directory.Exists("\\" & TextBox1.Text & "\PemiluEVote\resultdata") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Folder Hasil Pemilihan"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\resultdata"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Folder Hasil Pemilihan"
        End If
        If File.Exists("\\" & TextBox1.Text & "\PemiluEVote\candidatedata\1.jpg") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Foto Calon 1"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\candidatedata\1.jpg"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Foto Calon 1"
        End If
        If File.Exists("\\" & TextBox1.Text & "\PemiluEVote\candidatedata\2.jpg") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Foto Calon 2"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\candidatedata\2.jpg"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Foto Calon 2"
        End If
        If File.Exists("\\" & TextBox1.Text & "\PemiluEVote\candidatedata\3.jpg") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Foto Calon 3"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\candidatedata\3.jpg"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Foto Calon 3"
        End If
        If File.Exists("\\" & TextBox1.Text & "\PemiluEVote\candidatedata\4.jpg") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Foto Calon 4"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\candidatedata\4.jpg"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Foto Calon 4"
        End If
        If File.Exists("\\" & TextBox1.Text & "\PemiluEVote\candidatedata\5.jpg") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Foto Calon 5"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\candidatedata\5.jpg"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Foto Calon 5"
        End If
        If File.Exists("\\" & TextBox1.Text & "\PemiluEVote\candidatedata\1.idb") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Nama Calon 1"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\candidatedata\1.idb"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Nama Calon 1"
        End If
        If File.Exists("\\" & TextBox1.Text & "\PemiluEVote\candidatedata\2.idb") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Nama Calon 2"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\candidatedata\2.idb"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Nama Calon 2"
        End If
        If File.Exists("\\" & TextBox1.Text & "\PemiluEVote\candidatedata\3.idb") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Nama Calon 3"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\candidatedata\3.idb"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Nama Calon 3"
        End If
        If File.Exists("\\" & TextBox1.Text & "\PemiluEVote\candidatedata\4.idb") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Nama Calon 4"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\candidatedata\4.idb"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Nama Calon 4"
        End If
        If File.Exists("\\" & TextBox1.Text & "\PemiluEVote\candidatedata\5.idb") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Nama Calon 5"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\candidatedata\5.idb"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Nama Calon 5"
        End If
        If File.Exists("\\" & TextBox1.Text & "\PemiluEVote\candidatedata\1.txt") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Visi Misi Calon 1"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\candidatedata\1.txt"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Visi Misi Calon 1"
        End If
        If File.Exists("\\" & TextBox1.Text & "\PemiluEVote\candidatedata\2.txt") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Visi Misi Calon 2"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\candidatedata\2.txt"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Visi Misi Calon 2"
        End If
        If File.Exists("\\" & TextBox1.Text & "\PemiluEVote\candidatedata\3.txt") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Visi Misi Calon 3"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\candidatedata\3.txt"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Visi Misi Calon 3"
        End If
        If File.Exists("\\" & TextBox1.Text & "\PemiluEVote\candidatedata\4.txt") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Visi Misi Calon 4"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\candidatedata\4.txt"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Visi Misi Calon 4"
        End If
        If File.Exists("\\" & TextBox1.Text & "\PemiluEVote\candidatedata\5.txt") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Visi Misi Calon 5"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\candidatedata\5.txt"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Visi Misi Calon 5"
        End If
        TextBox2.ScrollBars = ScrollBars.Vertical
        If File.Exists("\\" & TextBox1.Text & "\PemiluEVote\resultdata\masterdata.csv") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Riwayat Vote Pusat"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\resultdata\masterdata.csv"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Riwayat Vote Pusat"
        End If
        If File.Exists("\\" & TextBox1.Text & "\PemiluEVote\resultdata\1.csv") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Jumlah Vote Calon 1"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\resultdata\1.csv"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Jumlah Vote Calon 1"
        End If
        If File.Exists("\\" & TextBox1.Text & "\PemiluEVote\resultdata\2.csv") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Jumlah Vote Calon 2"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\resultdata\2.csv"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Jumlah Vote Calon 2"
        End If
        If File.Exists("\\" & TextBox1.Text & "\PemiluEVote\resultdata\3.csv") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Jumlah Vote Calon 3"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\resultdata\3.csv"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Jumlah Vote Calon 3"
        End If
        If File.Exists("\\" & TextBox1.Text & "\PemiluEVote\resultdata\4.csv") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Jumlah Vote Calon 4"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\resultdata\4.csv"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Jumlah Vote Calon 4"
        End If
        If File.Exists("\\" & TextBox1.Text & "\PemiluEVote\resultdata\5.csv") = True Then
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[ ADA ] Jumlah Vote Calon 5"
        Else
            DataCounter = DataCounter + 1
            MissingFiles = MissingFiles & Environment.NewLine & "\\" & TextBox1.Text & "\PemiluEVote\resultdata\5.csv"
            TextBox2.Text = TextBox2.Text & Environment.NewLine & "[NIHIL] Jumlah Vote Calon 5"
        End If
        Select Case DataCounter
            Case < 0
                TextBox2.Text = "[ERROR] Folder server tidak ditemukan"
                MsgBox("Folder server tidak ditemukan")
            Case 0
                MsgBox("Semua file yang dibutuhkan ada di server")
                Button3.Enabled = True
                VarCentre.Hostname = TextBox1.Text
            Case Else
                MessageBox.Show(DataCounter & " file/folder tidak ada di server" & Environment.NewLine & Environment.NewLine & MissingFiles & Environment.NewLine & Environment.NewLine & "Silahkan cek komputer admin untuk melihat apakah file berikut ada di tempatnya")
        End Select
        DataCounter = 0
        MissingFiles = "Berikut ada file/folder yang tidak ada :"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoginForm.Show()
        StartPage.Close()
        Close()
    End Sub
End Class