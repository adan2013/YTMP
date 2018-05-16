Public Class recoverymode

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If backupy Is Nothing Then
            MsgBox("Wykryto uszkodzenie pliku zarządzającego kopiami bezpieczeństwa. Spróbuj przywrócić je ręcznie za pomocą drugiej opcji...", MsgBoxStyle.Critical, "YTMP")
        Else
            If backupy.kopie.Count = 0 Then
                MsgBox("Kopie bezpieczeństwa były wyłączone lub doszło do uszkodzenia pliku zarządzającego kopiami bezpieczeństwa. Spróbuj przywrócić je ręcznie za pomocą drugiej opcji...", MsgBoxStyle.Critical, "YTMP")
            Else
                backuprestore.ShowDialog()
                backuprestore.Close()
            End If
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If IO.Directory.Exists(Application.StartupPath & "\backup") Then
            opendialog.InitialDirectory = Application.StartupPath & "\backup"
        Else
            MsgBox("Nie znaleziono katalogu ""backup""! Znajdź plik kopii samodzielnie...", MsgBoxStyle.Exclamation, "YTMP")
        End If
        opendialog.ShowDialog()
        If Not opendialog.FileName = "" AndAlso IO.File.Exists(opendialog.FileName) Then
            Dim fi As IO.FileInfo = New IO.FileInfo(opendialog.FileName)
            If MsgBox("Czy chcesz przywrócić dane z kopii o nazwie """ & fi.Name & """?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
                Try
                    If IO.File.Exists(Application.StartupPath & "\magazyn.ytmp") Then IO.File.Delete(Application.StartupPath & "\magazyn.ytmp")
                    IO.File.Copy(fi.FullName, Application.StartupPath & "\magazyn.ytmp")
                    MsgBox("Dane zostały przywrócone, nastąpi zamknięcie aplikacji. Uruchom ją ponownie...", MsgBoxStyle.Information, "YTMP")
                    End
                Catch ex As Exception
                    MsgBox("Wystąpił błąd podczas przywracania danych! Zamknij aplikację i spróbuj ręcznie podmienić wskazany plik z plikiem ""magazyn.ytmp""! Uwaga: nazwa musi być zmieniona na ""magazyn""!", MsgBoxStyle.Critical, "YTMP")
                End Try
            End If
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If MsgBox("Czy na pewno przywrócić ustawienia fabryczne?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
            Try
                If IO.File.Exists(Application.StartupPath & "\magazyn.ytmp") Then IO.File.Delete(Application.StartupPath & "\magazyn.ytmp")
                If IO.File.Exists(Application.StartupPath & "\kopie.backup") Then IO.File.Delete(Application.StartupPath & "\kopie.backup")
                MsgBox("Dane zostały usunięte, nastąpi zamknięcie aplikacji. Uruchom ją ponownie...", MsgBoxStyle.Information, "YTMP")
                End
            Catch ex As Exception
                MsgBox("Wystąpił błąd podczas przywracania ustawień! Zamknij aplikację i spróbuj ręcznie usunąć pliki ""magazyn.ytmp"" oraz ""kopie.backup"" z katalogu głównego aplikacji!", MsgBoxStyle.Critical, "YTMP")
            End Try
        End If
    End Sub

    Private Sub recoverymode_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
End Class