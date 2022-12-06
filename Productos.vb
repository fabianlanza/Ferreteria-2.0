Imports System.Data.SqlClient
Public Class Productos

    Dim query As String
    Dim conexion As New Classconexion
    Dim dataview As New DataView
    Dim dataRead As SqlDataReader

    Public Sub cargar() '"select ProductID as ID, ProductName as Producto, UnitsInStock as Cantidad_Producto, UnitPrice as Precio_unidad from Products"
        query = "select id_producto as ID, nom_producto as Nombre, precio, id_proveedor as Proveedor, id_categoria as Categoria, existencia from Producto" ''cambiar esta sentencia
        If conexion.val(query) = True Then
            Dim dataadapter As New SqlDataAdapter(query, conexion.conexiion)
            Dim ds As New DataSet
            With DataGridView1
                .MultiSelect = False 'no permite selecciones multiples
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End With

            dataadapter.Fill(ds)
            dataview.Table = ds.Tables(0)
            DataGridView1.DataSource = dataview
        Else
            MsgBox("no hay registros")
        End If
    End Sub


    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
        cargarproveedorComb()
        cargarcategoriaComb()
        autoIncrementable()
    End Sub

    Public Sub limpiar()
        'txtciudad.Text = ""
        txtid.Text = ""
        txtnombre.Text = ""
        txtprecio.Text = ""
        txtexistencia.Text = ""
    End Sub


    Public Sub autoIncrementable()
        query = "select * from Producto"
        If conexion.val(query) Then
            query = "select MAX(id_producto)from Producto"
            dataRead = conexion.reader(query)
            While dataRead.Read
                txtid.Text = dataRead.GetValue(0) + 1
            End While
            dataRead.Close()
        Else
            txtid.Text = 1
        End If
    End Sub

    Private Sub Btnguardar_Click(sender As Object, e As EventArgs) Handles Btnguardar.Click
        '"insert into Clientes values(" & txtid.Text & ",' " & txtnombre.Text & " '," & cmbciudades.SelectedValue & ")"
        query = "insert into Producto values(" & txtid.Text & ",'" & txtnombre.Text & "' ," & txtprecio.Text & "," & cmbproveedor.SelectedValue & "," & cmbcategoria.SelectedValue & "," & txtexistencia.Text & ")"
        conexion.manipular(query)
        MsgBox("Registro Modificado correctamente")
        cargar()
        limpiar()
        autoIncrementable()
    End Sub

    Public Sub cargarproveedorComb()
        query = "select id_proveedor, nom_proveedor from Proveedor"
        Dim da As New SqlDataAdapter(query, conexion.conexiion)

        Dim dt As DataTable = New DataTable()
        conexion.conectar()
        da.Fill(dt)

        With cmbproveedor
            .DataSource = dt
            .DisplayMember = "nom_proveedor"
            .ValueMember = "id_proveedor"
        End With
        conexion.desconectar()
        da = Nothing
    End Sub

    Public Sub cargarcategoriaComb()
        query = "select id_categoria, nom_categoria from Categoria"
        Dim da As New SqlDataAdapter(query, conexion.conexiion)

        Dim dt As DataTable = New DataTable()
        conexion.conectar()
        da.Fill(dt)

        With cmbcategoria
            .DataSource = dt
            .DisplayMember = "nom_categoria"
            .ValueMember = "id_categoria"
        End With
        conexion.desconectar()
        da = Nothing
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If valprodcuto = 1 Then 'validacion para actualizar
            txtid.Text = DataGridView1.CurrentRow.Cells(0).Value
        ElseIf valprodcuto = 2 Then 'validacion para cargar producto en factura
            Factura.txtidprod.Text = DataGridView1.CurrentRow.Cells(0).Value
            Factura.txtnomprod.Text = DataGridView1.CurrentRow.Cells(1).Value
            Factura.txtexistencia.Text = DataGridView1.CurrentRow.Cells(5).Value
            Factura.txtprecio.Text = DataGridView1.CurrentRow.Cells(2).Value
            Factura.Show()

            Me.Close()
        End If
    End Sub
End Class
