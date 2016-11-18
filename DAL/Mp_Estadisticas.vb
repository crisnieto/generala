Imports System.Data.SqlClient

Public Class Mp_Estadisticas
    Dim ac As New Acceso


    Public Function VictoriasDerrotasEmpates() As DataTable
        Dim dt As DataTable = ac.Leer("VictoriasDerrotasEmpates")
        Return dt
    End Function

    Public Function PromedioVictorias() As DataTable
        Dim dt As DataTable = ac.Leer("PromedioVictorias")
        Return dt
    End Function

    Public Function TiempoJugado() As DataTable
        Dim dt As DataTable = ac.Leer("TiempoJugado")
        Return dt
    End Function

End Class
