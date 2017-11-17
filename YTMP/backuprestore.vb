Public Class backuprestore

    Dim REFpoz As List(Of BACKUP.strBACKUP) = New List(Of BACKUP.strBACKUP)

    Private Sub backuprestore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REFpoz.AddRange(backupy.kopie)
        For Each i As BACKUP.strBACKUP In REFpoz
            lst.Items.Add(Format(i.data, "HH:mm dd-MM-yyyy"))
        Next
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If lst.SelectedIndex < 0 Then
            MsgBox("Najpierw wybierz którą kopię bezpieczeństwa chcesz przywrócić!", MsgBoxStyle.Information, "YTMP")
        Else
            If MsgBox("Czy na pewno chcesz przywrócić dane z kopii bezpieczeństwa?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
                backupy.przywroc(REFpoz(lst.SelectedIndex))
            End If
        End If
    End Sub
End Class