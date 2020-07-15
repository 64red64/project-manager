Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Module Data

#Region "Variables"
    Public CurrentProject As New Project()
    Public AllTasks As New Dictionary(Of Integer, Task)
    Public CurrentProjectID = 0
    Public CurrentTaskID = 0
    Public CurrentPropertyID = 0
    Public CommandQueue As Queue = New Queue()
    Public NumberOfNodes As Integer 'number of nodes in the form

    'WINDOW CONTROLS
    Public ProjectWindowOpen As Boolean
    Public TasksWindowOpen As Boolean
    Public AnalysisWindowOpen As Boolean
    Public ScheduleWindowOpen As Boolean
    Public LoadWindowOpen As Boolean
    Public CurrentlyLoadingProject As Boolean
#End Region

    Public Function TranslateBooleanToSQL(Value As Boolean)
        'translates a vb boolean into a corresponding sql boolean
        If Value = True Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Public Sub GetPassword()
        Dim PasswordToHash As String
        PasswordToHash = InputBox("Please input the password")
        CurrentProject.SetCurrentPassword(PasswordToHash)
        CurrentProject.SetCurrentHashedPassword(HashValue(PasswordToHash))
    End Sub

#Region "Incrementing Current Values"
    Public Sub IncrementCurrentProjectID()
        CurrentProjectID += 1
        WriteCurrentIDs()
    End Sub

    Public Sub IncrementCurrentTaskID()
        CurrentTaskID += 1
        WriteCurrentIDs()
    End Sub

    Public Sub IncrementCurrentPropertyID()
        CurrentPropertyID += 1
        WriteCurrentIDs()
    End Sub
#End Region

#Region "Writing and Loading from data.dat"
    Public Sub WriteCurrentIDs()
        'writes the new values to data.dat
        Dim bw As BinaryWriter
        Try
            bw = New BinaryWriter(New FileStream(Application.StartupPath + "\data.dat",
                                                 FileMode.OpenOrCreate))
            bw.Write(CurrentProjectID)
            bw.Write(CurrentTaskID)
            bw.Write(CurrentPropertyID)
        Catch ex As IOException
            MessageBox.Show(ex.Message + " Cannot write to file.")
            Return
        End Try
        bw.Flush()
        bw.Close()
    End Sub

    Public Sub LoadCurrentIDs()
        'loading current ids from data.dat
        'or creating it with default values of 0 if it does not exist
        Dim br As BinaryReader

        If My.Computer.FileSystem.FileExists(Application.StartupPath + "\data.dat") Then
            Try
                br = New BinaryReader(New FileStream(Application.StartupPath + "\data.dat",
                                                     FileMode.Open))
                CurrentProjectID = br.ReadInt32()
                CurrentTaskID = br.ReadInt32()
                CurrentPropertyID = br.ReadInt32()
                br.Close()
            Catch ex As IOException
                Console.WriteLine(ex.Message + " Cannot read from file.")
                Return
            End Try
        Else
            WriteCurrentIDs()
        End If
    End Sub
#End Region

End Module

Module EncryptDecrypt

    'code from https://docs.microsoft.com/en-us/dotnet/visual-basic/programming-guide/language-features/strings/walkthrough-encrypting-and-decrypting-strings
    Public NotInheritable Class Simple3Des
        Private TripleDes As New TripleDESCryptoServiceProvider

        Private Function TruncateHash(
    ByVal key As String,
    ByVal length As Integer) As Byte()

            Dim sha1 As New SHA1CryptoServiceProvider

            ' Hash the key.
            Dim keyBytes() As Byte =
        System.Text.Encoding.Unicode.GetBytes(key)
            Dim hash() As Byte = sha1.ComputeHash(keyBytes)

            ' Truncate or pad the hash.
            ReDim Preserve hash(length - 1)
            Return hash
        End Function

        Sub New(ByVal key As String)
            ' Initialize the crypto provider.
            TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
            TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
        End Sub

        Public Function EncryptData(
    ByVal plaintext As String) As String

            ' Convert the plaintext string to a byte array.
            Dim plaintextBytes() As Byte =
        System.Text.Encoding.Unicode.GetBytes(plaintext)

            ' Create the stream.
            Dim ms As New System.IO.MemoryStream
            ' Create the encoder to write to the stream.
            Dim encStream As New CryptoStream(ms,
        TripleDes.CreateEncryptor(),
        System.Security.Cryptography.CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
            encStream.FlushFinalBlock()

            ' Convert the encrypted stream to a printable string.
            Return Convert.ToBase64String(ms.ToArray)
        End Function

        Public Function DecryptData(
    ByVal encryptedtext As String) As String

            ' Convert the encrypted text string to a byte array.
            Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

            ' Create the stream.
            Dim ms As New System.IO.MemoryStream
            ' Create the decoder to write to the stream.
            Dim decStream As New CryptoStream(ms,
        TripleDes.CreateDecryptor(),
        System.Security.Cryptography.CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
            decStream.FlushFinalBlock()

            ' Convert the plaintext stream to a string.
            Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
        End Function
    End Class

    Public Function EncryptData(Data As String)
        Dim wrapper As New Simple3Des(CurrentProject.GetCurrentPassword)
        Data = wrapper.EncryptData(Data)
        Return Data
    End Function

    Public Function DecryptData(Data As String)
        Dim wrapper As New Simple3Des(CurrentProject.GetCurrentPassword)
        ' DecryptData throws if the wrong password is used.
        Try
            Data = wrapper.DecryptData(Data)
        Catch ex As System.Security.Cryptography.CryptographicException
            MsgBox("The data could not be decrypted with the password.")
        End Try
        Return Data
    End Function

    Public Function HashValue(Value As String)

        Using Hasher As MD5 = MD5.Create()
            'CODE FROM: https://stackoverflow.com/questions/23513831/hash-with-md5-in-vb-net
            ' Convert to byte array and get hash
            Dim Hash As Byte() = Hasher.ComputeHash(Encoding.UTF8.GetBytes(Value))

            ' sb to create string from bytes
            Dim HashArray As New StringBuilder()

            ' convert byte data to hex string
            For n As Integer = 0 To Hash.Length - 1
                HashArray.Append(Hash(n).ToString("X2"))
            Next n

            Return HashArray.ToString()
        End Using

    End Function
End Module

Module Database
    Public Sub CreateDatabase()
        'creates the database if it does not exist.
        Dim strConn = "Server = localhost;
					userid = root;
					password =;
					Database = mysql;
					pooling = false;"

        Dim conn As New MySqlConnection(strConn)
        Dim cmd As MySqlCommand
        conn.Open()

        cmd = New MySqlCommand("Create Database If Not exists projectmanagerdb", conn)
        cmd.ExecuteNonQuery()

        'create projects table
        cmd = New MySqlCommand("create table If Not exists TBLProjects
					(id int,
					name varchar (50),
					description varchar (1024),
                    idealstartdate varchar (64),
                    idealenddate varchar (64),
                    realstartdate varchar (64),
                    realenddate varchar (64),
                    password varchar(256),
					primary key (id))", conn)
        cmd.ExecuteNonQuery()

        'create tasks table
        cmd = New MySqlCommand("create table If Not exists TBLTasks
					(id int,
					name varchar (320),
					description varchar (2560),
                    idealstartdate varchar (64),
                    idealenddate varchar (64),
                    realstartdate varchar (64),
                    realenddate varchar (64),                 
                    scheduled boolean,
                    important boolean,
                    complete boolean,
                    cost double,
                    personnel varchar(2560),
                    parenttaskid integer,
                    projectid integer,
					primary key (id))", conn)
        cmd.ExecuteNonQuery()

        'create properties table
        cmd = New MySqlCommand("create table If Not exists TBLProperties
                    (id int,
                    name varchar (320),
                    value varchar (2560),
                    parentid int,
                    primary key (id))", conn)
        cmd.ExecuteNonQuery()

        cmd = New MySqlCommand("ALTER TABLE TBLProjects ENGINE = InnoDB;", conn)
        cmd.ExecuteNonQuery()
        cmd = New MySqlCommand("ALTER TABLE TBLTasks ENGINE = InnoDB;", conn)
        cmd.ExecuteNonQuery()
        cmd = New MySqlCommand("ALTER TABLE TBLProperties ENGINE = InnoDB;", conn)
        cmd.ExecuteNonQuery()

        conn.Close()

    End Sub

    Public Function LoadData(ProjectID As Integer)
        'gets all projects from the database where the id = the given project id
        'saves the data from that to CurrentProject
        'gets tasks from the database where the task project id = the given project id
        'for each task in that data:
        '   create a new task, save to all tasks
        '   set the data from that to a new task, decrypting it as it goes
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

        cmd = New MySqlCommand(String.Format("SELECT * FROM TBLProjects WHERE id = {0};", ProjectID),
                               conn)
        da = New MySqlDataAdapter(cmd)
        da.Fill(ds, "TBLProjects")
        If ds.Tables("TBLProjects").Rows(0).Item(7) = CurrentProject.GetCurrentHashedPassword Then
            CurrentProject.SetID(ds.Tables("TBLProjects").Rows(0).Item(0))
            CurrentProject.SetName(ds.Tables("TBLProjects").Rows(0).Item(1))
            CurrentProject.SetDescription(ds.Tables("TBLProjects").Rows(0).Item(2))
            CurrentProject.SetIdealStartDate(ds.Tables("TBLProjects").Rows(0).Item(3))
            CurrentProject.SetIdealEndDate(ds.Tables("TBLProjects").Rows(0).Item(4))
            CurrentProject.SetRealStartDate(ds.Tables("TBLProjects").Rows(0).Item(5))
            CurrentProject.SetRealEndDate(ds.Tables("TBLProjects").Rows(0).Item(6))
            CurrentProject.SetCurrentHashedPassword(ds.Tables("TBLProjects").Rows(0).Item(7))

            cmd = New MySqlCommand(String.Format("SELECT * FROM TBLTasks WHERE projectid = {0};",
                                                 ProjectID), conn)
            datasks = New MySqlDataAdapter(cmd)
            datasks.Fill(ds, "TBLTasks")
            For Each Row In ds.Tables("TBLTasks").Rows
                If Row.Item(1) <> "" Then
                    CurrentProject.CreateTask(True, Row.Item(0))
                    AllTasks.Item(Row.Item(0)).SetID(Row.Item(0))
                    AllTasks.Item(Row.Item(0)).SetName(DecryptData(Row.Item(1)))
                    AllTasks.Item(Row.Item(0)).SetDescription(DecryptData(Row.Item(2)))
                    AllTasks.Item(Row.Item(0)).SetIdealStartDate(Row.Item(3))
                    AllTasks.Item(Row.Item(0)).SetIdealEndDate(Row.Item(4))
                    AllTasks.Item(Row.Item(0)).SetRealStartDate(Row.Item(5))
                    AllTasks.Item(Row.Item(0)).SetRealEndDate(Row.Item(6))
                    AllTasks.Item(Row.Item(0)).SetScheduled(Row.Item(7))
                    AllTasks.Item(Row.Item(0)).SetImportant(Row.Item(8))
                    AllTasks.Item(Row.Item(0)).SetComplete(Row.Item(9))
                    AllTasks.Item(Row.Item(0)).SetPersonnel(DecryptData(Row.Item(11)))
                    AllTasks.Item(Row.Item(0)).SetCost(Row.Item(10))
                    AllTasks.Item(Row.Item(0)).SetParentID(Row.Item(12))
                    NumberOfNodes += 1
                    Dim propertycmd = New MySqlCommand(String.Format("SELECT * FROM TBLProperties 
                                        WHERE parentid = {0};", Row.Item(0)), conn)
                    Dim propertydata = New MySqlDataAdapter(propertycmd)
                    propertydata.Fill(ds, "TBLProperties")
                    For Each Roww In ds.Tables("TBLProperties").Rows
                        AllTasks.Item(Row.Item(0)).AddProperty(DecryptData(Roww.Item(1)),
                                                               DecryptData(Roww.Item(2)))
                    Next
                End If
            Next
            Return 1
        Else
            Return 0
        End If

        'PROPERTIES

    End Function
End Module

Module Tasks
    Structure TaskProperty
        Dim Name As String
        Dim Value As String
    End Structure

    Class Root
        Private ID As Integer
        Private Name As String
        Private Description As String
        Private IdealStartDate As Date
        Private IdealEndDate As Date
        Private RealStartDate As Date
        Private RealEndDate As Date

#Region "Getters And Setters"
#Region "Getters"
        'GETTERS
        Public Function GetID()
            Return ID
        End Function
        Public Function GetName()
            Return Name
        End Function
        Public Function GetDescription()
            Return Description
        End Function
        Public Function GetIdealStartDate()
            Return IdealStartDate
        End Function
        Public Function GetIdealEndDate()
            Return IdealEndDate
        End Function
        Public Function GetRealStartDate()
            Return RealStartDate
        End Function
        Public Function GetRealEndDate()
            Return RealEndDate
        End Function
#End Region
#Region "Setters"
        Public Sub SetID(ID As Integer)
            Me.ID = ID
        End Sub
        Public Sub SetName(Name As String)
            Me.Name = Name
        End Sub
        Public Sub SetDescription(Description As String)
            Me.Description = Description
        End Sub
        Public Sub SetIdealStartDate(IdealStartDate As Date)
            Me.IdealStartDate = IdealStartDate
        End Sub
        Public Sub SetIdealEndDate(IdealEndDate As Date)
            Me.IdealEndDate = IdealEndDate
        End Sub
        Public Sub SetRealStartDate(RealStartDate As Date)
            Me.RealStartDate = RealStartDate
        End Sub
        Public Sub SetRealEndDate(RealEndDate As Date)
            Me.RealEndDate = RealEndDate
        End Sub
#End Region
#End Region

#Region "Tasks"
        Public Sub CreateTask(Loading As Boolean, ID As Integer)
            Dim NewTask As New Task
            'creates a task object and adds it to the dictionary
            If Loading = False Then
                'if this a NEW task, then create it with a new id
                NewTask.SetID(CurrentTaskID)
            Else
                'else use the id that loads with the task
                NewTask.SetID(ID)
            End If
            'default values
            NewTask.SetName("Untitled task")
            NewTask.SetDescription("No description")
            NewTask.SetIdealStartDate(Today)
            NewTask.SetIdealEndDate(Today)
            NewTask.SetRealStartDate(Today)
            NewTask.SetRealEndDate(Today)
            NewTask.SetScheduled(False)
            NewTask.SetComplete(False)
            NewTask.SetComplete(False)
            NewTask.SetPersonnel("")
            NewTask.SetCost(0)
            NewTask.SetParentID(0)
            AllTasks.Add(NewTask.GetID, NewTask)
            If Loading = False Then
                IncrementCurrentTaskID()
            End If
        End Sub
#End Region
    End Class

    Class Project
        Inherits Root

        Private CurrentPassword As String
        Private CurrentHashedPassword As String

        Public Sub New()
            Me.SetName("New project")
            Me.SetDescription("New project")
            Me.SetIdealStartDate(Today)
            Me.SetIdealEndDate(Today)
            Me.SetRealStartDate(Today)
            Me.SetRealEndDate(Today)
            Me.SetCurrentHashedPassword("")
        End Sub

        Public Sub SetCurrentHashedPassword(CurrentHashedPassword As String)
            Me.CurrentHashedPassword = CurrentHashedPassword
        End Sub
        Public Function GetCurrentHashedPassword()
            Return CurrentHashedPassword
        End Function

        Public Sub SetCurrentPassword(CurrentPassword As String)
            Me.CurrentPassword = CurrentPassword
        End Sub
        Public Function GetCurrentPassword()
            Return CurrentPassword
        End Function

    End Class

    Class Task
        Inherits Root

        Private ParentID = 0
        Private Scheduled As Boolean
        Private Important As Boolean
        Private Complete As Boolean
        Private Personnel As String
        Private Cost As Double
        Private Properties As New Dictionary(Of Integer, TaskProperty)

#Region "Getters And Setters"
#Region "Getters"
        Public Function GetParentID()
            Return ParentID
        End Function
        Public Function GetScheduled()
            Return Scheduled
        End Function
        Public Function GetImportant()
            Return Important
        End Function
        Public Function GetComplete()
            Return Complete
        End Function
        Public Function GetPersonnel()
            Return Personnel
        End Function
        Public Function GetCost()
            Return Cost
        End Function
        Public Function GetProperties()
            Return Properties
        End Function
#End Region
#Region "Setters"
        Public Sub SetParentID(ParentID As Integer)
            Me.ParentID = ParentID
        End Sub
        Public Sub SetScheduled(Scheduled As Boolean)
            Me.Scheduled = Scheduled
        End Sub
        Public Sub SetImportant(Important As Boolean)
            Me.Important = Important
        End Sub
        Public Sub SetComplete(Complete As Boolean)
            Me.Complete = Complete
        End Sub
        Public Sub SetPersonnel(Personnel As String)
            Me.Personnel = Personnel
        End Sub
        Public Sub SetCost(Cost As Decimal)
            Me.Cost = Cost
        End Sub
#End Region
#End Region

#Region "Properties"
        Public Sub AddProperty(Name As String, Value As String)
            Dim NewProperty As TaskProperty
            NewProperty.Name = Name
            NewProperty.Value = Value
            Properties.Add(CurrentPropertyID, NewProperty)
            IncrementCurrentPropertyID()
        End Sub

        Public Sub EditProperty(ID As Integer, Name As String, Value As String)
            Dim PropertyToEdit As TaskProperty
            PropertyToEdit.Name = Name
            PropertyToEdit.Value = Value
            Properties(ID) = PropertyToEdit
        End Sub

        Public Sub DeleteProperty(ID As Integer)
            Properties.Remove(ID)
        End Sub
#End Region

        Public Sub DeleteTask()
            'nullifies task's values so it is skipped over when loading
            Me.SetName("")
            Me.SetDescription("")
            Me.SetIdealStartDate(Today)
            Me.SetIdealEndDate(Today)
            Me.SetRealStartDate(Today)
            Me.SetRealEndDate(Today)
            Me.SetParentID(0)
        End Sub

        Public Function FindProperty(ID As Integer)
            Return Properties(ID)
        End Function

        Public Sub New()
            'sets the default value so that an empty value isn't loaded into the database
            Me.SetCost(0.00)
        End Sub

    End Class
End Module

Module Commands

    Class Command

        Private FinalCommand As String

        Public Sub SetFinalCommand(FinalCommand)
            'sets the command and then adds it to the queue
            Me.FinalCommand = FinalCommand
        End Sub

        Public Sub Execute()
            'connects to the sql server and runs the command
            Dim strConn = "Server = localhost;
                    userid = root;
					password =;
					Database = mysql;
					pooling = false;"

            Dim conn As New MySqlConnection(strConn)
            Dim cmd As MySqlCommand
            conn.Open()

            cmd = New MySqlCommand(FinalCommand, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        End Sub
    End Class

#Region "Create"

    Class CreateCommand
        Inherits Command
    End Class

    Class CreateProjectCommand
        Inherits CreateCommand

        Public Sub New(ProjectToAdd As Project)
            Dim NewCommand As String
            Dim ISD = ProjectToAdd.GetIdealStartDate.Date.ToString()
            Dim IED = ProjectToAdd.GetIdealEndDate.Date.ToString()
            Dim RSD = ProjectToAdd.GetRealStartDate.Date.ToString()
            Dim RED = ProjectToAdd.GetRealEndDate.Date.ToString()
            NewCommand = String.Format("INSERT INTO TBLProjects VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');",
                                       ProjectToAdd.GetID, ProjectToAdd.GetName,
                                       EncryptData(ProjectToAdd.GetDescription), ISD,
                                       IED, RSD,
                                       RED, ProjectToAdd.GetCurrentHashedPassword)
            SetFinalCommand(NewCommand)
            CommandQueue.Enqueue(Me)
        End Sub
    End Class

    Class CreateTaskCommand
        Inherits CreateCommand
        Public Sub New(TaskToAdd As Task)
            Dim NewCommand As String
            'converts datetimes into strings so it may be stored as a varchar in the database
            Dim ISD = TaskToAdd.GetIdealStartDate.Date.ToString()
            Dim IED = TaskToAdd.GetIdealEndDate.Date.ToString()
            Dim RSD = TaskToAdd.GetRealStartDate.Date.ToString()
            Dim RED = TaskToAdd.GetRealEndDate.Date.ToString()

            NewCommand = String.Format("INSERT INTO TBLTasks VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}');",
                                    TaskToAdd.GetID, EncryptData(TaskToAdd.GetName), EncryptData(TaskToAdd.GetDescription),
                                    ISD, IED, RSD, RED,
                                    TranslateBooleanToSQL(TaskToAdd.GetScheduled), TranslateBooleanToSQL(TaskToAdd.GetImportant),
                                    TranslateBooleanToSQL(TaskToAdd.GetComplete), TaskToAdd.GetCost, EncryptData(TaskToAdd.GetPersonnel),
                                    TaskToAdd.GetParentID, CurrentProjectID)
            SetFinalCommand(NewCommand)
            CommandQueue.Enqueue(Me)
        End Sub

    End Class

    Class CreatePropertyCommand
        Inherits CreateCommand
        Public Sub New(PropertyToAdd As TaskProperty, CurrentTID As Integer)
            Dim NewCommand As String
            NewCommand = String.Format("INSERT INTO TBLProperties VALUES ('{0}', '{1}', '{2}', '{3}');",
                                       CurrentPropertyID, EncryptData(PropertyToAdd.Name), EncryptData(PropertyToAdd.Value), CurrentTID)
            SetFinalCommand(NewCommand)
            CommandQueue.Enqueue(Me)
        End Sub

    End Class

#End Region

#Region "Other Commands"
    Class EditCommand
        Inherits Command

        Public Sub New(ID As Integer, Table As String, Field As String, NewValue As String)
            Dim NewCommand As String
            MsgBox(NewValue)
            If Field = "name" Or Field = "description" Or Field = "value" Or Field = "personnel" Then
                If Table <> "TBLProjects" Then
                    NewCommand = String.Format("UPDATE {0} SET {1} = '{2}' WHERE id = {3};", Table, Field, EncryptData(NewValue), ID)
                Else
                    NewCommand = String.Format("UPDATE {0} SET {1} = '{2}' WHERE id = {3};", Table, Field, NewValue, ID)
                End If
            Else
                If Field = "complete" Or Field = "scheduled" Or Field = "important" Then
                    NewValue = TranslateBooleanToSQL(NewValue)
                End If
                NewCommand = String.Format("UPDATE {0} SET {1} = '{2}' WHERE id = {3};", Table, Field, NewValue, ID)
                End If

            MsgBox(NewCommand)
            SetFinalCommand(NewCommand)
            CommandQueue.Enqueue(Me)
        End Sub
    End Class

    Class DeleteCommand
        Inherits Command

        Public Sub New(ID As Integer, Table As String)
            Dim NewCommand As String
            NewCommand = String.Format("DELETE FROM '{0}' WHERE id = {1};", Table, ID)
            SetFinalCommand(NewCommand)
            CommandQueue.Enqueue(Me)
        End Sub
    End Class
#End Region
End Module

Public Class FORMMain
    Private Sub BTNLoadProject_Click(sender As Object, e As EventArgs) Handles BTNLoadProject.Click
        'only open the window if the window is closed
        If LoadWindowOpen = False Then
            Dim LoadProject As New FORMLoadProject()
            LoadWindowOpen = True
            LoadProject.Show()
        End If
    End Sub

    Private Sub BTNSaveProject_Click(sender As Object, e As EventArgs) Handles BTNSaveProject.Click
        'if the project is new, then ask the user to set a password
        'then execute every command in the queue
        Dim ClonedQueue = CommandQueue.Clone()
        For Each Command In CommandQueue
            ClonedQueue.Dequeue().Execute()
        Next

        CommandQueue.Clear()
        MsgBox("Project has been saved.")
    End Sub

    Private Sub BTNViewProject_Click(sender As Object, e As EventArgs) Handles BTNViewProject.Click
        'only open the window if the window is closed
        If ProjectWindowOpen = False Then
            Dim ProjectDetails As New FORMProjectDetails()
            ProjectWindowOpen = True
            ProjectDetails.Show()
        End If
    End Sub

    Private Sub BTNViewTasks_Click(sender As Object, e As EventArgs) Handles BTNViewTasks.Click
        'only open the window if the window is closed
        If TasksWindowOpen = False Then
            Dim TaskDetails As New FORMTaskDetails()
            TasksWindowOpen = True
            TaskDetails.Show()
        End If
    End Sub

    Private Sub BTNAnalysis_Click(sender As Object, e As EventArgs) Handles BTNAnalysis.Click
        'only open the window if the window is closed
        If AnalysisWindowOpen = False Then
            Dim Analysis As New FORMAnalysis()
            AnalysisWindowOpen = True
            Analysis.Show()
        End If
    End Sub

    Private Sub BTNSchedule_Click(sender As Object, e As EventArgs) Handles BTNSchedule.Click
        If ScheduleWindowOpen = False Then
            Dim Schedule As New FORMSchedule()
            ScheduleWindowOpen = True
            Schedule.Show()
        End If
    End Sub

    Private Sub FORMMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateDatabase()
        LoadCurrentIDs() 'loads the current project/task/property ids to the program
        Dim Confirm As DialogResult = MessageBox.Show("Do you want to create a new project?", "Load or create?", MessageBoxButtons.YesNo)
        If (Confirm = DialogResult.Yes) Then
            IncrementCurrentProjectID()
            GetPassword()
            CurrentProject.SetID(CurrentProjectID)
            Dim ProjectToSave As New CreateProjectCommand(CurrentProject)
        Else
            LoadProject()
        End If

    End Sub

    Private Sub LoadProject()
        Dim LoadProject As New FORMLoadProject()
        CurrentlyLoadingProject = True
        LoadWindowOpen = True
        LoadProject.Show()
    End Sub
End Class
