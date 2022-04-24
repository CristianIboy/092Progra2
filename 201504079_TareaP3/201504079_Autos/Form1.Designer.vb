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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenúToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtKmInicial = New System.Windows.Forms.TextBox()
        Me.txtKmFinal = New System.Windows.Forms.TextBox()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTipoCarro = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TipoAuto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumPlaca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CobroBase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KmInicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KmFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(690, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenúToolStripMenuItem
        '
        Me.MenúToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.MostrarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenúToolStripMenuItem.Name = "MenúToolStripMenuItem"
        Me.MenúToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenúToolStripMenuItem.Text = "Menú"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CalcularToolStripMenuItem.Text = "Calcular"
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar vectores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(168, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kilometraje Inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kilometraje Final"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbTipoCarro)
        Me.GroupBox1.Controls.Add(Me.txtPlaca)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtKmFinal)
        Me.GroupBox1.Controls.Add(Me.txtKmInicial)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 104)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'txtKmInicial
        '
        Me.txtKmInicial.Location = New System.Drawing.Point(272, 49)
        Me.txtKmInicial.Name = "txtKmInicial"
        Me.txtKmInicial.Size = New System.Drawing.Size(100, 20)
        Me.txtKmInicial.TabIndex = 3
        '
        'txtKmFinal
        '
        Me.txtKmFinal.Location = New System.Drawing.Point(272, 75)
        Me.txtKmFinal.Name = "txtKmFinal"
        Me.txtKmFinal.Size = New System.Drawing.Size(100, 20)
        Me.txtKmFinal.TabIndex = 4
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(272, 19)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(100, 20)
        Me.txtPlaca.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(168, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "# de placa"
        '
        'cmbTipoCarro
        '
        Me.cmbTipoCarro.FormattingEnabled = True
        Me.cmbTipoCarro.Items.AddRange(New Object() {"Tipo 1", "Tipo 2", "Tipo 3", "Tipo 4"})
        Me.cmbTipoCarro.Location = New System.Drawing.Point(16, 46)
        Me.cmbTipoCarro.Name = "cmbTipoCarro"
        Me.cmbTipoCarro.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoCarro.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tipo de carro"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TipoAuto, Me.NumPlaca, Me.CobroBase, Me.KmInicial, Me.KmFinal, Me.PagoFinal})
        Me.DataGridView1.Location = New System.Drawing.Point(21, 170)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(654, 252)
        Me.DataGridView1.TabIndex = 4
        '
        'TipoAuto
        '
        Me.TipoAuto.HeaderText = "Tipo de Auto"
        Me.TipoAuto.Name = "TipoAuto"
        '
        'NumPlaca
        '
        Me.NumPlaca.HeaderText = "# de placa"
        Me.NumPlaca.Name = "NumPlaca"
        '
        'CobroBase
        '
        Me.CobroBase.HeaderText = "Cobro Base"
        Me.CobroBase.Name = "CobroBase"
        '
        'KmInicial
        '
        Me.KmInicial.HeaderText = "Km Inicial"
        Me.KmInicial.Name = "KmInicial"
        '
        'KmFinal
        '
        Me.KmFinal.HeaderText = "Km Final"
        Me.KmFinal.Name = "KmFinal"
        '
        'PagoFinal
        '
        Me.PagoFinal.HeaderText = "Pago Final"
        Me.PagoFinal.Name = "PagoFinal"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbTipoCarro As ComboBox
    Friend WithEvents txtPlaca As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKmFinal As TextBox
    Friend WithEvents txtKmInicial As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TipoAuto As DataGridViewTextBoxColumn
    Friend WithEvents NumPlaca As DataGridViewTextBoxColumn
    Friend WithEvents CobroBase As DataGridViewTextBoxColumn
    Friend WithEvents KmInicial As DataGridViewTextBoxColumn
    Friend WithEvents KmFinal As DataGridViewTextBoxColumn
    Friend WithEvents PagoFinal As DataGridViewTextBoxColumn
End Class
