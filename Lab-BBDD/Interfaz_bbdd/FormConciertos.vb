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

End Class