Public Class SettingsForm
    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Text = company_name
        txtTradeMark.Text = company_trade_mark
        txtPrimaryEmail.Text = company_email_primary
        txtOtherEmail.Text = company_email_secondary
        txtPrimaryPhone.Text = company_phone_primary
        txtOtherPhone.Text = company_phone_secondary
        txtStreet.Text = company_street_name
        txtDescription.Text = company_description
        txtHouseNumber.Text = company_house_number
        txtPostalCode.Text = company_postal_code
        txtRegion.Text = company_region
        txtState.Text = company_state
        txtHost.Text = My.Settings.host
        txtUsername.Text = My.Settings.username
        txtPassword.Text = My.Settings.password
        txtDatabase.Text = My.Settings.database
    End Sub

    Private Sub SaveDatabase_Click(sender As Object, e As EventArgs) Handles btnSaveDatabase.Click
        'update database access settings
        Try
            With My.Settings
                .host = txtHost.Text
                .username = txtUsername.Text
                .password = txtPassword.Text
                .database = txtDatabase.Text
            End With
            DisplayMessage("Database login changed ..")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SetupDatabase_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        'create database and related tables

    End Sub

    Private Sub SaveAddress_Click(sender As Object, e As EventArgs) Handles btnSaveAddress.Click
        'update company address details
        Try
            With My.Settings
                .company_street_name = txtStreet.Text
                .company_house_number = txtHouseNumber.Text
                .company_postal_code = txtPostalCode.Text
                .company_region = txtRegion.Text
                .company_state = txtState.Text
            End With
            DisplayMessage("Address updated successfully...")
        Catch ex As Exception

        End Try


    End Sub

    Private Sub SaveInformation_Click(sender As Object, e As EventArgs) Handles btnSaveInformation.Click
        'update company basic information
        Try
            With My.Settings
                .company_name = txtName.Text
                .company_description = txtDescription.Text
                .company_email_primary = txtPrimaryEmail.Text
                .company_email_secondary = txtOtherEmail.Text
                .company_phone_primary = txtPrimaryPhone.Text
                .company_phone_secondary = txtOtherPhone.Text
                .company_trade_mark = txtTradeMark.Text
            End With
            DisplayMessage("Company details changed ...")
        Catch ex As Exception

        End Try
    End Sub
End Class