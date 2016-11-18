Public Class Login
    Dim gestorBLL As New BLL.Jugador
    Dim gestorBLLPartida As New BLL.Partida
    Dim jugador1 As New BE.Jugador
    Dim jugador2 As New BE.Jugador
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        jugador1.user = TextBox1.Text
        jugador1.password = TextBox2.Text
        If CheckBox1.Checked = True Then
            Button1.Enabled = Not (LoginJugadorNuevo(jugador1))
        Else
            Button1.Enabled = Not (LoginJugadorExistente(jugador1))
        End If
        PosibleComenzar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        jugador2.user = TextBox4.Text
        jugador2.password = TextBox3.Text
        If CheckBox2.Checked = True Then
            Button2.Enabled = Not (LoginJugadorNuevo(jugador2))
        Else
            Button2.Enabled = Not (LoginJugadorExistente(jugador2))
        End If
        PosibleComenzar()
    End Sub

    Private Sub PosibleComenzar()
        If jugador1.logged = True And jugador2.logged = True Then
            Button3.Enabled = True
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Partida = New BE.Partida
        Partida.jugadores(0) = jugador1
        Partida.jugadores(1) = jugador2
        Generala.Show()
        Me.Close()
    End Sub

    Private Function LoginJugadorNuevo(unJugador) As Boolean
        If gestorBLL.VerificarExistencia(unJugador) = 0 Then
            gestorBLL.Registrar(unJugador)
            unJugador.logged = True
            unJugador.id = gestorBLL.conseguirID(unJugador)
            Return True
        Else
            MsgBox("Jugador ya registrado!")
            Return False
        End If

    End Function

    Private Function LoginJugadorExistente(unJugador) As Boolean
        If gestorBLL.ControlLogin(unJugador) > 0 Then
            unJugador.logged = True
            unJugador.id = gestorBLL.conseguirID(unJugador)
            Return True
        Else
            MsgBox("No se encontraron datos para el jugador indicado")
            Return False
        End If

    End Function

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Estadisticas.Show()
    End Sub
End Class