Public Class hisutw

    Private Sub hisutw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lsthis.Items.Clear()
        For Each i As UTWOR In Form1.yt.hisodtw
            lsthis.Items.Add(i.tytul & " - " & i.FKalbum.FKwykonawca.nazwa)
        Next
        If lsthis.Items.Count > 0 Then lsthis.SelectedIndex = lsthis.Items.Count - 1
    End Sub
End Class