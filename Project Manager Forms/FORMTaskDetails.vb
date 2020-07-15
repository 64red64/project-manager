Public Class FORMTaskDetails

    Private CurrentTaskNode As Integer 'current node id
    Private CurrentPropertyNode As Integer
    Private CurrentTID As Integer 'current task id
    Private CurrentPID As Integer

    Private Sub SetValuesToTask()
        'sets the values of the recently created task to the form itself
        'in this case it is the default values whenever a new task is created
        TEXTBOXTaskName.Text = AllTasks(CurrentTID).GetName
        TEXTBOXTaskDescription.Text = AllTasks(CurrentTID).GetDescription
        DATETaskISD.Value = AllTasks(CurrentTID).GetIdealStartDate
        DATETaskIED.Value = AllTasks(CurrentTID).GetIdealEndDate
        DATETaskRSD.Value = AllTasks(CurrentTID).GetRealStartDate
        DATETaskRED.Value = AllTasks(CurrentTID).GetRealEndDate
        CHECKTaskComplete.Checked = AllTasks(CurrentTID).GetComplete
        CHECKTaskScheduled.Checked = AllTasks(CurrentTID).GetScheduled
        CHECKTaskCritical.Checked = AllTasks(CurrentTID).GetImportant
        TEXTBOXTaskPersonnel.Text = AllTasks(CurrentTID).GetPersonnel
        TEXTBOXTaskCost.Text = AllTasks(CurrentTID).GetCost
    End Sub

    Private Sub CreateNewTask()
        Dim NewTask = New TreeNode("Untitled task")
        NewTask.Tag = CurrentTaskID
        CurrentProject.CreateTask(False, 0)
        LISTTasks.Nodes.Add(NewTask)
        CurrentTID = CurrentTaskID - 1
        Dim Command As New CreateTaskCommand(AllTasks(CurrentTID))

        SetValuesToTask()

        NumberOfNodes += 1
        LISTTasks.Refresh()
    End Sub

    Private Sub BTNExit_Click(sender As Object, e As EventArgs) Handles BTNExit.Click
        TasksWindowOpen = False
        Me.Close()
    End Sub

    Private Sub FORMTaskDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTNPropertyEdit.Enabled = False
        If NumberOfNodes = 0 Then
            CreateNewTask()
        Else
            For Each Task In AllTasks
                If Task.Value.GetName() <> "" Then
                    Dim NewTask = New TreeNode(Task.Value.GetName())
                    NewTask.Tag = Task.Value.GetID()
                    LISTTasks.Nodes.Add(NewTask)
                End If
            Next
        End If
    End Sub

    Private Sub BTNCreateTask_Click(sender As Object, e As EventArgs) Handles BTNCreateTask.Click
        CreateNewTask()
    End Sub

    Private Sub LISTTasks_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles LISTTasks.AfterSelect
        'determine the current node index
        CurrentTaskNode = e.Node.Index
        'determine the task id of the currently selected node
        CurrentTID = e.Node.Tag


        'update the form with the details of the task after the node is selected
        SetValuesToTask()
        LISTProperties.Nodes.Clear()

        Dim TaskProperties As New Dictionary(Of Integer, TaskProperty)
        TaskProperties = AllTasks(CurrentTID).GetProperties()

        For Each TaskProperty In TaskProperties
            Dim PropertyToAdd As New TreeNode(TaskProperty.Value.Name)
            PropertyToAdd.Tag = TaskProperty.Key
            LISTProperties.Nodes.Add(PropertyToAdd)
        Next

    End Sub

    Private Sub BTNSaveTaskInfo_Click(sender As Object, e As EventArgs) Handles BTNSaveTaskInfo.Click
        'add all the changes to the task itself
        LISTTasks.Nodes(CurrentTaskNode).Text = TEXTBOXTaskName.Text
        AllTasks(CurrentTID).SetName(TEXTBOXTaskName.Text)
        Dim NameCommand As New EditCommand(CurrentTID, "TBLtasks", "name", AllTasks(CurrentTID).GetName)
        AllTasks(CurrentTID).SetDescription(TEXTBOXTaskDescription.Text)
        Dim DescCommand As New EditCommand(CurrentTID, "TBLtasks", "description", AllTasks(CurrentTID).GetDescription)
        AllTasks(CurrentTID).SetIdealStartDate(DATETaskISD.Value)
        Dim ISDCommand As New EditCommand(CurrentTID, "TBLtasks", "idealstartdate", AllTasks(CurrentTID).GetIdealStartDate)
        AllTasks(CurrentTID).SetIdealEndDate(DATETaskIED.Value)
        Dim IEDCommand As New EditCommand(CurrentTID, "TBLtasks", "idealenddate", AllTasks(CurrentTID).GetIdealEndDate)
        AllTasks(CurrentTID).SetRealStartDate(DATETaskRSD.Value)
        Dim RSDCommand As New EditCommand(CurrentTID, "TBLtasks", "realstartdate", AllTasks(CurrentTID).GetRealStartDate)
        AllTasks(CurrentTID).SetRealEndDate(DATETaskRED.Value)
        Dim REDCommand As New EditCommand(CurrentTID, "TBLtasks", "realenddate", AllTasks(CurrentTID).GetRealEndDate)
        AllTasks(CurrentTID).SetComplete(CHECKTaskComplete.Checked)
        Dim CompleteCommand As New EditCommand(CurrentTID, "TBLtasks", "complete", AllTasks(CurrentTID).GetComplete)
        AllTasks(CurrentTID).SetScheduled(CHECKTaskScheduled.Checked)
        Dim ScheduledCommand As New EditCommand(CurrentTID, "TBLtasks", "scheduled", AllTasks(CurrentTID).GetScheduled)
        AllTasks(CurrentTID).SetImportant(CHECKTaskCritical.Checked)
        Dim ImportantCommand As New EditCommand(CurrentTID, "TBLtasks", "important", AllTasks(CurrentTID).GetImportant)
        AllTasks(CurrentTID).SetPersonnel(TEXTBOXTaskPersonnel.Text)
        Dim PersonnelCommand As New EditCommand(CurrentTID, "TBLtasks", "personnel", AllTasks(CurrentTID).GetPersonnel)
        AllTasks(CurrentTID).SetCost(CDec(TEXTBOXTaskCost.Text))
        Dim CostCommand As New EditCommand(CurrentTID, "TBLtasks", "cost", AllTasks(CurrentTID).GetCost)
        Dim ParentIDCommand As New EditCommand(CurrentTID, "TBLtasks", "parenttaskid", AllTasks(CurrentTID).GetParentID)
    End Sub

    Private Sub BTNDeleteTask_Click(sender As Object, e As EventArgs) Handles BTNDeleteTask.Click
        'deletes a task so long as the node isn't 0
        If CurrentTaskNode <> 0 Then
            Dim TaskToDelete = LISTTasks.Nodes.Item(CurrentTaskNode)
            AllTasks(LISTTasks.Nodes.Item(CurrentTaskNode).Tag).DeleteTask()
            TaskToDelete.Remove()
        End If
    End Sub

    Private Sub BTNCreateProperty_Click(sender As Object, e As EventArgs) Handles BTNCreateProperty.Click
        AllTasks(CurrentTID).AddProperty("Unitled property", "No value")
        Dim PropertyCommand As New CreatePropertyCommand(AllTasks(CurrentTID).FindProperty(CurrentPropertyID - 1), CurrentTID)
        Dim PropertyToAdd As New TreeNode("Unitled property")
        PropertyToAdd.Tag = CurrentPropertyID - 1
        LISTProperties.Nodes.Add(PropertyToAdd)
    End Sub

    Private Sub BTNDeleteProperty_Click(sender As Object, e As EventArgs) Handles BTNDeleteProperty.Click
        AllTasks(CurrentTID).DeleteProperty(CurrentPID)
        Dim PropertyCommand As New DeleteCommand(CurrentPID, "TBLProperties")
        LISTProperties.Nodes.RemoveAt(CurrentTaskNode)
    End Sub

    Private Sub LISTProperties_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles LISTProperties.AfterSelect
        'determine the current node index
        CurrentPropertyNode = e.Node.Index
        'determine the task id of the currently selected node
        CurrentPID = e.Node.Tag

        TEXTBOXPropertyName.Text = AllTasks(CurrentTID).FindProperty(CurrentPID).Name
        TEXTBOXPropertyValue.Text = AllTasks(CurrentTID).FindProperty(CurrentPID).Value
        BTNPropertyEdit.Enabled = True
    End Sub

    Private Sub BTNPropertyEdit_Click(sender As Object, e As EventArgs) Handles BTNPropertyEdit.Click
        Dim Name As String
        Dim Value As String
        Name = TEXTBOXPropertyName.Text
        MsgBox(Name)
        Value = TEXTBOXPropertyValue.Text
        MsgBox(Value)
        LISTProperties.Nodes(CurrentPropertyNode).Text = TEXTBOXPropertyName.Text
        AllTasks(CurrentTID).EditProperty(CurrentPID, TEXTBOXPropertyName.Text, TEXTBOXPropertyValue.Text)
        Dim PropertyCommand As New EditCommand(LISTProperties.Nodes.Item(CurrentPropertyNode).Tag, "TBLProperties", "name", Name)
        Dim PropertyCommandTwo As New EditCommand(LISTProperties.Nodes.Item(CurrentPropertyNode).Tag, "TBLProperties", "value", Value)
    End Sub
End Class