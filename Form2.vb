Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class Form2
    Private currentIndex As Integer = 0
    Private currentSubmissionId As Integer

    Private Async Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True ' Enable key preview for shortcuts
        Await LoadSubmission(currentIndex)
    End Sub

    Private Async Function LoadSubmission(index As Integer) As Task
        Using client As New HttpClient()
            Dim url As String = $"http://localhost:3000/read?index={index}"
            Dim response As HttpResponseMessage = Await client.GetAsync(url)

            If response.IsSuccessStatusCode Then
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(jsonResponse)

                ' Populate UI with submission data
                NameTextBox.Text = submission.name
                EmailTextBox.Text = submission.email
                PhoneTextBox.Text = submission.phone
                GitHubTextBox.Text = submission.github_link
                StopwatchTextBox.Text = submission.stopwatch_time

                ' Store current submission ID for edit/delete operations
                currentSubmissionId = submission.id
            Else
                MessageBox.Show("No more submissions")
            End If
        End Using
    End Function

    Private Async Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Await LoadSubmission(currentIndex)
        End If
    End Sub

    Private Async Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        currentIndex += 1
        Await LoadSubmission(currentIndex)
    End Sub

    Private Async Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim form3 As New Form3()

        ' Populate Form3 with the current submission details
        Await form3.LoadSubmissionDetails(currentSubmissionId, NameTextBox.Text, EmailTextBox.Text, PhoneTextBox.Text, GitHubTextBox.Text, StopwatchTextBox.Text)

        If form3.ShowDialog() = DialogResult.OK Then
            ' Reload submission details in Form2 after editing in Form3
            Await LoadSubmission(currentIndex)
        End If
    End Sub

    Private Async Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Using client As New HttpClient()
            Dim url As String = $"http://localhost:3000/delete/{currentSubmissionId}"
            Dim response As HttpResponseMessage = Await client.DeleteAsync(url)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission deleted successfully!")

                ' Adjust currentIndex after deletion
                If currentIndex > 0 Then
                    currentIndex -= 1
                End If
                Await LoadSubmission(currentIndex) ' Reload data after deletion
            Else
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                MessageBox.Show($"Failed to delete submission: {responseContent}")
            End If
        End Using
    End Sub

    ' Handle keyboard shortcuts
    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.D Then
            DeleteButton.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.E Then
            EditButton.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.P Then
            PreviousButton.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            NextButton.PerformClick()
        End If
    End Sub

    ' Submission Class
    Private Class Submission
        Public Property id As Integer
        Public Property name As String
        Public Property email As String
        Public Property phone As String
        Public Property github_link As String
        Public Property stopwatch_time As String
    End Class
End Class
