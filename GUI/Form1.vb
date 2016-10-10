Public Class Form1

    Dim Partida As New BE.PARTIDA
    Dim Cubilete As New BLL.CUBILETE

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Cubilete.llenar(Partida.dados)
        Cubilete.volcar()
        Actualizar()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Cubilete.volcar()
        Actualizar()
    End Sub

    Private Sub Actualizar()
        Button1.Text = Partida.dado1.numero
        Button2.Text = Partida.dado2.numero
        Button3.Text = Partida.dado3.numero
        Button4.Text = Partida.dado4.numero
        Button5.Text = Partida.dado5.numero
    End Sub

End Class
