Public Class Ayuda

#Region "Open_other_forms"
    Private Sub AbFormPanel(ByVal FormHijo As Object)
        Try
            If Panel_contenedor.Controls.Count > 0 Then
                Panel_contenedor.Controls.RemoveAt(0)
            End If
            Dim fh As Form = TryCast(FormHijo, Form)
            fh.TopLevel = False
            fh.FormBorderStyle = FormBorderStyle.None
            fh.Dock = DockStyle.Fill
            Panel_contenedor.Controls.Add(fh)
            Panel_contenedor.Tag = fh
            fh.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Btn_pnl"
    Private Sub Btn_Inventario_Click(sender As Object, e As EventArgs) Handles Btn_Inventario.Click
        Dim ayinv As New Ayuda_Inventario
        Try
            AbFormPanel(ayinv)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try

    End Sub
    Private Sub Btn_Usr_Click(sender As Object, e As EventArgs) Handles Btn_Usr.Click
        Dim ayusu As New Ayuda_Usuarios
        Try
            AbFormPanel(ayusu)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try

    End Sub
    Private Sub Btn_Prestamos_Click(sender As Object, e As EventArgs) Handles Btn_Prestamos.Click
        Dim aypres As New Ayuda_Prestamos
        Try
            AbFormPanel(aypres)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try

    End Sub
    Private Sub Btn_Correo_Click(sender As Object, e As EventArgs) Handles Btn_Correo.Click
        Dim aycorreo As New Ayuda_Correo
        Try
            AbFormPanel(aycorreo)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try

    End Sub

    Private Sub Pctb_salir_Click(sender As Object, e As EventArgs) Handles Pctb_salir.Click
        Close()
    End Sub
#End Region

End Class