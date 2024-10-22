Imports System.Collections.ObjectModel

Public Class AlbumDAO
    Public ReadOnly Property Album As Collection
    Public Sub New()
        Album = New Collection
    End Sub

    Public Sub LeerTodos()
        Dim a As Album
        Dim aux, col As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM albumes ORDER BY idAlbum")
        For Each aux In col
            a = New Album(CInt(aux(1).ToString))
            a.Nombre = aux(2).ToString
            a.Año = CInt(aux(3).ToString)
            a.Artista = New Artista(CInt(aux(4).ToString))
            Album.Add(a)
        Next
    End Sub
    Public Sub Leer(ByRef a As Album)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM albumes WHERE idAlbum='" & a.IDAlbum & "';")
        For Each aux In col
            a.Nombre = aux(2).ToString
            a.Año = CInt(aux(3).ToString)
            a.Artista = New Artista(CInt(aux(4).ToString))
        Next
    End Sub

    Public Sub Leer_Ranking(ByRef a As Artista)
        Dim col, aux As Collection
        Dim al As Album
        col = AgenteBD.ObtenerAgente().Leer("select al.NombreAlbum, count(*) as veces_interpretadas
        from setlist.setlists s
        join setlist.canciones c on c.idCancion = s.Canción
        join setlist.albumes al on al.idAlbum = c.Album
        join setlist.artistas a on a.IdArtista = al.Artista
        where a.Nombre = '" & a.Nombre & "'
        group by al.NombreAlbum
        order by veces_interpretadas;
        ")
        For Each aux In col
            al = New Album(aux(1).ToString)
            Leer2(al)
            Album.Add(al)
        Next
    End Sub

    Public Sub Leer2(ByRef a As Album)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM albumes WHERE NombreAlbum='" & a.Nombre & "';")
        For Each aux In col
            a.IDAlbum = CInt(aux(1).ToString)
            a.Año = CInt(aux(3).ToString)
            a.Artista = New Artista(CInt(aux(4).ToString))
        Next

    End Sub
    Public Function Insertar(ByVal a As Album) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO albumes VALUES ('" & a.IDAlbum & "', '" & a.Nombre & "', '" & a.Año & "', '" & a.Artista.IDArtista & "');")
    End Function
    Public Function Actualizar(ByVal a As Album) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE albumes Set NombreAlbum ='" & a.Nombre & "',AñoAlbum= '" & a.Año & "',Artista= '" & a.Artista.IDArtista & "' WHERE idAlbum='" & a.IDAlbum & "';")
    End Function
    Public Function Eliminar(ByRef a As Album) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM albumes WHERE idAlbum='" & a.IDAlbum & "';")
    End Function
End Class
