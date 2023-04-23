Public Class FormSitios

    Private Sub FormSitios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim paist As New Pais
        paist.LeerTodosPaises()

        For Each pais As Pais In paist.PaiDAO.Paises
            Sitios_ComboBox_PaisSitio.Items.Add(pais)
        Next
    End Sub

    Private Sub Sitios_Button_VerTodosSitios_Click(sender As Object, e As EventArgs) Handles Sitios_Button_VerTodosSitios.Click
        Sitios_Button_Limpiar.PerformClick()

        Dim sitios As New Sitio

        Try
            sitios.LeerTodosSitios()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        For Each sitio As Sitio In sitios.SiteDAO.Sitios
            Sitios_ListBox_Sitios.Items.Add(sitio)
        Next
    End Sub

    Private Sub Sitios_ListBox_Sitios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Sitios_ListBox_Sitios.SelectedIndexChanged

        If Sitios_ListBox_Sitios.SelectedItem Is Nothing Then
            Exit Sub
        End If

        Sitios_Button_Actualizar.Enabled = True
        Sitios_Button_Eliminar.Enabled = True

        Dim sitio As Sitio = Sitios_ListBox_Sitios.SelectedItem

        Sitios_TextBox_NombreSitio.Text = sitio.NombreSitio

        For Each item As Pais In Sitios_ComboBox_PaisSitio.Items
            If item.idPais = sitio.Pais.idPais Then
                Sitios_ComboBox_PaisSitio.SelectedItem = item
                Exit For
            End If
        Next
        For Each item As String In Sitios_ComboBox_TipoSitio.Items
            If item = sitio.tipo Then
                Sitios_ComboBox_TipoSitio.SelectedItem = item
                Exit For
            End If
        Next

    End Sub

    Private Sub Sitios_ButtonAgregar_Click(sender As Object, e As EventArgs) Handles Sitios_Button_Agregar.Click

        Dim nombre As String = Sitios_TextBox_NombreSitio.Text

        If String.IsNullOrEmpty(nombre) Then
            MessageBox.Show("El album debe tener un nombre.")
            Exit Sub
        End If

        Dim paisSitio As Pais = Sitios_ComboBox_PaisSitio.SelectedItem
        Dim nombrePais As String = paisSitio.NombrePais
        If String.IsNullOrEmpty(nombrePais) Then
            MessageBox.Show("Debe seleccionar un país primero.")
            Exit Sub
        End If

        Dim tipoSitio As String = Sitios_ComboBox_TipoSitio.SelectedItem
        If String.IsNullOrEmpty(tipoSitio) Then
            MessageBox.Show("Debe seleccionar un tipo de sitio primero.")
            Exit Sub
        End If

        Dim sitioAnadir As New Sitio(nombre, paisSitio, tipoSitio)

        Try
            If sitioAnadir.InsertarSitio() <> 1 Then
                MessageBox.Show("wtf cómo puede ocurrir esto?")
                Exit Sub
            End If
        Catch ex As Exception
            ' no se puede añadir
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show(sitioAnadir.ToString & " añadido correctamente")
        Sitios_Button_VerTodosSitios.PerformClick()
        Sitios_ListBox_Sitios.SelectedIndex = Sitios_ListBox_Sitios.Items.Count - 1

    End Sub

    Private Sub Sitios_ButtonActualizar_Click(sender As Object, e As EventArgs) Handles Sitios_Button_Actualizar.Click

        If Sitios_ListBox_Sitios.SelectedItem Is Nothing Then
            MessageBox.Show("Se debe seleccionar un sitio")
            Exit Sub
        End If

        Dim sitiomodificar As Sitio = Sitios_ListBox_Sitios.SelectedItem

        Dim nombrenuevo As String = Sitios_TextBox_NombreSitio.Text

        If String.IsNullOrEmpty(nombrenuevo) Then
            MessageBox.Show("Se debe introducir un nombre de sitio válido")
            Exit Sub
        End If

        If Sitios_ComboBox_TipoSitio.SelectedItem Is Nothing Then
            MessageBox.Show("Se debe seleccionar un tipo de sitio")
            Exit Sub
        End If

        Dim tipositionuevo As String = Sitios_ComboBox_TipoSitio.SelectedItem

        If Sitios_ComboBox_PaisSitio.SelectedItem Is Nothing Then
            MessageBox.Show("Se debe seleccionar un país del sitio")
            Exit Sub
        End If

        Dim paissitionuevo As Pais = Sitios_ComboBox_PaisSitio.SelectedItem

        sitiomodificar.NombreSitio = nombrenuevo
        sitiomodificar.tipo = tipositionuevo
        sitiomodificar.Pais = paissitionuevo

        Try
            If sitiomodificar.ActualizarSitio() <> 1 Then
                ' wtf como ocurre esto?
                MessageBox.Show("no existe (y no se puede modificar) " & sitiomodificar.ToString)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show(sitiomodificar.ToString & " modificado correctamente")

        ' porque no se ve actualizado en el listbox
        Sitios_ListBox_Sitios.Items.Remove(sitiomodificar)
        Sitios_ListBox_Sitios.Items.Add(sitiomodificar)
        Sitios_ListBox_Sitios.SelectedItem = sitiomodificar
    End Sub

    Private Sub sitios_ButtonEliminar_Click(sender As Object, e As EventArgs) Handles Sitios_Button_Eliminar.Click
        If Sitios_ListBox_Sitios.SelectedItem Is Nothing Then
            MessageBox.Show("Se debe seleccionar un sitio")
            Exit Sub
        End If

        Dim sitioborrar As Sitio = Sitios_ListBox_Sitios.SelectedItem

        Try
            If sitioborrar.BorrarSitio() <> 1 Then
                MessageBox.Show("no existe (y no se puede borrar) " & sitioborrar.ToString)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show(sitioborrar.ToString & " eliminado correctamente")
        Sitios_ListBox_Sitios.Items.Remove(sitioborrar)
    End Sub

    Private Sub sitios_ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles Sitios_Button_Limpiar.Click
        Sitios_ListBox_Sitios.Items.Clear()
        Sitios_TextBox_NombreSitio.Clear()

        Sitios_ComboBox_PaisSitio.SelectedIndex = -1
        Sitios_ComboBox_PaisSitio.Text = ""

        Sitios_ComboBox_TipoSitio.SelectedIndex = -1
        Sitios_ComboBox_TipoSitio.Text = ""

        Sitios_Button_Actualizar.Enabled = False
        Sitios_Button_Eliminar.Enabled = False
    End Sub
End Class
