Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private stopwatch As Stopwatch
    Private elapsedTime As TimeSpan = TimeSpan.Zero
    Private timer As Timer
    Private editIndex As Integer = -1

    Public Sub New()
        ' Constructor for creating a new submission
        InitializeComponent()
        editIndex = -1
    End Sub

    Public Sub New(index As Integer)
        ' Constructor for editing an existing submission
        InitializeComponent()
        editIndex = index
    End Sub

    Private Async Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stopwatch = New Stopwatch()
        Me.KeyPreview = True
        timer = New Timer()
        AddHandler timer.Tick, AddressOf Timer_Tick
        timer.Interval = 1000

        If editIndex <> -1 Then
            Await LoadSubmission(editIndex)
        End If
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.T
                    ToggleStopwatch()
                Case Keys.S
                    SubmitForm()
            End Select
        End If
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        ToggleStopwatch()
    End Sub

    Private Sub ToggleStopwatch()
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            elapsedTime += stopwatch.Elapsed
            stopwatch.Reset()
            timer.Stop()
        Else
            stopwatch.Start()
            timer.Start()
        End If
        UpdateStopwatchDisplay()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        UpdateStopwatchDisplay()
    End Sub

    Private Sub UpdateStopwatchDisplay()
        txtStopwatchTime.Text = (elapsedTime + stopwatch.Elapsed).ToString("hh\:mm\:ss")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        SubmitForm()
    End Sub

    Private Async Sub SubmitForm()
        ' Validate name, email, and phone number
        Dim name As String = txtName.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim phoneNum As String = txtPhoneNum.Text.Trim()

        If String.IsNullOrEmpty(name) Then
            MessageBox.Show("Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(email) Then
            MessageBox.Show("Email cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not IsValidPhoneNumber(phoneNum) Then
            MessageBox.Show("Phone number must be exactly 10 numeric digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim submission As New Submission() With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhoneNum.Text,
            .GithubLink = txtGithubLink.Text,
            .StopwatchTime = txtStopwatchTime.Text
        }

        Using client As New HttpClient()
            If editIndex = -1 Then
                ' Creating a new submission
                Dim json As String = JsonConvert.SerializeObject(submission)
                Dim content As New StringContent(json, Encoding.UTF8, "application/json")
                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission saved successfully!")
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    MessageBox.Show("Failed to save submission.")
                End If
            Else
                ' Updating an existing submission
                Dim json As String = JsonConvert.SerializeObject(submission)
                Dim content As New StringContent(json, Encoding.UTF8, "application/json")
                Dim response As HttpResponseMessage = Await client.PutAsync($"http://localhost:3000/update?index={editIndex}", content)
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission updated successfully!")
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    MessageBox.Show("Failed to update submission.")
                End If
            End If
        End Using
    End Sub

    Private Async Function LoadSubmission(index As Integer) As Task
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

                ' Parse the stopwatch time and set the elapsed time
                If TimeSpan.TryParse(submission.StopwatchTime, elapsedTime) Then
                    stopwatch.Start()
                End If
            End If
        End Using
    End Function

    Private Function IsValidPhoneNumber(phone As String) As Boolean
        Return phone.Length = 10 AndAlso phone.All(AddressOf Char.IsDigit)
    End Function

End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GithubLink As String
    Public Property StopwatchTime As String
End Class