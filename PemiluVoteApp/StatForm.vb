Imports System.IO

Public Class StatForm
    Dim DataDelay As Integer
    Dim DataTypes As Integer
    Private Sub StatForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chart1.Series("Jumlah Pemilih").Points.Clear()
        Chart1.Series("Jumlah Pemilih").Points.AddXY(File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\1.idb"), File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\1.rst"))
        Chart1.Series("Jumlah Pemilih").Points.AddXY(File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\2.idb"), File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\2.rst"))
        Chart1.Series("Jumlah Pemilih").Points.AddXY(File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\3.idb"), File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\3.rst"))
        Chart1.Series("Jumlah Pemilih").Points.AddXY(File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\4.idb"), File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\4.rst"))
        Chart1.Series("Jumlah Pemilih").Points.AddXY(File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\5.idb"), File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\5.rst"))
        PictureBox1.BackgroundImage = Image.FromFile("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\1.jpg")
        PictureBox2.BackgroundImage = Image.FromFile("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\2.jpg")
        PictureBox3.BackgroundImage = Image.FromFile("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\3.jpg")
        PictureBox4.BackgroundImage = Image.FromFile("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\4.jpg")
        PictureBox5.BackgroundImage = Image.FromFile("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\5.jpg")
        Label2.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\1.rst")
        Label3.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\2.rst")
        Label4.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\3.rst")
        Label5.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\4.rst")
        Label6.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\5.rst")
    End Sub

    Private Sub FormClosingPrevention(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Dim resultx As DialogResult = MsgBox("Apakah anda yakin ingin keluar?", MsgBoxStyle.YesNo, "Yakin?")
        If resultx = DialogResult.Yes Then
            e.Cancel = 0
            End
        Else
            e.Cancel = 1
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If DataDelay >= 44 Then
            If TimeOfDay.Second = (DataDelay + 15) - 60 Then
                DataGridView1.DataSource = Nothing
                DataGridView1.Refresh()
                DataGridView1.Rows.Clear()
                If DataDelay >= 41 Then
                    DataDelay = (DataDelay + 18) - 60
                Else
                    DataDelay = DataDelay + 18
                End If
                Spawn(DataTypes)
                Chart1.Series("Jumlah Pemilih").Points.Clear()
                Chart1.Series("Jumlah Pemilih").Points.AddXY(File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\1.idb"), File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\1.rst"))
                Chart1.Series("Jumlah Pemilih").Points.AddXY(File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\2.idb"), File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\2.rst"))
                Chart1.Series("Jumlah Pemilih").Points.AddXY(File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\3.idb"), File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\3.rst"))
                Chart1.Series("Jumlah Pemilih").Points.AddXY(File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\4.idb"), File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\4.rst"))
                Chart1.Series("Jumlah Pemilih").Points.AddXY(File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\5.idb"), File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\5.rst"))
                Label2.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\1.rst")
                Label3.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\2.rst")
                Label4.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\3.rst")
                Label5.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\4.rst")
                Label6.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\5.rst")
            End If
        Else
            If TimeOfDay.Second = DataDelay + 15 Then
                DataGridView1.DataSource = Nothing
                DataGridView1.Refresh()
                DataGridView1.Rows.Clear()
                If DataDelay >= 41 Then
                    DataDelay = (DataDelay + 18) - 60
                Else
                    DataDelay = DataDelay + 18
                End If
                Spawn(DataTypes)
                Chart1.Series("Jumlah Pemilih").Points.Clear()
                Chart1.Series("Jumlah Pemilih").Points.AddXY(File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\1.idb"), File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\1.rst"))
                Chart1.Series("Jumlah Pemilih").Points.AddXY(File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\2.idb"), File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\2.rst"))
                Chart1.Series("Jumlah Pemilih").Points.AddXY(File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\3.idb"), File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\3.rst"))
                Chart1.Series("Jumlah Pemilih").Points.AddXY(File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\4.idb"), File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\4.rst"))
                Chart1.Series("Jumlah Pemilih").Points.AddXY(File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\5.idb"), File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\5.rst"))
                Label2.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\1.rst")
                Label3.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\2.rst")
                Label4.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\3.rst")
                Label5.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\4.rst")
                Label6.Text = File.ReadAllText("\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\5.rst")
            End If
        End If
    End Sub

    Private Sub Spawn(Type As Integer)
        Select Case Type
            Case 0
                Dim TextFieldParser1 As New FileIO.TextFieldParser("\\" & Environment.MachineName & "\PemiluEVote\resultdata\masterdata.csv")

                TextFieldParser1.Delimiters = New String() {","}

                While Not TextFieldParser1.EndOfData
                    Dim Row1 As String() = TextFieldParser1.ReadFields()

                    If DataGridView1.Columns.Count = 0 AndAlso Row1.Count > 0 Then
                        Dim i As Integer

                        For i = 0 To Row1.Count - 1
                            DataGridView1.Columns.Add("Column" & i + 1, "Column" & i + 1)
                        Next
                    End If

                    DataGridView1.Rows.Add(Row1)
                End While
            Case 1
                Dim TextFieldParser1 As New FileIO.TextFieldParser("\\" & Environment.MachineName & "\PemiluEVote\resultdata\1.csv")

                TextFieldParser1.Delimiters = New String() {","}

                While Not TextFieldParser1.EndOfData
                    Dim Row1 As String() = TextFieldParser1.ReadFields()

                    If DataGridView1.Columns.Count = 0 AndAlso Row1.Count > 0 Then
                        Dim i As Integer

                        For i = 0 To Row1.Count - 1
                            DataGridView1.Columns.Add("Column" & i + 1, "Column" & i + 1)
                        Next
                    End If

                    DataGridView1.Rows.Add(Row1)
                End While
            Case 2
                Dim TextFieldParser1 As New FileIO.TextFieldParser("\\" & Environment.MachineName & "\PemiluEVote\resultdata\2.csv")

                TextFieldParser1.Delimiters = New String() {","}

                While Not TextFieldParser1.EndOfData
                    Dim Row1 As String() = TextFieldParser1.ReadFields()

                    If DataGridView1.Columns.Count = 0 AndAlso Row1.Count > 0 Then
                        Dim i As Integer

                        For i = 0 To Row1.Count - 1
                            DataGridView1.Columns.Add("Column" & i + 1, "Column" & i + 1)
                        Next
                    End If

                    DataGridView1.Rows.Add(Row1)
                End While
            Case 3
                Dim TextFieldParser1 As New FileIO.TextFieldParser("\\" & Environment.MachineName & "\PemiluEVote\resultdata\3.csv")

                TextFieldParser1.Delimiters = New String() {","}

                While Not TextFieldParser1.EndOfData
                    Dim Row1 As String() = TextFieldParser1.ReadFields()

                    If DataGridView1.Columns.Count = 0 AndAlso Row1.Count > 0 Then
                        Dim i As Integer

                        For i = 0 To Row1.Count - 1
                            DataGridView1.Columns.Add("Column" & i + 1, "Column" & i + 1)
                        Next
                    End If

                    DataGridView1.Rows.Add(Row1)
                End While
            Case 4
                Dim TextFieldParser1 As New FileIO.TextFieldParser("\\" & Environment.MachineName & "\PemiluEVote\resultdata\4.csv")

                TextFieldParser1.Delimiters = New String() {","}

                While Not TextFieldParser1.EndOfData
                    Dim Row1 As String() = TextFieldParser1.ReadFields()

                    If DataGridView1.Columns.Count = 0 AndAlso Row1.Count > 0 Then
                        Dim i As Integer

                        For i = 0 To Row1.Count - 1
                            DataGridView1.Columns.Add("Column" & i + 1, "Column" & i + 1)
                        Next
                    End If

                    DataGridView1.Rows.Add(Row1)
                End While
            Case 5
                Dim TextFieldParser1 As New FileIO.TextFieldParser("\\" & Environment.MachineName & "\PemiluEVote\resultdata\5.csv")

                TextFieldParser1.Delimiters = New String() {","}

                While Not TextFieldParser1.EndOfData
                    Dim Row1 As String() = TextFieldParser1.ReadFields()

                    If DataGridView1.Columns.Count = 0 AndAlso Row1.Count > 0 Then
                        Dim i As Integer

                        For i = 0 To Row1.Count - 1
                            DataGridView1.Columns.Add("Column" & i + 1, "Column" & i + 1)
                        Next
                    End If

                    DataGridView1.Rows.Add(Row1)
                End While
        End Select
        DataGridView1.CurrentCell = DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(DataGridView1.CurrentCell.ColumnIndex)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
        DataGridView1.Rows.Clear()
        Select Case ComboBox1.SelectedItem
            Case "Pusat"
                DataTypes = 0
                DataDelay = TimeOfDay.Second
                Timer1.Start()
                Spawn(DataTypes)
            Case "No. 1"
                DataTypes = 1
                DataDelay = TimeOfDay.Second
                Timer1.Start()
                Spawn(DataTypes)
            Case "No. 2"
                DataTypes = 2
                DataDelay = TimeOfDay.Second
                Timer1.Start()
                Spawn(DataTypes)
            Case "No. 3"
                DataTypes = 3
                DataDelay = TimeOfDay.Second
                Timer1.Start()
                Spawn(DataTypes)
            Case "No. 4"
                DataTypes = 4
                DataDelay = TimeOfDay.Second
                Timer1.Start()
                Spawn(DataTypes)
            Case "No. 5"
                DataTypes = 5
                DataDelay = TimeOfDay.Second
                Timer1.Start()
                Spawn(DataTypes)
        End Select
    End Sub
End Class