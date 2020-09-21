Imports System.ComponentModel

Public Class OrdersForm
    Dim orders As DataView
    Dim order_items As DataSet
    Dim order_id As String
    'currency manager
    Dim currencyManager As CurrencyManager
    Private Function OrderItems(order As String) As DataSet
        Dim order_items_query As String = " SELECT item_id, item_name, products.description, quantity as quantity_ordered," &
            "date_purchased, stock_purchased as quantity_purchased, purchase_price, selling_price, stock_available " &
            " FROM order_items" &
            " INNER JOIN products ON products.product_id = order_items.item_id " &
            " and order_items.order_id = '" & order & "'"
        order_items = Access.Access.SelectData(order_items_query, "orders_order_items")
        Return order_items
    End Function
    Private Sub BackgroundWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker.DoWork
        'mysql query string to load orders
        Dim orders_query As String = "SELECT order_id, items, date_created, concat('" & company_name & " : ', username) as ordered_by, order_status, mode_of_payment, concat(first_name, ' ', last_name) as supplier_name " &
            "FROM orders" &
            " INNER JOIN suppliers ON suppliers.supplier_id = orders.supplier"
        'load orders
        orders = New DataView(Access.Access.SelectData(orders_query, "orders").Tables("orders"))
        'set currency manager
        currencyManager = CType(Me.BindingContext(orders), CurrencyManager)
    End Sub
    Private Sub BackgroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted
        'remove bindings
        RemoveBindings()
        'do bindings
        DoBindings()
    End Sub
    Private Sub RemoveBindings()
        'remove bindings
        For Each txt In grpOrderDetails.Controls.OfType(Of TextBox)
            'clear bindings on textboxes
            txt.DataBindings.Clear()
        Next
        'clear bindings on list box
        lstOrderID.DataSource = Nothing
        lstOrderID.DisplayMember = Nothing
        'clear datagrid view bindings
        gridOrderedItems.DataSource = Nothing
        gridOrderedItems.DataMember = Nothing
        Me.BindingContext = Nothing
    End Sub
    Private Sub DoBindings()
        'listbox binding
        lstOrderID.DataSource = orders
        lstOrderID.DisplayMember = "order_id"
        'bind text boxex
        txtOrderID.DataBindings.Add("Text", orders, "order_id")
        txtNoOfItems.DataBindings.Add("Text", orders, "items")
        txtDateOrdered.DataBindings.Add("Text", orders, "date_created")
        txtOrderedBy.DataBindings.Add("Text", orders, "ordered_by")
        txtOrderStatus.DataBindings.Add("Text", orders, "order_status")
        txtModeOfPayment.DataBindings.Add("Text", orders, "mode_of_payment")
        txtSupplier.DataBindings.Add("Text", orders, "supplier_name")
        'bind the grid
        gridOrderedItems.DataSource = order_items
        gridOrderedItems.DataMember = "orders_order_items"
    End Sub
    Private Sub RenameColumns()
        With gridOrderedItems
            .Columns("item_id").HeaderCell.Value = "Item ID"
            .Columns("item_name").HeaderCell.Value = "Item Name"
        End With
    End Sub

    Private Sub OrdersForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        BackgroundWorker.RunWorkerAsync()
    End Sub

    Private Sub OrderID_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstOrderID.SelectedValueChanged
        order_id = sender.SelectedItem(0).ToString
        order_items = OrderItems(order_id)
        currencyManager.Position = lstOrderID.SelectedIndex
        ShowPosition()
    End Sub
    Private Sub ShowPosition()
        ' Display the current position and the number of records
        lblPosition.Text = currencyManager.Position + 1 & " of { " & currencyManager.Count() & " }"
    End Sub
    Private Sub MoveFirst(sender As Object, e As EventArgs) Handles btnMoveFirst.Click
        ' Set the record position to the first record.. 
        currencyManager.Position = 0
        ' Show the current record position..
        ShowPosition()
    End Sub
    Private Sub MovePrevious(sender As Object, e As EventArgs) Handles btnMovePrevious.Click
        ' Set the record position to the previous record.. 
        currencyManager.Position -= 1
        ' Show the current record position..
        ShowPosition()
    End Sub

    Private Sub MoveNext(sender As Object, e As EventArgs) Handles btnMoveNext.Click
        ' Set the record position to the next record.. 
        currencyManager.Position += 1
        ' Show the current record position..
        ShowPosition()
    End Sub
    Private Sub MoveLast(sender As Object, e As EventArgs) Handles btnMoveLast.Click
        ' Set the record position to the last record.. 
        currencyManager.Position = currencyManager.Count - 1
        ' Show the current record position..
        ShowPosition()
    End Sub
End Class