Public Class Turno
    Private _jugadores As List(Of Jugador)
    Public Property jugadores() As List(Of Jugador)
        Get
            Return _jugadores
        End Get
        Set(ByVal value As List(Of Jugador))
            _jugadores = value
        End Set
    End Property

    Private _tiro As Integer
    Public Property tiro() As Integer
        Get
            Return _tiro
        End Get
        Set(ByVal value As Integer)
            _tiro = value
        End Set
    End Property

    Private _jugadorActual As New Jugador
    Public Property jugadorActual() As Jugador
        Get
            Return _jugadorActual
        End Get
        Set(ByVal value As Jugador)
            _jugadorActual = value
        End Set
    End Property

End Class
