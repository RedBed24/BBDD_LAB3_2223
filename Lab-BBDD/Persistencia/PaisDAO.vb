Public Class PaisDAO

    Public ReadOnly Property Pais As Collection

    Public Sub New()
        Me.Pais = New Collection
    End Sub

    Public Sub LeerTodo()
        Dim tempPais As Pais
        Dim tabla, tupla As Collection

        tabla = AgenteBD.ObtenerAgente().Leer("select * from paises")
        For Each tupla In tabla
            tempPais = New Pais(tupla(1).ToString, tupla(2).ToString)
            Me.Pais.Add(tempPais)
        Next
    End Sub

    Public Function Insertar(ByVal pais As Pais) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("insert into paises values ('" & pais.idPais & "', '" & pais.NombrePais & "');")
    End Function
    Public Function Actualizar(ByVal pais As Pais) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("update paises set NombrePais='" & pais.NombrePais & "' where (idPais='" & pais.NombrePais & "');")
    End Function

    End Sub

End Class
