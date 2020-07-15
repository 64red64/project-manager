<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FORMTaskDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LISTTasks = New System.Windows.Forms.TreeView()
        Me.LBLTaskInformation = New System.Windows.Forms.Label()
        Me.LBLTaskName = New System.Windows.Forms.Label()
        Me.LBLTaskProperties = New System.Windows.Forms.Label()
        Me.TEXTBOXTaskName = New System.Windows.Forms.TextBox()
        Me.LBLTaskDescription = New System.Windows.Forms.Label()
        Me.TEXTBOXTaskDescription = New System.Windows.Forms.TextBox()
        Me.LBLTaskList = New System.Windows.Forms.Label()
        Me.LBLTaskISD = New System.Windows.Forms.Label()
        Me.LBLTaskIED = New System.Windows.Forms.Label()
        Me.LBLTaskRSD = New System.Windows.Forms.Label()
        Me.LBLTaskRED = New System.Windows.Forms.Label()
        Me.DATETaskISD = New System.Windows.Forms.DateTimePicker()
        Me.DATETaskIED = New System.Windows.Forms.DateTimePicker()
        Me.DATETaskRSD = New System.Windows.Forms.DateTimePicker()
        Me.DATETaskRED = New System.Windows.Forms.DateTimePicker()
        Me.CHECKTaskComplete = New System.Windows.Forms.CheckBox()
        Me.CHECKTaskCritical = New System.Windows.Forms.CheckBox()
        Me.CHECKTaskScheduled = New System.Windows.Forms.CheckBox()
        Me.LBLCost = New System.Windows.Forms.Label()
        Me.TEXTBOXTaskCost = New System.Windows.Forms.TextBox()
        Me.LBLPersonnel = New System.Windows.Forms.Label()
        Me.TEXTBOXTaskPersonnel = New System.Windows.Forms.TextBox()
        Me.BTNCreateTask = New System.Windows.Forms.Button()
        Me.BTNDeleteTask = New System.Windows.Forms.Button()
        Me.BTNCreateProperty = New System.Windows.Forms.Button()
        Me.BTNDeleteProperty = New System.Windows.Forms.Button()
        Me.TEXTBOXPropertyValue = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TEXTBOXPropertyName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTNExit = New System.Windows.Forms.Button()
        Me.BTNMakeChild = New System.Windows.Forms.Button()
        Me.BTNSaveTaskInfo = New System.Windows.Forms.Button()
        Me.LBLCurrency = New System.Windows.Forms.Label()
        Me.BTNPropertyEdit = New System.Windows.Forms.Button()
        Me.LISTProperties = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'LISTTasks
        '
        Me.LISTTasks.Location = New System.Drawing.Point(5, 36)
        Me.LISTTasks.Name = "LISTTasks"
        Me.LISTTasks.Size = New System.Drawing.Size(251, 395)
        Me.LISTTasks.TabIndex = 1
        '
        'LBLTaskInformation
        '
        Me.LBLTaskInformation.AutoSize = True
        Me.LBLTaskInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTaskInformation.Location = New System.Drawing.Point(275, 5)
        Me.LBLTaskInformation.Name = "LBLTaskInformation"
        Me.LBLTaskInformation.Size = New System.Drawing.Size(163, 24)
        Me.LBLTaskInformation.TabIndex = 3
        Me.LBLTaskInformation.Text = "Task Information"
        '
        'LBLTaskName
        '
        Me.LBLTaskName.AutoSize = True
        Me.LBLTaskName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTaskName.Location = New System.Drawing.Point(278, 36)
        Me.LBLTaskName.Name = "LBLTaskName"
        Me.LBLTaskName.Size = New System.Drawing.Size(39, 13)
        Me.LBLTaskName.TabIndex = 4
        Me.LBLTaskName.Text = "Name"
        '
        'LBLTaskProperties
        '
        Me.LBLTaskProperties.AutoSize = True
        Me.LBLTaskProperties.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTaskProperties.Location = New System.Drawing.Point(535, 5)
        Me.LBLTaskProperties.Name = "LBLTaskProperties"
        Me.LBLTaskProperties.Size = New System.Drawing.Size(155, 24)
        Me.LBLTaskProperties.TabIndex = 5
        Me.LBLTaskProperties.Text = "Task Properties"
        '
        'TEXTBOXTaskName
        '
        Me.TEXTBOXTaskName.Location = New System.Drawing.Point(281, 52)
        Me.TEXTBOXTaskName.Name = "TEXTBOXTaskName"
        Me.TEXTBOXTaskName.Size = New System.Drawing.Size(253, 20)
        Me.TEXTBOXTaskName.TabIndex = 6
        '
        'LBLTaskDescription
        '
        Me.LBLTaskDescription.AutoSize = True
        Me.LBLTaskDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTaskDescription.Location = New System.Drawing.Point(278, 85)
        Me.LBLTaskDescription.Name = "LBLTaskDescription"
        Me.LBLTaskDescription.Size = New System.Drawing.Size(71, 13)
        Me.LBLTaskDescription.TabIndex = 7
        Me.LBLTaskDescription.Text = "Description"
        '
        'TEXTBOXTaskDescription
        '
        Me.TEXTBOXTaskDescription.Location = New System.Drawing.Point(281, 101)
        Me.TEXTBOXTaskDescription.Multiline = True
        Me.TEXTBOXTaskDescription.Name = "TEXTBOXTaskDescription"
        Me.TEXTBOXTaskDescription.Size = New System.Drawing.Size(253, 101)
        Me.TEXTBOXTaskDescription.TabIndex = 8
        '
        'LBLTaskList
        '
        Me.LBLTaskList.AutoSize = True
        Me.LBLTaskList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTaskList.Location = New System.Drawing.Point(-1, 5)
        Me.LBLTaskList.Name = "LBLTaskList"
        Me.LBLTaskList.Size = New System.Drawing.Size(91, 24)
        Me.LBLTaskList.TabIndex = 9
        Me.LBLTaskList.Text = "Task List"
        '
        'LBLTaskISD
        '
        Me.LBLTaskISD.AutoSize = True
        Me.LBLTaskISD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTaskISD.Location = New System.Drawing.Point(278, 212)
        Me.LBLTaskISD.Name = "LBLTaskISD"
        Me.LBLTaskISD.Size = New System.Drawing.Size(97, 13)
        Me.LBLTaskISD.TabIndex = 11
        Me.LBLTaskISD.Text = "Ideal Start Date"
        '
        'LBLTaskIED
        '
        Me.LBLTaskIED.AutoSize = True
        Me.LBLTaskIED.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTaskIED.Location = New System.Drawing.Point(278, 238)
        Me.LBLTaskIED.Name = "LBLTaskIED"
        Me.LBLTaskIED.Size = New System.Drawing.Size(92, 13)
        Me.LBLTaskIED.TabIndex = 12
        Me.LBLTaskIED.Text = "Ideal End Date"
        '
        'LBLTaskRSD
        '
        Me.LBLTaskRSD.AutoSize = True
        Me.LBLTaskRSD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTaskRSD.Location = New System.Drawing.Point(278, 271)
        Me.LBLTaskRSD.Name = "LBLTaskRSD"
        Me.LBLTaskRSD.Size = New System.Drawing.Size(95, 13)
        Me.LBLTaskRSD.TabIndex = 13
        Me.LBLTaskRSD.Text = "Real Start Date"
        '
        'LBLTaskRED
        '
        Me.LBLTaskRED.AutoSize = True
        Me.LBLTaskRED.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTaskRED.Location = New System.Drawing.Point(278, 297)
        Me.LBLTaskRED.Name = "LBLTaskRED"
        Me.LBLTaskRED.Size = New System.Drawing.Size(90, 13)
        Me.LBLTaskRED.TabIndex = 14
        Me.LBLTaskRED.Text = "Real End Date"
        '
        'DATETaskISD
        '
        Me.DATETaskISD.Location = New System.Drawing.Point(385, 209)
        Me.DATETaskISD.Name = "DATETaskISD"
        Me.DATETaskISD.Size = New System.Drawing.Size(149, 20)
        Me.DATETaskISD.TabIndex = 15
        '
        'DATETaskIED
        '
        Me.DATETaskIED.Location = New System.Drawing.Point(385, 235)
        Me.DATETaskIED.Name = "DATETaskIED"
        Me.DATETaskIED.Size = New System.Drawing.Size(149, 20)
        Me.DATETaskIED.TabIndex = 16
        '
        'DATETaskRSD
        '
        Me.DATETaskRSD.Location = New System.Drawing.Point(385, 268)
        Me.DATETaskRSD.Name = "DATETaskRSD"
        Me.DATETaskRSD.Size = New System.Drawing.Size(149, 20)
        Me.DATETaskRSD.TabIndex = 17
        '
        'DATETaskRED
        '
        Me.DATETaskRED.Location = New System.Drawing.Point(385, 294)
        Me.DATETaskRED.Name = "DATETaskRED"
        Me.DATETaskRED.Size = New System.Drawing.Size(149, 20)
        Me.DATETaskRED.TabIndex = 18
        '
        'CHECKTaskComplete
        '
        Me.CHECKTaskComplete.AutoSize = True
        Me.CHECKTaskComplete.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CHECKTaskComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHECKTaskComplete.Location = New System.Drawing.Point(290, 327)
        Me.CHECKTaskComplete.Name = "CHECKTaskComplete"
        Me.CHECKTaskComplete.Size = New System.Drawing.Size(70, 17)
        Me.CHECKTaskComplete.TabIndex = 21
        Me.CHECKTaskComplete.Text = "Complete"
        Me.CHECKTaskComplete.UseVisualStyleBackColor = True
        '
        'CHECKTaskCritical
        '
        Me.CHECKTaskCritical.AutoSize = True
        Me.CHECKTaskCritical.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CHECKTaskCritical.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHECKTaskCritical.Location = New System.Drawing.Point(303, 350)
        Me.CHECKTaskCritical.Name = "CHECKTaskCritical"
        Me.CHECKTaskCritical.Size = New System.Drawing.Size(57, 17)
        Me.CHECKTaskCritical.TabIndex = 22
        Me.CHECKTaskCritical.Text = "Critical"
        Me.CHECKTaskCritical.UseVisualStyleBackColor = True
        '
        'CHECKTaskScheduled
        '
        Me.CHECKTaskScheduled.AutoSize = True
        Me.CHECKTaskScheduled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CHECKTaskScheduled.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHECKTaskScheduled.Location = New System.Drawing.Point(381, 327)
        Me.CHECKTaskScheduled.Name = "CHECKTaskScheduled"
        Me.CHECKTaskScheduled.Size = New System.Drawing.Size(77, 17)
        Me.CHECKTaskScheduled.TabIndex = 23
        Me.CHECKTaskScheduled.Text = "Scheduled"
        Me.CHECKTaskScheduled.UseVisualStyleBackColor = True
        '
        'LBLCost
        '
        Me.LBLCost.AutoSize = True
        Me.LBLCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCost.Location = New System.Drawing.Point(384, 352)
        Me.LBLCost.Name = "LBLCost"
        Me.LBLCost.Size = New System.Drawing.Size(28, 13)
        Me.LBLCost.TabIndex = 25
        Me.LBLCost.Text = "Cost"
        '
        'TEXTBOXTaskCost
        '
        Me.TEXTBOXTaskCost.Location = New System.Drawing.Point(443, 349)
        Me.TEXTBOXTaskCost.Name = "TEXTBOXTaskCost"
        Me.TEXTBOXTaskCost.Size = New System.Drawing.Size(89, 20)
        Me.TEXTBOXTaskCost.TabIndex = 26
        '
        'LBLPersonnel
        '
        Me.LBLPersonnel.AutoSize = True
        Me.LBLPersonnel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPersonnel.Location = New System.Drawing.Point(278, 370)
        Me.LBLPersonnel.Name = "LBLPersonnel"
        Me.LBLPersonnel.Size = New System.Drawing.Size(63, 13)
        Me.LBLPersonnel.TabIndex = 27
        Me.LBLPersonnel.Text = "Personnel"
        '
        'TEXTBOXTaskPersonnel
        '
        Me.TEXTBOXTaskPersonnel.Location = New System.Drawing.Point(281, 387)
        Me.TEXTBOXTaskPersonnel.Multiline = True
        Me.TEXTBOXTaskPersonnel.Name = "TEXTBOXTaskPersonnel"
        Me.TEXTBOXTaskPersonnel.Size = New System.Drawing.Size(251, 44)
        Me.TEXTBOXTaskPersonnel.TabIndex = 28
        '
        'BTNCreateTask
        '
        Me.BTNCreateTask.Location = New System.Drawing.Point(5, 439)
        Me.BTNCreateTask.Name = "BTNCreateTask"
        Me.BTNCreateTask.Size = New System.Drawing.Size(73, 23)
        Me.BTNCreateTask.TabIndex = 29
        Me.BTNCreateTask.Text = "Create Task"
        Me.BTNCreateTask.UseVisualStyleBackColor = True
        '
        'BTNDeleteTask
        '
        Me.BTNDeleteTask.Location = New System.Drawing.Point(84, 439)
        Me.BTNDeleteTask.Name = "BTNDeleteTask"
        Me.BTNDeleteTask.Size = New System.Drawing.Size(80, 23)
        Me.BTNDeleteTask.TabIndex = 30
        Me.BTNDeleteTask.Text = "Delete Task"
        Me.BTNDeleteTask.UseVisualStyleBackColor = True
        '
        'BTNCreateProperty
        '
        Me.BTNCreateProperty.Location = New System.Drawing.Point(540, 414)
        Me.BTNCreateProperty.Name = "BTNCreateProperty"
        Me.BTNCreateProperty.Size = New System.Drawing.Size(59, 48)
        Me.BTNCreateProperty.TabIndex = 31
        Me.BTNCreateProperty.Text = "Create New"
        Me.BTNCreateProperty.UseVisualStyleBackColor = True
        '
        'BTNDeleteProperty
        '
        Me.BTNDeleteProperty.Location = New System.Drawing.Point(671, 414)
        Me.BTNDeleteProperty.Name = "BTNDeleteProperty"
        Me.BTNDeleteProperty.Size = New System.Drawing.Size(55, 48)
        Me.BTNDeleteProperty.TabIndex = 32
        Me.BTNDeleteProperty.Text = "Delete"
        Me.BTNDeleteProperty.UseVisualStyleBackColor = True
        '
        'TEXTBOXPropertyValue
        '
        Me.TEXTBOXPropertyValue.Location = New System.Drawing.Point(541, 332)
        Me.TEXTBOXPropertyValue.Multiline = True
        Me.TEXTBOXPropertyValue.Name = "TEXTBOXPropertyValue"
        Me.TEXTBOXPropertyValue.Size = New System.Drawing.Size(186, 76)
        Me.TEXTBOXPropertyValue.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(540, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Value"
        '
        'TEXTBOXPropertyName
        '
        Me.TEXTBOXPropertyName.Location = New System.Drawing.Point(541, 288)
        Me.TEXTBOXPropertyName.Name = "TEXTBOXPropertyName"
        Me.TEXTBOXPropertyName.Size = New System.Drawing.Size(186, 20)
        Me.TEXTBOXPropertyName.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(540, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Name"
        '
        'BTNExit
        '
        Me.BTNExit.Location = New System.Drawing.Point(181, 5)
        Me.BTNExit.Name = "BTNExit"
        Me.BTNExit.Size = New System.Drawing.Size(75, 23)
        Me.BTNExit.TabIndex = 38
        Me.BTNExit.Text = "Exit"
        Me.BTNExit.UseVisualStyleBackColor = True
        '
        'BTNMakeChild
        '
        Me.BTNMakeChild.Location = New System.Drawing.Point(170, 439)
        Me.BTNMakeChild.Name = "BTNMakeChild"
        Me.BTNMakeChild.Size = New System.Drawing.Size(86, 23)
        Me.BTNMakeChild.TabIndex = 39
        Me.BTNMakeChild.Text = "Make Subtask"
        Me.BTNMakeChild.UseVisualStyleBackColor = True
        '
        'BTNSaveTaskInfo
        '
        Me.BTNSaveTaskInfo.Location = New System.Drawing.Point(281, 438)
        Me.BTNSaveTaskInfo.Name = "BTNSaveTaskInfo"
        Me.BTNSaveTaskInfo.Size = New System.Drawing.Size(251, 23)
        Me.BTNSaveTaskInfo.TabIndex = 40
        Me.BTNSaveTaskInfo.Text = "Save Task Information"
        Me.BTNSaveTaskInfo.UseVisualStyleBackColor = True
        '
        'LBLCurrency
        '
        Me.LBLCurrency.AutoSize = True
        Me.LBLCurrency.Location = New System.Drawing.Point(425, 352)
        Me.LBLCurrency.Name = "LBLCurrency"
        Me.LBLCurrency.Size = New System.Drawing.Size(13, 13)
        Me.LBLCurrency.TabIndex = 41
        Me.LBLCurrency.Text = "£"
        '
        'BTNPropertyEdit
        '
        Me.BTNPropertyEdit.Location = New System.Drawing.Point(605, 414)
        Me.BTNPropertyEdit.Name = "BTNPropertyEdit"
        Me.BTNPropertyEdit.Size = New System.Drawing.Size(60, 48)
        Me.BTNPropertyEdit.TabIndex = 42
        Me.BTNPropertyEdit.Text = "Save Edit"
        Me.BTNPropertyEdit.UseVisualStyleBackColor = True
        '
        'LISTProperties
        '
        Me.LISTProperties.Location = New System.Drawing.Point(541, 36)
        Me.LISTProperties.Name = "LISTProperties"
        Me.LISTProperties.Size = New System.Drawing.Size(181, 231)
        Me.LISTProperties.TabIndex = 43
        '
        'FORMTaskDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 470)
        Me.ControlBox = False
        Me.Controls.Add(Me.LISTProperties)
        Me.Controls.Add(Me.BTNPropertyEdit)
        Me.Controls.Add(Me.LBLCurrency)
        Me.Controls.Add(Me.BTNSaveTaskInfo)
        Me.Controls.Add(Me.BTNMakeChild)
        Me.Controls.Add(Me.BTNExit)
        Me.Controls.Add(Me.TEXTBOXPropertyValue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TEXTBOXPropertyName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BTNDeleteProperty)
        Me.Controls.Add(Me.BTNCreateProperty)
        Me.Controls.Add(Me.BTNDeleteTask)
        Me.Controls.Add(Me.BTNCreateTask)
        Me.Controls.Add(Me.TEXTBOXTaskPersonnel)
        Me.Controls.Add(Me.LBLPersonnel)
        Me.Controls.Add(Me.TEXTBOXTaskCost)
        Me.Controls.Add(Me.LBLCost)
        Me.Controls.Add(Me.CHECKTaskScheduled)
        Me.Controls.Add(Me.CHECKTaskCritical)
        Me.Controls.Add(Me.CHECKTaskComplete)
        Me.Controls.Add(Me.DATETaskRED)
        Me.Controls.Add(Me.DATETaskRSD)
        Me.Controls.Add(Me.DATETaskIED)
        Me.Controls.Add(Me.DATETaskISD)
        Me.Controls.Add(Me.LBLTaskRED)
        Me.Controls.Add(Me.LBLTaskRSD)
        Me.Controls.Add(Me.LBLTaskIED)
        Me.Controls.Add(Me.LBLTaskISD)
        Me.Controls.Add(Me.LBLTaskList)
        Me.Controls.Add(Me.TEXTBOXTaskDescription)
        Me.Controls.Add(Me.LBLTaskDescription)
        Me.Controls.Add(Me.TEXTBOXTaskName)
        Me.Controls.Add(Me.LBLTaskProperties)
        Me.Controls.Add(Me.LBLTaskName)
        Me.Controls.Add(Me.LBLTaskInformation)
        Me.Controls.Add(Me.LISTTasks)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FORMTaskDetails"
        Me.Text = "Task Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LISTTasks As TreeView
    Friend WithEvents LBLTaskInformation As Label
    Friend WithEvents LBLTaskName As Label
    Friend WithEvents LBLTaskProperties As Label
    Friend WithEvents TEXTBOXTaskName As TextBox
    Friend WithEvents LBLTaskDescription As Label
    Friend WithEvents TEXTBOXTaskDescription As TextBox
    Friend WithEvents LBLTaskList As Label
    Friend WithEvents LBLTaskISD As Label
    Friend WithEvents LBLTaskIED As Label
    Friend WithEvents LBLTaskRSD As Label
    Friend WithEvents LBLTaskRED As Label
    Friend WithEvents DATETaskISD As DateTimePicker
    Friend WithEvents DATETaskIED As DateTimePicker
    Friend WithEvents DATETaskRSD As DateTimePicker
    Friend WithEvents DATETaskRED As DateTimePicker
    Friend WithEvents CHECKTaskComplete As CheckBox
    Friend WithEvents CHECKTaskCritical As CheckBox
    Friend WithEvents CHECKTaskScheduled As CheckBox
    Friend WithEvents LBLCost As Label
    Friend WithEvents TEXTBOXTaskCost As TextBox
    Friend WithEvents LBLPersonnel As Label
    Friend WithEvents TEXTBOXTaskPersonnel As TextBox
    Friend WithEvents BTNCreateTask As Button
    Friend WithEvents BTNDeleteTask As Button
    Friend WithEvents BTNCreateProperty As Button
    Friend WithEvents BTNDeleteProperty As Button
    Friend WithEvents TEXTBOXPropertyValue As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TEXTBOXPropertyName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BTNExit As Button
    Friend WithEvents BTNMakeChild As Button
    Friend WithEvents BTNSaveTaskInfo As Button
    Friend WithEvents LBLCurrency As Label
    Friend WithEvents BTNPropertyEdit As Button
    Friend WithEvents LISTProperties As TreeView
End Class
