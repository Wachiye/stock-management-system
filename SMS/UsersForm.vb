Imports System.ComponentModel

Public Class UsersForm
    'dataview
    Dim view As DataView
    'currency manager
    Dim currencyManager As CurrencyManager
    Private Sub LoadData()
        'set view to dataset
        view = New DataView(Access.Access.SelectData("SELECT user_id, username, email, user_level FROM users", "users").Tables("users"))
        'set currency manager
        currencyManager = CType(Me.BindingContext(view), CurrencyManager)
    End Sub
    Private Sub ClearBindings()
        For Each txt In Splitter.Panel1.Controls.OfType(Of TextBox)
            txt.DataBindings.Clear()
        Next
        Me.BindingContext = Nothing
    End Sub
    Private Sub Binding(view As DataView)
        txtUserID.DataBindings.Add("Text", view, "user_id")
        txtUsername.DataBindings.Add("Text", view, "username")
        txtEmail.DataBindings.Add("Text", view, "email")
        txtUserLevel.DataBindings.Add("Text", view, "user_level")
    End Sub
    Private Sub ShowPosition()
        ' Display the current position and the number of records
        lblPosition.Text = currencyManager.Position + 1 & " of { " & currencyManager.Count() & " }"
        'disable userid textbox if enabled by the new button
        If txtUserID.Enabled = True Then
            txtUserID.Enabled = False
        End If
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
        For Each txt In Splitter.Panel1.Controls.OfType(Of TextBox)
            txt.Clear()
        Next
        'enable user id textbox
        txtUserID.Enabled = True
    End Sub

    Private Sub UpdateUser(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'check username and email
        If txtUsername.Text = String.Empty Or
                txtEmail.Text = String.Empty Then
            MsgBox("Inavlid username/email")
            Exit Sub
        Else
            Dim username = txtUsername.Text
            Dim email = txtEmail.Text
            Dim sql = "UPDATE users SET username='" & username & "', email = '" & email & "'" &
                " WHERE user_id = " & txtUserID.Text
            'update user
            Dim updated As Integer = Access.Access.InsertData(sql)
            If updated = 1 Then
                'display message
                DisplayMessage("User details updated ...")
                'reload data
                bgWorker.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub DeleteUser(sender As Object, e As EventArgs) Handles btnDelete.Click
        'confirm delete
        Dim result As DialogResult = MessageBox.Show("User account details:" & vbNewLine & "" &
                                                    "User ID: " & txtUserID.Text & vbNewLine &
                                                     "Username: " & txtUsername.Text & vbNewLine & "" &
                                                     "Are you sure you want to delete this account?", "Confrim Deletion",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim sql As String = "DELETE FROM users WHERE user_id =" & txtUserID.Text
            'delete user
            Dim deleted As Integer = Access.Access.InsertData(sql)
            If deleted = 1 Then
                'display message
                DisplayMessage("User account deleted successfully!!")
                'reload data
                bgWorker.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub SaveUser(sender As Object, e As EventArgs) Handles btnSave.Click
        'verify fields
        If VerifyInputs() = 0 Then
            MessageBox.Show("Operation cancelled. Some fields are empty!! Please go back And enter the required data.", "Input Error")
            Exit Sub
            'verify password
        ElseIf VerifyPassword() = 0 Then
            MessageBox.Show("Operation cancelled. Passwords don't Match!! Please go back and try again.", "Input Error")
            Exit Sub
        Else
            Dim sql = "INSERT INTO users(user_id,username,email,password) VALUES(" & CType(txtUserID.Text, Integer) & ",'" & txtUsername.Text & "','" & txtEmail.Text &
                "',md5('" & txtPassword.Text & "'))"
            Dim result = Access.Access.InsertData(sql)
            'if user saved
            If result = 1 Then
                'diplay message
                DisplayMessage("User saved successfully")
                'reload data
                bgWorker.RunWorkerAsync()
            Else
                DisplayMessage("Save Failed")

            End If
        End If
    End Sub

    Private Function VerifyInputs() As Integer
        Dim valid As Integer = 1
        'check if any text box is empty
        If txtUserID.Text = String.Empty OrElse
                txtUsername.Text = String.Empty OrElse
                txtEmail.Text = String.Empty OrElse
                txtPassword.Text = String.Empty Or
                txtConfirmPassword.Text = String.Empty Then
            valid = 0
        End If
        Return valid
    End Function
    Private Function VerifyPassword() As Integer
        'check if passwords match
        If txtPassword.Text = txtConfirmPassword.Text Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub ChangePassword(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        'check if password fields are empty
        If txtPassword.Text = String.Empty Or txtConfirmPassword.Text = String.Empty Then
            txtPassword.BackColor = Color.Orange
            txtConfirmPassword.BackColor = Color.Orange
            Exit Sub
        End If
        'passwords matching
        If VerifyPassword() = 1 Then
            'change password
            Dim sql As String = "UPDATE users SET password=md5('" & txtPassword.Text & "') WHERE user_id =" & txtUserID.Text
            Dim result As Integer = Access.Access.InsertData(sql)
            If result = 1 Then
                DisplayMessage("User password chnaged successfully!!.")
                bgWorker.RunWorkerAsync()
            End If
        Else
            txtPassword.BackColor = Color.Red
            Exit Sub
        End If
    End Sub

    Private Sub UsersForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'start the background worker
        bgWorker.RunWorkerAsync()
    End Sub

    Private Sub Worker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorker.DoWork
        'load data
        LoadData()
    End Sub
    Private Sub Worker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        'clear bindings
        ClearBindings()
        'populate the gridview
        grdUsers.DataSource = Access.Access.SelectData("SELECT user_id, username, email, user_level FROM users", "users")
        grdUsers.DataMember = "users"
        'set table column names
        grdUsers.Columns("user_id").HeaderCell.Value = "User ID"
        grdUsers.Columns("username").HeaderCell.Value = "Username"
        grdUsers.Columns("email").HeaderCell.Value = "Email Address"
        If grdUsers.Rows.Count = 0 Or view.Count = 0 Then
            Exit Sub
        End If
        'data binding
        Binding(view)
        'show position
        ShowPosition()
    End Sub
    Private Sub ChangeLevel_Click(sender As Object, e As EventArgs) Handles btnChangeLevel.Click
        'get current level and selected level
        Dim currentLevel As String = txtUserLevel.Text
        Dim selectedLevel As String = cboUserLevel.SelectedItem
        'exit sub if levels are same
        If currentLevel = selectedLevel Then
            Exit Sub
        Else
            'confirm
            Dim result As DialogResult = MessageBox.Show("Changing user access level may grant/revoke services to some users." & vbNewLine & "" &
                                                         " This may paralyse opartions in the organization. Are you sure about this?", "Confirm Operation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                'change user level
                Dim sql As String = "UPDATE users SET user_level ='" & selectedLevel & "' WHERE user_id =" & txtUserID.Text
                Dim done As Integer = Access.Access.InsertData(sql)
                If done = 1 Then
                    DisplayMessage("Access level changed...")
                    bgWorker.RunWorkerAsync()
                End If
            End If
        End If
    End Sub

    Private Sub Password_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        txtConfirmPassword.BackColor = Color.White
        txtPassword.BackColor = Color.White
    End Sub
End Class