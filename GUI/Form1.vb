Public Class Form1

    Dim Partida As New BE.Partida
    Dim Cubilete As New BLL.CUBILETE


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cubilete.llenar(Partida.dados)
        Cubilete.volcar()
        Actualizar()
        Cubilete.vaciar()
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Cubilete.llenar(Partida.dados)
        Cubilete.volcar()
        Cubilete.vaciar()
        Actualizar()
    End Sub

    Private Sub Actualizar()
        BDado0.Text = Partida.dados(0).numero
        BDado1.Text = Partida.dados(1).numero
        BDado2.Text = Partida.dados(2).numero
        BDado3.Text = Partida.dados(3).numero
        BDado4.Text = Partida.dados(4).numero
    End Sub

    Private Sub BDado0_Click(sender As Object, e As EventArgs) Handles BDado0.Click
        Cubilete.enviar(Partida.dados(0))
    End Sub

    Private Sub BDado1_Click(sender As Object, e As EventArgs) Handles BDado1.Click
        Cubilete.enviar(Partida.dados(1))
    End Sub

    Private Sub BDado2_Click(sender As Object, e As EventArgs) Handles BDado2.Click
        Cubilete.enviar(Partida.dados(2))
    End Sub

    Private Sub BDado3_Click(sender As Object, e As EventArgs) Handles BDado3.Click
        Cubilete.enviar(Partida.dados(3))
    End Sub

    Private Sub BDado4_Click(sender As Object, e As EventArgs) Handles BDado4.Click
        Cubilete.enviar(Partida.dados(4))
    End Sub
End Class
