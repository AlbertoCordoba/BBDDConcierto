Public Class CancionDAO
    Public ReadOnly Property Canciones As Collection
    Public Sub New()
        Canciones = New Collection
    End Sub
    Public Sub LeerTodos()
        Dim c As Cancion
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM canciones ORDER BY idCancion")
        For Each aux In col
            c = New Cancion(CInt(aux(1).ToString))
            c.Nombre = aux(2).ToString
            c.Duracion = CInt(aux(3).ToString)
            c.Album = New Album(CInt(aux(4).ToString))
            c.Orden = CInt(aux(5).ToString)
            Canciones.Add(c)
        Next
    End Sub
    Public Sub LeerCancionesMasInterpretadas(ByRef a As Artista)
        Dim c As Cancion
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("select c.NombreCancion, count(*) as veces_interpretadas from setlist.setlists s join setlist.canciones c on c.idCancion = s.Canción
        join setlist.albumes al on al.idAlbum = c.Album
        join setlist.artistas a on a.IdArtista = al.Artista
        where a.Nombre = '" & a.Nombre & "'
        group by s.Canción
        order by veces_interpretadas")
        For Each aux In col
            c = New Cancion(aux(1).ToString)
            leer2(c)
            Canciones.Add(c)
        Next

    End Sub
    Public Sub Leer(ByRef c As Cancion)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM canciones WHERE idCancion='" & c.IDCancion & "';")
        For Each aux In col
            c.Nombre = aux(2).ToString
            c.Duracion = CInt(aux(3).ToString)
            c.Album = New Album(CInt(aux(4).ToString))
            c.Orden = CInt(aux(5).ToString)
        Next
    End Sub
    Public Sub leer2(ByRef c As Cancion)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM canciones WHERE NombreCancion='" & c.Nombre & "';")
        For Each aux In col
            c.IDCancion = CInt(aux(1).ToString)
            c.Duracion = CInt(aux(3).ToString)
            c.Album = New Album(CInt(aux(4).ToString))
            c.Orden = CInt(aux(5).ToString)
        Next
    End Sub
    Public Sub ranking()
        Dim col, aux As Collection
        Dim c As Cancion
        col = AgenteBD.ObtenerAgente.Leer("select c.idCancion ,c.NombreCancion as Nombre, c.Duración as duracion, c.Album as album, c.OrdenCanción as orden, count(*) as veces_interpretadas
        from setlist.canciones c
        join setlist.albumes al on c.Album = al.idAlbum
        join setlist.artistas a on a.IdArtista = al.Artista
        join setlist.setlists s on c.idCancion = s.Canción
        group by c.NombreCancion, c.Duración, c.Album, c.OrdenCanción, a.Nombre
        order by veces_interpretadas desc")
        For Each aux In col
            c = New Cancion(CInt(aux(1).ToString))
            c.Nombre = aux(2).ToString
            c.Duracion = CInt(aux(3).ToString)
            c.Album = New Album(CInt(aux(4).ToString))
            c.Orden = CInt(aux(5).ToString)
            Canciones.Add(c)
        Next
    End Sub

    Public Function Insertar(ByVal c As Cancion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO canciones VALUES ('" & c.IDCancion & "', '" & c.Nombre & "', '" & c.Duracion & "', '" & c.Album.IDAlbum & "', '" & c.Orden & "');")
    End Function
    Public Function Actualizar(ByVal c As Cancion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE canciones Set NombreCancion ='" & c.Nombre & "', Duración= '" & c.Duracion & "',Album= '" & c.Album.IDAlbum & "',OrdenCanción= '" & c.Orden & "' WHERE idCancion='" & c.IDCancion & "';")
    End Function
    Public Function Eliminar(ByVal c As Cancion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM canciones WHERE idCancion='" & c.IDCancion & "';")
    End Function
End Class
