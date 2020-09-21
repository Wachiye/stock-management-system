<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductsForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Splitter = New System.Windows.Forms.SplitContainer()
        Me.grpProductDetails = New System.Windows.Forms.GroupBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnMoveNext = New System.Windows.Forms.Button()
        Me.btnMoveLast = New System.Windows.Forms.Button()
        Me.btnMovePrevious = New System.Windows.Forms.Button()
        Me.btnMoveFirst = New System.Windows.Forms.Button()
        Me.dtpDatePurchased = New System.Windows.Forms.DateTimePicker()
        Me.lblDatePurchased = New System.Windows.Forms.Label()
        Me.txtSellingPrice = New System.Windows.Forms.TextBox()
        Me.lblSellingPrice = New System.Windows.Forms.Label()
        Me.txtPurchasePrice = New System.Windows.Forms.TextBox()
        Me.lblPurchasePrice = New System.Windows.Forms.Label()
        Me.txtStockAvailable = New System.Windows.Forms.TextBox()
        Me.lblStockAvailable = New System.Windows.Forms.Label()
        Me.txtStockPurchased = New System.Windows.Forms.TextBox()
        Me.lblStockPurchased = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.txtProductId = New System.Windows.Forms.TextBox()
        Me.lblProductId = New System.Windows.Forms.Label()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.gridProducts = New System.Windows.Forms.DataGridView()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        CType(Me.Splitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Splitter.Panel1.SuspendLayout()
        Me.Splitter.Panel2.SuspendLayout()
        Me.Splitter.SuspendLayout()
        Me.grpProductDetails.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        CType(Me.gridProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Splitter
        '
        Me.Splitter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Splitter.Location = New System.Drawing.Point(0, 0)
        Me.Splitter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Splitter.Name = "Splitter"
        Me.Splitter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Splitter.Panel1
        '
        Me.Splitter.Panel1.Controls.Add(Me.grpProductDetails)
        Me.Splitter.Panel1.Controls.Add(Me.grpSearch)
        '
        'Splitter.Panel2
        '
        Me.Splitter.Panel2.Controls.Add(Me.gridProducts)
        Me.Splitter.Size = New System.Drawing.Size(1219, 712)
        Me.Splitter.SplitterDistance = 451
        Me.Splitter.SplitterWidth = 5
        Me.Splitter.TabIndex = 0
        '
        'grpProductDetails
        '
        Me.grpProductDetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpProductDetails.Controls.Add(Me.lblPosition)
        Me.grpProductDetails.Controls.Add(Me.btnUpdate)
        Me.grpProductDetails.Controls.Add(Me.btnDelete)
        Me.grpProductDetails.Controls.Add(Me.btnNew)
        Me.grpProductDetails.Controls.Add(Me.btnSave)
        Me.grpProductDetails.Controls.Add(Me.btnMoveNext)
        Me.grpProductDetails.Controls.Add(Me.btnMoveLast)
        Me.grpProductDetails.Controls.Add(Me.btnMovePrevious)
        Me.grpProductDetails.Controls.Add(Me.btnMoveFirst)
        Me.grpProductDetails.Controls.Add(Me.dtpDatePurchased)
        Me.grpProductDetails.Controls.Add(Me.lblDatePurchased)
        Me.grpProductDetails.Controls.Add(Me.txtSellingPrice)
        Me.grpProductDetails.Controls.Add(Me.lblSellingPrice)
        Me.grpProductDetails.Controls.Add(Me.txtPurchasePrice)
        Me.grpProductDetails.Controls.Add(Me.lblPurchasePrice)
        Me.grpProductDetails.Controls.Add(Me.txtStockAvailable)
        Me.grpProductDetails.Controls.Add(Me.lblStockAvailable)
        Me.grpProductDetails.Controls.Add(Me.txtStockPurchased)
        Me.grpProductDetails.Controls.Add(Me.lblStockPurchased)
        Me.grpProductDetails.Controls.Add(Me.txtDescription)
        Me.grpProductDetails.Controls.Add(Me.lblDescription)
        Me.grpProductDetails.Controls.Add(Me.txtProductName)
        Me.grpProductDetails.Controls.Add(Me.lblProductName)
        Me.grpProductDetails.Controls.Add(Me.txtProductId)
        Me.grpProductDetails.Controls.Add(Me.lblProductId)
        Me.grpProductDetails.Location = New System.Drawing.Point(41, 111)
        Me.grpProductDetails.Name = "grpProductDetails"
        Me.grpProductDetails.Size = New System.Drawing.Size(1137, 311)
        Me.grpProductDetails.TabIndex = 1
        Me.grpProductDetails.TabStop = False
        Me.grpProductDetails.Text = "Product Details"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(655, 282)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(67, 19)
        Me.lblPosition.TabIndex = 26
        Me.lblPosition.Text = "0 Of { 0 }"
        '
        'btnUpdate
        '
        Me.btnUpdate.AutoSize = True
        Me.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Image = Global.SMS.My.Resources.Resources.update
        Me.btnUpdate.Location = New System.Drawing.Point(915, 276)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(30, 30)
        Me.btnUpdate.TabIndex = 25
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.AutoSize = True
        Me.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Image = Global.SMS.My.Resources.Resources.close
        Me.btnDelete.Location = New System.Drawing.Point(961, 276)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(30, 30)
        Me.btnDelete.TabIndex = 24
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.AutoSize = True
        Me.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Image = Global.SMS.My.Resources.Resources._new
        Me.btnNew.Location = New System.Drawing.Point(823, 276)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(30, 30)
        Me.btnNew.TabIndex = 23
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Image = Global.SMS.My.Resources.Resources.save
        Me.btnSave.Location = New System.Drawing.Point(869, 276)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(30, 30)
        Me.btnSave.TabIndex = 22
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnMoveNext
        '
        Me.btnMoveNext.AutoSize = True
        Me.btnMoveNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMoveNext.FlatAppearance.BorderSize = 0
        Me.btnMoveNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoveNext.Image = Global.SMS.My.Resources.Resources.go_forward
        Me.btnMoveNext.Location = New System.Drawing.Point(739, 276)
        Me.btnMoveNext.Name = "btnMoveNext"
        Me.btnMoveNext.Size = New System.Drawing.Size(30, 30)
        Me.btnMoveNext.TabIndex = 21
        Me.btnMoveNext.UseVisualStyleBackColor = True
        '
        'btnMoveLast
        '
        Me.btnMoveLast.AutoSize = True
        Me.btnMoveLast.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMoveLast.FlatAppearance.BorderSize = 0
        Me.btnMoveLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoveLast.Image = Global.SMS.My.Resources.Resources.last_recor
        Me.btnMoveLast.Location = New System.Drawing.Point(777, 276)
        Me.btnMoveLast.Name = "btnMoveLast"
        Me.btnMoveLast.Size = New System.Drawing.Size(30, 30)
        Me.btnMoveLast.TabIndex = 20
        Me.btnMoveLast.UseVisualStyleBackColor = True
        '
        'btnMovePrevious
        '
        Me.btnMovePrevious.AutoSize = True
        Me.btnMovePrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMovePrevious.FlatAppearance.BorderSize = 0
        Me.btnMovePrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMovePrevious.Image = Global.SMS.My.Resources.Resources.go_back
        Me.btnMovePrevious.Location = New System.Drawing.Point(601, 276)
        Me.btnMovePrevious.Name = "btnMovePrevious"
        Me.btnMovePrevious.Size = New System.Drawing.Size(30, 30)
        Me.btnMovePrevious.TabIndex = 19
        Me.btnMovePrevious.UseVisualStyleBackColor = True
        '
        'btnMoveFirst
        '
        Me.btnMoveFirst.AutoSize = True
        Me.btnMoveFirst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMoveFirst.FlatAppearance.BorderSize = 0
        Me.btnMoveFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoveFirst.Image = Global.SMS.My.Resources.Resources.first_record
        Me.btnMoveFirst.Location = New System.Drawing.Point(563, 276)
        Me.btnMoveFirst.Name = "btnMoveFirst"
        Me.btnMoveFirst.Size = New System.Drawing.Size(30, 30)
        Me.btnMoveFirst.TabIndex = 2
        Me.btnMoveFirst.UseVisualStyleBackColor = True
        '
        'dtpDatePurchased
        '
        Me.dtpDatePurchased.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatePurchased.Location = New System.Drawing.Point(497, 53)
        Me.dtpDatePurchased.Name = "dtpDatePurchased"
        Me.dtpDatePurchased.Size = New System.Drawing.Size(196, 27)
        Me.dtpDatePurchased.TabIndex = 18
        Me.dtpDatePurchased.Value = New Date(2020, 1, 8, 0, 0, 0, 0)
        '
        'lblDatePurchased
        '
        Me.lblDatePurchased.AutoSize = True
        Me.lblDatePurchased.Location = New System.Drawing.Point(493, 32)
        Me.lblDatePurchased.Name = "lblDatePurchased"
        Me.lblDatePurchased.Size = New System.Drawing.Size(111, 19)
        Me.lblDatePurchased.TabIndex = 17
        Me.lblDatePurchased.Text = "Date Purchased"
        '
        'txtSellingPrice
        '
        Me.txtSellingPrice.Location = New System.Drawing.Point(498, 227)
        Me.txtSellingPrice.Name = "txtSellingPrice"
        Me.txtSellingPrice.Size = New System.Drawing.Size(196, 27)
        Me.txtSellingPrice.TabIndex = 16
        '
        'lblSellingPrice
        '
        Me.lblSellingPrice.AutoSize = True
        Me.lblSellingPrice.Location = New System.Drawing.Point(494, 203)
        Me.lblSellingPrice.Name = "lblSellingPrice"
        Me.lblSellingPrice.Size = New System.Drawing.Size(88, 19)
        Me.lblSellingPrice.TabIndex = 15
        Me.lblSellingPrice.Text = "Selling Price"
        '
        'txtPurchasePrice
        '
        Me.txtPurchasePrice.Location = New System.Drawing.Point(498, 168)
        Me.txtPurchasePrice.Name = "txtPurchasePrice"
        Me.txtPurchasePrice.Size = New System.Drawing.Size(196, 27)
        Me.txtPurchasePrice.TabIndex = 14
        '
        'lblPurchasePrice
        '
        Me.lblPurchasePrice.AutoSize = True
        Me.lblPurchasePrice.Location = New System.Drawing.Point(494, 144)
        Me.lblPurchasePrice.Name = "lblPurchasePrice"
        Me.lblPurchasePrice.Size = New System.Drawing.Size(104, 19)
        Me.lblPurchasePrice.TabIndex = 13
        Me.lblPurchasePrice.Text = "Purchase Price"
        '
        'txtStockAvailable
        '
        Me.txtStockAvailable.Location = New System.Drawing.Point(795, 56)
        Me.txtStockAvailable.Name = "txtStockAvailable"
        Me.txtStockAvailable.Size = New System.Drawing.Size(196, 27)
        Me.txtStockAvailable.TabIndex = 12
        '
        'lblStockAvailable
        '
        Me.lblStockAvailable.AutoSize = True
        Me.lblStockAvailable.Location = New System.Drawing.Point(791, 32)
        Me.lblStockAvailable.Name = "lblStockAvailable"
        Me.lblStockAvailable.Size = New System.Drawing.Size(107, 19)
        Me.lblStockAvailable.TabIndex = 11
        Me.lblStockAvailable.Text = "Stock Available"
        '
        'txtStockPurchased
        '
        Me.txtStockPurchased.Location = New System.Drawing.Point(497, 112)
        Me.txtStockPurchased.Name = "txtStockPurchased"
        Me.txtStockPurchased.Size = New System.Drawing.Size(196, 27)
        Me.txtStockPurchased.TabIndex = 10
        '
        'lblStockPurchased
        '
        Me.lblStockPurchased.AutoSize = True
        Me.lblStockPurchased.Location = New System.Drawing.Point(493, 88)
        Me.lblStockPurchased.Name = "lblStockPurchased"
        Me.lblStockPurchased.Size = New System.Drawing.Size(114, 19)
        Me.lblStockPurchased.TabIndex = 9
        Me.lblStockPurchased.Text = "Stock Purchased"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(118, 168)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(322, 121)
        Me.txtDescription.TabIndex = 8
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(114, 144)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(83, 19)
        Me.lblDescription.TabIndex = 7
        Me.lblDescription.Text = "Description"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(118, 112)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(322, 27)
        Me.txtProductName.TabIndex = 6
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(114, 88)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(100, 19)
        Me.lblProductName.TabIndex = 5
        Me.lblProductName.Text = "Product Name"
        '
        'txtProductId
        '
        Me.txtProductId.Enabled = False
        Me.txtProductId.Location = New System.Drawing.Point(118, 56)
        Me.txtProductId.Name = "txtProductId"
        Me.txtProductId.Size = New System.Drawing.Size(196, 27)
        Me.txtProductId.TabIndex = 4
        '
        'lblProductId
        '
        Me.lblProductId.AutoSize = True
        Me.lblProductId.Location = New System.Drawing.Point(114, 32)
        Me.lblProductId.Name = "lblProductId"
        Me.lblProductId.Size = New System.Drawing.Size(76, 19)
        Me.lblProductId.TabIndex = 3
        Me.lblProductId.Text = "Product ID"
        '
        'grpSearch
        '
        Me.grpSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpSearch.Controls.Add(Me.btnSearch)
        Me.grpSearch.Controls.Add(Me.txtSearch)
        Me.grpSearch.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearch.Location = New System.Drawing.Point(450, 28)
        Me.grpSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpSearch.Size = New System.Drawing.Size(437, 75)
        Me.grpSearch.TabIndex = 0
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search"
        '
        'btnSearch
        '
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Image = Global.SMS.My.Resources.Resources.search
        Me.btnSearch.Location = New System.Drawing.Point(291, 17)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(57, 48)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(89, 29)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(188, 27)
        Me.txtSearch.TabIndex = 0
        '
        'gridProducts
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        Me.gridProducts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridProducts.Location = New System.Drawing.Point(0, 0)
        Me.gridProducts.Name = "gridProducts"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridProducts.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.gridProducts.Size = New System.Drawing.Size(1219, 256)
        Me.gridProducts.TabIndex = 0
        '
        'bgWorker
        '
        Me.bgWorker.WorkerReportsProgress = True
        Me.bgWorker.WorkerSupportsCancellation = True
        '
        'ProductsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 712)
        Me.Controls.Add(Me.Splitter)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ProductsForm"
        Me.Text = "ProductsForm"
        Me.Splitter.Panel1.ResumeLayout(False)
        Me.Splitter.Panel2.ResumeLayout(False)
        CType(Me.Splitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Splitter.ResumeLayout(False)
        Me.grpProductDetails.ResumeLayout(False)
        Me.grpProductDetails.PerformLayout()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        CType(Me.gridProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Splitter As SplitContainer
    Friend WithEvents grpProductDetails As GroupBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnMoveNext As Button
    Friend WithEvents btnMoveLast As Button
    Friend WithEvents btnMovePrevious As Button
    Friend WithEvents btnMoveFirst As Button
    Friend WithEvents dtpDatePurchased As DateTimePicker
    Friend WithEvents lblDatePurchased As Label
    Friend WithEvents txtSellingPrice As TextBox
    Friend WithEvents lblSellingPrice As Label
    Friend WithEvents txtPurchasePrice As TextBox
    Friend WithEvents lblPurchasePrice As Label
    Friend WithEvents txtStockAvailable As TextBox
    Friend WithEvents lblStockAvailable As Label
    Friend WithEvents txtStockPurchased As TextBox
    Friend WithEvents lblStockPurchased As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents lblProductName As Label
    Friend WithEvents txtProductId As TextBox
    Friend WithEvents lblProductId As Label
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblPosition As Label
    Friend WithEvents gridProducts As DataGridView
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
End Class
