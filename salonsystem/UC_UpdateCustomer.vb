Imports MySql.Data.MySqlClient
Public Class UC_UpdateCustomer
    Dim isfound As Integer
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim count As Integer
    Dim dtp As String
    Dim myAge As Integer
    Dim Agegroup1 As Integer = 0
    Dim Agegroup2 As Integer = 0
    Dim Agegroup3 As Integer = 0
    Dim percentage As Double = 0
    Dim arr_Date As String
    Dim month1_1 As Integer
    Dim month1 As Integer
    Dim month2 As Integer
    Dim month3 As Integer
    Dim month4 As Integer
    Dim month5 As Integer
    Dim month6 As Integer
    Dim month7 As Integer
    Dim month8 As Integer
    Dim month9 As Integer
    Dim month10 As Integer
    Dim month11 As Integer
    Dim month12 As Integer
    Private Sub getprogressbarvalue()
        percentage = month1 * 100 / count
        vpbJanuary.Value = percentage
        percentage = month2 * 100 / count
        vpbFebruary.Value = percentage
        percentage = month3 * 100 / count
        vpbMarch.Value = percentage
        percentage = month4 * 100 / count
        vpbApril.Value = percentage
        percentage = month5 * 100 / count
        vpbMay.Value = percentage
        percentage = month6 * 100 / count
        vpbJune.Value = percentage
        percentage = month7 * 100 / count
        vpbJuly.Value = percentage
        percentage = month8 * 100 / count
        vpbAugust.Value = percentage
        percentage = month9 * 100 / count
        vpbSeptember.Value = percentage
        percentage = month10 * 100 / count
        vpbOctober.Value = percentage
        percentage = month11 * 100 / count
        vpbNovember.Value = percentage
        percentage = month12 * 100 / count
        vpbDecember.Value = percentage
    End Sub
    Private Sub monthcustomerdetails()

        Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
        Dim cmd As MySqlCommand = New MySqlCommand("Select Arriving_Date from Customer")
        cmd.Connection = conn
        conn.Open()
        Dim rdr As MySqlDataReader = cmd.ExecuteReader

        While rdr.Read
            arr_Date = rdr("Arriving_Date")
            month1_1 = Month(arr_Date)
            If month1_1 = 1 Then
                month1 = month1 + 1
            ElseIf month1_1 = 2 Then
                month2 += 1
            ElseIf month1_1 = 3 Then
                month3 += 1
            ElseIf month1_1 = 4 Then
                month4 += 1
            ElseIf month1_1 = 5 Then
                month5 += 1
            ElseIf month1_1 = 6 Then
                month6 += 1
            ElseIf month1_1 = 7 Then
                month7 += 1
            ElseIf month1_1 = 8 Then
                month8 += 1
            ElseIf month1_1 = 9 Then
                month9 += 1
            ElseIf month1_1 = 10 Then
                month10 += 1
            ElseIf month1_1 = 11 Then
                month11 += 1
            ElseIf month1_1 = 12 Then
                month12 += 1
            End If

        End While
        getprogressbarvalue()
    End Sub
    Private Sub getcuurentage()
        Dim myCoolBirthday As Date = dtp '// selected value from DateTimePicker.
        Dim currentDate As Date = Today
        myAge = currentDate.Year - myCoolBirthday.Year
        If myAge >= 5 And myAge <= 20 Then
            Agegroup1 = Agegroup1 + 1
            calculateperforagegroup1()
        ElseIf myAge >= 21 And myAge <= 50 Then
            Agegroup2 = Agegroup2 + 1
            calculateperforagegroup2()
        ElseIf myAge >= 51 And myAge <= 70 Then
            Agegroup3 = Agegroup3 + 1
            calculateperforagegroup3()
        End If
    End Sub
    Private Sub getage()
        Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
        Dim cmd As MySqlCommand = New MySqlCommand("select Date_of_Birth from Customer")
        cmd.Connection = conn
        conn.Open()
        Dim rdr As MySqlDataReader = cmd.ExecuteReader
        While rdr.Read
            dtp = rdr("Date_of_Birth")
            getcuurentage()
        End While
    End Sub
    Private Sub calculateperforagegroup3()
        Dim pers As Integer
        pers = Agegroup3 * 100 / count
        pbAge51_70.Value = pers
    End Sub
    Private Sub calculateperforagegroup2()
        Dim pers As Integer
        pers = Agegroup2 * 100 / count
        pbAge21_50.Value = pers
    End Sub
    Private Sub calculateperforagegroup1()
        Dim pers As Integer
        pers = Agegroup1 * 100 / count
        pbAge5_20.Value = pers
    End Sub
    Private Sub cmbname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbname.SelectedIndexChanged
        isfound = 1
        disableall()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("select * from Customer where [First_Name] = @Name")
            cmd.Parameters.AddWithValue("Name", cmbname.Text)
            cmd.Connection = conn
            conn.Open()
            disableall()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader

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
                txtaddress.Text = rdr("Address")
                enableall()
            Else
                disableall()
                MsgBox("ERROR : No Record Found ", MsgBoxStyle.Critical, "Milan Salon")
                isfound = 0
                cmbname.Focus()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getdata()
        Try
            Dim gender As String
            If rdbuttonmale.Checked = True Then
                gender = "Male"
            Else
                gender = "Female"
            End If
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("Update Customer set First_Name='" & txtfname.Text & "',Last_Name='" & txtlname.Text & "',Gender = '" & gender & "',Date_of_Birth= '" & dtpDOB.Value.ToString("dd/MM/yyyy") & "',Mobile_Number = '" & txtmobile.Text & "',Address = '" & txtaddress.Text & "' where First_Name = '" & cmbname.SelectedItem & "'")
            cmd.Connection = conn
            conn.Open()
            Dim r As Integer
            r = cmd.ExecuteNonQuery()
            If r > 0 Then
                MsgBox("Customer Record hass Been Updated !")
                coutcust()
                countmalecust()
                countfemalecust()
                'getage()
                getprogressbarvalue()
                getcuurentage()
                'monthcustomerdetails()
                getId()
                clearall()
            Else
                MsgBox("No Record has been Saved !")
            End If
            conn.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        getdata()

    End Sub
    Private Sub coutcust()
        Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
        Dim cmd As MySqlCommand = New MySqlCommand("select count(*) from Customer ")
        cmd.Connection = conn
        conn.Open()
        Dim r As Integer
        r = cmd.ExecuteScalar
        lblTotalCustomers.Text = r
        count = r
    End Sub
    Private Sub countfemalecust()
        Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
        Dim cmd As MySqlCommand = New MySqlCommand("select count(gender) from Customer where Gender ='Female'")
        Dim per As Integer
        cmd.Connection = conn
        conn.Open()
        Dim b As Integer
        b = cmd.ExecuteScalar
        lblFemaleCustomers.Text = b
        per = b * 100 / count
        cpbFemaleCustomers.Value = per
    End Sub
    Private Sub countmalecust()
        Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
        Dim cmd As MySqlCommand = New MySqlCommand("select count(gender) from Customer where Gender ='Male'")
        Dim per As Integer
        cmd.Connection = conn
        conn.Open()
        Dim a As Integer
        a = cmd.ExecuteScalar
        lblMaleCustomers.Text = a
        per = a * 100 / count
        cpbMaleCustomers.Value = per
    End Sub
    Private Sub UC_UpdateCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getId()
        coutcust()
        countmalecust()
        countfemalecust()
        getage()
        monthcustomerdetails()
        cmbname.Focus()
        disableall()
    End Sub
    Private Sub getId()
        cmbname.Items.Clear()

        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT First_Name from Customer order by First_Name")
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
    Private Sub disableall()
        txtfname.Enabled = False
        txtlname.Enabled = False
        txtmobile.Enabled = False
        txtaddress.Enabled = False
        rdbuttonmale.Enabled = False
        rdbuttonfemale.Enabled = False
        dtpDOB.Enabled = False
    End Sub
    Private Sub enableall()
        txtfname.Enabled = True
        txtlname.Enabled = True
        txtmobile.Enabled = True
        txtaddress.Enabled = True
        rdbuttonmale.Enabled = True
        rdbuttonfemale.Enabled = True
        dtpDOB.Enabled = True
    End Sub
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
    End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        disableall()
        clearall()
    End Sub
    Private Sub getcurrage()
        Dim myCoolBirthday As Date = dtp '// selected value from DateTimePicker.
        Dim currentDate As Date = Today

        myAge = currentDate.Year - myCoolBirthday.Year
        If myAge >= 5 And myAge <= 20 Then
            Agegroup1 = Agegroup1 + 1
            'MsgBox("This is Age Group 1 : " & Agegroup1)
            'calculateperforagegroup1()
        ElseIf myAge >= 21 And myAge <= 50 Then
            Agegroup2 = Agegroup2 + 1
            ' MsgBox("This is Age Group 2 : " & Agegroup2)
        ElseIf myAge >= 51 And myAge <= 70 Then
            Agegroup3 = Agegroup3 + 1
            'MsgBox("This is Age Group 3 : " & Agegroup3)
        End If
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
