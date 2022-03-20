Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If cmbTamaño.SelectedIndex = -1 Or cmbMaterial.SelectedIndex = -1 Then
            MsgBox("Seleccione todos los campos")
            Exit Sub
        End If

        If contador < 8 Then
            numeroVenta(contador) = contador + 1
            tamaño(contador) = cmbTamaño.SelectedItem
            material(contador) = cmbMaterial.SelectedItem


            Select Case tamaño(contador)

                Case "Sofá"
                    Select Case material(contador)
                        Case "Cuero"
                            precioManoObra(contador) = "Q" & "      " & precioSofa
                            precioCosto(contador) = "Q" & "      " & 8 * precio_cuero + precioManoObra(contador)
                        Case "Cuerina"
                            precioManoObra(contador) = "Q" & "      " & precioSofa
                            precioCosto(contador) = "Q" & "      " & 8 * precio_cuerina + precioManoObra(contador)
                    End Select

                Case "Individual"
                    Select Case material(contador)
                        Case "Cuero"
                            precioManoObra(contador) = "Q" & "      " & precioIndividual
                            precioCosto(contador) = "Q" & "      " & 3.5 * precio_cuero + precioManoObra(contador)
                        Case "Cuerina"
                            precioManoObra(contador) = "Q" & "      " & precioIndividual
                            precioCosto(contador) = "Q" & "      " & 3.5 * precio_cuerina + precioManoObra(contador)
                    End Select

                Case "Doble"
                    Select Case material(contador)
                        Case "Cuero"
                            precioManoObra(contador) = "Q" & "      " & precioDoble
                            precioCosto(contador) = "Q" & "      " & 6 * precio_cuero + precioManoObra(contador)
                        Case "Cuerina"
                            precioManoObra(contador) = "Q" & "      " & precioDoble
                            precioCosto(contador) = "Q" & "      " & 6 * precio_cuerina + precioManoObra(contador)
                    End Select

            End Select


            precioVenta(contador) = "Q" & "      " & precioCosto(contador) * 1.65


            ListBox1.Items.Add(numeroVenta(contador))
            ListBox2.Items.Add(tamaño(contador))
            ListBox3.Items.Add(material(contador))
            ListBox4.Items.Add(precioManoObra(contador))
            ListBox5.Items.Add(precioCosto(contador))
            ListBox6.Items.Add(precioVenta(contador))






            contador = contador + 1
        Else
            MsgBox("Límite de registros alcanzado")
        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If (MsgBox("¿Desea Salir?", vbCritical + vbYesNo)) = vbYes Then
            End
        End If
    End Sub
End Class
