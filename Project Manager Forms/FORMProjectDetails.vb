Public Class FORMProjectDetails
    Private Sub BTNExit_Click(sender As Object, e As EventArgs) Handles BTNExit.Click
        'ID As Integer, Table As String, Field As String, NewValue As String
        CurrentProject.SetName(TEXTBOXProjectName.Text)
        Dim NameCommand As New EditCommand(CurrentProjectID, "TBLProjects", "name", CurrentProject.GetName)
        CurrentProject.SetDescription(TEXTBOXProjectDescription.Text)
        Dim DescriptionCommand As New EditCommand(CurrentProjectID, "TBLProjects", "description", CurrentProject.GetDescription)
        CurrentProject.SetIdealStartDate(DATETIMEProjectISD.Value)
        Dim ISDCommand As New EditCommand(CurrentProjectID, "TBLProjects", "idealstartdate", CurrentProject.GetIdealStartDate)
        CurrentProject.SetIdealEndDate(DATETIMEProjectIED.Value)
        Dim IEDCommand As New EditCommand(CurrentProjectID, "TBLProjects", "idealenddate", CurrentProject.GetIdealEndDate)
        CurrentProject.SetRealStartDate(DATETIMEProjectRSD.Value)
        Dim RSDCOmmand As New EditCommand(CurrentProjectID, "TBLProjects", "realstartdate", CurrentProject.GetRealStartDate)
        CurrentProject.SetRealEndDate(DATETIMEProjectRED.Value)
        Dim REDCommand As New EditCommand(CurrentProjectID, "TBLProjects", "realenddate", CurrentProject.GetRealEndDate)
        ProjectWindowOpen = False
        Me.Close()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TEXTBOXProjectName.Text = CurrentProject.GetName
        TEXTBOXProjectDescription.Text = CurrentProject.GetDescription
        DATETIMEProjectISD.Value = CurrentProject.GetIdealStartDate
        DATETIMEProjectIED.Value = CurrentProject.GetIdealEndDate
        DATETIMEProjectRSD.Value = CurrentProject.GetRealStartDate
        DATETIMEProjectRED.Value = CurrentProject.GetRealEndDate
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Confirm As DialogResult = MessageBox.Show("Delete the project?", "Are you sure?", MessageBoxButtons.YesNo)

        If (Confirm = DialogResult.OK) Then
            Dim DeleteProject As New DeleteCommand(CurrentProjectID, "TBLProject")
        End If

        MessageBox.Show("Closing the program now.")
        Application.Exit()
    End Sub

End Class