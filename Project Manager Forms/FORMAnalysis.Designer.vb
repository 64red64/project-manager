<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORMAnalysis
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
        Me.LBLNumberOfDays = New System.Windows.Forms.Label()
        Me.LBLPercentage = New System.Windows.Forms.Label()
        Me.BTNExit = New System.Windows.Forms.Button()
        Me.LBLDNumberOfDays = New System.Windows.Forms.Label()
        Me.LBLDPercentage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBLNumberOfDays
        '
        Me.LBLNumberOfDays.AutoSize = True
        Me.LBLNumberOfDays.Location = New System.Drawing.Point(8, 13)
        Me.LBLNumberOfDays.Name = "LBLNumberOfDays"
        Me.LBLNumberOfDays.Size = New System.Drawing.Size(85, 13)
        Me.LBLNumberOfDays.TabIndex = 0
        Me.LBLNumberOfDays.Text = "Number Of Days"
        '
        'LBLPercentage
        '
        Me.LBLPercentage.AutoSize = True
        Me.LBLPercentage.Location = New System.Drawing.Point(8, 38)
        Me.LBLPercentage.Name = "LBLPercentage"
        Me.LBLPercentage.Size = New System.Drawing.Size(109, 13)
        Me.LBLPercentage.TabIndex = 1
        Me.LBLPercentage.Text = "Percentage Complete"
        '
        'BTNExit
        '
        Me.BTNExit.Location = New System.Drawing.Point(299, 54)
        Me.BTNExit.Name = "BTNExit"
        Me.BTNExit.Size = New System.Drawing.Size(75, 23)
        Me.BTNExit.TabIndex = 3
        Me.BTNExit.Text = "Exit"
        Me.BTNExit.UseVisualStyleBackColor = True
        '
        'LBLDNumberOfDays
        '
        Me.LBLDNumberOfDays.AutoSize = True
        Me.LBLDNumberOfDays.Location = New System.Drawing.Point(128, 13)
        Me.LBLDNumberOfDays.Name = "LBLDNumberOfDays"
        Me.LBLDNumberOfDays.Size = New System.Drawing.Size(13, 13)
        Me.LBLDNumberOfDays.TabIndex = 4
        Me.LBLDNumberOfDays.Text = "0"
        '
        'LBLDPercentage
        '
        Me.LBLDPercentage.AutoSize = True
        Me.LBLDPercentage.Location = New System.Drawing.Point(128, 38)
        Me.LBLDPercentage.Name = "LBLDPercentage"
        Me.LBLDPercentage.Size = New System.Drawing.Size(13, 13)
        Me.LBLDPercentage.TabIndex = 5
        Me.LBLDPercentage.Text = "0"
        '
        'FORMAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 89)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBLDPercentage)
        Me.Controls.Add(Me.LBLDNumberOfDays)
        Me.Controls.Add(Me.BTNExit)
        Me.Controls.Add(Me.LBLPercentage)
        Me.Controls.Add(Me.LBLNumberOfDays)
        Me.Name = "FORMAnalysis"
        Me.Text = "Analysis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLNumberOfDays As Label
    Friend WithEvents LBLPercentage As Label
    Friend WithEvents BTNExit As Button
    Friend WithEvents LBLDNumberOfDays As Label
    Friend WithEvents LBLDPercentage As Label
End Class
