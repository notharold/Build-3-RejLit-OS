<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        TextBox1d = New TextBox()
        TextBox2d = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1d
        ' 
        TextBox1d.Location = New Point(12, 26)
        TextBox1d.Name = "TextBox1d"
        TextBox1d.Size = New Size(240, 23)
        TextBox1d.TabIndex = 0
        ' 
        ' TextBox2d
        ' 
        TextBox2d.Location = New Point(12, 88)
        TextBox2d.Name = "TextBox2d"
        TextBox2d.Size = New Size(240, 23)
        TextBox2d.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 142)
        Button1.Name = "Button1"
        Button1.Size = New Size(240, 64)
        Button1.TabIndex = 2
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(274, 246)
        Controls.Add(Button1)
        Controls.Add(TextBox2d)
        Controls.Add(TextBox1d)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1d As TextBox
    Friend WithEvents TextBox2d As TextBox
    Friend WithEvents Button1 As Button
End Class
