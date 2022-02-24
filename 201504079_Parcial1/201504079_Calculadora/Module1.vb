Module Module1

    Dim total_suma = 0
    Dim total_resta = 0
    Dim total_multi = 0
    Dim total_division = 0
    Dim total_potencia = 0
    Dim total_raiz = 0
    Dim total_coseno = 0
    Dim total_seno = 0

    Sub limpiar()
        Form1.rbSimples.Checked = False
        Form1.rbComplejas.Checked = False
        Form1.rbSuma.Checked = False
        Form1.rbResta.Checked = False
        Form1.rbMulti.Checked = False
        Form1.rbDivision.Checked = False
        Form1.rbPotencia.Checked = False
        Form1.rbRaiz.Checked = False
        Form1.rbCoseno.Checked = False
        Form1.rbSeno.Checked = False
        Form1.txtValor1.Clear()
        Form1.txtValor2.Clear()
        Form1.txtValor3.Clear()

    End Sub

    Function calcularSimple(cantidad1 As Double, cantidad2 As Double) As Double
        total_suma = Form1.txtValor1.Text + Form1.txtValor2.Text
        total_resta = Form1.txtValor1.Text - Form1.txtValor2.Text
        total_multi = Form1.txtValor1.Text * Form1.txtValor2.Text
        total_division = Form1.txtValor1.Text / Form1.txtValor2.Text

        total_potencia = Form1.txtValor3.Text * Form1.txtValor3.Text

        total_coseno = Form1.txtValor3.Text * Form1.txtValor3.Text
        total_seno = Form1.txtValor3.Text * Form1.txtValor3.Text

    End Function
End Module
