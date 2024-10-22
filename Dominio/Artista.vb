Public Class Artista
    Public Property IDArtista As Integer
    Public Property Nombre As String
    Public Property Pais As Pais
    Public Property ArtistaDAO As artistaDAO

    Public Sub New()
        Me.ArtistaDAO = New artistaDAO()
    End Sub

    Public Sub New(id As Integer)
        Me.IDArtista = id
        Me.ArtistaDAO = New artistaDAO
    End Sub

    Public Sub New(nombre As String)
        Me.Nombre = nombre
        Me.ArtistaDAO = New artistaDAO
    End Sub

    Public Sub LeerTodosArtistas()
        ArtistaDAO.leerArtistas()
    End Sub

    Public Sub LeerArtista()
        ArtistaDAO.leer(Me)
    End Sub
    Public Sub LeerArtistas_ConNombre()
        ArtistaDAO.leer2(Me)
    End Sub
    Public Sub ranking(ByRef fechaInicio As Date, ByRef fechaFin As Date)
        ArtistaDAO.ranking(fechaInicio, fechaFin)
    End Sub

    Public Function InsertarArtista() As Integer
        Return Me.ArtistaDAO.Insertar(Me)
    End Function

    Public Function ActualizarArtista() As Integer
        Return Me.ArtistaDAO.Actualizar(Me)
    End Function

    Public Function BorrarArtista() As Integer
        Return Me.ArtistaDAO.Borrar(Me)
    End Function

End Class
