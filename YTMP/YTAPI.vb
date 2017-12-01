Imports Gecko
Imports System.IO
Imports Gecko.Events

Public Class YTAPI

    Public currenttime As Integer = 0
    Public durationtime As Integer = 0
    Public wyciszony As Boolean = False
    Public glosnosc As SByte = 100
    Public tekststatus As String = ""
    Public state As YTstate = YTstate.nieuruchomiono

    Dim WithEvents browser As GeckoWebBrowser

    Public updatever As String = "0"
    Public stoper As Stopwatch = New Stopwatch()
    Public directplay As UTWOR = Nothing
    Public wskaznikpl As UTWOR = Nothing
    Public historia As List(Of UTWOR) = New List(Of UTWOR)

    Enum YTstate
        nieuruchomiono = -1
        zakonczony = 0
        odtwarzanie = 1
        wstrzymany = 2
        buforowanie = 3
        filmwskazany = 5
    End Enum

    Public Sub usun()
        browser.Dispose()
    End Sub

    Public Sub New()
        Gecko.Xpcom.Initialize(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "xulrunner"))
        browser = New GeckoWebBrowser()
        browser.Visible = False
        'browser.Visible = True
        'browser.Location = New Point(80, 80)
        'browser.Size = New Size(300, 300)
        Form1.Controls.Add(browser)
        'browser.BringToFront()
    End Sub

    Private Sub loadwebpage(ByRef utw As UTWOR)
        'browser.Navigate("https://serwer1657623.home.pl/testapiyt.php?vid=" & utw.link & "&stime=" & utw.start)
        'browser.Navigate("https://adan2013.github.io/YTMP/?vid=" & utw.link & "&stime=" & utw.start & "&q=" & getq())
        browser.Navigate("https://adan2013.github.io/YTMP/?vid=" & utw.link & "&stime=" & utw.start)
        historia.Remove(utw)
        historia.Add(utw)
        If dane.SETdymek Then
            Form1.notify.BalloonTipText = """" & utw.tytul & """ " & utw.FKalbum.FKwykonawca.nazwa
            Form1.notify.ShowBalloonTip(1800)
        End If
        If dane.SETshowtitlewindow Then
            Form1.Text = """" & utw.tytul & """ " & utw.FKalbum.FKwykonawca.nazwa & " - YouTube Media Player"
        Else
            Form1.Text = "YouTube Media Player"
        End If
    End Sub

    Private Sub filtr(ByRef tekst As String, ByVal znacznik As String, ByVal wartosc As String)
        tekst = tekst.Replace(znacznik, wartosc)
    End Sub

    Private Function getcontent(ByVal id As String) As String
        If browser.Document IsNot Nothing Then
            If browser.Document.GetElementById(id) Is Nothing Then
                Return ""
            Else
                Return browser.Document.GetElementById(id).TextContent
            End If
        Else
            Return ""
        End If
    End Function

    Private Sub pushbutton(ByVal id As String)
        Try
            Dim button As Gecko.DOM.GeckoButtonElement = New Gecko.DOM.GeckoButtonElement(browser.Document.GetElementById(id).DOMElement)
            button.Click()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub przewin(ByVal proc As Double)
        If durationtime > 0 Then
            Try
                Dim button As Gecko.DOM.GeckoButtonElement = New Gecko.DOM.GeckoButtonElement(browser.Document.GetElementById("rewind").DOMElement)
                button.SetAttribute("onclick", "player.seekTo(" & (proc * durationtime) & ", true)")
                button.Click()
                pushbutton("play")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub przewindopocz(ByRef utw As UTWOR)
        przewin(utw.start / durationtime)
    End Sub

    Private Sub zmienglosnosc(ByVal nowawartosc As SByte)
        Try
            Dim button As Gecko.DOM.GeckoButtonElement = New Gecko.DOM.GeckoButtonElement(browser.Document.GetElementById("setvol").DOMElement)
            button.SetAttribute("onclick", "player.setVolume(" & nowawartosc & ")")
            button.Click()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub sterujglosnoscia(ByVal nowawartosc As Boolean)
        If nowawartosc Then pushbutton("mute") Else pushbutton("unmute")
    End Sub

    Private Function konwertujnaczas(ByVal wartosc As Integer, ByVal start As Boolean) As String
        Dim s As String = wartosc \ 60
        If s.Length = 1 Then s = "0" & s
        s &= ":"
        s &= IIf(wartosc Mod 60 < 10, "0", "") & (wartosc Mod 60)
        Dim second As Integer = 0
        If dane.SETczas And (directplay IsNot Nothing Or wskaznikpl IsNot Nothing) Then
            If start Then
                second = IIf(directplay Is Nothing, wskaznikpl, directplay).start
            Else
                second = IIf(directplay Is Nothing, wskaznikpl, directplay).koniec
            End If
            If second > 0 Then
                Dim s2 As String = second \ 60
                If s2.Length = 1 Then s2 = "0" & s2
                s2 &= ":"
                s2 &= IIf(second Mod 60 < 10, "0", "") & (second Mod 60)
                s &= vbNewLine & "(" & s2 & ")"
            End If
        End If
        Return s
    End Function

    Public Sub aktualizacja()
        Static pozloading As SByte = 0
        Dim s As String = ""
        s = getcontent("INFOcurrent")
        If s = "" Then currenttime = 0 Else currenttime = s
        If directplay Is Nothing And wskaznikpl Is Nothing Then currenttime = 0
        Form1.lblstart.Text = konwertujnaczas(currenttime, True)
        s = getcontent("INFOduration")
        If s = "" Then durationtime = 0 Else durationtime = s
        If directplay Is Nothing And wskaznikpl Is Nothing Then durationtime = 0
        Form1.lblkoniec.Text = konwertujnaczas(durationtime, False)
        If durationtime > 0 Then
            Form1.pnlprzewijanie.Size = New Size(currenttime / durationtime * Form1.pnlrewind.Size.Width, Form1.pnlprzewijanie.Size.Height)
        Else
            Form1.pnlprzewijanie.Size = New Size(0, Form1.pnlprzewijanie.Size.Height)
        End If
        s = getcontent("INFOstate")
        If s = "" Then state = YTstate.nieuruchomiono Else state = s
        If state = YTstate.odtwarzanie Or state = YTstate.buforowanie Then
            If Form1.btnplay.Image IsNot My.Resources.pause_button Then Form1.btnplay.Image = My.Resources.pause_button
        Else
            If Form1.btnplay.Image IsNot My.Resources.play_button Then Form1.btnplay.Image = My.Resources.play_button
        End If
        s = getcontent("INFOismuted")
        If s = "" Then
            wyciszony = False
        Else
            If s = "true" Then wyciszony = True Else wyciszony = False
            If Not wyciszony = dane.MODmute Then sterujglosnoscia(dane.MODmute)
        End If
        s = getcontent("INFOvolume")
        If s = "" Then
            glosnosc = 100
        Else
            glosnosc = s
            If Not glosnosc = dane.volume Then zmienglosnosc(dane.volume)
        End If
        Dim ob As UTWOR = Nothing
        If wskaznikpl Is Nothing Then
            If directplay Is Nothing Then
                tekststatus = "Brak utworu"
            Else
                ob = directplay
            End If
        Else
            ob = wskaznikpl
        End If
        If ob IsNot Nothing Then tekststatus = """" & ob.tytul & """ " & ob.FKalbum.FKwykonawca.nazwa
        Select Case state
            Case YTstate.buforowanie
                tekststatus &= " - Buforowanie... [" & IIf(pozloading = 0, "#", "_") & IIf(pozloading = 1, "#", "_") & IIf(pozloading = 2, "#", "_") & "]"
            Case YTstate.odtwarzanie
                tekststatus &= " - Odtwarzanie"
            Case YTstate.wstrzymany
                tekststatus &= " - Wstrzymano"
            Case YTstate.zakonczony
                tekststatus &= " - Zatrzymano"
        End Select
        If stoper.IsRunning Then
            Dim poz As Integer = dane.SETopoznienie - stoper.ElapsedMilliseconds
            If poz < 0 Then poz = 0
            tekststatus = "Opóźnienie przełączenia utwóru (Pozostało: " & Math.Round(poz / 1000, 1) & "s)"
        End If
        If state = YTstate.zakonczony Or (ob IsNot Nothing AndAlso ob.koniec = currenttime AndAlso ob.koniec > 0 AndAlso state = YTstate.odtwarzanie) Then
            Dim nast As Boolean = False
            If dane.SETopoznienie = 0 Then
                nast = True
                If stoper.IsRunning Then stoper.Reset()
            Else
                If stoper.IsRunning Then
                    If dane.SETopoznienie <= stoper.ElapsedMilliseconds Then
                        stoper.Reset()
                        nast = True
                    End If
                Else
                    playpause()
                    stoper.Start()
                End If
            End If
            If nast Then
                If dane.MODrep Then
                    If directplay Is Nothing Then przewindopocz(wskaznikpl) Else przewindopocz(directplay)
                Else
                    nastepnyutwor()
                End If
            End If
        Else
            If stoper.IsRunning Then stoper.Reset()
        End If
        pozloading += 1
        If pozloading >= 3 Then pozloading = 0
        If Form1.rewindstate >= 0 And (wskaznikpl IsNot Nothing Or directplay IsNot Nothing) And durationtime > 0 Then
            Dim t As String = Form1.rewindstate * durationtime \ 60
            If t.Length = 1 Then t = "0" & t
            t &= ":" & IIf(Math.Round(Form1.rewindstate * durationtime Mod 60, 0) < 10, "0", "") & Math.Round(Form1.rewindstate * durationtime Mod 60, 0)
            tekststatus = "Przewiń utwór do minuty: " & t
        End If
        'Dim v As String = getcontent("INFOversion")
        'If v = "" Then
        '    updatever = "0"
        'Else
        '    updatever = v
        '    If updatever = Form1.wersja Then
        '        If Form1.btnupdate.Visible Then Form1.btnupdate.Visible = False
        '    Else
        '        If Not Form1.btnupdate.Visible Then Form1.btnupdate.Visible = True
        '    End If
        'End If
    End Sub

    Public Sub odtworzteraz(ByRef obiekt As UTWOR)
        If odtwarzane.utwory.Contains(obiekt) Then
            directplay = Nothing
            wskaznikpl = obiekt
            loadwebpage(wskaznikpl)
        Else
            directplay = obiekt
            loadwebpage(directplay)
        End If
    End Sub

    Public Sub poprzedniutwor()
        pushbutton("pause")
        directplay = Nothing
        If wskaznikpl IsNot Nothing Then historia.Remove(wskaznikpl)
        Do
            If historia.Count > 0 Then
                If odtwarzane.utwory.Contains(historia(historia.Count - 1)) Then
                    wskaznikpl = historia(historia.Count - 1)
                    loadwebpage(wskaznikpl)
                    Exit Do
                Else
                    historia.RemoveAt(historia.Count - 1)
                End If
            Else
                Exit Do
            End If
        Loop
        If wskaznikpl IsNot Nothing Then pushbutton("play")
    End Sub

    Public Sub nastepnyutwor()
        pushbutton("pause")
        directplay = Nothing
        If odtwarzane.utwory.Count = 0 Then
            wskaznikpl = Nothing
        Else
            If dane.MODran Then
                'random
                Dim los As Integer = New Random().Next(0, odtwarzane.utwory.Count)
                Dim wejscie As Integer
                Do
                    wejscie = los
                    For Each i As UTWOR In odtwarzane.utwory
                        If Not historia.Contains(i) Then
                            If los > 0 Then
                                los -= 1
                            Else
                                wskaznikpl = i
                                Exit Do
                            End If
                        End If
                    Next
                    If los = wejscie Then
                        historia.Clear()
                    End If
                Loop
            Else
                'po kolei
                If odtwarzane.utwory.Contains(wskaznikpl) Then
                    Dim nast As Boolean = False
                    For Each i As UTWOR In odtwarzane.utwory
                        If nast Then
                            nast = False
                            wskaznikpl = i
                            Exit For
                        Else
                            If i Is wskaznikpl Then nast = True
                        End If
                    Next
                    If nast Then wskaznikpl = odtwarzane.utwory(0)
                Else
                    wskaznikpl = odtwarzane.utwory(0)
                End If
            End If
            If wskaznikpl IsNot Nothing Then
                loadwebpage(wskaznikpl)
            End If
        End If
    End Sub

    Public Sub playpause()
        If state = YTstate.odtwarzanie Then
            pushbutton("pause")
        Else
            Dim utw As UTWOR = Nothing
            If directplay IsNot Nothing Then
                utw = directplay
            Else
                If wskaznikpl IsNot Nothing Then
                    utw = wskaznikpl
                Else
                    If odtwarzane.utwory.Count > 0 Then utw = odtwarzane.utwory(0)
                    wskaznikpl = utw
                End If
            End If
            If utw IsNot Nothing Then
                If state = YTstate.wstrzymany Then
                    pushbutton("play")
                Else
                    If state = YTstate.zakonczony Then przewindopocz(utw) Else loadwebpage(utw)
                End If
            End If
        End If
    End Sub
End Class
