Public Class FormCanciones
    Private Sub FormCanciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim albumt As New Album
        albumt.LeerTodosAlbumes()

        For Each album As Album In albumt.AlbuDAO.Albumes
            Canciones_ComboBox_Album.Items.Add(album)
        Next
    End Sub

    Private Sub Canciones_Button_VerTodasCanciones_Click(sender As Object, e As EventArgs) Handles Canciones_Button_VerTodasCanciones.Click
        Canciones_Button_Limpiar.PerformClick()

        Dim canciones As New Cancion

        Try
            canciones.LeerTodosCanciones()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        For Each cancion As Cancion In canciones.CancioDAO.Canciones
            Canciones_ListBoxTodasLasCanciones.Items.Add(cancion)
        Next
    End Sub

    Private Sub Canciones_ListBoxTodasLasCanciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Canciones_ListBoxTodasLasCanciones.SelectedIndexChanged

        If Canciones_ListBoxTodasLasCanciones.SelectedItem Is Nothing Then
            Exit Sub
        End If

        Canciones_Button_Actualizar.Enabled = True
        Canciones_Button_Eliminar.Enabled = True

        Dim cancion As Cancion = Canciones_ListBoxTodasLasCanciones.SelectedItem

        Canciones_TextBoxNombreCanciones.Text = cancion.NombreCancion
        Canciones_TextBoxDuracionCanciones.Text = cancion.Duracion
        Canciones_TextBox_Orden.Text = cancion.OrdenCancion

        For Each item As Album In Canciones_ComboBox_Album.Items
            If item.idAlbum = cancion.Album.idAlbum Then
                Canciones_ComboBox_Album.SelectedItem = item
                Exit For
            End If
        Next

    End Sub

    Private Sub Canciones_Button_Agregar_Click(sender As Object, e As EventArgs) Handles Canciones_Button_Agregar.Click
        'DEBEREMOS CONTROLAR EL ORDEN INTRODUCIDO'

        Dim nombre As String = Canciones_TextBoxNombreCanciones.Text
        Dim duracion As String = Canciones_TextBoxDuracionCanciones.Text
        Dim orden As Integer = Canciones_TextBox_Orden.Text

        If String.IsNullOrEmpty(nombre) Then
            MessageBox.Show("La canción debe tener un nombre.")
            Exit Sub
        End If
        If String.IsNullOrEmpty(duracion) Then
            MessageBox.Show("La canción debe tener una duración")
            Exit Sub
        End If
        If String.IsNullOrEmpty(orden) Then
            MessageBox.Show("La canción debe tener un orden en el álbum.")
            Exit Sub
        End If

        Dim duracionInt As Integer = CInt(duracion)
        If duracionInt <= 0 Then
            MessageBox.Show("El programa no permite añadir a la base de datos canciones con duración igual o inferior a 0")
            Exit Sub
        End If
        Dim ordenInt As Integer = CInt(orden)
        If duracionInt <= 0 Then
            MessageBox.Show("El programa no permite añadir a la base de datos ordenes de canciones iguales o inferiores a 0")
            Exit Sub
        End If

        Dim albumCancion As Album = Canciones_ComboBox_Album.SelectedItem
        Dim nombreAlbum As String = albumCancion.NombreAlbum
        If String.IsNullOrEmpty(nombreAlbum) Then
            MessageBox.Show("Debe seleccionar un album primero.")
            Exit Sub
        End If

        Dim CancionAnadir As New Cancion(nombre, duracionInt, albumCancion, ordenInt)

        Try
            If CancionAnadir.InsertarCancion() <> 1 Then
                MessageBox.Show("wtf cómo puede ocurrir esto?")
                Exit Sub
            End If
        Catch ex As Exception
            ' no se puede añadir
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show(CancionAnadir.ToString & " añadido correctamente")
        Canciones_Button_VerTodasCanciones.PerformClick()
        Canciones_ListBoxTodasLasCanciones.SelectedIndex = Canciones_ListBoxTodasLasCanciones.Items.Count - 1
    End Sub

    Private Sub Canciones_Button_Actualizar_Click(sender As Object, e As EventArgs) Handles Canciones_Button_Actualizar.Click
        'DEBEREMOS CONTROLAR EL ORDEN INTRODUCIDO'

        Dim nombrenuevo As String = Canciones_TextBoxNombreCanciones.Text
        Dim duracionnuevo As String = Canciones_TextBoxDuracionCanciones.Text
        Dim ordennuevo As String = Canciones_TextBox_Orden.Text

        If Canciones_ListBoxTodasLasCanciones.SelectedItem Is Nothing Then
            MessageBox.Show("Se debe seleccionar una Canción")
            Exit Sub
        End If

        Dim cancionmodificar As Cancion = Canciones_ListBoxTodasLasCanciones.SelectedItem

        If String.IsNullOrEmpty(nombrenuevo) Then
            MessageBox.Show("Se debe introducir un nombre de album válido")
            Exit Sub
        End If

        If String.IsNullOrEmpty(duracionnuevo) Then
            MessageBox.Show("Se debe introducir una duración valida")
            Exit Sub
        End If

        If String.IsNullOrEmpty(ordennuevo) Then
            MessageBox.Show("Se debe introducir una órden válido")
            Exit Sub
        End If

        Dim duracionnuevoInt As Integer = CInt(duracionnuevo)
        If duracionnuevoInt <= 0 Then
            MessageBox.Show("El programa no permite añadir a la base de datos canciones con duración igual o inferior a 0")
            Exit Sub
        End If

        If Canciones_ComboBox_Album.SelectedItem Is Nothing Then
            MessageBox.Show("Se debe seleccionar un album")
            Exit Sub
        End If

        Dim albumNuevo As Album = Canciones_ComboBox_Album.SelectedItem

        cancionmodificar.NombreCancion = nombrenuevo
        cancionmodificar.Duracion = duracionnuevoInt
        cancionmodificar.OrdenCancion = CInt(ordennuevo)
        cancionmodificar.Album = albumNuevo

        Try
            If cancionmodificar.ActualizarCancion() <> 1 Then
                ' wtf como ocurre esto?
                MessageBox.Show("no existe (y no se puede modificar) " & cancionmodificar.ToString)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show(cancionmodificar.ToString & " modificado correctamente")

        ' porque no se ve actualizado en el listbox
        Canciones_ListBoxTodasLasCanciones.Items.Remove(cancionmodificar)
        Canciones_ListBoxTodasLasCanciones.Items.Add(cancionmodificar)
        Canciones_ListBoxTodasLasCanciones.SelectedItem = cancionmodificar
    End Sub

    Private Sub Canciones_Button_Eliminar_Click(sender As Object, e As EventArgs) Handles Canciones_Button_Eliminar.Click
        If Canciones_ListBoxTodasLasCanciones.SelectedItem Is Nothing Then
            MessageBox.Show("Se debe seleccionar una Canción")
            Exit Sub
        End If

        Dim cancionborrar As Cancion = Canciones_ListBoxTodasLasCanciones.SelectedItem

        Try
            If cancionborrar.Borrarcancion() <> 1 Then
                MessageBox.Show("no existe (y no se puede borrar) " & cancionborrar.ToString)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show(cancionborrar.ToString & " eliminado correctamente")
        Canciones_ListBoxTodasLasCanciones.Items.Remove(cancionborrar)
    End Sub

    Private Sub Canciones_Button_Limpiar_Click(sender As Object, e As EventArgs) Handles Canciones_Button_Limpiar.Click
        Canciones_ListBoxTodasLasCanciones.Items.Clear()
        Canciones_TextBoxDuracionCanciones.Clear()
        Canciones_TextBoxNombreCanciones.Clear()
        Canciones_TextBox_Orden.Clear()
        Canciones_ComboBox_Album.SelectedIndex = -1
        Canciones_ComboBox_Album.Text = ""

        Canciones_Button_Actualizar.Enabled = False
        Canciones_Button_Eliminar.Enabled = False
    End Sub

End Class