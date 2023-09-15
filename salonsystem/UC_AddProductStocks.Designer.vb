<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_AddProductStocks
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCurrentStock = New Guna.UI.WinForms.GunaLabel()
        Me.cmbAddStockProdName = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dtpAddProdStockDate = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.GunaLabel26 = New Guna.UI.WinForms.GunaLabel()
        Me.lblAddStockID = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel27 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel30 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel24 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel29 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel28 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel23 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel22 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.cmbAddProdCatStock = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GunaLabel20 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Separator6 = New Guna.UI2.WinForms.Guna2Separator()
        Me.btnAddProdStockClear = New Guna.UI.WinForms.GunaButton()
        Me.btnAddProductStock = New Guna.UI.WinForms.GunaButton()
        Me.txtAddProdStockQuantity = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel25 = New Guna.UI.WinForms.GunaLabel()
        Me.lbladdress = New Guna.UI.WinForms.GunaLabel()
        Me.lbllname = New Guna.UI.WinForms.GunaLabel()
        Me.lblfname = New Guna.UI.WinForms.GunaLabel()
        Me.lblcustomer = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.txtAddViewCurStockSearchByProdName = New Guna.UI.WinForms.GunaTextBox()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.dgvqnt5 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.dgv_ViewCurProdNameStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_ViewProdCurStockQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.dgvqnt1to5 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvqnt0 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvqnt5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvqnt1to5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvqnt0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblCurrentStock)
        Me.Panel1.Controls.Add(Me.cmbAddStockProdName)
        Me.Panel1.Controls.Add(Me.dtpAddProdStockDate)
        Me.Panel1.Controls.Add(Me.GunaLabel26)
        Me.Panel1.Controls.Add(Me.lblAddStockID)
        Me.Panel1.Controls.Add(Me.GunaLabel27)
        Me.Panel1.Controls.Add(Me.GunaLabel5)
        Me.Panel1.Controls.Add(Me.GunaLabel30)
        Me.Panel1.Controls.Add(Me.GunaLabel4)
        Me.Panel1.Controls.Add(Me.GunaLabel24)
        Me.Panel1.Controls.Add(Me.GunaLabel29)
        Me.Panel1.Controls.Add(Me.GunaLabel28)
        Me.Panel1.Controls.Add(Me.GunaLabel23)
        Me.Panel1.Controls.Add(Me.GunaLabel22)
        Me.Panel1.Controls.Add(Me.GunaLabel1)
        Me.Panel1.Controls.Add(Me.cmbAddProdCatStock)
        Me.Panel1.Controls.Add(Me.GunaLabel20)
        Me.Panel1.Controls.Add(Me.Guna2Separator6)
        Me.Panel1.Controls.Add(Me.btnAddProdStockClear)
        Me.Panel1.Controls.Add(Me.btnAddProductStock)
        Me.Panel1.Controls.Add(Me.txtAddProdStockQuantity)
        Me.Panel1.Controls.Add(Me.GunaLabel3)
        Me.Panel1.Controls.Add(Me.GunaLabel25)
        Me.Panel1.Controls.Add(Me.lbladdress)
        Me.Panel1.Controls.Add(Me.lbllname)
        Me.Panel1.Controls.Add(Me.lblfname)
        Me.Panel1.Controls.Add(Me.lblcustomer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(606, 1038)
        Me.Panel1.TabIndex = 157
        '
        'lblCurrentStock
        '
        Me.lblCurrentStock.AutoSize = True
        Me.lblCurrentStock.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentStock.ForeColor = System.Drawing.Color.Black
        Me.lblCurrentStock.Location = New System.Drawing.Point(319, 573)
        Me.lblCurrentStock.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCurrentStock.Name = "lblCurrentStock"
        Me.lblCurrentStock.Size = New System.Drawing.Size(27, 31)
        Me.lblCurrentStock.TabIndex = 150
        Me.lblCurrentStock.Text = "-"
        '
        'cmbAddStockProdName
        '
        Me.cmbAddStockProdName.BackColor = System.Drawing.Color.Transparent
        Me.cmbAddStockProdName.BorderColor = System.Drawing.Color.Black
        Me.cmbAddStockProdName.BorderThickness = 2
        Me.cmbAddStockProdName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbAddStockProdName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAddStockProdName.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbAddStockProdName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbAddStockProdName.FocusedState.Parent = Me.cmbAddStockProdName
        Me.cmbAddStockProdName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbAddStockProdName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbAddStockProdName.HoverState.Parent = Me.cmbAddStockProdName
        Me.cmbAddStockProdName.ItemHeight = 30
        Me.cmbAddStockProdName.ItemsAppearance.Parent = Me.cmbAddStockProdName
        Me.cmbAddStockProdName.Location = New System.Drawing.Point(324, 372)
        Me.cmbAddStockProdName.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbAddStockProdName.Name = "cmbAddStockProdName"
        Me.cmbAddStockProdName.ShadowDecoration.Parent = Me.cmbAddStockProdName
        Me.cmbAddStockProdName.Size = New System.Drawing.Size(219, 36)
        Me.cmbAddStockProdName.TabIndex = 149
        '
        'dtpAddProdStockDate
        '
        Me.dtpAddProdStockDate.BaseColor = System.Drawing.Color.White
        Me.dtpAddProdStockDate.BorderColor = System.Drawing.Color.Black
        Me.dtpAddProdStockDate.CustomFormat = Nothing
        Me.dtpAddProdStockDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpAddProdStockDate.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpAddProdStockDate.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAddProdStockDate.ForeColor = System.Drawing.Color.Black
        Me.dtpAddProdStockDate.Location = New System.Drawing.Point(324, 169)
        Me.dtpAddProdStockDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpAddProdStockDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpAddProdStockDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpAddProdStockDate.Name = "dtpAddProdStockDate"
        Me.dtpAddProdStockDate.OnHoverBaseColor = System.Drawing.Color.Black
        Me.dtpAddProdStockDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpAddProdStockDate.OnHoverForeColor = System.Drawing.Color.White
        Me.dtpAddProdStockDate.OnPressedColor = System.Drawing.Color.Black
        Me.dtpAddProdStockDate.Size = New System.Drawing.Size(202, 32)
        Me.dtpAddProdStockDate.TabIndex = 148
        Me.dtpAddProdStockDate.Text = "15 July 2020"
        Me.dtpAddProdStockDate.Value = New Date(2020, 7, 15, 0, 0, 0, 0)
        '
        'GunaLabel26
        '
        Me.GunaLabel26.AutoSize = True
        Me.GunaLabel26.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel26.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel26.Location = New System.Drawing.Point(488, 481)
        Me.GunaLabel26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel26.Name = "GunaLabel26"
        Me.GunaLabel26.Size = New System.Drawing.Size(58, 31)
        Me.GunaLabel26.TabIndex = 146
        Me.GunaLabel26.Text = "Pcs."
        '
        'lblAddStockID
        '
        Me.lblAddStockID.AutoSize = True
        Me.lblAddStockID.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddStockID.ForeColor = System.Drawing.Color.Black
        Me.lblAddStockID.Location = New System.Drawing.Point(319, 77)
        Me.lblAddStockID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAddStockID.Name = "lblAddStockID"
        Me.lblAddStockID.Size = New System.Drawing.Size(27, 31)
        Me.lblAddStockID.TabIndex = 145
        Me.lblAddStockID.Text = "-"
        '
        'GunaLabel27
        '
        Me.GunaLabel27.AutoSize = True
        Me.GunaLabel27.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel27.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel27.Location = New System.Drawing.Point(283, 573)
        Me.GunaLabel27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel27.Name = "GunaLabel27"
        Me.GunaLabel27.Size = New System.Drawing.Size(24, 31)
        Me.GunaLabel27.TabIndex = 145
        Me.GunaLabel27.Text = ":"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.Red
        Me.GunaLabel5.Location = New System.Drawing.Point(142, 483)
        Me.GunaLabel5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(26, 31)
        Me.GunaLabel5.TabIndex = 145
        Me.GunaLabel5.Text = "*"
        '
        'GunaLabel30
        '
        Me.GunaLabel30.AutoSize = True
        Me.GunaLabel30.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel30.ForeColor = System.Drawing.Color.Red
        Me.GunaLabel30.Location = New System.Drawing.Point(227, 370)
        Me.GunaLabel30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel30.Name = "GunaLabel30"
        Me.GunaLabel30.Size = New System.Drawing.Size(26, 31)
        Me.GunaLabel30.TabIndex = 145
        Me.GunaLabel30.Text = "*"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel4.Location = New System.Drawing.Point(283, 481)
        Me.GunaLabel4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(24, 31)
        Me.GunaLabel4.TabIndex = 145
        Me.GunaLabel4.Text = ":"
        '
        'GunaLabel24
        '
        Me.GunaLabel24.AutoSize = True
        Me.GunaLabel24.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel24.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel24.Location = New System.Drawing.Point(283, 370)
        Me.GunaLabel24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel24.Name = "GunaLabel24"
        Me.GunaLabel24.Size = New System.Drawing.Size(24, 31)
        Me.GunaLabel24.TabIndex = 145
        Me.GunaLabel24.Text = ":"
        '
        'GunaLabel29
        '
        Me.GunaLabel29.AutoSize = True
        Me.GunaLabel29.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel29.ForeColor = System.Drawing.Color.Red
        Me.GunaLabel29.Location = New System.Drawing.Point(201, 164)
        Me.GunaLabel29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel29.Name = "GunaLabel29"
        Me.GunaLabel29.Size = New System.Drawing.Size(26, 31)
        Me.GunaLabel29.TabIndex = 145
        Me.GunaLabel29.Text = "*"
        '
        'GunaLabel28
        '
        Me.GunaLabel28.AutoSize = True
        Me.GunaLabel28.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel28.ForeColor = System.Drawing.Color.Red
        Me.GunaLabel28.Location = New System.Drawing.Point(227, 273)
        Me.GunaLabel28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel28.Name = "GunaLabel28"
        Me.GunaLabel28.Size = New System.Drawing.Size(26, 31)
        Me.GunaLabel28.TabIndex = 145
        Me.GunaLabel28.Text = "*"
        '
        'GunaLabel23
        '
        Me.GunaLabel23.AutoSize = True
        Me.GunaLabel23.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel23.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel23.Location = New System.Drawing.Point(283, 271)
        Me.GunaLabel23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel23.Name = "GunaLabel23"
        Me.GunaLabel23.Size = New System.Drawing.Size(24, 31)
        Me.GunaLabel23.TabIndex = 145
        Me.GunaLabel23.Text = ":"
        '
        'GunaLabel22
        '
        Me.GunaLabel22.AutoSize = True
        Me.GunaLabel22.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel22.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel22.Location = New System.Drawing.Point(283, 169)
        Me.GunaLabel22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel22.Name = "GunaLabel22"
        Me.GunaLabel22.Size = New System.Drawing.Size(24, 31)
        Me.GunaLabel22.TabIndex = 145
        Me.GunaLabel22.Text = ":"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel1.Location = New System.Drawing.Point(283, 77)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(24, 31)
        Me.GunaLabel1.TabIndex = 145
        Me.GunaLabel1.Text = ":"
        '
        'cmbAddProdCatStock
        '
        Me.cmbAddProdCatStock.BackColor = System.Drawing.Color.Transparent
        Me.cmbAddProdCatStock.BorderColor = System.Drawing.Color.Black
        Me.cmbAddProdCatStock.BorderThickness = 2
        Me.cmbAddProdCatStock.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbAddProdCatStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAddProdCatStock.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbAddProdCatStock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbAddProdCatStock.FocusedState.Parent = Me.cmbAddProdCatStock
        Me.cmbAddProdCatStock.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbAddProdCatStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbAddProdCatStock.HoverState.Parent = Me.cmbAddProdCatStock
        Me.cmbAddProdCatStock.ItemHeight = 30
        Me.cmbAddProdCatStock.ItemsAppearance.Parent = Me.cmbAddProdCatStock
        Me.cmbAddProdCatStock.Location = New System.Drawing.Point(324, 273)
        Me.cmbAddProdCatStock.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbAddProdCatStock.Name = "cmbAddProdCatStock"
        Me.cmbAddProdCatStock.ShadowDecoration.Parent = Me.cmbAddProdCatStock
        Me.cmbAddProdCatStock.Size = New System.Drawing.Size(219, 36)
        Me.cmbAddProdCatStock.TabIndex = 144
        '
        'GunaLabel20
        '
        Me.GunaLabel20.AutoSize = True
        Me.GunaLabel20.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel20.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel20.Location = New System.Drawing.Point(128, 7)
        Me.GunaLabel20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel20.Name = "GunaLabel20"
        Me.GunaLabel20.Size = New System.Drawing.Size(362, 35)
        Me.GunaLabel20.TabIndex = 143
        Me.GunaLabel20.Text = "Add Product Stocks"
        '
        'Guna2Separator6
        '
        Me.Guna2Separator6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator6.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator6.FillStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.Guna2Separator6.FillThickness = 8
        Me.Guna2Separator6.Location = New System.Drawing.Point(-1, 58)
        Me.Guna2Separator6.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Separator6.Name = "Guna2Separator6"
        Me.Guna2Separator6.Size = New System.Drawing.Size(626, 8)
        Me.Guna2Separator6.TabIndex = 142
        '
        'btnAddProdStockClear
        '
        Me.btnAddProdStockClear.AnimationHoverSpeed = 0.07!
        Me.btnAddProdStockClear.AnimationSpeed = 0.03!
        Me.btnAddProdStockClear.BaseColor = System.Drawing.Color.Transparent
        Me.btnAddProdStockClear.BorderColor = System.Drawing.Color.Black
        Me.btnAddProdStockClear.BorderSize = 2
        Me.btnAddProdStockClear.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddProdStockClear.FocusedColor = System.Drawing.Color.Empty
        Me.btnAddProdStockClear.Font = New System.Drawing.Font("Algerian", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProdStockClear.ForeColor = System.Drawing.Color.Black
        Me.btnAddProdStockClear.Image = Nothing
        Me.btnAddProdStockClear.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAddProdStockClear.Location = New System.Drawing.Point(356, 684)
        Me.btnAddProdStockClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddProdStockClear.Name = "btnAddProdStockClear"
        Me.btnAddProdStockClear.OnHoverBaseColor = System.Drawing.Color.Black
        Me.btnAddProdStockClear.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAddProdStockClear.OnHoverForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddProdStockClear.OnHoverImage = Nothing
        Me.btnAddProdStockClear.OnPressedColor = System.Drawing.Color.Black
        Me.btnAddProdStockClear.Size = New System.Drawing.Size(186, 54)
        Me.btnAddProdStockClear.TabIndex = 9
        Me.btnAddProdStockClear.Text = "Clear Data"
        Me.btnAddProdStockClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAddProductStock
        '
        Me.btnAddProductStock.AnimationHoverSpeed = 0.07!
        Me.btnAddProductStock.AnimationSpeed = 0.03!
        Me.btnAddProductStock.BaseColor = System.Drawing.Color.Transparent
        Me.btnAddProductStock.BorderColor = System.Drawing.Color.Black
        Me.btnAddProductStock.BorderSize = 2
        Me.btnAddProductStock.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddProductStock.FocusedColor = System.Drawing.Color.Empty
        Me.btnAddProductStock.Font = New System.Drawing.Font("Algerian", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProductStock.ForeColor = System.Drawing.Color.Black
        Me.btnAddProductStock.Image = Nothing
        Me.btnAddProductStock.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAddProductStock.Location = New System.Drawing.Point(55, 684)
        Me.btnAddProductStock.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddProductStock.Name = "btnAddProductStock"
        Me.btnAddProductStock.OnHoverBaseColor = System.Drawing.Color.Black
        Me.btnAddProductStock.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAddProductStock.OnHoverForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddProductStock.OnHoverImage = Nothing
        Me.btnAddProductStock.OnPressedColor = System.Drawing.Color.Black
        Me.btnAddProductStock.Size = New System.Drawing.Size(266, 54)
        Me.btnAddProductStock.TabIndex = 8
        Me.btnAddProductStock.Text = "Add Product Stock"
        Me.btnAddProductStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAddProdStockQuantity
        '
        Me.txtAddProdStockQuantity.BaseColor = System.Drawing.Color.White
        Me.txtAddProdStockQuantity.BorderColor = System.Drawing.Color.Black
        Me.txtAddProdStockQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddProdStockQuantity.FocusedBaseColor = System.Drawing.Color.White
        Me.txtAddProdStockQuantity.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddProdStockQuantity.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtAddProdStockQuantity.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddProdStockQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtAddProdStockQuantity.Location = New System.Drawing.Point(324, 481)
        Me.txtAddProdStockQuantity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddProdStockQuantity.Name = "txtAddProdStockQuantity"
        Me.txtAddProdStockQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddProdStockQuantity.SelectedText = ""
        Me.txtAddProdStockQuantity.Size = New System.Drawing.Size(159, 35)
        Me.txtAddProdStockQuantity.TabIndex = 2
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel3.Location = New System.Drawing.Point(35, 481)
        Me.GunaLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(106, 31)
        Me.GunaLabel3.TabIndex = 129
        Me.GunaLabel3.Text = "Quantity"
        '
        'GunaLabel25
        '
        Me.GunaLabel25.AutoSize = True
        Me.GunaLabel25.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel25.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel25.Location = New System.Drawing.Point(35, 370)
        Me.GunaLabel25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel25.Name = "GunaLabel25"
        Me.GunaLabel25.Size = New System.Drawing.Size(163, 31)
        Me.GunaLabel25.TabIndex = 129
        Me.GunaLabel25.Text = "Product Name"
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.ForeColor = System.Drawing.Color.Black
        Me.lbladdress.Location = New System.Drawing.Point(35, 573)
        Me.lbladdress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(165, 31)
        Me.lbladdress.TabIndex = 129
        Me.lbladdress.Text = "Current Stock"
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllname.ForeColor = System.Drawing.Color.Black
        Me.lbllname.Location = New System.Drawing.Point(35, 271)
        Me.lbllname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(199, 31)
        Me.lbllname.TabIndex = 125
        Me.lbllname.Text = "Product Category"
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfname.ForeColor = System.Drawing.Color.Black
        Me.lblfname.Location = New System.Drawing.Point(35, 164)
        Me.lblfname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(140, 31)
        Me.lblfname.TabIndex = 124
        Me.lblfname.Text = "Select Date"
        '
        'lblcustomer
        '
        Me.lblcustomer.AutoSize = True
        Me.lblcustomer.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomer.ForeColor = System.Drawing.Color.Black
        Me.lblcustomer.Location = New System.Drawing.Point(35, 77)
        Me.lblcustomer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcustomer.Name = "lblcustomer"
        Me.lblcustomer.Size = New System.Drawing.Size(122, 31)
        Me.lblcustomer.TabIndex = 123
        Me.lblcustomer.Text = "Stock ID "
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel2.Location = New System.Drawing.Point(638, -8)
        Me.GunaLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(0, 35)
        Me.GunaLabel2.TabIndex = 158
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Comic Sans MS", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel6.Location = New System.Drawing.Point(642, 6)
        Me.GunaLabel6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(372, 38)
        Me.GunaLabel6.TabIndex = 151
        Me.GunaLabel6.Text = "Search By Product Name :"
        '
        'txtAddViewCurStockSearchByProdName
        '
        Me.txtAddViewCurStockSearchByProdName.BaseColor = System.Drawing.Color.White
        Me.txtAddViewCurStockSearchByProdName.BorderColor = System.Drawing.Color.Black
        Me.txtAddViewCurStockSearchByProdName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddViewCurStockSearchByProdName.FocusedBaseColor = System.Drawing.Color.White
        Me.txtAddViewCurStockSearchByProdName.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddViewCurStockSearchByProdName.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtAddViewCurStockSearchByProdName.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddViewCurStockSearchByProdName.ForeColor = System.Drawing.Color.Black
        Me.txtAddViewCurStockSearchByProdName.Location = New System.Drawing.Point(1026, 11)
        Me.txtAddViewCurStockSearchByProdName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddViewCurStockSearchByProdName.Name = "txtAddViewCurStockSearchByProdName"
        Me.txtAddViewCurStockSearchByProdName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddViewCurStockSearchByProdName.SelectedText = ""
        Me.txtAddViewCurStockSearchByProdName.Size = New System.Drawing.Size(272, 35)
        Me.txtAddViewCurStockSearchByProdName.TabIndex = 151
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator1.FillStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.Guna2Separator1.FillThickness = 8
        Me.Guna2Separator1.Location = New System.Drawing.Point(609, 58)
        Me.Guna2Separator1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(740, 8)
        Me.Guna2Separator1.TabIndex = 151
        '
        'dgvqnt5
        '
        Me.dgvqnt5.AllowUserToAddRows = False
        Me.dgvqnt5.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvqnt5.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvqnt5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvqnt5.BackgroundColor = System.Drawing.Color.LimeGreen
        Me.dgvqnt5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvqnt5.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvqnt5.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvqnt5.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvqnt5.ColumnHeadersHeight = 27
        Me.dgvqnt5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgv_ViewCurProdNameStock, Me.dgv_ViewProdCurStockQuantity})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvqnt5.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvqnt5.EnableHeadersVisualStyles = False
        Me.dgvqnt5.GridColor = System.Drawing.Color.Silver
        Me.dgvqnt5.Location = New System.Drawing.Point(664, 101)
        Me.dgvqnt5.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvqnt5.Name = "dgvqnt5"
        Me.dgvqnt5.ReadOnly = True
        Me.dgvqnt5.RowHeadersVisible = False
        Me.dgvqnt5.RowHeadersWidth = 51
        Me.dgvqnt5.RowTemplate.Height = 24
        Me.dgvqnt5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvqnt5.Size = New System.Drawing.Size(616, 182)
        Me.dgvqnt5.TabIndex = 159
        Me.dgvqnt5.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvqnt5.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvqnt5.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvqnt5.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvqnt5.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvqnt5.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvqnt5.ThemeStyle.BackColor = System.Drawing.Color.LimeGreen
        Me.dgvqnt5.ThemeStyle.GridColor = System.Drawing.Color.Silver
        Me.dgvqnt5.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvqnt5.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvqnt5.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvqnt5.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvqnt5.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvqnt5.ThemeStyle.HeaderStyle.Height = 27
        Me.dgvqnt5.ThemeStyle.ReadOnly = True
        Me.dgvqnt5.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvqnt5.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvqnt5.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvqnt5.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvqnt5.ThemeStyle.RowsStyle.Height = 24
        Me.dgvqnt5.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvqnt5.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'dgv_ViewCurProdNameStock
        '
        Me.dgv_ViewCurProdNameStock.HeaderText = "Product Name"
        Me.dgv_ViewCurProdNameStock.MinimumWidth = 20
        Me.dgv_ViewCurProdNameStock.Name = "dgv_ViewCurProdNameStock"
        Me.dgv_ViewCurProdNameStock.ReadOnly = True
        '
        'dgv_ViewProdCurStockQuantity
        '
        Me.dgv_ViewProdCurStockQuantity.HeaderText = "Product Quantity"
        Me.dgv_ViewProdCurStockQuantity.MinimumWidth = 6
        Me.dgv_ViewProdCurStockQuantity.Name = "dgv_ViewProdCurStockQuantity"
        Me.dgv_ViewProdCurStockQuantity.ReadOnly = True
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Algerian", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel7.Location = New System.Drawing.Point(708, 66)
        Me.GunaLabel7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(544, 30)
        Me.GunaLabel7.TabIndex = 151
        Me.GunaLabel7.Text = "Current Product(s) Stock  (qty > 5)"
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator2.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator2.FillStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.Guna2Separator2.FillThickness = 8
        Me.Guna2Separator2.Location = New System.Drawing.Point(609, 303)
        Me.Guna2Separator2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(740, 8)
        Me.Guna2Separator2.TabIndex = 160
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Algerian", 18.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel8.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel8.Location = New System.Drawing.Point(639, 314)
        Me.GunaLabel8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(704, 26)
        Me.GunaLabel8.TabIndex = 161
        Me.GunaLabel8.Text = " Product(s) near to out of Stock (Qty Between  1-5)"
        Me.GunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvqnt1to5
        '
        Me.dgvqnt1to5.AllowUserToAddRows = False
        Me.dgvqnt1to5.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvqnt1to5.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvqnt1to5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvqnt1to5.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.dgvqnt1to5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvqnt1to5.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvqnt1to5.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvqnt1to5.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvqnt1to5.ColumnHeadersHeight = 27
        Me.dgvqnt1to5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvqnt1to5.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvqnt1to5.EnableHeadersVisualStyles = False
        Me.dgvqnt1to5.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvqnt1to5.Location = New System.Drawing.Point(664, 350)
        Me.dgvqnt1to5.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvqnt1to5.Name = "dgvqnt1to5"
        Me.dgvqnt1to5.ReadOnly = True
        Me.dgvqnt1to5.RowHeadersVisible = False
        Me.dgvqnt1to5.RowHeadersWidth = 51
        Me.dgvqnt1to5.RowTemplate.Height = 24
        Me.dgvqnt1to5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvqnt1to5.Size = New System.Drawing.Size(616, 182)
        Me.dgvqnt1to5.TabIndex = 162
        Me.dgvqnt1to5.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvqnt1to5.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvqnt1to5.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvqnt1to5.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvqnt1to5.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvqnt1to5.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvqnt1to5.ThemeStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.dgvqnt1to5.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvqnt1to5.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvqnt1to5.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvqnt1to5.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvqnt1to5.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvqnt1to5.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvqnt1to5.ThemeStyle.HeaderStyle.Height = 27
        Me.dgvqnt1to5.ThemeStyle.ReadOnly = True
        Me.dgvqnt1to5.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvqnt1to5.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvqnt1to5.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvqnt1to5.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvqnt1to5.ThemeStyle.RowsStyle.Height = 24
        Me.dgvqnt1to5.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvqnt1to5.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 20
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Product Quantity"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'dgvqnt0
        '
        Me.dgvqnt0.AllowUserToAddRows = False
        Me.dgvqnt0.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.dgvqnt0.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvqnt0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvqnt0.BackgroundColor = System.Drawing.Color.DarkRed
        Me.dgvqnt0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvqnt0.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvqnt0.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvqnt0.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvqnt0.ColumnHeadersHeight = 27
        Me.dgvqnt0.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvqnt0.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvqnt0.EnableHeadersVisualStyles = False
        Me.dgvqnt0.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvqnt0.Location = New System.Drawing.Point(664, 600)
        Me.dgvqnt0.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvqnt0.Name = "dgvqnt0"
        Me.dgvqnt0.ReadOnly = True
        Me.dgvqnt0.RowHeadersVisible = False
        Me.dgvqnt0.RowHeadersWidth = 51
        Me.dgvqnt0.RowTemplate.Height = 24
        Me.dgvqnt0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvqnt0.Size = New System.Drawing.Size(616, 182)
        Me.dgvqnt0.TabIndex = 165
        Me.dgvqnt0.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvqnt0.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvqnt0.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvqnt0.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvqnt0.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvqnt0.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvqnt0.ThemeStyle.BackColor = System.Drawing.Color.DarkRed
        Me.dgvqnt0.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvqnt0.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvqnt0.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvqnt0.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvqnt0.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvqnt0.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvqnt0.ThemeStyle.HeaderStyle.Height = 27
        Me.dgvqnt0.ThemeStyle.ReadOnly = True
        Me.dgvqnt0.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvqnt0.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvqnt0.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvqnt0.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvqnt0.ThemeStyle.RowsStyle.Height = 24
        Me.dgvqnt0.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvqnt0.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 20
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Product Quantity"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Algerian", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel9.Location = New System.Drawing.Point(666, 562)
        Me.GunaLabel9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(650, 30)
        Me.GunaLabel9.TabIndex = 164
        Me.GunaLabel9.Text = " Out of stock Product(s) (Qty equals to 0)"
        Me.GunaLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Separator3
        '
        Me.Guna2Separator3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator3.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator3.FillStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.Guna2Separator3.FillThickness = 8
        Me.Guna2Separator3.Location = New System.Drawing.Point(609, 552)
        Me.Guna2Separator3.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Separator3.Name = "Guna2Separator3"
        Me.Guna2Separator3.Size = New System.Drawing.Size(740, 8)
        Me.Guna2Separator3.TabIndex = 163
        '
        'UC_AddProductStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.dgvqnt0)
        Me.Controls.Add(Me.GunaLabel9)
        Me.Controls.Add(Me.Guna2Separator3)
        Me.Controls.Add(Me.dgvqnt1to5)
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.Guna2Separator2)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.dgvqnt5)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.txtAddViewCurStockSearchByProdName)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "UC_AddProductStocks"
        Me.Size = New System.Drawing.Size(1748, 1038)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvqnt5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvqnt1to5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvqnt0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaLabel26 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblAddStockID As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel27 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel30 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel24 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel29 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel28 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel23 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel22 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cmbAddProdCatStock As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaLabel20 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Separator6 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents btnAddProdStockClear As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAddProductStock As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtAddProdStockQuantity As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel25 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbladdress As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbllname As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblfname As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblcustomer As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblCurrentStock As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cmbAddStockProdName As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dtpAddProdStockDate As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtAddViewCurStockSearchByProdName As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents dgvqnt5 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents dgv_ViewCurProdNameStock As DataGridViewTextBoxColumn
    Friend WithEvents dgv_ViewProdCurStockQuantity As DataGridViewTextBoxColumn
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dgvqnt1to5 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents dgvqnt0 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
End Class
