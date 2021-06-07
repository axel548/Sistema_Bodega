Public Class Configuración

#Region "Load"
    Private Sub Configuración_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Validar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "botones"
    Private Sub Pctb_salir_Click(sender As Object, e As EventArgs) Handles Pctb_salir.Click
        Close()
    End Sub
#End Region

#Region "Correo Eléctronico"
#Region "Variables"
    Private ent As New Entdad
    Private func As New DAtos
    Public a As Integer = 1
#End Region

#Region "Botones"
    Private Sub Btn_recuperar_Click(sender As Object, e As EventArgs) Handles Btn_recuperar.Click
        Try
            Actu()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Metodo"
    Private Sub Actu()
        Try
            If ValidateChildren() = True And Txt_correo.Text <> "" And Txt_Contra.Text <> "" Then
                ent.Email = Txt_correo.Text
                ent.Passw = Txt_Contra.Text
                ent.Id = a
                If func.ActualizarCorreo(ent) Then
                    MsgBox("Actualizado Correctamente.")
                    Validar()
                    Txt_correo.Clear()
                    Txt_Contra.Clear()
                End If
            Else
                MsgBox("Lastima, Intentalo de nuevo.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Validar()
        Try
            Dim usrModel As New UsrMod
            Dim validLog = usrModel.Correo(a)
            If validLog = True Then
                Lbl_ce.Text = correo
                Lbl_ct.Text = passw
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#End Region

#Region "Ayuda"
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
    Private Sub Btn_Correo_Click(sender As Object, e As EventArgs) Handles Btn_Correos.Click
        Dim aycorreo As New Ayuda_Correo
        Try
            AbFormPanel(aycorreo)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region
#Region "Open_other_forms"
    Private Sub AbFormPanel(ByVal FormHijo As Object)
        Try
            If Panel_Contenedor.Controls.Count > 0 Then
                Panel_Contenedor.Controls.RemoveAt(0)
            End If
            Dim fh As Form = TryCast(FormHijo, Form)
            fh.TopLevel = False
            fh.FormBorderStyle = FormBorderStyle.None
            fh.Dock = DockStyle.Fill
            Panel_Contenedor.Controls.Add(fh)
            Panel_Contenedor.Tag = fh
            fh.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#End Region

#Region "Métodos"

#End Region

End Class