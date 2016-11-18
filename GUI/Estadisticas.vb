Public Class Estadisticas
    Dim gestorBLL As New BLL.Estadisticas
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Estadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = gestorBLL.PromedioVictorias
        DataGridView2.DataSource = Nothing
        DataGridView2.DataSource = gestorBLL.VictoriasDerrotasEmpates
        DataGridView3.DataSource = Nothing
        DataGridView3.DataSource = gestorBLL.TiempoJugado
    End Sub
End Class