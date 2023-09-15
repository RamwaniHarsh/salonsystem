<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_NewUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_NewUser))
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.txtconfirmpassword = New Guna.UI.WinForms.GunaTextBox()
        Me.cmbsecurityquestion = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.chkshowpassword = New Guna.UI.WinForms.GunaCheckBox()
        Me.btnNewUserClear = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.btnAddNewUser = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.txtNewUserSecurAns = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.txtNewUserPass = New Guna.UI.WinForms.GunaTextBox()
        Me.txtNewUserName = New Guna.UI.WinForms.GunaTextBox()
        Me.lbllname = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.lbl = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.SuspendLayout()
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel8.Location = New System.Drawing.Point(9, 183)
        Me.GunaLabel8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(214, 31)
        Me.GunaLabel8.TabIndex = 189
        Me.GunaLabel8.Text = "Confirm Password "
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel9.Location = New System.Drawing.Point(223, 181)
        Me.GunaLabel9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(24, 31)
        Me.GunaLabel9.TabIndex = 188
        Me.GunaLabel9.Text = ":"
        '
        'txtconfirmpassword
        '
        Me.txtconfirmpassword.BaseColor = System.Drawing.Color.White
        Me.txtconfirmpassword.BorderColor = System.Drawing.Color.Black
        Me.txtconfirmpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtconfirmpassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txtconfirmpassword.FocusedBorderColor = System.Drawing.Color.Blue
        Me.txtconfirmpassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtconfirmpassword.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconfirmpassword.ForeColor = System.Drawing.Color.Black
        Me.txtconfirmpassword.Location = New System.Drawing.Point(252, 181)
        Me.txtconfirmpassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtconfirmpassword.Name = "txtconfirmpassword"
        Me.txtconfirmpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfirmpassword.SelectedText = ""
        Me.txtconfirmpassword.Size = New System.Drawing.Size(202, 35)
        Me.txtconfirmpassword.TabIndex = 187
        '
        'cmbsecurityquestion
        '
        Me.cmbsecurityquestion.BackColor = System.Drawing.Color.Transparent
        Me.cmbsecurityquestion.BorderColor = System.Drawing.Color.Black
        Me.cmbsecurityquestion.BorderThickness = 2
        Me.cmbsecurityquestion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbsecurityquestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsecurityquestion.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbsecurityquestion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbsecurityquestion.FocusedState.Parent = Me.cmbsecurityquestion
        Me.cmbsecurityquestion.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbsecurityquestion.ForeColor = System.Drawing.Color.Black
        Me.cmbsecurityquestion.HoverState.Parent = Me.cmbsecurityquestion
        Me.cmbsecurityquestion.ItemHeight = 30
        Me.cmbsecurityquestion.Items.AddRange(New Object() {"What is Your Pet Name?", "What is Your Nickname?", "What primary school did you attend?", "In what city or town did your mother and father meet?"})
        Me.cmbsecurityquestion.ItemsAppearance.Parent = Me.cmbsecurityquestion
        Me.cmbsecurityquestion.Location = New System.Drawing.Point(252, 261)
        Me.cmbsecurityquestion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbsecurityquestion.Name = "cmbsecurityquestion"
        Me.cmbsecurityquestion.ShadowDecoration.Parent = Me.cmbsecurityquestion
        Me.cmbsecurityquestion.Size = New System.Drawing.Size(204, 36)
        Me.cmbsecurityquestion.TabIndex = 186
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel7.Location = New System.Drawing.Point(223, 64)
        Me.GunaLabel7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(24, 31)
        Me.GunaLabel7.TabIndex = 185
        Me.GunaLabel7.Text = ":"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel6.Location = New System.Drawing.Point(222, 261)
        Me.GunaLabel6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(24, 31)
        Me.GunaLabel6.TabIndex = 184
        Me.GunaLabel6.Text = ":"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel5.Location = New System.Drawing.Point(222, 310)
        Me.GunaLabel5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(24, 31)
        Me.GunaLabel5.TabIndex = 183
        Me.GunaLabel5.Text = ":"
        '
        'chkshowpassword
        '
        Me.chkshowpassword.BaseColor = System.Drawing.Color.White
        Me.chkshowpassword.CheckedOffColor = System.Drawing.Color.Gray
        Me.chkshowpassword.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkshowpassword.FillColor = System.Drawing.Color.White
        Me.chkshowpassword.ForeColor = System.Drawing.Color.Black
        Me.chkshowpassword.Location = New System.Drawing.Point(360, 231)
        Me.chkshowpassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkshowpassword.Name = "chkshowpassword"
        Me.chkshowpassword.Size = New System.Drawing.Size(111, 20)
        Me.chkshowpassword.TabIndex = 182
        Me.chkshowpassword.Text = "Show Password"
        '
        'btnNewUserClear
        '
        Me.btnNewUserClear.AnimationHoverSpeed = 0.07!
        Me.btnNewUserClear.AnimationSpeed = 0.03!
        Me.btnNewUserClear.BaseColor = System.Drawing.Color.Transparent
        Me.btnNewUserClear.BorderColor = System.Drawing.Color.Black
        Me.btnNewUserClear.BorderSize = 3
        Me.btnNewUserClear.CheckedBaseColor = System.Drawing.Color.Blue
        Me.btnNewUserClear.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnNewUserClear.CheckedForeColor = System.Drawing.Color.Black
        Me.btnNewUserClear.CheckedImage = CType(resources.GetObject("btnNewUserClear.CheckedImage"), System.Drawing.Image)
        Me.btnNewUserClear.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnNewUserClear.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNewUserClear.FocusedColor = System.Drawing.Color.Empty
        Me.btnNewUserClear.Font = New System.Drawing.Font("Gill Sans MT Condensed", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewUserClear.ForeColor = System.Drawing.Color.Black
        Me.btnNewUserClear.Image = CType(resources.GetObject("btnNewUserClear.Image"), System.Drawing.Image)
        Me.btnNewUserClear.ImageSize = New System.Drawing.Size(80, 80)
        Me.btnNewUserClear.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnNewUserClear.Location = New System.Drawing.Point(243, 378)
        Me.btnNewUserClear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNewUserClear.Name = "btnNewUserClear"
        Me.btnNewUserClear.OnHoverBaseColor = System.Drawing.Color.Blue
        Me.btnNewUserClear.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnNewUserClear.OnHoverForeColor = System.Drawing.Color.White
        Me.btnNewUserClear.OnHoverImage = Nothing
        Me.btnNewUserClear.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnNewUserClear.OnPressedColor = System.Drawing.Color.Blue
        Me.btnNewUserClear.Size = New System.Drawing.Size(132, 129)
        Me.btnNewUserClear.TabIndex = 181
        Me.btnNewUserClear.Text = "Clear"
        '
        'btnAddNewUser
        '
        Me.btnAddNewUser.AnimationHoverSpeed = 0.07!
        Me.btnAddNewUser.AnimationSpeed = 0.03!
        Me.btnAddNewUser.BaseColor = System.Drawing.Color.Transparent
        Me.btnAddNewUser.BorderColor = System.Drawing.Color.Black
        Me.btnAddNewUser.BorderSize = 3
        Me.btnAddNewUser.CheckedBaseColor = System.Drawing.Color.Blue
        Me.btnAddNewUser.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnAddNewUser.CheckedForeColor = System.Drawing.Color.Black
        Me.btnAddNewUser.CheckedImage = CType(resources.GetObject("btnAddNewUser.CheckedImage"), System.Drawing.Image)
        Me.btnAddNewUser.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnAddNewUser.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddNewUser.FocusedColor = System.Drawing.Color.Empty
        Me.btnAddNewUser.Font = New System.Drawing.Font("Gill Sans MT Condensed", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewUser.ForeColor = System.Drawing.Color.Black
        Me.btnAddNewUser.Image = CType(resources.GetObject("btnAddNewUser.Image"), System.Drawing.Image)
        Me.btnAddNewUser.ImageSize = New System.Drawing.Size(80, 80)
        Me.btnAddNewUser.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnAddNewUser.Location = New System.Drawing.Point(62, 378)
        Me.btnAddNewUser.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAddNewUser.Name = "btnAddNewUser"
        Me.btnAddNewUser.OnHoverBaseColor = System.Drawing.Color.Blue
        Me.btnAddNewUser.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAddNewUser.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAddNewUser.OnHoverImage = Nothing
        Me.btnAddNewUser.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnAddNewUser.OnPressedColor = System.Drawing.Color.Blue
        Me.btnAddNewUser.Size = New System.Drawing.Size(132, 129)
        Me.btnAddNewUser.TabIndex = 180
        Me.btnAddNewUser.Text = "Add User"
        '
        'txtNewUserSecurAns
        '
        Me.txtNewUserSecurAns.BaseColor = System.Drawing.Color.White
        Me.txtNewUserSecurAns.BorderColor = System.Drawing.Color.Black
        Me.txtNewUserSecurAns.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewUserSecurAns.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNewUserSecurAns.FocusedBorderColor = System.Drawing.Color.Blue
        Me.txtNewUserSecurAns.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNewUserSecurAns.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewUserSecurAns.ForeColor = System.Drawing.Color.Black
        Me.txtNewUserSecurAns.Location = New System.Drawing.Point(252, 309)
        Me.txtNewUserSecurAns.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNewUserSecurAns.Name = "txtNewUserSecurAns"
        Me.txtNewUserSecurAns.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewUserSecurAns.SelectedText = ""
        Me.txtNewUserSecurAns.Size = New System.Drawing.Size(202, 35)
        Me.txtNewUserSecurAns.TabIndex = 177
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel2.Location = New System.Drawing.Point(9, 310)
        Me.GunaLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(91, 31)
        Me.GunaLabel2.TabIndex = 179
        Me.GunaLabel2.Text = "Answer"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel3.Location = New System.Drawing.Point(11, 261)
        Me.GunaLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(215, 31)
        Me.GunaLabel3.TabIndex = 178
        Me.GunaLabel3.Text = "Security Question "
        '
        'txtNewUserPass
        '
        Me.txtNewUserPass.BaseColor = System.Drawing.Color.White
        Me.txtNewUserPass.BorderColor = System.Drawing.Color.Black
        Me.txtNewUserPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewUserPass.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNewUserPass.FocusedBorderColor = System.Drawing.Color.Blue
        Me.txtNewUserPass.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNewUserPass.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewUserPass.ForeColor = System.Drawing.Color.Black
        Me.txtNewUserPass.Location = New System.Drawing.Point(252, 119)
        Me.txtNewUserPass.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNewUserPass.Name = "txtNewUserPass"
        Me.txtNewUserPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewUserPass.SelectedText = ""
        Me.txtNewUserPass.Size = New System.Drawing.Size(202, 35)
        Me.txtNewUserPass.TabIndex = 173
        '
        'txtNewUserName
        '
        Me.txtNewUserName.BaseColor = System.Drawing.Color.White
        Me.txtNewUserName.BorderColor = System.Drawing.Color.Black
        Me.txtNewUserName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewUserName.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNewUserName.FocusedBorderColor = System.Drawing.Color.Blue
        Me.txtNewUserName.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNewUserName.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewUserName.ForeColor = System.Drawing.Color.Black
        Me.txtNewUserName.Location = New System.Drawing.Point(252, 64)
        Me.txtNewUserName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNewUserName.Name = "txtNewUserName"
        Me.txtNewUserName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewUserName.SelectedText = ""
        Me.txtNewUserName.Size = New System.Drawing.Size(202, 35)
        Me.txtNewUserName.TabIndex = 172
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllname.ForeColor = System.Drawing.Color.Black
        Me.lbllname.Location = New System.Drawing.Point(9, 123)
        Me.lbllname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(121, 31)
        Me.lbllname.TabIndex = 176
        Me.lbllname.Text = "Password "
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel4.Location = New System.Drawing.Point(223, 121)
        Me.GunaLabel4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(24, 31)
        Me.GunaLabel4.TabIndex = 175
        Me.GunaLabel4.Text = ":"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.Black
        Me.lbl.Location = New System.Drawing.Point(10, 66)
        Me.lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(117, 31)
        Me.lbl.TabIndex = 174
        Me.lbl.Text = "Username"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator1.FillStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.Guna2Separator1.FillThickness = 8
        Me.Guna2Separator1.Location = New System.Drawing.Point(-3, 37)
        Me.Guna2Separator1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(496, 18)
        Me.Guna2Separator1.TabIndex = 171
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel1.Location = New System.Drawing.Point(119, 0)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(246, 35)
        Me.GunaLabel1.TabIndex = 170
        Me.GunaLabel1.Text = "Add New User"
        '
        'UC_NewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.GunaLabel9)
        Me.Controls.Add(Me.txtconfirmpassword)
        Me.Controls.Add(Me.cmbsecurityquestion)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.chkshowpassword)
        Me.Controls.Add(Me.btnNewUserClear)
        Me.Controls.Add(Me.btnAddNewUser)
        Me.Controls.Add(Me.txtNewUserSecurAns)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.txtNewUserPass)
        Me.Controls.Add(Me.txtNewUserName)
        Me.Controls.Add(Me.lbllname)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "UC_NewUser"
        Me.Size = New System.Drawing.Size(478, 561)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtconfirmpassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents cmbsecurityquestion As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents chkshowpassword As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents btnNewUserClear As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents btnAddNewUser As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents txtNewUserSecurAns As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtNewUserPass As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtNewUserName As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lbllname As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
End Class
