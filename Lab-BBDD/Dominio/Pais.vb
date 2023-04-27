Public Class Pais
    Public Property idPais As String
    Public Property NombrePais As String
    Public ReadOnly Property PaiDAO As PaisDAO

    Public Sub New()
        Me.PaiDAO = New PaisDAO
    End Sub

    Public Sub New(id As String)
        Me.PaiDAO = New PaisDAO
        idPais = id
    End Sub

    Public Sub New(id As String, nombre As String)
        Me.PaiDAO = New PaisDAO
        idPais = id
        NombrePais = nombre
    End Sub

    Public Shared Function obtainID(pais As String) As String
        Return pais.Substring(0, 3).ToUpper
    End Function

    Public Sub LeerTodosPaises()
        Me.PaiDAO.LeerTodo()
    End Sub

    Public Sub LeerPais()
        Me.PaiDAO.Leer(Me)
    End Sub

    Public Function InsertarPais() As Integer
        Return Me.PaiDAO.Insertar(Me)
    End Function

    Public Function ActualizarPais() As Integer
        Return Me.PaiDAO.Actualizar(Me)
    End Function

    Public Function BorrarPais() As Integer
        Return Me.PaiDAO.Borrar(Me)
    End Function

    Public Sub LeerPaisesMasConciertos(fechaInicio As Date, fechaFin As Date)
        Me.PaiDAO.LeerPaisesMasConciertos(fechaInicio, fechaFin)
    End Sub

    Overrides Public Function ToString() As String
        Return NombrePais
    End Function

End Class
