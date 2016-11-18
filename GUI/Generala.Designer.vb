<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Generala
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Generala))
        Me.btnTirar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEscalera = New System.Windows.Forms.Button()
        Me.btnFull = New System.Windows.Forms.Button()
        Me.btnPoker = New System.Windows.Forms.Button()
        Me.btnGenerala = New System.Windows.Forms.Button()
        Me.btnDoble = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Dice0 = New System.Windows.Forms.PictureBox()
        Me.Dice1 = New System.Windows.Forms.PictureBox()
        Me.Dice2 = New System.Windows.Forms.PictureBox()
        Me.Dice3 = New System.Windows.Forms.PictureBox()
        Me.Dice4 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTirar
        '
        Me.btnTirar.Location = New System.Drawing.Point(741, 144)
        Me.btnTirar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTirar.Name = "btnTirar"
        Me.btnTirar.Size = New System.Drawing.Size(300, 85)
        Me.btnTirar.TabIndex = 5
        Me.btnTirar.Text = "Tirar"
        Me.btnTirar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 144)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(532, 550)
        Me.DataGridView1.TabIndex = 6
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(1276, 144)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 33
        Me.DataGridView2.Size = New System.Drawing.Size(532, 550)
        Me.DataGridView2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 57)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1276, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 57)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Label2"
        '
        'btnEscalera
        '
        Me.btnEscalera.Location = New System.Drawing.Point(698, 85)
        Me.btnEscalera.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEscalera.Name = "btnEscalera"
        Me.btnEscalera.Size = New System.Drawing.Size(124, 48)
        Me.btnEscalera.TabIndex = 11
        Me.btnEscalera.Text = "Escalera"
        Me.btnEscalera.UseVisualStyleBackColor = True
        '
        'btnFull
        '
        Me.btnFull.Location = New System.Drawing.Point(828, 85)
        Me.btnFull.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFull.Name = "btnFull"
        Me.btnFull.Size = New System.Drawing.Size(124, 48)
        Me.btnFull.TabIndex = 12
        Me.btnFull.Text = "Full"
        Me.btnFull.UseVisualStyleBackColor = True
        '
        'btnPoker
        '
        Me.btnPoker.Location = New System.Drawing.Point(956, 85)
        Me.btnPoker.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPoker.Name = "btnPoker"
        Me.btnPoker.Size = New System.Drawing.Size(124, 48)
        Me.btnPoker.TabIndex = 13
        Me.btnPoker.Text = "Poker"
        Me.btnPoker.UseVisualStyleBackColor = True
        '
        'btnGenerala
        '
        Me.btnGenerala.Location = New System.Drawing.Point(1084, 85)
        Me.btnGenerala.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenerala.Name = "btnGenerala"
        Me.btnGenerala.Size = New System.Drawing.Size(124, 48)
        Me.btnGenerala.TabIndex = 14
        Me.btnGenerala.Text = "Generala"
        Me.btnGenerala.UseVisualStyleBackColor = True
        '
        'btnDoble
        '
        Me.btnDoble.Location = New System.Drawing.Point(564, 85)
        Me.btnDoble.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoble.Name = "btnDoble"
        Me.btnDoble.Size = New System.Drawing.Size(124, 48)
        Me.btnDoble.TabIndex = 16
        Me.btnDoble.Text = "Doble"
        Me.btnDoble.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 696)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(266, 57)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Puntaje Total: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1276, 696)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(266, 57)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Puntaje Total: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(284, 696)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 57)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(1548, 696)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 57)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Label6"
        '
        'Dice0
        '
        Me.Dice0.BackColor = System.Drawing.Color.Transparent
        Me.Dice0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Dice0.Location = New System.Drawing.Point(596, 317)
        Me.Dice0.Margin = New System.Windows.Forms.Padding(4)
        Me.Dice0.Name = "Dice0"
        Me.Dice0.Size = New System.Drawing.Size(200, 200)
        Me.Dice0.TabIndex = 21
        Me.Dice0.TabStop = False
        '
        'Dice1
        '
        Me.Dice1.BackColor = System.Drawing.Color.Transparent
        Me.Dice1.Location = New System.Drawing.Point(802, 317)
        Me.Dice1.Margin = New System.Windows.Forms.Padding(4)
        Me.Dice1.Name = "Dice1"
        Me.Dice1.Size = New System.Drawing.Size(200, 200)
        Me.Dice1.TabIndex = 22
        Me.Dice1.TabStop = False
        '
        'Dice2
        '
        Me.Dice2.BackColor = System.Drawing.Color.Transparent
        Me.Dice2.Location = New System.Drawing.Point(1008, 317)
        Me.Dice2.Margin = New System.Windows.Forms.Padding(4)
        Me.Dice2.Name = "Dice2"
        Me.Dice2.Size = New System.Drawing.Size(200, 200)
        Me.Dice2.TabIndex = 23
        Me.Dice2.TabStop = False
        '
        'Dice3
        '
        Me.Dice3.BackColor = System.Drawing.Color.Transparent
        Me.Dice3.Location = New System.Drawing.Point(700, 523)
        Me.Dice3.Margin = New System.Windows.Forms.Padding(4)
        Me.Dice3.Name = "Dice3"
        Me.Dice3.Size = New System.Drawing.Size(200, 200)
        Me.Dice3.TabIndex = 24
        Me.Dice3.TabStop = False
        '
        'Dice4
        '
        Me.Dice4.BackColor = System.Drawing.Color.Transparent
        Me.Dice4.Location = New System.Drawing.Point(904, 523)
        Me.Dice4.Margin = New System.Windows.Forms.Padding(4)
        Me.Dice4.Name = "Dice4"
        Me.Dice4.Size = New System.Drawing.Size(200, 200)
        Me.Dice4.TabIndex = 25
        Me.Dice4.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(731, 9)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 57)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Label7"
        '
        'Generala
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1832, 771)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Dice4)
        Me.Controls.Add(Me.Dice3)
        Me.Controls.Add(Me.Dice2)
        Me.Controls.Add(Me.Dice1)
        Me.Controls.Add(Me.Dice0)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnDoble)
        Me.Controls.Add(Me.btnGenerala)
        Me.Controls.Add(Me.btnPoker)
        Me.Controls.Add(Me.btnFull)
        Me.Controls.Add(Me.btnEscalera)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnTirar)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Generala"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTirar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEscalera As Button
    Friend WithEvents btnFull As Button
    Friend WithEvents btnPoker As Button
    Friend WithEvents btnGenerala As Button
    Friend WithEvents btnDoble As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Dice0 As PictureBox
    Friend WithEvents Dice1 As PictureBox
    Friend WithEvents Dice2 As PictureBox
    Friend WithEvents Dice3 As PictureBox
    Friend WithEvents Dice4 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label7 As Label
End Class
