Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim viewForm As New Form2()
        viewForm.ShowDialog() ' Use ShowDialog to prevent interacting with Form1 until Form2 is closed
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim createForm As New Form3()
        createForm.ShowDialog() ' Use ShowDialog to prevent interacting with Form1 until Form3 is closed
    End Sub
End Class
