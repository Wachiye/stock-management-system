Imports System.ComponentModel

Public Class ProductsForm
    Dim currencyManager As CurrencyManager
    'dataview
    Dim dataview As DataView
    Dim date_purchased As String = Date.Today.ToShortDateString
    Dim intPosition As Integer
    Dim products As DataSet
    Private Sub LoadData()
        'clear bindings
        ClearBindings()
        'set view to dataset
        dataview = New DataView(Access.Access.SelectData("SELECT * FROM products", "products").Tables("products"))
        'set currency manager
        currencyManager = CType(Me.BindingContext(dataview), CurrencyManager)
    End Sub
    Private Sub ClearBindings()
        For Each txt In grpProductDetails.Controls.OfType(Of TextBox)
            txt.DataBindings.Clear()
        Next
        For Each dtp In grpProductDetails.Controls.OfType(Of DateTimePicker)
            dtp.DataBindings.Clear()
        Next
        Me.BindingContext = Nothing
    End Sub
    Private Sub Binding(view As DataView)
        'clear bindings
        ClearBindings()
        txtProductId.DataBindings.Add("Text", view, "product_id")
        txtProductName.DataBindings.Add("Text", view, "product_name")
        txtDescription.DataBindings.Add("Text", view, "description")
        txtPurchasePrice.DataBindings.Add("Text", view, "purchase_price")
        txtSellingPrice.DataBindings.Add("Text", view, "selling_price")
        txtStockPurchased.DataBindings.Add("Text", view, "stock_purchased")
        txtStockAvailable.DataBindings.Add("Text", view, "stock_available")
        dtpDatePurchased.DataBindings.Add("Value", view, "date_purchased")
    End Sub
    Private Sub ShowPosition()
        ' Display the current position and the number of records
        lblPosition.Text = currencyManager.Position + 1 & " of { " & currencyManager.Count() & " }"
        'disable userid textbox if enabled by the new button
        'select datagrid current row
        'grdUser = currencyManager.Position - 1
    End Sub

    Private Sub MoveLast(sender As Object, e As EventArgs) Handles btnMoveLast.Click
        ' Set the record position to the last record.. 
        currencyManager.Position = currencyManager.Count - 1
        ' Show the current record position..
        ShowPosition()
    End Sub

    Private Sub MoveFirst(sender As Object, e As EventArgs) Handles btnMoveFirst.Click
        ' Set the record position to the first record.. 
        currencyManager.Position = 0
        ' Show the current record position..
        ShowPosition()
    End Sub

    Private Sub MoveNext(sender As Object, e As EventArgs) Handles btnMoveNext.Click
        ' Set the record position to the next record.. 
        currencyManager.Position += 1
        ' Show the current record position..
        ShowPosition()
    End Sub

    Private Sub MovePrevious(sender As Object, e As EventArgs) Handles btnMovePrevious.Click
        ' Set the record position to the previus record.. 
        currencyManager.Position -= 1
        ' Show the current record position..
        ShowPosition()
    End Sub

    Private Sub ClearFields(sender As Object, e As EventArgs) Handles btnNew.Click
        'clear fiels
        For Each txt In grpProductDetails.Controls.OfType(Of TextBox)
            If txt.Name <> txtProductId.Name Then
                txt.Clear()
            End If
        Next
        'generate a random key
        txtProductId.Text = GenerateKey()
    End Sub

    Private Sub UpdateProduct(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'check product details
        If txtProductName.Text = String.Empty OrElse
                txtDescription.Text = String.Empty Or
                txtSellingPrice.Text = String.Empty Then
            MsgBox("Product Name, Description and Selling Price can't be empty. Please go back and provide the required details.")
            Exit Sub
        Else
            Dim name = txtProductName.Text
            Dim description = txtDescription.Text
            Dim selling_price = txtSellingPrice.Text
            Dim sql = "UPDATE products SET product_name='" & name & "', description = '" & description & "'," &
                       "selling_price = '" & selling_price & "'" &
                " WHERE product_id ='" & txtProductId.Text & "'"
            'update product
            Dim updated As Integer = Access.Access.InsertData(sql)
            If updated = 1 Then
                'display message
                DisplayMessage("Product details updated ...")
                'reload data
                ProductsForm_Shown(sender, e)
            End If
        End If
    End Sub

    Private Sub DeleteProduct(sender As Object, e As EventArgs) Handles btnDelete.Click
        'confirm delete
        Dim result As DialogResult = MessageBox.Show("Product Details:" & vbNewLine & "" &
                                                    "Product ID: " & txtProductId.Text & vbNewLine &
                                                     "Product Name: " & txtProductName.Text & vbNewLine &
                                                     "Available Stock: " & txtStockAvailable.Text & vbNewLine & "" &
                                                     "Are you sure you want to delete this Product?", "Confrim Deletion",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim sql As String = "DELETE FROM products WHERE product_id ='" & txtProductId.Text & "'"
            'delete product
            Dim deleted As Integer = Access.Access.InsertData(sql)
            If deleted = 1 Then
                'display message
                DisplayMessage("Product deleted successfully!!")
                'reload data
                ProductsForm_Shown(sender, e)
            End If
        End If
    End Sub

    Private Sub SaveProduct(sender As Object, e As EventArgs) Handles btnSave.Click
        'verify fields
        If VerifyInputs() = 0 Then
            MessageBox.Show("Operation cancelled. Some fields are empty!! Please go back And enter the required data.", "Input Error")
            Exit Sub

        Else
            Dim sql = "INSERT INTO products(product_id, product_name, description, stock_purchased, stock_available, purchase_price, selling_price, date_purchased)" &
                " VALUES('" & txtProductId.Text & "','" & txtProductName.Text & "','" & txtDescription.Text & "'," & CType(txtStockPurchased.Text, Integer) & "" &
                "," & txtStockPurchased.Text & "," & txtPurchasePrice.Text & "," & txtSellingPrice.Text & ",'" & date_purchased & "') "
            Dim result = Access.Access.InsertData(sql)
            'if product saved
            If result = 1 Then
                'diplay message
                DisplayMessage("Product saved successfully")
                'reload data
                ProductsForm_Shown(sender, e)
            Else
                DisplayMessage("Save Failed")

            End If
        End If
    End Sub

    Private Function VerifyInputs() As Integer
        Dim valid As Integer = 1
        'check if any text box is empty
        If txtProductName.Text = String.Empty OrElse
                txtDescription.Text = String.Empty OrElse
                txtStockPurchased.Text = String.Empty OrElse
                txtSellingPrice.Text = String.Empty Or
            txtPurchasePrice.Text = String.Empty Then
            valid = 0
        End If
        Return valid
    End Function

    Private Sub ProductsForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'start the background worker
        bgWorker.RunWorkerAsync()

    End Sub

    Private Sub PurchasePrice_TextChanged(sender As Object, e As EventArgs) Handles txtPurchasePrice.TextChanged
        txtSellingPrice.Text = sender.Text
    End Sub

    Private Sub DatePurchased_ValueChanged(sender As Object, e As EventArgs) Handles dtpDatePurchased.ValueChanged
        date_purchased = dtpDatePurchased.Value.ToShortDateString
    End Sub
    Private Sub RenameColumnsBind()
        'set table column names
        gridProducts.Columns("product_id").HeaderCell.Value = "Product ID"
        gridProducts.Columns("product_name").HeaderCell.Value = "Product Name"
        gridProducts.Columns("description").HeaderCell.Value = "Description"
        gridProducts.Columns("date_purchased").HeaderCell.Value = "Date Purchased"
        gridProducts.Columns("purchase_price").HeaderCell.Value = "Purchase Price"
        'set currency style
        gridProducts.Columns("purchase_price").DefaultCellStyle = CurrencyStyle
        gridProducts.Columns("stock_available").HeaderCell.Value = "Stock Available"
        'data binding
        Binding(dataview)
        'show position
        ShowPosition()
    End Sub
    Private Sub Worker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorker.DoWork
        'load data
        LoadData()
    End Sub

    Private Sub Worker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        'populate the gridview
        products = Access.Access.SelectData("SELECT * FROM products", "products")
        gridProducts.DataSource = products
        gridProducts.DataMember = "products"
        RenameColumnsBind()
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'perform search
        Search()
    End Sub
    Private Sub GridProducts_SelectionChanged(sender As Object, e As EventArgs) Handles gridProducts.SelectionChanged
        'get the current index
        intPosition = gridProducts.CurrentRow.Index
        'reposition the currency manager to the index
        currencyManager.Position = intPosition
        'show position
        ShowPosition()
    End Sub
    Private Sub Search()
        'get the text to search
        Dim search = txtSearch.Text
        Dim sql As String
        If String.IsNullOrEmpty(search) Then
            bgWorker.RunWorkerAsync()
        End If
        If IsNumeric(search) Then
            sql = "SELECT * FROM products WHERE stock_available=" & search & " OR purchase_price=" &
                "" & search & "  OR selling_price=" & search
        Else
            ' otherwise find product id, name, description
            sql = "SELECT * FROM products WHERE product_id LIKE '%" & search & "%' OR product_name LIKE '%" & search & "%'" &
                " OR description LIKE '%" & search & "%'"
        End If
        products = Access.Access.SelectData(sql, "products_search")
        If products.Tables("products_search").Rows.Count = 0 Then
            DisplayMessage("Product not found ...")
            Exit Sub
        Else
            gridProducts.DataSource = products
            gridProducts.DataMember = "products_search"
            ' Show the current record position.. 
            ShowPosition()
        End If
    End Sub
End Class