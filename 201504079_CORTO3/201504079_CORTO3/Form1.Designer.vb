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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.cmbPago = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CálculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiaVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenúToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CálculoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LBLTipoPago = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LBHabitacion = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LBPagoTotal = New System.Windows.Forms.ListBox()
        Me.LBImpuesto = New System.Windows.Forms.ListBox()
        Me.LBPagoParcial = New System.Windows.Forms.ListBox()
        Me.LBDias = New System.Windows.Forms.ListBox()
        Me.LBNIT = New System.Windows.Forms.ListBox()
        Me.LBNombre = New System.Windows.Forms.ListBox()
        Me.LBNumero = New System.Windows.Forms.ListBox()
        Me.cmbHabitación = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Días de hospedaje"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Impuesto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(197, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tipo de habitación "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(197, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tipo de pago"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(76, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(76, 85)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(310, 41)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(76, 132)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 9
        '
        'cmbPago
        '
        Me.cmbPago.FormattingEnabled = True
        Me.cmbPago.Items.AddRange(New Object() {"Efectivo", "Tarjeta de crédito/débito", "Transferencia ", "Depósito"})
        Me.cmbPago.Location = New System.Drawing.Point(309, 127)
        Me.cmbPago.Name = "cmbPago"
        Me.cmbPago.Size = New System.Drawing.Size(121, 21)
        Me.cmbPago.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbHabitación)
        Me.GroupBox1.Controls.Add(Me.cmbPago)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 173)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CálculoToolStripMenuItem, Me.MostrarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.LimpiaVectoresToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(158, 114)
        '
        'CálculoToolStripMenuItem
        '
        Me.CálculoToolStripMenuItem.Name = "CálculoToolStripMenuItem"
        Me.CálculoToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CálculoToolStripMenuItem.Text = "Cálculo"
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'LimpiaVectoresToolStripMenuItem
        '
        Me.LimpiaVectoresToolStripMenuItem.Name = "LimpiaVectoresToolStripMenuItem"
        Me.LimpiaVectoresToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.LimpiaVectoresToolStripMenuItem.Text = "Limpia Vectores"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(834, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenúToolStripMenuItem
        '
        Me.MenúToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CálculoToolStripMenuItem1, Me.MostrarToolStripMenuItem1, Me.ConsultarToolStripMenuItem1, Me.EliminarToolStripMenuItem1, Me.LimpiarVectoresToolStripMenuItem})
        Me.MenúToolStripMenuItem.Name = "MenúToolStripMenuItem"
        Me.MenúToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenúToolStripMenuItem.Text = "Menú"
        '
        'CálculoToolStripMenuItem1
        '
        Me.CálculoToolStripMenuItem1.Name = "CálculoToolStripMenuItem1"
        Me.CálculoToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.CálculoToolStripMenuItem1.Text = "Cálculo"
        '
        'MostrarToolStripMenuItem1
        '
        Me.MostrarToolStripMenuItem1.Name = "MostrarToolStripMenuItem1"
        Me.MostrarToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.MostrarToolStripMenuItem1.Text = "Mostrar"
        '
        'ConsultarToolStripMenuItem1
        '
        Me.ConsultarToolStripMenuItem1.Name = "ConsultarToolStripMenuItem1"
        Me.ConsultarToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ConsultarToolStripMenuItem1.Text = "Consultar"
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.EliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Vectores"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.LBLTipoPago)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.LBHabitacion)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.LBPagoTotal)
        Me.GroupBox4.Controls.Add(Me.LBImpuesto)
        Me.GroupBox4.Controls.Add(Me.LBPagoParcial)
        Me.GroupBox4.Controls.Add(Me.LBDias)
        Me.GroupBox4.Controls.Add(Me.LBNIT)
        Me.GroupBox4.Controls.Add(Me.LBNombre)
        Me.GroupBox4.Controls.Add(Me.LBNumero)
        Me.GroupBox4.Location = New System.Drawing.Point(40, 215)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(782, 227)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(593, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 16)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Tipo de Pago"
        '
        'LBLTipoPago
        '
        Me.LBLTipoPago.FormattingEnabled = True
        Me.LBLTipoPago.Location = New System.Drawing.Point(596, 45)
        Me.LBLTipoPago.Name = "LBLTipoPago"
        Me.LBLTipoPago.Size = New System.Drawing.Size(78, 173)
        Me.LBLTipoPago.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(510, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 16)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Habitación"
        '
        'LBHabitacion
        '
        Me.LBHabitacion.FormattingEnabled = True
        Me.LBHabitacion.Location = New System.Drawing.Point(510, 45)
        Me.LBHabitacion.Name = "LBHabitacion"
        Me.LBHabitacion.Size = New System.Drawing.Size(78, 173)
        Me.LBHabitacion.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(702, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 16)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Total"
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(240, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Días"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(155, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "NIT"
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
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 16)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "# Trans."
        '
        'LBPagoTotal
        '
        Me.LBPagoTotal.FormattingEnabled = True
        Me.LBPagoTotal.Location = New System.Drawing.Point(686, 45)
        Me.LBPagoTotal.Name = "LBPagoTotal"
        Me.LBPagoTotal.Size = New System.Drawing.Size(78, 173)
        Me.LBPagoTotal.TabIndex = 8
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
        'LBDias
        '
        Me.LBDias.FormattingEnabled = True
        Me.LBDias.Location = New System.Drawing.Point(237, 45)
        Me.LBDias.Name = "LBDias"
        Me.LBDias.Size = New System.Drawing.Size(78, 173)
        Me.LBDias.TabIndex = 5
        '
        'LBNIT
        '
        Me.LBNIT.FormattingEnabled = True
        Me.LBNIT.Location = New System.Drawing.Point(152, 45)
        Me.LBNIT.Name = "LBNIT"
        Me.LBNIT.Size = New System.Drawing.Size(78, 173)
        Me.LBNIT.TabIndex = 4
        '
        'LBNombre
        '
        Me.LBNombre.FormattingEnabled = True
        Me.LBNombre.Location = New System.Drawing.Point(68, 45)
        Me.LBNombre.Name = "LBNombre"
        Me.LBNombre.Size = New System.Drawing.Size(78, 173)
        Me.LBNombre.TabIndex = 3
        '
        'LBNumero
        '
        Me.LBNumero.FormattingEnabled = True
        Me.LBNumero.Location = New System.Drawing.Point(11, 45)
        Me.LBNumero.Name = "LBNumero"
        Me.LBNumero.Size = New System.Drawing.Size(49, 173)
        Me.LBNumero.TabIndex = 2
        '
        'cmbHabitación
        '
        Me.cmbHabitación.FormattingEnabled = True
        Me.cmbHabitación.Items.AddRange(New Object() {"Sencilla", "Doble ", "Cabaña"})
        Me.cmbHabitación.Location = New System.Drawing.Point(310, 82)
        Me.cmbHabitación.Name = "cmbHabitación"
        Me.cmbHabitación.Size = New System.Drawing.Size(121, 21)
        Me.cmbHabitación.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 454)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents cmbPago As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CálculoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiaVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CálculoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents LBLTipoPago As ListBox
    Friend WithEvents Label13 As Label
    Friend WithEvents LBHabitacion As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LBPagoTotal As ListBox
    Friend WithEvents LBImpuesto As ListBox
    Friend WithEvents LBPagoParcial As ListBox
    Friend WithEvents LBDias As ListBox
    Friend WithEvents LBNIT As ListBox
    Friend WithEvents LBNombre As ListBox
    Friend WithEvents LBNumero As ListBox
    Friend WithEvents cmbHabitación As ComboBox
End Class
