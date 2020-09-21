<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuppliersForm
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
        Me.grpSupplierDetails = New System.Windows.Forms.GroupBox()
        Me.txtProducts = New System.Windows.Forms.TextBox()
        Me.lblProducts = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnMoveNext = New System.Windows.Forms.Button()
        Me.btnMoveLast = New System.Windows.Forms.Button()
        Me.btnMovePrevious = New System.Windows.Forms.Button()
        Me.btnMoveFirst = New System.Windows.Forms.Button()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtRegion = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.lblPostalCode = New System.Windows.Forms.Label()
        Me.txtHouseNumber = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblOtherNumber = New System.Windows.Forms.Label()
        Me.txtStreetName = New System.Windows.Forms.TextBox()
        Me.lblHouseNumber = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblStreetName = New System.Windows.Forms.Label()
        Me.txtOtherNumber = New System.Windows.Forms.TextBox()
        Me.lblSupplierId = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtSupplierId = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.grpSupplierDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSupplierDetails
        '
        Me.grpSupplierDetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpSupplierDetails.BackColor = System.Drawing.SystemColors.Control
        Me.grpSupplierDetails.Controls.Add(Me.txtProducts)
        Me.grpSupplierDetails.Controls.Add(Me.lblProducts)
        Me.grpSupplierDetails.Controls.Add(Me.lblPosition)
        Me.grpSupplierDetails.Controls.Add(Me.btnUpdate)
        Me.grpSupplierDetails.Controls.Add(Me.btnDelete)
        Me.grpSupplierDetails.Controls.Add(Me.btnNew)
        Me.grpSupplierDetails.Controls.Add(Me.btnSave)
        Me.grpSupplierDetails.Controls.Add(Me.btnMoveNext)
        Me.grpSupplierDetails.Controls.Add(Me.btnMoveLast)
        Me.grpSupplierDetails.Controls.Add(Me.btnMovePrevious)
        Me.grpSupplierDetails.Controls.Add(Me.btnMoveFirst)
        Me.grpSupplierDetails.Controls.Add(Me.txtState)
        Me.grpSupplierDetails.Controls.Add(Me.lblState)
        Me.grpSupplierDetails.Controls.Add(Me.txtRegion)
        Me.grpSupplierDetails.Controls.Add(Me.txtEmail)
        Me.grpSupplierDetails.Controls.Add(Me.lblRegion)
        Me.grpSupplierDetails.Controls.Add(Me.lblEmail)
        Me.grpSupplierDetails.Controls.Add(Me.txtPostalCode)
        Me.grpSupplierDetails.Controls.Add(Me.lblPostalCode)
        Me.grpSupplierDetails.Controls.Add(Me.txtHouseNumber)
        Me.grpSupplierDetails.Controls.Add(Me.lblPhoneNumber)
        Me.grpSupplierDetails.Controls.Add(Me.lblOtherNumber)
        Me.grpSupplierDetails.Controls.Add(Me.txtStreetName)
        Me.grpSupplierDetails.Controls.Add(Me.lblHouseNumber)
        Me.grpSupplierDetails.Controls.Add(Me.txtPhoneNumber)
        Me.grpSupplierDetails.Controls.Add(Me.lblStreetName)
        Me.grpSupplierDetails.Controls.Add(Me.txtOtherNumber)
        Me.grpSupplierDetails.Controls.Add(Me.lblSupplierId)
        Me.grpSupplierDetails.Controls.Add(Me.lblFirstName)
        Me.grpSupplierDetails.Controls.Add(Me.lblLastName)
        Me.grpSupplierDetails.Controls.Add(Me.txtSupplierId)
        Me.grpSupplierDetails.Controls.Add(Me.txtFirstName)
        Me.grpSupplierDetails.Controls.Add(Me.txtLastName)
        Me.grpSupplierDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSupplierDetails.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpSupplierDetails.Location = New System.Drawing.Point(28, 12)
        Me.grpSupplierDetails.Name = "grpSupplierDetails"
        Me.grpSupplierDetails.Size = New System.Drawing.Size(745, 514)
        Me.grpSupplierDetails.TabIndex = 66
        Me.grpSupplierDetails.TabStop = False
        Me.grpSupplierDetails.Text = "Supplier Details"
        '
        'txtProducts
        '
        Me.txtProducts.Location = New System.Drawing.Point(500, 108)
        Me.txtProducts.Multiline = True
        Me.txtProducts.Name = "txtProducts"
        Me.txtProducts.Size = New System.Drawing.Size(239, 242)
        Me.txtProducts.TabIndex = 76
        '
        'lblProducts
        '
        Me.lblProducts.AutoSize = True
        Me.lblProducts.Location = New System.Drawing.Point(497, 83)
        Me.lblProducts.Name = "lblProducts"
        Me.lblProducts.Size = New System.Drawing.Size(49, 13)
        Me.lblProducts.TabIndex = 75
        Me.lblProducts.Text = "Products"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(240, 484)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(50, 13)
        Me.lblPosition.TabIndex = 73
        Me.lblPosition.Text = "0 Of { 0 }"
        '
        'btnUpdate
        '
        Me.btnUpdate.AutoSize = True
        Me.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Image = Global.SMS.My.Resources.Resources.update
        Me.btnUpdate.Location = New System.Drawing.Point(500, 478)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(30, 30)
        Me.btnUpdate.TabIndex = 72
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.AutoSize = True
        Me.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Image = Global.SMS.My.Resources.Resources.close
        Me.btnDelete.Location = New System.Drawing.Point(546, 478)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(30, 30)
        Me.btnDelete.TabIndex = 71
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.AutoSize = True
        Me.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Image = Global.SMS.My.Resources.Resources._new
        Me.btnNew.Location = New System.Drawing.Point(408, 478)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(30, 30)
        Me.btnNew.TabIndex = 70
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Image = Global.SMS.My.Resources.Resources.save
        Me.btnSave.Location = New System.Drawing.Point(454, 478)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(30, 30)
        Me.btnSave.TabIndex = 69
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnMoveNext
        '
        Me.btnMoveNext.AutoSize = True
        Me.btnMoveNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMoveNext.FlatAppearance.BorderSize = 0
        Me.btnMoveNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoveNext.Image = Global.SMS.My.Resources.Resources.go_forward
        Me.btnMoveNext.Location = New System.Drawing.Point(324, 478)
        Me.btnMoveNext.Name = "btnMoveNext"
        Me.btnMoveNext.Size = New System.Drawing.Size(30, 30)
        Me.btnMoveNext.TabIndex = 68
        Me.btnMoveNext.UseVisualStyleBackColor = True
        '
        'btnMoveLast
        '
        Me.btnMoveLast.AutoSize = True
        Me.btnMoveLast.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMoveLast.FlatAppearance.BorderSize = 0
        Me.btnMoveLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoveLast.Image = Global.SMS.My.Resources.Resources.last_recor
        Me.btnMoveLast.Location = New System.Drawing.Point(362, 478)
        Me.btnMoveLast.Name = "btnMoveLast"
        Me.btnMoveLast.Size = New System.Drawing.Size(30, 30)
        Me.btnMoveLast.TabIndex = 67
        Me.btnMoveLast.UseVisualStyleBackColor = True
        '
        'btnMovePrevious
        '
        Me.btnMovePrevious.AutoSize = True
        Me.btnMovePrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMovePrevious.FlatAppearance.BorderSize = 0
        Me.btnMovePrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMovePrevious.Image = Global.SMS.My.Resources.Resources.go_back
        Me.btnMovePrevious.Location = New System.Drawing.Point(186, 478)
        Me.btnMovePrevious.Name = "btnMovePrevious"
        Me.btnMovePrevious.Size = New System.Drawing.Size(30, 30)
        Me.btnMovePrevious.TabIndex = 66
        Me.btnMovePrevious.UseVisualStyleBackColor = True
        '
        'btnMoveFirst
        '
        Me.btnMoveFirst.AutoSize = True
        Me.btnMoveFirst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMoveFirst.FlatAppearance.BorderSize = 0
        Me.btnMoveFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoveFirst.Image = Global.SMS.My.Resources.Resources.first_record
        Me.btnMoveFirst.Location = New System.Drawing.Point(148, 478)
        Me.btnMoveFirst.Name = "btnMoveFirst"
        Me.btnMoveFirst.Size = New System.Drawing.Size(30, 30)
        Me.btnMoveFirst.TabIndex = 65
        Me.btnMoveFirst.UseVisualStyleBackColor = True
        '
        'txtState
        '
        Me.txtState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.Location = New System.Drawing.Point(250, 423)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(212, 26)
        Me.txtState.TabIndex = 61
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(247, 398)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(85, 13)
        Me.lblState.TabIndex = 56
        Me.lblState.Text = "State / Province"
        '
        'txtRegion
        '
        Me.txtRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegion.Location = New System.Drawing.Point(20, 423)
        Me.txtRegion.Name = "txtRegion"
        Me.txtRegion.Size = New System.Drawing.Size(201, 26)
        Me.txtRegion.TabIndex = 60
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(20, 171)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(442, 26)
        Me.txtEmail.TabIndex = 58
        '
        'lblRegion
        '
        Me.lblRegion.AutoSize = True
        Me.lblRegion.Location = New System.Drawing.Point(17, 398)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(88, 13)
        Me.lblRegion.TabIndex = 55
        Me.lblRegion.Text = "Country / Region"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(17, 146)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 55
        Me.lblEmail.Text = "Email"
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostalCode.Location = New System.Drawing.Point(20, 362)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(201, 26)
        Me.txtPostalCode.TabIndex = 62
        '
        'lblPostalCode
        '
        Me.lblPostalCode.AutoSize = True
        Me.lblPostalCode.Location = New System.Drawing.Point(17, 337)
        Me.lblPostalCode.Name = "lblPostalCode"
        Me.lblPostalCode.Size = New System.Drawing.Size(64, 13)
        Me.lblPostalCode.TabIndex = 57
        Me.lblPostalCode.Text = "Postal Code"
        '
        'txtHouseNumber
        '
        Me.txtHouseNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseNumber.Location = New System.Drawing.Point(250, 297)
        Me.txtHouseNumber.Name = "txtHouseNumber"
        Me.txtHouseNumber.Size = New System.Drawing.Size(216, 26)
        Me.txtHouseNumber.TabIndex = 64
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(17, 209)
        Me.lblPhoneNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(78, 13)
        Me.lblPhoneNumber.TabIndex = 56
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'lblOtherNumber
        '
        Me.lblOtherNumber.AutoSize = True
        Me.lblOtherNumber.Location = New System.Drawing.Point(247, 209)
        Me.lblOtherNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOtherNumber.Name = "lblOtherNumber"
        Me.lblOtherNumber.Size = New System.Drawing.Size(73, 13)
        Me.lblOtherNumber.TabIndex = 57
        Me.lblOtherNumber.Text = "Other Number"
        '
        'txtStreetName
        '
        Me.txtStreetName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreetName.Location = New System.Drawing.Point(20, 297)
        Me.txtStreetName.Name = "txtStreetName"
        Me.txtStreetName.Size = New System.Drawing.Size(201, 26)
        Me.txtStreetName.TabIndex = 63
        '
        'lblHouseNumber
        '
        Me.lblHouseNumber.AutoSize = True
        Me.lblHouseNumber.Location = New System.Drawing.Point(247, 272)
        Me.lblHouseNumber.Name = "lblHouseNumber"
        Me.lblHouseNumber.Size = New System.Drawing.Size(78, 13)
        Me.lblHouseNumber.TabIndex = 59
        Me.lblHouseNumber.Text = "House Number"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(20, 234)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(201, 26)
        Me.txtPhoneNumber.TabIndex = 59
        '
        'lblStreetName
        '
        Me.lblStreetName.AutoSize = True
        Me.lblStreetName.Location = New System.Drawing.Point(17, 272)
        Me.lblStreetName.Name = "lblStreetName"
        Me.lblStreetName.Size = New System.Drawing.Size(66, 13)
        Me.lblStreetName.TabIndex = 58
        Me.lblStreetName.Text = "Street Name"
        '
        'txtOtherNumber
        '
        Me.txtOtherNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherNumber.Location = New System.Drawing.Point(250, 234)
        Me.txtOtherNumber.Name = "txtOtherNumber"
        Me.txtOtherNumber.Size = New System.Drawing.Size(216, 26)
        Me.txtOtherNumber.TabIndex = 60
        '
        'lblSupplierId
        '
        Me.lblSupplierId.AutoSize = True
        Me.lblSupplierId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplierId.Location = New System.Drawing.Point(17, 20)
        Me.lblSupplierId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSupplierId.Name = "lblSupplierId"
        Me.lblSupplierId.Size = New System.Drawing.Size(59, 13)
        Me.lblSupplierId.TabIndex = 34
        Me.lblSupplierId.Text = "Supplier ID"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(17, 83)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 35
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(258, 83)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 36
        Me.lblLastName.Text = "Last Name"
        '
        'txtSupplierId
        '
        Me.txtSupplierId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplierId.Location = New System.Drawing.Point(20, 45)
        Me.txtSupplierId.Name = "txtSupplierId"
        Me.txtSupplierId.Size = New System.Drawing.Size(201, 26)
        Me.txtSupplierId.TabIndex = 49
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(20, 108)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(201, 26)
        Me.txtFirstName.TabIndex = 50
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(261, 108)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(201, 26)
        Me.txtLastName.TabIndex = 51
        '
        'BackgroundWorker
        '
        Me.BackgroundWorker.WorkerReportsProgress = True
        Me.BackgroundWorker.WorkerSupportsCancellation = True
        '
        'SuppliersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 538)
        Me.Controls.Add(Me.grpSupplierDetails)
        Me.Name = "SuppliersForm"
        Me.Text = "Suppliers"
        Me.grpSupplierDetails.ResumeLayout(False)
        Me.grpSupplierDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpSupplierDetails As GroupBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents lblState As Label
    Friend WithEvents txtRegion As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblRegion As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtPostalCode As TextBox
    Friend WithEvents lblPostalCode As Label
    Friend WithEvents txtHouseNumber As TextBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblOtherNumber As Label
    Friend WithEvents txtStreetName As TextBox
    Friend WithEvents lblHouseNumber As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents lblStreetName As Label
    Friend WithEvents txtOtherNumber As TextBox
    Friend WithEvents lblSupplierId As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtSupplierId As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblProducts As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnMoveNext As Button
    Friend WithEvents btnMoveLast As Button
    Friend WithEvents btnMovePrevious As Button
    Friend WithEvents btnMoveFirst As Button
    Friend WithEvents txtProducts As TextBox
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
End Class
