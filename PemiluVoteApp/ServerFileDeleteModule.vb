Imports System.IO

Module ServerFileDeleteModule
    Public Sub DeleteTheDamnFile(Which As Integer)
        Select Case Which
            Case 1
                If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\1.jpg") = True Then
                    File.Delete("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\1.jpg")
                End If
                If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\1.idb") = True Then
                    File.Delete("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\1.idb")
                End If
                If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\1.txt") = True Then
                    File.Delete("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\1.txt")
                End If
            Case 2
                If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\2.jpg") = True Then
                    File.Delete("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\2.jpg")
                End If
                If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\2.idb") = True Then
                    File.Delete("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\2.idb")
                End If
                If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\2.txt") = True Then
                    File.Delete("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\2.txt")
                End If
            Case 3
                If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\3.jpg") = True Then
                    File.Delete("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\3.jpg")
                End If
                If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\3.idb") = True Then
                    File.Delete("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\3.idb")
                End If
                If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\3.txt") = True Then
                    File.Delete("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\3.txt")
                End If
            Case 4
                If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\4.jpg") = True Then
                    File.Delete("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\4.jpg")
                End If
                If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\4.idb") = True Then
                    File.Delete("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\4.idb")
                End If
                If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\4.txt") = True Then
                    File.Delete("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\4.txt")
                End If
            Case 5
                If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\5.jpg") = True Then
                    File.Delete("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\5.jpg")
                End If
                If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\5.idb") = True Then
                    File.Delete("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\5.idb")
                End If
                If File.Exists("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\5.txt") = True Then
                    File.Delete("\\" & Environment.MachineName & "\PemiluEVote\candidatedata\5.txt")
                End If
        End Select
        ServerSetup.Show()
    End Sub
End Module
