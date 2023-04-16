<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCanciones
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
        Me.lblTitulo_Can = New System.Windows.Forms.Label()
        Me.lblDuracion_Can = New System.Windows.Forms.Label()
        Me.NumericUpDownMin_Can = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownSeg_Can = New System.Windows.Forms.NumericUpDown()
        Me.Artistas_Button_Eliminar = New System.Windows.Forms.Button()
        Me.Artistas_Button_Limpiar = New System.Windows.Forms.Button()
        Me.Artistas_Button_Actualizar = New System.Windows.Forms.Button()
        Me.Artistas_Button_Agregar = New System.Windows.Forms.Button()
        Me.Canciones_TextBoxDuracionCanciones = New System.Windows.Forms.TextBox()
        Me.Canciones_LabelDuracion = New System.Windows.Forms.Label()
        Me.Canciones_TextBoxNombreCanciones = New System.Windows.Forms.TextBox()
        Me.Canciones_ListBoxTodasLasCanciones = New System.Windows.Forms.ListBox()
        Me.Canciones_LabelNombreCancion = New System.Windows.Forms.Label()
        Me.Canciones_LabelCanciones = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownMin_Can, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownSeg_Can, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo_Can
        '
        Me.lblTitulo_Can.AutoSize = True
        Me.lblTitulo_Can.Font = New System.Drawing.Font("Britannic Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo_Can.Location = New System.Drawing.Point(298, 22)
        Me.lblTitulo_Can.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo_Can.Name = "lblTitulo_Can"
        Me.lblTitulo_Can.Size = New System.Drawing.Size(142, 31)
        Me.lblTitulo_Can.TabIndex = 0
        Me.lblTitulo_Can.Text = "Canciones"
        '
        'lblDuracion_Can
        '
        Me.lblDuracion_Can.AutoSize = True
        Me.lblDuracion_Can.Location = New System.Drawing.Point(318, 160)
        Me.lblDuracion_Can.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDuracion_Can.Name = "lblDuracion_Can"
        Me.lblDuracion_Can.Size = New System.Drawing.Size(61, 16)
        Me.lblDuracion_Can.TabIndex = 40
        Me.lblDuracion_Can.Text = "Duración"
        '
        'NumericUpDownMin_Can
        '
        Me.NumericUpDownMin_Can.Location = New System.Drawing.Point(321, 189)
        Me.NumericUpDownMin_Can.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDownMin_Can.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDownMin_Can.Name = "NumericUpDownMin_Can"
        Me.NumericUpDownMin_Can.Size = New System.Drawing.Size(66, 22)
        Me.NumericUpDownMin_Can.TabIndex = 41
        '
        'NumericUpDownSeg_Can
        '
        Me.NumericUpDownSeg_Can.Location = New System.Drawing.Point(419, 189)
        Me.NumericUpDownSeg_Can.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDownSeg_Can.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumericUpDownSeg_Can.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.NumericUpDownSeg_Can.Name = "NumericUpDownSeg_Can"
        Me.NumericUpDownSeg_Can.Size = New System.Drawing.Size(66, 22)
        Me.NumericUpDownSeg_Can.TabIndex = 42
        '
        'Artistas_Button_Eliminar
        '
        Me.Artistas_Button_Eliminar.Enabled = False
        Me.Artistas_Button_Eliminar.Location = New System.Drawing.Point(557, 251)
        Me.Artistas_Button_Eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.Artistas_Button_Eliminar.Name = "Artistas_Button_Eliminar"
        Me.Artistas_Button_Eliminar.Size = New System.Drawing.Size(106, 35)
        Me.Artistas_Button_Eliminar.TabIndex = 52
        Me.Artistas_Button_Eliminar.Text = "Eliminar"
        Me.Artistas_Button_Eliminar.UseVisualStyleBackColor = True
        '
        'Artistas_Button_Limpiar
        '
        Me.Artistas_Button_Limpiar.Location = New System.Drawing.Point(557, 305)
        Me.Artistas_Button_Limpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.Artistas_Button_Limpiar.Name = "Artistas_Button_Limpiar"
        Me.Artistas_Button_Limpiar.Size = New System.Drawing.Size(106, 35)
        Me.Artistas_Button_Limpiar.TabIndex = 51
        Me.Artistas_Button_Limpiar.Text = "Limpiar"
        Me.Artistas_Button_Limpiar.UseVisualStyleBackColor = True
        '
        'Artistas_Button_Actualizar
        '
        Me.Artistas_Button_Actualizar.Enabled = False
        Me.Artistas_Button_Actualizar.Location = New System.Drawing.Point(377, 305)
        Me.Artistas_Button_Actualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.Artistas_Button_Actualizar.Name = "Artistas_Button_Actualizar"
        Me.Artistas_Button_Actualizar.Size = New System.Drawing.Size(112, 35)
        Me.Artistas_Button_Actualizar.TabIndex = 50
        Me.Artistas_Button_Actualizar.Text = "Actualizar"
        Me.Artistas_Button_Actualizar.UseVisualStyleBackColor = True
        '
        'Artistas_Button_Agregar
        '
        Me.Artistas_Button_Agregar.Location = New System.Drawing.Point(377, 251)
        Me.Artistas_Button_Agregar.Margin = New System.Windows.Forms.Padding(2)
        Me.Artistas_Button_Agregar.Name = "Artistas_Button_Agregar"
        Me.Artistas_Button_Agregar.Size = New System.Drawing.Size(112, 35)
        Me.Artistas_Button_Agregar.TabIndex = 49
        Me.Artistas_Button_Agregar.Text = "Agregar"
        Me.Artistas_Button_Agregar.UseVisualStyleBackColor = True
        '
        'Canciones_TextBoxDuracionCanciones
        '
        Me.Canciones_TextBoxDuracionCanciones.Location = New System.Drawing.Point(533, 113)
        Me.Canciones_TextBoxDuracionCanciones.Name = "Canciones_TextBoxDuracionCanciones"
        Me.Canciones_TextBoxDuracionCanciones.Size = New System.Drawing.Size(164, 22)
        Me.Canciones_TextBoxDuracionCanciones.TabIndex = 57
        Me.Canciones_TextBoxDuracionCanciones.UseWaitCursor = True
        '
        'Canciones_LabelDuracion
        '
        Me.Canciones_LabelDuracion.AutoSize = True
        Me.Canciones_LabelDuracion.Location = New System.Drawing.Point(530, 94)
        Me.Canciones_LabelDuracion.Name = "Canciones_LabelDuracion"
        Me.Canciones_LabelDuracion.Size = New System.Drawing.Size(147, 16)
        Me.Canciones_LabelDuracion.TabIndex = 56
        Me.Canciones_LabelDuracion.Text = "Duracion de la cancion:"
        Me.Canciones_LabelDuracion.UseWaitCursor = True
        '
        'Canciones_TextBoxNombreCanciones
        '
        Me.Canciones_TextBoxNombreCanciones.Location = New System.Drawing.Point(321, 113)
        Me.Canciones_TextBoxNombreCanciones.Name = "Canciones_TextBoxNombreCanciones"
        Me.Canciones_TextBoxNombreCanciones.Size = New System.Drawing.Size(164, 22)
        Me.Canciones_TextBoxNombreCanciones.TabIndex = 55
        Me.Canciones_TextBoxNombreCanciones.UseWaitCursor = True
        '
        'Canciones_ListBoxTodasLasCanciones
        '
        Me.Canciones_ListBoxTodasLasCanciones.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Canciones_ListBoxTodasLasCanciones.FormattingEnabled = True
        Me.Canciones_ListBoxTodasLasCanciones.ItemHeight = 16
        Me.Canciones_ListBoxTodasLasCanciones.Location = New System.Drawing.Point(12, 85)
        Me.Canciones_ListBoxTodasLasCanciones.Name = "Canciones_ListBoxTodasLasCanciones"
        Me.Canciones_ListBoxTodasLasCanciones.Size = New System.Drawing.Size(263, 276)
        Me.Canciones_ListBoxTodasLasCanciones.TabIndex = 54
        Me.Canciones_ListBoxTodasLasCanciones.UseWaitCursor = True
        '
        'Canciones_LabelNombreCancion
        '
        Me.Canciones_LabelNombreCancion.AutoSize = True
        Me.Canciones_LabelNombreCancion.Location = New System.Drawing.Point(318, 94)
        Me.Canciones_LabelNombreCancion.Name = "Canciones_LabelNombreCancion"
        Me.Canciones_LabelNombreCancion.Size = New System.Drawing.Size(142, 16)
        Me.Canciones_LabelNombreCancion.TabIndex = 53
        Me.Canciones_LabelNombreCancion.Text = "Nombre de la cancion:"
        Me.Canciones_LabelNombreCancion.UseWaitCursor = True
        '
        'Canciones_LabelCanciones
        '
        Me.Canciones_LabelCanciones.AutoSize = True
        Me.Canciones_LabelCanciones.Location = New System.Drawing.Point(12, 66)
        Me.Canciones_LabelCanciones.Name = "Canciones_LabelCanciones"
        Me.Canciones_LabelCanciones.Size = New System.Drawing.Size(71, 16)
        Me.Canciones_LabelCanciones.TabIndex = 58
        Me.Canciones_LabelCanciones.Text = "Canciones"
        Me.Canciones_LabelCanciones.UseWaitCursor = True
        '
        'FormCanciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 385)
        Me.Controls.Add(Me.Canciones_LabelCanciones)
        Me.Controls.Add(Me.Canciones_TextBoxDuracionCanciones)
        Me.Controls.Add(Me.Canciones_LabelDuracion)
        Me.Controls.Add(Me.Canciones_TextBoxNombreCanciones)
        Me.Controls.Add(Me.Canciones_ListBoxTodasLasCanciones)
        Me.Controls.Add(Me.Canciones_LabelNombreCancion)
        Me.Controls.Add(Me.Artistas_Button_Eliminar)
        Me.Controls.Add(Me.Artistas_Button_Limpiar)
        Me.Controls.Add(Me.Artistas_Button_Actualizar)
        Me.Controls.Add(Me.Artistas_Button_Agregar)
        Me.Controls.Add(Me.NumericUpDownSeg_Can)
        Me.Controls.Add(Me.NumericUpDownMin_Can)
        Me.Controls.Add(Me.lblDuracion_Can)
        Me.Controls.Add(Me.lblTitulo_Can)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormCanciones"
        Me.Text = "FormCanciones"
        CType(Me.NumericUpDownMin_Can, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownSeg_Can, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo_Can As Label
    Friend WithEvents cboArtista_Alb As ComboBox
    Friend WithEvents lblDuracion_Can As Label
    Friend WithEvents NumericUpDownMin_Can As NumericUpDown
    Friend WithEvents NumericUpDownSeg_Can As NumericUpDown
    Friend WithEvents Artistas_Button_Eliminar As Button
    Friend WithEvents Artistas_Button_Limpiar As Button
    Friend WithEvents Artistas_Button_Actualizar As Button
    Friend WithEvents Artistas_Button_Agregar As Button
    Friend WithEvents Canciones_TextBoxDuracionCanciones As TextBox
    Friend WithEvents Canciones_LabelDuracion As Label
    Friend WithEvents Canciones_TextBoxNombreCanciones As TextBox
    Friend WithEvents Canciones_ListBoxTodasLasCanciones As ListBox
    Friend WithEvents Canciones_LabelNombreCancion As Label
    Friend WithEvents Canciones_LabelCanciones As Label
End Class
