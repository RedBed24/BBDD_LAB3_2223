<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSitios
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
        Me.lblTitulo_Sit = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitulo_Sit
        '
        Me.lblTitulo_Sit.AutoSize = True
        Me.lblTitulo_Sit.Font = New System.Drawing.Font("Roboto Condensed", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo_Sit.Location = New System.Drawing.Point(395, 65)
        Me.lblTitulo_Sit.Name = "lblTitulo_Sit"
        Me.lblTitulo_Sit.Size = New System.Drawing.Size(91, 38)
        Me.lblTitulo_Sit.TabIndex = 1
        Me.lblTitulo_Sit.Text = "Sitios"
        '
        'FormSitios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 550)
        Me.Controls.Add(Me.lblTitulo_Sit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormSitios"
        Me.Text = "FormSitios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo_Sit As Label
End Class
