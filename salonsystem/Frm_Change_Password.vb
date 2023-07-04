Imports System.Data.SqlClient
Public Class Frm_Change_Password
    Dim isfound As Integer
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim count As Integer
    Dim question As String
    Dim ans As String
    Dim username As String
    Dim usrname As String
    Dim Answer As String
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If txtnewpassword.Text = txtconfirmpassword.Text Then
            updatepassword()
        Else
            MsgBox("Your Password is Not Matched", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub getShowPassword()
        If chkshowpassword.Checked = True Then
            txtconfirmpassword.PasswordChar = ""
            txtnewpassword.PasswordChar = ""
        Else
            txtnewpassword.PasswordChar = "*"
            txtconfirmpassword.PasswordChar = "*"
        End If
    End Sub
    Private Sub enable()
        txtsecurityans.Enabled = True
        txtnewpassword.Enabled = True
        txtconfirmpassword.Enabled = True
        cmbsecurityq.Enabled = True
    End Sub
    Private Sub disable()
        txtsecurityans.Enabled = False
        txtnewpassword.Enabled = False
        txtconfirmpassword.Enabled = False
        cmbsecurityq.Enabled = False
    End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Me.Hide()
        frmlogin.Show()
    End Sub

    Private Sub chkshowpassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkshowpassword.CheckedChanged
        getShowPassword()
    End Sub

    Private Sub Frm_Change_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disable()
    End Sub

    Private Sub txtusername_Leave(sender As Object, e As EventArgs) Handles txtusername.Leave
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("select Username from Login where Username = '" & txtusername.Text & "'")
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader

            If (rdr.Read() = True) Then
                usrname = rdr("Username")
                enable()
                getdata()
            Else
                MsgBox("ERROR : No Record Found ", MsgBoxStyle.Critical, "Milan Salon")
                isfound = 0
                cmbsecurityq.Focus()
                disable()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub updatepassword()
        Try
            If txtconfirmpassword.Text = txtnewpassword.Text Then
                Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
                Dim cmd As SqlCommand = New SqlCommand("UPDATE Login Set Password = '" & txtconfirmpassword.Text & "' where Username ='" & txtusername.Text & "'")
                cmd.Connection = con
                con.Open()
                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("Paasword Changed Successfully !")
                Else
                    MsgBox("Password is Not Changed !")
                End If
                con.Close()
            Else
                MsgBox("Password MustBe Same", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub getdata()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("select Question from Login where Username = '" & txtusername.Text & "'")
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader

            If (rdr.Read() = True) Then
                If txtusername.Text = usrname Then
                    cmbsecurityq.Items.Add(rdr("Question"))
                End If

            Else
                MsgBox("ERROR : No Record Found ", MsgBoxStyle.Critical, "Milan Salon")
                isfound = 0
                cmbsecurityq.Focus()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtsecurityans_Leave(sender As Object, e As EventArgs) Handles txtsecurityans.Leave
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("select Answer from Login where Question = '" & cmbsecurityq.Text & "'")
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader

            If (rdr.Read() = True) Then
                Answer = rdr("Answer")
                If Answer = txtsecurityans.Text Then
                    'MsgBox("Your Answer is Correct")
                    txtnewpassword.Enabled = True
                    txtconfirmpassword.Enabled = True
                Else
                    MsgBox("Yor Answer Is Incorrect")
                End If
            Else
                MsgBox("ERROR : No Record Found ", MsgBoxStyle.Critical, "Milan Salon")
                isfound = 0
                cmbsecurityq.Focus()
                disable()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Close()
        main.Show()
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub cmbsecurityq_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsecurityq.SelectedIndexChanged

    End Sub

    Private Sub txtsecurityans_TextChanged(sender As Object, e As EventArgs) Handles txtsecurityans.TextChanged

    End Sub

    Private Sub txtnewpassword_TextChanged(sender As Object, e As EventArgs) Handles txtnewpassword.TextChanged

    End Sub
End Class