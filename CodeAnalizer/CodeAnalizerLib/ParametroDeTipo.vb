Public Class ParametroDeTipo

    Private _NombreTipo As String
    Public Property NombreTipo() As String
        Get
            Return _NombreTipo
        End Get
        Set(ByVal value As String)
            _NombreTipo = value
        End Set
    End Property

    Private _Restricciones As ElementoLenguaje
    Public Property Restricciones() As ElementoLenguaje
        Get
            Return _Restricciones
        End Get
        Set(ByVal value As ElementoLenguaje)
            _Restricciones = value
        End Set
    End Property


End Class
