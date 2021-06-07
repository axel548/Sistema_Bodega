Imports System.IO
Public Class Inventario
#Region "Variables"
    Public ent As New Entdad
    Public Func As New DAtos
    Public a, b, c As Integer
    Public z As Integer = 0
    Dim n As Integer = 0
    Dim dec As Integer
#End Region

#Region "Load"
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet1.View_InerME' Puede moverla o quitarla según sea necesario.
            Me.View_InerMETableAdapter.Fill(Me.BodegaDataSet1.View_InerME)
            'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet1.View_InerRe' Puede moverla o quitarla según sea necesario.
            Me.View_InerReTableAdapter.Fill(Me.BodegaDataSet1.View_InerRe)
            'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet1.View_InerAc' Puede moverla o quitarla según sea necesario.
            Me.View_InerAcTableAdapter.Fill(Me.BodegaDataSet1.View_InerAc)
            OpenFileDialog1.Filter = "Todos(*.Jpg, * .Png, * .Gif, * .Tiff, * .Jpeg, * .Bmp)|*.Jpg; *.Png; *.Gif; *.Tiff; *.Jpeg; *.Bmp"
            Cb_estado.SelectedItem = "[Ninguno]"
            Cb_categoria.SelectedItem = "[Ninguno]"
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Botones"
    'Salir
    Private Sub Pctb_salir_Click(sender As Object, e As EventArgs) Handles Pctb_salir.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    'Insertar Imagen
    Private Sub Bf_btnIngresarImagen_Click(sender As Object, e As EventArgs) Handles Btn_InsertImage.Click
        Try
            'Objeto para abrir las imagenes y pasar la dirección a un label
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Pctb_imagen.Image = Image.FromFile(OpenFileDialog1.FileName)
                lbl_image.Text = OpenFileDialog1.FileName.ToString
                Pctb_imagen.Image = System.Drawing.Image.FromFile(lbl_image.Text)
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    'Ayuda
    Private Sub Pctb_Ayuda_Click(sender As Object, e As EventArgs) Handles Pctb_Ayuda.Click
        Dim frm As New Ayuda
        Try
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        Finally
            frm.Dispose()
        End Try
    End Sub
#End Region

#Region "Generar-Reporte"
    Private Sub Btn_generarCodigo_Click(sender As Object, e As EventArgs) Handles Btn_generarCodigo.Click
        dec = 2
        Dim codigoEstateWrong As String = CStr(Txt_CodEstateWrong.Text)
        Dim reportHI As New Reporte
        reportHI.codigo = codigoEstateWrong
        reportHI.dec = dec

        reportHI.ShowDialog()
    End Sub
#End Region

#Region "CRUD"
    'Página 2
    'Mostrar
    Private Sub Bf_btnMostrar_Click(sender As Object, e As EventArgs) Handles Btn_MostrarActives.Click
        'Botón para mostrar datos en la Datagridview
        Try
            MostrarDatos(Dgv_invActives, "View_InerAc")
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Btn_MostrarReservs_Click(sender As Object, e As EventArgs) Handles Btn_MostrarReservs.Click
        'Botón para mostrar datos en la Datagridview
        Try
            MostrarDatos(Dgv_invReservs, "View_InerRe")
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Btn_MostrarEstateWrong_Click(sender As Object, e As EventArgs) Handles Btn_MostrarEstateWrong.Click
        'Botón para mostrar datos en la Datagridview
        Try
            MostrarDatos(Dgv_invEstateWrong, "View_InerME")
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub

    'Página 1
    'Actualizar
    Private Sub Bf_btnModif_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        'Botón para Modificar los datos por medio de una Función y Procedimiento Almacenado, Revisar la Clase DAtos
        Try
            If ValidateChildren() = True And Txt_nomHerr.Text <> "" And Txt_cantHerr.Text <> "" And Txt_preUnit.Text <> "" And Txt_total.Text <> "" And Cb_categoria.Text <> "" And Cb_estado.Text <> "" Then
                If Cb_estado.Text = "Activo" Then
                    Actua()
                    If Func.RUAC(ent) Then
                        actualizado(Dgv_invActives, "View_InerAc")
                    End If
                ElseIf Cb_estado.Text = "Reserva" Then
                    Actua()
                    If Func.RURE(ent) Then
                        actualizado(Dgv_invReservs, "View_InerRe")
                    End If
                ElseIf Cb_estado.Text = "Mal Estado" Then
                    Actua()
                    If Func.RUME(ent) Then
                        actualizado(Dgv_invEstateWrong, "View_InerME")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub

    'Cancelar
    Private Sub Bf_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Try
            z = 0
            n = 0
            Txt_codigo.Focus()
            Txt_codigo.Enabled = True
            Btn_Actualizar.Visible = False
            Btn_Add.Visible = True
            Btn_Cancelar.Visible = False
            Btn_Limpiar.Enabled = True
            Cb_estado.Enabled = True
            Cb_estado.SelectedItem = "[Ninguno]"
            Cb_categoria.SelectedItem = "[Ninguno]"
            Cb_Subcate.Enabled = False
            Cb_categoria.Enabled = False
            Limpieza()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub

    'Insertar
    Private Sub Bf_btnAdd_Click_1(sender As Object, e As EventArgs) Handles Btn_Add.Click
        'Botón utilizado para la insertado de los datos por medio de una Función y un Procedimiento Almacenado
        'ent es utilizado como una instaciación de la clase Entdad
        Try
            If ValidateChildren() = True And Txt_codigo.Text <> "" And Txt_nomHerr.Text <> "" And Txt_cantHerr.Text <> "" And Txt_preUnit.Text <> "" And Txt_total.Text <> "" And Cb_categoria.Text <> "" And Cb_estado.Text <> "" Then
                If Cb_estado.Text = "Activo" And Txt_codigo.Text = Func.ACTIVO() Then
                    Inser()
                    If Func.RIAC(ent) Then
                        guardado(Dgv_invActives, "View_InerAc")
                    End If
                ElseIf Cb_estado.Text = "Reserva" And Txt_codigo.Text = Func.RESERVA() Then
                    Inser()
                    If Func.RIRE(ent) Then
                        guardado(Dgv_invReservs, "View_InerRe")
                    End If
                ElseIf Cb_estado.Text = "Mal Estado" And Txt_codigo.Text = Func.MALESTADO() Then
                    Inser()
                    If Func.RIME(ent) Then
                        guardado(Dgv_invEstateWrong, "View_InerME")
                    End If
                End If
            Else
                MessageBox.Show("Existen Campos vacíos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Faltante()
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub

    'Limpiar
    Private Sub Bf_btnLimpiar_Click(sender As Object, e As EventArgs) Handles Btn_Limpiar.Click
        'Botón para limpiar los demás  textboxs y otros elementos
        Try
            z = 1
            Limpieza()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub

    'TC_EstateWrong
    Private Sub Btn_Delet_Click(sender As Object, e As EventArgs) Handles Btn_Delet.Click
        Dim princ As New principal
        Try
            If Txt_CodEstateWrong.Text <> "" Then
                princ.Btn_Inventario.Enabled = False
                princ.Btn_Usr.Enabled = False
                princ.Btn_Prestamos.Enabled = False
                princ.Btn_Pendientes.Enabled = False
                princ.Btn_Solvencias.Enabled = False
                princ.Pctb_settings.Enabled = False
                princ.Pctb_Agenda.Enabled = False
                princ.Pctb_salir.Enabled = False
                princ.Btn_CierrSesi.Enabled = False
                Txt_nomHerr.Text = Dgv_invEstateWrong.CurrentRow.Cells(1).Value.ToString

                Txt_cantHerr.Text = Dgv_invEstateWrong.CurrentRow.Cells(3).Value.ToString
                Txt_preUnit.Text = Dgv_invEstateWrong.CurrentRow.Cells(4).Value.ToString
                Txt_total.Text = Dgv_invEstateWrong.CurrentRow.Cells(5).Value.ToString

                Txt_exists.Text = Dgv_invEstateWrong.CurrentRow.Cells(7).Value.ToString
                Txt_obser.Text = Dgv_invEstateWrong.CurrentRow.Cells(8).Value.ToString
                Cb_categoria.Text = Dgv_invEstateWrong.CurrentRow.Cells(9).Value.ToString
                Cb_Subcate.Text = Dgv_invEstateWrong.CurrentRow.Cells(10).Value.ToString

                Dim sql As String = "delete from usuarios where codigo=" + Txt_CodEstateWrong.Text
                Dim usr As New UsrMod
                Dim cons = usr.Consulta(Dgv_invEstateWrong, sql)
                Limpieza()
                MostrarDatos(Dgv_invEstateWrong, "View_InerME")
            Else
                MsgBox("Elija un Producto a Cambiar")
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try

    End Sub
    Private Sub Cb_categoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_categoria.SelectedIndexChanged
        If Cb_categoria.SelectedItem IsNot "[Ninguno]" Then
            AddCombobox(Cb_categoria, Cb_Subcate)
            Cb_Subcate.Enabled = True
        ElseIf Cb_categoria.SelectedItem Is "[Ninguno]" Then
            Cb_Subcate.Items.Clear()
            Cb_Subcate.Enabled = False
        End If
    End Sub
    Private Sub Cb_estado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_estado.SelectedIndexChanged
        Try
            If n = 0 Then
                If Cb_estado.Text = "Activo" Then
                    Txt_codigo.Text = Func.ACTIVO()
                    ManipulaciondeBotones()
                    Cb_categoria.Enabled = True
                ElseIf Cb_estado.Text = "Reserva" Then
                    Txt_codigo.Text = Func.RESERVA()
                    ManipulaciondeBotones()
                    Cb_categoria.Enabled = True
                ElseIf Cb_estado.Text = "Mal Estado" Then
                    Txt_codigo.Text = Func.MALESTADO()
                    ManipulaciondeBotones()
                    Cb_categoria.Enabled = True
                ElseIf Cb_estado.SelectedItem Is "[Ninguno]" Then
                    Cb_categoria.Enabled = False
                    Cb_categoria.SelectedItem = "[Ninguno]"
                End If
            ElseIf n = 1 Then
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Data"
    Private Sub Dgv_inv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_invActives.CellDoubleClick
        'Evento Dobleclick en la Datagridview, y un método llamado DAT()
        Try
            If MessageBox.Show("¿Desea modificar la fila?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                DATA(Dgv_invActives)
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Dgv_malesta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_invEstateWrong.CellDoubleClick
        'Evento Dobleclick en la Datagridview, y un método llamado DAT()
        Try
            If MessageBox.Show("¿Desea modificar la fila?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Txt_CodEstateWrong.Text = Dgv_invEstateWrong.CurrentRow.Cells(0).Value.ToString
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Dgv_rese_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_invReservs.CellDoubleClick
        'Evento Dobleclick en la Datagridview, y un método llamado DAT()
        Try
            If MessageBox.Show("¿Desea modificar la fila?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                DATA(Dgv_invReservs)
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Eventos"
    'Eventos tipo KeyPress, para evitar errores en los textbox, etc
    Private Sub Txt_codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_codigo.KeyPress
        Try
            If Char.IsWhiteSpace(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permite espacios")
            ElseIf Char.IsSymbol(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permiten Simbolos")
            ElseIf Char.IsPunctuation(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permiten Simbolos")
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try

    End Sub
    Private Sub Txt_nomHerr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_nomHerr.KeyPress
        Try
            If Char.IsSymbol(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permiten Simbolos")
            ElseIf Char.IsPunctuation(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permiten Simbolos")
            ElseIf Char.IsNumber(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permiten Números")
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try

    End Sub
    Private Sub Txt_cantHerr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_cantHerr.KeyPress
        Try
            If Char.IsSymbol(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permiten Simbolos")
            ElseIf Char.IsPunctuation(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permiten Simbolos")
            ElseIf Char.IsLetter(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permite Letras")
            ElseIf Char.IsWhiteSpace(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permite Espacios")
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try

    End Sub
    Private Sub Txt_preUnit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_preUnit.KeyPress
        Try
            If Char.IsSymbol(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permiten Simbolos")
            ElseIf Char.IsLetter(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permite Letras")
            ElseIf Char.IsWhiteSpace(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permite Espacios")
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Txt_total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_total.KeyPress
        Try
            If Char.IsSymbol(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permiten Simbolos")
            ElseIf Char.IsPunctuation(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permiten Simbolos")
            ElseIf Char.IsLetter(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permite Letras")
            ElseIf Char.IsWhiteSpace(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permite Espacios")
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Txt_obser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_obser.KeyPress
        Try
            If Char.IsSymbol(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permite Espacios")
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "ComboBox-Cantidad y Precio"
    'Región creada para resguardar las operaciones de los Textbox(Cantidad,precio = total) en tiempo de ejecución 
    Private Sub Txt_cantHerr_TextChanged(sender As Object, e As EventArgs) Handles Txt_cantHerr.TextChanged
        Dim a As Integer, b As Double
        On Error Resume Next
        If IsNumeric(Txt_cantHerr.Text) And CInt(Txt_cantHerr.Text) > 0 Then
            a = CInt(Txt_cantHerr.Text)
            Txt_exists.Text = "Existencias"
            Txt_exists.Visible = True
        ElseIf IsNumeric(Txt_cantHerr.Text) And CInt(Txt_cantHerr.Text) = 0 Then
            a = CInt(Txt_cantHerr.Text)
            Txt_exists.Text = "Sin existencias"
            Txt_exists.Visible = True
        ElseIf Txt_cantHerr.Text Is Nothing And Txt_cantHerr.Text = "" Then
            Txt_exists.Text = ""
            Txt_exists.Visible = False
        Else
            MsgBox("Ingrese Números positivos")
        End If
        If IsNumeric(Txt_preUnit.Text) Then b = CDec(Txt_preUnit.Text)
        Txt_total.Text = CStr(a * b)
    End Sub
    Private Sub Txt_preUnit_TextChanged(sender As Object, e As EventArgs) Handles Txt_preUnit.TextChanged
        Dim a As Double, b As Double
        On Error Resume Next
        If IsNumeric(Txt_cantHerr.Text) And CInt(Txt_cantHerr.Text) > 0 Then
            a = CInt(Txt_cantHerr.Text)
        Else
            MsgBox("Ingrese Números positivos")
        End If
        If IsNumeric(Txt_preUnit.Text) Then b = CDec(Txt_preUnit.Text)
        Txt_total.Text = CStr(a * b)
    End Sub
#End Region

#Region "Búsqueda Por ComboBox"
    'Categorías
    Private Sub Cb_categActives_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_categActives.SelectedIndexChanged
        Try
            AddCombobox(Cb_categActives, Cb_SubcateActives)
            BusquedaPorComboBox("View_InerAc", Dgv_invActives, Cb_categActives, Cb_SubcateActives)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Cb_categReservs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_categReservs.SelectedIndexChanged
        Try
            AddCombobox(Cb_categReservs, Cb_SubcateReservs)
            BusquedaPorComboBox("View_InerRe", Dgv_invReservs, Cb_categReservs, Cb_SubcateReservs)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Cb_categEstateWrong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_categEstateWrong.SelectedIndexChanged
        Try
            AddCombobox(Cb_categEstateWrong, Cb_SubcateEstateWrong)
            BusquedaPorComboBox("View_InerME", Dgv_invEstateWrong, Cb_categEstateWrong, Cb_SubcateEstateWrong)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    'Sub-Categorías
    Private Sub Cb_SubcateActives_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_SubcateActives.SelectedIndexChanged
        Try
            BusquedaPorComboBox("View_InerAc", Dgv_invActives, Cb_categActives, Cb_SubcateActives)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Cb_SubcateReservs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_SubcateReservs.SelectedIndexChanged
        Try
            BusquedaPorComboBox("View_InerRe", Dgv_invReservs, Cb_categReservs, Cb_SubcateReservs)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Cb_SubcateEstateWrong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_SubcateEstateWrong.SelectedIndexChanged
        Try
            BusquedaPorComboBox("View_InerME", Dgv_invEstateWrong, Cb_categEstateWrong, Cb_SubcateEstateWrong)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Radio-Button de Habilitación"
    Private Sub Rbtn_nombreReservs_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_nombreReservs.CheckedChanged
        RB_inv(Rbtn_nombreReservs, GB_NombreReservs, GB_CategoriaReservs, Cb_categReservs, Cb_SubcateReservs, Txt_SearchReservs)
    End Sub
    Private Sub Rbtn_categoriaReservs_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_categoriaReservs.CheckedChanged
        Txt_SearchReservs.Clear()
        RB_inv(Rbtn_categoriaReservs, GB_CategoriaReservs, GB_NombreReservs, Cb_categReservs, Cb_SubcateReservs, Txt_SearchReservs)
    End Sub
    Private Sub Rbtn_nombreEstateWrong_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_nombreEstateWrong.CheckedChanged
        RB_inv(Rbtn_nombreEstateWrong, GB_NombreEstateWrong, GB_CategoriaEstateWrong, Cb_categEstateWrong, Cb_SubcateEstateWrong, Txt_SearchEstateWrong)
    End Sub
    Private Sub Rbtn_categoriaEstateWrong_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_categoriaEstateWrong.CheckedChanged
        Txt_SearchEstateWrong.Clear()
        RB_inv(Rbtn_categoriaEstateWrong, GB_CategoriaEstateWrong, GB_NombreEstateWrong, Cb_categEstateWrong, Cb_SubcateEstateWrong, Txt_SearchEstateWrong)
    End Sub
    Private Sub Rbtn_nombreActives_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_nombreActives.CheckedChanged
        RB_inv(Rbtn_nombreActives, GB_NombreActives, GB_CategoriaActives, Cb_categActives, Cb_SubcateActives, Txt_SearchActives)
    End Sub
    Private Sub Rbtn_categoriaActives_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_categoriaActives.CheckedChanged
        Txt_SearchActives.Clear()
        RB_inv(Rbtn_categoriaActives, GB_CategoriaActives, GB_NombreActives, Cb_categActives, Cb_SubcateActives, Txt_SearchActives)
    End Sub
#End Region

#Region "Búsqueda por texto en Inventario"
    Private Sub Txt_SearchReservs_TextChanged(sender As Object, e As EventArgs) Handles Txt_SearchReservs.TextChanged
        Try
            BusquedaPorTexto("View_InerRe", Txt_SearchReservs, Dgv_invReservs)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Txt_SearchEstateWrong_TextChanged(sender As Object, e As EventArgs) Handles Txt_SearchEstateWrong.TextChanged
        Try
            BusquedaPorTexto("View_InerME", Txt_SearchEstateWrong, Dgv_invEstateWrong)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Txt_SearchActives_TextChanged(sender As Object, e As EventArgs) Handles Txt_SearchActives.TextChanged
        Try
            BusquedaPorTexto("View_InerAc", Txt_SearchActives, Dgv_invActives)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Sub BusquedaPorTexto(tabla As String, txt_search As TextBox, dgv_table As DataGridView)
        Try
            Dim sql As String = "select * from " & tabla & " where nombre like '" & "%" + txt_search.Text + "%" & "'"
            Dim usr As New UsrMod
            Dim cons = usr.Consulta(dgv_table, sql)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Métodos"
    Sub MostrarDatos(dgv_table As DataGridView, vista As String)
        Try
            Dim sql As String = "Select * from " & vista
            Dim usr As New UsrMod
            Dim cons = usr.Consulta(dgv_table, sql)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub

#Region "Habilitación de GroupBox"
    Sub RB_inv(rbtn_catego As RadioButton, GB_cat As GroupBox, GB_nom As GroupBox, cate As ComboBox, sub_cat As ComboBox, txt As TextBox)
        Try
            If rbtn_catego.Checked = True Then
                GB_cat.Enabled = True
                GB_nom.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Manipulación de Inventarios"
    Sub ManipulaciondeBotones()
        Try
            Txt_codigo.Enabled = False
            Btn_Actualizar.Visible = False
            Btn_Cancelar.Visible = True
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Sub Limpieza()
        Try
            If z = 1 Then
                Txt_nomHerr.Clear()
                Txt_cantHerr.Clear()
                Txt_preUnit.Clear()
                Txt_total.Clear()
                Txt_obser.Clear()
                Pctb_imagen.Image = Nothing
                Pctb_Error2.Visible = False
                Pctb_Error3.Visible = False
                Pctb_Error4.Visible = False
                Pctb_Error5.Visible = False
            ElseIf z = 0 Then
                Txt_codigo.Clear()
                Txt_nomHerr.Clear()
                Txt_cantHerr.Clear()
                Txt_preUnit.Clear()
                Txt_total.Clear()
                Txt_obser.Clear()
                lbl_image.Text = ""
                Pctb_imagen.Image = My.Resources.original
                Pctb_Error2.Visible = False
                Pctb_Error3.Visible = False
                Pctb_Error4.Visible = False
                Pctb_Error5.Visible = False
            End If

        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try

    End Sub
    Sub Faltante()
        Try
            If Txt_codigo.Text = "" Then
                Pctb_Error1.Visible = True
            Else
                Pctb_Error1.Visible = False
            End If
            If Txt_nomHerr.Text = "" Then
                Pctb_Error2.Visible = True
            Else
                Pctb_Error2.Visible = False
            End If
            '
            If Txt_cantHerr.Text = "" Then
                Pctb_Error3.Visible = True
            Else
                Pctb_Error3.Visible = False
            End If
            '
            If Txt_preUnit.Text = "" Then
                Pctb_Error4.Visible = True
            Else
                Pctb_Error4.Visible = False
            End If
            '
            If Txt_total.Text = "" Then
                Pctb_Error5.Visible = True
            Else
                Pctb_Error5.Visible = False
            End If
            '
            If Cb_categoria.Text = "" Then
                Pctb_Error6.Visible = True
            Else
                Pctb_Error6.Visible = False
            End If
            '
            If Cb_estado.Text = "" Then
                Pctb_Error7.Visible = True
            Else
                Pctb_Error7.Visible = False
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try

    End Sub
#End Region

#Region "Recuperación de Datos por DATA"
    Sub DATA(dgv_table As DataGridView)
        Try
            n = 1
            Txt_codigo.Enabled = False
            Btn_Add.Visible = False
            Btn_Actualizar.Visible = True
            Btn_Cancelar.Visible = True
            Btn_Limpiar.Enabled = False
            Cb_estado.Enabled = False
            'retorna los datos de la data a sus respectivos campos
            Txt_codigo.Text = dgv_table.CurrentRow.Cells(0).Value.ToString
            Txt_nomHerr.Text = dgv_table.CurrentRow.Cells(1).Value.ToString

            Txt_cantHerr.Text = dgv_table.CurrentRow.Cells(3).Value.ToString
            Txt_preUnit.Text = dgv_table.CurrentRow.Cells(4).Value.ToString
            Txt_total.Text = dgv_table.CurrentRow.Cells(5).Value.ToString
            Cb_estado.Text = dgv_table.CurrentRow.Cells(6).Value.ToString
            Txt_exists.Text = dgv_table.CurrentRow.Cells(7).Value.ToString
            Txt_obser.Text = dgv_table.CurrentRow.Cells(8).Value.ToString
            Cb_categoria.Text = dgv_table.CurrentRow.Cells(9).Value.ToString
            Cb_Subcate.Text = dgv_table.CurrentRow.Cells(10).Value.ToString

            'Recuperación de la Imagen 
            If IsNothing(Pctb_imagen.BackgroundImage) Then
                Dim i() As Byte = CType(dgv_table.CurrentRow.Cells(2).Value, Byte())
                Dim ms As New IO.MemoryStream(i)
                Pctb_imagen.Image = Image.FromStream(ms)
                Pctb_imagen.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                Dim i() As Byte = CType(dgv_table.CurrentRow.Cells(2).Value, Byte())
                Dim ms As New IO.MemoryStream(i)
                Pctb_imagen.Image = Image.FromStream(ms)
                Pctb_imagen.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Create-Update"
    Private Sub Inser()
        Try
            Using ms = New IO.MemoryStream()
                ent.Codigo = Txt_codigo.Text
                ent.Nombre = Txt_nomHerr.Text
                ent.Estado = Cb_estado.Text
                ent.Sub_Estado = Txt_exists.Text
                ent.Observacion = Txt_obser.Text
                ent.Categoria = Cb_categoria.Text
                ent.Sub_categoria = Cb_Subcate.Text
                ent.Cantidad = CInt(Txt_cantHerr.Text)
                ent.Preciounidad = CDbl(Txt_preUnit.Text)
                ent.Total = CDbl(Txt_total.Text)

                If Not Pctb_imagen.Image Is Nothing Then
                    Pctb_imagen.Image.Save(ms, Pctb_imagen.Image.RawFormat)
                ElseIf Pctb_imagen.Image Is Nothing Then
                    Pctb_imagen.Image = My.Resources.original
                End If
                ent.Foto = ms.GetBuffer
            End Using
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Actua()
        Try
            ent.Codigo = Txt_codigo.Text
            ent.Nombre = Txt_nomHerr.Text
            ent.Estado = Cb_estado.Text
            ent.Sub_Estado = Txt_exists.Text
            ent.Observacion = Txt_obser.Text
            ent.Categoria = Cb_categoria.Text
            ent.Sub_categoria = Cb_Subcate.Text
            ent.Cantidad = CInt(Txt_cantHerr.Text)
            ent.Preciounidad = CDbl(Txt_preUnit.Text)
            ent.Total = CDbl(Txt_total.Text)
            'MemoryStream método tipo byte, usado para convertir la imagen en tipo byte
            Using ms = New IO.MemoryStream()
                If Not Pctb_imagen.Image Is Nothing Then
                    Pctb_imagen.Image.Save(ms, Pctb_imagen.Image.RawFormat)
                Else
                    'Otra posibilidad de código para el PictureBox: pctb_imagen.Image = My.Resources.
                    Pctb_imagen.Image.Save(ms, Pctb_imagen.Image.RawFormat)
                End If
                'Manda el ms que es el MemoryStream a la clase Entdad.
                ent.Foto = ms.GetBuffer
            End Using
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Sub guardado(dgv_table As DataGridView, elec As String)
        Try
            MsgBox("Producto guardado correctamente ")
            MostrarDatos(dgv_table, elec)
            Limpieza()
            Txt_codigo.Enabled = True
            Txt_codigo.Clear()
            Btn_Cancelar.Visible = False
            lbl_image.Text = ""
            Pctb_imagen.Image = My.Resources.original
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Sub actualizado(dgv_table As DataGridView, elec As String)
        Try
            MsgBox("Producto actualizado correctamente ")
            MostrarDatos(dgv_table, elec)
            Limpieza()
            Txt_codigo.Enabled = True
            Btn_Actualizar.Visible = False
            Btn_Cancelar.Visible = False
            Btn_Add.Visible = True
            Pctb_imagen.Image = My.Resources.original
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub

    Private Sub Cb_Subcate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Subcate.SelectedIndexChanged

    End Sub
#End Region

#Region "Busqueda por Combobox"
    Sub BusquedaPorComboBox(tabla As String, dgv_table As DataGridView, cb_categoria As ComboBox, cb_subcategoria As ComboBox)
        Try
            Dim sql As String = "select * from " & tabla & " where categoría like '" & "%" + cb_categoria.Text + "%" & "' and  sub_cat like '" & "%" + cb_subcategoria.Text + "%" & "'"
            Dim usr As New UsrMod
            Dim cons = usr.Consulta(dgv_table, sql)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Sub AddCombobox(cb_cate As ComboBox, cb_subcate As ComboBox)
        If cb_cate.Text = "Computación" Then
            cb_subcate.Items.Clear()
            cb_subcate.Items.Add("Sonido")
            cb_subcate.Items.Add("Mantenimiento")
            cb_subcate.Items.Add("Equipos")
            cb_subcate.Items.Add("Tarjetas de video")
            cb_subcate.Items.Add("Complementos")
            cb_subcate.Items.Add("Impresoras")
        ElseIf cb_cate.Text = "Eléctronica" Then
            cb_subcate.Items.Clear()
            cb_subcate.Items.Add("Soldadoras")
            cb_subcate.Items.Add("Protoboards")
            cb_subcate.Items.Add("MotherBoards")
        ElseIf cb_cate.Text = "Electricidad" Then
            cb_subcate.Items.Clear()
            cb_subcate.Items.Add("Cascos")
            cb_subcate.Items.Add("Electricidad")
        ElseIf cb_cate.Text = "Dibujo Técnico" Then
            cb_subcate.Items.Clear()
            cb_subcate.Items.Add("Reglas")
            cb_subcate.Items.Add("Tableros")
        ElseIf cb_cate.Text = "Mecánica" Then
            cb_subcate.Items.Clear()
            cb_subcate.Items.Add("Cajas")
            cb_subcate.Items.Add("Enderezado")
            cb_subcate.Items.Add("Pintura")
        ElseIf cb_cate.Text = "Varios" Then
            cb_subcate.Enabled = False
            cb_subcate.Items.Clear()
        End If
    End Sub
#End Region
#End Region
End Class