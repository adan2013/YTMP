<Serializable()>
Public Class MAGAZYN

    Public wykonawcy As List(Of WYKONAWCA) = New List(Of WYKONAWCA)
    Public playlisty As List(Of PLAYLISTA) = New List(Of PLAYLISTA)

    Public skroty As List(Of KLAWISZE) = New List(Of KLAWISZE)
    Public SETmultimediakeys As Boolean = True
    Public SETkopie As Boolean = False
    Public SETnakoncu As Boolean = True
    Public SETdymek As Boolean = False
    Public SETdymekfocus As Boolean = False
    Public SETprzejscie As Boolean = False
    Public SETczas As Boolean = False
    Public SEThide As Boolean = False
    Public SETopoznienie As Integer = 0
    Public SEThidealbums As Boolean = False
    Public SETdefaulttab As Byte = 0
    Public SETshowtitlewindow As Boolean = False
    Public SETsearchW As Boolean = True
    Public SETsearchA As Boolean = False
    Public SETsearchID As Boolean = False
    Public SETzielbufor As Boolean = False
    Public SETkolorprogress As Byte = 0
    Public SETkolorpause As Byte = 0
    Public SETpilotact As Byte = 0
    Public SETpilotmode As Byte = 0
    Public SETpilotX As Integer = 0
    Public SETpilotY As Integer = 0

    Public volume As SByte = 100
    Public MODrep As Boolean = False
    Public MODran As Boolean = False
    Public MODmute As Boolean = False

    Public Sub New()
        wykonawcy.Add(New WYKONAWCA("", True))
        skroty.Clear()
    End Sub

    Public Sub ladujklawisze()
        addklawisze("play/pause")
        addklawisze("poprzedni utwór")
        addklawisze("następny utwór")
        addklawisze("wycisz/odcisz")
        addklawisze("zmniejsz głośność")
        addklawisze("zwiększ głośność")
        addklawisze("przewiń do początku")
    End Sub

    Private Sub addklawisze(ByVal nazwa As String)
        Dim ist As Boolean = False
        For Each i As KLAWISZE In skroty
            If i.nazwa = nazwa Then
                ist = True
                Exit For
            End If
        Next
        If Not ist Then skroty.Add(New KLAWISZE(nazwa))
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
