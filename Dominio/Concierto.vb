Public Class Concierto
    Public Property IDConcierto As Integer
    Public Property Artista As Artista
    Public Property sitio As Sitio
    Public Property fecha As Date
    Public Property conciertoDAO As ConciertoDAO
    Public Sub New()
        conciertoDAO = New ConciertoDAO
    End Sub
    Public Sub New(id As Integer)
        IDConcierto = id
        conciertoDAO = New ConciertoDAO

    End Sub
    Public Sub LeerTodosConciertos()
        conciertoDAO.LeerTodosConciertos()
    End Sub

    Public Sub LeerTodosSetlist()
        conciertoDAO.LeerTodosSetlist()
    End Sub
    Public Sub LeerConcierto()
        conciertoDAO.LeerConcierto(Me)
    End Sub
    Public Sub LeerSetlist(ByRef s As setlist)
        conciertoDAO.LeerSetlist(s)
    End Sub

    Public Sub LeerSetlist_Cancion(ByRef s As setlist)
        conciertoDAO.LeerSetlist2(s)
    End Sub
    Public Function InsertarConcierto() As Integer
        Return conciertoDAO.InsertarConcierto(Me)
    End Function
    Public Function InsertarSetlist(ByVal s As setlist) As Integer
        Return conciertoDAO.InsertarSetlist(s)
    End Function
    Public Function ActualizarConcierto() As Integer
        Return conciertoDAO.ActualizarConcierto(Me)
    End Function
    Public Function ActualizarSetlist(ByVal s As setlist) As Integer
        Return conciertoDAO.ActualizarSetlist(s)
    End Function
    Public Function EliminarConcierto() As Integer
        Return conciertoDAO.EliminarConcierto(Me)
    End Function
    Public Function EliminarSetlist(ByVal s As setlist) As Integer
        Return conciertoDAO.EliminarSetlist(s)
    End Function

End Class
