Public Class FormListados

    Private Sub FormListados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarArtistas()
            CargarArtistasAlbumCompleto()
            CargarCancionesMasInterpretadas()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Listados_ComboBox_Artista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Listados_ComboBox_Artista.SelectedIndexChanged
        If Listados_ComboBox_Artista.SelectedItem Is Nothing Then
            Exit Sub
        End If

        Dim artista As Artista = Listados_ComboBox_Artista.SelectedItem

        Try
            CargarCancionesMasInterpretadas(artista)
            CargarAlbumesMasInterpretados(artista)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub CargarArtistas()
        Dim artistat As New Artista

        artistat.LeerTodosArtistas()

        For Each artista As Artista In artistat.ArtistDAO.Artistas
            Listados_ComboBox_Artista.Items.Add(artista)
        Next
    End Sub

    Private Sub CargarArtistasAlbumCompleto()
        Dim artistat As New Artista

        artistat.LeerArtistasQueInterpretaronUnAlbumCompleto()

        For Each artista As Artista In artistat.ArtistDAO.Artistas
            Listados_ComboBox_Artista.Items.Add(artista)
        Next
    End Sub

    Private Sub CargarCancionesMasInterpretadas()
        Dim canciones As New Cancion

        canciones.LeerCancionesCuentaMasInterpretadas()

        For Each cancion In canciones.CancioDAO.Canciones
            Listados_ComboBox_Artista.Items.Add(cancion)
        Next
    End Sub

    Private Sub CargarCancionesMasInterpretadas(artista As Artista)
        Dim canciones As New Cancion()

        canciones.LeerCancionesCuentaMasInterpretadas(artista)

        For Each cancion As Cancion In canciones.CancioDAO.Canciones
            Listados_ListBox_CancionesMasInterpretadasArtista.Items.Add(cancion)
        Next
    End Sub

    Private Sub CargarAlbumesMasInterpretados(artista As Artista)
        Dim albumes As New Album()

        albumes.LeerAlbumesMasInterpretadosArtista(artista)

        For Each album As Album In albumes.AlbuDAO.Albumes
            Listados_ListBox_AlbumesMasInterpretados.Items.Add(artista)
        Next
    End Sub

End Class