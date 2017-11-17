<Serializable()>
Public Class PLAYLISTA

    Public nazwa As String = ""

    Public utwory As List(Of UTWOR) = New List(Of UTWOR)

    Public Sub New(ByVal nazwaplaylisty As String)
        nazwa = nazwaplaylisty
    End Sub

    Public Sub dodajutwor(ByVal obiekt As UTWOR)
        If Not utwory.Contains(obiekt) Then
            If dane.SETnakoncu Then utwory.Add(obiekt) Else utwory.Insert(0, obiekt)
        End If
    End Sub

    Public Sub usunutwor(ByVal obiekt As UTWOR)
        utwory.Remove(obiekt)
    End Sub

    Public Sub wyczyscliste()
        utwory.Clear()
    End Sub
End Class
