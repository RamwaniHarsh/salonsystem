﻿Imports System.Data.SqlClient
Public Class UC_ViewProductCategory
    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged
        Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True"
        Dim con As New SqlConnection(str)
        Dim com As String = "Select * from Product_Category where Category_Name like '" & txtname.Text & "%'"
        Dim Adpt As New SqlDataAdapter(com, con)
        Dim ds As New DataSet()
        Adpt.Fill(ds, "Product_Category")
        GunaDataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged
        Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True"
        Dim con As New SqlConnection(str)
        Dim com As String = "Select * from Product_Category where Id like '" & txtid.Text & "%'"
        Dim Adpt As New SqlDataAdapter(com, con)
        Dim ds As New DataSet()
        Adpt.Fill(ds, "Product_Category")
        GunaDataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "A" AndAlso e.KeyChar <= "z")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Character!")
        End If
    End Sub

    Private Sub txtid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtid.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "0" AndAlso e.KeyChar <= "9")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Number!")
        End If

    End Sub
End Class
