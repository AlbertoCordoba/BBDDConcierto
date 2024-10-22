Imports System.Security.Authentication

Public Class ConciertoDAO
    Public ReadOnly Property Conciertos As Collection
    Public ReadOnly Property Setlist As Collection
    Public Sub New()
        Conciertos = New Collection
        Setlist = New Collection
    End Sub
    Public Sub LeerTodosConciertos()
        Dim col, aux As Collection
        Dim c As Concierto
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM conciertos ORDER BY idConcierto")
        For Each aux In col
            c = New Concierto(CInt(aux(1).ToString))
            c.Artista = New Artista(CInt(aux(2).ToString))
            c.sitio = New Sitio(CInt(aux(3).ToString))
            c.fecha = CDate(aux(4).ToString)
            Conciertos.Add(c)
        Next
    End Sub
    Public Sub LeerTodosSetlist()
        Dim col, aux As Collection
        Dim st As setlist
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM setlists ORDER BY Concierto")
        For Each aux In col
            st = New setlist
            st.concierto = New Concierto(CInt(aux(1).ToString))
            st.Cancion = New Cancion(CInt(aux(2).ToString))
            st.ordenSetlist = CInt(aux(3).ToString)
            Setlist.Add(st)
        Next
    End Sub
    Public Sub LeerConcierto(ByRef c As Concierto)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM conciertos WHERE idConcierto='" & c.IDConcierto & "';")
        For Each aux In col
            c.Artista = New Artista(CInt(aux(2).ToString))
            c.sitio = New Sitio(CInt(aux(3).ToString))
            c.fecha = CDate(aux(4).ToString)
        Next
    End Sub

    Public Sub LeerSetlist(ByRef s As setlist)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM setlists WHERE Concierto='" & s.concierto.IDConcierto & "';")
        For Each aux In col
            s.concierto = New Concierto(CInt(aux(1).ToString))
            s.Cancion = New Cancion(CInt(aux(2).ToString))
            s.ordenSetlist = CInt(aux(3).ToString)
        Next
    End Sub

    Public Sub LeerSetlist2(ByRef s As setlist)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM setlists WHERE Canción='" & s.Cancion.IDCancion & "';")
        For Each aux In col
            s.concierto = New Concierto(CInt(aux(1).ToString))
            s.Cancion = New Cancion(CInt(aux(2).ToString))
            s.ordenSetlist = CInt(aux(3).ToString)
        Next
    End Sub
    Public Function InsertarConcierto(ByVal c As Concierto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO conciertos VALUES ('" & c.IDConcierto & "', '" & c.Artista.IDArtista & "', '" & c.sitio.IDSitio & "', '" & c.fecha.ToString("yyyy-MM-dd") & "');")
    End Function
    Public Function InsertarSetlist(ByVal s As setlist) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO setlists VALUES ('" & s.concierto.IDConcierto & "', '" & s.Cancion.IDCancion & "', '" & s.ordenSetlist & "' );")
    End Function
    Public Function ActualizarConcierto(ByVal c As Concierto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE conciertos Set Artista='" & c.Artista.IDArtista & "', Sitio='" & c.sitio.IDSitio & "',FechaConcierto= '" & c.fecha.ToString("yyyy-MM-dd") & "' WHERE idConcierto='" & c.IDConcierto & "';")
    End Function
    Public Function ActualizarSetlist(ByVal s As setlist) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE setlists Set Canción='" & s.Cancion.IDCancion & "', OrdenSetlist='" & s.ordenSetlist & "' WHERE Concierto='" & s.concierto.IDConcierto & "';")
    End Function
    Public Function EliminarConcierto(ByVal c As Concierto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM conciertos WHERE idConcierto='" & c.IDConcierto & "';")
    End Function
    Public Function EliminarSetlist(ByVal s As setlist) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM setlists WHERE Concierto='" & s.concierto.IDConcierto & "' and Canción = '" & s.Cancion.IDCancion & "';")
    End Function
End Class
