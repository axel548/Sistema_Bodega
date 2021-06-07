Public Class Prestamos

#Region "Variables"
    Public nombre As String
    Public apellido As String
    Public ent As New Entdad
    Public Func As New DAtos
    Dim rs As String
    Public z As Integer
    Public cantidad As Integer
    Public estado As String
    Public estado2 As String
    Public codigo2 As String
    Public persona As String
    Public tipo As String
#End Region

#Region "Load"
    Public Sub Prestamos_Estudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet1.PrestamoAnual' Puede moverla o quitarla según sea necesario.
            Me.PrestamoAnualTableAdapter.Fill(Me.BodegaDataSet1.PrestamoAnual)
            'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet1.PRESTAMOEXPIRADO' Puede moverla o quitarla según sea necesario.
            Me.PRESTAMOEXPIRADOTableAdapter.Fill(Me.BodegaDataSet1.PRESTAMOEXPIRADO)
            'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet1.View_PrestamoPRo' Puede moverla o quitarla según sea necesario.
            Me.View_PrestamoPRoTableAdapter.Fill(Me.BodegaDataSet1.View_PrestamoPRo)
            'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet1.View_PrestamoEStud' Puede moverla o quitarla según sea necesario.
            Me.View_PrestamoEStudTableAdapter1.Fill(Me.BodegaDataSet1.View_PrestamoEStud)
            MostrarDatos(Dgv_PresEst, "View_PrestamoEStud")
            MostrarDatos(Dgv_PresPro, "View_PrestamoPRo")
            Lbl_selecTipoPrest.Visible = True
            Dtp_fechdevolucion.Value = Dtp_fechdevolucion.Value.AddDays(7)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "SSAD"
    Private Sub Pctb_salir_Click(sender As Object, e As EventArgs) Handles Pctb_salir.Click
        Try
            Close()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Btn_seleccionar_Click(sender As Object, e As EventArgs) Handles Btn_seleccionarInventario.Click
        Try
            Dim frm As New SubForm_Inventario
            AddOwnedForm(frm)
            frm.Lbl_info1.Visible = True
            frm.Lbl_info2.Visible = True
            frm.Lbl_info3.Visible = True
            frm.Lbl_Aviso.Visible = True
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Btn_seleccionar2_Click(sender As Object, e As EventArgs) Handles Btn_seleccionarProEst.Click
        Try
            If Cb_desicion.Text = "Estudiante" Then
                Txt_carne.Clear()
                Txt_estudiante.Clear()
                Dim frm As New SubForm_Estudiante
                AddOwnedForm(frm)
                frm.ShowDialog()
            ElseIf Cb_desicion.Text = "Profesor" Then
                TxtDPI3.Clear()
                TxtDPI2.Clear()
                TxtDPI1.Clear()
                Txt_estudiante.Clear()
                Dim frm As New SubForm_Profesor
                AddOwnedForm(frm)
                frm.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles Pctb_Ayuda.Click
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

#Region "Botones"
    'TC_Devolución
    Private Sub Rbtn_fix_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_fix.CheckedChanged
        If Rbtn_fix.Checked = True Then
            GB_fix.Enabled = True
            Txt_codigo2.Text = Txt_codfix.Text
            GB_lose.Enabled = False

            If Txt_codigo2.Text = Func.ACTIVO Then
                estado2 = "View_InerAc"
                codigo2 = Txt_codigo2.Text
                Validar()
            ElseIf Txt_codigo2.Text = Func.RESERVA Then
                estado2 = "View_InerRe"
                codigo2 = Txt_codigo2.Text
                Validar()
            End If
        End If
    End Sub
    Private Sub Rbtn_lose_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_lose.CheckedChanged
        If Rbtn_lose.Checked = True Then
            GB_lose.Enabled = True
            Txt_codigo2.Text = Txt_codLose.Text
            GB_fix.Enabled = False
            If Txt_codigo2.Text = Func.ACTIVO Then
                estado = "View_InerAc"
                codigo2 = Txt_codigo2.Text
                Validar()
            ElseIf Txt_codigo2.Text = Func.RESERVA Then
                estado = "View_InerRe"
                codigo2 = Txt_codigo2.Text
                Validar()
            End If
        End If
    End Sub
    Private Sub ChkB_Ambas_CheckedChanged(sender As Object, e As EventArgs) Handles ChkB_Ambas.CheckedChanged
        If ChkB_Ambas.Checked = True Then
            GB_lose.Enabled = True
            GB_fix.Enabled = True
            Rbtn_fix.Enabled = False
            Rbtn_lose.Enabled = False
        ElseIf ChkB_Ambas.Checked = False Then
            GB_lose.Enabled = False
            GB_fix.Enabled = False
            Rbtn_fix.Enabled = True
            Rbtn_lose.Enabled = True
        End If
    End Sub
#End Region

#Region "Generar-Reporte"
    Private Sub Bf_btnGenerar_Click(sender As Object, e As EventArgs) Handles Btn_generarReporte.Click
        Dim frmreport As New Reporte
        Try
            If z = 0 Then
                Dim noprest As String = Txt_no.Text
                frmreport.noprest = noprest
                frmreport.dec = z
                frmreport.ShowDialog()
            ElseIf z = 1 Then
                Dim noprest As String = Txt_no.Text
                frmreport.noprest = noprest
                frmreport.dec = z
                frmreport.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            frmreport.Dispose()
        End Try
    End Sub
#End Region

#Region "Data"
    Private Sub Dgv_prest_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_PresEst.CellDoubleClick
        z = 0
        Try
            If MessageBox.Show("¿Desea modificar la fila o generar reporte?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Txt_carne2.Visible = True
                Lbl_carne2.Visible = True
                Lbl_dpi2.Visible = False
                Txt_dpi1.Visible = False
                Txt_dpi2.Visible = False
                Txt_dpi3.Visible = False
                Lbl_guion1.Visible = False
                Lbl_guion2.Visible = False

                Txt_prestamo.Text = CStr(Dgv_PresEst.CurrentRow.Cells(0).Value)

                Txt_codigo2.Text = Dgv_PresEst.CurrentRow.Cells(4).Value.ToString
                Txt_articulo.Text = Dgv_PresEst.CurrentRow.Cells(5).Value.ToString
                Txt_cantidadPrestada.Text = Dgv_PresEst.CurrentRow.Cells(6).Value.ToString

                Txt_carne2.Text = Dgv_PresEst.CurrentRow.Cells(7).Value.ToString
                nombre = Dgv_PresEst.CurrentRow.Cells(8).Value.ToString
                apellido = Dgv_PresEst.CurrentRow.Cells(9).Value.ToString
                Txt_persona.Text = nombre & " , " & apellido

                Lbl_idEstado.Text = Dgv_PresEst.CurrentRow.Cells(15).Value.ToString
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Dgv_prestPr_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_PresPro.CellDoubleClick
        Dim dpi As String
        z = 1
        Try
            If MessageBox.Show("¿Desea modificar la fila o generar reporte?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Lbl_dpi2.Visible = True
                Txt_dpi1.Visible = True
                Txt_dpi2.Visible = True
                Txt_dpi3.Visible = True
                Lbl_guion1.Visible = True
                Lbl_guion2.Visible = True
                Txt_carne2.Visible = False
                Lbl_carne2.Visible = False

                Txt_prestamo.Text = CStr(Dgv_PresPro.CurrentRow.Cells(0).Value)

                Txt_codigo2.Text = Dgv_PresPro.CurrentRow.Cells(4).Value.ToString
                Txt_articulo.Text = Dgv_PresPro.CurrentRow.Cells(5).Value.ToString
                Txt_cantidadPrestada.Text = Dgv_PresPro.CurrentRow.Cells(6).Value.ToString

                dpi = Dgv_PresPro.CurrentRow.Cells(7).Value.ToString
                Dim ArrCadena As String() = dpi.Split(CChar("-"))
                Txt_dpi1.Text = ArrCadena(0).ToString
                Txt_dpi2.Text = ArrCadena(1).ToString
                Txt_dpi3.Text = ArrCadena(2).ToString

                nombre = Dgv_PresPro.CurrentRow.Cells(8).Value.ToString
                apellido = Dgv_PresPro.CurrentRow.Cells(9).Value.ToString
                Txt_persona.Text = nombre & " , " & apellido

                Lbl_idEstado.Text = Dgv_PresPro.CurrentRow.Cells(11).Value.ToString
            End If

        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "CRUD"
    'Guardar
    Private Sub Bf_btnAdd_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Try
            If Cb_desicion.Text = "Estudiante" Then
                If Txt_no.Text = Func.GCodPrestamoEstudiante Then
                    If ValidateChildren() = True And Txt_no.Text <> "" And Txt_carne.Text <> "" And Txt_cantidadPrestam.Text <> "" And Cb_estadoPrestam.Text <> "" Then
                        If CInt(Txt_cantidadPrestam.Text) > cantidad Then
                            MsgBox("No puede Exceder la cantidad en almacenamiento")
                        ElseIf CInt(Txt_cantidadPrestam.Text) <= cantidad Then
                            ent.Noprest = Txt_no.Text
                            ent.Codigo = txt_codigo.Text
                            ent.Articulo = txt_nomHerr.Text
                            ent.Carne = Txt_carne.Text
                            ent.Nombre = Txt_estudiante.Text
                            ent.Autorizacion = Txt_Autorizacion.Text
                            ent.Cantidad = CInt(Txt_cantidadPrestam.Text)
                            ent.Estado = estado

                            ent.EstadoPres = Cb_estadoPrestam.Text
                            ent.FechPrestamo = CDate(Dtp_fechPrest.Value)
                            ent.FechDev = CDate(Dtp_fechdevolucion.Value)
                            ent.Observacion = Txt_obser.Text
                            If Func.InsertadoPrestamoEstudiante(ent) Then
                                MsgBox("Prestamo guardado correctamente ")
                                MostrarDatos(Dgv_PresEst, "View_PrestamoEStud")
                                Refresh()
                            Else
                                MsgBox("No se realizó la consulta")
                            End If
                        End If
                    End If
                ElseIf Txt_no.Text <> CStr(Func.GCodPrestamoEstudiante) Then
                    MessageBox.Show("Genere el código correcto", "Código Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            ElseIf Cb_desicion.Text = "Profesor" Then
                If Txt_no.Text = Func.GCodPrestamoProfesor Then
                    If ValidateChildren() = True And Txt_no.Text <> "" And TxtDPI1.Text <> "" And TxtDPI2.Text <> "" And TxtDPI3.Text <> "" And Txt_cantidadPrestam.Text <> "" And Cb_estadoPrestam.Text <> "" Then
                        If CInt(Txt_cantidadPrestam.Text) > cantidad Then
                            MsgBox("No puede Exceder la cantidad en almacenamiento")
                        ElseIf CInt(Txt_cantidadPrestam.Text) <= cantidad Then
                            ent.Noprest = Txt_no.Text
                            ent.Codigo = txt_codigo.Text
                            ent.Articulo = txt_nomHerr.Text
                            rs = TxtDPI3.Text & "-" & TxtDPI2.Text & "-" & TxtDPI1.Text
                            ent.DPI = rs
                            ent.Nombre = Txt_estudiante.Text
                            ent.Cantidad = CInt(Txt_cantidadPrestam.Text)
                            ent.Estado = estado

                            ent.EstadoPres = Cb_estadoPrestam.Text
                            ent.FechPrestamo = Dtp_fechPrest.Value
                            ent.FechDev = CDate(Dtp_fechdevolucion.Value)
                            ent.Observacion = Txt_obser.Text
                            If Func.InsertadoPrestamoProfesor(ent) Then
                                MsgBox("Prestamo guardado correctamente ")
                                MostrarDatos(Dgv_PresPro, "View_PrestamoPRo")
                                Refresh()
                            Else
                                MsgBox("No se realizó la consulta")
                            End If
                        End If
                    End If
                ElseIf Txt_no.Text <> CStr(Func.GCodPrestamoProfesor) Then
                    MessageBox.Show("Genere el código correcto", "Código Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MsgBox("Inserte Datos para poder guardarlos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Actualizar
    Private Sub Bf_btnModif_Click(sender As Object, e As EventArgs) Handles Btn_Modif.Click
        Dim ws As String = Func.GcLoseFix
        Try
            If ValidateChildren() = True And Txt_prestamo.Text <> "" And (TxtDPI1.Text <> "" And TxtDPI2.Text <> "" And TxtDPI3.Text <> "" Or Txt_carne2.Text <> "") And Txt_codigo2.Text <> "" And Cb_estadoPrestam.Text <> "" Then
                If Cb_estado2.Text = "Devolución" Then
                    If Txt_prestamo.Text = Func.GCodPrestamoEstudiante Then
                        persona = "Estudiante"
                        If Txt_codigo2.Text = Func.ACTIVO Then
                            tipo = "Activo"

                            ent.Noprest = Txt_prestamo.Text
                            ent.EstadoPres = Cb_estado2.Text
                            ent.Codigo = Txt_codigo2.Text
                            ent.FechDev = CDate(Dtp_fechDev.Value)
                            ent.Persona = persona
                            ent.Tipo = tipo
                            Actualizardevolucion()
                        ElseIf Txt_codigo2.Text = Func.RESERVA Then
                            tipo = "Resserva"

                            ent.Noprest = Txt_prestamo.Text
                            ent.EstadoPres = Cb_estado2.Text
                            ent.Codigo = Txt_codigo2.Text
                            ent.FechDev = CDate(Dtp_fechDev.Value)
                            ent.Persona = persona
                            ent.Tipo = tipo
                            Actualizardevolucion()
                        End If
                    ElseIf Txt_prestamo.Text = Func.GCodPrestamoProfesor Then
                        persona = "Profesor"
                        If Txt_codigo2.Text = Func.ACTIVO Then
                            tipo = "Activo"

                            ent.Noprest = Txt_prestamo.Text
                            ent.EstadoPres = Cb_estado2.Text
                            ent.Codigo = Txt_codigo2.Text
                            ent.FechDev = CDate(Dtp_fechDev.Value)
                            ent.Persona = persona
                            ent.Tipo = tipo
                            Actualizardevolucion()
                        ElseIf Txt_codigo2.Text = Func.RESERVA Then
                            tipo = "Resserva"

                            ent.Noprest = Txt_prestamo.Text
                            ent.EstadoPres = Cb_estado2.Text
                            ent.Codigo = Txt_codigo2.Text
                            ent.FechDev = CDate(Dtp_fechDev.Value)
                            ent.Persona = persona
                            ent.Tipo = tipo
                            Actualizardevolucion()
                        End If
                    End If
                ElseIf Cb_estado2.Text = "Pendiente" Then
                    If Txt_prestamo.Text = CStr(Func.GCodPrestamoEstudiante) Then
                        persona = "Estudiante"
                        If Txt_codigo2.Text = CStr(Func.ACTIVO) Then
                            tipo = "Activo"
                            If Rbtn_fix.Checked = True Then
                                estado = "Reparación"
                                ent.Noprest = Txt_prestamo.Text
                                ent.NoLF = ws
                                ent.EstadoPres = estado
                                ent.Codigo = Txt_codigo2.Text
                                ent.Articulo = Txt_articulo.Text
                                ent.FechDev = CDate(Dtp_fechDev.Value)
                                ent.Cantidad_Fix = CInt(Txt_cantidadfix.Text)
                                ent.Cantidad_Prestada = CInt(Txt_dev1.Text)
                                ent.Carne = Txt_carne2.Text
                                ent.Nombre = Txt_persona.Text
                                ent.Total = CInt(Txt_cobrofix.Text) * CInt(Txt_cantidadfix.Text)
                                ent.Persona = persona
                                ent.Tipo = tipo
                                ActualizarFix_lose()
                            ElseIf Rbtn_lose.Checked = True Then
                                estado = "Perdida"
                                ent.Noprest = Txt_prestamo.Text
                                ent.NoLF = ws
                                ent.EstadoPres = estado
                                ent.Codigo = Txt_codigo2.Text
                                ent.Articulo = Txt_articulo.Text
                                ent.FechDev = CDate(Dtp_fechDev.Value)
                                ent.Cantidad_Fix = CInt(Txt_cantidadLose.Text)
                                ent.Cantidad_Prestada = CInt(Txt_dev1.Text)
                                ent.Carne = Txt_carne2.Text
                                ent.Nombre = Txt_persona.Text
                                ent.Total = CInt(Txt_cobrolose.Text) * CInt(Txt_cantidadLose.Text)
                                ent.Persona = persona
                                ent.Tipo = tipo
                                ActualizarFix_lose()
                            End If
                        ElseIf Txt_codigo2.Text = CStr(Func.RESERVA) Then
                            tipo = "Reserva"
                            If Rbtn_fix.Checked = True Then
                                estado = "Reparación"
                                ent.Noprest = Txt_prestamo.Text
                                ent.NoLF = ws
                                ent.EstadoPres = estado
                                ent.Codigo = Txt_codigo2.Text
                                ent.Articulo = Txt_articulo.Text
                                ent.FechDev = CDate(Dtp_fechDev.Value)
                                ent.Cantidad_Fix = CInt(Txt_cantidadfix.Text)
                                ent.Cantidad_Prestada = CInt(Txt_dev1.Text)
                                ent.Carne = Txt_carne2.Text
                                ent.Nombre = Txt_persona.Text
                                ent.Total = CInt(Txt_cobrofix.Text) * CInt(Txt_cantidadfix.Text)
                                ent.Persona = persona
                                ent.Tipo = tipo
                                ActualizarFix_lose()
                            ElseIf Rbtn_lose.Checked = True Then
                                estado = "Perdida"
                                ent.Noprest = Txt_prestamo.Text
                                ent.NoLF = ws
                                ent.EstadoPres = estado
                                ent.Codigo = Txt_codigo2.Text
                                ent.Articulo = Txt_articulo.Text
                                ent.FechDev = CDate(Dtp_fechDev.Value)
                                ent.Cantidad_Fix = CInt(Txt_cantidadLose.Text)
                                ent.Cantidad_Prestada = CInt(Txt_dev1.Text)
                                ent.Carne = Txt_carne2.Text
                                ent.Nombre = Txt_persona.Text
                                ent.Total = CInt(Txt_cobrolose.Text) * CInt(Txt_cantidadLose.Text)
                                ent.Persona = persona
                                ent.Tipo = tipo
                                ActualizarFix_lose()
                            End If
                        End If
                    ElseIf Txt_prestamo.Text = CStr(Func.GCodPrestamoProfesor) Then
                        persona = "Profesor"
                        If Txt_codigo2.Text = CStr(Func.ACTIVO) Then
                            tipo = "Activo"
                            If Rbtn_fix.Checked = True Then
                                estado = "Reparación"
                                ent.Noprest = Txt_prestamo.Text
                                ent.NoLF = ws
                                ent.EstadoPres = estado
                                ent.Codigo = Txt_codigo2.Text
                                ent.Articulo = Txt_articulo.Text
                                ent.FechDev = CDate(Dtp_fechDev.Value)
                                ent.Cantidad_Fix = CInt(Txt_cantidadfix.Text)
                                ent.Cantidad_Prestada = CInt(Txt_dev1.Text)
                                ent.Carne = Txt_carne2.Text
                                ent.Nombre = Txt_persona.Text
                                ent.Total = CInt(Txt_cobrofix.Text) * CInt(Txt_cantidadfix.Text)
                                ent.Persona = persona
                                ent.Tipo = tipo
                                ActualizarFix_lose()
                            ElseIf Rbtn_lose.Checked = True Then
                                estado = "Perdida"
                                ent.Noprest = Txt_prestamo.Text
                                ent.NoLF = ws
                                ent.EstadoPres = estado
                                ent.Codigo = Txt_codigo2.Text
                                ent.Articulo = Txt_articulo.Text
                                ent.FechDev = CDate(Dtp_fechDev.Value)
                                ent.Cantidad_Fix = CInt(Txt_cantidadLose.Text)
                                ent.Cantidad_Prestada = CInt(Txt_dev1.Text)
                                ent.Carne = Txt_carne2.Text
                                ent.Nombre = Txt_persona.Text
                                ent.Total = CInt(Txt_cobrolose.Text) * CInt(Txt_cantidadLose.Text)
                                ent.Persona = persona
                                ent.Tipo = tipo
                                ActualizarFix_lose()
                            End If
                        ElseIf Txt_codigo2.Text = CStr(Func.RESERVA) Then
                            tipo = "Reserva"
                            If Rbtn_fix.Checked = True Then
                                estado = "Reparación"
                                ent.Noprest = Txt_prestamo.Text
                                ent.NoLF = ws
                                ent.EstadoPres = estado
                                ent.Codigo = Txt_codigo2.Text
                                ent.Articulo = Txt_articulo.Text
                                ent.FechDev = CDate(Dtp_fechDev.Value)
                                ent.Cantidad_Fix = CInt(Txt_cantidadfix.Text)
                                ent.Cantidad_Prestada = CInt(Txt_dev1.Text)
                                ent.Carne = Txt_carne2.Text
                                ent.Nombre = Txt_persona.Text
                                ent.Total = CInt(Txt_cobrofix.Text) * CInt(Txt_cantidadfix.Text)
                                ent.Persona = persona
                                ent.Tipo = tipo
                                ActualizarFix_lose()
                            ElseIf Rbtn_lose.Checked = True Then
                                ent.Noprest = Txt_prestamo.Text
                                ent.NoLF = ws
                                ent.EstadoPres = estado
                                ent.Codigo = Txt_codigo2.Text
                                ent.Articulo = Txt_articulo.Text
                                ent.FechDev = CDate(Dtp_fechDev.Value)
                                ent.Cantidad_Fix = CInt(Txt_cantidadLose.Text)
                                ent.Cantidad_Prestada = CInt(Txt_dev1.Text)
                                ent.Carne = Txt_carne2.Text
                                ent.Nombre = Txt_persona.Text
                                ent.Total = CInt(Txt_cobrolose.Text) * CInt(Txt_cantidadLose.Text)
                                ent.Persona = persona
                                ent.Tipo = tipo
                                ActualizarFix_lose()
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "ComboBox"
    Private Sub Cb_desicion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_desicion.SelectedIndexChanged
        Try
            If Cb_desicion.Text = "Estudiante" Then
                Txt_no.Text = Func.GCodPrestamoEstudiante()
                Lbl_Carne.Visible = True
                Lbl_Estudiante.Visible = True
                Txt_carne.Visible = True
                Lbl_Dpi.Visible = False
                Lbl_Profesor.Visible = False
                Lbl_SE1.Visible = False
                Lbl_SE2.Visible = False
                TxtDPI3.Visible = False
                TxtDPI2.Visible = False
                TxtDPI1.Visible = False
                Lbl_selecTipoPrest.Visible = False
                Txt_estudiante.Clear()
                Txt_no.Enabled = False
                Txt_Autorizacion.Visible = True
                Lbl_autorizar.Visible = True

            ElseIf Cb_desicion.Text = "Profesor" Then
                Txt_no.Text = Func.GCodPrestamoProfesor()
                Lbl_Dpi.Visible = True
                Lbl_Profesor.Visible = True
                TxtDPI3.Visible = True
                TxtDPI2.Visible = True
                TxtDPI1.Visible = True
                Lbl_Carne.Visible = False
                Lbl_Estudiante.Visible = False
                Lbl_SE1.Visible = True
                Lbl_SE2.Visible = True
                Txt_carne.Visible = False
                Lbl_selecTipoPrest.Visible = False
                Txt_estudiante.Clear()
                Txt_no.Enabled = False
                Txt_Autorizacion.Visible = False
                Lbl_autorizar.Visible = False
                Chk_PrestamoAnual.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Cb_estado2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_estado2.SelectedIndexChanged
        If Cb_estado2.Text = "Pendiente" Then
            Rbtn_fix.Enabled = True
            Rbtn_lose.Enabled = True
            ChkB_Ambas.Enabled = True
        End If
    End Sub
#End Region

#Region "RadioButton"
    'Estudiante
    Private Sub Rbtn_NoprestEst_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_NoprestEst.CheckedChanged
        Radio(Rbtn_NoprestEst, GB_SearchNombreEst)
    End Sub
    Private Sub Rbtn_CarneEst_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_CarneEst.CheckedChanged
        Txt_SearchEst.CharacterCasing = CharacterCasing.Upper
        Radio(Rbtn_CarneEst, GB_SearchNombreEst)
    End Sub
    Private Sub Rbtn_NombreEst_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_NombreEst.CheckedChanged
        Radio(Rbtn_NombreEst, GB_SearchNombreEst)
    End Sub
    ' Profesor
    Private Sub Rbtn_NoprestPro_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_NoprestPro.CheckedChanged
        Radio(Rbtn_NoprestPro, GB_SearchNombrePro)
    End Sub
    Private Sub Rbtn_DPIPro_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_DPIPro.CheckedChanged
        Radio(Rbtn_DPIPro, GB_SearchNombrePro)
    End Sub
    Private Sub Rbtn_nombrePro_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_nombrePro.CheckedChanged
        Radio(Rbtn_nombrePro, GB_SearchNombrePro)
    End Sub
#End Region

#Region "TextBox"
    Private Sub Txt_SearchPro_TextChanged(sender As Object, e As EventArgs) Handles Txt_SearchPro.TextChanged
        If Rbtn_NombreEst.Checked = True Then
            Busqueda(Dgv_PresPro, Txt_SearchEst, "Prestamo_Profesor", "nombre")
        ElseIf Rbtn_CarneEst.Checked = True Then
            Busqueda(Dgv_PresPro, Txt_SearchEst, "Prestamo_Profesor", "dpi")
        ElseIf Rbtn_NoprestEst.Checked = True Then
            Busqueda(Dgv_PresPro, Txt_SearchEst, "Prestamo_Profesor", "codigo")
        End If
    End Sub
    Private Sub Txt_SearchEst_TextChanged(sender As Object, e As EventArgs) Handles Txt_SearchEst.TextChanged
        If Rbtn_NombreEst.Checked = True Then
            Busqueda(Dgv_PresEst, Txt_SearchEst, "Prestamo_Estudiante", "nombre")
        ElseIf Rbtn_CarneEst.Checked = True Then
            Busqueda(Dgv_PresEst, Txt_SearchEst, "Prestamo_Estudiante", "Carne")
        ElseIf Rbtn_NoprestEst.Checked = True Then
            Busqueda(Dgv_PresEst, Txt_SearchEst, "Prestamo_Estudiante", "codigo")
        End If
    End Sub

#End Region

#Region "Eventos"
    Private Sub Txt_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_no.KeyPress
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
    Private Sub Txt_cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_cantidadPrestam.KeyPress
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

#Region "Métodos"
    Sub MostrarDatos(dgv_table As DataGridView, elec As String)
        Try
            Dim sql As String = "select * from " & elec
            Dim usr As New UsrMod
            Dim cons = usr.Consulta(dgv_table, sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub limpieza()
        If Cb_desicion.Text = "Estudiante" Then
            Txt_no.Clear()
            txt_codigo.Clear()
            txt_nomHerr.Clear()
            Txt_carne.Clear()
            Txt_obser.Clear()
            Txt_estudiante.Clear()
            Txt_cantidadPrestam.Clear()
        ElseIf Cb_desicion.Text = "Profesor" Then
            Txt_no.Clear()
            txt_codigo.Clear()
            txt_nomHerr.Clear()
            TxtDPI1.Clear()
            TxtDPI2.Clear()
            TxtDPI3.Clear()
            Txt_obser.Clear()
            Txt_estudiante.Clear()
            Txt_cantidadPrestam.Clear()
        End If
    End Sub
    Sub Actualizardevolucion()
        If Func.UpdateDevolucionEstudiante(ent) Then
            MsgBox("Prestamo guardado correctamente ")
            limpieza()
            Refresh()
        Else
            MsgBox("No se realizó la consulta")
        End If
    End Sub
    Sub ActualizarFix_lose()
        If Func.UpdateReparacionEstudiante(ent) Then
            MsgBox("Prestamo guardado correctamente ")
            Refresh()
        Else
            MsgBox("No se realizó la consulta")
        End If
    End Sub
    Sub Validar()
        Try
            Dim usrModel As New UsrMod
            Dim validLog = usrModel.Cobro_LF(estado2, codigo2)
            If validLog = True Then
                If Rbtn_fix.Checked = True Then
                    Txt_cobrofix.Text = CStr(cobro)
                ElseIf Rbtn_lose.Checked = True Then
                    Txt_cobrolose.Text = CStr(cobro)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Radio(Rbtn As RadioButton, GB As GroupBox)
        If Rbtn.Checked = True Then
            GB.Enabled = True
        ElseIf Rbtn.Checked = False Then
            GB.Enabled = False
        End If
    End Sub
    Sub Busqueda(dgv_table As DataGridView, txt As TextBox, table As String, campo As String)
        Try
            Dim sql As String = "select * from " & table & " where " & campo & " like '" & "%" + txt.Text + "%" & "'"
            Dim usr As New UsrMod
            Dim cons = usr.Consulta(dgv_table, sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub Btn_Siguiente_Click(sender As Object, e As EventArgs) Handles Btn_Siguiente.Click
        If Chk_PrestamoAnual.Checked = True Then
            If Cb_desicion.Text = "Profesor" Then
                '  Dgv_prestamos.Rows.Add(Txt_no.Text, txt_codigo.Text, txt_nomHerr.Text, Txt_carne.Text, Txt_estudiante.Text, "", CDate(Dtp_fechPrest.Value), CDate(Dtp_fechdevolucion.Value), Cb_estadoPrestam.Text, Txt_cantidadPrestam.Text)
                Dim rowld As Integer = Dgv_prestamos.Rows.Add()
                Dim row As DataGridViewRow = Dgv_prestamos.Rows(rowld)

                row.Cells("columNoprest").Value = Txt_no.Text
                row.Cells("columCodigo").Value = txt_codigo.Text
                row.Cells("columArticulo").Value = txt_nomHerr.Text
                row.Cells("columIdentificacion").Value = txt_nomHerr.Text
                row.Cells("columPersonanombre").Value = Txt_estudiante.Text

                row.Cells("columFechaprestamo").Value = Dtp_fechPrest.Value
                row.Cells("columFechadevolucion").Value = Dtp_fechdevolucion.Value
                row.Cells("columEstadoprestamo").Value = Cb_estadoPrestam.Text
                row.Cells("columCantidadprestamo").Value = Txt_cantidadPrestam.Text
            End If
        End If
    End Sub
End Class