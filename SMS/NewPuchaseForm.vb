Imports System.ComponentModel

Public Class NewPuchaseForm
    Dim items, index As Integer
    'get order_id
    Dim order_id As String
    Dim order_ids As DataRowCollection
    Dim order_items As DataSet
    Private Sub GetOrderIds()
        order_ids = Nothing
        Dim sql As String = "SELECT order_id, items FROM orders WHERE order_status='Processed'"
        order_ids = Access.Access.SelectData(sql, "order_ids").Tables("order_ids").Rows
    End Sub
    Private Function GetOrderItems(order_id As String) As DataSet
        Dim sql As String = "SELECT item_id,item_name,description,quantity FROM order_items WHERE order_id='" & order_id & "'"
        Dim items = Access.Access.SelectData(sql, "order_items")
        Return items
    End Function
    Private Sub AddPurchase(perItem As Boolean)

        'get number of purchased items
        Dim items_purchased As Integer = NumberOfItems(perItem)
        'get today's date
        Dim date_purchased As String = Date.Today.ToShortDateString
        'get tatal amount
        Dim total_amount = txtTotalAmount.Text
        'declare and set insert query
        Dim sql As String = "INSERT INTO purchases(order_id, purchase_date, items_paid_for, total_amount)" &
            " VALUES('" & order_id & "','" & date_purchased & "'," & items_purchased & "," & total_amount & ")"
        'try saving
        Dim result As Integer = Access.Access.InsertData(sql)
        If result = 1 Then
            'display success message
            DisplayMessage("Purchase Saved ... ")
        End If
    End Sub
    Private Sub AddProducts(perItem As Boolean)
        Dim sql_head As String = "INSERT INTO products(product_id, product_name, description, date_purchased," &
            "stock_purchased, stock_available, purchase_price, selling_price)"
        Dim sql_tail As String
        Dim product_id, product_name, description, date_purchased As String
        Dim quantity_purchased As Integer
        Dim purchase_price As Integer
        'loop over the rows to save
        For i = 0 To gridItems.Rows.Count - 2
            'get product details
            product_id = gridItems.Rows(i).Cells(0).Value.ToString
            product_name = gridItems.Rows(i).Cells(1).Value.ToString
            description = gridItems.Rows(i).Cells(2).Value.ToString
            'get the quantity purchased and the price
            If perItem Then
                quantity_purchased = gridItems.Rows(i).Cells(4).Value
                purchase_price = gridItems.Rows(i).Cells(5).Value.ToString
            Else
                quantity_purchased = gridItems.Rows(i).Cells(3).Value
                purchase_price = txtPriceForAll.Text
            End If
            'get today's date
            date_purchased = Date.Today.ToShortDateString

            'complete the insert query string
            sql_tail = " VALUES('" & product_id & "','" & product_name & "','" & description & "'," &
                    "'" & date_purchased & "'," & quantity_purchased & "," & quantity_purchased & "," & purchase_price & "," & purchase_price & ")"
            If perItem Then
                'quantity should be > 0 for item to be saved
                If quantity_purchased > 0 Then
                    Access.Access.InsertData(sql_head & sql_tail)
                End If
            Else
                Access.Access.InsertData(sql_head & sql_tail)
            End If
        Next
    End Sub
    Private Sub NewPurchaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load pending order id
        GetOrderIds()
        'display the loaded order ids in the combo box
        For Each order In order_ids
            cboOrderId.Items.Add(order("order_id").ToString)
        Next

    End Sub
    Private Sub OrderId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrderId.SelectedIndexChanged
        'get selected order id
        order_id = sender.SelectedItem.ToString
        'fetch related order_items
        order_items = GetOrderItems(order_id)
    End Sub
    Private Sub ShowOrderItems()
        'set data and name columns
        With gridItems
            .DataSource = order_items
            .DataMember = "order_items"
            .Columns("item_id").HeaderCell.Value = "Item ID"
            .Columns("item_name").HeaderCell.Value = "Name"
            .Columns("description").HeaderCell.Value = "Description"
            .Columns("quantity").HeaderCell.Value = "Quantity Ordered"
            'add three more columns
            .Columns.Add("quantity_purchased", "Quantity Selected") 'to display the purchased quantity
            .Columns.Add("purchase_price", "Purchase Price") 'to show the purchase price for each item
            .Columns("purchase_price").DefaultCellStyle = CurrencyStyle
            .Columns.Add("total_price", "Total Price") 'to show the total price of the items ordered
            .Columns("total_price").DefaultCellStyle = CurrencyStyle
        End With
        'calulate number of items
        items = NumberOfItems(False)
    End Sub
    Function NumberOfItems(perItem As Boolean) As Integer
        Dim sum As Integer = 0
        'create a loop on the quantity column
        For i = 0 To gridItems.Rows.Count - 2
            'cumulatively add up each quantity to sum
            If perItem = True Then
                sum += CType(gridItems.Rows(i).Cells(4).Value.ToString, Integer)
            Else
                sum = items
            End If
        Next
        'return the sum of items
        Return sum
    End Function
    Function TotalAmount() As Integer
        Dim sum As Integer = 0
        Dim price As Integer
        'create a loop on the quantity column
        For i = 0 To gridItems.Rows.Count - 2
            Try
                price = gridItems.Rows(i).Cells(6).Value
            Catch ex As Exception
                price = 0
            End Try
            'cumulatively add up each quantity to sum
            sum += price
        Next
        'return the sum of items
        Return sum
    End Function
    Private Sub PricingOption_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPricingOption.SelectedIndexChanged
        If cboPricingOption.SelectedIndex = 0 Then
            'enable the fixedprice groupbox
            grpFixedPriced.Enabled = True
            grpCostPerItem.Enabled = False
        ElseIf cboPricingOption.SelectedIndex = 1 Then
            'enable the costperitem groupbox
            grpCostPerItem.Enabled = True
            grpFixedPriced.Enabled = False
        End If
    End Sub
    Private Sub FixedPrice_Click(sender As Object, e As EventArgs) Handles btnFixedPrice.Click
        'calculate total amount using the fixed price
        Dim amount = items * CType(txtPriceForAll.Text, Integer)
        txtTotalAmount.Text = FormatToCents(amount)
    End Sub

    Private Sub GridItems_SelectionChanged(sender As Object, e As EventArgs) Handles gridItems.SelectionChanged
        Try
            'set Index to current selectedrow index
            index = gridItems.CurrentRow.Index
            ''show cell vaules in text boxes
            txtItem.Text = gridItems.CurrentRow.Cells(0).Value.ToString
            ShowQuantityPrice(index)
        Catch ex As Exception
            txtItem.Clear()
            txtQuantity.Clear()
            txtPrice.Clear()
        End Try

    End Sub

    Private Sub CostPerItem_Click(sender As Object, e As EventArgs) Handles btnCostPerItem.Click
        'calculate the total price of the item
        Dim total_price = CType(txtQuantity.Text, Integer) * txtPrice.Text
        gridItems.Rows(index).Cells(4).Value = txtQuantity.Text
        gridItems.Rows(index).Cells(5).Value = txtPrice.Text
        gridItems.Rows(index).Cells(6).Value = total_price
        'calculate the total amount of the purchased items
        Dim total_amount = TotalAmount()
        'display the amount in the totalamount textbox
        txtTotalAmount.Text = FormatToCents(total_amount)
    End Sub

    Private Sub Continue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Dim selected_index = cboPricingOption.SelectedIndex
        'check if option is selected
        If selected_index < 0 Then
            'nothing selected
            Exit Sub
        Else
            'check if values have been edited for saving
            If IsNumeric(txtTotalAmount.Text) = False OrElse
                    txtTotalAmount.Text <= 0 Or
                    txtTotalAmount.Text = String.Empty Then
                MsgBox("Purchase can't be saved. Amount should be > 0")
                Exit Sub
            Else
                'Try saving
                Try
                    If selected_index = 0 Then
                        AddPurchase(False)
                        AddProducts(False)
                    Else
                        AddPurchase(True)
                        AddProducts(True)
                    End If
                    'update the order
                    Dim sql As String = "UPDATE orders SET order_status = 'Completed:" & Date.Today.ToShortDateString & "' WHERE order_id='" & order_id & "'"
                    Dim result = Access.Access.InsertData(sql)
                    If result = 1 Then
                        'display message
                        DisplayMessage("Order completed...")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            Close()
        End If

    End Sub
    Private Sub ShowQuantityPrice(index)
        Dim quantity_ordered As Integer
        Dim quantity_selected As Integer
        Dim price As Integer
        Try
            quantity_ordered = gridItems.Rows(index).Cells(3).Value
            quantity_selected = gridItems.Rows(index).Cells(4).Value
            price = FormatToCents(gridItems.Rows(index).Cells(5).Value.ToString)
            If quantity_selected <> quantity_ordered Then
                txtQuantity.Text = quantity_selected
            End If
            txtPrice.Text = price
        Catch ex As Exception
            txtQuantity.Text = gridItems.Rows(index).Cells(3).Value
            txtPrice.Text = FormatToCents("0")
        End Try
    End Sub

    Private Sub View_Click(sender As Object, e As EventArgs) Handles btnView.Click
        ShowOrderItems()
    End Sub

End Class