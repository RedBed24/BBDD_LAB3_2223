Public Class Conciertos
    Public Property idConcierto As Integer
    Public Property FechaConciertos As Date
    Public Property OrdenSetlist As Integer
    Public Property Artista As Artista
    Public Property Sitio As Sitio


    Public Sub New(id As String)
        idConcierto = id
    End Sub


End Class
