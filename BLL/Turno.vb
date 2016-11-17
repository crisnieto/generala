Public Class Turno
    Dim turno As New BE.Turno
    Dim jugadorIndice As Integer
    Public Sub New(j As List(Of BE.Jugador))
        jugadorIndice = 0
        turno.jugadores = j
        turno.tiro = 0
        turno.jugadorActual = turno.jugadores(jugadorIndice)
    End Sub

    Public Function calcular() As Boolean
        turno.tiro += 1
        If turno.tiro < 3 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function proximoJugador(partida As BE.Partida) As BE.Jugador
        If checkFinJuego(partida) Then
            partida.empezada = False
            Return turno.jugadorActual
        Else

            Dim cantidad_jugadores As Integer = turno.jugadores.Count
            If jugadorIndice < cantidad_jugadores - 1 Then
                jugadorIndice += 1
            Else
                jugadorIndice = 0
            End If
            turno.jugadorActual = turno.jugadores(jugadorIndice)
            turno.tiro = 0
            Return turno.jugadorActual
        End If

    End Function

    Public Function conseguirJugadorActual() As BE.Jugador
        Return turno.jugadorActual
    End Function

    Public Function numeroTiro() As Integer
        Return turno.tiro
    End Function

    Public Function checkFinJuego(partida As BE.Partida) As Boolean
        Dim jugadores As List(Of BE.Jugador) = turno.jugadores
        Dim finJuego As Boolean = True
        'Checkeo si todas las categorias fueron utilizadas

        Do 'Este Do es un dummy, ya que no encontre manera de romper el For cuando se encuentra la generala Servida.
            For Each jugador As BE.Jugador In jugadores
                For Each categoria As BE.Categoria In jugador.categorias
                    If categoria.asignado = False Then
                        finJuego = False
                    End If
                    If categoria.nombre = "Generala Servida" And categoria.asignado = True And categoria.puntos > 0 Then
                        finJuego = True
                        Exit Do
                    End If
                Next
            Next
        Loop While False

        If finJuego = True Then
            MsgBox("TERMINO EL JUEGO")
            Dim empate As Boolean
            If jugadores(0).puntaje > jugadores(1).puntaje Then
                partida.ganador = jugadores(0)
                jugadores(0).resultado = "G"
                jugadores(1).resultado = "P"

            ElseIf jugadores(0).puntaje < jugadores(1).puntaje Then
                partida.ganador = jugadores(1)
                jugadores(1).resultado = "G"
                jugadores(0).resultado = "P"

            ElseIf jugadores(0).puntaje = jugadores(1).puntaje Then
                jugadores(1).resultado = "E"
                jugadores(0).resultado = "E"
            End If

            If empate Then
                partida.ganador = Nothing
                MsgBox("EL JUEGO TERMINA EMPATADO")
            Else
                MsgBox("EL GANADOR FUE " & partida.ganador.user)
            End If
        End If

        Return finJuego
    End Function

End Class
