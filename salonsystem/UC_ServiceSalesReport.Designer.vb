<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_ServiceSalesReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_ServiceSalesReport))
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnClearServReceipt = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaLabel23 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Separator4 = New Guna.UI2.WinForms.Guna2Separator()
        Me.lblServReceiptTotalRs = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel22 = New Guna.UI.WinForms.GunaLabel()
        Me.lblServReceiptQuantity = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel19 = New Guna.UI.WinForms.GunaLabel()
        Me.lblServReceiptCusMob = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel17 = New Guna.UI.WinForms.GunaLabel()
        Me.lblServReceiptBillNo = New Guna.UI.WinForms.GunaLabel()
        Me.lblServReceiptCusName = New Guna.UI.WinForms.GunaLabel()
        Me.lblServReceiptBillDate = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2PictureBox4 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnPrintServReceipt = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.pnlCusProdReceipt = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvprintReceipt = New System.Windows.Forms.DataGridView()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.dgvCusServBillReport = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCusServBillCusAddress = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.lblCusServBillCusName = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.lblCusServBillCusMobile = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2VSeparator2 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.lblCusServReportBillDate = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btnCusServBillReportSearch = New Guna.UI.WinForms.GunaButton()
        Me.txtCusServReportBillNo = New Guna.UI.WinForms.GunaTextBox()
        Me.lblfname = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel20 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Separator6 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.GunaLabel13 = New Guna.UI.WinForms.GunaLabel()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCusProdReceipt.SuspendLayout()
        CType(Me.dgvprintReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCusServBillReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClearServReceipt
        '
        Me.btnClearServReceipt.AnimationHoverSpeed = 0.07!
        Me.btnClearServReceipt.AnimationSpeed = 0.03!
        Me.btnClearServReceipt.BaseColor = System.Drawing.Color.Transparent
        Me.btnClearServReceipt.BorderColor = System.Drawing.Color.Black
        Me.btnClearServReceipt.BorderSize = 3
        Me.btnClearServReceipt.CheckedBaseColor = System.Drawing.Color.Blue
        Me.btnClearServReceipt.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnClearServReceipt.CheckedForeColor = System.Drawing.Color.Black
        Me.btnClearServReceipt.CheckedImage = CType(resources.GetObject("btnClearServReceipt.CheckedImage"), System.Drawing.Image)
        Me.btnClearServReceipt.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnClearServReceipt.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClearServReceipt.FocusedColor = System.Drawing.Color.Empty
        Me.btnClearServReceipt.Font = New System.Drawing.Font("Gill Sans MT Condensed", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearServReceipt.ForeColor = System.Drawing.Color.Black
        Me.btnClearServReceipt.Image = CType(resources.GetObject("btnClearServReceipt.Image"), System.Drawing.Image)
        Me.btnClearServReceipt.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnClearServReceipt.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnClearServReceipt.Location = New System.Drawing.Point(1537, 866)
        Me.btnClearServReceipt.Name = "btnClearServReceipt"
        Me.btnClearServReceipt.OnHoverBaseColor = System.Drawing.Color.Blue
        Me.btnClearServReceipt.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClearServReceipt.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClearServReceipt.OnHoverImage = Nothing
        Me.btnClearServReceipt.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnClearServReceipt.OnPressedColor = System.Drawing.Color.Blue
        Me.btnClearServReceipt.Size = New System.Drawing.Size(176, 116)
        Me.btnClearServReceipt.TabIndex = 211
        Me.btnClearServReceipt.Text = "Clear"
        '
        'GunaLabel23
        '
        Me.GunaLabel23.AutoSize = True
        Me.GunaLabel23.Font = New System.Drawing.Font("Algerian", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel23.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel23.Location = New System.Drawing.Point(91, 685)
        Me.GunaLabel23.Name = "GunaLabel23"
        Me.GunaLabel23.Size = New System.Drawing.Size(273, 72)
        Me.GunaLabel23.TabIndex = 198
        Me.GunaLabel23.Text = "Thank You" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For Your Visit!!"
        Me.GunaLabel23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Separator4
        '
        Me.Guna2Separator4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator4.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator4.FillThickness = 3
        Me.Guna2Separator4.Location = New System.Drawing.Point(2, 672)
        Me.Guna2Separator4.Name = "Guna2Separator4"
        Me.Guna2Separator4.Size = New System.Drawing.Size(457, 10)
        Me.Guna2Separator4.TabIndex = 197
        '
        'lblServReceiptTotalRs
        '
        Me.lblServReceiptTotalRs.AutoSize = True
        Me.lblServReceiptTotalRs.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServReceiptTotalRs.ForeColor = System.Drawing.Color.Black
        Me.lblServReceiptTotalRs.Location = New System.Drawing.Point(385, 643)
        Me.lblServReceiptTotalRs.Name = "lblServReceiptTotalRs"
        Me.lblServReceiptTotalRs.Size = New System.Drawing.Size(19, 26)
        Me.lblServReceiptTotalRs.TabIndex = 196
        Me.lblServReceiptTotalRs.Text = "-"
        '
        'GunaLabel22
        '
        Me.GunaLabel22.AutoSize = True
        Me.GunaLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel22.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel22.Location = New System.Drawing.Point(256, 643)
        Me.GunaLabel22.Name = "GunaLabel22"
        Me.GunaLabel22.Size = New System.Drawing.Size(114, 26)
        Me.GunaLabel22.TabIndex = 195
        Me.GunaLabel22.Text = "Total : Rs"
        '
        'lblServReceiptQuantity
        '
        Me.lblServReceiptQuantity.AutoSize = True
        Me.lblServReceiptQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServReceiptQuantity.ForeColor = System.Drawing.Color.Black
        Me.lblServReceiptQuantity.Location = New System.Drawing.Point(190, 643)
        Me.lblServReceiptQuantity.Name = "lblServReceiptQuantity"
        Me.lblServReceiptQuantity.Size = New System.Drawing.Size(19, 26)
        Me.lblServReceiptQuantity.TabIndex = 194
        Me.lblServReceiptQuantity.Text = "-"
        '
        'GunaLabel19
        '
        Me.GunaLabel19.AutoSize = True
        Me.GunaLabel19.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel19.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel19.Location = New System.Drawing.Point(3, 643)
        Me.GunaLabel19.Name = "GunaLabel19"
        Me.GunaLabel19.Size = New System.Drawing.Size(172, 26)
        Me.GunaLabel19.TabIndex = 193
        Me.GunaLabel19.Text = "No of Person : "
        '
        'lblServReceiptCusMob
        '
        Me.lblServReceiptCusMob.AutoSize = True
        Me.lblServReceiptCusMob.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServReceiptCusMob.ForeColor = System.Drawing.Color.Black
        Me.lblServReceiptCusMob.Location = New System.Drawing.Point(287, 231)
        Me.lblServReceiptCusMob.Name = "lblServReceiptCusMob"
        Me.lblServReceiptCusMob.Size = New System.Drawing.Size(19, 26)
        Me.lblServReceiptCusMob.TabIndex = 190
        Me.lblServReceiptCusMob.Text = "-"
        '
        'GunaLabel17
        '
        Me.GunaLabel17.AutoSize = True
        Me.GunaLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel17.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel17.Location = New System.Drawing.Point(178, 230)
        Me.GunaLabel17.Name = "GunaLabel17"
        Me.GunaLabel17.Size = New System.Drawing.Size(106, 26)
        Me.GunaLabel17.TabIndex = 191
        Me.GunaLabel17.Text = "Mob No : "
        '
        'lblServReceiptBillNo
        '
        Me.lblServReceiptBillNo.AutoSize = True
        Me.lblServReceiptBillNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServReceiptBillNo.ForeColor = System.Drawing.Color.Black
        Me.lblServReceiptBillNo.Location = New System.Drawing.Point(96, 228)
        Me.lblServReceiptBillNo.Name = "lblServReceiptBillNo"
        Me.lblServReceiptBillNo.Size = New System.Drawing.Size(19, 26)
        Me.lblServReceiptBillNo.TabIndex = 189
        Me.lblServReceiptBillNo.Text = "-"
        '
        'lblServReceiptCusName
        '
        Me.lblServReceiptCusName.AutoSize = True
        Me.lblServReceiptCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServReceiptCusName.ForeColor = System.Drawing.Color.Black
        Me.lblServReceiptCusName.Location = New System.Drawing.Point(147, 265)
        Me.lblServReceiptCusName.Name = "lblServReceiptCusName"
        Me.lblServReceiptCusName.Size = New System.Drawing.Size(19, 26)
        Me.lblServReceiptCusName.TabIndex = 188
        Me.lblServReceiptCusName.Text = "-"
        '
        'lblServReceiptBillDate
        '
        Me.lblServReceiptBillDate.AutoSize = True
        Me.lblServReceiptBillDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServReceiptBillDate.ForeColor = System.Drawing.Color.Black
        Me.lblServReceiptBillDate.Location = New System.Drawing.Point(109, 193)
        Me.lblServReceiptBillDate.Name = "lblServReceiptBillDate"
        Me.lblServReceiptBillDate.Size = New System.Drawing.Size(19, 26)
        Me.lblServReceiptBillDate.TabIndex = 184
        Me.lblServReceiptBillDate.Text = "-"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel8.Location = New System.Drawing.Point(1, 264)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(134, 26)
        Me.GunaLabel8.TabIndex = 186
        Me.GunaLabel8.Text = "Cust Name :"
        '
        'Guna2Separator3
        '
        Me.Guna2Separator3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator3.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator3.FillStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Separator3.FillThickness = 5
        Me.Guna2Separator3.Location = New System.Drawing.Point(2, 133)
        Me.Guna2Separator3.Name = "Guna2Separator3"
        Me.Guna2Separator3.Size = New System.Drawing.Size(457, 10)
        Me.Guna2Separator3.TabIndex = 184
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel11.Location = New System.Drawing.Point(3, 228)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(88, 26)
        Me.GunaLabel11.TabIndex = 185
        Me.GunaLabel11.Text = "Bill No :"
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Gill Sans MT Condensed", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.ForeColor = System.Drawing.Color.Firebrick
        Me.GunaLabel10.Location = New System.Drawing.Point(161, 143)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(142, 37)
        Me.GunaLabel10.TabIndex = 187
        Me.GunaLabel10.Text = "Print Receipt"
        '
        'GunaLabel12
        '
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel12.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel12.Location = New System.Drawing.Point(3, 193)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(112, 26)
        Me.GunaLabel12.TabIndex = 184
        Me.GunaLabel12.Text = "Bill Date : "
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Algerian", 18.0!)
        Me.GunaLabel6.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel6.Location = New System.Drawing.Point(152, 94)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(285, 34)
        Me.GunaLabel6.TabIndex = 185
        Me.GunaLabel6.Text = "The Family Salon"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Algerian", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel4.Location = New System.Drawing.Point(158, 5)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(279, 89)
        Me.GunaLabel4.TabIndex = 184
        Me.GunaLabel4.Text = "Milan"
        '
        'Guna2PictureBox4
        '
        Me.Guna2PictureBox4.Image = CType(resources.GetObject("Guna2PictureBox4.Image"), System.Drawing.Image)
        Me.Guna2PictureBox4.Location = New System.Drawing.Point(3, 3)
        Me.Guna2PictureBox4.Name = "Guna2PictureBox4"
        Me.Guna2PictureBox4.ShadowDecoration.Parent = Me.Guna2PictureBox4
        Me.Guna2PictureBox4.Size = New System.Drawing.Size(130, 126)
        Me.Guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox4.TabIndex = 184
        Me.Guna2PictureBox4.TabStop = False
        '
        'btnPrintServReceipt
        '
        Me.btnPrintServReceipt.AnimationHoverSpeed = 0.07!
        Me.btnPrintServReceipt.AnimationSpeed = 0.03!
        Me.btnPrintServReceipt.BaseColor = System.Drawing.Color.Transparent
        Me.btnPrintServReceipt.BorderColor = System.Drawing.Color.Black
        Me.btnPrintServReceipt.BorderSize = 3
        Me.btnPrintServReceipt.CheckedBaseColor = System.Drawing.Color.Blue
        Me.btnPrintServReceipt.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnPrintServReceipt.CheckedForeColor = System.Drawing.Color.Black
        Me.btnPrintServReceipt.CheckedImage = CType(resources.GetObject("btnPrintServReceipt.CheckedImage"), System.Drawing.Image)
        Me.btnPrintServReceipt.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnPrintServReceipt.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPrintServReceipt.FocusedColor = System.Drawing.Color.Empty
        Me.btnPrintServReceipt.Font = New System.Drawing.Font("Gill Sans MT Condensed", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintServReceipt.ForeColor = System.Drawing.Color.Black
        Me.btnPrintServReceipt.Image = CType(resources.GetObject("btnPrintServReceipt.Image"), System.Drawing.Image)
        Me.btnPrintServReceipt.ImageSize = New System.Drawing.Size(60, 60)
        Me.btnPrintServReceipt.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnPrintServReceipt.Location = New System.Drawing.Point(1296, 866)
        Me.btnPrintServReceipt.Name = "btnPrintServReceipt"
        Me.btnPrintServReceipt.OnHoverBaseColor = System.Drawing.Color.Blue
        Me.btnPrintServReceipt.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPrintServReceipt.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPrintServReceipt.OnHoverImage = Nothing
        Me.btnPrintServReceipt.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnPrintServReceipt.OnPressedColor = System.Drawing.Color.Blue
        Me.btnPrintServReceipt.Size = New System.Drawing.Size(176, 116)
        Me.btnPrintServReceipt.TabIndex = 210
        Me.btnPrintServReceipt.Text = "Print"
        '
        'pnlCusProdReceipt
        '
        Me.pnlCusProdReceipt.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlCusProdReceipt.Controls.Add(Me.dgvprintReceipt)
        Me.pnlCusProdReceipt.Controls.Add(Me.GunaLabel23)
        Me.pnlCusProdReceipt.Controls.Add(Me.Guna2Separator4)
        Me.pnlCusProdReceipt.Controls.Add(Me.lblServReceiptTotalRs)
        Me.pnlCusProdReceipt.Controls.Add(Me.GunaLabel22)
        Me.pnlCusProdReceipt.Controls.Add(Me.lblServReceiptQuantity)
        Me.pnlCusProdReceipt.Controls.Add(Me.GunaLabel19)
        Me.pnlCusProdReceipt.Controls.Add(Me.lblServReceiptCusMob)
        Me.pnlCusProdReceipt.Controls.Add(Me.GunaLabel17)
        Me.pnlCusProdReceipt.Controls.Add(Me.lblServReceiptBillNo)
        Me.pnlCusProdReceipt.Controls.Add(Me.lblServReceiptCusName)
        Me.pnlCusProdReceipt.Controls.Add(Me.lblServReceiptBillDate)
        Me.pnlCusProdReceipt.Controls.Add(Me.GunaLabel8)
        Me.pnlCusProdReceipt.Controls.Add(Me.Guna2Separator3)
        Me.pnlCusProdReceipt.Controls.Add(Me.GunaLabel11)
        Me.pnlCusProdReceipt.Controls.Add(Me.GunaLabel10)
        Me.pnlCusProdReceipt.Controls.Add(Me.GunaLabel12)
        Me.pnlCusProdReceipt.Controls.Add(Me.GunaLabel6)
        Me.pnlCusProdReceipt.Controls.Add(Me.GunaLabel4)
        Me.pnlCusProdReceipt.Controls.Add(Me.Guna2PictureBox4)
        Me.pnlCusProdReceipt.Location = New System.Drawing.Point(1276, 84)
        Me.pnlCusProdReceipt.Name = "pnlCusProdReceipt"
        Me.pnlCusProdReceipt.ShadowDecoration.Parent = Me.pnlCusProdReceipt
        Me.pnlCusProdReceipt.Size = New System.Drawing.Size(462, 771)
        Me.pnlCusProdReceipt.TabIndex = 209
        '
        'dgvprintReceipt
        '
        Me.dgvprintReceipt.AllowUserToAddRows = False
        Me.dgvprintReceipt.AllowUserToDeleteRows = False
        Me.dgvprintReceipt.AllowUserToOrderColumns = True
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvprintReceipt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.dgvprintReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvprintReceipt.DefaultCellStyle = DataGridViewCellStyle20
        Me.dgvprintReceipt.Location = New System.Drawing.Point(3, 293)
        Me.dgvprintReceipt.Name = "dgvprintReceipt"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvprintReceipt.RowHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.dgvprintReceipt.RowHeadersWidth = 51
        Me.dgvprintReceipt.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Silver
        Me.dgvprintReceipt.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvprintReceipt.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dgvprintReceipt.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvprintReceipt.RowTemplate.Height = 24
        Me.dgvprintReceipt.Size = New System.Drawing.Size(456, 336)
        Me.dgvprintReceipt.TabIndex = 199
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator2.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator2.FillStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.Guna2Separator2.FillThickness = 8
        Me.Guna2Separator2.Location = New System.Drawing.Point(1236, 68)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(553, 10)
        Me.Guna2Separator2.TabIndex = 208
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel2.Location = New System.Drawing.Point(1241, 11)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(494, 45)
        Me.GunaLabel2.TabIndex = 207
        Me.GunaLabel2.Text = "Print Reciept Preview"
        '
        'dgvCusServBillReport
        '
        Me.dgvCusServBillReport.AllowUserToAddRows = False
        Me.dgvCusServBillReport.AllowUserToDeleteRows = False
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.White
        Me.dgvCusServBillReport.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle22
        Me.dgvCusServBillReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCusServBillReport.BackgroundColor = System.Drawing.Color.White
        Me.dgvCusServBillReport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCusServBillReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCusServBillReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCusServBillReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.dgvCusServBillReport.ColumnHeadersHeight = 30
        Me.dgvCusServBillReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCusServBillReport.DefaultCellStyle = DataGridViewCellStyle24
        Me.dgvCusServBillReport.EnableHeadersVisualStyles = False
        Me.dgvCusServBillReport.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCusServBillReport.Location = New System.Drawing.Point(0, 452)
        Me.dgvCusServBillReport.Name = "dgvCusServBillReport"
        Me.dgvCusServBillReport.ReadOnly = True
        Me.dgvCusServBillReport.RowHeadersVisible = False
        Me.dgvCusServBillReport.RowHeadersWidth = 51
        Me.dgvCusServBillReport.RowTemplate.Height = 24
        Me.dgvCusServBillReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCusServBillReport.Size = New System.Drawing.Size(1217, 551)
        Me.dgvCusServBillReport.TabIndex = 206
        Me.dgvCusServBillReport.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvCusServBillReport.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCusServBillReport.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvCusServBillReport.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvCusServBillReport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvCusServBillReport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvCusServBillReport.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvCusServBillReport.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
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
        Me.Column1.HeaderText = "Service Name"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Sub Service Name"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Employee Name"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "No of Person"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Rate"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Total Amount"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'lblCusServBillCusAddress
        '
        Me.lblCusServBillCusAddress.AutoSize = True
        Me.lblCusServBillCusAddress.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCusServBillCusAddress.ForeColor = System.Drawing.Color.Black
        Me.lblCusServBillCusAddress.Location = New System.Drawing.Point(947, 273)
        Me.lblCusServBillCusAddress.Name = "lblCusServBillCusAddress"
        Me.lblCusServBillCusAddress.Size = New System.Drawing.Size(34, 39)
        Me.lblCusServBillCusAddress.TabIndex = 205
        Me.lblCusServBillCusAddress.Text = "-"
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel9.Location = New System.Drawing.Point(580, 273)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(271, 39)
        Me.GunaLabel9.TabIndex = 204
        Me.GunaLabel9.Text = "Customer Adress :"
        '
        'lblCusServBillCusName
        '
        Me.lblCusServBillCusName.AutoSize = True
        Me.lblCusServBillCusName.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCusServBillCusName.ForeColor = System.Drawing.Color.Black
        Me.lblCusServBillCusName.Location = New System.Drawing.Point(947, 198)
        Me.lblCusServBillCusName.Name = "lblCusServBillCusName"
        Me.lblCusServBillCusName.Size = New System.Drawing.Size(34, 39)
        Me.lblCusServBillCusName.TabIndex = 203
        Me.lblCusServBillCusName.Text = "-"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel7.Location = New System.Drawing.Point(580, 198)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(255, 39)
        Me.GunaLabel7.TabIndex = 202
        Me.GunaLabel7.Text = "Customer Name :"
        '
        'lblCusServBillCusMobile
        '
        Me.lblCusServBillCusMobile.AutoSize = True
        Me.lblCusServBillCusMobile.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCusServBillCusMobile.ForeColor = System.Drawing.Color.Black
        Me.lblCusServBillCusMobile.Location = New System.Drawing.Point(1008, 130)
        Me.lblCusServBillCusMobile.Name = "lblCusServBillCusMobile"
        Me.lblCusServBillCusMobile.Size = New System.Drawing.Size(34, 39)
        Me.lblCusServBillCusMobile.TabIndex = 201
        Me.lblCusServBillCusMobile.Text = "-"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel5.Location = New System.Drawing.Point(580, 131)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(329, 39)
        Me.GunaLabel5.TabIndex = 200
        Me.GunaLabel5.Text = "Customer Mobile No : "
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Gill Sans MT Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.Maroon
        Me.GunaLabel3.Location = New System.Drawing.Point(565, 81)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(215, 29)
        Me.GunaLabel3.TabIndex = 199
        Me.GunaLabel3.Text = "*Customer Billing Details"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator1.FillStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.Guna2Separator1.FillThickness = 8
        Me.Guna2Separator1.Location = New System.Drawing.Point(-2, 438)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(1225, 10)
        Me.Guna2Separator1.TabIndex = 198
        '
        'Guna2VSeparator2
        '
        Me.Guna2VSeparator2.FillColor = System.Drawing.Color.Black
        Me.Guna2VSeparator2.FillThickness = 7
        Me.Guna2VSeparator2.Location = New System.Drawing.Point(511, 81)
        Me.Guna2VSeparator2.Name = "Guna2VSeparator2"
        Me.Guna2VSeparator2.Size = New System.Drawing.Size(12, 364)
        Me.Guna2VSeparator2.TabIndex = 197
        '
        'lblCusServReportBillDate
        '
        Me.lblCusServReportBillDate.AutoSize = True
        Me.lblCusServReportBillDate.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCusServReportBillDate.ForeColor = System.Drawing.Color.Black
        Me.lblCusServReportBillDate.Location = New System.Drawing.Point(238, 233)
        Me.lblCusServReportBillDate.Name = "lblCusServReportBillDate"
        Me.lblCusServReportBillDate.Size = New System.Drawing.Size(34, 39)
        Me.lblCusServReportBillDate.TabIndex = 196
        Me.lblCusServReportBillDate.Text = "-"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel1.Location = New System.Drawing.Point(19, 233)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(172, 39)
        Me.GunaLabel1.TabIndex = 195
        Me.GunaLabel1.Text = "Bill Date : "
        '
        'btnCusServBillReportSearch
        '
        Me.btnCusServBillReportSearch.AnimationHoverSpeed = 0.07!
        Me.btnCusServBillReportSearch.AnimationSpeed = 0.03!
        Me.btnCusServBillReportSearch.BaseColor = System.Drawing.Color.Transparent
        Me.btnCusServBillReportSearch.BorderColor = System.Drawing.Color.Black
        Me.btnCusServBillReportSearch.BorderSize = 3
        Me.btnCusServBillReportSearch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCusServBillReportSearch.FocusedColor = System.Drawing.Color.Empty
        Me.btnCusServBillReportSearch.Font = New System.Drawing.Font("Algerian", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCusServBillReportSearch.ForeColor = System.Drawing.Color.Black
        Me.btnCusServBillReportSearch.Image = Nothing
        Me.btnCusServBillReportSearch.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCusServBillReportSearch.Location = New System.Drawing.Point(179, 327)
        Me.btnCusServBillReportSearch.Name = "btnCusServBillReportSearch"
        Me.btnCusServBillReportSearch.OnHoverBaseColor = System.Drawing.Color.Black
        Me.btnCusServBillReportSearch.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCusServBillReportSearch.OnHoverForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCusServBillReportSearch.OnHoverImage = Nothing
        Me.btnCusServBillReportSearch.OnPressedColor = System.Drawing.Color.Black
        Me.btnCusServBillReportSearch.Size = New System.Drawing.Size(143, 67)
        Me.btnCusServBillReportSearch.TabIndex = 193
        Me.btnCusServBillReportSearch.Text = "Search"
        Me.btnCusServBillReportSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCusServReportBillNo
        '
        Me.txtCusServReportBillNo.BackColor = System.Drawing.Color.White
        Me.txtCusServReportBillNo.BaseColor = System.Drawing.Color.White
        Me.txtCusServReportBillNo.BorderColor = System.Drawing.Color.Black
        Me.txtCusServReportBillNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCusServReportBillNo.FocusedBaseColor = System.Drawing.Color.White
        Me.txtCusServReportBillNo.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCusServReportBillNo.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCusServReportBillNo.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusServReportBillNo.ForeColor = System.Drawing.Color.Black
        Me.txtCusServReportBillNo.Location = New System.Drawing.Point(237, 111)
        Me.txtCusServReportBillNo.Name = "txtCusServReportBillNo"
        Me.txtCusServReportBillNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCusServReportBillNo.SelectedText = ""
        Me.txtCusServReportBillNo.Size = New System.Drawing.Size(202, 41)
        Me.txtCusServReportBillNo.TabIndex = 192
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfname.ForeColor = System.Drawing.Color.Black
        Me.lblfname.Location = New System.Drawing.Point(22, 111)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(145, 39)
        Me.lblfname.TabIndex = 194
        Me.lblfname.Text = "Bill No : "
        '
        'GunaLabel20
        '
        Me.GunaLabel20.AutoSize = True
        Me.GunaLabel20.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel20.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel20.Location = New System.Drawing.Point(253, 11)
        Me.GunaLabel20.Name = "GunaLabel20"
        Me.GunaLabel20.Size = New System.Drawing.Size(708, 45)
        Me.GunaLabel20.TabIndex = 191
        Me.GunaLabel20.Text = "Customer Services - Bill Report"
        '
        'Guna2Separator6
        '
        Me.Guna2Separator6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator6.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator6.FillStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.Guna2Separator6.FillThickness = 8
        Me.Guna2Separator6.Location = New System.Drawing.Point(-214, 68)
        Me.Guna2Separator6.Name = "Guna2Separator6"
        Me.Guna2Separator6.Size = New System.Drawing.Size(1437, 10)
        Me.Guna2Separator6.TabIndex = 190
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.FillColor = System.Drawing.Color.Black
        Me.Guna2VSeparator1.FillStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.Guna2VSeparator1.FillThickness = 7
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(1221, 8)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(10, 997)
        Me.Guna2VSeparator1.TabIndex = 189
        '
        'GunaLabel13
        '
        Me.GunaLabel13.AutoSize = True
        Me.GunaLabel13.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel13.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel13.Location = New System.Drawing.Point(893, 131)
        Me.GunaLabel13.Name = "GunaLabel13"
        Me.GunaLabel13.Size = New System.Drawing.Size(88, 39)
        Me.GunaLabel13.TabIndex = 212
        Me.GunaLabel13.Text = "(+91)"
        '
        'PrintDocument1
        '
        '
        'UC_ServiceSalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.GunaLabel13)
        Me.Controls.Add(Me.btnClearServReceipt)
        Me.Controls.Add(Me.btnPrintServReceipt)
        Me.Controls.Add(Me.pnlCusProdReceipt)
        Me.Controls.Add(Me.Guna2Separator2)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.dgvCusServBillReport)
        Me.Controls.Add(Me.lblCusServBillCusAddress)
        Me.Controls.Add(Me.GunaLabel9)
        Me.Controls.Add(Me.lblCusServBillCusName)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.lblCusServBillCusMobile)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.Guna2VSeparator2)
        Me.Controls.Add(Me.lblCusServReportBillDate)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.btnCusServBillReportSearch)
        Me.Controls.Add(Me.txtCusServReportBillNo)
        Me.Controls.Add(Me.lblfname)
        Me.Controls.Add(Me.GunaLabel20)
        Me.Controls.Add(Me.Guna2Separator6)
        Me.Controls.Add(Me.Guna2VSeparator1)
        Me.Name = "UC_ServiceSalesReport"
        Me.Size = New System.Drawing.Size(1768, 1003)
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCusProdReceipt.ResumeLayout(False)
        Me.pnlCusProdReceipt.PerformLayout()
        CType(Me.dgvprintReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCusServBillReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClearServReceipt As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaLabel23 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Separator4 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents lblServReceiptTotalRs As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel22 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblServReceiptQuantity As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel19 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblServReceiptCusMob As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel17 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblServReceiptBillNo As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblServReceiptCusName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblServReceiptBillDate As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2PictureBox4 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnPrintServReceipt As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents pnlCusProdReceipt As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dgvCusServBillReport As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblCusServBillCusAddress As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblCusServBillCusName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblCusServBillCusMobile As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2VSeparator2 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents lblCusServReportBillDate As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnCusServBillReportSearch As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtCusServReportBillNo As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblfname As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel20 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Separator6 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents GunaLabel13 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dgvprintReceipt As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
