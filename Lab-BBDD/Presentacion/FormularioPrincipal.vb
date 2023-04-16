Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormularioPrincipal

    Private Sub FormularioPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub TabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl.SelectedIndexChanged
        If TabControl.SelectedTab.Name = "TabArtistas" Then
            ' Cada vez que se seleccione la ventana artistas rellenamos el combobox, por si se ha actualizado en otras ventanas'
            Artistas_ComboBox_PaisArtista.Items.Clear()

            Dim paises As New Pais

            Try
                paises.LeerTodosPaises()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try

            For Each pais As Pais In paises.PaiDAO.Paises
                Artistas_ComboBox_PaisArtista.Items.Add(pais)
            Next
        End If

        If TabControl.SelectedTab.Name = "TabAlbumes" Then
            ' Cada vez que se seleccione la ventana albumes rellenamos el combobox, por si se ha actualizado en otras ventanas'
            Albumes_ComboBoxArtistas.Items.Clear()

            Dim artistas As New Artista

            Try
                artistas.LeerTodosArtistas()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try

            For Each artista As Artista In artistas.ArtistDAO.Artistas
                Albumes_ComboBoxArtistas.Items.Add(artista)
            Next
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
    ' TAB ARTISTA
    '

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

    Private Sub Artistas_Button_Agregar_Click(sender As Object, e As EventArgs) Handles Artistas_Button_Agregar.Click
        Dim nombre As String = Artistas_TextBox_NombreArtista.Text

        If String.IsNullOrEmpty(nombre) Then
            MessageBox.Show("El artista debe tener un nombre.")
            Exit Sub
        End If

        Dim pais As Pais = Artistas_ComboBox_PaisArtista.SelectedItem
        Dim nombrePais As String = pais.NombrePais
        If String.IsNullOrEmpty(nombrepais) Then
            MessageBox.Show("Debe seleccionar un país primero.")
            Exit Sub
        End If

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
        Artistas_Button_VerTodosArtistas.PerformClick()

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
        TabControl_SelectedIndexChanged(sender, e)
        Artistas_ComboBox_PaisArtista.SelectedIndex = -1
        Artistas_ComboBox_PaisArtista.Text = ""

    End Sub

    Private Sub Artistas_ListBox_Artistas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Artistas_ListBox_Artistas.SelectedIndexChanged

        If Artistas_ListBox_Artistas.SelectedItem Is Nothing Then
            Exit Sub
        End If

        Dim artista As Artista = Artistas_ListBox_Artistas.SelectedItem

        Artistas_TextBox_NombreArtista.Text = artista.Nombre

        For Each item As Pais In Artistas_ComboBox_PaisArtista.Items
            If item.NombrePais() = artista.Pais.NombrePais Then
                Artistas_ComboBox_PaisArtista.SelectedItem = item
                Exit For
            End If
        Next

        Paises_Button_VerTodosPaises.PerformClick()

    End Sub


    '
    '
    '
    '
    '
    '
    '
    '
    ' TAB PAISES
    '

    Private Sub Paises_Button_VerTodosPaises_Click(sender As Object, e As EventArgs) Handles Paises_Button_VerTodosPaises.Click
        Paises_Button_Limpiar.PerformClick()

        Dim paises As New Pais

        Try
            paises.LeerTodosPaises()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        For Each pais As Pais In paises.PaiDAO.Paises
            Paises_ListBox_Paises.Items.Add(pais)
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


    '
    '
    '
    '
    '
    '
    '
    '
    ' TAB ALBUMES
    '

    Private Sub Albumes_ComboBoxArtistas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Albumes_ComboBoxArtistas.SelectedIndexChanged
        Albumes_ButtonLimpiar.PerformClick()

        'Leer todos los álbumes del artista seleccionado de la combobox y mostrar en la listBox'

    End Sub

    Private Sub Conciertos_MonthCalendar_FechaConcierto_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Conciertos_MonthCalendar_FechaConcierto.DateChanged

    End Sub

    Private Sub Canciones_ButtonActualizar_Click(sender As Object, e As EventArgs) Handles Canciones_ButtonActualizar.Click

    End Sub

    Private Sub Canciones_ButtonAgregar_Click(sender As Object, e As EventArgs) Handles Canciones_ButtonAgregar.Click

    End Sub

    Private Sub Sitios_Button_Eliminar_Click(sender As Object, e As EventArgs) Handles Sitios_Button_Eliminar.Click

    End Sub

    Private Sub Sitios_Button_Limpiar_Click(sender As Object, e As EventArgs) Handles Sitios_Button_Limpiar.Click

    End Sub

    Private Sub Sitios_Button_Agregar_Click(sender As Object, e As EventArgs) Handles Sitios_Button_Agregar.Click

    End Sub

    Private Sub Sitios_Button_Actualizar_Click(sender As Object, e As EventArgs) Handles Sitios_Button_Actualizar.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Artistas_TextBox_NombreArtista_TextChanged(sender As Object, e As EventArgs) Handles Artistas_TextBox_NombreArtista.TextChanged

    End Sub

    Private Sub TabAlbum_Click(sender As Object, e As EventArgs) Handles TabAlbum.Click

    End Sub

    Private Sub Artistas_Label_NombreArtista_Click(sender As Object, e As EventArgs) Handles Artistas_Label_NombreArtista.Click

    End Sub

    Private Sub Artistas_ComboBox_PaisArtista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Artistas_ComboBox_PaisArtista.SelectedIndexChanged

    End Sub

    Private Sub Sitios_ListBox_Sitios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Sitios_ListBox_Sitios.SelectedIndexChanged

    End Sub
End Class