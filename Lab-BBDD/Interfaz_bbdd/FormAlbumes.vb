Public Class FormAlbumes

    Private Sub FormAlbumes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim artistat As New Artista
        artistat.LeerTodosArtistas()

        For Each artista As Artista In artistat.ArtistDAO.Artistas
            Albumes_ComboBoxArtistas.Items.Add(artista)
        Next
    End Sub

    Private Sub Albumes_ButtonVerTodosAlbumes_Click(sender As Object, e As EventArgs) Handles Albumes_Button_VerTodosAlbumes.Click
        Albumes_Button_Limpiar.PerformClick()

        Dim albumes As New Album

        Try
            albumes.LeerTodosAlbumes()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        For Each album As Album In albumes.AlbuDAO.Albumes
            Albumes_ListBox_Albumes.Items.Add(album)
        Next
    End Sub

    Private Sub Albumes_ListBoxAlbumes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Albumes_ListBox_Albumes.SelectedIndexChanged

        If Albumes_ListBox_Albumes.SelectedItem Is Nothing Then
            Exit Sub
        End If

        Albumes_Button_Actualizar.Enabled = True
        Albumes_Button_Eliminar.Enabled = True

        Dim album As Album = Albumes_ListBox_Albumes.SelectedItem

        Albumes_TextBoxNombreAlbum.Text = album.NombreAlbum
        Albumes_TextBoxAñoAlbum.Text = album.AñoAlbum

        For Each item As Artista In Albumes_ComboBoxArtistas.Items
            If item.IdArtista = album.Artist.IdArtista Then
                Albumes_ComboBoxArtistas.SelectedItem = item
                Exit For
            End If
        Next

    End Sub

    Private Sub Albumes_ButtonAgregar_Click(sender As Object, e As EventArgs) Handles Albumes_Button_Agregar.Click

        Dim nombre As String = Albumes_TextBoxNombreAlbum.Text
        Dim año As String = Albumes_TextBoxAñoAlbum.Text

        If String.IsNullOrEmpty(nombre) Then
            MessageBox.Show("El album debe tener un nombre.")
            Exit Sub
        End If
        If String.IsNullOrEmpty(año) Then
            MessageBox.Show("El album debe tener un año.")
            Exit Sub
        End If

        Dim añoInt As Integer = CInt(año)
        If añoInt < 1860 Or añoInt > 2023 Then
            MessageBox.Show("El programa no permite añadir a la base de datos canciones de antes del año 1860 ni de después del año 2023")
            Exit Sub
        End If

        Dim artistaAlbum As Artista = Albumes_ComboBoxArtistas.SelectedItem
        Dim nombreArtista As String = artistaAlbum.Nombre
        If String.IsNullOrEmpty(nombreArtista) Then
            MessageBox.Show("Debe seleccionar un artista primero.")
            Exit Sub
        End If

        Dim albumAnadir As New Album(nombre, añoInt, artistaAlbum)

        Try
            If albumAnadir.InsertarAlbum() <> 1 Then
                MessageBox.Show("wtf cómo puede ocurrir esto?")
                Exit Sub
            End If
        Catch ex As Exception
            ' no se puede añadir
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show(albumAnadir.ToString & " añadido correctamente")
        Albumes_ListBox_Albumes.Items.Add(albumAnadir)
        Albumes_ComboBoxArtistas.SelectedItem = albumAnadir

    End Sub

    Private Sub Albumes_ButtonActualizar_Click(sender As Object, e As EventArgs) Handles Albumes_Button_Actualizar.Click

        Dim nombrenuevo As String = Albumes_TextBoxNombreAlbum.Text
        Dim añonuevo As String = Albumes_TextBoxAñoAlbum.Text

        If Albumes_ListBox_Albumes.SelectedItem Is Nothing Then
            MessageBox.Show("Se debe seleccionar un Artista")
            Exit Sub
        End If

        Dim albummodificar As Album = Albumes_ListBox_Albumes.SelectedItem

        If String.IsNullOrEmpty(nombrenuevo) Then
            MessageBox.Show("Se debe introducir un nombre de album válido")
            Exit Sub
        End If

        If String.IsNullOrEmpty(añonuevo) Then
            MessageBox.Show("Se debe introducir un año válido")
            Exit Sub
        End If

        Dim añonuevoInt As Integer = CInt(añonuevo)
        If añonuevoInt < 1860 Or añonuevoInt > 2023 Then
            MessageBox.Show("El programa no permite añadir a la base de datos canciones de antes del año 1860 ni de después del año 2023")
            Exit Sub
        End If

        If Albumes_ComboBoxArtistas.SelectedItem Is Nothing Then
            MessageBox.Show("Se debe seleccionar un artista")
            Exit Sub
        End If

        Dim artistaNuevo As Artista = Albumes_ComboBoxArtistas.SelectedItem

        albummodificar.NombreAlbum = nombrenuevo
        albummodificar.AñoAlbum = añonuevoInt
        albummodificar.Artist = artistaNuevo

        Try
            If albummodificar.ActualizarAlbum() <> 1 Then
                ' wtf como ocurre esto?
                MessageBox.Show("no existe (y no se puede modificar) " & albummodificar.ToString)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show(albummodificar.ToString & " modificado correctamente")

        ' porque no se ve actualizado en el listbox
        Albumes_ListBox_Albumes.Items.Remove(albummodificar)
        Albumes_ListBox_Albumes.Items.Add(albummodificar)
        Albumes_ListBox_Albumes.SelectedItem = albummodificar
    End Sub

    Private Sub Albumes_ButtonEliminar_Click(sender As Object, e As EventArgs) Handles Albumes_Button_Eliminar.Click
        If Albumes_ListBox_Albumes.SelectedItem Is Nothing Then
            MessageBox.Show("Se debe seleccionar un Album")
            Exit Sub
        End If

        Dim albumborrar As Album = Albumes_ListBox_Albumes.SelectedItem

        Try
            If albumborrar.BorrarAlbum() <> 1 Then
                MessageBox.Show("no existe (y no se puede borrar) " & albumborrar.ToString)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show(albumborrar.ToString & " eliminado correctamente")
        Albumes_ListBox_Albumes.Items.Remove(albumborrar)
    End Sub

    Private Sub Albumes_ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles Albumes_Button_Limpiar.Click
        Albumes_ListBox_Albumes.Items.Clear()
        Albumes_TextBoxAñoAlbum.Clear()
        Albumes_TextBoxNombreAlbum.Clear()
        Albumes_ComboBoxArtistas.SelectedIndex = -1
        Albumes_ComboBoxArtistas.Text = ""

        Albumes_Button_Actualizar.Enabled = False
        Albumes_Button_Eliminar.Enabled = False
    End Sub
End Class