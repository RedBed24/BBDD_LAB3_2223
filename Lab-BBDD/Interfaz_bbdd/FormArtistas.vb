Public Class FormArtistas
    Public Property Paises_Button_VerTodosPaises As Object

    Private Sub FormArtistas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Artistas_Button_VerTodosArtistas.PerformClick()

        Dim temppais As New Pais
        temppais.LeerTodosPaises()

        For Each pais As Pais In temppais.PaiDAO.Paises
            Artistas_ComboBox_PaisArtista.Items.Add(pais)
        Next

    End Sub

    Private Sub Artistas_Button_VerTodosArtistas_Click(sender As Object, e As EventArgs) Handles Artistas_Button_VerTodosArtistas.Click
        Artistas_Button_Limpiar.PerformClick()

        Dim artistas As New Artista

        Try
            artistas.LeerTodosArtistas()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        For Each artista As Artista In artistas.ArtistDAO.Artistas
            Artistas_ListBox_Artistas.Items.Add(artista)
        Next

    End Sub

    Private Sub Artistas_ListBox_Artistas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Artistas_ListBox_Artistas.SelectedIndexChanged

        If Artistas_ListBox_Artistas.SelectedItem Is Nothing Then
            Exit Sub
        End If

        Dim artista As Artista = Artistas_ListBox_Artistas.SelectedItem

        Artistas_TextBox_NombreArtista.Text = artista.Nombre

        For Each item As Pais In Artistas_ComboBox_PaisArtista.Items
            If item.idPais() = artista.Pais.idPais Then
                Artistas_ComboBox_PaisArtista.SelectedItem = item
                Exit For
            End If
        Next

    End Sub

    Private Sub Artistas_Button_Actualizar_Click(sender As Object, e As EventArgs) Handles Artistas_Button_Actualizar.Click
        If Artistas_ListBox_Artistas.SelectedItem Is Nothing Then
            MessageBox.Show("Se debe seleccionar un Artista")
            Exit Sub
        End If

        Dim artistamodificar As Artista = Artistas_ListBox_Artistas.SelectedItem

        If String.IsNullOrEmpty(Artistas_TextBox_NombreArtista.Text) Then
            MessageBox.Show("Se debe introducir un nombre de artista válido")
            Exit Sub
        End If

        If Artistas_ComboBox_PaisArtista.SelectedItem Is Nothing Then
            MessageBox.Show("Se debe introducir un nombre de pais válido")
            Exit Sub
        End If

        Dim nuevonombre As String = Artistas_TextBox_NombreArtista.Text

        Dim pais As Pais = Artistas_ComboBox_PaisArtista.SelectedItem

        artistamodificar.Nombre = nuevonombre
        artistamodificar.Pais = pais

        Try
            If artistamodificar.ActualizarArtista() <> 1 Then
                ' wtf como ocurre esto?
                MessageBox.Show("no existe (y no se puede modificar) " & artistamodificar.ToString)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show(artistamodificar.ToString & " modificado correctamente")

        ' porque no se ve actualizado en el listbox
        Artistas_ListBox_Artistas.Items.Remove(artistamodificar)
        Artistas_ListBox_Artistas.Items.Add(artistamodificar)
        Artistas_ListBox_Artistas.SelectedItem = artistamodificar

    End Sub

    Private Sub Artistas_Button_Agregar_Click(sender As Object, e As EventArgs) Handles Artistas_Button_Agregar.Click
        Dim nombre As String = Artistas_TextBox_NombreArtista.Text

        If String.IsNullOrEmpty(nombre) Then
            MessageBox.Show("El artista debe tener un nombre.")
            Exit Sub
        End If

        Dim pais As Pais = Artistas_ComboBox_PaisArtista.SelectedItem
        Dim nombrePais As String = pais.NombrePais
        If String.IsNullOrEmpty(nombrePais) Then
            MessageBox.Show("Debe seleccionar un país primero.")
            Exit Sub
        End If

        Dim codpais As String = Pais.obtainID(nombrePais)

        Dim paisartista As New Pais(codpais, nombre)

        Dim artistaanadir As New Artista(nombre, paisartista)

        Try
            If artistaanadir.InsertarArtista() <> 1 Then
                MessageBox.Show("wtf cómo puede ocurrir esto?")
            End If
        Catch ex As Exception
            ' no se puede añadir
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show(artistaanadir.Nombre & " añadido correctamente.")

        ' no sabemos qué id le ha dado la bbdd
        Artistas_Button_VerTodosArtistas.PerformClick()

    End Sub

    Private Sub Artistas_Button_Eliminar_Click(sender As Object, e As EventArgs) Handles Artistas_Button_Eliminar.Click
        If Artistas_ListBox_Artistas.SelectedItem Is Nothing Then
            MessageBox.Show("Se debe seleccionar un Artista")
            Exit Sub
        End If

        Dim artistaborrar As Artista = Artistas_ListBox_Artistas.SelectedItem

        Try
            If artistaborrar.BorrarArtista() <> 1 Then
                MessageBox.Show("no existe (y no se puede borrar) " & artistaborrar.ToString)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show(artistaborrar.ToString & " eliminado correctamente")
        Artistas_ListBox_Artistas.Items.Remove(artistaborrar)

    End Sub

    Private Sub Artistas_Button_Limpiar_Click(sender As Object, e As EventArgs) Handles Artistas_Button_Limpiar.Click
        Artistas_ListBox_Artistas.Items.Clear()
        Artistas_TextBox_NombreArtista.Clear()
        Artistas_ComboBox_PaisArtista.SelectedIndex = -1
        Artistas_ComboBox_PaisArtista.Text = ""

    End Sub
End Class