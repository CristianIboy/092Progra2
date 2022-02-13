Module Module1
    Public Const tcDolar = 7.69
    Public Const tcPeso = 0.38
    Public Const tcEuro = 8.79
    Public Const tcColon = 0.012

    Const comisionCompra = 2.5 / 100
    Const comisionVenta = 3 / 100

    Dim total_parcial_compra = 0
    Dim total_parcial_venta = 0
    Dim total

    Sub limpiar()

        Form1.txtCompra.Clear()
        Form1.txtVenta.Clear()

        Form1.cbCompra.Checked = False
        Form1.cbVenta.Checked = False

        Form1.compraDolar.Checked = False
        Form1.compraPeso.Checked = False
        Form1.compraEuro.Checked = False
        Form1.compraColon.Checked = False

        Form1.ventaDolar.Checked = False
        Form1.ventaPeso.Checked = False
        Form1.ventaEuro.Checked = False
        Form1.ventaColon.Checked = False


        Form2.Label1.Text = "Limpio"

    End Sub

    Function calcularCompra(cantidadCompra As Double, tipoCompra As Double) As Double
        If cantidadCompra > 0 Then
            total_parcial_compra = cantidadCompra / tipoCompra
            total = total_parcial_compra - (total_parcial_compra * comisionCompra)

        End If
        Return Math.Round(total, 2)
    End Function


    Function calcularVenta(cantidadVenta As Double, tipoVenta As Double) As Double
        If cantidadVenta > 0 Then
            total_parcial_venta = cantidadVenta / tipoVenta
            total = total_parcial_venta - (total_parcial_venta * comisionVenta)

        End If
        Return Math.Round(total, 2)
    End Function


End Module
