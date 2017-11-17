Public Class MODpozycja

    Public wynik As Integer

    Public Sub ustaw(ByVal maxvalue As Integer, ByVal currentvalue As Integer)
        wynik = currentvalue
        listanr.Items.Clear()
        For i As Integer = 1 To maxvalue Step 1
            listanr.Items.Add(i)
        Next
        listanr.SelectedIndex = currentvalue
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        wynik = listanr.SelectedIndex
        DialogResult = DialogResult.OK
    End Sub
End Class