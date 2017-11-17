<Serializable()>
Public Class WYKONAWCA

    Public ReadOnly brakpozycji As Boolean = False
    Public nazwa As String = ""

    Public albumy As List(Of ALBUM) = New List(Of ALBUM)

    Public Sub New(ByVal nazwawykonawcy As String, Optional pozycjabraku As Boolean = False)
        If pozycjabraku Then
            brakpozycji = True
            nazwa = "(brak wykonawcy)"
        Else
            nazwa = nazwawykonawcy
        End If
        Dim defaultalb As ALBUM = New ALBUM("", Me, True)
    End Sub

    Public Sub dodajdowykonawcy(ByVal obiekt As ALBUM)
        albumy.Add(obiekt)
        obiekt.FKwykonawca = Me
    End Sub

    Public Sub usunmnie()
        If brakpozycji Then
            MsgBox("Nie można usunąć domyślnej pozycji!", MsgBoxStyle.Information, "YTMP")
        Else
            dane.wykonawcy.Remove(Me)
        End If
    End Sub

    Public Sub usunzwykonawcy(ByRef obiekt As ALBUM)
        If obiekt.brakpozycji Then
            MsgBox("Nie można usunąć domyślnej pozycji!", MsgBoxStyle.Information, "YTMP")
            Exit Sub
        End If
        For i As Integer = 0 To albumy.Count - 1 Step 1
            If albumy(i) Is obiekt Then
                albumy.RemoveAt(i)
                Exit Sub
            End If
        Next
    End Sub
End Class
