Public Class Sitios
    Public Property idSitio As Integer
    Public Property NombreSitio As String
    Public Property Pais As Pais
    ' Esto es un enum, por eso podemos usar un combobox para selecionar los 4 disponibles'
    'sala, pabellón, estadio, festival'
    Public Property tipo As String

    Public Sub New(id As Integer)
        idSitio = id
    End Sub

End Class
