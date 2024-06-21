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
        Label1 = New Label()
        txtGithubLink = New TextBox()
        txtPhoneNum = New TextBox()
        txtEmail = New TextBox()
        txtName = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label6 = New Label()
        txtStopwatchTime = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        btnDelete = New Button()
        btnEdit = New Button()
        txtSearchEmail = New TextBox()
        btnSearch = New Button()
        btnExportToCSV = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(621, 38)
        Label1.TabIndex = 2
        Label1.Text = "Dipyaman Roy, Slidely Task 2 - View Submissions"
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(269, 396)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(374, 31)
        txtGithubLink.TabIndex = 25
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.Location = New Point(269, 321)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.ReadOnly = True
        txtPhoneNum.Size = New Size(374, 31)
        txtPhoneNum.TabIndex = 24
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(269, 248)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(374, 31)
        txtEmail.TabIndex = 23
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(269, 177)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(374, 31)
        txtName.TabIndex = 22
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(96, 377)
        Label5.Name = "Label5"
        Label5.Size = New Size(143, 64)
        Label5.TabIndex = 21
        Label5.Text = "Github Link " & vbCrLf & "For Task 2"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(96, 321)
        Label4.Name = "Label4"
        Label4.Size = New Size(142, 32)
        Label4.TabIndex = 20
        Label4.Text = "Phone Num"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(126, 247)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 32)
        Label3.TabIndex = 19
        Label3.Text = "Email"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(126, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 32)
        Label2.TabIndex = 18
        Label2.Text = "Name"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(96, 459)
        Label6.Name = "Label6"
        Label6.Size = New Size(124, 64)
        Label6.TabIndex = 26
        Label6.Text = "Stopwatch" & vbCrLf & "time" & vbCrLf
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Location = New Point(269, 478)
        txtStopwatchTime.Multiline = True
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(374, 32)
        txtStopwatchTime.TabIndex = 27
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(156))
        btnPrevious.Location = New Point(22, 615)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(297, 40)
        btnPrevious.TabIndex = 28
        btnPrevious.Text = "◀ PREVIOUS (CTRL+P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.FromArgb(CByte(168), CByte(220), CByte(252))
        btnNext.Location = New Point(348, 615)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(295, 40)
        btnNext.TabIndex = 29
        btnNext.Text = "NEXT (CTRL+N) ▶"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.LightCoral
        btnDelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = SystemColors.ButtonHighlight
        btnDelete.Location = New Point(22, 545)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(297, 40)
        btnDelete.TabIndex = 30
        btnDelete.Text = "❌ DELETE (CTRL+D)"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.SteelBlue
        btnEdit.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEdit.ForeColor = SystemColors.ButtonHighlight
        btnEdit.Location = New Point(346, 545)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(297, 40)
        btnEdit.TabIndex = 31
        btnEdit.Text = "✎ EDIT (CTRL+E)"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' txtSearchEmail
        ' 
        txtSearchEmail.Location = New Point(22, 103)
        txtSearchEmail.Name = "txtSearchEmail"
        txtSearchEmail.Size = New Size(297, 31)
        txtSearchEmail.TabIndex = 32
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Azure
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = SystemColors.ActiveCaptionText
        btnSearch.Location = New Point(346, 98)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(297, 40)
        btnSearch.TabIndex = 33
        btnSearch.Text = "🔎 SEARCH BY EMAIL"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnExportToCSV
        ' 
        btnExportToCSV.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnExportToCSV.Location = New Point(348, 686)
        btnExportToCSV.Name = "btnExportToCSV"
        btnExportToCSV.Size = New Size(295, 40)
        btnExportToCSV.TabIndex = 34
        btnExportToCSV.Text = "📤 EXPORT TO CSV"
        btnExportToCSV.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(665, 748)
        Controls.Add(btnExportToCSV)
        Controls.Add(btnSearch)
        Controls.Add(txtSearchEmail)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtStopwatchTime)
        Controls.Add(Label6)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhoneNum)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtSearchEmail As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnExportToCSV As Button
End Class
