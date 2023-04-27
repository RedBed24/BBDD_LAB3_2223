Public Class FormNavegacion
    Private Sub lblTitulo_Alb_Click(sender As Object, e As EventArgs) Handles lblTitulo_Nav.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Navegacion_Label_sitio.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Navegacion_ComboBox_sitio.SelectedIndexChanged

    End Sub

    Private Sub Navegacion_Button_limpiar_Click(sender As Object, e As EventArgs) Handles Navegacion_Button_limpiar.Click
        Navegacion_ListBox_listado.Items.Clear()
        Navegacion_ListBox_setlist.Items.Clear()

    End Sub

    Private Sub Navegacion_Button_VerListado_Click(sender As Object, e As EventArgs) Handles Navegacion_Button_VerListado.Click
        Navegacion_Button_limpiar.PerformClick()

        Dim conciertos As New Concierto


        Try
            conciertos.LeerTodosConciertoes()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        For Each artista As Artista In conciertos.ConciertDAO.Conciertos
            Navegacion_ListBox_setlist.Items.Add(artista)
        Next
    End Sub
End Class