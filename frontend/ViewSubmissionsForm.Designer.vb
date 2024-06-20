<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGitHubLink = New Label()
        lblStopwatchTime = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(112, 19)
        lblName.Name = "lblName"
        lblName.Size = New Size(83, 32)
        lblName.TabIndex = 0
        lblName.Text = "Name:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(112, 92)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(76, 32)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email:"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(112, 167)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(87, 32)
        lblPhone.TabIndex = 2
        lblPhone.Text = "Phone:"
        ' 
        ' lblGitHubLink
        ' 
        lblGitHubLink.AutoSize = True
        lblGitHubLink.Location = New Point(112, 236)
        lblGitHubLink.Name = "lblGitHubLink"
        lblGitHubLink.Size = New Size(94, 32)
        lblGitHubLink.TabIndex = 3
        lblGitHubLink.Text = "GitHub:"
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.Location = New Point(112, 310)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(189, 32)
        lblStopwatchTime.TabIndex = 4
        lblStopwatchTime.Text = "Stopwatch Time:"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(33, 420)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(250, 50)
        btnPrevious.TabIndex = 5
        btnPrevious.Text = "PREVIOUS (CTRL+P)"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(461, 420)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(250, 50)
        btnNext.TabIndex = 6
        btnNext.Text = "NEXT (CTRL+N)"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(261, 33)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(487, 39)
        txtName.TabIndex = 7
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(261, 104)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(487, 39)
        txtEmail.TabIndex = 8
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(261, 180)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(487, 39)
        txtPhone.TabIndex = 9
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.Location = New Point(261, 242)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.ReadOnly = True
        txtGitHubLink.Size = New Size(487, 39)
        txtGitHubLink.TabIndex = 10
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Location = New Point(334, 320)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(414, 39)
        txtStopwatchTime.TabIndex = 11
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 551)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGitHubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(lblStopwatchTime)
        Controls.Add(lblGitHubLink)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        KeyPreview = True
        Name = "ViewSubmissionsForm"
        Text = "Akhil Manne, Slidely Task-2, ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGitHubLink As Label
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
End Class
