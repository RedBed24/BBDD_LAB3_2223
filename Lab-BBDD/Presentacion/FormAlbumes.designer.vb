<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAlbumes
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
        Me.lblTitulo_Alb = New System.Windows.Forms.Label()
        Me.Albumes_LabelNombre = New System.Windows.Forms.Label()
        Me.Albumes_LabelAño = New System.Windows.Forms.Label()
        Me.Albumes_TextBoxAñoAlbum = New System.Windows.Forms.TextBox()
        Me.Albumes_LabelListaAlbumes = New System.Windows.Forms.Label()
        Me.Albumes_LabelNombreArtista = New System.Windows.Forms.Label()
        Me.Albumes_ComboBoxArtistas = New System.Windows.Forms.ComboBox()
        Me.Albumes_Button_Eliminar = New System.Windows.Forms.Button()
        Me.Albumes_Button_Limpiar = New System.Windows.Forms.Button()
        Me.Albumes_Button_Actualizar = New System.Windows.Forms.Button()
        Me.Albumes_Button_Agregar = New System.Windows.Forms.Button()
        Me.Albumes_Button_VerTodosAlbumes = New System.Windows.Forms.Button()
        Me.Albumes_ListBox_Albumes = New System.Windows.Forms.ListBox()
        Me.Albumes_TextBoxNombreAlbum = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTitulo_Alb
        '
        Me.lblTitulo_Alb.AutoSize = True
        Me.lblTitulo_Alb.Font = New System.Drawing.Font("Britannic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo_Alb.Location = New System.Drawing.Point(300, 22)
        Me.lblTitulo_Alb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo_Alb.Name = "lblTitulo_Alb"
        Me.lblTitulo_Alb.Size = New System.Drawing.Size(106, 26)
        Me.lblTitulo_Alb.TabIndex = 26
        Me.lblTitulo_Alb.Text = "ALBUMES"
        '
        'Albumes_LabelNombre
        '
        Me.Albumes_LabelNombre.AutoSize = True
        Me.Albumes_LabelNombre.Location = New System.Drawing.Point(344, 89)
        Me.Albumes_LabelNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Albumes_LabelNombre.Name = "Albumes_LabelNombre"
        Me.Albumes_LabelNombre.Size = New System.Drawing.Size(56, 16)
        Me.Albumes_LabelNombre.TabIndex = 29
        Me.Albumes_LabelNombre.Text = "Nombre"
        '
        'Albumes_LabelAño
        '
        Me.Albumes_LabelAño.AutoSize = True
        Me.Albumes_LabelAño.Location = New System.Drawing.Point(542, 172)
        Me.Albumes_LabelAño.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Albumes_LabelAño.Name = "Albumes_LabelAño"
        Me.Albumes_LabelAño.Size = New System.Drawing.Size(31, 16)
        Me.Albumes_LabelAño.TabIndex = 30
        Me.Albumes_LabelAño.Text = "Año"
        '
        'Albumes_TextBoxAñoAlbum
        '
        Me.Albumes_TextBoxAñoAlbum.Location = New System.Drawing.Point(545, 203)
        Me.Albumes_TextBoxAñoAlbum.Margin = New System.Windows.Forms.Padding(2)
        Me.Albumes_TextBoxAñoAlbum.Name = "Albumes_TextBoxAñoAlbum"
        Me.Albumes_TextBoxAñoAlbum.Size = New System.Drawing.Size(150, 22)
        Me.Albumes_TextBoxAñoAlbum.TabIndex = 34
        '
        'Albumes_LabelListaAlbumes
        '
        Me.Albumes_LabelListaAlbumes.AutoSize = True
        Me.Albumes_LabelListaAlbumes.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Albumes_LabelListaAlbumes.Location = New System.Drawing.Point(111, -38)
        Me.Albumes_LabelListaAlbumes.Name = "Albumes_LabelListaAlbumes"
        Me.Albumes_LabelListaAlbumes.Size = New System.Drawing.Size(60, 16)
        Me.Albumes_LabelListaAlbumes.TabIndex = 41
        Me.Albumes_LabelListaAlbumes.Text = "Albumes"
        Me.Albumes_LabelListaAlbumes.UseWaitCursor = True
        '
        'Albumes_LabelNombreArtista
        '
        Me.Albumes_LabelNombreArtista.AutoSize = True
        Me.Albumes_LabelNombreArtista.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Albumes_LabelNombreArtista.Location = New System.Drawing.Point(542, 85)
        Me.Albumes_LabelNombreArtista.Name = "Albumes_LabelNombreArtista"
        Me.Albumes_LabelNombreArtista.Size = New System.Drawing.Size(44, 16)
        Me.Albumes_LabelNombreArtista.TabIndex = 44
        Me.Albumes_LabelNombreArtista.Text = "Artista"
        Me.Albumes_LabelNombreArtista.UseWaitCursor = True
        '
        'Albumes_ComboBoxArtistas
        '
        Me.Albumes_ComboBoxArtistas.FormattingEnabled = True
        Me.Albumes_ComboBoxArtistas.Location = New System.Drawing.Point(545, 116)
        Me.Albumes_ComboBoxArtistas.Name = "Albumes_ComboBoxArtistas"
        Me.Albumes_ComboBoxArtistas.Size = New System.Drawing.Size(150, 24)
        Me.Albumes_ComboBoxArtistas.TabIndex = 43
        Me.Albumes_ComboBoxArtistas.UseWaitCursor = True
        '
        'Albumes_Button_Eliminar
        '
        Me.Albumes_Button_Eliminar.Enabled = False
        Me.Albumes_Button_Eliminar.Location = New System.Drawing.Point(545, 256)
        Me.Albumes_Button_Eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.Albumes_Button_Eliminar.Name = "Albumes_Button_Eliminar"
        Me.Albumes_Button_Eliminar.Size = New System.Drawing.Size(106, 35)
        Me.Albumes_Button_Eliminar.TabIndex = 48
        Me.Albumes_Button_Eliminar.Text = "Eliminar"
        Me.Albumes_Button_Eliminar.UseVisualStyleBackColor = True
        '
        'Albumes_Button_Limpiar
        '
        Me.Albumes_Button_Limpiar.Location = New System.Drawing.Point(545, 310)
        Me.Albumes_Button_Limpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.Albumes_Button_Limpiar.Name = "Albumes_Button_Limpiar"
        Me.Albumes_Button_Limpiar.Size = New System.Drawing.Size(106, 35)
        Me.Albumes_Button_Limpiar.TabIndex = 47
        Me.Albumes_Button_Limpiar.Text = "Limpiar"
        Me.Albumes_Button_Limpiar.UseVisualStyleBackColor = True
        '
        'Albumes_Button_Actualizar
        '
        Me.Albumes_Button_Actualizar.Enabled = False
        Me.Albumes_Button_Actualizar.Location = New System.Drawing.Point(365, 310)
        Me.Albumes_Button_Actualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.Albumes_Button_Actualizar.Name = "Albumes_Button_Actualizar"
        Me.Albumes_Button_Actualizar.Size = New System.Drawing.Size(112, 35)
        Me.Albumes_Button_Actualizar.TabIndex = 46
        Me.Albumes_Button_Actualizar.Text = "Actualizar"
        Me.Albumes_Button_Actualizar.UseVisualStyleBackColor = True
        '
        'Albumes_Button_Agregar
        '
        Me.Albumes_Button_Agregar.Location = New System.Drawing.Point(365, 256)
        Me.Albumes_Button_Agregar.Margin = New System.Windows.Forms.Padding(2)
        Me.Albumes_Button_Agregar.Name = "Albumes_Button_Agregar"
        Me.Albumes_Button_Agregar.Size = New System.Drawing.Size(112, 35)
        Me.Albumes_Button_Agregar.TabIndex = 45
        Me.Albumes_Button_Agregar.Text = "Agregar"
        Me.Albumes_Button_Agregar.UseVisualStyleBackColor = True
        '
        'Albumes_Button_VerTodosAlbumes
        '
        Me.Albumes_Button_VerTodosAlbumes.BackColor = System.Drawing.Color.MistyRose
        Me.Albumes_Button_VerTodosAlbumes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Albumes_Button_VerTodosAlbumes.Location = New System.Drawing.Point(27, 73)
        Me.Albumes_Button_VerTodosAlbumes.Name = "Albumes_Button_VerTodosAlbumes"
        Me.Albumes_Button_VerTodosAlbumes.Size = New System.Drawing.Size(154, 28)
        Me.Albumes_Button_VerTodosAlbumes.TabIndex = 49
        Me.Albumes_Button_VerTodosAlbumes.Text = "Ver todos los Albumes"
        Me.Albumes_Button_VerTodosAlbumes.UseVisualStyleBackColor = False
        Me.Albumes_Button_VerTodosAlbumes.UseWaitCursor = True
        '
        'Albumes_ListBox_Albumes
        '
        Me.Albumes_ListBox_Albumes.BackColor = System.Drawing.Color.White
        Me.Albumes_ListBox_Albumes.FormattingEnabled = True
        Me.Albumes_ListBox_Albumes.ItemHeight = 16
        Me.Albumes_ListBox_Albumes.Location = New System.Drawing.Point(27, 116)
        Me.Albumes_ListBox_Albumes.Name = "Albumes_ListBox_Albumes"
        Me.Albumes_ListBox_Albumes.Size = New System.Drawing.Size(267, 228)
        Me.Albumes_ListBox_Albumes.TabIndex = 50
        Me.Albumes_ListBox_Albumes.UseWaitCursor = True
        '
        'Albumes_TextBoxNombreAlbum
        '
        Me.Albumes_TextBoxNombreAlbum.Location = New System.Drawing.Point(347, 118)
        Me.Albumes_TextBoxNombreAlbum.Name = "Albumes_TextBoxNombreAlbum"
        Me.Albumes_TextBoxNombreAlbum.Size = New System.Drawing.Size(138, 22)
        Me.Albumes_TextBoxNombreAlbum.TabIndex = 51
        '
        'FormAlbumes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 374)
        Me.Controls.Add(Me.Albumes_TextBoxNombreAlbum)
        Me.Controls.Add(Me.Albumes_ListBox_Albumes)
        Me.Controls.Add(Me.Albumes_Button_VerTodosAlbumes)
        Me.Controls.Add(Me.Albumes_Button_Eliminar)
        Me.Controls.Add(Me.Albumes_Button_Limpiar)
        Me.Controls.Add(Me.Albumes_Button_Actualizar)
        Me.Controls.Add(Me.Albumes_Button_Agregar)
        Me.Controls.Add(Me.Albumes_LabelNombreArtista)
        Me.Controls.Add(Me.Albumes_ComboBoxArtistas)
        Me.Controls.Add(Me.Albumes_LabelListaAlbumes)
        Me.Controls.Add(Me.Albumes_TextBoxAñoAlbum)
        Me.Controls.Add(Me.Albumes_LabelAño)
        Me.Controls.Add(Me.Albumes_LabelNombre)
        Me.Controls.Add(Me.lblTitulo_Alb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormAlbumes"
        Me.Text = "FormAlbumes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo_Alb As Label
    Friend WithEvents Albumes_LabelNombre As Label
    Friend WithEvents Albumes_LabelAño As Label
    Friend WithEvents Albumes_TextBoxAñoAlbum As TextBox
    Friend WithEvents Albumes_LabelListaAlbumes As Label
    Friend WithEvents Albumes_LabelNombreArtista As Label
    Friend WithEvents Albumes_ComboBoxArtistas As ComboBox
    Friend WithEvents Albumes_Button_Eliminar As Button
    Friend WithEvents Albumes_Button_Limpiar As Button
    Friend WithEvents Albumes_Button_Actualizar As Button
    Friend WithEvents Albumes_Button_Agregar As Button
    Friend WithEvents Albumes_Button_VerTodosAlbumes As Button
    Friend WithEvents Albumes_ListBox_Albumes As ListBox
    Friend WithEvents Albumes_TextBoxNombreAlbum As TextBox
End Class
