Imports Gecko
Imports System.IO
Imports Gecko.Events
Public Class ytbrowser

    Dim allowurl() As String = {"https://www.youtube.com", "https://accounts.google.com", "https://accounts.youtube.com", "about:blank"}
    Dim WithEvents browser As GeckoWebBrowser

    Public trybadd As strbtnadd = strbtnadd.brak
    Public plid As String = ""
    Public vid As String = ""
    Public vname As String = ""
    Public editutw As UTWOR = Nothing
    Public initurl As String = ""

    Public Enum strbtnadd
        brak = 0
        utwor = 1
        playlista = 2
        utworiplaylista = 3
    End Enum

    Private Sub browser_Navigated(sender As Object, e As GeckoNavigatedEventArgs) Handles browser.Navigated
        txturl.Text = e.Uri.ToString()
        Dim ok As Boolean = False
        For Each i As String In allowurl
            If e.Uri.ToString().IndexOf(i) = 0 Then
                ok = True
                Exit For
            End If
        Next
        If Not ok Then
            MsgBox("Przeglądarka nie pozwala na wychodzenie poza serwis YouTube!", MsgBoxStyle.Exclamation, "YTMP")
            browser.GoBack()
        End If
        Debug.WriteLine(e.Uri)
    End Sub

    Private Sub ytbrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        browser = New GeckoWebBrowser()
        ytbrowser_Resize(Me, New EventArgs())
        Controls.Add(browser)
        If initurl = "" Then browser.Navigate("https://youtube.com") Else browser.Navigate(initurl)
        browser.Select()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        browser.GoBack()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnforward.Click
        browser.GoForward()
    End Sub

    Private Sub btnreload_Click(sender As Object, e As EventArgs) Handles btnreload.Click
        browser.Reload()
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        browser.Navigate("https://youtube.com")
    End Sub

    Private Function getvid(ByVal s As String) As String
        s = s.Substring("https://www.youtube.com/watch?v=".Length)
        If s.IndexOf("&") > 0 Then s = s.Substring(0, s.IndexOf("&"))
        Return s
    End Function

    Private Function getplid(ByVal s As String) As String
        If s.IndexOf("&list=") > 0 Then
            s = s.Substring(s.IndexOf("&list=") + 6)
        Else
            s = s.Substring(s.IndexOf("?list=") + 6)
        End If
        If s.IndexOf("&") > 0 Then s = s.Substring(0, s.IndexOf("&"))
        Return s
    End Function

    Private Sub akt_Tick(sender As Object, e As EventArgs) Handles akt.Tick
        Dim n As strbtnadd = strbtnadd.brak

        If txturl.Text.IndexOf("https://www.youtube.com/watch?v=") = 0 Then
            n = strbtnadd.utwor
            vid = getvid(txturl.Text)
            Dim name As String = ""
            Dim g As GeckoElementCollection = browser.Document.GetElementsByTagName("h1")
            If g.Length > 0 Then
                For i As Integer = 0 To g.Length - 1 Step 1
                    If g.Item(i).ClassName.IndexOf("watch-title-container") >= 0 Then
                        name = g.Item(i).TextContent.Trim()
                    End If
                Next
            End If
            vname = name
        End If

        If editutw Is Nothing And (txturl.Text.IndexOf("&list=") > 0 Or txturl.Text.IndexOf("?list=") > 0) Then
            If n = strbtnadd.utwor Then n = strbtnadd.utworiplaylista Else n = strbtnadd.playlista
            plid = getplid(txturl.Text)
        End If

        Select Case n
            Case strbtnadd.brak
                If editutw Is Nothing Then
                    lblinfo.Text = "Znajdź i przejdź do interesującego Ciebie filmiku lub playlisty, a następnie dodaj go do biblioteki programu"
                    btnaddpl.Enabled = False
                    btnaddutw.Enabled = False
                Else
                    lblinfo.Text = "Jesteś w trybie edycji utworu. Znajdź nowy film do podmiany za poprzedni..."
                    btnokedit.Enabled = False
                End If
            Case strbtnadd.utwor
                If editutw Is Nothing Then
                    lblinfo.Text = "Znaleziono utwór " & IIf(vname = "", "", vname & " ") & "o identyfikatorze " & vid
                    btnaddpl.Enabled = False
                    btnaddutw.Enabled = True
                Else
                    lblinfo.Text = "Jesteś w trybie edycji utworu. Znaleziono utwór " & IIf(vname = "", "", vname & " ") & "o identyfikatorze " & vid
                    btnokedit.Enabled = True
                End If
            Case strbtnadd.playlista
                lblinfo.Text = "Znaleziono playlistę o identyfikatorze " & plid
                btnaddpl.Enabled = True
                btnaddutw.Enabled = False
            Case strbtnadd.utworiplaylista
                lblinfo.Text = "Znaleziono utwór o id: " & vid & " oraz playlistę o id: " & plid
                btnaddpl.Enabled = True
                btnaddutw.Enabled = True
        End Select
        skrocstring(lblinfo, Size.Width - 290, lblinfo.Text)
        trybadd = n
    End Sub

    Private Sub btnaddutw_Click(sender As Object, e As EventArgs) Handles btnaddutw.Click
        If trybadd = strbtnadd.brak Then Exit Sub
        Select Case trybadd
            Case strbtnadd.utwor, strbtnadd.utworiplaylista
                IMPORTutw.ShowDialog()
                IMPORTutw.Close()
        End Select
    End Sub

    Private Sub ytbrowser_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If browser IsNot Nothing Then
            browser.Location = New Point(0, 55)
            browser.Size = New Size(Size.Width - 15, Size.Height - 145)
            txturl.Size = New Size(Size.Width - 306, txturl.Size.Height)
            btnaddutw.Location = New Point(Size.Width - 138, Size.Height - 77)
            btnaddpl.Location = New Point(Size.Width - 264, Size.Height - 77)
            btnokedit.Location = New Point(Size.Width - 138, Size.Height - 77)
            btncanceledit.Location = New Point(Size.Width - 264, Size.Height - 77)
            lblinfo.Location = New Point(lblinfo.Location.X, Size.Height - 72)
        End If
    End Sub

    Private Sub browser_CreateWindow2(sender As Object, e As GeckoCreateWindow2EventArgs) Handles browser.CreateWindow2
        browser.Navigate(e.Uri)
        e.Cancel = True
    End Sub

    Private Sub btncanceledit_Click(sender As Object, e As EventArgs) Handles btncanceledit.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnokedit_Click(sender As Object, e As EventArgs) Handles btnokedit.Click
        If editutw Is Nothing Then
            DialogResult = DialogResult.Cancel
        Else
            If MODutw.Visible Then
                MODutw.lblid.Text = vid
                DialogResult = DialogResult.OK
            Else
                DialogResult = DialogResult.Cancel
            End If
        End If
    End Sub

    Public Sub edytujutwor(ByRef utw As UTWOR)
        editutw = utw
        If editutw IsNot Nothing Then
            btncanceledit.Visible = True
            btnokedit.Visible = True
            btnaddpl.Visible = False
            btnaddutw.Visible = False
        Else
            btncanceledit.Visible = False
            btnokedit.Visible = False
            btnaddpl.Visible = True
            btnaddutw.Visible = True
        End If
        initurl = "https://www.youtube.com/watch?v=" & editutw.link
    End Sub

    Public Sub zmienstrone(ByVal url As String)
        initurl = url
    End Sub

    Private Sub ytbrowser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        akt.Enabled = False
        browser.Dispose()
        Form1.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnaddpl_Click(sender As Object, e As EventArgs) Handles btnaddpl.Click
        IMPORTplaylist.plid = plid
        IMPORTplaylist.ShowDialog()
        IMPORTplaylist.Close()
    End Sub
End Class