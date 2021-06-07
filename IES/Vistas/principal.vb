Public Class principal

#Region "Load"
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Security()
            Loaduser()
            ManagePermissions()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "MMRS"
    Private Sub Pctb_salir_Click(sender As Object, e As EventArgs) Handles Pctb_salir.Click
        Try
            If MessageBox.Show("Estás seguro de cerrar la aplicación?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Application.Exit()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Pctb_maximizar_Click(sender As Object, e As EventArgs) Handles Pctb_maximizar.Click
        Try
            WindowState = FormWindowState.Maximized
            Pctb_restaurar.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Pctb_minimizar_Click(sender As Object, e As EventArgs) Handles Pctb_minimizar.Click
        Try
            WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Pctb_restaurar_Click(sender As Object, e As EventArgs) Handles Pctb_restaurar.Click
        Try
            WindowState = FormWindowState.Normal
            Pctb_restaurar.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_CierrSesi_Click(sender As Object, e As EventArgs) Handles Btn_CierrSesi.Click
        Try
            If MessageBox.Show("Estás seguro de cerrar la sesión?", "Warning",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Animación"
    Private Sub Pctb_menu_Click(sender As Object, e As EventArgs) Handles Pctb_menu.Click
        Try
            If Bf_slider.Width = 180 Then
                Bf_slider.Visible = False
                Bf_slider.Width = 80
                Pnl_conte_slide.Width = 80
                Bf_animation.Show(Bf_slider)
                Pctb_user.Location = New Point(9, 0)
                Visib()
            Else
                Bf_slider.Visible = False
                Bf_slider.Width = 180
                Pnl_conte_slide.Width = 180
                Bf_animation2.Show(Bf_slider)
                Pctb_user.Location = New Point(55, 0)
                Invisible()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

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
        Dim inv As New Inventario
        Try
            AbFormPanel(inv)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_Usr_Click(sender As Object, e As EventArgs) Handles Btn_Usr.Click
        Dim usu As New Usuarios
        Try
            AbFormPanel(usu)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_Prestamos_Click(sender As Object, e As EventArgs) Handles Btn_Prestamos.Click
        Dim pres As New Prestamos
        Try
            AbFormPanel(pres)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Pctb_settings.Click
        Dim conf As New Configuración
        Try
            AbFormPanel(conf)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_Categorias_Click(sender As Object, e As EventArgs) Handles Btn_Pendientes.Click
        Dim pp As New Perdida_Reparación
        Try
            AbFormPanel(pp)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles Pctb_Agenda.Click
        Dim vis As New Visualizaciones
        Try
            AbFormPanel(vis)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_Solvencias_Click(sender As Object, e As EventArgs) Handles Btn_Solvencias.Click
        Dim solv As New Solvencias
        Try
            AbFormPanel(solv)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "metodos"
    Private Sub Loaduser()
        Try
            Lbl_usr.Text = usr
            Lbl_email.Text = email
            Lbl_tipUsr.Text = tip_usr
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Security()
        Dim user As New UsrMod()
        If user.Anymethod(idusr) = False Then
            MsgBox("Error")
            Close()
        End If
    End Sub
    Private Sub ManagePermissions()
        Try
            If ActiveUser.tip_usr = Cargos.estand Then
                Btn_Usr.Visible = False
                Pnl_Usu.Visible = False
                Pctb_settings.Enabled = False

                Pnl_Pres.Location = New Point(0, 216)
                Btn_Prestamos.Location = New Point(3, 216)
                Pnl_Pendi.Location = New Point(0, 276)
                Btn_Pendientes.Location = New Point(3, 276)
                Pnl_solven.Location = New Point(0, 333)
                Btn_Solvencias.Location = New Point(3, 333)
                Pctb_Agenda.Visible = False
            ElseIf ActiveUser.tip_usr = Cargos.administrator Then

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'example
        'If (ActiveUser.tip_usr = Cargos.estand) Then
        '    btn_Inventario.Enabled = False
        'End If
    End Sub
    Sub Visib()
        Try
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Lbl_usr.Visible = False
            Lbl_tipUsr.Visible = False
            Lbl_email.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Invisible()
        Try
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Lbl_usr.Visible = True
            Lbl_tipUsr.Visible = True
            Lbl_email.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

End Class

