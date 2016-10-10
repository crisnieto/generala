Public Class CUBILETE
    Dim cubilete As New BE.CUBILETE

    Public Sub llenar(dados As List(Of BE.DADO))
        For Each dado As BE.DADO In dados
            cubilete.dados.Add(dado)
        Next

    End Sub

    Public Function volcar() As List(Of BE.DADO)
        Dim dados As New List(Of BE.DADO)
        dados = cubilete.dados
        For Each dado As BE.DADO In dados
            'RANDOMIZO LOS NUMEROS DE CADA DADO
            Randomize()
            Dim numero As Integer = CInt(Int((6 * Rnd()) + 1))
            dado.numero = numero
        Next
        Return dados
    End Function

End Class
