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
        Me.txtArroz = New System.Windows.Forms.TextBox()
        Me.txtFrijol = New System.Windows.Forms.TextBox()
        Me.txtAzucar = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblR5 = New System.Windows.Forms.Label()
        Me.lblR4 = New System.Windows.Forms.Label()
        Me.lblR3 = New System.Windows.Forms.Label()
        Me.lblR2 = New System.Windows.Forms.Label()
        Me.lblR1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtArroz
        '
        Me.txtArroz.Location = New System.Drawing.Point(118, 30)
        Me.txtArroz.Name = "txtArroz"
        Me.txtArroz.Size = New System.Drawing.Size(100, 20)
        Me.txtArroz.TabIndex = 0
        '
        'txtFrijol
        '
        Me.txtFrijol.Location = New System.Drawing.Point(118, 92)
        Me.txtFrijol.Name = "txtFrijol"
        Me.txtFrijol.Size = New System.Drawing.Size(100, 20)
        Me.txtFrijol.TabIndex = 1
        '
        'txtAzucar
        '
        Me.txtAzucar.Location = New System.Drawing.Point(118, 147)
        Me.txtAzucar.Name = "txtAzucar"
        Me.txtAzucar.Size = New System.Drawing.Size(100, 20)
        Me.txtAzucar.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAzucar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFrijol)
        Me.GroupBox1.Controls.Add(Me.txtArroz)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 204)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Libras de Frijol"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Libras de Azucar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Libras de Arroz"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Pago Antes del IVA"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblR5)
        Me.GroupBox2.Controls.Add(Me.lblR4)
        Me.GroupBox2.Controls.Add(Me.lblR3)
        Me.GroupBox2.Controls.Add(Me.lblR2)
        Me.GroupBox2.Controls.Add(Me.lblR1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(397, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 354)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados en Quetzales (Q)"
        '
        'lblR5
        '
        Me.lblR5.AutoSize = True
        Me.lblR5.Location = New System.Drawing.Point(144, 267)
        Me.lblR5.Name = "lblR5"
        Me.lblR5.Size = New System.Drawing.Size(22, 13)
        Me.lblR5.TabIndex = 13
        Me.lblR5.Text = "0.0"
        '
        'lblR4
        '
        Me.lblR4.AutoSize = True
        Me.lblR4.Location = New System.Drawing.Point(144, 208)
        Me.lblR4.Name = "lblR4"
        Me.lblR4.Size = New System.Drawing.Size(22, 13)
        Me.lblR4.TabIndex = 12
        Me.lblR4.Text = "0.0"
        '
        'lblR3
        '
        Me.lblR3.AutoSize = True
        Me.lblR3.Location = New System.Drawing.Point(144, 146)
        Me.lblR3.Name = "lblR3"
        Me.lblR3.Size = New System.Drawing.Size(22, 13)
        Me.lblR3.TabIndex = 11
        Me.lblR3.Text = "0.0"
        '
        'lblR2
        '
        Me.lblR2.AutoSize = True
        Me.lblR2.Location = New System.Drawing.Point(144, 88)
        Me.lblR2.Name = "lblR2"
        Me.lblR2.Size = New System.Drawing.Size(22, 13)
        Me.lblR2.TabIndex = 10
        Me.lblR2.Text = "0.0"
        '
        'lblR1
        '
        Me.lblR1.AutoSize = True
        Me.lblR1.Location = New System.Drawing.Point(144, 26)
        Me.lblR1.Name = "lblR1"
        Me.lblR1.Size = New System.Drawing.Size(22, 13)
        Me.lblR1.TabIndex = 9
        Me.lblR1.Text = "0.0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Descuento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Pago con IVA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Valor del IVA"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSalir)
        Me.GroupBox3.Controls.Add(Me.btnLimpiar)
        Me.GroupBox3.Controls.Add(Me.btnAceptar)
        Me.GroupBox3.Location = New System.Drawing.Point(31, 248)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(270, 188)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones "
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(179, 136)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(29, 92)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "&Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(29, 34)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 451)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtArroz As TextBox
    Friend WithEvents txtFrijol As TextBox
    Friend WithEvents txtAzucar As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblR5 As Label
    Friend WithEvents lblR4 As Label
    Friend WithEvents lblR3 As Label
    Friend WithEvents lblR2 As Label
    Friend WithEvents lblR1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnSalir As Button
End Class
