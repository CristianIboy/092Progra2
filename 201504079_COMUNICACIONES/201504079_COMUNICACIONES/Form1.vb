Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If cantidadSueldo > 0 And cantidadSueldo < 2000 Then
            comision = cantidadSueldo * 0.55
            bono = cantidadSueldo * 0.03
            sueldo_Neto = Form1.txtSueldo.Text + comision + bono
        End If

        If cantidadSueldo > 2000 And cantidadSueldo < 5000 Then
            comision = cantidadSueldo * 0.55
            bono = cantidadSueldo * 0.04
            sueldo_Neto = Form1.txtSueldo.Text + comision + bono
        End If

        If cantidadSueldo > 5000 Then
            comision = cantidadSueldo * 0.55
            bono = cantidadSueldo * 0.03
            sueldo_Neto = Form1.txtSueldo.Text + comision + bono
        End If
    End Sub
End Class
