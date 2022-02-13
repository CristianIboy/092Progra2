Public Class Form2
    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Form1.compraDolar.Checked Then
            Label1.Text = "La cantidad de la compra es:"
            txt1.Text = Str(calcularCompra(Form1.txtCompra.Text, tcDolar))
        End If

        If Form1.compraPeso.Checked Then
            Label1.Text = "La cantidad de la compra es:"
            txt1.Text = Str(calcularCompra(Form1.txtCompra.Text, tcPeso))
        End If

        If Form1.compraEuro.Checked Then
            Label1.Text = "La cantidad de la compra es:"
            txt1.Text = Str(calcularCompra(Form1.txtCompra.Text, tcEuro))
        End If

        If Form1.compraColon.Checked Then
            Label1.Text = "La cantidad de la compra es:"
            txt1.Text = Str(calcularCompra(Form1.txtCompra.Text, tcColon))
        End If



        If Form1.ventaDolar.Checked Then
            Label2.Text = "La cantidad de la venta es:"
            txt2.Text = Str(calcularVenta(Form1.txtVenta.Text, tcDolar))
        End If

        If Form1.ventaPeso.Checked Then
            Label2.Text = "La cantidad de la venta es:"
            txt2.Text = Str(calcularVenta(Form1.txtVenta.Text, tcPeso))
        End If

        If Form1.ventaEuro.Checked Then
            Label2.Text = "La cantidad de la venta es:"
            txt2.Text = Str(calcularVenta(Form1.txtVenta.Text, tcEuro))
        End If

        If Form1.ventaColon.Checked Then
            Label2.Text = "La cantidad de la venta es:"
            txt2.Text = Str(calcularVenta(Form1.txtVenta.Text, tcColon))
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If (MsgBox("¿Desea Salir?", vbCritical + vbYesNo)) = vbYes Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub
End Class