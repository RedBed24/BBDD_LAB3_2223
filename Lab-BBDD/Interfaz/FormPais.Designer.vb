<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPais
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
        Me.lblTitulo_Pai = New System.Windows.Forms.Label()
        Me.Btn_Eliminar_Pai = New System.Windows.Forms.Button()
        Me.Btn_Limpiar_Pai = New System.Windows.Forms.Button()
        Me.Btn_Modificar_Pai = New System.Windows.Forms.Button()
        Me.Btn_Add_Pai = New System.Windows.Forms.Button()
        Me.TextBox_Nombre_Pai = New System.Windows.Forms.TextBox()
        Me.TextBox_ID_Pai = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBox_Pai = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblTitulo_Pai
        '
        Me.lblTitulo_Pai.AutoSize = True
        Me.lblTitulo_Pai.Font = New System.Drawing.Font("Roboto Condensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo_Pai.Location = New System.Drawing.Point(414, 47)
        Me.lblTitulo_Pai.Name = "lblTitulo_Pai"
        Me.lblTitulo_Pai.Size = New System.Drawing.Size(98, 34)
        Me.lblTitulo_Pai.TabIndex = 0
        Me.lblTitulo_Pai.Text = "PAISES"
        '
        'Btn_Eliminar_Pai
        '
        Me.Btn_Eliminar_Pai.Enabled = False
        Me.Btn_Eliminar_Pai.Location = New System.Drawing.Point(368, 309)
        Me.Btn_Eliminar_Pai.Name = "Btn_Eliminar_Pai"
        Me.Btn_Eliminar_Pai.Size = New System.Drawing.Size(133, 54)
        Me.Btn_Eliminar_Pai.TabIndex = 28
        Me.Btn_Eliminar_Pai.Text = "Eliminar"
        Me.Btn_Eliminar_Pai.UseVisualStyleBackColor = True
        '
        'Btn_Limpiar_Pai
        '
        Me.Btn_Limpiar_Pai.Location = New System.Drawing.Point(368, 392)
        Me.Btn_Limpiar_Pai.Name = "Btn_Limpiar_Pai"
        Me.Btn_Limpiar_Pai.Size = New System.Drawing.Size(133, 54)
        Me.Btn_Limpiar_Pai.TabIndex = 27
        Me.Btn_Limpiar_Pai.Text = "Limpiar"
        Me.Btn_Limpiar_Pai.UseVisualStyleBackColor = True
        '
        'Btn_Modificar_Pai
        '
        Me.Btn_Modificar_Pai.Enabled = False
        Me.Btn_Modificar_Pai.Location = New System.Drawing.Point(143, 392)
        Me.Btn_Modificar_Pai.Name = "Btn_Modificar_Pai"
        Me.Btn_Modificar_Pai.Size = New System.Drawing.Size(140, 54)
        Me.Btn_Modificar_Pai.TabIndex = 26
        Me.Btn_Modificar_Pai.Text = "Modificar"
        Me.Btn_Modificar_Pai.UseVisualStyleBackColor = True
        '
        'Btn_Add_Pai
        '
        Me.Btn_Add_Pai.Location = New System.Drawing.Point(143, 309)
        Me.Btn_Add_Pai.Name = "Btn_Add_Pai"
        Me.Btn_Add_Pai.Size = New System.Drawing.Size(140, 54)
        Me.Btn_Add_Pai.TabIndex = 25
        Me.Btn_Add_Pai.Text = "Añadir"
        Me.Btn_Add_Pai.UseVisualStyleBackColor = True
        '
        'TextBox_Nombre_Pai
        '
        Me.TextBox_Nombre_Pai.Location = New System.Drawing.Point(261, 203)
        Me.TextBox_Nombre_Pai.Name = "TextBox_Nombre_Pai"
        Me.TextBox_Nombre_Pai.Size = New System.Drawing.Size(251, 31)
        Me.TextBox_Nombre_Pai.TabIndex = 24
        '
        'TextBox_ID_Pai
        '
        Me.TextBox_ID_Pai.Enabled = False
        Me.TextBox_ID_Pai.Location = New System.Drawing.Point(261, 152)
        Me.TextBox_ID_Pai.Name = "TextBox_ID_Pai"
        Me.TextBox_ID_Pai.Size = New System.Drawing.Size(251, 31)
        Me.TextBox_ID_Pai.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(130, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 25)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(130, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 25)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Nombre"
        '
        'ListBox_Pai
        '
        Me.ListBox_Pai.FormattingEnabled = True
        Me.ListBox_Pai.ItemHeight = 25
        Me.ListBox_Pai.Location = New System.Drawing.Point(589, 152)
        Me.ListBox_Pai.Name = "ListBox_Pai"
        Me.ListBox_Pai.Size = New System.Drawing.Size(225, 254)
        Me.ListBox_Pai.TabIndex = 20
        '
        'FormPais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 550)
        Me.Controls.Add(Me.Btn_Eliminar_Pai)
        Me.Controls.Add(Me.Btn_Limpiar_Pai)
        Me.Controls.Add(Me.Btn_Modificar_Pai)
        Me.Controls.Add(Me.Btn_Add_Pai)
        Me.Controls.Add(Me.TextBox_Nombre_Pai)
        Me.Controls.Add(Me.TextBox_ID_Pai)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBox_Pai)
        Me.Controls.Add(Me.lblTitulo_Pai)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPais"
        Me.Text = "FormPais"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo_Pai As Label
    Friend WithEvents Btn_Eliminar_Pai As Button
    Friend WithEvents Btn_Limpiar_Pai As Button
    Friend WithEvents Btn_Modificar_Pai As Button
    Friend WithEvents Btn_Add_Pai As Button
    Friend WithEvents TextBox_Nombre_Pai As TextBox
    Friend WithEvents TextBox_ID_Pai As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox_Pai As ListBox
End Class
