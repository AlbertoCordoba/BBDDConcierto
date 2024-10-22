Public Class setlist
    Public Property concierto As Concierto
    Public Property Cancion As Cancion
    Public Property ordenSetlist As Integer
    Public Sub New()

    End Sub

    Public Sub New(cancion As Integer)
        Me.Cancion = New Cancion(cancion)
    End Sub

End Class
