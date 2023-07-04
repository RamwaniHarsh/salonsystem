Imports System.Data.SqlClient
Public Class UC_UpdateProduct
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim isfound As Integer
    Private Sub cmbname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbproductname.SelectedIndexChanged
        isfound = 1
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("select * from Product where [Product_Name] = @Name")
            cmd.Parameters.AddWithValue("Name", cmbproductname.Text)
            cmd.Connection = con
            con.Open()
            'disableall()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            'getcategory()
            If (rdr.Read() = True) Then
                txtproductname.Text = rdr("Product_Name")
                cmbProductCategory.SelectedItem = rdr("Product_Category")
                txtprice.Text = rdr("Rate")
                txtdescription.Text = rdr("Description")
                'enablealrl()
            Else
                'disableall()
                ' MsgBox("ERROR : No Record Found ", MsgBoxStyle.Critical, "Milan Salon")
                isfound = 0
                cmbproductname.Focus()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub getname()
        cmbproductname.Items.Clear()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT * from Product order by Product_Name")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            cmbproductname.Items.Add(rdr("Product_Name"))
        End While
        cmbproductname.Text = ""
        cmbproductname.Enabled = True
    End Sub
    Private Sub getcategory()
        cmbProductCategory.Items.Clear()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT * from Product order by Product_Category")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            cmbProductCategory.Items.Add(rdr("Product_Category"))
        End While
        cmbProductCategory.Text = ""
        cmbProductCategory.Enabled = True
    End Sub
    Private Sub clearall()
        cmbproductname.SelectedIndex = -1
        cmbProductCategory.SelectedIndex = -1
        txtprice.Text = ""
        txtdescription.Text = ""
        txtproductname.Text = ""
    End Sub
    Private Sub updatedata()
        Try
            If txtproductname.Text = "" Or cmbProductCategory.SelectedItem = "" Or txtprice.Text = "" Then
                MsgBox("Product Name, Product Category or Price Must Require", MsgBoxStyle.Critical)
                txtproductname.Focus()
                con.Close()
            Else
                Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
                Dim cmd As SqlCommand = New SqlCommand("Update Product set Product_Name='" & txtproductname.Text & "',Product_Category='" & cmbProductCategory.SelectedItem & "',Rate = '" & txtprice.Text & "',Description = '" & txtdescription.Text & "' where Product_Name = '" & cmbproductname.SelectedItem & "'")
                cmd.Connection = con
                con.Open()

                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("Product Record hass Been Updated !")
                    clearall()
                Else
                    MsgBox("No Record has been Saved !")
                End If
                con.Close()
            End If
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        updatedata()
    End Sub

    Private Sub UC_UpdateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getcategory()
        getname()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clearall()
    End Sub

    Private Sub txtproductname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtproductname.KeyPress
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
