<Serializable()>
Public Class MAGAZYN

    Public wykonawcy As List(Of WYKONAWCA) = New List(Of WYKONAWCA)
    Public playlisty As List(Of PLAYLISTA) = New List(Of PLAYLISTA)

    Public skroty As List(Of KLAWISZE) = New List(Of KLAWISZE)
    Public SETmultimediakeys As Boolean = True
    Public SETkopie As Boolean = False
    Public SETnakoncu As Boolean = True
    Public SETdymek As Boolean = False
    Public SETprzejscie As Boolean = False
    Public SETczas As Boolean = False
    Public SEThide As Boolean = False
    Public SETopoznienie As Integer = 0
    Public SEThidealbums As Boolean = False
    Public SETq As Byte = 2

    Public volume As SByte = 100
    Public MODrep As Boolean = False
    Public MODran As Boolean = False
    Public MODmute As Boolean = False

    Public Sub New()
        wykonawcy.Add(New WYKONAWCA("", True))
        skroty.Clear()
        skroty.Add(New KLAWISZE("play/pause"))
        skroty.Add(New KLAWISZE("poprzedni utwór"))
        skroty.Add(New KLAWISZE("następny utwór"))
        skroty.Add(New KLAWISZE("wycisz/odcisz"))
        skroty.Add(New KLAWISZE("zmniejsz głośność"))
        skroty.Add(New KLAWISZE("zwiększ głośność"))
    End Sub

    Public Sub dodajwykonawce(ByVal obiekt As WYKONAWCA)
        wykonawcy.Add(obiekt)
    End Sub

    Public Sub usunwykonawce(ByRef obiekt As WYKONAWCA)
        If obiekt.brakpozycji Then
            MsgBox("Nie można usunąć domyślnej pozycji!", MsgBoxStyle.Information, "YTMP")
            Exit Sub
        End If
        For i As Integer = 0 To wykonawcy.Count - 1 Step 1
            If wykonawcy(i) Is obiekt Then
                wykonawcy.RemoveAt(i)
                Exit Sub
            End If
        Next
    End Sub
End Class
