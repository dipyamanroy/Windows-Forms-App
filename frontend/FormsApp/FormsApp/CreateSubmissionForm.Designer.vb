<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        Label1 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btnToggleStopwatch = New Button()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNum = New TextBox()
        txtGithubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        btnSubmit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(630, 38)
        Label1.TabIndex = 3
        Label1.Text = "Dipyaman Roy, Slidely Task 2 - Create Submission"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(96, 365)
        Label5.Name = "Label5"
        Label5.Size = New Size(143, 64)
        Label5.TabIndex = 11
        Label5.Text = "Github Link " & vbCrLf & "For Task 2"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(96, 294)
        Label4.Name = "Label4"
        Label4.Size = New Size(142, 32)
        Label4.TabIndex = 10
        Label4.Text = "Phone Num"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(126, 220)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 32)
        Label3.TabIndex = 9
        Label3.Text = "Email"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(126, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 32)
        Label2.TabIndex = 8
        Label2.Text = "Name"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(156))
        btnToggleStopwatch.Location = New Point(22, 493)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(309, 40)
        btnToggleStopwatch.TabIndex = 13
        btnToggleStopwatch.Text = "⏱️ TOGGLE STOPWATCH (CTRL+T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(269, 150)
        txtName.Name = "txtName"
        txtName.Size = New Size(374, 31)
        txtName.TabIndex = 14
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(269, 221)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(374, 31)
        txtEmail.TabIndex = 15
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.Location = New Point(269, 294)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.Size = New Size(374, 31)
        txtPhoneNum.TabIndex = 16
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(269, 384)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(374, 31)
        txtGithubLink.TabIndex = 17
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Location = New Point(350, 493)
        txtStopwatchTime.Multiline = True
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(293, 40)
        txtStopwatchTime.TabIndex = 18
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(168), CByte(220), CByte(252))
        btnSubmit.Location = New Point(22, 618)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(621, 40)
        btnSubmit.TabIndex = 19
        btnSubmit.Text = "✔️ SUBMIT (CTRL+S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(665, 748)
        Controls.Add(btnSubmit)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhoneNum)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents btnSubmit As Button
End Class
