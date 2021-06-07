Public Class SubForm_Estudiante
#Region "Variables"
    Dim n As Integer = 0
#End Region

#Region "Load"
    Private Sub SubForm_Estudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet.estudiante' Puede moverla o quitarla según sea necesario.
            Me.EstudianteTableAdapter.Fill(Me.BodegaDataSet.estudiante)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Botones"
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
            If ValidateChildren() = True And Txt_carne.Text <> "" And Txt_nombre.Text <> "" Then
                ent.Carne = Txt_carne.Text
                ent.Nombre = Txt_nombre.Text
                ent.Apellido = Txt_apellido.Text
                ent.Especialidad = Cb_Especiali.Text
                ent.Grado = Cb_grado.Text
                ent.Seccion = Cb_secc.Text
                If Func.Estudiante(ent) Then
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
            Rbtn_carne.Visible = True
            Rbtn_nombre.Visible = True
            Rbtn_apellido.Visible = True

            Txt_carne.Enabled = False
            Txt_nombre.Enabled = False
            Txt_apellido.Enabled = False
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
            Rbtn_carne.Visible = False
            Rbtn_nombre.Visible = False
            Rbtn_apellido.Visible = False

            Txt_carne.Enabled = True
            Txt_nombre.Enabled = True
            Txt_apellido.Enabled = True
            Limpieza()
            n = 0
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Data"
    Private Sub Dgv_SubEst_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_SubEst.CellDoubleClick
        Try
            Dim nomb As String, ape As String
            Dim frm As Prestamos = CType(Owner, Prestamos)
            frm.Txt_carne.Text = Dgv_SubEst.CurrentRow.Cells(0).Value.ToString
            nomb = Dgv_SubEst.CurrentRow.Cells(1).Value.ToString
            ape = Dgv_SubEst.CurrentRow.Cells(2).Value.ToString
            frm.Txt_estudiante.Text = nomb & " , " & ape
            Close()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Eventos"
    Private Sub Txt_carne_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_carne.KeyPress
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
    Private Sub Txt_carne_TextChanged(sender As Object, e As EventArgs) Handles Txt_carne.TextChanged
        Try
            If Rbtn_carne.Checked = True Then
                If n = 1 Then
                    Dim sql As String = "select * from estudiante where carne like '" & "%" + Txt_carne.Text + "%" & "'"
                    Dim usr As New UsrMod
                    Dim cons = usr.Consulta(Dgv_SubEst, sql)
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
                    Dim sql As String = "select * from estudiante where nombre like '" & "%" + Txt_nombre.Text + "%" & "'"
                    Dim usr As New UsrMod
                    Dim cons = usr.Consulta(Dgv_SubEst, sql)
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
                    Dim sql As String = "select * from estudiante where apellido like '" & "%" + Txt_apellido.Text + "%" & "'"
                    Dim usr As New UsrMod
                    Dim cons = usr.Consulta(Dgv_SubEst, sql)
                End If
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "RadioButton"
    Private Sub Rbtn_carne_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_carne.CheckedChanged
        Try
            If Rbtn_carne.Checked = True Then
                Txt_carne.Enabled = True
                Txt_nombre.Enabled = False
                Txt_apellido.Enabled = False
                Txt_carne.Focus()
            ElseIf Rbtn_carne.Checked = False Then
                Txt_nombre.Enabled = True
                Txt_apellido.Enabled = True
                Limpieza()
                MostrarDatos()
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Rbtn_nombre_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_nombre.CheckedChanged
        Try
            If Rbtn_nombre.Checked = True Then
                Txt_nombre.Enabled = True
                Txt_carne.Enabled = False
                Txt_apellido.Enabled = False
                Txt_nombre.Focus()
            ElseIf Rbtn_nombre.Checked = False Then
                Txt_carne.Enabled = True
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
                Txt_carne.Enabled = False
                Txt_nombre.Enabled = False
                Txt_apellido.Focus()
            ElseIf Rbtn_apellido.Checked = False Then
                Txt_carne.Enabled = True
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
            Dim sql As String = "select * from estudiante"
            Dim usr As New UsrMod
            Dim cons = usr.Consulta(Dgv_SubEst, sql)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Sub Limpieza()
        Try
            Txt_carne.Clear()
            Txt_nombre.Clear()
            Txt_apellido.Clear()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region
End Class
