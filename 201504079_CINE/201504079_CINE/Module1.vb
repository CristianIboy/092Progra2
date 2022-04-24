Module Module1

    Public Const precioNormal = 44
    Public Const precio3D = 62
    Public Const precio4DX = 104

    Public NIT(7) As Double
    Public pelicula(7) As String
    Public NoBoletos(7) As Double
    Public tipoSala(7) As String
    Public total(7) As Double

    Public fila As Byte = 0



    Sub calcular()

        If (fila < 7) Then
            If (IsNumeric(Form1.txtboletos.Text) And Val(Form1.txtboletos.Text) > 0) Then
                NoBoletos(fila) = Val(Form1.txtboletos.Text)
            Else
                MsgBox("Error, ingrese cantidad numérica")
                Form1.txtboletos.Focus() : Exit Sub
            End If
        End If

        If (fila < 7) Then
            If (IsNumeric(Form1.txtNIT.Text) And Val(Form1.txtNIT.Text) > 0) Then
                NIT(fila) = Val(Form1.txtNIT.Text)
            Else
                MsgBox("Error, ingrese número de NIT")
                Form1.txtNIT.Focus() : Exit Sub
            End If
        End If


        NIT(fila) = Form1.txtNIT.Text
        pelicula(fila) = Form1.txtPelicula.Text
        NoBoletos(fila) = Form1.txtboletos.Text
        tipoSala(fila) = Form1.cmbTipoSala.SelectedItem

        Select Case tipoSala(fila)

            Case "Normal"
                total(fila) = "Q" & Val(Form1.txtboletos.Text) * precioNormal

            Case "3D"
                total(fila) = "Q" & Val(Form1.txtboletos.Text) * precio3D

            Case "4DX"
                total(fila) = "Q" & Val(Form1.txtboletos.Text) * precio4DX


        End Select

        total(fila) = total(fila)

    End Sub

    Sub mostrar()

        Form1.DataGridView1.Rows.Add(NIT(fila), pelicula(fila), NoBoletos(fila), tipoSala(fila), total(fila))
        fila = fila + 1
        If (fila = 7) Then
            MsgBox("Vectores llenos")
            Form1.MostrarToolStripMenuItem.Enabled = False
            Form1.AceptarToolStripMenuItem.Enabled = False
        End If
    End Sub


    Sub limpiar()

        Form1.txtboletos.Text = " "
        Form1.txtNIT.Text = " "
        Form1.txtPelicula.Text = " "
        Form1.cmbTipoSala.Text = " "
        Form1.DataGridView1.Rows.Clear()

    End Sub

    Sub actualizar()

    End Sub

    Sub buscar()

    End Sub
End Module
