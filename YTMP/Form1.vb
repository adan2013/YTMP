Imports Microsoft.WindowsAPICodePack.Taskbar
Public Class Form1

    Public wersja As String = "v7.1"
    Public WithEvents kb As HOTKEY = New HOTKEY()
    Public rewindstate As Double = -1

    Public lblstart As Label = New Label()
    Public lblkoniec As Label = New Label()
    Public lblstan As Label = New Label()
    Public pnlglosnosc As Panel = New Panel()
    Public WithEvents pnlprzewijanie As Panel = New Panel()
    Public searchempty As Boolean = True

    Dim windowdragmode As Boolean = False
    Dim dragcords As Point = New Point(0, 0)
    Dim scrollpos As Integer = 0
    Dim pnlwewn As Panel = New Panel()
    Public PATHwyk As WYKONAWCA
    Public PATHalb As ALBUM
    Public PATHpl As PLAYLISTA

    Public yt As YTAPI

    Public TB1 As ThumbnailToolBarButton
    Public TB2 As ThumbnailToolBarButton
    Public TB3 As ThumbnailToolBarButton
    Public TB4 As ThumbnailToolBarButton
    Public TB5 As ThumbnailToolBarButton
    Public TB6 As ThumbnailToolBarButton

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.Style = cp.Style Or &H20000
            Return cp
        End Get
    End Property

    Public Sub refreshtabs(ByVal nr As Byte)
        'reset
        tab1.Location = New Point(tab1.Location.X, 42)
        tab2.Location = New Point(tab2.Location.X, 42)
        tab3.Location = New Point(tab3.Location.X, 42)
        'focus
        Select Case nr
            Case 0
                tab1.Location = New Point(tab1.Location.X, 39)
            Case 1
                tab2.Location = New Point(tab2.Location.X, 39)
            Case 2
                tab3.Location = New Point(tab3.Location.X, 39)
        End Select

        'panel
        searchempty = True
        txtsearch.Text = "Szukaj..."
        txtsearch.ForeColor = Color.Gray
        txtsearch.Size = New Size(180, txtsearch.Size.Height)
        ladujpanel()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load fonts
        loadfonts()

        If TaskbarManager.IsPlatformSupported Then
            TB1 = New ThumbnailToolBarButton(Icon.FromHandle(My.Resources.TBplay.GetHicon()), "Wznów odtwarzanie")
            TB2 = New ThumbnailToolBarButton(Icon.FromHandle(My.Resources.TBrewindL.GetHicon()), "Poprzedni")
            TB3 = New ThumbnailToolBarButton(Icon.FromHandle(My.Resources.TBrewindR.GetHicon()), "Następny")
            TB4 = New ThumbnailToolBarButton(Icon.FromHandle(My.Resources.TBvoloff.GetHicon()), "Wycisz dźwięk")
            TB5 = New ThumbnailToolBarButton(Icon.FromHandle(My.Resources.TBvoldn.GetHicon()), "Zmniejsz głośność")
            TB6 = New ThumbnailToolBarButton(Icon.FromHandle(My.Resources.TBvolup.GetHicon()), "Zwiększ głośność")
            AddHandler TB1.Click, AddressOf PlayPauseToolStripMenuItem_Click
            AddHandler TB2.Click, AddressOf PoprzedniUtwórToolStripMenuItem_Click
            AddHandler TB3.Click, AddressOf NastępnyUtwórToolStripMenuItem_Click
            AddHandler TB4.Click, AddressOf WyciszOdciszToolStripMenuItem_Click
            AddHandler TB5.Click, AddressOf ZmniejszGłośnośćToolStripMenuItem_Click
            AddHandler TB6.Click, AddressOf ZwiększGłośnośćToolStripMenuItem_Click
            TaskbarManager.Instance.ThumbnailToolBars.AddButtons(Handle, TB1, TB2, TB3, TB4, TB5, TB6)
        End If
        splashscreen.ShowDialog()
        With lblstart
            .Location = New Point(10, 0)
            .Size = New Size(50, 40)
            .Font = New Font("Consolas", 8)
            .TextAlign = ContentAlignment.MiddleCenter
            .Text = "00:00"
        End With
        With lblkoniec
            .Location = New Point(474, 0)
            .Size = New Size(50, 40)
            .Font = New Font("Consolas", 8)
            .TextAlign = ContentAlignment.MiddleCenter
            .Text = "00:00"
        End With
        With lblstan
            .Location = New Point(12, 95)
            .AutoSize = True
            .Font = New Font(getFontFamily("Carlito"), 10)
            .TextAlign = ContentAlignment.MiddleLeft
            .Text = ""
        End With
        With pnlprzewijanie
            .BackColor = Color.Red
            .Location = New Point(0, 0)
            .Size = New Size(0, pnlrewind.Size.Height)
        End With
        AddHandler pnlprzewijanie.MouseDown, AddressOf pnlrewind_MouseDown
        With pnlglosnosc
            .BackColor = Color.Red
            .Location = New Point(0, 0)
            .Size = New Size(0, pnlsound.Size.Height)
        End With
        AddHandler pnlglosnosc.MouseDown, AddressOf pnlsound_MouseDown
        pnlrewind.Controls.Add(pnlprzewijanie)
        pnlsound.Controls.Add(pnlglosnosc)
        pnlodtwarzacz.Controls.Add(lblstart)
        pnlodtwarzacz.Controls.Add(lblkoniec)
        pnlodtwarzacz.Controls.Add(lblstan)

        'deserializacja i odczyt
        'MAGAZYN
        If IO.File.Exists(Application.StartupPath & "\" & "magazyn.ytmp") Then
            dane = deserializuj(Application.StartupPath & "\" & "magazyn.ytmp")
        Else
            serializuj(dane, Application.StartupPath & "\" & "magazyn.ytmp")
            instrukcja.ShowDialog()
        End If
        If dane IsNot Nothing Then dane.ladujklawisze()
        'BACKUP
        If IO.File.Exists(Application.StartupPath & "\" & "kopie.backup") Then
            backupy = deserializuj(Application.StartupPath & "\" & "kopie.backup")
            If backupy Is Nothing Then
                MsgBox("Aplikacja wykryła problem z odczytem pliku odpowiedzialnego za zarządzanie kopiami bezpieczeństwa. Problemy te mogło spowodować nagły zanik zasilania komputera. Aplikacja utworzy teraz nowy plik i automatycznie naprawi działanie kopii zapasowych...", MsgBoxStyle.Critical, "YTMP")
                backupy = New BACKUP(Application.StartupPath)
                serializuj(backupy, Application.StartupPath & "\" & "kopie.backup")
            End If
        Else
            serializuj(backupy, Application.StartupPath & "\" & "kopie.backup")
        End If
        If dane IsNot Nothing AndAlso dane.SETkopie AndAlso backupy IsNot Nothing Then
            backupy.dodajkopie(dane)
            serializuj(backupy, Application.StartupPath & "\" & "kopie.backup")
        End If
        'RECOVERY MODE
        If dane Is Nothing Then
            recoverymode.ShowDialog()
            recoverymode.Close()
            End
        End If

        selectedtab = dane.SETdefaulttab
        pnlglosnosc.Size = New Size(dane.volume, pnlglosnosc.Size.Height)
        If dane.MODmute Then btnmute.BackColor = Color.Yellow
        If dane.MODran Then btnran.BackColor = Color.Yellow
        If dane.MODrep Then btnrep.BackColor = Color.Yellow
        yt = New YTAPI()
        akt.Enabled = True

        'pilot
        pilot.konfiguruj()
        If dane.SETpilotact = 1 Then pilot.Show()

        'sprawdzanie aktualizacji
        If IO.Directory.Exists(Application.StartupPath & "\YTMP-UPDATE-PACK") Then
            If IO.File.Exists(Application.StartupPath & "\install.txt") Then
                updateform.initsc = updateform.SCENA.pomyslnains
            Else
                updateform.initsc = updateform.SCENA.gotowosc
                btnupdate.Visible = True
            End If
            updateform.ShowDialog()
            updateform.Close()
        End If

        'start hotkey
        kb.startworking(Me)
        loadhotkeys()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        akt.Enabled = False
        UNREGISTERHOTKEYS()
        yt.usun()
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        kb.messagehook(m)
        MyBase.WndProc(m)
    End Sub

    Private Sub kb_HotKeyDetected(tagname As String) Handles kb.HotKeyDetected
        If Not edycjaskrotu.Visible Then
            For Each i As KLAWISZE In dane.skroty
                If i.nazwa = tagname Then i.uruchom()
            Next
        End If
        If dane.SETmultimediakeys Then
            Select Case tagname
                Case "MediaPlayPause"
                    btnplay_Click(btnplay, New EventArgs())
                Case "MediaPreviousTrack"
                    btnrewindL_Click(btnrewindL, New EventArgs())
                Case "MediaNextTrack"
                    btnrewindR_Click(btnrewindR, New EventArgs())
            End Select
        End If
    End Sub

    Private Sub txtsearch_GotFocus(sender As Object, e As EventArgs) Handles txtsearch.GotFocus
        If searchempty Then
            searchempty = False
            txtsearch.Text = ""
            txtsearch.ForeColor = Color.Black
            txtsearch.Size = New Size(151, txtsearch.Size.Height)
        End If
    End Sub

    Private Sub txtsearch_LostFocus(sender As Object, e As EventArgs) Handles txtsearch.LostFocus
        If Not searchempty And txtsearch.Text = "" Then
            searchempty = True
            txtsearch.Text = "Szukaj..."
            txtsearch.ForeColor = Color.Gray
            txtsearch.Size = New Size(180, txtsearch.Size.Height)
            ladujpanel()
        End If
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If searchempty Then
            searchempty = False
            txtsearch.Text = ""
            txtsearch.ForeColor = Color.Black
            txtsearch.Size = New Size(151, txtsearch.Size.Height)
        End If
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        If Not searchempty Then
            If txtsearch.Text = "" Then
                ladujpanel()
            Else
                If searchdelay.Enabled Then searchdelay.Enabled = False
                searchdelay.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnplay_MouseMove(sender As Object, e As EventArgs) Handles btnplay.MouseMove, btnrewindL.MouseMove, btnrewindR.MouseMove, btnmute.MouseMove, btnrep.MouseMove, btnran.MouseMove, btnsettings.MouseMove, btnupdate.MouseMove
        sender.BackColor = Color.Yellow
    End Sub

    Private Sub btnplay_MouseLeave(sender As Object, e As EventArgs) Handles btnplay.MouseLeave, btnrewindL.MouseLeave, btnrewindR.MouseLeave, btnmute.MouseLeave, btnrep.MouseLeave, btnran.MouseLeave, btnsettings.MouseLeave, btnupdate.MouseLeave
        If sender.Parent.Name = "pnlodtwarzacz" Then
            Select Case sender.Name
                Case "btnran"
                    If dane.MODran Then sender.BackColor = Color.Yellow Else sender.BackColor = Color.WhiteSmoke
                Case "btnrep"
                    If dane.MODrep Then sender.BackColor = Color.Yellow Else sender.BackColor = Color.WhiteSmoke
                Case "btnmute"
                    If dane.MODmute Then sender.BackColor = Color.Yellow Else sender.BackColor = Color.WhiteSmoke
                Case Else
                    sender.BackColor = Color.WhiteSmoke
            End Select
        Else
            sender.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub btnran_Click(sender As Object, e As EventArgs) Handles btnran.Click
        dane.MODran = Not dane.MODran
        If dane.MODran Then sender.BackColor = Color.Yellow Else sender.BackColor = Color.WhiteSmoke
        zapiszzmiany()
        pilot.aktualizacja()
    End Sub

    Private Sub btnrep_Click(sender As Object, e As EventArgs) Handles btnrep.Click
        dane.MODrep = Not dane.MODrep
        If dane.MODrep Then sender.BackColor = Color.Yellow Else sender.BackColor = Color.WhiteSmoke
        zapiszzmiany()
        pilot.aktualizacja()
    End Sub

    Public Sub btnmute_Click(sender As Object, e As EventArgs) Handles btnmute.Click
        dane.MODmute = Not dane.MODmute
        If dane.MODmute Then sender.BackColor = Color.Yellow Else sender.BackColor = Color.WhiteSmoke
        zapiszzmiany()
        pilot.aktualizacja()
    End Sub

    Private Sub btnsettings_Click(sender As Object, e As EventArgs) Handles btnsettings.Click
        settingsform.ShowDialog()
        settingsform.Close()
        ladujpanel()
    End Sub

    Public Function searchfilter(ByRef u As UTWOR) As Boolean
        Dim s As String = "*" & txtsearch.Text.ToLower() & "*"
        If u.tytul.ToLower() Like s Then Return True
        If dane.SETsearchW AndAlso u.FKalbum.FKwykonawca.nazwa.ToLower() Like s Then Return True
        If dane.SETsearchA AndAlso u.FKalbum.nazwa.ToLower() Like s Then Return True
        If dane.SETsearchID AndAlso u.link.ToLower() Like s Then Return True
        Return False
    End Function

    Public Sub ladujpanel()
        pnllista.turnOFF()
        Dim REF As List(Of Object) = New List(Of Object)
        pnllista.Clear()

        Select Case selectedtab
            Case 0 'lista odtwarzania
                btncofnij.Enabled = False
                btndodaj.Enabled = False
                btnwyczysc.Enabled = True
                btnodtwall.Enabled = False
                If searchempty Then
                    REF.AddRange(odtwarzane.utwory)
                    lblinfo.Text = "Ilość utworów: " & REF.Count
                Else
                    btnwyczysc.Enabled = False
                    If Not txtsearch.Text = "" Then
                        For Each i As UTWOR In odtwarzane.utwory
                            If searchfilter(i) Then REF.Add(i)
                        Next
                    End If
                    lblinfo.Text = "> Wyniki wyszukiwania >"
                End If
            Case 1 'utwory
                If searchempty Then
                    If PATHwyk Is Nothing Then
                        'WYKONAWCY
                        btncofnij.Enabled = False
                        btndodaj.Enabled = True
                        btnwyczysc.Enabled = False
                        btnodtwall.Enabled = True
                        REF.AddRange(dane.wykonawcy)
                        REF.Sort(Function(x, y) x.nazwa.CompareTo(y.nazwa))
                        lblinfo.Text = ">"
                    Else
                        If PATHalb Is Nothing Then
                            'ALBUMY
                            btncofnij.Enabled = True
                            btndodaj.Enabled = True
                            btnwyczysc.Enabled = False
                            btnodtwall.Enabled = True
                            REF.AddRange(PATHwyk.albumy)
                            REF.Sort(Function(x, y) x.nazwa.CompareTo(y.nazwa))
                            lblinfo.Text = "> " & PATHwyk.nazwa & " >"
                        Else
                            'UTWORY
                            btncofnij.Enabled = True
                            btndodaj.Enabled = True
                            btnwyczysc.Enabled = True
                            btnodtwall.Enabled = True
                            REF.AddRange(PATHalb.utwory)
                            lblinfo.Text = "> " & PATHwyk.nazwa & " > " & PATHalb.nazwa & " >"
                        End If
                    End If
                Else
                    'SEARCHMODE
                    btncofnij.Enabled = False
                    btndodaj.Enabled = False
                    btnwyczysc.Enabled = False
                    btnodtwall.Enabled = False
                    If Not txtsearch.Text = "" Then
                        For Each w As WYKONAWCA In dane.wykonawcy
                            For Each a As ALBUM In w.albumy
                                For Each u As UTWOR In a.utwory
                                    If searchfilter(u) Then REF.Add(u)
                                Next
                            Next
                        Next
                        REF.Sort(Function(x, y) x.tytul.CompareTo(y.tytul))
                    End If
                    lblinfo.Text = "> Wyniki wyszukiwania >"
                End If
            Case 2 'playlisty
                If PATHpl Is Nothing Then
                    'PLAYLISTY
                    btncofnij.Enabled = False
                    btndodaj.Enabled = True
                    btnwyczysc.Enabled = False
                    btnodtwall.Enabled = False
                    If searchempty Then
                        REF.AddRange(dane.playlisty)
                        lblinfo.Text = ">"
                    Else
                        If Not txtsearch.Text = "" Then
                            Dim txts As String = "*" & txtsearch.Text.ToLower() & "*"
                            For Each i As PLAYLISTA In dane.playlisty
                                If i.nazwa.ToLower() Like txts Then REF.Add(i)
                            Next
                        End If
                        lblinfo.Text = "> Wyniki wyszukiwania >"
                    End If
                    REF.Sort(Function(x, y) x.nazwa.CompareTo(y.nazwa))
                Else
                    'UTWORY Z PLAYLIST
                    If searchempty Then
                        btncofnij.Enabled = True
                        btndodaj.Enabled = False
                        btnwyczysc.Enabled = True
                        btnodtwall.Enabled = True
                        REF.AddRange(PATHpl.utwory)
                        lblinfo.Text = "> " & PATHpl.nazwa & " >"
                    Else
                        btncofnij.Enabled = False
                        btndodaj.Enabled = False
                        btnwyczysc.Enabled = False
                        btnodtwall.Enabled = False
                        If Not txtsearch.Text = "" Then
                            For Each i As UTWOR In PATHpl.utwory
                                If searchfilter(i) Then REF.Add(i)
                            Next
                        End If
                        lblinfo.Text = "> Wyniki wyszukiwania >"
                    End If
                End If
        End Select
        If REF.Count = 0 Then
            btnwyczysc.Enabled = False
        Else
            For lp As Integer = 0 To REF.Count - 1 Step 1
                Dim i As Object = REF(lp)
                If TypeOf i Is WYKONAWCA Then
                    Dim w As WYKONAWCA = i
                    pnllista.Add(w.nazwa, "", "", True, w)
                End If
                If TypeOf i Is ALBUM Then
                    Dim a As ALBUM = i
                    pnllista.Add(a.nazwa, "Ilość utworów: " & a.utwory.Count, "", True, a)
                End If
                If TypeOf i Is UTWOR Then
                    Dim u As UTWOR = i
                    Select Case selectedtab
                        Case 0
                            pnllista.Add(u.tytul, u.FKalbum.FKwykonawca.nazwa, (lp + 1) & " / " & REF.Count, False, u)
                        Case 1
                            If searchempty Then
                                pnllista.Add(u.tytul, "", (lp + 1) & " / " & REF.Count, False, u)
                            Else
                                pnllista.Add(u.tytul, u.FKalbum.FKwykonawca.nazwa, u.FKalbum.nazwa, False, u)
                            End If
                        Case 2
                            If searchempty Then
                                pnllista.Add(u.tytul, u.FKalbum.FKwykonawca.nazwa, (lp + 1) & " / " & REF.Count, False, u)
                            Else
                                pnllista.Add(u.tytul, u.FKalbum.FKwykonawca.nazwa, "Przynależność: " & PATHpl.nazwa, False, u)
                            End If
                    End Select
                End If
                If TypeOf i Is PLAYLISTA Then
                    Dim pl As PLAYLISTA = i
                    pnllista.Add(pl.nazwa, "Ilość utworów: " & pl.utwory.Count, "", True, pl)
                End If
            Next
        End If
        pnllista.turnON()
        skrocstring(lblinfo, 400, lblinfo.Text)
    End Sub

    Private Sub btncofnij_Click(sender As Object, e As EventArgs) Handles btncofnij.Click
        If selectedtab = 1 Then
            If PATHalb Is Nothing Then
                PATHwyk = Nothing
            Else
                PATHalb = Nothing
                If dane.SEThidealbums Then PATHwyk = Nothing
            End If
            ladujpanel()
        Else
            PATHpl = Nothing
            ladujpanel()
        End If
    End Sub

    Private Sub btnwyczysc_Click(sender As Object, e As EventArgs) Handles btnwyczysc.Click
        Select Case selectedtab
            Case 0
                odtwarzane.utwory.Clear()
                ladujpanel()
            Case 1
                If MsgBox("Usunąć wszystkie pozycje z listy?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
                    PATHalb.utwory.Clear()
                    ladujpanel()
                    zapiszzmiany()
                End If
            Case 2
                If MsgBox("Usunąć wszystkie pozycje z listy?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
                    PATHpl.utwory.Clear()
                    ladujpanel()
                    zapiszzmiany()
                End If
        End Select
    End Sub

    Private Sub btnodtwall_Click(sender As Object, e As EventArgs) Handles btnodtwall.Click
        odtwarzane.utwory.Clear()
        If (selectedtab = 1 And PATHwyk IsNot Nothing And PATHalb IsNot Nothing) Or (selectedtab = 2 And PATHpl IsNot Nothing) Then
            If selectedtab = 1 Then
                For Each u As UTWOR In PATHalb.utwory
                    odtwarzane.dodajutwor(u)
                Next
            Else
                For Each u As UTWOR In PATHpl.utwory
                    odtwarzane.dodajutwor(u)
                Next
            End If
        End If
        If selectedtab = 1 And PATHwyk IsNot Nothing And PATHalb Is Nothing Then
            For Each a As ALBUM In PATHwyk.albumy
                For Each u As UTWOR In a.utwory
                    odtwarzane.dodajutwor(u)
                Next
            Next
        End If
        If selectedtab = 1 And PATHwyk Is Nothing And PATHalb Is Nothing Then
            For Each w As WYKONAWCA In dane.wykonawcy
                For Each a As ALBUM In w.albumy
                    For Each u As UTWOR In a.utwory
                        odtwarzane.dodajutwor(u)
                    Next
                Next
            Next
        End If
        selectedtab = 0
        yt.nastepnyutwor()
    End Sub

    Private Sub btndodaj_Click(sender As Object, e As EventArgs) Handles btndodaj.Click
        If selectedtab = 2 Then
            If odtwarzane.utwory.Count > 0 Then
                MODpl.ShowDialog()
                MODpl.Close()
                ladujpanel()
                zapiszzmiany()
            Else
                MsgBox("Lista odtwarzania jest pusta!" & vbNewLine & "Aby utworzyć nową playliste, dodaj pierw utwory do listy odtwarzania", MsgBoxStyle.Exclamation, "YTMP")
            End If
        Else
            If PATHwyk Is Nothing Then
                newitemform.laduj(1)
                ladujpanel()
                zapiszzmiany()
            Else
                If PATHalb Is Nothing Then
                    newitemform.laduj(2)
                    ladujpanel()
                    zapiszzmiany()
                Else
                    newitemform.laduj(3)
                    ladujpanel()
                End If
            End If
        End If
    End Sub

    Private Sub pnlsound_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlsound.MouseDown
        If e.Button = MouseButtons.Left Then
            Dim var As Integer = e.Location.X
            If var Mod 10 > 4 Then
                var += 10 - var Mod 10
            Else
                var -= var Mod 10
            End If
            dane.volume = var
            pnlglosnosc.Size = New Size(dane.volume, pnlglosnosc.Size.Height)
            zapiszzmiany()
            pilot.aktualizacja()
        End If
    End Sub

    Private Sub pnlrewind_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlrewind.MouseDown
        If e.Button = MouseButtons.Left Then
            yt.przewin(e.Location.X / pnlrewind.Size.Width)
        End If
    End Sub

    Private Sub akt_Tick(sender As Object, e As EventArgs) Handles akt.Tick
        yt.aktualizacja()
        skrocstring(lblstan, 370, yt.tekststatus)
        pilot.status(yt.tekststatus, yt.currenttime, yt.durationtime)
    End Sub

    Private Sub btnplay_Click(sender As Object, e As EventArgs) Handles btnplay.Click
        yt.playpause()
    End Sub

    Private Sub btnrewindL_Click(sender As Object, e As EventArgs) Handles btnrewindL.Click
        yt.poprzedniutwor()
    End Sub

    Private Sub btnrewindR_Click(sender As Object, e As EventArgs) Handles btnrewindR.Click
        yt.nastepnyutwor()
    End Sub

    Private Sub PlayPauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayPauseToolStripMenuItem.Click
        yt.playpause()
    End Sub

    Private Sub PoprzedniUtwórToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PoprzedniUtwórToolStripMenuItem.Click
        yt.poprzedniutwor()
    End Sub

    Private Sub NastępnyUtwórToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NastępnyUtwórToolStripMenuItem.Click
        yt.nastepnyutwor()
    End Sub

    Private Sub WyciszOdciszToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WyciszOdciszToolStripMenuItem.Click
        btnmute_Click(btnmute, New EventArgs())
    End Sub

    Private Sub ZmniejszGłośnośćToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZmniejszGłośnośćToolStripMenuItem.Click
        If dane.volume >= 10 Then
            dane.volume -= 10
            pnlglosnosc.Size = New Size(dane.volume, pnlglosnosc.Size.Height)
            pilot.aktualizacja()
            zapiszzmiany()
        End If
    End Sub

    Private Sub ZwiększGłośnośćToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZwiększGłośnośćToolStripMenuItem.Click
        If dane.volume <= 90 Then
            dane.volume += 10
            pnlglosnosc.Size = New Size(dane.volume, pnlglosnosc.Size.Height)
            pilot.aktualizacja()
            zapiszzmiany()
        End If
    End Sub

    Private Sub ZakończToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZakończToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub notify_MouseUp(sender As Object, e As MouseEventArgs) Handles notify.MouseUp
        If e.Button = MouseButtons.Left Then
            If WindowState = FormWindowState.Minimized Then
                Show()
                WindowState = FormWindowState.Normal
            End If
        End If
    End Sub

    Private Sub btnsearchoff_Click(sender As Object, e As EventArgs) Handles btnsearchoff.Click
        searchempty = True
        txtsearch.Text = "Szukaj..."
        txtsearch.ForeColor = Color.Gray
        txtsearch.Size = New Size(180, txtsearch.Size.Height)
        ladujpanel()
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If dane.SEThide And WindowState = FormWindowState.Minimized Then Hide()
        If WindowState = FormWindowState.Maximized Then WindowState = FormWindowState.Normal
        'pilot
        If dane.SETpilotact = 2 Then
            If WindowState = FormWindowState.Minimized Then
                pilot.Show()
            Else
                pilot.Hide()
            End If
        End If
    End Sub

    Private Sub pnlrewind_MouseLeave(sender As Object, e As EventArgs) Handles pnlrewind.MouseLeave, pnlprzewijanie.MouseLeave
        rewindstate = -1
    End Sub

    Private Sub pnlrewind_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlrewind.MouseMove, pnlprzewijanie.MouseMove
        rewindstate = e.Location.X / pnlrewind.Size.Width
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If IO.Directory.Exists(Application.StartupPath & "\YTMP-UPDATE-PACK") Then
            updateform.initsc = updateform.SCENA.gotowosc
        Else
            updateform.initsc = updateform.SCENA.start
        End If
        updateform.ShowDialog()
        updateform.Close()
    End Sub

    Private Sub btnX_MouseMove(sender As Object, e As MouseEventArgs) Handles btnX.MouseMove, btnM.MouseMove, btnOPNCLS.MouseMove
        sender.BackColor = Color.FromArgb(belkapnl.BackColor.R - 20, belkapnl.BackColor.G - 20, belkapnl.BackColor.B - 20)
    End Sub

    Private Sub btnX_MouseLeave(sender As Object, e As EventArgs) Handles btnX.MouseLeave, btnM.MouseLeave, btnOPNCLS.MouseLeave
        sender.BackColor = belkapnl.BackColor
    End Sub

    Private Sub btnX_MouseDown(sender As Object, e As MouseEventArgs) Handles btnX.MouseDown, btnM.MouseDown, btnOPNCLS.MouseDown
        sender.BackColor = Color.FromArgb(belkapnl.BackColor.R - 40, belkapnl.BackColor.G - 40, belkapnl.BackColor.B - 40)
    End Sub

    Private Sub btnX_MouseUp(sender As Object, e As MouseEventArgs) Handles btnX.MouseUp, btnM.MouseUp, btnOPNCLS.MouseUp
        sender.BackColor = Color.FromArgb(belkapnl.BackColor.R - 20, belkapnl.BackColor.G - 20, belkapnl.BackColor.B - 20)
        If sender.Name = "btnX" Then Close()
        If sender.Name = "btnM" Then WindowState = FormWindowState.Minimized
        If sender.Name = "btnOPNCLS" Then
            If Size.Width < 550 Then
                btnOPNCLS.Image = My.Resources.belkaclose
                Size = New Size(960, Size.Height)
                If Location.X + Size.Width > Screen.PrimaryScreen.WorkingArea.Width Then Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Size.Width, Location.Y)
            Else
                btnOPNCLS.Image = My.Resources.belkaopen
                Size = New Size(534, Size.Height)
            End If
        End If
    End Sub

    Private Sub belkapnl_MouseDown(sender As Object, e As MouseEventArgs) Handles belkapnl.MouseDown, mainlbl.MouseDown
        If e.Button = MouseButtons.Left Then
            windowdragmode = True
            dragcords = New Point(Cursor.Position.X - Left, Cursor.Position.Y - Top)
        End If
    End Sub

    Private Sub belkapnl_MouseUp(sender As Object, e As MouseEventArgs) Handles belkapnl.MouseUp, mainlbl.MouseUp
        If e.Button = MouseButtons.Left Then windowdragmode = False
    End Sub

    Private Sub belkapnl_MouseMove(sender As Object, e As MouseEventArgs) Handles belkapnl.MouseMove, mainlbl.MouseMove
        If windowdragmode Then
            Left = Cursor.Position.X - dragcords.X
            Top = Cursor.Position.Y - dragcords.Y
        End If
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.DrawRectangle(New Pen(New SolidBrush(Color.FromArgb(100, 100, 100)), 2), New Rectangle(0, 0, 534, Size.Height))
        e.Graphics.DrawRectangle(New Pen(New SolidBrush(Color.FromArgb(100, 100, 100)), 2), New Rectangle(0, 0, Size.Width, Size.Height))
    End Sub

    Private Sub tab1_Click(sender As Object, e As EventArgs) Handles tab1.Click, tab2.Click, tab3.Click
        selectedtab = sender.Name.Substring(sender.Name.Length - 1, 1) - 1
    End Sub

    Private Sub searchdelay_Tick(sender As Object, e As EventArgs) Handles searchdelay.Tick
        If Not searchempty Then
            searchdelay.Enabled = False
            ladujpanel()
        End If
    End Sub
End Class
