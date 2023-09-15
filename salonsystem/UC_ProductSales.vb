Imports MySql.Data.MySqlClient
Public Class UC_ProductSales
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim count As Integer
    Dim isfound As Integer
    Dim quantity As Integer
    Dim mobile As Double
    Dim cusname As String
    Dim prodcat As String
    Dim prodname As String
    Dim Qnty1 As Integer
    Dim Price_Amount As Integer
    Dim billno As Integer
    Dim billdate As String
    Dim flag1 As Integer
    Dim address As String
    Private Sub getid()
        Try
            conn.ConnectionString = "server=localhost;username=root;password=;database=salonsystem;port=3306"
            If conn.State = ConnectionState.Open Then
                conn.Close()

            End If

            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT MAX(Bill_No) + 1 as Bill_No From Product_Sales_Master", conn)
            lblProdSalesBillNo.Text = cmd.ExecuteScalar().ToString()
            If lblProdSalesBillNo.Text = "" Then
                lblProdSalesBillNo.Text = 1

            End If

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub getname()
        cmbProdSalesSearchCusName.Items.Clear()

        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT First_Name from Customer order by First_Name")
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                cmbProdSalesSearchCusName.Items.Add(rdr("First_Name"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub getMobileNumber()
        isfound = 1
        Try
            If cmbProdSalesSearchCusName.Text <> "" Then
                Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
                Dim cmd As MySqlCommand = New MySqlCommand("select Mobile_Number,Address from Customer where First_Name = @Name")
                cmd.Parameters.AddWithValue("Name", cmbProdSalesSearchCusName.Text)
                cmd.Connection = conn
                conn.Open()
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                If (rdr.Read() = True) Then
                    txtProdSalesSearchCusMobNo.Text = rdr("Mobile_Number")
                    lbladdress.Text = rdr("Address")
                Else
                    MsgBox("ERROR : No Record Found ", MsgBoxStyle.Critical, "Milan Salon")
                    isfound = 0
                    cmbProdSalesSearchCusName.Focus()
                End If
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub getProductCategory()
        cmbProdSalesSelectProdCat.Items.Clear()

        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT Category_Name from Product_Category order by Category_Name")
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                cmbProdSalesSelectProdCat.Items.Add(rdr("Category_Name"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub UC_ProductSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpProdsalesBillDate.Value = Today

        getProductCategory()
        getname()
        getid()
        hideproductdetails()
    End Sub
    Private Sub hideproductdetails()
        cmbProdSalesSelectProdCat.Enabled = False
        cmbProdSalesSelectProdName.Enabled = False
        txtProdSalesEnterQuantity.Enabled = False
        txtprice.Enabled = False
        btnProdSalesAddToCart.Enabled = False
        btnProdSalesDeleteFromCart.Enabled = False
    End Sub
    Private Sub unhideproductdtails()
        cmbProdSalesSelectProdCat.Enabled = True
        cmbProdSalesSelectProdName.Enabled = True
        txtProdSalesEnterQuantity.Enabled = True
        txtprice.Enabled = True
        btnProdSalesAddToCart.Enabled = True
        btnProdSalesDeleteFromCart.Enabled = True
    End Sub
    Private Sub getbillno()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT Bill_No from Product_Sales_Details where Product_Name = '" & cmbProdSalesSelectProdName.Text & "'")
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                billno = (rdr("Bill_No"))
                MsgBox(billno)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub gettotalqntprev()
        Dim sum As Integer = 0
        For i As Integer = 0 To dtgprevcart.Rows.Count() - 1 Step +1
            sum = sum + dtgprevcart.Rows(i).Cells(4).Value
        Next
        lblProdSalesPrevOrdTotProd.Text = sum.ToString()
    End Sub
    Private Sub gettotalamountprev()
        Dim sum As Integer = 0
        For i As Integer = 0 To dtgprevcart.Rows.Count() - 1 Step +1
            sum = sum + dtgprevcart.Rows(i).Cells(5).Value
        Next
        lblProdSalesPrevOrderGrandTot.Text = sum.ToString()
    End Sub
    Private Sub Kacharaseth2()
        dtgprevcart.Rows.Clear()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd1 As MySqlCommand = New MySqlCommand("SELECT * from Product_Sales_Master where Customer_Name = '" & cmbProdSalesSearchCusName.Text & "'", conn)
            cmd1.Connection = conn
            conn.Open()
            Dim rdr1 As MySqlDataReader = cmd1.ExecuteReader
            While rdr1.Read
                billno = rdr1("Bill_No")
                billdate = rdr1("Bill_Date")
                cusname = rdr1("Customer_Name")
                mobile = rdr1("Mobile_Number")
                address = rdr1("Customer_Address")
                kacharaseth()
            End While

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub kacharaseth()
        ' dtgprevcart.Rows.Clear()
        Try
            If dtgprevcart.Rows.Count >= -1 Then
                Dim cmd2 As MySqlCommand = New MySqlCommand("SELECT * from Product_Sales_Details where Bill_No = '" & billno & "'", conn)
                cmd2.Connection = conn
                conn.Open()
                Dim rdr As MySqlDataReader = cmd2.ExecuteReader
                While rdr.Read
                    lblProdSalesPrevOrderCusName.Text = cusname
                    prodcat = rdr("Product_Category")
                    prodname = rdr("Product_Name")
                    Qnty1 = rdr("Product_Quantity")
                    amount = rdr("Product_Price")
                    dtgprevcart.Rows.Add(billno, billdate, prodcat, prodname, Qnty1, amount)
                End While

                conn.Close()
                gettotalamountprev()
                gettotalqntprev()
            Else
                MsgBox("No Prev Orders")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try

    End Sub
    Private Sub cmbProdSalesSearchCusName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProdSalesSearchCusName.SelectedIndexChanged
        'getbillno()
        getMobileNumber()
        unhideproductdtails()
        Kacharaseth2()
    End Sub
    Private Sub getproductname()
        cmbProdSalesSelectProdName.Items.Clear()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT Product_Name from Product where Product_Category = '" & cmbProdSalesSelectProdCat.Text & "'")
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                cmbProdSalesSelectProdName.Items.Add(rdr("Product_Name"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub cmbProdSalesSelectProdCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProdSalesSelectProdCat.SelectedIndexChanged
        getproductname()
    End Sub
    Dim flag As Integer
    Private Sub datagridvalidation()
        'MsgBox(dtgcurrcart.RowCount - 1)
        For i = 0 To dtgcurrcart.RowCount - 1
            flag = 0
            If dtgcurrcart.Rows(i).Cells(3).Value = cmbProdSalesSelectProdName.Text Then
                dtgcurrcart.Rows(i).Cells(4).Value = Convert.ToInt32(txtProdSalesEnterQuantity.Text) + Convert.ToInt32(dtgcurrcart.Rows(i).Cells(4).Value)
                'MsgBox("Duplicate data")
                dtgcurrcart.Rows(i).Cells(5).Value = Convert.ToInt32(dtgcurrcart.Rows(i).Cells(4).Value) * Convert.ToInt32(txtprice.Text)
                flag = 1
                Exit Sub 'So no insert occurs
            End If
        Next
    End Sub
    Private Sub getvalidation()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            If txtProdSalesEnterQuantity.Text >= quantity Then
                MsgBox("The Product is out of Stock")
            Else
                getdetails()
                'addProductSales()
            End If
            'MsgBox(quantity)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub cmbProdSalesSelectProdName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProdSalesSelectProdName.SelectedIndexChanged
        getamount()
        txtProdSalesEnterQuantity.Text = ""
    End Sub
    Dim amount As Integer = 0
    Private Sub getamount()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("select Rate from Product where Product_Name = '" & cmbProdSalesSelectProdName.Text & "'")

            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                amount = rdr("Rate")
                txtprice.Text = amount
            End While

            'getdetails()
            'MsgBox(amount)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub getQuantity()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("select Quantity from Product_Stock where Product_Name = '" & cmbProdSalesSelectProdName.Text & "'")

            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                quantity = rdr("Quantity")
            End While
            getvalidation()
            'MsgBox(quantity)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub getCurrCart()
        Dim str As String = "server=localhost;username=root;password=;database=salonsystem;port=3306"
        Dim conn As New MySqlConnection(str)
        Dim com As String = "Select * from Product_Sales_Details"
        Dim Adpt As New MySqlDataAdapter(com, conn)
        Dim ds As New DataSet()
        Adpt.Fill(ds, "Product_Sales_Details")
        dtgcurrcart.DataSource = ds.Tables(0)
    End Sub
    Private Sub btnProdSalesAddToCart_Click(sender As Object, e As EventArgs) Handles btnProdSalesAddToCart.Click
        getQuantity()
        txtProdSalesEnterQuantity.Text = ""
        'getCurrCart()
    End Sub
    Dim qnty As Integer
    Dim amt As Integer
    Private Sub getdetails()
        amt = txtprice.Text
        qnty = txtProdSalesEnterQuantity.Text
        datagridvalidation()
        If flag = 0 Then
            dtgcurrcart.Rows.Add(New String() {lblProdSalesBillNo.Text, dtpProdsalesBillDate.Value.ToString("dd/MM/yyyy"), cmbProdSalesSelectProdCat.Text, cmbProdSalesSelectProdName.Text, txtProdSalesEnterQuantity.Text, amt})
        End If

        gettotalqnt()
        gettotalamt()
    End Sub

    Private Sub txtProdSalesSearchCusMobNo_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub gettotalamt()
        Dim sum As Integer = 0
        For i As Integer = 0 To dtgcurrcart.Rows.Count() - 1 Step +1
            sum = sum + (dtgcurrcart.Rows(i).Cells(5).Value.ToString * dtgcurrcart.Rows(i).Cells(4).Value.ToString)
        Next
        lblProdSalesCurCartNetTot.Text = sum.ToString()
    End Sub
    Private Sub gettotalqnt()
        Dim sum As Integer = 0
        For i As Integer = 0 To dtgcurrcart.Rows.Count() - 1 Step +1
            sum = sum + dtgcurrcart.Rows(i).Cells(4).Value
        Next
        lblProdSalesTotCurCartProd.Text = sum.ToString()
    End Sub

    Private Sub btnProdSalesDeleteFromCart_Click(sender As Object, e As EventArgs) Handles btnProdSalesDeleteFromCart.Click
        Dim row As Integer
        Dim selRow As New DataGridViewRow
        Dim index As Integer
        index = dtgcurrcart.SelectedRows.Item(0).Index
        selRow = dtgcurrcart.Rows.Item(index)
        dtgcurrcart.Rows.Remove(selRow)
        row = row - 1
        gettotalqnt()
        gettotalamt()
        '  dtgcurrcart.Rows.Remove(dtgcurrcart.SelectedRows(0))
    End Sub
    Private Sub getDetails1()

        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim i As Integer
            'MsgBox(dtgcurrcart.RowCount - 2)
            For i = 0 To dtgcurrcart.RowCount - 1
                conn.Open()
                Dim cmd As MySqlCommand = New MySqlCommand("insert into Product_Sales_Details values ('" & dtgcurrcart.Rows(i).Cells(0).Value & "','" & dtgcurrcart.Rows(i).Cells(1).Value & "','" & dtgcurrcart.Rows(i).Cells(2).Value & "','" & dtgcurrcart.Rows(i).Cells(3).Value & "','" & dtgcurrcart.Rows(i).Cells(4).Value & "','" & dtgcurrcart.Rows(i).Cells(5).Value & "')")
                cmd.Connection = conn
                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("Product Sale Record hass been Saved!")
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
    Private Sub getmaster()
        Try
            Dim tstDate As DateTime = dtpProdsalesBillDate.Text
            Dim dateAsString As String = tstDate
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("insert into Product_Sales_Master values ('" & lblProdSalesBillNo.Text & "','" & dtpProdsalesBillDate.Value.ToString("dd/MM/yyyy") & "','" & txtProdSalesSearchCusMobNo.Text & "','" & cmbProdSalesSearchCusName.Text & "','" & lbladdress.Text & "')")
            cmd.Connection = conn
            conn.Open()
            Dim r As Integer
            r = cmd.ExecuteNonQuery()
            If r > 0 Then
                MsgBox("Product Sales Record hass been Saved!")
                flag1 = 1
            Else
                MsgBox("No record has been saved!")
                flag1 = 0
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub clearall()
        cmbProdSalesSearchCusName.SelectedIndex = -1
        cmbProdSalesSelectProdCat.SelectedIndex = -1
        cmbProdSalesSelectProdName.SelectedIndex = -1
        txtProdSalesSearchCusMobNo.Text = ""
        txtProdSalesEnterQuantity.Text = ""
        txtprice.Text = ""
        dtpProdsalesBillDate.Value = Date.Now
        dtgcurrcart.Rows.Clear()
        dtgprevcart.Rows.Clear()
        getid()
        lblProdSalesCurCartNetTot.Text = "-"
        lblProdSalesTotCurCartProd.Text = "-"
        lblProdSalesPrevOrderCusName.Text = "-"
        lblProdSalesPrevOrderGrandTot.Text = "-"
        lblProdSalesPrevOrdTotProd.Text = "-"
    End Sub
    Private Sub btnProdSalesCurCartSubmit_Click(sender As Object, e As EventArgs) Handles btnProdSalesCurCartSubmit.Click

        If dtgcurrcart.RowCount <> -1 Then
            getmaster()
            getDetails1()
            If flag1 = 1 Then
                updatequantity()
                clearall()
            Else
                MsgBox("Product Sales Record Has not Been Inserted in Database so Then You Can Not Update Product Stock", MsgBoxStyle.Critical)
                dtgcurrcart.Rows.Clear()
            End If

        Else
            MsgBox("Enter Data First", MsgBoxStyle.Information)
        End If

    End Sub
    Private Sub updatequantity()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim i As Integer
            For i = 0 To dtgcurrcart.RowCount - 1
                Dim compare_qnt As Integer = dtgcurrcart.Rows(i).Cells(4).Value
                Dim ans_qnt As Integer
                conn.Open()
                Try
                    Dim getqnt As Integer
                    Dim con1 As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
                    Dim cmd_qnt As MySqlCommand = New MySqlCommand("Select Quantity from Product_Stock where Product_Name = '" & dtgcurrcart.Rows(i).Cells(3).Value & "'", con1)
                    con1.Open()
                    Dim rdr As MySqlDataReader = cmd_qnt.ExecuteReader

                    While rdr.Read
                        getqnt = rdr("Quantity")
                    End While
                    ' MsgBox(getqnt)
                    'MsgBox(compare_qnt)

                    ans_qnt = getqnt - compare_qnt
                    'MsgBox(ans_qnt)
                    con1.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Dim cmd As MySqlCommand = New MySqlCommand("Update Product_Stock set Quantity = '" & ans_qnt & "' where Product_Name = '" & dtgcurrcart.Rows(i).Cells(3).Value & "'")
                cmd.Connection = conn
                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("Product Stock hass been Updated!")
                Else
                    MsgBox("No record has been Updated!")
                End If
                conn.Close()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
    'Private Sub getqnt()
    '    Try
    '        Dim getqnt As Integer

    '        conn.ConnectionString = "server=localhost;username=root;password=;database=salonsystem;port=3306"
    '        Dim cmd As MySqlCommand = New MySqlCommand("Select Quantity from Product_Stock where Product_Name = '" & dtgcurrcart.Rows(i).Cells(2).Value & "'", conn)
    '        Dim rdr As MySqlDataReader = cmd.ExecuteReader

    '        conn.Open()

    '        While rdr.Read
    '            getqnt = rdr("Quantity")
    '        End While
    '        conn.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    Private Sub dtgcurrcart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgcurrcart.CellContentClick

    End Sub

    Private Sub btnProdSalesCurrCartReset_Click(sender As Object, e As EventArgs) Handles btnProdSalesCurrCartReset.Click
        cmbProdSalesSearchCusName.SelectedIndex = -1
        cmbProdSalesSelectProdCat.SelectedIndex = -1
        cmbProdSalesSelectProdName.SelectedIndex = -1
        txtProdSalesSearchCusMobNo.Text = ""
        txtProdSalesEnterQuantity.Text = ""
        txtprice.Text = ""
        dtpProdsalesBillDate.Value = Date.Now
        dtgcurrcart.Rows.Clear()
        dtgprevcart.Rows.Clear()

    End Sub

    Private Sub txtProdSalesEnterQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtProdSalesEnterQuantity.TextChanged
        If txtProdSalesEnterQuantity.Text = "-" Then
            MsgBox("Nagative Value is Not Valid", MsgBoxStyle.Critical)
            txtProdSalesEnterQuantity.Text = ""
        End If
    End Sub

    Private Sub txtprice_TextChanged(sender As Object, e As EventArgs) Handles txtprice.TextChanged
        If txtprice.Text = "-" Then
            MsgBox("Nagative Value is Not Valid", MsgBoxStyle.Critical)
            txtprice.Text = ""
        End If
    End Sub

    Private Sub txtProdSalesSearchCusMobNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProdSalesSearchCusMobNo.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "0" AndAlso e.KeyChar <= "9")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Number!")
        End If
    End Sub

    Private Sub txtProdSalesEnterQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProdSalesEnterQuantity.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "0" AndAlso e.KeyChar <= "9")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Number!")
        End If
    End Sub

    Private Sub txtprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprice.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "0" AndAlso e.KeyChar <= "9")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Number!")
        End If
    End Sub
End Class
