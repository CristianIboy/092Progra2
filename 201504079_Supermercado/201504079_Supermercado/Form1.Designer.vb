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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumPacks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrePack = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidadInventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDeseada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sobrante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngresosPack = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngresoSobrante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumPacks, Me.NombrePack, Me.ProductoD, Me.cantidadInventario, Me.CantidadDeseada, Me.Sobrante, Me.IngresosPack, Me.IngresoSobrante})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 179)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(845, 212)
        Me.DataGridView1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.cmbProducto)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 90)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'cmbProducto
        '
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Items.AddRange(New Object() {"Jugos", "Frituras", "Galletas", "Beterías"})
        Me.cmbProducto.Location = New System.Drawing.Point(25, 45)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(121, 21)
        Me.cmbProducto.TabIndex = 0
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(413, 51)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 4
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(413, 102)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(536, 65)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(177, 46)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(121, 20)
        Me.txtCantidad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ingrese Cantidad"
        '
        'NumPacks
        '
        Me.NumPacks.HeaderText = "# de Packs"
        Me.NumPacks.Name = "NumPacks"
        '
        'NombrePack
        '
        Me.NombrePack.HeaderText = "Nombre del Pack"
        Me.NombrePack.Name = "NombrePack"
        '
        'ProductoD
        '
        Me.ProductoD.HeaderText = "Producto Deseado"
        Me.ProductoD.Name = "ProductoD"
        '
        'cantidadInventario
        '
        Me.cantidadInventario.HeaderText = "Cantidad en Inventario"
        Me.cantidadInventario.Name = "cantidadInventario"
        '
        'CantidadDeseada
        '
        Me.CantidadDeseada.HeaderText = "Cantidad Deseada"
        Me.CantidadDeseada.Name = "CantidadDeseada"
        '
        'Sobrante
        '
        Me.Sobrante.HeaderText = "Sobrante"
        Me.Sobrante.Name = "Sobrante"
        '
        'IngresosPack
        '
        Me.IngresosPack.HeaderText = "Ingresos Packs"
        Me.IngresosPack.Name = "IngresosPack"
        '
        'IngresoSobrante
        '
        Me.IngresoSobrante.HeaderText = "Ingresos Sobrante"
        Me.IngresoSobrante.Name = "IngresoSobrante"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbProducto As ComboBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents NumPacks As DataGridViewTextBoxColumn
    Friend WithEvents NombrePack As DataGridViewTextBoxColumn
    Friend WithEvents ProductoD As DataGridViewTextBoxColumn
    Friend WithEvents cantidadInventario As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDeseada As DataGridViewTextBoxColumn
    Friend WithEvents Sobrante As DataGridViewTextBoxColumn
    Friend WithEvents IngresosPack As DataGridViewTextBoxColumn
    Friend WithEvents IngresoSobrante As DataGridViewTextBoxColumn
End Class
