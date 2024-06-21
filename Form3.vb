Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports System.Diagnostics

Public Class Form3
    Private submissionId As Integer = -1 ' Initialize with an invalid ID
    Private stopwatch As Stopwatch = New Stopwatch() ' Initialize the Stopwatch instance
    Private initialElapsedTime As TimeSpan = TimeSpan.Zero ' Track initial elapsed time

    Public Async Function LoadSubmissionDetails(submissionId As Integer, name As String, email As String, phone As String, githubLink As String, elapsedTime As String) As Task
        Me.submissionId = submissionId

        ' Populate UI with submission data
        NameTextBox.Text = name
        EmailTextBox.Text = email
        PhoneTextBox.Text = phone
        GitHubTextBox.Text = githubLink
        StopwatchTextBox.Text = elapsedTime

        ' Set the initial elapsed time from the elapsed time string
        initialElapsedTime = TimeSpan.Parse(elapsedTime)
    End Function

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub StartStopButton_Click(sender As Object, e As EventArgs) Handles StartStopButton.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        UpdateStopwatchDisplay()
    End Sub

    Private Sub UpdateStopwatchDisplay()
        Dim totalElapsed = initialElapsedTime + stopwatch.Elapsed
        StopwatchTextBox.Text = String.Format("{0:hh\:mm\:ss}", totalElapsed)
    End Sub

    Private Async Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim name As String = NameTextBox.Text
        Dim email As String = EmailTextBox.Text
        Dim phone As String = PhoneTextBox.Text
        Dim githubLink As String = GitHubTextBox.Text
        Dim elapsedTime As String = StopwatchTextBox.Text

        Dim submission = New With {
            .id = submissionId, ' Ensure the ID is included in the update payload
            .name = name,
            .email = email,
            .phone = phone,
            .github_link = githubLink,
            .stopwatch_time = elapsedTime
        }

        Using client As New HttpClient()
            Dim json As String = JsonConvert.SerializeObject(submission)
            Dim content As New StringContent(json, System.Text.Encoding.UTF8, "application/json")
            Dim url As String = $"http://localhost:3000/edit/{submissionId}"
            Dim response As HttpResponseMessage = Await client.PutAsync(url, content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission updated successfully!")
                Me.DialogResult = DialogResult.OK ' Indicate successful submission
                Me.Close() ' Close Form3 after successful update
            Else
                MessageBox.Show("Failed to update submission")
            End If
        End Using
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            SubmitButton.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            StartStopButton.PerformClick()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If stopwatch.IsRunning Then
            UpdateStopwatchDisplay()
        End If
    End Sub

    Private Sub PhoneTextBox_TextChanged(sender As Object, e As EventArgs) Handles PhoneTextBox.TextChanged
        ' Additional functionality can be added here if needed
    End Sub
End Class
