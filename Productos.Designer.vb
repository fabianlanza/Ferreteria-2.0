<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Me.cmbproveedor = New System.Windows.Forms.ComboBox()
        Me.Btnguardar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbcategoria = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtexistencia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbproveedor
        '
        Me.cmbproveedor.FormattingEnabled = True
        Me.cmbproveedor.Location = New System.Drawing.Point(396, 338)
        Me.cmbproveedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbproveedor.Name = "cmbproveedor"
        Me.cmbproveedor.Size = New System.Drawing.Size(168, 24)
        Me.cmbproveedor.TabIndex = 15
        '
        'Btnguardar
        '
        Me.Btnguardar.ForeColor = System.Drawing.Color.Black
        Me.Btnguardar.Location = New System.Drawing.Point(123, 511)
        Me.Btnguardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btnguardar.Name = "Btnguardar"
        Me.Btnguardar.Size = New System.Drawing.Size(129, 52)
        Me.Btnguardar.TabIndex = 14
        Me.Btnguardar.Text = "Guardar"
        Me.Btnguardar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.DataGridView1.Location = New System.Drawing.Point(44, 38)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(899, 257)
        Me.DataGridView1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(316, 342)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Proveedor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(65, 342)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ID"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(123, 384)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(168, 22)
        Me.txtnombre.TabIndex = 12
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(123, 340)
        Me.txtid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(168, 22)
        Me.txtid.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(65, 388)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nombre"
        '
        'cmbcategoria
        '
        Me.cmbcategoria.FormattingEnabled = True
        Me.cmbcategoria.Location = New System.Drawing.Point(396, 383)
        Me.cmbcategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbcategoria.Name = "cmbcategoria"
        Me.cmbcategoria.Size = New System.Drawing.Size(168, 24)
        Me.cmbcategoria.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(316, 386)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Categoria"
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(123, 427)
        Me.txtprecio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(168, 22)
        Me.txtprecio.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(65, 431)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Precio"
        '
        'txtexistencia
        '
        Me.txtexistencia.Location = New System.Drawing.Point(396, 427)
        Me.txtexistencia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtexistencia.Name = "txtexistencia"
        Me.txtexistencia.Size = New System.Drawing.Size(168, 22)
        Me.txtexistencia.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(316, 431)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Existencia"
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(991, 709)
        Me.Controls.Add(Me.txtexistencia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbcategoria)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbproveedor)
        Me.Controls.Add(Me.Btnguardar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Productos"
        Me.Text = "Productos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbproveedor As ComboBox
    Friend WithEvents Btnguardar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbcategoria As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtexistencia As TextBox
    Friend WithEvents Label6 As Label
End Class
