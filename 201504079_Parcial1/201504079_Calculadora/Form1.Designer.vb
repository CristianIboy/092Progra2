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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbComplejas = New System.Windows.Forms.RadioButton()
        Me.rbSimples = New System.Windows.Forms.RadioButton()
        Me.gpSimples = New System.Windows.Forms.GroupBox()
        Me.rbMulti = New System.Windows.Forms.RadioButton()
        Me.rbResta = New System.Windows.Forms.RadioButton()
        Me.rbDivision = New System.Windows.Forms.RadioButton()
        Me.rbSuma = New System.Windows.Forms.RadioButton()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.gpComplejos = New System.Windows.Forms.GroupBox()
        Me.rbRaiz = New System.Windows.Forms.RadioButton()
        Me.rbSeno = New System.Windows.Forms.RadioButton()
        Me.rbCoseno = New System.Windows.Forms.RadioButton()
        Me.rbPotencia = New System.Windows.Forms.RadioButton()
        Me.txtValor3 = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.gpSimples.SuspendLayout()
        Me.gpComplejos.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbComplejas)
        Me.GroupBox1.Controls.Add(Me.rbSimples)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 50)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operaciones"
        '
        'rbComplejas
        '
        Me.rbComplejas.AutoSize = True
        Me.rbComplejas.Location = New System.Drawing.Point(383, 20)
        Me.rbComplejas.Name = "rbComplejas"
        Me.rbComplejas.Size = New System.Drawing.Size(73, 17)
        Me.rbComplejas.TabIndex = 1
        Me.rbComplejas.Text = "Complejas"
        Me.rbComplejas.UseVisualStyleBackColor = True
        '
        'rbSimples
        '
        Me.rbSimples.AutoSize = True
        Me.rbSimples.Location = New System.Drawing.Point(100, 20)
        Me.rbSimples.Name = "rbSimples"
        Me.rbSimples.Size = New System.Drawing.Size(61, 17)
        Me.rbSimples.TabIndex = 0
        Me.rbSimples.Text = "Simples"
        Me.rbSimples.UseVisualStyleBackColor = True
        '
        'gpSimples
        '
        Me.gpSimples.Controls.Add(Me.rbMulti)
        Me.gpSimples.Controls.Add(Me.rbResta)
        Me.gpSimples.Controls.Add(Me.rbDivision)
        Me.gpSimples.Controls.Add(Me.rbSuma)
        Me.gpSimples.Controls.Add(Me.txtValor2)
        Me.gpSimples.Controls.Add(Me.txtValor1)
        Me.gpSimples.Enabled = False
        Me.gpSimples.Location = New System.Drawing.Point(12, 142)
        Me.gpSimples.Name = "gpSimples"
        Me.gpSimples.Size = New System.Drawing.Size(263, 118)
        Me.gpSimples.TabIndex = 1
        Me.gpSimples.TabStop = False
        Me.gpSimples.Text = "Simples"
        '
        'rbMulti
        '
        Me.rbMulti.AutoSize = True
        Me.rbMulti.Location = New System.Drawing.Point(145, 63)
        Me.rbMulti.Name = "rbMulti"
        Me.rbMulti.Size = New System.Drawing.Size(89, 17)
        Me.rbMulti.TabIndex = 5
        Me.rbMulti.TabStop = True
        Me.rbMulti.Text = "Multiplicación"
        Me.rbMulti.UseVisualStyleBackColor = True
        '
        'rbResta
        '
        Me.rbResta.AutoSize = True
        Me.rbResta.Location = New System.Drawing.Point(16, 86)
        Me.rbResta.Name = "rbResta"
        Me.rbResta.Size = New System.Drawing.Size(53, 17)
        Me.rbResta.TabIndex = 4
        Me.rbResta.TabStop = True
        Me.rbResta.Text = "Resta"
        Me.rbResta.UseVisualStyleBackColor = True
        '
        'rbDivision
        '
        Me.rbDivision.AutoSize = True
        Me.rbDivision.Location = New System.Drawing.Point(145, 86)
        Me.rbDivision.Name = "rbDivision"
        Me.rbDivision.Size = New System.Drawing.Size(62, 17)
        Me.rbDivision.TabIndex = 3
        Me.rbDivision.TabStop = True
        Me.rbDivision.Text = "División"
        Me.rbDivision.UseVisualStyleBackColor = True
        '
        'rbSuma
        '
        Me.rbSuma.AutoSize = True
        Me.rbSuma.Location = New System.Drawing.Point(16, 63)
        Me.rbSuma.Name = "rbSuma"
        Me.rbSuma.Size = New System.Drawing.Size(52, 17)
        Me.rbSuma.TabIndex = 2
        Me.rbSuma.TabStop = True
        Me.rbSuma.Text = "Suma"
        Me.rbSuma.UseVisualStyleBackColor = True
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(145, 20)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 20)
        Me.txtValor2.TabIndex = 1
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(7, 20)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 20)
        Me.txtValor1.TabIndex = 0
        '
        'gpComplejos
        '
        Me.gpComplejos.Controls.Add(Me.rbRaiz)
        Me.gpComplejos.Controls.Add(Me.rbSeno)
        Me.gpComplejos.Controls.Add(Me.rbCoseno)
        Me.gpComplejos.Controls.Add(Me.rbPotencia)
        Me.gpComplejos.Controls.Add(Me.txtValor3)
        Me.gpComplejos.Enabled = False
        Me.gpComplejos.Location = New System.Drawing.Point(296, 142)
        Me.gpComplejos.Name = "gpComplejos"
        Me.gpComplejos.Size = New System.Drawing.Size(237, 118)
        Me.gpComplejos.TabIndex = 2
        Me.gpComplejos.TabStop = False
        Me.gpComplejos.Text = "Complejos"
        '
        'rbRaiz
        '
        Me.rbRaiz.AutoSize = True
        Me.rbRaiz.Location = New System.Drawing.Point(6, 86)
        Me.rbRaiz.Name = "rbRaiz"
        Me.rbRaiz.Size = New System.Drawing.Size(97, 17)
        Me.rbRaiz.TabIndex = 9
        Me.rbRaiz.TabStop = True
        Me.rbRaiz.Text = "Raíz Cuadrada"
        Me.rbRaiz.UseVisualStyleBackColor = True
        '
        'rbSeno
        '
        Me.rbSeno.AutoSize = True
        Me.rbSeno.Location = New System.Drawing.Point(156, 86)
        Me.rbSeno.Name = "rbSeno"
        Me.rbSeno.Size = New System.Drawing.Size(50, 17)
        Me.rbSeno.TabIndex = 8
        Me.rbSeno.TabStop = True
        Me.rbSeno.Text = "Seno"
        Me.rbSeno.UseVisualStyleBackColor = True
        '
        'rbCoseno
        '
        Me.rbCoseno.AutoSize = True
        Me.rbCoseno.Location = New System.Drawing.Point(156, 63)
        Me.rbCoseno.Name = "rbCoseno"
        Me.rbCoseno.Size = New System.Drawing.Size(61, 17)
        Me.rbCoseno.TabIndex = 7
        Me.rbCoseno.TabStop = True
        Me.rbCoseno.Text = "Coseno"
        Me.rbCoseno.UseVisualStyleBackColor = True
        '
        'rbPotencia
        '
        Me.rbPotencia.AutoSize = True
        Me.rbPotencia.Location = New System.Drawing.Point(6, 63)
        Me.rbPotencia.Name = "rbPotencia"
        Me.rbPotencia.Size = New System.Drawing.Size(127, 17)
        Me.rbPotencia.TabIndex = 6
        Me.rbPotencia.TabStop = True
        Me.rbPotencia.Text = "Potencia al Cuadrado"
        Me.rbPotencia.UseVisualStyleBackColor = True
        '
        'txtValor3
        '
        Me.txtValor3.Location = New System.Drawing.Point(90, 19)
        Me.txtValor3.Name = "txtValor3"
        Me.txtValor3.Size = New System.Drawing.Size(100, 20)
        Me.txtValor3.TabIndex = 6
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(57, 302)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 3
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(182, 302)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(311, 302)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 363)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.gpComplejos)
        Me.Controls.Add(Me.gpSimples)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gpSimples.ResumeLayout(False)
        Me.gpSimples.PerformLayout()
        Me.gpComplejos.ResumeLayout(False)
        Me.gpComplejos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbComplejas As RadioButton
    Friend WithEvents rbSimples As RadioButton
    Friend WithEvents gpSimples As GroupBox
    Friend WithEvents rbMulti As RadioButton
    Friend WithEvents rbResta As RadioButton
    Friend WithEvents rbDivision As RadioButton
    Friend WithEvents rbSuma As RadioButton
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents gpComplejos As GroupBox
    Friend WithEvents rbRaiz As RadioButton
    Friend WithEvents rbSeno As RadioButton
    Friend WithEvents rbCoseno As RadioButton
    Friend WithEvents rbPotencia As RadioButton
    Friend WithEvents txtValor3 As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
End Class
