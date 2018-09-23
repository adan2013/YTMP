Imports System.ComponentModel
Imports System.Net
Imports System.Web
Imports System.IO.Compression
Public Class updateform

    Public initsc As SCENA = 0

    Dim pnlfore As Panel = New Panel()
    Dim _downloadproc As Integer = 0
    Dim errmessage As String = ""
    Dim celruchu As Integer = 262

    Dim v1 As Boolean = False
    Dim v2 As Boolean = False
    Dim v3 As Boolean = False
    Dim tempdeleted As Boolean = False

    Dim client As WebClient

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
        CheckForIllegalCrossThreadCalls = False
        With pnlfore
            .BackColor = Color.Red
            .Location = New Point(0, 0)
            .Size = New Size(downloadproc, pnlback.Size.Height)
            .Visible = False
        End With
        pnlback.Controls.Add(pnlfore)
        ladujscene(initsc)
    End Sub

    Private Sub linkgithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkgithub.LinkClicked
        Try
            Process.Start("https://github.com/adan2013/YTMP/releases")
            DialogResult = DialogResult.Cancel
        Catch ex As Exception
            MsgBox("Wystąpił błąd podczas uruchamiania przeglądarki internetowej!", MsgBoxStyle.Critical, "YTMP")
        End Try
    End Sub

    Public Sub ladujscene(ByVal sc As SCENA)
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
                Size = New Size(Size.Width, 262)
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
                zmienroz(262, True, True, True)
            Case SCENA.pomyslnains
                lbltytul.Text = "Aktualizacja została zainstalowana"
                lblopis.Text = "Aplikacja została zaktualizowana do wersji " & Form1.wersja & " !"
                lblopis.Visible = True
                btn3.Text = "OK"
                btn3.Visible = True
                Size = New Size(Size.Width, 262)
            Case SCENA.blad
                lbltytul.Text = "Podczas aktualizacji wystąpił błąd"
                lblopis.Text = "Komunikat błędu: " & vbNewLine & errmessage
                If lblopis.Size.Width > 480 Then
                    Do
                        lblopis.Text = lblopis.Text.Substring(0, lblopis.Text.Length - 1)
                    Loop While lblopis.Size.Width > 470
                    lblopis.Text &= "..."
                End If
                lblopis.Visible = True
                btn2.Text = "Ponów próbę"
                btn3.Text = "Zamknij"
                zmienroz(262, False, True, True)
        End Select
        initsc = sc
    End Sub

    Private Sub zmienroz(ByVal nowy As Integer, Optional ByVal show1 As Boolean = False, Optional ByVal show2 As Boolean = False, Optional ByVal show3 As Boolean = False)
        If nowy = Size.Height Then
            If show1 Then btn1.Visible = True
            If show2 Then btn2.Visible = True
            If show3 Then btn3.Visible = True
            celruchu = nowy
            Exit Sub
        End If
        celruchu = nowy
        v1 = show1
        v2 = show2
        v3 = show3
        ruch.Enabled = True
    End Sub

    Private Sub ruch_Tick(sender As Object, e As EventArgs) Handles ruch.Tick
        Debug.WriteLine(celruchu & " " & Size.Height)
        If celruchu = Size.Height Then
            ruch.Enabled = False
            If v1 Then btn1.Visible = True
            If v2 Then btn2.Visible = True
            If v3 Then btn3.Visible = True
        Else
            If celruchu < Size.Height Then
                Size = New Size(Size.Width, Size.Height - 4)
            Else
                Size = New Size(Size.Width, Size.Height + 4)
            End If
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Select Case initsc
            Case SCENA.gotowosc
                If MsgBox("Czy na pewno chcesz usunąć z komputera pliki pobranej wcześniej aktualizacji?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
                    Try
                        If IO.File.Exists(Application.StartupPath & "\YTMP-UPDATE-PACK.zip") Then IO.File.Delete(Application.StartupPath & "\YTMP-UPDATE-PACK.zip")
                        If IO.Directory.Exists(Application.StartupPath & "\YTMP-UPDATE-PACK") Then My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\YTMP-UPDATE-PACK", FileIO.DeleteDirectoryOption.DeleteAllContents)
                        Form1.btnupdate.Visible = False
                        DialogResult = DialogResult.Cancel
                    Catch ex As Exception
                        MsgBox("Wystąpił błąd podczas usuwania plików aktualizacji, może to być spowodowane niewystarczającymi uprawnieniami aplikacji do swojego katalogu", MsgBoxStyle.Critical, "YTMP")
                    End Try
                End If
        End Select
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Select Case initsc
            Case SCENA.start
                DialogResult = DialogResult.Ignore
            Case SCENA.gotowosc
                DialogResult = DialogResult.Ignore
            Case SCENA.blad
                ladujscene(SCENA.start)
        End Select
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Select Case initsc
            Case SCENA.start
                ladujscene(SCENA.pobieranie)
                'uruchomienie pobierania
                Try
                    If Form1.yt.updatelink = "" Then
                        reperr("Aplikacja nie uzyskała adresu źródła pobierania")
                    Else
                        If IO.File.Exists(Application.StartupPath & "\YTMP-UPDATE-PACK.zip") Then IO.File.Delete(Application.StartupPath & "\YTMP-UPDATE-PACK.zip")
                        If IO.Directory.Exists(Application.StartupPath & "\YTMP-UPDATE-PACK") Then My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\YTMP-UPDATE-PACK", FileIO.DeleteDirectoryOption.DeleteAllContents)
                        client = New WebClient()
                        ServicePointManager.SecurityProtocol = CType(768, SecurityProtocolType) Or CType(3072, SecurityProtocolType)
                        AddHandler client.DownloadProgressChanged, AddressOf DownloadProgressChanged
                        AddHandler client.DownloadFileCompleted, AddressOf DownloadFileCompleted
                        client.DownloadFileAsync(New Uri(Form1.yt.updatelink), Application.StartupPath & "\YTMP-UPDATE-PACK.zip")
                    End If
                Catch ex As Exception
                    If client IsNot Nothing AndAlso client.IsBusy Then client.CancelAsync()
                    reperr(ex.Message)
                End Try
            Case SCENA.gotowosc
                'start autoupdater
                If IO.Directory.Exists(Application.StartupPath & "\YTMP-UPDATE-PACK") Then
                    If IO.File.Exists(Application.StartupPath & "\YTMP-UPDATE-PACK\YTMP-AUTOUPDATER.exe") Then
                        Process.Start(Application.StartupPath & "\YTMP-UPDATE-PACK\YTMP-AUTOUPDATER.exe")
                        UNREGISTERHOTKEYS()
                        End
                    Else
                        reperr("Nie znaleziono pliku exe aktualizatora. Możliwe, że nowa wersja nie wspera już automatycznej aktualizacji")
                    End If
                Else
                    reperr("Nie znaleziono plików gotowych do instalacji aktualizacji")
                End If
            Case SCENA.pomyslnains
                Try
                    If IO.File.Exists(Application.StartupPath & "\YTMP-UPDATE-PACK.zip") Then IO.File.Delete(Application.StartupPath & "\YTMP-UPDATE-PACK.zip")
                    If IO.Directory.Exists(Application.StartupPath & "\YTMP-UPDATE-PACK") Then My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\YTMP-UPDATE-PACK", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    If IO.File.Exists(Application.StartupPath & "\install.txt") Then IO.File.Delete(Application.StartupPath & "\install.txt")
                    tempdeleted = True
                    DialogResult = DialogResult.OK
                Catch ex As Exception
                    MsgBox("Wystąpił błąd podczas próby usuwania plików tymczasowych pozostałych po instalacji!", MsgBoxStyle.Critical, "YTMP")
                    DialogResult = DialogResult.Cancel
                End Try
                DialogResult = DialogResult.OK
            Case SCENA.blad
                DialogResult = DialogResult.Cancel
        End Select
    End Sub

    Private Sub DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs)
        If Not e.Cancelled Then
            BWunzip.RunWorkerAsync()
        End If
    End Sub

    Private Sub DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs)
        downloadproc = e.BytesReceived * 100 / e.TotalBytesToReceive
    End Sub

    Private Sub updateform_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If initsc = SCENA.pomyslnains Then
            If Not tempdeleted Then
                e.Cancel = True
                btn3_Click(btn3, New EventArgs())
            End If
        Else
            If client IsNot Nothing AndAlso client.IsBusy Then
                If MsgBox("Czy chcesz przerwać pobieranie plików?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
                    If client IsNot Nothing AndAlso client.IsBusy Then client.CancelAsync()
                Else
                    e.Cancel = True
                End If
            End If
            If BWunzip.IsBusy Then
                If MsgBox("Czy chcesz przerwać proces instalacji?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
                    If BWunzip.IsBusy Then BWunzip.CancelAsync()
                Else
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub BWunzip_DoWork(sender As Object, e As DoWorkEventArgs) Handles BWunzip.DoWork
        Try
            'unzip
            If IO.Directory.Exists(Application.StartupPath & "\YTMP-UPDATE-PACK") Then My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\YTMP-UPDATE-PACK", FileIO.DeleteDirectoryOption.DeleteAllContents)
            IO.Directory.CreateDirectory(Application.StartupPath & "\YTMP-UPDATE-PACK")
            'Dim sc = New Shell32.Shell
            'Dim output As Shell32.Folder = sc.NameSpace(Application.StartupPath & "\YTMP-UPDATE-PACK")
            'Dim input As Shell32.Folder = sc.NameSpace(Application.StartupPath & "\YTMP-UPDATE-PACK.zip")
            'output.CopyHere(input.Items, 4)

            Dim output As String = Application.StartupPath & "\YTMP-UPDATE-PACK"
            Dim input As String = Application.StartupPath & "\YTMP-UPDATE-PACK.zip"
            ZipFile.ExtractToDirectory(input, output)

            Dim dirfiles As String = Application.StartupPath & "\YTMP-UPDATE-PACK"
            For Each i As String In IO.Directory.GetDirectories(dirfiles)
                dirfiles &= "\" & New IO.DirectoryInfo(i).Name
                Exit For
            Next
            My.Computer.FileSystem.MoveDirectory(dirfiles, dirfiles & "\..", True)
        Catch ex As Exception
            reperr(ex.Message)
        End Try
    End Sub

    Private Sub BWunzip_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWunzip.RunWorkerCompleted
        If Not initsc = SCENA.blad Then ladujscene(SCENA.gotowosc)
    End Sub

    Private Sub reperr(ByVal message As String)
        errmessage = message.Replace(vbNewLine, "")
        ladujscene(SCENA.blad)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = &H112) AndAlso (m.WParam.ToInt32() = &HF010) Then
            Return
        End If
        If (m.Msg = &HA1) AndAlso (m.WParam.ToInt32() = &H2) Then
            Return
        End If
        MyBase.WndProc(m)
    End Sub
End Class