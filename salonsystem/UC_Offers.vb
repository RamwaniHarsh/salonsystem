Imports System.Data.SqlClient
Imports System.Net
Public Class UC_Offers
    Dim cname As String
    Dim number As Double
    Dim Message As String = ""
    Private Sub UC_Offers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getData()
    End Sub
    Private Sub getData()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("Select CONCAT(First_Name, ' ' , Last_Name) as Name, Mobile_Number as Contact from Customer", con)
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader

            While rdr.Read
                cname = rdr("Name")
                number = rdr("Contact")
                dgvNewOffers.Rows.Add(cname, number)
            End While
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnSelectAllForOffer_Click(sender As Object, e As EventArgs) Handles btnSelectAllForOffer.Click
        For Each row As DataGridViewRow In dgvNewOffers.Rows
            Dim checkbox As DataGridViewCheckBoxCell = (TryCast(row.Cells("chkbox"), DataGridViewCheckBoxCell))
            checkbox.Value = True
        Next
    End Sub

    Private Sub btnDeSelectAllForOffer_Click(sender As Object, e As EventArgs) Handles btnDeSelectAllForOffer.Click
        For Each row As DataGridViewRow In dgvNewOffers.Rows
            Dim checkbox As DataGridViewCheckBoxCell = (TryCast(row.Cells("chkbox"), DataGridViewCheckBoxCell))
            checkbox.Value = False
        Next
    End Sub
    Private Sub btnSendSmsOffer_Click_1(sender As Object, e As EventArgs) Handles btnSendSmsOffer.Click
        Dim flag As Integer = 0
        For Each row As DataGridViewRow In dgvNewOffers.Rows
            Dim checkBox As DataGridViewCheckBoxCell = (TryCast(row.Cells("chk"), DataGridViewCheckBoxCell))
            If checkBox.Value = True Then
                Dim s As New sendSMS
                Dim fullname As String
                fullname = dgvNewOffers.Rows(row.Index).Cells(0).Value
                If CheckForInternetConnection() = True Then
                    Message = "Hey Style Lover ! Get 20% off on all Services thiss Weekend when you visit Milan - The Family Salon this Month, Would you look Like to book Appointment ? Call @ 9978676386"
                    s.sendOffersSMS(fullname.Substring(0, fullname.IndexOf(" ")), dgvNewOffers.Rows(row.Index).Cells(1).Value, Message)
                    MsgBox("Successs SMS Message : " & s.sent_cnt & vbCrLf & "Failure SMS Message : " & s.failure_cnt, MsgBoxStyle.Information, "Capital - The Family Salon")
                Else
                    MsgBox("ERROR : No Internet Connection")
                    Exit Sub
                End If
                flag = 1
            End If
        Next
        If flag = 0 Then
            MsgBox("No Customer is Selected")
        End If

    End Sub

    Public Shared Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function
End Class
