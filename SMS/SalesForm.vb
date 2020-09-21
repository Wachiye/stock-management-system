Imports System.ComponentModel

Public Class SalesForm
    Dim products As DataSet
    Dim quantity As Integer
    Private Sub Amount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        If String.IsNullOrEmpty(txtAmount.Text) Or IsNumeric(txtAmount.Text) = False Then
            Exit Sub
        Else
            'calculate the change
            Dim change = txtAmount.Text - txtTotal.Text
            txtChange.Text = FormatToCents(change.ToString)
        End If
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles btnSearch.Click, MyBase.Load
        bgWorker.RunWorkerAsync()
        If bgWorker.IsBusy Then
            btnSearch.Enabled = False
            gridProducts.Enabled = False
            btnSubmit.Enabled = False
            PictureBox.Image = ImageList.Images.Item(2)
        End If
    End Sub

    Private Sub Worker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork
        products = Nothing
        'get text to search
        Dim searchText As String = txtSearch.Text
        'sql query
        Dim sql As String = "SELECT product_id, product_name, description, stock_available, selling_price FROM products" &
            " WHERE stock_available > 0 AND product_id LIKE '%" & searchText & "%' OR product_name LIKE '%" & searchText & "%'" &
            " OR description LIKE '%" & searchText & "%'"
        'get matched results
        products = Access.Access.SelectData(sql, "search_products")
        If products.Tables("search_products").Rows.Count = 0 Then
            MsgBox("Product not found!!! Please enter a product name/description/id and try again.")
            txtSearch.Clear()
            'query all products
            btnSearch.PerformClick()
        End If
    End Sub

    Private Sub Worker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        'display the mathched data
        gridProducts.DataSource = products
        gridProducts.DataMember = "search_products"
        'rename columns
        With gridProducts
            .Columns("product_id").HeaderCell.Value = "Product ID"
            .Columns("product_name").HeaderCell.Value = "Product Name"
            .Columns("description").HeaderCell.Value = "Description"
            .Columns("stock_available").HeaderCell.Value = "Available"
            .Columns("selling_price").HeaderCell.Value = "Price"
            .Columns("selling_price").DefaultCellStyle = CurrencyStyle
        End With
        'enable the search and submit button and grid products
        btnSearch.Enabled = True
        btnSubmit.Enabled = True
        gridProducts.Enabled = True
    End Sub

    Private Sub Products_SelectionChanged(sender As Object, e As EventArgs) Handles gridProducts.SelectionChanged
        'display values of the current selected product
        txtProductID.Text = gridProducts.CurrentRow.Cells(0).Value
        txtDescription.Text = gridProducts.CurrentRow.Cells(2).Value
        'get the quantity of the product
        quantity = gridProducts.CurrentRow.Cells(3).Value
        txtPrice.Text = gridProducts.CurrentRow.Cells(4).Value
        'set maximum value of the quantity
        txtQuantity.Maximum = quantity
    End Sub

    Private Sub Quantity_ValueChanged(sender As Object, e As EventArgs) Handles txtQuantity.ValueChanged
        If String.IsNullOrEmpty(txtPrice.Text) Then
            Exit Sub
        Else
            'get total price
            Dim total = txtQuantity.Value * txtPrice.Text
            txtTotal.Text = FormatToCents(total.ToString)
        End If
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        bgWorkerSave.RunWorkerAsync()
        If bgWorkerSave.IsBusy Then
            btnSubmit.Enabled = False
        End If
    End Sub

    Private Sub WorkerSave_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorkerSave.DoWork
        Dim query As String = "UPDATE products SET stock_available = products.stock_available - " & txtQuantity.Value & " WHERE product_id = '" & txtProductID.Text & "'"
        Dim sql As String = "INSERT INTO sales(product_id, price, quantity, total_amount, sale_date) VALUES(" &
            "'" & txtProductID.Text & "', " & txtPrice.Text & ", " & txtQuantity.Value & ", " & txtAmount.Text & ",'" & Date.Today.ToShortDateString & "')"
        'update the product quantity
        Dim update_product = Access.Access.InsertData(query)
        Dim insert_sale = Access.Access.InsertData(sql)
        If update_product = 1 And insert_sale = 1 Then
            PictureBox.Image = ImageList.Images.Item(1)

            Threading.Thread.Sleep(5000)
        Else
            PictureBox.Image = ImageList.Images.Item(0)
        End If
    End Sub

    Private Sub WorkerSave_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgWorkerSave.RunWorkerCompleted
        txtSearch.Clear()
        btnSearch.PerformClick()
        btnSubmit.Enabled = True
    End Sub
End Class