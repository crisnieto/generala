Public Class Partida

    Public Sub New()
        dados.Add(New Dado)
        dados.Add(New Dado)
        dados.Add(New Dado)
        dados.Add(New Dado)
        dados.Add(New Dado)
        jugadores.Add(New Jugador)
        jugadores.Add(New Jugador)
    End Sub

    Private _jugadores As New List(Of Jugador)
    Public Property jugadores() As List(Of Jugador)
        Get
            Return _jugadores
        End Get
        Set(ByVal value As List(Of Jugador))
            _jugadores = value
        End Set
    End Property

    Private _jugador1 As New Jugador
    Public Property jugador1() As Jugador
        Get
            Return _jugador1
        End Get
        Set(ByVal value As Jugador)
            _jugador1 = value
        End Set
    End Property

    Private _jugador2 As New Jugador
    Public Property jugador2() As Jugador
        Get
            Return _jugador2
        End Get
        Set(ByVal value As Jugador)
            _jugador2 = value
        End Set
    End Property

    Private _cubilete As New Cubilete
    Public Property cubilete() As Cubilete
        Get
            Return _cubilete
        End Get
        Set(ByVal value As Cubilete)
            _cubilete = value
        End Set
    End Property

    Private _dados As New List(Of Dado)
    Public Property dados() As List(Of Dado)
        Get
            Return _dados
        End Get
        Set(ByVal value As List(Of Dado))
            _dados = value
        End Set
    End Property
End Class
