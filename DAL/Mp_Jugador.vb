Imports System.Data.SqlClient
Public Class Mp_Jugador
    Dim ac As New Acceso

    Public Function insertar(unJugador As BE.Jugador)
        Dim params(2) As SqlParameter
        Dim id As Integer = calcularID()
        params(0) = New SqlParameter("@id", id)
        params(1) = New SqlParameter("@user", unJugador.user)
        params(2) = New SqlParameter("@password", unJugador.password)
        Return ac.Escribir("InsertarJugador", params)
    End Function

    Public Function calcularID() As Integer
        Return ac.DevolverEscalar("CalcularJugadorID")
    End Function

    Public Function conseguirID(unJugador As BE.Jugador) As Integer
        Dim params(0) As SqlParameter
        params(0) = New SqlParameter("@user_name", unJugador.user)
        Return ac.DevolverEscalar("ConseguirJugadorID", params)
    End Function

    Public Function VerificarExistencia(unJugador As BE.Jugador) As Integer
        Dim params(0) As SqlParameter
        params(0) = New SqlParameter("@user_name", unJugador.user)
        Return ac.DevolverEscalar("VerificarExistenciaJugador", params)
    End Function


End Class
