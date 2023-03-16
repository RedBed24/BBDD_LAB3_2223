Public Class Canciones
    Public Property idCancion As Integer
    Public Property NombreCancion As String
    Public Property Duracion As Integer
    Public Property OrdenCancion As Integer
    Public Property Album As Album

    Public Sub New(id As Integer)
        idCancion = id
    End Sub

End Class
