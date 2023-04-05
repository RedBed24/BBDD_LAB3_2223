Public Class PaisDAO

    Public ReadOnly Property Pais As Collection

    Private Shared nombreTabla As String = "paises"
    Private Shared campoIdentificador As String = "idPais"

    Public Sub New()
        Me.Pais = New Collection
    End Sub

    Public Sub LeerTodo()
        Dim tempPais As Pais
        Dim tabla, tupla As Collection

        tabla = AgenteBD.ObtenerAgente().Leer("select * from " & nombreTabla & "")
        For Each tupla In tabla
            tempPais = New Pais(tupla(1).ToString, tupla(2).ToString)
            Me.Pais.Add(tempPais)
        Next
    End Sub

    Public Sub Leer(ByVal pais As Pais)
        Dim tabla As Collection
        tabla = AgenteBD.ObtenerAgente().Leer("select * from " & nombreTabla & " where " & campoIdentificador & "='" & pais.idPais & "';")

        ' tabla debe tener una única tupla
        pais.NombrePais = tabla(1)(2).ToString
    End Sub

    Public Function Insertar(ByVal pais As Pais) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("insert into " & nombreTabla & " values ('" & pais.idPais & "', '" & pais.NombrePais & "');")
    End Function
    Public Function Actualizar(ByVal pais As Pais) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("update " & nombreTabla & " set NombrePais='" & pais.NombrePais & "' where " & campoIdentificador & "='" & pais.NombrePais & "';")
    End Function

    Public Function Borrar(ByVal pais As Pais) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("delete from " & nombreTabla & " where " & campoIdentificador & "='" & pais.idPais & "';")
    End Function

End Class
