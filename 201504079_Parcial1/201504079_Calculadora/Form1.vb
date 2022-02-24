Public Class Form1
    Private Sub rbSimples_CheckedChanged(sender As Object, e As EventArgs) Handles rbSimples.CheckedChanged

        If rbSimples.Checked = True Then
            gpSimples.Enabled = True
            txtValor1.Enabled = True
            txtValor2.Enabled = True

        Else
            rbSimples.Checked = False
            gpSimples.Enabled = False
            txtValor1.Enabled = False
            txtValor2.Enabled = False
        End If

    End Sub

    Private Sub rbComplejas_CheckedChanged(sender As Object, e As EventArgs) Handles rbComplejas.CheckedChanged

        If rbComplejas.Checked = True Then
            gpComplejos.Enabled = True
            txtValor3.Enabled = True

        Else
            rbComplejas.Checked = False
            gpComplejos.Enabled = False
            txtValor3.Enabled = False
        End If

    End Sub

    Private Sub txtValor1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
        End If
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValor2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
        End If
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValor3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
        End If
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        If rbSimples.Checked = False Or rbComplejas.Checked = False Then
            MsgBox("No ha seleccionado Operación")
        End If

        If rbSuma.Checked = False And rbResta.Checked = False And rbMulti.Checked = False And rbDivision.Checked = False Then
            MsgBox("No ha seleccionado Operación Simple")
        End If

        If rbPotencia.Checked = False And rbRaiz.Checked = False And rbCoseno.Checked = False And rbSeno.Checked = False Then
            MsgBox("No ha seleccionado Operación Compleja")
        End If

        If txtValor2.Text <= 0 Then
            MsgBox("No se puede dividir dentro de 0")
        End If

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
