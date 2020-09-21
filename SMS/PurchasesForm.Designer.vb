<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PurchasesForm
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
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.gridPurchaseDetails = New System.Windows.Forms.DataGridView()
        Me.grpOrderSummary = New System.Windows.Forms.GroupBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.txtItemsOrdered = New System.Windows.Forms.TextBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblItemsOrdered = New System.Windows.Forms.Label()
        Me.btnMoveNext = New System.Windows.Forms.Button()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.btnMoveLast = New System.Windows.Forms.Button()
        Me.btnMoreDetails = New System.Windows.Forms.Button()
        Me.btnMovePrevious = New System.Windows.Forms.Button()
        Me.btnMoveFirst = New System.Windows.Forms.Button()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.txtBillingAddress = New System.Windows.Forms.TextBox()
        Me.txtBillingName = New System.Windows.Forms.TextBox()
        Me.txtSupplierAddress = New System.Windows.Forms.TextBox()
        Me.txtDateOrdered = New System.Windows.Forms.TextBox()
        Me.txtOrderId = New System.Windows.Forms.TextBox()
        Me.lblBillingAddress = New System.Windows.Forms.Label()
        Me.lblBillingName = New System.Windows.Forms.Label()
        Me.lblSupplierAddress = New System.Windows.Forms.Label()
        Me.lblDateOrdered = New System.Windows.Forms.Label()
        Me.lblOrderId = New System.Windows.Forms.Label()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        CType(Me.gridPurchaseDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOrderSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer
        '
        Me.SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer.Name = "SplitContainer"
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.gridPurchaseDetails)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.AutoScroll = True
        Me.SplitContainer.Panel2.Controls.Add(Me.grpOrderSummary)
        Me.SplitContainer.Size = New System.Drawing.Size(1110, 641)
        Me.SplitContainer.SplitterDistance = 693
        Me.SplitContainer.TabIndex = 1
        '
        'gridPurchaseDetails
        '
        Me.gridPurchaseDetails.AllowUserToResizeColumns = False
        Me.gridPurchaseDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridPurchaseDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridPurchaseDetails.Location = New System.Drawing.Point(3, 11)
        Me.gridPurchaseDetails.Name = "gridPurchaseDetails"
        Me.gridPurchaseDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gridPurchaseDetails.Size = New System.Drawing.Size(676, 617)
        Me.gridPurchaseDetails.TabIndex = 0
        '
        'grpOrderSummary
        '
        Me.grpOrderSummary.Controls.Add(Me.btnNew)
        Me.grpOrderSummary.Controls.Add(Me.txtItemsOrdered)
        Me.grpOrderSummary.Controls.Add(Me.lblPosition)
        Me.grpOrderSummary.Controls.Add(Me.lblItemsOrdered)
        Me.grpOrderSummary.Controls.Add(Me.btnMoveNext)
        Me.grpOrderSummary.Controls.Add(Me.txtSupplier)
        Me.grpOrderSummary.Controls.Add(Me.btnMoveLast)
        Me.grpOrderSummary.Controls.Add(Me.btnMoreDetails)
        Me.grpOrderSummary.Controls.Add(Me.btnMovePrevious)
        Me.grpOrderSummary.Controls.Add(Me.btnMoveFirst)
        Me.grpOrderSummary.Controls.Add(Me.lblSupplier)
        Me.grpOrderSummary.Controls.Add(Me.txtBillingAddress)
        Me.grpOrderSummary.Controls.Add(Me.txtBillingName)
        Me.grpOrderSummary.Controls.Add(Me.txtSupplierAddress)
        Me.grpOrderSummary.Controls.Add(Me.txtDateOrdered)
        Me.grpOrderSummary.Controls.Add(Me.txtOrderId)
        Me.grpOrderSummary.Controls.Add(Me.lblBillingAddress)
        Me.grpOrderSummary.Controls.Add(Me.lblBillingName)
        Me.grpOrderSummary.Controls.Add(Me.lblSupplierAddress)
        Me.grpOrderSummary.Controls.Add(Me.lblDateOrdered)
        Me.grpOrderSummary.Controls.Add(Me.lblOrderId)
        Me.grpOrderSummary.Location = New System.Drawing.Point(13, 11)
        Me.grpOrderSummary.Name = "grpOrderSummary"
        Me.grpOrderSummary.Size = New System.Drawing.Size(389, 580)
        Me.grpOrderSummary.TabIndex = 1
        Me.grpOrderSummary.TabStop = False
        Me.grpOrderSummary.Text = "Order Summary"
        '
        'btnNew
        '
        Me.btnNew.AutoSize = True
        Me.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Image = Global.SMS.My.Resources.Resources._new
        Me.btnNew.Location = New System.Drawing.Point(311, 521)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(30, 30)
        Me.btnNew.TabIndex = 91
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'txtItemsOrdered
        '
        Me.txtItemsOrdered.Location = New System.Drawing.Point(123, 65)
        Me.txtItemsOrdered.Name = "txtItemsOrdered"
        Me.txtItemsOrdered.Size = New System.Drawing.Size(236, 20)
        Me.txtItemsOrdered.TabIndex = 18
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(153, 530)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(50, 13)
        Me.lblPosition.TabIndex = 90
        Me.lblPosition.Text = "0 Of { 0 }"
        '
        'lblItemsOrdered
        '
        Me.lblItemsOrdered.AutoSize = True
        Me.lblItemsOrdered.Location = New System.Drawing.Point(34, 68)
        Me.lblItemsOrdered.Name = "lblItemsOrdered"
        Me.lblItemsOrdered.Size = New System.Drawing.Size(73, 13)
        Me.lblItemsOrdered.TabIndex = 17
        Me.lblItemsOrdered.Text = "Items Ordered"
        '
        'btnMoveNext
        '
        Me.btnMoveNext.AutoSize = True
        Me.btnMoveNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMoveNext.FlatAppearance.BorderSize = 0
        Me.btnMoveNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoveNext.Image = Global.SMS.My.Resources.Resources.go_forward
        Me.btnMoveNext.Location = New System.Drawing.Point(223, 521)
        Me.btnMoveNext.Name = "btnMoveNext"
        Me.btnMoveNext.Size = New System.Drawing.Size(30, 30)
        Me.btnMoveNext.TabIndex = 85
        Me.btnMoveNext.UseVisualStyleBackColor = True
        '
        'txtSupplier
        '
        Me.txtSupplier.Location = New System.Drawing.Point(123, 163)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(236, 20)
        Me.txtSupplier.TabIndex = 12
        '
        'btnMoveLast
        '
        Me.btnMoveLast.AutoSize = True
        Me.btnMoveLast.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMoveLast.FlatAppearance.BorderSize = 0
        Me.btnMoveLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoveLast.Image = Global.SMS.My.Resources.Resources.last_recor
        Me.btnMoveLast.Location = New System.Drawing.Point(267, 521)
        Me.btnMoveLast.Name = "btnMoveLast"
        Me.btnMoveLast.Size = New System.Drawing.Size(30, 30)
        Me.btnMoveLast.TabIndex = 84
        Me.btnMoveLast.UseVisualStyleBackColor = True
        '
        'btnMoreDetails
        '
        Me.btnMoreDetails.FlatAppearance.BorderSize = 0
        Me.btnMoreDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMoreDetails.Image = Global.SMS.My.Resources.Resources.info
        Me.btnMoreDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMoreDetails.Location = New System.Drawing.Point(171, 471)
        Me.btnMoreDetails.Name = "btnMoreDetails"
        Me.btnMoreDetails.Size = New System.Drawing.Size(115, 33)
        Me.btnMoreDetails.TabIndex = 14
        Me.btnMoreDetails.Text = "More Details ..."
        Me.btnMoreDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMoreDetails.UseVisualStyleBackColor = True
        '
        'btnMovePrevious
        '
        Me.btnMovePrevious.AutoSize = True
        Me.btnMovePrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMovePrevious.FlatAppearance.BorderSize = 0
        Me.btnMovePrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMovePrevious.Image = Global.SMS.My.Resources.Resources.go_back
        Me.btnMovePrevious.Location = New System.Drawing.Point(109, 521)
        Me.btnMovePrevious.Name = "btnMovePrevious"
        Me.btnMovePrevious.Size = New System.Drawing.Size(30, 30)
        Me.btnMovePrevious.TabIndex = 83
        Me.btnMovePrevious.UseVisualStyleBackColor = True
        '
        'btnMoveFirst
        '
        Me.btnMoveFirst.AutoSize = True
        Me.btnMoveFirst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMoveFirst.FlatAppearance.BorderSize = 0
        Me.btnMoveFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoveFirst.Image = Global.SMS.My.Resources.Resources.first_record
        Me.btnMoveFirst.Location = New System.Drawing.Point(65, 521)
        Me.btnMoveFirst.Name = "btnMoveFirst"
        Me.btnMoveFirst.Size = New System.Drawing.Size(30, 30)
        Me.btnMoveFirst.TabIndex = 82
        Me.btnMoveFirst.UseVisualStyleBackColor = True
        '
        'lblSupplier
        '
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.Location = New System.Drawing.Point(62, 166)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(45, 13)
        Me.lblSupplier.TabIndex = 11
        Me.lblSupplier.Text = "Supplier"
        '
        'txtBillingAddress
        '
        Me.txtBillingAddress.Location = New System.Drawing.Point(123, 364)
        Me.txtBillingAddress.Multiline = True
        Me.txtBillingAddress.Name = "txtBillingAddress"
        Me.txtBillingAddress.Size = New System.Drawing.Size(236, 71)
        Me.txtBillingAddress.TabIndex = 13
        '
        'txtBillingName
        '
        Me.txtBillingName.Location = New System.Drawing.Point(123, 212)
        Me.txtBillingName.Name = "txtBillingName"
        Me.txtBillingName.Size = New System.Drawing.Size(236, 20)
        Me.txtBillingName.TabIndex = 12
        '
        'txtSupplierAddress
        '
        Me.txtSupplierAddress.Location = New System.Drawing.Point(123, 262)
        Me.txtSupplierAddress.Multiline = True
        Me.txtSupplierAddress.Name = "txtSupplierAddress"
        Me.txtSupplierAddress.Size = New System.Drawing.Size(236, 71)
        Me.txtSupplierAddress.TabIndex = 11
        '
        'txtDateOrdered
        '
        Me.txtDateOrdered.Location = New System.Drawing.Point(123, 114)
        Me.txtDateOrdered.Name = "txtDateOrdered"
        Me.txtDateOrdered.Size = New System.Drawing.Size(236, 20)
        Me.txtDateOrdered.TabIndex = 8
        '
        'txtOrderId
        '
        Me.txtOrderId.Location = New System.Drawing.Point(123, 19)
        Me.txtOrderId.Name = "txtOrderId"
        Me.txtOrderId.Size = New System.Drawing.Size(236, 20)
        Me.txtOrderId.TabIndex = 7
        '
        'lblBillingAddress
        '
        Me.lblBillingAddress.AutoSize = True
        Me.lblBillingAddress.Location = New System.Drawing.Point(32, 367)
        Me.lblBillingAddress.Name = "lblBillingAddress"
        Me.lblBillingAddress.Size = New System.Drawing.Size(75, 13)
        Me.lblBillingAddress.TabIndex = 6
        Me.lblBillingAddress.Text = "Billing Address"
        '
        'lblBillingName
        '
        Me.lblBillingName.AutoSize = True
        Me.lblBillingName.Location = New System.Drawing.Point(42, 215)
        Me.lblBillingName.Name = "lblBillingName"
        Me.lblBillingName.Size = New System.Drawing.Size(65, 13)
        Me.lblBillingName.TabIndex = 5
        Me.lblBillingName.Text = "Billing Name"
        '
        'lblSupplierAddress
        '
        Me.lblSupplierAddress.AutoSize = True
        Me.lblSupplierAddress.Location = New System.Drawing.Point(14, 265)
        Me.lblSupplierAddress.Name = "lblSupplierAddress"
        Me.lblSupplierAddress.Size = New System.Drawing.Size(93, 13)
        Me.lblSupplierAddress.TabIndex = 4
        Me.lblSupplierAddress.Text = "Supplier's Address"
        '
        'lblDateOrdered
        '
        Me.lblDateOrdered.AutoSize = True
        Me.lblDateOrdered.Location = New System.Drawing.Point(36, 117)
        Me.lblDateOrdered.Name = "lblDateOrdered"
        Me.lblDateOrdered.Size = New System.Drawing.Size(71, 13)
        Me.lblDateOrdered.TabIndex = 1
        Me.lblDateOrdered.Text = "Date Ordered"
        '
        'lblOrderId
        '
        Me.lblOrderId.AutoSize = True
        Me.lblOrderId.Location = New System.Drawing.Point(60, 22)
        Me.lblOrderId.Name = "lblOrderId"
        Me.lblOrderId.Size = New System.Drawing.Size(47, 13)
        Me.lblOrderId.TabIndex = 0
        Me.lblOrderId.Text = "Order ID"
        '
        'bgWorker
        '
        Me.bgWorker.WorkerReportsProgress = True
        Me.bgWorker.WorkerSupportsCancellation = True
        '
        'PurchasesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1110, 641)
        Me.Controls.Add(Me.SplitContainer)
        Me.Name = "PurchasesForm"
        Me.Text = "PurchasesForm"
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        CType(Me.gridPurchaseDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOrderSummary.ResumeLayout(False)
        Me.grpOrderSummary.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer As SplitContainer
    Friend WithEvents grpOrderSummary As GroupBox
    Friend WithEvents txtItemsOrdered As TextBox
    Friend WithEvents lblItemsOrdered As Label
    Friend WithEvents txtSupplier As TextBox
    Friend WithEvents btnMoreDetails As Button
    Friend WithEvents lblSupplier As Label
    Friend WithEvents txtBillingAddress As TextBox
    Friend WithEvents txtBillingName As TextBox
    Friend WithEvents txtSupplierAddress As TextBox
    Friend WithEvents txtDateOrdered As TextBox
    Friend WithEvents txtOrderId As TextBox
    Friend WithEvents lblBillingAddress As Label
    Friend WithEvents lblBillingName As Label
    Friend WithEvents lblSupplierAddress As Label
    Friend WithEvents lblDateOrdered As Label
    Friend WithEvents lblOrderId As Label
    Friend WithEvents gridPurchaseDetails As DataGridView
    Friend WithEvents lblPosition As Label
    Friend WithEvents btnMoveNext As Button
    Friend WithEvents btnMoveLast As Button
    Friend WithEvents btnMovePrevious As Button
    Friend WithEvents btnMoveFirst As Button
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnNew As Button
End Class
