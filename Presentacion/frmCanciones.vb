Imports System.Runtime.ExceptionServices
Imports Practica3.Sitio
Public Class frmCanciones
    Private a As Artista
    Private p As Pais
    Private al As Album
    Private c As Cancion
    Private s As Sitio
    Private con As Concierto
    Private se As setlist
    Private Sub ListArtistas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListArtistas.SelectedIndexChanged
        If Not Me.ListArtistas.SelectedItem Is Nothing Then
            Me.a = New Artista(CInt(Me.ListArtistas.SelectedItem.ToString))
            Try
                Me.a.LeerArtista()
            Catch ex As Exception
                MessageBox.Show(ex.Source, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.TextID_Artista.Text = a.IDArtista.ToString
            Me.TextNombre_artista.Text = a.Nombre
            Me.ComboPais_artista.Text = a.Pais.IDPais
            'leemos sus canciones mas interpretadas'
            Me.c = New Cancion
            c.Leer_Ranking(a)
            Dim can As Cancion
            Me.List_rank_canciones.Items.Clear()
            For Each can In c.CancionDAO.Canciones
                Me.List_rank_canciones.Items.Add(can.IDCancion)
            Next
            'leemos sus albumes mas interpretados'
            Me.al = New Album
            al.Leer_Album_Ranking(a)
            Dim pal As Album
            Me.List_Rank_Album.Items.Clear()
            For Each pal In al.AlbumDAO.Album
                Me.List_Rank_Album.Items.Add(pal.IDAlbum)
            Next
        End If
    End Sub

    Private Sub ListPaises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListPaises.SelectedIndexChanged
        If Not Me.ListPaises.SelectedItem Is Nothing Then
            Me.p = New Pais(Me.ListPaises.SelectedItem.ToString)
            Try
                Me.p.LeerPais()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.TextId_Pais.Text = p.IDPais
            Me.TextPais.Text = p.Nombre
        End If
    End Sub

    Private Sub ListAlbum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListAlbum.SelectedIndexChanged
        If Not Me.ListAlbum.SelectedItem Is Nothing Then
            Me.al = New Album(CInt(Me.ListAlbum.SelectedItem.ToString))
            Try
                Me.al.LeerAlbum()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            a = New Artista
            a.IDArtista = al.Artista.IDArtista
            a.LeerArtista()
            Me.id_album_text.Text = al.IDAlbum.ToString
            Me.artista_album_text.Text = a.Nombre
            Me.año_album_text.Text = al.Año.ToString
            Me.nombre_album_text.Text = al.Nombre
        End If
    End Sub
    Private Sub ListCanciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListCanciones.SelectedIndexChanged
        If Not Me.ListCanciones.SelectedItem Is Nothing Then
            Me.c = New Cancion(CInt(Me.ListCanciones.SelectedItem.ToString))
            Try
                Me.c.Leer()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            al = New Album
            al.IDAlbum = c.Album.IDAlbum
            al.LeerAlbum()
            Me.duracion_cancion_text.Text = c.Duracion.ToString
            Me.id_cancion_text.Text = c.IDCancion.ToString
            Me.nombre_cancion_text.Text = c.Nombre
            Me.orden_cancion_text.Text = c.Orden.ToString
            Me.album_cancion_text.Text = al.Nombre
        End If
    End Sub
    Private Sub ListSitios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListSitios.SelectedIndexChanged
        If Not Me.ListSitios.SelectedItem Is Nothing Then
            Me.s = New Sitio(CInt(Me.ListSitios.SelectedItem.ToString))
            Try
                Me.s.LeerSitio()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.id_sitio_text.Text = s.IDSitio.ToString
            Me.nombre_sitio_text.Text = s.Nombre
            Me.ComboPais_Sitio.Text = s.pais.IDPais.ToString
            Me.ComboTipo_Sitio.Text = [Enum].GetName(GetType(tipo2), s.Tipo)
        End If
    End Sub
    Private Sub ListConcierto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListConcierto.SelectedIndexChanged
        If Not Me.ListConcierto.SelectedItem Is Nothing Then
            Me.con = New Concierto(CInt(Me.ListConcierto.SelectedItem.ToString))
            Try
                Me.con.LeerConcierto()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.a = New Artista
            Me.s = New Sitio
            a.IDArtista = con.Artista.IDArtista
            s.IDSitio = con.sitio.IDSitio
            s.LeerSitio()
            a.LeerArtista()
            Me.Text_artista_concierto.Text = a.Nombre
            Me.Text_id_concierto.Text = con.IDConcierto.ToString
            Me.Text_sitio_concierto.Text = s.Nombre
            Me.DateTimePicker_concierto.Text = con.fecha.ToString

            Me.se = New setlist
            Me.con.LeerTodosSetlist()
            Dim ps As setlist
            Me.ListSetlist.Items.Clear()
            For Each ps In Me.con.conciertoDAO.Setlist
                If ps.concierto.IDConcierto = Me.con.IDConcierto Then
                    Me.ListSetlist.Items.Add(ps.Cancion.IDCancion)
                End If
            Next

        End If
    End Sub
    Private Sub ListSetlist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListSetlist.SelectedIndexChanged
        Me.con = New Concierto
        If Not Me.ListSetlist.SelectedItem Is Nothing Then
            Me.se = New setlist(CInt(ListSetlist.SelectedItem.ToString))
            Try
                Me.con.LeerSetlist_Cancion(se)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.con.IDConcierto = se.concierto.IDConcierto
            Me.c = New Cancion
            Me.c.IDCancion = se.Cancion.IDCancion
            Me.con.LeerConcierto()
            Me.c.Leer()
            Me.text_orden_setlist.Text = se.ordenSetlist.ToString
            Me.TextCancion_Setlist.Text = Me.c.Nombre
            Me.TextConcierto_setlist.Text = Me.con.IDConcierto.ToString
        End If
    End Sub
    Private Sub Limpiar_Artista_Boton_Click(sender As Object, e As EventArgs) Handles Limpiar_Artista_Boton.Click
        Me.TextID_Artista.Text = String.Empty
        Me.TextNombre_artista.Text = String.Empty
        Me.ComboPais_artista.Text = String.Empty
    End Sub

    Private Sub Limpiar_Pais_Boton_Click(sender As Object, e As EventArgs) Handles Limpiar_Pais_Boton.Click
        Me.TextId_Pais.Text = String.Empty
        Me.TextPais.Text = String.Empty
    End Sub

    Private Sub Limpiar_Album_Boton_Click(sender As Object, e As EventArgs) Handles Limpiar_Album_Boton.Click
        Me.artista_album_text.Text = String.Empty
        Me.año_album_text.Text = String.Empty
        Me.id_album_text.Text = String.Empty
        Me.nombre_album_text.Text = String.Empty
    End Sub

    Private Sub Limpiar_Cancion_Boton_Click(sender As Object, e As EventArgs) Handles Limpiar_Cancion_Boton.Click
        Me.album_cancion_text.Text = String.Empty
        Me.duracion_cancion_text.Text = String.Empty
        Me.id_cancion_text.Text = String.Empty
        Me.orden_cancion_text.Text = String.Empty
        Me.nombre_cancion_text.Text = String.Empty
    End Sub

    Private Sub Limpiar_Sitio_Boton_Click(sender As Object, e As EventArgs) Handles Limpiar_Sitio_Boton.Click
        Me.ComboPais_Sitio.Text = String.Empty
        Me.id_sitio_text.Text = String.Empty
        Me.ComboTipo_Sitio.Text = String.Empty
        Me.nombre_sitio_text.Text = String.Empty
    End Sub

    Private Sub frmCanciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.p = New Pais
        Me.s = New Sitio
        Me.a = New Artista
        Me.p.LeerTodosPaises()
        Me.s.LeerTodosSitios()
        Me.a.LeerTodosArtistas()
        Dim ps As Sitio
        Dim pa As Artista
        Dim pp As Pais
        For Each pp In p.PaisDAO.Pais
            ComboPais_artista.Items.Add(pp.IDPais)
            ComboPais_Sitio.Items.Add(pp.IDPais)
        Next
        ComboTipo_Sitio.DataSource = System.Enum.GetValues(GetType(Sitio.tipo2))
        For Each ps In Me.s.sitioDAO.Sitio
            Me.ComboFiltrar_Sitio.Items.Add(ps.Nombre)
        Next
        For Each pa In Me.a.ArtistaDAO.Artista
            Me.ComboFiltrar_Artista.Items.Add(pa.Nombre)
        Next

    End Sub

    Private Sub Button_Limpiar_Concierto_Click(sender As Object, e As EventArgs) Handles Button_Limpiar_Concierto.Click
        Me.Text_artista_concierto.Text = String.Empty
        Me.Text_id_concierto.Text = String.Empty
        Me.Text_sitio_concierto.Text = String.Empty
        Me.DateTimePicker_concierto.Text = String.Empty
    End Sub

    Private Sub Añadir_Boton_Pais_Click(sender As Object, e As EventArgs) Handles Añadir_Boton_Pais.Click
        If Me.TextPais.Text <> String.Empty Then
            p = New Pais
            p.Nombre = Me.TextPais.Text
            p.IDPais = UCase(Mid(Me.TextPais.Text, 1, 3))
            Try
                If p.InsertarPais() <> 1 Then
                    MessageBox.Show("Insert return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.ListPaises.Items.Add(p.IDPais)
            Me.ComboPais_artista.Items.Add(p.IDPais)
            Me.ComboPais_Sitio.Items.Add(p.IDPais)
        End If
    End Sub

    Private Sub Añadir_Boton_Click(sender As Object, e As EventArgs) Handles Añadir_Boton.Click
        If Me.TextNombre_artista.Text <> String.Empty And Me.ComboPais_artista.Text <> String.Empty Then
            a = New Artista
            a.Nombre = Me.TextNombre_artista.Text
            a.Pais = New Pais(Me.ComboPais_artista.Text)
            Try
                If a.InsertarArtista() <> 1 Then
                    MessageBox.Show("INSERT return <> 1,", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.ListArtistas.Items.Clear()
            Me.a = New Artista
            Dim pa As Artista
            a.LeerTodosArtistas()
            For Each pa In a.ArtistaDAO.Artista
                Me.ListArtistas.Items.Add(pa.IDArtista)
            Next
        End If
    End Sub

    Private Sub Añadir_Cancion_Boton_Click(sender As Object, e As EventArgs) Handles Añadir_Cancion_Boton.Click
        If Me.album_cancion_text.Text <> String.Empty And Me.duracion_cancion_text.Text <> String.Empty And Me.orden_cancion_text.Text <> String.Empty Then
            al = New Album(album_cancion_text.Text)
            al.LeerAlbum_conNombre()
            c = New Cancion
            c.Nombre = Me.nombre_cancion_text.Text
            c.Album = New Album(al.IDAlbum)
            c.Duracion = CInt(Me.duracion_cancion_text.Text)
            c.Orden = CInt(Me.orden_cancion_text.Text)
            Try
                If c.Insertar() <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.ListCanciones.Items.Clear()
            Me.c = New Cancion
            c.LeerTodasCanciones()
            Dim pc As Cancion
            For Each pc In c.CancionDAO.Canciones
                Me.ListCanciones.Items.Add(pc.IDCancion)
            Next
        End If
    End Sub
    Private Sub Añadir_Album_Boton_Click(sender As Object, e As EventArgs) Handles Añadir_Album_Boton.Click
        If Me.artista_album_text.Text <> String.Empty And Me.año_album_text.Text <> String.Empty And Me.nombre_album_text.Text <> String.Empty Then
            Me.a = New Artista(Me.artista_album_text.Text)
            a.LeerArtistas_ConNombre()
            Me.al = New Album
            al.Artista = New Artista(a.IDArtista)
            al.Nombre = Me.nombre_album_text.Text
            al.Año = CInt(Me.año_album_text.Text)
            Try
                If al.InsertarAlbum() <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.al = New Album
            Dim pal As Album
            Me.ListAlbum.Items.Clear()
            al.LeerTodosAlbum()
            For Each pal In al.AlbumDAO.Album
                Me.ListAlbum.Items.Add(pal.IDAlbum)
            Next
        End If
    End Sub
    Private Sub Añadir_Sitio_Boton_Click(sender As Object, e As EventArgs) Handles Añadir_Sitio_Boton.Click
        If Me.nombre_sitio_text.Text <> String.Empty And Me.ComboTipo_Sitio.Text <> String.Empty And Me.ComboPais_Sitio.Text <> String.Empty Then
            Me.s = New Sitio
            Me.s.Nombre = Me.nombre_sitio_text.Text
            Me.s.pais = New Pais(Me.ComboPais_Sitio.Text)
            Me.s.Tipo = CType([Enum].Parse(GetType(tipo2), Me.ComboTipo_Sitio.Text), tipo2)
            Try
                If s.InsertarSitio() <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.s = New Sitio
            Dim ps As Sitio
            s.LeerTodosSitios()
            Me.ListSitios.Items.Clear()
            For Each ps In s.sitioDAO.Sitio
                Me.ListSitios.Items.Add(ps.IDSitio)
            Next
        End If
    End Sub
    Private Sub Button_Añadir_Concierto_Click(sender As Object, e As EventArgs) Handles Button_Añadir_Concierto.Click
        If Me.Text_artista_concierto.Text <> String.Empty And Me.Text_sitio_concierto.Text <> String.Empty And Me.DateTimePicker_concierto.Text <> String.Empty Then
            Me.a = New Artista(Me.Text_artista_concierto.Text)
            Me.a.LeerArtistas_ConNombre()
            Me.s = New Sitio(Me.Text_sitio_concierto.Text)
            Me.s.LeerSitio_ConNombre()
            Me.con = New Concierto
            con.Artista = New Artista(Me.a.IDArtista)
            con.sitio = New Sitio(Me.s.IDSitio)
            con.fecha = CDate(DateTimePicker_concierto.Text)
            Try
                If con.InsertarConcierto() <> 1 Then
                    MessageBox.Show("INSERT return <> 1 ", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.con = New Concierto
            con.LeerTodosConciertos()
            Dim pcon As Concierto
            Me.ListConcierto.Items.Clear()
            For Each pcon In con.conciertoDAO.Conciertos
                Me.ListConcierto.Items.Add(pcon.IDConcierto)
            Next
        End If
    End Sub
    Private Sub Button_Añadir_Setlist_Click(sender As Object, e As EventArgs) Handles Button_Añadir_Setlist.Click
        Me.con = New Concierto
        If Me.text_orden_setlist.Text <> String.Empty And Me.TextCancion_Setlist.Text <> String.Empty And Me.TextConcierto_setlist.Text <> String.Empty Then
            Me.se = New setlist
            Me.c = New Cancion(Me.TextCancion_Setlist.Text)
            Me.c.Leer_conNombre()
            Me.se.concierto = New Concierto(CInt(Me.TextConcierto_setlist.Text))
            Me.se.ordenSetlist = CInt(Me.text_orden_setlist.Text)
            Me.se.Cancion = New Cancion(Me.c.IDCancion)
            Try
                If Me.con.InsertarSetlist(Me.se) <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.ListSetlist.Items.Add(Me.se.Cancion.IDCancion)
        End If
    End Sub
    Private Sub Actualizar_Boton_Pais_Click(sender As Object, e As EventArgs) Handles Actualizar_Boton_Pais.Click
        If Not Me.p Is Nothing Then
            Me.p.Nombre = Me.TextPais.Text
            Try
                If Me.p.ActualizarPais() <> 1 Then
                    MessageBox.Show("UPDATE returns <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            MessageBox.Show("Actualizado correctamente ")
        End If
    End Sub
    Private Sub Actualizar_Boton_Click(sender As Object, e As EventArgs) Handles Actualizar_Boton.Click
        If Not Me.a Is Nothing Then
            Me.a.Nombre = Me.TextNombre_artista.Text
            Me.a.Pais = New Pais(Me.ComboPais_artista.Text)
            Try
                If Me.a.ActualizarArtista() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            MessageBox.Show("Actualizado correctamente")
        End If
    End Sub
    Private Sub Actualizar_Album_Boton_Click(sender As Object, e As EventArgs) Handles Actualizar_Album_Boton.Click
        If Not Me.al Is Nothing Then
            Dim pa As Artista
            pa = New Artista(Me.artista_album_text.Text)
            pa.LeerArtistas_ConNombre()
            Me.al.Año = CInt(Me.año_album_text.Text)
            Me.al.Artista = New Artista(pa.IDArtista)
            Me.al.Nombre = Me.nombre_album_text.Text
            Try
                If Me.al.ActualizarAlbum() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1 ", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            MessageBox.Show("Actualizado correctamente")
        End If
    End Sub
    Private Sub Actualizar_Cancion_Boton_Click(sender As Object, e As EventArgs) Handles Actualizar_Cancion_Boton.Click
        If Not Me.c Is Nothing Then
            Dim pal As Album
            pal = New Album(Me.album_cancion_text.Text)
            pal.LeerAlbum_conNombre()
            Me.c.Album = New Album(pal.IDAlbum)
            Me.c.Duracion = CInt(Me.duracion_cancion_text.Text)
            Me.c.Nombre = Me.nombre_cancion_text.Text
            Me.c.Orden = CInt(Me.orden_cancion_text.Text)
            Try
                If c.Actualizar() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            MessageBox.Show("Actualizado correctamente")
        End If
    End Sub

    Private Sub Actualizar_Sitio_Boton_Click(sender As Object, e As EventArgs) Handles Actualizar_Sitio_Boton.Click
        If Not Me.s Is Nothing Then
            Me.s.pais = New Pais(Me.ComboPais_Sitio.Text)
            Me.s.Nombre = Me.nombre_sitio_text.Text
            Me.s.Tipo = CType([Enum].Parse(GetType(tipo2), Me.ComboTipo_Sitio.Text), tipo2)
            Try
                If s.ActualizarSitio() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            MessageBox.Show("Actualizado correctamente")
        End If
    End Sub
    Private Sub Button_Actualizar_concierto_Click(sender As Object, e As EventArgs) Handles Button_Actualizar_concierto.Click
        Dim pa As Artista
        Dim ps As Sitio
        If Not Me.con Is Nothing Then
            pa = New Artista(Me.Text_artista_concierto.Text)
            ps = New Sitio(Me.Text_sitio_concierto.Text)
            ps.LeerSitio_ConNombre()
            pa.LeerArtistas_ConNombre()
            Me.con.Artista = New Artista(pa.IDArtista)
            Me.con.sitio = New Sitio(ps.IDSitio)
            Me.con.fecha = CDate(DateTimePicker_concierto.Text)
            Try
                If Me.con.ActualizarConcierto() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            MessageBox.Show("Actualizado correctamente")
        End If
    End Sub
    Private Sub Button_Actualizar_Setlist_Click(sender As Object, e As EventArgs) Handles Button_Actualizar_Setlist.Click
        Dim pcan As Cancion
        Me.con = New Concierto
        If Not Me.se Is Nothing Then
            pcan = New Cancion(Me.TextCancion_Setlist.Text)
            pcan.Leer_conNombre()
            Me.se.Cancion = New Cancion(pcan.IDCancion)
            Me.se.ordenSetlist = CInt(Me.text_orden_setlist.Text)
            Try
                If Me.con.ActualizarSetlist(se) <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            MessageBox.Show("Actualizado correctamente")
        End If
    End Sub
    Private Sub Eliminar_Boton_Pais_Click(sender As Object, e As EventArgs) Handles Eliminar_Boton_Pais.Click
        If Not Me.p Is Nothing Then
            MessageBox.Show("¿Está seguro que quiere borrar a " & Me.TextId_Pais.Text, "? Por favor confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Try
                If p.EliminarPais() <> 1 Then
                    MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.ListPaises.Items.Remove(Me.p.IDPais)
            Me.ComboPais_artista.Items.Remove(Me.p.IDPais)
            Me.ComboPais_Sitio.Items.Remove(Me.p.IDPais)
        End If
    End Sub

    Private Sub Eliminar_Boton_Click(sender As Object, e As EventArgs) Handles Eliminar_Boton.Click
        If Not Me.a Is Nothing Then
            MessageBox.Show("¿Está seguro que quiere borrar a " & Me.TextNombre_artista.Text, "? Por favor confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Try
                If a.BorrarArtista() <> 1 Then
                    MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.ListArtistas.Items.Remove(a.IDArtista)
        End If
    End Sub

    Private Sub Eliminar_Album_Boton_Click(sender As Object, e As EventArgs) Handles Eliminar_Album_Boton.Click
        If Not Me.al Is Nothing Then
            MessageBox.Show("¿Está seguro que quiere borrar a " & Me.nombre_album_text.Text, "? Por favor confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Try
                If al.EliminarAlbum() <> 1 Then
                    MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.ListAlbum.Items.Remove(al.IDAlbum)
        End If
    End Sub
    Private Sub Eliminar_Cancion_Album_Click(sender As Object, e As EventArgs) Handles Eliminar_Cancion_Album.Click
        If Not Me.c Is Nothing Then
            MessageBox.Show("¿Está seguro que quiere borrar a " & Me.nombre_cancion_text.Text, "? Por favor confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Try
                If c.Eliminar() <> 1 Then
                    MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.ListCanciones.Items.Remove(c.IDCancion)
        End If
    End Sub
    Private Sub Eliminar_Sitio_Boton_Click(sender As Object, e As EventArgs) Handles Eliminar_Sitio_Boton.Click
        If Not Me.s Is Nothing Then
            MessageBox.Show("¿Está seguro que quiere borrar a " & Me.nombre_sitio_text.Text, "? Por favor confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Try
                If s.EliminarSitio() <> 1 Then
                    MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.ListSitios.Items.Remove(s.IDSitio)
        End If
    End Sub
    Private Sub Button_eliminar_concierto_Click(sender As Object, e As EventArgs) Handles Button_eliminar_concierto.Click
        If Not Me.con Is Nothing Then
            MessageBox.Show("¿Esta seguro que quiere borrar el concierto  " & Me.Text_id_concierto.Text, "? Por favor confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Try
                If Me.con.EliminarConcierto() <> 1 Then
                    MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.ListConcierto.Items.Remove(Me.con.IDConcierto)
        End If
    End Sub
    Private Sub Button_eliminar_setlist_Click(sender As Object, e As EventArgs) Handles Button_eliminar_setlist.Click
        If Not Me.se Is Nothing Then
            MessageBox.Show("¿Está seguro de que quiere borrar " & Me.TextCancion_Setlist.Text, " del repertorio? Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Try
                If Me.con.EliminarSetlist(Me.se) <> 1 Then
                    MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.ListSetlist.Items.Remove(Me.se.Cancion.IDCancion)
        End If
    End Sub
    Private Sub Filtrar_Boton_sitio_Click(sender As Object, e As EventArgs) Handles Filtrar_Boton_sitio.Click
        If Not ComboFiltrar_Sitio.Text Is Nothing Then
            Me.s = New Sitio(Me.ComboFiltrar_Sitio.Text)
            Me.s.LeerSitio_ConNombre()
            Me.con = New Concierto
            Me.con.LeerTodosConciertos()
            Dim pc As Concierto
            Me.ListConcierto.Items.Clear()
            For Each pc In con.conciertoDAO.Conciertos
                If pc.sitio.IDSitio = Me.s.IDSitio Then
                    Me.ListConcierto.Items.Add(pc.IDConcierto)
                End If
            Next

        End If
    End Sub

    Private Sub Filtrar_Boton_Aritsta_Click(sender As Object, e As EventArgs) Handles Filtrar_Boton_Aritsta.Click
        If Not Me.ComboFiltrar_Artista.Text Is Nothing Then
            Me.a = New Artista(Me.ComboFiltrar_Artista.Text)
            Me.a.LeerArtistas_ConNombre()
            Me.con = New Concierto
            Me.con.LeerTodosConciertos()
            Dim pc As Concierto
            Me.ListConcierto.Items.Clear()
            For Each pc In Me.con.conciertoDAO.Conciertos
                If pc.Artista.IDArtista = Me.a.IDArtista Then
                    Me.ListConcierto.Items.Add(pc.IDConcierto)
                End If
            Next
        End If
    End Sub
    Private Sub Limpiar_filtros_Boton_Click(sender As Object, e As EventArgs) Handles Limpiar_filtros_Boton.Click
        Me.con = New Concierto
        Me.con.LeerTodosConciertos()
        Dim pc As Concierto
        Me.ListConcierto.Items.Clear()
        For Each pc In Me.con.conciertoDAO.Conciertos
            Me.ListConcierto.Items.Add(pc.IDConcierto)
        Next
        Me.ComboFiltrar_Artista.Text = String.Empty
        Me.ComboFiltrar_Sitio.Text = String.Empty
    End Sub

    Private Sub Button_Limpiar_Setlist_Click(sender As Object, e As EventArgs) Handles Button_Limpiar_Setlist.Click
        Me.text_orden_setlist.Text = String.Empty
        Me.TextCancion_Setlist.Text = String.Empty
        Me.TextConcierto_setlist.Text = String.Empty
    End Sub

    Private Sub List_rank_canciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List_rank_canciones.SelectedIndexChanged
        If Not Me.List_rank_canciones.SelectedItem Is Nothing Then
            Me.c = New Cancion(CInt(Me.List_rank_canciones.SelectedItem.ToString))
            Try
                Me.c.Leer()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            al = New Album
            al.IDAlbum = c.Album.IDAlbum
            al.LeerAlbum()
            Me.Text_rank_duracion_cancion.Text = c.Duracion.ToString
            Me.Text_rank_id_cancion.Text = c.IDCancion.ToString
            Me.Text_rank_nombre_cancion.Text = c.Nombre
            Me.Text_rank_orden_cancion.Text = c.Orden.ToString
            Me.Text_rank_album_cancion.Text = al.Nombre
        End If
    End Sub

    Private Sub List_Rank_Album_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List_Rank_Album.SelectedIndexChanged
        If Not Me.List_Rank_Album.SelectedItem Is Nothing Then
            Me.al = New Album(CInt(Me.List_Rank_Album.SelectedItem.ToString))
            Try
                Me.al.LeerAlbum()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            a = New Artista
            a.IDArtista = al.Artista.IDArtista
            a.LeerArtista()
            Me.Text_rank_id_album.Text = al.IDAlbum.ToString
            Me.Text_rank_artista_album.Text = a.Nombre
            Me.Text_rabk_año_album.Text = al.Año.ToString
            Me.Text_rank_nombre_album.Text = al.Nombre
        End If
    End Sub

    Private Sub Mostrar_Ranking_Concierto_Click(sender As Object, e As EventArgs) Handles Mostrar_Ranking_Concierto.Click
        If Me.Date_ranking_inicio.Text <> String.Empty And Me.Date_rank_fin.Text <> String.Empty Then
            Me.a = New Artista
            a.ranking(CDate(Date_ranking_inicio.Text), CDate(Date_rank_fin.Text))
            Dim pa As Artista
            Me.List_rank_artista_concierto.Items.Clear()
            For Each pa In a.ArtistaDAO.Artista
                Me.List_rank_artista_concierto.Items.Add(pa.Nombre)
            Next
            Me.p = New Pais
            p.Ranking(CDate(Date_ranking_inicio.Text), CDate(Date_rank_fin.Text))
            Dim pp As Pais
            Me.List_Rank_paises_concierto.Items.Clear()
            For Each pp In Me.p.PaisDAO.Pais
                pp.LeerPais()
                Me.List_Rank_paises_concierto.Items.Add(pp.Nombre)
            Next
        End If
    End Sub
    Private Sub Butrron_rank_cancion_Click(sender As Object, e As EventArgs) Handles Butrron_rank_cancion.Click
        Me.c = New Cancion
        Try
            c.Leer_Ranking_2()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        Dim pc As Cancion
        Me.List_ranking_cancion2.Items.Clear()
        For Each pc In c.CancionDAO.Canciones
            Me.List_ranking_cancion2.Items.Add(pc.IDCancion)
        Next
    End Sub
    Private Sub List_ranking_cancion2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List_ranking_cancion2.SelectedIndexChanged
        If Not Me.List_ranking_cancion2.SelectedItem Is Nothing Then
            Me.c = New Cancion(CInt(Me.List_ranking_cancion2.SelectedItem))
            Me.c.Leer()
            Me.al = New Album(Me.c.Album.IDAlbum)
            Me.al.LeerAlbum()
            Me.Text_rank_albumcan_cancion.Text = Me.al.Nombre
            Me.Text_rank_duracioncan_cancion.Text = c.Duracion.ToString
            Me.Text_rank_nombrecan_cancion.Text = c.Nombre
            Me.Text_id_cancion_rank_cancion.Text = c.IDCancion.ToString
            Me.Text_rank_ordencan_cancion.Text = c.Orden.ToString
        End If
    End Sub
End Class
