Public Class Sitio
    Public Property idSitio As Integer
    Public Property NombreSitio As String
    Public Property Pais As Pais

    ' Esto es un enum, por eso podemos usar un combobox para selecionar los 4 disponibles'
    'sala, pabellón, estadio, festival'
    Public Property tipo As String

    Public ReadOnly Property SiteDAO As SitioDAO

    Public Sub New()
        SiteDAO = New SitioDAO
    End Sub

    Public Sub New(id As Integer)
        SiteDAO = New SitioDAO
        idSitio = id
    End Sub

    Public Sub New(id As Integer, nomb As String, pai As Pais, typ As String)
        SiteDAO = New SitioDAO
        idSitio = id
        NombreSitio = nomb
        Pais = pai
        tipo = typ
    End Sub

    Public Sub New(nomb As String, pai As Pais, typ As String)
        SiteDAO = New SitioDAO
        NombreSitio = nomb
        Pais = pai
        tipo = typ
    End Sub

    Public Sub LeerTodosSitios()
        Me.SiteDAO.LeerTodo()
    End Sub

    Public Sub LeerSitio()
        Me.SiteDAO.Leer(Me)
    End Sub

    Public Function InsertarSitio() As Integer
        Return Me.SiteDAO.Insertar(Me)
    End Function

    Public Function ActualizarSitio() As Integer
        Return Me.SiteDAO.Actualizar(Me)
    End Function

    Public Function BorrarSitio() As Integer
        Return Me.SiteDAO.Borrar(Me)
    End Function

End Class

