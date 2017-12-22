Public Class Form1

    Public wersja As String = "v5.0"
    Dim WithEvents kb As KeyboardHook = New KeyboardHook()
    Public rewindstate As Double = -1

    Public lblstart As Label = New Label()
    Public lblkoniec As Label = New Label()
    Public lblstan As Label = New Label()
    Public pnlglosnosc As Panel = New Panel()
    Public WithEvents pnlprzewijanie As Panel = New Panel()
    Dim searchempty As Boolean = True

    Dim windowdragmode As Boolean = False
    Dim dragcords As Point = New Point(0, 0)
    Dim seltab As SByte = 0
    Dim scrollpos As Integer = 0
    Dim pnlwewn As Panel = New Panel()
    Public PATHwyk As WYKONAWCA
    Public PATHalb As ALBUM
    Public PATHpl As PLAYLISTA
    Public REFpoz As List(Of Object) = New List(Of Object)

    Public yt As YTAPI

    Public Property selectedtab() As SByte
        Get
            Return seltab
        End Get
        Set(value As SByte)
            If value >= 0 And value < 3 Then
                seltab = value
                refreshtabs()
            End If
        End Set
    End Property

    Private Sub refreshtabs()
        'reset
        tab1.Location = New Point(tab1.Location.X, 42)
        tab2.Location = New Point(tab2.Location.X, 42)
        tab3.Location = New Point(tab3.Location.X, 42)
        'focus
        Select Case seltab
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
            .Font = New Font("Sans Serif", 9)
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
        If IO.File.Exists(Application.StartupPath & "\" & "magazyn.ytmp") Then
            dane = deserializuj(Application.StartupPath & "\" & "magazyn.ytmp")
        Else
            serializuj(dane, Application.StartupPath & "\" & "magazyn.ytmp")
            instrukcja.ShowDialog()
        End If

        If IO.File.Exists(Application.StartupPath & "\" & "kopie.backup") Then
            backupy = deserializuj(Application.StartupPath & "\" & "kopie.backup")
            backupy.init = Application.StartupPath
        Else
            serializuj(backupy, Application.StartupPath & "\" & "kopie.backup")
        End If
        If dane.SETkopie Then backupy.dodajkopie(dane)

        selectedtab = dane.SETdefaulttab
        pnlglosnosc.Size = New Size(dane.volume, pnlglosnosc.Size.Height)
        If dane.MODmute Then btnmute.BackColor = Color.Yellow
        If dane.MODran Then btnran.BackColor = Color.Yellow
        If dane.MODrep Then btnrep.BackColor = Color.Yellow
        yt = New YTAPI()
        akt.Enabled = True
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        serializuj(dane, Application.StartupPath & "\" & "magazyn.ytmp")
        serializuj(backupy, Application.StartupPath & "\" & "kopie.backup")
        akt.Enabled = False
        yt.usun()
    End Sub

    Private Sub kb_KeyDown(Key As Keys) Handles kb.KeyDown

    End Sub

    Private Sub kb_KeyUp(Key As Keys) Handles kb.KeyUp
        If edycjaskrotu.Visible Then
            edycjaskrotu.odczyt(Key.ToString())
        Else
            For Each i As KLAWISZE In dane.skroty
                If i.CTRLmod = My.Computer.Keyboard.CtrlKeyDown And i.ALTmod = My.Computer.Keyboard.AltKeyDown And i.SHIFTmod = My.Computer.Keyboard.ShiftKeyDown And i.KEY = Key.ToString() Then i.uruchom()
            Next
        End If
        If dane.SETmultimediakeys Then
            Select Case Key.ToString()
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

    Private Sub pnllista_Scroll(sender As Object, e As ScrollEventArgs) Handles pnllista.Scroll
        scrollpos = e.NewValue
    End Sub

    Private Sub pnllista_MouseWheel(sender As Object, e As MouseEventArgs) Handles pnllista.MouseWheel
        If pnlwewn.Size.Height > pnllista.Size.Height Then scrollpos = pnllista.VerticalScroll.Value
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        If Not searchempty Then ladujpanel()
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
    End Sub

    Private Sub btnrep_Click(sender As Object, e As EventArgs) Handles btnrep.Click
        dane.MODrep = Not dane.MODrep
        If dane.MODrep Then sender.BackColor = Color.Yellow Else sender.BackColor = Color.WhiteSmoke
    End Sub

    Public Sub btnmute_Click(sender As Object, e As EventArgs) Handles btnmute.Click
        dane.MODmute = Not dane.MODmute
        If dane.MODmute Then sender.BackColor = Color.Yellow Else sender.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub btnsettings_Click(sender As Object, e As EventArgs) Handles btnsettings.Click
        settingsform.ShowDialog()
        settingsform.Close()
        ladujpanel()
    End Sub

    Public Sub ladujpanel()
        pnllista.Controls.Remove(pnlwewn)
        pnlwewn = New Panel()
        pnlwewn.Name = "wewn"
        pnlwewn.Size = New Size(pnllista.Size.Width - 2, 0)

        REFpoz.Clear()
        Select Case selectedtab
            Case 0
                btncofnij.Enabled = False
                btndodaj.Enabled = False
                btnwyczysc.Enabled = True
                btnodtwall.Enabled = False
                If searchempty Then
                    lblinfo.Text = "Ilość utworów: " & odtwarzane.utwory.Count
                Else
                    lblinfo.Text = "> Wyniki wyszukiwania >"
                    btnwyczysc.Enabled = False
                End If
                For Each i As UTWOR In odtwarzane.utwory
                    REFpoz.Add(i)
                Next
            Case 1
                If searchempty Then
                    If PATHwyk Is Nothing Then
                        btncofnij.Enabled = False
                        btndodaj.Enabled = True
                        btnwyczysc.Enabled = False
                        btnodtwall.Enabled = True
                        lblinfo.Text = ">"
                        For Each i As WYKONAWCA In dane.wykonawcy
                            REFpoz.Add(i)
                        Next
                        REFpoz.Sort(Function(x, y) x.nazwa.CompareTo(y.nazwa))
                    Else
                        If PATHalb Is Nothing Then
                            btncofnij.Enabled = True
                            btndodaj.Enabled = True
                            btnwyczysc.Enabled = False
                            btnodtwall.Enabled = True
                            lblinfo.Text = "> " & PATHwyk.nazwa & " >"
                            For Each i As ALBUM In PATHwyk.albumy
                                REFpoz.Add(i)
                            Next
                            REFpoz.Sort(Function(x, y) x.nazwa.CompareTo(y.nazwa))
                        Else
                            btncofnij.Enabled = True
                            btndodaj.Enabled = True
                            btnwyczysc.Enabled = True
                            btnodtwall.Enabled = True
                            lblinfo.Text = "> " & PATHwyk.nazwa & " > " & PATHalb.nazwa & " >"
                            For Each i As UTWOR In PATHalb.utwory
                                REFpoz.Add(i)
                            Next
                        End If
                    End If
                Else
                    btncofnij.Enabled = False
                    btndodaj.Enabled = False
                    btnwyczysc.Enabled = False
                    btnodtwall.Enabled = False
                    lblinfo.Text = "> Wyniki wyszukiwania >"
                    If Not txtsearch.Text = "" Then
                        For Each w As WYKONAWCA In dane.wykonawcy
                            For Each a As ALBUM In w.albumy
                                For Each u As UTWOR In a.utwory
                                    If u.tytul.ToLower() Like "*" & txtsearch.Text.ToLower() & "*" Then REFpoz.Add(u)
                                Next
                            Next
                        Next
                        REFpoz.Sort(Function(x, y) x.tytul.CompareTo(y.tytul))
                    End If
                End If
            Case 2
                If PATHpl Is Nothing Then
                    btncofnij.Enabled = False
                    btndodaj.Enabled = True
                    btnwyczysc.Enabled = False
                    btnodtwall.Enabled = False
                    lblinfo.Text = ">"
                    For Each i As PLAYLISTA In dane.playlisty
                        REFpoz.Add(i)
                    Next
                    REFpoz.Sort(Function(x, y) x.nazwa.CompareTo(y.nazwa))
                Else
                    btncofnij.Enabled = True
                    btndodaj.Enabled = False
                    btnwyczysc.Enabled = True
                    btnodtwall.Enabled = True
                    lblinfo.Text = "> " & PATHpl.nazwa & " >"
                    For Each i As UTWOR In PATHpl.utwory
                        REFpoz.Add(i)
                    Next
                End If
                If Not searchempty Then
                    btncofnij.Enabled = False
                    btndodaj.Enabled = False
                    btnwyczysc.Enabled = False
                    btnodtwall.Enabled = False
                End If
        End Select
        If REFpoz.Count = 0 Then btnwyczysc.Enabled = False

        Dim nrpoz As Integer = 0
        For Each i As Object In REFpoz
            Dim pnl As Panel = New Panel()
            Dim lbltekst As Label = New Label()
            Dim lbltekst2 As Label = New Label()
            Dim lbltekst3 As Label = New Label()
            Dim btn(2) As PictureBox
            With pnl
                .Name = "poz" & nrpoz
                .Location = New Point(0, pnlwewn.Size.Height)
                .Size = New Size(pnlwewn.Size.Width, 60)
            End With
            With lbltekst
                .Name = "lbl" & nrpoz
                If TypeOf i Is UTWOR Then .Text = i.tytul Else .Text = i.nazwa
                .Font = New Font("Segoe UI", 12, FontStyle.Bold)
                .TextAlign = ContentAlignment.MiddleLeft
                .Location = New Point(5, 0)
                .Size = New Size(pnlwewn.Size.Width - 5, 30)
                .Parent = pnl
            End With
            If selectedtab = 0 Or (selectedtab = 1 And Not searchempty) Or (selectedtab = 2 And PATHpl IsNot Nothing) Then
                With lbltekst2
                    .Name = "lbl" & nrpoz
                    .Text = i.FKalbum.FKwykonawca.nazwa
                    .Font = New Font("Segoe UI", 8)
                    .Location = New Point(5, 30)
                    .Size = New Size(250, 15)
                    .Parent = pnl
                End With
                AddHandler lbltekst2.MouseMove, AddressOf podswietl
                AddHandler lbltekst2.Click, AddressOf klikpoz
            End If
            If TypeOf REFpoz(0) Is UTWOR And Not (selectedtab = 1 And Not searchempty) Then
                With lbltekst3
                    .Name = "lbl" & nrpoz
                    .Text = nrpoz + 1
                    .ForeColor = Color.Gray
                    .Font = New Font("Segoe UI", 7)
                    .Location = New Point(8, 45)
                    .Size = New Size(250, 15)
                    .Parent = pnl
                End With
                AddHandler lbltekst3.MouseMove, AddressOf podswietl
                AddHandler lbltekst3.Click, AddressOf klikpoz
            End If
            For lp As Byte = 0 To 2 Step 1
                btn(lp) = New PictureBox()
                With btn(lp)
                    .Name = lp & "btn" & nrpoz
                    .Parent = pnl
                    .BackColor = Color.WhiteSmoke
                    .Visible = False
                    .Cursor = Cursors.Hand
                    .SizeMode = PictureBoxSizeMode.CenterImage
                    .BorderStyle = BorderStyle.FixedSingle
                    .Location = New Point(284 + lp * 35, 25)
                    .Size = New Size(30, 30)
                    Select Case lp
                        Case 0
                            Select Case selectedtab
                                Case 0
                                    .Image = My.Resources.folder
                                Case 1
                                    If (PATHwyk IsNot Nothing And PATHalb IsNot Nothing) Or (selectedtab = 1 And Not searchempty) Then
                                        .Image = My.Resources.add_button_inside_black_circle
                                    End If
                                Case 2
                                    If PATHpl IsNot Nothing Then
                                        .Image = My.Resources.folder
                                    End If
                            End Select
                        Case 1
                            If selectedtab = 0 Then
                                .Image = My.Resources.switch_vertical_orientation_arrows
                            Else
                                If selectedtab = 2 And PATHpl IsNot Nothing Then
                                    .Image = My.Resources.switch_vertical_orientation_arrows
                                Else
                                    If (selectedtab = 1 And Not searchempty) Then
                                        .Image = My.Resources.folder
                                    Else
                                        .Image = My.Resources.pencil_edit_button
                                    End If
                                End If
                            End If
                        Case 2
                            If Not (selectedtab = 1 And Not searchempty) Then .Image = My.Resources.delete__2_
                    End Select
                End With
                pnl.Controls.Add(btn(lp))
                AddHandler btn(lp).MouseMove, AddressOf btnplay_MouseMove
                AddHandler btn(lp).MouseLeave, AddressOf btnplay_MouseLeave
                AddHandler btn(lp).Click, AddressOf btnclick
            Next

            pnl.Controls.Add(lbltekst)

            If searchempty OrElse lbltekst.Text.ToLower() Like "*" & txtsearch.Text.ToLower() & "*" Then
                pnlwewn.Controls.Add(pnl)
                pnlwewn.Size = New Size(pnlwewn.Size.Width, pnlwewn.Size.Height + 60)
            End If
            AddHandler pnl.MouseMove, AddressOf podswietl
            AddHandler lbltekst.MouseMove, AddressOf podswietl
            AddHandler pnl.Click, AddressOf klikpoz
            AddHandler lbltekst.Click, AddressOf klikpoz
            nrpoz += 1
        Next



        pnllista.Controls.Add(pnlwewn)
        If pnllista.VerticalScroll.Visible Then
            pnlwewn.Size = New Size(pnlwewn.Size.Width - 19, pnlwewn.Size.Height)
            Try
                pnllista.VerticalScroll.Value = scrollpos
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub klikpoz(sender As Object, e As EventArgs)
        If TypeOf REFpoz(sender.Name.SubString(3)) Is WYKONAWCA Then
            PATHwyk = REFpoz(sender.Name.SubString(3))
            If dane.SEThidealbums Then
                For Each i As ALBUM In PATHwyk.albumy
                    If i.brakpozycji Then
                        PATHalb = i
                        Exit For
                    End If
                Next
            End If
            ladujpanel()
        Else
            If TypeOf REFpoz(sender.Name.SubString(3)) Is ALBUM Then
                PATHalb = REFpoz(sender.Name.SubString(3))
                ladujpanel()
            Else
                If TypeOf REFpoz(sender.Name.SubString(3)) Is PLAYLISTA Then
                    PATHpl = REFpoz(sender.Name.SubString(3))
                    ladujpanel()
                Else
                    If TypeOf REFpoz(sender.Name.SubString(3)) Is UTWOR Then
                        yt.odtworzteraz(REFpoz(sender.Name.SubString(3)))
                    End If
                End If
            End If
        End If
        pnllista.Focus()
    End Sub

    Private Sub btnclick(sender As Object, e As EventArgs)
        Dim index As Integer = sender.Name.SubString(4)
        Select Case sender.Name.SubString(0, 1)
            Case "0" 'przejdz do i dodaj do playlisty
                Select Case selectedtab
                    Case 0, 2
                        PATHalb = REFpoz(index).FKalbum
                        PATHwyk = REFpoz(index).FKalbum.FKwykonawca
                        selectedtab = 1
                        ladujpanel()
                    Case 1
                        odtwarzane.dodajutwor(REFpoz(index))
                End Select
            Case "1" 'przesun i edycja (wyszukiwanie: przejdz do)
                If (selectedtab = 1 And Not searchempty) Then
                    PATHalb = REFpoz(index).FKalbum
                    PATHwyk = REFpoz(index).FKalbum.FKwykonawca
                    searchempty = True
                    txtsearch.Text = "Szukaj..."
                    txtsearch.ForeColor = Color.Gray
                    pnllista.Focus()
                Else
                    If TypeOf REFpoz(0) Is UTWOR And Not selectedtab = 1 Then
                        MODpozycja.ustaw(REFpoz.Count, index)
                        MODpozycja.ShowDialog()
                        If selectedtab = 0 Then
                            odtwarzane.usunutwor(REFpoz(index))
                            odtwarzane.utwory.Insert(MODpozycja.wynik, REFpoz(index))
                        Else
                            PATHpl.usunutwor(REFpoz(index))
                            PATHpl.utwory.Insert(MODpozycja.wynik, REFpoz(index))
                        End If
                        MODpozycja.Close()
                    Else
                        If TypeOf REFpoz(0) Is PLAYLISTA Then
                            MODpl.modyfikuj(REFpoz(index))
                            MODpl.ShowDialog()
                            MODpl.Close()
                        End If
                        If TypeOf REFpoz(0) Is WYKONAWCA Then
                            If REFpoz(index).brakpozycji Then
                                MsgBox("Nie można edytować domyślnej pozycji!", MsgBoxStyle.Information, "YTMP")
                            Else
                                MODwyk.modyfikuj(REFpoz(index))
                                MODwyk.ShowDialog()
                                MODwyk.Close()
                            End If
                        End If
                        If TypeOf REFpoz(0) Is ALBUM Then
                            If REFpoz(index).brakpozycji Then
                                MsgBox("Nie można edytować domyślnej pozycji!", MsgBoxStyle.Information, "YTMP")
                            Else
                                MODalb.modyfikuj(REFpoz(index))
                                MODalb.ShowDialog()
                                MODalb.Close()
                            End If
                        End If
                        If TypeOf REFpoz(0) Is UTWOR Then
                            MODutw.modyfikuj(REFpoz(index))
                            MODutw.ShowDialog()
                            MODutw.Close()
                        End If
                    End If
                End If
                ladujpanel()
            Case "2" 'usun
                Select Case selectedtab
                    Case 0
                        odtwarzane.utwory.Remove(REFpoz(index))
                        ladujpanel()
                    Case 1
                        If PATHwyk Is Nothing Then
                            If MsgBox("Usunąć wykonawcę oraz wszystkie albumy i utwory należące do niego?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
                                REFpoz(index).usunmnie()
                                ladujpanel()
                            End If
                        Else
                            If PATHalb Is Nothing Then
                                If MsgBox("Usunąć album oraz wszystkie utwory należące do niego?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
                                    REFpoz(index).usunmnie()
                                    ladujpanel()
                                End If
                            Else
                                If MsgBox("Usunąć utwór?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
                                    REFpoz(index).usunmnie()
                                    ladujpanel()
                                End If
                            End If
                        End If
                    Case 2
                        If PATHpl Is Nothing Then
                            If MsgBox("Usunąć całą playlistę?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
                                dane.playlisty.Remove(REFpoz(index))
                                ladujpanel()
                            End If
                        Else
                            PATHpl.usunutwor(REFpoz(index))
                            ladujpanel()
                        End If
                End Select
        End Select
    End Sub

    Private Sub podswietl(sender As Object, e As MouseEventArgs)
        For Each i As Control In pnlwewn.Controls
            If TypeOf i Is Panel Then
                For Each i2 As Control In i.Controls
                    If TypeOf i2 Is PictureBox And i2.Parent.BackColor = Color.Gainsboro Then i2.Visible = False
                    If i2.BackColor = Color.LightGray Then i2.BackColor = Color.Gainsboro
                Next
                If i.BackColor = Color.LightGray Then i.BackColor = Color.Gainsboro
            End If
        Next
        sender.BackColor = Color.LightGray
        For Each i As Control In sender.Controls
            If TypeOf i Is Label Then i.BackColor = Color.LightGray
        Next
        If sender.Parent.Name.SubString(0, 3) = "poz" Then
            sender.Parent.BackColor = Color.LightGray
        End If
        If TypeOf sender Is Label Then
            For Each i As Control In sender.Parent.Controls
                If TypeOf i Is PictureBox AndAlso CType(i, PictureBox).Image IsNot Nothing Then i.Visible = True
                If TypeOf i Is Label Then i.BackColor = Color.LightGray
            Next
        Else
            For Each i As Control In sender.Controls
                If TypeOf i Is PictureBox AndAlso CType(i, PictureBox).Image IsNot Nothing Then i.Visible = True
            Next
        End If
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
                End If
            Case 2
                If MsgBox("Usunąć wszystkie pozycje z listy?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
                    PATHpl.utwory.Clear()
                    ladujpanel()
                End If
        End Select
    End Sub

    Private Sub btnodtwall_Click(sender As Object, e As EventArgs) Handles btnodtwall.Click
        odtwarzane.utwory.Clear()
        If REFpoz.Count > 0 Then
            If TypeOf REFpoz(0) Is UTWOR Then
                For Each u As UTWOR In REFpoz
                    odtwarzane.dodajutwor(u)
                Next
            End If
            If TypeOf REFpoz(0) Is ALBUM Then
                For Each a As ALBUM In REFpoz
                    For Each u As UTWOR In a.utwory
                        odtwarzane.dodajutwor(u)
                    Next
                Next
            End If
            If TypeOf REFpoz(0) Is WYKONAWCA Then
                For Each w As WYKONAWCA In REFpoz
                    For Each a As ALBUM In w.albumy
                        For Each u As UTWOR In a.utwory
                            odtwarzane.dodajutwor(u)
                        Next
                    Next
                Next
            End If
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
            Else
                MsgBox("Lista odtwarzania jest pusta!" & vbNewLine & "Aby utworzyć nową playliste, dodaj pierw utwory do listy odtwarzania", MsgBoxStyle.Exclamation, "YTMP")
            End If
        Else
            If PATHwyk Is Nothing Then
                newitemform.laduj(1)
                ladujpanel()
            Else
                If PATHalb Is Nothing Then
                    newitemform.laduj(2)
                    ladujpanel()
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
        End If
    End Sub

    Private Sub ZwiększGłośnośćToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZwiększGłośnośćToolStripMenuItem.Click
        If dane.volume <= 90 Then
            dane.volume += 10
            pnlglosnosc.Size = New Size(dane.volume, pnlglosnosc.Size.Height)
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
    End Sub

    Private Sub pnlrewind_MouseLeave(sender As Object, e As EventArgs) Handles pnlrewind.MouseLeave, pnlprzewijanie.MouseLeave
        rewindstate = -1
    End Sub

    Private Sub pnlrewind_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlrewind.MouseMove, pnlprzewijanie.MouseMove
        rewindstate = e.Location.X / pnlrewind.Size.Width
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        updateform.Show()
    End Sub

    Private Sub btnX_MouseMove(sender As Object, e As MouseEventArgs) Handles btnX.MouseMove, btnM.MouseMove
        sender.BackColor = Color.FromArgb(belkapnl.BackColor.R - 20, belkapnl.BackColor.G - 20, belkapnl.BackColor.B - 20)
    End Sub

    Private Sub btnX_MouseLeave(sender As Object, e As EventArgs) Handles btnX.MouseLeave, btnM.MouseLeave
        sender.BackColor = belkapnl.BackColor
    End Sub

    Private Sub btnX_MouseDown(sender As Object, e As MouseEventArgs) Handles btnX.MouseDown, btnM.MouseDown
        sender.BackColor = Color.FromArgb(belkapnl.BackColor.R - 40, belkapnl.BackColor.G - 40, belkapnl.BackColor.B - 40)
    End Sub

    Private Sub btnX_MouseUp(sender As Object, e As MouseEventArgs) Handles btnX.MouseUp, btnM.MouseUp
        sender.BackColor = Color.FromArgb(belkapnl.BackColor.R - 20, belkapnl.BackColor.G - 20, belkapnl.BackColor.B - 20)
        If sender.Name = "btnX" Then Close() Else WindowState = FormWindowState.Minimized
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
        e.Graphics.DrawRectangle(New Pen(New SolidBrush(Color.FromArgb(100, 100, 100)), 2), New Rectangle(0, 0, Size.Width, Size.Height))
    End Sub

    Private Sub tab1_Click(sender As Object, e As EventArgs) Handles tab1.Click, tab2.Click, tab3.Click
        selectedtab = sender.Name.Substring(sender.Name.Length - 1, 1) - 1
    End Sub
End Class
