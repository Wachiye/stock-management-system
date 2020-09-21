<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewPuchaseForm
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
        Me.gridItems = New System.Windows.Forms.DataGridView()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtPriceForAll = New System.Windows.Forms.TextBox()
        Me.lblPriceForAll = New System.Windows.Forms.Label()
        Me.grpFixedPriced = New System.Windows.Forms.GroupBox()
        Me.btnFixedPrice = New System.Windows.Forms.Button()
        Me.grpCostPerItem = New System.Windows.Forms.GroupBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnCostPerItem = New System.Windows.Forms.Button()
        Me.cboPricingOption = New System.Windows.Forms.ComboBox()
        Me.lblSelectOption = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.grpPurchaseEntry = New System.Windows.Forms.GroupBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.cboOrderId = New System.Windows.Forms.ComboBox()
        Me.lblSelectOrderId = New System.Windows.Forms.Label()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFixedPriced.SuspendLayout()
        Me.grpCostPerItem.SuspendLayout()
        Me.grpPurchaseEntry.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridItems
        '
        Me.gridItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridItems.Location = New System.Drawing.Point(12, 330)
        Me.gridItems.Name = "gridItems"
        Me.gridItems.Size = New System.Drawing.Size(896, 210)
        Me.gridItems.TabIndex = 9
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(14, 19)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(27, 13)
        Me.lblItem.TabIndex = 10
        Me.lblItem.Text = "Item"
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(17, 45)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(151, 20)
        Me.txtItem.TabIndex = 11
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(198, 45)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(151, 20)
        Me.txtQuantity.TabIndex = 13
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(195, 19)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.TabIndex = 12
        Me.lblQuantity.Text = "Quantity"
        '
        'txtPriceForAll
        '
        Me.txtPriceForAll.Location = New System.Drawing.Point(17, 51)
        Me.txtPriceForAll.Name = "txtPriceForAll"
        Me.txtPriceForAll.Size = New System.Drawing.Size(151, 20)
        Me.txtPriceForAll.TabIndex = 15
        '
        'lblPriceForAll
        '
        Me.lblPriceForAll.AutoSize = True
        Me.lblPriceForAll.Location = New System.Drawing.Point(14, 25)
        Me.lblPriceForAll.Name = "lblPriceForAll"
        Me.lblPriceForAll.Size = New System.Drawing.Size(91, 13)
        Me.lblPriceForAll.TabIndex = 14
        Me.lblPriceForAll.Text = "Price For All Items"
        '
        'grpFixedPriced
        '
        Me.grpFixedPriced.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpFixedPriced.Controls.Add(Me.btnFixedPrice)
        Me.grpFixedPriced.Controls.Add(Me.txtPriceForAll)
        Me.grpFixedPriced.Controls.Add(Me.lblPriceForAll)
        Me.grpFixedPriced.Enabled = False
        Me.grpFixedPriced.Location = New System.Drawing.Point(310, 133)
        Me.grpFixedPriced.Name = "grpFixedPriced"
        Me.grpFixedPriced.Size = New System.Drawing.Size(301, 82)
        Me.grpFixedPriced.TabIndex = 16
        Me.grpFixedPriced.TabStop = False
        Me.grpFixedPriced.Text = "Fixed Price"
        '
        'btnFixedPrice
        '
        Me.btnFixedPrice.Location = New System.Drawing.Point(198, 43)
        Me.btnFixedPrice.Name = "btnFixedPrice"
        Me.btnFixedPrice.Size = New System.Drawing.Size(34, 31)
        Me.btnFixedPrice.TabIndex = 16
        Me.btnFixedPrice.Text = "Ok"
        Me.btnFixedPrice.UseVisualStyleBackColor = True
        '
        'grpCostPerItem
        '
        Me.grpCostPerItem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpCostPerItem.Controls.Add(Me.txtPrice)
        Me.grpCostPerItem.Controls.Add(Me.lblPrice)
        Me.grpCostPerItem.Controls.Add(Me.btnCostPerItem)
        Me.grpCostPerItem.Controls.Add(Me.txtQuantity)
        Me.grpCostPerItem.Controls.Add(Me.lblItem)
        Me.grpCostPerItem.Controls.Add(Me.txtItem)
        Me.grpCostPerItem.Controls.Add(Me.lblQuantity)
        Me.grpCostPerItem.Enabled = False
        Me.grpCostPerItem.Location = New System.Drawing.Point(137, 228)
        Me.grpCostPerItem.Name = "grpCostPerItem"
        Me.grpCostPerItem.Size = New System.Drawing.Size(647, 89)
        Me.grpCostPerItem.TabIndex = 17
        Me.grpCostPerItem.TabStop = False
        Me.grpCostPerItem.Text = "Cost Per Item"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(379, 45)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(151, 20)
        Me.txtPrice.TabIndex = 21
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(376, 19)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 20
        Me.lblPrice.Text = "Price"
        '
        'btnCostPerItem
        '
        Me.btnCostPerItem.Location = New System.Drawing.Point(577, 39)
        Me.btnCostPerItem.Name = "btnCostPerItem"
        Me.btnCostPerItem.Size = New System.Drawing.Size(34, 31)
        Me.btnCostPerItem.TabIndex = 17
        Me.btnCostPerItem.Text = "Ok"
        Me.btnCostPerItem.UseVisualStyleBackColor = True
        '
        'cboPricingOption
        '
        Me.cboPricingOption.FormattingEnabled = True
        Me.cboPricingOption.Items.AddRange(New Object() {"Fixed price for all items in the order", "Each item has a unique price"})
        Me.cboPricingOption.Location = New System.Drawing.Point(175, 53)
        Me.cboPricingOption.Name = "cboPricingOption"
        Me.cboPricingOption.Size = New System.Drawing.Size(254, 21)
        Me.cboPricingOption.TabIndex = 18
        '
        'lblSelectOption
        '
        Me.lblSelectOption.AutoSize = True
        Me.lblSelectOption.Location = New System.Drawing.Point(4, 56)
        Me.lblSelectOption.Name = "lblSelectOption"
        Me.lblSelectOption.Size = New System.Drawing.Size(121, 13)
        Me.lblSelectOption.TabIndex = 19
        Me.lblSelectOption.Text = "Select Option for Pricing"
        '
        'btnContinue
        '
        Me.btnContinue.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnContinue.Location = New System.Drawing.Point(796, 546)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(112, 31)
        Me.btnContinue.TabIndex = 20
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTotalAmount.Location = New System.Drawing.Point(548, 552)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(151, 20)
        Me.txtTotalAmount.TabIndex = 21
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Location = New System.Drawing.Point(460, 555)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(70, 13)
        Me.lblTotalAmount.TabIndex = 20
        Me.lblTotalAmount.Text = "Total Amount"
        '
        'grpPurchaseEntry
        '
        Me.grpPurchaseEntry.Controls.Add(Me.btnView)
        Me.grpPurchaseEntry.Controls.Add(Me.cboOrderId)
        Me.grpPurchaseEntry.Controls.Add(Me.lblSelectOrderId)
        Me.grpPurchaseEntry.Controls.Add(Me.cboPricingOption)
        Me.grpPurchaseEntry.Controls.Add(Me.lblSelectOption)
        Me.grpPurchaseEntry.Location = New System.Drawing.Point(223, 12)
        Me.grpPurchaseEntry.Name = "grpPurchaseEntry"
        Me.grpPurchaseEntry.Padding = New System.Windows.Forms.Padding(1)
        Me.grpPurchaseEntry.Size = New System.Drawing.Size(474, 108)
        Me.grpPurchaseEntry.TabIndex = 22
        Me.grpPurchaseEntry.TabStop = False
        Me.grpPurchaseEntry.Text = "Purchase Entry"
        '
        'btnView
        '
        Me.btnView.FlatAppearance.BorderSize = 0
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnView.Image = Global.SMS.My.Resources.Resources.info
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.Location = New System.Drawing.Point(335, 14)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(94, 33)
        Me.btnView.TabIndex = 19
        Me.btnView.Text = "View Items"
        Me.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnView.UseVisualStyleBackColor = True
        '
        'cboOrderId
        '
        Me.cboOrderId.FormattingEnabled = True
        Me.cboOrderId.Location = New System.Drawing.Point(175, 21)
        Me.cboOrderId.Name = "cboOrderId"
        Me.cboOrderId.Size = New System.Drawing.Size(154, 21)
        Me.cboOrderId.TabIndex = 1
        '
        'lblSelectOrderId
        '
        Me.lblSelectOrderId.AutoSize = True
        Me.lblSelectOrderId.Location = New System.Drawing.Point(41, 24)
        Me.lblSelectOrderId.Name = "lblSelectOrderId"
        Me.lblSelectOrderId.Size = New System.Drawing.Size(80, 13)
        Me.lblSelectOrderId.TabIndex = 0
        Me.lblSelectOrderId.Text = "Select Order ID"
        '
        'NewPuchaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 589)
        Me.Controls.Add(Me.grpPurchaseEntry)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.grpCostPerItem)
        Me.Controls.Add(Me.grpFixedPriced)
        Me.Controls.Add(Me.gridItems)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "NewPuchaseForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order : FVD456D"
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFixedPriced.ResumeLayout(False)
        Me.grpFixedPriced.PerformLayout()
        Me.grpCostPerItem.ResumeLayout(False)
        Me.grpCostPerItem.PerformLayout()
        Me.grpPurchaseEntry.ResumeLayout(False)
        Me.grpPurchaseEntry.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridItems As DataGridView
    Friend WithEvents lblItem As Label
    Friend WithEvents txtItem As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtPriceForAll As TextBox
    Friend WithEvents lblPriceForAll As Label
    Friend WithEvents grpFixedPriced As GroupBox
    Friend WithEvents btnFixedPrice As Button
    Friend WithEvents grpCostPerItem As GroupBox
    Friend WithEvents btnCostPerItem As Button
    Friend WithEvents cboPricingOption As ComboBox
    Friend WithEvents lblSelectOption As Label
    Friend WithEvents btnContinue As Button
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents grpPurchaseEntry As GroupBox
    Friend WithEvents btnView As Button
    Friend WithEvents cboOrderId As ComboBox
    Friend WithEvents lblSelectOrderId As Label
End Class
