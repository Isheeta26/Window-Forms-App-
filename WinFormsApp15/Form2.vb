Public Class Form2
    Private Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property PhoneNumber As String
        Public Property GitHubRepo As String
    End Class

    Private submissions As New List(Of Submission)()
    Private currentIndex As Integer = 0

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubmissions()
        DisplaySubmission(currentIndex)
    End Sub

    Private Sub LoadSubmissions()
        submissions.Add(New Submission With {
            .Name = "John Doe",
            .Email = "john.doe@example.com",
            .PhoneNumber = "123-456-7890",
            .GitHubRepo = "https://github.com/johndoe"
        })
        submissions.Add(New Submission With {
            .Name = "Jane Smith",
            .Email = "jane.smith@example.com",
            .PhoneNumber = "987-654-3210",
            .GitHubRepo = "https://github.com/janesmith"
        })
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            Dim currentSubmission = submissions(index)
            Label1.Text = $"Name: {currentSubmission.Name}"
            Label2.Text = $"Email: {currentSubmission.Email}"
            Label3.Text = $"Phone Number: {currentSubmission.PhoneNumber}"
            Label4.Text = $"GitHub Repo: {currentSubmission.GitHubRepo}"
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles previousbtn.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles nextbtn.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub


    Public Sub AddSubmission(name As String, email As String, phoneNumber As String, gitHubRepo As String)
        submissions.Add(New Submission With {
            .Name = name,
            .Email = email,
            .PhoneNumber = phoneNumber,
            .GitHubRepo = gitHubRepo
        })

        currentIndex = submissions.Count - 1
        DisplaySubmission(currentIndex)
    End Sub
End Class