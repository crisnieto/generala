Public Class Form1

    Dim Partida As New BE.Partida
    Dim Cubilete As New BLL.CUBILETE
    Dim Turno As New BLL.Turno(Partida.jugadores)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Partida.jugadores(0).user
        Label2.Text = Partida.jugadores(1).user
        Cubilete.llenar(Partida.dados)
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Cubilete.tieneContenido Then
            Cubilete.volcar()
            Cubilete.vaciar()
            mostrar()
            Button6.Enabled = Turno.calcular()
            Actualizar()
        End If
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        anotar()
    End Sub

    Public Sub anotar()
        Cubilete.llenar(Partida.dados)
        Turno.proximoJugador()
        BDado0.Visible = False
        BDado1.Visible = False
        BDado2.Visible = False
        BDado3.Visible = False
        BDado4.Visible = False
        Cubilete.llenar(Partida.dados)
        Button6.Enabled = True
    End Sub

    Public Sub mostrar()
        BDado0.Visible = True
        BDado1.Visible = True
        BDado2.Visible = True
        BDado3.Visible = True
        BDado4.Visible = True
    End Sub

End Class
