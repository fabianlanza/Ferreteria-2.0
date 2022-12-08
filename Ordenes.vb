Imports System.Data.SqlClient

Public Class Factura
    Dim query As String
    Dim conexion As New Classconexion
    Private dv As New DataView
    Dim dr As SqlDataReader
    Dim DET As Integer
    Dim dete As Integer




    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles button1.Click
        valprodcuto = 2
        Form1.openChildForm(Productos)
        'Productos.Show()
    End Sub


    Public Sub autonum()
        query = "select iif(Max(id_orden) is null,1,Max(id_orden) + 1) from Ordenes"
        dr = conexion.reader(query)
        While dr.Read
            DET = dr.GetValue(0)
        End While
        dr.Close()
        txtfactura.Text = DET
    End Sub


    Public Sub limpiar()
        txtidprod.Text = ""
        txtnomprod.Text = ""
        txtprecio.Text = ""
        txtexistencia.Text = ""
        txtcantidad.Text = ""
    End Sub

    Sub TotalValores()
        'Variable que guardara el valor
        Dim Xtotal As Double = 0
        Dim iTotal As Integer = Me.DataGridView2.Rows.Count 'ITotal toma el valor del numero de registros k tiene latabla
        'Definimos la variable i para controlar el ciclo for
        Dim i As Integer
        'Definimos del ciclo que va desde que i vale cero hasta que i valga itotal menos uno, osea el penultimo regsitro de la tabla
        For i = 0 To iTotal - 1
            'Double.<---es para convertir a double el valor que se encuentre entre lso parentesis
            'valores de esa columna, recuerda que las columnas inician en 0... asi que la 4 enrealidad sera la 5 visualmente
            Xtotal = Xtotal + (DataGridView2(5, i).Value)
        Next
        Me.txtsub.Text = Format(Xtotal, "#,##0.00")
        Me.txtisv.Text = Format(txtsub.Text * 0.15, "###0.00")
        Me.txttotal.Text = Format((Val(txtsub.Text) + Val(txtisv.Text)), "#,##0.00")
22:
    End Sub


    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autonum()
        txtfecha.Text = Today()
        txtidprod.Enabled = False
        txtnomprod.Enabled = False
        txtprecio.Enabled = False
        txtexistencia.Enabled = False

    End Sub

    Private Sub btnvaci_Click(sender As Object, e As EventArgs) Handles btnvaci.Click
        DataGridView2.Rows.Clear()
    End Sub

    Private Sub btnquit_Click(sender As Object, e As EventArgs) Handles btnquit.Click
        If DataGridView2.Rows.Count > 0 Then
            DataGridView2.Rows.RemoveAt(DataGridView2.CurrentRow.Index)
            TotalValores()
        Else
            MsgBox("no hay valores", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub btnadic_Click(sender As Object, e As EventArgs) Handles btnadic.Click
        If Val(txtcantidad.Text) > Val(txtexistencia.Text) Then
            MsgBox(" Cantida no valida", MsgBoxStyle.Critical)
        Else
            Dim line As Double = Val(txtcantidad.Text) * Val(txtprecio.Text)
            DataGridView2.Rows.Add(txtidprod.Text, txtnomprod.Text, txtexistencia.Text, txtcantidad.Text, txtprecio.Text, line)
            limpiar()
            TotalValores()
        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim prete As String = txttotal.Text
        Dim newstring2 As String = prete.Replace(",", ".")
        query = "Insert into Ordenes values(" & txtfactura.Text & ", '" & txtfecha.Text & "', " & txtIdCliente.Text & ", " & txtIdEmpleado.Text & ")"
        conexion.insertar(query)
        Dim lleno As Integer = Me.DataGridView2.Rows.Count
        Dim detalle As Integer


        For detalle = 0 To lleno - 1
            query = "insert into detalle_ordenes values(" & txtfactura.Text & "," & (DataGridView2(0, detalle).Value) & "," & (DataGridView2(2, detalle).Value) & ")"
            conexion.insertar(query)
            Dim nueexist = (DataGridView2(2, detalle).Value) - (DataGridView2(3, detalle).Value)
            query = "Update Producto Set existencia =" & nueexist & " where id_producto = " & (DataGridView2(0, detalle).Value)
            conexion.insertar(query)
        Next

        limpiar()
        autonum()
        DataGridView2.Rows.Clear()
    End Sub
End Class