Public Class FormNavegacion
    Private Sub FormNavegacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblTitulo_Nav_Click(sender As Object, e As EventArgs) Handles lblTitulo_Nav.Click

    End Sub

    Private Sub Albumes_Button_Limpiar_Click(sender As Object, e As EventArgs) Handles Albumes_Button_Limpiar.Click
        Navegacion_ListBox_Conciertos.Items.Clear()
        Navegacion_ListBox_setlist.Items.Clear()

    End Sub

    Private Sub Navegacion_Button_VerListado_Click(sender As Object, e As EventArgs) Handles Navegacion_Button_VerListado.Click
        Navegacion_Button_VerListado.PerformClick()

        Dim conciertos As New Concierto

        Try
            conciertos.LeerTodosConciertoes()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        For Each album As Album In conciertos.ConciertDAO.Conciertos

            Navegacion_ListBox_Conciertos.Items.Add(conciertos)
        Next
    End Sub
End Class