Imports System.ComponentModel

Public Class PurchasesForm

    Dim purchases As DataSet
    Dim dataview As DataView
    Dim objCurrency As CurrencyManager
    Private Sub GetPurchasesDataView()
        Dim sql_dataview As String = "SELECT orders.order_id, items, date_created, concat('" & company_name & ":', username) as billing_name," &
            "concat(first_name, last_name) as supplier_name," &
            " concat(street_name,' ', house_number, ' ' , postal_code , ', ' , region, ' ' , state) as supplier_address, '" & company_address & "' as billing_address " &
            "FROM orders " &
            "INNER JOIN suppliers ON supplier = suppliers.supplier_id " &
            "INNER JOIN addresses on suppliers.supplier_id = addresses.user_id"
        Dim sql_purchases As String = "SELECT * FROM purchases"
        dataview = Nothing
        purchases = Nothing
        dataview = New DataView(Access.Access.SelectData(sql_dataview, "purchases_dataview").Tables("purchases_dataview"))
        purchases = Access.Access.SelectData(sql_purchases, "purchases")
        objCurrency = CType(Me.BindingContext(dataview), CurrencyManager)

    End Sub
    Private Sub Worker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorker.DoWork
        GetPurchasesDataView()
    End Sub

    Private Sub Worker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        'reset data source and data member
        With gridPurchaseDetails
            .DataSource = Nothing
            .DataMember = Nothing
            'set grid data source
            .DataSource = purchases
            .DataMember = "purchases"
        End With

        'rename columns
        With gridPurchaseDetails
            .Columns("purchase_id").HeaderCell.Value = "Purchase ID"
            .Columns("order_id").HeaderCell.Value = "Order ID"
            .Columns("purchase_date").HeaderCell.Value = "Purchase Date"
            .Columns("items_paid_for").HeaderCell.Value = "Items Paid For"
            .Columns("total_amount").HeaderCell.Value = "Expenditure"
            'format expenditure to currency 
            .Columns("total_amount").DefaultCellStyle = CurrencyStyle
        End With
        'clear existing bindings and do bindings
        For Each txt In grpOrderSummary.Controls.OfType(Of TextBox)
            txt.DataBindings.Clear()
        Next
        txtOrderId.DataBindings.Add("Text", dataview, "order_id")
        txtItemsOrdered.DataBindings.Add("Text", dataview, "items")
        txtDateOrdered.DataBindings.Add("Text", dataview, "date_created")
        txtSupplier.DataBindings.Add("Text", dataview, "supplier_name")
        txtBillingName.DataBindings.Add("Text", dataview, "billing_name")
        txtSupplierAddress.DataBindings.Add("Text", dataview, "supplier_address")
        txtBillingAddress.DataBindings.Add("Text", dataview, "billing_address")
    End Sub
    Private Sub PurchasesForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'start the background worker
        bgWorker.RunWorkerAsync()
    End Sub
    Private Sub ShowPosition()
        ' Display the current position and the number of records
        lblPosition.Text = objCurrency.Position + 1 & " of { " & objCurrency.Count() & " }"
        'disable userid textbox if enabled by the new button
        'select datagrid current row
        'grdUser = objCurrency.Position - 1
    End Sub

    Private Sub MoveLast(sender As Object, e As EventArgs) Handles btnMoveLast.Click
        ' Set the record position to the last record.. 
        objCurrency.Position = objCurrency.Count - 1
        ' Show the current record position..
        ShowPosition()
    End Sub

    Private Sub MoveFirst(sender As Object, e As EventArgs) Handles btnMoveFirst.Click
        ' Set the record position to the first record.. 
        objCurrency.Position = 0
        ' Show the current record position..
        ShowPosition()
    End Sub

    Private Sub MoveNext(sender As Object, e As EventArgs) Handles btnMoveNext.Click
        ' Set the record position to the next record.. 
        objCurrency.Position += 1
        ' Show the current record position..
        ShowPosition()
    End Sub

    Private Sub MovePrevious(sender As Object, e As EventArgs) Handles btnMovePrevious.Click
        ' Set the record position to the previus record.. 
        objCurrency.Position -= 1
        ' Show the current record position..
        ShowPosition()
    End Sub
    Private Sub New_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim frm As New NewPuchaseForm
        frm.Show()
    End Sub

    Private Sub PurchaseDetails_SelectionChanged(sender As Object, e As EventArgs) Handles gridPurchaseDetails.SelectionChanged
        ' Set the record position to the last record.. 
        objCurrency.Position = gridPurchaseDetails.CurrentRow.Index
        ' Show the current record position..
        ShowPosition()
    End Sub
End Class