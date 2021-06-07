Public Class Reporte

#Region "Variables"
    Public noprest As String
    Public id_inve As Integer
    Public carne As String
    Public id_esopres As Integer
    Public dec As Integer
    Public codigo As String
#End Region

#Region "Load"
    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If dec = 0 Then
                Dim objreport As New CrystalReportValeDiario
                objreport.SetParameterValue("@NOPREST", noprest)
                CrystalReportViewer1.ReportSource = objreport
            ElseIf dec = 1 Then
                Dim objreport As New CrystalReportValeDiarioInstruc
                objreport.SetParameterValue("@NOPREST", noprest)
                CrystalReportViewer1.ReportSource = objreport
            ElseIf dec = 2 Then
                Dim objreport As New CrystalReportInvenME
                objreport.SetParameterValue("@codigo", codigo)
                CrystalReportViewer1.ReportSource = objreport
            ElseIf dec = 3 Then
                Dim objreport As New CrystalReportValeDiarioLose_Fix
                objreport.SetParameterValue("@noLF", codigo)
                CrystalReportViewer1.ReportSource = objreport
                'ElseIf dec = 4 Then
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