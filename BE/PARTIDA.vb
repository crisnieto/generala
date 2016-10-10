Public Class PARTIDA

    Public Sub New()
        dados.Add(dado1)
        dados.Add(dado2)
        dados.Add(dado3)
        dados.Add(dado4)
        dados.Add(dado5)
    End Sub

    Private _jugador1 As New JUGADOR
    Public Property jugador1() As JUGADOR
        Get
            Return _jugador1
        End Get
        Set(ByVal value As JUGADOR)
            _jugador1 = value
        End Set
    End Property

    Private _jugador2 As New JUGADOR
    Public Property jugador2() As JUGADOR
        Get
            Return _jugador2
        End Get
        Set(ByVal value As JUGADOR)
            _jugador2 = value
        End Set
    End Property

    Private _cubilete As New CUBILETE
    Public Property cubilete() As CUBILETE
        Get
            Return _cubilete
        End Get
        Set(ByVal value As CUBILETE)
            _cubilete = value
        End Set
    End Property

    Private _dado1 As New DADO
    Public Property dado1() As DADO
        Get
            Return _dado1
        End Get
        Set(ByVal value As DADO)
            _dado1 = value
        End Set
    End Property

    Private _dado2 As New DADO
    Public Property dado2() As DADO
        Get
            Return _dado2
        End Get
        Set(ByVal value As DADO)
            _dado2 = value
        End Set
    End Property

    Private _dado3 As New DADO
    Public Property dado3() As DADO
        Get
            Return _dado3
        End Get
        Set(ByVal value As DADO)
            _dado3 = value
        End Set
    End Property

    Private _dado4 As New DADO
    Public Property dado4() As DADO
        Get
            Return _dado4
        End Get
        Set(ByVal value As DADO)
            _dado4 = value
        End Set
    End Property

    Private _dado5 As New DADO
    Public Property dado5() As DADO
        Get
            Return _dado5
        End Get
        Set(ByVal value As DADO)
            _dado5 = value
        End Set
    End Property

    Private _dados As New List(Of DADO)
    Public Property dados() As List(Of DADO)
        Get
            Return _dados
        End Get
        Set(ByVal value As List(Of DADO))
            _dados = value
        End Set
    End Property

End Class
