Public Class DADO

    Public Sub New()
        numero = 1
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

End Class
