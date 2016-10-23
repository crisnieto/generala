Public Class Categoria
    Private _nombre As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _puntos As Integer
    Public Property puntos() As Integer
        Get
            Return _puntos
        End Get
        Set(ByVal value As Integer)
            _puntos = value
        End Set
    End Property

    Private _asignado As Boolean
    Public Property asignado() As Boolean
        Get
            Return _asignado
        End Get
        Set(ByVal value As Boolean)
            _asignado = value
        End Set
    End Property

    Sub New(ncat As String)
        Me.nombre = ncat
    End Sub

End Class
