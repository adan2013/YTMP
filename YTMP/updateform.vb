Public Class updateform

    Private Sub btnlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnlink.LinkClicked
        Try
            Process.Start("https://github.com/adan2013/YTMP/releases")
        Catch ex As Exception
            MsgBox("Wystąpił błąd podczas uruchamiania przeglądarki internetowej!", MsgBoxStyle.Critical, "YTMP")
        End Try
    End Sub
End Class