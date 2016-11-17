Public Class Partida
    Dim gestorDal As New DAL.Mp_Partida

    Public Function insertar(unPartido) As Integer
        gestorDal.insertar(unPartido)
    End Function

End Class
