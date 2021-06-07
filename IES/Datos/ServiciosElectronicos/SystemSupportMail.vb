Public Class SystemSupportMail
    Inherits EmailMasterServer
    Public a As Integer = 1
    'Constructor
    Public Sub New()
        Dim usrModel As New UsrMod
        Dim validLog = usrModel.Correo(a)
        If validLog = True Then
            sendermail = Correo
            password = passw
            host = "smtp.gmail.com"
            port = 587
            ssl = True
            InitializeSmtpClient()
        End If
    End Sub

    Public Sub Notification()
        'sendermail = "xaello57@gmail.com"
        'password = "Em123axel"
    End Sub
    Public Sub Errors()

    End Sub
End Class
