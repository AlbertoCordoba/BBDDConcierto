Public Class Cancion
    Public Property IDCancion As Integer
    Public Property Nombre As String
    Public Property Duracion As Integer
    Public Property Album As Album
    Public Property Orden As Integer
    Public Property CancionDAO As CancionDAO

    Public Sub New()
        CancionDAO = New CancionDAO
    End Sub
    Public Sub New(id As Integer)
        Me.IDCancion = id
        CancionDAO = New CancionDAO
    End Sub

    Public Sub New(nombre As String)
        Me.Nombre = nombre
        CancionDAO = New CancionDAO
    End Sub
    Public Sub LeerTodasCanciones()
        CancionDAO.LeerTodos()
    End Sub
    Public Sub Leer()
        CancionDAO.Leer(Me)
    End Sub
    Public Sub Leer_conNombre()
        CancionDAO.leer2(Me)
    End Sub

    Public Sub Leer_Ranking(ByRef a As Artista)
        CancionDAO.LeerCancionesMasInterpretadas(a)
    End Sub
    Public Sub Leer_Ranking_2()
        CancionDAO.ranking()
    End Sub

    Public Function Insertar() As Integer
        Return CancionDAO.Insertar(Me)
    End Function
    Public Function Actualizar() As Integer
        Return CancionDAO.Actualizar(Me)
    End Function
    Public Function Eliminar() As Integer
        Return CancionDAO.Eliminar(Me)
    End Function
End Class
