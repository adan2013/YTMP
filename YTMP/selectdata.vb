Public Class selectdata

    Public mag As MAGAZYN = Nothing
    Public dopliku As String = ""

    Dim REFw As List(Of WYKONAWCA) = New List(Of WYKONAWCA)
    Dim REFa As List(Of ALBUM) = New List(Of ALBUM)
    Dim REFu As List(Of UTWOR) = New List(Of UTWOR)
    Dim REFlst As List(Of UTWOR) = New List(Of UTWOR)

    Private Sub selectdata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadW()
    End Sub

    Private Sub loadW()
        REFw.Clear()
        lstw.Items.Clear()
        btnallw.Enabled = False
        For Each w As WYKONAWCA In mag.wykonawcy
            REFw.Add(w)
        Next
        REFw.Sort(Function(x, y) x.nazwa.CompareTo(y.nazwa))
        For Each w As WYKONAWCA In REFw
            lstw.Items.Add(w.nazwa)
        Next
    End Sub

    Private Sub loadA()
        REFa.Clear()
        lsta.Items.Clear()
        btnalla.Enabled = False
        REFu.Clear()
        lstu.Items.Clear()
        btnadd.Enabled = False
        If lstw.SelectedIndex < 0 Then Exit Sub
        For Each a As ALBUM In REFw(lstw.SelectedIndex).albumy
            REFa.Add(a)
        Next
        REFa.Sort(Function(x, y) x.nazwa.CompareTo(y.nazwa))
        For Each a As ALBUM In REFa
            lsta.Items.Add(a.nazwa)
        Next
    End Sub

    Private Sub loadU()
        REFu.Clear()
        lstu.Items.Clear()
        btnadd.Enabled = False
        If lsta.SelectedIndex < 0 Then Exit Sub
        For Each u As UTWOR In REFa(lsta.SelectedIndex).utwory
            REFu.Add(u)
        Next
        REFu.Sort(Function(x, y) x.tytul.CompareTo(y.tytul))
        For Each u As UTWOR In REFu
            lstu.Items.Add(u.tytul)
        Next
    End Sub

    Private Sub lstw_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstw.SelectedIndexChanged
        If lstw.SelectedIndex >= 0 Then
            loadA()
            btnallw.Enabled = True
        Else
            btnallw.Enabled = False
        End If
    End Sub

    Private Sub lsta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsta.SelectedIndexChanged
        If lsta.SelectedIndex >= 0 Then
            loadU()
            btnalla.Enabled = True
        Else
            btnalla.Enabled = False
        End If
    End Sub

    Private Sub lstu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstu.SelectedIndexChanged
        If lstu.SelectedIndex >= 0 Then btnadd.Enabled = True Else btnadd.Enabled = True
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        If MsgBox("Wyczyścić listę utworów?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
            REFlst.Clear()
            lst.Items.Clear()
            btnclear.Enabled = False
            btndel.Enabled = False
            btnok.Enabled = False
        End If
    End Sub

    Private Sub lst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst.SelectedIndexChanged
        If lst.SelectedIndex < 0 Then btndel.Enabled = False Else btndel.Enabled = True
    End Sub

    Private Sub addutw(ByVal ob As UTWOR)
        If Not REFlst.Contains(ob) Then
            REFlst.Add(ob)
            REFlst.Sort(Function(x, y) x.tytul.CompareTo(y.tytul))
            lst.Items.Clear()
            For Each u As UTWOR In REFlst
                lst.Items.Add(u.tytul & " [ " & u.FKalbum.FKwykonawca.nazwa & " - " & u.FKalbum.nazwa & " ]")
            Next
            If REFlst.Count > 0 Then
                btnclear.Enabled = True
                btnok.Enabled = True
            Else
                btnclear.Enabled = False
                btnok.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click, lstu.DoubleClick
        If lstu.SelectedIndex >= 0 Then addutw(REFu(lstu.SelectedIndex))
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        If lst.SelectedIndex < 0 Then
            btndel.Enabled = False
        Else
            REFlst.RemoveAt(lst.SelectedIndex)
            lst.Items.RemoveAt(lst.SelectedIndex)
            lst.SelectedIndex = -1
            If REFlst.Count = 0 Then btnclear.Enabled = False
        End If
    End Sub

    Private Sub btnalla_Click(sender As Object, e As EventArgs) Handles btnalla.Click
        If lsta.SelectedIndex < 0 Then
            btnalla.Enabled = False
        Else
            For Each u As UTWOR In REFa(lsta.SelectedIndex).utwory
                addutw(u)
            Next
        End If
    End Sub

    Private Sub btnallw_Click(sender As Object, e As EventArgs) Handles btnallw.Click
        If lstw.SelectedIndex < 0 Then
            btnallw.Enabled = False
        Else
            For Each a As ALBUM In REFw(lstw.SelectedIndex).albumy
                For Each u As UTWOR In a.utwory
                    addutw(u)
                Next
            Next
        End If
    End Sub

    Public Sub addall()
        For Each w As WYKONAWCA In mag.wykonawcy
            For Each a As ALBUM In w.albumy
                For Each u As UTWOR In a.utwory
                    addutw(u)
                Next
            Next
        Next
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If dopliku = "" Then
            'do aktualnej biblioteki
            Dim s As String = "Rozpocząć proces dodawania utworów do aktualnej biblioteki?" & vbNewLine
            s &= "Jeśli wykonawca o podanej nazwie nie istnieje to zostanie utworzony." & vbNewLine
            s &= "Jeśli album o podanej nazwie nie istnieje to zostanie utworzony." & vbNewLine
            s &= "Jeśli utwór o podanym ID i nazwie nie istnieje to zostanie utworzony." & vbNewLine
            If MsgBox(s, MsgBoxStyle.Information + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
                Dim Lw As Integer = 0
                Dim La As Integer = 0
                Dim Lu As Integer = 0
                For Each ob As UTWOR In REFlst
                    'sprawdzanie wykonawcy
                    Dim Wexists As Boolean = False
                    Dim obwykonawcy As WYKONAWCA = Nothing
                    For Each w As WYKONAWCA In dane.wykonawcy
                        If ob.FKalbum.FKwykonawca.nazwa = w.nazwa Then
                            obwykonawcy = w
                            Wexists = True
                            Exit For
                        End If
                    Next
                    If Not Wexists Then
                        Lw += 1
                        obwykonawcy = New WYKONAWCA(ob.FKalbum.FKwykonawca.nazwa)
                        dane.wykonawcy.Add(obwykonawcy)
                    End If
                    'sprawdzanie albumu
                    Dim Aexists As Boolean = False
                    Dim obalbumu As ALBUM = Nothing
                    For Each a As ALBUM In obwykonawcy.albumy
                        If ob.FKalbum.nazwa = a.nazwa Then
                            obalbumu = a
                            Aexists = True
                            Exit For
                        End If
                    Next
                    If Not Aexists Then
                        La += 1
                        obalbumu = New ALBUM(ob.FKalbum.nazwa, obwykonawcy)
                    End If
                    'sprawdzanie utworu
                    Dim Uexists As Boolean = False
                    Dim obutworu As UTWOR = Nothing
                    If Aexists Then
                        For Each u As UTWOR In obalbumu.utwory
                            If ob.tytul = u.tytul And ob.link = u.link Then
                                Uexists = True
                                Exit For
                            End If
                        Next
                    End If
                    If Not Uexists Then
                        Lu += 1
                        obutworu = New UTWOR(ob.tytul, ob.link, obalbumu, ob.start, ob.koniec)
                    End If
                Next
                s = "Zakończono pomyślnie dodawanie utworów do biblioteki!" & vbNewLine & vbNewLine
                s &= "Statystyki:" & vbNewLine
                s &= "nowych wykonawców: " & Lw & vbNewLine
                s &= "nowych albumów: " & La & vbNewLine
                s &= "nowych utworów: " & Lu & vbNewLine
                MsgBox(s, MsgBoxStyle.Information, "YTMP")
                mag = Nothing
                DialogResult = DialogResult.OK
            End If
        Else
            'do pliku
            If MsgBox("Rozpocząć proces zapisu utworów do pliku?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
                Dim wynik As MAGAZYN = New MAGAZYN()
                For Each ob As UTWOR In REFlst
                    'sprawdzanie wykonawcy
                    Dim Wexists As Boolean = False
                    Dim obwykonawcy As WYKONAWCA = Nothing
                    For Each w As WYKONAWCA In wynik.wykonawcy
                        If ob.FKalbum.FKwykonawca.nazwa = w.nazwa Then
                            obwykonawcy = w
                            Wexists = True
                            Exit For
                        End If
                    Next
                    If Not Wexists Then
                        obwykonawcy = New WYKONAWCA(ob.FKalbum.FKwykonawca.nazwa)
                        wynik.wykonawcy.Add(obwykonawcy)
                    End If
                    'sprawdzanie albumu
                    Dim Aexists As Boolean = False
                    Dim obalbumu As ALBUM = Nothing
                    For Each a As ALBUM In obwykonawcy.albumy
                        If ob.FKalbum.nazwa = a.nazwa Then
                            obalbumu = a
                            Aexists = True
                            Exit For
                        End If
                    Next
                    If Not Aexists Then
                        obalbumu = New ALBUM(ob.FKalbum.nazwa, obwykonawcy)
                    End If
                    'sprawdzanie utworu
                    Dim Uexists As Boolean = False
                    Dim obutworu As UTWOR = Nothing
                    If Aexists Then
                        For Each u As UTWOR In obalbumu.utwory
                            If ob.tytul = u.tytul And ob.link = u.link Then
                                Uexists = True
                                Exit For
                            End If
                        Next
                    End If
                    If Not Uexists Then
                        obutworu = New UTWOR(ob.tytul, ob.link, obalbumu, ob.start, ob.koniec)
                    End If
                Next
                serializuj(wynik, dopliku)
                MsgBox("Zapisano pomyślnie utwory do pliku!", MsgBoxStyle.Information, "YTMP")
                mag = Nothing
                dopliku = ""
                DialogResult = DialogResult.OK
            End If
        End If
    End Sub
End Class