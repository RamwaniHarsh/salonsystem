Imports MySql.Data.MySqlClient
Public Class UC_NewCustomer
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
    Private Sub getcuurentage()
        Dim myCoolBirthday As Date = dtp
        Dim currentDate As Date = Today

        myAge = currentDate.Year - myCoolBirthday.Year
        If myAge >= 5 And myAge <= 20 Then
            Agegroup1 = Agegroup1 + 1
            calculateperforagegroup1()
        ElseIf myAge >= 21 And myAge <= 50 Then
            Agegroup2 = Agegroup2 + 1
            calculateperforagegroup2()
        ElseIf myAge >= 51 And myAge <= 100 Then
            Agegroup3 = Agegroup3 + 1
            calculateperforagegroup3()
        End If
        'calculateperforagegroup1()
        'calculateperforagegroup2()
        'calculateperforagegroup3()
        coutcust()
        countfemalecust()
        countmalecust()
    End Sub
    Private Sub getage()
        Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
        Dim cmd As MySqlCommand = New MySqlCommand("select Date_of_Birth from Customer")
        cmd.Connection = conn
        conn.Open()
        Dim rdr As MySqlDataReader = cmd.ExecuteReader
        While rdr.Read
            dtp = rdr("Date_of_Birth").ToString()
            getcuurentage()
        End While

    End Sub
    Private Sub calculateperforagegroup3()
        pbAge51_70.Value = 0
        Dim pers As Integer
        pers = Agegroup3 * 100 / count
        pbAge51_70.Value = pers
    End Sub
    Private Sub calculateperforagegroup2()
        pbAge21_50.Value = 0
        Dim pers As Integer
        pers = Agegroup2 * 100 / count
        pbAge21_50.Value = pers
    End Sub
    Private Sub calculateperforagegroup1()

        Dim pers As Integer
        pers = Agegroup1 * 100 / count
        pbAge5_20.Value = pers
    End Sub
    Private Sub addcustomer()
        Try
            Dim gender As String = ""
            If rdbuttonmale.Checked = True Then
                gender = "Male"
            Else
                gender = "Female"
            End If
            If txtID.Text = "" Or txtfname.Text = "" Then
                MsgBox("Id and First Name Must Require", MsgBoxStyle.Critical)
                txtfname.Focus()
                conn.Close()
            Else
                Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
                Dim cmd As MySqlCommand = New MySqlCommand("insert into customer values ('" & txtID.Text & "', '" & txtfname.Text & "','" & txtlname.Text & "','" & gender & "','" & dtpDOB.Value.ToString("dd/MM/yyyy") & "','" & Today.ToString("dd/MM/yyyy") & "','" & txtmobile.Text & "','" & txtaddress.Text & "')")
                cmd.Connection = conn
                conn.Open()
                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("Customer Record hass been Saved!")
                    coutcust()
                    countmalecust()
                    countfemalecust()
                    'getage()
                    getcuurentage()
                    getid()
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
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        addcustomer()
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
        Dim cmd As MySqlCommand = New MySqlCommand("select count(Gender) from Customer where Gender ='Female'")
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
        Dim cmd As MySqlCommand = New MySqlCommand("select count(Gender) from Customer where Gender ='Male'")
        Dim per As Integer
        cmd.Connection = conn
        conn.Open()
        Dim a As Integer
        a = cmd.ExecuteScalar
        lblMaleCustomers.Text = a
        per = a * 100 / count

        cpbMaleCustomers.Value = per
    End Sub
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
    Private Sub getid()
        Try
            conn.ConnectionString = "server=localhost;username=root;password=;database=salonsystem;port=3306"
            If conn.State = ConnectionState.Open Then
                conn.Close()

            End If

            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT MAX(Id) + 1 as Id From Customer", conn)
            txtID.Text = cmd.ExecuteScalar().ToString()
            If txtID.Text = "" Then
                txtID.Text = 1

            End If

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub UC_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getid()
        coutcust()
        countmalecust()
        countfemalecust()
        getage()
        monthcustomerdetails()
    End Sub
    Private Sub disableall()
        txtfname.Enabled = False
        txtlname.Enabled = False
        txtmobile.Enabled = False
        txtaddress.Enabled = False
        rdbuttonmale.Enabled = False
        rdbuttonfemale.Enabled = False
        'dtpDOB.Enabled = False
    End Sub
    Private Sub enableall()
        txtfname.Enabled = True
        txtlname.Enabled = True
        txtmobile.Enabled = True
        txtaddress.Enabled = True
        rdbuttonmale.Enabled = True
        rdbuttonfemale.Enabled = True
        ' dtpDOB.Enabled = True

    End Sub
    Private Sub clearall()
        txtfname.Text = ""
        txtlname.Text = ""
        txtmobile.Text = ""
        txtaddress.Text = ""
        rdbuttonmale.Checked = False
        rdbuttonfemale.Checked = False
        dtpDOB.Value = Date.Now
    End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        disableall()
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
