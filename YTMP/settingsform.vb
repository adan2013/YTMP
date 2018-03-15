Public Class settingsform

    Dim init As Boolean = False

    Private Sub settingsform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init = True
        tabs.SelectedIndex = 0
        For Each i As KLAWISZE In dane.skroty
            If i.KEY = "" Then
                skrotygrid.Rows.Add(i.nazwa, "(brak)")
            Else
                skrotygrid.Rows.Add(i.nazwa, IIf(i.CTRLmod, "CTRL + ", "") & IIf(i.ALTmod, "ALT + ", "") & IIf(i.SHIFTmod, "SHIFT + ", "") & i.KEY)
            End If
        Next
        lblver.Text = "Wersja aplikacji: " & Form1.wersja
        'odczyt
        If dane.SETnakoncu Then chkboxkoniec.Checked = True Else chkboxpocz.Checked = True
        chkboxdymek.Checked = dane.SETdymek
        chkboxprzejdz.Checked = dane.SETprzejscie
        chkboxczas.Checked = dane.SETczas
        chkboxhide.Checked = dane.SEThide
        nropoznienie.Value = dane.SETopoznienie
        chkboxmkeys.Checked = dane.SETmultimediakeys
        chkboxhidealbums.Checked = dane.SEThidealbums
        chkboxtitlewindow.Checked = dane.SETshowtitlewindow
        chkboxsearchW.Checked = dane.SETsearchW
        chkboxsearchA.Checked = dane.SETsearchA
        chkboxsearchID.Checked = dane.SETsearchID
        chkboxzielbufor.Checked = dane.SETzielbufor
        lstdefaulttab.SelectedIndex = dane.SETdefaulttab
        lstprogress.SelectedIndex = dane.SETkolorprogress
        lstpause.SelectedIndex = dane.SETkolorpause
        If dane.SETkopie Then lstkopie.SelectedIndex = 1 Else lstkopie.SelectedIndex = 0
        init = False

        'historia odtwarzania
        lsthis.Items.Clear()
        For Each i As UTWOR In Form1.yt.hisodtw
            lsthis.Items.Add(i.tytul & " - " & i.FKalbum.FKwykonawca.nazwa)
        Next
        If lsthis.Items.Count > 0 Then lsthis.SelectedIndex = lsthis.Items.Count - 1
    End Sub

    Private Sub skrotygrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles skrotygrid.CellDoubleClick
        edycjaskrotu.ShowDialog()
        If edycjaskrotu.wynik Is Nothing Then
            dane.skroty(e.RowIndex).KEY = ""
        Else
            With dane.skroty(e.RowIndex)
                .CTRLmod = edycjaskrotu.wynik.CTRLmod
                .ALTmod = edycjaskrotu.wynik.ALTmod
                .SHIFTmod = edycjaskrotu.wynik.SHIFTmod
                .KEY = edycjaskrotu.wynik.KEY
            End With
        End If
        edycjaskrotu.Close()
        skrotygrid.Rows.Clear()
        For Each i As KLAWISZE In dane.skroty
            If i.KEY = "" Then
                skrotygrid.Rows.Add(i.nazwa, "(brak)")
            Else
                skrotygrid.Rows.Add(i.nazwa, IIf(i.CTRLmod, "CTRL + ", "") & IIf(i.ALTmod, "ALT + ", "") & IIf(i.SHIFTmod, "SHIFT + ", "") & i.KEY)
            End If
        Next
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If MsgBox("WYKASOWAĆ WSZYSTKIE DANE PROGRAMU ORAZ KOPIE BEZPIECZEŃSTWA?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
            Try
                If IO.File.Exists(Application.StartupPath & "\" & "magazyn.ytmp") Then
                    IO.File.Delete(Application.StartupPath & "\" & "magazyn.ytmp")
                End If
                backupy.usunwszystkie()
                MsgBox("Dane zostały wykasowane! Nastąpi zamknięcie aplikacji!", MsgBoxStyle.Exclamation, "YTMP")
                End
            Catch ex As Exception
                MsgBox("Wystąpił błąd podczas kasowania danych!", MsgBoxStyle.Critical, "YTMP")
            End Try
        End If
    End Sub

    Private Sub settingsform_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        dane.SETnakoncu = chkboxkoniec.Checked
        dane.SETdymek = chkboxdymek.Checked
        dane.SETprzejscie = chkboxprzejdz.Checked
        dane.SETczas = chkboxczas.Checked
        dane.SEThide = chkboxhide.Checked
        dane.SETopoznienie = nropoznienie.Value
        dane.SETmultimediakeys = chkboxmkeys.Checked
        dane.SEThidealbums = chkboxhidealbums.Checked
        dane.SETdefaulttab = lstdefaulttab.SelectedIndex
        dane.SETshowtitlewindow = chkboxtitlewindow.Checked
        dane.SETsearchW = chkboxsearchW.Checked
        dane.SETsearchA = chkboxsearchA.Checked
        dane.SETsearchID = chkboxsearchID.Checked
        dane.SETzielbufor = chkboxzielbufor.Checked
        dane.SETkolorprogress = lstprogress.SelectedIndex
        dane.SETkolorpause = lstpause.SelectedIndex
        If lstkopie.SelectedIndex = 0 Then dane.SETkopie = False Else dane.SETkopie = True
        Form1.Text = "YouTube Media Player"
        zapiszzmiany()
    End Sub

    Private Sub btnlocalsave_Click(sender As Object, e As EventArgs) Handles btnlocalsave.Click
        savedialog.FileName = ""
        savedialog.ShowDialog()
        If Not savedialog.FileName = "" Then
            serializuj(dane, savedialog.FileName)
        End If
    End Sub

    Private Sub btnwgraj_Click(sender As Object, e As EventArgs) Handles btnwgraj.Click
        opendialog.FileName = ""
        opendialog.ShowDialog()
        If Not opendialog.FileName = "" Then
            selectdata.mag = deserializuj(opendialog.FileName)
            selectdata.ShowDialog()
            selectdata.Close()
        End If
    End Sub

    Private Sub btnzapisz_Click(sender As Object, e As EventArgs) Handles btnzapisz.Click
        savedialog.FileName = ""
        savedialog.ShowDialog()
        If Not savedialog.FileName = "" Then
            selectdata.mag = dane
            selectdata.dopliku = savedialog.FileName
            selectdata.ShowDialog()
            selectdata.Close()
        End If
    End Sub

    Private Sub btnwgrajcalosc_Click(sender As Object, e As EventArgs) Handles btnwgrajcalosc.Click
        opendialog.FileName = ""
        opendialog.ShowDialog()
        If Not opendialog.FileName = "" Then
            selectdata.mag = deserializuj(opendialog.FileName)
            selectdata.addall()
            selectdata.ShowDialog()
            selectdata.Close()
        End If
    End Sub

    Private Sub btnprzywroc_Click(sender As Object, e As EventArgs) Handles btnprzywroc.Click
        If lstkopie.SelectedIndex = 0 Then
            MsgBox("Kopie bezpieczeństwa są wyłączone!", MsgBoxStyle.Information, "YTMP")
        Else
            backuprestore.ShowDialog()
            backuprestore.Close()
        End If
    End Sub

    Private Sub btngeneruj_Click(sender As Object, e As EventArgs) Handles btngeneruj.Click
        genraport.ShowDialog()
        genraport.Close()
    End Sub

    Private Sub chkboxhidealbums_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxhidealbums.CheckedChanged
        If init Then Exit Sub
        If chkboxhidealbums.Checked Then
            MsgBox("Od teraz wybór albumów będzie ukryty. A domyślną pozycją stanie się ""(bez albumu)"". Dotychczasowo utworzone albumy nie zostaną usunięte.", MsgBoxStyle.Information, "YTMP")
        End If
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

    Private Sub btnhistory_Click(sender As Object, e As EventArgs)
        hisutw.ShowDialog()
        hisutw.Close()
    End Sub

    Private Sub btngithub_Click(sender As Object, e As EventArgs) Handles btngithub.Click
        Try
            Process.Start("https://github.com/adan2013/YTMP")
        Catch ex As Exception

        End Try
    End Sub
End Class