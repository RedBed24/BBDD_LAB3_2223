<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSitios
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
        Me.lblTitulo_Sit = New System.Windows.Forms.Label()
        Me.Sitios_Label_Tipo = New System.Windows.Forms.Label()
        Me.Sitios_ComboBox_TipoSitio = New System.Windows.Forms.ComboBox()
        Me.Sitios_ComboBox_PaisSitio = New System.Windows.Forms.ComboBox()
        Me.Sitios_ListBox_Sitios = New System.Windows.Forms.ListBox()
        Me.Sitios_Label_PaisSitio = New System.Windows.Forms.Label()
        Me.Sitios_Label_NombreSitio = New System.Windows.Forms.Label()
        Me.Sitios_TextBox_NombreSitio = New System.Windows.Forms.TextBox()
        Me.Sitios_Button_VerTodosSitios = New System.Windows.Forms.Button()
        Me.Sitios_Button_Eliminar = New System.Windows.Forms.Button()
        Me.Sitios_Button_Limpiar = New System.Windows.Forms.Button()
        Me.Sitios_Button_Actualizar = New System.Windows.Forms.Button()
        Me.Sitios_Button_Agregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo_Sit
        '
        Me.lblTitulo_Sit.AutoSize = True
        Me.lblTitulo_Sit.Font = New System.Drawing.Font("Britannic Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo_Sit.Location = New System.Drawing.Point(309, 18)
        Me.lblTitulo_Sit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo_Sit.Name = "lblTitulo_Sit"
        Me.lblTitulo_Sit.Size = New System.Drawing.Size(82, 31)
        Me.lblTitulo_Sit.TabIndex = 1
        Me.lblTitulo_Sit.Text = "Sitios"
        '
        'Sitios_Label_Tipo
        '
        Me.Sitios_Label_Tipo.AutoSize = True
        Me.Sitios_Label_Tipo.Location = New System.Drawing.Point(373, 137)
        Me.Sitios_Label_Tipo.Name = "Sitios_Label_Tipo"
        Me.Sitios_Label_Tipo.Size = New System.Drawing.Size(87, 16)
        Me.Sitios_Label_Tipo.TabIndex = 23
        Me.Sitios_Label_Tipo.Text = "Tipo del sitio:"
        Me.Sitios_Label_Tipo.UseWaitCursor = True
        '
        'Sitios_ComboBox_TipoSitio
        '
        Me.Sitios_ComboBox_TipoSitio.FormattingEnabled = True
        Me.Sitios_ComboBox_TipoSitio.Items.AddRange(New Object() {"sala", "pabellón", "estadio", "festival"})
        Me.Sitios_ComboBox_TipoSitio.Location = New System.Drawing.Point(365, 156)
        Me.Sitios_ComboBox_TipoSitio.Name = "Sitios_ComboBox_TipoSitio"
        Me.Sitios_ComboBox_TipoSitio.Size = New System.Drawing.Size(256, 24)
        Me.Sitios_ComboBox_TipoSitio.TabIndex = 22
        Me.Sitios_ComboBox_TipoSitio.UseWaitCursor = True
        '
        'Sitios_ComboBox_PaisSitio
        '
        Me.Sitios_ComboBox_PaisSitio.FormattingEnabled = True
        Me.Sitios_ComboBox_PaisSitio.Location = New System.Drawing.Point(365, 210)
        Me.Sitios_ComboBox_PaisSitio.Name = "Sitios_ComboBox_PaisSitio"
        Me.Sitios_ComboBox_PaisSitio.Size = New System.Drawing.Size(256, 24)
        Me.Sitios_ComboBox_PaisSitio.TabIndex = 21
        Me.Sitios_ComboBox_PaisSitio.UseWaitCursor = True
        '
        'Sitios_ListBox_Sitios
        '
        Me.Sitios_ListBox_Sitios.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Sitios_ListBox_Sitios.FormattingEnabled = True
        Me.Sitios_ListBox_Sitios.ItemHeight = 16
        Me.Sitios_ListBox_Sitios.Location = New System.Drawing.Point(31, 112)
        Me.Sitios_ListBox_Sitios.Name = "Sitios_ListBox_Sitios"
        Me.Sitios_ListBox_Sitios.Size = New System.Drawing.Size(267, 228)
        Me.Sitios_ListBox_Sitios.TabIndex = 20
        Me.Sitios_ListBox_Sitios.UseWaitCursor = True
        '
        'Sitios_Label_PaisSitio
        '
        Me.Sitios_Label_PaisSitio.AutoSize = True
        Me.Sitios_Label_PaisSitio.Location = New System.Drawing.Point(373, 191)
        Me.Sitios_Label_PaisSitio.Name = "Sitios_Label_PaisSitio"
        Me.Sitios_Label_PaisSitio.Size = New System.Drawing.Size(86, 16)
        Me.Sitios_Label_PaisSitio.TabIndex = 19
        Me.Sitios_Label_PaisSitio.Text = "País del sitio:"
        Me.Sitios_Label_PaisSitio.UseWaitCursor = True
        '
        'Sitios_Label_NombreSitio
        '
        Me.Sitios_Label_NombreSitio.AutoSize = True
        Me.Sitios_Label_NombreSitio.Location = New System.Drawing.Point(373, 87)
        Me.Sitios_Label_NombreSitio.Name = "Sitios_Label_NombreSitio"
        Me.Sitios_Label_NombreSitio.Size = New System.Drawing.Size(108, 16)
        Me.Sitios_Label_NombreSitio.TabIndex = 18
        Me.Sitios_Label_NombreSitio.Text = "Nombre del sitio:"
        Me.Sitios_Label_NombreSitio.UseWaitCursor = True
        '
        'Sitios_TextBox_NombreSitio
        '
        Me.Sitios_TextBox_NombreSitio.Location = New System.Drawing.Point(365, 106)
        Me.Sitios_TextBox_NombreSitio.Name = "Sitios_TextBox_NombreSitio"
        Me.Sitios_TextBox_NombreSitio.Size = New System.Drawing.Size(256, 22)
        Me.Sitios_TextBox_NombreSitio.TabIndex = 17
        Me.Sitios_TextBox_NombreSitio.UseWaitCursor = True
        '
        'Sitios_Button_VerTodosSitios
        '
        Me.Sitios_Button_VerTodosSitios.BackColor = System.Drawing.Color.MistyRose
        Me.Sitios_Button_VerTodosSitios.Location = New System.Drawing.Point(31, 72)
        Me.Sitios_Button_VerTodosSitios.Name = "Sitios_Button_VerTodosSitios"
        Me.Sitios_Button_VerTodosSitios.Size = New System.Drawing.Size(154, 28)
        Me.Sitios_Button_VerTodosSitios.TabIndex = 16
        Me.Sitios_Button_VerTodosSitios.Text = "Ver todos los Sitios"
        Me.Sitios_Button_VerTodosSitios.UseVisualStyleBackColor = False
        Me.Sitios_Button_VerTodosSitios.UseWaitCursor = True
        '
        'Sitios_Button_Eliminar
        '
        Me.Sitios_Button_Eliminar.Enabled = False
        Me.Sitios_Button_Eliminar.Location = New System.Drawing.Point(545, 261)
        Me.Sitios_Button_Eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.Sitios_Button_Eliminar.Name = "Sitios_Button_Eliminar"
        Me.Sitios_Button_Eliminar.Size = New System.Drawing.Size(106, 35)
        Me.Sitios_Button_Eliminar.TabIndex = 52
        Me.Sitios_Button_Eliminar.Text = "Eliminar"
        Me.Sitios_Button_Eliminar.UseVisualStyleBackColor = True
        '
        'Sitios_Button_Limpiar
        '
        Me.Sitios_Button_Limpiar.Location = New System.Drawing.Point(545, 315)
        Me.Sitios_Button_Limpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.Sitios_Button_Limpiar.Name = "Sitios_Button_Limpiar"
        Me.Sitios_Button_Limpiar.Size = New System.Drawing.Size(106, 35)
        Me.Sitios_Button_Limpiar.TabIndex = 51
        Me.Sitios_Button_Limpiar.Text = "Limpiar"
        Me.Sitios_Button_Limpiar.UseVisualStyleBackColor = True
        '
        'Sitios_Button_Actualizar
        '
        Me.Sitios_Button_Actualizar.Enabled = False
        Me.Sitios_Button_Actualizar.Location = New System.Drawing.Point(365, 315)
        Me.Sitios_Button_Actualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.Sitios_Button_Actualizar.Name = "Sitios_Button_Actualizar"
        Me.Sitios_Button_Actualizar.Size = New System.Drawing.Size(112, 35)
        Me.Sitios_Button_Actualizar.TabIndex = 50
        Me.Sitios_Button_Actualizar.Text = "Actualizar"
        Me.Sitios_Button_Actualizar.UseVisualStyleBackColor = True
        '
        'Sitios_Button_Agregar
        '
        Me.Sitios_Button_Agregar.Location = New System.Drawing.Point(365, 261)
        Me.Sitios_Button_Agregar.Margin = New System.Windows.Forms.Padding(2)
        Me.Sitios_Button_Agregar.Name = "Sitios_Button_Agregar"
        Me.Sitios_Button_Agregar.Size = New System.Drawing.Size(112, 35)
        Me.Sitios_Button_Agregar.TabIndex = 49
        Me.Sitios_Button_Agregar.Text = "Agregar"
        Me.Sitios_Button_Agregar.UseVisualStyleBackColor = True
        '
        'FormSitios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 384)
        Me.Controls.Add(Me.Sitios_Button_Eliminar)
        Me.Controls.Add(Me.Sitios_Button_Limpiar)
        Me.Controls.Add(Me.Sitios_Button_Actualizar)
        Me.Controls.Add(Me.Sitios_Button_Agregar)
        Me.Controls.Add(Me.Sitios_Label_Tipo)
        Me.Controls.Add(Me.Sitios_ComboBox_TipoSitio)
        Me.Controls.Add(Me.Sitios_ComboBox_PaisSitio)
        Me.Controls.Add(Me.Sitios_ListBox_Sitios)
        Me.Controls.Add(Me.Sitios_Label_PaisSitio)
        Me.Controls.Add(Me.Sitios_Label_NombreSitio)
        Me.Controls.Add(Me.Sitios_TextBox_NombreSitio)
        Me.Controls.Add(Me.Sitios_Button_VerTodosSitios)
        Me.Controls.Add(Me.lblTitulo_Sit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormSitios"
        Me.Text = "FormSitios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo_Sit As Label
    Friend WithEvents Sitios_Label_Tipo As Label
    Friend WithEvents Sitios_ComboBox_TipoSitio As ComboBox
    Friend WithEvents Sitios_ComboBox_PaisSitio As ComboBox
    Friend WithEvents Sitios_ListBox_Sitios As ListBox
    Friend WithEvents Sitios_Label_PaisSitio As Label
    Friend WithEvents Sitios_Label_NombreSitio As Label
    Friend WithEvents Sitios_TextBox_NombreSitio As TextBox
    Friend WithEvents Sitios_Button_VerTodosSitios As Button
    Friend WithEvents Sitios_Button_Eliminar As Button
    Friend WithEvents Sitios_Button_Limpiar As Button
    Friend WithEvents Sitios_Button_Actualizar As Button
    Friend WithEvents Sitios_Button_Agregar As Button
End Class
