Public Class Form1
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If cmbPaquete.SelectedIndex = -1 Or cmbMedio.SelectedIndex = -1 Then
            MsgBox("Seleccione todos los campos")
        End If

        If contador < 10 Then
            numeroTransaccion(contador) = contador + 1
            nombre(contador) = txtNombre.Text
            nombrePaquete(contador) = cmbPaquete.SelectedItem
            ValorPaquete(contador) = Val(txtValor.Text)
            valorImpuesto(contador) = Val(txtPeso.Text)
            pagoTotal(contador) = pagoTotal(contador)
            vehiculo(contador) = cmbMedio.SelectedItem

            Select Case nombrePaquete(contador)

                Case "Documentos"
                    Select Case cmbMedio.SelectedItem
                        Case "Camion"
                            valorImpuesto(contador) = "Q" & "  " & Val(txtValor.Text * 0.015)
                            pagoParcal(contador) = "Q" & "  " & valorImpuesto(contador) + ValorPaquete(contador)
                            pagoTotal(contador) = "Q" & "  " & precioCamion + pagoParcal(contador)
                            vehiculo(contador) = "Q" & "  " & 50

                        Case "Motocicleta"
                            valorImpuesto(contador) = "Q" & "  " & Val(txtValor.Text * 0.015)
                            pagoParcal(contador) = "Q" & "  " & valorImpuesto(contador) + ValorPaquete(contador)
                            pagoTotal(contador) = "Q" & "  " & precioMoto + pagoParcal(contador)
                            vehiculo(contador) = "Q" & "  " & 15
                    End Select

                Case "Ropa"
                    Select Case cmbMedio.SelectedItem
                        Case "Camion"
                            valorImpuesto(contador) = "Q" & "  " & Val(txtValor.Text * 0.06)
                            pagoParcal(contador) = "Q" & "  " & valorImpuesto(contador) + ValorPaquete(contador)
                            pagoTotal(contador) = "Q" & "  " & precioCamion + pagoParcal(contador)
                            vehiculo(contador) = "Q" & "  " & 50

                        Case "Motocicleta"
                            valorImpuesto(contador) = "Q" & "  " & Val(txtValor.Text * 0.06)
                            pagoParcal(contador) = "Q" & "  " & valorImpuesto(contador) + ValorPaquete(contador)
                            pagoTotal(contador) = "Q" & "  " & precioMoto + pagoParcal(contador)
                            vehiculo(contador) = "Q" & "  " & 15
                    End Select

                Case "Artículos Perecederos"
                    Select Case cmbMedio.SelectedItem
                        Case "Camion"
                            valorImpuesto(contador) = "Q" & "  " & Val(txtValor.Text * 0.055)
                            pagoParcal(contador) = "Q" & "  " & valorImpuesto(contador) + ValorPaquete(contador)
                            pagoTotal(contador) = "Q" & "  " & precioCamion + pagoParcal(contador)
                            vehiculo(contador) = "Q" & "  " & 50

                        Case "Motocicleta"
                            valorImpuesto(contador) = "Q" & "  " & Val(txtValor.Text * 0.055)
                            pagoParcal(contador) = "Q" & "  " & valorImpuesto(contador) + ValorPaquete(contador)
                            pagoTotal(contador) = "Q" & "  " & precioMoto + pagoParcal(contador)
                            vehiculo(contador) = "Q" & "  " & 15
                    End Select

                Case "Artículos de Plástico"
                    Select Case cmbMedio.SelectedItem
                        Case "Camion"
                            valorImpuesto(contador) = "Q" & "  " & Val(txtValor.Text * 0.045)
                            pagoParcal(contador) = "Q" & "  " & valorImpuesto(contador) + ValorPaquete(contador)
                            pagoTotal(contador) = "Q" & "  " & precioCamion + pagoParcal(contador)
                            vehiculo(contador) = "Q" & "  " & 50

                        Case "Motocicleta"
                            valorImpuesto(contador) = "Q" & "  " & Val(txtValor.Text * 0.045)
                            pagoParcal(contador) = "Q" & "  " & valorImpuesto(contador) + ValorPaquete(contador)
                            pagoTotal(contador) = "Q" & "  " & precioMoto + pagoParcal(contador)
                            vehiculo(contador) = "Q" & "  " & 15
                    End Select

                Case "Lociones"
                    Select Case cmbMedio.SelectedItem
                        Case "Camion"
                            valorImpuesto(contador) = "Q" & "  " & Val(txtValor.Text * 0.02)
                            pagoParcal(contador) = "Q" & "  " & valorImpuesto(contador) + ValorPaquete(contador)
                            pagoTotal(contador) = "Q" & "  " & precioCamion + pagoParcal(contador)
                            vehiculo(contador) = "Q" & "  " & 50

                        Case "Motocicleta"
                            valorImpuesto(contador) = "Q" & "  " & Val(txtValor.Text * 0.02)
                            pagoParcal(contador) = "Q" & "  " & valorImpuesto(contador) + ValorPaquete(contador)
                            pagoTotal(contador) = "Q" & "  " & precioMoto + pagoParcal(contador)
                            vehiculo(contador) = "Q" & "  " & 15
                    End Select

            End Select


            LBNumero.Items.Add(numeroTransaccion(contador))
            LBNombre.Items.Add(nombre(contador))
            LBPaquete.Items.Add(nombrePaquete(contador))
            LBValor.Items.Add(ValorPaquete(contador))
            LBPagoParcial.Items.Add(pagoParcal(contador))
            LBImpuesto.Items.Add(valorImpuesto(contador))
            LBPagoTotal.Items.Add(pagoTotal(contador))
            LBVehiculo.Items.Add(vehiculo(contador))


            contador = contador + 1

        Else
            MsgBox("Límite de registros alcanzado")

        End If

    End Sub

    Private Sub btnLimpiarEntradas_Click(sender As Object, e As EventArgs) Handles btnLimpiarEntradas.Click
        txtNombre.Clear()
        txtPeso.Clear()
        txtValor.Clear()
        cmbPaquete.Items.Clear()
        cmbMedio.Items.Clear()

    End Sub

    Private Sub btnLimpiarVectores_Click(sender As Object, e As EventArgs) Handles btnLimpiarVectores.Click
        LBNumero.Items.Clear()
        LBNombre.Items.Clear()
        LBPaquete.Items.Clear()
        LBValor.Items.Clear()
        LBPagoParcial.Items.Clear()
        LBImpuesto.Items.Clear()
        LBVehiculo.Items.Clear()
        LBPagoTotal.Items.Clear()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If (MsgBox("¿Desea Salir?", vbCritical + vbYesNo)) = vbYes Then
            End
        End If
    End Sub
End Class
