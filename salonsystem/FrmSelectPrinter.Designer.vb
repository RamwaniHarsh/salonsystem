<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelectPrinter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSelectPrinter))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel20 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Separator6 = New Guna.UI2.WinForms.Guna2Separator()
        Me.txtPrinterName = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.btnChoosePrinter = New Guna.UI.WinForms.GunaGradientTileButton()
        Me.btnClearPrinter = New Guna.UI.WinForms.GunaGradientTileButton()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btnminimize = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btnclose = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(12, 112)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(237, 41)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Printer Name :"
        '
        'GunaLabel20
        '
        Me.GunaLabel20.AutoSize = True
        Me.GunaLabel20.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel20.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel20.Location = New System.Drawing.Point(158, 9)
        Me.GunaLabel20.Name = "GunaLabel20"
        Me.GunaLabel20.Size = New System.Drawing.Size(382, 45)
        Me.GunaLabel20.TabIndex = 145
        Me.GunaLabel20.Text = "Printer Settings"
        '
        'Guna2Separator6
        '
        Me.Guna2Separator6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator6.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator6.FillStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.Guna2Separator6.FillThickness = 8
        Me.Guna2Separator6.Location = New System.Drawing.Point(-19, 65)
        Me.Guna2Separator6.Name = "Guna2Separator6"
        Me.Guna2Separator6.Size = New System.Drawing.Size(834, 10)
        Me.Guna2Separator6.TabIndex = 144
        '
        'txtPrinterName
        '
        Me.txtPrinterName.BaseColor = System.Drawing.Color.White
        Me.txtPrinterName.BorderColor = System.Drawing.Color.Black
        Me.txtPrinterName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrinterName.FocusedBaseColor = System.Drawing.Color.White
        Me.txtPrinterName.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrinterName.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPrinterName.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrinterName.Location = New System.Drawing.Point(321, 112)
        Me.txtPrinterName.Name = "txtPrinterName"
        Me.txtPrinterName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrinterName.SelectedText = ""
        Me.txtPrinterName.Size = New System.Drawing.Size(467, 41)
        Me.txtPrinterName.TabIndex = 146
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Red
        Me.GunaLabel2.Location = New System.Drawing.Point(255, 112)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(34, 41)
        Me.GunaLabel2.TabIndex = 147
        Me.GunaLabel2.Text = "*"
        '
        'btnChoosePrinter
        '
        Me.btnChoosePrinter.AnimationHoverSpeed = 0.07!
        Me.btnChoosePrinter.AnimationSpeed = 0.03!
        Me.btnChoosePrinter.BaseColor1 = System.Drawing.Color.DimGray
        Me.btnChoosePrinter.BaseColor2 = System.Drawing.Color.White
        Me.btnChoosePrinter.BorderColor = System.Drawing.Color.Black
        Me.btnChoosePrinter.BorderSize = 3
        Me.btnChoosePrinter.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnChoosePrinter.FocusedColor = System.Drawing.Color.Empty
        Me.btnChoosePrinter.Font = New System.Drawing.Font("Algerian", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChoosePrinter.ForeColor = System.Drawing.Color.Black
        Me.btnChoosePrinter.Image = CType(resources.GetObject("btnChoosePrinter.Image"), System.Drawing.Image)
        Me.btnChoosePrinter.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnChoosePrinter.Location = New System.Drawing.Point(104, 263)
        Me.btnChoosePrinter.Name = "btnChoosePrinter"
        Me.btnChoosePrinter.OnHoverBaseColor1 = System.Drawing.Color.Black
        Me.btnChoosePrinter.OnHoverBaseColor2 = System.Drawing.Color.Silver
        Me.btnChoosePrinter.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnChoosePrinter.OnHoverForeColor = System.Drawing.Color.White
        Me.btnChoosePrinter.OnHoverImage = Nothing
        Me.btnChoosePrinter.OnPressedColor = System.Drawing.Color.Black
        Me.btnChoosePrinter.Size = New System.Drawing.Size(160, 160)
        Me.btnChoosePrinter.TabIndex = 148
        Me.btnChoosePrinter.Text = "Choose"
        '
        'btnClearPrinter
        '
        Me.btnClearPrinter.AnimationHoverSpeed = 0.07!
        Me.btnClearPrinter.AnimationSpeed = 0.03!
        Me.btnClearPrinter.BaseColor1 = System.Drawing.Color.DimGray
        Me.btnClearPrinter.BaseColor2 = System.Drawing.Color.White
        Me.btnClearPrinter.BorderColor = System.Drawing.Color.Black
        Me.btnClearPrinter.BorderSize = 3
        Me.btnClearPrinter.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClearPrinter.FocusedColor = System.Drawing.Color.Empty
        Me.btnClearPrinter.Font = New System.Drawing.Font("Algerian", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearPrinter.ForeColor = System.Drawing.Color.Black
        Me.btnClearPrinter.Image = CType(resources.GetObject("btnClearPrinter.Image"), System.Drawing.Image)
        Me.btnClearPrinter.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnClearPrinter.Location = New System.Drawing.Point(407, 263)
        Me.btnClearPrinter.Name = "btnClearPrinter"
        Me.btnClearPrinter.OnHoverBaseColor1 = System.Drawing.Color.Black
        Me.btnClearPrinter.OnHoverBaseColor2 = System.Drawing.Color.Silver
        Me.btnClearPrinter.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClearPrinter.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClearPrinter.OnHoverImage = Nothing
        Me.btnClearPrinter.OnPressedColor = System.Drawing.Color.Black
        Me.btnClearPrinter.Size = New System.Drawing.Size(160, 160)
        Me.btnClearPrinter.TabIndex = 149
        Me.btnClearPrinter.Text = "Clear"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnminimize
        '
        Me.btnminimize.BackColor = System.Drawing.Color.Transparent
        Me.btnminimize.BorderColor = System.Drawing.Color.Transparent
        Me.btnminimize.BorderThickness = 2
        Me.btnminimize.CheckedState.Parent = Me.btnminimize
        Me.btnminimize.CustomImages.Parent = Me.btnminimize
        Me.btnminimize.FillColor = System.Drawing.Color.SteelBlue
        Me.btnminimize.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnminimize.ForeColor = System.Drawing.Color.White
        Me.btnminimize.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnminimize.HoverState.FillColor = System.Drawing.Color.Orange
        Me.btnminimize.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnminimize.HoverState.Parent = Me.btnminimize
        Me.btnminimize.Location = New System.Drawing.Point(694, 2)
        Me.btnminimize.Name = "btnminimize"
        Me.btnminimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnminimize.ShadowDecoration.Parent = Me.btnminimize
        Me.btnminimize.Size = New System.Drawing.Size(47, 52)
        Me.btnminimize.TabIndex = 180
        Me.btnminimize.Text = "-"
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.BorderColor = System.Drawing.Color.Transparent
        Me.btnclose.BorderThickness = 2
        Me.btnclose.CheckedState.Parent = Me.btnclose
        Me.btnclose.CustomImages.Parent = Me.btnclose
        Me.btnclose.FillColor = System.Drawing.Color.SteelBlue
        Me.btnclose.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnclose.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnclose.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnclose.HoverState.Parent = Me.btnclose
        Me.btnclose.Location = New System.Drawing.Point(741, 2)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnclose.ShadowDecoration.Parent = Me.btnclose
        Me.btnclose.Size = New System.Drawing.Size(47, 52)
        Me.btnclose.TabIndex = 179
        Me.btnclose.Text = "X"
        '
        'FrmSelectPrinter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnminimize)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnClearPrinter)
        Me.Controls.Add(Me.btnChoosePrinter)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.txtPrinterName)
        Me.Controls.Add(Me.GunaLabel20)
        Me.Controls.Add(Me.Guna2Separator6)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSelectPrinter"
        Me.Text = "FrmSelectPrinter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel20 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Separator6 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents txtPrinterName As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnChoosePrinter As Guna.UI.WinForms.GunaGradientTileButton
    Friend WithEvents btnClearPrinter As Guna.UI.WinForms.GunaGradientTileButton
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents btnminimize As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btnclose As Guna.UI2.WinForms.Guna2CircleButton
End Class
