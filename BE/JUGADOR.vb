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

    Private _categorias As List(Of Categoria)
    Public Property categorias() As List(Of Categoria)
        Get
            Return _categorias
        End Get
        Set(ByVal value As List(Of Categoria))
            _categorias = value
        End Set
    End Property

    Private _puntaje As Integer
    Public Property puntaje() As Integer
        Get
            Return _puntaje
        End Get
        Set(ByVal value As Integer)
            _puntaje = value
        End Set
    End Property

    Private _logged As Boolean
    Public Property logged() As Boolean
        Get
            Return _logged
        End Get
        Set(ByVal value As Boolean)
            _logged = value
        End Set
    End Property

    Private _resultado As String
    Public Property resultado() As String
        Get
            Return _resultado
        End Get
        Set(ByVal value As String)
            _resultado = value
        End Set
    End Property

End Class
