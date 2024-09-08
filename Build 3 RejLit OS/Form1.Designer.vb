<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        ProgressBar1 = New ProgressBar()
        lblClock = New Label()
        Timer1 = New Timer(components)
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(ProgressBar1)
        Panel1.Controls.Add(lblClock)
        Panel1.Location = New Point(1, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1289, 29)
        Panel1.TabIndex = 0
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(986, 3)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(233, 22)
        ProgressBar1.TabIndex = 2
        ' 
        ' lblClock
        ' 
        lblClock.AutoSize = True
        lblClock.BackColor = SystemColors.Control
        lblClock.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblClock.Location = New Point(1234, 8)
        lblClock.Name = "lblClock"
        lblClock.Size = New Size(43, 15)
        lblClock.TabIndex = 1
        lblClock.Text = "Label1"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 36)
        Button1.Name = "Button1"
        Button1.Size = New Size(107, 94)
        Button1.TabIndex = 1
        Button1.Text = "Apply your name"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(125, 36)
        Button2.Name = "Button2"
        Button2.Size = New Size(108, 94)
        Button2.TabIndex = 2
        Button2.Text = "+ Calculator"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(239, 36)
        Button3.Name = "Button3"
        Button3.Size = New Size(113, 94)
        Button3.TabIndex = 3
        Button3.Text = "RejLit Browser BETA Candidate 1"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(889, 3)
        Button4.Name = "Button4"
        Button4.Size = New Size(91, 22)
        Button4.TabIndex = 3
        Button4.Text = "Fill"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1290, 661)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblClock As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
