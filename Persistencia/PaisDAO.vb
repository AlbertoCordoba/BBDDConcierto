Public Class PaisDAO
    Public ReadOnly Property Pais As Collection

    Public Sub New()
        Me.Pais = New Collection
    End Sub

    Public Sub leerPaises()
        Dim p As Pais
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM paises ORDER BY idPais")
        For Each aux In col
            p = New Pais(aux(1).ToString)
            p.Nombre = aux(2).ToString
            Me.Pais.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Pais)
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM paises WHERE idPais='" & p.IDPais & "';")
        For Each aux In col
            p.Nombre = aux(2).ToString
        Next
    End Sub
    Public Sub Ranking(ByRef fechaInicio As Date, ByRef fechaFin As Date)
        Dim p As Pais
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("select p.idPais as sitio, count(*) as numero_conciertos
        from setlist.paises p
        join setlist.sitio s on p.idPais = s.País
        join setlist.conciertos con on s.idSitio = con.Sitio
        where con.FechaConcierto between '" & fechaInicio.ToString("yyyy-MM-dd") & "' and '" & fechaFin.ToString("yyyy-MM-dd") & "'
        group by p.idPais
        order by numero_conciertos desc")
        For Each aux In col
            p = New Pais(aux(1).ToString)
            Pais.Add(p)
        Next
    End Sub

    Public Function Insertar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO paises VALUES ('" & p.IDPais & "', '" & p.Nombre & "');")
    End Function

    Public Function Actualizar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE paises SET NombrePais='" & p.Nombre & "' WHERE idPais='" & p.IDPais & "';")
    End Function

    Public Function Borrar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM paises WHERE IDPais='" & p.IDPais & "';")
    End Function

End Class
