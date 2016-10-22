Public Class Cubilete
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
