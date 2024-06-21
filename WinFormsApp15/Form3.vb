Public Class Form3
    Private stopwatch As New System.Diagnostics.Stopwatch()
    Private stopwatchOffset As TimeSpan

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Stopwatchbtn.Text = "Start"
        Labelstopwatch.Text = "Elapsed Time: 00:00:00"


        Timer1.Enabled = False
    End Sub

    Private Sub Stopwatchbtn_Click(sender As Object, e As EventArgs) Handles Stopwatchbtn.Click
        If stopwatch.IsRunning Then

            stopwatch.Stop()
            stopwatchOffset = stopwatch.Elapsed
            Stopwatchbtn.Text = "Resume"
            Timer1.Enabled = False ' Stop timer
        Else

            stopwatch.Start()
            Stopwatchbtn.Text = "Pause"
            Timer1.Enabled = True ' Start timer
            stopwatchOffset = TimeSpan.Zero ' Reset offset when starting
        End If
    End Sub

    Private Sub Submitbtn_Click(sender As Object, e As EventArgs) Handles Submitbtn.Click
        Dim name As String = TextBox1.Text
        Dim email As String = TextBox6.Text
        Dim phoneNumber As String = TextBox2.Text
        Dim gitHubRepo As String = TextBox3.Text


        Dim form2 As New Form2


        form2.AddSubmission(name, email, phoneNumber, gitHubRepo)


        form2.Show()


        MessageBox.Show($"Submission Created.{vbCrLf}Name: {name}{vbCrLf}Email: {email}{vbCrLf}Phone Number: {phoneNumber}{vbCrLf}GitHub Repo: {gitHubRepo}")
    End Sub

    Private Sub UpdateStopwatchDisplay()
        Dim elapsed As TimeSpan
        If stopwatch.IsRunning Then
            elapsed = stopwatch.Elapsed
        Else
            elapsed = stopwatchOffset
        End If
        Labelstopwatch.Text = $"Elapsed Time: {elapsed.ToString("hh\:mm\:ss")}"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateStopwatchDisplay()
    End Sub
End Class