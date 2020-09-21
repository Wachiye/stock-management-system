<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.topPanel = New System.Windows.Forms.Panel()
        Me.lblTradeMark = New System.Windows.Forms.Label()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.bottomPanel = New System.Windows.Forms.Panel()
        Me.lblSystemCompany = New System.Windows.Forms.Label()
        Me.grpLogin = New System.Windows.Forms.GroupBox()
        Me.cboUsers = New System.Windows.Forms.ComboBox()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.topPanel.SuspendLayout()
        Me.bottomPanel.SuspendLayout()
        Me.grpLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(106, 50)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(83, 20)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(106, 100)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(78, 20)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(222, 97)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(321, 26)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Image = Global.SMS.My.Resources.Resources.Apply
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.Location = New System.Drawing.Point(222, 159)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(134, 36)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(409, 159)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(134, 36)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Cancel"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'topPanel
        '
        Me.topPanel.BackColor = System.Drawing.Color.Silver
        Me.topPanel.Controls.Add(Me.lblTradeMark)
        Me.topPanel.Controls.Add(Me.lblCompanyName)
        Me.topPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topPanel.Location = New System.Drawing.Point(0, 0)
        Me.topPanel.Name = "topPanel"
        Me.topPanel.Size = New System.Drawing.Size(862, 100)
        Me.topPanel.TabIndex = 10
        '
        'lblTradeMark
        '
        Me.lblTradeMark.AutoSize = True
        Me.lblTradeMark.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTradeMark.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTradeMark.Location = New System.Drawing.Point(53, 60)
        Me.lblTradeMark.Name = "lblTradeMark"
        Me.lblTradeMark.Size = New System.Drawing.Size(89, 20)
        Me.lblTradeMark.TabIndex = 11
        Me.lblTradeMark.Text = "Trade Mark"
        '
        'lblCompanyName
        '
        Me.lblCompanyName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.Location = New System.Drawing.Point(50, 9)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(297, 39)
        Me.lblCompanyName.TabIndex = 12
        Me.lblCompanyName.Text = "COMPANY NAME"
        '
        'bottomPanel
        '
        Me.bottomPanel.BackColor = System.Drawing.Color.Silver
        Me.bottomPanel.Controls.Add(Me.lblSystemCompany)
        Me.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottomPanel.Location = New System.Drawing.Point(0, 395)
        Me.bottomPanel.Name = "bottomPanel"
        Me.bottomPanel.Size = New System.Drawing.Size(862, 55)
        Me.bottomPanel.TabIndex = 11
        '
        'lblSystemCompany
        '
        Me.lblSystemCompany.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSystemCompany.AutoSize = True
        Me.lblSystemCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemCompany.Location = New System.Drawing.Point(59, 15)
        Me.lblSystemCompany.Name = "lblSystemCompany"
        Me.lblSystemCompany.Size = New System.Drawing.Size(504, 25)
        Me.lblSystemCompany.TabIndex = 13
        Me.lblSystemCompany.Text = "STOCK MANAGEMENT SYSTEM - COMPANY NAME"
        '
        'grpLogin
        '
        Me.grpLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpLogin.Controls.Add(Me.cboUsers)
        Me.grpLogin.Controls.Add(Me.lblUsername)
        Me.grpLogin.Controls.Add(Me.lblPassword)
        Me.grpLogin.Controls.Add(Me.btnClose)
        Me.grpLogin.Controls.Add(Me.btnLogin)
        Me.grpLogin.Controls.Add(Me.txtPassword)
        Me.grpLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLogin.Location = New System.Drawing.Point(111, 143)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Size = New System.Drawing.Size(649, 219)
        Me.grpLogin.TabIndex = 12
        Me.grpLogin.TabStop = False
        Me.grpLogin.Text = "User Login"
        '
        'cboUsers
        '
        Me.cboUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsers.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboUsers.FormattingEnabled = True
        Me.cboUsers.Location = New System.Drawing.Point(222, 47)
        Me.cboUsers.Name = "cboUsers"
        Me.cboUsers.Size = New System.Drawing.Size(321, 28)
        Me.cboUsers.TabIndex = 10
        '
        'bgWorker
        '
        Me.bgWorker.WorkerReportsProgress = True
        Me.bgWorker.WorkerSupportsCancellation = True
        '
        'LoginForm
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(862, 450)
        Me.Controls.Add(Me.grpLogin)
        Me.Controls.Add(Me.bottomPanel)
        Me.Controls.Add(Me.topPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.topPanel.ResumeLayout(False)
        Me.topPanel.PerformLayout()
        Me.bottomPanel.ResumeLayout(False)
        Me.bottomPanel.PerformLayout()
        Me.grpLogin.ResumeLayout(False)
        Me.grpLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents topPanel As Panel
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents bottomPanel As Panel
    Friend WithEvents lblSystemCompany As Label
    Friend WithEvents grpLogin As GroupBox
    Friend WithEvents cboUsers As ComboBox
    Friend WithEvents lblTradeMark As Label
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
End Class
