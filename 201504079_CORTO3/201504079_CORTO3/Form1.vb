Public Class Form1

    Private Sub CálculoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CálculoToolStripMenuItem1.Click
        If contador < 7 Then
            numeroTransaccion(contador) = contador + 1
            nombre(contador) = contador + 1
            NIT(contador) = contador + 1
            dias(contador) = contador + 1
            impuesto(contador) = contador + 1
            habitacion(contador) = contador + 1
            pago(contador) = contador + 1
            total(contador) = contador + 1

            Select Case sencilla
                Case "Sencilla"
                    Select Case cmbPago.SelectedItem
                        Case "Efectivo"

                    End Select
            End Select




        End If
    End Sub
End Class
