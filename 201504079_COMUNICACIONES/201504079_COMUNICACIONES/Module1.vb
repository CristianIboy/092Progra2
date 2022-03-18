Module Module1

    Public Const precio_Tablet = 375
    Public Const precio_Drone = 560
    Public Const precio_Celular = 1450
    Public Const precio_Televisor = 3250

    Dim sueldo_Neto = 0
    Dim comision = 0
    Dim bono = 0


    Sub limpiar()

        Form1.txtNombre.Clear()
        Form1.txtSueldo.Clear()

        Form1.rbCelular.Checked = False
        Form1.rbDrone.Checked = False
        Form1.rbTablet.Checked = False
        Form1.rbTelevisor.Checked = False



    End Sub


    End Sub
    Function calcularComisiones(cantidadSueldo As Double, cantidadComision As Double) As Double

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

    End Function

End Module
