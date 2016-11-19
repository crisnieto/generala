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
        Me.btnTirar.Location = New System.Drawing.Point(370, 75)
        Me.btnTirar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTirar.Name = "btnTirar"
        Me.btnTirar.Size = New System.Drawing.Size(150, 44)
        Me.btnTirar.TabIndex = 5
        Me.btnTirar.Text = "Tirar"
        Me.btnTirar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 75)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(266, 286)
        Me.DataGridView1.TabIndex = 6
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(638, 75)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 33
        Me.DataGridView2.Size = New System.Drawing.Size(266, 286)
        Me.DataGridView2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 28)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(638, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 28)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Label2"
        '
        'btnEscalera
        '
        Me.btnEscalera.Location = New System.Drawing.Point(349, 44)
        Me.btnEscalera.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEscalera.Name = "btnEscalera"
        Me.btnEscalera.Size = New System.Drawing.Size(62, 25)
        Me.btnEscalera.TabIndex = 11
        Me.btnEscalera.Text = "Escalera"
        Me.btnEscalera.UseVisualStyleBackColor = True
        '
        'btnFull
        '
        Me.btnFull.Location = New System.Drawing.Point(414, 44)
        Me.btnFull.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnFull.Name = "btnFull"
        Me.btnFull.Size = New System.Drawing.Size(62, 25)
        Me.btnFull.TabIndex = 12
        Me.btnFull.Text = "Full"
        Me.btnFull.UseVisualStyleBackColor = True
        '
        'btnPoker
        '
        Me.btnPoker.Location = New System.Drawing.Point(478, 44)
        Me.btnPoker.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPoker.Name = "btnPoker"
        Me.btnPoker.Size = New System.Drawing.Size(62, 25)
        Me.btnPoker.TabIndex = 13
        Me.btnPoker.Text = "Poker"
        Me.btnPoker.UseVisualStyleBackColor = True
        '
        'btnGenerala
        '
        Me.btnGenerala.Location = New System.Drawing.Point(542, 44)
        Me.btnGenerala.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGenerala.Name = "btnGenerala"
        Me.btnGenerala.Size = New System.Drawing.Size(62, 25)
        Me.btnGenerala.TabIndex = 14
        Me.btnGenerala.Text = "Generala"
        Me.btnGenerala.UseVisualStyleBackColor = True
        '
        'btnDoble
        '
        Me.btnDoble.Location = New System.Drawing.Point(282, 44)
        Me.btnDoble.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDoble.Name = "btnDoble"
        Me.btnDoble.Size = New System.Drawing.Size(62, 25)
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
        Me.Label3.Location = New System.Drawing.Point(6, 362)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 28)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Puntaje Total: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(638, 362)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 28)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Puntaje Total: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(142, 362)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 28)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(774, 362)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 28)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Label6"
        '
        'Dice0
        '
        Me.Dice0.BackColor = System.Drawing.Color.Transparent
        Me.Dice0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Dice0.Location = New System.Drawing.Point(298, 165)
        Me.Dice0.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Dice0.Name = "Dice0"
        Me.Dice0.Size = New System.Drawing.Size(100, 104)
        Me.Dice0.TabIndex = 21
        Me.Dice0.TabStop = False
        '
        'Dice1
        '
        Me.Dice1.BackColor = System.Drawing.Color.Transparent
        Me.Dice1.Location = New System.Drawing.Point(401, 165)
        Me.Dice1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Dice1.Name = "Dice1"
        Me.Dice1.Size = New System.Drawing.Size(100, 104)
        Me.Dice1.TabIndex = 22
        Me.Dice1.TabStop = False
        '
        'Dice2
        '
        Me.Dice2.BackColor = System.Drawing.Color.Transparent
        Me.Dice2.Location = New System.Drawing.Point(504, 165)
        Me.Dice2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Dice2.Name = "Dice2"
        Me.Dice2.Size = New System.Drawing.Size(100, 104)
        Me.Dice2.TabIndex = 23
        Me.Dice2.TabStop = False
        '
        'Dice3
        '
        Me.Dice3.BackColor = System.Drawing.Color.Transparent
        Me.Dice3.Location = New System.Drawing.Point(350, 272)
        Me.Dice3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Dice3.Name = "Dice3"
        Me.Dice3.Size = New System.Drawing.Size(100, 104)
        Me.Dice3.TabIndex = 24
        Me.Dice3.TabStop = False
        '
        'Dice4
        '
        Me.Dice4.BackColor = System.Drawing.Color.Transparent
        Me.Dice4.Location = New System.Drawing.Point(452, 272)
        Me.Dice4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Dice4.Name = "Dice4"
        Me.Dice4.Size = New System.Drawing.Size(100, 104)
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
        Me.Label7.Location = New System.Drawing.Point(366, 5)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 28)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Label7"
        '
        'Generala
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(922, 401)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
