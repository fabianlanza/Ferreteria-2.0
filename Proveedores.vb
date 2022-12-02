Imports System.Data.SqlClient

Public Class Proveedores

    Dim query As String
    Dim conexion As New Classconexion
    Dim dataview As New DataView
    Dim dataRead As SqlDataReader


    Public Sub cargar() '"select ProductID as ID, ProductName as Producto, UnitsInStock as Cantidad_Producto, UnitPrice as Precio_unidad from Products"
        query = "select id_proveedor as ID, nom_proveedor as Nombre from Proveedor" ''cambiar esta sentencia
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

    Public Sub autoIncrementable() 'falta el MAX
        query = "select * from Proveedor"
        If conexion.val(query) Then
            query = "select MAX(id_proveedor)from Proveedor"
            dataRead = conexion.reader(query)
            While dataRead.Read
                txtid.Text = dataRead.GetValue(0) + 1
            End While
            dataRead.Close()
        Else
            txtid.Text = 1
        End If
    End Sub


    Public Sub limpiar()
        txtid.Text = ""
        txtnombre.Text = ""
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        query = "insert into Proveedor values(" & txtid.Text & ",'" & txtnombre.Text & "')"
        conexion.manipular(query)
        MsgBox("Registro Modificado correctamente")
        cargar()
        limpiar()
        autoIncrementable()
    End Sub

    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
        autoIncrementable()
    End Sub
End Class