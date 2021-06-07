Public Class SubForm_Profesor
#Region "Variables"
    Dim rs As String
    Dim n As Integer = 0
#End Region

#Region "Load"
    Private Sub SubForm_Profesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet.profesor' Puede moverla o quitarla según sea necesario.
            Me.ProfesorTableAdapter.Fill(Me.BodegaDataSet.profesor)
            MostrarDatos()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Botones"
    'Salir
    Private Sub Pctb_salir_Click(sender As Object, e As EventArgs) Handles Pctb_salir.Click
        Try
            Close()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "CRUD"
    'Guardar
    Private Sub Bf_btnAdd_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Dim ent As New Entdad
        Dim Func As New DAtos
        Try
            If ValidateChildren() = True And TxtDPI1.Text <> "" And TxtDPI2.Text <> "" And TxtDPI3.Text <> "" And Txt_nombre.Text <> "" And Txt_apellido.Text <> "" Then
                rs = TxtDPI3.Text & "-" & TxtDPI2.Text & "-" & TxtDPI1.Text
                ent.DPI = rs
                ent.Nombre = Txt_nombre.Text
                ent.Apellido = Txt_apellido.Text
                ent.Especialidad = Cb_Especiali.Text
                If Func.Profesor(ent) Then
                    MsgBox("Prestamo guardado correctamente ")
                    MostrarDatos()
                Else
                    MsgBox("No se realizó la consulta")
                End If
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    'Mostrar
    Private Sub Bf_btnShow_Click(sender As Object, e As EventArgs) Handles Btn_Mostrar.Click
        Try
            MostrarDatos()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    'Buscar
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Try
            Btn_Search.Visible = False
            Btn_Cancelar.Visible = True
            Lbl_Modobusqueda.Visible = True
            Rbtn_dpi.Visible = True
            Rbtn_nombre.Visible = True
            Rbtn_apellido.Visible = True

            TxtDPI1.Enabled = False
            TxtDPI2.Enabled = False
            TxtDPI3.Enabled = False
            Txt_nombre.Enabled = False
            Txt_apellido.Enabled = False
            Cb_Especiali.Enabled = False
            n = 1
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    'Cancelar
    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Try
            Btn_Search.Visible = True
            Btn_Cancelar.Visible = False
            Lbl_Modobusqueda.Visible = False
            Rbtn_dpi.Visible = False
            Rbtn_nombre.Visible = False
            Rbtn_apellido.Visible = False

            TxtDPI1.Enabled = True
            TxtDPI2.Enabled = True
            TxtDPI3.Enabled = True
            Txt_nombre.Enabled = True
            Txt_apellido.Enabled = True
            Cb_Especiali.Enabled = False
            Limpieza()
            n = 0
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Data"
    Private Sub Dgv_SubPro_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_SubPro.CellDoubleClick
        Try
            Dim nomb As String, ape As String, dpi As String
            Dim frm As Prestamos = CType(Owner, Prestamos)
            dpi = Dgv_SubPro.CurrentRow.Cells(0).Value.ToString
            Dim ArrCadena As String() = dpi.Split(CChar("-"))
            frm.TxtDPI3.Text = ArrCadena(0).ToString
            frm.TxtDPI2.Text = ArrCadena(1).ToString
            frm.TxtDPI1.Text = ArrCadena(2).ToString
            nomb = Dgv_SubPro.CurrentRow.Cells(1).Value.ToString
            ape = Dgv_SubPro.CurrentRow.Cells(2).Value.ToString
            frm.Txt_estudiante.Text = nomb & " , " & ape
            Close()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Eventos"
    Private Sub TxtDPI3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDPI3.KeyPress
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
            ElseIf Char.IsLetter(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permiten Letras")
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub TxtDPI2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDPI2.KeyPress
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
            ElseIf Char.IsLetter(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permiten Letras")
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub TxtDPI1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDPI1.KeyPress
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
            ElseIf Char.IsLetter(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permiten Letras")
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_nombre.KeyPress
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
            ElseIf Char.IsNumber(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permiten Números")
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Txt_apellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_apellido.KeyPress
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
            ElseIf Char.IsNumber(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permiten Números")
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "TextBoxs"
    Private Sub TxtDPI3_TextChanged(sender As Object, e As EventArgs) Handles TxtDPI3.TextChanged
        Try
            If Len(TxtDPI3.Text) = 4 Then
                TxtDPI2.Focus()
            End If
            If Rbtn_dpi.Checked = True Then
                If n = 1 Then
                    Dim sql As String = "select * from profesor where dpi like '" & "%" + TxtDPI3.Text + "%" & "'"
                    Dim usr As New UsrMod
                    Dim cons = usr.Consulta(Dgv_SubPro, sql)
                End If
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub TxtDPI2_TextChanged(sender As Object, e As EventArgs) Handles TxtDPI2.TextChanged
        Try
            If Len(TxtDPI2.Text) = 5 Then
                TxtDPI1.Focus()
            End If
            If Rbtn_dpi.Checked = True Then
                If n = 1 Then
                    Dim sql As String = "select * from profesor where nombre like '" & "%" + TxtDPI3.Text + "-" + TxtDPI2.Text + "%" & "'"
                    Dim usr As New UsrMod
                    Dim cons = usr.Consulta(Dgv_SubPro, sql)
                End If
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub TxtDPI1_TextChanged(sender As Object, e As EventArgs) Handles TxtDPI1.TextChanged
        Try
            If Len(TxtDPI1.Text) = 4 Then
                Txt_nombre.Focus()
            End If
            If Rbtn_dpi.Checked = True Then
                If n = 1 Then
                    Dim sql As String = "select * from profesor where nombre like '" & "%" + TxtDPI3.Text + "-" + TxtDPI2.Text + "-" + TxtDPI1.Text + "%" & "'"
                    Dim usr As New UsrMod
                    Dim cons = usr.Consulta(Dgv_SubPro, sql)
                End If
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles Txt_nombre.TextChanged
        Try
            If Rbtn_nombre.Checked = True Then
                If n = 1 Then
                    Dim sql As String = "select * from profesor where nombre like '" & "%" + Txt_nombre.Text + "%" & "'"
                    Dim usr As New UsrMod
                    Dim cons = usr.Consulta(Dgv_SubPro, sql)
                End If
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Txt_apellido_TextChanged(sender As Object, e As EventArgs) Handles Txt_apellido.TextChanged
        Try
            If Rbtn_apellido.Checked = True Then
                If n = 1 Then
                    Dim sql As String = "select * from profesor where apellido like '" & "%" + Txt_apellido.Text + "%" & "'"
                    Dim usr As New UsrMod
                    Dim cons = usr.Consulta(Dgv_SubPro, sql)
                End If
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "RadioButton"
    Private Sub Rbtn_nombre_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_nombre.CheckedChanged
        Try
            If Rbtn_nombre.Checked = True Then
                Txt_nombre.Enabled = True
                TxtDPI1.Enabled = False
                TxtDPI2.Enabled = False
                TxtDPI3.Enabled = False
                Txt_apellido.Enabled = False
                Txt_nombre.Focus()
            ElseIf Rbtn_nombre.Checked = False Then
                TxtDPI1.Enabled = True
                TxtDPI2.Enabled = True
                TxtDPI3.Enabled = True
                Txt_apellido.Enabled = True
                Limpieza()
                MostrarDatos()
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Rbtn_dpi_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_dpi.CheckedChanged
        Try
            If Rbtn_dpi.Checked = True Then
                TxtDPI1.Enabled = True
                TxtDPI2.Enabled = True
                TxtDPI3.Enabled = True
                Txt_nombre.Enabled = False
                Txt_apellido.Enabled = False
                TxtDPI3.Focus()
            ElseIf Rbtn_dpi.Checked = False Then
                Txt_nombre.Enabled = True
                Txt_apellido.Enabled = True
                Limpieza()
                MostrarDatos()
            End If

        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Rbtn_apellido_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_apellido.CheckedChanged
        Try
            If Rbtn_apellido.Checked = True Then
                Txt_apellido.Enabled = True
                TxtDPI1.Enabled = False
                TxtDPI2.Enabled = False
                TxtDPI3.Enabled = False
                Txt_nombre.Enabled = False
                Txt_apellido.Focus()
            ElseIf Rbtn_apellido.Checked = False Then
                TxtDPI1.Enabled = True
                TxtDPI2.Enabled = True
                TxtDPI3.Enabled = True
                Txt_nombre.Enabled = True
                Limpieza()
                MostrarDatos()
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Métodos"
    Sub MostrarDatos()
        Try
            Dim sql As String = "select * from profesor"
            Dim usr As New UsrMod
            Dim cons = usr.Consulta(Dgv_SubPro, sql)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Sub Limpieza()
        Try
            TxtDPI1.Clear()
            TxtDPI2.Clear()
            TxtDPI3.Clear()
            Txt_nombre.Clear()
            Txt_apellido.Clear()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region
End Class