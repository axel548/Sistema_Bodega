Public Class UsrMod
    'Primera capa: Creación de función retorno booleano de Vistas'
    Dim datos As New DAtos()

    Public Function RecoverPassword(requesting As String) As String
        Return datos.RequestUserPassword(requesting)
    End Function
    Public Function Login(usr As String, pssw As String) As Boolean
        Return datos.Login(usr, pssw)
    End Function
    Public Function Correo(id_a As Integer) As Boolean
        Return datos.Correo(id_a)
    End Function
    Public Function Consulta(tabla As DataGridView, sql As String) As Boolean
        Return datos.Consulta(tabla, sql)
    End Function
    Public Function Cobro_LF(estado As String, codigo As String) As Boolean
        Return datos.Cobro(estado, codigo)
    End Function
    Public Function Anymethod(id As Integer) As Boolean
        If ActiveUser.idusr >= 1 Then
            If datos.ExistsUser(ActiveUser.idusr) = True Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
    Public Sub Anymethod2()
        If ActiveUser.tip_usr = Cargos.administrator Then

        End If
        If ActiveUser.tip_usr = Cargos.estand Then

        End If
    End Sub

End Class
