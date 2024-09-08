<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Browser
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
        txtURL = New TextBox()
        btnGo = New Button()
        WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        btnHome = New Button()
        btnBack = New Button()
        btnForward = New Button()
        CType(WebView21, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtURL
        ' 
        txtURL.Location = New Point(12, 0)
        txtURL.Name = "txtURL"
        txtURL.Size = New Size(710, 23)
        txtURL.TabIndex = 0
        ' 
        ' btnGo
        ' 
        btnGo.Location = New Point(728, 0)
        btnGo.Name = "btnGo"
        btnGo.Size = New Size(65, 23)
        btnGo.TabIndex = 1
        btnGo.Text = "Go "
        btnGo.UseVisualStyleBackColor = True
        ' 
        ' WebView21
        ' 
        WebView21.AllowExternalDrop = True
        WebView21.CreationProperties = Nothing
        WebView21.DefaultBackgroundColor = Color.White
        WebView21.Location = New Point(19, 58)
        WebView21.Name = "WebView21"
        WebView21.Size = New Size(769, 380)
        WebView21.TabIndex = 2
        WebView21.ZoomFactor = 1.0R
        ' 
        ' btnHome
        ' 
        btnHome.Location = New Point(19, 29)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(71, 23)
        btnHome.TabIndex = 3
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(96, 29)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(78, 23)
        btnBack.TabIndex = 4
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnForward
        ' 
        btnForward.Location = New Point(180, 29)
        btnForward.Name = "btnForward"
        btnForward.Size = New Size(75, 23)
        btnForward.TabIndex = 5
        btnForward.Text = "Forward"
        btnForward.UseVisualStyleBackColor = True
        ' 
        ' Browser
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnForward)
        Controls.Add(btnBack)
        Controls.Add(btnHome)
        Controls.Add(WebView21)
        Controls.Add(btnGo)
        Controls.Add(txtURL)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Name = "Browser"
        Text = "RejLit Browser BETA Candidate 1"
        CType(WebView21, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtURL As TextBox
    Friend WithEvents btnGo As Button
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents btnHome As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnForward As Button
End Class
