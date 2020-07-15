Imports Microsoft.VisualBasic

Imports System

Module Data
    Public CurrentProject As New Root()
    Public AllTasks As New Dictionary(Of Integer, Task)
    Public CurrentProjectID As Integer
    Public CurrentTaskID As Integer
    Public CurrentPropertyID As Integer
    Public CommandStack As Stack(Of Command)
End Module

Module Tasks
    Structure TaskProperty
        Dim Name As String
        Dim Value As String
    End Structure

    Class Root
        Private ID As Integer
        Private Level As Integer
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
        Public Function GetLevel()
            Return Level
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
        Public Sub SetLevel(Level As Integer)
            Me.Level = Level
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
        Public Sub CreateTask()

        End Sub

        Public Sub DeleteTask()

        End Sub
#End Region
    End Class

    Class Project
        Inherits Root

        Public Sub New()
            Me.SetLevel(0)
        End Sub

        Public Sub CreateProject()
            Me.SetName(Methods.GetInput("Name"))
            Me.SetDescription(Methods.GetInput("Description"))
        End Sub

        Public Sub ViewProject()
            Console.WriteLine(Methods.PrintIndents(2) + "ID: " + Str(Me.GetID))
            Console.WriteLine(Methods.PrintIndents(2) + "Name: " + Me.GetName)
            Console.WriteLine(Methods.PrintIndents(2) + "Description: " + Me.GetDescription)
            Console.WriteLine(Methods.PrintIndents(2) + "Ideal Start Date: " + Me.GetIdealStartDate)
            Console.WriteLine(Methods.PrintIndents(2) + "Ideal End Date: " + Str(Me.GetIdealEndDate))
            Console.WriteLine(Methods.PrintIndents(2) + "Real Start Date: " + Str(Me.GetRealStartDate))
            Console.WriteLine(Methods.PrintIndents(2) + "Real End Date: " + Str(Me.GetRealEndDate))
        End Sub

        Public Sub DeleteProject()

        End Sub

    End Class

    Class Task
        Inherits Root

        Private ParentID As Integer
        Private Scheduled As Boolean
        Private Important As Boolean
        Private Complete As Boolean
        Private Personnel As String
        Private Cost As Decimal
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

        End Sub
        Public Sub SetScheduled(Scheduled As Boolean)

        End Sub
        Public Sub SetImportant(Important As Boolean)

        End Sub
        Public Sub SetComplete(Complete As Boolean)

        End Sub
        Public Sub SetPersonnel(Personnel As String)

        End Sub
        Public Sub SetCost(Cost As Decimal)

        End Sub
#End Region
#End Region

#Region "Properties"
        Public Sub AddProperty()
            Dim NewProperty As TaskProperty
            NewProperty.Name = Methods.GetInput("Name")
            NewProperty.Value = Methods.GetInput("Value")
            Properties.Add(CurrentPropertyID, NewProperty)
            CurrentPropertyID += 1
        End Sub

        Public Sub EditProperty(ID As Integer, ValueToEdit As String, NewValue As String)
            Dim PropertyToEdit As TaskProperty
            PropertyToEdit = Properties(ID)
            Select Case ValueToEdit
                Case "Name"
                    PropertyToEdit.Name = NewValue
                Case "Value"
                    PropertyToEdit.Value = NewValue
            End Select
            Properties(ID) = PropertyToEdit
        End Sub

        Public Sub DeleteProperty(ID As Integer)
            Properties.Remove(ID)
        End Sub

        Public Sub ListProperties()
            Dim PropertyToList As TaskProperty
            Dim Counter = 1
            For Each TaskProperty In Properties
                PropertyToList = TaskProperty.Value
                Console.WriteLine(Methods.PrintIndents(2) + "===PROPERTY " + Str(Counter) + "===")
                Console.WriteLine(Methods.PrintIndents(3) + "Name: " + PropertyToList.Name)
                Console.WriteLine(Methods.PrintIndents(4) + "Description: " + PropertyToList.Value)
                Counter += 1
            Next
        End Sub
#End Region

        Public Sub ViewTask()
            Console.WriteLine(Methods.PrintIndents(2) + "ID: " + Str(Me.GetID))
            Console.WriteLine(Methods.PrintIndents(2) + "Parent ID: " + Str(Me.GetParentID))
            Console.WriteLine(Methods.PrintIndents(2) + "Name: " + Me.GetName)
            Console.WriteLine(Methods.PrintIndents(2) + "Description: " + Me.GetDescription)
            Console.WriteLine(Methods.PrintIndents(2) + "Ideal Start Date: " + Me.GetIdealStartDate)
            Console.WriteLine(Methods.PrintIndents(2) + "Ideal End Date: " + Str(Me.GetIdealEndDate))
            Console.WriteLine(Methods.PrintIndents(2) + "Real Start Date: " + Str(Me.GetRealStartDate))
            Console.WriteLine(Methods.PrintIndents(2) + "Real End Date: " + Str(Me.GetRealEndDate))
            Console.WriteLine(Methods.PrintIndents(2) + "Scheduled: " + Str(Me.GetScheduled))
            Console.WriteLine(Methods.PrintIndents(2) + "Important: " + Str(Me.GetImportant))
            Console.WriteLine(Methods.PrintIndents(2) + "Complete: " + Str(Me.GetComplete))
            Console.WriteLine(Methods.PrintIndents(2) + "Personnel: " + Str(Me.GetPersonnel))
            Console.WriteLine(Methods.PrintIndents(2) + "Cost: " + Str(Me.GetCost))
            ListProperties()
        End Sub

    End Class
End Module

Module Commands
    Class Command

        Private ID As Integer
        Private Table As String

        Public Sub New()

        End Sub

        Public Sub Execute()

        End Sub
    End Class

    Class CreateCommand
        Inherits Command

        Private Values As Dictionary(Of String, String)

        Public Sub New()

        End Sub
    End Class

    Class EditCommand
        Inherits Command

        Private Field As String
        Private NewValue As String

        Public Sub New()

        End Sub
    End Class

    Class DeleteCommand
        Inherits Command

        Public Sub New()

        End Sub
    End Class
End Module

Module Analysis

End Module

Module Database

End Module

Module Methods
    Public Function PrintIndents(ByRef Number As Integer)
        Dim IndentString = ""
        Dim Counter As Integer
        For Counter = 1 To Number
            IndentString += "    "
        Next
        Return IndentString
    End Function

    Public Function GetInput(ByRef Value As String)
        Dim Input As String
        Console.Write(Value + ": ")
        Input = Console.ReadLine()
        Return Input
    End Function

    Public Sub ShowMenu()
        Console.WriteLine("===PROJECT MANAGER===")
        Console.WriteLine(PrintIndents(1) + "1. Create new project                 A. List all tasks by ID")
        Console.WriteLine(PrintIndents(1) + "2. View current project               B. Create a root task")
        Console.WriteLine(PrintIndents(1) + "3. Save current project               C. Delete task by ID")
        Console.WriteLine(PrintIndents(1) + "4. Load current project               D. Create a child task")
        Console.WriteLine(PrintIndents(1) + "5. Edit project details               E. Attach property to task")
        Console.WriteLine(PrintIndents(1) + "X. EXIT                               F. Edit task by ID")
    End Sub

    Public Sub AskForChoice()
        Dim Choice = Console.ReadLine.ToUpper()
        Select Case Choice
            Case "1"
                Console.WriteLine("CREATING A NEW PROJECT")
            Case "2"
                Console.WriteLine("VIEWING CURRENT PROJECT")
            Case "3"
                Console.WriteLine("SAVING CURRENT PROJECT")
            Case "4"
                Console.WriteLine("LOADING A PROJECT")
            Case "5"
                Console.WriteLine("EDITING CURRENT PROJECT DETAILS")
            Case "A"
                Console.WriteLine("LISTING ALL TASKS BY ID")
            Case "B"
                Console.WriteLine("CREATING A NEW ROOT TASK")
            Case "C"
                Console.WriteLine("DELETING A TASK BY ID")
            Case "D"
                Console.WriteLine("CREATING A CHILD TASK")
            Case "E"
                Console.WriteLine("ATTACHING A PROPERTY TO A TASK")
            Case "F"
                Console.WriteLine("EDITING A TASK BY ID")
            Case Else
                Console.WriteLine("CLOSING PROGRAM")
                End
        End Select
    End Sub
End Module

Module Program
    Sub Main()
        While True
            Methods.ShowMenu()
            Methods.AskForChoice()
            Console.WriteLine()
        End While
    End Sub
End Module
