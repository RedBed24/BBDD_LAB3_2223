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
        Me.Artista_TabArtista = New System.Windows.Forms.TabPage()
        Me.lblPaisArtista = New System.Windows.Forms.Label()
        Me.txtBoxPaisArtista = New System.Windows.Forms.TextBox()
        Me.Artista_lblNombreArtista = New System.Windows.Forms.Label()
        Me.txtBoxNombreArtista = New System.Windows.Forms.TextBox()
        Me.Artista_buttomVerTodosArtistas = New System.Windows.Forms.Button()
        Me.lblArtistas = New System.Windows.Forms.Label()
        Me.cmbBoxArtistas = New System.Windows.Forms.ComboBox()
        Me.TabPaises = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabAlbum = New System.Windows.Forms.TabPage()
        Me.TabConciertos = New System.Windows.Forms.TabPage()
        Me.TabCanciones = New System.Windows.Forms.TabPage()
        Me.TabSitio = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBoxConciertos = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TabControl.SuspendLayout()
        Me.Artista_TabArtista.SuspendLayout()
        Me.TabPaises.SuspendLayout()
        Me.TabConciertos.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.Artista_TabArtista)
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
        'Artista_TabArtista
        '
        Me.Artista_TabArtista.Controls.Add(Me.lblPaisArtista)
        Me.Artista_TabArtista.Controls.Add(Me.txtBoxPaisArtista)
        Me.Artista_TabArtista.Controls.Add(Me.Artista_lblNombreArtista)
        Me.Artista_TabArtista.Controls.Add(Me.txtBoxNombreArtista)
        Me.Artista_TabArtista.Controls.Add(Me.Artista_buttomVerTodosArtistas)
        Me.Artista_TabArtista.Controls.Add(Me.lblArtistas)
        Me.Artista_TabArtista.Controls.Add(Me.cmbBoxArtistas)
        Me.Artista_TabArtista.Location = New System.Drawing.Point(4, 25)
        Me.Artista_TabArtista.Name = "Artista_TabArtista"
        Me.Artista_TabArtista.Padding = New System.Windows.Forms.Padding(3)
        Me.Artista_TabArtista.Size = New System.Drawing.Size(627, 502)
        Me.Artista_TabArtista.TabIndex = 1
        Me.Artista_TabArtista.Text = "Artista"
        Me.Artista_TabArtista.UseVisualStyleBackColor = True
        '
        'lblPaisArtista
        '
        Me.lblPaisArtista.AutoSize = True
        Me.lblPaisArtista.Location = New System.Drawing.Point(331, 91)
        Me.lblPaisArtista.Name = "lblPaisArtista"
        Me.lblPaisArtista.Size = New System.Drawing.Size(95, 16)
        Me.lblPaisArtista.TabIndex = 6
        Me.lblPaisArtista.Text = "País del artista"
        '
        'txtBoxPaisArtista
        '
        Me.txtBoxPaisArtista.Location = New System.Drawing.Point(317, 118)
        Me.txtBoxPaisArtista.Name = "txtBoxPaisArtista"
        Me.txtBoxPaisArtista.Size = New System.Drawing.Size(256, 22)
        Me.txtBoxPaisArtista.TabIndex = 5
        '
        'Artista_lblNombreArtista
        '
        Me.Artista_lblNombreArtista.AutoSize = True
        Me.Artista_lblNombreArtista.Location = New System.Drawing.Point(331, 25)
        Me.Artista_lblNombreArtista.Name = "Artista_lblNombreArtista"
        Me.Artista_lblNombreArtista.Size = New System.Drawing.Size(120, 16)
        Me.Artista_lblNombreArtista.TabIndex = 4
        Me.Artista_lblNombreArtista.Text = "Nombre del artista:"
        '
        'txtBoxNombreArtista
        '
        Me.txtBoxNombreArtista.Location = New System.Drawing.Point(317, 47)
        Me.txtBoxNombreArtista.Name = "txtBoxNombreArtista"
        Me.txtBoxNombreArtista.Size = New System.Drawing.Size(256, 22)
        Me.txtBoxNombreArtista.TabIndex = 3
        '
        'Artista_buttomVerTodosArtistas
        '
        Me.Artista_buttomVerTodosArtistas.Location = New System.Drawing.Point(112, 10)
        Me.Artista_buttomVerTodosArtistas.Name = "Artista_buttomVerTodosArtistas"
        Me.Artista_buttomVerTodosArtistas.Size = New System.Drawing.Size(154, 28)
        Me.Artista_buttomVerTodosArtistas.TabIndex = 2
        Me.Artista_buttomVerTodosArtistas.Text = "Ver todos los Artistas"
        Me.Artista_buttomVerTodosArtistas.UseVisualStyleBackColor = True
        '
        'lblArtistas
        '
        Me.lblArtistas.AutoSize = True
        Me.lblArtistas.Location = New System.Drawing.Point(43, 19)
        Me.lblArtistas.Name = "lblArtistas"
        Me.lblArtistas.Size = New System.Drawing.Size(54, 16)
        Me.lblArtistas.TabIndex = 1
        Me.lblArtistas.Text = "Artistas:"
        '
        'cmbBoxArtistas
        '
        Me.cmbBoxArtistas.FormattingEnabled = True
        Me.cmbBoxArtistas.Location = New System.Drawing.Point(22, 47)
        Me.cmbBoxArtistas.Name = "cmbBoxArtistas"
        Me.cmbBoxArtistas.Size = New System.Drawing.Size(256, 24)
        Me.cmbBoxArtistas.TabIndex = 0
        '
        'TabPaises
        '
        Me.TabPaises.Controls.Add(Me.Label3)
        Me.TabPaises.Controls.Add(Me.TextBox1)
        Me.TabPaises.Controls.Add(Me.Label2)
        Me.TabPaises.Controls.Add(Me.ComboBox1)
        Me.TabPaises.Controls.Add(Me.Label1)
        Me.TabPaises.Location = New System.Drawing.Point(4, 25)
        Me.TabPaises.Name = "TabPaises"
        Me.TabPaises.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPaises.Size = New System.Drawing.Size(627, 502)
        Me.TabPaises.TabIndex = 0
        Me.TabPaises.Text = "Paises"
        Me.TabPaises.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 391)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(205, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "¿Desea agregar algún pais?"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(331, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selecciones el pais en el cual va a buscar artistas:"
        '
        'TabAlbum
        '
        Me.TabAlbum.Location = New System.Drawing.Point(4, 25)
        Me.TabAlbum.Name = "TabAlbum"
        Me.TabAlbum.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAlbum.Size = New System.Drawing.Size(627, 502)
        Me.TabAlbum.TabIndex = 2
        Me.TabAlbum.Text = "Albumes"
        Me.TabAlbum.UseVisualStyleBackColor = True
        '
        'TabConciertos
        '
        Me.TabConciertos.Controls.Add(Me.TextBox2)
        Me.TabConciertos.Controls.Add(Me.Label5)
        Me.TabConciertos.Controls.Add(Me.ListBoxConciertos)
        Me.TabConciertos.Controls.Add(Me.Label4)
        Me.TabConciertos.Location = New System.Drawing.Point(4, 25)
        Me.TabConciertos.Name = "TabConciertos"
        Me.TabConciertos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabConciertos.Size = New System.Drawing.Size(627, 502)
        Me.TabConciertos.TabIndex = 3
        Me.TabConciertos.Text = "Conciertos"
        Me.TabConciertos.UseVisualStyleBackColor = True
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Ver todos los conciertos"
        '
        'ListBoxConciertos
        '
        Me.ListBoxConciertos.FormattingEnabled = True
        Me.ListBoxConciertos.ItemHeight = 16
        Me.ListBoxConciertos.Location = New System.Drawing.Point(20, 47)
        Me.ListBoxConciertos.Name = "ListBoxConciertos"
        Me.ListBoxConciertos.Size = New System.Drawing.Size(148, 244)
        Me.ListBoxConciertos.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(365, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "¿Desea agregar algun concierto nuevo?"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(368, 68)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(208, 22)
        Me.TextBox2.TabIndex = 3
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
        Me.Artista_TabArtista.ResumeLayout(False)
        Me.Artista_TabArtista.PerformLayout()
        Me.TabPaises.ResumeLayout(False)
        Me.TabPaises.PerformLayout()
        Me.TabConciertos.ResumeLayout(False)
        Me.TabConciertos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPaises As TabPage
    Friend WithEvents Artista_TabArtista As TabPage
    Friend WithEvents TabAlbum As TabPage
    Friend WithEvents TabConciertos As TabPage
    Friend WithEvents TabCanciones As TabPage
    Friend WithEvents TabSitio As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblArtistas As Label
    Friend WithEvents cmbBoxArtistas As ComboBox
    Friend WithEvents Artista_lblNombreArtista As Label
    Friend WithEvents txtBoxNombreArtista As TextBox
    Friend WithEvents Artista_buttomVerTodosArtistas As Button
    Friend WithEvents lblPaisArtista As Label
    Friend WithEvents txtBoxPaisArtista As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBoxConciertos As ListBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
End Class
