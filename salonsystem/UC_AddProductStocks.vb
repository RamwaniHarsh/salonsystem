Imports MySql.Data.MySqlClient
Public Class UC_AddProductStocks
    Dim isfound As Integer
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Private Sub cmbAddProdCatStock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAddProdCatStock.SelectedIndexChanged
        getProductName()
    End Sub
    Private Sub getProductName()
        cmbAddStockProdName.Items.Clear()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT Product_Name from Product where Product_Category = '" & cmbAddProdCatStock.Text & "'")
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                cmbAddStockProdName.Items.Add(rdr("Product_Name"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub getCategory()
        cmbAddProdCatStock.Items.Clear()

        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT Category_Name from Product_Category")
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                cmbAddProdCatStock.Items.Add(rdr("Category_Name"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try

    End Sub
    Private Sub getid()
        Try
            conn.ConnectionString = "server=localhost;username=root;password=;database=salonsystem;port=3306"
            If conn.State = ConnectionState.Open Then
                conn.Close()

            End If

            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT MAX(Stock_Id) + 1 as Id From Product_Stock", conn)
            lblAddStockID.Text = cmd.ExecuteScalar().ToString()
            If lblAddStockID.Text = "" Then
                lblAddStockID.Text = 1

            End If

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getproductstock()
        dgvqnt0.Rows.Clear()
        dgvqnt1to5.Rows.Clear()
        dgvqnt5.Rows.Clear()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT Product_Name , Quantity from Product_Stock")
            Dim currStock As Integer
            Dim product_name As String
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                product_name = rdr("Product_Name")
                currStock = rdr("Quantity")
                If currStock = 0 Then
                    dgvqnt0.Rows.Add(product_name, currStock)
                ElseIf currStock >= 1 And currStock <= 5 Then
                    dgvqnt1to5.Rows.Add(product_name, currStock)
                ElseIf currStock > 5 Then
                    dgvqnt5.Rows.Add(product_name, currStock)
                End If
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub UC_AddProductStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getproductstock()
        getCategory()
        getid()
        dtpAddProdStockDate.Value = Date.Now
    End Sub
    Private Sub getCurrQuantity()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT Quantity from Product_Stock where Product_Name = '" & cmbAddStockProdName.Text & "'")
            Dim currStock As Integer
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                currStock = (rdr("Quantity"))
                If currStock = 0 Then
                    lblCurrentStock.Text = "0"
                Else
                    lblCurrentStock.Text = currStock
                End If
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub getname()
        Try
            If cmbAddStockProdName.SelectedItem = "" Then
                MsgBox("Product Name Required")
            Else
                Dim name As String = ""
                Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
                Dim cmd As MySqlCommand = New MySqlCommand("select Product_Name From Product_Stock where Product_Name = '" & cmbAddStockProdName.SelectedItem & "'")
                cmd.Connection = conn
                conn.Open()
                Dim rdr As MySqlDataReader = cmd.ExecuteReader
                If rdr.Read Then
                    name = (rdr("Product_Name"))
                    If name = cmbAddStockProdName.Text Then
                        addDuplicateStock()
                        Exit Sub
                    Else
                        AddProductStock()
                        Exit Sub
                    End If
                Else
                    AddProductStock()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub addDuplicateStock()
        Try
            If lblAddStockID.Text = "" Then
                MsgBox("Product ID Must Require", MsgBoxStyle.Critical)
                conn.Close()
            Else
                Dim currstock As Integer
                Dim quentity As Integer = txtAddProdStockQuantity.Text
                If quentity = 0 Then
                    MsgBox("You can Not Enter 0 Keyword")
                    Exit Sub
                End If
                Dim ans As Integer
                Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
                Dim cmd As MySqlCommand = New MySqlCommand("select Quantity from Product_Stock Where Product_Name = '" & cmbAddStockProdName.SelectedItem & "'")
                cmd.Connection = conn
                conn.Open()
                Dim rdr As MySqlDataReader = cmd.ExecuteReader
                While rdr.Read
                    currstock = (rdr("Quantity"))
                End While
                ans = currstock + quentity
                Dim con1 As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
                Dim cmd1 As MySqlCommand = New MySqlCommand("update Product_Stock set Quantity = '" & ans & "' Where Product_Name = '" & cmbAddStockProdName.SelectedItem & "'")
                cmd1.Connection = con1
                con1.Open()
                Dim r As Integer
                r = cmd1.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("Product Stock Record hass Been Updated !")
                    clearall()
                    getproductstock()
                Else
                    MsgBox("No Record has been Saved !")
                End If
                con1.Close()
                lblCurrentStock.Text = ans
                'MsgBox(ans)
                conn.Close()
            End If
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub AddProductStock()
        dgvqnt0.Rows.Clear()
        dgvqnt1to5.Rows.Clear()
        dgvqnt5.Rows.Clear()
        Try
            If lblAddStockID.Text = "" Then
                MsgBox("Id Must Require", MsgBoxStyle.Critical)
                conn.Close()
            Else
                Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
                Dim cmd As MySqlCommand = New MySqlCommand("insert into Product_Stock values ('" & lblAddStockID.Text & "', '" & dtpAddProdStockDate.Value.ToString("MM/dd/yyyy") & "','" & cmbAddProdCatStock.Text & "','" & cmbAddStockProdName.Text & "','" & txtAddProdStockQuantity.Text & "')")
                cmd.Connection = conn
                conn.Open()
                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("Product Stock Record hass been Saved!")
                    getproductstock()
                    clearall()

                Else
                    MsgBox("No record has been saved!")
                End If
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnAddProductStock_Click(sender As Object, e As EventArgs) Handles btnAddProductStock.Click
        getname()
        getid()
    End Sub

    Private Sub cmbAddStockProdName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAddStockProdName.SelectedIndexChanged
        getCurrQuantity()
    End Sub
    Private Sub clearall()
        cmbAddProdCatStock.Text = ""
        cmbAddStockProdName.Text = ""
        txtAddProdStockQuantity.Text = ""
        lblCurrentStock.Text = "-"
        lblAddStockID.Text = "-"
        dtpAddProdStockDate.Value = Date.Now
    End Sub
    Private Sub btnAddProdStockClear_Click(sender As Object, e As EventArgs) Handles btnAddProdStockClear.Click
        clearall()
    End Sub

    Private Sub txtAddProdStockQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddProdStockQuantity.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "0" AndAlso e.KeyChar <= "9")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Number!")
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
