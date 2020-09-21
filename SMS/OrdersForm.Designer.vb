<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdersForm
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gridOrderedItems = New System.Windows.Forms.DataGridView()
        Me.lstOrderID = New System.Windows.Forms.ListBox()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.txtNoOfItems = New System.Windows.Forms.TextBox()
        Me.lblNoOfItems = New System.Windows.Forms.Label()
        Me.txtDateOrdered = New System.Windows.Forms.TextBox()
        Me.lblDateOrdered = New System.Windows.Forms.Label()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.txtOrderedBy = New System.Windows.Forms.TextBox()
        Me.lblOrderedBy = New System.Windows.Forms.Label()
        Me.txtModeOfPayment = New System.Windows.Forms.TextBox()
        Me.lblModeOfPayment = New System.Windows.Forms.Label()
        Me.txtOrderStatus = New System.Windows.Forms.TextBox()
        Me.lblOrderStatus = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.btnMoveNext = New System.Windows.Forms.Button()
        Me.btnMoveLast = New System.Windows.Forms.Button()
        Me.btnMovePrevious = New System.Windows.Forms.Button()
        Me.btnMoveFirst = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpOrderDetails = New System.Windows.Forms.GroupBox()
        Me.grpOrderedItems = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        CType(Me.gridOrderedItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOrderDetails.SuspendLayout()
        Me.grpOrderedItems.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridOrderedItems
        '
        Me.gridOrderedItems.AllowUserToAddRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        Me.gridOrderedItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.gridOrderedItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridOrderedItems.BackgroundColor = System.Drawing.Color.White
        Me.gridOrderedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridOrderedItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridOrderedItems.Location = New System.Drawing.Point(3, 16)
        Me.gridOrderedItems.Name = "gridOrderedItems"
        Me.gridOrderedItems.Size = New System.Drawing.Size(777, 226)
        Me.gridOrderedItems.TabIndex = 0
        '
        'lstOrderID
        '
        Me.lstOrderID.Dock = System.Windows.Forms.DockStyle.Right
        Me.lstOrderID.FormattingEnabled = True
        Me.lstOrderID.Location = New System.Drawing.Point(783, 0)
        Me.lstOrderID.Name = "lstOrderID"
        Me.lstOrderID.Size = New System.Drawing.Size(171, 601)
        Me.lstOrderID.TabIndex = 1
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Location = New System.Drawing.Point(20, 30)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(47, 13)
        Me.lblOrderID.TabIndex = 3
        Me.lblOrderID.Text = "Order ID"
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(23, 53)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(166, 20)
        Me.txtOrderID.TabIndex = 4
        '
        'txtNoOfItems
        '
        Me.txtNoOfItems.Location = New System.Drawing.Point(387, 53)
        Me.txtNoOfItems.Name = "txtNoOfItems"
        Me.txtNoOfItems.Size = New System.Drawing.Size(94, 20)
        Me.txtNoOfItems.TabIndex = 6
        '
        'lblNoOfItems
        '
        Me.lblNoOfItems.AutoSize = True
        Me.lblNoOfItems.Location = New System.Drawing.Point(384, 34)
        Me.lblNoOfItems.Name = "lblNoOfItems"
        Me.lblNoOfItems.Size = New System.Drawing.Size(66, 13)
        Me.lblNoOfItems.TabIndex = 5
        Me.lblNoOfItems.Text = "No. Of Items"
        '
        'txtDateOrdered
        '
        Me.txtDateOrdered.Location = New System.Drawing.Point(23, 106)
        Me.txtDateOrdered.Name = "txtDateOrdered"
        Me.txtDateOrdered.Size = New System.Drawing.Size(166, 20)
        Me.txtDateOrdered.TabIndex = 8
        '
        'lblDateOrdered
        '
        Me.lblDateOrdered.AutoSize = True
        Me.lblDateOrdered.Location = New System.Drawing.Point(20, 83)
        Me.lblDateOrdered.Name = "lblDateOrdered"
        Me.lblDateOrdered.Size = New System.Drawing.Size(71, 13)
        Me.lblDateOrdered.TabIndex = 7
        Me.lblDateOrdered.Text = "Date Ordered"
        '
        'txtSupplier
        '
        Me.txtSupplier.Location = New System.Drawing.Point(23, 159)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(276, 20)
        Me.txtSupplier.TabIndex = 10
        '
        'lblSupplier
        '
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.Location = New System.Drawing.Point(20, 136)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(45, 13)
        Me.lblSupplier.TabIndex = 9
        Me.lblSupplier.Text = "Supplier"
        '
        'txtOrderedBy
        '
        Me.txtOrderedBy.Location = New System.Drawing.Point(23, 212)
        Me.txtOrderedBy.Name = "txtOrderedBy"
        Me.txtOrderedBy.Size = New System.Drawing.Size(276, 20)
        Me.txtOrderedBy.TabIndex = 12
        '
        'lblOrderedBy
        '
        Me.lblOrderedBy.AutoSize = True
        Me.lblOrderedBy.Location = New System.Drawing.Point(20, 189)
        Me.lblOrderedBy.Name = "lblOrderedBy"
        Me.lblOrderedBy.Size = New System.Drawing.Size(60, 13)
        Me.lblOrderedBy.TabIndex = 11
        Me.lblOrderedBy.Text = "Ordered By"
        '
        'txtModeOfPayment
        '
        Me.txtModeOfPayment.Location = New System.Drawing.Point(387, 106)
        Me.txtModeOfPayment.Multiline = True
        Me.txtModeOfPayment.Name = "txtModeOfPayment"
        Me.txtModeOfPayment.Size = New System.Drawing.Size(302, 73)
        Me.txtModeOfPayment.TabIndex = 14
        '
        'lblModeOfPayment
        '
        Me.lblModeOfPayment.AutoSize = True
        Me.lblModeOfPayment.Location = New System.Drawing.Point(384, 83)
        Me.lblModeOfPayment.Name = "lblModeOfPayment"
        Me.lblModeOfPayment.Size = New System.Drawing.Size(97, 13)
        Me.lblModeOfPayment.TabIndex = 13
        Me.lblModeOfPayment.Text = "Modes Of Payment"
        '
        'txtOrderStatus
        '
        Me.txtOrderStatus.Location = New System.Drawing.Point(387, 212)
        Me.txtOrderStatus.Name = "txtOrderStatus"
        Me.txtOrderStatus.Size = New System.Drawing.Size(166, 20)
        Me.txtOrderStatus.TabIndex = 16
        '
        'lblOrderStatus
        '
        Me.lblOrderStatus.AutoSize = True
        Me.lblOrderStatus.Location = New System.Drawing.Point(384, 193)
        Me.lblOrderStatus.Name = "lblOrderStatus"
        Me.lblOrderStatus.Size = New System.Drawing.Size(66, 13)
        Me.lblOrderStatus.TabIndex = 15
        Me.lblOrderStatus.Text = "Order Status"
        '
        'btnNew
        '
        Me.btnNew.AutoSize = True
        Me.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Image = Global.SMS.My.Resources.Resources._new
        Me.btnNew.Location = New System.Drawing.Point(456, 264)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(30, 30)
        Me.btnNew.TabIndex = 97
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(297, 273)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(50, 13)
        Me.lblPosition.TabIndex = 96
        Me.lblPosition.Text = "0 Of { 0 }"
        '
        'btnMoveNext
        '
        Me.btnMoveNext.AutoSize = True
        Me.btnMoveNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMoveNext.FlatAppearance.BorderSize = 0
        Me.btnMoveNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoveNext.Image = Global.SMS.My.Resources.Resources.go_forward
        Me.btnMoveNext.Location = New System.Drawing.Point(367, 264)
        Me.btnMoveNext.Name = "btnMoveNext"
        Me.btnMoveNext.Size = New System.Drawing.Size(30, 30)
        Me.btnMoveNext.TabIndex = 95
        Me.btnMoveNext.UseVisualStyleBackColor = True
        '
        'btnMoveLast
        '
        Me.btnMoveLast.AutoSize = True
        Me.btnMoveLast.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMoveLast.FlatAppearance.BorderSize = 0
        Me.btnMoveLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoveLast.Image = Global.SMS.My.Resources.Resources.last_recor
        Me.btnMoveLast.Location = New System.Drawing.Point(411, 264)
        Me.btnMoveLast.Name = "btnMoveLast"
        Me.btnMoveLast.Size = New System.Drawing.Size(30, 30)
        Me.btnMoveLast.TabIndex = 94
        Me.btnMoveLast.UseVisualStyleBackColor = True
        '
        'btnMovePrevious
        '
        Me.btnMovePrevious.AutoSize = True
        Me.btnMovePrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMovePrevious.FlatAppearance.BorderSize = 0
        Me.btnMovePrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMovePrevious.Image = Global.SMS.My.Resources.Resources.go_back
        Me.btnMovePrevious.Location = New System.Drawing.Point(253, 264)
        Me.btnMovePrevious.Name = "btnMovePrevious"
        Me.btnMovePrevious.Size = New System.Drawing.Size(30, 30)
        Me.btnMovePrevious.TabIndex = 93
        Me.btnMovePrevious.UseVisualStyleBackColor = True
        '
        'btnMoveFirst
        '
        Me.btnMoveFirst.AutoSize = True
        Me.btnMoveFirst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMoveFirst.FlatAppearance.BorderSize = 0
        Me.btnMoveFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoveFirst.Image = Global.SMS.My.Resources.Resources.first_record
        Me.btnMoveFirst.Location = New System.Drawing.Point(209, 264)
        Me.btnMoveFirst.Name = "btnMoveFirst"
        Me.btnMoveFirst.Size = New System.Drawing.Size(30, 30)
        Me.btnMoveFirst.TabIndex = 92
        Me.btnMoveFirst.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(783, 36)
        Me.lblTitle.TabIndex = 98
        Me.lblTitle.Text = "Stock Management System : ORDERS"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpOrderDetails
        '
        Me.grpOrderDetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpOrderDetails.Controls.Add(Me.txtOrderID)
        Me.grpOrderDetails.Controls.Add(Me.lblOrderID)
        Me.grpOrderDetails.Controls.Add(Me.btnNew)
        Me.grpOrderDetails.Controls.Add(Me.lblNoOfItems)
        Me.grpOrderDetails.Controls.Add(Me.lblPosition)
        Me.grpOrderDetails.Controls.Add(Me.txtNoOfItems)
        Me.grpOrderDetails.Controls.Add(Me.btnMoveNext)
        Me.grpOrderDetails.Controls.Add(Me.lblDateOrdered)
        Me.grpOrderDetails.Controls.Add(Me.btnMoveLast)
        Me.grpOrderDetails.Controls.Add(Me.txtDateOrdered)
        Me.grpOrderDetails.Controls.Add(Me.btnMovePrevious)
        Me.grpOrderDetails.Controls.Add(Me.lblSupplier)
        Me.grpOrderDetails.Controls.Add(Me.btnMoveFirst)
        Me.grpOrderDetails.Controls.Add(Me.txtSupplier)
        Me.grpOrderDetails.Controls.Add(Me.txtOrderStatus)
        Me.grpOrderDetails.Controls.Add(Me.lblOrderedBy)
        Me.grpOrderDetails.Controls.Add(Me.lblOrderStatus)
        Me.grpOrderDetails.Controls.Add(Me.txtOrderedBy)
        Me.grpOrderDetails.Controls.Add(Me.txtModeOfPayment)
        Me.grpOrderDetails.Controls.Add(Me.lblModeOfPayment)
        Me.grpOrderDetails.Location = New System.Drawing.Point(45, 39)
        Me.grpOrderDetails.Name = "grpOrderDetails"
        Me.grpOrderDetails.Size = New System.Drawing.Size(695, 311)
        Me.grpOrderDetails.TabIndex = 99
        Me.grpOrderDetails.TabStop = False
        Me.grpOrderDetails.Text = "Order Details"
        '
        'grpOrderedItems
        '
        Me.grpOrderedItems.Controls.Add(Me.gridOrderedItems)
        Me.grpOrderedItems.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpOrderedItems.Location = New System.Drawing.Point(0, 356)
        Me.grpOrderedItems.Name = "grpOrderedItems"
        Me.grpOrderedItems.Size = New System.Drawing.Size(783, 245)
        Me.grpOrderedItems.TabIndex = 100
        Me.grpOrderedItems.TabStop = False
        Me.grpOrderedItems.Text = "Ordered Items"
        '
        'BackgroundWorker
        '
        Me.BackgroundWorker.WorkerReportsProgress = True
        Me.BackgroundWorker.WorkerSupportsCancellation = True
        '
        'OrdersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 601)
        Me.Controls.Add(Me.grpOrderedItems)
        Me.Controls.Add(Me.grpOrderDetails)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lstOrderID)
        Me.Name = "OrdersForm"
        Me.Text = "OrdersForm"
        CType(Me.gridOrderedItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOrderDetails.ResumeLayout(False)
        Me.grpOrderDetails.PerformLayout()
        Me.grpOrderedItems.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gridOrderedItems As DataGridView
    Friend WithEvents lstOrderID As ListBox
    Friend WithEvents lblOrderID As Label
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents txtNoOfItems As TextBox
    Friend WithEvents lblNoOfItems As Label
    Friend WithEvents txtDateOrdered As TextBox
    Friend WithEvents lblDateOrdered As Label
    Friend WithEvents txtSupplier As TextBox
    Friend WithEvents lblSupplier As Label
    Friend WithEvents txtOrderedBy As TextBox
    Friend WithEvents lblOrderedBy As Label
    Friend WithEvents txtModeOfPayment As TextBox
    Friend WithEvents lblModeOfPayment As Label
    Friend WithEvents txtOrderStatus As TextBox
    Friend WithEvents lblOrderStatus As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents lblPosition As Label
    Friend WithEvents btnMoveNext As Button
    Friend WithEvents btnMoveLast As Button
    Friend WithEvents btnMovePrevious As Button
    Friend WithEvents btnMoveFirst As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpOrderDetails As GroupBox
    Friend WithEvents grpOrderedItems As GroupBox
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
End Class
