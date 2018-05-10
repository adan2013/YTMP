Public Class updateform

    Dim pnlfore As Panel = New Panel()
    Dim _downloadproc As Integer = 0
    Dim errmessage As String = ""

    Property downloadproc() As Integer
        Get
            Return _downloadproc
        End Get
        Set(value As Integer)
            If value < 0 Then
                _downloadproc = 0
            Else
                If value > 100 Then
                    _downloadproc = 100
                Else
                    _downloadproc = value
                End If
            End If
            pnlfore.Size = New Size(_downloadproc / 100 * pnlback.Size.Width, pnlfore.Size.Height)
            lblproc.Text = _downloadproc & "%"
        End Set
    End Property

    Enum SCENA
        empty = 0
        start = 1
        pobieranie = 2
        gotowosc = 3
        pomyslnains = 4
        blad = 5
    End Enum

    Private Sub updateform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With pnlfore
            .BackColor = Color.Red
            .Location = pnlback.Location
            .Size = New Size(downloadproc, pnlback.Size.Height)
            .Visible = False
        End With
        Controls.Add(pnlfore)
        ladujscene(SCENA.empty)
    End Sub

    Private Sub linkgithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkgithub.LinkClicked
        Try
            Process.Start("https://github.com/adan2013/YTMP/releases")
        Catch ex As Exception
            MsgBox("Wystąpił błąd podczas uruchamiania przeglądarki internetowej!", MsgBoxStyle.Critical, "YTMP")
        End Try
    End Sub

    Private Sub ladujscene(ByVal sc As SCENA)
        lblopis.Visible = False
        lblproc.Visible = False
        pnlback.Visible = False
        pnlfore.Visible = False
        linkgithub.Visible = False
        btn1.Visible = False
        btn2.Visible = False
        btn3.Visible = False
        Select Case sc
            Case SCENA.start
                lbltytul.Text = "Dostępna jest nowa wersja aplikacji YTMP"
                lblopis.Text = "Możesz ją zainstalować samodzielnie pobierając jej pliki z serwisu GitHub" & vbNewLine & "lub skorzystać z automatycznej aktualizacji"
                lblopis.Visible = True
                linkgithub.Visible = True
                btn2.Text = "Odłóż na później"
                btn2.Visible = True
                btn3.Text = "Pobierz aktualizację"
                btn3.Visible = True
                Size = New Size(Size.Width, 260)
            Case SCENA.pobieranie
                lbltytul.Text = "Trwa pobieranie aktualizacji"
                lblopis.Text = "Proszę czekać, trwa pobieranie aktualizacji z serwerów GitHub..."
                lblopis.Visible = True
                downloadproc = 0
                pnlback.Visible = True
                pnlfore.Visible = True
                lblproc.Visible = True
                zmienroz(190)
            Case SCENA.gotowosc
                lbltytul.Text = "Aktualizacja gotowa do zainstalowania"
                lblopis.Text = "Pliki są gotowe do instalacji, możesz uruchomić instalację teraz lub później"
                lblopis.Visible = True
                downloadproc = 100
                pnlback.Visible = True
                pnlfore.Visible = True
                lblproc.Visible = True
                btn1.Text = "Usuń ją z komputera"
                btn2.Text = "Odłóż na później"
                btn3.Text = "Uruchom instalację"
                zmienroz(260, True, True, True)
            Case SCENA.pomyslnains
                lbltytul.Text = "Aktualizacja została zainstalowana"
                lblopis.Text = "Proces instalacji został zakończony pomyślnie!"
                lblopis.Visible = True
                btn3.Text = "OK"
                btn3.Visible = True
                Size = New Size(Size.Width, 260)
            Case SCENA.blad
                lbltytul.Text = "Podczas aktualizacji wystąpił błąd"
                lblopis.Text = "Komunikat błędu: " & errmessage
                lblopis.Visible = True
                btn2.Text = "Ponów próbę"
                btn3.Text = "Zamknij"
                zmienroz(260, False, True, True)
        End Select
    End Sub

    Private Sub zmienroz(ByVal nowy As Integer, Optional ByVal show1 As Boolean = False, Optional ByVal show2 As Boolean = False, Optional ByVal show3 As Boolean = False)

    End Sub
End Class