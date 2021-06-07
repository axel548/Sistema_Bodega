Imports System.Data.SqlClient
Public Class Usuarios

#Region "Variables"
    Public id As String
    Public nombre As String
    Public apellido As String
    Public email As String
    Public usr As String
    Public contr As String
    Public tipUsr As String
#End Region

#Region "Load"
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet2.usuarios' Puede moverla o quitarla según sea necesario.
            Me.UsuariosTableAdapter2.Fill(Me.BodegaDataSet2.usuarios)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Usuarios_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dgv_usr.Width = Me.Width - 10
    End Sub
#End Region

#Region "botones"
    Private Sub Pctb_salir_Click(sender As Object, e As EventArgs) Handles Pctb_salir.Click
        Try
            Close()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles Pctb_ayuda.Click
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

#Region "CRUD"
    'Buscar
    Private Sub Bf_btnSear_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Try
            Iterador()
        Catch ex As Exception
            MessageBox.Show("Busqueda Fallida, Inserte datos para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    'Guardar
    Private Sub Bf_btnAdd_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Try
            If txt_nom.Text = "" Or txt_apellido.Text = "" Or txt_email.Text = "" Or txt_usr.Text = "" Or txt_contr.Text = "" Or cb_tipUsr.Text = "" Then
                MsgBox("No se permite espacios en blanco")
                Faltante()
            Else
                Dim sql As String = "insert into usuarios values('" + txt_nom.Text + "','" + txt_apellido.Text + "','" + txt_email.Text + "','" + txt_usr.Text + "','" + txt_contr.Text + "','" + cb_tipUsr.Text + "')"
                Dim usr As New UsrMod
                Dim cons = usr.Consulta(Dgv_usr, sql)
                Faltante()
                MostrarDatos()
                Limpieza()
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    'Elimianr
    Private Sub Bf_btnDelet_Click(sender As Object, e As EventArgs) Handles Btn_Delet.Click
        Try
            Dim sql As String = "delete from usuarios where id_usr=" + txt_no.Text
            Dim usr As New UsrMod
            Dim cons = usr.Consulta(Dgv_usr, sql)
            Limpieza()
            MostrarDatos()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    'Modificar
    Private Sub Bf_btnModif_Click(sender As Object, e As EventArgs) Handles Btn_Modif.Click
        Try
            Dim sql As String = "update usuarios set nombre='" + txt_nom.Text + "', apellido='" + txt_apellido.Text + "', email='" + txt_email.Text + "', usr='" + txt_usr.Text + "', passw='" + txt_contr.Text + "', tip_usr='" + cb_tipUsr.Text + "' where id_usr='" + txt_no.Text + "'"
            Dim usr As New UsrMod
            Dim cons = usr.Consulta(Dgv_usr, sql)
            MostrarDatos()
            txt_no.Enabled = True
            Limpieza()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    'Limpieza
    Private Sub Bf_btnClear_Click(sender As Object, e As EventArgs) Handles Btn_Limpiar.Click
        Try
            Limpieza()
            MostrarDatos()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    'Mostrar
    Private Sub BF_btnMostrar_Click(sender As Object, e As EventArgs) Handles Btn_Mostrar.Click
        Try
            MostrarDatos()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Eventos"
    Private Sub Txt_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_no.KeyPress
        Try
            If Char.IsWhiteSpace(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permite espacios")
            ElseIf Char.IsLetter(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permiten letras")
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
    Private Sub Txt_nom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nom.KeyPress
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
    Private Sub Txt_apellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_apellido.KeyPress
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
    Private Sub Txt_email_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_email.KeyPress
        Try
            If Char.IsWhiteSpace(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permite espacios")
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Txt_usr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_usr.KeyPress
        Try
            If Char.IsWhiteSpace(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permite espacios")
            ElseIf Char.IsPunctuation(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permiten Simbolos")
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Txt_contr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_contr.KeyPress
        Try
            If Char.IsWhiteSpace(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permite espacios")
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Chkb_mostrarContra_CheckedChanged(sender As Object, e As EventArgs) Handles Chkb_mostrarContra.CheckedChanged
        Try
            If Chkb_mostrarContra.Checked = True Then
                txt_contr.UseSystemPasswordChar = False
            Else
                txt_contr.UseSystemPasswordChar = True
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Data"
    Private Sub Dgv_usr_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_usr.CellDoubleClick
        Try
            If MessageBox.Show("¿Desea Modificar El Registro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                txt_no.Enabled = False
                Btn_Modif.Enabled = True
                txt_no.Text = Dgv_usr.CurrentRow.Cells(0).Value.ToString()
                txt_nom.Text = Dgv_usr.CurrentRow.Cells(1).Value.ToString()
                txt_apellido.Text = Dgv_usr.CurrentRow.Cells(2).Value.ToString()
                txt_email.Text = Dgv_usr.CurrentRow.Cells(3).Value.ToString()
                txt_usr.Text = Dgv_usr.CurrentRow.Cells(4).Value.ToString()
                txt_contr.Text = Dgv_usr.CurrentRow.Cells(5).Value.ToString()
                cb_tipUsr.Text = Dgv_usr.CurrentRow.Cells(6).Value.ToString()
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub

    '(select * from openrowset(bulk N' dirección de la imagen ', single_blob)as image)
#End Region

#Region "Metodos"
    Sub MostrarDatos()
        Try
            Dim sql As String = "select * from usuarios"
            Dim usr As New UsrMod
            Dim cons = usr.Consulta(Dgv_usr, sql)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Sub Limpieza()
        Try
            txt_no.Clear()
            txt_nom.Clear()
            txt_apellido.Clear()
            txt_email.Clear()
            txt_usr.Clear()
            txt_contr.Clear()
            cb_tipUsr.Text = " "
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Sub Iterador()
        Dim vec() As TextBox = {txt_no, txt_nom, txt_apellido, txt_email, txt_usr}
        Dim usr As New UsrMod
        Try
            For i As Integer = 0 To 5
                If vec(0).Text <> "" AndAlso vec(i).Text = "" Then
                    MessageBox.Show("Buscó por id", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim sql As String = "select * from usuarios where id_usr='" + txt_no.Text + "'"
                    Dim cons = usr.Consulta(Dgv_usr, sql)
                    Exit For
                ElseIf vec(1).Text <> "" AndAlso vec(i).Text = "" Then
                    MessageBox.Show("Buscó por Nombre", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim sql As String = "select * from usuarios where nombre='" + txt_nom.Text + "'"
                    Dim cons = usr.Consulta(Dgv_usr, sql)
                    Exit For
                ElseIf vec(2).Text <> "" AndAlso vec(i).Text = "" Then
                    MessageBox.Show("Buscó por Apellido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim sql As String = "select * from usuarios where apellido='" + txt_apellido.Text + "'"
                    Dim cons = usr.Consulta(Dgv_usr, sql)
                    Exit For
                ElseIf vec(3).Text <> "" AndAlso vec(i).Text = "" Then
                    MessageBox.Show("Buscó por Correo electrónico", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim sql As String = "select * from usuarios where email='" + txt_email.Text + "'"
                    Dim cons = usr.Consulta(Dgv_usr, sql)
                    Exit For
                ElseIf vec(4).Text <> "" AndAlso vec(i).Text = "" Then
                    MessageBox.Show("Buscó por usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim sql As String = "select * from usuarios where usr='" + txt_usr.Text + "'"
                    Dim cons = usr.Consulta(Dgv_usr, sql)
                    Exit For
                ElseIf cb_tipUsr.Text <> "" AndAlso vec(i).Text = "" Then
                    MessageBox.Show("Buscó por Tipo de usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim sql As String = "select * from usuarios where tip_usr='" + cb_tipUsr.Text + "'"
                    Dim cons = usr.Consulta(Dgv_usr, sql)
                    Exit For
                ElseIf vec(i).Text IsNot "" AndAlso cb_tipUsr.Text IsNot "" Then
                    MessageBox.Show("Busqueda exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim sql As String = "select * from usuarios where id_usr='" + txt_no.Text + "'"
                    Dim cons = usr.Consulta(Dgv_usr, sql)
                    Exit For
                ElseIf vec(i).Text = "" AndAlso cb_tipUsr.Text = "" Then
                    MessageBox.Show("Introduzca un valor para buscar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Sub Faltante()
        Try
            If txt_nom.Text = "" Then
                Pctb_Error2.Visible = True
            Else
                Pctb_Error2.Visible = False
            End If
            '
            If txt_apellido.Text = "" Then
                Pctb_Error3.Visible = True
            Else
                Pctb_Error3.Visible = False
            End If
            '
            If txt_email.Text = "" Then
                Pctb_Error4.Visible = True
            Else
                Pctb_Error4.Visible = False
            End If
            '
            If txt_usr.Text = "" Then
                Pctb_Error5.Visible = True
            Else
                Pctb_Error5.Visible = False
            End If
            '
            If txt_contr.Text = "" Then
                Pctb_Error6.Visible = True
            Else
                Pctb_Error6.Visible = False
            End If
            '
            If cb_tipUsr.Text = "" Then
                Pctb_Error7.Visible = True
            Else
                Pctb_Error7.Visible = False
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try

    End Sub
#End Region

End Class
