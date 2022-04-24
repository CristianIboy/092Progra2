Module Module1

    Public Const tipo1 = 500
    Public Const tipo2 = 400
    Public Const tipo3 = 300
    Public Const tipo4 = 200

    Public tipoAuto(7) As String
    Public placa(7) As Double
    Public cobrobase(7) As Double
    Public kminicial(7) As Double
    Public kmfinal(7) As Double
    Public pagofinal(7) As Double
    Public precioPorKm(7) As Double
    Public kmRecorridos As Double

    Public fila As Byte = 0

    Sub calcular()

        If (fila < 7) Then
            If (IsNumeric(Form1.txtPlaca.Text) And Val(Form1.txtPlaca.Text) > 0) Then
                placa(fila) = Val(Form1.txtPlaca.Text)
            Else
                MsgBox("Error, el dato no es numérico")
                Form1.txtPlaca.Focus() : Exit Sub
            End If
        End If

        If (fila < 7) Then
            If (IsNumeric(Form1.txtKmInicial.Text) And Val(Form1.txtKmInicial.Text) >= 0) Then
                kminicial(fila) = Val(Form1.txtKmInicial.Text)
            Else
                MsgBox("Error, el dato no es válido")
                Form1.txtKmInicial.Focus() : Exit Sub
            End If
        End If

        If (fila < 7) Then
            If (IsNumeric(Form1.txtKmFinal.Text) And Val(Form1.txtKmFinal.Text) > 0) Then
                kmfinal(fila) = Val(Form1.txtKmFinal.Text)
            Else
                MsgBox("Error, el dato no es válido")
                Form1.txtKmFinal.Focus() : Exit Sub
            End If
        End If

        tipoAuto(fila) = Form1.cmbTipoCarro.SelectedItem
        placa(fila) = Form1.txtPlaca.Text
        kminicial(fila) = Form1.txtKmInicial.Text
        kmfinal(fila) = Form1.txtKmFinal.Text
        kmRecorridos = (Val(Form1.txtKmFinal.Text) - Val(Form1.txtKmInicial.Text))

        Select Case tipoAuto(fila)
            Case "Tipo 1"
                cobrobase(fila) = "Q" & "  " & tipo1

                If kmRecorridos >= 0 And kmRecorridos <= 50 Then
                    pagofinal(fila) = (kmRecorridos * 3) + cobrobase(fila)
                End If
                If kmRecorridos >= 51 And kmRecorridos <= 70 Then
                    pagofinal(fila) = (kmRecorridos * 4) + cobrobase(fila)
                End If
                If kmRecorridos >= 71 Then
                    pagofinal(fila) = (kmRecorridos * 5) + cobrobase(fila)
                End If

            Case "Tipo 2"
                cobrobase(fila) = "Q" & "  " & tipo2
                If kmRecorridos >= 0 And kmRecorridos <= 50 Then
                    pagofinal(fila) = (kmRecorridos * 3) + cobrobase(fila)
                End If
                If kmRecorridos >= 51 And kmRecorridos <= 70 Then
                    pagofinal(fila) = (kmRecorridos * 4) + cobrobase(fila)
                End If
                If kmRecorridos >= 71 Then
                    pagofinal(fila) = (kmRecorridos * 5) + cobrobase(fila)
                End If

            Case "Tipo 3"
                cobrobase(fila) = "Q" & "  " & tipo3
                If kmRecorridos >= 0 And kmRecorridos <= 50 Then
                    pagofinal(fila) = (kmRecorridos * 3) + cobrobase(fila)
                End If
                If kmRecorridos >= 51 And kmRecorridos <= 70 Then
                    pagofinal(fila) = (kmRecorridos * 4) + cobrobase(fila)
                End If
                If kmRecorridos >= 71 Then
                    pagofinal(fila) = (kmRecorridos * 5) + cobrobase(fila)
                End If

            Case "Tipo 4"
                cobrobase(fila) = "Q" & "  " & tipo4
                If kmRecorridos >= 0 And kmRecorridos <= 50 Then
                    pagofinal(fila) = (kmRecorridos * 3) + cobrobase(fila)
                End If
                If kmRecorridos >= 51 And kmRecorridos <= 70 Then
                    pagofinal(fila) = (kmRecorridos * 4) + cobrobase(fila)
                End If
                If kmRecorridos >= 71 Then
                    pagofinal(fila) = (kmRecorridos * 5) + cobrobase(fila)
                End If

        End Select

        pagofinal(fila) = pagofinal(fila)

    End Sub

    Sub mostrar()

        Form1.DataGridView1.Rows.Add(tipoAuto(fila), placa(fila), cobrobase(fila), kminicial(fila), kmfinal(fila), pagofinal(fila))
        fila = fila + 1
        If (fila = 7) Then
            MsgBox("Vectores llenos")
            Form1.CalcularToolStripMenuItem.Enabled = False

        End If
    End Sub

    Sub limpiar()

        Form1.txtPlaca.Text = " "
        Form1.txtKmFinal.Text = " "
        Form1.txtKmInicial.Text = " "
        Form1.cmbTipoCarro.Text = " "
        Form1.DataGridView1.Rows.Clear()

    End Sub

    Sub salir()
        If (MsgBox("¿Desea Salir?", vbCritical + vbYesNo)) = vbYes Then
            End
        End If
    End Sub

End Module
