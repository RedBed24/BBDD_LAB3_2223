Public Class CancionDAO
    Public ReadOnly Property Canciones As Collection

    Private Shared nombreTabla As String = "canciones"
    Private Shared campoIdentificador As String = "idCancion"

    Public Sub New()
        Me.Canciones = New Collection
    End Sub

    Public Sub LeerTodo()
        Dim tempCancion As Cancion
        Dim tempAlbum As Album

        Dim tabla, tupla As Collection

        tabla = AgenteBD.ObtenerAgente().Leer("select * from " & nombreTabla & "")

        For Each tupla In tabla
            tempAlbum = New Album(Integer.Parse(tupla(4).ToString))
            tempAlbum.LeerAlbum()

            tempCancion = New Cancion(Integer.Parse(tupla(1).ToString), tupla(2).ToString, Integer.Parse(tupla(3).ToString), tempAlbum, Integer.Parse(tupla(5).ToString))

            Me.Canciones.Add(tempCancion)
        Next
    End Sub

    ' TODO: Debería ser Por Valor o Por Referencia?? Se van a ver los datos leídos una vez que hayamos llamado al método?
    Public Sub Leer(ByVal cancion As Cancion)
        Dim tempAlbum As Album

        Dim tabla As Collection

        tabla = AgenteBD.ObtenerAgente().Leer("select * from " & nombreTabla & " where " & campoIdentificador & "='" & cancion.idCancion & "';")

        tempAlbum = New Album(Integer.Parse(tabla(1)(4).ToString))
        tempAlbum.LeerAlbum()

        cancion.NombreCancion = tabla(1)(2).ToString
        cancion.Duracion = Integer.Parse(tabla(1)(3).ToString)
        cancion.Album = tempAlbum
        cancion.OrdenCancion = Integer.Parse(tabla(1)(3).ToString)
    End Sub

    Public Function Insertar(ByVal cancion As Cancion) As Integer
        ' No le pasamos una clave porque esta la genera la bbdd automáticamente
        Return AgenteBD.ObtenerAgente().Modificar("insert into " & nombreTabla & " (NombreCancion, Duración, Album, OrdenCanción) values ('" & cancion.NombreCancion & "', '" & cancion.Duracion & "', '" & cancion.Album.idAlbum & "', '" & cancion.OrdenCancion & "');")
    End Function
    Public Function Actualizar(ByVal cancion As Cancion) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("update " & nombreTabla & " set NombreCancion='" & cancion.NombreCancion & "', Duración='" & cancion.Duracion & "', Album='" & cancion.Album.idAlbum & "', OrdenCanción='" & cancion.OrdenCancion & "' where " & campoIdentificador & "='" & cancion.idCancion & "';")
    End Function

    Public Function Borrar(ByVal cancion As Cancion) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("delete from " & nombreTabla & " where " & campoIdentificador & "='" & cancion.idCancion & "';")
    End Function

    Public Sub LeerCancionesArtista(artista As Artista)
        Dim tempCancion As Cancion
        Dim tempAlbum As Album

        Dim tabla As Collection

        tabla = AgenteBD.ObtenerAgente().Leer(
            "Select c.idCancion, c.NombreCancion, c.Duración, c.Album, c.OrdenCanción
            From artistas a, canciones c, albumes l
            Where a.IdArtista = " & artista.IdArtista & " And l.Artista = a.IdArtista And c.Album = l.idAlbum;"
            )

        For Each tupla As Collection In tabla
            tempAlbum = New Album(Integer.Parse(tupla(4).ToString))
            tempAlbum.LeerAlbum()

            tempCancion = New Cancion(Integer.Parse(tupla(1).ToString), tupla(2).ToString, Integer.Parse(tupla(3).ToString), tempAlbum, Integer.Parse(tupla(5).ToString))

            Me.Canciones.Add(tempCancion)
        Next
    End Sub

End Class
