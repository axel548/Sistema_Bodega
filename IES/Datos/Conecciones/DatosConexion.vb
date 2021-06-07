Imports System.Data.SqlClient
'Primera capa: conexión a la base de datos'
Public Class DatosConexion
    Private conexion As String
    'conexion de una variable publica'
    Protected Sub New()
        conexion = My.Settings.cadconex
    End Sub
    'función protegido para retornar la conexión'
    Protected Function Getconection() As SqlConnection
        Return New SqlConnection(conexion)
    End Function
End Class
