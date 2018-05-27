Public Class MODutw

    Public docelowyWYK As WYKONAWCA = Nothing
    Public docelowyALB As ALBUM = Nothing

    Dim domodyfikacji As UTWOR = Nothing
    Public newutw As UTWOR = Nothing
    Public predefwykalb As Boolean = False

    Public Sub modyfikuj(ByRef obiekt As UTWOR)
        domodyfikacji = obiekt
        docelowyWYK = domodyfikacji.FKalbum.FKwykonawca
        docelowyALB = domodyfikacji.FKalbum
        Text = "Edycja utworu"
        btnok.Text = "Zmień"
        btnzmienid.Visible = True
        btnpozycja.Visible = True
        btnyt.Visible = True
        txtname.Text = domodyfikacji.tytul
        lblid.Text = domodyfikacji.link
        If domodyfikacji.start > 0 Then
            chkboxstart.Checked = False
            nrstartm.Value = domodyfikacji.start \ 60
            nrstarts.Value = domodyfikacji.start Mod 60
        End If
        If domodyfikacji.koniec > 0 Then
            chkboxkoniec.Checked = False
            nrkoniecm.Value = domodyfikacji.koniec \ 60
            nrkoniecs.Value = domodyfikacji.koniec Mod 60
        End If
        aktpath()
    End Sub

    Private Sub MODutw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtname.Focus()
        If domodyfikacji Is Nothing Then
            If Not predefwykalb Then
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
                If Form1.PATHalb Is Nothing Then
                    For Each a As ALBUM In docelowyWYK.albumy
                        If a.brakpozycji Then
                            docelowyALB = a
                            Exit For
                        End If
                    Next
                Else
                    docelowyALB = Form1.PATHalb
                End If
            End If
            aktpath()
        End If
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If txtname.Text.Trim() = "" Then
            MsgBox("Nie podano tytułu utworu!", MsgBoxStyle.Exclamation, "YTMP")
            Exit Sub
        End If
        If lblid.Text = "Nie przypisano" Then
            MsgBox("Nie podano identyfikatora filmu YouTube!", MsgBoxStyle.Exclamation, "YTMP")
            Exit Sub
        End If
        If Not chkboxkoniec.Checked Then
            If nrkoniecm.Value * 60 + nrkoniecs.Value < 10 Then
                MsgBox("Czas końca odtwarzania musi mieć minimum 10 sekund!", MsgBoxStyle.Exclamation, "YTMP")
                Exit Sub
            End If
        End If
        If Not chkboxstart.Checked And Not chkboxkoniec.Checked Then
            If nrstartm.Value * 60 + nrstarts.Value + 10 > nrkoniecm.Value * 60 + nrkoniecs.Value Then
                MsgBox("Czas początku musi być mniejszy niż czas końca i posiadać minimum 10 sekund różnicy!", MsgBoxStyle.Exclamation, "YTMP")
                Exit Sub
            End If
        End If
        If domodyfikacji Is Nothing Then
            newutw = New UTWOR(txtname.Text.Trim(), lblid.Text, docelowyALB, IIf(chkboxstart.Checked, 0, nrstartm.Value * 60 + nrstarts.Value), IIf(chkboxkoniec.Checked, 0, nrkoniecm.Value * 60 + nrkoniecs.Value))
        Else
            domodyfikacji.tytul = txtname.Text.Trim()
            domodyfikacji.link = lblid.Text
            If chkboxstart.Checked Then domodyfikacji.start = 0 Else domodyfikacji.start = nrstartm.Value * 60 + nrstarts.Value
            If chkboxkoniec.Checked Then domodyfikacji.koniec = 0 Else domodyfikacji.koniec = nrkoniecm.Value * 60 + nrkoniecs.Value
        End If
        Form1.ladujpanel()
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnpozycja_Click(sender As Object, e As EventArgs) Handles btnpozycja.Click
        'TODO zmiana pozycji brak refpoz
        'Dim nr As Integer = 0
        'For Each i As UTWOR In Form1.PATHalb.utwory
        '    If i Is domodyfikacji Then Exit For
        '    nr += 1
        'Next
        'MODpozycja.ustaw(Form1.REFpoz.Count, nr)
        'MODpozycja.ShowDialog()
        'Form1.PATHalb.usunzalbumu(domodyfikacji)
        'Form1.PATHalb.utwory.Insert(MODpozycja.wynik, domodyfikacji)
        'MODpozycja.Close()
    End Sub

    Private Sub chkboxstart_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxstart.CheckedChanged
        nrstartm.Enabled = Not sender.Checked
        nrstarts.Enabled = Not sender.Checked
    End Sub

    Private Sub chkboxkoniec_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxkoniec.CheckedChanged
        nrkoniecm.Enabled = Not sender.Checked
        nrkoniecs.Enabled = Not sender.Checked
    End Sub

    Private Sub przenies()
        If domodyfikacji IsNot Nothing Then
            domodyfikacji.usunmnie()
            docelowyALB.dodajdoalbumu(domodyfikacji)
        End If
    End Sub

    Private Sub aktpath()
        lblpath.Text = "> " & docelowyWYK.nazwa & " > " & docelowyALB.nazwa & " > ..."
        skrocstring(lblpath, 280, lblpath.Text)
    End Sub

    Private Sub btnpath_Click(sender As Object, e As EventArgs) Handles btnpath.Click
        If domodyfikacji IsNot Nothing AndAlso (odtwarzane.utwory.Contains(domodyfikacji) Or Form1.yt.directplay Is domodyfikacji) Then
            MsgBox("Utwór znajduje się na liście odtwarzania lub jest aktualnie odtwarzany i nie może zostać przeniesiony!", MsgBoxStyle.Exclamation, "YTMP")
            Exit Sub
        End If
        Dim wybrWYK As WYKONAWCA = Nothing
        Dim wybrALB As ALBUM = Nothing
        selectform.laduj(Nothing, dane, True)
        wybrWYK = selectform.wynik
        selectform.Close()
        If wybrWYK Is Nothing Then
            MsgBox("Anulowano zmianę ścieżki!", MsgBoxStyle.Information, "YTMP")
            Exit Sub
        End If
        If dane.SEThidealbums Then
            For Each i As ALBUM In wybrWYK.albumy
                If i.brakpozycji Then
                    wybrALB = i
                    Exit For
                End If
            Next
        Else
            selectform.laduj(wybrWYK, dane, True)
            wybrALB = selectform.wynik
            selectform.Close()
        End If
        If wybrWYK Is Nothing Or wybrALB Is Nothing Then
            MsgBox("Anulowano zmianę ścieżki!", MsgBoxStyle.Information, "YTMP")
        Else
            docelowyWYK = wybrWYK
            docelowyALB = wybrALB
            aktpath()
            przenies()
        End If
    End Sub

    Private Sub btnyt_Click(sender As Object, e As EventArgs) Handles btnyt.Click
        If lblid.Text = "Nie przypisano" Then
            MsgBox("Najpierw przypisz identyfikator filmu do utworu!", MsgBoxStyle.Information, "YTMP")
        Else
            If ytbrowser.Visible Then ytbrowser.Close()
            ytbrowser.zmienstrone("https://www.youtube.com/watch?v=" & lblid.Text)
            ytbrowser.ShowDialog()
            ytbrowser.Close()
        End If
    End Sub

    Private Sub btnzmienid_Click(sender As Object, e As EventArgs) Handles btnzmienid.Click
        If ytbrowser.Visible Then ytbrowser.Close()
        ytbrowser.edytujutwor(domodyfikacji)
        ytbrowser.ShowDialog()
        ytbrowser.Close()
    End Sub
End Class