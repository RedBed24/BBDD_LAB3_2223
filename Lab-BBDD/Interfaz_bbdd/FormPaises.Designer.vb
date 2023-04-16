<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPaises
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
        Me.Paises_TextBox_NombrePais = New System.Windows.Forms.TextBox()
        Me.Paises_Label_Nombre = New System.Windows.Forms.Label()
        Me.Paises_Button_VerTodosPaises = New System.Windows.Forms.Button()
        Me.Paises_ListBox_Paises = New System.Windows.Forms.ListBox()
        Me.Paises_Button_Eliminar = New System.Windows.Forms.Button()
        Me.Paises_Button_Limpiar = New System.Windows.Forms.Button()
        Me.Paises_Button_Actualizar = New System.Windows.Forms.Button()
        Me.Paises_Button_Agregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo_Pai
        '
        Me.lblTitulo_Pai.AutoSize = True
        Me.lblTitulo_Pai.Font = New System.Drawing.Font("Britannic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo_Pai.Location = New System.Drawing.Point(319, 24)
        Me.lblTitulo_Pai.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo_Pai.Name = "lblTitulo_Pai"
        Me.lblTitulo_Pai.Size = New System.Drawing.Size(83, 26)
        Me.lblTitulo_Pai.TabIndex = 0
        Me.lblTitulo_Pai.Text = "PAISES"
        '
        'Paises_TextBox_NombrePais
        '
        Me.Paises_TextBox_NombrePais.Location = New System.Drawing.Point(43, 106)
        Me.Paises_TextBox_NombrePais.Name = "Paises_TextBox_NombrePais"
        Me.Paises_TextBox_NombrePais.Size = New System.Drawing.Size(256, 22)
        Me.Paises_TextBox_NombrePais.TabIndex = 32
        Me.Paises_TextBox_NombrePais.UseWaitCursor = True
        '
        'Paises_Label_Nombre
        '
        Me.Paises_Label_Nombre.AutoSize = True
        Me.Paises_Label_Nombre.Location = New System.Drawing.Point(57, 84)
        Me.Paises_Label_Nombre.Name = "Paises_Label_Nombre"
        Me.Paises_Label_Nombre.Size = New System.Drawing.Size(111, 16)
        Me.Paises_Label_Nombre.TabIndex = 31
        Me.Paises_Label_Nombre.Text = "Nombre del País:"
        Me.Paises_Label_Nombre.UseWaitCursor = True
        '
        'Paises_Button_VerTodosPaises
        '
        Me.Paises_Button_VerTodosPaises.BackColor = System.Drawing.Color.MistyRose
        Me.Paises_Button_VerTodosPaises.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Paises_Button_VerTodosPaises.Location = New System.Drawing.Point(456, 73)
        Me.Paises_Button_VerTodosPaises.Name = "Paises_Button_VerTodosPaises"
        Me.Paises_Button_VerTodosPaises.Size = New System.Drawing.Size(154, 28)
        Me.Paises_Button_VerTodosPaises.TabIndex = 30
        Me.Paises_Button_VerTodosPaises.Text = "Ver todos los Paises"
        Me.Paises_Button_VerTodosPaises.UseVisualStyleBackColor = False
        Me.Paises_Button_VerTodosPaises.UseWaitCursor = True
        '
        'Paises_ListBox_Paises
        '
        Me.Paises_ListBox_Paises.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Paises_ListBox_Paises.FormattingEnabled = True
        Me.Paises_ListBox_Paises.ItemHeight = 16
        Me.Paises_ListBox_Paises.Location = New System.Drawing.Point(435, 106)
        Me.Paises_ListBox_Paises.Name = "Paises_ListBox_Paises"
        Me.Paises_ListBox_Paises.Size = New System.Drawing.Size(267, 228)
        Me.Paises_ListBox_Paises.TabIndex = 29
        Me.Paises_ListBox_Paises.UseWaitCursor = True
        '
        'Paises_Button_Eliminar
        '
        Me.Paises_Button_Eliminar.Enabled = False
        Me.Paises_Button_Eliminar.Location = New System.Drawing.Point(227, 209)
        Me.Paises_Button_Eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.Paises_Button_Eliminar.Name = "Paises_Button_Eliminar"
        Me.Paises_Button_Eliminar.Size = New System.Drawing.Size(106, 35)
        Me.Paises_Button_Eliminar.TabIndex = 36
        Me.Paises_Button_Eliminar.Text = "Eliminar"
        Me.Paises_Button_Eliminar.UseVisualStyleBackColor = True
        '
        'Paises_Button_Limpiar
        '
        Me.Paises_Button_Limpiar.Location = New System.Drawing.Point(227, 263)
        Me.Paises_Button_Limpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.Paises_Button_Limpiar.Name = "Paises_Button_Limpiar"
        Me.Paises_Button_Limpiar.Size = New System.Drawing.Size(106, 35)
        Me.Paises_Button_Limpiar.TabIndex = 35
        Me.Paises_Button_Limpiar.Text = "Limpiar"
        Me.Paises_Button_Limpiar.UseVisualStyleBackColor = True
        '
        'Paises_Button_Actualizar
        '
        Me.Paises_Button_Actualizar.Enabled = False
        Me.Paises_Button_Actualizar.Location = New System.Drawing.Point(47, 263)
        Me.Paises_Button_Actualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.Paises_Button_Actualizar.Name = "Paises_Button_Actualizar"
        Me.Paises_Button_Actualizar.Size = New System.Drawing.Size(112, 35)
        Me.Paises_Button_Actualizar.TabIndex = 34
        Me.Paises_Button_Actualizar.Text = "Actualizar"
        Me.Paises_Button_Actualizar.UseVisualStyleBackColor = True
        '
        'Paises_Button_Agregar
        '
        Me.Paises_Button_Agregar.Location = New System.Drawing.Point(47, 209)
        Me.Paises_Button_Agregar.Margin = New System.Windows.Forms.Padding(2)
        Me.Paises_Button_Agregar.Name = "Paises_Button_Agregar"
        Me.Paises_Button_Agregar.Size = New System.Drawing.Size(112, 35)
        Me.Paises_Button_Agregar.TabIndex = 33
        Me.Paises_Button_Agregar.Text = "Agregar"
        Me.Paises_Button_Agregar.UseVisualStyleBackColor = True
        '
        'FormPaises
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 368)
        Me.Controls.Add(Me.Paises_Button_Eliminar)
        Me.Controls.Add(Me.Paises_Button_Limpiar)
        Me.Controls.Add(Me.Paises_Button_Actualizar)
        Me.Controls.Add(Me.Paises_Button_Agregar)
        Me.Controls.Add(Me.Paises_TextBox_NombrePais)
        Me.Controls.Add(Me.Paises_Label_Nombre)
        Me.Controls.Add(Me.Paises_Button_VerTodosPaises)
        Me.Controls.Add(Me.Paises_ListBox_Paises)
        Me.Controls.Add(Me.lblTitulo_Pai)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormPaises"
        Me.Text = "FormPais"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo_Pai As Label
    Friend WithEvents Paises_TextBox_NombrePais As TextBox
    Friend WithEvents Paises_Label_Nombre As Label
    Friend WithEvents Paises_Button_VerTodosPaises As Button
    Friend WithEvents Paises_ListBox_Paises As ListBox
    Friend WithEvents Paises_Button_Eliminar As Button
    Friend WithEvents Paises_Button_Limpiar As Button
    Friend WithEvents Paises_Button_Actualizar As Button
    Friend WithEvents Paises_Button_Agregar As Button
End Class
