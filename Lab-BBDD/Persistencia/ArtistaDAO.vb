Public Class ArtistaDAO
    Public ReadOnly Property Artistas As Collection

    Private Shared nombreTabla As String = "artistas"
    Private Shared campoIdentificador As String = "IdArtista"

    Public Sub New()
        Me.Artistas = New Collection
    End Sub

    Public Sub LeerTodo()
        Dim tempArtista As Artista
        Dim tempPais As Pais

        Dim tabla, tupla As Collection

        tabla = AgenteBD.ObtenerAgente().Leer("select * from " & nombreTabla & "")

        For Each tupla In tabla
            ' obtenemos el identificador del pais
            tempPais = New Pais(tupla(3).ToString)
            ' leemos la información de ese pais
            tempPais.LeerPais()

            tempArtista = New Artista(Integer.Parse(tupla(1).ToString), tupla(2).ToString, tempPais)

            Me.Artistas.Add(tempArtista)
        Next
    End Sub

    ' TODO: Debería ser Por Valor o Por Referencia?? Se van a ver los datos leídos una vez que hayamos llamado al método?
    Public Sub Leer(ByVal artista As Artista)
        Dim tempPais As Pais

        Dim tabla As Collection

        tabla = AgenteBD.ObtenerAgente().Leer("select * from " & nombreTabla & " where " & campoIdentificador & "='" & artista.IdArtista & "';")

        tempPais = New Pais(tabla(1)(3).ToString)
        tempPais.LeerPais()

        artista.Nombre = tabla(1)(2).ToString
        artista.Pais = tempPais
    End Sub

    Public Function Insertar(ByVal artista As Artista) As Integer
        ' No le pasamos una clave porque esta la genera la bbdd automáticamente
        Return AgenteBD.ObtenerAgente().Modificar("insert into " & nombreTabla & " (Nombre, País) values ('" & artista.Nombre & "', '" & artista.Pais.idPais & "');")
    End Function
    Public Function Actualizar(ByVal artista As Artista) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("update " & nombreTabla & " set Nombre='" & artista.Nombre & "',`País` ='" & artista.Pais.idPais & "' where " & campoIdentificador & "='" & artista.IdArtista & "';")
    End Function

    Public Function Borrar(ByVal artista As Artista) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("delete from " & nombreTabla & " where " & campoIdentificador & "='" & artista.IdArtista & "';")
    End Function

    Public Sub LeerArtistasQueInterpretaronUnAlbumCompleto()
        Dim canciones As New Cancion
        canciones.LeerTodosCanciones()

        Dim conciertos As New Concierto()
        conciertos.LeerTodosConciertoes()

        Dim albumes As New List(Of List(Of Cancion))

        Dim max = 0
        For Each cancion As Cancion In canciones.CancioDAO.Canciones
            If max < cancion.Album.idAlbum Then
                max = cancion.Album.idAlbum
            End If
        Next

        For i As Integer = 0 To max
            albumes.Add(New List(Of Cancion))
        Next

        For Each cancion As Cancion In canciones.CancioDAO.Canciones
            ' para cada canción, la añadimos al album correspondiente
            ' el album se selecciona por el índice
            albumes.ElementAt(cancion.Album.idAlbum).Add(cancion)
        Next

        ' TODO: albumes puede tener posiciones vacías (álbumes sin canciones)

        Dim albumesCompletameInterpretados As New List(Of Album)

        For Each album As List(Of Cancion) In albumes
            For Each concierto As Concierto In conciertos.ConciertDAO.Conciertos
                If completo(album, concierto) Then
                    albumesCompletameInterpretados.Add(album.ElementAt(0).Album)
                End If
            Next
        Next

        Dim artistasAlbumCompleto As New List(Of Artista)

        For Each album As Album In albumesCompletameInterpretados
            Dim yaAñadido = False
            Dim i = 0
            While Not yaAñadido And i < artistasAlbumCompleto.Count
                If artistasAlbumCompleto.ElementAt(i).IdArtista = album.Artist.IdArtista Then
                    yaAñadido = True
                End If
            End While
            ' sólo lo añadimos si no estaba ya añadido
            If Not yaAñadido Then
                artistasAlbumCompleto.Add(album.Artist)
            End If
        Next

        For Each artista In artistasAlbumCompleto
            Artistas.Add(artista)
        Next

    End Sub

    ''' <summary>
    ''' Función auxiliar
    ''' Se comprueba si todas las canciones pertenecientes al album están contenidas en el concierto
    ''' </summary>
    ''' <param name="album">Lista de canciones a buscar</param>
    ''' <param name="concierto">Concierto con las canciones</param>
    ''' <returns>True si el album ha sido completamente cantado en el concierto. False si falta alguna canción del album dentro del concierto</returns>
    Private Function completo(album As List(Of Cancion), concierto As Concierto) As Boolean
        ' se asume completo
        Dim complet = True
        Dim i = 0
        ' para cada canción del album
        While complet And i < album.Count
            ' se asume no encontrada
            Dim encontrada = False
            Dim j = 0
            ' para cada canción del concierto
            While Not encontrada And j < concierto.SetList.Count
                ' si es la canción del album
                If album.ElementAt(i).idCancion = concierto.SetList.ElementAt(j).idCancion Then
                    encontrada = True
                End If
            End While
            ' si no la hemos encontrado
            If Not encontrada Then
                ' no está completo
                complet = False
            End If
        End While

        Return completo
    End Function

End Class
