Public Class AlbumDAO

    Public ReadOnly Property Albumes As Collection

    Private Shared nombreTabla As String = "albumes"
    Private Shared campoIdentificador As String = "idAlbum"

    Public Sub New()
        Me.Albumes = New Collection
    End Sub

    Public Sub LeerTodo()
        Dim tempAlbum As Album
        Dim tempArtista As Artista

        Dim tabla, tupla As Collection

        tabla = AgenteBD.ObtenerAgente().Leer("select * from " & nombreTabla & "")

        For Each tupla In tabla
            tempArtista = New Artista(Integer.Parse(tupla(4).ToString))
            tempArtista.LeerArtista()

            tempAlbum = New Album(Integer.Parse(tupla(1).ToString), tupla(2).ToString, Integer.Parse(tupla(3).ToString), tempArtista)

            Me.Albumes.Add(tempAlbum)
        Next
    End Sub

    ' TODO: Debería ser Por Valor o Por Referencia?? Se van a ver los datos leídos una vez que hayamos llamado al método?
    Public Sub Leer(ByVal album As Album)
        Dim tempArtista As Artista

        Dim tabla As Collection

        tabla = AgenteBD.ObtenerAgente().Leer("select * from " & nombreTabla & " where " & campoIdentificador & "='" & album.idAlbum & "';")

        tempArtista = New Artista(Integer.Parse(tabla(1)(4).ToString))
        tempArtista.LeerArtista()

        album.NombreAlbum = tabla(1)(2).ToString
        album.AñoAlbum = Integer.Parse(tabla(1)(3).ToString)
        album.Artist = tempArtista
    End Sub

    Public Function Insertar(ByVal album As Album) As Integer
        ' No le pasamos una clave porque esta la genera la bbdd automáticamente
        Return AgenteBD.ObtenerAgente().Modificar("insert into " & nombreTabla & " (NombreAlbum, AñoAlbum, Artista) values ('" & album.NombreAlbum & "', '" & album.AñoAlbum & "', '" & album.Artist.IdArtista & "');")
    End Function
    Public Function Actualizar(ByVal album As Album) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("update " & nombreTabla & " set NombreAlbum='" & album.NombreAlbum & "', AñoAlbum='" & album.AñoAlbum & "', Artista='" & album.Artist.IdArtista & "' where " & campoIdentificador & "='" & album.idAlbum & "';")
    End Function

    Public Function Borrar(ByVal album As Album) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("delete from " & nombreTabla & " where " & campoIdentificador & "='" & album.idAlbum & "';")
    End Function

    Public Sub LeerAlbumesMasInterpretadosArtista(artista As Artista)
        Dim tabla As Collection

        tabla = AgenteBD.ObtenerAgente().Leer("
            Select count(s.Concierto) || ': ' || a.NombreAlbum
            from albumes a, canciones c, setlists s
            where a.idAlbum = c.Album and c.idCancion = s.canción
            group by a.idAlbum
            order by count(s.Concierto) desc;
            ")

        For Each tupla As Collection In tabla
            Me.Albumes.Add(tupla)
        Next
    End Sub

End Class
