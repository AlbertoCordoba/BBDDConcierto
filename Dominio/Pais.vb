Imports System.Net.Http.Headers

Public Class Pais
    Public Property IDPais As String
    Public Property Nombre As String
    Public ReadOnly Property PaisDAO As PaisDAO


    Public Sub New()
        PaisDAO = New PaisDAO
    End Sub

    Public Sub New(id As String)
        Me.IDPais = id
        Me.PaisDAO = New PaisDAO
    End Sub

    Public Sub LeerTodosPaises()
        Me.PaisDAO.leerPaises()
    End Sub

    Public Sub LeerPais()
        Me.PaisDAO.Leer(Me)
    End Sub
    Public Sub Ranking(ByRef fechaInicio As Date, ByRef fechaFin As Date)
        Me.PaisDAO.Ranking(fechaInicio, fechaFin)
    End Sub

    Public Function InsertarPais() As Integer
        Return Me.PaisDAO.Insertar(Me)
    End Function

    Public Function ActualizarPais() As Integer
        Return Me.PaisDAO.Actualizar(Me)
    End Function

    Public Function EliminarPais() As Integer
        Return Me.PaisDAO.Borrar(Me)
    End Function





End Class
