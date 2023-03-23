<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabArtista = New System.Windows.Forms.TabPage()
        Me.Artista_labelPaisArtista = New System.Windows.Forms.Label()
        Me.Artista_textBoxPaisArtista = New System.Windows.Forms.TextBox()
        Me.Artista_labelNombreArtista = New System.Windows.Forms.Label()
        Me.Artista_textBoxNombreArtista = New System.Windows.Forms.TextBox()
        Me.Artista_buttonVerTodosArtistas = New System.Windows.Forms.Button()
        Me.Artista_labelArtistas = New System.Windows.Forms.Label()
        Me.Artista_ComboBoxArtistas = New System.Windows.Forms.ComboBox()
        Me.TabPaises = New System.Windows.Forms.TabPage()
        Me.Paises_TextBox_Agregar = New System.Windows.Forms.TextBox()
        Me.Paises_LabelAgregar = New System.Windows.Forms.Label()
        Me.Paises_ComboBox_Seleccionar = New System.Windows.Forms.ComboBox()
        Me.Paises_LabelSeleccionar = New System.Windows.Forms.Label()
        Me.TabAlbum = New System.Windows.Forms.TabPage()
        Me.Albumes_ButtonAñadirAlbum = New System.Windows.Forms.Button()
        Me.Albumes_ButtonAplicarCambios = New System.Windows.Forms.Button()
        Me.Albumes_LabelAñoAlbum = New System.Windows.Forms.Label()
        Me.Albumes_TextBoxAñoAlbum = New System.Windows.Forms.TextBox()
        Me.Albumes_LabelNombre = New System.Windows.Forms.Label()
        Me.Albumes_TextBoxNombreAlbum = New System.Windows.Forms.TextBox()
        Me.Albumes_ListBoxAlbumes = New System.Windows.Forms.ListBox()
        Me.Albumes_ButtonVerTodosLosArtistas = New System.Windows.Forms.Button()
        Me.Albumes_ComboBoxArtistas = New System.Windows.Forms.ComboBox()
        Me.TabConciertos = New System.Windows.Forms.TabPage()
        Me.Conciertos_LabelAlbumes = New System.Windows.Forms.Label()
        Me.Conciertos_LabelArtista = New System.Windows.Forms.Label()
        Me.TabCanciones = New System.Windows.Forms.TabPage()
        Me.TabSitio = New System.Windows.Forms.TabPage()
        Me.TabControl.SuspendLayout()
        Me.TabArtista.SuspendLayout()
        Me.TabPaises.SuspendLayout()
        Me.TabAlbum.SuspendLayout()
        Me.TabConciertos.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabArtista)
        Me.TabControl.Controls.Add(Me.TabPaises)
        Me.TabControl.Controls.Add(Me.TabAlbum)
        Me.TabControl.Controls.Add(Me.TabConciertos)
        Me.TabControl.Controls.Add(Me.TabCanciones)
        Me.TabControl.Controls.Add(Me.TabSitio)
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(635, 531)
        Me.TabControl.TabIndex = 0
        '
        'TabArtista
        '
        Me.TabArtista.Controls.Add(Me.Artista_labelPaisArtista)
        Me.TabArtista.Controls.Add(Me.Artista_textBoxPaisArtista)
        Me.TabArtista.Controls.Add(Me.Artista_labelNombreArtista)
        Me.TabArtista.Controls.Add(Me.Artista_textBoxNombreArtista)
        Me.TabArtista.Controls.Add(Me.Artista_buttonVerTodosArtistas)
        Me.TabArtista.Controls.Add(Me.Artista_labelArtistas)
        Me.TabArtista.Controls.Add(Me.Artista_ComboBoxArtistas)
        Me.TabArtista.Location = New System.Drawing.Point(4, 25)
        Me.TabArtista.Name = "TabArtista"
        Me.TabArtista.Padding = New System.Windows.Forms.Padding(3)
        Me.TabArtista.Size = New System.Drawing.Size(627, 502)
        Me.TabArtista.TabIndex = 1
        Me.TabArtista.Text = "Artista"
        Me.TabArtista.UseVisualStyleBackColor = True
        '
        'Artista_labelPaisArtista
        '
        Me.Artista_labelPaisArtista.AutoSize = True
        Me.Artista_labelPaisArtista.Location = New System.Drawing.Point(331, 91)
        Me.Artista_labelPaisArtista.Name = "Artista_labelPaisArtista"
        Me.Artista_labelPaisArtista.Size = New System.Drawing.Size(95, 16)
        Me.Artista_labelPaisArtista.TabIndex = 6
        Me.Artista_labelPaisArtista.Text = "País del artista"
        '
        'Artista_textBoxPaisArtista
        '
        Me.Artista_textBoxPaisArtista.Location = New System.Drawing.Point(317, 118)
        Me.Artista_textBoxPaisArtista.Name = "Artista_textBoxPaisArtista"
        Me.Artista_textBoxPaisArtista.Size = New System.Drawing.Size(256, 22)
        Me.Artista_textBoxPaisArtista.TabIndex = 5
        '
        'Artista_labelNombreArtista
        '
        Me.Artista_labelNombreArtista.AutoSize = True
        Me.Artista_labelNombreArtista.Location = New System.Drawing.Point(331, 25)
        Me.Artista_labelNombreArtista.Name = "Artista_labelNombreArtista"
        Me.Artista_labelNombreArtista.Size = New System.Drawing.Size(120, 16)
        Me.Artista_labelNombreArtista.TabIndex = 4
        Me.Artista_labelNombreArtista.Text = "Nombre del artista:"
        '
        'Artista_textBoxNombreArtista
        '
        Me.Artista_textBoxNombreArtista.Location = New System.Drawing.Point(317, 47)
        Me.Artista_textBoxNombreArtista.Name = "Artista_textBoxNombreArtista"
        Me.Artista_textBoxNombreArtista.Size = New System.Drawing.Size(256, 22)
        Me.Artista_textBoxNombreArtista.TabIndex = 3
        '
        'Artista_buttonVerTodosArtistas
        '
        Me.Artista_buttonVerTodosArtistas.Location = New System.Drawing.Point(112, 10)
        Me.Artista_buttonVerTodosArtistas.Name = "Artista_buttonVerTodosArtistas"
        Me.Artista_buttonVerTodosArtistas.Size = New System.Drawing.Size(154, 28)
        Me.Artista_buttonVerTodosArtistas.TabIndex = 2
        Me.Artista_buttonVerTodosArtistas.Text = "Ver todos los Artistas"
        Me.Artista_buttonVerTodosArtistas.UseVisualStyleBackColor = True
        '
        'Artista_labelArtistas
        '
        Me.Artista_labelArtistas.AutoSize = True
        Me.Artista_labelArtistas.Location = New System.Drawing.Point(43, 19)
        Me.Artista_labelArtistas.Name = "Artista_labelArtistas"
        Me.Artista_labelArtistas.Size = New System.Drawing.Size(54, 16)
        Me.Artista_labelArtistas.TabIndex = 1
        Me.Artista_labelArtistas.Text = "Artistas:"
        '
        'Artista_ComboBoxArtistas
        '
        Me.Artista_ComboBoxArtistas.FormattingEnabled = True
        Me.Artista_ComboBoxArtistas.Location = New System.Drawing.Point(22, 47)
        Me.Artista_ComboBoxArtistas.Name = "Artista_ComboBoxArtistas"
        Me.Artista_ComboBoxArtistas.Size = New System.Drawing.Size(256, 24)
        Me.Artista_ComboBoxArtistas.TabIndex = 0
        '
        'TabPaises
        '
        Me.TabPaises.Controls.Add(Me.Paises_TextBox_Agregar)
        Me.TabPaises.Controls.Add(Me.Paises_LabelAgregar)
        Me.TabPaises.Controls.Add(Me.Paises_ComboBox_Seleccionar)
        Me.TabPaises.Controls.Add(Me.Paises_LabelSeleccionar)
        Me.TabPaises.Location = New System.Drawing.Point(4, 25)
        Me.TabPaises.Name = "TabPaises"
        Me.TabPaises.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPaises.Size = New System.Drawing.Size(627, 502)
        Me.TabPaises.TabIndex = 0
        Me.TabPaises.Text = "Paises"
        Me.TabPaises.UseVisualStyleBackColor = True
        '
        'Paises_TextBox_Agregar
        '
        Me.Paises_TextBox_Agregar.Location = New System.Drawing.Point(195, 79)
        Me.Paises_TextBox_Agregar.Name = "Paises_TextBox_Agregar"
        Me.Paises_TextBox_Agregar.Size = New System.Drawing.Size(100, 22)
        Me.Paises_TextBox_Agregar.TabIndex = 3
        '
        'Paises_LabelAgregar
        '
        Me.Paises_LabelAgregar.AutoSize = True
        Me.Paises_LabelAgregar.Location = New System.Drawing.Point(21, 91)
        Me.Paises_LabelAgregar.Name = "Paises_LabelAgregar"
        Me.Paises_LabelAgregar.Size = New System.Drawing.Size(178, 16)
        Me.Paises_LabelAgregar.TabIndex = 2
        Me.Paises_LabelAgregar.Text = "¿Desea agregar algún pais?"
        '
        'Paises_ComboBox_Seleccionar
        '
        Me.Paises_ComboBox_Seleccionar.FormattingEnabled = True
        Me.Paises_ComboBox_Seleccionar.Location = New System.Drawing.Point(331, 31)
        Me.Paises_ComboBox_Seleccionar.Name = "Paises_ComboBox_Seleccionar"
        Me.Paises_ComboBox_Seleccionar.Size = New System.Drawing.Size(121, 24)
        Me.Paises_ComboBox_Seleccionar.TabIndex = 1
        '
        'Paises_LabelSeleccionar
        '
        Me.Paises_LabelSeleccionar.AutoSize = True
        Me.Paises_LabelSeleccionar.Location = New System.Drawing.Point(21, 34)
        Me.Paises_LabelSeleccionar.Name = "Paises_LabelSeleccionar"
        Me.Paises_LabelSeleccionar.Size = New System.Drawing.Size(307, 16)
        Me.Paises_LabelSeleccionar.TabIndex = 0
        Me.Paises_LabelSeleccionar.Text = "Selecciones el pais en el cual va a buscar artistas:"
        '
        'TabAlbum
        '
        Me.TabAlbum.Controls.Add(Me.Albumes_ButtonAñadirAlbum)
        Me.TabAlbum.Controls.Add(Me.Albumes_ButtonAplicarCambios)
        Me.TabAlbum.Controls.Add(Me.Albumes_LabelAñoAlbum)
        Me.TabAlbum.Controls.Add(Me.Albumes_TextBoxAñoAlbum)
        Me.TabAlbum.Controls.Add(Me.Albumes_LabelNombre)
        Me.TabAlbum.Controls.Add(Me.Albumes_TextBoxNombreAlbum)
        Me.TabAlbum.Controls.Add(Me.Albumes_ListBoxAlbumes)
        Me.TabAlbum.Controls.Add(Me.Albumes_ButtonVerTodosLosArtistas)
        Me.TabAlbum.Controls.Add(Me.Albumes_ComboBoxArtistas)
        Me.TabAlbum.Location = New System.Drawing.Point(4, 25)
        Me.TabAlbum.Name = "TabAlbum"
        Me.TabAlbum.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAlbum.Size = New System.Drawing.Size(627, 502)
        Me.TabAlbum.TabIndex = 2
        Me.TabAlbum.Text = "Albumes"
        Me.TabAlbum.UseVisualStyleBackColor = True
        '
        'Albumes_ButtonAñadirAlbum
        '
        Me.Albumes_ButtonAñadirAlbum.Location = New System.Drawing.Point(180, 399)
        Me.Albumes_ButtonAñadirAlbum.Name = "Albumes_ButtonAñadirAlbum"
        Me.Albumes_ButtonAñadirAlbum.Size = New System.Drawing.Size(119, 44)
        Me.Albumes_ButtonAñadirAlbum.TabIndex = 13
        Me.Albumes_ButtonAñadirAlbum.Text = "Añadir álbum"
        Me.Albumes_ButtonAñadirAlbum.UseVisualStyleBackColor = True
        '
        'Albumes_ButtonAplicarCambios
        '
        Me.Albumes_ButtonAplicarCambios.Location = New System.Drawing.Point(43, 399)
        Me.Albumes_ButtonAplicarCambios.Name = "Albumes_ButtonAplicarCambios"
        Me.Albumes_ButtonAplicarCambios.Size = New System.Drawing.Size(119, 44)
        Me.Albumes_ButtonAplicarCambios.TabIndex = 12
        Me.Albumes_ButtonAplicarCambios.Text = "Aplicar cambios"
        Me.Albumes_ButtonAplicarCambios.UseVisualStyleBackColor = True
        '
        'Albumes_LabelAñoAlbum
        '
        Me.Albumes_LabelAñoAlbum.AutoSize = True
        Me.Albumes_LabelAñoAlbum.Location = New System.Drawing.Point(57, 317)
        Me.Albumes_LabelAñoAlbum.Name = "Albumes_LabelAñoAlbum"
        Me.Albumes_LabelAñoAlbum.Size = New System.Drawing.Size(71, 16)
        Me.Albumes_LabelAñoAlbum.TabIndex = 11
        Me.Albumes_LabelAñoAlbum.Text = "Año álbum"
        '
        'Albumes_TextBoxAñoAlbum
        '
        Me.Albumes_TextBoxAñoAlbum.Location = New System.Drawing.Point(43, 344)
        Me.Albumes_TextBoxAñoAlbum.Name = "Albumes_TextBoxAñoAlbum"
        Me.Albumes_TextBoxAñoAlbum.Size = New System.Drawing.Size(256, 22)
        Me.Albumes_TextBoxAñoAlbum.TabIndex = 10
        '
        'Albumes_LabelNombre
        '
        Me.Albumes_LabelNombre.AutoSize = True
        Me.Albumes_LabelNombre.Location = New System.Drawing.Point(57, 251)
        Me.Albumes_LabelNombre.Name = "Albumes_LabelNombre"
        Me.Albumes_LabelNombre.Size = New System.Drawing.Size(118, 16)
        Me.Albumes_LabelNombre.TabIndex = 9
        Me.Albumes_LabelNombre.Text = "Nombre del álbum"
        '
        'Albumes_TextBoxNombreAlbum
        '
        Me.Albumes_TextBoxNombreAlbum.Location = New System.Drawing.Point(43, 273)
        Me.Albumes_TextBoxNombreAlbum.Name = "Albumes_TextBoxNombreAlbum"
        Me.Albumes_TextBoxNombreAlbum.Size = New System.Drawing.Size(256, 22)
        Me.Albumes_TextBoxNombreAlbum.TabIndex = 8
        '
        'Albumes_ListBoxAlbumes
        '
        Me.Albumes_ListBoxAlbumes.FormattingEnabled = True
        Me.Albumes_ListBoxAlbumes.ItemHeight = 16
        Me.Albumes_ListBoxAlbumes.Location = New System.Drawing.Point(385, 61)
        Me.Albumes_ListBoxAlbumes.Name = "Albumes_ListBoxAlbumes"
        Me.Albumes_ListBoxAlbumes.Size = New System.Drawing.Size(150, 260)
        Me.Albumes_ListBoxAlbumes.TabIndex = 6
        '
        'Albumes_ButtonVerTodosLosArtistas
        '
        Me.Albumes_ButtonVerTodosLosArtistas.Location = New System.Drawing.Point(133, 24)
        Me.Albumes_ButtonVerTodosLosArtistas.Name = "Albumes_ButtonVerTodosLosArtistas"
        Me.Albumes_ButtonVerTodosLosArtistas.Size = New System.Drawing.Size(154, 28)
        Me.Albumes_ButtonVerTodosLosArtistas.TabIndex = 5
        Me.Albumes_ButtonVerTodosLosArtistas.Text = "Ver todos los Artistas"
        Me.Albumes_ButtonVerTodosLosArtistas.UseVisualStyleBackColor = True
        '
        'Albumes_ComboBoxArtistas
        '
        Me.Albumes_ComboBoxArtistas.FormattingEnabled = True
        Me.Albumes_ComboBoxArtistas.Location = New System.Drawing.Point(43, 61)
        Me.Albumes_ComboBoxArtistas.Name = "Albumes_ComboBoxArtistas"
        Me.Albumes_ComboBoxArtistas.Size = New System.Drawing.Size(256, 24)
        Me.Albumes_ComboBoxArtistas.TabIndex = 3
        '
        'TabConciertos
        '
        Me.TabConciertos.Controls.Add(Me.Conciertos_LabelAlbumes)
        Me.TabConciertos.Controls.Add(Me.Conciertos_LabelArtista)
        Me.TabConciertos.Location = New System.Drawing.Point(4, 25)
        Me.TabConciertos.Name = "TabConciertos"
        Me.TabConciertos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabConciertos.Size = New System.Drawing.Size(627, 502)
        Me.TabConciertos.TabIndex = 3
        Me.TabConciertos.Text = "Conciertos"
        Me.TabConciertos.UseVisualStyleBackColor = True
        '
        'Conciertos_LabelAlbumes
        '
        Me.Conciertos_LabelAlbumes.AutoSize = True
        Me.Conciertos_LabelAlbumes.Location = New System.Drawing.Point(428, 39)
        Me.Conciertos_LabelAlbumes.Name = "Conciertos_LabelAlbumes"
        Me.Conciertos_LabelAlbumes.Size = New System.Drawing.Size(63, 16)
        Me.Conciertos_LabelAlbumes.TabIndex = 7
        Me.Conciertos_LabelAlbumes.Text = "Álbumes:"
        '
        'Conciertos_LabelArtista
        '
        Me.Conciertos_LabelArtista.AutoSize = True
        Me.Conciertos_LabelArtista.Location = New System.Drawing.Point(67, 36)
        Me.Conciertos_LabelArtista.Name = "Conciertos_LabelArtista"
        Me.Conciertos_LabelArtista.Size = New System.Drawing.Size(54, 16)
        Me.Conciertos_LabelArtista.TabIndex = 4
        Me.Conciertos_LabelArtista.Text = "Artistas:"
        '
        'TabCanciones
        '
        Me.TabCanciones.Location = New System.Drawing.Point(4, 25)
        Me.TabCanciones.Name = "TabCanciones"
        Me.TabCanciones.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCanciones.Size = New System.Drawing.Size(627, 502)
        Me.TabCanciones.TabIndex = 4
        Me.TabCanciones.Text = "Canciones"
        Me.TabCanciones.UseVisualStyleBackColor = True
        '
        'TabSitio
        '
        Me.TabSitio.Location = New System.Drawing.Point(4, 25)
        Me.TabSitio.Name = "TabSitio"
        Me.TabSitio.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSitio.Size = New System.Drawing.Size(627, 502)
        Me.TabSitio.TabIndex = 5
        Me.TabSitio.Text = "Sitio"
        Me.TabSitio.UseVisualStyleBackColor = True
        '
        'FormularioPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 539)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "FormularioPrincipal"
        Me.Text = "Aplicación BBDD"
        Me.TabControl.ResumeLayout(False)
        Me.TabArtista.ResumeLayout(False)
        Me.TabArtista.PerformLayout()
        Me.TabPaises.ResumeLayout(False)
        Me.TabPaises.PerformLayout()
        Me.TabAlbum.ResumeLayout(False)
        Me.TabAlbum.PerformLayout()
        Me.TabConciertos.ResumeLayout(False)
        Me.TabConciertos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl



    Friend WithEvents TabPaises As TabPage
    Friend WithEvents TabArtista As TabPage
    Friend WithEvents TabAlbum As TabPage
    Friend WithEvents TabConciertos As TabPage
    Friend WithEvents TabCanciones As TabPage
    Friend WithEvents TabSitio As TabPage



    Friend WithEvents Paises_LabelSeleccionar As Label
    Friend WithEvents Paises_ComboBox_Seleccionar As ComboBox
    Friend WithEvents Paises_TextBox_Agregar As TextBox
    Friend WithEvents Paises_LabelAgregar As Label



    Friend WithEvents Artista_labelArtistas As Label
    Friend WithEvents Artista_ComboBoxArtistas As ComboBox
    Friend WithEvents Artista_labelNombreArtista As Label
    Friend WithEvents Artista_textBoxNombreArtista As TextBox
    Friend WithEvents Artista_buttonVerTodosArtistas As Button
    Friend WithEvents Artista_labelPaisArtista As Label
    Friend WithEvents Artista_textBoxPaisArtista As TextBox



    Friend WithEvents Conciertos_LabelArtista As Label
    Friend WithEvents Conciertos_LabelAlbumes As Label



    Friend WithEvents Albumes_ListBoxAlbumes As ListBox
    Friend WithEvents Albumes_ButtonVerTodosLosArtistas As Button
    Friend WithEvents Albumes_ComboBoxArtistas As ComboBox
    Friend WithEvents Albumes_ButtonAplicarCambios As Button
    Friend WithEvents Albumes_LabelAñoAlbum As Label
    Friend WithEvents Albumes_TextBoxAñoAlbum As TextBox
    Friend WithEvents Albumes_LabelNombre As Label
    Friend WithEvents Albumes_TextBoxNombreAlbum As TextBox
    Friend WithEvents Albumes_ButtonAñadirAlbum As Button



End Class
