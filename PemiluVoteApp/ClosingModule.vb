Module ClosingModule
    Public Sub ExecutePrevention(bo As FormClosingEventArgs)
        Select Case bo.CloseReason
            Case CloseReason.UserClosing
                Dim AskPW As New FormClosingPrevent
                MsgBox("Eureka!")
                AskPW.ShowDialog()
                If AskPW.IsTrueClose = True Then
                    bo.Cancel = 0
                Else
                    bo.Cancel = 1
                    MsgBox("Nice try!")
                End If
            Case Else
                MsgBox("No Eureka!")
                bo.Cancel = 0
        End Select
    End Sub
End Module
