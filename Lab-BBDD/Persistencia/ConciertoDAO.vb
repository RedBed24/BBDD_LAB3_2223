Public Class ConciertoDAO
    Public ReadOnly Property Conciertos As Collection

    Private Shared nombreTabla As String = "conciertos"
    Private Shared campoIdentificador As String = "IdConcierto"

    Public Sub New()
        Me.Conciertos = New Collection
    End Sub

    Public Sub LeerTodo()
        Dim tempConcierto As Concierto
        Dim tempArtista As Artista
        Dim tempSitio As Sitio

        Dim tabla, tupla As Collection

        tabla = AgenteBD.ObtenerAgente().Leer("select * from " & nombreTabla & "")

        For Each tupla In tabla
            tempArtista = New Artista(tupla(2).ToString)
            tempArtista.LeerArtista()
            tempSitio = New Sitio(tupla(3).ToString)
            tempSitio.LeerSitio()

            tempConcierto = New Concierto(Integer.Parse(tupla(1).ToString), tempArtista, tempSitio, Date.Parse(tupla(4).ToString))

            tempConcierto.LeerSetlist()

            Me.Conciertos.Add(tempConcierto)
        Next
    End Sub

    ' TODO: Debería ser Por Valor o Por Referencia?? Se van a ver los datos leídos una vez que hayamos llamado al método?
    Public Sub Leer(ByVal concierto As Concierto)
        Dim tempArtista As Artista
        Dim tempSitio As Sitio

        Dim tabla As Collection

        tabla = AgenteBD.ObtenerAgente().Leer("select * from " & nombreTabla & " where " & campoIdentificador & "='" & concierto.idConcierto & "';")

        tempArtista = New Artista(tabla(1)(2).ToString)
        tempArtista.LeerArtista()
        tempSitio = New Sitio(tabla(1)(3).ToString)
        tempSitio.LeerSitio()

        concierto.Artista = tempArtista
        concierto.Sitio = tempSitio
        concierto.FechaConcierto = Date.Parse(tabla(1)(4).ToString)
    End Sub

    Public Function Insertar(ByVal concierto As Concierto) As Integer
        ' No le pasamos una clave porque esta la genera la bbdd automáticamente
        Return AgenteBD.ObtenerAgente().Modificar("insert into " & nombreTabla & " (Artista, Sitio, FechaConcierto) values ('" & concierto.Artista.IdArtista & "', '" & concierto.Sitio.idSitio & "', '" & concierto.FechaConcierto.ToString("yyyy-MM-dd") & "');")
    End Function
    Public Function Actualizar(ByVal concierto As Concierto) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("update " & nombreTabla & " set Artista='" & concierto.Artista.IdArtista & "', Sitio ='" & concierto.Sitio.idSitio & "', FechaConcierto = '" & concierto.FechaConcierto.ToString("yyyy-MM-dd") & "' where " & campoIdentificador & "='" & concierto.idConcierto & "';")
    End Function

    Public Function Borrar(ByVal concierto As Concierto) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("delete from " & nombreTabla & " where " & campoIdentificador & "='" & concierto.idConcierto & "';")
    End Function

    Public Sub LeerConciertosArtista(artista As Artista)
        Dim tempConcierto As Concierto
        Dim tempSitio As Sitio

        Dim tabla As Collection

        tabla = AgenteBD.ObtenerAgente().Leer(
                "Select *
                From conciertos
                Where Artista = " & artista.IdArtista & ";"
                )

        For Each tupla As Collection In tabla
            tempSitio = New Sitio(tupla(3).ToString)
            tempSitio.LeerSitio()

            tempConcierto = New Concierto(Integer.Parse(tupla(1).ToString), artista, tempSitio, Date.Parse(tupla(4).ToString))

            tempConcierto.LeerSetlist()

            Me.Conciertos.Add(tempConcierto)
        Next
    End Sub

    Public Sub LeerConciertosArtistaPais(artista As Artista, pais As Pais)
        Dim tempConcierto As Concierto
        Dim tempSitio As Sitio

        Dim tabla As Collection

        tabla = AgenteBD.ObtenerAgente().Leer(
                "select c.idConcierto, c.Artista, c.Sitio, c.FechaConcierto
                from conciertos c, sitio s
                where s.País = '" & pais.idPais & "' and s.idSitio = c.Sitio and c.Artista = " & artista.IdArtista & ";"
                )

        For Each tupla As Collection In tabla
            tempSitio = New Sitio(tupla(3).ToString)
            tempSitio.LeerSitio()

            tempConcierto = New Concierto(Integer.Parse(tupla(1).ToString), artista, tempSitio, Date.Parse(tupla(4).ToString))

            tempConcierto.LeerSetlist()

            Me.Conciertos.Add(tempConcierto)
        Next
    End Sub

    Public Sub LeerConciertosSitio(Sitio As Sitio)
        Dim tempConcierto As Concierto
        Dim tempArtista As Artista

        Dim tabla As Collection

        tabla = AgenteBD.ObtenerAgente().Leer(
                "select *
                from conciertos
                where Sitio = " & Sitio.idSitio & ";"
                )

        For Each tupla As Collection In tabla
            tempArtista = New Artista(tupla(2).ToString)
            tempArtista.LeerArtista()

            tempConcierto = New Concierto(Integer.Parse(tupla(1).ToString), tempArtista, Sitio, Date.Parse(tupla(4).ToString))

            tempConcierto.LeerSetlist()

            Me.Conciertos.Add(tempConcierto)
        Next
    End Sub

End Class
