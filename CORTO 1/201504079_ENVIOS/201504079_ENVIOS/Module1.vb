Module Module1
    Public Const viatico_Norte = 150
    Public Const viatico_Sur = 200
    Public Const viatico_Oriente = 175
    Public Const viatico_Occidente = 225

    Public Const seguro_Vehiculo = 3 / 100
    Public Const seguro_accidente = 5 / 100

    Public Const sueldo_mensajero = 3800

    Dim total_sueldo_final As Double


    Sub limpiar()
        Form1.txt1.Clear()
        Form1.txt2.Clear()

        Form1.rbNorte.Checked = False
        Form1.rbSur.Checked = False
        Form1.rbOriente.Checked = False
        Form1.rbOccidente.Checked = False

        Form1.lblRespuestaAccidente.Visible = False
        Form1.lblRespuestaVehiculo.Visible = False

        Form1.rbVehiculo.Checked = False
        Form1.rbAccidente.Checked = False
    End Sub

    Function calcularSueldo(sueldo_mensajero As Double, tipoPorcentaje As Double) As Double
        If Form1.rbNorte.Checked And Form1.rbVehiculo.Checked Then
            sueldo_mensajero = sueldo_mensajero + (sueldo_mensajero * seguro_Vehiculo) + viatico_Norte
        End If

        If Form1.rbNorte.Checked And Form1.rbAccidente.Checked Then
            sueldo_mensajero = sueldo_mensajero + (sueldo_mensajero * seguro_accidente) + viatico_Norte
        End If

        If Form1.rbSur.Checked And Form1.rbVehiculo.Checked Then
            sueldo_mensajero = sueldo_mensajero + (sueldo_mensajero * seguro_Vehiculo) + viatico_Sur
        End If

        If Form1.rbSur.Checked And Form1.rbAccidente.Checked Then
            sueldo_mensajero = sueldo_mensajero + (sueldo_mensajero * seguro_accidente) + viatico_Sur
        End If
        If Form1.rbOriente.Checked And Form1.rbVehiculo.Checked Then
            sueldo_mensajero = sueldo_mensajero + (sueldo_mensajero * seguro_Vehiculo) + viatico_Oriente
        End If

        If Form1.rbOriente.Checked And Form1.rbAccidente.Checked Then
            sueldo_mensajero = sueldo_mensajero + (sueldo_mensajero * seguro_accidente) + viatico_Oriente
        End If
        If Form1.rbOccidente.Checked And Form1.rbVehiculo.Checked Then
            sueldo_mensajero = sueldo_mensajero + (sueldo_mensajero * seguro_Vehiculo) + viatico_Occidente
        End If

        If Form1.rbOccidente.Checked And Form1.rbAccidente.Checked Then
            sueldo_mensajero = sueldo_mensajero + (sueldo_mensajero * seguro_accidente) + viatico_Occidente
        End If


        Form1.lblRespuestaSueldo.Text = sueldo_mensajero

    End Function

End Module
