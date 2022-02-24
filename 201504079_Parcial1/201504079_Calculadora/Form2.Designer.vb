<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtResultadoSimple = New System.Windows.Forms.TextBox()
        Me.txtResultadoComplejo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Resultado Operaciones Simples"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(414, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Resultado Operaciones Complejas"
        '
        'txtResultadoSimple
        '
        Me.txtResultadoSimple.Location = New System.Drawing.Point(154, 200)
        Me.txtResultadoSimple.Name = "txtResultadoSimple"
        Me.txtResultadoSimple.Size = New System.Drawing.Size(100, 20)
        Me.txtResultadoSimple.TabIndex = 2
        '
        'txtResultadoComplejo
        '
        Me.txtResultadoComplejo.Location = New System.Drawing.Point(447, 200)
        Me.txtResultadoComplejo.Name = "txtResultadoComplejo"
        Me.txtResultadoComplejo.Size = New System.Drawing.Size(100, 20)
        Me.txtResultadoComplejo.TabIndex = 3
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtResultadoComplejo)
        Me.Controls.Add(Me.txtResultadoSimple)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtResultadoSimple As TextBox
    Friend WithEvents txtResultadoComplejo As TextBox
End Class
