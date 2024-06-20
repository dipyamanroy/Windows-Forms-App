Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Check for shortcut keys
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.V
                    ' CTRL + V: Open View Submissions form
                    ShowViewSubmissions()
                Case Keys.N
                    ' CTRL + N: Open Create Submission form
                    ShowCreateSubmission()
            End Select
        End If
    End Sub

    Private Sub ShowViewSubmissions()
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub ShowCreateSubmission()
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        ShowViewSubmissions()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        ShowCreateSubmission()
    End Sub

End Class
