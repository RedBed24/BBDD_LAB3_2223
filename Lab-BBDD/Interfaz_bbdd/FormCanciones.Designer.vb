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
        Me.Canciones_Button_Eliminar = New System.Windows.Forms.Button()
        Me.Canciones_Button_Limpiar = New System.Windows.Forms.Button()
        Me.Canciones_Button_Actualizar = New System.Windows.Forms.Button()
        Me.Canciones_Button_Agregar = New System.Windows.Forms.Button()
        Me.Canciones_TextBoxDuracionCanciones = New System.Windows.Forms.TextBox()
        Me.Canciones_LabelDuracion = New System.Windows.Forms.Label()
        Me.Canciones_TextBoxNombreCanciones = New System.Windows.Forms.TextBox()
        Me.Canciones_ListBoxTodasLasCanciones = New System.Windows.Forms.ListBox()
        Me.Canciones_LabelNombreCancion = New System.Windows.Forms.Label()
        Me.Canciones_LabelAlbum = New System.Windows.Forms.Label()
        Me.Canciones_ComboBox_Album = New System.Windows.Forms.ComboBox()
        Me.Canciones_LabelOrden = New System.Windows.Forms.Label()
        Me.Canciones_TextBox_Orden = New System.Windows.Forms.TextBox()
        Me.Canciones_Button_VerTodasCanciones = New System.Windows.Forms.Button()
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
        'Canciones_Button_Eliminar
        '
        Me.Canciones_Button_Eliminar.Enabled = False
        Me.Canciones_Button_Eliminar.Location = New System.Drawing.Point(557, 251)
        Me.Canciones_Button_Eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.Canciones_Button_Eliminar.Name = "Canciones_Button_Eliminar"
        Me.Canciones_Button_Eliminar.Size = New System.Drawing.Size(106, 35)
        Me.Canciones_Button_Eliminar.TabIndex = 52
        Me.Canciones_Button_Eliminar.Text = "Eliminar"
        Me.Canciones_Button_Eliminar.UseVisualStyleBackColor = True
        '
        'Canciones_Button_Limpiar
        '
        Me.Canciones_Button_Limpiar.Location = New System.Drawing.Point(557, 305)
        Me.Canciones_Button_Limpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.Canciones_Button_Limpiar.Name = "Canciones_Button_Limpiar"
        Me.Canciones_Button_Limpiar.Size = New System.Drawing.Size(106, 35)
        Me.Canciones_Button_Limpiar.TabIndex = 51
        Me.Canciones_Button_Limpiar.Text = "Limpiar"
        Me.Canciones_Button_Limpiar.UseVisualStyleBackColor = True
        '
        'Canciones_Button_Actualizar
        '
        Me.Canciones_Button_Actualizar.Enabled = False
        Me.Canciones_Button_Actualizar.Location = New System.Drawing.Point(377, 305)
        Me.Canciones_Button_Actualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.Canciones_Button_Actualizar.Name = "Canciones_Button_Actualizar"
        Me.Canciones_Button_Actualizar.Size = New System.Drawing.Size(112, 35)
        Me.Canciones_Button_Actualizar.TabIndex = 50
        Me.Canciones_Button_Actualizar.Text = "Actualizar"
        Me.Canciones_Button_Actualizar.UseVisualStyleBackColor = True
        '
        'Canciones_Button_Agregar
        '
        Me.Canciones_Button_Agregar.Location = New System.Drawing.Point(377, 251)
        Me.Canciones_Button_Agregar.Margin = New System.Windows.Forms.Padding(2)
        Me.Canciones_Button_Agregar.Name = "Canciones_Button_Agregar"
        Me.Canciones_Button_Agregar.Size = New System.Drawing.Size(112, 35)
        Me.Canciones_Button_Agregar.TabIndex = 49
        Me.Canciones_Button_Agregar.Text = "Agregar"
        Me.Canciones_Button_Agregar.UseVisualStyleBackColor = True
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
        'Canciones_LabelAlbum
        '
        Me.Canciones_LabelAlbum.AutoSize = True
        Me.Canciones_LabelAlbum.Location = New System.Drawing.Point(318, 170)
        Me.Canciones_LabelAlbum.Name = "Canciones_LabelAlbum"
        Me.Canciones_LabelAlbum.Size = New System.Drawing.Size(128, 16)
        Me.Canciones_LabelAlbum.TabIndex = 59
        Me.Canciones_LabelAlbum.Text = "Album de la canción"
        Me.Canciones_LabelAlbum.UseWaitCursor = True
        '
        'Canciones_ComboBox_Album
        '
        Me.Canciones_ComboBox_Album.FormattingEnabled = True
        Me.Canciones_ComboBox_Album.Location = New System.Drawing.Point(321, 189)
        Me.Canciones_ComboBox_Album.Name = "Canciones_ComboBox_Album"
        Me.Canciones_ComboBox_Album.Size = New System.Drawing.Size(164, 24)
        Me.Canciones_ComboBox_Album.TabIndex = 60
        '
        'Canciones_LabelOrden
        '
        Me.Canciones_LabelOrden.AutoSize = True
        Me.Canciones_LabelOrden.Location = New System.Drawing.Point(530, 170)
        Me.Canciones_LabelOrden.Name = "Canciones_LabelOrden"
        Me.Canciones_LabelOrden.Size = New System.Drawing.Size(127, 16)
        Me.Canciones_LabelOrden.TabIndex = 61
        Me.Canciones_LabelOrden.Text = "Orden de la canción"
        Me.Canciones_LabelOrden.UseWaitCursor = True
        '
        'Canciones_TextBox_Orden
        '
        Me.Canciones_TextBox_Orden.Location = New System.Drawing.Point(533, 189)
        Me.Canciones_TextBox_Orden.Name = "Canciones_TextBox_Orden"
        Me.Canciones_TextBox_Orden.Size = New System.Drawing.Size(164, 22)
        Me.Canciones_TextBox_Orden.TabIndex = 62
        Me.Canciones_TextBox_Orden.UseWaitCursor = True
        '
        'Canciones_Button_VerTodasCanciones
        '
        Me.Canciones_Button_VerTodasCanciones.BackColor = System.Drawing.Color.MistyRose
        Me.Canciones_Button_VerTodasCanciones.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Canciones_Button_VerTodasCanciones.Location = New System.Drawing.Point(12, 51)
        Me.Canciones_Button_VerTodasCanciones.Name = "Canciones_Button_VerTodasCanciones"
        Me.Canciones_Button_VerTodasCanciones.Size = New System.Drawing.Size(170, 28)
        Me.Canciones_Button_VerTodasCanciones.TabIndex = 63
        Me.Canciones_Button_VerTodasCanciones.Text = "Ver todas las Canciones"
        Me.Canciones_Button_VerTodasCanciones.UseVisualStyleBackColor = False
        Me.Canciones_Button_VerTodasCanciones.UseWaitCursor = True
        '
        'FormCanciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 385)
        Me.Controls.Add(Me.Canciones_Button_VerTodasCanciones)
        Me.Controls.Add(Me.Canciones_TextBox_Orden)
        Me.Controls.Add(Me.Canciones_LabelOrden)
        Me.Controls.Add(Me.Canciones_ComboBox_Album)
        Me.Controls.Add(Me.Canciones_LabelAlbum)
        Me.Controls.Add(Me.Canciones_TextBoxDuracionCanciones)
        Me.Controls.Add(Me.Canciones_LabelDuracion)
        Me.Controls.Add(Me.Canciones_TextBoxNombreCanciones)
        Me.Controls.Add(Me.Canciones_ListBoxTodasLasCanciones)
        Me.Controls.Add(Me.Canciones_LabelNombreCancion)
        Me.Controls.Add(Me.Canciones_Button_Eliminar)
        Me.Controls.Add(Me.Canciones_Button_Limpiar)
        Me.Controls.Add(Me.Canciones_Button_Actualizar)
        Me.Controls.Add(Me.Canciones_Button_Agregar)
        Me.Controls.Add(Me.lblTitulo_Can)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormCanciones"
        Me.Text = "FormCanciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo_Can As Label
    Friend WithEvents cboArtista_Alb As ComboBox
    Friend WithEvents Canciones_Button_Eliminar As Button
    Friend WithEvents Canciones_Button_Limpiar As Button
    Friend WithEvents Canciones_Button_Actualizar As Button
    Friend WithEvents Canciones_Button_Agregar As Button
    Friend WithEvents Canciones_TextBoxDuracionCanciones As TextBox
    Friend WithEvents Canciones_LabelDuracion As Label
    Friend WithEvents Canciones_TextBoxNombreCanciones As TextBox
    Friend WithEvents Canciones_ListBoxTodasLasCanciones As ListBox
    Friend WithEvents Canciones_LabelNombreCancion As Label
    Friend WithEvents Canciones_LabelAlbum As Label
    Friend WithEvents Canciones_ComboBox_Album As ComboBox
    Friend WithEvents Canciones_LabelOrden As Label
    Friend WithEvents Canciones_TextBox_Orden As TextBox
    Friend WithEvents Canciones_Button_VerTodasCanciones As Button
End Class
