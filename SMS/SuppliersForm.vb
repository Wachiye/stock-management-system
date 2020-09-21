Imports System.ComponentModel

Public Class SuppliersForm
    'dataview
    Dim dataview As DataView
    'currency manager
    Dim currencyManager As CurrencyManager
    Private Sub LoadData()
        'clear bindings
        ClearBindings()

        Dim sql As String = " SELECT suppliers.supplier_id as supplier_id, first_name, last_name, email, phone_number, other_number, products, " &
                            " street_name, house_number, region, state, postal_code" &
                            " FROM suppliers,addresses" &
                            " WHERE addresses.user_id = suppliers.supplier_id"
        'set view to dataset
        dataview = New DataView(Access.Access.SelectData(sql, "suppliers").Tables("suppliers"))
        'set currency manager
        currencyManager = CType(Me.BindingContext(dataview), CurrencyManager)
    End Sub
    Private Sub ClearBindings()
        For Each txt In grpSupplierDetails.Controls.OfType(Of TextBox)
            txt.DataBindings.Clear()
        Next
        Me.BindingContext = Nothing
    End Sub
    Private Sub Binding(view As DataView)
        txtSupplierId.DataBindings.Add("Text", view, "supplier_id")
        txtFirstName.DataBindings.Add("Text", view, "first_name")
        txtLastName.DataBindings.Add("Text", view, "last_name")
        txtEmail.DataBindings.Add("Text", view, "email")
        txtPhoneNumber.DataBindings.Add("Text", view, "phone_number")
        txtOtherNumber.DataBindings.Add("Text", view, "other_number")
        txtProducts.DataBindings.Add("Text", view, "products")
        txtStreetName.DataBindings.Add("Text", view, "street_name")
        txtHouseNumber.DataBindings.Add("Text", view, "house_number")
        txtPostalCode.DataBindings.Add("Text", view, "postal_code")
        txtRegion.DataBindings.Add("Text", view, "region")
        txtState.DataBindings.Add("Text", view, "state")
    End Sub
    Private Sub ShowPosition()
        ' Display the current position and the number of records
        lblPosition.Text = currencyManager.Position + 1 & " of { " & currencyManager.Count() & " }"
        'disable userid textbox if enabled by the new button
        If txtSupplierId.Enabled = True Then
            txtSupplierId.Enabled = False
        End If
        'select datagrid current row
        'grdUser = currencyManager.Position - 1
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

    Private Sub NewSupplier(sender As Object, e As EventArgs) Handles btnNew.Click
        'clear fields
        For Each txt In grpSupplierDetails.Controls.OfType(Of TextBox)
            txt.Clear()
        Next
        'enabled the supplier id field
        txtSupplierId.Enabled = True
    End Sub
    Private Function IsFieldsEmpty() As Integer
        Dim valid As Integer = 1
        For Each txt In grpSupplierDetails.Controls.OfType(Of TextBox)
            If txt.Text = String.Empty Then
                valid = 0
                Exit For
            End If
        Next
        Return valid
    End Function


    Private Sub SaveSupplier(sender As Object, e As EventArgs) Handles btnSave.Click
        'check for empty fields
        If IsFieldsEmpty() = 0 Then
            MsgBox("Operation Canceled. Some fileds are empty. Please go back and fill in the required details.")
            Exit Sub
        End If

        Dim id As Integer = txtSupplierId.Text
        Dim firstname As String = txtFirstName.Text
        Dim lastname As String = txtLastName.Text
        Dim email As String = txtEmail.Text
        Dim phone_number As String = txtPhoneNumber.Text
        Dim other_number As String = txtOtherNumber.Text
        Dim products As String = txtProducts.Text
        Dim street_name As String = txtStreetName.Text
        Dim house_number As String = txtHouseNumber.Text
        Dim postal_code As String = txtPostalCode.Text
        Dim region As String = txtRegion.Text
        Dim state As String = txtState.Text

        Dim supplier As String = "INSERT INTO suppliers(supplier_id, first_name, last_name, email, phone_number, other_number, products)" &
                                " VALUES(" & id & ",'" & firstname & "','" & lastname & "','" & email & "','" & phone_number & "'," &
                                "'" & other_number & "','" & products & "')"
        'save supplier details
        If Access.Access.InsertData(supplier) = 1 Then

            Dim address As String = "INSERT INTO addresses(user_id, street_name, house_number, postal_code, region, state)" &
                                " VALUES(" & id & ",'" & street_name & "'," & house_number & ",'" & postal_code & "','" & region & "'," &
                                "'" & state & "')"
            'save address details
            If Access.Access.InsertData(address) = 1 Then
                DisplayMessage("New supplier added")
                SuppliersForm_Shown(sender, e)
            End If
        End If
    End Sub

    Private Sub UpdateSupplier(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'check for empty fields
        If IsFieldsEmpty() = 0 Then
            MsgBox("Operation Canceled. Some fileds are empty. Please go back and fill in the required details.")
            Exit Sub
        End If

        Dim id As Integer = txtSupplierId.Text
        Dim firstname As String = txtFirstName.Text
        Dim lastname As String = txtLastName.Text
        Dim email As String = txtEmail.Text
        Dim phone_number As String = txtPhoneNumber.Text
        Dim other_number As String = txtOtherNumber.Text
        Dim products As String = txtProducts.Text
        Dim street_name As String = txtStreetName.Text
        Dim house_number As String = txtHouseNumber.Text
        Dim postal_code As String = txtPostalCode.Text
        Dim region As String = txtRegion.Text
        Dim state As String = txtState.Text

        Dim supplier As String = "UPDATE suppliers SET first_name='" & firstname & "', last_name='" & lastname & "',email='" & email & "',phone_number='" & phone_number & "'," &
                                "other_number='" & other_number & "',products='" & products & "' WHERE supplier_id=" & id
        'update supplier details
        If Access.Access.InsertData(supplier) = 1 Then
            DisplayMessage("Supplier details updated ...")
            Dim address As String = "UPDATE addresses SET street_name='" & street_name & "',house_number=" & house_number & ",postal_code='" & postal_code & "',region='" & region & "'," &
                                "state='" & state & "'  WHERE user_id=" & id
            'update address details
            If Access.Access.InsertData(address) = 1 Then
                DisplayMessage("Address updated")
                SuppliersForm_Shown(sender, e)
            End If
        End If
    End Sub

    Private Sub DeleteSupplier(sender As Object, e As EventArgs) Handles btnDelete.Click
        'confirm delete
        Dim result As DialogResult = MessageBox.Show("Supplier account details:" & vbNewLine & "" &
                                                     "ID: " & txtSupplierId.Text & vbNewLine &
                                                     "Name : " & txtFirstName.Text & " " & txtLastName.Text & vbNewLine & "" &
                                                     "Are you sure you want to delete this account?", "Confrim Deletion",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim sql As String = "DELETE FROM suppliers WHERE supplier_id =" & txtSupplierId.Text
            'delete user
            Dim deleted As Integer = Access.Access.InsertData(sql)
            If deleted = 1 Then
                'display message
                DisplayMessage("Record deleted Successfully. Removing address")
                sql = "DELETE FROM addresses WHERE user_id=" & txtSupplierId.Text
                'reload data
                If Access.Access.InsertData(sql) = 1 Then
                    DisplayMessage("Address removed ...")
                End If
                SuppliersForm_Shown(sender, e)
            End If
        End If
    End Sub

    Private Sub SuppliersForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'start the background worker
        BackgroundWorker.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker.DoWork
        'load the data
        LoadData()
    End Sub

    Private Sub BackgroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted
        'data binding
        Binding(dataview)
        'show position
        ShowPosition()
    End Sub
End Class