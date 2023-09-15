Imports MySql.Data.MySqlClient
Public Class UC_UpdateSubServices
    Dim isfound As Integer
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim cus_name As String
    Dim Bill_No As Integer
    Dim hair_cut As Integer = 0
    Dim beard_work As Integer = 0
    Dim Makeup_Facial As Integer = 0
    Dim Massage As Integer = 0
    Dim totalcustomer As Integer = 0
    Dim service_Name As String
    Dim count As Integer = 0
    Private Sub coutcust()
        Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
        Dim cmd As MySqlCommand = New MySqlCommand("select count(*) from Service_Sales_Master", conn)
        cmd.Connection = conn
        conn.Open()
        Dim r As Integer
        r = cmd.ExecuteScalar
        totalcustomer = r
    End Sub
    Private Sub kacharaseth2()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd1 As MySqlCommand = New MySqlCommand("SELECT * from Service_Sales_Master", conn)
            cmd1.Connection = conn
            conn.Open()
            Dim rdr1 As MySqlDataReader = cmd1.ExecuteReader
            While rdr1.Read
                Bill_No = rdr1("Bill_No")
                cus_name = rdr1("Customer_Name")
                kacharaseth()
            End While
            calculatehaircutper()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
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
        Else
            MsgBox("Service Name Does Not Exist")
        End If
    End Sub
    Private Sub kacharaseth()

        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT * from Service_Sales_Details where Bill_No = '" & Bill_No & "'", conn)
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                service_Name = rdr("Service_Name")
                servicecount()
            End While

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try

    End Sub
    Private Sub gettotalservices()
        Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
        Dim cmd As MySqlCommand = New MySqlCommand("select count(*) from Service_Sales_Master", conn)
        cmd.Connection = conn
        conn.Open()
        Dim r As Integer
        r = cmd.ExecuteScalar
        count = r
    End Sub
    Private Sub cmbSubServiceName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubServiceName.SelectedIndexChanged
        isfound = 1
        'disableall()

        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("select * from Sub_Services where [Sub_Service_Name] = @Name")
            cmd.Parameters.AddWithValue("Name", cmbSubServiceName.Text)
            cmd.Connection = conn
            conn.Open()
            'disableall()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader

            If (rdr.Read() = True) Then
                txtsubservicename.Text = rdr("Sub_Service_Name")
                cmbServiceName.SelectedItem = rdr("Service_Name")
                getServiceName()
                txtdesc.Enabled = True
                txtprice.Enabled = True


            Else
                ' disableall()
                MsgBox("ERROR : No Record Found ", MsgBoxStyle.Critical, "Milan Salon")
                isfound = 0
                cmbSubServiceName.Focus()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub getServiceName()
        cmbServiceName.Items.Clear()

        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT Service_Name from Services")
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                cmbServiceName.Items.Add(rdr("Service_Name"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try

    End Sub
    Private Sub getName()
        cmbSubServiceName.Items.Clear()

        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT Sub_Service_Name from Sub_Services")
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                cmbSubServiceName.Items.Add(rdr("Sub_Service_Name"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try

    End Sub
    Private Sub UC_UpdateSubServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getName()
        txtprice.Enabled = False
        txtdesc.Enabled = False
        coutcust()
        gettotalservices()
        kacharaseth2()
    End Sub

    Private Sub cmbServiceName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServiceName.SelectedIndexChanged
        isfound = 1
        'disableall()

        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("select * from Services where [Service_Name] = @Name")
            cmd.Parameters.AddWithValue("Name", cmbServiceName.Text)
            cmd.Connection = conn
            conn.Open()
            'disableall()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader

            If (rdr.Read() = True) Then
                txtprice.Text = rdr("Price")
                txtdesc.Text = rdr("Description")
            Else
                ' disableall()
                MsgBox("ERROR : No Record Found ", MsgBoxStyle.Critical, "Milan Salon")
                isfound = 0
                cmbServiceName.Focus()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("Update Sub_Services set Sub_Service_Name='" & txtsubservicename.Text & "',Service_Name='" & cmbServiceName.SelectedItem & "',Price='" & txtprice.Text & "',Description='" & txtdesc.Text & "' where Sub_Service_Name = '" & cmbSubServiceName.Text & "'")
            cmd.Connection = conn
            conn.Open()

            Dim r As Integer
            r = cmd.ExecuteNonQuery()
            If r > 0 Then
                MsgBox("Sub Services Record hass Been Updated !")

            Else
                MsgBox("No Record has been Saved !")
            End If
            conn.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        cmbServiceName.SelectedItem = " "
        cmbSubServiceName.SelectedItem = " "
        txtdesc.Text = ""
        txtprice.Text = ""
        txtsubservicename.Text = ""

    End Sub

    Private Sub txtsubservicename_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsubservicename.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "A" AndAlso e.KeyChar <= "z")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Character!")
        End If
    End Sub

    Private Sub txtprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprice.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "0" AndAlso e.KeyChar <= "9")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Number!")
        End If
    End Sub
End Class
