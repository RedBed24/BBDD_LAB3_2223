Public Class FormPaises

    Private Sub FormPaises_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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

    Private Sub Paises_ListBox_Paises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Paises_ListBox_Paises.SelectedIndexChanged
        If Paises_ListBox_Paises.SelectedItem Is Nothing Then
            Exit Sub
        End If

        Dim pais As Pais = Paises_ListBox_Paises.SelectedItem

        Paises_TextBox_NombrePais.Text = pais.NombrePais

    End Sub

    Private Sub Artistas_Button_Actualizar_Click(sender As Object, e As EventArgs) Handles Paises_Button_Actualizar.Click
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

    Private Sub Artistas_Button_Agregar_Click(sender As Object, e As EventArgs) Handles Paises_Button_Agregar.Click
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

    Private Sub Artistas_Button_Eliminar_Click(sender As Object, e As EventArgs) Handles Paises_Button_Eliminar.Click
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

    Private Sub Artistas_Button_Limpiar_Click(sender As Object, e As EventArgs) Handles Paises_Button_Limpiar.Click
        Paises_ListBox_Paises.Items.Clear()
        Paises_TextBox_NombrePais.Clear()
    End Sub
End Class