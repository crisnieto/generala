Imports System.Data.SqlClient

Public Class Acceso
    Dim sqlString = "Data source=.\SQLEXPRESS;Initial Catalog=Generala;Integrated Security=SSPI"
    Dim cn As New SqlConnection(sqlString)
    Public Sub abrir()
        cn.Open()
    End Sub

    Public Sub Cerrar()
        cn.Close()
    End Sub

    Public Function Escribir(procedure As String, params() As SqlParameter) As Integer
        Dim cmd As New SqlCommand
        Dim cant As Integer
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = procedure
        cmd.Connection = cn
        cmd.Parameters.AddRange(params)
        abrir()
        cant = cmd.ExecuteNonQuery()
        Cerrar()
        Return cant
    End Function

    Public Function Leer(procedure As String, Optional params() As SqlParameter = Nothing) As DataTable
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = procedure
        cmd.Connection = cn
        If params IsNot Nothing Then
            cmd.Parameters.AddRange(params)
        End If
        da.SelectCommand = cmd
        abrir()
        da.Fill(dt)
        Cerrar()

        Return dt
    End Function

    Public Function DevolverEscalar(proc As String) As Integer
        Dim cmd As New SqlCommand
        Dim cant As Integer
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = proc
        cmd.Connection = cn
        abrir()
        cant = cmd.ExecuteScalar()
        Cerrar()
        Return cant
    End Function

    Public Function DevolverEscalar(proc As String, params() As SqlParameter) As Integer
        Dim cmd As New SqlCommand
        Dim cant As Integer
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = proc
        cmd.Connection = cn
        cmd.Parameters.AddRange(params)
        abrir()
        cant = cmd.ExecuteScalar()
        Cerrar()
        Return cant
    End Function


End Class