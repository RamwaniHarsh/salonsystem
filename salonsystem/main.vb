Imports MySql.Data.MySqlClient
Public Class main
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
    Private Sub closeusersetting()
        pnlusersettings.Height = 35
    End Sub
    Private Sub closeStocks()
        PnlStocks.Height = 35
    End Sub
    Private Sub openStocks()

        PnlStocks.Height = 132
    End Sub
    Private Sub closeSMS()
        pnlsms.Height = 35
    End Sub
    Private Sub openSMS()

        pnlsms.Height = 68
    End Sub
    Private Sub closeReports()
        pnlReports.Height = 35
    End Sub
    Private Sub openReports()

        pnlReports.Height = 105
    End Sub
    Private Sub closeEmployee()
        pnlEmployee.Height = 35
    End Sub
    Private Sub openEmployee()

        pnlEmployee.Height = 133
    End Sub
    Private Sub openusersettings()
        pnlusersettings.Height = 135
    End Sub
    Private Sub closeusersettings()
        pnlusersettings.Height = 35
    End Sub
    Private Sub opensales()
        pnlSales.Height = 100
    End Sub
    Private Sub closesales()
        pnlSales.Height = 35
    End Sub
    Private Sub closeProductCategory()
        pnlproductcat.Height = 35
    End Sub
    Private Sub openProductCategory()

        pnlproductcat.Height = 133
    End Sub
    Private Sub closeProduct()
        pnlProducts.Height = 35
    End Sub
    Private Sub openProduct()

        pnlProducts.Height = 133
    End Sub
    Private Sub closeServices()
        pnlservices.Height = 35
    End Sub
    Private Sub openServices()

        pnlservices.Height = 133
    End Sub
    Private Sub closeSubServices()
        pnlSubServices.Height = 35
    End Sub
    Private Sub openSubServices()

        pnlSubServices.Height = 133
    End Sub
    Private Sub closecustomer()
        pnlcustomer.Height = 35
    End Sub

    Private Sub opencustomer()
        pnlcustomer.Height = 133
    End Sub
    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Close()
        frmlogin.Show()
        frmlogin.txtusername.Text = ""
        frmlogin.txtpassword.Text = ""
        frmlogin.txtusername.Focus()
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        opencustomer()
        closeEmployee()
        closeProduct()
        closeProductCategory()
        closeServices()
        closeSubServices()
        closeReports()
        closesales()
        closeSMS()
        closeusersettings()
        closeStocks()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim uc As New UC_Home
        addhomeusercontrol(uc)
        If conn.State = ConnectionState.Open Then
            conn.Close()
        Else
            conn.Open()
        End If
        lblcurrdate.Text = Date.Now.ToString("dd/MM/yyyy")
        currtime.Enabled = True
    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles btnaddcustomer.Click
        Dim uc As New UC_NewCustomer
        addusercontrol(uc)
        closecustomer()

    End Sub
    Private Sub addhomeusercontrol(ByVal uc As UC_Home)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub addusercontrol(ByVal uc As UC_NewCustomer)

        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)

    End Sub
    Private Sub viewusercontrol(ByVal uc As UC_ViewCustomer)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)

    End Sub
    Private Sub updateusercontrol(ByVal uc As UC_UpdateCustomer)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub addproductcategory(ByVal uc As UC_AddProductCategory)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub

    Private Sub btnupdatecustomer_Click(sender As Object, e As EventArgs) Handles btnupdatecustomer.Click
        Dim uc As New UC_UpdateCustomer
        updateusercontrol(uc)
        closecustomer()
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        openEmployee()
        closecustomer()
        closeProduct()
        closeProductCategory()
        closeServices()
        closeSubServices()
        closeReports()
        closesales()
        closeSMS()
        closeusersettings()
        closeStocks()
    End Sub
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim uc As New UC_Home
        addhomeusercontrol(uc)
        closecustomer()
        closeEmployee()
        closeProduct()
        closeProductCategory()
        closeServices()
        closeSubServices()
        closeReports()
        closesales()
        closeSMS()
        closeusersettings()
        closeStocks()
    End Sub

    Private Sub btnshowcustomer_Click(sender As Object, e As EventArgs) Handles btnshowcustomer.Click
        Dim uc As New UC_ViewCustomer
        viewusercontrol(uc)
        closecustomer()
    End Sub
    Private Sub addemployeeusercontrol(ByVal uc As UC_NewEmployee)

        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub updateemployeeusercontrol(ByVal uc As UC_UpdateEmplyee)

        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub btnaddemployee_Click(sender As Object, e As EventArgs) Handles btnaddemployee.Click
        Dim uc As New UC_NewEmployee
        addemployeeusercontrol(uc)
        closeEmployee()
    End Sub

    Private Sub btnupdateemployee_click(sender As Object, e As EventArgs) Handles btnupdateemployee.Click
        Dim uc As New UC_UpdateEmplyee
        updateemployeeusercontrol(uc)
        closeEmployee()
    End Sub
    Private Sub viewemployeeusercontrol(ByVal uc As UC_ViewEmployee)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub

    Private Sub btnviewemployee_Click(sender As Object, e As EventArgs) Handles btnviewemployee.Click
        Dim uc As New UC_ViewEmployee
        viewemployeeusercontrol(uc)
        closeEmployee()
    End Sub

    Private Sub btnaddproductcat_Click(sender As Object, e As EventArgs) Handles btnaddproductcat.Click
        Dim uc As New UC_AddProductCategory
        addproductcategory(uc)
        closeProductCategory()
    End Sub

    Private Sub btnproductcat_Click(sender As Object, e As EventArgs) Handles btnproductcat.Click
        openProductCategory()
        closeServices()
        closecustomer()
        closeEmployee()
        closeProduct()
        closeSubServices()
        closeReports()
        closesales()
        closeSMS()
        closeusersettings()
        closeStocks()
    End Sub
    Private Sub updateproductcategory(ByVal uc As UC_UpdateProductCategory)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        Dim uc As New UC_UpdateProductCategory
        updateproductcategory(uc)
        closeProductCategory()
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        openProduct()
        closecustomer()
        closeEmployee()
        closeProductCategory()
        closeServices()
        closeSubServices()
        closeReports()
        closesales()
        closeSMS()
        closeusersettings()
        closeStocks()
    End Sub
    Private Sub viewproductcategory(ByVal uc As UC_ViewProductCategory)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Dim uc As New UC_ViewProductCategory
        viewproductcategory(uc)
        closeProductCategory()
    End Sub
    Private Sub addproduct(ByVal uc As UC_AddProducts)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub btnaddproducts_Click(sender As Object, e As EventArgs) Handles btnaddproducts.Click
        Dim uc As New UC_AddProducts
        addproduct(uc)
        closeProduct()
    End Sub
    Private Sub updateproduct(ByVal uc As UC_UpdateProduct)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub btnupdateproducts_Click(sender As Object, e As EventArgs) Handles btnupdateproducts.Click
        Dim uc As New UC_UpdateProduct
        updateproduct(uc)
        closeProduct()
    End Sub
    Private Sub viewproduct(ByVal uc As UC_ViewProduct)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub btnviewproducts_Click(sender As Object, e As EventArgs) Handles btnviewproducts.Click
        Dim uc As New UC_ViewProduct
        viewproduct(uc)
        closeProduct()
    End Sub
    Private Sub addservices(ByVal uc As UC_AddServices)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub updateservices(ByVal uc As UC_UpdateService)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub viewservices(ByVal uc As UC_ViewServices)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub btnaddservices_Click(sender As Object, e As EventArgs) Handles btnaddservices.Click
        Dim uc As New UC_AddServices
        addservices(uc)
        closeServices()
    End Sub

    Private Sub btnshowservices_Click(sender As Object, e As EventArgs) Handles btnshowservices.Click
        Dim uc As New UC_ViewServices
        viewservices(uc)
        closeServices()
    End Sub

    Private Sub btnupdateservices_Click(sender As Object, e As EventArgs) Handles btnupdateservices.Click
        Dim uc As New UC_UpdateService
        updateservices(uc)
        closeServices()
    End Sub
    Private Sub addsubservice(ByVal uc As UC_AddSubService)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub updatesubservice(ByVal uc As UC_UpdateSubServices)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub viewsubservices(ByVal uc As UC_ViewSubServices)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub btnservices_Click(sender As Object, e As EventArgs) Handles btnservices.Click
        closeProduct()
        closecustomer()
        closeEmployee()
        closeProductCategory()
        closeSubServices()
        closeReports()
        closesales()
        closeSMS()
        closeusersettings()
        closeStocks()
        openServices()
    End Sub

    Private Sub btnUpdateSubServices_Click(sender As Object, e As EventArgs) Handles btnUpdateSubServices.Click
        Dim uc As New UC_UpdateSubServices
        updatesubservice(uc)
        closeSubServices()
    End Sub

    Private Sub btnShowSubServices_Click(sender As Object, e As EventArgs) Handles btnShowSubServices.Click
        Dim uc As New UC_ViewSubServices
        viewsubservices(uc)
        closeSubServices()
    End Sub

    Private Sub btnAddSubServices_Click(sender As Object, e As EventArgs) Handles btnAddSubServices.Click
        Dim uc As New UC_AddSubService
        addsubservice(uc)
        closeSubServices()
    End Sub

    Private Sub btnSubServices_Click(sender As Object, e As EventArgs) Handles btnSubServices.Click
        closeProduct()
        closecustomer()
        closeEmployee()
        closeProductCategory()
        closeReports()
        closesales()
        closeSMS()
        closeusersettings()
        closeStocks()
        closesales()
        closeServices()
        openSubServices()
    End Sub
    Private Sub btnSales_Click_1(sender As Object, e As EventArgs) Handles btnSales.Click
        closeProduct()
        closecustomer()
        closeEmployee()
        closeProductCategory()
        closeReports()
        closesales()
        closeSMS()
        closeusersettings()
        closeStocks()
        closeSubServices()
        closeServices()
        opensales()
    End Sub

    Private Sub btnStocks_Click(sender As Object, e As EventArgs) Handles btnStocks.Click
        closeProduct()
        closecustomer()
        closeEmployee()
        closeProductCategory()
        closeReports()
        closesales()
        closeSMS()
        closeusersettings()
        closeSubServices()
        openStocks()
        closesales()
        closeServices()
    End Sub

    Private Sub btnSMSpanel_Click(sender As Object, e As EventArgs) Handles btnSMSpanel.Click
        closeProduct()
        closecustomer()
        closeEmployee()
        closeProductCategory()
        closeReports()
        closesales()
        openSMS()
        closeusersettings()
        closeSubServices()
        closeStocks()
        closesales()
        closeServices()
    End Sub

    Private Sub btnReportsPanel_Click(sender As Object, e As EventArgs) Handles btnReportsPanel.Click
        closeProduct()
        closecustomer()
        closeEmployee()
        closeProductCategory()
        openReports()
        closesales()
        closeSMS()
        closeusersettings()
        closeSubServices()
        closeStocks()
        closesales()
        closeServices()
    End Sub

    Private Sub btnusersettings_Click(sender As Object, e As EventArgs) Handles btnusersettings.Click
        closeProduct()
        closecustomer()
        closeEmployee()
        closeProductCategory()
        closeReports()
        closesales()
        closeSMS()
        openusersettings()
        closeSubServices()
        closeStocks()
        closesales()
        closeServices()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()
        frmlogin.Show()
        frmForgotPassword.Close()
        Frm_Change_Password.Close()
        frmlogin.txtusername.Text = ""
        frmlogin.txtpassword.Text = ""
        frmlogin.txtusername.Focus()
    End Sub
    Private Sub btnchangepassword_Click(sender As Object, e As EventArgs) Handles btnchangepassword.Click
        closeusersetting()
        Me.Hide()
        Frm_Change_Password.Show()
    End Sub
    Private Sub addproductstock(ByVal uc As UC_AddProductStocks)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub btnAddProductStocksPanel_Click(sender As Object, e As EventArgs) Handles btnAddProductStocksPanel.Click
        closeStocks()
        Dim uc As New UC_AddProductStocks
        addproductstock(uc)
        closeSubServices()
    End Sub
    Private Sub updateProductStock(ByVal uc As UC_UpdateProductStock)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub btnUpdaProdStocksPanel_Click(sender As Object, e As EventArgs) Handles btnUpdaProdStocksPanel.Click
        closeStocks()
        Dim uc As New UC_UpdateProductStock
        updateProductStock(uc)
        closeSubServices()
    End Sub
    Private Sub viewProductStock(ByVal uc As UC_ViewProductStock)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub btnViewAllStockHistoryPanel_Click(sender As Object, e As EventArgs) Handles btnViewAllStockHistoryPanel.Click
        closeStocks()
        Dim uc As New UC_ViewProductStock
        viewProductStock(uc)
        closeSubServices()
    End Sub
    Private Sub productsales(ByVal uc As UC_ProductSales)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub servicetsales(ByVal uc As UC_ServicesSales)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub btnProductsSale_Click(sender As Object, e As EventArgs) Handles btnProductsSale.Click
        closesales()
        Dim uc As New UC_ProductSales
        productsales(uc)
    End Sub

    Private Sub btnServicesSale_Click(sender As Object, e As EventArgs) Handles btnServicesSale.Click
        closesales()
        Dim uc As New UC_ServicesSales
        servicetsales(uc)
    End Sub

    Private Sub manageuser(ByVal uc As UC_NewUser)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Top
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub btnManageAllUser_Click(sender As Object, e As EventArgs) Handles btnManageAllUser.Click
        Dim uc As New UC_NewUser
        manageuser(uc)
        closeusersetting()
    End Sub
    Private Sub productsellsbill(ByVal uc As UC_ProductSalesReports)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Top
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub servicesellsbill(ByVal uc As UC_ServiceSalesReport)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Top
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub btnProductBillReportPanel_Click(sender As Object, e As EventArgs) Handles btnProductBillReportPanel.Click
        Dim uc As New UC_ProductSalesReports
        productsellsbill(uc)
        closeReports()
    End Sub

    Private Sub btnServiceBillReportPanel_Click(sender As Object, e As EventArgs) Handles btnServiceBillReportPanel.Click
        Dim uc As New UC_ServiceSalesReport
        servicesellsbill(uc)
        closeReports()
    End Sub
    Private Sub smsoffer(ByVal uc As UC_Offers)
        panelContainer.Controls.Clear()
        uc.Dock = DockStyle.Top
        uc.BringToFront()
        panelContainer.Controls.Add(uc)
    End Sub
    Private Sub btnAddSmsOfferPanel_Click(sender As Object, e As EventArgs) Handles btnAddSmsOfferPanel.Click
        Dim uc As New UC_Offers
        smsoffer(uc)
        closeSMS()
    End Sub

    Private Sub currtime_Tick(sender As Object, e As EventArgs) Handles currtime.Tick
        lblcurrtime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub btnprintersettings_Click(sender As Object, e As EventArgs) Handles btnprintersettings.Click
        Me.Close()
        FrmSelectPrinter.Show()
        closeusersettings()
    End Sub

End Class