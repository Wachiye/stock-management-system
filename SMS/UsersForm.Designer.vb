<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsersForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Splitter = New System.Windows.Forms.SplitContainer()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.btnChangeLevel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.cboUserLevel = New System.Windows.Forms.ComboBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblNewLevel = New System.Windows.Forms.Label()
        Me.btnMoveNext = New System.Windows.Forms.Button()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtUserLevel = New System.Windows.Forms.TextBox()
        Me.btnMoveLast = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnMovePrevious = New System.Windows.Forms.Button()
        Me.lblUserLevel = New System.Windows.Forms.Label()
        Me.btnMoveFirst = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.grdUsers = New System.Windows.Forms.DataGridView()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        CType(Me.Splitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Splitter.Panel1.SuspendLayout()
        Me.Splitter.Panel2.SuspendLayout()
        Me.Splitter.SuspendLayout()
        CType(Me.grdUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Splitter
        '
        Me.Splitter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Splitter.Location = New System.Drawing.Point(0, 0)
        Me.Splitter.Name = "Splitter"
        Me.Splitter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Splitter.Panel1
        '
        Me.Splitter.Panel1.Controls.Add(Me.btnChangePassword)
        Me.Splitter.Panel1.Controls.Add(Me.lblUserID)
        Me.Splitter.Panel1.Controls.Add(Me.lblPosition)
        Me.Splitter.Panel1.Controls.Add(Me.btnChangeLevel)
        Me.Splitter.Panel1.Controls.Add(Me.btnUpdate)
        Me.Splitter.Panel1.Controls.Add(Me.lblUsername)
        Me.Splitter.Panel1.Controls.Add(Me.btnDelete)
        Me.Splitter.Panel1.Controls.Add(Me.cboUserLevel)
        Me.Splitter.Panel1.Controls.Add(Me.btnNew)
        Me.Splitter.Panel1.Controls.Add(Me.lblEmail)
        Me.Splitter.Panel1.Controls.Add(Me.btnSave)
        Me.Splitter.Panel1.Controls.Add(Me.lblNewLevel)
        Me.Splitter.Panel1.Controls.Add(Me.btnMoveNext)
        Me.Splitter.Panel1.Controls.Add(Me.txtUserID)
        Me.Splitter.Panel1.Controls.Add(Me.txtUserLevel)
        Me.Splitter.Panel1.Controls.Add(Me.btnMoveLast)
        Me.Splitter.Panel1.Controls.Add(Me.txtUsername)
        Me.Splitter.Panel1.Controls.Add(Me.btnMovePrevious)
        Me.Splitter.Panel1.Controls.Add(Me.lblUserLevel)
        Me.Splitter.Panel1.Controls.Add(Me.btnMoveFirst)
        Me.Splitter.Panel1.Controls.Add(Me.lblPassword)
        Me.Splitter.Panel1.Controls.Add(Me.txtConfirmPassword)
        Me.Splitter.Panel1.Controls.Add(Me.txtEmail)
        Me.Splitter.Panel1.Controls.Add(Me.txtPassword)
        Me.Splitter.Panel1.Controls.Add(Me.lblConfirmPassword)
        '
        'Splitter.Panel2
        '
        Me.Splitter.Panel2.Controls.Add(Me.grdUsers)
        Me.Splitter.Size = New System.Drawing.Size(841, 574)
        Me.Splitter.SplitterDistance = 390
        Me.Splitter.TabIndex = 0
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnChangePassword.Location = New System.Drawing.Point(639, 220)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(137, 34)
        Me.btnChangePassword.TabIndex = 81
        Me.btnChangePassword.Text = "Change &Password"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'lblUserID
        '
        Me.lblUserID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Location = New System.Drawing.Point(57, 55)
        Me.lblUserID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(50, 17)
        Me.lblUserID.TabIndex = 73
        Me.lblUserID.Text = "User ID"
        '
        'lblPosition
        '
        Me.lblPosition.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(401, 290)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(55, 17)
        Me.lblPosition.TabIndex = 72
        Me.lblPosition.Text = "0 Of { 0 }"
        '
        'btnChangeLevel
        '
        Me.btnChangeLevel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnChangeLevel.Location = New System.Drawing.Point(486, 223)
        Me.btnChangeLevel.Name = "btnChangeLevel"
        Me.btnChangeLevel.Size = New System.Drawing.Size(137, 34)
        Me.btnChangeLevel.TabIndex = 80
        Me.btnChangeLevel.Text = "Change Access &Level"
        Me.btnChangeLevel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.Image = Global.SMS.My.Resources.Resources.update
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(433, 329)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(102, 43)
        Me.btnUpdate.TabIndex = 71
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(57, 102)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(66, 17)
        Me.lblUsername.TabIndex = 60
        Me.lblUsername.Text = "Username"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.Image = Global.SMS.My.Resources.Resources.close
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(557, 329)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(102, 43)
        Me.btnDelete.TabIndex = 70
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'cboUserLevel
        '
        Me.cboUserLevel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboUserLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboUserLevel.FormattingEnabled = True
        Me.cboUserLevel.Items.AddRange(New Object() {"System User", "Administrator"})
        Me.cboUserLevel.Location = New System.Drawing.Point(530, 96)
        Me.cboUserLevel.Name = "cboUserLevel"
        Me.cboUserLevel.Size = New System.Drawing.Size(216, 23)
        Me.cboUserLevel.TabIndex = 79
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.Image = Global.SMS.My.Resources.Resources._new
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(185, 329)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(102, 43)
        Me.btnNew.TabIndex = 69
        Me.btnNew.Text = " New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(57, 149)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(39, 17)
        Me.lblEmail.TabIndex = 61
        Me.lblEmail.Text = "Email"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.Image = Global.SMS.My.Resources.Resources.save
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(309, 329)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 43)
        Me.btnSave.TabIndex = 59
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblNewLevel
        '
        Me.lblNewLevel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNewLevel.AutoSize = True
        Me.lblNewLevel.Location = New System.Drawing.Point(442, 96)
        Me.lblNewLevel.Name = "lblNewLevel"
        Me.lblNewLevel.Size = New System.Drawing.Size(34, 17)
        Me.lblNewLevel.TabIndex = 78
        Me.lblNewLevel.Text = "New"
        '
        'btnMoveNext
        '
        Me.btnMoveNext.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMoveNext.AutoSize = True
        Me.btnMoveNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMoveNext.FlatAppearance.BorderSize = 0
        Me.btnMoveNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoveNext.Image = Global.SMS.My.Resources.Resources.go_forward
        Me.btnMoveNext.Location = New System.Drawing.Point(485, 284)
        Me.btnMoveNext.Name = "btnMoveNext"
        Me.btnMoveNext.Size = New System.Drawing.Size(30, 30)
        Me.btnMoveNext.TabIndex = 68
        Me.btnMoveNext.UseVisualStyleBackColor = True
        '
        'txtUserID
        '
        Me.txtUserID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUserID.BackColor = System.Drawing.SystemColors.Window
        Me.txtUserID.Enabled = False
        Me.txtUserID.Location = New System.Drawing.Point(185, 55)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(216, 24)
        Me.txtUserID.TabIndex = 54
        '
        'txtUserLevel
        '
        Me.txtUserLevel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUserLevel.Location = New System.Drawing.Point(530, 52)
        Me.txtUserLevel.Name = "txtUserLevel"
        Me.txtUserLevel.Size = New System.Drawing.Size(216, 24)
        Me.txtUserLevel.TabIndex = 77
        '
        'btnMoveLast
        '
        Me.btnMoveLast.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMoveLast.AutoSize = True
        Me.btnMoveLast.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMoveLast.FlatAppearance.BorderSize = 0
        Me.btnMoveLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoveLast.Image = Global.SMS.My.Resources.Resources.last_recor
        Me.btnMoveLast.Location = New System.Drawing.Point(523, 284)
        Me.btnMoveLast.Name = "btnMoveLast"
        Me.btnMoveLast.Size = New System.Drawing.Size(30, 30)
        Me.btnMoveLast.TabIndex = 67
        Me.btnMoveLast.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsername.BackColor = System.Drawing.SystemColors.Window
        Me.txtUsername.Location = New System.Drawing.Point(185, 102)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(216, 24)
        Me.txtUsername.TabIndex = 55
        '
        'btnMovePrevious
        '
        Me.btnMovePrevious.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMovePrevious.AutoSize = True
        Me.btnMovePrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMovePrevious.FlatAppearance.BorderSize = 0
        Me.btnMovePrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMovePrevious.Image = Global.SMS.My.Resources.Resources.go_back
        Me.btnMovePrevious.Location = New System.Drawing.Point(347, 284)
        Me.btnMovePrevious.Name = "btnMovePrevious"
        Me.btnMovePrevious.Size = New System.Drawing.Size(30, 30)
        Me.btnMovePrevious.TabIndex = 66
        Me.btnMovePrevious.UseVisualStyleBackColor = True
        '
        'lblUserLevel
        '
        Me.lblUserLevel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUserLevel.AutoSize = True
        Me.lblUserLevel.Location = New System.Drawing.Point(439, 55)
        Me.lblUserLevel.Name = "lblUserLevel"
        Me.lblUserLevel.Size = New System.Drawing.Size(51, 17)
        Me.lblUserLevel.TabIndex = 76
        Me.lblUserLevel.Text = "Current"
        '
        'btnMoveFirst
        '
        Me.btnMoveFirst.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMoveFirst.AutoSize = True
        Me.btnMoveFirst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMoveFirst.FlatAppearance.BorderSize = 0
        Me.btnMoveFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoveFirst.Image = Global.SMS.My.Resources.Resources.first_record
        Me.btnMoveFirst.Location = New System.Drawing.Point(309, 284)
        Me.btnMoveFirst.Name = "btnMoveFirst"
        Me.btnMoveFirst.Size = New System.Drawing.Size(30, 30)
        Me.btnMoveFirst.TabIndex = 65
        Me.btnMoveFirst.UseVisualStyleBackColor = True
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(57, 199)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(61, 17)
        Me.lblPassword.TabIndex = 62
        Me.lblPassword.Text = "Password"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtConfirmPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtConfirmPassword.Location = New System.Drawing.Point(185, 230)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(216, 24)
        Me.txtConfirmPassword.TabIndex = 58
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.Location = New System.Drawing.Point(185, 149)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(216, 24)
        Me.txtEmail.TabIndex = 56
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtPassword.Location = New System.Drawing.Point(185, 196)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(216, 24)
        Me.txtPassword.TabIndex = 57
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Location = New System.Drawing.Point(57, 233)
        Me.lblConfirmPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(108, 17)
        Me.lblConfirmPassword.TabIndex = 63
        Me.lblConfirmPassword.Text = "Confirm Password"
        '
        'grdUsers
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.grdUsers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdUsers.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grdUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdUsers.Location = New System.Drawing.Point(60, 3)
        Me.grdUsers.Name = "grdUsers"
        Me.grdUsers.Size = New System.Drawing.Size(721, 165)
        Me.grdUsers.TabIndex = 0
        '
        'bgWorker
        '
        Me.bgWorker.WorkerReportsProgress = True
        Me.bgWorker.WorkerSupportsCancellation = True
        '
        'UsersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(841, 574)
        Me.Controls.Add(Me.Splitter)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "UsersForm"
        Me.Text = "Users"
        Me.Splitter.Panel1.ResumeLayout(False)
        Me.Splitter.Panel1.PerformLayout()
        Me.Splitter.Panel2.ResumeLayout(False)
        CType(Me.Splitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Splitter.ResumeLayout(False)
        CType(Me.grdUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Splitter As SplitContainer
    Friend WithEvents btnChangeLevel As Button
    Friend WithEvents cboUserLevel As ComboBox
    Friend WithEvents lblNewLevel As Label
    Friend WithEvents txtUserLevel As TextBox
    Friend WithEvents lblUserLevel As Label
    Friend WithEvents lblUserID As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents lblPosition As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnMoveNext As Button
    Friend WithEvents btnMoveLast As Button
    Friend WithEvents btnMovePrevious As Button
    Friend WithEvents btnMoveFirst As Button
    Friend WithEvents grdUsers As DataGridView
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
End Class
