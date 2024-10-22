Public Class Album
    Public Property IDAlbum As Integer
    Public Property Nombre As String
    Public Property Año As Integer
    Public Property Artista As Artista
    Public Property AlbumDAO As AlbumDAO

    Public Sub New()
        AlbumDAO = New AlbumDAO
    End Sub
    Public Sub New(id As Integer)
        IDAlbum = id
        AlbumDAO = New AlbumDAO
    End Sub
    Public Sub New(nombre As String)
        Me.Nombre = nombre
        AlbumDAO = New AlbumDAO
    End Sub
    Public Sub LeerTodosAlbum()
        AlbumDAO.LeerTodos()
    End Sub
    Public Sub LeerAlbum()
        AlbumDAO.Leer(Me)
    End Sub
    Public Sub LeerAlbum_conNombre()
        AlbumDAO.Leer2(Me)
    End Sub
    Public Sub Leer_Album_Ranking(ByRef a As Artista)
        AlbumDAO.Leer_Ranking(a)
    End Sub
    Public Function InsertarAlbum() As Integer
        Return AlbumDAO.Insertar(Me)
    End Function
    Public Function ActualizarAlbum() As Integer
        Return AlbumDAO.Actualizar(Me)
    End Function
    Public Function EliminarAlbum() As Integer
        Return AlbumDAO.Eliminar(Me)
    End Function
End Class
