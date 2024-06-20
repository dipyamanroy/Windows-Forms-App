Imports System.IO
Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Await DisplaySubmission(currentIndex)
    End Sub

    Private Async Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.P
                    Await ShowPreviousSubmission()
                Case Keys.N
                    Await ShowNextSubmission()
                Case Keys.D
                    DeleteSubmissionWithConfirmation()
                Case Keys.E
                    Await EditSubmission()
            End Select
        End If
    End Sub

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Await ShowPreviousSubmission()
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Await ShowNextSubmission()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteSubmissionWithConfirmation()
    End Sub

    Private Async Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Await EditSubmission()
    End Sub

    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim email As String = txtSearchEmail.Text.Trim()
        If Not String.IsNullOrEmpty(email) Then
            Await SearchAndDisplaySubmissionByEmail(email)
        Else
            MessageBox.Show("Please enter an email to search.")
        End If
    End Sub

    Private Async Function ShowPreviousSubmission() As Task
        If currentIndex > 0 Then
            currentIndex -= 1
            Await DisplaySubmission(currentIndex)
        End If
    End Function

    Private Async Function ShowNextSubmission() As Task
        currentIndex += 1
        Await DisplaySubmission(currentIndex)
    End Function

    Private Async Function DisplaySubmission(index As Integer) As Task
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={index}")
            If response.IsSuccessStatusCode Then
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(jsonResponse)
                txtName.Text = submission.Name
                txtEmail.Text = submission.Email
                txtPhoneNum.Text = submission.Phone
                txtGithubLink.Text = submission.GithubLink
                txtStopwatchTime.Text = submission.StopwatchTime
            Else
                MessageBox.Show("No more submissions.")
                If index > 0 Then currentIndex -= 1 ' Maintain current index if no submission is found
            End If
        End Using
    End Function

    Private Async Sub DeleteSubmission(confirmed As Boolean)
        If confirmed Then
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.DeleteAsync($"http://localhost:3000/delete?index={currentIndex}")
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission deleted successfully.")
                    currentIndex = 0
                    Await DisplaySubmission(currentIndex)
                Else
                    MessageBox.Show("Failed to delete submission.")
                End If
            End Using
        End If
    End Sub

    Private Sub DeleteSubmissionWithConfirmation()
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this submission?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            DeleteSubmission(True) ' Await the DeleteSubmission method
        End If
    End Sub

    Private Async Function EditSubmission() As Task
        Dim editForm As New CreateSubmissionForm(currentIndex)
        ' Show the form as a dialog and wait for it to close
        If editForm.ShowDialog() = DialogResult.OK Then
            ' Reload the current submission after the form is closed
            Await DisplaySubmission(currentIndex)
        End If
    End Function

    Private Async Function SearchAndDisplaySubmissionByEmail(email As String) As Task
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/search?email={email}")
            If response.IsSuccessStatusCode Then
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(jsonResponse)
                txtName.Text = submission.Name
                txtEmail.Text = submission.Email
                txtPhoneNum.Text = submission.Phone
                txtGithubLink.Text = submission.GithubLink
                txtStopwatchTime.Text = submission.StopwatchTime
            Else
                MessageBox.Show("Submission not found.")
            End If
        End Using
    End Function

    ' Add the button click event handler for exporting to CSV
    Private Sub btnExportToCSV_Click(sender As Object, e As EventArgs) Handles btnExportToCSV.Click
        ExportSubmissionsToCSV()
    End Sub

    ' Function to fetch all submissions and export to CSV
    Private Async Sub ExportSubmissionsToCSV()
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/readAll")
            If response.IsSuccessStatusCode Then
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                Dim submissions As List(Of Submission) = JsonConvert.DeserializeObject(Of List(Of Submission))(jsonResponse)
                SaveSubmissionsToCSV(submissions)
            Else
                MessageBox.Show("Failed to fetch submissions.")
            End If
        End Using
    End Sub

    ' Function to save submissions to CSV
    Private Sub SaveSubmissionsToCSV(submissions As List(Of Submission))
        Dim saveFileDialog As New SaveFileDialog() With {
            .Filter = "CSV files (*.csv)|*.csv",
            .Title = "Save Submissions to CSV"
        }

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName
            Using writer As New StreamWriter(filePath)
                writer.WriteLine("Name,Email,Phone,GithubLink,StopwatchTime") ' Header row

                For Each submission As Submission In submissions
                    writer.WriteLine($"{submission.Name},{submission.Email},{submission.Phone},{submission.GithubLink},{submission.StopwatchTime}")
                Next
            End Using
            MessageBox.Show("Submissions exported to CSV successfully!")
        End If
    End Sub

End Class
