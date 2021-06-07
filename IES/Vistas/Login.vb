Imports System.ComponentModel
Imports System.Runtime.InteropServices
Public Class Login

#Region "Dll"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

    End Sub
#End Region

#Region "MS"
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles pctb_salir.Click
        Try
            If MessageBox.Show("Estás seguro de cerrar la aplicación?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Application.Exit()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles pctb_minimizar.Click
        Try
            WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Login"
    Private Sub Btn_ingresar_Click(sender As Object, e As EventArgs) Handles Btn_ingresar.Click
        Try
            Verificacion()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Txt_contr_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_contr.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Verificacion()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "logout"
    Private Sub Logout(sender As Object, e As FormClosedEventArgs)
        Try
            txt_usr.Clear()
            txt_contr.Clear()
            Show()
            txt_usr.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "EventMove"
    Private Sub Pnl_menu_MouseMove(sender As Object, e As MouseEventArgs) Handles Pnl_menu.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Lbl_inicio_MouseMove(sender As Object, e As MouseEventArgs) Handles Lbl_inicio.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region

#Region "Eventos"
    Private Sub Txt_usr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_usr.KeyPress
        Try
            If Char.IsWhiteSpace(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permite espacios")
            ElseIf Char.IsNumber(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permiten Números")
            ElseIf Char.IsSymbol(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permiten Simbolos")
            ElseIf Char.IsPunctuation(e.KeyChar) Then
                e.Handled = True
                MsgBox("No se permiten Simbolos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Chkb_mostrarContra_CheckedChanged_1(sender As Object, e As EventArgs) Handles Chkb_mostrarContra.CheckedChanged
        Try
            If Chkb_mostrarContra.Checked = True Then
                txt_contr.UseSystemPasswordChar = False
            Else
                txt_contr.UseSystemPasswordChar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Lnklbl_olvContra_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklbl_olvContra.LinkClicked
        Dim frm As New RecvoverPass
        Try
            frm.Show()
            Hide()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub

#End Region

#Region "Metodos"
    Private Sub Ingreso()
        'Uso de la capa modelo y el metodo Login'
        Dim usrModel As New UsrMod
        'Envio de datos'
        Dim validLog = usrModel.Login(txt_usr.Text, txt_contr.Text)
        Dim frm As New principal
        Try
            'Validación Booleana'
            If validLog = True Then
                MessageBox.Show("Hola " & ActiveUser.usr, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frm.Show()
                AddHandler frm.FormClosed, AddressOf Logout
                Hide()
            Else
                MessageBox.Show("Usuario y/o Contraseña" & vbNewLine & "Incorrecta", caption:="Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_contr.Clear()
                txt_contr.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub
    Sub Verificacion()
        Try
            If txt_usr.Text <> "" And txt_contr.Text <> "" Then
                Ingreso()
            ElseIf txt_usr.Text = "" And txt_contr.Text <> "" Then
                MessageBox.Show("El campo de Usuario esta vacío", caption:="Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txt_usr.Text <> "" And txt_contr.Text = "" Then
                MessageBox.Show("El campo de Contraseña esta vacío", caption:="Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txt_usr.Text = "" And txt_contr.Text = "" Then
                MessageBox.Show("Los campos de Usuario " & vbNewLine & "y Contraseña estan vacíos", caption:="Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Txt_usr_KeyUp(keyCode As Integer, Shift As Integer)
        Clipboard.Clear()
        Clipboard.SetText("")
    End Sub

    Private Sub Txt_usr_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
        Clipboard.Clear()
        Clipboard.SetText("")
    End Sub

    Private Sub Txt_usr_TextChanged(sender As Object, e As EventArgs) Handles txt_usr.TextChanged

    End Sub

#End Region
End Class
