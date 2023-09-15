Imports MySql.Data.MySqlClient
Public Class UC_UpdateProductCategory
    Dim isfound As Integer
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        updatedata()
    End Sub
    Private Sub clearall()
        cmbIdProductCat.SelectedIndex = -1
        txtcatdesc.Text = ""
        txtcatname.Text = ""
    End Sub
    Private Sub updatedata()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("Update Product_Category set Category_Name='" & txtcatname.Text & "',Description='" & txtcatdesc.Text & "' where Category_Name = '" & cmbIdProductCat.SelectedItem & "'")
            cmd.Connection = conn
            conn.Open()

            Dim r As Integer
            r = cmd.ExecuteNonQuery()
            If r > 0 Then
                MsgBox("Product Category  Record hass Been Updated !")
                clearall()
            Else
                MsgBox("No Record has been Saved !")
            End If
            conn.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub getName()
        cmbIdProductCat.Items.Clear()

        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT Category_Name from Product_Category")
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                cmbIdProductCat.Items.Add(rdr("Category_Name"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try

    End Sub
    Private Sub UC_UpdateProductCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getName()
        cmbIdProductCat.Focus()
    End Sub

    Private Sub cmbIdProductCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIdProductCat.SelectedIndexChanged
        isfound = 1
        'disableall()

        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("select * from Product_Category where [Category_Name] = @name")
            cmd.Parameters.AddWithValue("name", cmbIdProductCat.Text)
            cmd.Connection = conn
            conn.Open()
            'disableall()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader

            If (rdr.Read() = True) Then
                txtcatname.Text = rdr("Category_Name")
                txtcatdesc.Text = rdr("Description")
            Else
                ' disableall()
                MsgBox("ERROR : No Record Found ", MsgBoxStyle.Critical, "Milan Salon")
                isfound = 0
                cmbIdProductCat.Focus()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clearall()
    End Sub

    Private Sub txtcatname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcatname.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "A" AndAlso e.KeyChar <= "z")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Character!")
        End If
    End Sub
End Class
