Public Class Album
    Public Property idAlbum As Integer
    Public Property NombreAlbum As String
    Public Property AñoAlbum As Integer
    Public Property Artist As Artista

    Public ReadOnly Property AlbuDAO As AlbumDAO

    Public Sub New()
        AlbuDAO = New AlbumDAO
    End Sub

    Public Sub New(id As Integer)
        AlbuDAO = New AlbumDAO
        idAlbum = id
    End Sub

    Public Sub New(nomb As String, año As Integer, Artist As Artista)
        AlbuDAO = New AlbumDAO
        NombreAlbum = nomb
        AñoAlbum = año
        Me.Artist = Artist
    End Sub

    Public Sub New(id As Integer, nomb As String, año As Integer, Artist As Artista)
        AlbuDAO = New AlbumDAO
        idAlbum = id
        NombreAlbum = nomb
        AñoAlbum = año
        Me.Artist = Artist
    End Sub

    Public Sub LeerTodosAlbumes()
        Me.AlbuDAO.LeerTodo()
    End Sub

    Public Sub LeerAlbum()
        Me.AlbuDAO.Leer(Me)
    End Sub

    Public Function InsertarAlbum() As Integer
        Return Me.AlbuDAO.Insertar(Me)
    End Function

    Public Function ActualizarAlbum() As Integer
        Return Me.AlbuDAO.Actualizar(Me)
    End Function

    Public Function BorrarAlbum() As Integer
        Return Me.AlbuDAO.Borrar(Me)
    End Function

    Public Sub LeerAlbumesMasInterpretadosArtista(Artista As Artista)
        Me.AlbuDAO.LeerAlbumesMasInterpretadosArtista(Artista)
    End Sub

    Overrides Public Function ToString() As String
        Return NombreAlbum
    End Function

End Class
