Public Class Conectar

    Private a As Album
    Private ar As Artista
    Private c As Cancion
    Private s As Sitio
    Private p As Pais
    Private con As Concierto

    Private Sub Conectar_Click(sender As Object, e As EventArgs) Handles Boton_Conectar.Click
        Me.a = New Album
        Me.ar = New Artista
        Me.c = New Cancion
        Me.s = New Sitio
        Me.p = New Pais
        Me.con = New Concierto
        Dim Pa As Album
        Dim Par As Artista
        Dim Pc As Cancion
        Dim ps As Sitio
        Dim pp As Pais
        Dim Pcon As Concierto
        Dim pset As setlist
        Try
            Me.a.LeerTodosAlbum()
            Me.ar.LeerTodosArtistas()
            Me.c.LeerTodasCanciones()
            Me.s.LeerTodosSitios()
            Me.p.LeerTodosPaises()
            Me.con.LeerTodosConciertos()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
        End Try

        For Each Pa In Me.a.AlbumDAO.Album
            frmCanciones.ListAlbum.Items.Add(Pa.IDAlbum)
        Next
        For Each Par In Me.ar.ArtistaDAO.Artista
            frmCanciones.ListArtistas.Items.Add(Par.IDArtista)
        Next
        For Each Pc In Me.c.CancionDAO.Canciones
            frmCanciones.ListCanciones.Items.Add(Pc.IDCancion)
        Next
        For Each ps In Me.s.sitioDAO.Sitio
            frmCanciones.ListSitios.Items.Add(ps.IDSitio)
        Next
        For Each pp In Me.p.PaisDAO.Pais
            frmCanciones.ListPaises.Items.Add(pp.IDPais)
        Next
        For Each Pcon In Me.con.conciertoDAO.Conciertos
            frmCanciones.ListConcierto.Items.Add(Pcon.IDConcierto)
        Next

        Me.Hide()
        frmCanciones.Show()
    End Sub


End Class