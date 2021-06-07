Public Class Reporte_Solven
#Region "Variables"
    Public dpi As String
    Public carnet As String
    Public dec As Integer
#End Region

#Region "Load"
    Private Sub Reporte_Solven_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If dec = 0 Then
                Dim objreport As New CrystalReportSolvenciasEstudiantes
                objreport.SetParameterValue("@carne", carnet)
                CrystalReportViewer1.ReportSource = objreport
            ElseIf dec = 1 Then
                Dim objreport As New CrystalReportSolvenciasProfesores
                objreport.SetParameterValue("@dpi", dpi)
                CrystalReportViewer1.ReportSource = objreport
            End If
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