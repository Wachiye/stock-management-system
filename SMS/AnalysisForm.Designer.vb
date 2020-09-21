<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnalysisForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnalysisForm))
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PanelTopIncome = New System.Windows.Forms.Panel()
        Me.IncomePictureBox = New System.Windows.Forms.PictureBox()
        Me.lblTopIncome = New System.Windows.Forms.Label()
        Me.lblIncome = New System.Windows.Forms.Label()
        Me.PanelTopProducts = New System.Windows.Forms.Panel()
        Me.ProductsPictureBox = New System.Windows.Forms.PictureBox()
        Me.lblTopProducts = New System.Windows.Forms.Label()
        Me.lblProducts = New System.Windows.Forms.Label()
        Me.PanelTopCustomers = New System.Windows.Forms.Panel()
        Me.CustomersPictureBox = New System.Windows.Forms.PictureBox()
        Me.lblTopExpenditure = New System.Windows.Forms.Label()
        Me.lblExpenditure = New System.Windows.Forms.Label()
        Me.PanelTopUsers = New System.Windows.Forms.Panel()
        Me.UsersPictureBox = New System.Windows.Forms.PictureBox()
        Me.lblTopUsers = New System.Windows.Forms.Label()
        Me.lblUsers = New System.Windows.Forms.Label()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.grpYearlyProfits = New System.Windows.Forms.GroupBox()
        Me.ExpenditureChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PanelYearlyProfitsLosses = New System.Windows.Forms.Panel()
        Me.cboYearProfits = New System.Windows.Forms.ComboBox()
        Me.btnYearlyProfits = New System.Windows.Forms.Button()
        Me.gridYearlyExpenditure = New System.Windows.Forms.DataGridView()
        Me.month = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.expenditure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.income = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.profits = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.losses = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpProductsGraph = New System.Windows.Forms.GroupBox()
        Me.QuantityChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.PanelTop.SuspendLayout()
        Me.PanelTopIncome.SuspendLayout()
        CType(Me.IncomePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTopProducts.SuspendLayout()
        CType(Me.ProductsPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTopCustomers.SuspendLayout()
        CType(Me.CustomersPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTopUsers.SuspendLayout()
        CType(Me.UsersPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBottom.SuspendLayout()
        Me.grpYearlyProfits.SuspendLayout()
        CType(Me.ExpenditureChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelYearlyProfitsLosses.SuspendLayout()
        CType(Me.gridYearlyExpenditure, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProductsGraph.SuspendLayout()
        CType(Me.QuantityChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.SystemColors.Control
        Me.PanelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTop.Controls.Add(Me.lblTitle)
        Me.PanelTop.Controls.Add(Me.PanelTopIncome)
        Me.PanelTop.Controls.Add(Me.PanelTopProducts)
        Me.PanelTop.Controls.Add(Me.PanelTopCustomers)
        Me.PanelTop.Controls.Add(Me.PanelTopUsers)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1166, 118)
        Me.PanelTop.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(340, 4)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(3)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(3)
        Me.lblTitle.Size = New System.Drawing.Size(468, 33)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "STOCK MANAGEMENT SYSTEM: REPORTS"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelTopIncome
        '
        Me.PanelTopIncome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelTopIncome.AutoSize = True
        Me.PanelTopIncome.BackColor = System.Drawing.Color.White
        Me.PanelTopIncome.Controls.Add(Me.IncomePictureBox)
        Me.PanelTopIncome.Controls.Add(Me.lblTopIncome)
        Me.PanelTopIncome.Controls.Add(Me.lblIncome)
        Me.PanelTopIncome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelTopIncome.Location = New System.Drawing.Point(874, 43)
        Me.PanelTopIncome.Name = "PanelTopIncome"
        Me.PanelTopIncome.Size = New System.Drawing.Size(280, 70)
        Me.PanelTopIncome.TabIndex = 6
        '
        'IncomePictureBox
        '
        Me.IncomePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.IncomePictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.IncomePictureBox.Image = CType(resources.GetObject("IncomePictureBox.Image"), System.Drawing.Image)
        Me.IncomePictureBox.Location = New System.Drawing.Point(0, 0)
        Me.IncomePictureBox.Name = "IncomePictureBox"
        Me.IncomePictureBox.Size = New System.Drawing.Size(100, 70)
        Me.IncomePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.IncomePictureBox.TabIndex = 5
        Me.IncomePictureBox.TabStop = False
        '
        'lblTopIncome
        '
        Me.lblTopIncome.BackColor = System.Drawing.Color.Silver
        Me.lblTopIncome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTopIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopIncome.Location = New System.Drawing.Point(120, 34)
        Me.lblTopIncome.Name = "lblTopIncome"
        Me.lblTopIncome.Size = New System.Drawing.Size(151, 23)
        Me.lblTopIncome.TabIndex = 4
        Me.lblTopIncome.Text = "100, 365.00"
        Me.lblTopIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIncome
        '
        Me.lblIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncome.ForeColor = System.Drawing.Color.Orange
        Me.lblIncome.Location = New System.Drawing.Point(115, 9)
        Me.lblIncome.Name = "lblIncome"
        Me.lblIncome.Size = New System.Drawing.Size(130, 25)
        Me.lblIncome.TabIndex = 3
        Me.lblIncome.Text = "Income( Ksh)"
        Me.lblIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelTopProducts
        '
        Me.PanelTopProducts.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelTopProducts.AutoSize = True
        Me.PanelTopProducts.BackColor = System.Drawing.Color.White
        Me.PanelTopProducts.Controls.Add(Me.ProductsPictureBox)
        Me.PanelTopProducts.Controls.Add(Me.lblTopProducts)
        Me.PanelTopProducts.Controls.Add(Me.lblProducts)
        Me.PanelTopProducts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelTopProducts.Location = New System.Drawing.Point(298, 43)
        Me.PanelTopProducts.Name = "PanelTopProducts"
        Me.PanelTopProducts.Size = New System.Drawing.Size(280, 70)
        Me.PanelTopProducts.TabIndex = 5
        '
        'ProductsPictureBox
        '
        Me.ProductsPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ProductsPictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.ProductsPictureBox.Image = Global.SMS.My.Resources.Resources.database
        Me.ProductsPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.ProductsPictureBox.Name = "ProductsPictureBox"
        Me.ProductsPictureBox.Size = New System.Drawing.Size(100, 70)
        Me.ProductsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ProductsPictureBox.TabIndex = 8
        Me.ProductsPictureBox.TabStop = False
        '
        'lblTopProducts
        '
        Me.lblTopProducts.BackColor = System.Drawing.Color.Silver
        Me.lblTopProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTopProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopProducts.Location = New System.Drawing.Point(125, 37)
        Me.lblTopProducts.Name = "lblTopProducts"
        Me.lblTopProducts.Size = New System.Drawing.Size(131, 23)
        Me.lblTopProducts.TabIndex = 7
        Me.lblTopProducts.Text = "10,789"
        Me.lblTopProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProducts
        '
        Me.lblProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducts.ForeColor = System.Drawing.Color.Orange
        Me.lblProducts.Location = New System.Drawing.Point(120, 12)
        Me.lblProducts.Name = "lblProducts"
        Me.lblProducts.Size = New System.Drawing.Size(89, 25)
        Me.lblProducts.TabIndex = 3
        Me.lblProducts.Text = "Products"
        Me.lblProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelTopCustomers
        '
        Me.PanelTopCustomers.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelTopCustomers.AutoSize = True
        Me.PanelTopCustomers.BackColor = System.Drawing.Color.White
        Me.PanelTopCustomers.Controls.Add(Me.CustomersPictureBox)
        Me.PanelTopCustomers.Controls.Add(Me.lblTopExpenditure)
        Me.PanelTopCustomers.Controls.Add(Me.lblExpenditure)
        Me.PanelTopCustomers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelTopCustomers.Location = New System.Drawing.Point(586, 43)
        Me.PanelTopCustomers.Name = "PanelTopCustomers"
        Me.PanelTopCustomers.Size = New System.Drawing.Size(280, 70)
        Me.PanelTopCustomers.TabIndex = 4
        '
        'CustomersPictureBox
        '
        Me.CustomersPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CustomersPictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.CustomersPictureBox.Image = Global.SMS.My.Resources.Resources.euro
        Me.CustomersPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.CustomersPictureBox.Name = "CustomersPictureBox"
        Me.CustomersPictureBox.Size = New System.Drawing.Size(100, 70)
        Me.CustomersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.CustomersPictureBox.TabIndex = 5
        Me.CustomersPictureBox.TabStop = False
        '
        'lblTopExpenditure
        '
        Me.lblTopExpenditure.BackColor = System.Drawing.Color.Silver
        Me.lblTopExpenditure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTopExpenditure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopExpenditure.Location = New System.Drawing.Point(122, 37)
        Me.lblTopExpenditure.Name = "lblTopExpenditure"
        Me.lblTopExpenditure.Size = New System.Drawing.Size(113, 23)
        Me.lblTopExpenditure.TabIndex = 4
        Me.lblTopExpenditure.Text = "2,456"
        Me.lblTopExpenditure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExpenditure
        '
        Me.lblExpenditure.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpenditure.ForeColor = System.Drawing.Color.Orange
        Me.lblExpenditure.Location = New System.Drawing.Point(117, 9)
        Me.lblExpenditure.Name = "lblExpenditure"
        Me.lblExpenditure.Size = New System.Drawing.Size(118, 25)
        Me.lblExpenditure.TabIndex = 3
        Me.lblExpenditure.Text = "Expenditure"
        Me.lblExpenditure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelTopUsers
        '
        Me.PanelTopUsers.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelTopUsers.AutoSize = True
        Me.PanelTopUsers.BackColor = System.Drawing.Color.White
        Me.PanelTopUsers.Controls.Add(Me.UsersPictureBox)
        Me.PanelTopUsers.Controls.Add(Me.lblTopUsers)
        Me.PanelTopUsers.Controls.Add(Me.lblUsers)
        Me.PanelTopUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelTopUsers.Location = New System.Drawing.Point(10, 43)
        Me.PanelTopUsers.Name = "PanelTopUsers"
        Me.PanelTopUsers.Size = New System.Drawing.Size(280, 70)
        Me.PanelTopUsers.TabIndex = 1
        '
        'UsersPictureBox
        '
        Me.UsersPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.UsersPictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.UsersPictureBox.Image = Global.SMS.My.Resources.Resources.people
        Me.UsersPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.UsersPictureBox.Name = "UsersPictureBox"
        Me.UsersPictureBox.Size = New System.Drawing.Size(100, 70)
        Me.UsersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.UsersPictureBox.TabIndex = 5
        Me.UsersPictureBox.TabStop = False
        '
        'lblTopUsers
        '
        Me.lblTopUsers.BackColor = System.Drawing.Color.Silver
        Me.lblTopUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTopUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopUsers.Location = New System.Drawing.Point(108, 37)
        Me.lblTopUsers.Name = "lblTopUsers"
        Me.lblTopUsers.Size = New System.Drawing.Size(140, 23)
        Me.lblTopUsers.TabIndex = 4
        Me.lblTopUsers.Text = "25"
        Me.lblTopUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsers
        '
        Me.lblUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsers.ForeColor = System.Drawing.Color.Orange
        Me.lblUsers.Location = New System.Drawing.Point(103, 9)
        Me.lblUsers.Name = "lblUsers"
        Me.lblUsers.Size = New System.Drawing.Size(63, 25)
        Me.lblUsers.TabIndex = 3
        Me.lblUsers.Text = "Users"
        Me.lblUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelBottom
        '
        Me.PanelBottom.Controls.Add(Me.grpYearlyProfits)
        Me.PanelBottom.Controls.Add(Me.grpProductsGraph)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBottom.Location = New System.Drawing.Point(0, 118)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(1166, 597)
        Me.PanelBottom.TabIndex = 1
        '
        'grpYearlyProfits
        '
        Me.grpYearlyProfits.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpYearlyProfits.AutoSize = True
        Me.grpYearlyProfits.Controls.Add(Me.ExpenditureChart)
        Me.grpYearlyProfits.Controls.Add(Me.PanelYearlyProfitsLosses)
        Me.grpYearlyProfits.Controls.Add(Me.gridYearlyExpenditure)
        Me.grpYearlyProfits.Enabled = False
        Me.grpYearlyProfits.Location = New System.Drawing.Point(592, 40)
        Me.grpYearlyProfits.Name = "grpYearlyProfits"
        Me.grpYearlyProfits.Size = New System.Drawing.Size(563, 545)
        Me.grpYearlyProfits.TabIndex = 1
        Me.grpYearlyProfits.TabStop = False
        Me.grpYearlyProfits.Text = "Yearly Profits and Losses"
        '
        'ExpenditureChart
        '
        ChartArea3.Name = "ExpenditureIncomeChartArea"
        Me.ExpenditureChart.ChartAreas.Add(ChartArea3)
        Me.ExpenditureChart.Dock = System.Windows.Forms.DockStyle.Top
        Legend3.Name = "Legend1"
        Me.ExpenditureChart.Legends.Add(Legend3)
        Me.ExpenditureChart.Location = New System.Drawing.Point(3, 47)
        Me.ExpenditureChart.Name = "ExpenditureChart"
        Series5.ChartArea = "ExpenditureIncomeChartArea"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series5.IsValueShownAsLabel = True
        Series5.Legend = "Legend1"
        Series5.Name = "Expenditure"
        Series6.ChartArea = "ExpenditureIncomeChartArea"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series6.Legend = "Legend1"
        Series6.Name = "Income"
        Me.ExpenditureChart.Series.Add(Series5)
        Me.ExpenditureChart.Series.Add(Series6)
        Me.ExpenditureChart.Size = New System.Drawing.Size(557, 291)
        Me.ExpenditureChart.TabIndex = 7
        Me.ExpenditureChart.Text = "Chart2"
        '
        'PanelYearlyProfitsLosses
        '
        Me.PanelYearlyProfitsLosses.Controls.Add(Me.cboYearProfits)
        Me.PanelYearlyProfitsLosses.Controls.Add(Me.btnYearlyProfits)
        Me.PanelYearlyProfitsLosses.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelYearlyProfitsLosses.Location = New System.Drawing.Point(3, 16)
        Me.PanelYearlyProfitsLosses.Name = "PanelYearlyProfitsLosses"
        Me.PanelYearlyProfitsLosses.Size = New System.Drawing.Size(557, 31)
        Me.PanelYearlyProfitsLosses.TabIndex = 6
        '
        'cboYearProfits
        '
        Me.cboYearProfits.FormattingEnabled = True
        Me.cboYearProfits.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025", "2026"})
        Me.cboYearProfits.Location = New System.Drawing.Point(185, 6)
        Me.cboYearProfits.Name = "cboYearProfits"
        Me.cboYearProfits.Size = New System.Drawing.Size(121, 21)
        Me.cboYearProfits.TabIndex = 3
        '
        'btnYearlyProfits
        '
        Me.btnYearlyProfits.Location = New System.Drawing.Point(321, 4)
        Me.btnYearlyProfits.Name = "btnYearlyProfits"
        Me.btnYearlyProfits.Size = New System.Drawing.Size(44, 23)
        Me.btnYearlyProfits.TabIndex = 4
        Me.btnYearlyProfits.Text = "Load"
        Me.btnYearlyProfits.UseVisualStyleBackColor = True
        '
        'gridYearlyExpenditure
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        Me.gridYearlyExpenditure.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.gridYearlyExpenditure.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridYearlyExpenditure.BackgroundColor = System.Drawing.Color.Silver
        Me.gridYearlyExpenditure.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridYearlyExpenditure.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.gridYearlyExpenditure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridYearlyExpenditure.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.month, Me.expenditure, Me.income, Me.profits, Me.losses})
        Me.gridYearlyExpenditure.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gridYearlyExpenditure.Location = New System.Drawing.Point(3, 338)
        Me.gridYearlyExpenditure.Name = "gridYearlyExpenditure"
        Me.gridYearlyExpenditure.Size = New System.Drawing.Size(557, 204)
        Me.gridYearlyExpenditure.StandardTab = True
        Me.gridYearlyExpenditure.TabIndex = 5
        '
        'month
        '
        Me.month.HeaderText = "Month"
        Me.month.Name = "month"
        '
        'expenditure
        '
        Me.expenditure.HeaderText = "Expenditure"
        Me.expenditure.Name = "expenditure"
        '
        'income
        '
        Me.income.HeaderText = "Income"
        Me.income.Name = "income"
        '
        'profits
        '
        Me.profits.HeaderText = "Profits"
        Me.profits.Name = "profits"
        '
        'losses
        '
        Me.losses.HeaderText = "Losses"
        Me.losses.Name = "losses"
        '
        'grpProductsGraph
        '
        Me.grpProductsGraph.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpProductsGraph.AutoSize = True
        Me.grpProductsGraph.Controls.Add(Me.QuantityChart)
        Me.grpProductsGraph.Location = New System.Drawing.Point(19, 35)
        Me.grpProductsGraph.Name = "grpProductsGraph"
        Me.grpProductsGraph.Size = New System.Drawing.Size(560, 440)
        Me.grpProductsGraph.TabIndex = 0
        Me.grpProductsGraph.TabStop = False
        Me.grpProductsGraph.Text = "Top 10 Most Purchased Products"
        '
        'QuantityChart
        '
        Me.QuantityChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center
        ChartArea4.AxisX.Interval = 1.0R
        ChartArea4.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        ChartArea4.AxisX.Title = "Product"
        ChartArea4.AxisY.Title = "Quantity/Frequency"
        ChartArea4.Name = "QuantityChartArea"
        Me.QuantityChart.ChartAreas.Add(ChartArea4)
        Me.QuantityChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend4.Name = "Legend1"
        Me.QuantityChart.Legends.Add(Legend4)
        Me.QuantityChart.Location = New System.Drawing.Point(3, 16)
        Me.QuantityChart.Name = "QuantityChart"
        Series7.ChartArea = "QuantityChartArea"
        Series7.IsValueShownAsLabel = True
        Series7.LabelAngle = -90
        Series7.Legend = "Legend1"
        Series7.Name = "Quantity"
        Series8.ChartArea = "QuantityChartArea"
        Series8.IsValueShownAsLabel = True
        Series8.Legend = "Legend1"
        Series8.Name = "Frequency"
        Me.QuantityChart.Series.Add(Series7)
        Me.QuantityChart.Series.Add(Series8)
        Me.QuantityChart.Size = New System.Drawing.Size(554, 421)
        Me.QuantityChart.TabIndex = 0
        Me.QuantityChart.Text = "Chart1"
        Title2.BackColor = System.Drawing.Color.Silver
        Title2.Name = "quantity_title"
        Title2.Text = "Chart Representing The Frequency of Purchasing Against The Quantity Purchased"
        Me.QuantityChart.Titles.Add(Title2)
        '
        'bgWorker
        '
        Me.bgWorker.WorkerReportsProgress = True
        Me.bgWorker.WorkerSupportsCancellation = True
        '
        'AnalysisForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1166, 715)
        Me.Controls.Add(Me.PanelBottom)
        Me.Controls.Add(Me.PanelTop)
        Me.Name = "AnalysisForm"
        Me.Text = "Stock Management System"
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.PanelTopIncome.ResumeLayout(False)
        CType(Me.IncomePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTopProducts.ResumeLayout(False)
        CType(Me.ProductsPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTopCustomers.ResumeLayout(False)
        CType(Me.CustomersPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTopUsers.ResumeLayout(False)
        CType(Me.UsersPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBottom.ResumeLayout(False)
        Me.PanelBottom.PerformLayout()
        Me.grpYearlyProfits.ResumeLayout(False)
        CType(Me.ExpenditureChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelYearlyProfitsLosses.ResumeLayout(False)
        CType(Me.gridYearlyExpenditure, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProductsGraph.ResumeLayout(False)
        CType(Me.QuantityChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents PanelTopIncome As Panel
    Friend WithEvents lblTopIncome As Label
    Friend WithEvents lblIncome As Label
    Friend WithEvents PanelTopProducts As Panel
    Friend WithEvents lblTopProducts As Label
    Friend WithEvents lblProducts As Label
    Friend WithEvents PanelTopCustomers As Panel
    Friend WithEvents lblTopExpenditure As Label
    Friend WithEvents lblExpenditure As Label
    Friend WithEvents PanelTopUsers As Panel
    Friend WithEvents lblTopUsers As Label
    Friend WithEvents lblUsers As Label
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents grpYearlyProfits As GroupBox
    Friend WithEvents grpProductsGraph As GroupBox
    Friend WithEvents IncomePictureBox As PictureBox
    Friend WithEvents ProductsPictureBox As PictureBox
    Friend WithEvents CustomersPictureBox As PictureBox
    Friend WithEvents UsersPictureBox As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents PanelYearlyProfitsLosses As Panel
    Friend WithEvents cboYearProfits As ComboBox
    Friend WithEvents btnYearlyProfits As Button
    Friend WithEvents gridYearlyExpenditure As DataGridView
    Friend WithEvents month As DataGridViewTextBoxColumn
    Friend WithEvents expenditure As DataGridViewTextBoxColumn
    Friend WithEvents income As DataGridViewTextBoxColumn
    Friend WithEvents profits As DataGridViewTextBoxColumn
    Friend WithEvents losses As DataGridViewTextBoxColumn
    Friend WithEvents QuantityChart As DataVisualization.Charting.Chart
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ExpenditureChart As DataVisualization.Charting.Chart
End Class
