Public Class FormConciertos

    Private Sub FormConciertos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim artista As New Artista
        artista.LeerTodosArtistas()

        For Each artist As Artista In artista.ArtistDAO.Artistas
            Concierto_ComboBox_Artista.Items.Add(artist)
        Next

        Dim sitio As New Sitio
        sitio.LeerTodosSitios()

        For Each artist As Sitio In sitio.SiteDAO.Sitios
            Concierto_ComboBox_Sitio.Items.Add(artist)
        Next
    End Sub

    '
    '
    '
    '
    '
    ' FUNCIONES AUXILIARES
    '
    Private Sub SetArtistaInComboBox(concierto As Concierto)
        For Each item As Artista In Concierto_ComboBox_Artista.Items
            If item.IdArtista = concierto.Artista.IdArtista Then
                Concierto_ComboBox_Artista.SelectedItem = item
                Exit For
            End If
        Next
    End Sub

    Public Function CancionInSetlist(cancion As Cancion, concierto As Concierto) As Boolean
        For Each canciontmp As Cancion In concierto.SetList
            If cancion.idCancion = canciontmp.idCancion Then
                Return True
            End If
        Next

        Return False
    End Function

    Public Sub CargarCancionesListBox(concierto As Concierto, artista As Artista)
        Concierto_ListBox_CancionesArtista.Items.Clear()
        Concierto_ListBox_CancionesSeleccionadas.Items.Clear()

        Dim canciones As New Cancion

        Try
            canciones.LeerCancionesArtista(artista)
        Catch ex As Exception
            Exit Sub
        End Try

        For Each cancion As Cancion In canciones.CancioDAO.Canciones
            If CancionInSetlist(cancion, concierto) Then
                Concierto_ListBox_CancionesSeleccionadas.Items.Add(cancion)
            Else
                Concierto_ListBox_CancionesArtista.Items.Add(cancion)
            End If
        Next
    End Sub

    Private Sub SetSitio(concierto As Concierto)
        For Each item As Sitio In Concierto_ComboBox_Sitio.Items
            If item.idSitio = concierto.Sitio.idSitio Then
                Concierto_ComboBox_Sitio.SelectedItem = item
                Exit For
            End If
        Next
    End Sub

    '
    '
    '
    '
    '
    ' FUNCIONES BOTONES
    '

    Private Sub Concierto_Button_VerTodosConcierto_Click(sender As Object, e As EventArgs) Handles Concierto_Button_VerTodosConcierto.Click
        Concierto_Button_Limpiar.PerformClick()

        Dim conciertos As New Concierto

        Try
            conciertos.LeerTodosConciertoes()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        For Each concierto As Concierto In conciertos.ConciertDAO.Conciertos
            Concierto_ListBox_Concierto.Items.Add(concierto)
        Next
    End Sub


    Private Sub Concierto_Button_Agregar_Click(sender As Object, e As EventArgs) Handles Concierto_Button_Agregar.Click

        If Concierto_ComboBox_Artista.SelectedItem Is Nothing Then
            MessageBox.Show("Debe seleccionar un artista primero.")
            Exit Sub
        End If
        If Concierto_ComboBox_Sitio.SelectedItem Is Nothing Then
            MessageBox.Show("Debe seleccionar un sitio primero.")
            Exit Sub
        End If

        Dim artistaConcierto As Artista = Concierto_ComboBox_Artista.SelectedItem
        Dim sitioConcierto As Sitio = Concierto_ComboBox_Sitio.SelectedItem
        Dim fecha As Date = Concierto_DateTimePicker_Fecha.Value

        ' Creamos la setlist
        Dim setlist As New List(Of Cancion)
        For Each cancion As Cancion In Concierto_ListBox_CancionesSeleccionadas.Items
            setlist.Add(cancion)
        Next

        If setlist.Count = 0 Then
            MessageBox.Show("Debe seleccionar al menos una canción para la setlist.")
            Exit Sub
        End If

        Dim conciertoAnadir As New Concierto(artistaConcierto, sitioConcierto, fecha, setlist)

        Try
            If conciertoAnadir.InsertarConcierto() <> setlist.Count Then
                MessageBox.Show("Ha ocurrido un error al insertar alguna canción.")
                Exit Sub
            End If
        Catch ex As Exception
            ' no se puede añadir
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show(conciertoAnadir.ToString & " añadido correctamente")
        Concierto_ListBox_Concierto.Items.Add(conciertoAnadir)
        Concierto_ListBox_Concierto.SelectedItem = conciertoAnadir
    End Sub

    Private Sub Concierto_Button_Actualizar_Click(sender As Object, e As EventArgs) Handles Concierto_Button_Actualizar.Click

        If Concierto_ComboBox_Artista.SelectedItem Is Nothing Then
            MessageBox.Show("Se debe seleccionar un artista")
            Exit Sub
        End If
        Dim artistaNuevo As Artista = Concierto_ComboBox_Artista.SelectedItem

        If Concierto_ComboBox_Sitio.SelectedItem Is Nothing Then
            MessageBox.Show("Se debe seleccionar un sitio")
            Exit Sub
        End If
        Dim sitioNuevo As Sitio = Concierto_ComboBox_Sitio.SelectedItem

        Dim fecha As Date = Concierto_DateTimePicker_Fecha.Value

        Dim setlist As New List(Of Cancion)
        For Each cancion As Cancion In Concierto_ListBox_CancionesSeleccionadas.Items
            setlist.Add(cancion)
        Next

        If setlist.Count = 0 Then
            MessageBox.Show("Debe seleccionar al menos una canción para la setlist.")
            Exit Sub
        End If

        Dim conciertomodificar As Concierto = Concierto_ListBox_Concierto.SelectedItem

        conciertomodificar.Artista = artistaNuevo
        conciertomodificar.Sitio = sitioNuevo
        conciertomodificar.FechaConcierto = fecha
        conciertomodificar.SetList = setlist

        Try
            conciertomodificar.ActualizarConcierto()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show(conciertomodificar.ToString & " modificado correctamente")

        ' porque no se ve actualizado en el listbox
        Concierto_ListBox_Concierto.Items.Remove(conciertomodificar)
        Concierto_ListBox_Concierto.Items.Add(conciertomodificar)
        Concierto_ListBox_Concierto.SelectedItem = conciertomodificar
    End Sub

    Private Sub Concierto_Button_Eliminar_Click(sender As Object, e As EventArgs) Handles Concierto_Button_Eliminar.Click
        If Concierto_ListBox_Concierto.SelectedItem Is Nothing Then
            MessageBox.Show("Se debe seleccionar un concierto")
            Exit Sub
        End If

        Dim conciertoborrar As Concierto = Concierto_ListBox_Concierto.SelectedItem

        Try
            If conciertoborrar.BorrarConcierto() <> 1 Then
                MessageBox.Show("Hubo un error al borrar alguna canción del setlist.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show(conciertoborrar.ToString & " eliminado correctamente")
        Concierto_ListBox_Concierto.Items.Remove(conciertoborrar)
    End Sub

    Private Sub Concierto_Button_Limpiar_Click(sender As Object, e As EventArgs) Handles Concierto_Button_Limpiar.Click
        Concierto_ListBox_Concierto.Items.Clear()
        Concierto_ListBox_CancionesArtista.Items.Clear()
        Concierto_ListBox_CancionesSeleccionadas.Items.Clear()
        Concierto_ComboBox_Sitio.SelectedIndex = -1
        Concierto_ComboBox_Sitio.Text = ""
        Concierto_ComboBox_Artista.SelectedIndex = -1
        Concierto_ComboBox_Artista.Text = ""
        Concierto_DateTimePicker_Fecha.Value = Now

        Concierto_Button_Actualizar.Enabled = False
        Concierto_Button_Eliminar.Enabled = False
    End Sub

    '
    '
    '
    '
    '
    '
    ' FUNCIONES DE CAMBIO DE SELECCIÓN
    '

    Private Sub Concierto_ListBox_Concierto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Concierto_ListBox_Concierto.SelectedIndexChanged
        If Concierto_ListBox_Concierto.SelectedItem Is Nothing Then
            Exit Sub
        End If

        Dim concierto As Concierto = Concierto_ListBox_Concierto.SelectedItem

        Concierto_Button_Actualizar.Enabled = True
        Concierto_Button_Eliminar.Enabled = True

        Concierto_DateTimePicker_Fecha.Value = concierto.FechaConcierto
        SetArtistaInComboBox(concierto)
        CargarCancionesListBox(concierto, concierto.Artista)
        SetSitio(concierto)
    End Sub

    Private Sub Concierto_ComboBox_Artista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Concierto_ComboBox_Artista.SelectedIndexChanged
        If Concierto_ComboBox_Artista.SelectedItem Is Nothing Then
            Exit Sub
        ElseIf Concierto_ListBox_Concierto.SelectedItem Is Nothing Then
            CargarCancionesListBox(New Concierto, Concierto_ComboBox_Artista.SelectedItem)
        Else
            CargarCancionesListBox(Concierto_ListBox_Concierto.SelectedItem, Concierto_ComboBox_Artista.SelectedItem)
        End If
    End Sub

    Private Sub Concierto_ListBox_CancionesArtista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Concierto_ListBox_CancionesArtista.SelectedIndexChanged
        ' para que a la hora de mover canciones, no se perjudiquen el uno al otro
        Concierto_ListBox_CancionesSeleccionadas.SelectedIndex = -1
    End Sub

    Private Sub Concierto_ListBox_CancionesSeleccionadas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Concierto_ListBox_CancionesSeleccionadas.SelectedIndexChanged
        Concierto_ListBox_CancionesArtista.SelectedIndex = -1
    End Sub


    '
    '
    '
    '
    '
    '
    '
    ' FUNCIONES PARA SELECCIONAR CANCIONES
    '

    '
    ' Botones
    '

    Private Sub Concierto_Button_MoverAbajo_Click(sender As Object, e As EventArgs) Handles Concierto_Button_MoverAbajo.Click
        If Concierto_ListBox_CancionesArtista.SelectedItem Is Nothing And Concierto_ListBox_CancionesSeleccionadas.SelectedItem Is Nothing Then
            Exit Sub
        ElseIf Concierto_ListBox_CancionesSeleccionadas.SelectedItem IsNot Nothing Then
            CambiarOrden(Concierto_ListBox_CancionesSeleccionadas.SelectedItem, +1)
        Else
            MoverAListBoxSeleccionadas(Concierto_ListBox_CancionesArtista.SelectedItem)
        End If
    End Sub

    Private Sub Concierto_Button_MoverArriba_Click(sender As Object, e As EventArgs) Handles Concierto_Button_MoverArriba.Click
        If Concierto_ListBox_CancionesArtista.SelectedItem Is Nothing And Concierto_ListBox_CancionesSeleccionadas.SelectedItem Is Nothing Then
            Exit Sub
        ElseIf Concierto_ListBox_CancionesSeleccionadas.SelectedItem IsNot Nothing Then
            ' ya se encarga de mover a ListBox Artista
            CambiarOrden(Concierto_ListBox_CancionesSeleccionadas.SelectedItem, -1)
        End If
    End Sub

    '
    ' Auxiliares
    '

    Private Sub MoverAListBoxSeleccionadas(cancion As Cancion)
        Concierto_ListBox_CancionesArtista.Items.Remove(cancion)
        Concierto_ListBox_CancionesSeleccionadas.Items.Insert(0, cancion)

        Concierto_ListBox_CancionesSeleccionadas.SelectedIndex = 0
    End Sub

    Private Sub MoverAListBoxArtista(cancion As Cancion)
        Concierto_ListBox_CancionesSeleccionadas.Items.Remove(cancion)
        Concierto_ListBox_CancionesArtista.Items.Add(cancion)

        Concierto_ListBox_CancionesArtista.SelectedIndex = Concierto_ListBox_CancionesArtista.Items.Count - 1
    End Sub

    Private Sub CambiarOrden(cancion As Cancion, diferencia As Integer)
        Dim index As Integer = Concierto_ListBox_CancionesSeleccionadas.Items.IndexOf(cancion)

        If index + diferencia < 0 Then
            MoverAListBoxArtista(cancion)
            Exit Sub
        ElseIf index + diferencia >= Concierto_ListBox_CancionesSeleccionadas.Items.Count Then
            ' Esto está hecho para que la diferencia pueda ser general, pero la idea es usarla de 1 en 1
            diferencia = Concierto_ListBox_CancionesSeleccionadas.Items.Count - index - 1
        End If

        Dim otracancion As Cancion = Concierto_ListBox_CancionesSeleccionadas.Items.Item(index + diferencia)

        Concierto_ListBox_CancionesSeleccionadas.Items.Item(index + diferencia) = cancion
        Concierto_ListBox_CancionesSeleccionadas.Items.Item(index) = otracancion

        Concierto_ListBox_CancionesSeleccionadas.SelectedIndex = index + diferencia
    End Sub

End Class

