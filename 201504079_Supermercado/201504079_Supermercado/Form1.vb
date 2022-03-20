Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If cmbProducto.SelectedIndex = -1 Then
            MsgBox("Seleccione el producto")
            Exit Sub
        End If

        Call calcular()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Call salir()
    End Sub
End Class
