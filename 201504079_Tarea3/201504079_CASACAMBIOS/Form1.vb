Public Class Form1
    Private Sub cbCompra_CheckedChanged(sender As Object, e As EventArgs) Handles cbCompra.CheckedChanged
        If cbCompra.Checked = True Then
            txtCompra.Enabled = True
            GroupBox3.Enabled = True
            GroupBox3.Visible = True
        Else
            txtCompra.Enabled = False
            GroupBox3.Enabled = False
            GroupBox3.Visible = False
        End If
    End Sub

    Private Sub cbVenta_CheckedChanged(sender As Object, e As EventArgs) Handles cbVenta.CheckedChanged
        If cbVenta.Checked = True Then
            txtVenta.Enabled = True
            GroupBox4.Enabled = True
            GroupBox4.Visible = True
        Else
            txtVenta.Enabled = False
            GroupBox4.Enabled = False
            GroupBox4.Visible = False
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If (MsgBox("¿Desea Salir?", vbCritical + vbYesNo)) = vbYes Then
            End
        End If
    End Sub

    Private Sub txtCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCompra.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVenta.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
