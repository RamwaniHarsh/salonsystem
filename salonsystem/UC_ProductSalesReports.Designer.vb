<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_ProductSalesReports
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_ProductSalesReports))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnClearProdReceipt = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.btnPrintProdReceipt = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.pnlCusProdReceipt = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvprintReceipt = New System.Windows.Forms.DataGridView()
        Me.GunaLabel23 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Separator4 = New Guna.UI2.WinForms.Guna2Separator()
        Me.lblProdReceiptTotalRs = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel22 = New Guna.UI.WinForms.GunaLabel()
        Me.lblProdReceiptQuantity = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel19 = New Guna.UI.WinForms.GunaLabel()
        Me.lblProdReceiptCusMob = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel17 = New Guna.UI.WinForms.GunaLabel()
        Me.lblProdReceiptBillNo = New Guna.UI.WinForms.GunaLabel()
        Me.lblProdReceiptCusName = New Guna.UI.WinForms.GunaLabel()
        Me.lblProdReceiptBillDate = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2PictureBox4 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblCusProdReportBillDate = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btnCusProdBillReportSearch = New Guna.UI.WinForms.GunaButton()
        Me.txtCusProdReportBillNo = New Guna.UI.WinForms.GunaTextBox()
        Me.lblfname = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel20 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Separator6 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2VSeparator2 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.dgvCusServBillReport = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.lblCusProdBillCusName = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.lblCusProdBillCusMobile = New Guna.UI.WinForms.GunaLabel()
        Me.lblCusProdBillCusAddress = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel13 = New Guna.UI.WinForms.GunaLabel()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.pnlCusProdReceipt.SuspendLayout()
        CType(Me.dgvprintReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCusServBillReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClearProdReceipt
        '
        Me.btnClearProdReceipt.AnimationHoverSpeed = 0.07!
        Me.btnClearProdReceipt.AnimationSpeed = 0.03!
        Me.btnClearProdReceipt.BaseColor = System.Drawing.Color.Transparent
        Me.btnClearProdReceipt.BorderColor = System.Drawing.Color.Black
        Me.btnClearProdReceipt.BorderSize = 3
        Me.btnClearProdReceipt.CheckedBaseColor = System.Drawing.Color.Blue
        Me.btnClearProdReceipt.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnClearProdReceipt.CheckedForeColor = System.Drawing.Color.Black
        Me.btnClearProdReceipt.CheckedImage = CType(resources.GetObject("btnClearProdReceipt.CheckedImage"), System.Drawing.Image)
        Me.btnClearProdReceipt.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnClearProdReceipt.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClearProdReceipt.FocusedColor = System.Drawing.Color.Empty
        Me.btnClearProdReceipt.Font = New System.Drawing.Font("Gill Sans MT Condensed", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearProdReceipt.ForeColor = System.Drawing.Color.Black
        Me.btnClearProdReceipt.Image = CType(resources.GetObject("btnClearProdReceipt.Image"), System.Drawing.Image)
        Me.btnClearProdReceipt.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnClearProdReceipt.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnClearProdReceipt.Location = New System.Drawing.Point(1271, 710)
        Me.btnClearProdReceipt.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClearProdReceipt.Name = "btnClearProdReceipt"
        Me.btnClearProdReceipt.OnHoverBaseColor = System.Drawing.Color.Blue
        Me.btnClearProdReceipt.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClearProdReceipt.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClearProdReceipt.OnHoverImage = Nothing
        Me.btnClearProdReceipt.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnClearProdReceipt.OnPressedColor = System.Drawing.Color.Blue
        Me.btnClearProdReceipt.Size = New System.Drawing.Size(132, 94)
        Me.btnClearProdReceipt.TabIndex = 208
        Me.btnClearProdReceipt.Text = "Clear"
        '
        'btnPrintProdReceipt
        '
        Me.btnPrintProdReceipt.AnimationHoverSpeed = 0.07!
        Me.btnPrintProdReceipt.AnimationSpeed = 0.03!
        Me.btnPrintProdReceipt.BaseColor = System.Drawing.Color.Transparent
        Me.btnPrintProdReceipt.BorderColor = System.Drawing.Color.Black
        Me.btnPrintProdReceipt.BorderSize = 3
        Me.btnPrintProdReceipt.CheckedBaseColor = System.Drawing.Color.Blue
        Me.btnPrintProdReceipt.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnPrintProdReceipt.CheckedForeColor = System.Drawing.Color.Black
        Me.btnPrintProdReceipt.CheckedImage = CType(resources.GetObject("btnPrintProdReceipt.CheckedImage"), System.Drawing.Image)
        Me.btnPrintProdReceipt.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnPrintProdReceipt.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPrintProdReceipt.FocusedColor = System.Drawing.Color.Empty
        Me.btnPrintProdReceipt.Font = New System.Drawing.Font("Gill Sans MT Condensed", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintProdReceipt.ForeColor = System.Drawing.Color.Black
        Me.btnPrintProdReceipt.Image = CType(resources.GetObject("btnPrintProdReceipt.Image"), System.Drawing.Image)
        Me.btnPrintProdReceipt.ImageSize = New System.Drawing.Size(60, 60)
        Me.btnPrintProdReceipt.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnPrintProdReceipt.Location = New System.Drawing.Point(972, 716)
        Me.btnPrintProdReceipt.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrintProdReceipt.Name = "btnPrintProdReceipt"
        Me.btnPrintProdReceipt.OnHoverBaseColor = System.Drawing.Color.Blue
        Me.btnPrintProdReceipt.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPrintProdReceipt.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPrintProdReceipt.OnHoverImage = Nothing
        Me.btnPrintProdReceipt.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnPrintProdReceipt.OnPressedColor = System.Drawing.Color.Blue
        Me.btnPrintProdReceipt.Size = New System.Drawing.Size(132, 94)
        Me.btnPrintProdReceipt.TabIndex = 207
        Me.btnPrintProdReceipt.Text = "Print"
        '
        'pnlCusProdReceipt
        '
        Me.pnlCusProdReceipt.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlCusProdReceipt.Controls.Add(Me.dgvprintReceipt)
        Me.pnlCusProdReceipt.Controls.Add(Me.GunaLabel23)
        Me.pnlCusProdReceipt.Controls.Add(Me.Guna2Separator4)
        Me.pnlCusProdReceipt.Controls.Add(Me.lblProdReceiptTotalRs)
        Me.pnlCusProdReceipt.Controls.Add(Me.GunaLabel22)
        Me.pnlCusProdReceipt.Controls.Add(Me.lblProdReceiptQuantity)
        Me.pnlCusProdReceipt.Controls.Add(Me.GunaLabel19)
        Me.pnlCusProdReceipt.Controls.Add(Me.lblProdReceiptCusMob)
        Me.pnlCusProdReceipt.Controls.Add(Me.GunaLabel17)
        Me.pnlCusProdReceipt.Controls.Add(Me.lblProdReceiptBillNo)
        Me.pnlCusProdReceipt.Controls.Add(Me.lblProdReceiptCusName)
        Me.pnlCusProdReceipt.Controls.Add(Me.lblProdReceiptBillDate)
        Me.pnlCusProdReceipt.Controls.Add(Me.GunaLabel8)
        Me.pnlCusProdReceipt.Controls.Add(Me.Guna2Separator3)
        Me.pnlCusProdReceipt.Controls.Add(Me.GunaLabel11)
        Me.pnlCusProdReceipt.Controls.Add(Me.GunaLabel10)
        Me.pnlCusProdReceipt.Controls.Add(Me.GunaLabel12)
        Me.pnlCusProdReceipt.Controls.Add(Me.GunaLabel6)
        Me.pnlCusProdReceipt.Controls.Add(Me.GunaLabel4)
        Me.pnlCusProdReceipt.Controls.Add(Me.Guna2PictureBox4)
        Me.pnlCusProdReceipt.Location = New System.Drawing.Point(957, 80)
        Me.pnlCusProdReceipt.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlCusProdReceipt.Name = "pnlCusProdReceipt"
        Me.pnlCusProdReceipt.ShadowDecoration.Parent = Me.pnlCusProdReceipt
        Me.pnlCusProdReceipt.Size = New System.Drawing.Size(448, 626)
        Me.pnlCusProdReceipt.TabIndex = 206
        '
        'dgvprintReceipt
        '
        Me.dgvprintReceipt.AllowUserToAddRows = False
        Me.dgvprintReceipt.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvprintReceipt.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvprintReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvprintReceipt.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvprintReceipt.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvprintReceipt.Location = New System.Drawing.Point(2, 239)
        Me.dgvprintReceipt.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvprintReceipt.Name = "dgvprintReceipt"
        Me.dgvprintReceipt.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvprintReceipt.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvprintReceipt.RowHeadersWidth = 51
        Me.dgvprintReceipt.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvprintReceipt.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvprintReceipt.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
        Me.dgvprintReceipt.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvprintReceipt.RowTemplate.Height = 24
        Me.dgvprintReceipt.Size = New System.Drawing.Size(444, 282)
        Me.dgvprintReceipt.TabIndex = 199
        '
        'GunaLabel23
        '
        Me.GunaLabel23.AutoSize = True
        Me.GunaLabel23.Font = New System.Drawing.Font("Algerian", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel23.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel23.Location = New System.Drawing.Point(125, 556)
        Me.GunaLabel23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel23.Name = "GunaLabel23"
        Me.GunaLabel23.Size = New System.Drawing.Size(225, 60)
        Me.GunaLabel23.TabIndex = 198
        Me.GunaLabel23.Text = "Thank You" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For Your Visit!!"
        Me.GunaLabel23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Separator4
        '
        Me.Guna2Separator4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator4.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator4.FillThickness = 3
        Me.Guna2Separator4.Location = New System.Drawing.Point(2, 546)
        Me.Guna2Separator4.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Separator4.Name = "Guna2Separator4"
        Me.Guna2Separator4.Size = New System.Drawing.Size(474, 8)
        Me.Guna2Separator4.TabIndex = 197
        '
        'lblProdReceiptTotalRs
        '
        Me.lblProdReceiptTotalRs.AutoSize = True
        Me.lblProdReceiptTotalRs.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdReceiptTotalRs.ForeColor = System.Drawing.Color.Black
        Me.lblProdReceiptTotalRs.Location = New System.Drawing.Point(378, 523)
        Me.lblProdReceiptTotalRs.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProdReceiptTotalRs.Name = "lblProdReceiptTotalRs"
        Me.lblProdReceiptTotalRs.Size = New System.Drawing.Size(16, 22)
        Me.lblProdReceiptTotalRs.TabIndex = 196
        Me.lblProdReceiptTotalRs.Text = "-"
        '
        'GunaLabel22
        '
        Me.GunaLabel22.AutoSize = True
        Me.GunaLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel22.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel22.Location = New System.Drawing.Point(273, 523)
        Me.GunaLabel22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel22.Name = "GunaLabel22"
        Me.GunaLabel22.Size = New System.Drawing.Size(98, 22)
        Me.GunaLabel22.TabIndex = 195
        Me.GunaLabel22.Text = "Total : Rs"
        '
        'lblProdReceiptQuantity
        '
        Me.lblProdReceiptQuantity.AutoSize = True
        Me.lblProdReceiptQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdReceiptQuantity.ForeColor = System.Drawing.Color.Black
        Me.lblProdReceiptQuantity.Location = New System.Drawing.Point(101, 523)
        Me.lblProdReceiptQuantity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProdReceiptQuantity.Name = "lblProdReceiptQuantity"
        Me.lblProdReceiptQuantity.Size = New System.Drawing.Size(16, 22)
        Me.lblProdReceiptQuantity.TabIndex = 194
        Me.lblProdReceiptQuantity.Text = "-"
        '
        'GunaLabel19
        '
        Me.GunaLabel19.AutoSize = True
        Me.GunaLabel19.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel19.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel19.Location = New System.Drawing.Point(2, 522)
        Me.GunaLabel19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel19.Name = "GunaLabel19"
        Me.GunaLabel19.Size = New System.Drawing.Size(103, 22)
        Me.GunaLabel19.TabIndex = 193
        Me.GunaLabel19.Text = "Quantity : "
        '
        'lblProdReceiptCusMob
        '
        Me.lblProdReceiptCusMob.AutoSize = True
        Me.lblProdReceiptCusMob.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdReceiptCusMob.ForeColor = System.Drawing.Color.Black
        Me.lblProdReceiptCusMob.Location = New System.Drawing.Point(347, 155)
        Me.lblProdReceiptCusMob.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProdReceiptCusMob.Name = "lblProdReceiptCusMob"
        Me.lblProdReceiptCusMob.Size = New System.Drawing.Size(16, 22)
        Me.lblProdReceiptCusMob.TabIndex = 190
        Me.lblProdReceiptCusMob.Text = "-"
        '
        'GunaLabel17
        '
        Me.GunaLabel17.AutoSize = True
        Me.GunaLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel17.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel17.Location = New System.Drawing.Point(257, 157)
        Me.GunaLabel17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel17.Name = "GunaLabel17"
        Me.GunaLabel17.Size = New System.Drawing.Size(87, 22)
        Me.GunaLabel17.TabIndex = 191
        Me.GunaLabel17.Text = "Mob No : "
        '
        'lblProdReceiptBillNo
        '
        Me.lblProdReceiptBillNo.AutoSize = True
        Me.lblProdReceiptBillNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdReceiptBillNo.ForeColor = System.Drawing.Color.Black
        Me.lblProdReceiptBillNo.Location = New System.Drawing.Point(80, 185)
        Me.lblProdReceiptBillNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProdReceiptBillNo.Name = "lblProdReceiptBillNo"
        Me.lblProdReceiptBillNo.Size = New System.Drawing.Size(16, 22)
        Me.lblProdReceiptBillNo.TabIndex = 189
        Me.lblProdReceiptBillNo.Text = "-"
        '
        'lblProdReceiptCusName
        '
        Me.lblProdReceiptCusName.AutoSize = True
        Me.lblProdReceiptCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdReceiptCusName.ForeColor = System.Drawing.Color.Black
        Me.lblProdReceiptCusName.Location = New System.Drawing.Point(110, 215)
        Me.lblProdReceiptCusName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProdReceiptCusName.Name = "lblProdReceiptCusName"
        Me.lblProdReceiptCusName.Size = New System.Drawing.Size(16, 22)
        Me.lblProdReceiptCusName.TabIndex = 188
        Me.lblProdReceiptCusName.Text = "-"
        '
        'lblProdReceiptBillDate
        '
        Me.lblProdReceiptBillDate.AutoSize = True
        Me.lblProdReceiptBillDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdReceiptBillDate.ForeColor = System.Drawing.Color.Black
        Me.lblProdReceiptBillDate.Location = New System.Drawing.Point(91, 157)
        Me.lblProdReceiptBillDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProdReceiptBillDate.Name = "lblProdReceiptBillDate"
        Me.lblProdReceiptBillDate.Size = New System.Drawing.Size(16, 22)
        Me.lblProdReceiptBillDate.TabIndex = 184
        Me.lblProdReceiptBillDate.Text = "-"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel8.Location = New System.Drawing.Point(1, 214)
        Me.GunaLabel8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(109, 22)
        Me.GunaLabel8.TabIndex = 186
        Me.GunaLabel8.Text = "Cust Name :"
        '
        'Guna2Separator3
        '
        Me.Guna2Separator3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator3.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator3.FillStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Separator3.FillThickness = 5
        Me.Guna2Separator3.Location = New System.Drawing.Point(2, 108)
        Me.Guna2Separator3.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Separator3.Name = "Guna2Separator3"
        Me.Guna2Separator3.Size = New System.Drawing.Size(444, 10)
        Me.Guna2Separator3.TabIndex = 184
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel11.Location = New System.Drawing.Point(2, 185)
        Me.GunaLabel11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(72, 22)
        Me.GunaLabel11.TabIndex = 185
        Me.GunaLabel11.Text = "Bill No :"
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Gill Sans MT Condensed", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.ForeColor = System.Drawing.Color.Firebrick
        Me.GunaLabel10.Location = New System.Drawing.Point(169, 120)
        Me.GunaLabel10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(119, 29)
        Me.GunaLabel10.TabIndex = 187
        Me.GunaLabel10.Text = "Print Receipt"
        '
        'GunaLabel12
        '
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel12.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel12.Location = New System.Drawing.Point(2, 157)
        Me.GunaLabel12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(92, 22)
        Me.GunaLabel12.TabIndex = 184
        Me.GunaLabel12.Text = "Bill Date : "
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Algerian", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel6.Location = New System.Drawing.Point(169, 76)
        Me.GunaLabel6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(255, 30)
        Me.GunaLabel6.TabIndex = 185
        Me.GunaLabel6.Text = "The Family Salon"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Algerian", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel4.Location = New System.Drawing.Point(118, 4)
        Me.GunaLabel4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(332, 71)
        Me.GunaLabel4.TabIndex = 184
        Me.GunaLabel4.Text = "Keshava"
        '
        'Guna2PictureBox4
        '
        Me.Guna2PictureBox4.Image = CType(resources.GetObject("Guna2PictureBox4.Image"), System.Drawing.Image)
        Me.Guna2PictureBox4.Location = New System.Drawing.Point(2, 2)
        Me.Guna2PictureBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2PictureBox4.Name = "Guna2PictureBox4"
        Me.Guna2PictureBox4.ShadowDecoration.Parent = Me.Guna2PictureBox4
        Me.Guna2PictureBox4.Size = New System.Drawing.Size(98, 102)
        Me.Guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox4.TabIndex = 184
        Me.Guna2PictureBox4.TabStop = False
        '
        'lblCusProdReportBillDate
        '
        Me.lblCusProdReportBillDate.AutoSize = True
        Me.lblCusProdReportBillDate.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCusProdReportBillDate.ForeColor = System.Drawing.Color.Black
        Me.lblCusProdReportBillDate.Location = New System.Drawing.Point(178, 189)
        Me.lblCusProdReportBillDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCusProdReportBillDate.Name = "lblCusProdReportBillDate"
        Me.lblCusProdReportBillDate.Size = New System.Drawing.Size(27, 31)
        Me.lblCusProdReportBillDate.TabIndex = 193
        Me.lblCusProdReportBillDate.Text = "-"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel1.Location = New System.Drawing.Point(14, 189)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(136, 31)
        Me.GunaLabel1.TabIndex = 192
        Me.GunaLabel1.Text = "Bill Date : "
        '
        'btnCusProdBillReportSearch
        '
        Me.btnCusProdBillReportSearch.AnimationHoverSpeed = 0.07!
        Me.btnCusProdBillReportSearch.AnimationSpeed = 0.03!
        Me.btnCusProdBillReportSearch.BaseColor = System.Drawing.Color.Transparent
        Me.btnCusProdBillReportSearch.BorderColor = System.Drawing.Color.Black
        Me.btnCusProdBillReportSearch.BorderSize = 3
        Me.btnCusProdBillReportSearch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCusProdBillReportSearch.FocusedColor = System.Drawing.Color.Empty
        Me.btnCusProdBillReportSearch.Font = New System.Drawing.Font("Algerian", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCusProdBillReportSearch.ForeColor = System.Drawing.Color.Black
        Me.btnCusProdBillReportSearch.Image = Nothing
        Me.btnCusProdBillReportSearch.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCusProdBillReportSearch.Location = New System.Drawing.Point(134, 266)
        Me.btnCusProdBillReportSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCusProdBillReportSearch.Name = "btnCusProdBillReportSearch"
        Me.btnCusProdBillReportSearch.OnHoverBaseColor = System.Drawing.Color.Black
        Me.btnCusProdBillReportSearch.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCusProdBillReportSearch.OnHoverForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCusProdBillReportSearch.OnHoverImage = Nothing
        Me.btnCusProdBillReportSearch.OnPressedColor = System.Drawing.Color.Black
        Me.btnCusProdBillReportSearch.Size = New System.Drawing.Size(107, 54)
        Me.btnCusProdBillReportSearch.TabIndex = 190
        Me.btnCusProdBillReportSearch.Text = "Search"
        Me.btnCusProdBillReportSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCusProdReportBillNo
        '
        Me.txtCusProdReportBillNo.BackColor = System.Drawing.Color.White
        Me.txtCusProdReportBillNo.BaseColor = System.Drawing.Color.White
        Me.txtCusProdReportBillNo.BorderColor = System.Drawing.Color.Black
        Me.txtCusProdReportBillNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCusProdReportBillNo.FocusedBaseColor = System.Drawing.Color.White
        Me.txtCusProdReportBillNo.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCusProdReportBillNo.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCusProdReportBillNo.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusProdReportBillNo.ForeColor = System.Drawing.Color.Black
        Me.txtCusProdReportBillNo.Location = New System.Drawing.Point(178, 90)
        Me.txtCusProdReportBillNo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCusProdReportBillNo.Name = "txtCusProdReportBillNo"
        Me.txtCusProdReportBillNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCusProdReportBillNo.SelectedText = ""
        Me.txtCusProdReportBillNo.Size = New System.Drawing.Size(152, 35)
        Me.txtCusProdReportBillNo.TabIndex = 189
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfname.ForeColor = System.Drawing.Color.Black
        Me.lblfname.Location = New System.Drawing.Point(16, 90)
        Me.lblfname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(116, 31)
        Me.lblfname.TabIndex = 191
        Me.lblfname.Text = "Bill No : "
        '
        'GunaLabel20
        '
        Me.GunaLabel20.AutoSize = True
        Me.GunaLabel20.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel20.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel20.Location = New System.Drawing.Point(156, 9)
        Me.GunaLabel20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel20.Name = "GunaLabel20"
        Me.GunaLabel20.Size = New System.Drawing.Size(597, 35)
        Me.GunaLabel20.TabIndex = 188
        Me.GunaLabel20.Text = "Customer Product - Sales Report"
        '
        'Guna2Separator6
        '
        Me.Guna2Separator6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator6.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator6.FillStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.Guna2Separator6.FillThickness = 8
        Me.Guna2Separator6.Location = New System.Drawing.Point(-160, 55)
        Me.Guna2Separator6.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Separator6.Name = "Guna2Separator6"
        Me.Guna2Separator6.Size = New System.Drawing.Size(1078, 8)
        Me.Guna2Separator6.TabIndex = 187
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.FillColor = System.Drawing.Color.Black
        Me.Guna2VSeparator1.FillStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.Guna2VSeparator1.FillThickness = 7
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(916, 6)
        Me.Guna2VSeparator1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(8, 810)
        Me.Guna2VSeparator1.TabIndex = 186
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator2.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator2.FillStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.Guna2Separator2.FillThickness = 8
        Me.Guna2Separator2.Location = New System.Drawing.Point(925, 55)
        Me.Guna2Separator2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(415, 8)
        Me.Guna2Separator2.TabIndex = 205
        '
        'Guna2VSeparator2
        '
        Me.Guna2VSeparator2.FillColor = System.Drawing.Color.Black
        Me.Guna2VSeparator2.FillThickness = 7
        Me.Guna2VSeparator2.Location = New System.Drawing.Point(363, 66)
        Me.Guna2VSeparator2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2VSeparator2.Name = "Guna2VSeparator2"
        Me.Guna2VSeparator2.Size = New System.Drawing.Size(9, 296)
        Me.Guna2VSeparator2.TabIndex = 194
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel2.Location = New System.Drawing.Point(928, 6)
        Me.GunaLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(400, 35)
        Me.GunaLabel2.TabIndex = 204
        Me.GunaLabel2.Text = "Print Reciept Preview"
        '
        'dgvCusServBillReport
        '
        Me.dgvCusServBillReport.AllowUserToAddRows = False
        Me.dgvCusServBillReport.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvCusServBillReport.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCusServBillReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCusServBillReport.BackgroundColor = System.Drawing.Color.White
        Me.dgvCusServBillReport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCusServBillReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCusServBillReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCusServBillReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCusServBillReport.ColumnHeadersHeight = 30
        Me.dgvCusServBillReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCusServBillReport.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCusServBillReport.EnableHeadersVisualStyles = False
        Me.dgvCusServBillReport.GridColor = System.Drawing.Color.Black
        Me.dgvCusServBillReport.Location = New System.Drawing.Point(0, 367)
        Me.dgvCusServBillReport.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvCusServBillReport.Name = "dgvCusServBillReport"
        Me.dgvCusServBillReport.ReadOnly = True
        Me.dgvCusServBillReport.RowHeadersVisible = False
        Me.dgvCusServBillReport.RowHeadersWidth = 51
        Me.dgvCusServBillReport.RowTemplate.Height = 24
        Me.dgvCusServBillReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCusServBillReport.Size = New System.Drawing.Size(913, 448)
        Me.dgvCusServBillReport.TabIndex = 203
        Me.dgvCusServBillReport.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvCusServBillReport.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCusServBillReport.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvCusServBillReport.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvCusServBillReport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvCusServBillReport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvCusServBillReport.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvCusServBillReport.ThemeStyle.GridColor = System.Drawing.Color.Black
        Me.dgvCusServBillReport.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCusServBillReport.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCusServBillReport.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvCusServBillReport.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCusServBillReport.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvCusServBillReport.ThemeStyle.HeaderStyle.Height = 30
        Me.dgvCusServBillReport.ThemeStyle.ReadOnly = True
        Me.dgvCusServBillReport.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCusServBillReport.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCusServBillReport.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvCusServBillReport.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvCusServBillReport.ThemeStyle.RowsStyle.Height = 24
        Me.dgvCusServBillReport.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCusServBillReport.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product Category"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Product Name"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Product Quantity"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Price"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator1.FillStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.Guna2Separator1.FillThickness = 8
        Me.Guna2Separator1.Location = New System.Drawing.Point(-2, 356)
        Me.Guna2Separator1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(919, 8)
        Me.Guna2Separator1.TabIndex = 195
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Gill Sans MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.Maroon
        Me.GunaLabel3.Location = New System.Drawing.Point(376, 66)
        Me.GunaLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(173, 25)
        Me.GunaLabel3.TabIndex = 196
        Me.GunaLabel3.Text = "*Customer Billing Details"
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel9.Location = New System.Drawing.Point(388, 222)
        Me.GunaLabel9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(216, 31)
        Me.GunaLabel9.TabIndex = 201
        Me.GunaLabel9.Text = "Customer Adress :"
        '
        'lblCusProdBillCusName
        '
        Me.lblCusProdBillCusName.AutoSize = True
        Me.lblCusProdBillCusName.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCusProdBillCusName.ForeColor = System.Drawing.Color.Black
        Me.lblCusProdBillCusName.Location = New System.Drawing.Point(689, 161)
        Me.lblCusProdBillCusName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCusProdBillCusName.Name = "lblCusProdBillCusName"
        Me.lblCusProdBillCusName.Size = New System.Drawing.Size(27, 31)
        Me.lblCusProdBillCusName.TabIndex = 200
        Me.lblCusProdBillCusName.Text = "-"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel7.Location = New System.Drawing.Point(388, 161)
        Me.GunaLabel7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(201, 31)
        Me.GunaLabel7.TabIndex = 199
        Me.GunaLabel7.Text = "Customer Name :"
        '
        'lblCusProdBillCusMobile
        '
        Me.lblCusProdBillCusMobile.AutoSize = True
        Me.lblCusProdBillCusMobile.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCusProdBillCusMobile.ForeColor = System.Drawing.Color.Black
        Me.lblCusProdBillCusMobile.Location = New System.Drawing.Point(754, 106)
        Me.lblCusProdBillCusMobile.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCusProdBillCusMobile.Name = "lblCusProdBillCusMobile"
        Me.lblCusProdBillCusMobile.Size = New System.Drawing.Size(27, 31)
        Me.lblCusProdBillCusMobile.TabIndex = 198
        Me.lblCusProdBillCusMobile.Text = "-"
        '
        'lblCusProdBillCusAddress
        '
        Me.lblCusProdBillCusAddress.AutoSize = True
        Me.lblCusProdBillCusAddress.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCusProdBillCusAddress.ForeColor = System.Drawing.Color.Black
        Me.lblCusProdBillCusAddress.Location = New System.Drawing.Point(689, 222)
        Me.lblCusProdBillCusAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCusProdBillCusAddress.Name = "lblCusProdBillCusAddress"
        Me.lblCusProdBillCusAddress.Size = New System.Drawing.Size(27, 31)
        Me.lblCusProdBillCusAddress.TabIndex = 202
        Me.lblCusProdBillCusAddress.Text = "-"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel5.Location = New System.Drawing.Point(388, 106)
        Me.GunaLabel5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(260, 31)
        Me.GunaLabel5.TabIndex = 197
        Me.GunaLabel5.Text = "Customer Mobile No : "
        '
        'GunaLabel13
        '
        Me.GunaLabel13.AutoSize = True
        Me.GunaLabel13.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel13.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel13.Location = New System.Drawing.Point(642, 106)
        Me.GunaLabel13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel13.Name = "GunaLabel13"
        Me.GunaLabel13.Size = New System.Drawing.Size(69, 31)
        Me.GunaLabel13.TabIndex = 209
        Me.GunaLabel13.Text = "(+91)"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'UC_ProductSalesReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.GunaLabel13)
        Me.Controls.Add(Me.btnClearProdReceipt)
        Me.Controls.Add(Me.btnPrintProdReceipt)
        Me.Controls.Add(Me.pnlCusProdReceipt)
        Me.Controls.Add(Me.lblCusProdReportBillDate)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.btnCusProdBillReportSearch)
        Me.Controls.Add(Me.txtCusProdReportBillNo)
        Me.Controls.Add(Me.lblfname)
        Me.Controls.Add(Me.GunaLabel20)
        Me.Controls.Add(Me.Guna2Separator6)
        Me.Controls.Add(Me.Guna2VSeparator1)
        Me.Controls.Add(Me.Guna2Separator2)
        Me.Controls.Add(Me.Guna2VSeparator2)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.dgvCusServBillReport)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel9)
        Me.Controls.Add(Me.lblCusProdBillCusName)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.lblCusProdBillCusMobile)
        Me.Controls.Add(Me.lblCusProdBillCusAddress)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "UC_ProductSalesReports"
        Me.Size = New System.Drawing.Size(1411, 995)
        Me.pnlCusProdReceipt.ResumeLayout(False)
        Me.pnlCusProdReceipt.PerformLayout()
        CType(Me.dgvprintReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCusServBillReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClearProdReceipt As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents btnPrintProdReceipt As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents pnlCusProdReceipt As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaLabel23 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Separator4 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents lblProdReceiptTotalRs As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel22 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblProdReceiptQuantity As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel19 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblProdReceiptCusMob As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel17 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblProdReceiptBillNo As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblProdReceiptCusName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblProdReceiptBillDate As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2PictureBox4 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblCusProdReportBillDate As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnCusProdBillReportSearch As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtCusProdReportBillNo As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblfname As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel20 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Separator6 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2VSeparator2 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dgvCusServBillReport As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblCusProdBillCusName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblCusProdBillCusMobile As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblCusProdBillCusAddress As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel13 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents dgvprintReceipt As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
