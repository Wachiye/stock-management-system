<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.tbpInformation = New System.Windows.Forms.TabPage()
        Me.txtOtherPhone = New System.Windows.Forms.TextBox()
        Me.txtPrimaryPhone = New System.Windows.Forms.TextBox()
        Me.txtOtherEmail = New System.Windows.Forms.TextBox()
        Me.txtPrimaryEmail = New System.Windows.Forms.TextBox()
        Me.lblOtherPhone = New System.Windows.Forms.Label()
        Me.lblPrimaryPhone = New System.Windows.Forms.Label()
        Me.lblOtherEmail = New System.Windows.Forms.Label()
        Me.lblPrimaryEmail = New System.Windows.Forms.Label()
        Me.btnSaveInformation = New System.Windows.Forms.Button()
        Me.btnChoose = New System.Windows.Forms.Button()
        Me.pcbLogo = New System.Windows.Forms.PictureBox()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.txtTradeMark = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblTradeMark = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.tbpAddress = New System.Windows.Forms.TabPage()
        Me.btnSaveAddress = New System.Windows.Forms.Button()
        Me.txtRegion = New System.Windows.Forms.TextBox()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtHouseNumber = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.lblHouseNumber = New System.Windows.Forms.Label()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.lblPostalCode = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblStreet = New System.Windows.Forms.Label()
        Me.tbpDatabase = New System.Windows.Forms.TabPage()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.lstDetails = New System.Windows.Forms.ListBox()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.btnSaveDatabase = New System.Windows.Forms.Button()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.TabControl.SuspendLayout()
        Me.tbpInformation.SuspendLayout()
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpAddress.SuspendLayout()
        Me.tbpDatabase.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl.Controls.Add(Me.tbpInformation)
        Me.TabControl.Controls.Add(Me.tbpAddress)
        Me.TabControl.Controls.Add(Me.tbpDatabase)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.HotTrack = True
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(677, 443)
        Me.TabControl.TabIndex = 1
        '
        'tbpInformation
        '
        Me.tbpInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbpInformation.Controls.Add(Me.txtOtherPhone)
        Me.tbpInformation.Controls.Add(Me.txtPrimaryPhone)
        Me.tbpInformation.Controls.Add(Me.txtOtherEmail)
        Me.tbpInformation.Controls.Add(Me.txtPrimaryEmail)
        Me.tbpInformation.Controls.Add(Me.lblOtherPhone)
        Me.tbpInformation.Controls.Add(Me.lblPrimaryPhone)
        Me.tbpInformation.Controls.Add(Me.lblOtherEmail)
        Me.tbpInformation.Controls.Add(Me.lblPrimaryEmail)
        Me.tbpInformation.Controls.Add(Me.btnSaveInformation)
        Me.tbpInformation.Controls.Add(Me.btnChoose)
        Me.tbpInformation.Controls.Add(Me.pcbLogo)
        Me.tbpInformation.Controls.Add(Me.lblLogo)
        Me.tbpInformation.Controls.Add(Me.txtTradeMark)
        Me.tbpInformation.Controls.Add(Me.txtDescription)
        Me.tbpInformation.Controls.Add(Me.txtName)
        Me.tbpInformation.Controls.Add(Me.lblTradeMark)
        Me.tbpInformation.Controls.Add(Me.lblDescription)
        Me.tbpInformation.Controls.Add(Me.lblName)
        Me.tbpInformation.Location = New System.Drawing.Point(4, 25)
        Me.tbpInformation.Name = "tbpInformation"
        Me.tbpInformation.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpInformation.Size = New System.Drawing.Size(669, 414)
        Me.tbpInformation.TabIndex = 0
        Me.tbpInformation.Text = "Company Information"
        Me.tbpInformation.UseVisualStyleBackColor = True
        '
        'txtOtherPhone
        '
        Me.txtOtherPhone.Location = New System.Drawing.Point(255, 260)
        Me.txtOtherPhone.Name = "txtOtherPhone"
        Me.txtOtherPhone.Size = New System.Drawing.Size(223, 20)
        Me.txtOtherPhone.TabIndex = 24
        '
        'txtPrimaryPhone
        '
        Me.txtPrimaryPhone.Location = New System.Drawing.Point(36, 260)
        Me.txtPrimaryPhone.Name = "txtPrimaryPhone"
        Me.txtPrimaryPhone.Size = New System.Drawing.Size(198, 20)
        Me.txtPrimaryPhone.TabIndex = 23
        '
        'txtOtherEmail
        '
        Me.txtOtherEmail.Location = New System.Drawing.Point(255, 203)
        Me.txtOtherEmail.Name = "txtOtherEmail"
        Me.txtOtherEmail.Size = New System.Drawing.Size(223, 20)
        Me.txtOtherEmail.TabIndex = 22
        '
        'txtPrimaryEmail
        '
        Me.txtPrimaryEmail.Location = New System.Drawing.Point(36, 203)
        Me.txtPrimaryEmail.Name = "txtPrimaryEmail"
        Me.txtPrimaryEmail.Size = New System.Drawing.Size(198, 20)
        Me.txtPrimaryEmail.TabIndex = 21
        '
        'lblOtherPhone
        '
        Me.lblOtherPhone.AutoSize = True
        Me.lblOtherPhone.Location = New System.Drawing.Point(252, 235)
        Me.lblOtherPhone.Name = "lblOtherPhone"
        Me.lblOtherPhone.Size = New System.Drawing.Size(67, 13)
        Me.lblOtherPhone.TabIndex = 20
        Me.lblOtherPhone.Text = "Other Phone"
        '
        'lblPrimaryPhone
        '
        Me.lblPrimaryPhone.AutoSize = True
        Me.lblPrimaryPhone.Location = New System.Drawing.Point(33, 235)
        Me.lblPrimaryPhone.Name = "lblPrimaryPhone"
        Me.lblPrimaryPhone.Size = New System.Drawing.Size(75, 13)
        Me.lblPrimaryPhone.TabIndex = 19
        Me.lblPrimaryPhone.Text = "Primary Phone"
        '
        'lblOtherEmail
        '
        Me.lblOtherEmail.AutoSize = True
        Me.lblOtherEmail.Location = New System.Drawing.Point(252, 178)
        Me.lblOtherEmail.Name = "lblOtherEmail"
        Me.lblOtherEmail.Size = New System.Drawing.Size(61, 13)
        Me.lblOtherEmail.TabIndex = 18
        Me.lblOtherEmail.Text = "Other Email"
        '
        'lblPrimaryEmail
        '
        Me.lblPrimaryEmail.AutoSize = True
        Me.lblPrimaryEmail.Location = New System.Drawing.Point(33, 178)
        Me.lblPrimaryEmail.Name = "lblPrimaryEmail"
        Me.lblPrimaryEmail.Size = New System.Drawing.Size(69, 13)
        Me.lblPrimaryEmail.TabIndex = 17
        Me.lblPrimaryEmail.Text = "Primary Email"
        '
        'btnSaveInformation
        '
        Me.btnSaveInformation.Location = New System.Drawing.Point(589, 386)
        Me.btnSaveInformation.Name = "btnSaveInformation"
        Me.btnSaveInformation.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveInformation.TabIndex = 4
        Me.btnSaveInformation.Text = "Save"
        Me.btnSaveInformation.UseVisualStyleBackColor = True
        '
        'btnChoose
        '
        Me.btnChoose.Location = New System.Drawing.Point(545, 163)
        Me.btnChoose.Name = "btnChoose"
        Me.btnChoose.Size = New System.Drawing.Size(75, 23)
        Me.btnChoose.TabIndex = 3
        Me.btnChoose.Text = "Choose"
        Me.btnChoose.UseVisualStyleBackColor = True
        '
        'pcbLogo
        '
        Me.pcbLogo.Location = New System.Drawing.Point(517, 46)
        Me.pcbLogo.Name = "pcbLogo"
        Me.pcbLogo.Size = New System.Drawing.Size(142, 106)
        Me.pcbLogo.TabIndex = 16
        Me.pcbLogo.TabStop = False
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Location = New System.Drawing.Point(532, 19)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(88, 13)
        Me.lblLogo.TabIndex = 15
        Me.lblLogo.Text = "Icon/Label/Logo"
        '
        'txtTradeMark
        '
        Me.txtTradeMark.Location = New System.Drawing.Point(36, 327)
        Me.txtTradeMark.Name = "txtTradeMark"
        Me.txtTradeMark.Size = New System.Drawing.Size(339, 20)
        Me.txtTradeMark.TabIndex = 2
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(36, 91)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(339, 75)
        Me.txtDescription.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(36, 34)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(339, 20)
        Me.txtName.TabIndex = 0
        '
        'lblTradeMark
        '
        Me.lblTradeMark.AutoSize = True
        Me.lblTradeMark.Location = New System.Drawing.Point(33, 298)
        Me.lblTradeMark.Name = "lblTradeMark"
        Me.lblTradeMark.Size = New System.Drawing.Size(62, 13)
        Me.lblTradeMark.TabIndex = 11
        Me.lblTradeMark.Text = "Trade Mark"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(33, 66)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 10
        Me.lblDescription.Text = "Description"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(31, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 9
        Me.lblName.Text = "Name"
        '
        'tbpAddress
        '
        Me.tbpAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbpAddress.Controls.Add(Me.btnSaveAddress)
        Me.tbpAddress.Controls.Add(Me.txtRegion)
        Me.tbpAddress.Controls.Add(Me.txtPostalCode)
        Me.tbpAddress.Controls.Add(Me.txtState)
        Me.tbpAddress.Controls.Add(Me.txtHouseNumber)
        Me.tbpAddress.Controls.Add(Me.txtStreet)
        Me.tbpAddress.Controls.Add(Me.lblHouseNumber)
        Me.tbpAddress.Controls.Add(Me.lblRegion)
        Me.tbpAddress.Controls.Add(Me.lblPostalCode)
        Me.tbpAddress.Controls.Add(Me.lblState)
        Me.tbpAddress.Controls.Add(Me.lblStreet)
        Me.tbpAddress.Location = New System.Drawing.Point(4, 25)
        Me.tbpAddress.Name = "tbpAddress"
        Me.tbpAddress.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpAddress.Size = New System.Drawing.Size(669, 414)
        Me.tbpAddress.TabIndex = 2
        Me.tbpAddress.Text = "Address"
        Me.tbpAddress.UseVisualStyleBackColor = True
        '
        'btnSaveAddress
        '
        Me.btnSaveAddress.Location = New System.Drawing.Point(589, 386)
        Me.btnSaveAddress.Name = "btnSaveAddress"
        Me.btnSaveAddress.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveAddress.TabIndex = 21
        Me.btnSaveAddress.Text = "Save"
        Me.btnSaveAddress.UseVisualStyleBackColor = True
        '
        'txtRegion
        '
        Me.txtRegion.Location = New System.Drawing.Point(158, 161)
        Me.txtRegion.Name = "txtRegion"
        Me.txtRegion.Size = New System.Drawing.Size(246, 20)
        Me.txtRegion.TabIndex = 20
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Location = New System.Drawing.Point(158, 117)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(246, 20)
        Me.txtPostalCode.TabIndex = 19
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(158, 199)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(246, 20)
        Me.txtState.TabIndex = 18
        '
        'txtHouseNumber
        '
        Me.txtHouseNumber.Location = New System.Drawing.Point(158, 74)
        Me.txtHouseNumber.Name = "txtHouseNumber"
        Me.txtHouseNumber.Size = New System.Drawing.Size(117, 20)
        Me.txtHouseNumber.TabIndex = 17
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(158, 28)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(246, 20)
        Me.txtStreet.TabIndex = 16
        '
        'lblHouseNumber
        '
        Me.lblHouseNumber.AutoSize = True
        Me.lblHouseNumber.Location = New System.Drawing.Point(36, 77)
        Me.lblHouseNumber.Name = "lblHouseNumber"
        Me.lblHouseNumber.Size = New System.Drawing.Size(78, 13)
        Me.lblHouseNumber.TabIndex = 15
        Me.lblHouseNumber.Text = "House Number"
        '
        'lblRegion
        '
        Me.lblRegion.AutoSize = True
        Me.lblRegion.Location = New System.Drawing.Point(36, 164)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(41, 13)
        Me.lblRegion.TabIndex = 14
        Me.lblRegion.Text = "Region"
        '
        'lblPostalCode
        '
        Me.lblPostalCode.AutoSize = True
        Me.lblPostalCode.Location = New System.Drawing.Point(36, 120)
        Me.lblPostalCode.Name = "lblPostalCode"
        Me.lblPostalCode.Size = New System.Drawing.Size(64, 13)
        Me.lblPostalCode.TabIndex = 13
        Me.lblPostalCode.Text = "Postal Code"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(36, 202)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(32, 13)
        Me.lblState.TabIndex = 12
        Me.lblState.Text = "State"
        '
        'lblStreet
        '
        Me.lblStreet.AutoSize = True
        Me.lblStreet.Location = New System.Drawing.Point(36, 31)
        Me.lblStreet.Name = "lblStreet"
        Me.lblStreet.Size = New System.Drawing.Size(66, 13)
        Me.lblStreet.TabIndex = 11
        Me.lblStreet.Text = "Street Name"
        '
        'tbpDatabase
        '
        Me.tbpDatabase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbpDatabase.Controls.Add(Me.GroupBox)
        Me.tbpDatabase.Controls.Add(Me.txtDatabase)
        Me.tbpDatabase.Controls.Add(Me.txtPassword)
        Me.tbpDatabase.Controls.Add(Me.txtUsername)
        Me.tbpDatabase.Controls.Add(Me.txtHost)
        Me.tbpDatabase.Controls.Add(Me.btnSaveDatabase)
        Me.tbpDatabase.Controls.Add(Me.btnSetup)
        Me.tbpDatabase.Controls.Add(Me.lblDatabase)
        Me.tbpDatabase.Controls.Add(Me.lblPassword)
        Me.tbpDatabase.Controls.Add(Me.lblUsername)
        Me.tbpDatabase.Controls.Add(Me.lblHost)
        Me.tbpDatabase.Location = New System.Drawing.Point(4, 25)
        Me.tbpDatabase.Name = "tbpDatabase"
        Me.tbpDatabase.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDatabase.Size = New System.Drawing.Size(669, 414)
        Me.tbpDatabase.TabIndex = 3
        Me.tbpDatabase.Text = "Database"
        Me.tbpDatabase.UseVisualStyleBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.lstDetails)
        Me.GroupBox.Location = New System.Drawing.Point(59, 199)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(236, 163)
        Me.GroupBox.TabIndex = 11
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Details"
        Me.GroupBox.Visible = False
        '
        'lstDetails
        '
        Me.lstDetails.FormattingEnabled = True
        Me.lstDetails.Location = New System.Drawing.Point(6, 19)
        Me.lstDetails.Name = "lstDetails"
        Me.lstDetails.Size = New System.Drawing.Size(224, 134)
        Me.lstDetails.TabIndex = 10
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(143, 145)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(172, 20)
        Me.txtDatabase.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(143, 100)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(172, 20)
        Me.txtPassword.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(143, 55)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(172, 20)
        Me.txtUsername.TabIndex = 1
        '
        'txtHost
        '
        Me.txtHost.Location = New System.Drawing.Point(143, 16)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(317, 20)
        Me.txtHost.TabIndex = 0
        '
        'btnSaveDatabase
        '
        Me.btnSaveDatabase.Enabled = False
        Me.btnSaveDatabase.Location = New System.Drawing.Point(589, 386)
        Me.btnSaveDatabase.Name = "btnSaveDatabase"
        Me.btnSaveDatabase.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveDatabase.TabIndex = 4
        Me.btnSaveDatabase.Text = "Save"
        Me.btnSaveDatabase.UseVisualStyleBackColor = True
        '
        'btnSetup
        '
        Me.btnSetup.Enabled = False
        Me.btnSetup.Location = New System.Drawing.Point(508, 386)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(75, 23)
        Me.btnSetup.TabIndex = 5
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'lblDatabase
        '
        Me.lblDatabase.AutoSize = True
        Me.lblDatabase.Location = New System.Drawing.Point(43, 148)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(53, 13)
        Me.lblDatabase.TabIndex = 3
        Me.lblDatabase.Text = "Database"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(43, 103)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(44, 58)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username"
        '
        'lblHost
        '
        Me.lblHost.AutoSize = True
        Me.lblHost.Location = New System.Drawing.Point(43, 19)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(81, 13)
        Me.lblHost.TabIndex = 0
        Me.lblHost.Text = "Host URL/Path"
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 443)
        Me.Controls.Add(Me.TabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SettingsForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "User Settings"
        Me.TabControl.ResumeLayout(False)
        Me.tbpInformation.ResumeLayout(False)
        Me.tbpInformation.PerformLayout()
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpAddress.ResumeLayout(False)
        Me.tbpAddress.PerformLayout()
        Me.tbpDatabase.ResumeLayout(False)
        Me.tbpDatabase.PerformLayout()
        Me.GroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents tbpInformation As TabPage
    Friend WithEvents btnSaveInformation As Button
    Friend WithEvents btnChoose As Button
    Friend WithEvents pcbLogo As PictureBox
    Friend WithEvents lblLogo As Label
    Friend WithEvents txtTradeMark As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblTradeMark As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblName As Label
    Friend WithEvents tbpAddress As TabPage
    Friend WithEvents btnSaveAddress As Button
    Friend WithEvents txtRegion As TextBox
    Friend WithEvents txtPostalCode As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtHouseNumber As TextBox
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents lblHouseNumber As Label
    Friend WithEvents lblRegion As Label
    Friend WithEvents lblPostalCode As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblStreet As Label
    Friend WithEvents tbpDatabase As TabPage
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents lstDetails As ListBox
    Friend WithEvents txtDatabase As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtHost As TextBox
    Friend WithEvents btnSaveDatabase As Button
    Friend WithEvents btnSetup As Button
    Friend WithEvents lblDatabase As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblHost As Label
    Friend WithEvents txtOtherPhone As TextBox
    Friend WithEvents txtPrimaryPhone As TextBox
    Friend WithEvents txtOtherEmail As TextBox
    Friend WithEvents txtPrimaryEmail As TextBox
    Friend WithEvents lblOtherPhone As Label
    Friend WithEvents lblPrimaryPhone As Label
    Friend WithEvents lblOtherEmail As Label
    Friend WithEvents lblPrimaryEmail As Label
End Class
