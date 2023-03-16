Public Class Pais
    Public Property idPais As String
    Public Property NombrePais As String
    'Public ReadOnly Property PaisDAO As PaisDAO'

    Public Sub New(id As String)
        idPais = id
    End Sub

    Private Sub obtainID()
        idPais = NombrePais.Substring(0, 3).ToUpper
    End Sub

    Public Sub LeerTodosPaises()

    End Sub

End Class
