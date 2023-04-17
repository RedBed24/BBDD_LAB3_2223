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
        Me.TabArtistas = New System.Windows.Forms.TabPage()
        Me.Artistas_ComboBox_PaisArtista = New System.Windows.Forms.ComboBox()
        Me.Artistas_ListBox_Artistas = New System.Windows.Forms.ListBox()
        Me.Artistas_Button_Limpiar = New System.Windows.Forms.Button()
        Me.Artistas_Button_Eliminar = New System.Windows.Forms.Button()
        Me.Artistas_Button_Agregar = New System.Windows.Forms.Button()
        Me.Artistas_Button_Actualizar = New System.Windows.Forms.Button()
        Me.Artistas_Label_PaisArtista = New System.Windows.Forms.Label()
        Me.Artistas_Label_NombreArtista = New System.Windows.Forms.Label()
        Me.Artistas_TextBox_NombreArtista = New System.Windows.Forms.TextBox()
        Me.Artistas_Button_VerTodosArtistas = New System.Windows.Forms.Button()
        Me.Artistas_Label_Artistas = New System.Windows.Forms.Label()
        Me.TabPaises = New System.Windows.Forms.TabPage()
        Me.Paises_TextBox_NombrePais = New System.Windows.Forms.TextBox()
        Me.Paises_Label_Nombre = New System.Windows.Forms.Label()
        Me.Paises_Label_Paises = New System.Windows.Forms.Label()
        Me.Paises_Button_VerTodosPaises = New System.Windows.Forms.Button()
        Me.Paises_ListBox_Paises = New System.Windows.Forms.ListBox()
        Me.Paises_Button_Limpiar = New System.Windows.Forms.Button()
        Me.Paises_Button_Eliminar = New System.Windows.Forms.Button()
        Me.Paises_Button_Agregar = New System.Windows.Forms.Button()
        Me.Paises_Button_Actualizar = New System.Windows.Forms.Button()
        Me.TabAlbum = New System.Windows.Forms.TabPage()
        Me.Albumes_LabelListaAlbumes = New System.Windows.Forms.Label()
        Me.Albumes_LabelNombreArtista = New System.Windows.Forms.Label()
        Me.Albumes_ButtonLimpiar = New System.Windows.Forms.Button()
        Me.Albumes_ButtonEliminar = New System.Windows.Forms.Button()
        Me.Albumes_ButtonAgregar = New System.Windows.Forms.Button()
        Me.Albumes_ButtonActualizar = New System.Windows.Forms.Button()
        Me.Albumes_LabelAñoAlbum = New System.Windows.Forms.Label()
        Me.Albumes_TextBoxAñoAlbum = New System.Windows.Forms.TextBox()
        Me.Albumes_LabelNombre = New System.Windows.Forms.Label()
        Me.Albumes_TextBoxNombreAlbum = New System.Windows.Forms.TextBox()
        Me.Albumes_ListBoxAlbumes = New System.Windows.Forms.ListBox()
        Me.Albumes_ComboBoxArtistas = New System.Windows.Forms.ComboBox()
        Me.TabConciertos = New System.Windows.Forms.TabPage()
        Me.Conciertos_MonthCalendar_FechaConcierto = New System.Windows.Forms.MonthCalendar()
        Me.Conciertos_ListBoxTodosLosConciertos = New System.Windows.Forms.ListBox()
        Me.Conciertos_LabelArtistaActua = New System.Windows.Forms.Label()
        Me.Conciertos_ButtonLimpiar = New System.Windows.Forms.Button()
        Me.Conciertos_ButtonEliminar = New System.Windows.Forms.Button()
        Me.Conciertos_ButtonAgregar = New System.Windows.Forms.Button()
        Me.Conciertos_ButtonActualizar = New System.Windows.Forms.Button()
        Me.Conciertos_ComboBoxSitiosDondeHayConcierto = New System.Windows.Forms.ComboBox()
        Me.Conciertos_LabelSitiosDondeHayConciertos = New System.Windows.Forms.Label()
        Me.Conciertos_LabelArtistasActuan = New System.Windows.Forms.Label()
        Me.Conciertos_ComboBoxArtistaActua = New System.Windows.Forms.ComboBox()
        Me.Conciertos_LabelArtistas = New System.Windows.Forms.Label()
        Me.TabCanciones = New System.Windows.Forms.TabPage()
        Me.Canciones_TextBoxDuracionCanciones = New System.Windows.Forms.TextBox()
        Me.Canciones_LabelDuracion = New System.Windows.Forms.Label()
        Me.Canciones_TextBoxNombreCanciones = New System.Windows.Forms.TextBox()
        Me.Canciones_ListBoxTodasLasCanciones = New System.Windows.Forms.ListBox()
        Me.Canciones_ButtonLimpiar = New System.Windows.Forms.Button()
        Me.Canciones_ButtonEliminar = New System.Windows.Forms.Button()
        Me.Canciones_ButtonAgregar = New System.Windows.Forms.Button()
        Me.Canciones_ButtonActualizar = New System.Windows.Forms.Button()
        Me.Canciones_LabelNombreCancion = New System.Windows.Forms.Label()
        Me.TabSitio = New System.Windows.Forms.TabPage()
        Me.Sitios_Label_Tipo = New System.Windows.Forms.Label()
        Me.Sitios_ComboBox_TipoSitio = New System.Windows.Forms.ComboBox()
        Me.Sitios_ComboBox_PaisSitio = New System.Windows.Forms.ComboBox()
        Me.Sitios_ListBox_Sitios = New System.Windows.Forms.ListBox()
        Me.Sitios_Button_Limpiar = New System.Windows.Forms.Button()
        Me.Sitios_Button_Eliminar = New System.Windows.Forms.Button()
        Me.Sitios_Button_Agregar = New System.Windows.Forms.Button()
        Me.Sitios_Button_Actualizar = New System.Windows.Forms.Button()
        Me.Sitios_Label_PaisSitio = New System.Windows.Forms.Label()
        Me.Sitios_Label_NombreSitio = New System.Windows.Forms.Label()
        Me.Sitios_TextBox_NombreSitio = New System.Windows.Forms.TextBox()
        Me.Sitios_Button_VerTodosSitios = New System.Windows.Forms.Button()
        Me.Sitios_Label_Sitios = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Canciones_LabelArtista = New System.Windows.Forms.Label()
        Me.Canciones_comboBoxArtista = New System.Windows.Forms.ComboBox()
        Me.Canciones_LabelCanciones = New System.Windows.Forms.Label()
        Me.TabControl.SuspendLayout()
        Me.TabArtistas.SuspendLayout()
        Me.TabPaises.SuspendLayout()
        Me.TabAlbum.SuspendLayout()
        Me.TabConciertos.SuspendLayout()
        Me.TabCanciones.SuspendLayout()
        Me.TabSitio.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabArtistas)
        Me.TabControl.Controls.Add(Me.TabPaises)
        Me.TabControl.Controls.Add(Me.TabAlbum)
        Me.TabControl.Controls.Add(Me.TabConciertos)
        Me.TabControl.Controls.Add(Me.TabCanciones)
        Me.TabControl.Controls.Add(Me.TabSitio)
        Me.TabControl.Location = New System.Drawing.Point(0, -4)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(635, 531)
        Me.TabControl.TabIndex = 0
        Me.TabControl.UseWaitCursor = True
        '
        'TabArtistas
        '
        Me.TabArtistas.Controls.Add(Me.Artistas_ComboBox_PaisArtista)
        Me.TabArtistas.Controls.Add(Me.Artistas_ListBox_Artistas)
        Me.TabArtistas.Controls.Add(Me.Artistas_Button_Limpiar)
        Me.TabArtistas.Controls.Add(Me.Artistas_Button_Eliminar)
        Me.TabArtistas.Controls.Add(Me.Artistas_Button_Agregar)
        Me.TabArtistas.Controls.Add(Me.Artistas_Button_Actualizar)
        Me.TabArtistas.Controls.Add(Me.Artistas_Label_PaisArtista)
        Me.TabArtistas.Controls.Add(Me.Artistas_Label_NombreArtista)
        Me.TabArtistas.Controls.Add(Me.Artistas_TextBox_NombreArtista)
        Me.TabArtistas.Controls.Add(Me.Artistas_Button_VerTodosArtistas)
        Me.TabArtistas.Controls.Add(Me.Artistas_Label_Artistas)
        Me.TabArtistas.Location = New System.Drawing.Point(4, 25)
        Me.TabArtistas.Name = "TabArtistas"
        Me.TabArtistas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabArtistas.Size = New System.Drawing.Size(627, 502)
        Me.TabArtistas.TabIndex = 1
        Me.TabArtistas.Text = "Artistas"
        Me.TabArtistas.UseVisualStyleBackColor = True
        Me.TabArtistas.UseWaitCursor = True
        '
        'Artistas_ComboBox_PaisArtista
        '
        Me.Artistas_ComboBox_PaisArtista.FormattingEnabled = True
        Me.Artistas_ComboBox_PaisArtista.Location = New System.Drawing.Point(333, 193)
        Me.Artistas_ComboBox_PaisArtista.Name = "Artistas_ComboBox_PaisArtista"
        Me.Artistas_ComboBox_PaisArtista.Size = New System.Drawing.Size(256, 24)
        Me.Artistas_ComboBox_PaisArtista.TabIndex = 12
        Me.Artistas_ComboBox_PaisArtista.UseWaitCursor = True
        '
        'Artistas_ListBox_Artistas
        '
        Me.Artistas_ListBox_Artistas.BackColor = System.Drawing.SystemColors.Control
        Me.Artistas_ListBox_Artistas.FormattingEnabled = True
        Me.Artistas_ListBox_Artistas.ItemHeight = 16
        Me.Artistas_ListBox_Artistas.Location = New System.Drawing.Point(29, 49)
        Me.Artistas_ListBox_Artistas.Name = "Artistas_ListBox_Artistas"
        Me.Artistas_ListBox_Artistas.Size = New System.Drawing.Size(267, 228)
        Me.Artistas_ListBox_Artistas.TabIndex = 11
        Me.Artistas_ListBox_Artistas.UseWaitCursor = True
        '
        'Artistas_Button_Limpiar
        '
        Me.Artistas_Button_Limpiar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Artistas_Button_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Artistas_Button_Limpiar.Location = New System.Drawing.Point(166, 380)
        Me.Artistas_Button_Limpiar.Name = "Artistas_Button_Limpiar"
        Me.Artistas_Button_Limpiar.Size = New System.Drawing.Size(130, 52)
        Me.Artistas_Button_Limpiar.TabIndex = 10
        Me.Artistas_Button_Limpiar.Text = "LIMPIAR"
        Me.Artistas_Button_Limpiar.UseVisualStyleBackColor = False
        Me.Artistas_Button_Limpiar.UseWaitCursor = True
        '
        'Artistas_Button_Eliminar
        '
        Me.Artistas_Button_Eliminar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Artistas_Button_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Artistas_Button_Eliminar.Location = New System.Drawing.Point(29, 380)
        Me.Artistas_Button_Eliminar.Name = "Artistas_Button_Eliminar"
        Me.Artistas_Button_Eliminar.Size = New System.Drawing.Size(130, 52)
        Me.Artistas_Button_Eliminar.TabIndex = 9
        Me.Artistas_Button_Eliminar.Text = "ELIMINAR"
        Me.Artistas_Button_Eliminar.UseVisualStyleBackColor = False
        Me.Artistas_Button_Eliminar.UseWaitCursor = True
        '
        'Artistas_Button_Agregar
        '
        Me.Artistas_Button_Agregar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Artistas_Button_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Artistas_Button_Agregar.Location = New System.Drawing.Point(166, 319)
        Me.Artistas_Button_Agregar.Name = "Artistas_Button_Agregar"
        Me.Artistas_Button_Agregar.Size = New System.Drawing.Size(130, 52)
        Me.Artistas_Button_Agregar.TabIndex = 8
        Me.Artistas_Button_Agregar.Text = "AGREGAR"
        Me.Artistas_Button_Agregar.UseVisualStyleBackColor = False
        Me.Artistas_Button_Agregar.UseWaitCursor = True
        '
        'Artistas_Button_Actualizar
        '
        Me.Artistas_Button_Actualizar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Artistas_Button_Actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Artistas_Button_Actualizar.Location = New System.Drawing.Point(29, 319)
        Me.Artistas_Button_Actualizar.Name = "Artistas_Button_Actualizar"
        Me.Artistas_Button_Actualizar.Size = New System.Drawing.Size(130, 52)
        Me.Artistas_Button_Actualizar.TabIndex = 7
        Me.Artistas_Button_Actualizar.Text = "ACTUALIZAR"
        Me.Artistas_Button_Actualizar.UseVisualStyleBackColor = False
        Me.Artistas_Button_Actualizar.UseWaitCursor = True
        '
        'Artistas_Label_PaisArtista
        '
        Me.Artistas_Label_PaisArtista.AutoSize = True
        Me.Artistas_Label_PaisArtista.Location = New System.Drawing.Point(347, 161)
        Me.Artistas_Label_PaisArtista.Name = "Artistas_Label_PaisArtista"
        Me.Artistas_Label_PaisArtista.Size = New System.Drawing.Size(98, 16)
        Me.Artistas_Label_PaisArtista.TabIndex = 6
        Me.Artistas_Label_PaisArtista.Text = "País del artista:"
        Me.Artistas_Label_PaisArtista.UseWaitCursor = True
        '
        'Artistas_Label_NombreArtista
        '
        Me.Artistas_Label_NombreArtista.AutoSize = True
        Me.Artistas_Label_NombreArtista.Location = New System.Drawing.Point(347, 95)
        Me.Artistas_Label_NombreArtista.Name = "Artistas_Label_NombreArtista"
        Me.Artistas_Label_NombreArtista.Size = New System.Drawing.Size(120, 16)
        Me.Artistas_Label_NombreArtista.TabIndex = 4
        Me.Artistas_Label_NombreArtista.Text = "Nombre del artista:"
        Me.Artistas_Label_NombreArtista.UseWaitCursor = True
        '
        'Artistas_TextBox_NombreArtista
        '
        Me.Artistas_TextBox_NombreArtista.Location = New System.Drawing.Point(333, 117)
        Me.Artistas_TextBox_NombreArtista.Name = "Artistas_TextBox_NombreArtista"
        Me.Artistas_TextBox_NombreArtista.Size = New System.Drawing.Size(256, 22)
        Me.Artistas_TextBox_NombreArtista.TabIndex = 3
        Me.Artistas_TextBox_NombreArtista.UseWaitCursor = True
        '
        'Artistas_Button_VerTodosArtistas
        '
        Me.Artistas_Button_VerTodosArtistas.BackColor = System.Drawing.Color.MistyRose
        Me.Artistas_Button_VerTodosArtistas.Location = New System.Drawing.Point(112, 10)
        Me.Artistas_Button_VerTodosArtistas.Name = "Artistas_Button_VerTodosArtistas"
        Me.Artistas_Button_VerTodosArtistas.Size = New System.Drawing.Size(154, 28)
        Me.Artistas_Button_VerTodosArtistas.TabIndex = 2
        Me.Artistas_Button_VerTodosArtistas.Text = "Ver todos los Artistas"
        Me.Artistas_Button_VerTodosArtistas.UseVisualStyleBackColor = False
        Me.Artistas_Button_VerTodosArtistas.UseWaitCursor = True
        '
        'Artistas_Label_Artistas
        '
        Me.Artistas_Label_Artistas.AutoSize = True
        Me.Artistas_Label_Artistas.Location = New System.Drawing.Point(43, 19)
        Me.Artistas_Label_Artistas.Name = "Artistas_Label_Artistas"
        Me.Artistas_Label_Artistas.Size = New System.Drawing.Size(54, 16)
        Me.Artistas_Label_Artistas.TabIndex = 1
        Me.Artistas_Label_Artistas.Text = "Artistas:"
        Me.Artistas_Label_Artistas.UseWaitCursor = True
        '
        'TabPaises
        '
        Me.TabPaises.Controls.Add(Me.Paises_TextBox_NombrePais)
        Me.TabPaises.Controls.Add(Me.Paises_Label_Nombre)
        Me.TabPaises.Controls.Add(Me.Paises_Label_Paises)
        Me.TabPaises.Controls.Add(Me.Paises_Button_VerTodosPaises)
        Me.TabPaises.Controls.Add(Me.Paises_ListBox_Paises)
        Me.TabPaises.Controls.Add(Me.Paises_Button_Limpiar)
        Me.TabPaises.Controls.Add(Me.Paises_Button_Eliminar)
        Me.TabPaises.Controls.Add(Me.Paises_Button_Agregar)
        Me.TabPaises.Controls.Add(Me.Paises_Button_Actualizar)
        Me.TabPaises.Location = New System.Drawing.Point(4, 25)
        Me.TabPaises.Name = "TabPaises"
        Me.TabPaises.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPaises.Size = New System.Drawing.Size(627, 502)
        Me.TabPaises.TabIndex = 0
        Me.TabPaises.Text = "Paises"
        Me.TabPaises.UseVisualStyleBackColor = True
        Me.TabPaises.UseWaitCursor = True
        '
        'Paises_TextBox_NombrePais
        '
        Me.Paises_TextBox_NombrePais.Location = New System.Drawing.Point(334, 49)
        Me.Paises_TextBox_NombrePais.Name = "Paises_TextBox_NombrePais"
        Me.Paises_TextBox_NombrePais.Size = New System.Drawing.Size(256, 22)
        Me.Paises_TextBox_NombrePais.TabIndex = 12
        Me.Paises_TextBox_NombrePais.UseWaitCursor = True
        '
        'Paises_Label_Nombre
        '
        Me.Paises_Label_Nombre.AutoSize = True
        Me.Paises_Label_Nombre.Location = New System.Drawing.Point(348, 27)
        Me.Paises_Label_Nombre.Name = "Paises_Label_Nombre"
        Me.Paises_Label_Nombre.Size = New System.Drawing.Size(111, 16)
        Me.Paises_Label_Nombre.TabIndex = 11
        Me.Paises_Label_Nombre.Text = "Nombre del País:"
        Me.Paises_Label_Nombre.UseWaitCursor = True
        '
        'Paises_Label_Paises
        '
        Me.Paises_Label_Paises.AutoSize = True
        Me.Paises_Label_Paises.Location = New System.Drawing.Point(43, 19)
        Me.Paises_Label_Paises.Name = "Paises_Label_Paises"
        Me.Paises_Label_Paises.Size = New System.Drawing.Size(52, 16)
        Me.Paises_Label_Paises.TabIndex = 10
        Me.Paises_Label_Paises.Text = "Paises:"
        Me.Paises_Label_Paises.UseWaitCursor = True
        '
        'Paises_Button_VerTodosPaises
        '
        Me.Paises_Button_VerTodosPaises.Location = New System.Drawing.Point(112, 10)
        Me.Paises_Button_VerTodosPaises.Name = "Paises_Button_VerTodosPaises"
        Me.Paises_Button_VerTodosPaises.Size = New System.Drawing.Size(154, 28)
        Me.Paises_Button_VerTodosPaises.TabIndex = 9
        Me.Paises_Button_VerTodosPaises.Text = "Ver todos los Paises"
        Me.Paises_Button_VerTodosPaises.UseVisualStyleBackColor = True
        Me.Paises_Button_VerTodosPaises.UseWaitCursor = True
        '
        'Paises_ListBox_Paises
        '
        Me.Paises_ListBox_Paises.BackColor = System.Drawing.SystemColors.Control
        Me.Paises_ListBox_Paises.FormattingEnabled = True
        Me.Paises_ListBox_Paises.ItemHeight = 16
        Me.Paises_ListBox_Paises.Location = New System.Drawing.Point(29, 49)
        Me.Paises_ListBox_Paises.Name = "Paises_ListBox_Paises"
        Me.Paises_ListBox_Paises.Size = New System.Drawing.Size(267, 228)
        Me.Paises_ListBox_Paises.TabIndex = 8
        Me.Paises_ListBox_Paises.UseWaitCursor = True
        '
        'Paises_Button_Limpiar
        '
        Me.Paises_Button_Limpiar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Paises_Button_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Paises_Button_Limpiar.Location = New System.Drawing.Point(166, 376)
        Me.Paises_Button_Limpiar.Name = "Paises_Button_Limpiar"
        Me.Paises_Button_Limpiar.Size = New System.Drawing.Size(130, 51)
        Me.Paises_Button_Limpiar.TabIndex = 7
        Me.Paises_Button_Limpiar.Text = "LIMPIAR"
        Me.Paises_Button_Limpiar.UseVisualStyleBackColor = False
        Me.Paises_Button_Limpiar.UseWaitCursor = True
        '
        'Paises_Button_Eliminar
        '
        Me.Paises_Button_Eliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Paises_Button_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Paises_Button_Eliminar.Location = New System.Drawing.Point(29, 376)
        Me.Paises_Button_Eliminar.Name = "Paises_Button_Eliminar"
        Me.Paises_Button_Eliminar.Size = New System.Drawing.Size(130, 51)
        Me.Paises_Button_Eliminar.TabIndex = 6
        Me.Paises_Button_Eliminar.Text = "ELIMINAR"
        Me.Paises_Button_Eliminar.UseVisualStyleBackColor = False
        Me.Paises_Button_Eliminar.UseWaitCursor = True
        '
        'Paises_Button_Agregar
        '
        Me.Paises_Button_Agregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Paises_Button_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Paises_Button_Agregar.Location = New System.Drawing.Point(166, 315)
        Me.Paises_Button_Agregar.Name = "Paises_Button_Agregar"
        Me.Paises_Button_Agregar.Size = New System.Drawing.Size(130, 51)
        Me.Paises_Button_Agregar.TabIndex = 5
        Me.Paises_Button_Agregar.Text = "AGREGAR"
        Me.Paises_Button_Agregar.UseVisualStyleBackColor = False
        Me.Paises_Button_Agregar.UseWaitCursor = True
        '
        'Paises_Button_Actualizar
        '
        Me.Paises_Button_Actualizar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Paises_Button_Actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Paises_Button_Actualizar.Location = New System.Drawing.Point(29, 315)
        Me.Paises_Button_Actualizar.Name = "Paises_Button_Actualizar"
        Me.Paises_Button_Actualizar.Size = New System.Drawing.Size(130, 51)
        Me.Paises_Button_Actualizar.TabIndex = 4
        Me.Paises_Button_Actualizar.Text = "ACTUALIZAR"
        Me.Paises_Button_Actualizar.UseVisualStyleBackColor = False
        Me.Paises_Button_Actualizar.UseWaitCursor = True
        '
        'TabAlbum
        '
        Me.TabAlbum.Controls.Add(Me.Albumes_LabelListaAlbumes)
        Me.TabAlbum.Controls.Add(Me.Albumes_LabelNombreArtista)
        Me.TabAlbum.Controls.Add(Me.Albumes_ButtonLimpiar)
        Me.TabAlbum.Controls.Add(Me.Albumes_ButtonEliminar)
        Me.TabAlbum.Controls.Add(Me.Albumes_ButtonAgregar)
        Me.TabAlbum.Controls.Add(Me.Albumes_ButtonActualizar)
        Me.TabAlbum.Controls.Add(Me.Albumes_LabelAñoAlbum)
        Me.TabAlbum.Controls.Add(Me.Albumes_TextBoxAñoAlbum)
        Me.TabAlbum.Controls.Add(Me.Albumes_LabelNombre)
        Me.TabAlbum.Controls.Add(Me.Albumes_TextBoxNombreAlbum)
        Me.TabAlbum.Controls.Add(Me.Albumes_ListBoxAlbumes)
        Me.TabAlbum.Controls.Add(Me.Albumes_ComboBoxArtistas)
        Me.TabAlbum.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabAlbum.Location = New System.Drawing.Point(4, 25)
        Me.TabAlbum.Name = "TabAlbum"
        Me.TabAlbum.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAlbum.Size = New System.Drawing.Size(627, 502)
        Me.TabAlbum.TabIndex = 2
        Me.TabAlbum.Text = "Albumes"
        Me.TabAlbum.UseVisualStyleBackColor = True
        Me.TabAlbum.UseWaitCursor = True
        '
        'Albumes_LabelListaAlbumes
        '
        Me.Albumes_LabelListaAlbumes.AutoSize = True
        Me.Albumes_LabelListaAlbumes.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Albumes_LabelListaAlbumes.Location = New System.Drawing.Point(427, 35)
        Me.Albumes_LabelListaAlbumes.Name = "Albumes_LabelListaAlbumes"
        Me.Albumes_LabelListaAlbumes.Size = New System.Drawing.Size(60, 16)
        Me.Albumes_LabelListaAlbumes.TabIndex = 17
        Me.Albumes_LabelListaAlbumes.Text = "Albumes"
        Me.Albumes_LabelListaAlbumes.UseWaitCursor = True
        '
        'Albumes_LabelNombreArtista
        '
        Me.Albumes_LabelNombreArtista.AutoSize = True
        Me.Albumes_LabelNombreArtista.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Albumes_LabelNombreArtista.Location = New System.Drawing.Point(31, 35)
        Me.Albumes_LabelNombreArtista.Name = "Albumes_LabelNombreArtista"
        Me.Albumes_LabelNombreArtista.Size = New System.Drawing.Size(135, 16)
        Me.Albumes_LabelNombreArtista.TabIndex = 16
        Me.Albumes_LabelNombreArtista.Text = "Seleccionar un artista"
        Me.Albumes_LabelNombreArtista.UseWaitCursor = True
        '
        'Albumes_ButtonLimpiar
        '
        Me.Albumes_ButtonLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Albumes_ButtonLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Albumes_ButtonLimpiar.Location = New System.Drawing.Point(154, 345)
        Me.Albumes_ButtonLimpiar.Name = "Albumes_ButtonLimpiar"
        Me.Albumes_ButtonLimpiar.Size = New System.Drawing.Size(132, 44)
        Me.Albumes_ButtonLimpiar.TabIndex = 15
        Me.Albumes_ButtonLimpiar.Text = "LIMPIAR"
        Me.Albumes_ButtonLimpiar.UseVisualStyleBackColor = False
        Me.Albumes_ButtonLimpiar.UseWaitCursor = True
        '
        'Albumes_ButtonEliminar
        '
        Me.Albumes_ButtonEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Albumes_ButtonEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Albumes_ButtonEliminar.Location = New System.Drawing.Point(17, 345)
        Me.Albumes_ButtonEliminar.Name = "Albumes_ButtonEliminar"
        Me.Albumes_ButtonEliminar.Size = New System.Drawing.Size(132, 44)
        Me.Albumes_ButtonEliminar.TabIndex = 14
        Me.Albumes_ButtonEliminar.Text = "ELIMINAR"
        Me.Albumes_ButtonEliminar.UseVisualStyleBackColor = False
        Me.Albumes_ButtonEliminar.UseWaitCursor = True
        '
        'Albumes_ButtonAgregar
        '
        Me.Albumes_ButtonAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Albumes_ButtonAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Albumes_ButtonAgregar.Location = New System.Drawing.Point(154, 282)
        Me.Albumes_ButtonAgregar.Name = "Albumes_ButtonAgregar"
        Me.Albumes_ButtonAgregar.Size = New System.Drawing.Size(132, 44)
        Me.Albumes_ButtonAgregar.TabIndex = 13
        Me.Albumes_ButtonAgregar.Text = "AGREGAR"
        Me.Albumes_ButtonAgregar.UseVisualStyleBackColor = False
        Me.Albumes_ButtonAgregar.UseWaitCursor = True
        '
        'Albumes_ButtonActualizar
        '
        Me.Albumes_ButtonActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Albumes_ButtonActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Albumes_ButtonActualizar.Location = New System.Drawing.Point(17, 282)
        Me.Albumes_ButtonActualizar.Name = "Albumes_ButtonActualizar"
        Me.Albumes_ButtonActualizar.Size = New System.Drawing.Size(132, 44)
        Me.Albumes_ButtonActualizar.TabIndex = 12
        Me.Albumes_ButtonActualizar.Text = "ACTUALIZAR"
        Me.Albumes_ButtonActualizar.UseVisualStyleBackColor = False
        Me.Albumes_ButtonActualizar.UseWaitCursor = True
        '
        'Albumes_LabelAñoAlbum
        '
        Me.Albumes_LabelAñoAlbum.AutoSize = True
        Me.Albumes_LabelAñoAlbum.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Albumes_LabelAñoAlbum.Location = New System.Drawing.Point(31, 205)
        Me.Albumes_LabelAñoAlbum.Name = "Albumes_LabelAñoAlbum"
        Me.Albumes_LabelAñoAlbum.Size = New System.Drawing.Size(71, 16)
        Me.Albumes_LabelAñoAlbum.TabIndex = 11
        Me.Albumes_LabelAñoAlbum.Text = "Año álbum"
        Me.Albumes_LabelAñoAlbum.UseWaitCursor = True
        '
        'Albumes_TextBoxAñoAlbum
        '
        Me.Albumes_TextBoxAñoAlbum.Location = New System.Drawing.Point(17, 232)
        Me.Albumes_TextBoxAñoAlbum.Name = "Albumes_TextBoxAñoAlbum"
        Me.Albumes_TextBoxAñoAlbum.Size = New System.Drawing.Size(256, 22)
        Me.Albumes_TextBoxAñoAlbum.TabIndex = 10
        Me.Albumes_TextBoxAñoAlbum.UseWaitCursor = True
        '
        'Albumes_LabelNombre
        '
        Me.Albumes_LabelNombre.AutoSize = True
        Me.Albumes_LabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Albumes_LabelNombre.Location = New System.Drawing.Point(31, 139)
        Me.Albumes_LabelNombre.Name = "Albumes_LabelNombre"
        Me.Albumes_LabelNombre.Size = New System.Drawing.Size(118, 16)
        Me.Albumes_LabelNombre.TabIndex = 9
        Me.Albumes_LabelNombre.Text = "Nombre del álbum"
        Me.Albumes_LabelNombre.UseWaitCursor = True
        '
        'Albumes_TextBoxNombreAlbum
        '
        Me.Albumes_TextBoxNombreAlbum.Location = New System.Drawing.Point(17, 161)
        Me.Albumes_TextBoxNombreAlbum.Name = "Albumes_TextBoxNombreAlbum"
        Me.Albumes_TextBoxNombreAlbum.Size = New System.Drawing.Size(256, 22)
        Me.Albumes_TextBoxNombreAlbum.TabIndex = 8
        Me.Albumes_TextBoxNombreAlbum.UseWaitCursor = True
        '
        'Albumes_ListBoxAlbumes
        '
        Me.Albumes_ListBoxAlbumes.BackColor = System.Drawing.SystemColors.Control
        Me.Albumes_ListBoxAlbumes.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Albumes_ListBoxAlbumes.FormattingEnabled = True
        Me.Albumes_ListBoxAlbumes.ItemHeight = 16
        Me.Albumes_ListBoxAlbumes.Location = New System.Drawing.Point(343, 63)
        Me.Albumes_ListBoxAlbumes.Name = "Albumes_ListBoxAlbumes"
        Me.Albumes_ListBoxAlbumes.Size = New System.Drawing.Size(235, 324)
        Me.Albumes_ListBoxAlbumes.TabIndex = 6
        Me.Albumes_ListBoxAlbumes.UseWaitCursor = True
        '
        'Albumes_ComboBoxArtistas
        '
        Me.Albumes_ComboBoxArtistas.FormattingEnabled = True
        Me.Albumes_ComboBoxArtistas.Location = New System.Drawing.Point(17, 63)
        Me.Albumes_ComboBoxArtistas.Name = "Albumes_ComboBoxArtistas"
        Me.Albumes_ComboBoxArtistas.Size = New System.Drawing.Size(256, 24)
        Me.Albumes_ComboBoxArtistas.TabIndex = 3
        Me.Albumes_ComboBoxArtistas.UseWaitCursor = True
        '
        'TabConciertos
        '
        Me.TabConciertos.Controls.Add(Me.Conciertos_MonthCalendar_FechaConcierto)
        Me.TabConciertos.Controls.Add(Me.Conciertos_ListBoxTodosLosConciertos)
        Me.TabConciertos.Controls.Add(Me.Conciertos_LabelArtistaActua)
        Me.TabConciertos.Controls.Add(Me.Conciertos_ButtonLimpiar)
        Me.TabConciertos.Controls.Add(Me.Conciertos_ButtonEliminar)
        Me.TabConciertos.Controls.Add(Me.Conciertos_ButtonAgregar)
        Me.TabConciertos.Controls.Add(Me.Conciertos_ButtonActualizar)
        Me.TabConciertos.Controls.Add(Me.Conciertos_ComboBoxSitiosDondeHayConcierto)
        Me.TabConciertos.Controls.Add(Me.Conciertos_LabelSitiosDondeHayConciertos)
        Me.TabConciertos.Controls.Add(Me.Conciertos_LabelArtistasActuan)
        Me.TabConciertos.Controls.Add(Me.Conciertos_ComboBoxArtistaActua)
        Me.TabConciertos.Controls.Add(Me.Conciertos_LabelArtistas)
        Me.TabConciertos.Location = New System.Drawing.Point(4, 25)
        Me.TabConciertos.Name = "TabConciertos"
        Me.TabConciertos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabConciertos.Size = New System.Drawing.Size(627, 502)
        Me.TabConciertos.TabIndex = 3
        Me.TabConciertos.Text = "Conciertos"
        Me.TabConciertos.UseVisualStyleBackColor = True
        Me.TabConciertos.UseWaitCursor = True
        '
        'Conciertos_MonthCalendar_FechaConcierto
        '
        Me.Conciertos_MonthCalendar_FechaConcierto.Location = New System.Drawing.Point(304, 135)
        Me.Conciertos_MonthCalendar_FechaConcierto.Name = "Conciertos_MonthCalendar_FechaConcierto"
        Me.Conciertos_MonthCalendar_FechaConcierto.TabIndex = 20
        Me.Conciertos_MonthCalendar_FechaConcierto.TitleBackColor = System.Drawing.SystemColors.Highlight
        Me.Conciertos_MonthCalendar_FechaConcierto.UseWaitCursor = True
        '
        'Conciertos_ListBoxTodosLosConciertos
        '
        Me.Conciertos_ListBoxTodosLosConciertos.BackColor = System.Drawing.SystemColors.Control
        Me.Conciertos_ListBoxTodosLosConciertos.FormattingEnabled = True
        Me.Conciertos_ListBoxTodosLosConciertos.ItemHeight = 16
        Me.Conciertos_ListBoxTodosLosConciertos.Location = New System.Drawing.Point(18, 135)
        Me.Conciertos_ListBoxTodosLosConciertos.Name = "Conciertos_ListBoxTodosLosConciertos"
        Me.Conciertos_ListBoxTodosLosConciertos.Size = New System.Drawing.Size(211, 308)
        Me.Conciertos_ListBoxTodosLosConciertos.TabIndex = 17
        Me.Conciertos_ListBoxTodosLosConciertos.UseWaitCursor = True
        '
        'Conciertos_LabelArtistaActua
        '
        Me.Conciertos_LabelArtistaActua.AutoSize = True
        Me.Conciertos_LabelArtistaActua.Location = New System.Drawing.Point(24, 22)
        Me.Conciertos_LabelArtistaActua.Name = "Conciertos_LabelArtistaActua"
        Me.Conciertos_LabelArtistaActua.Size = New System.Drawing.Size(180, 16)
        Me.Conciertos_LabelArtistaActua.TabIndex = 16
        Me.Conciertos_LabelArtistaActua.Text = "Seleccionar artista que actua"
        Me.Conciertos_LabelArtistaActua.UseWaitCursor = True
        '
        'Conciertos_ButtonLimpiar
        '
        Me.Conciertos_ButtonLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Conciertos_ButtonLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Conciertos_ButtonLimpiar.Location = New System.Drawing.Point(446, 432)
        Me.Conciertos_ButtonLimpiar.Name = "Conciertos_ButtonLimpiar"
        Me.Conciertos_ButtonLimpiar.Size = New System.Drawing.Size(120, 46)
        Me.Conciertos_ButtonLimpiar.TabIndex = 15
        Me.Conciertos_ButtonLimpiar.Text = "LIMPIAR"
        Me.Conciertos_ButtonLimpiar.UseVisualStyleBackColor = False
        Me.Conciertos_ButtonLimpiar.UseWaitCursor = True
        '
        'Conciertos_ButtonEliminar
        '
        Me.Conciertos_ButtonEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Conciertos_ButtonEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Conciertos_ButtonEliminar.Location = New System.Drawing.Point(304, 432)
        Me.Conciertos_ButtonEliminar.Name = "Conciertos_ButtonEliminar"
        Me.Conciertos_ButtonEliminar.Size = New System.Drawing.Size(120, 46)
        Me.Conciertos_ButtonEliminar.TabIndex = 14
        Me.Conciertos_ButtonEliminar.Text = "ELIMINAR"
        Me.Conciertos_ButtonEliminar.UseVisualStyleBackColor = False
        Me.Conciertos_ButtonEliminar.UseWaitCursor = True
        '
        'Conciertos_ButtonAgregar
        '
        Me.Conciertos_ButtonAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Conciertos_ButtonAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Conciertos_ButtonAgregar.Location = New System.Drawing.Point(446, 359)
        Me.Conciertos_ButtonAgregar.Name = "Conciertos_ButtonAgregar"
        Me.Conciertos_ButtonAgregar.Size = New System.Drawing.Size(120, 46)
        Me.Conciertos_ButtonAgregar.TabIndex = 13
        Me.Conciertos_ButtonAgregar.Text = "AGREGAR"
        Me.Conciertos_ButtonAgregar.UseVisualStyleBackColor = False
        Me.Conciertos_ButtonAgregar.UseWaitCursor = True
        '
        'Conciertos_ButtonActualizar
        '
        Me.Conciertos_ButtonActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Conciertos_ButtonActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Conciertos_ButtonActualizar.Location = New System.Drawing.Point(304, 359)
        Me.Conciertos_ButtonActualizar.Name = "Conciertos_ButtonActualizar"
        Me.Conciertos_ButtonActualizar.Size = New System.Drawing.Size(120, 46)
        Me.Conciertos_ButtonActualizar.TabIndex = 12
        Me.Conciertos_ButtonActualizar.Text = "ACTUALIZAR"
        Me.Conciertos_ButtonActualizar.UseVisualStyleBackColor = False
        Me.Conciertos_ButtonActualizar.UseWaitCursor = True
        '
        'Conciertos_ComboBoxSitiosDondeHayConcierto
        '
        Me.Conciertos_ComboBoxSitiosDondeHayConcierto.FormattingEnabled = True
        Me.Conciertos_ComboBoxSitiosDondeHayConcierto.Location = New System.Drawing.Point(304, 54)
        Me.Conciertos_ComboBoxSitiosDondeHayConcierto.Name = "Conciertos_ComboBoxSitiosDondeHayConcierto"
        Me.Conciertos_ComboBoxSitiosDondeHayConcierto.Size = New System.Drawing.Size(170, 24)
        Me.Conciertos_ComboBoxSitiosDondeHayConcierto.TabIndex = 11
        Me.Conciertos_ComboBoxSitiosDondeHayConcierto.UseWaitCursor = True
        '
        'Conciertos_LabelSitiosDondeHayConciertos
        '
        Me.Conciertos_LabelSitiosDondeHayConciertos.AutoSize = True
        Me.Conciertos_LabelSitiosDondeHayConciertos.Location = New System.Drawing.Point(301, 26)
        Me.Conciertos_LabelSitiosDondeHayConciertos.Name = "Conciertos_LabelSitiosDondeHayConciertos"
        Me.Conciertos_LabelSitiosDondeHayConciertos.Size = New System.Drawing.Size(175, 16)
        Me.Conciertos_LabelSitiosDondeHayConciertos.TabIndex = 10
        Me.Conciertos_LabelSitiosDondeHayConciertos.Text = "Sitios donde hay conciertos:"
        Me.Conciertos_LabelSitiosDondeHayConciertos.UseWaitCursor = True
        '
        'Conciertos_LabelArtistasActuan
        '
        Me.Conciertos_LabelArtistasActuan.AutoSize = True
        Me.Conciertos_LabelArtistasActuan.Location = New System.Drawing.Point(16, 106)
        Me.Conciertos_LabelArtistasActuan.Name = "Conciertos_LabelArtistasActuan"
        Me.Conciertos_LabelArtistasActuan.Size = New System.Drawing.Size(144, 16)
        Me.Conciertos_LabelArtistasActuan.TabIndex = 8
        Me.Conciertos_LabelArtistasActuan.Text = "Conciertos disponibles"
        Me.Conciertos_LabelArtistasActuan.UseWaitCursor = True
        '
        'Conciertos_ComboBoxArtistaActua
        '
        Me.Conciertos_ComboBoxArtistaActua.FormattingEnabled = True
        Me.Conciertos_ComboBoxArtistaActua.Location = New System.Drawing.Point(18, 50)
        Me.Conciertos_ComboBoxArtistaActua.Name = "Conciertos_ComboBoxArtistaActua"
        Me.Conciertos_ComboBoxArtistaActua.Size = New System.Drawing.Size(211, 24)
        Me.Conciertos_ComboBoxArtistaActua.TabIndex = 5
        Me.Conciertos_ComboBoxArtistaActua.UseWaitCursor = True
        '
        'Conciertos_LabelArtistas
        '
        Me.Conciertos_LabelArtistas.AutoSize = True
        Me.Conciertos_LabelArtistas.Location = New System.Drawing.Point(301, 110)
        Me.Conciertos_LabelArtistas.Name = "Conciertos_LabelArtistas"
        Me.Conciertos_LabelArtistas.Size = New System.Drawing.Size(125, 16)
        Me.Conciertos_LabelArtistas.TabIndex = 2
        Me.Conciertos_LabelArtistas.Text = "Fecha del concierto"
        Me.Conciertos_LabelArtistas.UseWaitCursor = True
        '
        'TabCanciones
        '
        Me.TabCanciones.Controls.Add(Me.Canciones_LabelCanciones)
        Me.TabCanciones.Controls.Add(Me.Canciones_comboBoxArtista)
        Me.TabCanciones.Controls.Add(Me.Canciones_LabelArtista)
        Me.TabCanciones.Controls.Add(Me.Canciones_TextBoxDuracionCanciones)
        Me.TabCanciones.Controls.Add(Me.Canciones_LabelDuracion)
        Me.TabCanciones.Controls.Add(Me.Canciones_TextBoxNombreCanciones)
        Me.TabCanciones.Controls.Add(Me.Canciones_ListBoxTodasLasCanciones)
        Me.TabCanciones.Controls.Add(Me.Canciones_ButtonLimpiar)
        Me.TabCanciones.Controls.Add(Me.Canciones_ButtonEliminar)
        Me.TabCanciones.Controls.Add(Me.Canciones_ButtonAgregar)
        Me.TabCanciones.Controls.Add(Me.Canciones_ButtonActualizar)
        Me.TabCanciones.Controls.Add(Me.Canciones_LabelNombreCancion)
        Me.TabCanciones.Location = New System.Drawing.Point(4, 25)
        Me.TabCanciones.Name = "TabCanciones"
        Me.TabCanciones.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCanciones.Size = New System.Drawing.Size(627, 502)
        Me.TabCanciones.TabIndex = 4
        Me.TabCanciones.Text = "Canciones"
        Me.TabCanciones.UseVisualStyleBackColor = True
        Me.TabCanciones.UseWaitCursor = True
        '
        'Canciones_TextBoxDuracionCanciones
        '
        Me.Canciones_TextBoxDuracionCanciones.Location = New System.Drawing.Point(24, 211)
        Me.Canciones_TextBoxDuracionCanciones.Name = "Canciones_TextBoxDuracionCanciones"
        Me.Canciones_TextBoxDuracionCanciones.Size = New System.Drawing.Size(256, 22)
        Me.Canciones_TextBoxDuracionCanciones.TabIndex = 10
        Me.Canciones_TextBoxDuracionCanciones.UseWaitCursor = True
        '
        'Canciones_LabelDuracion
        '
        Me.Canciones_LabelDuracion.AutoSize = True
        Me.Canciones_LabelDuracion.Location = New System.Drawing.Point(35, 178)
        Me.Canciones_LabelDuracion.Name = "Canciones_LabelDuracion"
        Me.Canciones_LabelDuracion.Size = New System.Drawing.Size(147, 16)
        Me.Canciones_LabelDuracion.TabIndex = 9
        Me.Canciones_LabelDuracion.Text = "Duracion de la cancion:"
        Me.Canciones_LabelDuracion.UseWaitCursor = True
        '
        'Canciones_TextBoxNombreCanciones
        '
        Me.Canciones_TextBoxNombreCanciones.Location = New System.Drawing.Point(24, 143)
        Me.Canciones_TextBoxNombreCanciones.Name = "Canciones_TextBoxNombreCanciones"
        Me.Canciones_TextBoxNombreCanciones.Size = New System.Drawing.Size(256, 22)
        Me.Canciones_TextBoxNombreCanciones.TabIndex = 8
        Me.Canciones_TextBoxNombreCanciones.UseWaitCursor = True
        '
        'Canciones_ListBoxTodasLasCanciones
        '
        Me.Canciones_ListBoxTodasLasCanciones.BackColor = System.Drawing.SystemColors.Control
        Me.Canciones_ListBoxTodasLasCanciones.FormattingEnabled = True
        Me.Canciones_ListBoxTodasLasCanciones.ItemHeight = 16
        Me.Canciones_ListBoxTodasLasCanciones.Location = New System.Drawing.Point(341, 58)
        Me.Canciones_ListBoxTodasLasCanciones.Name = "Canciones_ListBoxTodasLasCanciones"
        Me.Canciones_ListBoxTodasLasCanciones.Size = New System.Drawing.Size(229, 276)
        Me.Canciones_ListBoxTodasLasCanciones.TabIndex = 7
        Me.Canciones_ListBoxTodasLasCanciones.UseWaitCursor = True
        '
        'Canciones_ButtonLimpiar
        '
        Me.Canciones_ButtonLimpiar.BackColor = System.Drawing.Color.Salmon
        Me.Canciones_ButtonLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Canciones_ButtonLimpiar.ForeColor = System.Drawing.Color.Black
        Me.Canciones_ButtonLimpiar.Location = New System.Drawing.Point(164, 329)
        Me.Canciones_ButtonLimpiar.Name = "Canciones_ButtonLimpiar"
        Me.Canciones_ButtonLimpiar.Size = New System.Drawing.Size(140, 56)
        Me.Canciones_ButtonLimpiar.TabIndex = 6
        Me.Canciones_ButtonLimpiar.Text = "LIMPIAR"
        Me.Canciones_ButtonLimpiar.UseVisualStyleBackColor = False
        Me.Canciones_ButtonLimpiar.UseWaitCursor = True
        '
        'Canciones_ButtonEliminar
        '
        Me.Canciones_ButtonEliminar.BackColor = System.Drawing.Color.Salmon
        Me.Canciones_ButtonEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Canciones_ButtonEliminar.ForeColor = System.Drawing.Color.Black
        Me.Canciones_ButtonEliminar.Location = New System.Drawing.Point(24, 329)
        Me.Canciones_ButtonEliminar.Name = "Canciones_ButtonEliminar"
        Me.Canciones_ButtonEliminar.Size = New System.Drawing.Size(140, 56)
        Me.Canciones_ButtonEliminar.TabIndex = 5
        Me.Canciones_ButtonEliminar.Text = "ELIMINAR"
        Me.Canciones_ButtonEliminar.UseVisualStyleBackColor = False
        Me.Canciones_ButtonEliminar.UseWaitCursor = True
        '
        'Canciones_ButtonAgregar
        '
        Me.Canciones_ButtonAgregar.BackColor = System.Drawing.Color.Salmon
        Me.Canciones_ButtonAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Canciones_ButtonAgregar.ForeColor = System.Drawing.Color.Black
        Me.Canciones_ButtonAgregar.Location = New System.Drawing.Point(164, 260)
        Me.Canciones_ButtonAgregar.Name = "Canciones_ButtonAgregar"
        Me.Canciones_ButtonAgregar.Size = New System.Drawing.Size(140, 56)
        Me.Canciones_ButtonAgregar.TabIndex = 4
        Me.Canciones_ButtonAgregar.Text = "AGREGAR"
        Me.Canciones_ButtonAgregar.UseVisualStyleBackColor = False
        Me.Canciones_ButtonAgregar.UseWaitCursor = True
        '
        'Canciones_ButtonActualizar
        '
        Me.Canciones_ButtonActualizar.BackColor = System.Drawing.Color.Salmon
        Me.Canciones_ButtonActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Canciones_ButtonActualizar.ForeColor = System.Drawing.Color.Black
        Me.Canciones_ButtonActualizar.Location = New System.Drawing.Point(24, 260)
        Me.Canciones_ButtonActualizar.Name = "Canciones_ButtonActualizar"
        Me.Canciones_ButtonActualizar.Size = New System.Drawing.Size(140, 56)
        Me.Canciones_ButtonActualizar.TabIndex = 3
        Me.Canciones_ButtonActualizar.Text = "ACTUALIZAR"
        Me.Canciones_ButtonActualizar.UseVisualStyleBackColor = False
        Me.Canciones_ButtonActualizar.UseWaitCursor = True
        '
        'Canciones_LabelNombreCancion
        '
        Me.Canciones_LabelNombreCancion.AutoSize = True
        Me.Canciones_LabelNombreCancion.Location = New System.Drawing.Point(35, 109)
        Me.Canciones_LabelNombreCancion.Name = "Canciones_LabelNombreCancion"
        Me.Canciones_LabelNombreCancion.Size = New System.Drawing.Size(142, 16)
        Me.Canciones_LabelNombreCancion.TabIndex = 1
        Me.Canciones_LabelNombreCancion.Text = "Nombre de la cancion:"
        Me.Canciones_LabelNombreCancion.UseWaitCursor = True
        '
        'TabSitio
        '
        Me.TabSitio.Controls.Add(Me.Sitios_Label_Tipo)
        Me.TabSitio.Controls.Add(Me.Sitios_ComboBox_TipoSitio)
        Me.TabSitio.Controls.Add(Me.Sitios_ComboBox_PaisSitio)
        Me.TabSitio.Controls.Add(Me.Sitios_ListBox_Sitios)
        Me.TabSitio.Controls.Add(Me.Sitios_Button_Limpiar)
        Me.TabSitio.Controls.Add(Me.Sitios_Button_Eliminar)
        Me.TabSitio.Controls.Add(Me.Sitios_Button_Agregar)
        Me.TabSitio.Controls.Add(Me.Sitios_Button_Actualizar)
        Me.TabSitio.Controls.Add(Me.Sitios_Label_PaisSitio)
        Me.TabSitio.Controls.Add(Me.Sitios_Label_NombreSitio)
        Me.TabSitio.Controls.Add(Me.Sitios_TextBox_NombreSitio)
        Me.TabSitio.Controls.Add(Me.Sitios_Button_VerTodosSitios)
        Me.TabSitio.Controls.Add(Me.Sitios_Label_Sitios)
        Me.TabSitio.Location = New System.Drawing.Point(4, 25)
        Me.TabSitio.Name = "TabSitio"
        Me.TabSitio.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSitio.Size = New System.Drawing.Size(627, 502)
        Me.TabSitio.TabIndex = 5
        Me.TabSitio.Text = "Sitio"
        Me.TabSitio.UseVisualStyleBackColor = True
        Me.TabSitio.UseWaitCursor = True
        '
        'Sitios_Label_Tipo
        '
        Me.Sitios_Label_Tipo.AutoSize = True
        Me.Sitios_Label_Tipo.Location = New System.Drawing.Point(345, 131)
        Me.Sitios_Label_Tipo.Name = "Sitios_Label_Tipo"
        Me.Sitios_Label_Tipo.Size = New System.Drawing.Size(87, 16)
        Me.Sitios_Label_Tipo.TabIndex = 15
        Me.Sitios_Label_Tipo.Text = "Tipo del sitio:"
        Me.Sitios_Label_Tipo.UseWaitCursor = True
        '
        'Sitios_ComboBox_TipoSitio
        '
        Me.Sitios_ComboBox_TipoSitio.FormattingEnabled = True
        Me.Sitios_ComboBox_TipoSitio.Items.AddRange(New Object() {"sala", "pabellón", "estadio", "festival"})
        Me.Sitios_ComboBox_TipoSitio.Location = New System.Drawing.Point(337, 150)
        Me.Sitios_ComboBox_TipoSitio.Name = "Sitios_ComboBox_TipoSitio"
        Me.Sitios_ComboBox_TipoSitio.Size = New System.Drawing.Size(256, 24)
        Me.Sitios_ComboBox_TipoSitio.TabIndex = 14
        Me.Sitios_ComboBox_TipoSitio.UseWaitCursor = True
        '
        'Sitios_ComboBox_PaisSitio
        '
        Me.Sitios_ComboBox_PaisSitio.FormattingEnabled = True
        Me.Sitios_ComboBox_PaisSitio.Location = New System.Drawing.Point(337, 204)
        Me.Sitios_ComboBox_PaisSitio.Name = "Sitios_ComboBox_PaisSitio"
        Me.Sitios_ComboBox_PaisSitio.Size = New System.Drawing.Size(256, 24)
        Me.Sitios_ComboBox_PaisSitio.TabIndex = 13
        Me.Sitios_ComboBox_PaisSitio.UseWaitCursor = True
        '
        'Sitios_ListBox_Sitios
        '
        Me.Sitios_ListBox_Sitios.BackColor = System.Drawing.SystemColors.Control
        Me.Sitios_ListBox_Sitios.FormattingEnabled = True
        Me.Sitios_ListBox_Sitios.ItemHeight = 16
        Me.Sitios_ListBox_Sitios.Location = New System.Drawing.Point(29, 61)
        Me.Sitios_ListBox_Sitios.Name = "Sitios_ListBox_Sitios"
        Me.Sitios_ListBox_Sitios.Size = New System.Drawing.Size(267, 228)
        Me.Sitios_ListBox_Sitios.TabIndex = 11
        Me.Sitios_ListBox_Sitios.UseWaitCursor = True
        '
        'Sitios_Button_Limpiar
        '
        Me.Sitios_Button_Limpiar.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Sitios_Button_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sitios_Button_Limpiar.Location = New System.Drawing.Point(166, 385)
        Me.Sitios_Button_Limpiar.Name = "Sitios_Button_Limpiar"
        Me.Sitios_Button_Limpiar.Size = New System.Drawing.Size(130, 49)
        Me.Sitios_Button_Limpiar.TabIndex = 10
        Me.Sitios_Button_Limpiar.Text = "LIMPIAR"
        Me.Sitios_Button_Limpiar.UseVisualStyleBackColor = False
        Me.Sitios_Button_Limpiar.UseWaitCursor = True
        '
        'Sitios_Button_Eliminar
        '
        Me.Sitios_Button_Eliminar.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Sitios_Button_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sitios_Button_Eliminar.Location = New System.Drawing.Point(29, 385)
        Me.Sitios_Button_Eliminar.Name = "Sitios_Button_Eliminar"
        Me.Sitios_Button_Eliminar.Size = New System.Drawing.Size(131, 49)
        Me.Sitios_Button_Eliminar.TabIndex = 9
        Me.Sitios_Button_Eliminar.Text = "ELIMINAR"
        Me.Sitios_Button_Eliminar.UseVisualStyleBackColor = False
        Me.Sitios_Button_Eliminar.UseWaitCursor = True
        '
        'Sitios_Button_Agregar
        '
        Me.Sitios_Button_Agregar.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Sitios_Button_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sitios_Button_Agregar.Location = New System.Drawing.Point(166, 324)
        Me.Sitios_Button_Agregar.Name = "Sitios_Button_Agregar"
        Me.Sitios_Button_Agregar.Size = New System.Drawing.Size(130, 49)
        Me.Sitios_Button_Agregar.TabIndex = 8
        Me.Sitios_Button_Agregar.Text = "AGREGAR"
        Me.Sitios_Button_Agregar.UseVisualStyleBackColor = False
        Me.Sitios_Button_Agregar.UseWaitCursor = True
        '
        'Sitios_Button_Actualizar
        '
        Me.Sitios_Button_Actualizar.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Sitios_Button_Actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sitios_Button_Actualizar.Location = New System.Drawing.Point(29, 324)
        Me.Sitios_Button_Actualizar.Name = "Sitios_Button_Actualizar"
        Me.Sitios_Button_Actualizar.Size = New System.Drawing.Size(131, 49)
        Me.Sitios_Button_Actualizar.TabIndex = 7
        Me.Sitios_Button_Actualizar.Text = "ACTUALIZAR"
        Me.Sitios_Button_Actualizar.UseVisualStyleBackColor = False
        Me.Sitios_Button_Actualizar.UseWaitCursor = True
        '
        'Sitios_Label_PaisSitio
        '
        Me.Sitios_Label_PaisSitio.AutoSize = True
        Me.Sitios_Label_PaisSitio.Location = New System.Drawing.Point(345, 185)
        Me.Sitios_Label_PaisSitio.Name = "Sitios_Label_PaisSitio"
        Me.Sitios_Label_PaisSitio.Size = New System.Drawing.Size(86, 16)
        Me.Sitios_Label_PaisSitio.TabIndex = 6
        Me.Sitios_Label_PaisSitio.Text = "País del sitio:"
        Me.Sitios_Label_PaisSitio.UseWaitCursor = True
        '
        'Sitios_Label_NombreSitio
        '
        Me.Sitios_Label_NombreSitio.AutoSize = True
        Me.Sitios_Label_NombreSitio.Location = New System.Drawing.Point(345, 81)
        Me.Sitios_Label_NombreSitio.Name = "Sitios_Label_NombreSitio"
        Me.Sitios_Label_NombreSitio.Size = New System.Drawing.Size(108, 16)
        Me.Sitios_Label_NombreSitio.TabIndex = 4
        Me.Sitios_Label_NombreSitio.Text = "Nombre del sitio:"
        Me.Sitios_Label_NombreSitio.UseWaitCursor = True
        '
        'Sitios_TextBox_NombreSitio
        '
        Me.Sitios_TextBox_NombreSitio.Location = New System.Drawing.Point(337, 100)
        Me.Sitios_TextBox_NombreSitio.Name = "Sitios_TextBox_NombreSitio"
        Me.Sitios_TextBox_NombreSitio.Size = New System.Drawing.Size(256, 22)
        Me.Sitios_TextBox_NombreSitio.TabIndex = 3
        Me.Sitios_TextBox_NombreSitio.UseWaitCursor = True
        '
        'Sitios_Button_VerTodosSitios
        '
        Me.Sitios_Button_VerTodosSitios.BackColor = System.Drawing.Color.MistyRose
        Me.Sitios_Button_VerTodosSitios.Location = New System.Drawing.Point(112, 16)
        Me.Sitios_Button_VerTodosSitios.Name = "Sitios_Button_VerTodosSitios"
        Me.Sitios_Button_VerTodosSitios.Size = New System.Drawing.Size(154, 28)
        Me.Sitios_Button_VerTodosSitios.TabIndex = 2
        Me.Sitios_Button_VerTodosSitios.Text = "Ver todos los Sitios"
        Me.Sitios_Button_VerTodosSitios.UseVisualStyleBackColor = False
        Me.Sitios_Button_VerTodosSitios.UseWaitCursor = True
        '
        'Sitios_Label_Sitios
        '
        Me.Sitios_Label_Sitios.AutoSize = True
        Me.Sitios_Label_Sitios.Location = New System.Drawing.Point(46, 22)
        Me.Sitios_Label_Sitios.Name = "Sitios_Label_Sitios"
        Me.Sitios_Label_Sitios.Size = New System.Drawing.Size(43, 16)
        Me.Sitios_Label_Sitios.TabIndex = 1
        Me.Sitios_Label_Sitios.Text = "Sitios:"
        Me.Sitios_Label_Sitios.UseWaitCursor = True
        '
        'Canciones_LabelArtista
        '
        Me.Canciones_LabelArtista.AutoSize = True
        Me.Canciones_LabelArtista.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Canciones_LabelArtista.Location = New System.Drawing.Point(35, 28)
        Me.Canciones_LabelArtista.Name = "Canciones_LabelArtista"
        Me.Canciones_LabelArtista.Size = New System.Drawing.Size(135, 16)
        Me.Canciones_LabelArtista.TabIndex = 17
        Me.Canciones_LabelArtista.Text = "Seleccionar un artista"
        Me.Canciones_LabelArtista.UseWaitCursor = True
        '
        'Canciones_comboBoxArtista
        '
        Me.Canciones_comboBoxArtista.FormattingEnabled = True
        Me.Canciones_comboBoxArtista.Location = New System.Drawing.Point(24, 58)
        Me.Canciones_comboBoxArtista.Name = "Canciones_comboBoxArtista"
        Me.Canciones_comboBoxArtista.Size = New System.Drawing.Size(256, 24)
        Me.Canciones_comboBoxArtista.TabIndex = 18
        Me.Canciones_comboBoxArtista.UseWaitCursor = True
        '
        'Canciones_LabelCanciones
        '
        Me.Canciones_LabelCanciones.AutoSize = True
        Me.Canciones_LabelCanciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Canciones_LabelCanciones.Location = New System.Drawing.Point(418, 28)
        Me.Canciones_LabelCanciones.Name = "Canciones_LabelCanciones"
        Me.Canciones_LabelCanciones.Size = New System.Drawing.Size(71, 16)
        Me.Canciones_LabelCanciones.TabIndex = 19
        Me.Canciones_LabelCanciones.Text = "Canciones"
        Me.Canciones_LabelCanciones.UseWaitCursor = True
        '
        'FormularioPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 539)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "FormularioPrincipal"
        Me.Text = "Práctica 3 - BBDD"
        Me.UseWaitCursor = True
        Me.TabControl.ResumeLayout(False)
        Me.TabArtistas.ResumeLayout(False)
        Me.TabArtistas.PerformLayout()
        Me.TabPaises.ResumeLayout(False)
        Me.TabPaises.PerformLayout()
        Me.TabAlbum.ResumeLayout(False)
        Me.TabAlbum.PerformLayout()
        Me.TabConciertos.ResumeLayout(False)
        Me.TabConciertos.PerformLayout()
        Me.TabCanciones.ResumeLayout(False)
        Me.TabCanciones.PerformLayout()
        Me.TabSitio.ResumeLayout(False)
        Me.TabSitio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl



    Friend WithEvents TabPaises As TabPage
    Friend WithEvents TabArtistas As TabPage
    Friend WithEvents TabAlbum As TabPage
    Friend WithEvents TabConciertos As TabPage
    Friend WithEvents TabCanciones As TabPage
    Friend WithEvents TabSitio As TabPage

    Friend WithEvents Paises_Button_Limpiar As Button
    Friend WithEvents Paises_Button_Eliminar As Button
    Friend WithEvents Paises_Button_Agregar As Button
    Friend WithEvents Paises_Button_Actualizar As Button
    Friend WithEvents Paises_Button_VerTodosPaises As Button
    Friend WithEvents Paises_Label_Paises As Label
    Friend WithEvents Paises_Label_Nombre As Label
    Friend WithEvents Paises_TextBox_NombrePais As TextBox
    Friend WithEvents Paises_ListBox_Paises As ListBox



    Friend WithEvents Artistas_Label_Artistas As Label
    Friend WithEvents Artistas_Label_NombreArtista As Label
    Friend WithEvents Artistas_TextBox_NombreArtista As TextBox
    Friend WithEvents Artistas_Button_VerTodosArtistas As Button
    Friend WithEvents Artistas_Label_PaisArtista As Label
    Friend WithEvents Artistas_Button_Eliminar As Button
    Friend WithEvents Artistas_Button_Agregar As Button
    Friend WithEvents Artistas_Button_Actualizar As Button
    Friend WithEvents Artistas_Button_Limpiar As Button
    Friend WithEvents Artistas_ComboBox_PaisArtista As ComboBox
    Friend WithEvents Artistas_ListBox_Artistas As ListBox



    Friend WithEvents Sitios_Label_Sitios As Label
    Friend WithEvents Sitios_Label_NombreSitio As Label
    Friend WithEvents Sitios_TextBox_NombreSitio As TextBox
    Friend WithEvents Sitios_Button_VerTodosSitios As Button
    Friend WithEvents Sitios_Label_PaisSitio As Label
    Friend WithEvents Sitios_Button_Eliminar As Button
    Friend WithEvents Sitios_Button_Agregar As Button
    Friend WithEvents Sitios_Button_Actualizar As Button
    Friend WithEvents Sitios_Button_Limpiar As Button
    Friend WithEvents Sitios_ListBox_Sitios As ListBox
    Friend WithEvents Sitios_ComboBox_TipoSitio As ComboBox
    Friend WithEvents Sitios_ComboBox_PaisSitio As ComboBox



    Friend WithEvents Albumes_ListBoxAlbumes As ListBox
    Friend WithEvents Albumes_ComboBoxArtistas As ComboBox
    Friend WithEvents Albumes_ButtonActualizar As Button
    Friend WithEvents Albumes_LabelAñoAlbum As Label
    Friend WithEvents Albumes_TextBoxAñoAlbum As TextBox
    Friend WithEvents Albumes_LabelNombre As Label
    Friend WithEvents Albumes_TextBoxNombreAlbum As TextBox
    Friend WithEvents Albumes_ButtonAgregar As Button
    Friend WithEvents Albumes_ButtonEliminar As Button
    Friend WithEvents Albumes_ButtonLimpiar As Button



    Friend WithEvents Conciertos_LabelArtistas As Label
    Friend WithEvents Conciertos_LabelArtistasActuan As Label
    Friend WithEvents Conciertos_ComboBoxArtistaActua As ComboBox
    Friend WithEvents Conciertos_ComboBoxSitiosDondeHayConcierto As ComboBox
    Friend WithEvents Conciertos_LabelSitiosDondeHayConciertos As Label
    Friend WithEvents Conciertos_ButtonLimpiar As Button
    Friend WithEvents Conciertos_ButtonEliminar As Button
    Friend WithEvents Conciertos_ButtonAgregar As Button
    Friend WithEvents Conciertos_ButtonActualizar As Button
    Friend WithEvents Conciertos_LabelArtistaActua As Label
    Friend WithEvents Conciertos_ListBoxTodosLosConciertos As ListBox
    Friend WithEvents Conciertos_MonthCalendar_FechaConcierto As MonthCalendar



    Friend WithEvents ColorDialog1 As ColorDialog


    Friend WithEvents Canciones_ButtonLimpiar As Button
    Friend WithEvents Canciones_ButtonEliminar As Button
    Friend WithEvents Canciones_ButtonAgregar As Button
    Friend WithEvents Canciones_ButtonActualizar As Button
    Friend WithEvents Canciones_LabelNombreCancion As Label
    Friend WithEvents Canciones_TextBoxDuracionCanciones As TextBox
    Friend WithEvents Canciones_LabelDuracion As Label
    Friend WithEvents Canciones_TextBoxNombreCanciones As TextBox
    Friend WithEvents Canciones_ListBoxTodasLasCanciones As ListBox



    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Albumes_LabelListaAlbumes As Label
    Friend WithEvents Albumes_LabelNombreArtista As Label
    Friend WithEvents Sitios_Label_Tipo As Label
    Friend WithEvents Canciones_LabelCanciones As Label
    Friend WithEvents Canciones_comboBoxArtista As ComboBox
    Friend WithEvents Canciones_LabelArtista As Label
End Class
