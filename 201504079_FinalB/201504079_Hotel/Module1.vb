Module Module1


    Public Const precioEstandarl = 250
    Public Const precioAC = 290
    Public Const precioJacuzzi = 370


    Public Nombre(7) As String
    Public NIT(7) As Double
    Public CantidadPersonas(7) As Double
    Public TipoHabitacion(7) As String
    Public total(7) As Double

    Public matriz(7, 5) As String

    Public Indice As Byte = 0



    Sub mostrar()

        Form1.DataGridView1.Rows.Add(matriz(Indice, 0), matriz(Indice, 1), matriz(Indice, 2), matriz(Indice, 3), matriz(Indice, 4))
        If (Indice = 7) Then
            MsgBox("Vectores llenos")
        End If

    End Sub

    Sub limpiar()
        Form1.txtNombre.Text = ""
        Form1.txtNIT.Text = ""
        Form1.txtCantidadPersonas.Text = ""
        Form1.cmbTipoHabitacion.Text = ""
        Form1.DataGridView1.Rows.Clear()


        Indice = 0


    End Sub


End Module
