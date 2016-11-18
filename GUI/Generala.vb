Imports System.IO
Imports System.Threading

Public Class Generala

    Dim Cubilete As New BLL.CUBILETE
    Dim Calculador As New BLL.Calculador
    Dim PartidaBLL As New BLL.Partida
    Dim Turno As New BLL.Turno(Partida.jugadores)
    Dim mypath As String = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\dice_states\\"))
    Dim actualPictureBox As PictureBox
    Dim botonesTiro As New List(Of Button)
    Dim counter As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Game()
    End Sub


    Private Sub btnTirar_Click(sender As Object, e As EventArgs) Handles btnTirar.Click
        If Cubilete.tieneContenido Then
            Cubilete.volcar()
            Cubilete.vaciar()
            mostrar()
            EstadoBotonesDePrueba()
            Actualizar()
        End If
    End Sub

    Private Sub Actualizar()
        Label1.Text = Partida.jugadores(0).user
        Label2.Text = Partida.jugadores(1).user
        Dice0.ImageLocation = CargarImagenDado(Partida.dados(0))
        Dice1.ImageLocation = CargarImagenDado(Partida.dados(1))
        Dice2.ImageLocation = CargarImagenDado(Partida.dados(2))
        Dice3.ImageLocation = CargarImagenDado(Partida.dados(3))
        Dice4.ImageLocation = CargarImagenDado(Partida.dados(4))



        Calculador.borrarCalculos(Turno)
        Calculador.calcularPosibilidades(Partida.dados, Turno)
        Calculador.calcularPuntajes(Partida)
        Label5.Text = Partida.jugadores(0).puntaje
        Label6.Text = Partida.jugadores(1).puntaje
        ActualizarGrids()
    End Sub

    Private Sub ActualizarGrids()
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = Partida.jugadores(0).categorias
        DataGridStyle(DataGridView1)
        DataGridView1.Columns(2).Visible = False
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim categoria As BE.Categoria = row.DataBoundItem
            row.DefaultCellStyle.SelectionBackColor = row.DefaultCellStyle.BackColor
            row.DefaultCellStyle.SelectionForeColor = row.DefaultCellStyle.ForeColor
            If categoria.puntos <> 0 And categoria.asignado = False Then
                row.DefaultCellStyle.BackColor = Color.LightBlue
                row.DefaultCellStyle.SelectionBackColor = row.DefaultCellStyle.BackColor
                row.DefaultCellStyle.SelectionForeColor = row.DefaultCellStyle.ForeColor
            Else
                If categoria.puntos = 0 And categoria.asignado = False And Turno.conseguirJugadorActual.Equals(Partida.jugadores(0)) Then
                    row.DefaultCellStyle.BackColor = Color.LightSalmon
                    row.DefaultCellStyle.SelectionBackColor = row.DefaultCellStyle.BackColor
                    row.DefaultCellStyle.SelectionForeColor = row.DefaultCellStyle.ForeColor
                End If
            End If


        Next

        DataGridView2.DataSource = Nothing
        DataGridView2.DataSource = Partida.jugadores(1).categorias
        DataGridStyle(DataGridView2)
        DataGridView2.Columns(2).Visible = False
        For Each row As DataGridViewRow In DataGridView2.Rows
            Dim categoria As BE.Categoria = row.DataBoundItem
            row.DefaultCellStyle.SelectionBackColor = row.DefaultCellStyle.BackColor
            row.DefaultCellStyle.SelectionForeColor = row.DefaultCellStyle.ForeColor
            If categoria.puntos <> 0 And categoria.asignado = False Then
                row.DefaultCellStyle.BackColor = Color.LightBlue
                row.DefaultCellStyle.SelectionBackColor = row.DefaultCellStyle.BackColor
                row.DefaultCellStyle.SelectionForeColor = row.DefaultCellStyle.ForeColor
            Else
                If categoria.puntos = 0 And categoria.asignado = False And Turno.conseguirJugadorActual.Equals(Partida.jugadores(1)) Then
                    row.DefaultCellStyle.BackColor = Color.LightSalmon
                    row.DefaultCellStyle.SelectionBackColor = row.DefaultCellStyle.BackColor
                    row.DefaultCellStyle.SelectionForeColor = row.DefaultCellStyle.ForeColor
                End If
            End If
        Next
    End Sub

    Private Sub BDado0_Click(sender As Object, e As EventArgs)
        Cubilete.enviar(Partida.dados(0))
    End Sub

    Private Sub BDado1_Click(sender As Object, e As EventArgs)
        Cubilete.enviar(Partida.dados(1))
    End Sub

    Private Sub BDado2_Click(sender As Object, e As EventArgs)
        Cubilete.enviar(Partida.dados(2))
    End Sub

    Private Sub BDado3_Click(sender As Object, e As EventArgs)
        Cubilete.enviar(Partida.dados(3))
    End Sub

    Private Sub BDado4_Click(sender As Object, e As EventArgs)
        Cubilete.enviar(Partida.dados(4))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        prepararSiguienteJugada()
    End Sub

    Public Sub prepararSiguienteJugada()
        Cubilete.llenar(Partida.dados)
        Calculador.borrarCalculos(Turno)
        Dice0.Visible = False
        Dice1.Visible = False
        Dice2.Visible = False
        Dice3.Visible = False
        Dice4.Visible = False
        Cubilete.llenar(Partida.dados)
        HabilitarBotones()
        Actualizar()
        Turno.proximoJugador(Partida)
        Label7.Text = "Es el turno de: " + Turno.conseguirJugadorActual.user
        EvaluarFinalPartida()

    End Sub

    Public Sub mostrar()
        Dice0.Visible = True
        Dice1.Visible = True
        Dice2.Visible = True
        Dice3.Visible = True
        Dice4.Visible = True
    End Sub

    Public Sub DataGridStyle(datagrid As DataGridView)
        For Each row As DataGridViewRow In datagrid.Rows
            Dim categoria As BE.Categoria = row.DataBoundItem
            If categoria.asignado = True Then
                row.DefaultCellStyle.BackColor = Color.Yellow
            End If
            If categoria.asignado = False Then
                row.DefaultCellStyle.BackColor = Color.White
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
        Dim msgBoxText As String = "¿Asignar " & categoria.puntos & " a la categoría " & categoria.nombre & "?"
        If categoria.asignado = False And Turno.numeroTiro >= 1 And Turno.conseguirJugadorActual.Equals(jugador) Then
            If MsgBox(msgBoxText, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                categoria.asignado = True
                prepararSiguienteJugada()
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnFull_Click(sender As Object, e As EventArgs) Handles btnFull.Click
        Cubilete.vaciar()
        Cubilete.llenar(Partida.dados)
        Dim lista As New List(Of Integer) From {2, 2, 2, 3, 3}
        If Cubilete.tieneContenido Then
            Cubilete.volcar(lista)
            Cubilete.vaciar()
            mostrar()
            EstadoBotonesDePrueba()
            Actualizar()
        End If
    End Sub

    Private Sub btnEscalera_Click(sender As Object, e As EventArgs) Handles btnEscalera.Click
        Cubilete.vaciar()
        Cubilete.llenar(Partida.dados)
        Dim lista As New List(Of Integer) From {1, 2, 3, 4, 5, 6}
        If Cubilete.tieneContenido Then
            Cubilete.volcar(lista)
            Cubilete.vaciar()
            mostrar()
            EstadoBotonesDePrueba()
            Actualizar()
        End If
    End Sub

    Private Sub btnDoble_Click(sender As Object, e As EventArgs) Handles btnDoble.Click
        Cubilete.vaciar()
        Cubilete.llenar(Partida.dados)
        Dim lista As New List(Of Integer) From {2, 2, 1, 3, 3}
        If Cubilete.tieneContenido Then
            Cubilete.volcar(lista)
            Cubilete.vaciar()
            mostrar()
            EstadoBotonesDePrueba()
            Actualizar()
        End If
    End Sub

    Private Sub btnPoker_Click(sender As Object, e As EventArgs) Handles btnPoker.Click
        Cubilete.vaciar()
        Cubilete.llenar(Partida.dados)
        Dim lista As New List(Of Integer) From {5, 1, 5, 5, 5}
        If Cubilete.tieneContenido Then
            Cubilete.volcar(lista)
            Cubilete.vaciar()
            mostrar()
            EstadoBotonesDePrueba()
            Actualizar()
        End If
    End Sub

    Private Sub btnGenerala_Click(sender As Object, e As EventArgs) Handles btnGenerala.Click
        Cubilete.vaciar()
        Cubilete.llenar(Partida.dados)
        Dim lista As New List(Of Integer) From {4, 4, 4, 4, 4}
        If Cubilete.tieneContenido Then
            Cubilete.volcar(lista)
            Cubilete.vaciar()
            mostrar()
            EstadoBotonesDePrueba()
            Actualizar()
        End If
    End Sub

    Public Sub EstadoBotonesDePrueba()
        Dim estado As Boolean = Turno.calcular
        For Each boton As Button In botonesTiro
            boton.Enabled = estado
        Next
    End Sub

    Public Sub HabilitarBotones()
        For Each boton As Button In botonesTiro
            boton.Enabled = True
        Next
    End Sub

    Public Function CargarImagenDado(dado As BE.Dado) As String
        Dim numero As Integer = dado.numero
        If numero >= 1 Then
            Dim nombre As String = numero.ToString + ".png"
            Return IO.Path.Combine(mypath, nombre)
        End If

    End Function

    Public Function UpdateImagenDado(dado As BE.Dado) As String
        Dim numero As Integer = dado.numero
        If numero >= 1 And dado.tirado = False Then
            Dim nombre As String = numero.ToString + "c.png"
            Return IO.Path.Combine(mypath, nombre)
        Else
            Dim nombre As String = numero.ToString + ".png"
            Return IO.Path.Combine(mypath, nombre)
        End If

    End Function

    Private Sub Dice0_Click(sender As Object, e As EventArgs) Handles Dice0.Click
        Cubilete.enviar(Partida.dados(0))
        Dice0.ImageLocation = UpdateImagenDado(Partida.dados(0))
    End Sub

    Private Sub Dice1_Click(sender As Object, e As EventArgs) Handles Dice1.Click
        Cubilete.enviar(Partida.dados(1))
        Dice1.ImageLocation = UpdateImagenDado(Partida.dados(1))
    End Sub

    Private Sub Dice2_Click(sender As Object, e As EventArgs) Handles Dice2.Click
        Cubilete.enviar(Partida.dados(2))
        Dice2.ImageLocation = UpdateImagenDado(Partida.dados(2))
    End Sub

    Private Sub Dice3_Click(sender As Object, e As EventArgs) Handles Dice3.Click
        Cubilete.enviar(Partida.dados(3))
        Dice3.ImageLocation = UpdateImagenDado(Partida.dados(3))
    End Sub

    Private Sub Dice4_Click(sender As Object, e As EventArgs) Handles Dice4.Click
        Cubilete.enviar(Partida.dados(4))
        Dice4.ImageLocation = UpdateImagenDado(Partida.dados(4))
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter = counter + 1
    End Sub

    Private Sub Load_Game()
        counter = 0
        Timer1.Start()
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
        botonesTiro.AddRange({btnTirar, btnDoble, btnEscalera, btnFull, btnGenerala, btnPoker})
        Actualizar()
        Label7.Text = "Es el turno de: " + Turno.conseguirJugadorActual.user
    End Sub

    Public Sub EvaluarFinalPartida()
        If Partida.empezada = False Then
            Partida.tiempo = counter
            MsgBox("La partida duró " + (Partida.tiempo / 60).ToString + " minutos")
            PartidaBLL.Insertar(Partida)
            Login.Show()
            Me.Close()
        End If
    End Sub

End Class
