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
        Me.Conciertos_Button_Eliminar = New System.Windows.Forms.Button()
        Me.Conciertos_Button_Limpiar = New System.Windows.Forms.Button()
        Me.Conciertos_Button_Actualizar = New System.Windows.Forms.Button()
        Me.Conciertos_Button_Agregar = New System.Windows.Forms.Button()
        Me.Concierto_DateTimePicker_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Conciertos_CheckedListBox_Canciones = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'lblTitulo_Sit
        '
        Me.lblTitulo_Sit.AutoSize = True
        Me.lblTitulo_Sit.Font = New System.Drawing.Font("Britannic Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo_Sit.Location = New System.Drawing.Point(309, 18)
        Me.lblTitulo_Sit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo_Sit.Name = "lblTitulo_Sit"
        Me.lblTitulo_Sit.Size = New System.Drawing.Size(134, 31)
        Me.lblTitulo_Sit.TabIndex = 1
        Me.lblTitulo_Sit.Text = "Concierto"
        '
        'Concierto_Label_Sitio
        '
        Me.Concierto_Label_Sitio.AutoSize = True
        Me.Concierto_Label_Sitio.Location = New System.Drawing.Point(452, 122)
        Me.Concierto_Label_Sitio.Name = "Concierto_Label_Sitio"
        Me.Concierto_Label_Sitio.Size = New System.Drawing.Size(116, 16)
        Me.Concierto_Label_Sitio.TabIndex = 23
        Me.Concierto_Label_Sitio.Text = "Sitio del concierto:"
        Me.Concierto_Label_Sitio.UseWaitCursor = True
        '
        'Concierto_ComboBox_Sitio
        '
        Me.Concierto_ComboBox_Sitio.FormattingEnabled = True
        Me.Concierto_ComboBox_Sitio.Location = New System.Drawing.Point(444, 141)
        Me.Concierto_ComboBox_Sitio.Name = "Concierto_ComboBox_Sitio"
        Me.Concierto_ComboBox_Sitio.Size = New System.Drawing.Size(256, 24)
        Me.Concierto_ComboBox_Sitio.TabIndex = 22
        Me.Concierto_ComboBox_Sitio.UseWaitCursor = True
        '
        'Concierto_ComboBox_Artista
        '
        Me.Concierto_ComboBox_Artista.FormattingEnabled = True
        Me.Concierto_ComboBox_Artista.Location = New System.Drawing.Point(444, 195)
        Me.Concierto_ComboBox_Artista.Name = "Concierto_ComboBox_Artista"
        Me.Concierto_ComboBox_Artista.Size = New System.Drawing.Size(256, 24)
        Me.Concierto_ComboBox_Artista.TabIndex = 21
        Me.Concierto_ComboBox_Artista.UseWaitCursor = True
        '
        'Concierto_ListBox_Concierto
        '
        Me.Concierto_ListBox_Concierto.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Concierto_ListBox_Concierto.FormattingEnabled = True
        Me.Concierto_ListBox_Concierto.ItemHeight = 16
        Me.Concierto_ListBox_Concierto.Location = New System.Drawing.Point(31, 112)
        Me.Concierto_ListBox_Concierto.Name = "Concierto_ListBox_Concierto"
        Me.Concierto_ListBox_Concierto.Size = New System.Drawing.Size(187, 228)
        Me.Concierto_ListBox_Concierto.TabIndex = 20
        Me.Concierto_ListBox_Concierto.UseWaitCursor = True
        '
        'Concierto_Label_Artista
        '
        Me.Concierto_Label_Artista.AutoSize = True
        Me.Concierto_Label_Artista.Location = New System.Drawing.Point(452, 176)
        Me.Concierto_Label_Artista.Name = "Concierto_Label_Artista"
        Me.Concierto_Label_Artista.Size = New System.Drawing.Size(47, 16)
        Me.Concierto_Label_Artista.TabIndex = 19
        Me.Concierto_Label_Artista.Text = "Artista:"
        Me.Concierto_Label_Artista.UseWaitCursor = True
        '
        'Concierto_Label_Fecha
        '
        Me.Concierto_Label_Fecha.AutoSize = True
        Me.Concierto_Label_Fecha.Location = New System.Drawing.Point(452, 72)
        Me.Concierto_Label_Fecha.Name = "Concierto_Label_Fecha"
        Me.Concierto_Label_Fecha.Size = New System.Drawing.Size(128, 16)
        Me.Concierto_Label_Fecha.TabIndex = 18
        Me.Concierto_Label_Fecha.Text = "Fecha del concierto:"
        Me.Concierto_Label_Fecha.UseWaitCursor = True
        '
        'Concierto_Button_VerTodosConcierto
        '
        Me.Concierto_Button_VerTodosConcierto.BackColor = System.Drawing.Color.MistyRose
        Me.Concierto_Button_VerTodosConcierto.Location = New System.Drawing.Point(31, 72)
        Me.Concierto_Button_VerTodosConcierto.Name = "Concierto_Button_VerTodosConcierto"
        Me.Concierto_Button_VerTodosConcierto.Size = New System.Drawing.Size(187, 28)
        Me.Concierto_Button_VerTodosConcierto.TabIndex = 16
        Me.Concierto_Button_VerTodosConcierto.Text = "Ver todos los Conciertos"
        Me.Concierto_Button_VerTodosConcierto.UseVisualStyleBackColor = False
        Me.Concierto_Button_VerTodosConcierto.UseWaitCursor = True
        '
        'Conciertos_Button_Eliminar
        '
        Me.Conciertos_Button_Eliminar.Enabled = False
        Me.Conciertos_Button_Eliminar.Location = New System.Drawing.Point(608, 251)
        Me.Conciertos_Button_Eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.Conciertos_Button_Eliminar.Name = "Conciertos_Button_Eliminar"
        Me.Conciertos_Button_Eliminar.Size = New System.Drawing.Size(106, 35)
        Me.Conciertos_Button_Eliminar.TabIndex = 52
        Me.Conciertos_Button_Eliminar.Text = "Eliminar"
        Me.Conciertos_Button_Eliminar.UseVisualStyleBackColor = True
        '
        'Conciertos_Button_Limpiar
        '
        Me.Conciertos_Button_Limpiar.Location = New System.Drawing.Point(608, 305)
        Me.Conciertos_Button_Limpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.Conciertos_Button_Limpiar.Name = "Conciertos_Button_Limpiar"
        Me.Conciertos_Button_Limpiar.Size = New System.Drawing.Size(106, 35)
        Me.Conciertos_Button_Limpiar.TabIndex = 51
        Me.Conciertos_Button_Limpiar.Text = "Limpiar"
        Me.Conciertos_Button_Limpiar.UseVisualStyleBackColor = True
        '
        'Conciertos_Button_Actualizar
        '
        Me.Conciertos_Button_Actualizar.Enabled = False
        Me.Conciertos_Button_Actualizar.Location = New System.Drawing.Point(428, 305)
        Me.Conciertos_Button_Actualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.Conciertos_Button_Actualizar.Name = "Conciertos_Button_Actualizar"
        Me.Conciertos_Button_Actualizar.Size = New System.Drawing.Size(112, 35)
        Me.Conciertos_Button_Actualizar.TabIndex = 50
        Me.Conciertos_Button_Actualizar.Text = "Actualizar"
        Me.Conciertos_Button_Actualizar.UseVisualStyleBackColor = True
        '
        'Conciertos_Button_Agregar
        '
        Me.Conciertos_Button_Agregar.Location = New System.Drawing.Point(428, 251)
        Me.Conciertos_Button_Agregar.Margin = New System.Windows.Forms.Padding(2)
        Me.Conciertos_Button_Agregar.Name = "Conciertos_Button_Agregar"
        Me.Conciertos_Button_Agregar.Size = New System.Drawing.Size(112, 35)
        Me.Conciertos_Button_Agregar.TabIndex = 49
        Me.Conciertos_Button_Agregar.Text = "Agregar"
        Me.Conciertos_Button_Agregar.UseVisualStyleBackColor = True
        '
        'Concierto_DateTimePicker_Fecha
        '
        Me.Concierto_DateTimePicker_Fecha.Location = New System.Drawing.Point(444, 91)
        Me.Concierto_DateTimePicker_Fecha.Name = "Concierto_DateTimePicker_Fecha"
        Me.Concierto_DateTimePicker_Fecha.Size = New System.Drawing.Size(256, 22)
        Me.Concierto_DateTimePicker_Fecha.TabIndex = 53
        '
        'Conciertos_CheckedListBox_Canciones
        '
        Me.Conciertos_CheckedListBox_Canciones.AllowDrop = True
        Me.Conciertos_CheckedListBox_Canciones.FormattingEnabled = True
        Me.Conciertos_CheckedListBox_Canciones.Items.AddRange(New Object() {"Hola", "Test"})
        Me.Conciertos_CheckedListBox_Canciones.Location = New System.Drawing.Point(245, 112)
        Me.Conciertos_CheckedListBox_Canciones.Name = "Conciertos_CheckedListBox_Canciones"
        Me.Conciertos_CheckedListBox_Canciones.Size = New System.Drawing.Size(154, 225)
        Me.Conciertos_CheckedListBox_Canciones.TabIndex = 54
        '
        'FormConciertos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 384)
        Me.Controls.Add(Me.Conciertos_CheckedListBox_Canciones)
        Me.Controls.Add(Me.Concierto_DateTimePicker_Fecha)
        Me.Controls.Add(Me.Conciertos_Button_Eliminar)
        Me.Controls.Add(Me.Conciertos_Button_Limpiar)
        Me.Controls.Add(Me.Conciertos_Button_Actualizar)
        Me.Controls.Add(Me.Conciertos_Button_Agregar)
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
    Friend WithEvents Conciertos_Button_Eliminar As Button
    Friend WithEvents Conciertos_Button_Limpiar As Button
    Friend WithEvents Conciertos_Button_Actualizar As Button
    Friend WithEvents Conciertos_Button_Agregar As Button
    Friend WithEvents Concierto_DateTimePicker_Fecha As DateTimePicker
    Friend WithEvents Conciertos_CheckedListBox_Canciones As CheckedListBox
End Class
