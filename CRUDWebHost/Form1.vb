Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Net
Imports System.Collections.Generic
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Header
Imports System.Text
Imports System.IO

Public Class Form1
    Public post As New List(Of Post)
    Public jsonStr As String

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        postRequest()
    End Sub

    Private Sub postRequest()
        Dim title = txtTitle.Text
        Dim PostData = "title=" & title
        Dim request As WebRequest = WebRequest.Create("https://foodappandroid.000webhostapp.com/addtitle.php")

        request.Method = "POST"
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(PostData)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length
        Dim dataStream As Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()

        Dim response As WebResponse = request.GetResponse()
        dataStream = response.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()
        reader.Close()
        dataStream.Close()
        response.Close()
        MsgBox(responseFromServer)
        getRequest()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        getRequest()
        txtTitle.Text = ""
    End Sub

    Public Sub getRequest()
        GunaDataGridView1.Rows.Clear()
        Dim webclient As WebClient = New WebClient
        Try
            jsonStr = webclient.DownloadString("https://foodappandroid.000webhostapp.com/posts.php")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        Dim jsonobject As JObject = JObject.Parse(jsonStr)
        Dim jsonarray As JArray = JArray.Parse(jsonobject.SelectToken("posts").ToString)
        Try
            For Each item As JObject In jsonarray
                'Console.WriteLine("Title:" & item.SelectToken("title").ToString)
                GunaDataGridView1.Rows.Add(item.SelectToken("id").ToString, item.SelectToken("title").ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getRequest()
    End Sub
End Class
