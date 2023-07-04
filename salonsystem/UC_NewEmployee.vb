Imports System.Data.SqlClient
Public Class UC_NewEmployee

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        getdata()
    End Sub
    Private Sub getdata()
        Try
            Dim gender As String = ""
            If rdbuttonmale.Checked = True Then
                gender = "Male"
            Else
                gender = "Female"
            End If
            If lblid.Text = "" Or txtfname.Text = "" Then
                MsgBox("Id and First Name Must Require", MsgBoxStyle.Critical)
                txtfname.Focus()
                con.Close()
            Else
                Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
                Dim ability As String = ""
                If chkboxHairAbility.Checked = True Then
                    ability = ability & "Hair"
                End If

                If chkboxBeardAbility.Checked = True Then
                    If ability <> "" Then
                        ability = ability & ",Beard"
                    Else
                        ability = ability & "Beard"
                    End If
                End If
                If chkboxFacialAbility.Checked = True Then
                    If ability <> "" Then
                        ability = ability & ",Facial"
                    Else
                        ability = ability & "Facial"
                    End If
                End If
                If chkboxMassageAbility.Checked = True Then
                    If ability <> "" Then
                        ability = ability & ",Massage"
                    Else
                        ability = ability & "Massage"
                    End If
                End If

                Dim cmd As SqlCommand = New SqlCommand("insert into employee values ('" & lblid.Text & "','" & txtfname.Text & "','" & txtlname.Text & "','" & gender & "','" & dtpDOB.Value.ToString("dd/MM/yyyy") & "','" & txtmobile.Text & "','" & ability & "','" & txtaddress.Text & " ')")
                cmd.Connection = con
                con.Open()
                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("Employee Record hass been Saved!")
                    getid()
                    getemployee()

                    gettop3hairwork()
                    gettop3Beardwork()
                    gettop3Facialwork()
                    gettop3Massagework()
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
    Private Sub getemployee()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select count(*) from Employee ")
        cmd.Connection = con
        con.Open()
        Dim r As Integer
        r = cmd.ExecuteScalar
        lblTotalEmp.Text = r
    End Sub
    Private Sub getid()
        Try
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True"
            If con.State = ConnectionState.Open Then
                con.Close()

            End If

            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("SELECT MAX(Id) + 1 as Id From Employee", con)
            lblid.Text = cmd.ExecuteScalar().ToString()
            If lblid.Text = "" Then
                lblid.Text = 1
            End If
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub gettop3hairwork()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("SELECT Top 3 First_Name from employee Where Ability like '%Hair%'")
            Dim count As Integer = 1
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            While (rdr.Read() And count <= 3)
                If count = 1 Then
                    lblhairdressingtop1.Text = rdr("First_Name")
                ElseIf count = 2 Then
                    lblhairdressingtop2.Text = rdr("First_Name")
                ElseIf count = 3 Then
                    lblhairdressingtop3.Text = rdr("First_Name")
                End If
                count = count + 1
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub gettop3Facialwork()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("SELECT Top 3 First_Name from employee Where Ability like '%Facial%'")
            Dim count As Integer = 1
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            While (rdr.Read() And count <= 3)
                If count = 1 Then
                    lblFacialtop1.Text = rdr("First_Name")
                ElseIf count = 2 Then
                    lblFacialtop2.Text = rdr("First_Name")
                ElseIf count = 3 Then
                    lblFacialtop3.Text = rdr("First_Name")
                End If
                count = count + 1
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub gettop3Beardwork()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("SELECT Top 3 First_Name from employee Where Ability like '%Beard%'")
            Dim count As Integer = 1
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            While (rdr.Read() And count <= 3)
                If count = 1 Then
                    lblbeardworktop1.Text = rdr("First_Name")
                ElseIf count = 2 Then
                    lblbeardworktop2.Text = rdr("First_Name")
                ElseIf count = 3 Then
                    lblbeardworktop3.Text = rdr("First_Name")
                End If
                count = count + 1
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub gettop3Massagework()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("SELECT Top 3 First_Name from employee Where Ability like '%Massage%'")
            Dim count As Integer = 1
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            While (rdr.Read() And count <= 3)
                If count = 1 Then
                    lblMassagetop1.Text = rdr("First_Name")
                ElseIf count = 2 Then
                    lblMassagetop2.Text = rdr("First_Name")
                ElseIf count = 3 Then
                    lblMassagetop3.Text = rdr("First_Name")
                End If
                count = count + 1
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub test()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("Select First_Name , COUNT(id) as CUST_COUNT from Employee group by (First_Name) ORDER BY CUST_COUNT DESC", con)
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Dim count As Integer = 1
            While (rdr.Read() And count <= 3)
                If count = 1 Then
                    lblhairdressingtop1.Text = rdr("First_Name")
                ElseIf count = 2 Then
                    lblhairdressingtop2.Text = rdr("First_Name")
                Else
                    lblhairdressingtop3.Text = rdr("First_Name")
                End If
                count = count + 1
            End While

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub UC_NewEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getemployee()
        getid()
        gettop3hairwork()
        gettop3Beardwork()
        gettop3Facialwork()
        gettop3Massagework()
        'test()
    End Sub
    Private Sub clearall()
        txtfname.Text = ""
        txtlname.Text = ""
        txtmobile.Text = ""
        txtaddress.Text = ""
        rdbuttonmale.Checked = False
        rdbuttonfemale.Checked = False
        dtpDOB.Value = Date.Now
        chkboxBeardAbility.Checked = False
        chkboxFacialAbility.Checked = False
        chkboxHairAbility.Checked = False
        chkboxMassageAbility.Checked = False
    End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clearall()
    End Sub
    Private Sub txtlname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtlname.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "A" AndAlso e.KeyChar <= "z")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Character!")
        End If
    End Sub
    Private Sub txtfname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfname.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "A" AndAlso e.KeyChar <= "z")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Character!")
        End If
    End Sub

    Private Sub txtmobile_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmobile.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "0" AndAlso e.KeyChar <= "9")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Number!")
        End If
    End Sub
End Class
