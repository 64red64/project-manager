<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORMLoadProject
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
        Me.LISTProjectList = New System.Windows.Forms.TreeView()
        Me.BTNLoadProject = New System.Windows.Forms.Button()
        Me.BTNExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LISTProjectList
        '
        Me.LISTProjectList.Location = New System.Drawing.Point(12, 12)
        Me.LISTProjectList.Name = "LISTProjectList"
        Me.LISTProjectList.Size = New System.Drawing.Size(201, 198)
        Me.LISTProjectList.TabIndex = 0
        '
        'BTNLoadProject
        '
        Me.BTNLoadProject.Location = New System.Drawing.Point(220, 13)
        Me.BTNLoadProject.Name = "BTNLoadProject"
        Me.BTNLoadProject.Size = New System.Drawing.Size(75, 55)
        Me.BTNLoadProject.TabIndex = 1
        Me.BTNLoadProject.Text = "Load Selected Project"
        Me.BTNLoadProject.UseVisualStyleBackColor = True
        '
        'BTNExit
        '
        Me.BTNExit.Location = New System.Drawing.Point(220, 75)
        Me.BTNExit.Name = "BTNExit"
        Me.BTNExit.Size = New System.Drawing.Size(75, 23)
        Me.BTNExit.TabIndex = 2
        Me.BTNExit.Text = "Exit"
        Me.BTNExit.UseVisualStyleBackColor = True
        '
        'FORMLoadProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 223)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTNExit)
        Me.Controls.Add(Me.BTNLoadProject)
        Me.Controls.Add(Me.LISTProjectList)
        Me.Name = "FORMLoadProject"
        Me.Text = "Load Project"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LISTProjectList As TreeView
    Friend WithEvents BTNLoadProject As Button
    Friend WithEvents BTNExit As Button
End Class
