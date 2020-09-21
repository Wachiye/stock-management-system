<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesForm))
        Me.Splitter = New System.Windows.Forms.SplitContainer()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.gridProducts = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.txtQuantity = New System.Windows.Forms.NumericUpDown()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblSellProduct = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.bgWorkerSave = New System.ComponentModel.BackgroundWorker()
        CType(Me.Splitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Splitter.Panel1.SuspendLayout()
        Me.Splitter.Panel2.SuspendLayout()
        Me.Splitter.SuspendLayout()
        CType(Me.gridProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Splitter
        '
        Me.Splitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Splitter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Splitter.IsSplitterFixed = True
        Me.Splitter.Location = New System.Drawing.Point(0, 0)
        Me.Splitter.Name = "Splitter"
        '
        'Splitter.Panel1
        '
        Me.Splitter.Panel1.Controls.Add(Me.lblDescription)
        Me.Splitter.Panel1.Controls.Add(Me.txtDescription)
        Me.Splitter.Panel1.Controls.Add(Me.gridProducts)
        Me.Splitter.Panel1.Controls.Add(Me.txtSearch)
        Me.Splitter.Panel1.Controls.Add(Me.btnSearch)
        Me.Splitter.Panel1.Controls.Add(Me.lblSearch)
        '
        'Splitter.Panel2
        '
        Me.Splitter.Panel2.Controls.Add(Me.PictureBox)
        Me.Splitter.Panel2.Controls.Add(Me.txtQuantity)
        Me.Splitter.Panel2.Controls.Add(Me.txtTotal)
        Me.Splitter.Panel2.Controls.Add(Me.lblTotal)
        Me.Splitter.Panel2.Controls.Add(Me.lblSellProduct)
        Me.Splitter.Panel2.Controls.Add(Me.btnSubmit)
        Me.Splitter.Panel2.Controls.Add(Me.txtChange)
        Me.Splitter.Panel2.Controls.Add(Me.txtAmount)
        Me.Splitter.Panel2.Controls.Add(Me.txtPrice)
        Me.Splitter.Panel2.Controls.Add(Me.txtProductID)
        Me.Splitter.Panel2.Controls.Add(Me.lblChange)
        Me.Splitter.Panel2.Controls.Add(Me.lblAmount)
        Me.Splitter.Panel2.Controls.Add(Me.lblQuantity)
        Me.Splitter.Panel2.Controls.Add(Me.lblPrice)
        Me.Splitter.Panel2.Controls.Add(Me.lblProductID)
        Me.Splitter.Size = New System.Drawing.Size(835, 537)
        Me.Splitter.SplitterDistance = 605
        Me.Splitter.TabIndex = 0
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(33, 330)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 17
        Me.lblDescription.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(33, 352)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(538, 172)
        Me.txtDescription.TabIndex = 16
        '
        'gridProducts
        '
        Me.gridProducts.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.gridProducts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridProducts.BackgroundColor = System.Drawing.Color.White
        Me.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridProducts.Location = New System.Drawing.Point(33, 46)
        Me.gridProducts.Name = "gridProducts"
        Me.gridProducts.Size = New System.Drawing.Size(538, 275)
        Me.gridProducts.TabIndex = 14
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(134, 16)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(298, 20)
        Me.txtSearch.TabIndex = 13
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(438, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(67, 30)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(76, 19)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(41, 13)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Search"
        '
        'PictureBox
        '
        Me.PictureBox.Location = New System.Drawing.Point(160, 19)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(53, 50)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox.TabIndex = 15
        Me.PictureBox.TabStop = False
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(17, 206)
        Me.txtQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(170, 20)
        Me.txtQuantity.TabIndex = 14
        Me.txtQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(17, 265)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(170, 20)
        Me.txtTotal.TabIndex = 13
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(14, 249)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.Text = "Total"
        '
        'lblSellProduct
        '
        Me.lblSellProduct.AutoSize = True
        Me.lblSellProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSellProduct.Location = New System.Drawing.Point(12, 30)
        Me.lblSellProduct.Name = "lblSellProduct"
        Me.lblSellProduct.Size = New System.Drawing.Size(136, 25)
        Me.lblSellProduct.TabIndex = 11
        Me.lblSellProduct.Text = "Sell A Product"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(17, 468)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(170, 30)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtChange
        '
        Me.txtChange.Location = New System.Drawing.Point(20, 375)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(170, 20)
        Me.txtChange.TabIndex = 9
        Me.txtChange.Text = "0"
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(20, 324)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(170, 20)
        Me.txtAmount.TabIndex = 8
        Me.txtAmount.Text = "0"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrice
        '
        Me.txtPrice.Enabled = False
        Me.txtPrice.Location = New System.Drawing.Point(17, 155)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(170, 20)
        Me.txtPrice.TabIndex = 6
        Me.txtPrice.Text = "0"
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtProductID
        '
        Me.txtProductID.Enabled = False
        Me.txtProductID.Location = New System.Drawing.Point(17, 104)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(170, 20)
        Me.txtProductID.TabIndex = 5
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Location = New System.Drawing.Point(17, 359)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(44, 13)
        Me.lblChange.TabIndex = 4
        Me.lblChange.Text = "Change"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(17, 308)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(43, 13)
        Me.lblAmount.TabIndex = 3
        Me.lblAmount.Text = "Amount"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(14, 190)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.TabIndex = 2
        Me.lblQuantity.Text = "Quantity"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(14, 139)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 1
        Me.lblPrice.Text = "Price"
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Location = New System.Drawing.Point(14, 88)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(58, 13)
        Me.lblProductID.TabIndex = 0
        Me.lblProductID.Text = "Product ID"
        '
        'bgWorker
        '
        Me.bgWorker.WorkerReportsProgress = True
        Me.bgWorker.WorkerSupportsCancellation = True
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "Bad mark.gif")
        Me.ImageList.Images.SetKeyName(1, "Good-mark.gif")
        Me.ImageList.Images.SetKeyName(2, "working.gif")
        '
        'bgWorkerSave
        '
        Me.bgWorkerSave.WorkerReportsProgress = True
        Me.bgWorkerSave.WorkerSupportsCancellation = True
        '
        'SalesForm
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 537)
        Me.Controls.Add(Me.Splitter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SalesForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Sell Product"
        Me.Splitter.Panel1.ResumeLayout(False)
        Me.Splitter.Panel1.PerformLayout()
        Me.Splitter.Panel2.ResumeLayout(False)
        Me.Splitter.Panel2.PerformLayout()
        CType(Me.Splitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Splitter.ResumeLayout(False)
        CType(Me.gridProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Splitter As SplitContainer
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents gridProducts As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblSearch As Label
    Friend WithEvents lblSellProduct As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtChange As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents lblChange As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblProductID As Label
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtQuantity As NumericUpDown
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents ImageList As ImageList
    Friend WithEvents bgWorkerSave As System.ComponentModel.BackgroundWorker
End Class
