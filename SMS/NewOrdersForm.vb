Imports System.ComponentModel

Public Class NewOrdersForm
    Dim suppliers As DataView
    Dim currencyManager As CurrencyManager
    Dim supplier_id As Integer
    Dim supplier_names As DataRowCollection
    Private Sub OrdersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCompanyName.Text = company_name
        txtEmail.Text = company_email_primary
        txtPhone.Text = company_phone_primary
        txtAddress.Text = company_address
        txtUsername.Text = username
        lblOrderNoValue.Text = GenerateKey()
    End Sub

    Private Sub OrdersForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'start the background worker
        bgWorker.RunWorkerAsync()

    End Sub
    Private Sub ClearBindings()
        'clear the bindings
        For Each txt In grpSupplier.Controls.OfType(Of TextBox)
            txt.DataBindings.Clear()
        Next
        Me.BindingContext = Nothing
    End Sub
    Private Sub Showdata(view As DataView)
        'display data in textboxes
        Dim index As Integer = currencyManager.Position
        supplier_id = CType(view(index)(0).ToString, Integer)
        txtFullName.Text = view(index)(1).ToString & " " & view(index)(2).ToString
        txtSupplierEmail.Text = view(index)(3).ToString
        txtSupplierPhone.Text = view(index)(4).ToString
        txtSupplierAddress.Text = view(index)(5).ToString & " " & view(index)(6).ToString & ", " & view(index)(7).ToString & " " & view(index)(8).ToString & ", " & view(index)(9).ToString
    End Sub
    Private Sub Worker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorker.DoWork
        'clear bindings
        ClearBindings()
        'sql to load suppliers
        Dim sql As String = " SELECT suppliers.supplier_id, first_name, last_name, email, phone_number," &
                            " street_name, house_number, postal_code, region, state" &
                            " FROM suppliers,addresses" &
                            " WHERE addresses.user_id = suppliers.supplier_id"
        'set view to dataset
        suppliers = New DataView(Access.Access.SelectData(sql, "suppliers").Tables("suppliers"))
        'get names of suppliers
        supplier_names = Access.Access.SelectData("Select concat(first_name,' ', last_name) as supplier_name FROM suppliers", "supplier_names").Tables("supplier_names").Rows

    End Sub
    Private Sub Worker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        'set currency manager
        currencyManager = CType(Me.BindingContext(suppliers), CurrencyManager)
        'clear combo box items
        cboSuppliers.Items.Clear()
        For Each supplier_name In supplier_names
            'populate the combobox
            cboSuppliers.Items.Add(supplier_name("supplier_name"))
        Next

        'show data
        Showdata(suppliers)
    End Sub
    Private Sub SupplierSelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSuppliers.SelectedIndexChanged
        currencyManager.Position = cboSuppliers.SelectedIndex
        Showdata(suppliers)
    End Sub

    Private Sub AddNewItem_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'create new row 
        Dim row As String() = {GenerateKey(), txtItem.Text, txtDescription.Text, txtQuantity.Text}
        'add new row
        gridOrderItems.Rows.Add(row)
        'clear the text boxes
        txtItem.Clear()
        txtDescription.Clear()
        txtQuantity.Clear()
        'show current items
        ShowItems()
    End Sub

    Private Sub RemoveSelectedItems_Click(sender As Object, e As EventArgs) Handles btnRemoveSelected.Click
        'remove selected items
        For Each item In gridOrderItems.SelectedRows
            gridOrderItems.Rows.Remove(item)
        Next
        ShowItems()
    End Sub
    Public Sub ShowItems()
        lblOrderItems.Text = gridOrderItems.Rows.Count - 1
    End Sub
    Private Sub ClearItems_Click(sender As Object, e As EventArgs) Handles btnClearItems.Click
        gridOrderItems.Rows.Clear()
        ShowItems()
    End Sub
    Private Function CheckInputs() As Boolean
        Dim result As Boolean = True
        'check for empty fields in the billing informartion
        For Each txt In grpBillingInformation.Controls.OfType(Of TextBox)
            If String.IsNullOrEmpty(txt.Text) Then
                result = False
                MsgBox("Incomplete billing informartion. Please ensure you have included the mode of purchase.")
            End If
        Next
        'check for empty fields in the supplier informartion
        For Each txt In grpSupplier.Controls.OfType(Of TextBox)
            If String.IsNullOrEmpty(txt.Text) Then
                result = False
                MsgBox("Incomplete Supplier informartion. Please ensure you have selected a supplier.")
            End If
        Next
        'check for empty fields in the order items

        If gridOrderItems.Rows.Count - 1 <= 0 Then
            result = False
            MsgBox("Incomplete Order. Please ensure you have included at least one item.")
        End If
        Return result
    End Function
    Private Sub Continue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If chkConfirm.Checked = False Then
            'user must confirm submission
            MsgBox("Please ensure that your entered the correct billing informartion, supplier and included the required details of items to order and selected the check box above.")
            Exit Sub
        ElseIf CheckInputs Then
            'process the order detials and make order
            Dim order_id As String = lblOrderNoValue.Text
            Dim items As Integer = CalculateTotalItems()
            Dim supplier_selected As String = txtFullName.Text
            Dim date_created As String = Date.Today.ToShortDateString
            Dim user As String = username
            Dim status As String = "Pending"

            Dim sql As String = "INSERT INTO orders(order_id, items, supplier, date_created, username, mode_of_payment, order_status)" &
                            " VALUES('" & order_id & "'," & items & "," & supplier_id & ",'" & date_created & "'" &
                            ",'" & user & "','" & cboModeOfPayment.SelectedItem.ToString & "','" & status & "')"
            Dim result As Integer = Access.Access.InsertData(sql)
            If result = 1 Then
                InsertOrderItems()
                DisplayMessage("Order Created")
                btnClearItems.PerformClick()
                chkConfirm.Checked = False
            End If
        Else
            Exit Sub
        End If
    End Sub
    Private Sub InsertOrderItems()
        'get order item detials
        Dim order_id As String = lblOrderNoValue.Text
        Dim item_id As String
        Dim item_name As String
        Dim item_description As String
        Dim item_quantity As Integer
        Dim sql As String
        'loop over the grid
        For i As Integer = 0 To gridOrderItems.Rows.Count - 2
            item_id = gridOrderItems.Rows(i).Cells(0).Value.ToString
            item_name = gridOrderItems.Rows(i).Cells(1).Value.ToString
            item_description = gridOrderItems.Rows(i).Cells(2).Value.ToString
            item_quantity = CType(gridOrderItems.Rows(i).Cells(3).Value.ToString, Integer)
            sql = "INSERT INTO order_items(order_id,item_id, item_name,description, quantity)" &
                " VALUES('" & order_id & "','" & item_id & "','" & item_name & "','" & item_description & "'," & item_quantity & ")"
            Access.Access.InsertData(sql)
        Next
    End Sub
    Private Function CalculateTotalItems() As Integer
        Dim total As Integer = 0
        For i As Integer = 0 To gridOrderItems.Rows.Count - 2
            total += CType(gridOrderItems.Rows(i).Cells(3).Value.ToString, Integer)
        Next
        Return total
    End Function

    Private Sub Confirm_CheckedChanged(sender As Object, e As EventArgs) Handles chkConfirm.CheckedChanged
        If sender.Checked = True Then
            btnContinue.Enabled = True
        Else
            btnContinue.Enabled = False
        End If
    End Sub


End Class