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

    Public Function proximoJugador() As BE.Jugador
        Dim cantidad_jugadores As Integer = turno.jugadores.Count
        If jugadorIndice < cantidad_jugadores - 1 Then
            jugadorIndice += 1
        Else
            jugadorIndice = 0
        End If
        turno.jugadorActual = turno.jugadores(jugadorIndice)
        turno.tiro = 0
        Return turno.jugadorActual
    End Function

    Public Function conseguirJugadorActual() As BE.Jugador
        Return turno.jugadorActual
    End Function

    Public Function numeroTiro() As Integer
        Return turno.tiro
    End Function




End Class
