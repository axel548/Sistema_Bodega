Public Class SubForm_Inventario
#Region "Variables"
    Dim elec As String
#End Region

#Region "Load"
    Private Sub SubForm_Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "C"
    Private Sub Pctb_salir_Click(sender As Object, e As EventArgs) Handles Pctb_salir.Click
        Try
            Close()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Data"
    Private Sub Dgv_SubInv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_SubInv.CellDoubleClick
        Try
            Dim frm As Prestamos = CType(Owner, Prestamos)
            frm.txt_codigo.Text = Dgv_SubInv.CurrentRow.Cells(0).Value.ToString
            frm.txt_nomHerr.Text = Dgv_SubInv.CurrentRow.Cells(1).Value.ToString
            frm.cantidad = CInt(Dgv_SubInv.CurrentRow.Cells(2).Value.ToString)
            frm.estado = Dgv_SubInv.CurrentRow.Cells(4).Value.ToString

            Close()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "ComboBox"
    Private Sub Cb_Eleccion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Eleccion.SelectedIndexChanged
        Try
            If Cb_Eleccion.Text = "Activo" Then
                MostrarDatos("View_InerAc")
                elec = "View_InerAc"
            ElseIf Cb_Eleccion.Text = "Reserva" Then
                MostrarDatos("View_InerRe")
                elec = "View_InerRe"
            ElseIf Cb_Eleccion.Text = "Mal Estado" Then
                MostrarDatos("View_InerME")
                elec = "View_InerME"
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Cb_categoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_categoria.SelectedIndexChanged
        Try
            If Cb_categoria.Text = "Computación" Then
                Cb_Subcate.Items.Clear()
                Cb_Subcate.Items.Add("Sonido")
                Cb_Subcate.Items.Add("Mantenimiento")
                Cb_Subcate.Items.Add("Equipos")
                Cb_Subcate.Items.Add("Tarjetas de video")
                Cb_Subcate.Items.Add("Complementos")
                Cb_Subcate.Items.Add("Impresoras")
                busqueda()
            ElseIf Cb_categoria.Text = "Eléctronica" Then
                Cb_Subcate.Items.Clear()
                Cb_Subcate.Items.Add("Soldadoras")
                Cb_Subcate.Items.Add("Protoboards")
                Cb_Subcate.Items.Add("MotherBoards")
                busqueda()
            ElseIf Cb_categoria.Text = "Electricidad" Then
                Cb_Subcate.Items.Clear()
                Cb_Subcate.Items.Add("Cascos")
                Cb_Subcate.Items.Add("Electricidad")
                busqueda()
            ElseIf Cb_categoria.Text = "Dibujo Técnico" Then
                Cb_Subcate.Items.Clear()
                Cb_Subcate.Items.Add("Reglas")
                Cb_Subcate.Items.Add("Tableros")
                busqueda()
            ElseIf Cb_categoria.Text = "Mecánica" Then
                Cb_Subcate.Items.Clear()
                Cb_Subcate.Items.Add("Cajas")
                Cb_Subcate.Items.Add("Enderezado")
                Cb_Subcate.Items.Add("Pintura")
                busqueda()
            ElseIf Cb_categoria.Text = "Varios" Then
                Cb_Subcate.Enabled = False
                Cb_Subcate.Items.Clear()
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Cb_Subcate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Subcate.SelectedIndexChanged
        Try
            If Cb_Subcate.Text = Cb_Subcate.Text Then
                Dim sql As String = "select codigo as Código, nombre as Nombre, cant as Cantidad, imagen as Foto, estado as Estado, categoría as Categoría, sub_cat as Sub-Categoría from " + elec + " where categoría like '" & "%" + Cb_categoria.Text + "%" & "' and  sub_cat like '" & "%" + Cb_Subcate.Text + "%" & "'"
                Dim usr As New UsrMod
                Dim cons = usr.Consulta(Dgv_SubInv, sql)
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Métodos"
    Sub MostrarDatos(table As String)
        Try
            Dim sql As String = "select codigo, nombre, cant, imagen, estado, categoría, sub_cat from " & table
            Dim usr As New UsrMod
            Dim cons = usr.Consulta(Dgv_SubInv, sql)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Sub busqueda()
        Try
            Dim sql As String = "select codigo, nombre, cant, imagen, estado, categoría, sub_cat from " + elec + " where categoría = '" & Cb_categoria.Text & "'"
            Dim usr As New UsrMod
            Dim cons = usr.Consulta(Dgv_SubInv, sql)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region
End Class