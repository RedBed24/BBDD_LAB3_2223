Public Class FormNavegacion

    Private Sub FormNavegacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarArtistas()
            CargarPaises()
            CargarSitios()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub CargarArtistas()
        Dim artistas As New Artista

        artistas.LeerTodosArtistas()

        For Each artista As Artista In artistas.ArtistDAO.Artistas
            Navegacion_ComboBox_Artista.Items.Add(artista)
        Next
    End Sub

    Private Sub CargarPaises()
        Dim paises As New Pais

        paises.LeerTodosPaises()

        For Each pais As Pais In paises.PaiDAO.Paises
            Navegacion_ComboBox_Pais.Items.Add(pais)
        Next
    End Sub

    Private Sub CargarSitios()
        Dim sitios As New Sitio

        sitios.LeerTodosSitios()

        For Each sitio As Sitio In sitios.SiteDAO.Sitios
            Navegacion_ComboBox_Sitio.Items.Add(sitio)
        Next
    End Sub

    Private Sub CargarCanciones(concierto As Concierto)
        Navegacion_ListBox_CancionesConcierto.Items.Clear()

        For Each cancion As Cancion In concierto.SetList
            Navegacion_ListBox_CancionesConcierto.Items.Add(cancion)
        Next

    End Sub

    Private Sub Navegacion1()
        Navegacion_ListBox_ConciertosNav1.Items.Clear()

        If Navegacion_ComboBox_Artista.SelectedItem Is Nothing Then
            Exit Sub
        End If

        Dim artista As Artista = Navegacion_ComboBox_Artista.SelectedItem

        Dim filtrarPorPais As Boolean = Navegaciones_CheckBox_FiltrarPais.Checked

        If filtrarPorPais And Navegacion_ComboBox_Pais.SelectedItem Is Nothing Then
            Exit Sub
        End If

        Dim pais As Pais = Navegacion_ComboBox_Pais.SelectedItem

        Dim conciertos As New Concierto

        Try
            If filtrarPorPais Then
                conciertos.LeerConciertosArtistaPais(artista, pais)
            Else
                conciertos.LeerConciertosArtista(artista)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        For Each concierto As Concierto In conciertos.ConciertDAO.Conciertos
            Navegacion_ListBox_ConciertosNav2.Items.Add(concierto)
        Next

    End Sub

    Private Sub Navegacion_ComboBox_Sitio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Navegacion_ComboBox_Sitio.SelectedIndexChanged
        Navegacion_ListBox_ConciertosNav2.Items.Clear()

        If Navegacion_ComboBox_Sitio.SelectedItem Is Nothing Then
            Exit Sub
        End If

        Dim sitio As Sitio = Navegacion_ComboBox_Sitio.SelectedItem

        Dim conciertos As New Concierto

        Try
            conciertos.LeerConciertosSitio(sitio)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        For Each concierto As Concierto In conciertos.ConciertDAO.Conciertos
            Navegacion_ListBox_ConciertosNav2.Items.Add(concierto)
        Next

    End Sub

    Private Sub Navegacion_ComboBox_Artista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Navegacion_ComboBox_Artista.SelectedIndexChanged
        Navegacion1()
    End Sub

    Private Sub Navegaciones_CheckBox_FiltrarPais_CheckedChanged(sender As Object, e As EventArgs) Handles Navegaciones_CheckBox_FiltrarPais.CheckedChanged
        Navegacion1()
    End Sub

    Private Sub Navegacion_ComboBox_Pais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Navegacion_ComboBox_Pais.SelectedIndexChanged
        Navegacion1()
    End Sub

    Private Sub Navegacion_ListBox_ConciertosNav1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Navegacion_ListBox_ConciertosNav1.SelectedIndexChanged
        If Navegacion_ListBox_ConciertosNav1.SelectedItem Is Nothing Then
            Exit Sub
        End If

        Dim concierto As Concierto = Navegacion_ListBox_ConciertosNav1.SelectedItem

        CargarCanciones(concierto)
    End Sub

    Private Sub Navegacion_ListBox_ConciertosNav2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Navegacion_ListBox_ConciertosNav2.SelectedIndexChanged
        If Navegacion_ListBox_ConciertosNav2.SelectedItem Is Nothing Then
            Exit Sub
        End If

        Dim concierto As Concierto = Navegacion_ListBox_ConciertosNav2.SelectedItem

        CargarCanciones(concierto)
    End Sub

End Class