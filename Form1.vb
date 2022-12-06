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

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        valprodcuto = 1
        openChildForm(New Productos)

    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        openChildForm(New Proveedores)

    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        openChildForm(New Empleados)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
