Public Class FormularioPrincipal

    '
    ' TAB ARTISTA
    '

    Private Sub Artista_Button_VerTodosArtistas_Click(sender As Object, e As EventArgs) Handles Artista_Button_VerTodosArtistas.Click
        Artista_Button_Limpiar.PerformClick()

        Dim artistas As New Artista

        Try
            artistas.LeerTodosArtistas()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        For Each artista As Artista In artistas.ArtistDAO.Artistas
            Artista_ListBox_Artistas.Items.Add(artista)
        Next

    End Sub

    Private Sub Artista_Button_Agregar_Click(sender As Object, e As EventArgs) Handles Artista_Button_Agregar.Click
        Dim nombre As String = Artista_TextBox_NombreArtista.Text

        If String.IsNullOrEmpty(nombre) Then
            MessageBox.Show("El artista debe tener un nombre.")
            Exit Sub
        End If

        Dim nombrepais As String = Artista_TextBox_PaisArtista.Text
        Dim codpais As String = Pais.obtainID(nombrepais)

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
        Artista_Button_VerTodosArtistas.PerformClick()

    End Sub

    Private Sub Artista_Button_Eliminar_Click(sender As Object, e As EventArgs) Handles Artista_Button_Eliminar.Click
        If Artista_ListBox_Artistas.SelectedItem Is Nothing Then
            MessageBox.Show("Se debe seleccionar un Artista")
            Exit Sub
        End If

        Dim artistaborrar As Artista = Artista_ListBox_Artistas.SelectedItem

        Try
            If artistaborrar.BorrarArtista() <> 1 Then
                MessageBox.Show("no existe (y no se puede borrar) " & artistaborrar.ToString)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show(artistaborrar.ToString & " eliminado correctamente")
        Artista_ListBox_Artistas.Items.Remove(artistaborrar)

    End Sub

    Private Sub Artista_Button_Limpiar_Click(sender As Object, e As EventArgs) Handles Artista_Button_Limpiar.Click
        Artista_ListBox_Artistas.Items.Clear()

        Artista_TextBox_NombreArtista.Clear()
        Artista_TextBox_PaisArtista.Clear()

    End Sub

    Private Sub Artista_ListBox_Artistas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Artista_ListBox_Artistas.SelectedIndexChanged
        If Artista_ListBox_Artistas.SelectedItem Is Nothing Then
            Exit Sub
        End If

        Dim artista As Artista = Artista_ListBox_Artistas.SelectedItem

        Artista_TextBox_NombreArtista.Text = artista.Nombre
        Artista_TextBox_PaisArtista.Text = artista.Pais.NombrePais

        Paises_Button_VerTodosPaises.PerformClick()

        For Each pais As Pais In Artista_ComboBox_PaisArtista.Items
            If pais.idPais = artista.Pais.idPais Then
                Artista_ComboBox_PaisArtista.SelectedItem = pais
                Exit For
            End If
        Next

    End Sub

    '
    ' TAB PAISES
    '

    Private Sub Paises_Button_VerTodosPaises_Click(sender As Object, e As EventArgs) Handles Paises_Button_VerTodosPaises.Click
        Paises_Button_Limpiar.PerformClick()
        Artista_ComboBox_PaisArtista.Items.Clear()

        Dim paises As New Pais

        Try
            paises.LeerTodosPaises()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        For Each pais As Pais In paises.PaiDAO.Paises
            Paises_ListBox_Paises.Items.Add(pais)
            Artista_ComboBox_PaisArtista.Items.Add(pais)
        Next

    End Sub

    Private Sub Paises_Button_Limpiar_Click(sender As Object, e As EventArgs) Handles Paises_Button_Limpiar.Click
        Paises_ListBox_Paises.Items.Clear()

        Paises_TextBox_NombrePais.Clear()
    End Sub

    Private Sub Paises_Button_Agregar_Click(sender As Object, e As EventArgs) Handles Paises_Button_Agregar.Click
        Dim nombre As String = Paises_TextBox_NombrePais.Text

        If String.IsNullOrEmpty(nombre) Then
            MessageBox.Show("El país debe tener un nombre.")
            Exit Sub
        End If

        Dim cod As String = Pais.obtainID(nombre)

        Dim paisanadir As New Pais(cod, nombre)

        Try
            If paisanadir.InsertarPais() <> 1 Then
                MessageBox.Show("wtf cómo puede ocurrir esto?")
                Exit Sub
            End If
        Catch ex As Exception
            ' no se puede añadir
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show(paisanadir.ToString & " añadido correctamente")
        Paises_ListBox_Paises.Items.Add(paisanadir)
        Paises_ListBox_Paises.SelectedItem = paisanadir

    End Sub

    Private Sub Paises_Button_Actualizar_Click(sender As Object, e As EventArgs) Handles Paises_Button_Actualizar.Click
        If Paises_ListBox_Paises.SelectedItem Is Nothing Then
            MessageBox.Show("Se debe seleccionar un País")
            Exit Sub
        End If

        Dim paismodificar As Pais = Paises_ListBox_Paises.SelectedItem

        Dim nuevonombre As String = Paises_TextBox_NombrePais.Text

        If String.IsNullOrEmpty(nuevonombre) Or nuevonombre.Length < 3 Then
            MessageBox.Show("Se debe introducir un nombre de país válido")
            Exit Sub
        End If

        If Pais.obtainID(nuevonombre) <> paismodificar.idPais Then
            MessageBox.Show("El código ha cambiado")
            Exit Sub
        End If

        paismodificar.NombrePais = nuevonombre

        Try
            If paismodificar.ActualizarPais() <> 1 Then
                ' wtf como ocurre esto?
                MessageBox.Show("no existe (y no se puede modificar) " & paismodificar.ToString)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show(paismodificar.ToString & " modificado correctamente")

        ' porque no se ve actualizado en el listbox
        Paises_ListBox_Paises.Items.Remove(paismodificar)
        Paises_ListBox_Paises.Items.Add(paismodificar)
        Paises_ListBox_Paises.SelectedItem = paismodificar

    End Sub

    Private Sub Paises_Button_Eliminar_Click(sender As Object, e As EventArgs) Handles Paises_Button_Eliminar.Click
        If Paises_ListBox_Paises.SelectedItem Is Nothing Then
            MessageBox.Show("Se debe seleccionar un País")
            Exit Sub
        End If

        Dim paisborrar As Pais = Paises_ListBox_Paises.SelectedItem

        Try
            If paisborrar.BorrarPais() <> 1 Then
                ' wtf como ocurre esto?
                MessageBox.Show("no existe (y no se puede borrar) " & paisborrar.ToString)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show(paisborrar.ToString & " eliminado correctamente")
        Paises_ListBox_Paises.Items.Remove(paisborrar)

    End Sub

    Private Sub Paises_ListBox_Paises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Paises_ListBox_Paises.SelectedIndexChanged
        If Paises_ListBox_Paises.SelectedItem Is Nothing Then
            Exit Sub
        End If

        Dim pais As Pais = Paises_ListBox_Paises.SelectedItem

        Paises_TextBox_NombrePais.Text = pais.NombrePais

    End Sub

End Class