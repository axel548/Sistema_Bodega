Imports System.Data
Imports System.IO
Imports System.Data.SqlClient

Public Class DAtos
    Inherits DatosConexion
    'Segunda capa: proceso de almacenamiento con variables VB y SQL Server'
    'Capa en la cual se distribuyen las funciones y demás en regiones para poder,
    'llevar mejor el control del código.

#Region "Validaciones"
    'Función para Login
    Public Function Login(usr As String, pssw As String) As Boolean
        'Obtención del método de la clase DatosConexion'
        Using connection = Getconection()
            connection.Open()
            Using comand = New SqlCommand()
                With comand
                    .Connection = connection
                    '.CommandText = "SELECT PWDCOMPARE( CAST(@usr,@passw) ,PWDENCRYPT( CAST(@usuario, @password))) from usuarios"
                    .CommandText = "select * from usuarios where usr=@usr and passw=@pass"
                    .Parameters.AddWithValue("@usr", usr)
                    .Parameters.AddWithValue("@pass", pssw)
                    .CommandType = CommandType.Text
                End With
                'Lector y ejecución del comando'
                Dim reader = comand.ExecuteReader()
                If reader.HasRows Then 'Verifica de filas, y retorno Booleano'
                    While reader.Read()
                        ActiveUser.idusr = reader.GetInt32(0)
                        ActiveUser.usr = reader.GetString(4)
                        ActiveUser.email = reader.GetString(3)
                        ActiveUser.tip_usr = reader.GetString(6)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function


    'Función Usuario Existente
    Public Function ExistsUser(id As Integer) As Boolean
        Using connection = Getconection()
            connection.Open()
            'Uso de la conexion y la sentencia'
            Using comand = New SqlCommand()
                comand.Connection = connection
                comand.CommandText = "select * from usuarios where id_usr = @usr"
                comand.Parameters.AddWithValue("@usr", id)
                comand.CommandType = CommandType.Text
                'Lector y ejecución del comando'
                Dim reader = comand.ExecuteReader()
                If reader.HasRows Then 'Verifica de filas, y retorno Booleano'
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function


    'Metodo de Cargos
    Public Sub Anymethod2()
        If ActiveUser.tip_usr = Cargos.administrator Then
        End If
        If ActiveUser.tip_usr = Cargos.estand Then
        End If
    End Sub


    'Función Existencia
    Public Function Conec() As Boolean
        Try
            Using cn = Getconection()
                cn.Open()
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Función Cobro
    Public Function Cobro(estado As String, codigo As String) As Boolean
        Using connection = Getconection()
            connection.Open()
            Using comand = New SqlCommand()
                With comand
                    .Connection = connection
                    .CommandText = "select prec_unit from " + estado + "  where codigo = @codigo"
                    .Parameters.AddWithValue("@codigo", codigo)
                    .CommandType = CommandType.Text
                End With
                'Lector y ejecución del comando'
                Dim reader = comand.ExecuteReader()
                If reader.HasRows Then 'Verifica de filas, y retorno Booleano'
                    While reader.Read()
                        ActiveUser.cobro = reader.GetDouble(9)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function
#End Region


#Region "Prestamos"
    'Función de Insertado para Prestamos 
    Public Function InsertadoPrestamoEstudiante(ByVal ent As Entdad) As Boolean
        Using conec = Getconection()
            conec.Open()
            Try
                Using cmd = New SqlCommand("ADDPrestamoEstudiante", conec)
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@noprest", ent.Noprest)
                        .Parameters.AddWithValue("@codigo", ent.Codigo)
                        .Parameters.AddWithValue("@articculo", ent.Articulo)
                        .Parameters.AddWithValue("@nombre", ent.Nombre)
                        .Parameters.AddWithValue("@carne", ent.Carne)
                        .Parameters.AddWithValue("@profeautoriza", ent.Autorizacion)
                        .Parameters.AddWithValue("@cantidad", ent.Cantidad)
                        .Parameters.AddWithValue("@estado_cod", ent.Estado)
                        .Parameters.AddWithValue("@estado_pres", ent.EstadoPres)
                        .Parameters.AddWithValue("@fec_prest", ent.FechPrestamo)
                        .Parameters.AddWithValue("@fec_dev", ent.FechDev)
                        .Parameters.AddWithValue("@obser_pr", ent.Observacion)
                    End With
                    If CBool(cmd.ExecuteNonQuery()) Then
                        Return True
                    Else
                        Return False
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            Finally
                conec.Close()
            End Try
        End Using
    End Function
    Public Function InsertadoPrestamoProfesor(ByVal ent As Entdad) As Boolean
        Using conec = Getconection()
            conec.Open()
            Try
                Using cmd = New SqlCommand("ADDPrestamoProfesor", conec)
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@noprest", ent.Noprest)
                        .Parameters.AddWithValue("@codigo", ent.Codigo)
                        .Parameters.AddWithValue("@articulo", ent.Articulo)
                        .Parameters.AddWithValue("@nombre", ent.Nombre)
                        .Parameters.AddWithValue("@dpi", ent.DPI)
                        .Parameters.AddWithValue("@cantidad", ent.Cantidad)
                        .Parameters.AddWithValue("@estado_cod", ent.Estado)
                        .Parameters.AddWithValue("@estado_pres", ent.EstadoPres)
                        .Parameters.AddWithValue("@fec_prest", ent.FechPrestamo)
                        .Parameters.AddWithValue("@fec_dev", ent.FechDev)
                        .Parameters.AddWithValue("@obser_pr", ent.Observacion)
                    End With
                    If CBool(cmd.ExecuteNonQuery()) Then
                        Return True
                    Else
                        Return False
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            Finally
                conec.Close()
            End Try
        End Using
    End Function

    'Función de Actualización para Prestamos
    Public Function UpdateDevolucionEstudiante(ByVal ent As Entdad) As Boolean
        Dim cmd As SqlCommand
        Using conec = Getconection()
            conec.Open()
            Try
                cmd = New SqlCommand("UpdateDevolucionEstudiante", conec) With {
                    .CommandType = CommandType.StoredProcedure
                }
                With cmd.Parameters
                    .AddWithValue("@noprest", ent.Noprest)
                    .AddWithValue("@estado_pres", ent.EstadoPres)
                    .AddWithValue("@codigo", ent.Codigo)
                    .AddWithValue("@fec_dev", ent.FechDev)
                    .AddWithValue("@persona", ent.Persona)
                    .AddWithValue("@tipo", ent.Tipo)
                End With
                If CBool(cmd.ExecuteNonQuery()) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            Finally
                conec.Close()
            End Try
        End Using
    End Function
    Public Function UpdateReparacionEstudiante(ByVal ent As Entdad) As Boolean
        Dim cmd As SqlCommand
        Using conec = Getconection()
            conec.Open()
            Try
                cmd = New SqlCommand("UpdateReparacionEstudiante", conec) With {
                    .CommandType = CommandType.StoredProcedure
                }
                With cmd.Parameters
                    .AddWithValue("@noprest", ent.Noprest)
                    .AddWithValue("@no_LF", ent.NoLF)
                    .AddWithValue("@estado_pres", ent.EstadoPres)
                    .AddWithValue("@codigo", ent.Codigo)
                    .AddWithValue("@fec_dev", ent.FechDev)
                    .AddWithValue("@cantfix", ent.Cantidad_Fix)
                    .AddWithValue("@cantDev", ent.Cantidad_Prestada)
                    .AddWithValue("@carne", ent.Carne)
                    .AddWithValue("@total", ent.Total)
                    .AddWithValue("@persona", ent.Persona)
                    .AddWithValue("@tipo", ent.Tipo)
                End With
                If CBool(cmd.ExecuteNonQuery()) Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            Finally
                conec.Close()
            End Try
        End Using
    End Function
#End Region


#Region "Estudiante - Profesor"
    'Función de Estudiante
    Public Function Estudiante(ByVal ent As Entdad) As Boolean
        Using conec = Getconection()
            conec.Open()
            Try
                Using cmd = New SqlCommand("ADDEstudiante", conec) With {
                    .CommandType = CommandType.StoredProcedure
                }
                    With cmd.Parameters
                        .AddWithValue("@carne", ent.Carne)
                        .AddWithValue("@nombre", ent.Nombre)
                        .AddWithValue("@apellido", ent.Apellido)
                        .AddWithValue("@especialidad", ent.Especialidad)
                        .AddWithValue("@grado", ent.Grado)
                        .AddWithValue("@seccion", ent.Seccion)
                    End With
                    If CBool(cmd.ExecuteNonQuery()) Then
                        Return True
                    Else
                        Return False
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            Finally
                conec.Close()
            End Try
        End Using
    End Function
    Public Function ActualizarEstudiante(ByVal ent As Entdad) As Boolean
        Using conec = Getconection()
            conec.Open()
            Try
                Using cmd = New SqlCommand("UPDATEEstudiante", conec) With {
                    .CommandType = CommandType.StoredProcedure
                }
                    With cmd.Parameters
                        .AddWithValue("@carne", ent.Carne)
                        .AddWithValue("@nombre", ent.Nombre)
                        .AddWithValue("@apellido", ent.Apellido)
                        .AddWithValue("@especialidad", ent.Especialidad)
                        .AddWithValue("@grado", ent.Grado)
                        .AddWithValue("@seccion", ent.Seccion)
                    End With
                    If CBool(cmd.ExecuteNonQuery()) Then
                        Return True
                    Else
                        Return False
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            Finally
                conec.Close()
            End Try
        End Using
    End Function

    'Función de Profesores
    Public Function Profesor(ByVal ent As Entdad) As Boolean
        Using conec = Getconection()
            conec.Open()
            Try
                Using cmd = New SqlCommand("ADDProfesor", conec) With {
                    .CommandType = CommandType.StoredProcedure
                }
                    With cmd.Parameters
                        .AddWithValue("@dpi", ent.DPI)
                        .AddWithValue("@nombre", ent.Nombre)
                        .AddWithValue("@apellido", ent.Apellido)
                        .AddWithValue("@especialidad", ent.Especialidad)
                    End With
                    If CBool(cmd.ExecuteNonQuery()) Then
                        Return True
                    Else
                        Return False
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            Finally
                conec.Close()
            End Try
        End Using
    End Function
    Public Function ActualizarProfesor(ByVal ent As Entdad) As Boolean
        Using conec = Getconection()
            conec.Open()
            Try
                Using cmd = New SqlCommand("UPDATEProfesor", conec) With {
                    .CommandType = CommandType.StoredProcedure
                }
                    With cmd.Parameters
                        .AddWithValue("@dpi", ent.DPI)
                        .AddWithValue("@nombre", ent.Nombre)
                        .AddWithValue("@apellido", ent.Apellido)
                        .AddWithValue("@especialidad", ent.Especialidad)
                    End With
                    If CBool(cmd.ExecuteNonQuery()) Then
                        Return True
                    Else
                        Return False
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            Finally
                conec.Close()
            End Try
        End Using
    End Function
#End Region


#Region "Correo Eléctronico"
    'Función De Verificación De Correo
    Public Function Correo(id_a As Integer) As Boolean
        Using connection = Getconection()
            connection.Open()
            Using comand = New SqlCommand()
                With comand
                    .Connection = connection
                    .CommandText = "select * from CorreoElectronico  where id = @id"
                    .Parameters.AddWithValue("@id", id_a)
                    .CommandType = CommandType.Text
                End With
                'Lector y ejecución del comando'
                Dim reader = comand.ExecuteReader()
                If reader.HasRows Then 'Verifica de filas, y retorno Booleano'
                    While reader.Read()
                        ActiveUser.correo = reader.GetString(1)
                        ActiveUser.passw = reader.GetString(2)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function


    'Función De Actualización de Correo Electrónico
    Public Function ActualizarCorreo(ByVal ent As Entdad) As Boolean
        Using conec = Getconection()
            conec.Open()
            Try
                Using cmd = New SqlCommand("UPDATEce", conec)
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@id", ent.Id)
                        .Parameters.AddWithValue("@email", ent.Email)
                        .Parameters.AddWithValue("@passw", ent.Passw)
                    End With
                    If CBool(cmd.ExecuteNonQuery) Then
                        Return True
                    Else
                        Return False
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            Finally
                conec.Close()
            End Try
        End Using
    End Function


    'Función Recuperación de Correo Electrónico
    Public Function RequestUserPassword(requesting As String) As String
        Using conec = Getconection()
            conec.Open()
            Try
                Using cmd = New SqlCommand()
                    With cmd
                        .Connection = conec
                        .CommandText = "select * from usuarios where usr=@user or email = @mail"
                        .Parameters.AddWithValue("@user", requesting)
                        .Parameters.AddWithValue("@mail", requesting)
                        .CommandType = CommandType.Text
                    End With
                    'Dim reader As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    If reader.Read() = True Then
                        Dim userName = reader.GetString(1) & ", " & reader.GetString(2)
                        Dim userMail = reader.GetString(3)
                        Dim userPassword = reader.GetString(5)

                        Dim mailSupport As New SystemSupportMail()

                        mailSupport.SendMail(subject:="SYSTEM: Password recovery request",
                                             body:="Hi" & userName & vbNewLine & "you requested to recover your password." & vbNewLine &
                                             "Your current password is: " & userPassword & vbNewLine &
                                             "However, we ask that you change your password inmediately once you enter the system.",
                                             receivermail:=New List(Of String) From {userMail})
                        Return "Hi " & userName & "you requested to recover your password." & vbNewLine &
                                "Please check your email: " & userMail & vbNewLine &
                                "However, we ask that you change your password inmediately once you enter the system."
                    Else
                        Return "Sorry, you don't have an account with that email or username"
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return CType(False, String)
            End Try
        End Using
    End Function
#End Region


#Region "Inventario"
    'Función Ingreso de Inventario-Activo
    Public Function RIAC(ByVal ent As Entdad) As Boolean
        Dim cmd As SqlCommand
        Using conec = Getconection()
            conec.Open()
            Try
                cmd = New SqlCommand("ADDInvAc", conec) With {
                    .CommandType = CommandType.StoredProcedure
                }
                With cmd.Parameters
                    .AddWithValue("@codigo", ent.Codigo)
                    .AddWithValue("@nombre", ent.Nombre)
                    .AddWithValue("@imagen", ent.Foto)
                    .AddWithValue("@estado", ent.Estado)
                    .AddWithValue("@subestado", ent.Sub_Estado)
                    .AddWithValue("@obser", ent.Observacion)
                    .AddWithValue("@categoria", ent.Categoria)
                    .AddWithValue("@sub_cat", ent.Sub_categoria)
                    .AddWithValue("@cant", ent.Cantidad)
                    .AddWithValue("@precuni", ent.Preciounidad)
                    .AddWithValue("@total", ent.Total)
                End With
                If CBool(cmd.ExecuteNonQuery()) Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            Finally
                conec.Close()
            End Try
        End Using
    End Function
    'Función Actualización de Inventario-Activo
    Public Function RUAC(ByVal ent As Entdad) As Boolean
        Dim cmd As SqlCommand
        Using conec = Getconection()
            conec.Open()
            Try
                cmd = New SqlCommand("UPDATEInvAc", conec) With {
                    .CommandType = CommandType.StoredProcedure
                }
                With cmd.Parameters
                    .AddWithValue("@codigo", ent.Codigo)
                    .AddWithValue("@nombre", ent.Nombre)
                    .AddWithValue("@imagen", ent.Foto)
                    .AddWithValue("@estado", ent.Estado)
                    .AddWithValue("@subestado", ent.Sub_Estado)
                    .AddWithValue("@obser", ent.Observacion)
                    .AddWithValue("@categoria", ent.Categoria)
                    .AddWithValue("@sub_cat", ent.Sub_categoria)
                    .AddWithValue("@cant", ent.Cantidad)
                    .AddWithValue("@precuni", ent.Preciounidad)
                    .AddWithValue("@total", ent.Total)
                End With
                If CBool(cmd.ExecuteNonQuery()) Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            Finally
                conec.Close()
            End Try
        End Using
    End Function

    '///////////////////////////////////////////////////////
    'Función Ingreso de Inventario-Reserva
    Public Function RIRE(ByVal ent As Entdad) As Boolean
        Dim cmd As SqlCommand
        Using conec = Getconection()
            conec.Open()
            Try
                cmd = New SqlCommand("ADDInvRe", conec) With {
                    .CommandType = CommandType.StoredProcedure
                }
                With cmd.Parameters
                    .AddWithValue("@codigo", ent.Codigo)
                    .AddWithValue("@nombre", ent.Nombre)
                    .AddWithValue("@imagen", ent.Foto)
                    .AddWithValue("@estado", ent.Estado)
                    .AddWithValue("@subestado", ent.Sub_Estado)
                    .AddWithValue("@obser", ent.Observacion)
                    .AddWithValue("@categoria", ent.Categoria)
                    .AddWithValue("@sub_cat", ent.Sub_categoria)
                    .AddWithValue("@cant", ent.Cantidad)
                    .AddWithValue("@precuni", ent.Preciounidad)
                    .AddWithValue("@total", ent.Total)
                End With
                If CBool(cmd.ExecuteNonQuery()) Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            Finally
                conec.Close()
            End Try
        End Using
    End Function
    'Función Actualización de Inventario-Reserva
    Public Function RURE(ByVal ent As Entdad) As Boolean
        Dim cmd As SqlCommand
        Using conec = Getconection()
            conec.Open()
            Try
                cmd = New SqlCommand("UPDATEInvRe", conec) With {
                    .CommandType = CommandType.StoredProcedure
                }
                With cmd.Parameters
                    .AddWithValue("@codigo", ent.Codigo)
                    .AddWithValue("@nombre", ent.Nombre)
                    .AddWithValue("@imagen", ent.Foto)
                    .AddWithValue("@estado", ent.Estado)
                    .AddWithValue("@subestado", ent.Sub_Estado)
                    .AddWithValue("@obser", ent.Observacion)
                    .AddWithValue("@categoria", ent.Categoria)
                    .AddWithValue("@sub_cat", ent.Sub_categoria)
                    .AddWithValue("@cant", ent.Cantidad)
                    .AddWithValue("@precuni", ent.Preciounidad)
                    .AddWithValue("@total", ent.Total)
                End With
                If CBool(cmd.ExecuteNonQuery()) Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            Finally
                conec.Close()
            End Try
        End Using
    End Function

    '///////////////////////////////////////////////////////
    'Función Ingreso de Inventario-Mal Estado
    Public Function RIME(ByVal ent As Entdad) As Boolean
        Dim cmd As SqlCommand
        Using conec = Getconection()
            conec.Open()
            Try
                cmd = New SqlCommand("ADDInvME", conec) With {
                    .CommandType = CommandType.StoredProcedure
                }
                With cmd.Parameters
                    .AddWithValue("@codigo", ent.Codigo)
                    .AddWithValue("@nombre", ent.Nombre)
                    .AddWithValue("@imagen", ent.Foto)
                    .AddWithValue("@estado", ent.Estado)
                    .AddWithValue("@subestado", ent.Sub_Estado)
                    .AddWithValue("@obser", ent.Observacion)
                    .AddWithValue("@categoria", ent.Categoria)
                    .AddWithValue("@sub_cat", ent.Sub_categoria)
                    .AddWithValue("@cant", ent.Cantidad)
                    .AddWithValue("@precuni", ent.Preciounidad)
                    .AddWithValue("@total", ent.Total)
                End With
                If CBool(cmd.ExecuteNonQuery()) Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            Finally
                conec.Close()
            End Try
        End Using
    End Function
    'Función Actualización de Inventario-Mal Estado
    Public Function RUME(ByVal ent As Entdad) As Boolean
        Dim cmd As SqlCommand
        Using conec = Getconection()
            conec.Open()
            Try
                cmd = New SqlCommand("UPDATEInvME", conec) With {
                    .CommandType = CommandType.StoredProcedure
                }
                With cmd.Parameters
                    .AddWithValue("@codigo", ent.Codigo)
                    .AddWithValue("@nombre", ent.Nombre)
                    .AddWithValue("@imagen", ent.Foto)
                    .AddWithValue("@estado", ent.Estado)
                    .AddWithValue("@subestado", ent.Sub_Estado)
                    .AddWithValue("@obser", ent.Observacion)
                    .AddWithValue("@categoria", ent.Categoria)
                    .AddWithValue("@sub_cat", ent.Sub_categoria)
                    .AddWithValue("@cant", ent.Cantidad)
                    .AddWithValue("@precuni", ent.Preciounidad)
                    .AddWithValue("@total", ent.Total)
                End With
                If CBool(cmd.ExecuteNonQuery()) Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            Finally
                conec.Close()
            End Try
        End Using
    End Function
#End Region


#Region "Consultas Dinámicas"
    'Función Consulta
    Public Function Consulta(ByVal tabla As DataGridView, ByVal sql As String) As Boolean

        Dim dt As DataTable
        Using conec = Getconection()
            conec.Open()
            Try
                Using da = New SqlDataAdapter(sql, conec)
                    dt = New DataTable
                    da.Fill(dt)
                    tabla.DataSource = dt
                    Return True
                End Using
            Catch ex As Exception
                Return False
            End Try
            conec.Close()
        End Using
    End Function

#End Region


#Region "Generación Código"

    'Prestamo de Estudiante
    Function GCodPrestamoEstudiante() As String
        Dim codigo As String = ""
        Dim total As Integer = 0
        Try
            Using conec = Getconection()
                conec.Open()

                Using cmd = New SqlCommand("select count(*) as totalregistros from Historial_Prestamos where left(no_prest,2)='PE'", conec)
                    Dim reader = cmd.ExecuteReader()
                    If reader.Read Then
                        total = CInt(reader.Item("totalregistros"))
                        total += 1
                    End If
                    reader.Close()

                    If total < 10 Then
                        codigo = "PE000" + total.ToString
                    ElseIf total < 100 Then
                        codigo = "PE00" + total.ToString
                    ElseIf total < 1000 Then
                        codigo = "PE0" + total.ToString
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return codigo
    End Function

    'Prestamo de Profesor
    Function GCodPrestamoProfesor() As String
        Dim codigo As String = ""
        Dim total As Integer = 0
        Try
            Using conec = Getconection()
                conec.Open()

                Using cmd = New SqlCommand("select count(*) as totalregistros from Historial_Prestamos where left(no_prest,2)='PP'", conec)
                    Dim reader = cmd.ExecuteReader()
                    If reader.Read Then
                        total = CInt(reader.Item("totalregistros"))
                        total += 1
                    End If
                    reader.Close()

                    If total < 10 Then
                        codigo = "PP000" + total.ToString
                    ElseIf total < 100 Then
                        codigo = "PP00" + total.ToString
                    ElseIf total < 1000 Then
                        codigo = "PP0" + total.ToString
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return codigo
    End Function

    'Función Generador de Codigo de Inventario
    Function GenerarCodigo() As String
        Dim codigo As String = ""
        Dim total As Integer = 0
        Try
            Using conec = Getconection()
                conec.Open()

                Using cmd = New SqlCommand("select count(*) as totalregistros from inventario", conec)
                    Dim reader = cmd.ExecuteReader()
                    If reader.Read Then
                        total = CInt(reader.Item("totalregistros"))
                        total += 1
                    End If
                    reader.Close()

                    If total < 10 Then
                        codigo = "AE000" + total.ToString
                    ElseIf total < 100 Then
                        codigo = "AE00" + total.ToString
                    ElseIf total < 1000 Then
                        codigo = "AE0" + total.ToString
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return codigo
    End Function

    Function GcLoseFix() As String
        Dim codigo As String = ""
        Dim total As Integer = 0
        Try
            Using conec = Getconection()
                conec.Open()

                Using cmd = New SqlCommand("select count(*) as totalregistros from lose_fix", conec)
                    Dim reader = cmd.ExecuteReader()
                    If reader.Read Then
                        total = CInt(reader.Item("totalregistros"))
                        total += 1
                    End If
                    reader.Close()

                    If total < 10 Then
                        codigo = "LP000" + total.ToString
                    ElseIf total < 100 Then
                        codigo = "LP00" + total.ToString
                    ElseIf total < 1000 Then
                        codigo = "LP0" + total.ToString
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return codigo
    End Function

    Function ACTIVO() As String
        Dim codigo As String = ""
        Dim total As Integer = 0
        Try
            Using conec = Getconection()
                conec.Open()

                Using cmd = New SqlCommand("select count(*) as totalregistros from View_InerAc", conec)
                    Dim reader = cmd.ExecuteReader()
                    If reader.Read Then
                        total = CInt(reader.Item("totalregistros"))
                        total += 1
                    End If
                    reader.Close()

                    If total < 10 Then
                        codigo = "AC000" + total.ToString
                    ElseIf total < 100 Then
                        codigo = "AC00" + total.ToString
                    ElseIf total < 1000 Then
                        codigo = "AC0" + total.ToString
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return codigo
    End Function
    Function RESERVA() As String
        Dim codigo As String = ""
        Dim total As Integer = 0
        Try
            Using conec = Getconection()
                conec.Open()

                Using cmd = New SqlCommand("select count(*) as totalregistros from View_InerRe", conec)
                    Dim reader = cmd.ExecuteReader()
                    If reader.Read Then
                        total = CInt(reader.Item("totalregistros"))
                        total += 1
                    End If
                    reader.Close()

                    If total < 10 Then
                        codigo = "RE000" + total.ToString
                    ElseIf total < 100 Then
                        codigo = "RE00" + total.ToString
                    ElseIf total < 1000 Then
                        codigo = "RE0" + total.ToString
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return codigo
    End Function
    Function MALESTADO() As String
        Dim codigo As String = ""
        Dim total As Integer = 0
        Try
            Using conec = Getconection()
                conec.Open()

                Using cmd = New SqlCommand("select count(*) as totalregistros from View_InerME", conec)
                    Dim reader = cmd.ExecuteReader()
                    If reader.Read Then
                        total = CInt(reader.Item("totalregistros"))
                        total += 1
                    End If
                    reader.Close()

                    If total < 10 Then
                        codigo = "ME000" + total.ToString
                    ElseIf total < 100 Then
                        codigo = "ME00" + total.ToString
                    ElseIf total < 1000 Then
                        codigo = "ME0" + total.ToString
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return codigo
    End Function
#End Region
End Class

