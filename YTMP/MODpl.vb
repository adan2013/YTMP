Public Class MODpl

    Dim domodyfikacji As PLAYLISTA = Nothing

    Public Sub modyfikuj(ByRef obiekt As PLAYLISTA)
        domodyfikacji = obiekt
        Text = "Edycja playlisty"
        btnok.Text = "Zmień"
        btndodaj.Visible = True
        txtname.Text = domodyfikacji.nazwa
    End Sub

    Private Sub MODpl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtname.Focus()
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If txtname.Text.Trim() = "" Then
            MsgBox("Nie podano nazwy playlisty!", MsgBoxStyle.Exclamation, "YTMP")
            Exit Sub
        End If
        If domodyfikacji Is Nothing Then
            Dim nowy As PLAYLISTA = New PLAYLISTA(txtname.Text.Trim())
            nowy.utwory.AddRange(odtwarzane.utwory)
            dane.playlisty.Add(nowy)
            If dane.SETprzejscie Then Form1.PATHpl = nowy
        Else
            domodyfikacji.nazwa = txtname.Text.Trim()
        End If
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btndodaj_Click(sender As Object, e As EventArgs) Handles btndodaj.Click
        If odtwarzane.utwory.Count > 0 Then
            For Each i As UTWOR In odtwarzane.utwory
                domodyfikacji.dodajutwor(i)
            Next
            MsgBox("Utwory z listy odtwarzania zostały pomyślnie dodane do playlisty!", MsgBoxStyle.Information, "YTMP")
        Else
            MsgBox("Lista odtwarzania nie zawiera utworów do dodania!", MsgBoxStyle.Information, "YTMP")
        End If
    End Sub

    Private Sub txtname_KeyUp(sender As Object, e As KeyEventArgs) Handles txtname.KeyUp
        If e.KeyCode = Keys.Enter Then btnok_Click(btnok, New EventArgs())
    End Sub
End Class