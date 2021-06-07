Imports System.Net
Imports System.Net.Mail
Public MustInherit Class EmailMasterServer
    Private smtpClient As SmtpClient
    Protected sendermail As String
    Protected password As String
    Protected host As String
    Protected port As Integer
    Protected ssl As Boolean

    Protected Sub InitializeSmtpClient()
        smtpClient = New SmtpClient With {
            .Credentials = New NetworkCredential(sendermail, password),
            .Host = host,
            .Port = port,
            .EnableSsl = ssl
        }
    End Sub

    Public Sub SendMail(subject As String, body As String, receivermail As List(Of String))
        Dim mailMessage As New MailMessage()
        Try
            mailMessage.From = New MailAddress(sendermail)
            For Each recipienteMail As String In receivermail
                mailMessage.To.Add(recipienteMail)
            Next
            With mailMessage
                .Subject = subject
                .Body = body
                .Priority = MailPriority.Normal
            End With

            smtpClient.Send(mailMessage)
        Catch ex As Exception
        Finally
            mailMessage.Dispose()
            smtpClient.Dispose()
        End Try
    End Sub
End Class
