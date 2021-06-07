Public Class Reporte_Historial_Prestamos
#Region "Variables"
    Public fechinicial As Date
    Public fechfinal As Date
#End Region
#Region "Load"
    Private Sub Reporte_Historial_Prestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreport As New CrystalReportPrestamos
        objreport.SetParameterValue("@fecha_inicial", fechinicial)
        objreport.SetParameterValue("@fecha_final", fechfinal)

        CrystalReportViewer1.ReportSource = objreport
    End Sub
#End Region
#Region "S"
    Private Sub Pctb_salir_Click(sender As Object, e As EventArgs) Handles Pctb_salir.Click
        Close()
    End Sub
#End Region



End Class