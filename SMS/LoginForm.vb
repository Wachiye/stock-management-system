Imports System.ComponentModel

Public Class LoginForm
    Dim data As DataRowCollection
    Private Function ValidUser(username As String, password As String) As Integer
        'verify user details
        Dim user As DataTable = Access.Access.SelectData("SELECT username, password FROM users WHERE username=" &
                                "'" & username & "' AND password=md5('" & password & "')", "user").Tables("user")
        If user.Rows.Count = 1 Then
            Return 1
        Else
            Return 0
        End If
        user.Dispose()
    End Function

    Private Sub ExitApplication(sender As Object, e As EventArgs) Handles btnClose.Click
        'confirm exit application
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to quit application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'if user selects yes, then exit
        If result = DialogResult.Yes Then
            'cancel the background worker if its busy
            If bgWorker.IsBusy Then
                bgWorker.CancelAsync()
            End If
            Application.Exit()
        End If
    End Sub

    Private Sub Login(sender As Object, e As EventArgs) Handles btnLogin.Click
        'check if username name and password is given
        If cboUsers.SelectedItem = String.Empty Or txtPassword.Text = String.Empty Then
            MessageBox.Show("Username and Password fields can't be empty. Please fill in these fields to continue", "Input Error")
            Exit Sub
        End If
        'assign the values to variable
        Dim user As String = cboUsers.SelectedItem
        Dim password As String = txtPassword.Text
        'check if user exist
        Dim found As Integer = ValidUser(user, password)
        If found = 1 Then 'user exits
            'open main form
            username = user
            MainForm.Show()
            txtPassword.Clear()
            'hide login form
            Me.Hide()
        Else 'user does not exist
            MessageBox.Show("Wrong Username/Password. Please try again.", "Access Denied")
        End If

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'start background worker
        bgWorker.RunWorkerAsync()
        If bgWorker.IsBusy Then
            btnLogin.Enabled = False
        End If
        Me.Text = My.Settings.company_name.ToUpper.ToString
        Me.lblCompanyName.Text = Me.Text
        Me.lblTradeMark.Text = My.Settings.company_trade_mark.ToString
        Me.lblSystemCompany.Text = "STOCK MANAGEMENT SYSTEM - " & My.Settings.company_name.ToUpper
    End Sub

    Private Sub Worker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorker.DoWork
        'fetch username from database
        data = Access.Access.SelectData("SELECT username FROM USERS", "usernames").Tables("usernames").Rows

    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        If data.Count = 0 Then
            UsersForm.ShowDialog()
        Else
            'populate the combobox with the usernames
            For Each user In data
                cboUsers.Items.Add(user("username"))
            Next
            'enable the login button
            btnLogin.Enabled = True
        End If
    End Sub

End Class