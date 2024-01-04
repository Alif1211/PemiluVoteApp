Imports System.IO

Public Class Form1
    Dim NIPM As String()
    Dim password As String()
    Dim kelas As String()
    Dim ado As String()
    Dim nama As String()
    Dim jumkel As String()
    Dim currentado As Integer = 0
    Dim currentNIPM As Integer = 0
    Dim currentpassword As Integer = 0
    Dim currentkelas As Integer = 0
    Dim currentnama As Integer = 0
    Dim currentjumkel As Integer = 0
    Dim ShouldStop As Boolean = False
    Dim UserFiles(4) As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        NIPM = File.ReadAllLines("D:\Work Files\PemiluUserData\NIPM.txt")
        password = File.ReadAllLines("D:\Work Files\PemiluUserData\passwords.txt")
        kelas = File.ReadAllLines("D:\Work Files\PemiluUserData\Kelas.txt")
        ado = File.ReadAllLines("D:\Work Files\PemiluUserData\Ado.txt")
        nama = File.ReadAllLines("D:\Work Files\PemiluUserData\Nama.txt")
        jumkel = File.ReadAllLines("D:\Work Files\PemiluUserData\jumkel.txt")
        UserFiles(0) = Nothing
        UserFiles(1) = Nothing
        UserFiles(2) = Nothing
        UserFiles(3) = Nothing
        UserFiles(4) = Nothing
        ProgressBar1.Maximum = ado(currentado)
        ProgressBar2.Maximum = jumkel(currentjumkel)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = NIPM(currentNIPM)
        Label5.Text = currentNIPM
        Label4.Visible = False
        Select Case Label3.Text
            Case "switch"
                currentNIPM = currentNIPM + 1
                Label3.Text = NIPM(currentNIPM)
                Label5.Text = currentNIPM
                Label4.Visible = True
                currentkelas = currentkelas + 1
                currentjumkel = currentjumkel + 1
                ProgressBar2.Value = 0
                ProgressBar2.Maximum = jumkel(currentjumkel)
            Case "FUCK"
                Timer1.Stop()
                ShouldStop = True
        End Select
        If ShouldStop = True Then
            MsgBox("!")
        Else
            Label2.Text = nama(currentnama)
            Label6.Text = currentnama
            Label1.Text = kelas(currentkelas)
            Label7.Text = currentkelas
            TextBox1.Text = password(currentpassword)
            Label8.Text = currentpassword
            ProgressBar2.Value = ProgressBar2.Value + 1
            ProgressBar1.Value = currentkelas
            UserFiles(0) = NIPM(currentNIPM)
            UserFiles(1) = nama(currentnama)
            UserFiles(2) = kelas(currentkelas)
            UserFiles(3) = password(currentpassword)
            UserFiles(4) = 0
            Dim PutList As String = File.ReadAllText("D:\Work Files\PemiluUserData\Username\list.csv")
            PutList = PutList & Environment.NewLine & NIPM(currentNIPM) & "," & nama(currentnama) & "," & kelas(currentkelas) & "," & password(currentpassword)
            File.WriteAllText("D:\Work Files\PemiluUserData\Username\list.csv", PutList)
            currentNIPM = currentNIPM + 1
            currentnama = currentnama + 1
            currentpassword = currentpassword + 1
            File.WriteAllLines("D:\Work Files\PemiluUserData\Username\" & Label3.Text & ".udb", UserFiles)
        End If
    End Sub
End Class
