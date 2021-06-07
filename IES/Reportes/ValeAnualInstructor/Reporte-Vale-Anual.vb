Public Class Reporte_Vale_Anual

#Region "Variables"

#End Region

#Region "Load"
    Private Sub Reporte_Solven_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Dim objreport As New CrystalReportSolvenciasEstudiantes
            'objreport.SetParameterValue("@carne", carnet)
            'CrystalReportViewer1.ReportSource = objreport
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "S"
    Private Sub Pctb_salir_Click(sender As Object, e As EventArgs) Handles Pctb_salir.Click
        Close()
    End Sub
#End Region
End Class