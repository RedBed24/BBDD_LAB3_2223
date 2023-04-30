<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormListados
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
        Me.Listados_ComboBox_Artista = New System.Windows.Forms.ComboBox()
        Me.Listados_ListBox_CancionesMasInterpretadasArtista = New System.Windows.Forms.ListBox()
        Me.Listados_ListBox_AlbumesMasInterpretados = New System.Windows.Forms.ListBox()
        Me.Listados_ListBox_ArtistasAlbumCompleto = New System.Windows.Forms.ListBox()
        Me.Listados_DateTimePicker_FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Listados_DateTimePicker_FechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Listados_ListBox_ArtistasMasConcietos = New System.Windows.Forms.ListBox()
        Me.Listados_ListBox_PaisesMasConciertos = New System.Windows.Forms.ListBox()
        Me.Listados_Label_FiltrarArtista = New System.Windows.Forms.Label()
        Me.Listados_Label_CancionesMasInterpretadas = New System.Windows.Forms.Label()
        Me.Listados_ListBox_CancionesMasIntepretadas = New System.Windows.Forms.ListBox()
        Me.Listados_Label_AlbumesMasIntepretados = New System.Windows.Forms.Label()
        Me.Listados_Label_RankingCanciones = New System.Windows.Forms.Label()
        Me.Listados_Label_ArtistasAlbumCompleto = New System.Windows.Forms.Label()
        Me.Listados_Label_FechaInicio = New System.Windows.Forms.Label()
        Me.Listados_Label_FechaFin = New System.Windows.Forms.Label()
        Me.Listados_Label_RankingArtistasConcierto = New System.Windows.Forms.Label()
        Me.Listados_Label_RankingPaisesConciertos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Listados_ComboBox_Artista
        '
        Me.Listados_ComboBox_Artista.FormattingEnabled = True
        Me.Listados_ComboBox_Artista.Location = New System.Drawing.Point(11, 24)
        Me.Listados_ComboBox_Artista.Margin = New System.Windows.Forms.Padding(2)
        Me.Listados_ComboBox_Artista.Name = "Listados_ComboBox_Artista"
        Me.Listados_ComboBox_Artista.Size = New System.Drawing.Size(192, 21)
        Me.Listados_ComboBox_Artista.TabIndex = 0
        '
        'Listados_ListBox_CancionesMasInterpretadasArtista
        '
        Me.Listados_ListBox_CancionesMasInterpretadasArtista.FormattingEnabled = True
        Me.Listados_ListBox_CancionesMasInterpretadasArtista.Location = New System.Drawing.Point(11, 69)
        Me.Listados_ListBox_CancionesMasInterpretadasArtista.Margin = New System.Windows.Forms.Padding(2)
        Me.Listados_ListBox_CancionesMasInterpretadasArtista.Name = "Listados_ListBox_CancionesMasInterpretadasArtista"
        Me.Listados_ListBox_CancionesMasInterpretadasArtista.Size = New System.Drawing.Size(192, 82)
        Me.Listados_ListBox_CancionesMasInterpretadasArtista.TabIndex = 1
        '
        'Listados_ListBox_AlbumesMasInterpretados
        '
        Me.Listados_ListBox_AlbumesMasInterpretados.FormattingEnabled = True
        Me.Listados_ListBox_AlbumesMasInterpretados.Location = New System.Drawing.Point(11, 180)
        Me.Listados_ListBox_AlbumesMasInterpretados.Margin = New System.Windows.Forms.Padding(2)
        Me.Listados_ListBox_AlbumesMasInterpretados.Name = "Listados_ListBox_AlbumesMasInterpretados"
        Me.Listados_ListBox_AlbumesMasInterpretados.Size = New System.Drawing.Size(192, 108)
        Me.Listados_ListBox_AlbumesMasInterpretados.TabIndex = 2
        '
        'Listados_ListBox_ArtistasAlbumCompleto
        '
        Me.Listados_ListBox_ArtistasAlbumCompleto.FormattingEnabled = True
        Me.Listados_ListBox_ArtistasAlbumCompleto.Location = New System.Drawing.Point(225, 24)
        Me.Listados_ListBox_ArtistasAlbumCompleto.Margin = New System.Windows.Forms.Padding(2)
        Me.Listados_ListBox_ArtistasAlbumCompleto.Name = "Listados_ListBox_ArtistasAlbumCompleto"
        Me.Listados_ListBox_ArtistasAlbumCompleto.Size = New System.Drawing.Size(153, 121)
        Me.Listados_ListBox_ArtistasAlbumCompleto.TabIndex = 3
        '
        'Listados_DateTimePicker_FechaInicio
        '
        Me.Listados_DateTimePicker_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Listados_DateTimePicker_FechaInicio.Location = New System.Drawing.Point(398, 25)
        Me.Listados_DateTimePicker_FechaInicio.Name = "Listados_DateTimePicker_FechaInicio"
        Me.Listados_DateTimePicker_FechaInicio.Size = New System.Drawing.Size(160, 20)
        Me.Listados_DateTimePicker_FechaInicio.TabIndex = 5
        '
        'Listados_DateTimePicker_FechaFin
        '
        Me.Listados_DateTimePicker_FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Listados_DateTimePicker_FechaFin.Location = New System.Drawing.Point(398, 69)
        Me.Listados_DateTimePicker_FechaFin.Name = "Listados_DateTimePicker_FechaFin"
        Me.Listados_DateTimePicker_FechaFin.Size = New System.Drawing.Size(160, 20)
        Me.Listados_DateTimePicker_FechaFin.TabIndex = 6
        '
        'Listados_ListBox_ArtistasMasConcietos
        '
        Me.Listados_ListBox_ArtistasMasConcietos.FormattingEnabled = True
        Me.Listados_ListBox_ArtistasMasConcietos.Location = New System.Drawing.Point(398, 111)
        Me.Listados_ListBox_ArtistasMasConcietos.Name = "Listados_ListBox_ArtistasMasConcietos"
        Me.Listados_ListBox_ArtistasMasConcietos.Size = New System.Drawing.Size(160, 69)
        Me.Listados_ListBox_ArtistasMasConcietos.TabIndex = 7
        '
        'Listados_ListBox_PaisesMasConciertos
        '
        Me.Listados_ListBox_PaisesMasConciertos.FormattingEnabled = True
        Me.Listados_ListBox_PaisesMasConciertos.Location = New System.Drawing.Point(398, 206)
        Me.Listados_ListBox_PaisesMasConciertos.Name = "Listados_ListBox_PaisesMasConciertos"
        Me.Listados_ListBox_PaisesMasConciertos.Size = New System.Drawing.Size(160, 82)
        Me.Listados_ListBox_PaisesMasConciertos.TabIndex = 8
        '
        'Listados_Label_FiltrarArtista
        '
        Me.Listados_Label_FiltrarArtista.AutoSize = True
        Me.Listados_Label_FiltrarArtista.Location = New System.Drawing.Point(12, 9)
        Me.Listados_Label_FiltrarArtista.Name = "Listados_Label_FiltrarArtista"
        Me.Listados_Label_FiltrarArtista.Size = New System.Drawing.Size(102, 13)
        Me.Listados_Label_FiltrarArtista.TabIndex = 9
        Me.Listados_Label_FiltrarArtista.Text = "Artista a seleccionar"
        '
        'Listados_Label_CancionesMasInterpretadas
        '
        Me.Listados_Label_CancionesMasInterpretadas.AutoSize = True
        Me.Listados_Label_CancionesMasInterpretadas.Location = New System.Drawing.Point(12, 54)
        Me.Listados_Label_CancionesMasInterpretadas.Name = "Listados_Label_CancionesMasInterpretadas"
        Me.Listados_Label_CancionesMasInterpretadas.Size = New System.Drawing.Size(191, 13)
        Me.Listados_Label_CancionesMasInterpretadas.TabIndex = 10
        Me.Listados_Label_CancionesMasInterpretadas.Text = "Canciones mas interpretadas del artista"
        '
        'Listados_ListBox_CancionesMasIntepretadas
        '
        Me.Listados_ListBox_CancionesMasIntepretadas.FormattingEnabled = True
        Me.Listados_ListBox_CancionesMasIntepretadas.Location = New System.Drawing.Point(225, 180)
        Me.Listados_ListBox_CancionesMasIntepretadas.Margin = New System.Windows.Forms.Padding(2)
        Me.Listados_ListBox_CancionesMasIntepretadas.Name = "Listados_ListBox_CancionesMasIntepretadas"
        Me.Listados_ListBox_CancionesMasIntepretadas.Size = New System.Drawing.Size(153, 108)
        Me.Listados_ListBox_CancionesMasIntepretadas.TabIndex = 11
        '
        'Listados_Label_AlbumesMasIntepretados
        '
        Me.Listados_Label_AlbumesMasIntepretados.AutoSize = True
        Me.Listados_Label_AlbumesMasIntepretados.Location = New System.Drawing.Point(8, 165)
        Me.Listados_Label_AlbumesMasIntepretados.Name = "Listados_Label_AlbumesMasIntepretados"
        Me.Listados_Label_AlbumesMasIntepretados.Size = New System.Drawing.Size(181, 13)
        Me.Listados_Label_AlbumesMasIntepretados.TabIndex = 12
        Me.Listados_Label_AlbumesMasIntepretados.Text = "Álbumes mas interpretados del artista"
        '
        'Listados_Label_RankingCanciones
        '
        Me.Listados_Label_RankingCanciones.AutoSize = True
        Me.Listados_Label_RankingCanciones.Location = New System.Drawing.Point(222, 165)
        Me.Listados_Label_RankingCanciones.Name = "Listados_Label_RankingCanciones"
        Me.Listados_Label_RankingCanciones.Size = New System.Drawing.Size(100, 13)
        Me.Listados_Label_RankingCanciones.TabIndex = 13
        Me.Listados_Label_RankingCanciones.Text = "Ranking Canciones"
        '
        'Listados_Label_ArtistasAlbumCompleto
        '
        Me.Listados_Label_ArtistasAlbumCompleto.AutoSize = True
        Me.Listados_Label_ArtistasAlbumCompleto.Location = New System.Drawing.Point(222, 9)
        Me.Listados_Label_ArtistasAlbumCompleto.Name = "Listados_Label_ArtistasAlbumCompleto"
        Me.Listados_Label_ArtistasAlbumCompleto.Size = New System.Drawing.Size(139, 13)
        Me.Listados_Label_ArtistasAlbumCompleto.TabIndex = 14
        Me.Listados_Label_ArtistasAlbumCompleto.Text = "Artistas con album completo"
        '
        'Listados_Label_FechaInicio
        '
        Me.Listados_Label_FechaInicio.AutoSize = True
        Me.Listados_Label_FechaInicio.Location = New System.Drawing.Point(395, 9)
        Me.Listados_Label_FechaInicio.Name = "Listados_Label_FechaInicio"
        Me.Listados_Label_FechaInicio.Size = New System.Drawing.Size(65, 13)
        Me.Listados_Label_FechaInicio.TabIndex = 15
        Me.Listados_Label_FechaInicio.Text = "Fecha Inicio"
        '
        'Listados_Label_FechaFin
        '
        Me.Listados_Label_FechaFin.AutoSize = True
        Me.Listados_Label_FechaFin.Location = New System.Drawing.Point(395, 54)
        Me.Listados_Label_FechaFin.Name = "Listados_Label_FechaFin"
        Me.Listados_Label_FechaFin.Size = New System.Drawing.Size(54, 13)
        Me.Listados_Label_FechaFin.TabIndex = 16
        Me.Listados_Label_FechaFin.Text = "Fecha Fin"
        '
        'Listados_Label_RankingArtistasConcierto
        '
        Me.Listados_Label_RankingArtistasConcierto.AutoSize = True
        Me.Listados_Label_RankingArtistasConcierto.Location = New System.Drawing.Point(395, 95)
        Me.Listados_Label_RankingArtistasConcierto.Name = "Listados_Label_RankingArtistasConcierto"
        Me.Listados_Label_RankingArtistasConcierto.Size = New System.Drawing.Size(130, 13)
        Me.Listados_Label_RankingArtistasConcierto.TabIndex = 17
        Me.Listados_Label_RankingArtistasConcierto.Text = "Ranking artistas concierto"
        '
        'Listados_Label_RankingPaisesConciertos
        '
        Me.Listados_Label_RankingPaisesConciertos.AutoSize = True
        Me.Listados_Label_RankingPaisesConciertos.Location = New System.Drawing.Point(395, 190)
        Me.Listados_Label_RankingPaisesConciertos.Name = "Listados_Label_RankingPaisesConciertos"
        Me.Listados_Label_RankingPaisesConciertos.Size = New System.Drawing.Size(133, 13)
        Me.Listados_Label_RankingPaisesConciertos.TabIndex = 18
        Me.Listados_Label_RankingPaisesConciertos.Text = "Ranking paieses concierto"
        '
        'FormListados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 299)
        Me.Controls.Add(Me.Listados_Label_RankingPaisesConciertos)
        Me.Controls.Add(Me.Listados_Label_RankingArtistasConcierto)
        Me.Controls.Add(Me.Listados_Label_FechaFin)
        Me.Controls.Add(Me.Listados_Label_FechaInicio)
        Me.Controls.Add(Me.Listados_Label_ArtistasAlbumCompleto)
        Me.Controls.Add(Me.Listados_Label_RankingCanciones)
        Me.Controls.Add(Me.Listados_Label_AlbumesMasIntepretados)
        Me.Controls.Add(Me.Listados_ListBox_CancionesMasIntepretadas)
        Me.Controls.Add(Me.Listados_Label_CancionesMasInterpretadas)
        Me.Controls.Add(Me.Listados_Label_FiltrarArtista)
        Me.Controls.Add(Me.Listados_ListBox_PaisesMasConciertos)
        Me.Controls.Add(Me.Listados_ListBox_ArtistasMasConcietos)
        Me.Controls.Add(Me.Listados_DateTimePicker_FechaFin)
        Me.Controls.Add(Me.Listados_DateTimePicker_FechaInicio)
        Me.Controls.Add(Me.Listados_ListBox_ArtistasAlbumCompleto)
        Me.Controls.Add(Me.Listados_ListBox_AlbumesMasInterpretados)
        Me.Controls.Add(Me.Listados_ListBox_CancionesMasInterpretadasArtista)
        Me.Controls.Add(Me.Listados_ComboBox_Artista)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormListados"
        Me.Text = "FormListados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Listados_ComboBox_Artista As ComboBox
    Friend WithEvents Listados_ListBox_CancionesMasInterpretadasArtista As ListBox
    Friend WithEvents Listados_ListBox_AlbumesMasInterpretados As ListBox
    Friend WithEvents Listados_ListBox_ArtistasAlbumCompleto As ListBox
    Friend WithEvents Listados_DateTimePicker_FechaInicio As DateTimePicker
    Friend WithEvents Listados_DateTimePicker_FechaFin As DateTimePicker
    Friend WithEvents Listados_ListBox_ArtistasMasConcietos As ListBox
    Friend WithEvents Listados_ListBox_PaisesMasConciertos As ListBox
    Friend WithEvents Listados_Label_FiltrarArtista As Label
    Friend WithEvents Listados_Label_CancionesMasInterpretadas As Label
    Friend WithEvents Listados_ListBox_CancionesMasIntepretadas As ListBox
    Friend WithEvents Listados_Label_AlbumesMasIntepretados As Label
    Friend WithEvents Listados_Label_RankingCanciones As Label
    Friend WithEvents Listados_Label_ArtistasAlbumCompleto As Label
    Friend WithEvents Listados_Label_FechaInicio As Label
    Friend WithEvents Listados_Label_FechaFin As Label
    Friend WithEvents Listados_Label_RankingArtistasConcierto As Label
    Friend WithEvents Listados_Label_RankingPaisesConciertos As Label
End Class
