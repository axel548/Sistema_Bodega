Public Class Reporte_Historiales

#Region "Variables"
    Public fechinicial As Date
    Public fechfinal As Date
    Public tipo As String
    Public categoria As String
    Public sub_categoria As String
    Public dec As Integer
#End Region
#Region "Load"
    Private Sub Reporte_Historiales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            If dec = 0 Then
                Dim objreport As New CrystalReportPrestamos
                objreport.SetParameterValue("@fecha_inicial", fechinicial)
                objreport.SetParameterValue("@fecha_final", fechfinal)
                CrystalReportViewer1.ReportSource = objreport
            ElseIf dec = 1 Then
                Dim objreport As New CrystalReportInv
                objreport.SetParameterValue("@categoria", categoria)
                objreport.SetParameterValue("@subcat", sub_categoria)
                objreport.SetParameterValue("@tipo", tipo)
                CrystalReportViewer1.ReportSource = objreport
            ElseIf dec = 2 Then
                Dim objreport As New CrystalReportInventario
                objreport.SetParameterValue("@fecha_inicial", fechinicial)
                objreport.SetParameterValue("@fecha_final", fechfinal)
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