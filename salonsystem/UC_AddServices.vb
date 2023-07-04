Imports System.Data.SqlClient
Public Class UC_AddServices
    Dim isfound As Integer
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim percentage As Double = 0
    Dim count As Integer = 0
    Dim cus_name As String
    Dim Bill_No As Integer
    Dim hair_cut As Integer = 0
    Dim beard_work As Integer = 0
    Dim Makeup_Facial As Integer = 0
    Dim Massage As Integer = 0
    Dim totalservices As Integer = 0
    Dim service_Name As String
    Private Sub coutcust()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select count(*) from Service_Sales_Master")
        cmd.Connection = con
        con.Open()
        Dim r As Integer
        r = cmd.ExecuteScalar
        totalservices = r
    End Sub
    Private Sub UC_AddServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getid()
        coutcust()
        ' gettotalservices()
        kacharaseth2()
    End Sub
    Private Sub kacharaseth2()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
            Dim cmd1 As SqlCommand = New SqlCommand("SELECT * from Service_Sales_Master", con)
            cmd1.Connection = con
            con.Open()
            Dim rdr1 As SqlDataReader = cmd1.ExecuteReader
            While rdr1.Read
                Bill_No = rdr1("Bill_No")
                cus_name = rdr1("Customer_Name")
                kacharaseth()

            End While

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub calculatehaircutper()
        Dim pers As Integer
        pers = hair_cut * 100 / totalservices
        lblAddServHairTotPercen.Text = (pers & " %")
        pers = beard_work * 100 / totalservices
        lblAddServBeardTotPercen.Text = (pers & " %")
        pers = Makeup_Facial * 100 / totalservices
        lblAddServMakeupTotPercen.Text = (pers & " %")
        pers = Massage * 100 / totalservices
        lblAddServMassageTotPercen.Text = (pers & " %")
    End Sub
    Private Sub servicecount()
        If service_Name = "Haircut" Then
            hair_cut += 1
        ElseIf service_Name = "Beard Cut" Then
            beard_work += 1
        ElseIf service_Name = "Makeup or Facial" Then
            Makeup_Facial += 1
        ElseIf service_Name = "Massage" Then
            Massage += 1
        Else
            MsgBox("Service Name Does Not Exist")
        End If
    End Sub
    Private Sub kacharaseth()

        Try
            Dim cmd As SqlCommand = New SqlCommand("SELECT * from Service_Sales_Details where Bill_No = '" & Bill_No & "'", con)
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            While rdr.Read
                service_Name = rdr("Service_Name")
                servicecount()
                calculatehaircutper()
            End While

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try

    End Sub
    Private Sub gettotalservices()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select count(*) from Service_Sales_Master ")
        cmd.Connection = con
        con.Open()
        Dim r As Integer
        r = cmd.ExecuteScalar
        count = r
    End Sub
    Private Sub getid()
        Try
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True"
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("SELECT MAX(Id) + 1 as Id From Services", con)
            lblid.Text = cmd.ExecuteScalar().ToString()
            If lblid.Text = "" Then
                lblid.Text = 1
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub getdata()
        Try
            If txtservicename.Text = "" Then
                MsgBox("Service Name Must Require", MsgBoxStyle.Critical)
                txtservicename.Focus()
                con.Close()
            Else
                Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
                Dim cmd As SqlCommand = New SqlCommand("insert into Services values ('" & lblid.Text & "','" & txtservicename.Text & " ','" & txtdesc.Text & "')")
                cmd.Connection = con
                con.Open()
                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("Service Record hass been Saved!")

                    clear()
                Else
                    MsgBox("No record has been saved!")
                End If
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        getdata()
        getid()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
    End Sub
    Private Sub clear()
        txtservicename.Text = ""
        txtdesc.Text = ""

    End Sub
    Private Sub txtservicename_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtservicename.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "A" AndAlso e.KeyChar <= "z")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Character!")
        End If
    End Sub
End Class