Public Class Dado

    Public Sub New()
        numero = 1
        tirado = False
    End Sub

    Private _numero As Integer
    Public Property numero() As Integer
        Get
            Return _numero
        End Get
        Set(ByVal value As Integer)
            _numero = value
        End Set
    End Property

    Private _tirado As Boolean
    Public Property tirado() As Boolean
        Get
            Return _tirado
        End Get
        Set(ByVal value As Boolean)
            _tirado = value
        End Set
    End Property

End Class
