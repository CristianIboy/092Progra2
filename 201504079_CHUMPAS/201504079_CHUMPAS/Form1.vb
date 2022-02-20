Public Class Form1
    Private Sub txtCantidad_keyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Asc(e.KeyChar) <> 8 Then
        End If
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCalcular_Click_1(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If rbSmall.Checked = False And rbMedium.Checked = False And rbLarge.Checked = False Then
            MsgBox("No se ha seleccionado tamaño")
        End If

        If rbAlgodon.Checked = False And rbSeda.Checked = False And rbLona.Checked = False Then
            MsgBox("No se ha seleccionado material")
        End If

        If txtCantidad.Text = "" Then
            MsgBox("Ingrese cantidad")
        End If

        Dim tamaño As String
        Dim material As String

        If rbSmall.Checked Then
            tamaño = "small"
        ElseIf rbMedium.Checked Then
            tamaño = "Medium"
        ElseIf rbLarge.Checked Then
            tamaño = "Large"
        End If

        If rbAlgodon.Checked Then
            material = "Algodon"
        ElseIf rbSeda.Checked Then
            material = "Seda"
        ElseIf rbLona.Checked Then
            material = "Lona"
        End If

        calcular(tamaño, material, Val(txtCantidad.Text))
        Me.Hide()
        Form2.Show()

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
