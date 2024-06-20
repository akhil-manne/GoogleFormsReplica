<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        btnViewSubmissions = New Button()
        btnCreateNewSubmission = New Button()
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.Location = New Point(50, 50)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(600, 50)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL+V)"
        btnViewSubmissions.UseVisualStyleBackColor = True
        ' 
        ' btnCreateNewSubmission
        ' 
        btnCreateNewSubmission.Location = New Point(50, 120)
        btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        btnCreateNewSubmission.Size = New Size(600, 50)
        btnCreateNewSubmission.TabIndex = 1
        btnCreateNewSubmission.Text = "CREATE NEW SUBMISSION (CTRL+N)"
        btnCreateNewSubmission.UseVisualStyleBackColor = True
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCreateNewSubmission)
        Controls.Add(btnViewSubmissions)
        KeyPreview = True
        Name = "MainForm"
        Text = "Akhil Manne, Slidely Task-2, Slidely Form App"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateNewSubmission As Button

End Class
