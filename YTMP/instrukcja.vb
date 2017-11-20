Public Class instrukcja

    Dim ok As Boolean = False

    Private Sub instrukcja_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not ok Then End
    End Sub

    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        ok = True
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnpdf_Click(sender As Object, e As EventArgs) Handles btnpdf.Click
        Try
            If IO.File.Exists(Application.StartupPath & "\instrukcja.pdf") Then
                Process.Start(Application.StartupPath & "\instrukcja.pdf")
            Else
                MsgBox("Nie znaleziono pliku z instrukcją! Możliwe że został on przeniesiony lub usunięty z komputera!", MsgBoxStyle.Exclamation, "YTMP")
            End If
        Catch ex As Exception
            MsgBox("Wystąpił błąd podczas próby otwarcia pliku PDF!", MsgBoxStyle.Exclamation, "YTMP")
        End Try
    End Sub

    Private Sub instrukcja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlbtn.Location = New Point(Size.Width / 2 - pnlbtn.Size.Width / 2, pnlbtn.Location.Y)
    End Sub
End Class