Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class Form2
    Private stopwatchRunning As Boolean = False
    Private elapsedTime As TimeSpan = TimeSpan.Zero

    Private Sub BtnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatchRunning Then
            timerStopwatch.Stop()
        Else
            timerStopwatch.Start()
        End If
        stopwatchRunning = Not stopwatchRunning
    End Sub

    Private Sub TimerStopwatch_Tick(sender As Object, e As EventArgs) Handles timerStopwatch.Tick
        elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1))
        lblStopwatch.Text = elapsedTime.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Submission() With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text,
            .GitHubLink = txtGitHub.Text,
            .StopwatchTime = elapsedTime.ToString("hh\:mm\:ss")
        }
        Await SaveSubmission(submission)
        Me.Close()
    End Sub

    Private Async Function SaveSubmission(submission As Submission) As Task
        Dim client As New HttpClient()
        Dim uri As New Uri("http://localhost:3000/submit") ' Replace with your server URL

        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Dim response As HttpResponseMessage = Await client.PostAsync(uri, content)

        If response.IsSuccessStatusCode Then
            MessageBox.Show("Submission successful!")
        Else
            MessageBox.Show("Error submitting data: " & response.StatusCode)
        End If
    End Function



    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            BtnToggleStopwatch_Click(sender, e)
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            BtnSubmit_Click(sender, e)
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub


End Class


