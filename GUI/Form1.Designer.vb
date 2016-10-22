<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BDado3 = New System.Windows.Forms.Button()
        Me.BDado0 = New System.Windows.Forms.Button()
        Me.BDado1 = New System.Windows.Forms.Button()
        Me.BDado2 = New System.Windows.Forms.Button()
        Me.BDado4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BDado3
        '
        Me.BDado3.Location = New System.Drawing.Point(809, 245)
        Me.BDado3.Name = "BDado3"
        Me.BDado3.Size = New System.Drawing.Size(96, 84)
        Me.BDado3.TabIndex = 0
        Me.BDado3.Text = "1"
        Me.BDado3.UseVisualStyleBackColor = True
        '
        'BDado0
        '
        Me.BDado0.Location = New System.Drawing.Point(503, 245)
        Me.BDado0.Name = "BDado0"
        Me.BDado0.Size = New System.Drawing.Size(96, 84)
        Me.BDado0.TabIndex = 1
        Me.BDado0.Text = "1"
        Me.BDado0.UseVisualStyleBackColor = True
        '
        'BDado1
        '
        Me.BDado1.Location = New System.Drawing.Point(605, 245)
        Me.BDado1.Name = "BDado1"
        Me.BDado1.Size = New System.Drawing.Size(96, 84)
        Me.BDado1.TabIndex = 2
        Me.BDado1.Text = "2"
        Me.BDado1.UseVisualStyleBackColor = True
        '
        'BDado2
        '
        Me.BDado2.Location = New System.Drawing.Point(707, 245)
        Me.BDado2.Name = "BDado2"
        Me.BDado2.Size = New System.Drawing.Size(96, 84)
        Me.BDado2.TabIndex = 3
        Me.BDado2.Text = "3"
        Me.BDado2.UseVisualStyleBackColor = True
        '
        'BDado4
        '
        Me.BDado4.Location = New System.Drawing.Point(911, 245)
        Me.BDado4.Name = "BDado4"
        Me.BDado4.Size = New System.Drawing.Size(96, 84)
        Me.BDado4.TabIndex = 4
        Me.BDado4.Text = "4"
        Me.BDado4.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(658, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(210, 84)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Tirar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 93)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(361, 608)
        Me.DataGridView1.TabIndex = 6
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(1215, 93)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 33
        Me.DataGridView2.Size = New System.Drawing.Size(361, 608)
        Me.DataGridView2.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1595, 735)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.BDado4)
        Me.Controls.Add(Me.BDado2)
        Me.Controls.Add(Me.BDado1)
        Me.Controls.Add(Me.BDado0)
        Me.Controls.Add(Me.BDado3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BDado3 As Button
    Friend WithEvents BDado0 As Button
    Friend WithEvents BDado1 As Button
    Friend WithEvents BDado2 As Button
    Friend WithEvents BDado4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
End Class
