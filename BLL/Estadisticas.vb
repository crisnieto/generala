Public Class Estadisticas
    Dim gestor_mp As New DAL.Mp_Estadisticas
    Function VictoriasDerrotasEmpates() As DataTable
        Return gestor_mp.VictoriasDerrotasEmpates()
    End Function

    Public Function PromedioVictorias() As DataTable
        Return gestor_mp.PromedioVictorias()
    End Function

    Public Function TiempoJugado() As DataTable
        Return gestor_mp.TiempoJugado
    End Function


End Class
