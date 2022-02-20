<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblPrecioVenta = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPrecioCosto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrecioVenta
        '
        Me.lblPrecioVenta.AutoSize = True
        Me.lblPrecioVenta.ForeColor = System.Drawing.Color.Red
        Me.lblPrecioVenta.Location = New System.Drawing.Point(201, 122)
        Me.lblPrecioVenta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecioVenta.Name = "lblPrecioVenta"
        Me.lblPrecioVenta.Size = New System.Drawing.Size(13, 13)
        Me.lblPrecioVenta.TabIndex = 3
        Me.lblPrecioVenta.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 122)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio Venta (Q)"
        '
        'lblPrecioCosto
        '
        Me.lblPrecioCosto.AutoSize = True
        Me.lblPrecioCosto.ForeColor = System.Drawing.Color.Red
        Me.lblPrecioCosto.Location = New System.Drawing.Point(201, 76)
        Me.lblPrecioCosto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecioCosto.Name = "lblPrecioCosto"
        Me.lblPrecioCosto.Size = New System.Drawing.Size(13, 13)
        Me.lblPrecioCosto.TabIndex = 1
        Me.lblPrecioCosto.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Precio Costo (Q)"
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(121, 183)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 3
        Me.btnRegresar.Text = "&Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 238)
        Me.Controls.Add(Me.lblPrecioVenta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.lblPrecioCosto)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrecioVenta As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPrecioCosto As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegresar As Button
End Class
