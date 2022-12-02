Public Class Form1

    Private currentChildForm As Form


    Private Sub openChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then  'abrir solo un child form
            currentChildForm.Close()
        End If
        currentChildForm = childForm

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        desktopPanel.Controls.Add(childForm)
        desktopPanel.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        LabelMenu.Text = childForm.Text
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        openChildForm(New Clientes)
        'Clientes.Show() 'Cliente
        'Me.Visible = False
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        openChildForm(New Productos)
        'Productos.Visible = True 'Productos
        'Me.Visible = False
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        openChildForm(New Proveedores)
        'Proveedores.Visible = True 'Proveedores
        'Me.Visible = False
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        openChildForm(New Empleados)
        'Empleados.Visible = True 'Empleados
        'Me.Visible = False
    End Sub






End Class
