Public Class Artista
    Public Property IdArtista As Integer
    Public Property Nombre As String
    Public Property Pais As Pais

    Public ReadOnly Property ArtistDAO As ArtistaDAO

    Public Sub New()
        ArtistDAO = New ArtistaDAO
    End Sub

    Public Sub New(id As Integer)
        ArtistDAO = New ArtistaDAO
        IdArtista = id
    End Sub

    Public Sub New(nomb As String, pai As Pais)
        ArtistDAO = New ArtistaDAO
        Nombre = nomb
        Pais = pai
    End Sub

    Public Sub New(id As Integer, nomb As String, pai As Pais)
        ArtistDAO = New ArtistaDAO
        IdArtista = id
        Nombre = nomb
        Pais = pai
    End Sub

    Public Sub LeerTodosArtistas()
        Me.ArtistDAO.LeerTodo()
    End Sub

    Public Sub LeerArtista()
        Me.ArtistDAO.Leer(Me)
    End Sub

    Public Function InsertarArtista() As Integer
        Return Me.ArtistDAO.Insertar(Me)
    End Function

    Public Function ActualizarArtista() As Integer
        Return Me.ArtistDAO.Actualizar(Me)
    End Function

    Public Function BorrarArtista() As Integer
        Return Me.ArtistDAO.Borrar(Me)
    End Function

    Public Overrides Function ToString() As String
        Return IdArtista & ": " & Nombre & ", from " & Pais.ToString
    End Function
End Class