Public Class Form1
    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click

        If (Indice <= 7) Then
            matriz(Indice, 0) = txtNombre.Text
            matriz(Indice, 1) = txtNIT.Text
            matriz(Indice, 2) = txtCantidadPersonas.Text
            matriz(Indice, 3) = cmbTipoHabitacion.Text

            Select Case cmbTipoHabitacion.SelectedIndex
                Case 0 : matriz(Indice, 4) = 250
                Case 1 : matriz(Indice, 4) = 290
                Case 2 : matriz(Indice, 4) = 370
            End Select

            If Val(txtCantidadPersonas.Text) <= 4 Then
                matriz(Indice, 4) = Str(Val(matriz(Indice, 4)))

            Else
                matriz(Indice, 4) = Str(Val(matriz(Indice, 4)) + (Val(matriz(Indice, 2) - 4) * 60))

            End If

            End If



    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click

        Call mostrar()

    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click

        Call limpiar()

    End Sub

    Private Sub OrdenarDecendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarDecendenteToolStripMenuItem.Click

    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click

    End Sub
End Class
