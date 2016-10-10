Public Class CUBILETE
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
