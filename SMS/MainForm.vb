Public Class MainForm
    Dim tabtext As String
    'display tab
    Private Sub DisplayTab(text As String, frm As Form)
        Dim found As Boolean = False
        Dim tabIndex As Integer
        'loop in the tabcontrol to verify is tab exits
        For Each tabPage In Me.TabControl.TabPages
            'check if the target tab exist
            If tabPage.Text = text Then
                found = True
                tabIndex = Me.TabControl.TabPages.IndexOf(tabPage)
                Exit For
            End If
        Next

        'if no tab exits
        If found = False Then
            'form initialization
            With frm
                .TopLevel = False
                .TopMost = False
                .FormBorderStyle = FormBorderStyle.None
                .BackColor = Color.Silver
                .ControlBox = False
                .Dock = DockStyle.Fill
                .ContextMenuStrip = ContextMenu
            End With
            'tabpage initialization
            Dim page As New TabPage
            With page
                .Text = text
                .Controls.Add(frm)
                .AutoScroll = True
            End With
            'make the from visible
            frm.Show()
            'add the new tab to the tabcontrol
            Me.TabControl.TabPages.Add(page)
            Me.TabControl.SelectTab(Me.TabControl.TabPages.IndexOf(page))
        Else
            'select the already opened tab
            Me.TabControl.SelectTab(tabIndex)
        End If
        tabtext = text
    End Sub

    Private Sub Mainform_shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        DisplayTab("Products", ProductsForm)
    End Sub

    Private Sub Openproductsform(sender As Object, e As EventArgs) Handles btnProducts.Click
        DisplayTab("Products", ProductsForm)
    End Sub

    Private Sub OpenSettingsForm(sender As Object, e As EventArgs) Handles btnSettings.Click
        'OPEN SETTINGS FORM MODALLY
        SettingsForm.ShowInTaskbar = False
        SettingsForm.ShowDialog()
    End Sub
    Private Sub OpenUsersForm(sender As Object, e As EventArgs) Handles btnUsers.Click
        DisplayTab("Users", UsersForm)
    End Sub
    Private Sub OpenOrdersForm(sender As Object, e As EventArgs) Handles btnOrders.Click
        DisplayTab("Orders", OrdersForm)
    End Sub
    Private Sub OpenNewOrdersForm(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        DisplayTab("Create New Order", NewOrdersForm)
    End Sub

    Private Sub OpenPurchasesForm(sender As Object, e As EventArgs) Handles btnPurchases.Click
        DisplayTab("Purchases", PurchasesForm)
    End Sub

    Private Sub ExitApplication(sender As Object, e As EventArgs) Handles btnExit.Click, Me.Closing
        'confirm exit application
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to quit application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'if user selects yes, then exit
        If result = DialogResult.Yes Then
            Application.Exit()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub OpenHelpForm(sender As Object, e As EventArgs) Handles btnHelp.Click
        HelpForm.ShowDialog()
    End Sub

    Private Sub OpenAboutForm(sender As Object, e As EventArgs) Handles btnAbout.Click
        AboutForm.ShowDialog()
    End Sub

    Private Sub OpenAnalysisForm(sender As Object, e As EventArgs) Handles btnAnalysis.Click
        DisplayTab("Quick Analysis", AnalysisForm)
    End Sub

    Private Sub OpenSuppliers_Form(sender As Object, e As EventArgs) Handles btnSuppliers.Click
        DisplayTab("Suppliers", SuppliersForm)
    End Sub

    Private Sub SellProduct_Click(sender As Object, e As EventArgs) Handles btnSellProduct.Click
        SalesForm.Show()
    End Sub

    Private Sub CloseTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseTabToolStripMenuItem.Click
        'close the current tab
        For Each page In TabControl.TabPages
            If page.Text = tabtext Then
                TabControl.TabPages.Remove(page)
                Exit For
            End If
        Next
    End Sub

    Private Sub CloseOtherTabsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseOtherTabsToolStripMenuItem.Click
        'close other tabs but this
        For Each page In TabControl.TabPages
            If page.Text <> tabtext Then
                TabControl.TabPages.Remove(page)
            End If
        Next
    End Sub

    Private Sub CloseTabsExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseTabsExitToolStripMenuItem.Click
        TabControl.TabPages.Clear()
        Application.Exit()
    End Sub

    Private Sub SafeExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SafeExitToolStripMenuItem.Click
        Access.Access.Disconnect()
        Application.Exit()
    End Sub

    Private Sub RestartApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartApplicationToolStripMenuItem.Click
        Application.Restart()
    End Sub
End Class
