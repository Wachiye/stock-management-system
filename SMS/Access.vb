
Module Access
    'global variable
    Public Access As New DbController
    ' Declare and set the style for currency cells ..
    Dim objCurrencyCellStyle As New DataGridViewCellStyle
    Public Property CurrencyStyle As DataGridViewCellStyle
        Get
            objCurrencyCellStyle.Format = "c"
            objCurrencyCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Return objCurrencyCellStyle
        End Get
        Set(value As DataGridViewCellStyle)
            objCurrencyCellStyle = value
        End Set
    End Property
    Public Function FormatToCents(value As String)
        Try
            value = Format(CType(value, Decimal), "##0.00")
        Catch e As Exception
            value = "0"
            value = Format(CType(value, Decimal), "##0.00")
        End Try
        Return value
    End Function

    Public Sub DisplayMessage(message As String)
        'display message on the status bar 
        MainForm.lblStatus.Text = message
        MainForm.StatusStrip.Refresh()
    End Sub

    'generates a string key with 8 chars
    Public Function GenerateKey() As String
        Dim rand As New Random
        Dim allowedChars() As Char = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim final As String = String.Empty
        For i As Integer = 0 To 7
            final += allowedChars(rand.Next(allowedChars.Length - 1))
        Next
        Return final.ToUpper
    End Function
    'captures logged in user
    Public username As String
    'company details
    Public company_name As String = My.Settings.company_name
    Public company_trade_mark As String = My.Settings.company_trade_mark
    Public company_email_primary As String = My.Settings.company_email_primary
    Public company_email_secondary As String = My.Settings.company_email_secondary
    Public company_phone_primary As String = My.Settings.company_phone_primary
    Public company_phone_secondary As String = My.Settings.company_phone_secondary
    Public company_postal_code As String = My.Settings.company_postal_code
    Public company_street_name As String = My.Settings.company_street_name
    Public company_house_number As String = My.Settings.company_house_number
    Public company_region As String = My.Settings.company_region
    Public company_state As String = My.Settings.company_state
    Public company_description As String = My.Settings.company_description
    'stores company address
    Public company_address As String = company_street_name & " " & company_house_number & ", " & company_postal_code & " " & company_region & ", " & company_state
End Module
