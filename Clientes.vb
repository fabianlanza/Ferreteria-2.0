Imports System.Data.SqlClient

Public Class Clientes

    Dim query As String
    Dim conexion As New Classconexion
    Dim dataview As New DataView
    Dim dataRead As SqlDataReader

    Public Sub cargar() '"select ProductID as ID, ProductName as Producto, UnitsInStock as Cantidad_Producto, UnitPrice as Precio_unidad from Products"
        query = "select id_cliente as ID, nom_cliente as nombre, id_ciudad as ciudad  from Clientes" ''cambiar esta sentencia
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

    Public Sub limpiar()
        'txtciudad.Text = ""
        txtid.Text = ""
        txtnombre.Text = ""
    End Sub


    Public Sub autoIncrementable()
        query = "select * from Clientes"
        If conexion.val(query) Then
            query = "select MAX(id_cliente)from Clientes"
            dataRead = conexion.reader(query)
            While dataRead.Read
                txtid.Text = dataRead.GetValue(0) + 1
            End While
            dataRead.Close()
        Else
            txtid.Text = 1
        End If
    End Sub

    Public Sub cargarComb()
        query = "select id_ciudad, nom_ciudad from Ciudad"
        Dim da As New SqlDataAdapter(query, conexion.conexiion)

        Dim dt As DataTable = New DataTable()
        conexion.conectar()
        da.Fill(dt)

        With cmbciudades
            .DataSource = dt
            .DisplayMember = "nom_ciudad"
            .ValueMember = "id_ciudad"
        End With
        conexion.desconectar()
        da = Nothing
    End Sub



    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarComb()
        cargar()
        autoIncrementable()
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    ' Form1.Visible = True
    'Me.Visible = False
    'End Sub

    Private Sub Btnguardar_Click(sender As Object, e As EventArgs) Handles Btnguardar.Click
        query = "insert into Clientes values(" & txtid.Text & ",' " & txtnombre.Text & " '," & cmbciudades.SelectedValue & ")"
        conexion.manipular(query)
        MsgBox("Registro Modificado correctamente")
        cargar()
        limpiar()
        autoIncrementable()

    End Sub

    Private Sub cmbciudades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbciudades.SelectedIndexChanged

    End Sub
End Class

