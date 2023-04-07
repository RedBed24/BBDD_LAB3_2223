Public Class Cancion
    Public Property idCancion As Integer
    Public Property NombreCancion As String
    Public Property Duracion As Integer
    Public Property OrdenCancion As Integer

    Public Property Album As Album

    Public ReadOnly Property CancioDAO As CancionDAO

    Public Sub New()
        CancioDAO = New CancionDAO
    End Sub

    Public Sub New(id As Integer)
        CancioDAO = New CancionDAO
        idCancion = id
    End Sub

    Public Sub New(nomb As String, dur As Integer, Albu As Album, orden As Integer)
        CancioDAO = New CancionDAO
        NombreCancion = nomb
        Duracion = dur
        Me.Album = Albu
        OrdenCancion = orden
    End Sub

    Public Sub New(id As Integer, nomb As String, dur As Integer, Albu As Album, orden As Integer)
        CancioDAO = New CancionDAO
        idCancion = id
        NombreCancion = nomb
        Duracion = dur
        Me.Album = Albu
        OrdenCancion = orden
    End Sub

    Public Sub LeerTodosCanciones()
        Me.CancioDAO.LeerTodo()
    End Sub

    Public Sub LeerCancion()
        Me.CancioDAO.Leer(Me)
    End Sub

    Public Function InsertarCancion() As Integer
        Return Me.CancioDAO.Insertar(Me)
    End Function

    Public Function ActualizarCancion() As Integer
        Return Me.CancioDAO.Actualizar(Me)
    End Function

    Public Function BorrarCancion() As Integer
        Return Me.CancioDAO.Borrar(Me)
    End Function

    Public Overrides Function ToString() As String
        Return idCancion & ": " & NombreCancion & ", artist " & Album.ToString
    End Function

End Class
