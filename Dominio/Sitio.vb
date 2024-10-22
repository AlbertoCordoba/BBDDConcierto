Public Class Sitio
    Public Property IDSitio As Integer
    Public Property Nombre As String
    Public Property pais As Pais
    Public Property sitioDAO As SitioDAO

    Public Property Tipo As tipo2

    Public Enum tipo2
        sala
        pabellón
        estadio
        festival
    End Enum


    Public Sub New()
        sitioDAO = New SitioDAO()
    End Sub
    Public Sub New(id As Integer)
        Me.IDSitio = id
        sitioDAO = New SitioDAO()

    End Sub

    Public Sub New(nombre As String)
        Me.Nombre = nombre
        Me.sitioDAO = New SitioDAO
    End Sub

    Public Sub LeerTodosSitios()
        sitioDAO.LeerTodos()
    End Sub

    Public Sub LeerSitio()
        sitioDAO.Leer(Me)
    End Sub
    Public Sub LeerSitio_ConNombre()
        sitioDAO.Leer2(Me)
    End Sub
    Public Function InsertarSitio() As Integer
        Return sitioDAO.Insertar(Me)
    End Function

    Public Function ActualizarSitio() As Integer
        Return sitioDAO.Actualizar(Me)
    End Function

    Public Function EliminarSitio() As Integer
        Return sitioDAO.Eliminar(Me)
    End Function

End Class

