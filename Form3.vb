Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class Form3
    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission)

    Private Async Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Await LoadSubmissions()
        DisplaySubmission()
    End Sub

    Private Async Function LoadSubmissions() As Task
        Dim client As New HttpClient()
        Dim uri As New Uri("http://localhost:3000/read")

        Dim response As HttpResponseMessage = Await client.GetAsync(uri)

        If response.IsSuccessStatusCode Then
            Dim json As String = Await response.Content.ReadAsStringAsync()
            submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(json)
        Else
            MessageBox.Show("Error loading submissions: " & response.StatusCode)
        End If
    End Function

    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission = submissions(currentIndex)
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhone.Text = submission.Phone
            txtGitHub.Text = submission.GitHubLink
            lblStopwatch.Text = submission.StopwatchTime
        End If
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If
    End Sub


    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            BtnPrevious_Click(sender, e)
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            BtnNext_Click(sender, e)
        End If
    End Sub

End Class
