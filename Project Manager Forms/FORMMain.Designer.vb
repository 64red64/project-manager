<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORMMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BTNViewProject = New System.Windows.Forms.Button()
        Me.BTNSaveProject = New System.Windows.Forms.Button()
        Me.BTNLoadProject = New System.Windows.Forms.Button()
        Me.BTNViewTasks = New System.Windows.Forms.Button()
        Me.LBLProject = New System.Windows.Forms.Label()
        Me.LBLAnalysis = New System.Windows.Forms.Label()
        Me.BTNAnalysis = New System.Windows.Forms.Button()
        Me.BTNSchedule = New System.Windows.Forms.Button()
        Me.BTNEdit = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTNViewProject
        '
        Me.BTNViewProject.Location = New System.Drawing.Point(129, 22)
        Me.BTNViewProject.Name = "BTNViewProject"
        Me.BTNViewProject.Size = New System.Drawing.Size(111, 23)
        Me.BTNViewProject.TabIndex = 1
        Me.BTNViewProject.Text = "Edit Project Details"
        Me.BTNViewProject.UseVisualStyleBackColor = True
        '
        'BTNSaveProject
        '
        Me.BTNSaveProject.Location = New System.Drawing.Point(12, 51)
        Me.BTNSaveProject.Name = "BTNSaveProject"
        Me.BTNSaveProject.Size = New System.Drawing.Size(111, 23)
        Me.BTNSaveProject.TabIndex = 2
        Me.BTNSaveProject.Text = "Save Project"
        Me.BTNSaveProject.UseVisualStyleBackColor = True
        '
        'BTNLoadProject
        '
        Me.BTNLoadProject.Location = New System.Drawing.Point(12, 23)
        Me.BTNLoadProject.Name = "BTNLoadProject"
        Me.BTNLoadProject.Size = New System.Drawing.Size(111, 23)
        Me.BTNLoadProject.TabIndex = 3
        Me.BTNLoadProject.Text = "Load Project"
        Me.BTNLoadProject.UseVisualStyleBackColor = True
        '
        'BTNViewTasks
        '
        Me.BTNViewTasks.Location = New System.Drawing.Point(129, 51)
        Me.BTNViewTasks.Name = "BTNViewTasks"
        Me.BTNViewTasks.Size = New System.Drawing.Size(110, 23)
        Me.BTNViewTasks.TabIndex = 5
        Me.BTNViewTasks.Text = "View Tasks"
        Me.BTNViewTasks.UseVisualStyleBackColor = True
        '
        'LBLProject
        '
        Me.LBLProject.AutoSize = True
        Me.LBLProject.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLProject.Location = New System.Drawing.Point(12, 7)
        Me.LBLProject.Name = "LBLProject"
        Me.LBLProject.Size = New System.Drawing.Size(27, 13)
        Me.LBLProject.TabIndex = 6
        Me.LBLProject.Text = "File"
        '
        'LBLAnalysis
        '
        Me.LBLAnalysis.AutoSize = True
        Me.LBLAnalysis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLAnalysis.Location = New System.Drawing.Point(243, 8)
        Me.LBLAnalysis.Name = "LBLAnalysis"
        Me.LBLAnalysis.Size = New System.Drawing.Size(53, 13)
        Me.LBLAnalysis.TabIndex = 9
        Me.LBLAnalysis.Text = "Analysis"
        '
        'BTNAnalysis
        '
        Me.BTNAnalysis.Location = New System.Drawing.Point(246, 22)
        Me.BTNAnalysis.Name = "BTNAnalysis"
        Me.BTNAnalysis.Size = New System.Drawing.Size(110, 23)
        Me.BTNAnalysis.TabIndex = 10
        Me.BTNAnalysis.Text = "Analysis"
        Me.BTNAnalysis.UseVisualStyleBackColor = True
        '
        'BTNSchedule
        '
        Me.BTNSchedule.Location = New System.Drawing.Point(246, 51)
        Me.BTNSchedule.Name = "BTNSchedule"
        Me.BTNSchedule.Size = New System.Drawing.Size(110, 23)
        Me.BTNSchedule.TabIndex = 11
        Me.BTNSchedule.Text = "Schedule"
        Me.BTNSchedule.UseVisualStyleBackColor = True
        '
        'BTNEdit
        '
        Me.BTNEdit.AutoSize = True
        Me.BTNEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEdit.Location = New System.Drawing.Point(127, 7)
        Me.BTNEdit.Name = "BTNEdit"
        Me.BTNEdit.Size = New System.Drawing.Size(29, 13)
        Me.BTNEdit.TabIndex = 15
        Me.BTNEdit.Text = "Edit"
        '
        'FORMMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 83)
        Me.Controls.Add(Me.BTNEdit)
        Me.Controls.Add(Me.BTNSchedule)
        Me.Controls.Add(Me.BTNAnalysis)
        Me.Controls.Add(Me.LBLAnalysis)
        Me.Controls.Add(Me.LBLProject)
        Me.Controls.Add(Me.BTNViewTasks)
        Me.Controls.Add(Me.BTNLoadProject)
        Me.Controls.Add(Me.BTNSaveProject)
        Me.Controls.Add(Me.BTNViewProject)
        Me.Name = "FORMMain"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNViewProject As Button
    Friend WithEvents BTNSaveProject As Button
    Friend WithEvents BTNLoadProject As Button
    Friend WithEvents BTNViewTasks As Button
    Friend WithEvents LBLProject As Label
    Friend WithEvents LBLAnalysis As Label
    Friend WithEvents BTNAnalysis As Button
    Friend WithEvents BTNSchedule As Button
    Friend WithEvents BTNEdit As Label
End Class
