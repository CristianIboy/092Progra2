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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.gpDatos = New System.Windows.Forms.GroupBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.gpRegion = New System.Windows.Forms.GroupBox()
        Me.rbOccidente = New System.Windows.Forms.RadioButton()
        Me.rbOriente = New System.Windows.Forms.RadioButton()
        Me.rbSur = New System.Windows.Forms.RadioButton()
        Me.rbNorte = New System.Windows.Forms.RadioButton()
        Me.gpMontos = New System.Windows.Forms.GroupBox()
        Me.lblRespuestaSueldo = New System.Windows.Forms.Label()
        Me.lblSueldo = New System.Windows.Forms.Label()
        Me.lblRespuestaAccidente = New System.Windows.Forms.Label()
        Me.lblRespuestaVehiculo = New System.Windows.Forms.Label()
        Me.lblAccidente = New System.Windows.Forms.Label()
        Me.lblVehiculo = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbAccidente = New System.Windows.Forms.RadioButton()
        Me.rbVehiculo = New System.Windows.Forms.RadioButton()
        Me.gpDatos.SuspendLayout()
        Me.gpRegion.SuspendLayout()
        Me.gpMontos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(26, 26)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(26, 63)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(54, 13)
        Me.lblMonto.TabIndex = 1
        Me.lblMonto.Text = "Monto (Q)"
        '
        'gpDatos
        '
        Me.gpDatos.Controls.Add(Me.txt2)
        Me.gpDatos.Controls.Add(Me.txt1)
        Me.gpDatos.Controls.Add(Me.lblNombre)
        Me.gpDatos.Controls.Add(Me.lblMonto)
        Me.gpDatos.Location = New System.Drawing.Point(51, 60)
        Me.gpDatos.Name = "gpDatos"
        Me.gpDatos.Size = New System.Drawing.Size(206, 99)
        Me.gpDatos.TabIndex = 3
        Me.gpDatos.TabStop = False
        Me.gpDatos.Text = "Datos"
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(86, 63)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 20)
        Me.txt2.TabIndex = 4
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(86, 26)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 20)
        Me.txt1.TabIndex = 3
        '
        'gpRegion
        '
        Me.gpRegion.Controls.Add(Me.rbOccidente)
        Me.gpRegion.Controls.Add(Me.rbOriente)
        Me.gpRegion.Controls.Add(Me.rbSur)
        Me.gpRegion.Controls.Add(Me.rbNorte)
        Me.gpRegion.Location = New System.Drawing.Point(275, 60)
        Me.gpRegion.Name = "gpRegion"
        Me.gpRegion.Size = New System.Drawing.Size(112, 125)
        Me.gpRegion.TabIndex = 8
        Me.gpRegion.TabStop = False
        Me.gpRegion.Text = "Región"
        '
        'rbOccidente
        '
        Me.rbOccidente.AutoSize = True
        Me.rbOccidente.Location = New System.Drawing.Point(6, 98)
        Me.rbOccidente.Name = "rbOccidente"
        Me.rbOccidente.Size = New System.Drawing.Size(77, 17)
        Me.rbOccidente.TabIndex = 12
        Me.rbOccidente.TabStop = True
        Me.rbOccidente.Text = "Occidente "
        Me.rbOccidente.UseVisualStyleBackColor = True
        '
        'rbOriente
        '
        Me.rbOriente.AutoSize = True
        Me.rbOriente.Location = New System.Drawing.Point(6, 75)
        Me.rbOriente.Name = "rbOriente"
        Me.rbOriente.Size = New System.Drawing.Size(62, 17)
        Me.rbOriente.TabIndex = 11
        Me.rbOriente.TabStop = True
        Me.rbOriente.Text = "Oriente "
        Me.rbOriente.UseVisualStyleBackColor = True
        '
        'rbSur
        '
        Me.rbSur.AutoSize = True
        Me.rbSur.Location = New System.Drawing.Point(6, 52)
        Me.rbSur.Name = "rbSur"
        Me.rbSur.Size = New System.Drawing.Size(41, 17)
        Me.rbSur.TabIndex = 10
        Me.rbSur.TabStop = True
        Me.rbSur.Text = "Sur"
        Me.rbSur.UseVisualStyleBackColor = True
        '
        'rbNorte
        '
        Me.rbNorte.AutoSize = True
        Me.rbNorte.Location = New System.Drawing.Point(6, 29)
        Me.rbNorte.Name = "rbNorte"
        Me.rbNorte.Size = New System.Drawing.Size(51, 17)
        Me.rbNorte.TabIndex = 9
        Me.rbNorte.TabStop = True
        Me.rbNorte.Text = "Norte"
        Me.rbNorte.UseVisualStyleBackColor = True
        '
        'gpMontos
        '
        Me.gpMontos.Controls.Add(Me.lblRespuestaSueldo)
        Me.gpMontos.Controls.Add(Me.lblSueldo)
        Me.gpMontos.Controls.Add(Me.lblRespuestaAccidente)
        Me.gpMontos.Controls.Add(Me.lblRespuestaVehiculo)
        Me.gpMontos.Controls.Add(Me.lblAccidente)
        Me.gpMontos.Controls.Add(Me.lblVehiculo)
        Me.gpMontos.Location = New System.Drawing.Point(349, 209)
        Me.gpMontos.Name = "gpMontos"
        Me.gpMontos.Size = New System.Drawing.Size(251, 206)
        Me.gpMontos.TabIndex = 9
        Me.gpMontos.TabStop = False
        Me.gpMontos.Text = "Resultados"
        '
        'lblRespuestaSueldo
        '
        Me.lblRespuestaSueldo.AutoSize = True
        Me.lblRespuestaSueldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuestaSueldo.ForeColor = System.Drawing.Color.Red
        Me.lblRespuestaSueldo.Location = New System.Drawing.Point(165, 101)
        Me.lblRespuestaSueldo.Name = "lblRespuestaSueldo"
        Me.lblRespuestaSueldo.Size = New System.Drawing.Size(15, 16)
        Me.lblRespuestaSueldo.TabIndex = 5
        Me.lblRespuestaSueldo.Text = "0"
        '
        'lblSueldo
        '
        Me.lblSueldo.AutoSize = True
        Me.lblSueldo.Location = New System.Drawing.Point(18, 101)
        Me.lblSueldo.Name = "lblSueldo"
        Me.lblSueldo.Size = New System.Drawing.Size(65, 13)
        Me.lblSueldo.TabIndex = 4
        Me.lblSueldo.Text = "Sueldo Final"
        '
        'lblRespuestaAccidente
        '
        Me.lblRespuestaAccidente.AutoSize = True
        Me.lblRespuestaAccidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuestaAccidente.ForeColor = System.Drawing.Color.Red
        Me.lblRespuestaAccidente.Location = New System.Drawing.Point(165, 64)
        Me.lblRespuestaAccidente.Name = "lblRespuestaAccidente"
        Me.lblRespuestaAccidente.Size = New System.Drawing.Size(15, 16)
        Me.lblRespuestaAccidente.TabIndex = 3
        Me.lblRespuestaAccidente.Text = "0"
        '
        'lblRespuestaVehiculo
        '
        Me.lblRespuestaVehiculo.AutoSize = True
        Me.lblRespuestaVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuestaVehiculo.ForeColor = System.Drawing.Color.Red
        Me.lblRespuestaVehiculo.Location = New System.Drawing.Point(165, 29)
        Me.lblRespuestaVehiculo.Name = "lblRespuestaVehiculo"
        Me.lblRespuestaVehiculo.Size = New System.Drawing.Size(15, 16)
        Me.lblRespuestaVehiculo.TabIndex = 2
        Me.lblRespuestaVehiculo.Text = "0"
        '
        'lblAccidente
        '
        Me.lblAccidente.AutoSize = True
        Me.lblAccidente.Location = New System.Drawing.Point(18, 64)
        Me.lblAccidente.Name = "lblAccidente"
        Me.lblAccidente.Size = New System.Drawing.Size(106, 13)
        Me.lblAccidente.TabIndex = 1
        Me.lblAccidente.Text = "Seguro de accidente"
        '
        'lblVehiculo
        '
        Me.lblVehiculo.AutoSize = True
        Me.lblVehiculo.Location = New System.Drawing.Point(18, 29)
        Me.lblVehiculo.Name = "lblVehiculo"
        Me.lblVehiculo.Size = New System.Drawing.Size(101, 13)
        Me.lblVehiculo.TabIndex = 0
        Me.lblVehiculo.Text = "Seguro de vehículo"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(51, 220)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 10
        Me.btnCalcular.Text = "&Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(162, 220)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 11
        Me.btnLimpiar.Text = "&Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(56, 310)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbAccidente)
        Me.GroupBox1.Controls.Add(Me.rbVehiculo)
        Me.GroupBox1.Location = New System.Drawing.Point(417, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(119, 100)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seguros"
        '
        'rbAccidente
        '
        Me.rbAccidente.AutoSize = True
        Me.rbAccidente.Location = New System.Drawing.Point(16, 52)
        Me.rbAccidente.Name = "rbAccidente"
        Me.rbAccidente.Size = New System.Drawing.Size(73, 17)
        Me.rbAccidente.TabIndex = 1
        Me.rbAccidente.TabStop = True
        Me.rbAccidente.Text = "Accidente"
        Me.rbAccidente.UseVisualStyleBackColor = True
        '
        'rbVehiculo
        '
        Me.rbVehiculo.AutoSize = True
        Me.rbVehiculo.Location = New System.Drawing.Point(16, 20)
        Me.rbVehiculo.Name = "rbVehiculo"
        Me.rbVehiculo.Size = New System.Drawing.Size(68, 17)
        Me.rbVehiculo.TabIndex = 0
        Me.rbVehiculo.TabStop = True
        Me.rbVehiculo.Text = "Vehículo"
        Me.rbVehiculo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.gpMontos)
        Me.Controls.Add(Me.gpRegion)
        Me.Controls.Add(Me.gpDatos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gpDatos.ResumeLayout(False)
        Me.gpDatos.PerformLayout()
        Me.gpRegion.ResumeLayout(False)
        Me.gpRegion.PerformLayout()
        Me.gpMontos.ResumeLayout(False)
        Me.gpMontos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents lblMonto As Label
    Friend WithEvents gpDatos As GroupBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt1 As TextBox
    Friend WithEvents gpRegion As GroupBox
    Friend WithEvents rbOccidente As RadioButton
    Friend WithEvents rbOriente As RadioButton
    Friend WithEvents rbSur As RadioButton
    Friend WithEvents rbNorte As RadioButton
    Friend WithEvents gpMontos As GroupBox
    Friend WithEvents lblRespuestaAccidente As Label
    Friend WithEvents lblRespuestaVehiculo As Label
    Friend WithEvents lblAccidente As Label
    Friend WithEvents lblVehiculo As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbAccidente As RadioButton
    Friend WithEvents rbVehiculo As RadioButton
    Friend WithEvents lblRespuestaSueldo As Label
    Friend WithEvents lblSueldo As Label
End Class
