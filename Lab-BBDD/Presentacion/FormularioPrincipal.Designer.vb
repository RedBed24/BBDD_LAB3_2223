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
        Me.Artista_ComboBox_PaisArtista = New System.Windows.Forms.ComboBox()
        Me.Artista_ListBox_Artistas = New System.Windows.Forms.ListBox()
        Me.Artista_Button_Limpiar = New System.Windows.Forms.Button()
        Me.Artista_Button_Eliminar = New System.Windows.Forms.Button()
        Me.Artista_Button_Agregar = New System.Windows.Forms.Button()
        Me.Artista_Button_Actualizar = New System.Windows.Forms.Button()
        Me.Artista_Label_PaisArtista = New System.Windows.Forms.Label()
        Me.Artista_TextBox_PaisArtista = New System.Windows.Forms.TextBox()
        Me.Artista_Label_NombreArtista = New System.Windows.Forms.Label()
        Me.Artista_TextBox_NombreArtista = New System.Windows.Forms.TextBox()
        Me.Artista_Button_VerTodosArtistas = New System.Windows.Forms.Button()
        Me.Artista_Label_Artistas = New System.Windows.Forms.Label()
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
        Me.Paises_ComboBox_Seleccionar = New System.Windows.Forms.ComboBox()
        Me.Paises_LabelSeleccionar = New System.Windows.Forms.Label()
        Me.TabAlbum = New System.Windows.Forms.TabPage()
        Me.Albumes_ButtonLimpiar = New System.Windows.Forms.Button()
        Me.Albumes_ButtonEliminar = New System.Windows.Forms.Button()
        Me.Albumes_ButtonAgregar = New System.Windows.Forms.Button()
        Me.Albumes_ButtonActualizar = New System.Windows.Forms.Button()
        Me.Albumes_LabelAñoAlbum = New System.Windows.Forms.Label()
        Me.Albumes_TextBoxAñoAlbum = New System.Windows.Forms.TextBox()
        Me.Albumes_LabelNombre = New System.Windows.Forms.Label()
        Me.Albumes_TextBoxNombreAlbum = New System.Windows.Forms.TextBox()
        Me.Albumes_ListBoxAlbumes = New System.Windows.Forms.ListBox()
        Me.Albumes_ButtonVerTodosLosArtistas = New System.Windows.Forms.Button()
        Me.Albumes_ComboBoxArtistas = New System.Windows.Forms.ComboBox()
        Me.TabConciertos = New System.Windows.Forms.TabPage()
        Me.FechaEjemplo = New System.Windows.Forms.Label()
        Me.Conciertos_TextBoxFecha = New System.Windows.Forms.TextBox()
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
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TabControl.SuspendLayout()
        Me.TabArtista.SuspendLayout()
        Me.TabPaises.SuspendLayout()
        Me.TabAlbum.SuspendLayout()
        Me.TabConciertos.SuspendLayout()
        Me.TabCanciones.SuspendLayout()
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
        Me.TabArtista.Controls.Add(Me.Artista_ComboBox_PaisArtista)
        Me.TabArtista.Controls.Add(Me.Artista_ListBox_Artistas)
        Me.TabArtista.Controls.Add(Me.Artista_Button_Limpiar)
        Me.TabArtista.Controls.Add(Me.Artista_Button_Eliminar)
        Me.TabArtista.Controls.Add(Me.Artista_Button_Agregar)
        Me.TabArtista.Controls.Add(Me.Artista_Button_Actualizar)
        Me.TabArtista.Controls.Add(Me.Artista_Label_PaisArtista)
        Me.TabArtista.Controls.Add(Me.Artista_TextBox_PaisArtista)
        Me.TabArtista.Controls.Add(Me.Artista_Label_NombreArtista)
        Me.TabArtista.Controls.Add(Me.Artista_TextBox_NombreArtista)
        Me.TabArtista.Controls.Add(Me.Artista_Button_VerTodosArtistas)
        Me.TabArtista.Controls.Add(Me.Artista_Label_Artistas)
        Me.TabArtista.Location = New System.Drawing.Point(4, 25)
        Me.TabArtista.Name = "TabArtista"
        Me.TabArtista.Padding = New System.Windows.Forms.Padding(3)
        Me.TabArtista.Size = New System.Drawing.Size(627, 502)
        Me.TabArtista.TabIndex = 1
        Me.TabArtista.Text = "Artista"
        Me.TabArtista.UseVisualStyleBackColor = True
        '
        'Artista_ComboBox_PaisArtista
        '
        Me.Artista_ComboBox_PaisArtista.FormattingEnabled = True
        Me.Artista_ComboBox_PaisArtista.Location = New System.Drawing.Point(257, 318)
        Me.Artista_ComboBox_PaisArtista.Name = "Artista_ComboBox_PaisArtista"
        Me.Artista_ComboBox_PaisArtista.Size = New System.Drawing.Size(119, 24)
        Me.Artista_ComboBox_PaisArtista.TabIndex = 12
        '
        'Artista_ListBox_Artistas
        '
        Me.Artista_ListBox_Artistas.FormattingEnabled = True
        Me.Artista_ListBox_Artistas.ItemHeight = 16
        Me.Artista_ListBox_Artistas.Location = New System.Drawing.Point(29, 49)
        Me.Artista_ListBox_Artistas.Name = "Artista_ListBox_Artistas"
        Me.Artista_ListBox_Artistas.Size = New System.Drawing.Size(267, 228)
        Me.Artista_ListBox_Artistas.TabIndex = 11
        '
        'Artista_Button_Limpiar
        '
        Me.Artista_Button_Limpiar.Location = New System.Drawing.Point(471, 236)
        Me.Artista_Button_Limpiar.Name = "Artista_Button_Limpiar"
        Me.Artista_Button_Limpiar.Size = New System.Drawing.Size(119, 39)
        Me.Artista_Button_Limpiar.TabIndex = 10
        Me.Artista_Button_Limpiar.Text = "LIMPIAR"
        Me.Artista_Button_Limpiar.UseVisualStyleBackColor = True
        '
        'Artista_Button_Eliminar
        '
        Me.Artista_Button_Eliminar.Location = New System.Drawing.Point(334, 236)
        Me.Artista_Button_Eliminar.Name = "Artista_Button_Eliminar"
        Me.Artista_Button_Eliminar.Size = New System.Drawing.Size(119, 39)
        Me.Artista_Button_Eliminar.TabIndex = 9
        Me.Artista_Button_Eliminar.Text = "ELIMINAR"
        Me.Artista_Button_Eliminar.UseVisualStyleBackColor = True
        '
        'Artista_Button_Agregar
        '
        Me.Artista_Button_Agregar.Location = New System.Drawing.Point(471, 175)
        Me.Artista_Button_Agregar.Name = "Artista_Button_Agregar"
        Me.Artista_Button_Agregar.Size = New System.Drawing.Size(119, 39)
        Me.Artista_Button_Agregar.TabIndex = 8
        Me.Artista_Button_Agregar.Text = "AGREGAR"
        Me.Artista_Button_Agregar.UseVisualStyleBackColor = True
        '
        'Artista_Button_Actualizar
        '
        Me.Artista_Button_Actualizar.Location = New System.Drawing.Point(334, 175)
        Me.Artista_Button_Actualizar.Name = "Artista_Button_Actualizar"
        Me.Artista_Button_Actualizar.Size = New System.Drawing.Size(119, 39)
        Me.Artista_Button_Actualizar.TabIndex = 7
        Me.Artista_Button_Actualizar.Text = "ACTUALIZAR"
        Me.Artista_Button_Actualizar.UseVisualStyleBackColor = True
        '
        'Artista_Label_PaisArtista
        '
        Me.Artista_Label_PaisArtista.AutoSize = True
        Me.Artista_Label_PaisArtista.Location = New System.Drawing.Point(348, 93)
        Me.Artista_Label_PaisArtista.Name = "Artista_Label_PaisArtista"
        Me.Artista_Label_PaisArtista.Size = New System.Drawing.Size(98, 16)
        Me.Artista_Label_PaisArtista.TabIndex = 6
        Me.Artista_Label_PaisArtista.Text = "País del artista:"
        '
        'Artista_TextBox_PaisArtista
        '
        Me.Artista_TextBox_PaisArtista.Location = New System.Drawing.Point(334, 120)
        Me.Artista_TextBox_PaisArtista.Name = "Artista_TextBox_PaisArtista"
        Me.Artista_TextBox_PaisArtista.Size = New System.Drawing.Size(256, 22)
        Me.Artista_TextBox_PaisArtista.TabIndex = 5
        '
        'Artista_Label_NombreArtista
        '
        Me.Artista_Label_NombreArtista.AutoSize = True
        Me.Artista_Label_NombreArtista.Location = New System.Drawing.Point(348, 27)
        Me.Artista_Label_NombreArtista.Name = "Artista_Label_NombreArtista"
        Me.Artista_Label_NombreArtista.Size = New System.Drawing.Size(120, 16)
        Me.Artista_Label_NombreArtista.TabIndex = 4
        Me.Artista_Label_NombreArtista.Text = "Nombre del artista:"
        '
        'Artista_TextBox_NombreArtista
        '
        Me.Artista_TextBox_NombreArtista.Location = New System.Drawing.Point(334, 49)
        Me.Artista_TextBox_NombreArtista.Name = "Artista_TextBox_NombreArtista"
        Me.Artista_TextBox_NombreArtista.Size = New System.Drawing.Size(256, 22)
        Me.Artista_TextBox_NombreArtista.TabIndex = 3
        '
        'Artista_Button_VerTodosArtistas
        '
        Me.Artista_Button_VerTodosArtistas.Location = New System.Drawing.Point(112, 10)
        Me.Artista_Button_VerTodosArtistas.Name = "Artista_Button_VerTodosArtistas"
        Me.Artista_Button_VerTodosArtistas.Size = New System.Drawing.Size(154, 28)
        Me.Artista_Button_VerTodosArtistas.TabIndex = 2
        Me.Artista_Button_VerTodosArtistas.Text = "Ver todos los Artistas"
        Me.Artista_Button_VerTodosArtistas.UseVisualStyleBackColor = True
        '
        'Artista_Label_Artistas
        '
        Me.Artista_Label_Artistas.AutoSize = True
        Me.Artista_Label_Artistas.Location = New System.Drawing.Point(43, 19)
        Me.Artista_Label_Artistas.Name = "Artista_Label_Artistas"
        Me.Artista_Label_Artistas.Size = New System.Drawing.Size(54, 16)
        Me.Artista_Label_Artistas.TabIndex = 1
        Me.Artista_Label_Artistas.Text = "Artistas:"
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
        'Paises_TextBox_NombrePais
        '
        Me.Paises_TextBox_NombrePais.Location = New System.Drawing.Point(328, 67)
        Me.Paises_TextBox_NombrePais.Name = "Paises_TextBox_NombrePais"
        Me.Paises_TextBox_NombrePais.Size = New System.Drawing.Size(265, 22)
        Me.Paises_TextBox_NombrePais.TabIndex = 12
        '
        'Paises_Label_Nombre
        '
        Me.Paises_Label_Nombre.AutoSize = True
        Me.Paises_Label_Nombre.Location = New System.Drawing.Point(351, 37)
        Me.Paises_Label_Nombre.Name = "Paises_Label_Nombre"
        Me.Paises_Label_Nombre.Size = New System.Drawing.Size(111, 16)
        Me.Paises_Label_Nombre.TabIndex = 11
        Me.Paises_Label_Nombre.Text = "Nombre del País:"
        '
        'Paises_Label_Paises
        '
        Me.Paises_Label_Paises.AutoSize = True
        Me.Paises_Label_Paises.Location = New System.Drawing.Point(41, 27)
        Me.Paises_Label_Paises.Name = "Paises_Label_Paises"
        Me.Paises_Label_Paises.Size = New System.Drawing.Size(52, 16)
        Me.Paises_Label_Paises.TabIndex = 10
        Me.Paises_Label_Paises.Text = "Paises:"
        '
        'Paises_Button_VerTodosPaises
        '
        Me.Paises_Button_VerTodosPaises.Location = New System.Drawing.Point(111, 18)
        Me.Paises_Button_VerTodosPaises.Name = "Paises_Button_VerTodosPaises"
        Me.Paises_Button_VerTodosPaises.Size = New System.Drawing.Size(146, 35)
        Me.Paises_Button_VerTodosPaises.TabIndex = 9
        Me.Paises_Button_VerTodosPaises.Text = "Ver todos los Paises"
        Me.Paises_Button_VerTodosPaises.UseVisualStyleBackColor = True
        '
        'Paises_ListBox_Paises
        '
        Me.Paises_ListBox_Paises.FormattingEnabled = True
        Me.Paises_ListBox_Paises.ItemHeight = 16
        Me.Paises_ListBox_Paises.Location = New System.Drawing.Point(25, 67)
        Me.Paises_ListBox_Paises.Name = "Paises_ListBox_Paises"
        Me.Paises_ListBox_Paises.Size = New System.Drawing.Size(262, 212)
        Me.Paises_ListBox_Paises.TabIndex = 8
        '
        'Paises_Button_Limpiar
        '
        Me.Paises_Button_Limpiar.Location = New System.Drawing.Point(473, 219)
        Me.Paises_Button_Limpiar.Name = "Paises_Button_Limpiar"
        Me.Paises_Button_Limpiar.Size = New System.Drawing.Size(120, 34)
        Me.Paises_Button_Limpiar.TabIndex = 7
        Me.Paises_Button_Limpiar.Text = "LIMPIAR"
        Me.Paises_Button_Limpiar.UseVisualStyleBackColor = True
        '
        'Paises_Button_Eliminar
        '
        Me.Paises_Button_Eliminar.Location = New System.Drawing.Point(328, 219)
        Me.Paises_Button_Eliminar.Name = "Paises_Button_Eliminar"
        Me.Paises_Button_Eliminar.Size = New System.Drawing.Size(120, 34)
        Me.Paises_Button_Eliminar.TabIndex = 6
        Me.Paises_Button_Eliminar.Text = "ELIMINAR"
        Me.Paises_Button_Eliminar.UseVisualStyleBackColor = True
        '
        'Paises_Button_Agregar
        '
        Me.Paises_Button_Agregar.Location = New System.Drawing.Point(473, 159)
        Me.Paises_Button_Agregar.Name = "Paises_Button_Agregar"
        Me.Paises_Button_Agregar.Size = New System.Drawing.Size(120, 34)
        Me.Paises_Button_Agregar.TabIndex = 5
        Me.Paises_Button_Agregar.Text = "AGREGAR"
        Me.Paises_Button_Agregar.UseVisualStyleBackColor = True
        '
        'Paises_Button_Actualizar
        '
        Me.Paises_Button_Actualizar.Location = New System.Drawing.Point(328, 159)
        Me.Paises_Button_Actualizar.Name = "Paises_Button_Actualizar"
        Me.Paises_Button_Actualizar.Size = New System.Drawing.Size(120, 34)
        Me.Paises_Button_Actualizar.TabIndex = 4
        Me.Paises_Button_Actualizar.Text = "ACTUALIZAR"
        Me.Paises_Button_Actualizar.UseVisualStyleBackColor = True
        '
        'Paises_ComboBox_Seleccionar
        '
        Me.Paises_ComboBox_Seleccionar.FormattingEnabled = True
        Me.Paises_ComboBox_Seleccionar.Location = New System.Drawing.Point(354, 336)
        Me.Paises_ComboBox_Seleccionar.Name = "Paises_ComboBox_Seleccionar"
        Me.Paises_ComboBox_Seleccionar.Size = New System.Drawing.Size(121, 24)
        Me.Paises_ComboBox_Seleccionar.TabIndex = 1
        '
        'Paises_LabelSeleccionar
        '
        Me.Paises_LabelSeleccionar.AutoSize = True
        Me.Paises_LabelSeleccionar.Location = New System.Drawing.Point(31, 339)
        Me.Paises_LabelSeleccionar.Name = "Paises_LabelSeleccionar"
        Me.Paises_LabelSeleccionar.Size = New System.Drawing.Size(307, 16)
        Me.Paises_LabelSeleccionar.TabIndex = 0
        Me.Paises_LabelSeleccionar.Text = "Selecciones el pais en el cual va a buscar artistas:"
        '
        'TabAlbum
        '
        Me.TabAlbum.Controls.Add(Me.Albumes_ButtonLimpiar)
        Me.TabAlbum.Controls.Add(Me.Albumes_ButtonEliminar)
        Me.TabAlbum.Controls.Add(Me.Albumes_ButtonAgregar)
        Me.TabAlbum.Controls.Add(Me.Albumes_ButtonActualizar)
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
        'Albumes_ButtonLimpiar
        '
        Me.Albumes_ButtonLimpiar.Location = New System.Drawing.Point(480, 431)
        Me.Albumes_ButtonLimpiar.Name = "Albumes_ButtonLimpiar"
        Me.Albumes_ButtonLimpiar.Size = New System.Drawing.Size(119, 44)
        Me.Albumes_ButtonLimpiar.TabIndex = 15
        Me.Albumes_ButtonLimpiar.Text = "LIMPIAR"
        Me.Albumes_ButtonLimpiar.UseVisualStyleBackColor = True
        '
        'Albumes_ButtonEliminar
        '
        Me.Albumes_ButtonEliminar.Location = New System.Drawing.Point(343, 431)
        Me.Albumes_ButtonEliminar.Name = "Albumes_ButtonEliminar"
        Me.Albumes_ButtonEliminar.Size = New System.Drawing.Size(119, 44)
        Me.Albumes_ButtonEliminar.TabIndex = 14
        Me.Albumes_ButtonEliminar.Text = "ELIMINAR"
        Me.Albumes_ButtonEliminar.UseVisualStyleBackColor = True
        '
        'Albumes_ButtonAgregar
        '
        Me.Albumes_ButtonAgregar.Location = New System.Drawing.Point(480, 368)
        Me.Albumes_ButtonAgregar.Name = "Albumes_ButtonAgregar"
        Me.Albumes_ButtonAgregar.Size = New System.Drawing.Size(119, 44)
        Me.Albumes_ButtonAgregar.TabIndex = 13
        Me.Albumes_ButtonAgregar.Text = "AGREGAR"
        Me.Albumes_ButtonAgregar.UseVisualStyleBackColor = True
        '
        'Albumes_ButtonActualizar
        '
        Me.Albumes_ButtonActualizar.Location = New System.Drawing.Point(343, 368)
        Me.Albumes_ButtonActualizar.Name = "Albumes_ButtonActualizar"
        Me.Albumes_ButtonActualizar.Size = New System.Drawing.Size(119, 44)
        Me.Albumes_ButtonActualizar.TabIndex = 12
        Me.Albumes_ButtonActualizar.Text = "ACTUALIZAR"
        Me.Albumes_ButtonActualizar.UseVisualStyleBackColor = True
        '
        'Albumes_LabelAñoAlbum
        '
        Me.Albumes_LabelAñoAlbum.AutoSize = True
        Me.Albumes_LabelAñoAlbum.Location = New System.Drawing.Point(31, 205)
        Me.Albumes_LabelAñoAlbum.Name = "Albumes_LabelAñoAlbum"
        Me.Albumes_LabelAñoAlbum.Size = New System.Drawing.Size(71, 16)
        Me.Albumes_LabelAñoAlbum.TabIndex = 11
        Me.Albumes_LabelAñoAlbum.Text = "Año álbum"
        '
        'Albumes_TextBoxAñoAlbum
        '
        Me.Albumes_TextBoxAñoAlbum.Location = New System.Drawing.Point(17, 232)
        Me.Albumes_TextBoxAñoAlbum.Name = "Albumes_TextBoxAñoAlbum"
        Me.Albumes_TextBoxAñoAlbum.Size = New System.Drawing.Size(256, 22)
        Me.Albumes_TextBoxAñoAlbum.TabIndex = 10
        '
        'Albumes_LabelNombre
        '
        Me.Albumes_LabelNombre.AutoSize = True
        Me.Albumes_LabelNombre.Location = New System.Drawing.Point(31, 139)
        Me.Albumes_LabelNombre.Name = "Albumes_LabelNombre"
        Me.Albumes_LabelNombre.Size = New System.Drawing.Size(118, 16)
        Me.Albumes_LabelNombre.TabIndex = 9
        Me.Albumes_LabelNombre.Text = "Nombre del álbum"
        '
        'Albumes_TextBoxNombreAlbum
        '
        Me.Albumes_TextBoxNombreAlbum.Location = New System.Drawing.Point(17, 161)
        Me.Albumes_TextBoxNombreAlbum.Name = "Albumes_TextBoxNombreAlbum"
        Me.Albumes_TextBoxNombreAlbum.Size = New System.Drawing.Size(256, 22)
        Me.Albumes_TextBoxNombreAlbum.TabIndex = 8
        '
        'Albumes_ListBoxAlbumes
        '
        Me.Albumes_ListBoxAlbumes.FormattingEnabled = True
        Me.Albumes_ListBoxAlbumes.ItemHeight = 16
        Me.Albumes_ListBoxAlbumes.Location = New System.Drawing.Point(401, 35)
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
        Me.TabConciertos.Controls.Add(Me.FechaEjemplo)
        Me.TabConciertos.Controls.Add(Me.Conciertos_TextBoxFecha)
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
        '
        'FechaEjemplo
        '
        Me.FechaEjemplo.AutoSize = True
        Me.FechaEjemplo.BackColor = System.Drawing.Color.Transparent
        Me.FechaEjemplo.ForeColor = System.Drawing.SystemColors.GrayText
        Me.FechaEjemplo.Location = New System.Drawing.Point(475, 53)
        Me.FechaEjemplo.Name = "FechaEjemplo"
        Me.FechaEjemplo.Size = New System.Drawing.Size(113, 16)
        Me.FechaEjemplo.TabIndex = 19
        Me.FechaEjemplo.Text = "Ejemplo: 19/03/23" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Conciertos_TextBoxFecha
        '
        Me.Conciertos_TextBoxFecha.Location = New System.Drawing.Point(324, 51)
        Me.Conciertos_TextBoxFecha.Name = "Conciertos_TextBoxFecha"
        Me.Conciertos_TextBoxFecha.Size = New System.Drawing.Size(143, 22)
        Me.Conciertos_TextBoxFecha.TabIndex = 18
        '
        'Conciertos_ListBoxTodosLosConciertos
        '
        Me.Conciertos_ListBoxTodosLosConciertos.FormattingEnabled = True
        Me.Conciertos_ListBoxTodosLosConciertos.ItemHeight = 16
        Me.Conciertos_ListBoxTodosLosConciertos.Location = New System.Drawing.Point(18, 135)
        Me.Conciertos_ListBoxTodosLosConciertos.Name = "Conciertos_ListBoxTodosLosConciertos"
        Me.Conciertos_ListBoxTodosLosConciertos.Size = New System.Drawing.Size(211, 308)
        Me.Conciertos_ListBoxTodosLosConciertos.TabIndex = 17
        '
        'Conciertos_LabelArtistaActua
        '
        Me.Conciertos_LabelArtistaActua.AutoSize = True
        Me.Conciertos_LabelArtistaActua.Location = New System.Drawing.Point(24, 22)
        Me.Conciertos_LabelArtistaActua.Name = "Conciertos_LabelArtistaActua"
        Me.Conciertos_LabelArtistaActua.Size = New System.Drawing.Size(180, 16)
        Me.Conciertos_LabelArtistaActua.TabIndex = 16
        Me.Conciertos_LabelArtistaActua.Text = "Seleccionar artista que actua"
        '
        'Conciertos_ButtonLimpiar
        '
        Me.Conciertos_ButtonLimpiar.Location = New System.Drawing.Point(468, 423)
        Me.Conciertos_ButtonLimpiar.Name = "Conciertos_ButtonLimpiar"
        Me.Conciertos_ButtonLimpiar.Size = New System.Drawing.Size(120, 46)
        Me.Conciertos_ButtonLimpiar.TabIndex = 15
        Me.Conciertos_ButtonLimpiar.Text = "LIMPIAR"
        Me.Conciertos_ButtonLimpiar.UseVisualStyleBackColor = True
        '
        'Conciertos_ButtonEliminar
        '
        Me.Conciertos_ButtonEliminar.Location = New System.Drawing.Point(326, 423)
        Me.Conciertos_ButtonEliminar.Name = "Conciertos_ButtonEliminar"
        Me.Conciertos_ButtonEliminar.Size = New System.Drawing.Size(120, 46)
        Me.Conciertos_ButtonEliminar.TabIndex = 14
        Me.Conciertos_ButtonEliminar.Text = "ELIMINAR"
        Me.Conciertos_ButtonEliminar.UseVisualStyleBackColor = True
        '
        'Conciertos_ButtonAgregar
        '
        Me.Conciertos_ButtonAgregar.Location = New System.Drawing.Point(468, 350)
        Me.Conciertos_ButtonAgregar.Name = "Conciertos_ButtonAgregar"
        Me.Conciertos_ButtonAgregar.Size = New System.Drawing.Size(120, 46)
        Me.Conciertos_ButtonAgregar.TabIndex = 13
        Me.Conciertos_ButtonAgregar.Text = "AGREGAR"
        Me.Conciertos_ButtonAgregar.UseVisualStyleBackColor = True
        '
        'Conciertos_ButtonActualizar
        '
        Me.Conciertos_ButtonActualizar.Location = New System.Drawing.Point(326, 350)
        Me.Conciertos_ButtonActualizar.Name = "Conciertos_ButtonActualizar"
        Me.Conciertos_ButtonActualizar.Size = New System.Drawing.Size(120, 46)
        Me.Conciertos_ButtonActualizar.TabIndex = 12
        Me.Conciertos_ButtonActualizar.Text = "ACTUALIZAR"
        Me.Conciertos_ButtonActualizar.UseVisualStyleBackColor = True
        '
        'Conciertos_ComboBoxSitiosDondeHayConcierto
        '
        Me.Conciertos_ComboBoxSitiosDondeHayConcierto.FormattingEnabled = True
        Me.Conciertos_ComboBoxSitiosDondeHayConcierto.Location = New System.Drawing.Point(326, 156)
        Me.Conciertos_ComboBoxSitiosDondeHayConcierto.Name = "Conciertos_ComboBoxSitiosDondeHayConcierto"
        Me.Conciertos_ComboBoxSitiosDondeHayConcierto.Size = New System.Drawing.Size(170, 24)
        Me.Conciertos_ComboBoxSitiosDondeHayConcierto.TabIndex = 11
        '
        'Conciertos_LabelSitiosDondeHayConciertos
        '
        Me.Conciertos_LabelSitiosDondeHayConciertos.AutoSize = True
        Me.Conciertos_LabelSitiosDondeHayConciertos.Location = New System.Drawing.Point(324, 122)
        Me.Conciertos_LabelSitiosDondeHayConciertos.Name = "Conciertos_LabelSitiosDondeHayConciertos"
        Me.Conciertos_LabelSitiosDondeHayConciertos.Size = New System.Drawing.Size(175, 16)
        Me.Conciertos_LabelSitiosDondeHayConciertos.TabIndex = 10
        Me.Conciertos_LabelSitiosDondeHayConciertos.Text = "Sitios donde hay conciertos:"
        '
        'Conciertos_LabelArtistasActuan
        '
        Me.Conciertos_LabelArtistasActuan.AutoSize = True
        Me.Conciertos_LabelArtistasActuan.Location = New System.Drawing.Point(16, 106)
        Me.Conciertos_LabelArtistasActuan.Name = "Conciertos_LabelArtistasActuan"
        Me.Conciertos_LabelArtistasActuan.Size = New System.Drawing.Size(144, 16)
        Me.Conciertos_LabelArtistasActuan.TabIndex = 8
        Me.Conciertos_LabelArtistasActuan.Text = "Conciertos disponibles"
        '
        'Conciertos_ComboBoxArtistaActua
        '
        Me.Conciertos_ComboBoxArtistaActua.FormattingEnabled = True
        Me.Conciertos_ComboBoxArtistaActua.Location = New System.Drawing.Point(18, 50)
        Me.Conciertos_ComboBoxArtistaActua.Name = "Conciertos_ComboBoxArtistaActua"
        Me.Conciertos_ComboBoxArtistaActua.Size = New System.Drawing.Size(211, 24)
        Me.Conciertos_ComboBoxArtistaActua.TabIndex = 5
        '
        'Conciertos_LabelArtistas
        '
        Me.Conciertos_LabelArtistas.AutoSize = True
        Me.Conciertos_LabelArtistas.Location = New System.Drawing.Point(324, 23)
        Me.Conciertos_LabelArtistas.Name = "Conciertos_LabelArtistas"
        Me.Conciertos_LabelArtistas.Size = New System.Drawing.Size(125, 16)
        Me.Conciertos_LabelArtistas.TabIndex = 2
        Me.Conciertos_LabelArtistas.Text = "Fecha del concierto"
        '
        'TabCanciones
        '
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
        '
        'Canciones_TextBoxDuracionCanciones
        '
        Me.Canciones_TextBoxDuracionCanciones.Location = New System.Drawing.Point(24, 171)
        Me.Canciones_TextBoxDuracionCanciones.Name = "Canciones_TextBoxDuracionCanciones"
        Me.Canciones_TextBoxDuracionCanciones.Size = New System.Drawing.Size(164, 22)
        Me.Canciones_TextBoxDuracionCanciones.TabIndex = 10
        '
        'Canciones_LabelDuracion
        '
        Me.Canciones_LabelDuracion.AutoSize = True
        Me.Canciones_LabelDuracion.Location = New System.Drawing.Point(21, 137)
        Me.Canciones_LabelDuracion.Name = "Canciones_LabelDuracion"
        Me.Canciones_LabelDuracion.Size = New System.Drawing.Size(147, 16)
        Me.Canciones_LabelDuracion.TabIndex = 9
        Me.Canciones_LabelDuracion.Text = "Duracion de la cancion:"
        '
        'Canciones_TextBoxNombreCanciones
        '
        Me.Canciones_TextBoxNombreCanciones.Location = New System.Drawing.Point(24, 67)
        Me.Canciones_TextBoxNombreCanciones.Name = "Canciones_TextBoxNombreCanciones"
        Me.Canciones_TextBoxNombreCanciones.Size = New System.Drawing.Size(164, 22)
        Me.Canciones_TextBoxNombreCanciones.TabIndex = 8
        '
        'Canciones_ListBoxTodasLasCanciones
        '
        Me.Canciones_ListBoxTodasLasCanciones.FormattingEnabled = True
        Me.Canciones_ListBoxTodasLasCanciones.ItemHeight = 16
        Me.Canciones_ListBoxTodasLasCanciones.Location = New System.Drawing.Point(340, 22)
        Me.Canciones_ListBoxTodasLasCanciones.Name = "Canciones_ListBoxTodasLasCanciones"
        Me.Canciones_ListBoxTodasLasCanciones.Size = New System.Drawing.Size(263, 276)
        Me.Canciones_ListBoxTodasLasCanciones.TabIndex = 7
        '
        'Canciones_ButtonLimpiar
        '
        Me.Canciones_ButtonLimpiar.Location = New System.Drawing.Point(480, 430)
        Me.Canciones_ButtonLimpiar.Name = "Canciones_ButtonLimpiar"
        Me.Canciones_ButtonLimpiar.Size = New System.Drawing.Size(123, 44)
        Me.Canciones_ButtonLimpiar.TabIndex = 6
        Me.Canciones_ButtonLimpiar.Text = "LIMPIAR"
        Me.Canciones_ButtonLimpiar.UseVisualStyleBackColor = True
        '
        'Canciones_ButtonEliminar
        '
        Me.Canciones_ButtonEliminar.Location = New System.Drawing.Point(340, 430)
        Me.Canciones_ButtonEliminar.Name = "Canciones_ButtonEliminar"
        Me.Canciones_ButtonEliminar.Size = New System.Drawing.Size(123, 44)
        Me.Canciones_ButtonEliminar.TabIndex = 5
        Me.Canciones_ButtonEliminar.Text = "ELIMINAR"
        Me.Canciones_ButtonEliminar.UseVisualStyleBackColor = True
        '
        'Canciones_ButtonAgregar
        '
        Me.Canciones_ButtonAgregar.Location = New System.Drawing.Point(480, 361)
        Me.Canciones_ButtonAgregar.Name = "Canciones_ButtonAgregar"
        Me.Canciones_ButtonAgregar.Size = New System.Drawing.Size(123, 44)
        Me.Canciones_ButtonAgregar.TabIndex = 4
        Me.Canciones_ButtonAgregar.Text = "AGREGAR"
        Me.Canciones_ButtonAgregar.UseVisualStyleBackColor = True
        '
        'Canciones_ButtonActualizar
        '
        Me.Canciones_ButtonActualizar.Location = New System.Drawing.Point(340, 361)
        Me.Canciones_ButtonActualizar.Name = "Canciones_ButtonActualizar"
        Me.Canciones_ButtonActualizar.Size = New System.Drawing.Size(123, 44)
        Me.Canciones_ButtonActualizar.TabIndex = 3
        Me.Canciones_ButtonActualizar.Text = "ACTUALIZAR"
        Me.Canciones_ButtonActualizar.UseVisualStyleBackColor = True
        '
        'Canciones_LabelNombreCancion
        '
        Me.Canciones_LabelNombreCancion.AutoSize = True
        Me.Canciones_LabelNombreCancion.Location = New System.Drawing.Point(21, 33)
        Me.Canciones_LabelNombreCancion.Name = "Canciones_LabelNombreCancion"
        Me.Canciones_LabelNombreCancion.Size = New System.Drawing.Size(142, 16)
        Me.Canciones_LabelNombreCancion.TabIndex = 1
        Me.Canciones_LabelNombreCancion.Text = "Nombre de la cancion:"
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
        Me.TabCanciones.ResumeLayout(False)
        Me.TabCanciones.PerformLayout()
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



    Friend WithEvents Artista_Label_Artistas As Label
    Friend WithEvents Artista_Label_NombreArtista As Label
    Friend WithEvents Artista_TextBox_NombreArtista As TextBox
    Friend WithEvents Artista_Button_VerTodosArtistas As Button
    Friend WithEvents Artista_Label_PaisArtista As Label
    Friend WithEvents Artista_TextBox_PaisArtista As TextBox




    Friend WithEvents Albumes_ListBoxAlbumes As ListBox
    Friend WithEvents Albumes_ButtonVerTodosLosArtistas As Button
    Friend WithEvents Albumes_ComboBoxArtistas As ComboBox
    Friend WithEvents Albumes_ButtonActualizar As Button
    Friend WithEvents Albumes_LabelAñoAlbum As Label
    Friend WithEvents Albumes_TextBoxAñoAlbum As TextBox
    Friend WithEvents Albumes_LabelNombre As Label
    Friend WithEvents Albumes_TextBoxNombreAlbum As TextBox
    Friend WithEvents Albumes_ButtonAgregar As Button
    Friend WithEvents Artista_Button_Eliminar As Button
    Friend WithEvents Artista_Button_Agregar As Button
    Friend WithEvents Artista_Button_Actualizar As Button
    Friend WithEvents Conciertos_LabelArtistas As Label
    Friend WithEvents Artista_Button_Limpiar As Button
    Friend WithEvents Paises_Button_Limpiar As Button
    Friend WithEvents Paises_Button_Eliminar As Button
    Friend WithEvents Paises_Button_Agregar As Button
    Friend WithEvents Paises_Button_Actualizar As Button
    Friend WithEvents Albumes_ButtonLimpiar As Button
    Friend WithEvents Albumes_ButtonEliminar As Button
    Friend WithEvents Paises_ListBox_Paises As ListBox
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
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FechaEjemplo As Label
    Friend WithEvents Conciertos_TextBoxFecha As TextBox
    Friend WithEvents Canciones_ButtonLimpiar As Button
    Friend WithEvents Canciones_ButtonEliminar As Button
    Friend WithEvents Canciones_ButtonAgregar As Button
    Friend WithEvents Canciones_ButtonActualizar As Button
    Friend WithEvents Canciones_LabelNombreCancion As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Canciones_TextBoxDuracionCanciones As TextBox
    Friend WithEvents Canciones_LabelDuracion As Label
    Friend WithEvents Canciones_TextBoxNombreCanciones As TextBox
    Friend WithEvents Canciones_ListBoxTodasLasCanciones As ListBox
    Friend WithEvents Artista_ListBox_Artistas As ListBox
    Friend WithEvents Paises_Button_VerTodosPaises As Button
    Friend WithEvents Paises_Label_Paises As Label
    Friend WithEvents Paises_Label_Nombre As Label
    Friend WithEvents Paises_TextBox_NombrePais As TextBox
    Friend WithEvents Artista_ComboBox_PaisArtista As ComboBox
End Class
