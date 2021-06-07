Public Class RecvoverPass

#Region "MSR"
    Private Sub Pctb_salir_Click(sender As Object, e As EventArgs) Handles pctb_salir.Click
        Try
            If MessageBox.Show("Estás seguro de cerrar la aplicación?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Application.Exit()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Pctb_minimizar_Click(sender As Object, e As EventArgs) Handles pctb_minimizar.Click
        Try
            WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_regresar_Click(sender As Object, e As EventArgs) Handles Btn_regresar.Click
        Try
            Login.Show()
            Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Botón recuperar"
    Private Sub Btn_ingresar_Click(sender As Object, e As EventArgs) Handles Btn_recuperar.Click
        Try
            recover()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Txt_recuperar_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_recuperar.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                recover()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Método"
    Sub recover()
        Try
            Dim usrModel As New UsrMod()
            Dim result = usrModel.RecoverPassword(Txt_recuperar.Text)
            Lbl_Result.Visible = True
            Lbl_Result.Text = result
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

End Class