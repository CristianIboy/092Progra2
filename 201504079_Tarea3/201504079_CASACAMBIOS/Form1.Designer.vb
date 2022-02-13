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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cbCompra = New System.Windows.Forms.CheckBox()
        Me.cbVenta = New System.Windows.Forms.CheckBox()
        Me.txtCompra = New System.Windows.Forms.TextBox()
        Me.txtVenta = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.compraDolar = New System.Windows.Forms.RadioButton()
        Me.compraPeso = New System.Windows.Forms.RadioButton()
        Me.compraEuro = New System.Windows.Forms.RadioButton()
        Me.compraColon = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ventaDolar = New System.Windows.Forms.RadioButton()
        Me.ventaColon = New System.Windows.Forms.RadioButton()
        Me.ventaPeso = New System.Windows.Forms.RadioButton()
        Me.ventaEuro = New System.Windows.Forms.RadioButton()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbCompra
        '
        Me.cbCompra.AutoSize = True
        Me.cbCompra.Location = New System.Drawing.Point(6, 29)
        Me.cbCompra.Name = "cbCompra"
        Me.cbCompra.Size = New System.Drawing.Size(78, 20)
        Me.cbCompra.TabIndex = 0
        Me.cbCompra.Text = "Comprar"
        Me.cbCompra.UseVisualStyleBackColor = True
        '
        'cbVenta
        '
        Me.cbVenta.AutoSize = True
        Me.cbVenta.Location = New System.Drawing.Point(203, 31)
        Me.cbVenta.Name = "cbVenta"
        Me.cbVenta.Size = New System.Drawing.Size(70, 20)
        Me.cbVenta.TabIndex = 1
        Me.cbVenta.Text = "Vender"
        Me.cbVenta.UseVisualStyleBackColor = True
        '
        'txtCompra
        '
        Me.txtCompra.Enabled = False
        Me.txtCompra.Location = New System.Drawing.Point(81, 27)
        Me.txtCompra.Name = "txtCompra"
        Me.txtCompra.Size = New System.Drawing.Size(100, 22)
        Me.txtCompra.TabIndex = 2
        '
        'txtVenta
        '
        Me.txtVenta.Enabled = False
        Me.txtVenta.Location = New System.Drawing.Point(279, 29)
        Me.txtVenta.Name = "txtVenta"
        Me.txtVenta.Size = New System.Drawing.Size(100, 22)
        Me.txtVenta.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox2.Controls.Add(Me.txtCompra)
        Me.GroupBox2.Controls.Add(Me.cbCompra)
        Me.GroupBox2.Controls.Add(Me.cbVenta)
        Me.GroupBox2.Controls.Add(Me.txtVenta)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(24, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(399, 64)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transacciones"
        '
        'compraDolar
        '
        Me.compraDolar.AutoSize = True
        Me.compraDolar.Location = New System.Drawing.Point(9, 27)
        Me.compraDolar.Name = "compraDolar"
        Me.compraDolar.Size = New System.Drawing.Size(58, 20)
        Me.compraDolar.TabIndex = 14
        Me.compraDolar.TabStop = True
        Me.compraDolar.Text = "Dolar"
        Me.compraDolar.UseVisualStyleBackColor = True
        '
        'compraPeso
        '
        Me.compraPeso.AutoSize = True
        Me.compraPeso.Location = New System.Drawing.Point(9, 50)
        Me.compraPeso.Name = "compraPeso"
        Me.compraPeso.Size = New System.Drawing.Size(92, 20)
        Me.compraPeso.TabIndex = 15
        Me.compraPeso.TabStop = True
        Me.compraPeso.Text = "Pesos Mex"
        Me.compraPeso.UseVisualStyleBackColor = True
        '
        'compraEuro
        '
        Me.compraEuro.AutoSize = True
        Me.compraEuro.Location = New System.Drawing.Point(9, 73)
        Me.compraEuro.Name = "compraEuro"
        Me.compraEuro.Size = New System.Drawing.Size(60, 20)
        Me.compraEuro.TabIndex = 16
        Me.compraEuro.TabStop = True
        Me.compraEuro.Text = "Euros"
        Me.compraEuro.UseVisualStyleBackColor = True
        '
        'compraColon
        '
        Me.compraColon.AutoSize = True
        Me.compraColon.Location = New System.Drawing.Point(9, 96)
        Me.compraColon.Name = "compraColon"
        Me.compraColon.Size = New System.Drawing.Size(97, 20)
        Me.compraColon.TabIndex = 17
        Me.compraColon.TabStop = True
        Me.compraColon.Text = "Colones CR"
        Me.compraColon.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox3.Controls.Add(Me.compraDolar)
        Me.GroupBox3.Controls.Add(Me.compraColon)
        Me.GroupBox3.Controls.Add(Me.compraPeso)
        Me.GroupBox3.Controls.Add(Me.compraEuro)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(30, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(107, 127)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Compra"
        Me.GroupBox3.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox4.Controls.Add(Me.ventaDolar)
        Me.GroupBox4.Controls.Add(Me.ventaColon)
        Me.GroupBox4.Controls.Add(Me.ventaPeso)
        Me.GroupBox4.Controls.Add(Me.ventaEuro)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(227, 112)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(107, 127)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Venta"
        Me.GroupBox4.Visible = False
        '
        'ventaDolar
        '
        Me.ventaDolar.AutoSize = True
        Me.ventaDolar.Location = New System.Drawing.Point(9, 27)
        Me.ventaDolar.Name = "ventaDolar"
        Me.ventaDolar.Size = New System.Drawing.Size(58, 20)
        Me.ventaDolar.TabIndex = 14
        Me.ventaDolar.TabStop = True
        Me.ventaDolar.Text = "Dolar"
        Me.ventaDolar.UseVisualStyleBackColor = True
        '
        'ventaColon
        '
        Me.ventaColon.AutoSize = True
        Me.ventaColon.Location = New System.Drawing.Point(9, 96)
        Me.ventaColon.Name = "ventaColon"
        Me.ventaColon.Size = New System.Drawing.Size(97, 20)
        Me.ventaColon.TabIndex = 17
        Me.ventaColon.TabStop = True
        Me.ventaColon.Text = "Colones CR"
        Me.ventaColon.UseVisualStyleBackColor = True
        '
        'ventaPeso
        '
        Me.ventaPeso.AutoSize = True
        Me.ventaPeso.Location = New System.Drawing.Point(9, 50)
        Me.ventaPeso.Name = "ventaPeso"
        Me.ventaPeso.Size = New System.Drawing.Size(92, 20)
        Me.ventaPeso.TabIndex = 15
        Me.ventaPeso.TabStop = True
        Me.ventaPeso.Text = "Pesos Mex"
        Me.ventaPeso.UseVisualStyleBackColor = True
        '
        'ventaEuro
        '
        Me.ventaEuro.AutoSize = True
        Me.ventaEuro.Location = New System.Drawing.Point(9, 73)
        Me.ventaEuro.Name = "ventaEuro"
        Me.ventaEuro.Size = New System.Drawing.Size(60, 20)
        Me.ventaEuro.TabIndex = 16
        Me.ventaEuro.TabStop = True
        Me.ventaEuro.Text = "Euros"
        Me.ventaEuro.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(52, 274)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(100, 31)
        Me.btnCalcular.TabIndex = 20
        Me.btnCalcular.Text = "&Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(178, 274)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(100, 31)
        Me.btnLimpiar.TabIndex = 21
        Me.btnLimpiar.Text = "&Limpiar "
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.RosyBrown
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(331, 302)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 31)
        Me.btnSalir.TabIndex = 22
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(450, 355)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbCompra As CheckBox
    Friend WithEvents cbVenta As CheckBox
    Friend WithEvents txtCompra As TextBox
    Friend WithEvents txtVenta As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents compraDolar As RadioButton
    Friend WithEvents compraPeso As RadioButton
    Friend WithEvents compraEuro As RadioButton
    Friend WithEvents compraColon As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ventaDolar As RadioButton
    Friend WithEvents ventaColon As RadioButton
    Friend WithEvents ventaPeso As RadioButton
    Friend WithEvents ventaEuro As RadioButton
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
End Class
