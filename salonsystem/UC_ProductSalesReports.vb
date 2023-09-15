Imports MySql.Data.MySqlClient

Public Class UC_ProductSalesReports
    Dim billno As Integer
    Dim bill_date As String
    Dim Product_Category As String
    Dim Product_Name As String
    Dim Product_qnt As Integer
    Dim Product_Price As Integer
    Dim mobile As Double
    Dim total As Integer
    Private Sub btnCusProdBillReportSearch_Click(sender As Object, e As EventArgs) Handles btnCusProdBillReportSearch.Click
        getdata()
        getbill()
        AddtoGrid()
    End Sub
    'Private Sub lblReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblReset.Click
    '    resetAll()
    'End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.pnlCusProdReceipt.Width, Me.pnlCusProdReceipt.Height)
        pnlCusProdReceipt.DrawToBitmap(bm, New Rectangle(0, 0, Me.pnlCusProdReceipt.Width, Me.pnlCusProdReceipt.Height))
        e.Graphics.DrawImage(bm, 0, 0)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub
    Private Sub AddtoGrid()

        dgvprintReceipt.ColumnCount = 4
        For i = 0 To dgvCusServBillReport.Rows.Count - 1
            Dim rNum As Integer = dgvprintReceipt.Rows.Add
            dgvprintReceipt.Rows.Item(rNum).Cells(0).Value = dgvCusServBillReport.Item(0, i).Value.ToString()
            dgvprintReceipt.Rows.Item(rNum).Cells(1).Value = dgvCusServBillReport.Item(2, i).Value.ToString()
            dgvprintReceipt.Rows.Item(rNum).Cells(2).Value = dgvCusServBillReport.Item(3, i).Value.ToString()
            dgvprintReceipt.Rows.Item(rNum).Cells(3).Value = dgvCusServBillReport.Item(4, i).Value.ToString()
        Next

        GridSettings()
        calc()

        'Reset all Controls - After
    End Sub
    Private Sub calc()
        Dim total As Integer = 0
        Dim qty As Integer = 0
        For index As Integer = 0 To dgvprintReceipt.RowCount - 1
            qty += Convert.ToDouble(dgvprintReceipt.Rows(index).Cells(1).Value.ToString())
        Next
        lblProdReceiptQuantity.Text = qty.ToString()
        For index As Integer = 0 To dgvprintReceipt.RowCount - 1
            total += Convert.ToDouble(dgvprintReceipt.Rows(index).Cells(3).Value.ToString())
        Next
        lblProdReceiptTotalRs.Text = total.ToString()
    End Sub
    Private Sub GridSettings()
        dgvprintReceipt.ScrollBars = ScrollBars.None
        dgvprintReceipt.RowHeadersVisible = False
        dgvprintReceipt.ColumnCount = 4
        dgvprintReceipt.Columns(0).HeaderText = "Name"
        dgvprintReceipt.Columns(1).HeaderText = "Quantity"
        dgvprintReceipt.Columns(2).HeaderText = "Rate"
        dgvprintReceipt.Columns(3).HeaderText = "Total"
        dgvprintReceipt.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvprintReceipt.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvprintReceipt.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvprintReceipt.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgvprintReceipt.Columns(1).Width = 80
        dgvprintReceipt.Columns(2).Width = 80
        dgvprintReceipt.Columns(3).Width = 80
    End Sub
    Private Sub getbill()
        Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
        Dim cmd As MySqlCommand = New MySqlCommand("SELECT Customer_Name, Mobile_Number from Product_Sales_Master Where Bill_No = '" & txtCusProdReportBillNo.Text & "'")
        cmd.Connection = conn
        conn.Open()
        Dim rdr As MySqlDataReader = cmd.ExecuteReader
        While rdr.Read
            lblProdReceiptBillDate.Text = bill_date
            lblProdReceiptBillNo.Text = billno
            mobile = rdr("Mobile_Number")
            lblProdReceiptCusMob.Text = mobile
            lblProdReceiptCusName.Text = rdr("Customer_Name")
        End While
        gettotalamt()
        gettotalqnt()
    End Sub
    Private Sub gettotalamt()
        Dim sum As Integer = 0
        For i As Integer = 0 To dgvCusServBillReport.Rows.Count() - 1 Step +1
            sum = sum + dgvCusServBillReport.Rows(i).Cells(3).Value
        Next
        lblProdReceiptTotalRs.Text = sum.ToString()
    End Sub
    Private Sub gettotalqnt()
        Dim sum As Integer = 0
        For i As Integer = 0 To dgvCusServBillReport.Rows.Count() - 1 Step +1
            sum = sum + dgvCusServBillReport.Rows(i).Cells(2).Value
        Next
        lblProdReceiptQuantity.Text = sum.ToString()
    End Sub
    Private Sub getdata()
        dgvCusServBillReport.Rows.Clear()

        Try
            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT * from Product_Sales_Details Where Bill_No = '" & txtCusProdReportBillNo.Text & "'")
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                billno = rdr("Bill_No")
                bill_date = rdr("Bill_Date")
                Product_Category = rdr("Product_Category")
                Product_Name = rdr("Product_Name")
                Product_qnt = rdr("Product_Quantity")
                Product_Price = rdr("Product_Price")
                total = Product_qnt * Product_Price
                dgvCusServBillReport.Rows.Add(Product_Category, Product_Name, Product_qnt, Product_Price, total)
            End While

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub txtCusProdReportBillNo_TextChanged(sender As Object, e As EventArgs) Handles txtCusProdReportBillNo.TextChanged
        getcustomerdetails()

    End Sub
    Private Sub getcustomerdetails()

        Try

            Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT * from Product_Sales_Master Where Bill_No = '" & txtCusProdReportBillNo.Text & "'")
            cmd.Connection = conn
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                lblCusProdBillCusMobile.Text = rdr("Mobile_Number")
                lblCusProdReportBillDate.Text = rdr("Bill_Date")
                lblCusProdBillCusAddress.Text = rdr("Customer_Address")
                lblCusProdBillCusName.Text = rdr("Customer_Name")
            End While

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub txtCusProdReportBillNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCusProdReportBillNo.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "0" AndAlso e.KeyChar <= "9")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Number!")
        End If
    End Sub

    Private Sub btnPrintProdReceipt_Click(sender As Object, e As EventArgs) Handles btnPrintProdReceipt.Click
        PrintDocument1.PrinterSettings.PrinterName = My.Settings.printer
        PrintDocument1.Print()
    End Sub

End Class
