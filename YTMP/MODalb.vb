Public Class MODalb

    Dim docelowyWYK As WYKONAWCA = Nothing

    Dim domodyfikacji As ALBUM = Nothing

    Public Sub modyfikuj(ByRef obiekt As ALBUM)
        domodyfikacji = obiekt
        docelowyWYK = domodyfikacji.FKwykonawca
        Text = "Edycja albumu"
        btnok.Text = "Zmień"
        lblwyk.Text = "> " & docelowyWYK.nazwa & " > ..."
        txtname.Text = domodyfikacji.nazwa
    End Sub

    Public Sub zablokujprzynaleznosc(ByRef docWYK As WYKONAWCA)
        docelowyWYK = docWYK
        lblwyk.Text = "> " & docelowyWYK.nazwa & " > ..."
        btnwyk.Enabled = False
    End Sub

    Private Sub MODalb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtname.Focus()
        If domodyfikacji Is Nothing And btnwyk.Enabled Then
            If Form1.PATHwyk Is Nothing Then
                For Each w As WYKONAWCA In dane.wykonawcy
                    If w.brakpozycji Then
                        docelowyWYK = w
                        Exit For
                    End If
                Next
            Else
                docelowyWYK = Form1.PATHwyk
            End If
            lblwyk.Text = "> " & docelowyWYK.nazwa & " > ..."
        End If
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If txtname.Text.Trim() = "" Then
            MsgBox("Nie podano nazwy albumu!", MsgBoxStyle.Exclamation, "YTMP")
            Exit Sub
        End If
        If domodyfikacji Is Nothing Then
            Dim nowy As ALBUM = New ALBUM(txtname.Text.Trim(), docelowyWYK)
            Form1.PATHwyk = docelowyWYK
            If dane.SETprzejscie Then Form1.PATHalb = nowy
        Else
            domodyfikacji.nazwa = txtname.Text.Trim()
        End If
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnwyk_Click(sender As Object, e As EventArgs) Handles btnwyk.Click
        selectform.laduj(Nothing, dane, True)
        If selectform.wynik IsNot Nothing Then
            docelowyWYK = selectform.wynik
            lblwyk.Text = "> " & docelowyWYK.nazwa & " > ..."
        End If
        If domodyfikacji IsNot Nothing Then
            domodyfikacji.usunmnie()
            docelowyWYK.dodajdowykonawcy(domodyfikacji)
        End If
        selectform.Close()
    End Sub

    Private Sub txtname_KeyUp(sender As Object, e As KeyEventArgs) Handles txtname.KeyUp
        If e.KeyCode = Keys.Enter Then btnok_Click(btnok, New EventArgs())
    End Sub
End Class