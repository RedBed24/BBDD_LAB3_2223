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
        Me.SuspendLayout()
        '
        'Listados_ComboBox_Artista
        '
        Me.Listados_ComboBox_Artista.FormattingEnabled = True
        Me.Listados_ComboBox_Artista.Location = New System.Drawing.Point(11, 24)
        Me.Listados_ComboBox_Artista.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.Listados_ListBox_AlbumesMasInterpretados.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Listados_ListBox_AlbumesMasInterpretados.Name = "Listados_ListBox_AlbumesMasInterpretados"
        Me.Listados_ListBox_AlbumesMasInterpretados.Size = New System.Drawing.Size(192, 108)
        Me.Listados_ListBox_AlbumesMasInterpretados.TabIndex = 2
        '
        'Listados_ListBox_ArtistasAlbumCompleto
        '
        Me.Listados_ListBox_ArtistasAlbumCompleto.FormattingEnabled = True
        Me.Listados_ListBox_ArtistasAlbumCompleto.Location = New System.Drawing.Point(225, 24)
        Me.Listados_ListBox_ArtistasAlbumCompleto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Listados_ListBox_ArtistasAlbumCompleto.Name = "Listados_ListBox_ArtistasAlbumCompleto"
        Me.Listados_ListBox_ArtistasAlbumCompleto.Size = New System.Drawing.Size(126, 121)
        Me.Listados_ListBox_ArtistasAlbumCompleto.TabIndex = 3
        '
        'Listados_DateTimePicker_FechaInicio
        '
        Me.Listados_DateTimePicker_FechaInicio.Location = New System.Drawing.Point(367, 25)
        Me.Listados_DateTimePicker_FechaInicio.Name = "Listados_DateTimePicker_FechaInicio"
        Me.Listados_DateTimePicker_FechaInicio.Size = New System.Drawing.Size(191, 20)
        Me.Listados_DateTimePicker_FechaInicio.TabIndex = 5
        '
        'Listados_DateTimePicker_FechaFin
        '
        Me.Listados_DateTimePicker_FechaFin.Location = New System.Drawing.Point(367, 69)
        Me.Listados_DateTimePicker_FechaFin.Name = "Listados_DateTimePicker_FechaFin"
        Me.Listados_DateTimePicker_FechaFin.Size = New System.Drawing.Size(191, 20)
        Me.Listados_DateTimePicker_FechaFin.TabIndex = 6
        '
        'Listados_ListBox_ArtistasMasConcietos
        '
        Me.Listados_ListBox_ArtistasMasConcietos.FormattingEnabled = True
        Me.Listados_ListBox_ArtistasMasConcietos.Location = New System.Drawing.Point(367, 111)
        Me.Listados_ListBox_ArtistasMasConcietos.Name = "Listados_ListBox_ArtistasMasConcietos"
        Me.Listados_ListBox_ArtistasMasConcietos.Size = New System.Drawing.Size(191, 69)
        Me.Listados_ListBox_ArtistasMasConcietos.TabIndex = 7
        '
        'Listados_ListBox_PaisesMasConciertos
        '
        Me.Listados_ListBox_PaisesMasConciertos.FormattingEnabled = True
        Me.Listados_ListBox_PaisesMasConciertos.Location = New System.Drawing.Point(367, 206)
        Me.Listados_ListBox_PaisesMasConciertos.Name = "Listados_ListBox_PaisesMasConciertos"
        Me.Listados_ListBox_PaisesMasConciertos.Size = New System.Drawing.Size(191, 82)
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
        Me.Listados_ListBox_CancionesMasIntepretadas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Listados_ListBox_CancionesMasIntepretadas.Name = "Listados_ListBox_CancionesMasIntepretadas"
        Me.Listados_ListBox_CancionesMasIntepretadas.Size = New System.Drawing.Size(126, 108)
        Me.Listados_ListBox_CancionesMasIntepretadas.TabIndex = 11
        '
        'FormListados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 299)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
End Class
