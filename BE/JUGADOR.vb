Public Class Jugador

    Public Sub New(Optional usuario As String = "Jugador")
        user = usuario
    End Sub

    Private _user As String
    Public Property user() As String
        Get
            Return _user
        End Get
        Set(ByVal value As String)
            _user = value
        End Set
    End Property

    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _turno As Integer
    Public Property turno() As Integer
        Get
            Return _turno
        End Get
        Set(ByVal value As Integer)
            _turno = value
        End Set
    End Property

    Private _password As String
    Public Property password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property

End Class
