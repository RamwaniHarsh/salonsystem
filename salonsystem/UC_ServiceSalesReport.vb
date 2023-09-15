Imports MySql.Data.MySqlClient
Public Class UC_ServiceSalesReport
    Dim billno As Integer
    Dim bill_date As String
    Dim Service_Name As String
    Dim Sub_Service_Name As String
    Dim Employee_Name As String
    Dim No_of_Person As Integer
    Dim Amount As Integer
    Dim mobile As Double
    Dim address As String
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.pnlCusProdReceipt.Width, Me.pnlCusProdReceipt.Height)
        pnlCusProdReceipt.DrawToBitmap(bm, New Rectangle(0, 0, Me.pnlCusProdReceipt.Width, Me.pnlCusProdReceipt.Height))
        e.Graphics.DrawImage(bm, 0, 0)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub
    Private Sub getaddrees()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT Address from Customer Where Mobile_Number = '" & mobile & "'")
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                address = rdr("Address")
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub txtCusServReportBillNo_TextChanged(sender As Object, e As EventArgs) Handles txtCusServReportBillNo.TextChanged
        getcustomerdetails()
        dgvCusServBillReport.Rows.Clear()
    End Sub
    Private Sub getcustomerdetails()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT * from Service_Sales_Master Where Bill_No = '" & txtCusServReportBillNo.Text & "'")
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                getaddrees()
                lblCusServBillCusName.Text = rdr("Customer_Name")
                lblCusServBillCusMobile.Text = rdr("Mobile_Number")
                lblCusServReportBillDate.Text = rdr("Bill_Date")
                lblCusServBillCusAddress.Text = rdr("Customer_Address")

            End While

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub getbill()
        Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
        Dim cmd As MySqlCommand = New MySqlCommand("SELECT Customer_Name, Mobile_Number from Service_Sales_Master Where Bill_No = '" & txtCusServReportBillNo.Text & "'")
        cmd.Connection = conn
        conn.Open()
        Dim rdr As MySqlDataReader = cmd.ExecuteReader
        While rdr.Read
            lblServReceiptBillDate.Text = bill_date
            lblServReceiptBillNo.Text = billno
            mobile = rdr("Mobile_Number")
            lblServReceiptCusMob.Text = mobile
            lblServReceiptCusName.Text = rdr("Customer_Name")
        End While
        gettotalamt()
        gettotalqnt()
    End Sub
    Private Sub gettotalamt()
        Dim sum As Integer = 0
        For i As Integer = 0 To dgvCusServBillReport.Rows.Count() - 1 Step +1
            sum = sum + dgvCusServBillReport.Rows(i).Cells(5).Value
        Next
        lblServReceiptTotalRs.Text = sum.ToString()
    End Sub
    Private Sub gettotalqnt()
        Dim sum As Integer = 0
        For i As Integer = 0 To dgvCusServBillReport.Rows.Count() - 1 Step +1
            sum = sum + dgvCusServBillReport.Rows(i).Cells(3).Value
        Next
        lblServReceiptQuantity.Text = sum.ToString()
    End Sub
    Private Sub getdata()
        dgvCusServBillReport.Rows.Clear()
        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT * from Service_Sales_Details Where Bill_No = '" & txtCusServReportBillNo.Text & "'")
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                billno = rdr("Bill_No")
                bill_date = rdr("Bill_Date")
                Service_Name = rdr("Service_Name")
                Sub_Service_Name = rdr("Sub_Service_Name")
                Employee_Name = rdr("Employee_Name")
                No_of_Person = rdr("No_of_Person")
                Amount = rdr("Rate")

                dgvCusServBillReport.Rows.Add(Service_Name, Sub_Service_Name, Employee_Name, No_of_Person, Amount, No_of_Person * Amount)
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub btnCusServBillReportSearch_Click(sender As Object, e As EventArgs) Handles btnCusServBillReportSearch.Click
        getdata()
        getbill()
        AddtoGrid()
    End Sub
    Private Sub AddtoGrid()

        dgvprintReceipt.ColumnCount = 4
        For i = 0 To dgvCusServBillReport.Rows.Count - 1
            Dim rNum As Integer = dgvprintReceipt.Rows.Add
            dgvprintReceipt.Rows.Item(rNum).Cells(0).Value = dgvCusServBillReport.Item(0, i).Value.ToString()
            dgvprintReceipt.Rows.Item(rNum).Cells(1).Value = dgvCusServBillReport.Item(3, i).Value.ToString()
            dgvprintReceipt.Rows.Item(rNum).Cells(2).Value = dgvCusServBillReport.Item(4, i).Value.ToString()
            dgvprintReceipt.Rows.Item(rNum).Cells(3).Value = dgvCusServBillReport.Item(5, i).Value.ToString()
        Next

        GridSettings()
        'calc()

        'Reset all Controls - After
    End Sub
    Private Sub calc()
        Dim total As Integer = 0
        Dim qty As Integer = 0
        For index As Integer = 0 To dgvprintReceipt.RowCount - 1
            qty += Convert.ToDouble(dgvprintReceipt.Rows(index).Cells(1).Value.ToString())
        Next
        lblServReceiptQuantity.Text = qty.ToString()
        For index As Integer = 0 To dgvprintReceipt.RowCount - 1
            total += Convert.ToDouble(dgvprintReceipt.Rows(index).Cells(3).Value.ToString())
        Next
        lblServReceiptTotalRs.Text = total.ToString()
    End Sub
    Private Sub GridSettings()
        dgvprintReceipt.ScrollBars = ScrollBars.None
        dgvprintReceipt.RowHeadersVisible = False
        dgvprintReceipt.ColumnCount = 4
        dgvprintReceipt.Columns(0).HeaderText = "Service Name"
        dgvprintReceipt.Columns(1).HeaderText = "Number of Person"
        dgvprintReceipt.Columns(2).HeaderText = "Rate"
        dgvprintReceipt.Columns(3).HeaderText = "Total"
        dgvprintReceipt.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvprintReceipt.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvprintReceipt.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvprintReceipt.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgvprintReceipt.Columns(1).Width = 80
        dgvprintReceipt.Columns(2).Width = 80
        dgvprintReceipt.Columns(3).Width = 80
    End Sub
    Private Sub UC_ServiceSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtCusServReportBillNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCusServReportBillNo.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "0" AndAlso e.KeyChar <= "9")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Number!")
        End If
    End Sub

    Private Sub btnPrintServReceipt_Click(sender As Object, e As EventArgs) Handles btnPrintServReceipt.Click
        PrintDocument1.PrinterSettings.PrinterName = My.Settings.printer
        PrintDocument1.Print()
    End Sub
End Class
