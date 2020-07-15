Public Class FORMAnalysis
    Private Sub BTNExit_Click(sender As Object, e As EventArgs) Handles BTNExit.Click
        AnalysisWindowOpen = False
        Me.Close()
    End Sub

    Private Function CalculateDate()
        Dim DateNumber As Integer
        Dim DateNumberString
        DateNumberString = (CurrentProject.GetRealEndDate - CurrentProject.GetRealStartDate)
        DateNumber = DateNumberString.TotalDays()
        Return DateNumber
    End Function

    Private Function CalculatePercentage()
        Dim Percentage As Integer
        Dim Counter As Integer
        For Each Task In AllTasks
            If Task.Value.GetComplete() = True Then
                Counter += 1
            End If
        Next
        Percentage = (Counter / AllTasks.Count) * 100
        Return Percentage
    End Function

    Private Sub FORMAnalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If AllTasks.Count = 0 Then
            MsgBox("No tasks to analyse")
        Else
            LBLDNumberOfDays.Text = String.Format("{0} days", CalculateDate())
            LBLDPercentage.Text = String.Format("{0}%", CalculatePercentage())
        End If
    End Sub
End Class