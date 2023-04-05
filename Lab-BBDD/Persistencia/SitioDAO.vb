Public Class SitioDAO
    Public ReadOnly Property Sitios As Collection

    Private Shared nombreTabla As String = "sitios"
    Private Shared campoIdentificador As String = "Idsitio"

    Public Sub New()
        Me.Sitios = New Collection
    End Sub

    Public Sub LeerTodo()
        Dim tempSitio As Sitio
        Dim tempPais As Pais

        Dim tabla, tupla As Collection

        tabla = AgenteBD.ObtenerAgente().Leer("select * from " & nombreTabla & "")

        For Each tupla In tabla
            ' obtenemos el identificador del pais
            tempPais = New Pais(tupla(3).ToString)
            ' leemos la información de ese pais
            tempPais.LeerPais()

            tempSitio = New Sitio(tupla(1).ToString, tupla(2).ToString, tempPais, tupla(3).ToString)

            Me.Sitios.Add(tempSitio)
        Next
    End Sub

    ' TODO: Debería ser Por Valor o Por Referencia?? Se van a ver los datos leídos una vez que hayamos llamado al método?
    Public Sub Leer(ByVal sitio As Sitio)
        Dim tempPais As Pais

        Dim tabla As Collection

        tabla = AgenteBD.ObtenerAgente().Leer("select * from " & nombreTabla & " where " & campoIdentificador & "='" & sitio.idSitio & "';")

        tempPais = New Pais(tabla(1)(3).ToString)
        tempPais.LeerPais()

        sitio.NombreSitio = tabla(1)(2).ToString
        sitio.Pais = tempPais
        sitio.tipo = tabla(1)(3).ToString
    End Sub

    Public Function Insertar(ByVal sitio As Sitio) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("insert into " & nombreTabla & " values ('" & sitio.idSitio & "', '" & sitio.NombreSitio & "');")
    End Function
    Public Function Actualizar(ByVal sitio As Sitio) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("update " & nombreTabla & " set NombreSitio='" & sitio.NombreSitio & "' where " & campoIdentificador & "='" & sitio.idSitio & "';")
    End Function

    Public Function Borrar(ByVal sitio As Sitio) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("delete from " & nombreTabla & " where " & campoIdentificador & "='" & sitio.idSitio & "';")
    End Function

End Class

