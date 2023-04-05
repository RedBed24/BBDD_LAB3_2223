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
        Return AgenteBD.ObtenerAgente().Modificar("insert into " & nombreTabla & " values ('" & artista.IdArtista & "', '" & artista.Nombre & "');")
    End Function
    Public Function Actualizar(ByVal artista As Artista) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("update " & nombreTabla & " set NombreArtista='" & artista.Nombre & "' where " & campoIdentificador & "='" & artista.IdArtista & "';")
    End Function

    Public Function Borrar(ByVal artista As Artista) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("delete from " & nombreTabla & " where " & campoIdentificador & "='" & artista.IdArtista & "';")
    End Function


End Class
