Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New Form2()
        createForm.ShowDialog()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New Form3()
        viewForm.ShowDialog()
    End Sub


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            Button2_Click(sender, e)
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub


End Class
