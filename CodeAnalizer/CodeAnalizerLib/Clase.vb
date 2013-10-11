Public Class Clase
    Inherits ElementoLenguaje

    Private _ElementosImportados As List(Of ElementoLenguaje) = Nothing
    Public Property ElementosImportados() As List(Of ElementoLenguaje)
        Get
            Return _ElementosImportados
        End Get
        Set(ByVal value As List(Of ElementoLenguaje))
            _ElementosImportados = value
        End Set
    End Property

    Private _EspacioDeNombres As EspacioNombres
    Public Property EspacioDeNombres() As EspacioNombres
        Get
            Return _EspacioDeNombres
        End Get
        Set(ByVal value As EspacioNombres)
            _EspacioDeNombres = value
        End Set
    End Property

    Private _Modulo As Modulo
    Public Property Modulo() As Modulo
        Get
            Return _Modulo
        End Get
        Set(ByVal value As Modulo)
            _Modulo = value
        End Set
    End Property

    Protected _Atributos As List(Of Attribute) = Nothing
    Public Property Atributos() As List(Of Attribute)
        Get
            Return _Atributos
        End Get
        Set(ByVal value As List(Of Attribute))
            _Atributos = value
        End Set
    End Property

    Protected _ModificadorAcceso As ModificadorAcceso = EnumeracionesAuxiliares.ModificadorAcceso.FriendAccess
    Public Property ModificadorAcceso() As ModificadorAcceso
        Get
            Return _ModificadorAcceso
        End Get
        Set(ByVal value As ModificadorAcceso)
            _ModificadorAcceso = value
        End Set
    End Property

    Protected _Oculta As Boolean = False
    Public Property Oculta() As Boolean
        Get
            Return _Oculta
        End Get
        Set(ByVal value As Boolean)
            _Oculta = value
        End Set
    End Property

    Protected _Herencia As ModificadorHerencia = ModificadorHerencia.NoInheritanceModifier
    Public Property Herencia() As ModificadorHerencia
        Get
            Return _Herencia
        End Get
        Set(ByVal value As ModificadorHerencia)
            _Herencia = value
        End Set
    End Property

    Protected _IsPartial As Boolean = False
    Public Property IsPartial() As Boolean
        Get
            Return _IsPartial
        End Get
        Set(ByVal value As Boolean)
            _IsPartial = value
        End Set
    End Property

    Protected _TiposGenericos As List(Of ParametroDeTipo) = Nothing
    Public Property TiposGenericos() As List(Of ParametroDeTipo)
        Get
            Return _TiposGenericos
        End Get
        Set(ByVal value As List(Of ParametroDeTipo))
            _TiposGenericos = value
        End Set
    End Property

    Private _SuperClase As Clase = Nothing
    Public Property SuperClase() As Clase
        Get
            Return _SuperClase
        End Get
        Set(ByVal value As Clase)
            _SuperClase = value
        End Set
    End Property

    Private _Interfaces As List(Of Interfaz) = Nothing
    Public Property Interfaces() As List(Of Interfaz)
        Get
            Return _Interfaces
        End Get
        Set(ByVal value As List(Of Interfaz))
            _Interfaces = value
        End Set
    End Property

    Private _Codigo As List(Of String)
    Public Property Codigo() As List(Of String)
        Get
            Return _Codigo
        End Get
        Set(ByVal value As List(Of String))
            _Codigo = value
        End Set
    End Property

    Private _SubClases As List(Of Clase) = Nothing
    Public Property SubClases() As List(Of Clase)
        Get
            Return _SubClases
        End Get
        Set(ByVal value As List(Of Clase))
            _SubClases = value
        End Set
    End Property

    Private _Enumeraciones As List(Of Enumeracion) = Nothing
    Public Property Enumeraciones() As List(Of Enumeracion)
        Get
            Return _Enumeraciones
        End Get
        Set(ByVal value As List(Of Enumeracion))
            _Enumeraciones = value
        End Set
    End Property

    Private _Variables As List(Of Variable) = Nothing
    Public Property Variables() As List(Of Variable)
        Get
            Return _Variables
        End Get
        Set(ByVal value As List(Of Variable))
            _Variables = value
        End Set
    End Property

    Private _Estructuras As List(Of Estructura) = Nothing
    Public Property Estructuras() As List(Of Estructura)
        Get
            Return _Estructuras
        End Get
        Set(ByVal value As List(Of Estructura))
            _Estructuras = value
        End Set
    End Property


End Class
