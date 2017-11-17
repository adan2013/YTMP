Public Class instrukcja

    Const max As SByte = 10
    Dim current As SByte = 0
    Dim pomin As Boolean = False

    Private Sub instrukcja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        laduj(current)
    End Sub

    Private Sub laduj(ByVal nr As SByte)
        current = nr
        If current < 0 Then current = 0
        If current > max Then current = max
        If current > 0 Then btnprev.Enabled = True Else btnprev.Enabled = False
        If current < max Then btnnext.Text = "Dalej   >" Else btnnext.Text = "Zakończ"
        Select Case current
            Case 0
                lbltytul.Text = "Wprowadzenie"
                lblopis.Text = "Witam w programie YouTube Media Player," & vbNewLine & "wprowadzenie ma na celu zaznajomić Cię" & vbNewLine & "z obsługą tej aplikacji. Jeśli chcesz możesz" & vbNewLine & "pominąć go przyciskiem po lewej..."
                img.Image = My.Resources.INS0
            Case 1
                lbltytul.Text = "Strumieniuj muzykę z YouTube!"
                lblopis.Text = "Program umożliwia łatwe odtwarzanie muzyki" & vbNewLine & "pobieranej na żywo z serwisu YouTube"
                img.Image = My.Resources.INS1
            Case 2
                lbltytul.Text = "Główne okno aplikacji"
                lblopis.Text = "U góry okna aplikacji widoczne są trzy karty:" & vbNewLine & "1.Lista odtwarzania - aktualnie używana" & vbNewLine & "lista utworów" & vbNewLine & "2.Utwory - zawartość biblioteki utworów" & vbNewLine & "pogrupowana na wykonawców i albumy" & vbNewLine & "3.Playlisty - wszystkie zapisane listy utworów" & vbNewLine & "stworzonych przez użytkownika" & vbNewLine & vbNewLine & "Obok kart znajduje się także wyszukiwarka" & vbNewLine & "do znajdywania pozycji"
                img.Image = My.Resources.INS2
            Case 3
                lbltytul.Text = "Wybór utworów"
                lblopis.Text = "W karcie ""Utwory"" można znaleźć zapisane" & vbNewLine & "przez siebie utwory pogrupowane najpierw" & vbNewLine & "wg. wykonawców, a następnie wg. albumów" & vbNewLine & "Kliknięcie na pozycje powoduje przejście" & vbNewLine & "do danej kategorii lub szybkie odtworzenie" & vbNewLine & "utworu bez dodawania go do listy odtwarzania." & vbNewLine & "Zielony plus przy pozycji umożliwia dodanie" & vbNewLine & "utworu do listy odtwarzania. Edycję i zmiane" & vbNewLine & "pozycji w albumie umożliwia przycisk" & vbNewLine & "z ołówkiem. W każdej chwili możesz użyć" & vbNewLine & "przycisku Odtwórz wszystkie, który dodaje" & vbNewLine & "wszystkie wyświetlane elementy do listy" & vbNewLine & "odtwarzania i elementy podrzędne"
                img.Image = My.Resources.INS3
            Case 4
                lbltytul.Text = "Sterowanie odtwarzaniem"
                lblopis.Text = "Podczas odtwarzania utworu możesz:" & vbNewLine & "-zatrzymywać i wznawiać odtwarzanie" & vbNewLine & "-przełączać się między utworami strzałkami" & vbNewLine & "-przewijać utwór do konkretnej sekundy" & vbNewLine & "-zmieniać głośność lub wyciszyć utwór" & vbNewLine & "-włączyć powtarzanie utworu" & vbNewLine & "-włączyć odtwarzanie losowe"
                img.Image = My.Resources.INS4
            Case 5
                lbltytul.Text = "Dodawanie utworów"
                lblopis.Text = "Do dodawania nowych utworów do biblioteki" & vbNewLine & "służy przycisk plusa w karcie ""Utwory""." & vbNewLine & "W oknie należy podać:" & vbNewLine & "-tytuł utworu" & vbNewLine & "-link do filmiku w serwisie YouTube" & vbNewLine & "-opcjonalnie: początek i koniec utworu"
                img.Image = My.Resources.INS5
            Case 6
                lbltytul.Text = "Zarządzanie listą odtwarzania"
                lblopis.Text = "Usunięcie utworu z listy odtwarzania nie" & vbNewLine & "powoduje jego usunięcia z biblioteki, tak samo" & vbNewLine & "jest ze zmianą pozycji na liście, nie zmienia" & vbNewLine & "ona pozycji w albumie. Przycisk folderu" & vbNewLine & "umożliwia przejście do utworu w bibliotece"
                img.Image = My.Resources.INS6
            Case 7
                lbltytul.Text = "Tworzenie własnych playlist"
                lblopis.Text = "Nową playlistę tworzy się na podstawie" & vbNewLine & "zawartości listy odtwarzania, jeśli jest ona" & vbNewLine & "pusta to playlista nie może zostać utworzona." & vbNewLine & "Późniejsze dodanie utworów do playlisty" & vbNewLine & "umożliwia okno edycji"
                img.Image = My.Resources.INS7
            Case 8
                lbltytul.Text = "Ustawienia aplikacji"
                lblopis.Text = "Aby spersonalizować aplikację odwiedź okno" & vbNewLine & "jej ustawień. Oto niektóre z opcji:" & vbNewLine & "-dodawanie pauzy między utworami" & vbNewLine & "-informacja o odtwarzanym utworze" & vbNewLine & "-ukrycie okna po minimalizacji" & vbNewLine & "-sterowanie odtwarzaczem za pomocą skrótów" & vbNewLine & "-tworzenie kopii bezpieczeństwa biblioteki"
                img.Image = My.Resources.INS8
            Case 9
                lbltytul.Text = "Udostępnianie bibliotek"
                lblopis.Text = "Wymieniaj się z innymi swoimi utworami!" & vbNewLine & "W oknie ustawień znajdziesz opcje" & vbNewLine & "pozwalające na swobodny zapis i odczyt" & vbNewLine & "utworów z zewnętrznych plików. Możesz" & vbNewLine & "udostępniać całość biblioteki lub tylko" & vbNewLine & "konkretnego wykonawce czy album!"
                img.Image = My.Resources.INS9
            Case 10
                lbltytul.Text = "Zaczynamy!"
                lblopis.Text = "To już koniec wprowadzenia do obsługi" & vbNewLine & "programu YouTube Media Player." & vbNewLine & "Dziękuję za używanie mojej aplikacji!"
                img.Image = My.Resources.ok_appproval_acceptance
        End Select
    End Sub

    Private Sub btnskip_Click(sender As Object, e As EventArgs) Handles btnskip.Click
        Close()
    End Sub

    Private Sub btnprev_Click(sender As Object, e As EventArgs) Handles btnprev.Click
        laduj(current - 1)
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        If current < max Then
            laduj(current + 1)
        Else
            pomin = True
            Close()
        End If
    End Sub

    Private Sub instrukcja_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not pomin AndAlso Not MsgBox("Pominąć wprowadzenie?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then e.Cancel = True
    End Sub
End Class