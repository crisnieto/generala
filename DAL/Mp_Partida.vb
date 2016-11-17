Imports System.Data.SqlClient
Public Class Mp_Partida
    Dim ac As New Acceso

    Public Function insertar(unPartido As BE.Partida)
        Dim idPartido As Integer = calcularID()

        For Each unJugador As BE.Jugador In unPartido.jugadores
            Dim params(4) As SqlParameter
            Dim id As Integer = calcularID()
            params(0) = New SqlParameter("@id_partido", idPartido)
            params(1) = New SqlParameter("@id_jugador", unJugador.id)
            params(2) = New SqlParameter("@puntaje", unJugador.puntaje)
            params(3) = New SqlParameter("@resultado", unJugador.resultado)
            params(4) = New SqlParameter("@tiempo", unPartido.tiempo)
            ac.Escribir("InsertarPartido", params)
        Next
    End Function

    Public Function calcularID() As Integer
        Return ac.DevolverEscalar("CalcularPartidoID")
    End Function
End Class
