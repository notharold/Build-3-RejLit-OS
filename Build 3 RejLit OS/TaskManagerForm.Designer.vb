<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskManagerForm
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
        ListView1 = New ListView()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Task_Manager = New ColumnHeader()
        CPU_Usage = New ColumnHeader()
        Memory_Usage = New ColumnHeader()
        btnEndTask = New Button()
        ListView2 = New ListView()
        SuspendLayout()
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {Task_Manager, CPU_Usage, Memory_Usage})
        ListView1.Location = New Point(12, 12)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(185, 426)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' btnEndTask
        ' 
        btnEndTask.Location = New Point(203, 372)
        btnEndTask.Name = "btnEndTask"
        btnEndTask.Size = New Size(157, 66)
        btnEndTask.TabIndex = 1
        btnEndTask.Text = "End Task"
        btnEndTask.UseVisualStyleBackColor = True
        ' 
        ' ListView2
        ' 
        ListView2.Location = New Point(473, 17)
        ListView2.Name = "ListView2"
        ListView2.Size = New Size(184, 421)
        ListView2.TabIndex = 2
        ListView2.UseCompatibleStateImageBehavior = False
        ListView2.View = View.Details
        ' 
        ' TaskManagerForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(669, 450)
        Controls.Add(ListView2)
        Controls.Add(btnEndTask)
        Controls.Add(ListView1)
        Name = "TaskManagerForm"
        Text = "TaskManagerForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Task_Manager As ColumnHeader
    Friend WithEvents CPU_Usage As ColumnHeader
    Friend WithEvents Memory_Usage As ColumnHeader
    Friend WithEvents btnEndTask As Button
    Friend WithEvents ListView2 As ListView
End Class
