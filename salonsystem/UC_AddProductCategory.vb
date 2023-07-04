Imports System.Data.SqlClient
Public Class UC_AddProductCategory
    Dim isfound As Integer
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        getdata()
    End Sub
    Private Sub getdata()
        Try
            If txtcatname.Text = "" Then
                MsgBox("Category Name Must Require", MsgBoxStyle.Critical)
                txtcatname.Focus()
                con.Close()
            Else
                Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
                Dim cmd As SqlCommand = New SqlCommand("insert into Product_Category values ('" & lblid.Text & "', '" & txtcatname.Text & "','" & txtcatdesc.Text & "')")
                cmd.Connection = con
                con.Open()
                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("Product Category Record hass been Saved!")
                    clearall()
                    getID()

                Else
                    MsgBox("No record has been saved!")
                End If
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub getID()
        Try
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True"
            If con.State = ConnectionState.Open Then
                con.Close()

            End If

            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("SELECT MAX(Id) + 1 as Id From Product_Category", con)
            lblid.Text = cmd.ExecuteScalar().ToString()
            If lblid.Text = "" Then
                lblid.Text = 1
            End If
            con.Close()
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

    Private Sub txtcatname_TextChanged(sender As Object, e As EventArgs) Handles txtcatname.TextChanged

    End Sub

    Private Sub txtcatname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcatname.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "A" AndAlso e.KeyChar <= "z")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Character!")
        End If
    End Sub
    Private Sub txtcatdesc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcatdesc.KeyPress

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
