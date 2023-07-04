<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.glpTimeUser = New System.Windows.Forms.Panel()
        Me.lblTime = New Guna.UI.WinForms.GunaLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.glpTimeUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'glpTimeUser
        '
        Me.glpTimeUser.BackgroundImage = CType(resources.GetObject("glpTimeUser.BackgroundImage"), System.Drawing.Image)
        Me.glpTimeUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.glpTimeUser.Controls.Add(Me.lblTime)
        Me.glpTimeUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.glpTimeUser.Location = New System.Drawing.Point(0, 0)
        Me.glpTimeUser.Name = "glpTimeUser"
        Me.glpTimeUser.Size = New System.Drawing.Size(1176, 78)
        Me.glpTimeUser.TabIndex = 1
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTime.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(12, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(71, 29)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "TIME"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 781)
        Me.Controls.Add(Me.glpTimeUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.glpTimeUser.ResumeLayout(False)
        Me.glpTimeUser.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents glpTimeUser As Panel
    Friend WithEvents lblTime As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Timer1 As Timer
End Class
