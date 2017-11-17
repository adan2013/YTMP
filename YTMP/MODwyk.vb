Public Class MODwyk

    Dim domodyfikacji As WYKONAWCA = Nothing

    Public Sub modyfikuj(ByRef obiekt As WYKONAWCA)
        domodyfikacji = obiekt
        Text = "Edycja wykonawcy"
        btnok.Text = "Zmień"
        txtname.Text = domodyfikacji.nazwa
    End Sub

    Private Sub MODwyk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtname.Focus()
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If txtname.Text.Trim() = "" Then
            MsgBox("Nie podano nazwy wykonawcy!", MsgBoxStyle.Exclamation, "YTMP")
            Exit Sub
        End If
        If domodyfikacji Is Nothing Then
            Dim nowy As WYKONAWCA = New WYKONAWCA(txtname.Text.Trim())
            dane.wykonawcy.Add(nowy)
            If dane.SETprzejscie Then
                Form1.PATHwyk = nowy
            Else
                Form1.PATHwyk = Nothing
                Form1.PATHalb = Nothing
            End If
        Else
            domodyfikacji.nazwa = txtname.Text.Trim()
        End If
        DialogResult = DialogResult.OK
    End Sub

    Private Sub txtname_KeyUp(sender As Object, e As KeyEventArgs) Handles txtname.KeyUp
        If e.KeyCode = Keys.Enter Then btnok_Click(btnok, New EventArgs())
    End Sub
End Class