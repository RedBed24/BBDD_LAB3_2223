Public Class Artista
    Public Property IdArtista As Integer
    Public Property Nombre As String
    Public Property Pais As Pais

    'Public ReadOnly Property ArtistaDAO As ArtistaDAO'

    Public Sub New(id As String)
        IdArtista = id
    End Sub

    ' Set list no tiene porqué ser una clase sola, la podemos poner como 1'

    ' Nos piden una serie de consultas '

    ' Navegaciones, permite mostrar información sobre los conciertos de un cierto artista'
    ' Filtrado por pais...'

End Class