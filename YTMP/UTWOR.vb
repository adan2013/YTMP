<Serializable()>
Public Class UTWOR

    Public tytul As String = ""
    Public link As String = ""

    Public start As Integer = 0
    Public koniec As Integer = 0

    Public FKalbum As ALBUM

    Public Sub New(ByVal tytulutworu As String, ByVal linkyt As String, ByRef doalbumu As ALBUM, ByVal uststart As Integer, ByVal ustkoniec As Integer)
        tytul = tytulutworu
        link = linkyt
        start = uststart
        koniec = ustkoniec
        FKalbum = doalbumu
        FKalbum.dodajdoalbumu(Me)
    End Sub

    Public Sub usunmnie()
        If odtwarzane.utwory.Contains(Me) Or Form1.yt.directplay Is Me Then
            MsgBox("Utwór znajduje się na liście odtwarzania lub jest aktualnie odtwarzany i nie może zostać usunięty!", MsgBoxStyle.Exclamation, "YTMP")
        Else
            For Each pl As PLAYLISTA In dane.playlisty
                pl.utwory.Remove(Me)
            Next
            FKalbum.usunzalbumu(Me)
        End If
    End Sub

    Public Sub przeniesdo(ByVal obiektalbumu As ALBUM)
        FKalbum.usunzalbumu(Me)
        FKalbum = obiektalbumu
        FKalbum.dodajdoalbumu(Me)
    End Sub
End Class
