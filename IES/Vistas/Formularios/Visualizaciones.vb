Public Class Visualizaciones

#Region "Variables"
    Dim elec As String
    Dim dec As Integer
    Dim rs As String
#End Region

#Region "Load"
    Private Sub Visualizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet.profesor' Puede moverla o quitarla según sea necesario.
            Me.ProfesorTableAdapter.Fill(Me.BodegaDataSet.profesor)
            'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet.estudiante' Puede moverla o quitarla según sea necesario.
            Me.EstudianteTableAdapter.Fill(Me.BodegaDataSet.estudiante)
            'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet.Historial_Prestamos' Puede moverla o quitarla según sea necesario.
            Me.Historial_PrestamosTableAdapter.Fill(Me.BodegaDataSet.Historial_Prestamos)
            'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet.Historial_Inven' Puede moverla o quitarla según sea necesario.
            Me.Historial_InvenTableAdapter.Fill(Me.BodegaDataSet.Historial_Inven)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "CRUD"
    'Actualizar
    Private Sub Btn_Modif_Click(sender As Object, e As EventArgs) Handles Btn_Modif.Click
        Dim ent As New Entdad
        Dim Func As New DAtos
        Try
            If dec = 0 Then
                If ValidateChildren() = True And Txt_carne.Text <> "" And Txt_nombre.Text <> "" Then
                    ent.Carne = Txt_carne.Text
                    ent.Nombre = Txt_nombre.Text
                    ent.Apellido = Txt_Apellido.Text
                    ent.Especialidad = Cb_Especiali.Text
                    ent.Grado = Cb_grado.Text
                    ent.Seccion = Cb_secc.Text
                    If Func.ActualizarEstudiante(ent) Then
                        MsgBox("Registro actualizado correctamente ")
                        MostrarDatos(Dgv_est, "estudiante")
                    Else
                        MsgBox("No se realizó la consulta")
                    End If
                End If
            ElseIf dec = 1 Then
                If ValidateChildren() = True And TxtDPI1.Text <> "" And TxtDPI2.Text <> "" And TxtDPI3.Text <> "" And Txt_nombre.Text <> "" And Txt_Apellido.Text <> "" Then
                    rs = TxtDPI3.Text & "-" & TxtDPI2.Text & "-" & TxtDPI1.Text
                    ent.DPI = rs
                    ent.Nombre = Txt_nombre.Text
                    ent.Apellido = Txt_Apellido.Text
                    ent.Especialidad = Cb_Especiali.Text
                    If Func.ActualizarProfesor(ent) Then
                        MsgBox("Prestamo guardado correctamente ")
                        MostrarDatos(Dgv_pro, "profesor")
                    Else
                        MsgBox("No se realizó la consulta")
                    End If
                End If
            Else
                MsgBox("Seleccione un registro que actualizar.")
            End If

        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "C"
    Private Sub Pctb_salir_Click(sender As Object, e As EventArgs) Handles Pctb_salir.Click
        Close()
    End Sub
#End Region

#Region "Generar-Reportes"
    Private Sub Btn_GenerarReporte_Click(sender As Object, e As EventArgs) Handles Btn_GenerarReporte.Click
        dec = 2
        Dim fechinic As Date = CDate(Dtp_fechaInicial.Text)
        Dim fechfinal As Date = CDate(Dtp_fechaFinal.Text)

        Dim reportHI As New Reporte_Historiales With {
            .fechinicial = fechinic,
            .fechfinal = fechfinal,
            .dec = dec
        }
        reportHI.ShowDialog()
    End Sub
    Private Sub Btn_GenerarReporte2_Click(sender As Object, e As EventArgs) Handles Btn_GenerarReporte2.Click
        dec = 0
        Dim fechinic As Date = CDate(Dtp_fechaInicial2.Text)
        Dim fechfinal As Date = CDate(Dtp_fechaFinal2.Text)

        Dim reportHI As New Reporte_Historiales With {
            .fechinicial = fechinic,
            .fechfinal = fechfinal,
            .dec = dec
        }
        reportHI.ShowDialog()
    End Sub
    Private Sub Btn_GenerarReporteInventario_Click(sender As Object, e As EventArgs) Handles Btn_GenerarReporteInventario.Click
        dec = 1
        Dim categoria As String = Cb_categEstateWrong.Text
        Dim sub_categoria As String = Cb_SubcateEstateWrong.Text

        Dim reportHI As New Reporte_Historiales With {
            .tipo = elec,
            .categoria = categoria,
            .sub_categoria = sub_categoria,
            .dec = dec
        }
        reportHI.ShowDialog()
    End Sub
#End Region

#Region "Data"
    Private Sub Dgv_SubEst_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_est.CellDoubleClick
        Try
            dec = 0
            Txt_carne.Visible = True
            Lbl_Carne.Visible = True
            TxtDPI1.Visible = False
            TxtDPI2.Visible = False
            TxtDPI3.Visible = False
            Lbl_Dpi.Visible = False
            Lbl_SE1.Visible = False
            Lbl_SE2.Visible = False
            Txt_carne.Text = Dgv_est.CurrentRow.Cells(0).Value.ToString
            Txt_nombre.Text = Dgv_est.CurrentRow.Cells(1).Value.ToString
            Txt_Apellido.Text = Dgv_est.CurrentRow.Cells(2).Value.ToString
            Cb_Especiali.Text = Dgv_est.CurrentRow.Cells(3).Value.ToString
            Cb_grado.Text = Dgv_est.CurrentRow.Cells(4).Value.ToString
            Cb_secc.Text = Dgv_est.CurrentRow.Cells(5).Value.ToString
            Close()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Dgv_SubPro_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_pro.CellDoubleClick
        Try
            dec = 1
            Txt_carne.Visible = False
            Lbl_Carne.Visible = False
            Cb_grado.Enabled = False
            Cb_secc.Enabled = False
            TxtDPI1.Visible = True
            TxtDPI2.Visible = True
            TxtDPI3.Visible = True
            Lbl_Dpi.Visible = True
            Lbl_SE1.Visible = True
            Lbl_SE2.Visible = True

            Dim dpi As String
            dpi = Dgv_pro.CurrentRow.Cells(0).Value.ToString
            Dim ArrCadena As String() = dpi.Split(CChar("-"))
            TxtDPI3.Text = ArrCadena(0).ToString
            TxtDPI2.Text = ArrCadena(1).ToString
            TxtDPI1.Text = ArrCadena(2).ToString
            Txt_nombre.Text = Dgv_pro.CurrentRow.Cells(1).Value.ToString
            Txt_Apellido.Text = Dgv_pro.CurrentRow.Cells(2).Value.ToString
            Cb_Especiali.Text = Dgv_pro.CurrentRow.Cells(3).Value.ToString
            Close()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "ComboBox"
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Eleccion.SelectedIndexChanged
        If Cb_Eleccion.Text = "Activo" Then
            elec = "View_InerAc"
            MostrarDatos(Dgv_SearchInv, elec)
        ElseIf Cb_Eleccion.Text = "Reserva" Then
            elec = "View_InerRe"
            MostrarDatos(Dgv_SearchInv, elec)
        ElseIf Cb_Eleccion.Text = "Mal Estado" Then
            elec = "View_InerME"
            MostrarDatos(Dgv_SearchInv, elec)
        End If
    End Sub
    Private Sub Cb_categEstateWrong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_categEstateWrong.SelectedIndexChanged
        Try
            If Cb_SubcateEstateWrong.Text = Cb_SubcateEstateWrong.Text Then
                Dim sql As String = "select *from " & elec & " where categoría like '" & "%" + Cb_categEstateWrong.Text + "%" & "'"
                Dim usr As New UsrMod
                Dim cons = usr.Consulta(Dgv_SearchInv, sql)
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Cb_SubcateEstateWrong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_SubcateEstateWrong.SelectedIndexChanged
        Try
            If Cb_SubcateEstateWrong.Text = Cb_SubcateEstateWrong.Text Then
                Dim sql As String = "select *from " & elec & " where categoría like '" & "%" + Cb_categEstateWrong.Text + "%" & "' and  sub_cat like '" & "%" + Cb_SubcateEstateWrong.Text + "%" & "'"
                Dim usr As New UsrMod
                Dim cons = usr.Consulta(Dgv_SearchInv, sql)
            End If
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
#End Region
End Class