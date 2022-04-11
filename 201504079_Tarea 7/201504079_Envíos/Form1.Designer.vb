<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.groupPaquete = New System.Windows.Forms.GroupBox()
        Me.cmbPaquete = New System.Windows.Forms.ComboBox()
        Me.groupVehiculo = New System.Windows.Forms.GroupBox()
        Me.lblMoto = New System.Windows.Forms.Label()
        Me.lblCamion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groupDatos = New System.Windows.Forms.GroupBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBNumero = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LBImpuesto = New System.Windows.Forms.ListBox()
        Me.LBPagoParcial = New System.Windows.Forms.ListBox()
        Me.LBValor = New System.Windows.Forms.ListBox()
        Me.LBPaquete = New System.Windows.Forms.ListBox()
        Me.LBNombre = New System.Windows.Forms.ListBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnLimpiarEntradas = New System.Windows.Forms.Button()
        Me.btnLimpiarVectores = New System.Windows.Forms.Button()
        Me.btnMostratVectores = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.LBPagoTotal = New System.Windows.Forms.ListBox()
        Me.cmbMedio = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LBVehiculo = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.groupPaquete.SuspendLayout()
        Me.groupVehiculo.SuspendLayout()
        Me.groupDatos.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupPaquete
        '
        Me.groupPaquete.Controls.Add(Me.cmbPaquete)
        Me.groupPaquete.Location = New System.Drawing.Point(31, 169)
        Me.groupPaquete.Name = "groupPaquete"
        Me.groupPaquete.Size = New System.Drawing.Size(188, 91)
        Me.groupPaquete.TabIndex = 0
        Me.groupPaquete.TabStop = False
        Me.groupPaquete.Text = "Paquete"
        '
        'cmbPaquete
        '
        Me.cmbPaquete.FormattingEnabled = True
        Me.cmbPaquete.Items.AddRange(New Object() {"Articulos de plastico", "Articulos no perecederos", "Documentos", "Lociones", "Ropa"})
        Me.cmbPaquete.Location = New System.Drawing.Point(6, 31)
        Me.cmbPaquete.Name = "cmbPaquete"
        Me.cmbPaquete.Size = New System.Drawing.Size(176, 21)
        Me.cmbPaquete.TabIndex = 4
        '
        'groupVehiculo
        '
        Me.groupVehiculo.Controls.Add(Me.cmbMedio)
        Me.groupVehiculo.Controls.Add(Me.lblMoto)
        Me.groupVehiculo.Controls.Add(Me.lblCamion)
        Me.groupVehiculo.Controls.Add(Me.Label2)
        Me.groupVehiculo.Controls.Add(Me.Label1)
        Me.groupVehiculo.Location = New System.Drawing.Point(35, 277)
        Me.groupVehiculo.Name = "groupVehiculo"
        Me.groupVehiculo.Size = New System.Drawing.Size(178, 88)
        Me.groupVehiculo.TabIndex = 1
        Me.groupVehiculo.TabStop = False
        Me.groupVehiculo.Text = "Medio de transporte"
        '
        'lblMoto
        '
        Me.lblMoto.AutoSize = True
        Me.lblMoto.Location = New System.Drawing.Point(113, 58)
        Me.lblMoto.Name = "lblMoto"
        Me.lblMoto.Size = New System.Drawing.Size(48, 13)
        Me.lblMoto.TabIndex = 11
        Me.lblMoto.Text = "Q. 15.00"
        Me.lblMoto.Visible = False
        '
        'lblCamion
        '
        Me.lblCamion.AutoSize = True
        Me.lblCamion.Location = New System.Drawing.Point(113, 58)
        Me.lblCamion.Name = "lblCamion"
        Me.lblCamion.Size = New System.Drawing.Size(48, 13)
        Me.lblCamion.TabIndex = 10
        Me.lblCamion.Text = "Q. 50.00"
        Me.lblCamion.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Precio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Medio de envío"
        '
        'groupDatos
        '
        Me.groupDatos.Controls.Add(Me.txtPeso)
        Me.groupDatos.Controls.Add(Me.txtValor)
        Me.groupDatos.Controls.Add(Me.txtNombre)
        Me.groupDatos.Controls.Add(Me.Label5)
        Me.groupDatos.Controls.Add(Me.Label4)
        Me.groupDatos.Controls.Add(Me.Label3)
        Me.groupDatos.Location = New System.Drawing.Point(29, 28)
        Me.groupDatos.Name = "groupDatos"
        Me.groupDatos.Size = New System.Drawing.Size(246, 135)
        Me.groupDatos.TabIndex = 1
        Me.groupDatos.TabStop = False
        Me.groupDatos.Text = "Datos"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(61, 99)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(100, 20)
        Me.txtPeso.TabIndex = 5
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(61, 59)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(61, 26)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(166, 20)
        Me.txtNombre.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Peso:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Valor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nombre:"
        '
        'LBNumero
        '
        Me.LBNumero.FormattingEnabled = True
        Me.LBNumero.Location = New System.Drawing.Point(11, 45)
        Me.LBNumero.Name = "LBNumero"
        Me.LBNumero.Size = New System.Drawing.Size(49, 173)
        Me.LBNumero.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.LBVehiculo)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.LBPagoTotal)
        Me.GroupBox4.Controls.Add(Me.LBImpuesto)
        Me.GroupBox4.Controls.Add(Me.LBPagoParcial)
        Me.GroupBox4.Controls.Add(Me.LBValor)
        Me.GroupBox4.Controls.Add(Me.LBPaquete)
        Me.GroupBox4.Controls.Add(Me.LBNombre)
        Me.GroupBox4.Controls.Add(Me.LBNumero)
        Me.GroupBox4.Location = New System.Drawing.Point(291, 33)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(687, 227)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'LBImpuesto
        '
        Me.LBImpuesto.FormattingEnabled = True
        Me.LBImpuesto.Location = New System.Drawing.Point(426, 45)
        Me.LBImpuesto.Name = "LBImpuesto"
        Me.LBImpuesto.Size = New System.Drawing.Size(78, 173)
        Me.LBImpuesto.TabIndex = 7
        '
        'LBPagoParcial
        '
        Me.LBPagoParcial.FormattingEnabled = True
        Me.LBPagoParcial.Location = New System.Drawing.Point(321, 45)
        Me.LBPagoParcial.Name = "LBPagoParcial"
        Me.LBPagoParcial.Size = New System.Drawing.Size(99, 173)
        Me.LBPagoParcial.TabIndex = 6
        '
        'LBValor
        '
        Me.LBValor.FormattingEnabled = True
        Me.LBValor.Location = New System.Drawing.Point(237, 45)
        Me.LBValor.Name = "LBValor"
        Me.LBValor.Size = New System.Drawing.Size(78, 173)
        Me.LBValor.TabIndex = 5
        '
        'LBPaquete
        '
        Me.LBPaquete.FormattingEnabled = True
        Me.LBPaquete.Location = New System.Drawing.Point(152, 45)
        Me.LBPaquete.Name = "LBPaquete"
        Me.LBPaquete.Size = New System.Drawing.Size(78, 173)
        Me.LBPaquete.TabIndex = 4
        '
        'LBNombre
        '
        Me.LBNombre.FormattingEnabled = True
        Me.LBNombre.Location = New System.Drawing.Point(68, 45)
        Me.LBNombre.Name = "LBNombre"
        Me.LBNombre.Size = New System.Drawing.Size(78, 173)
        Me.LBNombre.TabIndex = 3
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(233, 316)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(96, 49)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnLimpiarEntradas
        '
        Me.btnLimpiarEntradas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarEntradas.Location = New System.Drawing.Point(357, 314)
        Me.btnLimpiarEntradas.Name = "btnLimpiarEntradas"
        Me.btnLimpiarEntradas.Size = New System.Drawing.Size(96, 49)
        Me.btnLimpiarEntradas.TabIndex = 5
        Me.btnLimpiarEntradas.Text = "Limpiar Entradas"
        Me.btnLimpiarEntradas.UseVisualStyleBackColor = True
        '
        'btnLimpiarVectores
        '
        Me.btnLimpiarVectores.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarVectores.Location = New System.Drawing.Point(470, 316)
        Me.btnLimpiarVectores.Name = "btnLimpiarVectores"
        Me.btnLimpiarVectores.Size = New System.Drawing.Size(96, 49)
        Me.btnLimpiarVectores.TabIndex = 6
        Me.btnLimpiarVectores.Text = "Limpiar Vectores"
        Me.btnLimpiarVectores.UseVisualStyleBackColor = True
        '
        'btnMostratVectores
        '
        Me.btnMostratVectores.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostratVectores.Location = New System.Drawing.Point(572, 316)
        Me.btnMostratVectores.Name = "btnMostratVectores"
        Me.btnMostratVectores.Size = New System.Drawing.Size(96, 49)
        Me.btnMostratVectores.TabIndex = 7
        Me.btnMostratVectores.Text = "Mostrar Vectores"
        Me.btnMostratVectores.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.LightCoral
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(692, 316)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 43)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'LBPagoTotal
        '
        Me.LBPagoTotal.FormattingEnabled = True
        Me.LBPagoTotal.Location = New System.Drawing.Point(594, 45)
        Me.LBPagoTotal.Name = "LBPagoTotal"
        Me.LBPagoTotal.Size = New System.Drawing.Size(78, 173)
        Me.LBPagoTotal.TabIndex = 8
        '
        'cmbMedio
        '
        Me.cmbMedio.FormattingEnabled = True
        Me.cmbMedio.Items.AddRange(New Object() {"Camion", "Motocicleta"})
        Me.cmbMedio.Location = New System.Drawing.Point(2, 55)
        Me.cmbMedio.Name = "cmbMedio"
        Me.cmbMedio.Size = New System.Drawing.Size(96, 21)
        Me.cmbMedio.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "# Trans."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(76, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Nombre"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(240, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Valor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(155, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Paquete"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(434, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 16)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Impuesto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(321, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 16)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Pago Parcial"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(610, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 16)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Total"
        '
        'LBVehiculo
        '
        Me.LBVehiculo.FormattingEnabled = True
        Me.LBVehiculo.Location = New System.Drawing.Point(510, 45)
        Me.LBVehiculo.Name = "LBVehiculo"
        Me.LBVehiculo.Size = New System.Drawing.Size(78, 173)
        Me.LBVehiculo.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(510, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 16)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Vehículo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 390)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnMostratVectores)
        Me.Controls.Add(Me.btnLimpiarVectores)
        Me.Controls.Add(Me.btnLimpiarEntradas)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.groupVehiculo)
        Me.Controls.Add(Me.groupDatos)
        Me.Controls.Add(Me.groupPaquete)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.groupPaquete.ResumeLayout(False)
        Me.groupVehiculo.ResumeLayout(False)
        Me.groupVehiculo.PerformLayout()
        Me.groupDatos.ResumeLayout(False)
        Me.groupDatos.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents groupPaquete As GroupBox
    Friend WithEvents groupVehiculo As GroupBox
    Friend WithEvents lblMoto As Label
    Friend WithEvents lblCamion As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents groupDatos As GroupBox
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LBNumero As ListBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents LBImpuesto As ListBox
    Friend WithEvents LBPagoParcial As ListBox
    Friend WithEvents LBValor As ListBox
    Friend WithEvents LBPaquete As ListBox
    Friend WithEvents LBNombre As ListBox
    Friend WithEvents cmbPaquete As ComboBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnLimpiarEntradas As Button
    Friend WithEvents btnLimpiarVectores As Button
    Friend WithEvents btnMostratVectores As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents LBPagoTotal As ListBox
    Friend WithEvents cmbMedio As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LBVehiculo As ListBox
End Class
