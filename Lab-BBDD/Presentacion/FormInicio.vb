Imports System.Runtime.CompilerServices

Public Class FormInicio

    Private Sub AbrirFormEnPanel(ByVal Formhijo As Form)

        If Me.PanelFormulario.Controls.Count > 0 Then
            Me.PanelFormulario.Controls.RemoveAt(0)
        End If

        Formhijo.TopLevel = False
        Formhijo.Dock = DockStyle.Fill
        Me.PanelFormulario.Controls.Add(Formhijo)
        Me.PanelFormulario.Tag = Formhijo
        Formhijo.Show()

    End Sub

    Private Sub btnPaises_Click(sender As Object, e As EventArgs) Handles btnPaises.Click
        AbrirFormEnPanel(New FormPaises)
    End Sub
    Private Sub btnArtistas_Click(sender As Object, e As EventArgs) Handles btnArtistas.Click
        AbrirFormEnPanel(New FormArtistas)
    End Sub

    Private Sub btnAlbum_Click(sender As Object, e As EventArgs) Handles btnAlbum.Click
        AbrirFormEnPanel(New FormAlbumes)
    End Sub

    Private Sub btnCanciones_Click(sender As Object, e As EventArgs) Handles btnCanciones.Click
        AbrirFormEnPanel(New FormCanciones)
    End Sub

    Private Sub btnSitios_Click(sender As Object, e As EventArgs) Handles btnSitios.Click
        AbrirFormEnPanel(New FormSitios)
    End Sub

    Private Sub btnConciertos_Click(sender As Object, e As EventArgs) Handles btnConciertos.Click
        AbrirFormEnPanel(New FormConciertos)
    End Sub

    Private Sub BtnNavegaciones_Click(sender As Object, e As EventArgs) Handles BtnNavegaciones.Click
        AbrirFormEnPanel(New FormNavegacion)
    End Sub

    Private Sub BtnListados_Click(sender As Object, e As EventArgs) Handles BtnListados.Click
        AbrirFormEnPanel(New FormListados)
    End Sub

End Class