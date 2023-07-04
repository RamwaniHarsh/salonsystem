Imports System.Data.SqlClient
Public Class UC_UpdateService
    Dim isfound As Integer
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim count As Integer = 0
    Dim cus_name As String
    Dim Bill_No As Integer
    Dim hair_cut As Integer = 0
    Dim beard_work As Integer = 0
    Dim Makeup_Facial As Integer = 0
    Dim Massage As Integer = 0
    Dim totalcustomer As Integer = 0
    Dim service_Name As String
    Private Sub coutcust()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select count(*) from Service_Sales_Master", con)
        cmd.Connection = con
        con.Open()
        Dim r As Integer
        r = cmd.ExecuteScalar
        totalcustomer = r
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
            calculatehaircutper()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub calculatehaircutper()
        Dim pers As Integer = 0
        pers = hair_cut * 100 / totalcustomer
        lblAddServHairTotPercen.Text = (pers & " %")
        pers = beard_work * 100 / totalcustomer
        lblAddServBeardTotPercen.Text = (pers & " %")
        pers = Makeup_Facial * 100 / totalcustomer
        lblAddServMakeupTotPercen.Text = (pers & " %")
        pers = Massage * 100 / totalcustomer
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
        End If
    End Sub
    Private Sub kacharaseth()

        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("SELECT * from Service_Sales_Details where Bill_No = '" & Bill_No & "'", con)
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            While rdr.Read
                service_Name = rdr("Service_Name")
                servicecount()
            End While

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try

    End Sub
    Private Sub gettotalservices()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select count(*) from Service_Sales_Master", con)
        cmd.Connection = con
        con.Open()
        Dim r As Integer
        r = cmd.ExecuteScalar
        count = r
    End Sub
    Private Sub getdata()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("Update Services set Service_Name='" & txtservicename.Text & "',Description='" & txtdesc.Text & "' where Service_Name = '" & cmbServiceName.SelectedItem & "'")
            cmd.Connection = con
            con.Open()

            Dim r As Integer
            r = cmd.ExecuteNonQuery()
            If r > 0 Then
                MsgBox("Services Record hass Been Updated !")

            Else
                MsgBox("No Record has been Saved !")
            End If
            con.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        getdata()
        kacharaseth2()
    End Sub
    Private Sub getName()
        cmbServiceName.Items.Clear()

        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("SELECT Service_Name from Services", con)
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            While rdr.Read
                cmbServiceName.Items.Add(rdr("Service_Name"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub UC_UpdateService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getName()
        cmbServiceName.Focus()
        coutcust()
        gettotalservices()
        kacharaseth2()
    End Sub

    Private Sub cmbIdServiceName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServiceName.SelectedIndexChanged
        isfound = 1
        'disableall()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("select * from Services where [Service_Name] = @name")
            cmd.Parameters.AddWithValue("name", cmbServiceName.Text)
            cmd.Connection = con
            con.Open()
            'disableall()
            Dim rdr As SqlDataReader = cmd.ExecuteReader

            If (rdr.Read() = True) Then
                txtservicename.Text = rdr("Service_Name")
                txtdesc.Text = rdr("Description")
            Else
                ' disableall()
                MsgBox("ERROR : No Record Found ", MsgBoxStyle.Critical, "Milan Salon")
                isfound = 0
                cmbServiceName.Focus()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtservicename_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtservicename.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "A" AndAlso e.KeyChar <= "z")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Character!")
        End If
    End Sub
End Class
