Imports System.Data.SqlClient
Public Class UC_AddProducts
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        getdata()
    End Sub
    Private Sub clearall()
        txtPrice.Text = ""
        txtDescription.Text = ""
        txtproductname.Text = ""
        cmbProductCat.SelectedIndex = -1
    End Sub
    Private Sub getdata()
        Try

            If txtproductname.Text = "" Or cmbProductCat.SelectedItem = "" Or txtPrice.Text = "" Then
                MsgBox("Product Name, Product Category, Price Must Require or Quantity", MsgBoxStyle.Critical)
                txtproductname.Focus()
                con.Close()
            Else
                Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
                Dim cmd As SqlCommand = New SqlCommand("insert into Product values ('" & lblid.Text & "', '" & txtproductname.Text & "','" & cmbProductCat.SelectedItem & "','" & txtPrice.Text & "','" & txtDescription.Text & "')")
                cmd.Connection = con
                con.Open()
                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("Product Record hass been Saved!")
                    getId()
                    clearall()
                Else
                    MsgBox("No record has been saved!")
                End If
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clearall()
    End Sub

    Private Sub UC_AddProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getId()
        getcategory()
        txtDescription.Enabled = False
        txtPrice.Enabled = False
    End Sub
    Private Sub getcategory()
        cmbProductCat.Items.Clear()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT * from Product_Category order by Category_Name")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            cmbProductCat.Items.Add(rdr("Category_Name"))
        End While
        cmbProductCat.Text = ""
        cmbProductCat.Enabled = True
    End Sub
    Private Sub getId()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("SELECT MAX(Id) + 1 as Id FROM product", con)
            lblid.Text = cmd.ExecuteScalar().ToString()
            If lblid.Text = "" Then
                lblid.Text = 1
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmbProductCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductCat.SelectedIndexChanged
        txtPrice.Enabled = True
        txtDescription.Enabled = True
    End Sub

    Private Sub txtproductname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtproductname.KeyPress
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
End Class
