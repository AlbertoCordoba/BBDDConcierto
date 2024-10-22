Imports System.Runtime.InteropServices
Imports Practica3.Sitio

Public Class SitioDAO
    Public ReadOnly Property Sitio As Collection

    Public Sub New()
        Me.Sitio = New Collection
    End Sub

    Public Sub LeerTodos()
        Dim s As Sitio
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM sitio ORDER BY idSitio")
        For Each aux In col
            s = New Sitio(CInt(aux(1).ToString))
            s.Nombre = aux(2).ToString
            s.pais = New Pais(aux(3).ToString)
            s.Tipo = CType([Enum].Parse(GetType(tipo2), aux(4).ToString), tipo2)
            Me.Sitio.Add(s)
        Next
    End Sub

    Public Sub Leer(ByRef s As Sitio)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM sitio WHERE idSitio='" & s.IDSitio & "';")
        For Each aux In col
            s.Nombre = aux(2).ToString
            s.pais = New Pais(aux(3).ToString)
            s.Tipo = CType([Enum].Parse(GetType(tipo2), aux(4).ToString), tipo2)
        Next
    End Sub
    Public Sub Leer2(ByRef s As Sitio)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM sitio WHERE NombreSitio='" & s.Nombre & "';")
        For Each aux In col
            s.IDSitio = CInt(aux(1).ToString)
            s.pais = New Pais(aux(3).ToString)
            s.Tipo = CType([Enum].Parse(GetType(tipo2), aux(4).ToString), tipo2)
        Next
    End Sub
    Public Function Insertar(ByVal s As Sitio) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO sitio VALUES ('" & s.IDSitio & "', '" & s.Nombre & "', '" & s.pais.IDPais & "', '" & [Enum].GetName(GetType(tipo2), s.Tipo) & "');")
    End Function

    Public Function Actualizar(ByVal s As Sitio) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE sitio Set NombreSitio ='" & s.Nombre & "', País='" & s.pais.IDPais & "', Tipo = '" & [Enum].GetName(GetType(tipo2), s.Tipo) & "' WHERE idSitio='" & s.IDSitio & "';")
    End Function
    Public Function Eliminar(ByVal s As Sitio) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM sitio WHERE idSitio='" & s.IDSitio & "';")
    End Function

End Class
