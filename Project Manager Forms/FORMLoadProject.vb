Imports MySql.Data.MySqlClient

Public Class FORMLoadProject

    Dim CurrentProjectSelectedID = 0

    Private Sub BTNLoadProject_Click(sender As Object, e As EventArgs) Handles BTNLoadProject.Click
        'asks the user for the password, loads sucessfully if it is correct, else continually prompts for password
        'the project is loaded and the form is closed
        GetPassword()
        While LoadData(CurrentProjectSelectedID) = 0
            GetPassword()
            LoadData(CurrentProjectSelectedID)
        End While
        CurrentlyLoadingProject = False
        LoadWindowOpen = False
        MsgBox("Project has been loaded.")
        Me.Close()
    End Sub

    Private Sub LISTProjectList_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles LISTProjectList.AfterSelect
        'after a project in the list has been selected
        'determine the current node index
        CurrentProjectSelectedID = e.Node.Tag
        'determine the task id of the currently selected node
    End Sub

    Private Function LoadProjectNames()
        'gets all of the projects from the database
        'adds all of their names to an array which is passed back to the main program
        Dim ProjectNameArray As New Dictionary(Of Integer, String)
        Dim strConn = "Server = localhost;
        			userid = root;
        			password =;
        			Database = mysql;
        			pooling = false;"
        Dim conn As New MySqlConnection(strConn)
        Dim da As New MySqlDataAdapter
        Dim datasks As New MySqlDataAdapter
        Dim cmd As New MySqlCommand
        Dim ds As New DataSet
        conn.Open()

        cmd = New MySqlCommand(String.Format("SELECT * FROM TBLProjects;"), conn)
        da = New MySqlDataAdapter(cmd)
        da.Fill(ds, "TBLProjects")
        For Each Row In ds.Tables("TBLProjects").Rows
            If Row.Item(1) <> "" Then
                ProjectNameArray.Add(Row.Item(0), Row.Item(1))
            End If
        Next

        Return ProjectNameArray
    End Function

    Private Sub FORMLoadProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'disables the exit button if the program is just loading
        'adds each project name to the list
        Dim CurrentProjects As New Dictionary(Of Integer, String)
        If CurrentlyLoadingProject = True Then
            BTNExit.Enabled = False
        End If
        CurrentProjects = LoadProjectNames()
        For Each ProjectToAdd In CurrentProjects
            If ProjectToAdd.Value <> "" Then
                Dim NewProject = New TreeNode(ProjectToAdd.Value)
                NewProject.Tag = ProjectToAdd.Key
                LISTProjectList.Nodes.Add(NewProject)
            End If
        Next
    End Sub

    Private Sub BTNExit_Click(sender As Object, e As EventArgs) Handles BTNExit.Click
        LoadWindowOpen = False
        Me.Close()
    End Sub
End Class

