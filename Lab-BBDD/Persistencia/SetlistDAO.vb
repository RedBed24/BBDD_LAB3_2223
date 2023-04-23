Public Class SetlistDAO

    Public Sub Leer(concierto As Concierto)
        Dim canciones As New List(Of Cancion)
        Dim tabla As Collection
        Dim tempcancion As Cancion

        tabla = AgenteBD.ObtenerAgente().Leer("select * from setlists where Concierto='" & concierto.idConcierto & "' order by OrdenSetlist;")

        For Each tupla As Collection In tabla
            tempcancion = New Cancion(tupla(2).ToString)
            tempcancion.LeerCancion()

            canciones.Insert(Integer.Parse(tupla(3)), tempcancion)
        Next

        concierto.SetList = canciones
    End Sub

    Public Function Insertar(concierto As Concierto) As Integer
        Dim SQL As String = "insert into setlists values "

        ' Por cada canción, excepto la última (para que no ponga una , al final)
        For i As Integer = 1 To concierto.SetList.Count - 1
            Dim cancion As Cancion = concierto.SetList.ElementAt(i)
            ' añadimos la tupla de esta setlist a la sentencia de insert con el orden que le corresponde
            SQL += "('" & concierto.idConcierto & "', '" & cancion.idCancion & "', " & i & "), "
        Next

        ' Debe devolver concierto.SetList.Count
        Return AgenteBD.ObtenerAgente().Modificar(SQL & "('" & concierto.idConcierto & "', '" & concierto.SetList.ElementAt(concierto.SetList.Count).idCancion & "', '" & concierto.SetList.Count & "');")
    End Function

    ' Para actualizar la setlist del concierto es mucho más fácil borrar la setlist y añadirla de nuevo para no tener que ir canción a canción
    '    Public Function Actualizar(concierto As Concierto) As Integer
    '    Return AgenteBD.ObtenerAgente().Modificar("update setlists set OrdenSetlist='" & orden & "' where (Concierto='" & concierto.idConcierto & "' and Canción='" & Cancion.idCancion & "');")
    '    End Function
    '
    '    Public Function Borrar(concierto As Concierto, cancion As Cancion) As Integer
    '    Return AgenteBD.ObtenerAgente().Modificar("delete from setlists where (Concierto='" & concierto.idConcierto & "' and Canción= '" & cancion.idCancion & "');")
    '    End Function

    Public Function Borrar(concierto As Concierto) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("delete from setlists where Concierto='" & concierto.idConcierto & "';")
    End Function

End Class
