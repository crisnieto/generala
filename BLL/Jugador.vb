Public Class Jugador
    Dim gestorDal As New DAL.Mp_Jugador

    Public Function Registrar(unJugador) As Integer
        gestorDal.insertar(unJugador)
    End Function

    Public Function Login() As Integer

    End Function

    Public Function conseguirID(unJugador As BE.Jugador) As Integer
        Return gestorDal.conseguirID(unJugador)
    End Function

    Public Function VerificarExistencia(unJugador As BE.Jugador) As Integer
        Return gestorDal.VerificarExistencia(unJugador)
    End Function

    Public Function ControlLogin(unJugador As BE.Jugador) As Integer
        Return gestorDal.ControlLogin(unJugador)
    End Function

End Class
