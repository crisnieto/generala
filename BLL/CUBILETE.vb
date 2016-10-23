Public Class CUBILETE
    Dim cubilete As New BE.Cubilete

    Public Sub llenar(dados As List(Of BE.Dado))
        For Each dado As BE.Dado In dados
            cubilete.dados.Add(dado)
        Next
    End Sub

    Public Function enviar(dado As BE.Dado) As Boolean
        'Este metodo se encarga tanto de agregar un dado al cubilete como quitarlo en caso de arrepentirse
        If dado.tirado = True Then
            dado.tirado = False
            cubilete.dados.Add(dado)
            Debug.Print("AGREGADO")
            Return True
        ElseIf dado.tirado = False Then
            cubilete.dados.Remove(dado)
            dado.tirado = True
            Debug.Print("QUITADO")
            Return False
        End If
        Return Nothing
    End Function

    Public Function volcar() As List(Of BE.Dado)
        Dim dados As New List(Of BE.Dado)
        dados = cubilete.dados
        For Each dado As BE.Dado In dados
            'Randomizo los numeros de cada dado que se encuentran en el cubilete
            Randomize()
            Dim numero As Integer = CInt(Int((6 * Rnd()) + 1))
            dado.numero = numero
            dado.tirado = True
        Next
        Return dados
    End Function

    Public Sub vaciar()
        cubilete.dados = Nothing
        cubilete.dados = New List(Of BE.Dado)
    End Sub

    Public Function tieneContenido() As Boolean
        If cubilete.dados.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class