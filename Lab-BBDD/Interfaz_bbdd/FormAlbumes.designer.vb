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
        Me.Albumes_TextBoxNombreAlbum = New System.Windows.Forms.TextBox()
        Me.Albumes_TextBoxAñoAlbum = New System.Windows.Forms.TextBox()
        Me.Albumes_LabelListaAlbumes = New System.Windows.Forms.Label()
        Me.Albumes_ListBoxAlbumes = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Albumes_LabelNombreArtista = New System.Windows.Forms.Label()
        Me.Albumes_ComboBoxArtistas = New System.Windows.Forms.ComboBox()
        Me.Artistas_Button_Eliminar = New System.Windows.Forms.Button()
        Me.Artistas_Button_Limpiar = New System.Windows.Forms.Button()
        Me.Artistas_Button_Actualizar = New System.Windows.Forms.Button()
        Me.Artistas_Button_Agregar = New System.Windows.Forms.Button()
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
        'Albumes_TextBoxNombreAlbum
        '
        Me.Albumes_TextBoxNombreAlbum.Location = New System.Drawing.Point(347, 118)
        Me.Albumes_TextBoxNombreAlbum.Margin = New System.Windows.Forms.Padding(2)
        Me.Albumes_TextBoxNombreAlbum.Name = "Albumes_TextBoxNombreAlbum"
        Me.Albumes_TextBoxNombreAlbum.Size = New System.Drawing.Size(150, 22)
        Me.Albumes_TextBoxNombreAlbum.TabIndex = 33
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
        'Albumes_ListBoxAlbumes
        '
        Me.Albumes_ListBoxAlbumes.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Albumes_ListBoxAlbumes.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Albumes_ListBoxAlbumes.FormattingEnabled = True
        Me.Albumes_ListBoxAlbumes.ItemHeight = 16
        Me.Albumes_ListBoxAlbumes.Location = New System.Drawing.Point(27, 118)
        Me.Albumes_ListBoxAlbumes.Name = "Albumes_ListBoxAlbumes"
        Me.Albumes_ListBoxAlbumes.Size = New System.Drawing.Size(235, 196)
        Me.Albumes_ListBoxAlbumes.TabIndex = 40
        Me.Albumes_ListBoxAlbumes.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Albumes"
        Me.Label1.UseWaitCursor = True
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
        'Artistas_Button_Eliminar
        '
        Me.Artistas_Button_Eliminar.Enabled = False
        Me.Artistas_Button_Eliminar.Location = New System.Drawing.Point(545, 256)
        Me.Artistas_Button_Eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.Artistas_Button_Eliminar.Name = "Artistas_Button_Eliminar"
        Me.Artistas_Button_Eliminar.Size = New System.Drawing.Size(106, 35)
        Me.Artistas_Button_Eliminar.TabIndex = 48
        Me.Artistas_Button_Eliminar.Text = "Eliminar"
        Me.Artistas_Button_Eliminar.UseVisualStyleBackColor = True
        '
        'Artistas_Button_Limpiar
        '
        Me.Artistas_Button_Limpiar.Location = New System.Drawing.Point(545, 310)
        Me.Artistas_Button_Limpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.Artistas_Button_Limpiar.Name = "Artistas_Button_Limpiar"
        Me.Artistas_Button_Limpiar.Size = New System.Drawing.Size(106, 35)
        Me.Artistas_Button_Limpiar.TabIndex = 47
        Me.Artistas_Button_Limpiar.Text = "Limpiar"
        Me.Artistas_Button_Limpiar.UseVisualStyleBackColor = True
        '
        'Artistas_Button_Actualizar
        '
        Me.Artistas_Button_Actualizar.Enabled = False
        Me.Artistas_Button_Actualizar.Location = New System.Drawing.Point(365, 310)
        Me.Artistas_Button_Actualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.Artistas_Button_Actualizar.Name = "Artistas_Button_Actualizar"
        Me.Artistas_Button_Actualizar.Size = New System.Drawing.Size(112, 35)
        Me.Artistas_Button_Actualizar.TabIndex = 46
        Me.Artistas_Button_Actualizar.Text = "Actualizar"
        Me.Artistas_Button_Actualizar.UseVisualStyleBackColor = True
        '
        'Artistas_Button_Agregar
        '
        Me.Artistas_Button_Agregar.Location = New System.Drawing.Point(365, 256)
        Me.Artistas_Button_Agregar.Margin = New System.Windows.Forms.Padding(2)
        Me.Artistas_Button_Agregar.Name = "Artistas_Button_Agregar"
        Me.Artistas_Button_Agregar.Size = New System.Drawing.Size(112, 35)
        Me.Artistas_Button_Agregar.TabIndex = 45
        Me.Artistas_Button_Agregar.Text = "Agregar"
        Me.Artistas_Button_Agregar.UseVisualStyleBackColor = True
        '
        'FormAlbumes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 374)
        Me.Controls.Add(Me.Artistas_Button_Eliminar)
        Me.Controls.Add(Me.Artistas_Button_Limpiar)
        Me.Controls.Add(Me.Artistas_Button_Actualizar)
        Me.Controls.Add(Me.Artistas_Button_Agregar)
        Me.Controls.Add(Me.Albumes_LabelNombreArtista)
        Me.Controls.Add(Me.Albumes_ComboBoxArtistas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Albumes_LabelListaAlbumes)
        Me.Controls.Add(Me.Albumes_ListBoxAlbumes)
        Me.Controls.Add(Me.Albumes_TextBoxAñoAlbum)
        Me.Controls.Add(Me.Albumes_TextBoxNombreAlbum)
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
    Friend WithEvents Albumes_TextBoxNombreAlbum As TextBox
    Friend WithEvents Albumes_TextBoxAñoAlbum As TextBox
    Friend WithEvents Albumes_LabelListaAlbumes As Label
    Friend WithEvents Albumes_ListBoxAlbumes As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Albumes_LabelNombreArtista As Label
    Friend WithEvents Albumes_ComboBoxArtistas As ComboBox
    Friend WithEvents Artistas_Button_Eliminar As Button
    Friend WithEvents Artistas_Button_Limpiar As Button
    Friend WithEvents Artistas_Button_Actualizar As Button
    Friend WithEvents Artistas_Button_Agregar As Button
End Class
