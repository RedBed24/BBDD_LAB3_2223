Public Class FormularioPrincipal

    Private Sub Paises_ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles Paises_ButtonLimpiar.Click
        Dim paises As New Pais

        Try
            paises.LeerTodosPaises()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        For Each pais As Pais In paises.PaiDAO.Paises
            MessageBox.Show(pais.ToString)
        Next

    End Sub

    Private Sub Paises_ButtonAgregar_Click(sender As Object, e As EventArgs) Handles Paises_ButtonAgregar.Click
        Dim cod, nombre As String

        nombre = "España"
        cod = Pais.obtainID(nombre)

        Dim paisanadir As New Pais(cod, nombre)


        Try
            If paisanadir.InsertarPais() = 1 Then
                MessageBox.Show(paisanadir.ToString & " añadido correctamente")
            Else
                MessageBox.Show("wtf cómo puede ocurrir esto?")
            End If
        Catch ex As Exception
            ' no se puede añadir
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub Paises_ButtonEliminar_Click(sender As Object, e As EventArgs) Handles Paises_ButtonEliminar.Click
        Dim cod, nombre As String

        nombre = "España"
        cod = Pais.obtainID(nombre)

        Dim paisborrar As New Pais(cod, nombre)

        Try
            If paisborrar.BorrarPais() = 1 Then
                MessageBox.Show(paisborrar.ToString & " eliminado correctamente")
            Else
                MessageBox.Show("no existe (y no se puede borrar) " & paisborrar.ToString)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub Artista_ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles Artista_ButtonLimpiar.Click
        Dim artistas As New Artista

        Try
            artistas.LeerTodosArtistas()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        For Each pais As Artista In artistas.ArtistDAO.Artistas
            MessageBox.Show(pais.ToString)
        Next
    End Sub

    Private Sub Artista_Button_Agregar_Click(sender As Object, e As EventArgs) Handles Artista_Button_Agregar.Click
        Dim paisartista As New Pais("ESP")
        paisartista.LeerPais()

        Dim artistaanadir As New Artista("Samuel", paisartista)

        Try
            If artistaanadir.InsertarArtista() = 1 Then
                MessageBox.Show(artistaanadir.ToString & " añadido correctamente EL ID NO COINCIDE CON EL QUE LE HA PUESTO LA DB")
            Else
                MessageBox.Show("wtf cómo puede ocurrir esto?")
            End If
        Catch ex As Exception
            ' no se puede añadir
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub Artista_ButtonEliminar_Click(sender As Object, e As EventArgs) Handles Artista_ButtonEliminar.Click
        Dim paisartista As New Pais("ESP")
        paisartista.LeerPais()

        Dim artistaborrar As New Artista(Integer.Parse("1"), "Samuel", paisartista)

        Try
            If artistaborrar.BorrarArtista() = 1 Then
                MessageBox.Show(artistaborrar.ToString & " eliminado correctamente")
            Else
                MessageBox.Show("no existe (y no se puede borrar) " & artistaborrar.ToString)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

    End Sub

End Class
'Hay que usar combobox para las clases de paises, sitios, artistas, albumes, canciones y conciertos