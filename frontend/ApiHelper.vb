Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class ApiHelper
    Private Shared ReadOnly httpClient As HttpClient = New HttpClient()

    Public Shared Async Function PingAsync() As Task(Of Boolean)
        Dim response As HttpResponseMessage = Await httpClient.GetAsync("http://localhost:3000/ping")
        response.EnsureSuccessStatusCode()
        Dim result As String = Await response.Content.ReadAsStringAsync()
        Return Boolean.Parse(result)
    End Function

    Public Shared Async Function SubmitAsync(submission As Object) As Task
        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
        Dim response As HttpResponseMessage = Await httpClient.PostAsync("http://localhost:3000/submit", content)
        response.EnsureSuccessStatusCode()
    End Function

    Public Shared Async Function ReadAsync(index As Integer) As Task(Of Object)
        Dim response As HttpResponseMessage = Await httpClient.GetAsync($"http://localhost:3000/read?index={index}")
        response.EnsureSuccessStatusCode()
        Dim result As String = Await response.Content.ReadAsStringAsync()
        Return JsonConvert.DeserializeObject(Of Object)(result)
    End Function
End Class
