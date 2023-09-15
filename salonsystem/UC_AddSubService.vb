Imports MySql.Data.MySqlClient
Public Class UC_AddSubService
    Dim isfound As Integer
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
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
        Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
        Dim cmd As MySqlCommand = New MySqlCommand("select count(*) from Service_Sales_Master", conn)
        cmd.Connection = conn
        conn.Open()
        Dim r As Integer
        r = cmd.ExecuteScalar
        totalservices = r
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
        Dim pers As Double = 0
        pers = hair_cut * 100 / totalservices
        lblAddServHairTotPercen.Text = (pers & " %")
        pers = 0
        pers = beard_work * 100 / totalservices
        lblAddServBeardTotPercen.Text = (pers & " %")
        pers = 0
        pers = Makeup_Facial * 100 / totalservices
        lblAddServMakeupTotPercen.Text = (pers & " %")
        pers = 0
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
        Dim cmd As MySqlCommand = New MySqlCommand("select count(*) from Service_Sales_Master")
        cmd.Connection = conn
        conn.Open()
        Dim r As Integer
        r = cmd.ExecuteScalar
        count = r
    End Sub
    Private Sub getdata()
        Try
            If txtsubservicename.Text = "" Then
                MsgBox("Sub Service Name Must Require", MsgBoxStyle.Critical)
                txtsubservicename.Focus()
                conn.Close()
            Else
                Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
                Dim cmd As MySqlCommand = New MySqlCommand("insert into Sub_Services values ('" & lblid.Text & "','" & txtsubservicename.Text & "','" & cmbservicename.SelectedItem & " ','" & txtPrice.Text & "','" & txtDescription.Text & "')")
                cmd.Connection = conn
                conn.Open()
                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("Sub Service Record hass been Saved!")
                    clear()
                    getId()

                Else
                    MsgBox("No record has been saved!")
                End If
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub getId()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As New MySqlCommand("SELECT MAX(Id) + 1 as Id FROM Sub_Services", conn)
            conn.Open()
            lblid.Text = cmd.ExecuteScalar().ToString()
            If lblid.Text = "" Then
                lblid.Text = 1
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub getservicename()
        Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
        Dim cmd1 As MySqlCommand = New MySqlCommand("SELECT * from Services order by Service_Name", conn)
        cmd1.Connection = conn
        conn.Open()
        Dim rdr As MySqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            cmbservicename.Items.Add(rdr("Service_Name"))
        End While
        cmbservicename.Text = ""
        cmbservicename.Enabled = True
    End Sub
    Private Sub UC_AddSubService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getservicename()
        getId()
        coutcust()
        gettotalservices()
        kacharaseth2()
    End Sub
    Private Sub txtsubservicename_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsubservicename.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "A" AndAlso e.KeyChar <= "z")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Character!")
        End If
    End Sub
    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "0" AndAlso e.KeyChar <= "9")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Number!")
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
    End Sub
    Private Sub clear()
        txtDescription.Text = ""
        txtPrice.Text = ""
        txtsubservicename.Text = ""
        cmbservicename.SelectedIndex = -1
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        getdata()
    End Sub
End Class
