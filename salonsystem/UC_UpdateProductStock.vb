﻿Imports System.Data.SqlClient
Public Class UC_UpdateProductStock
    Dim isfound As Integer
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub cmbUpdaProdCatStock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUpdaProdCatStock.SelectedIndexChanged
        getProductName()
    End Sub
    Private Sub getProductName()
        cmbUpdaStockProdName.Items.Clear()

        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("SELECT Product_Name from Product_Stock where Product_Category = '" & cmbUpdaProdCatStock.SelectedItem & "'")
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            While rdr.Read
                cmbUpdaStockProdName.Items.Add(rdr("Product_Name"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub getCurrQuantity()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("SELECT Quantity from Product_Stock where Product_Name = '" & cmbUpdaStockProdName.SelectedItem & "'")
            Dim currStock As Integer
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            While rdr.Read
                currStock = (rdr("Quantity"))
                If currStock = 0 Then
                    lblUpdaCurrentStock.Text = "0"
                Else
                    lblUpdaCurrentStock.Text = currStock
                End If
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub getstockid()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("SELECT Stock_Id from Product_Stock Where Product_Name = '" & cmbUpdaStockProdName.SelectedItem & "'")
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            While rdr.Read
                lblUpdaStockID.Text = (rdr("Stock_Id"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub getProductCategoryStock()
        cmbUpdaProdCatStock.Items.Clear()

        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("SELECT Category_Name from Product_Category")
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            While rdr.Read
                cmbUpdaProdCatStock.Items.Add(rdr("Category_Name"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub UC_UpdateProductStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getProductCategoryStock()
        getproductstock()
    End Sub
    Private Sub getproductstock()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("SELECT Product_Name,Quantity from Product_Stock")
            Dim currStock As Integer
            Dim product_name As String
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
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
            con.Close()
        End Try
    End Sub
    Private Sub cmbUpdaStockProdName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUpdaStockProdName.SelectedIndexChanged
        getstockid()
        getCurrQuantity()
    End Sub
    Private Sub getdetails()
        Try
            If cmbUpdaProdCatStock.Text = "" Or cmbUpdaStockProdName.Text = "" Or txtUpdaProdStockQuantity.Text = "" Then
                MsgBox("Product Name, Product Category or Quantity Must Require", MsgBoxStyle.Critical)
                cmbUpdaStockProdName.Focus()
                con.Close()
            Else
                Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
                Dim cmd As SqlCommand = New SqlCommand("Update Product_Stock set date='" & dtpUpdaProdStockDate.Value.ToString("MM/dd/yyyy") & "',Product_Category='" & cmbUpdaProdCatStock.Text & "',Product_Name = '" & cmbUpdaStockProdName.Text & "',Quantity = '" & txtUpdaProdStockQuantity.Text & "' where Product_Name = '" & cmbUpdaStockProdName.Text & "'")
                cmd.Connection = con
                con.Open()

                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("Product Record hass Been Updated !")
                    'outcust()
                    clearall()
                    getProductCategoryStock()
                Else
                    MsgBox("No Record has been Saved !")
                End If
                con.Close()
            End If
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnUpdaProductStock_Click(sender As Object, e As EventArgs) Handles btnUpdaProductStock.Click
        getdetails()

    End Sub

    Private Sub txtUpdaProdStockQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUpdaProdStockQuantity.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "0" AndAlso e.KeyChar <= "9")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Number!")
        End If
    End Sub

    Private Sub txtViewUpdaCurStockSearchByProdName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtViewUpdaCurStockSearchByProdName.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "A" AndAlso e.KeyChar <= "z")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Character!")
        End If
    End Sub
    Private Sub clearall()
        dtpUpdaProdStockDate.Value = Date.Now
        cmbUpdaProdCatStock.SelectedIndex = -1
        cmbUpdaStockProdName.SelectedIndex = -1
        txtUpdaProdStockQuantity.Text = ""
        txtViewUpdaCurStockSearchByProdName.Text = ""
        lblUpdaCurrentStock.Text = "-"
    End Sub
    Private Sub btnUpdaProdStockClear_Click(sender As Object, e As EventArgs) Handles btnUpdaProdStockClear.Click
        clearall()
    End Sub
End Class
