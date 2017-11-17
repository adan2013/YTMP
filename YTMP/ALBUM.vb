<Serializable()>
Public Class ALBUM

    Public ReadOnly brakpozycji As Boolean = False
    Public nazwa As String = ""

    Public utwory As List(Of UTWOR) = New List(Of UTWOR)
    Public FKwykonawca As WYKONAWCA

    Public Sub New(ByVal nazwaalbumu As String, ByRef dowykonawcy As WYKONAWCA, Optional pozycjabraku As Boolean = False)
        If pozycjabraku Then
            brakpozycji = True
            nazwa = "(brak albumu)"
        Else
            nazwa = nazwaalbumu
        End If
        FKwykonawca = dowykonawcy
        FKwykonawca.dodajdowykonawcy(Me)
    End Sub

    Public Sub dodajdoalbumu(ByVal obiekt As UTWOR)
        If dane.SETnakoncu Then utwory.Add(obiekt) Else utwory.Insert(0, obiekt)
        obiekt.FKalbum = Me
    End Sub

    Public Sub usunmnie()
        FKwykonawca.usunzwykonawcy(Me)
    End Sub

    Public Sub przeniesdo(ByVal obiektwykonawcy As WYKONAWCA)
        FKwykonawca.usunzwykonawcy(Me)
        FKwykonawca = obiektwykonawcy
        FKwykonawca.dodajdowykonawcy(Me)
    End Sub

    Public Sub usunzalbumu(ByRef obiekt As UTWOR)
        For i As Integer = 0 To utwory.Count - 1 Step 1
            If utwory(i) Is obiekt Then
                utwory.RemoveAt(i)
                Exit Sub
            End If
        Next
    End Sub
End Class
