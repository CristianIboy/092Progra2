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
        Me.rbTablet = New System.Windows.Forms.RadioButton()
        Me.rbDrone = New System.Windows.Forms.RadioButton()
        Me.rbCelular = New System.Windows.Forms.RadioButton()
        Me.rbTelevisor = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblNombreEmpleado = New System.Windows.Forms.Label()
        Me.lblSueldo = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbTelevisor)
        Me.GroupBox1.Controls.Add(Me.rbCelular)
        Me.GroupBox1.Controls.Add(Me.rbDrone)
        Me.GroupBox1.Controls.Add(Me.rbTablet)
        Me.GroupBox1.Location = New System.Drawing.Point(445, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(110, 183)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Producto"
        '
        'rbTablet
        '
        Me.rbTablet.AutoSize = True
        Me.rbTablet.Location = New System.Drawing.Point(24, 44)
        Me.rbTablet.Name = "rbTablet"
        Me.rbTablet.Size = New System.Drawing.Size(55, 17)
        Me.rbTablet.TabIndex = 0
        Me.rbTablet.TabStop = True
        Me.rbTablet.Text = "Tablet"
        Me.rbTablet.UseVisualStyleBackColor = True
        '
        'rbDrone
        '
        Me.rbDrone.AutoSize = True
        Me.rbDrone.Location = New System.Drawing.Point(24, 78)
        Me.rbDrone.Name = "rbDrone"
        Me.rbDrone.Size = New System.Drawing.Size(54, 17)
        Me.rbDrone.TabIndex = 1
        Me.rbDrone.TabStop = True
        Me.rbDrone.Text = "Drone"
        Me.rbDrone.UseVisualStyleBackColor = True
        '
        'rbCelular
        '
        Me.rbCelular.AutoSize = True
        Me.rbCelular.Location = New System.Drawing.Point(24, 119)
        Me.rbCelular.Name = "rbCelular"
        Me.rbCelular.Size = New System.Drawing.Size(57, 17)
        Me.rbCelular.TabIndex = 2
        Me.rbCelular.TabStop = True
        Me.rbCelular.Text = "Celular"
        Me.rbCelular.UseVisualStyleBackColor = True
        '
        'rbTelevisor
        '
        Me.rbTelevisor.AutoSize = True
        Me.rbTelevisor.Location = New System.Drawing.Point(24, 158)
        Me.rbTelevisor.Name = "rbTelevisor"
        Me.rbTelevisor.Size = New System.Drawing.Size(68, 17)
        Me.rbTelevisor.TabIndex = 3
        Me.rbTelevisor.TabStop = True
        Me.rbTelevisor.Text = "Televisor"
        Me.rbTelevisor.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSueldo)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.lblSueldo)
        Me.GroupBox2.Controls.Add(Me.lblNombreEmpleado)
        Me.GroupBox2.Location = New System.Drawing.Point(38, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(391, 125)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'lblNombreEmpleado
        '
        Me.lblNombreEmpleado.AutoSize = True
        Me.lblNombreEmpleado.Location = New System.Drawing.Point(17, 33)
        Me.lblNombreEmpleado.Name = "lblNombreEmpleado"
        Me.lblNombreEmpleado.Size = New System.Drawing.Size(47, 13)
        Me.lblNombreEmpleado.TabIndex = 0
        Me.lblNombreEmpleado.Text = "Nombre:"
        '
        'lblSueldo
        '
        Me.lblSueldo.AutoSize = True
        Me.lblSueldo.Location = New System.Drawing.Point(17, 80)
        Me.lblSueldo.Name = "lblSueldo"
        Me.lblSueldo.Size = New System.Drawing.Size(60, 13)
        Me.lblSueldo.TabIndex = 1
        Me.lblSueldo.Text = "Sueldo: (Q)"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(85, 32)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(293, 20)
        Me.txtNombre.TabIndex = 2
        '
        'txtSueldo
        '
        Me.txtSueldo.Location = New System.Drawing.Point(83, 77)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(143, 20)
        Me.txtSueldo.TabIndex = 3
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(74, 269)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(288, 134)
        Me.ListBox1.TabIndex = 3
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(19, 34)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 4
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.btnLimpiar)
        Me.GroupBox3.Controls.Add(Me.btnCalcular)
        Me.GroupBox3.Location = New System.Drawing.Point(572, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(110, 142)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(19, 68)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(19, 106)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ListBox1)
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

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbTelevisor As RadioButton
    Friend WithEvents rbCelular As RadioButton
    Friend WithEvents rbDrone As RadioButton
    Friend WithEvents rbTablet As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSueldo As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblSueldo As Label
    Friend WithEvents lblNombreEmpleado As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents btnLimpiar As Button
End Class
