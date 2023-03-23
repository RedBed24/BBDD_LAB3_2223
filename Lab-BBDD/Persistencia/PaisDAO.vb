Public Class PaisDAO

    Public ReadOnly Property Pais As Collection

    Public Sub New()
        Me.Pais = New Collection
    End Sub

    Public Sub LeerTodo()
        Dim tempPais As Pais
        Dim tabla, tupla As Collection

        tabla = AgenteBD.obtenerAgente().Leer()

    End Sub

End Class
