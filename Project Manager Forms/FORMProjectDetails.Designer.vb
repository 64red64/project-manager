<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORMProjectDetails
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
        Me.LBLProjectName = New System.Windows.Forms.Label()
        Me.LBLProjectDescription = New System.Windows.Forms.Label()
        Me.LBLProjectISD = New System.Windows.Forms.Label()
        Me.LBLProjectRSD = New System.Windows.Forms.Label()
        Me.LBLProjectIED = New System.Windows.Forms.Label()
        Me.LBLProjectRED = New System.Windows.Forms.Label()
        Me.TEXTBOXProjectName = New System.Windows.Forms.TextBox()
        Me.TEXTBOXProjectDescription = New System.Windows.Forms.TextBox()
        Me.DATETIMEProjectISD = New System.Windows.Forms.DateTimePicker()
        Me.DATETIMEProjectRSD = New System.Windows.Forms.DateTimePicker()
        Me.DATETIMEProjectRED = New System.Windows.Forms.DateTimePicker()
        Me.DATETIMEProjectIED = New System.Windows.Forms.DateTimePicker()
        Me.BTNExit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBLProjectName
        '
        Me.LBLProjectName.AutoSize = True
        Me.LBLProjectName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLProjectName.Location = New System.Drawing.Point(9, 12)
        Me.LBLProjectName.Name = "LBLProjectName"
        Me.LBLProjectName.Size = New System.Drawing.Size(83, 13)
        Me.LBLProjectName.TabIndex = 1
        Me.LBLProjectName.Text = "Project Name"
        '
        'LBLProjectDescription
        '
        Me.LBLProjectDescription.AutoSize = True
        Me.LBLProjectDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLProjectDescription.Location = New System.Drawing.Point(9, 40)
        Me.LBLProjectDescription.Name = "LBLProjectDescription"
        Me.LBLProjectDescription.Size = New System.Drawing.Size(115, 13)
        Me.LBLProjectDescription.TabIndex = 2
        Me.LBLProjectDescription.Text = "Project Description"
        '
        'LBLProjectISD
        '
        Me.LBLProjectISD.AutoSize = True
        Me.LBLProjectISD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLProjectISD.Location = New System.Drawing.Point(9, 177)
        Me.LBLProjectISD.Name = "LBLProjectISD"
        Me.LBLProjectISD.Size = New System.Drawing.Size(97, 13)
        Me.LBLProjectISD.TabIndex = 3
        Me.LBLProjectISD.Text = "Ideal Start Date"
        '
        'LBLProjectRSD
        '
        Me.LBLProjectRSD.AutoSize = True
        Me.LBLProjectRSD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLProjectRSD.Location = New System.Drawing.Point(9, 204)
        Me.LBLProjectRSD.Name = "LBLProjectRSD"
        Me.LBLProjectRSD.Size = New System.Drawing.Size(95, 13)
        Me.LBLProjectRSD.TabIndex = 4
        Me.LBLProjectRSD.Text = "Real Start Date"
        '
        'LBLProjectIED
        '
        Me.LBLProjectIED.AutoSize = True
        Me.LBLProjectIED.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLProjectIED.Location = New System.Drawing.Point(9, 245)
        Me.LBLProjectIED.Name = "LBLProjectIED"
        Me.LBLProjectIED.Size = New System.Drawing.Size(92, 13)
        Me.LBLProjectIED.TabIndex = 5
        Me.LBLProjectIED.Text = "Ideal End Date"
        '
        'LBLProjectRED
        '
        Me.LBLProjectRED.AutoSize = True
        Me.LBLProjectRED.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLProjectRED.Location = New System.Drawing.Point(9, 270)
        Me.LBLProjectRED.Name = "LBLProjectRED"
        Me.LBLProjectRED.Size = New System.Drawing.Size(90, 13)
        Me.LBLProjectRED.TabIndex = 6
        Me.LBLProjectRED.Text = "Real End Date"
        '
        'TEXTBOXProjectName
        '
        Me.TEXTBOXProjectName.Location = New System.Drawing.Point(132, 9)
        Me.TEXTBOXProjectName.Name = "TEXTBOXProjectName"
        Me.TEXTBOXProjectName.Size = New System.Drawing.Size(183, 20)
        Me.TEXTBOXProjectName.TabIndex = 8
        '
        'TEXTBOXProjectDescription
        '
        Me.TEXTBOXProjectDescription.Location = New System.Drawing.Point(132, 40)
        Me.TEXTBOXProjectDescription.Multiline = True
        Me.TEXTBOXProjectDescription.Name = "TEXTBOXProjectDescription"
        Me.TEXTBOXProjectDescription.Size = New System.Drawing.Size(183, 115)
        Me.TEXTBOXProjectDescription.TabIndex = 9
        '
        'DATETIMEProjectISD
        '
        Me.DATETIMEProjectISD.Location = New System.Drawing.Point(132, 174)
        Me.DATETIMEProjectISD.Name = "DATETIMEProjectISD"
        Me.DATETIMEProjectISD.Size = New System.Drawing.Size(183, 20)
        Me.DATETIMEProjectISD.TabIndex = 10
        '
        'DATETIMEProjectRSD
        '
        Me.DATETIMEProjectRSD.Location = New System.Drawing.Point(133, 200)
        Me.DATETIMEProjectRSD.Name = "DATETIMEProjectRSD"
        Me.DATETIMEProjectRSD.Size = New System.Drawing.Size(182, 20)
        Me.DATETIMEProjectRSD.TabIndex = 11
        '
        'DATETIMEProjectRED
        '
        Me.DATETIMEProjectRED.Location = New System.Drawing.Point(134, 268)
        Me.DATETIMEProjectRED.Name = "DATETIMEProjectRED"
        Me.DATETIMEProjectRED.Size = New System.Drawing.Size(182, 20)
        Me.DATETIMEProjectRED.TabIndex = 13
        '
        'DATETIMEProjectIED
        '
        Me.DATETIMEProjectIED.Location = New System.Drawing.Point(133, 242)
        Me.DATETIMEProjectIED.Name = "DATETIMEProjectIED"
        Me.DATETIMEProjectIED.Size = New System.Drawing.Size(183, 20)
        Me.DATETIMEProjectIED.TabIndex = 12
        '
        'BTNExit
        '
        Me.BTNExit.Location = New System.Drawing.Point(239, 305)
        Me.BTNExit.Name = "BTNExit"
        Me.BTNExit.Size = New System.Drawing.Size(77, 23)
        Me.BTNExit.TabIndex = 14
        Me.BTNExit.Text = "Exit"
        Me.BTNExit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 305)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FORMProjectDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 338)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTNExit)
        Me.Controls.Add(Me.DATETIMEProjectRED)
        Me.Controls.Add(Me.DATETIMEProjectIED)
        Me.Controls.Add(Me.DATETIMEProjectRSD)
        Me.Controls.Add(Me.DATETIMEProjectISD)
        Me.Controls.Add(Me.TEXTBOXProjectDescription)
        Me.Controls.Add(Me.TEXTBOXProjectName)
        Me.Controls.Add(Me.LBLProjectRED)
        Me.Controls.Add(Me.LBLProjectIED)
        Me.Controls.Add(Me.LBLProjectRSD)
        Me.Controls.Add(Me.LBLProjectISD)
        Me.Controls.Add(Me.LBLProjectDescription)
        Me.Controls.Add(Me.LBLProjectName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(341, 377)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(341, 377)
        Me.Name = "FORMProjectDetails"
        Me.Text = "Project Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLProjectName As Label
    Friend WithEvents LBLProjectDescription As Label
    Friend WithEvents LBLProjectISD As Label
    Friend WithEvents LBLProjectRSD As Label
    Friend WithEvents LBLProjectIED As Label
    Friend WithEvents LBLProjectRED As Label
    Friend WithEvents TEXTBOXProjectName As TextBox
    Friend WithEvents TEXTBOXProjectDescription As TextBox
    Friend WithEvents DATETIMEProjectISD As DateTimePicker
    Friend WithEvents DATETIMEProjectRSD As DateTimePicker
    Friend WithEvents DATETIMEProjectRED As DateTimePicker
    Friend WithEvents DATETIMEProjectIED As DateTimePicker
    Friend WithEvents BTNExit As Button
    Friend WithEvents Button1 As Button
End Class
