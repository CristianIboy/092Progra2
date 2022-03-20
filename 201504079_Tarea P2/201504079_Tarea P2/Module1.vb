Module Module1
    Public Const precioSofa = 250.99
    Public Const precioIndividual = 150.99
    Public Const precioDoble = 200.99

    Public Const precio_cuero = 75
    Public Const precio_cuerina = 45.99


    Public numeroVenta(8)
    Public tamaño(8)
    Public material(8)
    Public precioManoObra(8)
    Public precioCosto(8)
    Public precioVenta(8)


    Public contador = 0

    Sub limpiar()



        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()


    End Sub
End Module
