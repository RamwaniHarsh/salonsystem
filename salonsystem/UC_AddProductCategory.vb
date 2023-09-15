Imports MySql.Data.MySqlClient
Public Class UC_AddProductCategory
    Dim isfound As Integer
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        getdata()
    End Sub
    Private Sub getdata()
        Try
            If txtcatname.Text = "" Then
                MsgBox("Category Name Must Require", MsgBoxStyle.Critical)
                txtcatname.Focus()
                conn.Close()
            Else
                Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
                Dim cmd As MySqlCommand = New MySqlCommand("insert into Product_Category values ('" & lblid.Text & "', '" & txtcatname.Text & "','" & txtcatdesc.Text & "')")
                cmd.Connection = conn
                conn.Open()
                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("Product Category Record hass been Saved!")
                    clearall()
                    getID()

                Else
                    MsgBox("No record has been saved!")
                End If
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub getID()
        Try
            conn.ConnectionString = "server=localhost;username=root;password=;database=salonsystem;port=3306"
            If conn.State = ConnectionState.Open Then
                conn.Close()

            End If

            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT MAX(Id) + 1 as Id From Product_Category", conn)
            lblid.Text = cmd.ExecuteScalar().ToString()
            If lblid.Text = "" Then
                lblid.Text = 1
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub UC_AddProductCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getID()
    End Sub
    Private Sub clearall()
        txtcatdesc.Text = ""
        txtcatname.Text = ""
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        getID()
        txtcatdesc.Text = ""
        txtcatname.Text = ""
    End Sub

    Private Sub txtcatname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcatname.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "A" AndAlso e.KeyChar <= "z")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Character!")
        End If
    End Sub

End Class
