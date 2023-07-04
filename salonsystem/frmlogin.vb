Imports System.Data.SqlClient
Public Class frmlogin
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

    End Sub
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        Dim cmd As SqlCommand = New SqlCommand("Select * from Login where [Username] = @uname and [password] = @pass")
        If txtusername.Text <> "" And txtpassword.Text <> "" Then

            cmd.Parameters.AddWithValue("uname", txtusername.Text)
            cmd.Parameters.AddWithValue("pass", txtpassword.Text)
            Dim user As String = ""
            Dim pass As String = ""
            cmd.Connection = con
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            If (rdr.Read() = True) Then
                user = rdr("username")
                pass = rdr("password")
                If txtusername.Text = user And txtpassword.Text = pass Then
                    main.lblusername.Text = user
                    main.Show()
                    Me.Hide()
                End If
            Else
                MsgBox("Login Un Successful")
            End If
        Else
            MsgBox("ERROR : Please Enter Valid Username or Password", MsgBoxStyle.Critical, "Harsh Ramwani")
        End If
        con.Close()
    End Sub

    Private Sub chkbxshowpass_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxshowpass.CheckedChanged
        If chkbxshowpass.Checked = True Then
            txtpassword.PasswordChar = ""
        End If
        If chkbxshowpass.Checked = False Then
            txtpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub btncancle_Click(sender As Object, e As EventArgs) Handles btncancle.Click
        Me.Close()
    End Sub
    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtusername.Text = ""
        txtpassword.Text = ""
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        frmForgotPassword.Show()
    End Sub
End Class
