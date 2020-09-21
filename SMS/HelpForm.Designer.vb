<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpForm))
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnSelectFiles = New System.Windows.Forms.Button()
        Me.lstAttachments = New System.Windows.Forms.ListBox()
        Me.lblAttachments = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.btnSendMail = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grpGmailConfig = New System.Windows.Forms.GroupBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.grpGmailConfig.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRemove
        '
        Me.btnRemove.Image = Global.SMS.My.Resources.Resources.close
        Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemove.Location = New System.Drawing.Point(787, 227)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(117, 35)
        Me.btnRemove.TabIndex = 25
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnSelectFiles
        '
        Me.btnSelectFiles.Image = CType(resources.GetObject("btnSelectFiles.Image"), System.Drawing.Image)
        Me.btnSelectFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelectFiles.Location = New System.Drawing.Point(787, 176)
        Me.btnSelectFiles.Name = "btnSelectFiles"
        Me.btnSelectFiles.Size = New System.Drawing.Size(117, 35)
        Me.btnSelectFiles.TabIndex = 24
        Me.btnSelectFiles.Text = "Attatch Files"
        Me.btnSelectFiles.UseVisualStyleBackColor = True
        '
        'lstAttachments
        '
        Me.lstAttachments.FormattingEnabled = True
        Me.lstAttachments.ItemHeight = 15
        Me.lstAttachments.Location = New System.Drawing.Point(516, 176)
        Me.lstAttachments.Name = "lstAttachments"
        Me.lstAttachments.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstAttachments.Size = New System.Drawing.Size(265, 259)
        Me.lstAttachments.TabIndex = 23
        '
        'lblAttachments
        '
        Me.lblAttachments.AutoSize = True
        Me.lblAttachments.Location = New System.Drawing.Point(513, 148)
        Me.lblAttachments.Name = "lblAttachments"
        Me.lblAttachments.Size = New System.Drawing.Size(80, 17)
        Me.lblAttachments.TabIndex = 22
        Me.lblAttachments.Text = "Attachments"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(20, 204)
        Me.txtSubject.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(360, 24)
        Me.txtSubject.TabIndex = 21
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(16, 178)
        Me.lblSubject.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(49, 17)
        Me.lblSubject.TabIndex = 20
        Me.lblSubject.Text = "Subject"
        '
        'btnSendMail
        '
        Me.btnSendMail.Image = CType(resources.GetObject("btnSendMail.Image"), System.Drawing.Image)
        Me.btnSendMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSendMail.Location = New System.Drawing.Point(800, 519)
        Me.btnSendMail.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSendMail.Name = "btnSendMail"
        Me.btnSendMail.Size = New System.Drawing.Size(117, 34)
        Me.btnSendMail.TabIndex = 19
        Me.btnSendMail.Text = "Send Mail"
        Me.btnSendMail.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(20, 258)
        Me.txtMessage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(360, 295)
        Me.txtMessage.TabIndex = 18
        '
        'txtTo
        '
        Me.txtTo.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtTo.Enabled = False
        Me.txtTo.Location = New System.Drawing.Point(20, 148)
        Me.txtTo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(360, 24)
        Me.txtTo.TabIndex = 17
        Me.txtTo.Text = "siranjofuw@gmail.com"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(14, 237)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(58, 17)
        Me.lblMessage.TabIndex = 15
        Me.lblMessage.Text = "Message"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(16, 119)
        Me.lblTo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(21, 17)
        Me.lblTo.TabIndex = 14
        Me.lblTo.Text = "To"
        '
        'btnClear
        '
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(787, 281)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 35)
        Me.btnClear.TabIndex = 26
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'grpGmailConfig
        '
        Me.grpGmailConfig.Controls.Add(Me.lblPassword)
        Me.grpGmailConfig.Controls.Add(Me.txtPassword)
        Me.grpGmailConfig.Controls.Add(Me.lblEmail)
        Me.grpGmailConfig.Controls.Add(Me.txtEmail)
        Me.grpGmailConfig.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpGmailConfig.Enabled = False
        Me.grpGmailConfig.Location = New System.Drawing.Point(0, 0)
        Me.grpGmailConfig.Name = "grpGmailConfig"
        Me.grpGmailConfig.Size = New System.Drawing.Size(930, 112)
        Me.grpGmailConfig.TabIndex = 27
        Me.grpGmailConfig.TabStop = False
        Me.grpGmailConfig.Text = "Gmail Configurations"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(16, 78)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(101, 17)
        Me.lblPassword.TabIndex = 29
        Me.lblPassword.Text = "Gmail Password:"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtPassword.Location = New System.Drawing.Point(123, 75)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(218, 24)
        Me.txtPassword.TabIndex = 28
        Me.txtPassword.Text = "4sirah@123"
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(15, 37)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(79, 17)
        Me.lblEmail.TabIndex = 27
        Me.lblEmail.Text = "Gmail Email:"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtEmail.Location = New System.Drawing.Point(123, 34)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(218, 24)
        Me.txtEmail.TabIndex = 26
        Me.txtEmail.Text = "jerrysirah8@gmail.com"
        '
        'HelpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(930, 566)
        Me.Controls.Add(Me.grpGmailConfig)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnSelectFiles)
        Me.Controls.Add(Me.lstAttachments)
        Me.Controls.Add(Me.lblAttachments)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.btnSendMail)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblTo)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HelpForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help Contact"
        Me.grpGmailConfig.ResumeLayout(False)
        Me.grpGmailConfig.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRemove As Button
    Friend WithEvents btnSelectFiles As Button
    Friend WithEvents lstAttachments As ListBox
    Friend WithEvents lblAttachments As Label
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents lblSubject As Label
    Friend WithEvents btnSendMail As Button
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents txtTo As TextBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents btnClear As Button
    Friend WithEvents grpGmailConfig As GroupBox
    Private WithEvents lblPassword As Label
    Private WithEvents txtPassword As TextBox
    Private WithEvents lblEmail As Label
    Private WithEvents txtEmail As TextBox
End Class
