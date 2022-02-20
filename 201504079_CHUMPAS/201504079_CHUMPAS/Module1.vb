Module Module1

    Public Const mano_obra_Small = 65.5
    Public Const mano_obra_Medium = 85.99
    Public Const mano_obra_Large = 99.99

    Public Const precio_yarda_Algodon = 15
    Public Const precio_yarda_Seda = 23.99
    Public Const precio_yarda_Lona = 30.99

    Public Const cantidad_Yarda_Small = 2
    Public Const cantidad_Yarda_Medium = 2.5
    Public Const cantidad_Yarda_Large = 3

    Public precio_Costo = 0
    Public precio_Venta = 0



    Public Sub calcular(material As String, tamaño As String, Cantidad As Double)

        'costo = mano de obra + (material * yardas)

        Select Case tamaño
            Case "Small"
                Select Case material
                    Case "Algodon"
                        precio_Costo = (Cantidad * mano_obra_Small) + (Cantidad * precio_yarda_Algodon * cantidad_Yarda_Small)
                    Case "Seda"
                        precio_Costo = (Cantidad * mano_obra_Small) + (Cantidad * precio_yarda_Seda * cantidad_Yarda_Small)
                    Case "Lona"
                        precio_Costo = (Cantidad * mano_obra_Small) + (Cantidad * precio_yarda_Lona * cantidad_Yarda_Small)
                End Select

            Case "Medium"
                Select Case material
                    Case "Algodon"
                        precio_Costo = (Cantidad * mano_obra_Medium) + (Cantidad * precio_yarda_Algodon * cantidad_Yarda_Medium)
                    Case "Seda"
                        precio_Costo = (Cantidad * mano_obra_Medium) + (Cantidad * precio_yarda_Seda * cantidad_Yarda_Medium)
                    Case "Lona"
                        precio_Costo = (Cantidad * mano_obra_Medium) + (Cantidad * precio_yarda_Lona * cantidad_Yarda_Medium)
                End Select

            Case "Large"
                Select Case material
                    Case "Algodon"
                        precio_Costo = (Cantidad * mano_obra_Large) + (Cantidad * precio_yarda_Algodon * cantidad_Yarda_Large)
                    Case "Seda"
                        precio_Costo = (Cantidad * mano_obra_Large) + (Cantidad * precio_yarda_Seda * cantidad_Yarda_Large)
                    Case "Lona"
                        precio_Costo = (Cantidad * mano_obra_Large) + (Cantidad * precio_yarda_Lona * cantidad_Yarda_Large)
                End Select
        End Select


        precio_Venta = precio_Costo + 0.65 * precio_Costo



    End Sub

    Sub limpiar()

        Form1.txtCantidad.Clear()

        Form1.rbSmall.Checked = False
        Form1.rbMedium.Checked = False
        Form1.rbLarge.Checked = False

        Form1.rbAlgodon.Checked = False
        Form1.rbLona.Checked = False
        Form1.rbSeda.Checked = False

    End Sub

End Module
