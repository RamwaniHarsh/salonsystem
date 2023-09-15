Imports MySql.Data.MySqlClient
Public Class UC_UpdateEmplyee
    Dim isfound As Integer
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim ability As String = ""

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        getdata()
        gettop3Beardwork()
        gettop3Facialwork()
        gettop3hairwork()
        gettop3Massagework()
    End Sub
    Private Sub local()
        Try
            Dim gender As String
            If rdbuttonmale.Checked = True Then
                gender = "Male"
            Else
                gender = "Female"
            End If
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("Update Employee set First_Name='" & txtfname.Text & "',Last_Name='" & txtlname.Text & "',Gender = '" & gender & "',Date_of_Birth= '" & dtpDOB.Value.ToString("dd/MM/yyyy") & "',Mobile_Number = '" & txtmobile.Text & "',Ability = '" & ability & "',Address = '" & txtaddress.Text & "' where First_Name = '" & cmbname.SelectedItem & "'")
            cmd.Connection = conn
            conn.Open()

            Dim r As Integer
            r = cmd.ExecuteNonQuery()
            If r > 0 Then
                MsgBox("Employee Record hass Been Updated !")
                clearall()
                getId()

            Else
                MsgBox("No Record has been Saved !")
            End If
            conn.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub getId()
        cmbname.Items.Clear()

        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT First_Name from Employee order by First_Name")
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                cmbname.Items.Add(rdr("First_Name"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try

    End Sub
    Private Sub resetAllSelection()
        chkboxBeardAbility.Checked = False
        chkboxFacialAbility.Checked = False
        chkboxHairAbility.Checked = False
        chkboxMassageAbility.Checked = False
    End Sub
    Private Sub cmbname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbname.SelectedIndexChanged
        resetAllSelection()
        isfound = 1
        'disableall()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")


            Dim cmd As MySqlCommand = New MySqlCommand("select * from Employee where [First_Name] = @Name")
            cmd.Parameters.AddWithValue("Name", cmbname.Text)
            cmd.Connection = conn
            conn.Open()
            'disableall()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            Dim ability As String = ""
            If (rdr.Read() = True) Then
                txtfname.Text = rdr("First_Name")
                txtlname.Text = rdr("Last_Name")
                Dim gender As String
                gender = rdr("Gender")
                If gender = "Male" Then
                    rdbuttonmale.Checked = True
                Else
                    rdbuttonfemale.Checked = True
                End If
                dtpDOB.Value = rdr("Date_of_Birth")
                txtmobile.Text = rdr("Mobile_Number")
                ability = rdr("Ability")
                'MsgBox(ability)
                Dim cnt As Integer
                Dim first As String = ""
                Dim second As String = ""
                Dim third As String = ""
                Dim fourth As String = ""
                Dim Sep_index As Integer = 0
                cnt = CountCharacter(ability, ",")


                If cnt = 0 Then
                    first = ability
                    selectAbility(first)
                ElseIf cnt = 1 Then
                    Sep_index = ability.IndexOf(",")
                    first = ability.Substring(0, Sep_index)
                    selectAbility(first)
                    second = ability.Substring(Sep_index + 1, (ability.Length - (Sep_index + 1)))
                    selectAbility(second)
                ElseIf cnt = 2 Then
                    Sep_index = ability.IndexOf(",")
                    first = ability.Substring(0, Sep_index)
                    selectAbility(first)
                    second = ability.Substring(Sep_index + 1, (ability.LastIndexOf(",") - (Sep_index + 1)))
                    selectAbility(second)
                    third = ability.Substring(ability.LastIndexOf(",") + 1, (ability.Length - (ability.LastIndexOf(",") + 1)))
                    selectAbility(third)
                ElseIf cnt = 3 Then
                    Sep_index = ability.IndexOf(",")
                    first = ability.Substring(0, Sep_index)
                    selectAbility(first)
                    ability = ability.Substring(Sep_index + 1, (ability.Length - (Sep_index + 1)))
                    Sep_index = ability.IndexOf(",")
                    second = ability.Substring(0, Sep_index)
                    selectAbility(second)
                    third = ability.Substring(Sep_index + 1, (ability.LastIndexOf(",") - (Sep_index + 1)))
                    selectAbility(third)
                    fourth = ability.Substring(ability.LastIndexOf(",") + 1, (ability.Length - (ability.LastIndexOf(",") + 1)))
                    selectAbility(fourth)
                End If
                txtaddress.Text = rdr("Address")
                'enableall()
            Else
                ' disableall()
                MsgBox("ERROR : No Record Found ", MsgBoxStyle.Critical, "Milan Salon")
                isfound = 0
                cmbname.Focus()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub selectAbility(ByVal val As String)
        If val = "Hair" Then
            chkboxHairAbility.Checked = True
        ElseIf val = "Beard" Then
            chkboxBeardAbility.Checked = True
        ElseIf val = "Facial" Then
            chkboxFacialAbility.Checked = True
        ElseIf val = "Massage" Then
            chkboxMassageAbility.Checked = True
        End If
    End Sub
    Public Function CountCharacter(ByVal value As String, ByVal ch As Char) As Integer
        Dim cnt As Integer = 0
        For Each c As Char In value
            If c = ch Then
                cnt += 1
            End If
        Next
        Return cnt
    End Function
    Private Sub clearall()
        cmbname.Text = ""
        txtfname.Text = ""
        txtlname.Text = ""
        txtmobile.Text = ""
        txtaddress.Text = ""
        rdbuttonmale.Checked = False
        rdbuttonfemale.Checked = False
        dtpDOB.Value = Date.Now
        cmbname.Focus()
        chkboxBeardAbility.Checked = False
        chkboxFacialAbility.Checked = False
        chkboxHairAbility.Checked = False
        chkboxMassageAbility.Checked = False
    End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clearall()
    End Sub
    Private Sub getdata()
        Try
            Dim gender As String = ""
            If rdbuttonmale.Checked = True Then
                gender = "Male"
            Else
                gender = "Female"
            End If
            If txtfname.Text = "" Then
                MsgBox("First Name Must Require", MsgBoxStyle.Critical)
                txtfname.Focus()
                conn.Close()
            Else
                Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")

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

                Dim cmd As MySqlCommand = New MySqlCommand("Update Employee set First_Name='" & txtfname.Text & "',Last_Name='" & txtlname.Text & "',Gender = '" & gender & "',Date_of_Birth= '" & dtpDOB.Value.ToString("dd/MM/yyyy") & "',Mobile_Number = '" & txtmobile.Text & "',Ability = '" & ability & "',Address = '" & txtaddress.Text & "' where First_Name = '" & cmbname.SelectedItem & "'")
                cmd.Connection = conn
                conn.Open()
                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("Employee Record hass been Saved!")
                    getId()
                    getemployee()
                    clearall()

                Else
                    MsgBox("No record has been saved!")
                End If
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub getemployee()
        Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
        Dim cmd As MySqlCommand = New MySqlCommand("select count(*) from Employee ")
        cmd.Connection = conn
        conn.Open()
        Dim r As Integer
        r = cmd.ExecuteScalar
        lblTotalEmp.Text = r
    End Sub
    Private Sub gettop3hairwork()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT Top 3 First_Name from employee Where Ability like '%Hair%'")
            Dim count As Integer = 1
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
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
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub gettop3Facialwork()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT Top 3 First_Name from employee Where Ability like '%Facial%'")
            Dim count As Integer = 1
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
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
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub gettop3Beardwork()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT Top 3 First_Name from employee Where Ability like '%Beard%'")
            Dim count As Integer = 1
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
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
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub gettop3Massagework()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT Top 3 First_Name from employee Where Ability like '%Massage%'")
            Dim count As Integer = 1
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
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
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub UC_UpdateEmplyee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getId()
        getemployee()
        cmbname.Focus()
        gettop3Beardwork()
        gettop3Facialwork()
        gettop3hairwork()
        gettop3Massagework()
        'disableall()
    End Sub

    Private Sub txtfname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtlname.KeyPress, txtfname.KeyPress
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
