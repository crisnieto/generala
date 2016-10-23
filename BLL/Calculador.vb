Public Class Calculador
    Public Sub asignarCategorias(jugador As BE.Jugador)
        jugador.categorias = conseguirCategorias()
    End Sub

    Public Sub calcularPosibilidades(dados As List(Of BE.Dado), turno As Turno)
        Dim categorias As List(Of BE.Categoria) = turno.conseguirJugadorActual.categorias
        For Each dado As BE.Dado In dados
            Select Case dado.numero
                Case 1
                    Dim categoria As BE.Categoria = buscarCategoria("1", categorias)
                    If categoria.asignado = False Then
                        categoria.puntos = categoria.puntos + 1
                    End If
                Case 2
                    Dim categoria As BE.Categoria = buscarCategoria("2", categorias)
                    If categoria.asignado = False Then
                        categoria.puntos = categoria.puntos + 2
                    End If
                Case 3
                    Dim categoria As BE.Categoria = buscarCategoria("3", categorias)
                    If categoria.asignado = False Then
                        categoria.puntos = categoria.puntos + 3
                    End If
                Case 4
                    Dim categoria As BE.Categoria = buscarCategoria("4", categorias)
                    If categoria.asignado = False Then
                        categoria.puntos = categoria.puntos + 4
                    End If
                Case 5
                    Dim categoria As BE.Categoria = buscarCategoria("5", categorias)
                    If categoria.asignado = False Then
                        categoria.puntos = categoria.puntos + 5
                    End If
                Case 6
                    Dim categoria As BE.Categoria = buscarCategoria("6", categorias)
                    If categoria.asignado = False Then
                        categoria.puntos = categoria.puntos + 6
                    End If
            End Select
        Next
    End Sub

    Public Function conseguirCategorias() As List(Of BE.Categoria)
        Dim cat1 As New BE.Categoria("1")
        Dim cat2 As New BE.Categoria("2")
        Dim cat3 As New BE.Categoria("3")
        Dim cat4 As New BE.Categoria("4")
        Dim cat5 As New BE.Categoria("5")
        Dim cat6 As New BE.Categoria("6")
        Dim catEscalera As New BE.Categoria("Escalera")
        Dim catFull As New BE.Categoria("Full")
        Dim catPoker As New BE.Categoria("Poker")
        Dim catGenerala As New BE.Categoria("Generala")
        Dim catGeneralaDoble As New BE.Categoria("Generala Doble")
        Dim listaCat As New List(Of BE.Categoria)
        listaCat.Add(cat1)
        listaCat.Add(cat2)
        listaCat.Add(cat3)
        listaCat.Add(cat4)
        listaCat.Add(cat5)
        listaCat.Add(cat6)
        listaCat.Add(catEscalera)
        listaCat.Add(catFull)
        listaCat.Add(catPoker)
        listaCat.Add(catGenerala)
        listaCat.Add(catGeneralaDoble)
        Return listaCat
    End Function

    Public Function buscarCategoria(nombre As String, categorias As List(Of BE.Categoria)) As BE.Categoria
        For Each categoria As BE.Categoria In categorias
            If categoria.nombre = nombre Then
                Return categoria
            End If
        Next
    End Function

    Public Sub borrarCalculos(turno As Turno)
        Dim categorias As List(Of BE.Categoria) = turno.conseguirJugadorActual.categorias
        For Each categoria As BE.Categoria In categorias
            If categoria.asignado = False Then
                categoria.puntos = 0
            End If
        Next
    End Sub

    Public Function calcularEscalera(dados As List(Of BE.Dado), turno As Turno) As Integer

    End Function

    Public Function calcularFull(dados As List(Of BE.Dado), turno As Turno) As Integer

    End Function

    Public Function calcularPoker(dados As List(Of BE.Dado), turno As Turno) As Integer

    End Function

    Public Function calcularGenerala(dados As List(Of BE.Dado), turno As Turno) As Integer

    End Function




End Class
