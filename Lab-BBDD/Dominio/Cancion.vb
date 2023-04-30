Public Class Cancion
    Public Property idCancion As Integer
    Public Property NombreCancion As String
    Public Property Duracion As Integer
    Public Property OrdenCancion As Integer

    Public Property Album As Album

    Public ReadOnly Property CancioDAO As CancionDAO

    Public Sub New()
        CancioDAO = New CancionDAO
    End Sub

    Public Sub New(id As Integer)
        CancioDAO = New CancionDAO
        idCancion = id
    End Sub

    Public Sub New(nomb As String, dur As Integer, Albu As Album, orden As Integer)
        CancioDAO = New CancionDAO
        NombreCancion = nomb
        Duracion = dur
        Me.Album = Albu
        OrdenCancion = orden
    End Sub

    Public Sub New(id As Integer, nomb As String, dur As Integer, Albu As Album, orden As Integer)
        CancioDAO = New CancionDAO
        idCancion = id
        NombreCancion = nomb
        Duracion = dur
        Me.Album = Albu
        OrdenCancion = orden
    End Sub

    Public Sub LeerTodosCanciones()
        Me.CancioDAO.LeerTodo()
    End Sub

    Public Sub LeerCancion()
        Me.CancioDAO.Leer(Me)
    End Sub

    Public Function InsertarCancion() As Integer
        Return Me.CancioDAO.Insertar(Me)
    End Function

    Public Function ActualizarCancion() As Integer
        Return Me.CancioDAO.Actualizar(Me)
    End Function

    Public Function BorrarCancion() As Integer
        Return Me.CancioDAO.Borrar(Me)
    End Function

    ''' <summary>
    ''' Obtiene todas las canciones del artista dado y las carga en Me.CancioDAO.Canciones sin modificar las canciones de Me
    ''' </summary>
    ''' <param name="artista"></param>
    Public Sub LeerCancionesArtista(artista As Artista)
        Me.CancioDAO.LeerCancionesArtista(artista)
    End Sub

    ''' <summary>
    ''' Obtiene las canciones más interpretadas del artista dado
    ''' Carga STRINGs en Me.CancioDAO con la cuenta y el nombre de la canción
    ''' </summary>
    ''' <param name="artista"></param>
    Public Sub LeerCancionesCuentaMasInterpretadas(artista As Artista)
        Me.CancioDAO.LeerCancionesCuentaMasInterpretadas(artista)
    End Sub

    Public Sub LeerCancionesCuentaMasInterpretadas()
        Me.CancioDAO.LeerCancionesCuentaMasInterpretadas()
    End Sub

    Overrides Public Function ToString() As String
        Return NombreCancion
    End Function

End Class
