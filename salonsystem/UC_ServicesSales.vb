Imports MySql.Data.MySqlClient
Public Class UC_ServicesSales
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim count As Integer
    Dim isfound As Integer
    Dim Rate As Integer
    Dim Price As Integer
    Dim totemp As Integer
    Dim amt As Integer
    Dim person As Integer
    Dim flag As Integer
    Dim bill As Integer
    Dim sername As String
    Dim subsername As String
    Dim emplname As String
    Dim noperson As Integer
    Dim servamount As Integer
    Dim mobile As Double
    Dim cusname As String
    Dim bill_date As String
    Dim address As String
    Dim birth_date As String


    Private Sub getid()
        Try
            conn.ConnectionString = "server=localhost;username=root;password=;database=salonsystem;port=3306"
            If conn.State = ConnectionState.Open Then
                conn.Close()

            End If

            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT MAX(Bill_No) + 1 as Bill_No From Service_Sales_Master", conn)
            lblServSalesBillNo.Text = cmd.ExecuteScalar().ToString()
            If lblServSalesBillNo.Text = "" Then
                lblServSalesBillNo.Text = 1

            End If

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub getname()
        cmbServSalesSearchCusName.Items.Clear()

        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT First_Name from Customer order by First_Name")
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                cmbServSalesSearchCusName.Items.Add(rdr("First_Name"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub getname_search()
        isfound = 1
        Try
            If cmbServSalesSearchCusName.Text <> "" Then


                Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
                Dim cmd As MySqlCommand = New MySqlCommand("select First_Name from Customer where [Mobile_Number] = @Number")
                cmd.Parameters.AddWithValue("Number", txtServSalesSearchCusMobNo.Text)
                cmd.Connection = conn
                conn.Open()
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                If (rdr.Read() = True) Then
                    cmbServSalesSearchCusName.Text = rdr("First_Name")
                Else
                    MsgBox("ERROR : No Record Found ", MsgBoxStyle.Critical, "Milan Salon")
                    isfound = 0
                    cmbServSalesSearchCusName.Focus()
                End If
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub getMobileNumber()
        isfound = 1
        Try
            If cmbServSalesSearchCusName.Text <> "" Then
                Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
                Dim cmd As MySqlCommand = New MySqlCommand("select Mobile_Number,Address from Customer where [First_Name] = @Name")
                cmd.Parameters.AddWithValue("Name", cmbServSalesSearchCusName.Text)
                cmd.Connection = conn
                conn.Open()
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                If (rdr.Read() = True) Then
                    txtServSalesSearchCusMobNo.Text = rdr("Mobile_Number")
                    address = rdr("Address")
                Else
                    MsgBox("ERROR : No Record Found ", MsgBoxStyle.Critical, "Milan Salon")
                    isfound = 0
                    cmbServSalesSearchCusName.Focus()
                End If
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub getServiceName()
        cmbServSalesSelectService.Items.Clear()

        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT Service_Name from Services order by Service_Name")
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                cmbServSalesSelectService.Items.Add(rdr("Service_Name"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub getsubService()
        cmbServSalesSelectSubServ.Items.Clear()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT Sub_Service_Name from Sub_Services where Service_Name = '" & cmbServSalesSelectService.Text & "'")
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                cmbServSalesSelectSubServ.Items.Add(rdr("Sub_Service_Name"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub getEmployee()
        cmbServSalesSelectEmp.Items.Clear()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT First_Name from Employee")
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                cmbServSalesSelectEmp.Items.Add(rdr("First_Name"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub UC_ServicesSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getname()
        getServiceName()
        getEmployee()
        getid()
        disable()
    End Sub

    Private Sub cmbServSalesSelectSubServ_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServSalesSelectSubServ.SelectedIndexChanged
        getrate()
    End Sub
    Private Sub enable()
        cmbServSalesSelectService.Enabled = True
        cmbServSalesSelectSubServ.Enabled = True
        cmbServSalesSelectEmp.Enabled = True
        txtServSalesRate.Enabled = True
        txtServSalesEnterNoOfPers.Enabled = True
        btnServSalesAddToCart.Enabled = True
        btnServSalesDeleteFromCart.Enabled = True
    End Sub
    Private Sub disable()
        cmbServSalesSelectService.Enabled = False
        cmbServSalesSelectSubServ.Enabled = False
        cmbServSalesSelectEmp.Enabled = False
        txtServSalesRate.Enabled = False
        txtServSalesEnterNoOfPers.Enabled = False
        btnServSalesAddToCart.Enabled = False
        btnServSalesDeleteFromCart.Enabled = False
    End Sub
    Private Sub gettotalnopersonprev()
        Dim sum As Integer = 0
        For i As Integer = 0 To dtgprevcart.Rows.Count() - 1 Step +1
            sum = sum + dtgprevcart.Rows(i).Cells(5).Value
        Next
        lblnoofpersonprev.Text = sum.ToString()
    End Sub
    Private Sub gettotalamountprev()
        Dim sum As Integer = 0
        For i As Integer = 0 To dtgprevcart.Rows.Count() - 1 Step +1
            sum = sum + dtgprevcart.Rows(i).Cells(6).Value
        Next
        lblServSalesPrevOrderGrandTot.Text = sum.ToString()
    End Sub
    Private Sub getbirthdate()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT Date_of_Birth from Customer where First_Name = '" & cmbServSalesSearchCusName.Text & "'", conn)
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                birth_date = rdr("Date_of_Birth").ToString("dd/MM/yyyy")
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub kacharaseth2()
        dtgprevcart.Rows.Clear()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT * from Service_Sales_Master where Customer_Name = '" & cmbServSalesSearchCusName.Text & "'", conn)
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                bill = rdr("Bill_No")
                bill_date = rdr("Bill_Date")
                mobile = rdr("Mobile_Number")
                cusname = rdr("Customer_Name")
                address = rdr("Customer_Address")
                kacharaseth()
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub kacharaseth()
        dtgprevcart.Rows.Clear()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT * from Service_Sales_Details where Bill_No = '" & bill & "'", conn)
            cmd.Connection = conn
            conn.Open()
            Dim rdr2 As MySqlDataReader = cmd.ExecuteReader
            While rdr2.Read
                lblServSalesPrevOrderCusName.Text = cusname
                sername = rdr2("Service_Name")
                subsername = rdr2("Sub_Service_Name")
                emplname = rdr2("Employee_Name")
                noperson = rdr2("No_of_Person")
                servamount = rdr2("Rate")
                dtgprevcart.Rows.Add(bill, bill_date, sername, subsername, emplname, noperson, servamount)

            End While
            gettotalamountprev()
            gettotalnopersonprev()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub cmbServSalesSearchCusName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServSalesSearchCusName.SelectedIndexChanged
        getMobileNumber()
        enable()
        kacharaseth2()
    End Sub

    Private Sub cmbServSalesSelectService_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServSalesSelectService.SelectedIndexChanged
        getsubService()
    End Sub

    Private Sub Validation()

        Dim totalemp As Integer = txtServSalesEnterNoOfPers.Text
        Dim price As Integer = txtServSalesRate.Text
        If price < 0 Or totalemp < 0 Then
            MsgBox("Enter Valid Price And No. of Person")
        Else
            'MsgBox("HI")
            'addServiceSale()
        End If
    End Sub


    Private Sub getrate()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("select Price from Sub_Services where Sub_Service_Name = '" & cmbServSalesSelectSubServ.Text & "'")

            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                Rate = rdr("Price")
                txtServSalesRate.Text = Rate
            End While
            'MsgBox(Rate)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub getServiceDetails()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim i As Integer

            For i = 0 To dtgcurrcart.RowCount - 1
                conn.Open()
                Dim cmd As MySqlCommand = New MySqlCommand("insert into Service_Sales_Details values ('" & dtgcurrcart.Rows(i).Cells(0).Value & "','" & dtgcurrcart.Rows(i).Cells(1).Value & "','" & dtgcurrcart.Rows(i).Cells(2).Value & "','" & dtgcurrcart.Rows(i).Cells(3).Value & "','" & dtgcurrcart.Rows(i).Cells(4).Value & "','" & dtgcurrcart.Rows(i).Cells(5).Value & "','" & dtgcurrcart.Rows(i).Cells(6).Value & "')")
                cmd.Connection = conn
                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("Service Sale Details Record hass been Saved!")
                Else
                    MsgBox("No record has been saved!")
                End If
                conn.Close()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub getServicemaster()
        Try
            Price = txtServSalesRate.Text
            totemp = txtServSalesEnterNoOfPers.Text
            If lblServSalesBillNo.Text = "" Then
                MsgBox("Bill No Must Require", MsgBoxStyle.Critical)
                conn.Close()
            Else
                If dtgcurrcart.Rows.Count > -1 Then
                    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
                    Dim cmd As MySqlCommand = New MySqlCommand("insert into Service_Sales_Master values ('" & lblServSalesBillNo.Text & "', '" & dtpServSalesBillDate.Value.ToString("dd/MM/yyyy") & "','" & txtServSalesSearchCusMobNo.Text & "','" & cmbServSalesSearchCusName.Text & "','" & address & "')")
                    cmd.Connection = conn
                    conn.Open()
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Service Sale Customer Record hass been Saved!")
                        clearalll()
                        getid()


                    Else
                        MsgBox("No record has been saved!")
                    End If
                    conn.Close()
                Else
                    gettotalamountprev()
                    gettotalnopersonprev()
                    MsgBox("No Data in the Current Cart!")
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub getcurrcart()
        Dim str As String = "server=localhost;username=root;password=;database=salonsystem;port=3306"
        Dim conn As New MySqlConnection(str)
        Dim com As String = "Select * from Service_Sales_Master"
        Dim Adpt As New MySqlDataAdapter(com, conn)
        Dim ds As New DataSet()
        Adpt.Fill(ds, "Service_Sales_Master")
        dtgcurrcart.DataSource = ds.Tables(0)
    End Sub
    Private Sub btnServSalesAddToCart_Click(sender As Object, e As EventArgs) Handles btnServSalesAddToCart.Click
        getdetails()
        'Validation()
        'getcurrcart()
    End Sub
    Private Sub datagridvalidation()
        For i = 0 To dtgcurrcart.RowCount - 1
            flag = 0
            If dtgcurrcart.Rows(i).Cells(3).Value = cmbServSalesSelectSubServ.Text Then
                dtgcurrcart.Rows(i).Cells(5).Value = Convert.ToInt32(txtServSalesEnterNoOfPers.Text) + Convert.ToInt32(dtgcurrcart.Rows(i).Cells(5).Value)
                dtgcurrcart.Rows(i).Cells(6).Value = Convert.ToInt32(dtgcurrcart.Rows(i).Cells(5).Value) * Convert.ToInt32(txtServSalesRate.Text)
                flag = 1
                Exit Sub 'So no insert occurs
            End If
        Next
    End Sub
    Private Sub getdetails()
        amt = txtServSalesRate.Text
        person = txtServSalesEnterNoOfPers.Text
        datagridvalidation()
        If flag = 0 Then
            dtgcurrcart.Rows.Add(New String() {lblServSalesBillNo.Text, dtpServSalesBillDate.Value.ToString("dd/MM/yyyy"), cmbServSalesSelectService.Text, cmbServSalesSelectSubServ.Text, cmbServSalesSelectEmp.Text, txtServSalesEnterNoOfPers.Text, amt})
        End If
        gettotalperson()
        gettotalamt()
    End Sub
    Private Sub gettotalamt()
        Dim sum As Integer = 0
        For i As Integer = 0 To dtgcurrcart.Rows.Count() - 1 Step +1
            sum = sum + (dtgcurrcart.Rows(i).Cells(6).Value * dtgcurrcart.Rows(i).Cells(5).Value)
        Next
        lblServSalesCurCartNetTot.Text = sum.ToString()
    End Sub
    Private Sub gettotalperson()
        Dim sum As Integer = 0
        For i As Integer = 0 To dtgcurrcart.Rows.Count() - 1 Step +1
            sum = sum + dtgcurrcart.Rows(i).Cells(5).Value
        Next
        lblServSalesTotCurCartServ.Text = sum.ToString()
    End Sub
    Private Sub btnServSalesCurCartSubmit_Click(sender As Object, e As EventArgs) Handles btnServSalesCurCartSubmit.Click

        getServiceDetails()
        getServicemaster()
    End Sub
    Private Sub clearalll()
        dtgprevcart.Rows.Clear()
        dtgcurrcart.Rows.Clear()
        txtServSalesSearchCusMobNo.Text = ""
        cmbServSalesSearchCusName.SelectedIndex = -1
        cmbServSalesSelectEmp.SelectedIndex = -1
        cmbServSalesSelectService.SelectedIndex = -1
        cmbServSalesSelectSubServ.SelectedIndex = -1
        txtServSalesEnterNoOfPers.Text = ""
        txtServSalesRate.Text = ""
        dtpServSalesBillDate.Value = Date.Now
        lblServSalesCurCartNetTot.Text = "00"
        lblServSalesTotCurCartServ.Text = "00"
        lblServSalesPrevOrderCusName.Text = "-"
        lblServSalesPrevOrderGrandTot.Text = "00"
        lblnoofpersonprev.Text = "00"
    End Sub
    Private Sub btnServSalesCurrCartReset_Click(sender As Object, e As EventArgs) Handles btnServSalesCurrCartReset.Click
        clearalll()
        getid()
    End Sub

    Private Sub btnServSalesDeleteFromCart_Click(sender As Object, e As EventArgs) Handles btnServSalesDeleteFromCart.Click
        Dim row As Integer
        Dim selRow As New DataGridViewRow
        Dim index As Integer
        index = dtgcurrcart.SelectedRows.Item(0).Index
        selRow = dtgcurrcart.Rows.Item(index)
        dtgcurrcart.Rows.Remove(selRow)
        row = row - 1
    End Sub

    Private Sub txtServSalesRate_TextChanged(sender As Object, e As EventArgs) Handles txtServSalesRate.TextChanged
        If txtServSalesRate.Text = "-" Then
            MsgBox("Nagative Value is Not Valid", MsgBoxStyle.Critical)
            txtServSalesRate.Text = ""
        End If
    End Sub

    Private Sub txtServSalesEnterNoOfPers_TextChanged(sender As Object, e As EventArgs) Handles txtServSalesEnterNoOfPers.TextChanged
        If txtServSalesEnterNoOfPers.Text = "-" Then
            MsgBox("Nagative Value is Not Valid", MsgBoxStyle.Critical)
            txtServSalesEnterNoOfPers.Text = ""
        End If
    End Sub
    Private Sub txtServSalesSearchCusMobNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtServSalesSearchCusMobNo.KeyPress, txtServSalesRate.KeyPress, txtServSalesEnterNoOfPers.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "0" AndAlso e.KeyChar <= "9")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Number!")
        End If
    End Sub
End Class
