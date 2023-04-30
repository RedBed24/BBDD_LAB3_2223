<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormConciertos
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
        Me.Concierto_Label_Sitio = New System.Windows.Forms.Label()
        Me.Concierto_ComboBox_Sitio = New System.Windows.Forms.ComboBox()
        Me.Concierto_ComboBox_Artista = New System.Windows.Forms.ComboBox()
        Me.Concierto_ListBox_Concierto = New System.Windows.Forms.ListBox()
        Me.Concierto_Label_Artista = New System.Windows.Forms.Label()
        Me.Concierto_Label_Fecha = New System.Windows.Forms.Label()
        Me.Concierto_Button_VerTodosConcierto = New System.Windows.Forms.Button()
        Me.Concierto_Button_Eliminar = New System.Windows.Forms.Button()
        Me.Concierto_Button_Limpiar = New System.Windows.Forms.Button()
        Me.Concierto_Button_Actualizar = New System.Windows.Forms.Button()
        Me.Concierto_Button_Agregar = New System.Windows.Forms.Button()
        Me.Concierto_DateTimePicker_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.concierto_labelcanciones = New System.Windows.Forms.Label()
        Me.Concierto_ListBox_CancionesArtista = New System.Windows.Forms.ListBox()
        Me.Concierto_ListBox_CancionesSeleccionadas = New System.Windows.Forms.ListBox()
        Me.Concierto_Button_MoverArriba = New System.Windows.Forms.Button()
        Me.Concierto_Button_MoverAbajo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitulo_Sit
        '
        Me.lblTitulo_Sit.AutoSize = True
        Me.lblTitulo_Sit.Font = New System.Drawing.Font("Britannic Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo_Sit.Location = New System.Drawing.Point(232, 15)
        Me.lblTitulo_Sit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo_Sit.Name = "lblTitulo_Sit"
        Me.lblTitulo_Sit.Size = New System.Drawing.Size(105, 25)
        Me.lblTitulo_Sit.TabIndex = 1
        Me.lblTitulo_Sit.Text = "Concierto"
        '
        'Concierto_Label_Sitio
        '
        Me.Concierto_Label_Sitio.AutoSize = True
        Me.Concierto_Label_Sitio.Location = New System.Drawing.Point(339, 99)
        Me.Concierto_Label_Sitio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Concierto_Label_Sitio.Name = "Concierto_Label_Sitio"
        Me.Concierto_Label_Sitio.Size = New System.Drawing.Size(94, 13)
        Me.Concierto_Label_Sitio.TabIndex = 23
        Me.Concierto_Label_Sitio.Text = "Sitio del concierto:"
        Me.Concierto_Label_Sitio.UseWaitCursor = True
        '
        'Concierto_ComboBox_Sitio
        '
        Me.Concierto_ComboBox_Sitio.FormattingEnabled = True
        Me.Concierto_ComboBox_Sitio.Location = New System.Drawing.Point(333, 115)
        Me.Concierto_ComboBox_Sitio.Margin = New System.Windows.Forms.Padding(2)
        Me.Concierto_ComboBox_Sitio.Name = "Concierto_ComboBox_Sitio"
        Me.Concierto_ComboBox_Sitio.Size = New System.Drawing.Size(193, 21)
        Me.Concierto_ComboBox_Sitio.TabIndex = 22
        Me.Concierto_ComboBox_Sitio.UseWaitCursor = True
        '
        'Concierto_ComboBox_Artista
        '
        Me.Concierto_ComboBox_Artista.FormattingEnabled = True
        Me.Concierto_ComboBox_Artista.Location = New System.Drawing.Point(333, 158)
        Me.Concierto_ComboBox_Artista.Margin = New System.Windows.Forms.Padding(2)
        Me.Concierto_ComboBox_Artista.Name = "Concierto_ComboBox_Artista"
        Me.Concierto_ComboBox_Artista.Size = New System.Drawing.Size(193, 21)
        Me.Concierto_ComboBox_Artista.TabIndex = 21
        Me.Concierto_ComboBox_Artista.UseWaitCursor = True
        '
        'Concierto_ListBox_Concierto
        '
        Me.Concierto_ListBox_Concierto.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Concierto_ListBox_Concierto.FormattingEnabled = True
        Me.Concierto_ListBox_Concierto.Location = New System.Drawing.Point(23, 91)
        Me.Concierto_ListBox_Concierto.Margin = New System.Windows.Forms.Padding(2)
        Me.Concierto_ListBox_Concierto.Name = "Concierto_ListBox_Concierto"
        Me.Concierto_ListBox_Concierto.Size = New System.Drawing.Size(141, 199)
        Me.Concierto_ListBox_Concierto.TabIndex = 20
        Me.Concierto_ListBox_Concierto.UseWaitCursor = True
        '
        'Concierto_Label_Artista
        '
        Me.Concierto_Label_Artista.AutoSize = True
        Me.Concierto_Label_Artista.Location = New System.Drawing.Point(339, 143)
        Me.Concierto_Label_Artista.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Concierto_Label_Artista.Name = "Concierto_Label_Artista"
        Me.Concierto_Label_Artista.Size = New System.Drawing.Size(39, 13)
        Me.Concierto_Label_Artista.TabIndex = 19
        Me.Concierto_Label_Artista.Text = "Artista:"
        Me.Concierto_Label_Artista.UseWaitCursor = True
        '
        'Concierto_Label_Fecha
        '
        Me.Concierto_Label_Fecha.AutoSize = True
        Me.Concierto_Label_Fecha.Location = New System.Drawing.Point(339, 58)
        Me.Concierto_Label_Fecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Concierto_Label_Fecha.Name = "Concierto_Label_Fecha"
        Me.Concierto_Label_Fecha.Size = New System.Drawing.Size(104, 13)
        Me.Concierto_Label_Fecha.TabIndex = 18
        Me.Concierto_Label_Fecha.Text = "Fecha del concierto:"
        Me.Concierto_Label_Fecha.UseWaitCursor = True
        '
        'Concierto_Button_VerTodosConcierto
        '
        Me.Concierto_Button_VerTodosConcierto.BackColor = System.Drawing.Color.MistyRose
        Me.Concierto_Button_VerTodosConcierto.Location = New System.Drawing.Point(23, 58)
        Me.Concierto_Button_VerTodosConcierto.Margin = New System.Windows.Forms.Padding(2)
        Me.Concierto_Button_VerTodosConcierto.Name = "Concierto_Button_VerTodosConcierto"
        Me.Concierto_Button_VerTodosConcierto.Size = New System.Drawing.Size(140, 23)
        Me.Concierto_Button_VerTodosConcierto.TabIndex = 16
        Me.Concierto_Button_VerTodosConcierto.Text = "Ver todos los Conciertos"
        Me.Concierto_Button_VerTodosConcierto.UseVisualStyleBackColor = False
        Me.Concierto_Button_VerTodosConcierto.UseWaitCursor = True
        '
        'Concierto_Button_Eliminar
        '
        Me.Concierto_Button_Eliminar.Enabled = False
        Me.Concierto_Button_Eliminar.Location = New System.Drawing.Point(456, 204)
        Me.Concierto_Button_Eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.Concierto_Button_Eliminar.Name = "Concierto_Button_Eliminar"
        Me.Concierto_Button_Eliminar.Size = New System.Drawing.Size(80, 28)
        Me.Concierto_Button_Eliminar.TabIndex = 52
        Me.Concierto_Button_Eliminar.Text = "Eliminar"
        Me.Concierto_Button_Eliminar.UseVisualStyleBackColor = True
        '
        'Concierto_Button_Limpiar
        '
        Me.Concierto_Button_Limpiar.Location = New System.Drawing.Point(456, 248)
        Me.Concierto_Button_Limpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.Concierto_Button_Limpiar.Name = "Concierto_Button_Limpiar"
        Me.Concierto_Button_Limpiar.Size = New System.Drawing.Size(80, 28)
        Me.Concierto_Button_Limpiar.TabIndex = 51
        Me.Concierto_Button_Limpiar.Text = "Limpiar"
        Me.Concierto_Button_Limpiar.UseVisualStyleBackColor = True
        '
        'Concierto_Button_Actualizar
        '
        Me.Concierto_Button_Actualizar.Enabled = False
        Me.Concierto_Button_Actualizar.Location = New System.Drawing.Point(321, 248)
        Me.Concierto_Button_Actualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.Concierto_Button_Actualizar.Name = "Concierto_Button_Actualizar"
        Me.Concierto_Button_Actualizar.Size = New System.Drawing.Size(84, 28)
        Me.Concierto_Button_Actualizar.TabIndex = 50
        Me.Concierto_Button_Actualizar.Text = "Actualizar"
        Me.Concierto_Button_Actualizar.UseVisualStyleBackColor = True
        '
        'Concierto_Button_Agregar
        '
        Me.Concierto_Button_Agregar.Location = New System.Drawing.Point(321, 204)
        Me.Concierto_Button_Agregar.Margin = New System.Windows.Forms.Padding(2)
        Me.Concierto_Button_Agregar.Name = "Concierto_Button_Agregar"
        Me.Concierto_Button_Agregar.Size = New System.Drawing.Size(84, 28)
        Me.Concierto_Button_Agregar.TabIndex = 49
        Me.Concierto_Button_Agregar.Text = "Agregar"
        Me.Concierto_Button_Agregar.UseVisualStyleBackColor = True
        '
        'Concierto_DateTimePicker_Fecha
        '
        Me.Concierto_DateTimePicker_Fecha.Checked = False
        Me.Concierto_DateTimePicker_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Concierto_DateTimePicker_Fecha.Location = New System.Drawing.Point(333, 74)
        Me.Concierto_DateTimePicker_Fecha.Margin = New System.Windows.Forms.Padding(2)
        Me.Concierto_DateTimePicker_Fecha.Name = "Concierto_DateTimePicker_Fecha"
        Me.Concierto_DateTimePicker_Fecha.Size = New System.Drawing.Size(193, 20)
        Me.Concierto_DateTimePicker_Fecha.TabIndex = 53
        '
        'concierto_labelcanciones
        '
        Me.concierto_labelcanciones.AutoSize = True
        Me.concierto_labelcanciones.Location = New System.Drawing.Point(167, 68)
        Me.concierto_labelcanciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.concierto_labelcanciones.Name = "concierto_labelcanciones"
        Me.concierto_labelcanciones.Size = New System.Drawing.Size(60, 13)
        Me.concierto_labelcanciones.TabIndex = 55
        Me.concierto_labelcanciones.Text = "Canciones "
        '
        'Concierto_ListBox_CancionesArtista
        '
        Me.Concierto_ListBox_CancionesArtista.FormattingEnabled = True
        Me.Concierto_ListBox_CancionesArtista.Location = New System.Drawing.Point(169, 91)
        Me.Concierto_ListBox_CancionesArtista.Name = "Concierto_ListBox_CancionesArtista"
        Me.Concierto_ListBox_CancionesArtista.Size = New System.Drawing.Size(140, 82)
        Me.Concierto_ListBox_CancionesArtista.TabIndex = 56
        '
        'Concierto_ListBox_CancionesSeleccionadas
        '
        Me.Concierto_ListBox_CancionesSeleccionadas.FormattingEnabled = True
        Me.Concierto_ListBox_CancionesSeleccionadas.Location = New System.Drawing.Point(169, 208)
        Me.Concierto_ListBox_CancionesSeleccionadas.Name = "Concierto_ListBox_CancionesSeleccionadas"
        Me.Concierto_ListBox_CancionesSeleccionadas.Size = New System.Drawing.Size(140, 82)
        Me.Concierto_ListBox_CancionesSeleccionadas.TabIndex = 57
        '
        'Concierto_Button_MoverArriba
        '
        Me.Concierto_Button_MoverArriba.Location = New System.Drawing.Point(283, 180)
        Me.Concierto_Button_MoverArriba.Name = "Concierto_Button_MoverArriba"
        Me.Concierto_Button_MoverArriba.Size = New System.Drawing.Size(26, 23)
        Me.Concierto_Button_MoverArriba.TabIndex = 58
        Me.Concierto_Button_MoverArriba.Text = "^"
        Me.Concierto_Button_MoverArriba.UseVisualStyleBackColor = True
        '
        'Concierto_Button_MoverAbajo
        '
        Me.Concierto_Button_MoverAbajo.Location = New System.Drawing.Point(251, 180)
        Me.Concierto_Button_MoverAbajo.Name = "Concierto_Button_MoverAbajo"
        Me.Concierto_Button_MoverAbajo.Size = New System.Drawing.Size(26, 23)
        Me.Concierto_Button_MoverAbajo.TabIndex = 59
        Me.Concierto_Button_MoverAbajo.Text = "v"
        Me.Concierto_Button_MoverAbajo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(169, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Seleccionadas"
        '
        'FormConciertos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 312)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Concierto_Button_MoverAbajo)
        Me.Controls.Add(Me.Concierto_Button_MoverArriba)
        Me.Controls.Add(Me.Concierto_ListBox_CancionesSeleccionadas)
        Me.Controls.Add(Me.Concierto_ListBox_CancionesArtista)
        Me.Controls.Add(Me.concierto_labelcanciones)
        Me.Controls.Add(Me.Concierto_DateTimePicker_Fecha)
        Me.Controls.Add(Me.Concierto_Button_Eliminar)
        Me.Controls.Add(Me.Concierto_Button_Limpiar)
        Me.Controls.Add(Me.Concierto_Button_Actualizar)
        Me.Controls.Add(Me.Concierto_Button_Agregar)
        Me.Controls.Add(Me.Concierto_Label_Sitio)
        Me.Controls.Add(Me.Concierto_ComboBox_Sitio)
        Me.Controls.Add(Me.Concierto_ComboBox_Artista)
        Me.Controls.Add(Me.Concierto_ListBox_Concierto)
        Me.Controls.Add(Me.Concierto_Label_Artista)
        Me.Controls.Add(Me.Concierto_Label_Fecha)
        Me.Controls.Add(Me.Concierto_Button_VerTodosConcierto)
        Me.Controls.Add(Me.lblTitulo_Sit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormConciertos"
        Me.Text = "FormConcierto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo_Sit As Label
    Friend WithEvents Concierto_Label_Sitio As Label
    Friend WithEvents Concierto_ComboBox_Sitio As ComboBox
    Friend WithEvents Concierto_ComboBox_Artista As ComboBox
    Friend WithEvents Concierto_ListBox_Concierto As ListBox
    Friend WithEvents Concierto_Label_Artista As Label
    Friend WithEvents Concierto_Label_Fecha As Label
    Friend WithEvents Concierto_Button_VerTodosConcierto As Button
    Friend WithEvents Concierto_Button_Eliminar As Button
    Friend WithEvents Concierto_Button_Limpiar As Button
    Friend WithEvents Concierto_Button_Actualizar As Button
    Friend WithEvents Concierto_Button_Agregar As Button
    Friend WithEvents Concierto_DateTimePicker_Fecha As DateTimePicker
    Friend WithEvents concierto_labelcanciones As Label
    Friend WithEvents Concierto_ListBox_CancionesArtista As ListBox
    Friend WithEvents Concierto_ListBox_CancionesSeleccionadas As ListBox
    Friend WithEvents Concierto_Button_MoverArriba As Button
    Friend WithEvents Concierto_Button_MoverAbajo As Button
    Friend WithEvents Label1 As Label
End Class
