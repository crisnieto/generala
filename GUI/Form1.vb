Public Class Form1

    Dim Partida As New BE.Partida
    Dim Cubilete As New BLL.CUBILETE
    Dim Calculador As New BLL.Calculador
    Dim Turno As New BLL.Turno(Partida.jugadores)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.DefaultCellStyle.BackColor = Color.White
        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.White
        DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.DefaultCellStyle.BackColor = Color.White
        DataGridView2.DefaultCellStyle.SelectionBackColor = Color.White
        DataGridView2.DefaultCellStyle.SelectionForeColor = Color.Black
        Label1.Text = Partida.jugadores(0).user
        Label2.Text = Partida.jugadores(1).user
        Calculador.asignarCategorias(Partida.jugadores(0))
        Calculador.asignarCategorias(Partida.jugadores(1))
        Cubilete.llenar(Partida.dados)
        Actualizar()
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
        Calculador.borrarCalculos(Turno)
        Calculador.calcularPosibilidades(Partida.dados, Turno)
        ActualizarGrids()
    End Sub

    Private Sub ActualizarGrids()
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = Partida.jugadores(0).categorias
        DataGridStyle(DataGridView1)
        DataGridView1.Columns(2).Visible = False
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.DefaultCellStyle.SelectionBackColor = row.DefaultCellStyle.BackColor
            row.DefaultCellStyle.SelectionForeColor = row.DefaultCellStyle.ForeColor
        Next


        DataGridView2.DataSource = Nothing
        DataGridView2.DataSource = Partida.jugadores(1).categorias
        DataGridStyle(DataGridView2)
        DataGridView2.Columns(2).Visible = False
        For Each row As DataGridViewRow In DataGridView2.Rows
            row.DefaultCellStyle.SelectionBackColor = row.DefaultCellStyle.BackColor
            row.DefaultCellStyle.SelectionForeColor = row.DefaultCellStyle.ForeColor
        Next
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
        prepararSiguienteJugada()
    End Sub

    Public Sub prepararSiguienteJugada()
        Actualizar()
        Cubilete.llenar(Partida.dados)
        Calculador.borrarCalculos(Turno)
        ActualizarGrids()
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

    Public Sub DataGridStyle(datagrid As DataGridView)
        For Each row As DataGridViewRow In datagrid.Rows
            Dim categoria As BE.Categoria = row.DataBoundItem
            If categoria.asignado = True Then
                row.DefaultCellStyle.BackColor = Color.Yellow
            End If
        Next

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        anotar(Partida.jugadores(0), DataGridView1)
    End Sub

    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        anotar(Partida.jugadores(1), DataGridView2)
    End Sub

    Public Sub anotar(jugador As BE.Jugador, dgv As DataGridView)
        Dim categoria As BE.Categoria = dgv.SelectedRows(0).DataBoundItem
        Dim msgBoxText As String = "¿Asignar " & categoria.puntos & "a " & categoria.nombre & "?"
        If categoria.asignado = False And Turno.numeroTiro >= 1 And Turno.conseguirJugadorActual.Equals(jugador) Then
            If MsgBox(msgBoxText, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                categoria.asignado = True
                prepararSiguienteJugada()
                ActualizarGrids()
            End If
        End If
    End Sub

End Class
