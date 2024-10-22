<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCanciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Artistas = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Text_rank_artista_album = New System.Windows.Forms.TextBox()
        Me.Text_rabk_año_album = New System.Windows.Forms.TextBox()
        Me.Text_rank_id_album = New System.Windows.Forms.TextBox()
        Me.Text_rank_nombre_album = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.List_Rank_Album = New System.Windows.Forms.ListBox()
        Me.Text_rank_album_cancion = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Text_rank_orden_cancion = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Text_rank_duracion_cancion = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Text_rank_nombre_cancion = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Text_rank_id_cancion = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.List_rank_canciones = New System.Windows.Forms.ListBox()
        Me.Limpiar_Artista_Boton = New System.Windows.Forms.Button()
        Me.Eliminar_Boton = New System.Windows.Forms.Button()
        Me.Actualizar_Boton = New System.Windows.Forms.Button()
        Me.Añadir_Boton = New System.Windows.Forms.Button()
        Me.ListArtistas = New System.Windows.Forms.ListBox()
        Me.TextID_Artista = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboPais_artista = New System.Windows.Forms.ComboBox()
        Me.Pais = New System.Windows.Forms.Label()
        Me.TextNombre_artista = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Limpiar_Pais_Boton = New System.Windows.Forms.Button()
        Me.Eliminar_Boton_Pais = New System.Windows.Forms.Button()
        Me.Actualizar_Boton_Pais = New System.Windows.Forms.Button()
        Me.Añadir_Boton_Pais = New System.Windows.Forms.Button()
        Me.ListPaises = New System.Windows.Forms.ListBox()
        Me.TextId_Pais = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextPais = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Limpiar_Album_Boton = New System.Windows.Forms.Button()
        Me.Eliminar_Album_Boton = New System.Windows.Forms.Button()
        Me.Actualizar_Album_Boton = New System.Windows.Forms.Button()
        Me.Añadir_Album_Boton = New System.Windows.Forms.Button()
        Me.artista_album_text = New System.Windows.Forms.TextBox()
        Me.año_album_text = New System.Windows.Forms.TextBox()
        Me.id_album_text = New System.Windows.Forms.TextBox()
        Me.nombre_album_text = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListAlbum = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Limpiar_Cancion_Boton = New System.Windows.Forms.Button()
        Me.Eliminar_Cancion_Album = New System.Windows.Forms.Button()
        Me.Actualizar_Cancion_Boton = New System.Windows.Forms.Button()
        Me.Añadir_Cancion_Boton = New System.Windows.Forms.Button()
        Me.album_cancion_text = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.orden_cancion_text = New System.Windows.Forms.TextBox()
        Me.Orden = New System.Windows.Forms.Label()
        Me.duracion_cancion_text = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.nombre_cancion_text = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.id_cancion_text = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListCanciones = New System.Windows.Forms.ListBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.ComboTipo_Sitio = New System.Windows.Forms.ComboBox()
        Me.ComboPais_Sitio = New System.Windows.Forms.ComboBox()
        Me.Limpiar_Sitio_Boton = New System.Windows.Forms.Button()
        Me.Eliminar_Sitio_Boton = New System.Windows.Forms.Button()
        Me.Actualizar_Sitio_Boton = New System.Windows.Forms.Button()
        Me.Añadir_Sitio_Boton = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Tipo = New System.Windows.Forms.Label()
        Me.nombre_sitio_text = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.id_sitio_text = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ListSitios = New System.Windows.Forms.ListBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.List_Rank_paises_concierto = New System.Windows.Forms.ListBox()
        Me.Mostrar_Ranking_Concierto = New System.Windows.Forms.Button()
        Me.Date_rank_fin = New System.Windows.Forms.DateTimePicker()
        Me.Date_ranking_inicio = New System.Windows.Forms.DateTimePicker()
        Me.List_rank_artista_concierto = New System.Windows.Forms.ListBox()
        Me.Limpiar_filtros_Boton = New System.Windows.Forms.Button()
        Me.Filtrar_Boton_Aritsta = New System.Windows.Forms.Button()
        Me.Filtrar_Boton_sitio = New System.Windows.Forms.Button()
        Me.ComboFiltrar_Artista = New System.Windows.Forms.ComboBox()
        Me.ComboFiltrar_Sitio = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.DateTimePicker_concierto = New System.Windows.Forms.DateTimePicker()
        Me.Button_Limpiar_Setlist = New System.Windows.Forms.Button()
        Me.Button_Limpiar_Concierto = New System.Windows.Forms.Button()
        Me.Button_Actualizar_Setlist = New System.Windows.Forms.Button()
        Me.Button_eliminar_setlist = New System.Windows.Forms.Button()
        Me.Button_Añadir_Setlist = New System.Windows.Forms.Button()
        Me.text_orden_setlist = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextConcierto_setlist = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextCancion_Setlist = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ListSetlist = New System.Windows.Forms.ListBox()
        Me.Button_Actualizar_concierto = New System.Windows.Forms.Button()
        Me.Button_Añadir_Concierto = New System.Windows.Forms.Button()
        Me.Button_eliminar_concierto = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Text_sitio_concierto = New System.Windows.Forms.TextBox()
        Me.Text_artista_concierto = New System.Windows.Forms.TextBox()
        Me.Text_id_concierto = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.Label()
        Me.ListConcierto = New System.Windows.Forms.ListBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.List_Ranking = New System.Windows.Forms.ListBox()
        Me.List_ranking_cancion2 = New System.Windows.Forms.ListBox()
        Me.Text_rank_albumcan_cancion = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Text_rank_ordencan_cancion = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Text_rank_duracioncan_cancion = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Text_rank_nombrecan_cancion = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Text_id_cancion_rank_cancion = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Butrron_rank_cancion = New System.Windows.Forms.Button()
        Me.Artistas.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Artistas
        '
        Me.Artistas.Controls.Add(Me.TabPage1)
        Me.Artistas.Controls.Add(Me.TabPage2)
        Me.Artistas.Controls.Add(Me.TabPage3)
        Me.Artistas.Controls.Add(Me.TabPage4)
        Me.Artistas.Controls.Add(Me.TabPage5)
        Me.Artistas.Controls.Add(Me.TabPage6)
        Me.Artistas.Controls.Add(Me.TabPage7)
        Me.Artistas.Location = New System.Drawing.Point(1, 12)
        Me.Artistas.Name = "Artistas"
        Me.Artistas.SelectedIndex = 0
        Me.Artistas.Size = New System.Drawing.Size(1746, 508)
        Me.Artistas.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label34)
        Me.TabPage1.Controls.Add(Me.Text_rank_artista_album)
        Me.TabPage1.Controls.Add(Me.Text_rabk_año_album)
        Me.TabPage1.Controls.Add(Me.Text_rank_id_album)
        Me.TabPage1.Controls.Add(Me.Text_rank_nombre_album)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.Label32)
        Me.TabPage1.Controls.Add(Me.Label33)
        Me.TabPage1.Controls.Add(Me.List_Rank_Album)
        Me.TabPage1.Controls.Add(Me.Text_rank_album_cancion)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.Text_rank_orden_cancion)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.Text_rank_duracion_cancion)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.Text_rank_nombre_cancion)
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.Text_rank_id_cancion)
        Me.TabPage1.Controls.Add(Me.Label29)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.List_rank_canciones)
        Me.TabPage1.Controls.Add(Me.Limpiar_Artista_Boton)
        Me.TabPage1.Controls.Add(Me.Eliminar_Boton)
        Me.TabPage1.Controls.Add(Me.Actualizar_Boton)
        Me.TabPage1.Controls.Add(Me.Añadir_Boton)
        Me.TabPage1.Controls.Add(Me.ListArtistas)
        Me.TabPage1.Controls.Add(Me.TextID_Artista)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.ComboPais_artista)
        Me.TabPage1.Controls.Add(Me.Pais)
        Me.TabPage1.Controls.Add(Me.TextNombre_artista)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1738, 479)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Artistas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(990, 22)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(491, 25)
        Me.Label34.TabIndex = 38
        Me.Label34.Text = "LISTADO DE ALBUMES MAS INTERPRETADOS"
        '
        'Text_rank_artista_album
        '
        Me.Text_rank_artista_album.Location = New System.Drawing.Point(1365, 321)
        Me.Text_rank_artista_album.Name = "Text_rank_artista_album"
        Me.Text_rank_artista_album.Size = New System.Drawing.Size(242, 22)
        Me.Text_rank_artista_album.TabIndex = 37
        '
        'Text_rabk_año_album
        '
        Me.Text_rabk_año_album.Location = New System.Drawing.Point(1365, 256)
        Me.Text_rabk_año_album.Name = "Text_rabk_año_album"
        Me.Text_rabk_año_album.Size = New System.Drawing.Size(242, 22)
        Me.Text_rabk_año_album.TabIndex = 36
        '
        'Text_rank_id_album
        '
        Me.Text_rank_id_album.Location = New System.Drawing.Point(1365, 179)
        Me.Text_rank_id_album.Name = "Text_rank_id_album"
        Me.Text_rank_id_album.ReadOnly = True
        Me.Text_rank_id_album.Size = New System.Drawing.Size(242, 22)
        Me.Text_rank_id_album.TabIndex = 35
        '
        'Text_rank_nombre_album
        '
        Me.Text_rank_nombre_album.Location = New System.Drawing.Point(1365, 102)
        Me.Text_rank_nombre_album.Name = "Text_rank_nombre_album"
        Me.Text_rank_nombre_album.Size = New System.Drawing.Size(242, 22)
        Me.Text_rank_nombre_album.TabIndex = 34
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(1233, 314)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(67, 25)
        Me.Label30.TabIndex = 33
        Me.Label30.Text = "Artista"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(1233, 252)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(48, 25)
        Me.Label31.TabIndex = 32
        Me.Label31.Text = "Año"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(1250, 175)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(31, 25)
        Me.Label32.TabIndex = 31
        Me.Label32.Text = "ID"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(1233, 98)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(81, 25)
        Me.Label33.TabIndex = 30
        Me.Label33.Text = "Nombre"
        '
        'List_Rank_Album
        '
        Me.List_Rank_Album.FormattingEnabled = True
        Me.List_Rank_Album.ItemHeight = 16
        Me.List_Rank_Album.Location = New System.Drawing.Point(1048, 68)
        Me.List_Rank_Album.Name = "List_Rank_Album"
        Me.List_Rank_Album.Size = New System.Drawing.Size(160, 308)
        Me.List_Rank_Album.TabIndex = 29
        '
        'Text_rank_album_cancion
        '
        Me.Text_rank_album_cancion.Location = New System.Drawing.Point(861, 325)
        Me.Text_rank_album_cancion.Name = "Text_rank_album_cancion"
        Me.Text_rank_album_cancion.Size = New System.Drawing.Size(129, 22)
        Me.Text_rank_album_cancion.TabIndex = 28
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(727, 321)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(68, 25)
        Me.Label25.TabIndex = 27
        Me.Label25.Text = "Album"
        '
        'Text_rank_orden_cancion
        '
        Me.Text_rank_orden_cancion.Location = New System.Drawing.Point(861, 260)
        Me.Text_rank_orden_cancion.Name = "Text_rank_orden_cancion"
        Me.Text_rank_orden_cancion.Size = New System.Drawing.Size(129, 22)
        Me.Text_rank_orden_cancion.TabIndex = 26
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(728, 256)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(67, 25)
        Me.Label26.TabIndex = 25
        Me.Label26.Text = "Orden"
        '
        'Text_rank_duracion_cancion
        '
        Me.Text_rank_duracion_cancion.Location = New System.Drawing.Point(861, 201)
        Me.Text_rank_duracion_cancion.Name = "Text_rank_duracion_cancion"
        Me.Text_rank_duracion_cancion.Size = New System.Drawing.Size(129, 22)
        Me.Text_rank_duracion_cancion.TabIndex = 24
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(727, 197)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(90, 25)
        Me.Label27.TabIndex = 23
        Me.Label27.Text = "Duracion"
        '
        'Text_rank_nombre_cancion
        '
        Me.Text_rank_nombre_cancion.Location = New System.Drawing.Point(861, 149)
        Me.Text_rank_nombre_cancion.Name = "Text_rank_nombre_cancion"
        Me.Text_rank_nombre_cancion.Size = New System.Drawing.Size(129, 22)
        Me.Text_rank_nombre_cancion.TabIndex = 22
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(727, 145)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(81, 25)
        Me.Label28.TabIndex = 21
        Me.Label28.Text = "Nombre"
        '
        'Text_rank_id_cancion
        '
        Me.Text_rank_id_cancion.Location = New System.Drawing.Point(861, 103)
        Me.Text_rank_id_cancion.Name = "Text_rank_id_cancion"
        Me.Text_rank_id_cancion.ReadOnly = True
        Me.Text_rank_id_cancion.Size = New System.Drawing.Size(129, 22)
        Me.Text_rank_id_cancion.TabIndex = 20
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(748, 99)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(31, 25)
        Me.Label29.TabIndex = 19
        Me.Label29.Text = "ID"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(400, 22)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(515, 25)
        Me.Label24.TabIndex = 18
        Me.Label24.Text = "LISTADO DE CANCIONES MAS INTERPRETADAS"
        '
        'List_rank_canciones
        '
        Me.List_rank_canciones.FormattingEnabled = True
        Me.List_rank_canciones.ItemHeight = 16
        Me.List_rank_canciones.Location = New System.Drawing.Point(545, 65)
        Me.List_rank_canciones.Name = "List_rank_canciones"
        Me.List_rank_canciones.Size = New System.Drawing.Size(151, 308)
        Me.List_rank_canciones.TabIndex = 17
        '
        'Limpiar_Artista_Boton
        '
        Me.Limpiar_Artista_Boton.Location = New System.Drawing.Point(387, 346)
        Me.Limpiar_Artista_Boton.Name = "Limpiar_Artista_Boton"
        Me.Limpiar_Artista_Boton.Size = New System.Drawing.Size(104, 36)
        Me.Limpiar_Artista_Boton.TabIndex = 11
        Me.Limpiar_Artista_Boton.Text = "Limpiar"
        Me.Limpiar_Artista_Boton.UseVisualStyleBackColor = True
        '
        'Eliminar_Boton
        '
        Me.Eliminar_Boton.Location = New System.Drawing.Point(204, 346)
        Me.Eliminar_Boton.Name = "Eliminar_Boton"
        Me.Eliminar_Boton.Size = New System.Drawing.Size(104, 36)
        Me.Eliminar_Boton.TabIndex = 10
        Me.Eliminar_Boton.Text = "Eliminar"
        Me.Eliminar_Boton.UseVisualStyleBackColor = True
        '
        'Actualizar_Boton
        '
        Me.Actualizar_Boton.Location = New System.Drawing.Point(204, 281)
        Me.Actualizar_Boton.Name = "Actualizar_Boton"
        Me.Actualizar_Boton.Size = New System.Drawing.Size(104, 36)
        Me.Actualizar_Boton.TabIndex = 9
        Me.Actualizar_Boton.Text = "Actualizar"
        Me.Actualizar_Boton.UseVisualStyleBackColor = True
        '
        'Añadir_Boton
        '
        Me.Añadir_Boton.Location = New System.Drawing.Point(387, 281)
        Me.Añadir_Boton.Name = "Añadir_Boton"
        Me.Añadir_Boton.Size = New System.Drawing.Size(104, 36)
        Me.Añadir_Boton.TabIndex = 8
        Me.Añadir_Boton.Text = "Añadir"
        Me.Añadir_Boton.UseVisualStyleBackColor = True
        '
        'ListArtistas
        '
        Me.ListArtistas.FormattingEnabled = True
        Me.ListArtistas.ItemHeight = 16
        Me.ListArtistas.Location = New System.Drawing.Point(3, 65)
        Me.ListArtistas.Name = "ListArtistas"
        Me.ListArtistas.Size = New System.Drawing.Size(174, 324)
        Me.ListArtistas.TabIndex = 6
        '
        'TextID_Artista
        '
        Me.TextID_Artista.Location = New System.Drawing.Point(351, 68)
        Me.TextID_Artista.Name = "TextID_Artista"
        Me.TextID_Artista.ReadOnly = True
        Me.TextID_Artista.Size = New System.Drawing.Size(140, 22)
        Me.TextID_Artista.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(258, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ID"
        '
        'ComboPais_artista
        '
        Me.ComboPais_artista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPais_artista.FormattingEnabled = True
        Me.ComboPais_artista.Location = New System.Drawing.Point(351, 215)
        Me.ComboPais_artista.Name = "ComboPais_artista"
        Me.ComboPais_artista.Size = New System.Drawing.Size(146, 24)
        Me.ComboPais_artista.TabIndex = 3
        '
        'Pais
        '
        Me.Pais.AutoSize = True
        Me.Pais.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pais.Location = New System.Drawing.Point(258, 211)
        Me.Pais.Name = "Pais"
        Me.Pais.Size = New System.Drawing.Size(50, 25)
        Me.Pais.TabIndex = 2
        Me.Pais.Text = "Pais"
        '
        'TextNombre_artista
        '
        Me.TextNombre_artista.Location = New System.Drawing.Point(351, 139)
        Me.TextNombre_artista.Name = "TextNombre_artista"
        Me.TextNombre_artista.Size = New System.Drawing.Size(140, 22)
        Me.TextNombre_artista.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Limpiar_Pais_Boton)
        Me.TabPage2.Controls.Add(Me.Eliminar_Boton_Pais)
        Me.TabPage2.Controls.Add(Me.Actualizar_Boton_Pais)
        Me.TabPage2.Controls.Add(Me.Añadir_Boton_Pais)
        Me.TabPage2.Controls.Add(Me.ListPaises)
        Me.TabPage2.Controls.Add(Me.TextId_Pais)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.TextPais)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1738, 479)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Paises"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Limpiar_Pais_Boton
        '
        Me.Limpiar_Pais_Boton.Location = New System.Drawing.Point(516, 337)
        Me.Limpiar_Pais_Boton.Name = "Limpiar_Pais_Boton"
        Me.Limpiar_Pais_Boton.Size = New System.Drawing.Size(104, 36)
        Me.Limpiar_Pais_Boton.TabIndex = 13
        Me.Limpiar_Pais_Boton.Text = "Limpiar"
        Me.Limpiar_Pais_Boton.UseVisualStyleBackColor = True
        '
        'Eliminar_Boton_Pais
        '
        Me.Eliminar_Boton_Pais.Location = New System.Drawing.Point(350, 337)
        Me.Eliminar_Boton_Pais.Name = "Eliminar_Boton_Pais"
        Me.Eliminar_Boton_Pais.Size = New System.Drawing.Size(104, 36)
        Me.Eliminar_Boton_Pais.TabIndex = 12
        Me.Eliminar_Boton_Pais.Text = "Eliminar"
        Me.Eliminar_Boton_Pais.UseVisualStyleBackColor = True
        '
        'Actualizar_Boton_Pais
        '
        Me.Actualizar_Boton_Pais.Location = New System.Drawing.Point(350, 270)
        Me.Actualizar_Boton_Pais.Name = "Actualizar_Boton_Pais"
        Me.Actualizar_Boton_Pais.Size = New System.Drawing.Size(104, 36)
        Me.Actualizar_Boton_Pais.TabIndex = 11
        Me.Actualizar_Boton_Pais.Text = "Actualizar"
        Me.Actualizar_Boton_Pais.UseVisualStyleBackColor = True
        '
        'Añadir_Boton_Pais
        '
        Me.Añadir_Boton_Pais.Location = New System.Drawing.Point(516, 270)
        Me.Añadir_Boton_Pais.Name = "Añadir_Boton_Pais"
        Me.Añadir_Boton_Pais.Size = New System.Drawing.Size(104, 36)
        Me.Añadir_Boton_Pais.TabIndex = 9
        Me.Añadir_Boton_Pais.Text = "Añadir"
        Me.Añadir_Boton_Pais.UseVisualStyleBackColor = True
        '
        'ListPaises
        '
        Me.ListPaises.FormattingEnabled = True
        Me.ListPaises.ItemHeight = 16
        Me.ListPaises.Location = New System.Drawing.Point(7, 20)
        Me.ListPaises.Name = "ListPaises"
        Me.ListPaises.Size = New System.Drawing.Size(317, 324)
        Me.ListPaises.TabIndex = 4
        '
        'TextId_Pais
        '
        Me.TextId_Pais.Location = New System.Drawing.Point(514, 197)
        Me.TextId_Pais.Name = "TextId_Pais"
        Me.TextId_Pais.ReadOnly = True
        Me.TextId_Pais.Size = New System.Drawing.Size(150, 22)
        Me.TextId_Pais.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(390, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ID"
        '
        'TextPais
        '
        Me.TextPais.Location = New System.Drawing.Point(516, 125)
        Me.TextPais.Name = "TextPais"
        Me.TextPais.Size = New System.Drawing.Size(148, 22)
        Me.TextPais.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(373, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nombre"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Limpiar_Album_Boton)
        Me.TabPage3.Controls.Add(Me.Eliminar_Album_Boton)
        Me.TabPage3.Controls.Add(Me.Actualizar_Album_Boton)
        Me.TabPage3.Controls.Add(Me.Añadir_Album_Boton)
        Me.TabPage3.Controls.Add(Me.artista_album_text)
        Me.TabPage3.Controls.Add(Me.año_album_text)
        Me.TabPage3.Controls.Add(Me.id_album_text)
        Me.TabPage3.Controls.Add(Me.nombre_album_text)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.ListAlbum)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1738, 479)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Album"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Limpiar_Album_Boton
        '
        Me.Limpiar_Album_Boton.Location = New System.Drawing.Point(549, 348)
        Me.Limpiar_Album_Boton.Name = "Limpiar_Album_Boton"
        Me.Limpiar_Album_Boton.Size = New System.Drawing.Size(104, 36)
        Me.Limpiar_Album_Boton.TabIndex = 14
        Me.Limpiar_Album_Boton.Text = "Limpiar"
        Me.Limpiar_Album_Boton.UseVisualStyleBackColor = True
        '
        'Eliminar_Album_Boton
        '
        Me.Eliminar_Album_Boton.Location = New System.Drawing.Point(549, 293)
        Me.Eliminar_Album_Boton.Name = "Eliminar_Album_Boton"
        Me.Eliminar_Album_Boton.Size = New System.Drawing.Size(104, 36)
        Me.Eliminar_Album_Boton.TabIndex = 12
        Me.Eliminar_Album_Boton.Text = "Eliminar"
        Me.Eliminar_Album_Boton.UseVisualStyleBackColor = True
        '
        'Actualizar_Album_Boton
        '
        Me.Actualizar_Album_Boton.Location = New System.Drawing.Point(359, 293)
        Me.Actualizar_Album_Boton.Name = "Actualizar_Album_Boton"
        Me.Actualizar_Album_Boton.Size = New System.Drawing.Size(104, 36)
        Me.Actualizar_Album_Boton.TabIndex = 11
        Me.Actualizar_Album_Boton.Text = "Actualizar"
        Me.Actualizar_Album_Boton.UseVisualStyleBackColor = True
        '
        'Añadir_Album_Boton
        '
        Me.Añadir_Album_Boton.Location = New System.Drawing.Point(359, 351)
        Me.Añadir_Album_Boton.Name = "Añadir_Album_Boton"
        Me.Añadir_Album_Boton.Size = New System.Drawing.Size(104, 36)
        Me.Añadir_Album_Boton.TabIndex = 9
        Me.Añadir_Album_Boton.Text = "Añadir"
        Me.Añadir_Album_Boton.UseVisualStyleBackColor = True
        '
        'artista_album_text
        '
        Me.artista_album_text.Location = New System.Drawing.Point(481, 241)
        Me.artista_album_text.Name = "artista_album_text"
        Me.artista_album_text.Size = New System.Drawing.Size(242, 22)
        Me.artista_album_text.TabIndex = 8
        '
        'año_album_text
        '
        Me.año_album_text.Location = New System.Drawing.Point(481, 168)
        Me.año_album_text.Name = "año_album_text"
        Me.año_album_text.Size = New System.Drawing.Size(242, 22)
        Me.año_album_text.TabIndex = 7
        '
        'id_album_text
        '
        Me.id_album_text.Location = New System.Drawing.Point(481, 101)
        Me.id_album_text.Name = "id_album_text"
        Me.id_album_text.ReadOnly = True
        Me.id_album_text.Size = New System.Drawing.Size(242, 22)
        Me.id_album_text.TabIndex = 6
        '
        'nombre_album_text
        '
        Me.nombre_album_text.Location = New System.Drawing.Point(481, 26)
        Me.nombre_album_text.Name = "nombre_album_text"
        Me.nombre_album_text.Size = New System.Drawing.Size(242, 22)
        Me.nombre_album_text.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(354, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 25)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Artista"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(354, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 25)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Año"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(354, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 25)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "ID"
        '
        'ListAlbum
        '
        Me.ListAlbum.FormattingEnabled = True
        Me.ListAlbum.ItemHeight = 16
        Me.ListAlbum.Location = New System.Drawing.Point(3, 3)
        Me.ListAlbum.Name = "ListAlbum"
        Me.ListAlbum.Size = New System.Drawing.Size(311, 388)
        Me.ListAlbum.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(354, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nombre"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Butrron_rank_cancion)
        Me.TabPage4.Controls.Add(Me.Text_rank_albumcan_cancion)
        Me.TabPage4.Controls.Add(Me.Label35)
        Me.TabPage4.Controls.Add(Me.Text_rank_ordencan_cancion)
        Me.TabPage4.Controls.Add(Me.Label36)
        Me.TabPage4.Controls.Add(Me.Text_rank_duracioncan_cancion)
        Me.TabPage4.Controls.Add(Me.Label37)
        Me.TabPage4.Controls.Add(Me.Text_rank_nombrecan_cancion)
        Me.TabPage4.Controls.Add(Me.Label38)
        Me.TabPage4.Controls.Add(Me.Text_id_cancion_rank_cancion)
        Me.TabPage4.Controls.Add(Me.Label39)
        Me.TabPage4.Controls.Add(Me.List_ranking_cancion2)
        Me.TabPage4.Controls.Add(Me.Limpiar_Cancion_Boton)
        Me.TabPage4.Controls.Add(Me.Eliminar_Cancion_Album)
        Me.TabPage4.Controls.Add(Me.Actualizar_Cancion_Boton)
        Me.TabPage4.Controls.Add(Me.Añadir_Cancion_Boton)
        Me.TabPage4.Controls.Add(Me.album_cancion_text)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.orden_cancion_text)
        Me.TabPage4.Controls.Add(Me.Orden)
        Me.TabPage4.Controls.Add(Me.duracion_cancion_text)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.nombre_cancion_text)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.id_cancion_text)
        Me.TabPage4.Controls.Add(Me.Label9)
        Me.TabPage4.Controls.Add(Me.ListCanciones)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1738, 479)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Canciones"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Limpiar_Cancion_Boton
        '
        Me.Limpiar_Cancion_Boton.Location = New System.Drawing.Point(337, 358)
        Me.Limpiar_Cancion_Boton.Name = "Limpiar_Cancion_Boton"
        Me.Limpiar_Cancion_Boton.Size = New System.Drawing.Size(104, 36)
        Me.Limpiar_Cancion_Boton.TabIndex = 15
        Me.Limpiar_Cancion_Boton.Text = "Limpiar"
        Me.Limpiar_Cancion_Boton.UseVisualStyleBackColor = True
        '
        'Eliminar_Cancion_Album
        '
        Me.Eliminar_Cancion_Album.Location = New System.Drawing.Point(469, 297)
        Me.Eliminar_Cancion_Album.Name = "Eliminar_Cancion_Album"
        Me.Eliminar_Cancion_Album.Size = New System.Drawing.Size(104, 36)
        Me.Eliminar_Cancion_Album.TabIndex = 14
        Me.Eliminar_Cancion_Album.Text = "Eliminar"
        Me.Eliminar_Cancion_Album.UseVisualStyleBackColor = True
        '
        'Actualizar_Cancion_Boton
        '
        Me.Actualizar_Cancion_Boton.Location = New System.Drawing.Point(469, 358)
        Me.Actualizar_Cancion_Boton.Name = "Actualizar_Cancion_Boton"
        Me.Actualizar_Cancion_Boton.Size = New System.Drawing.Size(104, 36)
        Me.Actualizar_Cancion_Boton.TabIndex = 13
        Me.Actualizar_Cancion_Boton.Text = "Actualizar"
        Me.Actualizar_Cancion_Boton.UseVisualStyleBackColor = True
        '
        'Añadir_Cancion_Boton
        '
        Me.Añadir_Cancion_Boton.Location = New System.Drawing.Point(337, 297)
        Me.Añadir_Cancion_Boton.Name = "Añadir_Cancion_Boton"
        Me.Añadir_Cancion_Boton.Size = New System.Drawing.Size(104, 36)
        Me.Añadir_Cancion_Boton.TabIndex = 11
        Me.Añadir_Cancion_Boton.Text = "Añadir"
        Me.Añadir_Cancion_Boton.UseVisualStyleBackColor = True
        '
        'album_cancion_text
        '
        Me.album_cancion_text.Location = New System.Drawing.Point(494, 249)
        Me.album_cancion_text.Name = "album_cancion_text"
        Me.album_cancion_text.Size = New System.Drawing.Size(129, 22)
        Me.album_cancion_text.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(360, 245)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 25)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Album"
        '
        'orden_cancion_text
        '
        Me.orden_cancion_text.Location = New System.Drawing.Point(494, 184)
        Me.orden_cancion_text.Name = "orden_cancion_text"
        Me.orden_cancion_text.Size = New System.Drawing.Size(129, 22)
        Me.orden_cancion_text.TabIndex = 8
        '
        'Orden
        '
        Me.Orden.AutoSize = True
        Me.Orden.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Orden.Location = New System.Drawing.Point(361, 180)
        Me.Orden.Name = "Orden"
        Me.Orden.Size = New System.Drawing.Size(67, 25)
        Me.Orden.TabIndex = 7
        Me.Orden.Text = "Orden"
        '
        'duracion_cancion_text
        '
        Me.duracion_cancion_text.Location = New System.Drawing.Point(494, 125)
        Me.duracion_cancion_text.Name = "duracion_cancion_text"
        Me.duracion_cancion_text.Size = New System.Drawing.Size(129, 22)
        Me.duracion_cancion_text.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(360, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 25)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Duracion"
        '
        'nombre_cancion_text
        '
        Me.nombre_cancion_text.Location = New System.Drawing.Point(494, 73)
        Me.nombre_cancion_text.Name = "nombre_cancion_text"
        Me.nombre_cancion_text.Size = New System.Drawing.Size(129, 22)
        Me.nombre_cancion_text.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(360, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 25)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Nombre"
        '
        'id_cancion_text
        '
        Me.id_cancion_text.Location = New System.Drawing.Point(494, 27)
        Me.id_cancion_text.Name = "id_cancion_text"
        Me.id_cancion_text.ReadOnly = True
        Me.id_cancion_text.Size = New System.Drawing.Size(129, 22)
        Me.id_cancion_text.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(381, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 25)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "ID"
        '
        'ListCanciones
        '
        Me.ListCanciones.FormattingEnabled = True
        Me.ListCanciones.ItemHeight = 16
        Me.ListCanciones.Location = New System.Drawing.Point(7, 6)
        Me.ListCanciones.Name = "ListCanciones"
        Me.ListCanciones.Size = New System.Drawing.Size(304, 372)
        Me.ListCanciones.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.ComboTipo_Sitio)
        Me.TabPage5.Controls.Add(Me.ComboPais_Sitio)
        Me.TabPage5.Controls.Add(Me.Limpiar_Sitio_Boton)
        Me.TabPage5.Controls.Add(Me.Eliminar_Sitio_Boton)
        Me.TabPage5.Controls.Add(Me.Actualizar_Sitio_Boton)
        Me.TabPage5.Controls.Add(Me.Añadir_Sitio_Boton)
        Me.TabPage5.Controls.Add(Me.Label15)
        Me.TabPage5.Controls.Add(Me.Tipo)
        Me.TabPage5.Controls.Add(Me.nombre_sitio_text)
        Me.TabPage5.Controls.Add(Me.Label14)
        Me.TabPage5.Controls.Add(Me.id_sitio_text)
        Me.TabPage5.Controls.Add(Me.Label13)
        Me.TabPage5.Controls.Add(Me.ListSitios)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1738, 479)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Sitios"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'ComboTipo_Sitio
        '
        Me.ComboTipo_Sitio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboTipo_Sitio.FormattingEnabled = True
        Me.ComboTipo_Sitio.Location = New System.Drawing.Point(475, 161)
        Me.ComboTipo_Sitio.Name = "ComboTipo_Sitio"
        Me.ComboTipo_Sitio.Size = New System.Drawing.Size(154, 24)
        Me.ComboTipo_Sitio.TabIndex = 18
        '
        'ComboPais_Sitio
        '
        Me.ComboPais_Sitio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPais_Sitio.FormattingEnabled = True
        Me.ComboPais_Sitio.Location = New System.Drawing.Point(475, 221)
        Me.ComboPais_Sitio.Name = "ComboPais_Sitio"
        Me.ComboPais_Sitio.Size = New System.Drawing.Size(154, 24)
        Me.ComboPais_Sitio.TabIndex = 17
        '
        'Limpiar_Sitio_Boton
        '
        Me.Limpiar_Sitio_Boton.Location = New System.Drawing.Point(558, 348)
        Me.Limpiar_Sitio_Boton.Name = "Limpiar_Sitio_Boton"
        Me.Limpiar_Sitio_Boton.Size = New System.Drawing.Size(104, 36)
        Me.Limpiar_Sitio_Boton.TabIndex = 16
        Me.Limpiar_Sitio_Boton.Text = "Limpiar"
        Me.Limpiar_Sitio_Boton.UseVisualStyleBackColor = True
        '
        'Eliminar_Sitio_Boton
        '
        Me.Eliminar_Sitio_Boton.Location = New System.Drawing.Point(358, 281)
        Me.Eliminar_Sitio_Boton.Name = "Eliminar_Sitio_Boton"
        Me.Eliminar_Sitio_Boton.Size = New System.Drawing.Size(104, 36)
        Me.Eliminar_Sitio_Boton.TabIndex = 12
        Me.Eliminar_Sitio_Boton.Text = "Eliminar"
        Me.Eliminar_Sitio_Boton.UseVisualStyleBackColor = True
        '
        'Actualizar_Sitio_Boton
        '
        Me.Actualizar_Sitio_Boton.Location = New System.Drawing.Point(358, 348)
        Me.Actualizar_Sitio_Boton.Name = "Actualizar_Sitio_Boton"
        Me.Actualizar_Sitio_Boton.Size = New System.Drawing.Size(104, 36)
        Me.Actualizar_Sitio_Boton.TabIndex = 11
        Me.Actualizar_Sitio_Boton.Text = "Actualizar"
        Me.Actualizar_Sitio_Boton.UseVisualStyleBackColor = True
        '
        'Añadir_Sitio_Boton
        '
        Me.Añadir_Sitio_Boton.Location = New System.Drawing.Point(558, 281)
        Me.Añadir_Sitio_Boton.Name = "Añadir_Sitio_Boton"
        Me.Añadir_Sitio_Boton.Size = New System.Drawing.Size(104, 36)
        Me.Añadir_Sitio_Boton.TabIndex = 9
        Me.Añadir_Sitio_Boton.Text = "Añadir"
        Me.Añadir_Sitio_Boton.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(371, 221)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 25)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Pais"
        '
        'Tipo
        '
        Me.Tipo.AutoSize = True
        Me.Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tipo.Location = New System.Drawing.Point(371, 157)
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Size = New System.Drawing.Size(51, 25)
        Me.Tipo.TabIndex = 5
        Me.Tipo.Text = "Tipo"
        '
        'nombre_sitio_text
        '
        Me.nombre_sitio_text.Location = New System.Drawing.Point(475, 101)
        Me.nombre_sitio_text.Name = "nombre_sitio_text"
        Me.nombre_sitio_text.Size = New System.Drawing.Size(154, 22)
        Me.nombre_sitio_text.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(367, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 25)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Nombre"
        '
        'id_sitio_text
        '
        Me.id_sitio_text.Location = New System.Drawing.Point(475, 45)
        Me.id_sitio_text.Name = "id_sitio_text"
        Me.id_sitio_text.ReadOnly = True
        Me.id_sitio_text.Size = New System.Drawing.Size(154, 22)
        Me.id_sitio_text.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(371, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 25)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "ID"
        '
        'ListSitios
        '
        Me.ListSitios.FormattingEnabled = True
        Me.ListSitios.ItemHeight = 16
        Me.ListSitios.Location = New System.Drawing.Point(3, 3)
        Me.ListSitios.Name = "ListSitios"
        Me.ListSitios.Size = New System.Drawing.Size(335, 372)
        Me.ListSitios.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.List_Rank_paises_concierto)
        Me.TabPage6.Controls.Add(Me.Mostrar_Ranking_Concierto)
        Me.TabPage6.Controls.Add(Me.Date_rank_fin)
        Me.TabPage6.Controls.Add(Me.Date_ranking_inicio)
        Me.TabPage6.Controls.Add(Me.List_rank_artista_concierto)
        Me.TabPage6.Controls.Add(Me.Limpiar_filtros_Boton)
        Me.TabPage6.Controls.Add(Me.Filtrar_Boton_Aritsta)
        Me.TabPage6.Controls.Add(Me.Filtrar_Boton_sitio)
        Me.TabPage6.Controls.Add(Me.ComboFiltrar_Artista)
        Me.TabPage6.Controls.Add(Me.ComboFiltrar_Sitio)
        Me.TabPage6.Controls.Add(Me.Label23)
        Me.TabPage6.Controls.Add(Me.Label22)
        Me.TabPage6.Controls.Add(Me.DateTimePicker_concierto)
        Me.TabPage6.Controls.Add(Me.Button_Limpiar_Setlist)
        Me.TabPage6.Controls.Add(Me.Button_Limpiar_Concierto)
        Me.TabPage6.Controls.Add(Me.Button_Actualizar_Setlist)
        Me.TabPage6.Controls.Add(Me.Button_eliminar_setlist)
        Me.TabPage6.Controls.Add(Me.Button_Añadir_Setlist)
        Me.TabPage6.Controls.Add(Me.text_orden_setlist)
        Me.TabPage6.Controls.Add(Me.Label21)
        Me.TabPage6.Controls.Add(Me.TextConcierto_setlist)
        Me.TabPage6.Controls.Add(Me.Label20)
        Me.TabPage6.Controls.Add(Me.TextCancion_Setlist)
        Me.TabPage6.Controls.Add(Me.Label19)
        Me.TabPage6.Controls.Add(Me.ListSetlist)
        Me.TabPage6.Controls.Add(Me.Button_Actualizar_concierto)
        Me.TabPage6.Controls.Add(Me.Button_Añadir_Concierto)
        Me.TabPage6.Controls.Add(Me.Button_eliminar_concierto)
        Me.TabPage6.Controls.Add(Me.Label18)
        Me.TabPage6.Controls.Add(Me.Text_sitio_concierto)
        Me.TabPage6.Controls.Add(Me.Text_artista_concierto)
        Me.TabPage6.Controls.Add(Me.Text_id_concierto)
        Me.TabPage6.Controls.Add(Me.Label17)
        Me.TabPage6.Controls.Add(Me.Label16)
        Me.TabPage6.Controls.Add(Me.ID)
        Me.TabPage6.Controls.Add(Me.ListConcierto)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1738, 479)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Concierto"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'List_Rank_paises_concierto
        '
        Me.List_Rank_paises_concierto.FormattingEnabled = True
        Me.List_Rank_paises_concierto.ItemHeight = 16
        Me.List_Rank_paises_concierto.Location = New System.Drawing.Point(1560, 3)
        Me.List_Rank_paises_concierto.Name = "List_Rank_paises_concierto"
        Me.List_Rank_paises_concierto.Size = New System.Drawing.Size(162, 340)
        Me.List_Rank_paises_concierto.TabIndex = 39
        '
        'Mostrar_Ranking_Concierto
        '
        Me.Mostrar_Ranking_Concierto.Location = New System.Drawing.Point(1418, 398)
        Me.Mostrar_Ranking_Concierto.Name = "Mostrar_Ranking_Concierto"
        Me.Mostrar_Ranking_Concierto.Size = New System.Drawing.Size(110, 64)
        Me.Mostrar_Ranking_Concierto.TabIndex = 38
        Me.Mostrar_Ranking_Concierto.Text = "Mostrar Ranking"
        Me.Mostrar_Ranking_Concierto.UseVisualStyleBackColor = True
        '
        'Date_rank_fin
        '
        Me.Date_rank_fin.Location = New System.Drawing.Point(1392, 227)
        Me.Date_rank_fin.Name = "Date_rank_fin"
        Me.Date_rank_fin.Size = New System.Drawing.Size(145, 22)
        Me.Date_rank_fin.TabIndex = 37
        '
        'Date_ranking_inicio
        '
        Me.Date_ranking_inicio.Location = New System.Drawing.Point(1392, 38)
        Me.Date_ranking_inicio.Name = "Date_ranking_inicio"
        Me.Date_ranking_inicio.Size = New System.Drawing.Size(145, 22)
        Me.Date_ranking_inicio.TabIndex = 36
        '
        'List_rank_artista_concierto
        '
        Me.List_rank_artista_concierto.FormattingEnabled = True
        Me.List_rank_artista_concierto.ItemHeight = 16
        Me.List_rank_artista_concierto.Location = New System.Drawing.Point(1220, 0)
        Me.List_rank_artista_concierto.Name = "List_rank_artista_concierto"
        Me.List_rank_artista_concierto.Size = New System.Drawing.Size(162, 340)
        Me.List_rank_artista_concierto.TabIndex = 35
        '
        'Limpiar_filtros_Boton
        '
        Me.Limpiar_filtros_Boton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Limpiar_filtros_Boton.Location = New System.Drawing.Point(605, 404)
        Me.Limpiar_filtros_Boton.Name = "Limpiar_filtros_Boton"
        Me.Limpiar_filtros_Boton.Size = New System.Drawing.Size(142, 58)
        Me.Limpiar_filtros_Boton.TabIndex = 34
        Me.Limpiar_filtros_Boton.Text = "Limpiar filtros"
        Me.Limpiar_filtros_Boton.UseVisualStyleBackColor = True
        '
        'Filtrar_Boton_Aritsta
        '
        Me.Filtrar_Boton_Aritsta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Filtrar_Boton_Aritsta.Location = New System.Drawing.Point(723, 327)
        Me.Filtrar_Boton_Aritsta.Name = "Filtrar_Boton_Aritsta"
        Me.Filtrar_Boton_Aritsta.Size = New System.Drawing.Size(147, 61)
        Me.Filtrar_Boton_Aritsta.TabIndex = 33
        Me.Filtrar_Boton_Aritsta.Text = "Filtrar Artista"
        Me.Filtrar_Boton_Aritsta.UseVisualStyleBackColor = True
        '
        'Filtrar_Boton_sitio
        '
        Me.Filtrar_Boton_sitio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Filtrar_Boton_sitio.Location = New System.Drawing.Point(479, 327)
        Me.Filtrar_Boton_sitio.Name = "Filtrar_Boton_sitio"
        Me.Filtrar_Boton_sitio.Size = New System.Drawing.Size(156, 61)
        Me.Filtrar_Boton_sitio.TabIndex = 31
        Me.Filtrar_Boton_sitio.Text = "Filtrar sitio"
        Me.Filtrar_Boton_sitio.UseVisualStyleBackColor = True
        '
        'ComboFiltrar_Artista
        '
        Me.ComboFiltrar_Artista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboFiltrar_Artista.FormattingEnabled = True
        Me.ComboFiltrar_Artista.Location = New System.Drawing.Point(677, 256)
        Me.ComboFiltrar_Artista.Name = "ComboFiltrar_Artista"
        Me.ComboFiltrar_Artista.Size = New System.Drawing.Size(121, 24)
        Me.ComboFiltrar_Artista.TabIndex = 30
        '
        'ComboFiltrar_Sitio
        '
        Me.ComboFiltrar_Sitio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboFiltrar_Sitio.FormattingEnabled = True
        Me.ComboFiltrar_Sitio.Location = New System.Drawing.Point(677, 24)
        Me.ComboFiltrar_Sitio.Name = "ComboFiltrar_Sitio"
        Me.ComboFiltrar_Sitio.Size = New System.Drawing.Size(121, 24)
        Me.ComboFiltrar_Sitio.TabIndex = 29
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(519, 253)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(147, 25)
        Me.Label23.TabIndex = 28
        Me.Label23.Text = "Filtar por Artista"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(536, 23)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(130, 25)
        Me.Label22.TabIndex = 27
        Me.Label22.Text = "Filtar por Sitio"
        '
        'DateTimePicker_concierto
        '
        Me.DateTimePicker_concierto.Location = New System.Drawing.Point(262, 298)
        Me.DateTimePicker_concierto.Name = "DateTimePicker_concierto"
        Me.DateTimePicker_concierto.Size = New System.Drawing.Size(145, 22)
        Me.DateTimePicker_concierto.TabIndex = 26
        '
        'Button_Limpiar_Setlist
        '
        Me.Button_Limpiar_Setlist.Location = New System.Drawing.Point(1061, 426)
        Me.Button_Limpiar_Setlist.Name = "Button_Limpiar_Setlist"
        Me.Button_Limpiar_Setlist.Size = New System.Drawing.Size(104, 36)
        Me.Button_Limpiar_Setlist.TabIndex = 25
        Me.Button_Limpiar_Setlist.Text = "Limpiar"
        Me.Button_Limpiar_Setlist.UseVisualStyleBackColor = True
        '
        'Button_Limpiar_Concierto
        '
        Me.Button_Limpiar_Concierto.Location = New System.Drawing.Point(167, 442)
        Me.Button_Limpiar_Concierto.Name = "Button_Limpiar_Concierto"
        Me.Button_Limpiar_Concierto.Size = New System.Drawing.Size(104, 36)
        Me.Button_Limpiar_Concierto.TabIndex = 24
        Me.Button_Limpiar_Concierto.Text = "Limpiar"
        Me.Button_Limpiar_Concierto.UseVisualStyleBackColor = True
        '
        'Button_Actualizar_Setlist
        '
        Me.Button_Actualizar_Setlist.Location = New System.Drawing.Point(910, 426)
        Me.Button_Actualizar_Setlist.Name = "Button_Actualizar_Setlist"
        Me.Button_Actualizar_Setlist.Size = New System.Drawing.Size(104, 36)
        Me.Button_Actualizar_Setlist.TabIndex = 23
        Me.Button_Actualizar_Setlist.Text = "Actualizar"
        Me.Button_Actualizar_Setlist.UseVisualStyleBackColor = True
        '
        'Button_eliminar_setlist
        '
        Me.Button_eliminar_setlist.Location = New System.Drawing.Point(1061, 362)
        Me.Button_eliminar_setlist.Name = "Button_eliminar_setlist"
        Me.Button_eliminar_setlist.Size = New System.Drawing.Size(104, 36)
        Me.Button_eliminar_setlist.TabIndex = 22
        Me.Button_eliminar_setlist.Text = "Eliminar"
        Me.Button_eliminar_setlist.UseVisualStyleBackColor = True
        '
        'Button_Añadir_Setlist
        '
        Me.Button_Añadir_Setlist.Location = New System.Drawing.Point(910, 362)
        Me.Button_Añadir_Setlist.Name = "Button_Añadir_Setlist"
        Me.Button_Añadir_Setlist.Size = New System.Drawing.Size(104, 36)
        Me.Button_Añadir_Setlist.TabIndex = 21
        Me.Button_Añadir_Setlist.Text = "Añadir"
        Me.Button_Añadir_Setlist.UseVisualStyleBackColor = True
        '
        'text_orden_setlist
        '
        Me.text_orden_setlist.Location = New System.Drawing.Point(830, 212)
        Me.text_orden_setlist.Name = "text_orden_setlist"
        Me.text_orden_setlist.Size = New System.Drawing.Size(107, 22)
        Me.text_orden_setlist.TabIndex = 20
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(852, 168)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 25)
        Me.Label21.TabIndex = 19
        Me.Label21.Text = "Orden"
        '
        'TextConcierto_setlist
        '
        Me.TextConcierto_setlist.Location = New System.Drawing.Point(830, 127)
        Me.TextConcierto_setlist.Name = "TextConcierto_setlist"
        Me.TextConcierto_setlist.Size = New System.Drawing.Size(107, 22)
        Me.TextConcierto_setlist.TabIndex = 18
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(841, 84)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 25)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "Concierto"
        '
        'TextCancion_Setlist
        '
        Me.TextCancion_Setlist.Location = New System.Drawing.Point(837, 38)
        Me.TextCancion_Setlist.Name = "TextCancion_Setlist"
        Me.TextCancion_Setlist.Size = New System.Drawing.Size(100, 22)
        Me.TextCancion_Setlist.TabIndex = 16
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(852, 10)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 25)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "Cancion"
        '
        'ListSetlist
        '
        Me.ListSetlist.FormattingEnabled = True
        Me.ListSetlist.ItemHeight = 16
        Me.ListSetlist.Location = New System.Drawing.Point(943, 0)
        Me.ListSetlist.Name = "ListSetlist"
        Me.ListSetlist.Size = New System.Drawing.Size(193, 340)
        Me.ListSetlist.TabIndex = 14
        '
        'Button_Actualizar_concierto
        '
        Me.Button_Actualizar_concierto.Location = New System.Drawing.Point(6, 442)
        Me.Button_Actualizar_concierto.Name = "Button_Actualizar_concierto"
        Me.Button_Actualizar_concierto.Size = New System.Drawing.Size(104, 36)
        Me.Button_Actualizar_concierto.TabIndex = 13
        Me.Button_Actualizar_concierto.Text = "Actualizar"
        Me.Button_Actualizar_concierto.UseVisualStyleBackColor = True
        '
        'Button_Añadir_Concierto
        '
        Me.Button_Añadir_Concierto.Location = New System.Drawing.Point(6, 384)
        Me.Button_Añadir_Concierto.Name = "Button_Añadir_Concierto"
        Me.Button_Añadir_Concierto.Size = New System.Drawing.Size(104, 36)
        Me.Button_Añadir_Concierto.TabIndex = 12
        Me.Button_Añadir_Concierto.Text = "Añadir"
        Me.Button_Añadir_Concierto.UseVisualStyleBackColor = True
        '
        'Button_eliminar_concierto
        '
        Me.Button_eliminar_concierto.Location = New System.Drawing.Point(167, 384)
        Me.Button_eliminar_concierto.Name = "Button_eliminar_concierto"
        Me.Button_eliminar_concierto.Size = New System.Drawing.Size(104, 36)
        Me.Button_eliminar_concierto.TabIndex = 11
        Me.Button_eliminar_concierto.Text = "Eliminar"
        Me.Button_eliminar_concierto.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(293, 266)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 29)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Fecha"
        '
        'Text_sitio_concierto
        '
        Me.Text_sitio_concierto.Location = New System.Drawing.Point(262, 229)
        Me.Text_sitio_concierto.Name = "Text_sitio_concierto"
        Me.Text_sitio_concierto.Size = New System.Drawing.Size(130, 22)
        Me.Text_sitio_concierto.TabIndex = 6
        '
        'Text_artista_concierto
        '
        Me.Text_artista_concierto.Location = New System.Drawing.Point(262, 144)
        Me.Text_artista_concierto.Name = "Text_artista_concierto"
        Me.Text_artista_concierto.Size = New System.Drawing.Size(130, 22)
        Me.Text_artista_concierto.TabIndex = 5
        '
        'Text_id_concierto
        '
        Me.Text_id_concierto.Location = New System.Drawing.Point(262, 55)
        Me.Text_id_concierto.Name = "Text_id_concierto"
        Me.Text_id_concierto.ReadOnly = True
        Me.Text_id_concierto.Size = New System.Drawing.Size(130, 22)
        Me.Text_id_concierto.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(294, 182)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 29)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Sitio"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(293, 98)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 29)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Artista"
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.Location = New System.Drawing.Point(313, 23)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(36, 29)
        Me.ID.TabIndex = 1
        Me.ID.Text = "ID"
        '
        'ListConcierto
        '
        Me.ListConcierto.FormattingEnabled = True
        Me.ListConcierto.ItemHeight = 16
        Me.ListConcierto.Location = New System.Drawing.Point(0, 6)
        Me.ListConcierto.Name = "ListConcierto"
        Me.ListConcierto.Size = New System.Drawing.Size(244, 372)
        Me.ListConcierto.TabIndex = 0
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.List_Ranking)
        Me.TabPage7.Location = New System.Drawing.Point(4, 25)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(1738, 479)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "TabPage7"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'List_Ranking
        '
        Me.List_Ranking.FormattingEnabled = True
        Me.List_Ranking.ItemHeight = 16
        Me.List_Ranking.Location = New System.Drawing.Point(0, 3)
        Me.List_Ranking.Name = "List_Ranking"
        Me.List_Ranking.Size = New System.Drawing.Size(394, 468)
        Me.List_Ranking.TabIndex = 0
        '
        'List_ranking_cancion2
        '
        Me.List_ranking_cancion2.FormattingEnabled = True
        Me.List_ranking_cancion2.ItemHeight = 16
        Me.List_ranking_cancion2.Location = New System.Drawing.Point(662, 6)
        Me.List_ranking_cancion2.Name = "List_ranking_cancion2"
        Me.List_ranking_cancion2.Size = New System.Drawing.Size(289, 372)
        Me.List_ranking_cancion2.TabIndex = 16
        '
        'Text_rank_albumcan_cancion
        '
        Me.Text_rank_albumcan_cancion.Location = New System.Drawing.Point(1112, 253)
        Me.Text_rank_albumcan_cancion.Name = "Text_rank_albumcan_cancion"
        Me.Text_rank_albumcan_cancion.Size = New System.Drawing.Size(129, 22)
        Me.Text_rank_albumcan_cancion.TabIndex = 26
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(978, 249)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(68, 25)
        Me.Label35.TabIndex = 25
        Me.Label35.Text = "Album"
        '
        'Text_rank_ordencan_cancion
        '
        Me.Text_rank_ordencan_cancion.Location = New System.Drawing.Point(1112, 188)
        Me.Text_rank_ordencan_cancion.Name = "Text_rank_ordencan_cancion"
        Me.Text_rank_ordencan_cancion.Size = New System.Drawing.Size(129, 22)
        Me.Text_rank_ordencan_cancion.TabIndex = 24
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(979, 184)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(67, 25)
        Me.Label36.TabIndex = 23
        Me.Label36.Text = "Orden"
        '
        'Text_rank_duracioncan_cancion
        '
        Me.Text_rank_duracioncan_cancion.Location = New System.Drawing.Point(1112, 129)
        Me.Text_rank_duracioncan_cancion.Name = "Text_rank_duracioncan_cancion"
        Me.Text_rank_duracioncan_cancion.Size = New System.Drawing.Size(129, 22)
        Me.Text_rank_duracioncan_cancion.TabIndex = 22
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(978, 125)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(90, 25)
        Me.Label37.TabIndex = 21
        Me.Label37.Text = "Duracion"
        '
        'Text_rank_nombrecan_cancion
        '
        Me.Text_rank_nombrecan_cancion.Location = New System.Drawing.Point(1112, 77)
        Me.Text_rank_nombrecan_cancion.Name = "Text_rank_nombrecan_cancion"
        Me.Text_rank_nombrecan_cancion.Size = New System.Drawing.Size(129, 22)
        Me.Text_rank_nombrecan_cancion.TabIndex = 20
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(978, 73)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(81, 25)
        Me.Label38.TabIndex = 19
        Me.Label38.Text = "Nombre"
        '
        'Text_id_cancion_rank_cancion
        '
        Me.Text_id_cancion_rank_cancion.Location = New System.Drawing.Point(1112, 31)
        Me.Text_id_cancion_rank_cancion.Name = "Text_id_cancion_rank_cancion"
        Me.Text_id_cancion_rank_cancion.ReadOnly = True
        Me.Text_id_cancion_rank_cancion.Size = New System.Drawing.Size(129, 22)
        Me.Text_id_cancion_rank_cancion.TabIndex = 18
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(999, 27)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(31, 25)
        Me.Label39.TabIndex = 17
        Me.Label39.Text = "ID"
        '
        'Butrron_rank_cancion
        '
        Me.Butrron_rank_cancion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butrron_rank_cancion.Location = New System.Drawing.Point(1012, 342)
        Me.Butrron_rank_cancion.Name = "Butrron_rank_cancion"
        Me.Butrron_rank_cancion.Size = New System.Drawing.Size(229, 88)
        Me.Butrron_rank_cancion.TabIndex = 27
        Me.Butrron_rank_cancion.Text = "Mostrar Canciones mas Interpretadas en Vivo"
        Me.Butrron_rank_cancion.UseVisualStyleBackColor = True
        '
        'frmCanciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1759, 624)
        Me.Controls.Add(Me.Artistas)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCanciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setlist"
        Me.Artistas.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Artistas As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents ListArtistas As ListBox
    Friend WithEvents TextID_Artista As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboPais_artista As ComboBox
    Friend WithEvents Pais As Label
    Friend WithEvents TextNombre_artista As TextBox
    Friend WithEvents ListPaises As ListBox
    Friend WithEvents TextId_Pais As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextPais As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ListAlbum As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents artista_album_text As TextBox
    Friend WithEvents año_album_text As TextBox
    Friend WithEvents id_album_text As TextBox
    Friend WithEvents nombre_album_text As TextBox
    Friend WithEvents duracion_cancion_text As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents nombre_cancion_text As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents id_cancion_text As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ListCanciones As ListBox
    Friend WithEvents album_cancion_text As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents orden_cancion_text As TextBox
    Friend WithEvents Orden As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ListSitios As ListBox
    Friend WithEvents Label14 As Label
    Friend WithEvents id_sitio_text As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Tipo As Label
    Friend WithEvents nombre_sitio_text As TextBox
    Friend WithEvents Eliminar_Boton As Button
    Friend WithEvents Actualizar_Boton As Button
    Friend WithEvents Añadir_Boton As Button
    Friend WithEvents Añadir_Boton_Pais As Button
    Friend WithEvents Añadir_Album_Boton As Button
    Friend WithEvents Añadir_Cancion_Boton As Button
    Friend WithEvents Añadir_Sitio_Boton As Button
    Friend WithEvents Actualizar_Boton_Pais As Button
    Friend WithEvents Actualizar_Album_Boton As Button
    Friend WithEvents Actualizar_Cancion_Boton As Button
    Friend WithEvents Actualizar_Sitio_Boton As Button
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents ID As Label
    Friend WithEvents ListConcierto As ListBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Text_sitio_concierto As TextBox
    Friend WithEvents Text_artista_concierto As TextBox
    Friend WithEvents Text_id_concierto As TextBox
    Friend WithEvents Eliminar_Boton_Pais As Button
    Friend WithEvents Eliminar_Album_Boton As Button
    Friend WithEvents Eliminar_Cancion_Album As Button
    Friend WithEvents Eliminar_Sitio_Boton As Button
    Friend WithEvents Button_Añadir_Concierto As Button
    Friend WithEvents Button_eliminar_concierto As Button
    Friend WithEvents Button_Actualizar_concierto As Button
    Friend WithEvents Limpiar_Artista_Boton As Button
    Friend WithEvents Limpiar_Pais_Boton As Button
    Friend WithEvents Limpiar_Album_Boton As Button
    Friend WithEvents Limpiar_Cancion_Boton As Button
    Friend WithEvents Limpiar_Sitio_Boton As Button
    Friend WithEvents ListSetlist As ListBox
    Friend WithEvents TextCancion_Setlist As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Button_Limpiar_Setlist As Button
    Friend WithEvents Button_Limpiar_Concierto As Button
    Friend WithEvents Button_Actualizar_Setlist As Button
    Friend WithEvents Button_eliminar_setlist As Button
    Friend WithEvents Button_Añadir_Setlist As Button
    Friend WithEvents text_orden_setlist As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TextConcierto_setlist As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents ComboPais_Sitio As ComboBox
    Friend WithEvents DateTimePicker_concierto As DateTimePicker
    Friend WithEvents ComboTipo_Sitio As ComboBox
    Friend WithEvents Filtrar_Boton_sitio As Button
    Friend WithEvents ComboFiltrar_Artista As ComboBox
    Friend WithEvents ComboFiltrar_Sitio As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Limpiar_filtros_Boton As Button
    Friend WithEvents Filtrar_Boton_Aritsta As Button
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents List_Ranking As ListBox
    Friend WithEvents Text_rank_album_cancion As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Text_rank_orden_cancion As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Text_rank_duracion_cancion As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Text_rank_nombre_cancion As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Text_rank_id_cancion As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents List_rank_canciones As ListBox
    Friend WithEvents Text_rank_artista_album As TextBox
    Friend WithEvents Text_rabk_año_album As TextBox
    Friend WithEvents Text_rank_id_album As TextBox
    Friend WithEvents Text_rank_nombre_album As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents List_Rank_Album As ListBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Date_rank_fin As DateTimePicker
    Friend WithEvents Date_ranking_inicio As DateTimePicker
    Friend WithEvents List_rank_artista_concierto As ListBox
    Friend WithEvents List_Rank_paises_concierto As ListBox
    Friend WithEvents Mostrar_Ranking_Concierto As Button
    Friend WithEvents List_ranking_cancion2 As ListBox
    Friend WithEvents Butrron_rank_cancion As Button
    Friend WithEvents Text_rank_albumcan_cancion As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Text_rank_ordencan_cancion As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Text_rank_duracioncan_cancion As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Text_rank_nombrecan_cancion As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Text_id_cancion_rank_cancion As TextBox
    Friend WithEvents Label39 As Label
End Class
