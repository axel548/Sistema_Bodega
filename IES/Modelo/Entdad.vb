Public Class Entdad
    Private _nom As String
    Private _foto() As Byte
    Private _estado As String
    Private _subestado As String
    Private _obser As String
    Private _categoria As String
    Private _subcatego As String
    Private _cantidad As Integer
    Private _preciounidad As Double
    Private _total As Double
    Private _codigo As String
    Private _idInventario As Integer
    '///
    Private _email As String
    Private _passw As String
    Private _id As Integer
    '///
    Private _noprest As String
    Private _carne As String
    Private _articulo As String
    Private _autorizacion As String
    'cantidad ya declarado
    'nombre ya declarado
    Private _apellido As String
    Private _especialidad As String
    Private _grado As String
    Private _seccion As String
    Private _estadoPres As String
    Private _fechPres As Date
    Private _fechDev As Date
    'observación ya declarado
    '//
    Private _dpi As String
    '//
    Private _noLf As String
    Private _cantidadPrestada As Integer
    Private _cantidadlose As Integer
    Private _cantidadfix As Integer
    '//
    Private _persona As String
    Private _tipo As String



#Region "Insertado Inventario"
    Public Property Nombre As String
        Get
            Return _nom
        End Get
        Set(value As String)
            _nom = value
        End Set
    End Property

    Public Property Foto As Byte()
        Get
            Return _foto
        End Get
        Set(value As Byte())
            _foto = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property
    Public Property Sub_Estado As String
        Get
            Return _subestado
        End Get
        Set(value As String)
            _subestado = value
        End Set
    End Property
    Public Property Observacion As String
        Get
            Return _obser
        End Get
        Set(value As String)
            _obser = value
        End Set
    End Property

    Public Property Categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property

    Public Property Sub_categoria As String
        Get
            Return _subcatego
        End Get
        Set(value As String)
            _subcatego = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
        End Set
    End Property

    Public Property Preciounidad As Double
        Get
            Return _preciounidad
        End Get
        Set(value As Double)
            _preciounidad = value
        End Set
    End Property

    Public Property Total As Double
        Get
            Return _total
        End Get
        Set(value As Double)
            _total = value
        End Set
    End Property

    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Property IdInventario As Integer
        Get
            Return _idInventario
        End Get
        Set(value As Integer)
            _idInventario = value
        End Set
    End Property
#End Region

#Region "Actualización del Correo"
    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Passw As String
        Get
            Return _passw
        End Get
        Set(value As String)
            _passw = value
        End Set
    End Property

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

#End Region

#Region "Insertado Prestamo Estudiante-Profesor"
    Public Property Noprest As String
        Get
            Return _noprest
        End Get
        Set(value As String)
            _noprest = value
        End Set
    End Property

    Public Property Carne As String
        Get
            Return _carne
        End Get
        Set(value As String)
            _carne = value
        End Set
    End Property
    Public Property DPI As String
        Get
            Return _dpi
        End Get
        Set(value As String)
            _dpi = value
        End Set
    End Property
    Public Property Articulo As String
        Get
            Return _articulo
        End Get
        Set(value As String)
            _articulo = value
        End Set
    End Property
    Public Property Autorizacion As String
        Get
            Return _autorizacion
        End Get
        Set(value As String)
            _autorizacion = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property
    Public Property Especialidad As String
        Get
            Return _especialidad
        End Get
        Set(value As String)
            _especialidad = value
        End Set
    End Property

    Public Property Grado As String
        Get
            Return _grado
        End Get
        Set(value As String)
            _grado = value
        End Set
    End Property

    Public Property Seccion As String
        Get
            Return _seccion
        End Get
        Set(value As String)
            _seccion = value
        End Set
    End Property

    Public Property EstadoPres As String
        Get
            Return _estadoPres
        End Get
        Set(value As String)
            _estadoPres = value
        End Set
    End Property

    Public Property FechPrestamo As Date
        Get
            Return _fechPres
        End Get
        Set(value As Date)
            _fechPres = value
        End Set
    End Property

    Public Property FechDev As Date
        Get
            Return _fechDev
        End Get
        Set(value As Date)
            _fechDev = value
        End Set
    End Property
#End Region

#Region "Herramienta Perdida/Reparación"
    Public Property NoLF As String
        Get
            Return _noLf
        End Get
        Set(value As String)
            _noLf = value
        End Set
    End Property

    Public Property Cantidad_Prestada As Integer
        Get
            Return _cantidadPrestada
        End Get
        Set(value As Integer)
            _cantidadPrestada = value
        End Set
    End Property
    Public Property Cantidad_Lose As Integer
        Get
            Return _cantidadlose
        End Get
        Set(value As Integer)
            _cantidadlose = value
        End Set
    End Property
    Public Property Cantidad_Fix As Integer
        Get
            Return _cantidadfix
        End Get
        Set(value As Integer)
            _cantidadfix = value
        End Set
    End Property

    Public Property Persona As String
        Get
            Return _persona
        End Get
        Set(value As String)
            _persona = value
        End Set
    End Property
    Public Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property
#End Region

End Class
