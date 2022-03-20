Module Module1
    Public Const precioJugos = 8.5
    Public Const precioFrituras = 11.2
    Public Const precioGalletas = 4.25
    Public Const precioBaterias = 15

    Dim inventarioJugo = 1000
    Dim inventarioFrituras = 2000
    Dim inventarioGalletas = 3000
    Dim inventarioBaterias = 4000

    Public nombreProducto(6)
    Public nombrePack(6)
    Public numeroPacks(6)
    Public productoDeseado(6)
    Public cantidadInventario(6)
    Public cantidadDeseada(6)
    Public sobrante(6)
    Public ingresoPacks(6)
    Public IngresoSobrante(6)
    Public FILA As Byte = 0


    Public contador = 0


    Sub limpiar()
        Form1.cmbProducto.Text = ""
        Form1.txtCantidad.Text = ""

        Form1.DataGridView1.Rows.Clear()


    End Sub

    Sub calcular()
        nombreProducto(contador) = Form1.cmbProducto.SelectedItem
        nombrePack(contador) = "Pack" & Form1.cmbProducto.SelectedItem
        productoDeseado(contador) = Form1.cmbProducto.SelectedItem
        cantidadDeseada(contador) = Form1.txtCantidad.Text
        cantidadInventario(contador) = inventarioJugo
        cantidadDeseada(contador) = Form1.txtCantidad
        sobrante(contador) = inventarioJugo Mod cantidadDeseada


        Select Case nombreProducto(contador)
            Case "Jugo"

                numeroPacks(contador) = inventarioJugo / cantidadDeseada(contador)



        End Select




        Form1.DataGridView1.Rows.Add(numeroPacks(FILA), nombrePack(FILA), productoDeseado(FILA), cantidadInventario(FILA), cantidadDeseada(FILA), sobrante(FILA), ingresoPacks(FILA), IngresoSobrante(FILA))
        FILA = FILA + 1
        If FILA = 6 Then
            MsgBox("Vectores Llenos")
            Form1.btnCalcular.Enabled = False
        End If


    End Sub

    Sub salir()
        If (MsgBox("¿Desea Salir?", vbCritical + vbYesNo)) = vbYes Then
            End
        End If
    End Sub

End Module
