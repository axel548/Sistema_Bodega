Public Class CopyANDPaste
    Partial Public Class Mitexto
        Inherits TextBox
        Private Const WM_COPY As Integer = &H301
        Private Const WM_PASTE As Integer = &H302

        <System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name:="FullTrust")>
        Protected Overloads Overrides Sub WndProc(ByRef m As Message)
            Select Case m.Msg
                Case WM_PASTE, WM_COPY
                    Return
            End Select
            MyBase.WndProc(m)
        End Sub

    End Class

End Class
