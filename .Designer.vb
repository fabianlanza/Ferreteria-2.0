<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnadic = New System.Windows.Forms.Button()
        Me.btnquit = New System.Windows.Forms.Button()
        Me.btnvaci = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.txtidprod = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtexistencia = New System.Windows.Forms.TextBox()
        Me.txtnomprod = New System.Windows.Forms.TextBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtisv = New System.Windows.Forms.TextBox()
        Me.txtsub = New System.Windows.Forms.TextBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Existencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Linea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtfactura = New System.Windows.Forms.TextBox()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.txtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(25, 58)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(50, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Precio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(310, 88)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(184, 88)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Existencia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(398, 306)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Subtotal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(461, 7)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Fecha"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 7)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "No. Factura"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(409, 375)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(409, 339)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "ISV"
        '
        'btnadic
        '
        Me.btnadic.Location = New System.Drawing.Point(542, 139)
        Me.btnadic.Margin = New System.Windows.Forms.Padding(2)
        Me.btnadic.Name = "btnadic"
        Me.btnadic.Size = New System.Drawing.Size(80, 24)
        Me.btnadic.TabIndex = 10
        Me.btnadic.Text = "Adicionar"
        Me.btnadic.UseVisualStyleBackColor = True
        '
        'btnquit
        '
        Me.btnquit.Location = New System.Drawing.Point(542, 179)
        Me.btnquit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnquit.Name = "btnquit"
        Me.btnquit.Size = New System.Drawing.Size(80, 24)
        Me.btnquit.TabIndex = 11
        Me.btnquit.Text = "Quitar"
        Me.btnquit.UseVisualStyleBackColor = True
        '
        'btnvaci
        '
        Me.btnvaci.Location = New System.Drawing.Point(542, 221)
        Me.btnvaci.Margin = New System.Windows.Forms.Padding(2)
        Me.btnvaci.Name = "btnvaci"
        Me.btnvaci.Size = New System.Drawing.Size(80, 24)
        Me.btnvaci.TabIndex = 12
        Me.btnvaci.Text = "Vaciar"
        Me.btnvaci.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(27, 313)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(80, 24)
        Me.btnguardar.TabIndex = 13
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'txtidprod
        '
        Me.txtidprod.Location = New System.Drawing.Point(75, 56)
        Me.txtidprod.Margin = New System.Windows.Forms.Padding(2)
        Me.txtidprod.Name = "txtidprod"
        Me.txtidprod.Size = New System.Drawing.Size(56, 20)
        Me.txtidprod.TabIndex = 14
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(371, 85)
        Me.txtcantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(67, 20)
        Me.txtcantidad.TabIndex = 15
        '
        'txtexistencia
        '
        Me.txtexistencia.Location = New System.Drawing.Point(240, 85)
        Me.txtexistencia.Margin = New System.Windows.Forms.Padding(2)
        Me.txtexistencia.Name = "txtexistencia"
        Me.txtexistencia.Size = New System.Drawing.Size(58, 20)
        Me.txtexistencia.TabIndex = 16
        '
        'txtnomprod
        '
        Me.txtnomprod.Location = New System.Drawing.Point(134, 56)
        Me.txtnomprod.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnomprod.Name = "txtnomprod"
        Me.txtnomprod.Size = New System.Drawing.Size(294, 20)
        Me.txtnomprod.TabIndex = 17
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(75, 88)
        Me.txtprecio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(96, 20)
        Me.txtprecio.TabIndex = 18
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(444, 372)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(78, 20)
        Me.txttotal.TabIndex = 19
        '
        'txtisv
        '
        Me.txtisv.Location = New System.Drawing.Point(444, 336)
        Me.txtisv.Margin = New System.Windows.Forms.Padding(2)
        Me.txtisv.Name = "txtisv"
        Me.txtisv.Size = New System.Drawing.Size(78, 20)
        Me.txtisv.TabIndex = 20
        '
        'txtsub
        '
        Me.txtsub.Location = New System.Drawing.Point(444, 301)
        Me.txtsub.Margin = New System.Windows.Forms.Padding(2)
        Me.txtsub.Name = "txtsub"
        Me.txtsub.Size = New System.Drawing.Size(78, 20)
        Me.txtsub.TabIndex = 21
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.button1.Location = New System.Drawing.Point(444, 56)
        Me.button1.Margin = New System.Windows.Forms.Padding(2)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(80, 24)
        Me.button1.TabIndex = 22
        Me.button1.Text = "..."
        Me.button1.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod, Me.Nombre, Me.Existencia, Me.Cantidad, Me.Precio, Me.Linea})
        Me.DataGridView2.Location = New System.Drawing.Point(19, 123)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.Size = New System.Drawing.Size(505, 162)
        Me.DataGridView2.TabIndex = 23
        '
        'Cod
        '
        Me.Cod.HeaderText = "Codigo"
        Me.Cod.MinimumWidth = 6
        Me.Cod.Name = "Cod"
        Me.Cod.Width = 125
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Producto"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 125
        '
        'Existencia
        '
        Me.Existencia.HeaderText = "Existencia"
        Me.Existencia.MinimumWidth = 6
        Me.Existencia.Name = "Existencia"
        Me.Existencia.Visible = False
        Me.Existencia.Width = 125
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 125
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.Width = 125
        '
        'Linea
        '
        Me.Linea.HeaderText = "Linea"
        Me.Linea.MinimumWidth = 6
        Me.Linea.Name = "Linea"
        Me.Linea.Width = 125
        '
        'txtfactura
        '
        Me.txtfactura.Location = New System.Drawing.Point(86, 5)
        Me.txtfactura.Margin = New System.Windows.Forms.Padding(2)
        Me.txtfactura.Name = "txtfactura"
        Me.txtfactura.Size = New System.Drawing.Size(96, 20)
        Me.txtfactura.TabIndex = 25
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(500, 7)
        Me.txtfecha.Margin = New System.Windows.Forms.Padding(2)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(96, 20)
        Me.txtfecha.TabIndex = 26
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(226, 356)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtIdCliente.TabIndex = 30
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.Location = New System.Drawing.Point(226, 306)
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.txtIdEmpleado.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(152, 308)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "ID Empleado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(152, 356)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "ID Cliente"
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 520)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtIdEmpleado)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.txtfactura)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.txtsub)
        Me.Controls.Add(Me.txtisv)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.txtnomprod)
        Me.Controls.Add(Me.txtexistencia)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.txtidprod)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnvaci)
        Me.Controls.Add(Me.btnquit)
        Me.Controls.Add(Me.btnadic)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Factura"
        Me.Text = "Ordenes"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnadic As Button
    Friend WithEvents btnquit As Button
    Friend WithEvents btnvaci As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents txtidprod As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtexistencia As TextBox
    Friend WithEvents txtnomprod As TextBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtisv As TextBox
    Friend WithEvents txtsub As TextBox
    Friend WithEvents button1 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Cod As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Existencia As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Linea As DataGridViewTextBoxColumn
    Friend WithEvents txtfactura As TextBox
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents txtIdEmpleado As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
