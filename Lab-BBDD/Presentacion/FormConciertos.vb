Imports Mysqlx.Cursor

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
    ' ARRASTRAR ELEMENTOS EN LA CHECKED LIST BOX
    '
    '

    Private Sub Conciertos_CheckedListBox_Canciones_MouseDown(sender As Object, e As MouseEventArgs) Handles Conciertos_CheckedListBox_Canciones.MouseDown
        ' Comprobar que se ha hecho clic en un elemento de la lista
        Dim index As Integer = Conciertos_CheckedListBox_Canciones.IndexFromPoint(e.Location)
        If index >= 0 AndAlso index < Conciertos_CheckedListBox_Canciones.Items.Count Then
            ' Iniciar la operación de arrastre
            Conciertos_CheckedListBox_Canciones.DoDragDrop(Conciertos_CheckedListBox_Canciones.Items(index), DragDropEffects.Move)
        End If
    End Sub

    Private Sub Conciertos_CheckedListBox_Canciones_DragEnter(sender As Object, e As DragEventArgs) Handles Conciertos_CheckedListBox_Canciones.DragEnter
        ' Comprobar que se está arrastrando un elemento de la lista
        If e.Data.GetDataPresent(GetType(String)) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub Conciertos_CheckedListBox_Canciones_DragDrop(sender As Object, e As DragEventArgs) Handles Conciertos_CheckedListBox_Canciones.DragDrop
        ' Obtener el elemento arrastrado y la posición de destino
        Dim draggedItem As String = e.Data.GetData(GetType(String))
        Dim targetIndex As Integer = Conciertos_CheckedListBox_Canciones.IndexFromPoint(Conciertos_CheckedListBox_Canciones.PointToClient(New Point(e.X, e.Y)))

        ' Mover el elemento a la nueva posición
        If targetIndex >= 0 AndAlso targetIndex < Conciertos_CheckedListBox_Canciones.Items.Count Then
            Conciertos_CheckedListBox_Canciones.Items.Remove(draggedItem)
            Conciertos_CheckedListBox_Canciones.Items.Insert(targetIndex, draggedItem)
        End If
    End Sub

    '
    '
    '
    '
    '
    ' 
    '
    '

    Private Sub Concierto_Button_VerTodosConcierto_Click(sender As Object, e As EventArgs) Handles Concierto_Button_VerTodosConcierto.Click
        Conciertos_Button_Limpiar.PerformClick()

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

    Private Sub Concierto_ListBox_Concierto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Concierto_ListBox_Concierto.SelectedIndexChanged

        If Concierto_ListBox_Concierto.SelectedItem Is Nothing Then
            Exit Sub
        End If

        Dim concierto As Concierto = Concierto_ListBox_Concierto.SelectedItem

        Conciertos_Button_Actualizar.Enabled = True
        Conciertos_Button_Eliminar.Enabled = True

        Concierto_DateTimePicker_Fecha.Value = concierto.FechaConcierto
        Concierto_ComboBox_Artista.SelectedItem = concierto.Artista
        Concierto_ComboBox_Sitio.SelectedItem = concierto.Sitio

        ' Al cambiar el indice se cargan todas las canciones de un artista '
        Dim canciones As New Cancion

        Try
            canciones.LeerCancionesArtista(concierto.Artista)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try


        For i As Integer = 0 To concierto.SetList.Count - 1 Step +1
            Dim cancion As Cancion = concierto.SetList.ElementAt(i)
            Conciertos_CheckedListBox_Canciones.Items.Add(cancion)
            Conciertos_CheckedListBox_Canciones.SetItemChecked(i, True)
            ' checkear esta canción

            ' lo recorremos a la inversa para no tener problemas con los indices
            For j As Integer = canciones.CancioDAO.Canciones.Count - 1 To 0 Step -1
                Dim cancion2 As Cancion = canciones.CancioDAO.Canciones.Item(j)
                If cancion2.idCancion = cancion.idCancion Then
                    ' quitar cancion2 de canciones.CancionDAO.Canciones
                    canciones.CancioDAO.Canciones.Remove(j)
                End If
            Next
        Next

        ' cargar en el listbox las canciones que queden en canciones.CancioDAO.Canciones
        For Each cancion As Cancion In canciones.CancioDAO.Canciones
            Conciertos_CheckedListBox_Canciones.Items.Add(cancion)
        Next


        For Each item As Artista In Concierto_ComboBox_Artista.Items
            If item.IdArtista = concierto.Artista.IdArtista Then
                Concierto_ComboBox_Artista.SelectedItem = item
                Exit For
            End If
        Next

        For Each item As Sitio In Concierto_ComboBox_Sitio.Items
            If item.idSitio = concierto.Sitio.idSitio Then
                Concierto_ComboBox_Sitio.SelectedItem = item
                Exit For
            End If
        Next

    End Sub

    Private Sub Conciertos_Button_Agregar_Click(sender As Object, e As EventArgs) Handles Conciertos_Button_Agregar.Click

        Dim artistaConcierto As Artista = Concierto_ComboBox_Artista.SelectedItem
        Dim nombreArtista As String = artistaConcierto.Nombre
        Dim sitioConcierto As Sitio = Concierto_ComboBox_Sitio.SelectedItem
        Dim nombreSitio As String = sitioConcierto.NombreSitio
        Dim fecha As Date = Concierto_DateTimePicker_Fecha.Value
        Dim stringFecha As String = fecha.ToString("yyyy-MM-dd")
        If String.IsNullOrEmpty(nombreArtista) Then
            MessageBox.Show("Debe seleccionar un artista primero.")
            Exit Sub
        End If
        If String.IsNullOrEmpty(nombreSitio) Then
            MessageBox.Show("Debe seleccionar un sitio primero.")
            Exit Sub
        End If
        If String.IsNullOrEmpty(stringFecha) Then
            MessageBox.Show("Debe seleccionar una fecha primero.")
            Exit Sub
        End If

        ' Creamos la setlist
        Dim setlist As New List(Of Cancion)
        For Each i As Integer In Conciertos_CheckedListBox_Canciones.CheckedIndices
            setlist.Add(Conciertos_CheckedListBox_Canciones.Items(i))
        Next

        If setlist.Count = 0 Then
            MessageBox.Show("Debe seleccionar al menos una canción para la setlist.")
            Exit Sub
        End If

        Dim conciertoAnadir As New Concierto(artistaConcierto, sitioConcierto, fecha, setlist)

        Try
            If conciertoAnadir.InsertarConcierto() <> 1 Then
                MessageBox.Show("wtf cómo puede ocurrir esto?")
                Exit Sub
            End If
        Catch ex As Exception
            ' no se puede añadir
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show(conciertoAnadir.ToString & " añadido correctamente")
        Concierto_Button_VerTodosConcierto.PerformClick()
        Concierto_ListBox_Concierto.SelectedIndex = Concierto_ListBox_Concierto.Items.Count - 1
    End Sub

    Private Sub Conciertos_Button_Actualizar_Click(sender As Object, e As EventArgs) Handles Conciertos_Button_Actualizar.Click


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
        Dim stringFecha As String = fecha.ToString("yyyy-MM-dd")
        If String.IsNullOrEmpty(stringFecha) Then
            MessageBox.Show("Debe seleccionar una fecha primero.")
            Exit Sub
        End If

        Dim setlist As New List(Of Cancion)
        For Each i As Integer In Conciertos_CheckedListBox_Canciones.CheckedIndices
            setlist.Add(Conciertos_CheckedListBox_Canciones.Items(i))
        Next

        If setlist.Count = 0 Then
            MessageBox.Show("Debe seleccionar al menos una canción para la setlist.")
            Exit Sub
        End If

        Dim conciertomodificar As Concierto = Concierto_ListBox_Concierto.SelectedItem

        conciertomodificar.Artista = artistaNuevo
        conciertomodificar.Sitio = sitioNuevo
        conciertomodificar.FechaConcierto = fecha

        Try
            If conciertomodificar.ActualizarConcierto() <> 1 Then
                ' wtf como ocurre esto?
                MessageBox.Show("no existe (y no se puede modificar) " & conciertomodificar.ToString)
                Exit Sub
            End If
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

    Private Sub Conciertos_Button_Eliminar_Click(sender As Object, e As EventArgs) Handles Conciertos_Button_Eliminar.Click
        If Concierto_ListBox_Concierto.SelectedItem Is Nothing Then
            MessageBox.Show("Se debe seleccionar un concierto")
            Exit Sub
        End If

        Dim conciertoborrar As Concierto = Concierto_ListBox_Concierto.SelectedItem

        Try
            If conciertoborrar.BorrarConcierto() <> 1 Then
                MessageBox.Show("no existe (y no se puede borrar) " & conciertoborrar.ToString)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show(conciertoborrar.ToString & " eliminado correctamente")
        Concierto_ListBox_Concierto.Items.Remove(conciertoborrar)
    End Sub

    Private Sub Conciertos_Button_Limpiar_Click(sender As Object, e As EventArgs) Handles Conciertos_Button_Limpiar.Click
        Concierto_ListBox_Concierto.Items.Clear()
        Conciertos_CheckedListBox_Canciones.Items.Clear()
        Concierto_ComboBox_Sitio.SelectedItem = -1
        Concierto_ComboBox_Sitio.Text = ""
        Concierto_ComboBox_Artista.SelectedIndex = -1
        Concierto_ComboBox_Artista.Text = ""
        'Habría que limpiar el date?

        Conciertos_Button_Actualizar.Enabled = False
        Conciertos_Button_Eliminar.Enabled = False
    End Sub

    Private Sub Concierto_ComboBox_Artista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Concierto_ComboBox_Artista.SelectedIndexChanged
        ' Al cambiar el artista se cargan todas las canciones de otro artista '
        Dim canciones As New Cancion
        Dim artista As New Artista
        artista = Concierto_ComboBox_Artista.SelectedItem

        Conciertos_CheckedListBox_Canciones.Items.Clear()

        Try
            canciones.LeerCancionesArtista(artista)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        ' cargar en el listbox las canciones del artista
        For Each cancion As Cancion In canciones.CancioDAO.Canciones
            Conciertos_CheckedListBox_Canciones.Items.Add(cancion)
        Next
    End Sub
End Class

