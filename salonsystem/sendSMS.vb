
Imports System.Web
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Resources

Public Class sendSMS
    Public Function sendSMS()

        Dim apikey = "NzA0YzM1MzE2MjY4MzU3MTZmNzQ0YzZlNDg2MzczNzc="
        Dim message = "This is your message"
        Dim numbers = "919978676386"
        Dim strGet As String
        Dim sender = "TXTLCL"
        Dim url As String = "https://api.textlocal.in/send/?"

        strGet = url + "apikey=" + apikey _
        + "&numbers=" + numbers _
        + "&message=" + WebUtility.UrlEncode(message) _
        + "&sender=" + sender

        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString(strGet)
        Console.WriteLine(result)
        Return result
    End Function

    Public sent_cnt As Integer = 0
    Public failure_cnt As Integer = 0
    Public Function sendOffersSMS(ByVal CustName As String, ByVal MobNo As String, ByVal msg As String)
        Dim apikey = "NzA0YzM1MzE2MjY4MzU3MTZmNzQ0YzZlNDg2MzczNzc="

        sent_cnt = 0
        failure_cnt = 0
        'Dim message = "Hi " & CustName & " " & msg
        Dim message = msg
        MsgBox(message)
        Dim numbers = MobNo
        Dim strPost As String
        Dim sender = "TXTLCL"
        Dim url As String = "https://api.textlocal.in/send/?"

        strPost = url + "apikey=" + apikey _
        + "&numbers=" + numbers _
        + "&message=" + WebUtility.UrlEncode(message) _
        + "&sender=" + sender

        Dim request As WebRequest = WebRequest.Create(strPost)
        request.Method = "POST"
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(strPost)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length
        Dim dataStream As Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()

        Dim response As WebResponse = request.GetResponse()
        dataStream = response.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()
        'Console.WriteLine(responseFromServer)
        'MsgBox(responseFromServer)
        'Console.ReadLine()

        If responseFromServer.Substring(responseFromServer.LastIndexOf(":") + 2, 7) = "failure" Then
            failure_cnt = failure_cnt + 1
            MsgBox("API Response: " & responseFromServer)
        Else
            sent_cnt = sent_cnt + 1
            MsgBox("API Response: " & responseFromServer)
        End If

        reader.Close()
        dataStream.Close()
        response.Close()

        If responseFromServer.Length > 0 Then
            Return responseFromServer
        Else
            Return CType(response, HttpWebResponse).StatusDescription
        End If
    End Function

End Class
