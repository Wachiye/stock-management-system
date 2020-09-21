Imports System.Net
Imports System.Net.Mail

Public Class HelpForm

    Private Sub SendMail(sender As Object, e As EventArgs) Handles btnSendMail.Click
        Try
            Using mm As New MailMessage(txtEmail.Text.Trim(), txtTo.Text.Trim())
                mm.Subject = txtSubject.Text
                mm.Body = txtMessage.Text
                AddAttachments(mm)
                mm.IsBodyHtml = False
                Dim smtp As New SmtpClient()
                smtp.Host = "smtp.gmail.com"
                smtp.EnableSsl = True
                Dim NetworkCred As New NetworkCredential(txtEmail.Text.Trim(), txtPassword.Text.Trim())
                smtp.UseDefaultCredentials = True
                smtp.Credentials = NetworkCred
                smtp.Port = 587
                smtp.Send(mm)
                MessageBox.Show("Email sent.", "Message")
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub AddAttachments(email As MailMessage)
        If lstAttachments.Items.Count > 0 Then
            For Each attachment In lstAttachments.Items
                email.Attachments.Add(New Attachment(attachment.ToString))
            Next
        End If
    End Sub
    Private Sub SelectFiles(sender As Object, e As EventArgs) Handles btnSelectFiles.Click
        'open file displag box
        Dim results As DialogResult = OpenFileDialog.ShowDialog
        If results = DialogResult.OK Then
            Dim files As Array = OpenFileDialog.FileNames
            For Each file In files
                lstAttachments.Items.Add(file)
            Next
        End If
    End Sub

    Private Sub RemoveAllAttachments(sender As Object, e As EventArgs) Handles btnClear.Click
        lstAttachments.Items.Clear()
    End Sub

    Private Sub RemoveAttachment(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim items As New Collection
        For Each attachment In lstAttachments.SelectedItems
            items.Add(attachment)
        Next
        For Each item In items
            lstAttachments.Items.Remove(item)
        Next
    End Sub

End Class