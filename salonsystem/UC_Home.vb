Imports System.Data.SqlClient
Public Class UC_Home
    Dim ddmmyy As String
    Private Sub getYearlySales()
        Dim currDate As New Date
        currDate = DateTime.Now.ToString("dd/MM/yyyy")
        Dim yourYear As Integer
        yourYear = Year(currDate)
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select Bill_Date, Product_Quantity ,Product_Price from Product_Sales_Details")
        cmd.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd.ExecuteReader
        Dim total As Double = 0
        While rdr.Read
            Dim Rcds_date As String
            Rcds_date = rdr("Bill_Date").ToString()
            Dim lastindex As Integer
            lastindex = Rcds_date.LastIndexOf("-")
            Rcds_date = Rcds_date.Substring(lastindex + 1, 4)
            If Rcds_date = yourYear Then
                total = total + (rdr("Product_Price") * rdr("Product_Quantity"))
            End If
        End While
        lblYearlySalesReports.Text = total
    End Sub
    Private Sub getmonthlysales()
        Dim currDate As New Date
        currDate = DateTime.Now.ToString("dd/MM/yyyy")
        Dim yourMonth As Integer
        yourMonth = Month(currDate)
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select Bill_Date,Product_Price,Product_Quantity from Product_Sales_Details")
        cmd.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd.ExecuteReader
        Dim total As Double = 0
        While rdr.Read
            'lblMonthlySalesReports.Text = rdr("Total").ToString
            Dim Rcds_date As String
            Rcds_date = rdr("Bill_Date").ToString()
            Dim firstindex As Integer
            Dim lastindex As Integer
            firstindex = Rcds_date.IndexOf("-")
            lastindex = Rcds_date.LastIndexOf("-")
            Rcds_date = Rcds_date.Substring(firstindex + 1, (lastindex - (firstindex + 1)))
            If Rcds_date = yourMonth Then
                total = total + (rdr("Product_Price") * rdr("Product_Quantity"))
            End If
        End While
        lblMonthlySalesReports.Text = total
    End Sub
    Private Sub getweeklysales()
        Dim DateValue As New Date()
        Dim startdate As New Date()
        Dim Enddate As New Date()
        Dim total As Double = 0
        DateValue = DateTime.Now.ToString("dd/MM/yyyy")
        Dim diff As Integer
        diff = (Convert.ToInt32(DateValue.DayOfWeek))
        If (diff > 0) Then
            diff = diff * (-1)
        End If
        startdate = DateValue.AddDays(diff)
        'MsgBox(DateValue)
        Enddate = startdate.AddDays(6)
        'MsgBox(DateValue)
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select sum(Product_Price * Product Quantity) as Total from Product_Sales_Details where Bill_Date >= '" & startdate & "' and Bill_Date <= '" & Enddate & "'")
        cmd.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd.ExecuteReader
        While rdr.Read

            If Not IsDBNull(rdr("Total")) Then

                lblWeeklySalesReports.Text = rdr("Total")
            Else
                lblWeeklySalesReports.Text = "00"
            End If
        End While
    End Sub
    Private Sub getdailysales()
        ddmmyy = Date.Now.ToString("dd/MM/yyyy")
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select sum(Product_Price) as Total from Product_Sales_Details where Bill_Date = '" & ddmmyy & "'")
        Dim total As Double = 0
        cmd.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd.ExecuteReader
        While rdr.Read

            If Not IsDBNull(rdr("Total")) Then
                total = rdr("Total")
                lblDailySalesReport.Text = total
            Else
                lblDailySalesReport.Text = "0"
            End If

        End While
    End Sub
    Private Sub UC_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalcustomer()
        totalproducts()
        totalproductcategory()
        totalservices()
        totalsubservices()
        getdailysales()
        'getweeklysales()
        getmonthlysales()
        getYearlySales()
    End Sub
    Private Sub totalcustomer()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select count(*) from Customer ")
        cmd.Connection = con
        con.Open()
        Dim r As Integer
        r = cmd.ExecuteScalar
        lblTotalCusReports.Text = r
    End Sub
    Private Sub totalproducts()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select count(*) from Product")
        cmd.Connection = con
        con.Open()
        Dim r As Integer
        r = cmd.ExecuteScalar
        lblTotalProdReports.Text = r
    End Sub
    Private Sub totalproductcategory()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select count(*) from Product_Category")
        cmd.Connection = con
        con.Open()
        Dim r As Integer
        r = cmd.ExecuteScalar
        lblProdCatReports.Text = r
    End Sub
    Private Sub totalservices()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select count(*) from Services")
        cmd.Connection = con
        con.Open()
        Dim r As Integer
        r = cmd.ExecuteScalar
        lblTotServicesReports.Text = r
    End Sub
    Private Sub totalsubservices()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anomaly Enterprise\Projects\Windows App\.NET\salonsystem_2\salonsystem (2)\salonsystem\salonsystem\DataConnection.mdf;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select count(*) from Sub_Services")
        cmd.Connection = con
        con.Open()
        Dim r As Integer
        r = cmd.ExecuteScalar
        lblTotalSubServicesReports.Text = r
    End Sub
End Class
