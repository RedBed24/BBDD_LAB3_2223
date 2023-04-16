Imports System.Runtime.CompilerServices

Public Class FormInicio

    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)

        If Me.PanelFormulario.Controls.Count > 0 Then
            Me.PanelFormulario.Controls.RemoveAt(0)
        End If

        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelFormulario.Controls.Add(fh)
        Me.PanelFormulario.Tag = fh
        fh.Show()

    End Sub
    Private Sub btnPaises_Click(sender As Object, e As EventArgs) Handles btnPaises.Click
        AbrirFormEnPanel(New FormPais)
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
End Class