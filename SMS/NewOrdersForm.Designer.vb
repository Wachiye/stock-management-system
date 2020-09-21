<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewOrdersForm
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
        Me.txtSupplierAddress = New System.Windows.Forms.TextBox()
        Me.txtSupplierPhone = New System.Windows.Forms.TextBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.lblModeOfPayment = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.chkConfirm = New System.Windows.Forms.CheckBox()
        Me.lblSupplierAddress = New System.Windows.Forms.Label()
        Me.lblSupplierPhone = New System.Windows.Forms.Label()
        Me.grpBillingInformation = New System.Windows.Forms.GroupBox()
        Me.cboModeOfPayment = New System.Windows.Forms.ComboBox()
        Me.grpOrderDetails = New System.Windows.Forms.GroupBox()
        Me.lblOrderItems = New System.Windows.Forms.Label()
        Me.gridOrderItems = New System.Windows.Forms.DataGridView()
        Me.item_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnClearItems = New System.Windows.Forms.Button()
        Me.btnRemoveSelected = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblOrderNoValue = New System.Windows.Forms.Label()
        Me.lblOrderNo = New System.Windows.Forms.Label()
        Me.txtSupplierEmail = New System.Windows.Forms.TextBox()
        Me.lblSupplierEmail = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblSelectName = New System.Windows.Forms.Label()
        Me.cboSuppliers = New System.Windows.Forms.ComboBox()
        Me.grpSupplier = New System.Windows.Forms.GroupBox()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.grpBillingInformation.SuspendLayout()
        Me.grpOrderDetails.SuspendLayout()
        CType(Me.gridOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSupplier.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSupplierAddress
        '
        Me.txtSupplierAddress.Location = New System.Drawing.Point(94, 176)
        Me.txtSupplierAddress.Name = "txtSupplierAddress"
        Me.txtSupplierAddress.Size = New System.Drawing.Size(319, 20)
        Me.txtSupplierAddress.TabIndex = 9
        '
        'txtSupplierPhone
        '
        Me.txtSupplierPhone.Location = New System.Drawing.Point(94, 141)
        Me.txtSupplierPhone.Name = "txtSupplierPhone"
        Me.txtSupplierPhone.Size = New System.Drawing.Size(203, 20)
        Me.txtSupplierPhone.TabIndex = 7
        '
        'btnContinue
        '
        Me.btnContinue.Enabled = False
        Me.btnContinue.Location = New System.Drawing.Point(953, 597)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(118, 27)
        Me.btnContinue.TabIndex = 20
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'lblModeOfPayment
        '
        Me.lblModeOfPayment.AutoSize = True
        Me.lblModeOfPayment.Location = New System.Drawing.Point(27, 225)
        Me.lblModeOfPayment.Name = "lblModeOfPayment"
        Me.lblModeOfPayment.Size = New System.Drawing.Size(135, 13)
        Me.lblModeOfPayment.TabIndex = 17
        Me.lblModeOfPayment.Text = "Prefered Mode Of Payment"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(27, 196)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(351, 20)
        Me.txtAddress.TabIndex = 15
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(24, 180)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 14
        Me.lblAddress.Text = "Address"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(27, 143)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(162, 20)
        Me.txtPhone.TabIndex = 13
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(24, 127)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(38, 13)
        Me.lblPhone.TabIndex = 12
        Me.lblPhone.Text = "Phone"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(27, 93)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(351, 20)
        Me.txtEmail.TabIndex = 11
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(24, 77)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "Email"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(264, 44)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(162, 20)
        Me.txtUsername.TabIndex = 9
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(261, 28)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 8
        Me.lblUsername.Text = "Username"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(27, 44)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(231, 20)
        Me.txtCompanyName.TabIndex = 7
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Location = New System.Drawing.Point(24, 28)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(82, 13)
        Me.lblCompanyName.TabIndex = 6
        Me.lblCompanyName.Text = "Company Name"
        '
        'chkConfirm
        '
        Me.chkConfirm.AutoSize = True
        Me.chkConfirm.ForeColor = System.Drawing.Color.Red
        Me.chkConfirm.Location = New System.Drawing.Point(542, 574)
        Me.chkConfirm.Name = "chkConfirm"
        Me.chkConfirm.Size = New System.Drawing.Size(567, 17)
        Me.chkConfirm.TabIndex = 19
        Me.chkConfirm.Text = "I confirm that the above billing information and supplier details are correct and" &
    " I have included all the items required."
        Me.chkConfirm.UseVisualStyleBackColor = True
        '
        'lblSupplierAddress
        '
        Me.lblSupplierAddress.AutoSize = True
        Me.lblSupplierAddress.Location = New System.Drawing.Point(34, 179)
        Me.lblSupplierAddress.Name = "lblSupplierAddress"
        Me.lblSupplierAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblSupplierAddress.TabIndex = 8
        Me.lblSupplierAddress.Text = "Address"
        '
        'lblSupplierPhone
        '
        Me.lblSupplierPhone.AutoSize = True
        Me.lblSupplierPhone.Location = New System.Drawing.Point(41, 144)
        Me.lblSupplierPhone.Name = "lblSupplierPhone"
        Me.lblSupplierPhone.Size = New System.Drawing.Size(38, 13)
        Me.lblSupplierPhone.TabIndex = 6
        Me.lblSupplierPhone.Text = "Phone"
        '
        'grpBillingInformation
        '
        Me.grpBillingInformation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpBillingInformation.Controls.Add(Me.cboModeOfPayment)
        Me.grpBillingInformation.Controls.Add(Me.lblModeOfPayment)
        Me.grpBillingInformation.Controls.Add(Me.txtAddress)
        Me.grpBillingInformation.Controls.Add(Me.lblAddress)
        Me.grpBillingInformation.Controls.Add(Me.txtPhone)
        Me.grpBillingInformation.Controls.Add(Me.lblPhone)
        Me.grpBillingInformation.Controls.Add(Me.txtEmail)
        Me.grpBillingInformation.Controls.Add(Me.lblEmail)
        Me.grpBillingInformation.Controls.Add(Me.txtUsername)
        Me.grpBillingInformation.Controls.Add(Me.lblUsername)
        Me.grpBillingInformation.Controls.Add(Me.txtCompanyName)
        Me.grpBillingInformation.Controls.Add(Me.lblCompanyName)
        Me.grpBillingInformation.Location = New System.Drawing.Point(47, 26)
        Me.grpBillingInformation.Name = "grpBillingInformation"
        Me.grpBillingInformation.Size = New System.Drawing.Size(430, 335)
        Me.grpBillingInformation.TabIndex = 18
        Me.grpBillingInformation.TabStop = False
        Me.grpBillingInformation.Text = "Billing Information"
        '
        'cboModeOfPayment
        '
        Me.cboModeOfPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModeOfPayment.FormattingEnabled = True
        Me.cboModeOfPayment.Items.AddRange(New Object() {"M~Pesa", "Airtel money", "PayPal", "Bank Tranfer", "Credit Card"})
        Me.cboModeOfPayment.Location = New System.Drawing.Point(30, 245)
        Me.cboModeOfPayment.Name = "cboModeOfPayment"
        Me.cboModeOfPayment.Size = New System.Drawing.Size(228, 21)
        Me.cboModeOfPayment.TabIndex = 18
        '
        'grpOrderDetails
        '
        Me.grpOrderDetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpOrderDetails.Controls.Add(Me.lblOrderItems)
        Me.grpOrderDetails.Controls.Add(Me.gridOrderItems)
        Me.grpOrderDetails.Controls.Add(Me.btnClearItems)
        Me.grpOrderDetails.Controls.Add(Me.btnRemoveSelected)
        Me.grpOrderDetails.Controls.Add(Me.btnAdd)
        Me.grpOrderDetails.Controls.Add(Me.txtQuantity)
        Me.grpOrderDetails.Controls.Add(Me.txtDescription)
        Me.grpOrderDetails.Controls.Add(Me.lblQuantity)
        Me.grpOrderDetails.Controls.Add(Me.lblDescription)
        Me.grpOrderDetails.Controls.Add(Me.txtItem)
        Me.grpOrderDetails.Controls.Add(Me.lblItem)
        Me.grpOrderDetails.Controls.Add(Me.lblOrderNoValue)
        Me.grpOrderDetails.Controls.Add(Me.lblOrderNo)
        Me.grpOrderDetails.Location = New System.Drawing.Point(483, 26)
        Me.grpOrderDetails.Name = "grpOrderDetails"
        Me.grpOrderDetails.Size = New System.Drawing.Size(588, 521)
        Me.grpOrderDetails.TabIndex = 16
        Me.grpOrderDetails.TabStop = False
        Me.grpOrderDetails.Text = "Order Details"
        '
        'lblOrderItems
        '
        Me.lblOrderItems.AutoSize = True
        Me.lblOrderItems.Location = New System.Drawing.Point(467, 254)
        Me.lblOrderItems.Name = "lblOrderItems"
        Me.lblOrderItems.Size = New System.Drawing.Size(41, 13)
        Me.lblOrderItems.TabIndex = 12
        Me.lblOrderItems.Text = "0 Items"
        '
        'gridOrderItems
        '
        Me.gridOrderItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridOrderItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridOrderItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridOrderItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item_id, Me.item_name, Me.description, Me.quantity})
        Me.gridOrderItems.Location = New System.Drawing.Point(6, 282)
        Me.gridOrderItems.Name = "gridOrderItems"
        Me.gridOrderItems.ReadOnly = True
        Me.gridOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridOrderItems.Size = New System.Drawing.Size(576, 225)
        Me.gridOrderItems.TabIndex = 11
        '
        'item_id
        '
        Me.item_id.HeaderText = "Item ID"
        Me.item_id.Name = "item_id"
        Me.item_id.ReadOnly = True
        '
        'item_name
        '
        Me.item_name.HeaderText = "Item Name"
        Me.item_name.Name = "item_name"
        Me.item_name.ReadOnly = True
        '
        'description
        '
        Me.description.HeaderText = "Description"
        Me.description.Name = "description"
        Me.description.ReadOnly = True
        '
        'quantity
        '
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        '
        'btnClearItems
        '
        Me.btnClearItems.Location = New System.Drawing.Point(309, 245)
        Me.btnClearItems.Name = "btnClearItems"
        Me.btnClearItems.Size = New System.Drawing.Size(101, 31)
        Me.btnClearItems.TabIndex = 10
        Me.btnClearItems.Text = "Clear Items"
        Me.btnClearItems.UseVisualStyleBackColor = True
        '
        'btnRemoveSelected
        '
        Me.btnRemoveSelected.Location = New System.Drawing.Point(191, 245)
        Me.btnRemoveSelected.Name = "btnRemoveSelected"
        Me.btnRemoveSelected.Size = New System.Drawing.Size(101, 31)
        Me.btnRemoveSelected.TabIndex = 9
        Me.btnRemoveSelected.Text = "Remove Selected"
        Me.btnRemoveSelected.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(73, 245)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(101, 31)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(157, 208)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(254, 20)
        Me.txtQuantity.TabIndex = 7
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(157, 101)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(254, 88)
        Me.txtDescription.TabIndex = 6
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(82, 208)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(43, 13)
        Me.lblQuantity.TabIndex = 5
        Me.lblQuantity.Text = "Quanity"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(65, 101)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 4
        Me.lblDescription.Text = "Description"
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(157, 56)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(254, 20)
        Me.txtItem.TabIndex = 3
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(67, 63)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(58, 13)
        Me.lblItem.TabIndex = 2
        Me.lblItem.Text = "Item Name"
        '
        'lblOrderNoValue
        '
        Me.lblOrderNoValue.AutoSize = True
        Me.lblOrderNoValue.Location = New System.Drawing.Point(123, 28)
        Me.lblOrderNoValue.Name = "lblOrderNoValue"
        Me.lblOrderNoValue.Size = New System.Drawing.Size(58, 13)
        Me.lblOrderNoValue.TabIndex = 1
        Me.lblOrderNoValue.Text = "O345HW3"
        '
        'lblOrderNo
        '
        Me.lblOrderNo.AutoSize = True
        Me.lblOrderNo.Location = New System.Drawing.Point(66, 28)
        Me.lblOrderNo.Name = "lblOrderNo"
        Me.lblOrderNo.Size = New System.Drawing.Size(50, 13)
        Me.lblOrderNo.TabIndex = 0
        Me.lblOrderNo.Text = "Order No"
        '
        'txtSupplierEmail
        '
        Me.txtSupplierEmail.Location = New System.Drawing.Point(94, 106)
        Me.txtSupplierEmail.Name = "txtSupplierEmail"
        Me.txtSupplierEmail.Size = New System.Drawing.Size(258, 20)
        Me.txtSupplierEmail.TabIndex = 5
        '
        'lblSupplierEmail
        '
        Me.lblSupplierEmail.AutoSize = True
        Me.lblSupplierEmail.Location = New System.Drawing.Point(47, 109)
        Me.lblSupplierEmail.Name = "lblSupplierEmail"
        Me.lblSupplierEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblSupplierEmail.TabIndex = 4
        Me.lblSupplierEmail.Text = "Email"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(94, 71)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(258, 20)
        Me.txtFullName.TabIndex = 3
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(25, 74)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(54, 13)
        Me.lblFullName.TabIndex = 2
        Me.lblFullName.Text = "Full Name"
        '
        'lblSelectName
        '
        Me.lblSelectName.AutoSize = True
        Me.lblSelectName.Location = New System.Drawing.Point(11, 37)
        Me.lblSelectName.Name = "lblSelectName"
        Me.lblSelectName.Size = New System.Drawing.Size(68, 13)
        Me.lblSelectName.TabIndex = 1
        Me.lblSelectName.Text = "Select Name"
        '
        'cboSuppliers
        '
        Me.cboSuppliers.FormattingEnabled = True
        Me.cboSuppliers.Location = New System.Drawing.Point(94, 30)
        Me.cboSuppliers.Name = "cboSuppliers"
        Me.cboSuppliers.Size = New System.Drawing.Size(203, 21)
        Me.cboSuppliers.TabIndex = 0
        '
        'grpSupplier
        '
        Me.grpSupplier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpSupplier.Controls.Add(Me.txtSupplierAddress)
        Me.grpSupplier.Controls.Add(Me.lblSupplierAddress)
        Me.grpSupplier.Controls.Add(Me.txtSupplierPhone)
        Me.grpSupplier.Controls.Add(Me.lblSupplierPhone)
        Me.grpSupplier.Controls.Add(Me.txtSupplierEmail)
        Me.grpSupplier.Controls.Add(Me.lblSupplierEmail)
        Me.grpSupplier.Controls.Add(Me.txtFullName)
        Me.grpSupplier.Controls.Add(Me.lblFullName)
        Me.grpSupplier.Controls.Add(Me.lblSelectName)
        Me.grpSupplier.Controls.Add(Me.cboSuppliers)
        Me.grpSupplier.Location = New System.Drawing.Point(46, 367)
        Me.grpSupplier.Name = "grpSupplier"
        Me.grpSupplier.Size = New System.Drawing.Size(431, 222)
        Me.grpSupplier.TabIndex = 17
        Me.grpSupplier.TabStop = False
        Me.grpSupplier.Text = "Choose Supplier"
        '
        'bgWorker
        '
        Me.bgWorker.WorkerReportsProgress = True
        Me.bgWorker.WorkerSupportsCancellation = True
        '
        'OrdersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 647)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.chkConfirm)
        Me.Controls.Add(Me.grpBillingInformation)
        Me.Controls.Add(Me.grpOrderDetails)
        Me.Controls.Add(Me.grpSupplier)
        Me.Name = "OrdersForm"
        Me.Text = "OrdersForm"
        Me.grpBillingInformation.ResumeLayout(False)
        Me.grpBillingInformation.PerformLayout()
        Me.grpOrderDetails.ResumeLayout(False)
        Me.grpOrderDetails.PerformLayout()
        CType(Me.gridOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSupplier.ResumeLayout(False)
        Me.grpSupplier.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSupplierAddress As TextBox
    Friend WithEvents txtSupplierPhone As TextBox
    Friend WithEvents btnContinue As Button
    Friend WithEvents lblModeOfPayment As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents chkConfirm As CheckBox
    Friend WithEvents lblSupplierAddress As Label
    Friend WithEvents lblSupplierPhone As Label
    Friend WithEvents grpBillingInformation As GroupBox
    Friend WithEvents grpOrderDetails As GroupBox
    Friend WithEvents gridOrderItems As DataGridView
    Friend WithEvents btnClearItems As Button
    Friend WithEvents btnRemoveSelected As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtItem As TextBox
    Friend WithEvents lblItem As Label
    Friend WithEvents lblOrderNoValue As Label
    Friend WithEvents lblOrderNo As Label
    Friend WithEvents txtSupplierEmail As TextBox
    Friend WithEvents lblSupplierEmail As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblSelectName As Label
    Friend WithEvents cboSuppliers As ComboBox
    Friend WithEvents grpSupplier As GroupBox
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents item_id As DataGridViewTextBoxColumn
    Friend WithEvents item_name As DataGridViewTextBoxColumn
    Friend WithEvents description As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents lblOrderItems As Label
    Friend WithEvents cboModeOfPayment As ComboBox
End Class
