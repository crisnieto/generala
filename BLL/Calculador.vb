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

        calcularCategoriasComplejas(categorias, dados, turno) 'Calcula las categorías formadas por grupos de dados, desde dobles en adelante

    End Sub

    Public Sub calcularCategoriasComplejas(categorias As List(Of BE.Categoria), dados As List(Of BE.Dado), turno As Turno)

        'Dim cDoble As BE.Categoria = buscarCategoria("Doble", categorias)
        'If cDoble.asignado = False Then
        'cDoble.puntos = calcularDoble(dados, turno)
        'End If

        Dim cEscalera As BE.Categoria = buscarCategoria("Escalera", categorias)
        If cEscalera.asignado = False Then
            cEscalera.puntos = calcularEscalera(dados, turno)
        End If

        Dim cFull As BE.Categoria = buscarCategoria("Full", categorias)
        If cFull.asignado = False Then
            cFull.puntos = calcularFull(dados, turno)
        End If

        Dim cPoker As BE.Categoria = buscarCategoria("Poker", categorias)
        If cPoker.asignado = False Then
            cPoker.puntos = calcularPoker(dados, turno)
        End If

        Dim cGenerala As BE.Categoria = buscarCategoria("Generala", categorias)

        Dim cGeneralaDoble As BE.Categoria = buscarCategoria("Generala Doble", categorias)
        If cGeneralaDoble.asignado = False And turno.numeroTiro > 1 And cGenerala.asignado = True Then
            cGeneralaDoble.puntos = calcularGenerala(dados, turno) * 2
        End If

        Dim cGeneralaServida As BE.Categoria = buscarCategoria("Generala Servida", categorias)
        If cGeneralaServida.asignado = False And turno.numeroTiro = 1 Then
            cGeneralaServida.puntos = calcularGenerala(dados, turno) * 200
        End If

        If cGenerala.asignado = False And turno.numeroTiro > 1 Then
            cGenerala.puntos = calcularGenerala(dados, turno)
        End If

    End Sub

    Public Function conseguirCategorias() As List(Of BE.Categoria)
        Dim cat1 As New BE.Categoria("1")
        Dim cat2 As New BE.Categoria("2")
        Dim cat3 As New BE.Categoria("3")
        Dim cat4 As New BE.Categoria("4")
        Dim cat5 As New BE.Categoria("5")
        Dim cat6 As New BE.Categoria("6")
        'Dim catDoble As New BE.Categoria("Doble")
        Dim catEscalera As New BE.Categoria("Escalera")
        Dim catFull As New BE.Categoria("Full")
        Dim catPoker As New BE.Categoria("Poker")
        Dim catGenerala As New BE.Categoria("Generala")
        Dim catGeneralaDoble As New BE.Categoria("Generala Doble")
        Dim catGeneralaServida As New BE.Categoria("Generala Servida")
        Dim listaCat As New List(Of BE.Categoria)
        listaCat.Add(cat1)
        listaCat.Add(cat2)
        listaCat.Add(cat3)
        listaCat.Add(cat4)
        listaCat.Add(cat5)
        listaCat.Add(cat6)
        'listaCat.Add(catDoble)
        listaCat.Add(catEscalera)
        listaCat.Add(catFull)
        listaCat.Add(catPoker)
        listaCat.Add(catGenerala)
        listaCat.Add(catGeneralaDoble)
        listaCat.Add(catGeneralaServida)
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

    Public Function calcularDoble(dados As List(Of BE.Dado), turno As Turno) As Integer
        Dim grupos As Hashtable = calcularGrupos(dados)
        Dim puntos As Integer
        Dim g1 As Boolean = False 'Primer grupo de 2 dados
        Dim g2 As Boolean = False 'Segundo grupo de 2 dados

        For Each grupo As DictionaryEntry In grupos
            If grupo.Value = 2 And g1 = False Then
                g1 = True
                Continue For
            End If
            If grupo.Value = 2 Then
                g2 = True
            End If
        Next
        Debug.Print(g1)
        Debug.Print(g2)
        If g1 And g2 Then
            puntos = 10
        End If
        If calcularServida(turno) And puntos > 0 Then
            puntos = puntos + 5
        End If
        Return puntos

    End Function

    Public Function calcularEscalera(dados As List(Of BE.Dado), turno As Turno) As Integer
        Dim puntos As Integer
        Dim valores As New List(Of Integer)
        For Each dado As BE.Dado In dados
            valores.Add(dado.numero)
        Next
        If valores.Contains(1) And valores.Contains(2) And valores.Contains(3) And valores.Contains(4) And valores.Contains(5) Then
            puntos = 20
        ElseIf valores.Contains(2) And valores.Contains(3) And valores.Contains(4) And valores.Contains(5) And valores.Contains(6) Then
            puntos = 20
        ElseIf valores.Contains(3) And valores.Contains(4) And valores.Contains(5) And valores.Contains(6) And valores.Contains(1) Then
            puntos = 20
        End If

        If calcularServida(turno) And puntos > 0 Then
            puntos = puntos + 5
        End If
        Return puntos
    End Function

    Public Function calcularFull(dados As List(Of BE.Dado), turno As Turno) As Integer
        Dim grupos As Hashtable = calcularGrupos(dados)
        Dim puntos As Integer
        Dim g1 As Boolean
        Dim g2 As Boolean
        For Each grupo As DictionaryEntry In grupos
            If grupo.Value = 3 Then
                g1 = True
            End If
            If grupo.Value = 2 Then
                g2 = True
            End If
        Next
        Debug.Print(g1)
        Debug.Print(g2)
        If g1 And g2 Then
            puntos = 30
        End If
        If calcularServida(turno) And puntos > 0 Then
            puntos = puntos + 5
        End If
        Return puntos

    End Function

    Public Function calcularPoker(dados As List(Of BE.Dado), turno As Turno) As Integer
        Dim grupos As Hashtable = calcularGrupos(dados)
        Dim puntos As Integer
        Dim g1 As Boolean
        For Each grupo As DictionaryEntry In grupos
            If grupo.Value = 4 Then
                g1 = True
            End If
        Next
        Debug.Print(g1)
        If g1 Then
            puntos = 40
        End If
        If calcularServida(turno) And puntos > 0 Then
            puntos = puntos + 5
        End If
        Return puntos
    End Function

    Public Function calcularGenerala(dados As List(Of BE.Dado), turno As Turno) As Integer
        Dim grupos As Hashtable = calcularGrupos(dados)
        Dim puntos As Integer
        Dim g1 As Boolean
        For Each grupo As DictionaryEntry In grupos
            If grupo.Value = 5 Then
                g1 = True
            End If
        Next
        Debug.Print(g1)
        If g1 Then
            puntos = 50
        End If
        Return puntos
    End Function

    Public Function calcularServida(turno As Turno) As Boolean
        If turno.numeroTiro = 1 Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function calcularGrupos(dados As List(Of BE.Dado)) As Hashtable

        Dim grupos As New Hashtable
        grupos.Add("1", 0)
        grupos.Add("2", 0)
        grupos.Add("3", 0)
        grupos.Add("4", 0)
        grupos.Add("5", 0)

        For Each dado As BE.Dado In dados
            If dado.numero = 1 Then
                grupos("1") += 1
            End If
            If dado.numero = 2 Then
                grupos("2") += 1
            End If
            If dado.numero = 3 Then
                grupos("3") += 1
            End If
            If dado.numero = 4 Then
                grupos("4") += 1
            End If
            If dado.numero = 5 Then
                grupos("5") += 1
            End If
            If dado.numero = 6 Then
                grupos("6") += 1
            End If
        Next
        Return grupos
    End Function

    Public Sub calcularPuntajes(partida As BE.Partida)
        For Each jugador As BE.Jugador In partida.jugadores
            Dim puntaje As Integer = 0
            For Each categoria As BE.Categoria In jugador.categorias
                If categoria.asignado = True Then
                    puntaje = puntaje + categoria.puntos
                End If
            Next
            jugador.puntaje = puntaje
        Next
    End Sub
End Class
