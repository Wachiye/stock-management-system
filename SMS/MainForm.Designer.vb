<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Splitter = New System.Windows.Forms.SplitContainer()
        Me.btnNewOrder = New System.Windows.Forms.Button()
        Me.btnSellProduct = New System.Windows.Forms.Button()
        Me.btnSuppliers = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnAnalysis = New System.Windows.Forms.Button()
        Me.btnPurchases = New System.Windows.Forms.Button()
        Me.btnOrders = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.ContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReloadCurrentFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseOtherTabsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTabsExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SafeExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RestartApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        CType(Me.Splitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Splitter.Panel1.SuspendLayout()
        Me.Splitter.Panel2.SuspendLayout()
        Me.Splitter.SuspendLayout()
        Me.ContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.SystemColors.Window
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 545)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(845, 22)
        Me.StatusStrip.TabIndex = 11
        Me.StatusStrip.Text = "StatusStrip"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(39, 17)
        Me.lblStatus.Text = "Ready"
        '
        'Splitter
        '
        Me.Splitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Splitter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Splitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Splitter.IsSplitterFixed = True
        Me.Splitter.Location = New System.Drawing.Point(0, 0)
        Me.Splitter.Name = "Splitter"
        '
        'Splitter.Panel1
        '
        Me.Splitter.Panel1.Controls.Add(Me.btnNewOrder)
        Me.Splitter.Panel1.Controls.Add(Me.btnSellProduct)
        Me.Splitter.Panel1.Controls.Add(Me.btnSuppliers)
        Me.Splitter.Panel1.Controls.Add(Me.btnExit)
        Me.Splitter.Panel1.Controls.Add(Me.btnAbout)
        Me.Splitter.Panel1.Controls.Add(Me.btnHelp)
        Me.Splitter.Panel1.Controls.Add(Me.btnSettings)
        Me.Splitter.Panel1.Controls.Add(Me.btnUsers)
        Me.Splitter.Panel1.Controls.Add(Me.btnAnalysis)
        Me.Splitter.Panel1.Controls.Add(Me.btnPurchases)
        Me.Splitter.Panel1.Controls.Add(Me.btnOrders)
        Me.Splitter.Panel1.Controls.Add(Me.btnProducts)
        '
        'Splitter.Panel2
        '
        Me.Splitter.Panel2.Controls.Add(Me.TabControl)
        Me.Splitter.Size = New System.Drawing.Size(845, 545)
        Me.Splitter.SplitterDistance = 206
        Me.Splitter.TabIndex = 12
        '
        'btnNewOrder
        '
        Me.btnNewOrder.AutoSize = True
        Me.btnNewOrder.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewOrder.Image = CType(resources.GetObject("btnNewOrder.Image"), System.Drawing.Image)
        Me.btnNewOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewOrder.Location = New System.Drawing.Point(22, 106)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Padding = New System.Windows.Forms.Padding(3)
        Me.btnNewOrder.Size = New System.Drawing.Size(159, 38)
        Me.btnNewOrder.TabIndex = 21
        Me.btnNewOrder.Text = "Create New Order"
        Me.btnNewOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNewOrder.UseVisualStyleBackColor = True
        '
        'btnSellProduct
        '
        Me.btnSellProduct.AutoSize = True
        Me.btnSellProduct.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnSellProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSellProduct.Image = Global.SMS.My.Resources.Resources.euro
        Me.btnSellProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSellProduct.Location = New System.Drawing.Point(22, 148)
        Me.btnSellProduct.Name = "btnSellProduct"
        Me.btnSellProduct.Padding = New System.Windows.Forms.Padding(3)
        Me.btnSellProduct.Size = New System.Drawing.Size(159, 38)
        Me.btnSellProduct.TabIndex = 20
        Me.btnSellProduct.Text = "Sell Product"
        Me.btnSellProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSellProduct.UseVisualStyleBackColor = True
        '
        'btnSuppliers
        '
        Me.btnSuppliers.AutoSize = True
        Me.btnSuppliers.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuppliers.Image = CType(resources.GetObject("btnSuppliers.Image"), System.Drawing.Image)
        Me.btnSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSuppliers.Location = New System.Drawing.Point(22, 316)
        Me.btnSuppliers.Name = "btnSuppliers"
        Me.btnSuppliers.Padding = New System.Windows.Forms.Padding(3)
        Me.btnSuppliers.Size = New System.Drawing.Size(159, 38)
        Me.btnSuppliers.TabIndex = 19
        Me.btnSuppliers.Text = "Suppliers"
        Me.btnSuppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSuppliers.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(22, 484)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(3)
        Me.btnExit.Size = New System.Drawing.Size(159, 38)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.AutoSize = True
        Me.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Image = CType(resources.GetObject("btnAbout.Image"), System.Drawing.Image)
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.Location = New System.Drawing.Point(22, 442)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Padding = New System.Windows.Forms.Padding(3)
        Me.btnAbout.Size = New System.Drawing.Size(159, 38)
        Me.btnAbout.TabIndex = 17
        Me.btnAbout.Text = "About"
        Me.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.AutoSize = True
        Me.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
        Me.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHelp.Location = New System.Drawing.Point(22, 400)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Padding = New System.Windows.Forms.Padding(3)
        Me.btnHelp.Size = New System.Drawing.Size(159, 38)
        Me.btnHelp.TabIndex = 16
        Me.btnHelp.Text = "Help"
        Me.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.AutoSize = True
        Me.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(22, 358)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.btnSettings.Size = New System.Drawing.Size(159, 38)
        Me.btnSettings.TabIndex = 15
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.AutoSize = True
        Me.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.Image = CType(resources.GetObject("btnUsers.Image"), System.Drawing.Image)
        Me.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.Location = New System.Drawing.Point(22, 274)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Padding = New System.Windows.Forms.Padding(3)
        Me.btnUsers.Size = New System.Drawing.Size(159, 38)
        Me.btnUsers.TabIndex = 14
        Me.btnUsers.Text = "Users"
        Me.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'btnAnalysis
        '
        Me.btnAnalysis.AutoSize = True
        Me.btnAnalysis.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnalysis.Image = CType(resources.GetObject("btnAnalysis.Image"), System.Drawing.Image)
        Me.btnAnalysis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnalysis.Location = New System.Drawing.Point(22, 232)
        Me.btnAnalysis.Name = "btnAnalysis"
        Me.btnAnalysis.Padding = New System.Windows.Forms.Padding(3)
        Me.btnAnalysis.Size = New System.Drawing.Size(159, 38)
        Me.btnAnalysis.TabIndex = 13
        Me.btnAnalysis.Text = "Analysis"
        Me.btnAnalysis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAnalysis.UseVisualStyleBackColor = True
        '
        'btnPurchases
        '
        Me.btnPurchases.AutoSize = True
        Me.btnPurchases.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPurchases.Image = CType(resources.GetObject("btnPurchases.Image"), System.Drawing.Image)
        Me.btnPurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPurchases.Location = New System.Drawing.Point(22, 190)
        Me.btnPurchases.Name = "btnPurchases"
        Me.btnPurchases.Padding = New System.Windows.Forms.Padding(3)
        Me.btnPurchases.Size = New System.Drawing.Size(159, 38)
        Me.btnPurchases.TabIndex = 12
        Me.btnPurchases.Text = "Purchases"
        Me.btnPurchases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPurchases.UseVisualStyleBackColor = True
        '
        'btnOrders
        '
        Me.btnOrders.AutoSize = True
        Me.btnOrders.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrders.Image = CType(resources.GetObject("btnOrders.Image"), System.Drawing.Image)
        Me.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrders.Location = New System.Drawing.Point(22, 64)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Padding = New System.Windows.Forms.Padding(3)
        Me.btnOrders.Size = New System.Drawing.Size(159, 38)
        Me.btnOrders.TabIndex = 11
        Me.btnOrders.Text = "Orders"
        Me.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOrders.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.AutoSize = True
        Me.btnProducts.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducts.Image = CType(resources.GetObject("btnProducts.Image"), System.Drawing.Image)
        Me.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducts.Location = New System.Drawing.Point(22, 22)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Padding = New System.Windows.Forms.Padding(3)
        Me.btnProducts.Size = New System.Drawing.Size(159, 38)
        Me.btnProducts.TabIndex = 10
        Me.btnProducts.Text = "Products"
        Me.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'TabControl
        '
        Me.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl.ContextMenuStrip = Me.ContextMenu
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.HotTrack = True
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(631, 541)
        Me.TabControl.TabIndex = 1
        '
        'ContextMenu
        '
        Me.ContextMenu.BackColor = System.Drawing.Color.White
        Me.ContextMenu.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadCurrentFormToolStripMenuItem, Me.ToolStripSeparator1, Me.CloseTabToolStripMenuItem, Me.CloseOtherTabsToolStripMenuItem, Me.CloseTabsExitToolStripMenuItem, Me.ToolStripSeparator2, Me.SafeExitToolStripMenuItem, Me.ToolStripSeparator3, Me.RestartApplicationToolStripMenuItem})
        Me.ContextMenu.Name = "ContextMenu"
        Me.ContextMenu.Size = New System.Drawing.Size(275, 166)
        '
        'ReloadCurrentFormToolStripMenuItem
        '
        Me.ReloadCurrentFormToolStripMenuItem.Name = "ReloadCurrentFormToolStripMenuItem"
        Me.ReloadCurrentFormToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ReloadCurrentFormToolStripMenuItem.Size = New System.Drawing.Size(274, 24)
        Me.ReloadCurrentFormToolStripMenuItem.Text = "Refresh/Reload"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(271, 6)
        '
        'CloseTabToolStripMenuItem
        '
        Me.CloseTabToolStripMenuItem.Name = "CloseTabToolStripMenuItem"
        Me.CloseTabToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseTabToolStripMenuItem.Size = New System.Drawing.Size(274, 24)
        Me.CloseTabToolStripMenuItem.Text = "Close Tab"
        '
        'CloseOtherTabsToolStripMenuItem
        '
        Me.CloseOtherTabsToolStripMenuItem.Name = "CloseOtherTabsToolStripMenuItem"
        Me.CloseOtherTabsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseOtherTabsToolStripMenuItem.Size = New System.Drawing.Size(274, 24)
        Me.CloseOtherTabsToolStripMenuItem.Text = "Close Other Tabs"
        '
        'CloseTabsExitToolStripMenuItem
        '
        Me.CloseTabsExitToolStripMenuItem.Name = "CloseTabsExitToolStripMenuItem"
        Me.CloseTabsExitToolStripMenuItem.Size = New System.Drawing.Size(274, 24)
        Me.CloseTabsExitToolStripMenuItem.Text = "Close Tabs && Exit"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(271, 6)
        '
        'SafeExitToolStripMenuItem
        '
        Me.SafeExitToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SafeExitToolStripMenuItem.Name = "SafeExitToolStripMenuItem"
        Me.SafeExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[End]), System.Windows.Forms.Keys)
        Me.SafeExitToolStripMenuItem.Size = New System.Drawing.Size(274, 24)
        Me.SafeExitToolStripMenuItem.Text = "Safe Exit"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(271, 6)
        '
        'RestartApplicationToolStripMenuItem
        '
        Me.RestartApplicationToolStripMenuItem.Name = "RestartApplicationToolStripMenuItem"
        Me.RestartApplicationToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RestartApplicationToolStripMenuItem.Size = New System.Drawing.Size(274, 24)
        Me.RestartApplicationToolStripMenuItem.Text = "Restart Application"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(845, 567)
        Me.ContextMenuStrip = Me.ContextMenu
        Me.Controls.Add(Me.Splitter)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MainForm"
        Me.Text = "Stock Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.Splitter.Panel1.ResumeLayout(False)
        Me.Splitter.Panel1.PerformLayout()
        Me.Splitter.Panel2.ResumeLayout(False)
        CType(Me.Splitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Splitter.ResumeLayout(False)
        Me.ContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents Splitter As SplitContainer
    Friend WithEvents btnExit As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnUsers As Button
    Friend WithEvents btnAnalysis As Button
    Friend WithEvents btnPurchases As Button
    Friend WithEvents btnOrders As Button
    Friend WithEvents btnProducts As Button
    Friend WithEvents TabControl As TabControl
    Friend WithEvents btnSuppliers As Button
    Friend WithEvents btnSellProduct As Button
    Friend WithEvents btnNewOrder As Button
    Friend WithEvents ContextMenu As ContextMenuStrip
    Friend WithEvents ReloadCurrentFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CloseTabToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseOtherTabsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseTabsExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SafeExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents RestartApplicationToolStripMenuItem As ToolStripMenuItem
End Class
