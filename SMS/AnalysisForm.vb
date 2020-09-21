Imports System.ComponentModel

Public Class AnalysisForm
    Dim users, products, total_expenditure, total_income As String
    Dim mostPurchasedData As DataTable
    Private Function GetValues(sql As String, table As String) As String
        Dim datarow As DataRowCollection = Access.Access.SelectData(sql, table).Tables(table).Rows
        Dim data As String = datarow.Item(0).Item(0)
        If data = String.Empty Then
            Return "0"
        End If
        Return data
    End Function
    Private Sub AnalysisForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        bgWorker.RunWorkerAsync()
    End Sub

    Private Sub Worker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorker.DoWork
        'get numbre of system users
        users = GetValues("SELECT count(user_id) as users FROM users", "user_number")
        'get number of available products
        products = GetValues("SELECT sum(stock_available) as products FROM products", "product_number")
        'get total expenditure
        total_expenditure = GetValues("SELECT sum(purchase_price) as expenditure FROM products", "total_expenditure")
        'get tital income
        total_income = GetValues("SELECT sum(total_amount) as income FROM sales", "total_income")
        'get most purchased products
        Dim sql As String = "SELECT product_id, count(product_id) as frequency, sum(quantity) as quantity" &
            " FROM sales " &
            " GROUP BY product_id ORDER BY frequency DESC" &
            " LIMIT 10"
        mostPurchasedData = Access.Access.SelectData(sql, "most_purchased").Tables("most_purchased")
    End Sub

    Private Sub Worker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        'display values
        lblTopUsers.Text = users
        lblTopProducts.Text = products
        lblTopExpenditure.Text = FormatToCents(total_expenditure)
        lblTopIncome.Text = FormatToCents(total_income)
        'display most purchased products
        QuantityChart.Series("Quantity").XValueMember = "product_id"
        QuantityChart.Series("Quantity").YValueMembers = "quantity"
        QuantityChart.Series("Frequency").XValueMember = "product_id"
        QuantityChart.Series("Frequency").YValueMembers = "frequency"
        QuantityChart.DataSource = mostPurchasedData
        QuantityChart.DataBind()
    End Sub
End Class