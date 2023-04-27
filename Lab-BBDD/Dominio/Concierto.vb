Public Class Concierto
    Public Property idConcierto As Integer
    Public Property FechaConcierto As Date
    Public Property SetList As List(Of Cancion)
    Public Property Artista As Artista
    Public Property Sitio As Sitio

    Public Property ConciertDAO As ConciertoDAO
    Public Property SetlisDAO As SetlistDAO

    Public Sub New()
        ConciertDAO = New ConciertoDAO
        SetlisDAO = New SetlistDAO
    End Sub

    Public Sub New(id As Integer)
        ConciertDAO = New ConciertoDAO
        SetlisDAO = New SetlistDAO
        SetList = New List(Of Cancion)
        idConcierto = id
    End Sub

    Public Sub New(id As Integer, artist As Artista, site As Sitio, fecha As Date)
        ConciertDAO = New ConciertoDAO
        SetlisDAO = New SetlistDAO
        SetList = New List(Of Cancion)
        idConcierto = id
        Artista = artist
        Sitio = site
        FechaConcierto = fecha
    End Sub

    Public Sub New(artist As Artista, site As Sitio, fecha As Date, setliste As List(Of Cancion))
        ConciertDAO = New ConciertoDAO
        SetlisDAO = New SetlistDAO
        SetList = setliste
        Artista = artist
        Sitio = site
        FechaConcierto = fecha
    End Sub

    Public Sub LeerTodosConciertoes()
        Me.ConciertDAO.LeerTodo()
    End Sub

    ''' <summary>
    ''' NO SE DEBERÍA LLAMAR A ESTE MÉTODO, SÓLO LO DEBE USAR ConciertoDAO
    ''' </summary>
    Public Sub LeerSetlist()
        Me.SetlisDAO.Leer(Me)
    End Sub

    Public Sub LeerConcierto()
        Me.ConciertDAO.Leer(Me)
        LeerSetlist()
    End Sub

    ''' <summary>
    ''' Intenta insertar un concierto y su setlist.
    ''' </summary>
    ''' <returns>El número de tuplas insertadas en la tabla setlist</returns>
    Public Function InsertarConcierto() As Integer
        Me.ConciertDAO.Insertar(Me)
        ' si no se ha podido añaidir el concierto, intentar insertar las setlist dará un fallo por la integridad referencial
        Return Me.SetlisDAO.Insertar(Me)
    End Function

    ''' <summary>
    ''' Actualiza todo el setlist del concierto junto con la información del concierto
    ''' </summary>
    ''' <returns>Diferencia de canciones añadidas y borradas</returns>
    Public Function ActualizarConcierto() As Integer
        Me.ConciertDAO.Actualizar(Me)
        Return ActualizarSetlist()
    End Function

    ''' <summary>
    ''' Intenta borrar la setlist y luego, el concierto.
    ''' Si no se consigue borrar alguna canción, se devuelve cuántas canciones faltan por borrar en negativo
    ''' </summary>
    ''' <returns>
    ''' > 1 si todo es correcto
    ''' > Un número negativo si no se ha podido borrar las canciones
    ''' >  0 si se han borrado las canciones pero no el concierto
    ''' </returns>
    Public Function BorrarConcierto() As Integer
        Dim cancionesborradas As Integer = Me.SetlisDAO.Borrar(Me)

        ' si no hemos conseguido borrar todas las canciones, marcamos el error
        If cancionesborradas <> SetList.Count Then
            ' no deberíamos borrar la setlist, volvemos indicando cuantas canciones se tienen que borrar, en negativo para recalcar el error
            Return cancionesborradas - SetList.Count
        End If

        Return Me.ConciertDAO.Borrar(Me)
    End Function

    ''' <summary>
    ''' Actualiza todo el setlist del concierto
    ''' </summary>
    ''' <returns>Diferencia de canciones añadidas y borradas</returns>
    Private Function ActualizarSetlist() As Integer
        ' No tiene mucho sentido que se devuelva algo
        Dim cancionesBorradas As Integer = Me.SetlisDAO.Borrar(Me)
        Dim cancionesAñadidas As Integer = Me.SetlisDAO.Insertar(Me)
        Return cancionesAñadidas - cancionesBorradas
    End Function

    Overrides Public Function ToString() As String
        Return FechaConcierto.ToString & " " & Artista.ToString
    End Function

End Class
