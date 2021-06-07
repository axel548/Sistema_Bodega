Public Class Perdida_Reparación

#Region "Variables"

#End Region

#Region "Load"
    Private Sub Perdida_Reparación_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet.lose_fix' Puede moverla o quitarla según sea necesario.
            Me.Lose_fixTableAdapter.Fill(Me.BodegaDataSet.lose_fix)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "SA"
    Private Sub Pctb_salir_Click(sender As Object, e As EventArgs) Handles Pctb_salir.Click
        Close()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles Pctb_ayuda.Click
        Ayuda.ShowDialog()
    End Sub
#End Region

#Region "DATA"
    Private Sub Dgv_pendientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Pendientes.CellDoubleClick
        Try
            If MessageBox.Show("¿Desea modificar la fila o generar reporte?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                txt_herramienta.Text = Dgv_Pendientes.CurrentRow.Cells(0).Value.ToString
                Txt_no.Text = Dgv_Pendientes.CurrentRow.Cells(1).Value.ToString
                Txt_codigo.Text = Dgv_Pendientes.CurrentRow.Cells(2).Value.ToString
                Txt_articulo.Text = Dgv_Pendientes.CurrentRow.Cells(3).Value.ToString

                Txt_estudiante.Text = Dgv_Pendientes.CurrentRow.Cells(5).Value.ToString
                Txt_cantHerr.Text = Dgv_Pendientes.CurrentRow.Cells(6).Value.ToString
                Txt_preUnit.Text = Dgv_Pendientes.CurrentRow.Cells(7).Value.ToString
                Txt_total.Text = Dgv_Pendientes.CurrentRow.Cells(8).Value.ToString
                Cb_categoria.Text = Dgv_Pendientes.CurrentRow.Cells(9).Value.ToString
                Cb_estado.Text = Dgv_Pendientes.CurrentRow.Cells(10).Value.ToString
                Cb_tipo.Text = Dgv_Pendientes.CurrentRow.Cells(11).Value.ToString
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Generar-Reporte"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_generarCodigo.Click
        Dim dec As Integer = 3
        Dim frmreport As New Reporte
        Dim codigo As String = txt_herramienta.Text
        frmreport.codigo = codigo
        frmreport.dec = dec
        frmreport.ShowDialog()
    End Sub
#End Region

#Region "Métodos"
    Sub MostrarDatos()
        Try
            Dim sql As String = "select * from lose_fix"
            Dim usr As New UsrMod
            Dim cons = usr.Consulta(Dgv_Pendientes, sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class