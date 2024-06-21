Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True ' Enable key preview for the form
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            Button1.PerformClick() ' Simulate click on View Submissions button
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            Button2.PerformClick() ' Simulate click on Create New Submission button
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim viewForm As New Form2()
        viewForm.ShowDialog() ' Use ShowDialog to prevent interacting with Form1 until Form2 is closed
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim createForm As New Form3()
        createForm.SetAsNewSubmission() ' Indicate that this is a new submission
        createForm.ShowDialog() ' Use ShowDialog to prevent interacting with Form1 until Form3 is closed
    End Sub
End Class
