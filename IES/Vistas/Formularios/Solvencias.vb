Public Class Solvencias
#Region "Variables"

#End Region

#Region "Load"
    Private Sub Solvencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet.View_Solven_Profesor' Puede moverla o quitarla según sea necesario.
            Me.View_Solven_ProfesorTableAdapter.Fill(Me.BodegaDataSet.View_Solven_Profesor)
            'TODO: esta línea de código carga datos en la tabla 'BodegaDataSet.View_Solven_Estudiante' Puede moverla o quitarla según sea necesario.
            Me.View_Solven_EstudianteTableAdapter.Fill(Me.BodegaDataSet.View_Solven_Estudiante)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Data"
    Private Sub Dgv_SolveEstudiante_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_SolveEstudiante.CellDoubleClick
        Try
            If MessageBox.Show("¿Desea modificar la fila?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Txt_carnet.Text = Dgv_SolveEstudiante.CurrentRow.Cells(0).Value.ToString
                Txt_nombreEstudiante.Text = Dgv_SolveEstudiante.CurrentRow.Cells(1).Value.ToString
                Txt_PendiEstudiantes.Text = Dgv_SolveEstudiante.CurrentRow.Cells(6).Value.ToString
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un problema: " & ex.Message)
        End Try
    End Sub

    Private Sub Dgv_SolveProfesor_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_SolveProfesor.CellDoubleClick
        Try
            If MessageBox.Show("¿Desea modificar la fila?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim dpi As String
                dpi = Dgv_SolveProfesor.CurrentRow.Cells(0).Value.ToString
                Dim ArrCadena As String() = dpi.Split(CChar("-"))
                TxtDPI3.Text = ArrCadena(0).ToString
                TxtDPI2.Text = ArrCadena(1).ToString
                TxtDPI1.Text = ArrCadena(2).ToString
                Txt_profesor.Text = Dgv_SolveProfesor.CurrentRow.Cells(1).Value.ToString
                Txt_PendiProfesor.Text = Dgv_SolveProfesor.CurrentRow.Cells(3).Value.ToString
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un problema: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Generar-Reporte"
    Private Sub Btn_GReportEstudiante_Click(sender As Object, e As EventArgs) Handles Btn_GReportEstudiante.Click
        Dim frmreport As New Reporte_Solven
        Try
            frmreport.dec = 0
            frmreport.carnet = Txt_carnet.Text
            frmreport.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            frmreport.Dispose()
        End Try
    End Sub
    Private Sub Btn_GReportProfesor_Click(sender As Object, e As EventArgs) Handles Btn_GReportProfesor.Click
        Dim frmreport As New Reporte_Solven
        Try
            Dim dpi As String = TxtDPI3.Text & "-" & TxtDPI2.Text & "-" & TxtDPI1.Text
            frmreport.dec = 1
            frmreport.dpi = dpi
            frmreport.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            frmreport.Dispose()
        End Try
    End Sub
#End Region
End Class