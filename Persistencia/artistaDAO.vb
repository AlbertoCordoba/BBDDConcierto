Public Class artistaDAO
    Public ReadOnly Property Artista As Collection

    Public Sub New()
        Me.Artista = New Collection
    End Sub

    Public Sub leerArtistas()
        Dim a As Artista
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM artistas ORDER BY IDArtista")
        For Each aux In col
            a = New Artista(CInt(aux(1).ToString()))
            a.Nombre = aux(2).ToString
            a.Pais = New Pais(aux(3).ToString)
            Me.Artista.Add(a)
        Next
    End Sub

    Public Sub leer(ByRef a As Artista)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM artistas WHERE IDArtista='" & a.IDArtista & "';")
        For Each aux In col
            a.Nombre = aux(2).ToString
            a.Pais = New Pais(aux(3).ToString)
        Next
    End Sub

    Public Sub leer2(ByRef a As Artista)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM artistas WHERE Nombre='" & a.Nombre & "';")
        For Each aux In col
            a.IDArtista = CInt(aux(1).ToString)
            a.Pais = New Pais(aux(3).ToString)
        Next
    End Sub

    Public Sub ranking(ByRef fechaInicio As Date, ByRef fechaFin As Date)
        Dim col As Collection
        Dim aux As Collection
        Dim a As Artista
        col = AgenteBD.ObtenerAgente.Leer("select a.Nombre as artista, con.FechaConcierto as fecha
        from setlist.artistas a
        join setlist.conciertos con on a.IdArtista = con.Artista
        where con.FechaConcierto between '" & fechaInicio.ToString("yyyy-MM-dd") & "' and '" & fechaFin.ToString("yyyy-MM-dd") & "'
        group by a.Nombre,con.FechaConcierto
        order by fecha asc")
        For Each aux In col
            a = New Artista(aux(1).ToString)
            Artista.Add(a)
        Next

    End Sub

    Public Function Insertar(ByVal a As Artista) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO artistas (Nombre, País) VALUES ('" & a.Nombre & "', '" & a.Pais.IDPais & "');")
    End Function

    Public Function Actualizar(ByVal a As Artista) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE artistas Set Nombre='" & a.Nombre & "', País= '" & a.Pais.IDPais & "' WHERE IDArtista='" & a.IDArtista & "';")
    End Function

    Public Function Borrar(ByVal a As Artista) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM artistas WHERE IdArtista='" & a.IDArtista & "';")
    End Function
End Class
