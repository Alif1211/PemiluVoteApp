Module ErrorModule

    Public Sub ErrHandler(Cause As String)
        Select Case Cause
            Case "\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\1.jpg"
                MsgBox("Foto Calon No. 1 tidak ditemukan! (Kode: DB0101)")
            Case "\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\2.jpg"
                MsgBox("Foto Calon No. 2 tidak ditemukan! (Kode: DB0102)")
            Case "\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\3.jpg"
                MsgBox("Foto Calon No. 3 tidak ditemukan! (Kode: DB0103)")
            Case "\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\4.jpg"
                MsgBox("Foto Calon No. 4 tidak ditemukan! (Kode: DB0104)")
            Case "\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\5.jpg"
                MsgBox("Foto Calon No. 5 tidak ditemukan! (Kode: DB0105)")
            Case "Could not find file '\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\1.idb'."
                MsgBox("Nama Calon No. 1 tidak ditemukan! (Kode: DB0106)")
            Case "Could not find file '\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\2.idb'."
                MsgBox("Nama Calon No. 2 tidak ditemukan! (Kode: DB0107)")
            Case "Could not find file '\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\3.idb'."
                MsgBox("Nama Calon No. 3 tidak ditemukan! (Kode: DB0108)")
            Case "Could not find file '\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\4.idb'."
                MsgBox("Nama Calon No. 4 tidak ditemukan! (Kode: DB0109)")
            Case "Could not find file '\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\5.idb'."
                MsgBox("Nama Calon No. 5 tidak ditemukan! (Kode: DB0110)")
            Case "Could not find file '\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\1.txt'."
                MsgBox("Visi Misi Calon No. 1 tidak ditemukan! (Kode: DB0111)")
            Case "Could not find file '\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\2.txt'."
                MsgBox("Visi Misi Calon No. 2 tidak ditemukan! (Kode: DB0112)")
            Case "Could not find file '\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\3.txt'."
                MsgBox("Visi Misi Calon No. 3 tidak ditemukan! (Kode: DB0113)")
            Case "Could not find file '\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\4.txt'."
                MsgBox("Visi Misi Calon No. 4 tidak ditemukan! (Kode: DB0114)")
            Case "Could not find file '\\" & VarCentre.Hostname & "\PemiluEVote\candidatedata\5.txt'."
                MsgBox("Visi Misi Calon No. 5 tidak ditemukan! (Kode: DB0115)")
            Case "Could not find file '\\" & VarCentre.Hostname & "\PemiluEVote\resultdata\masterdata.csv'."
                MsgBox("Data Hasil Pusat tidak ditemukan! (Kode: DB0201)")
            Case Else
                MsgBox(Cause)
        End Select
    End Sub
End Module
