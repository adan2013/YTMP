Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Threading
Public Class IMPORTplaylist

    Public plid As String = ""
    Dim input As String = ""

    Dim docelowyWYK As WYKONAWCA
    Dim docelowyALB As ALBUM

    Dim ORIwyk As List(Of String) = New List(Of String)
    Dim REFwyk As List(Of WYKONAWCA) = New List(Of WYKONAWCA)
    Dim REFalb As List(Of ALBUM) = New List(Of ALBUM)
    Dim REFpl As List(Of PLAYLISTA) = New List(Of PLAYLISTA)

    Dim postep As Byte = 0
    Dim nextpagetoken As String = ""

    Private Sub addlog(ByVal s As String)
        txtprogress.Text &= s & vbNewLine
        txtprogress.SelectionStart = txtprogress.Text.Length
        txtprogress.ScrollToCaret()
    End Sub

    Private Function downloadpage(ByVal url As String) As String
        Try
            Dim client As New Net.WebClient
            client.Encoding = System.Text.Encoding.UTF8
            Return client.DownloadString(url)
        Catch ex As Net.WebException
            Dim response As Net.WebResponse = ex.Response
            Using reader As IO.StreamReader = New IO.StreamReader(response.GetResponseStream())
                Dim Text As String = reader.ReadToEnd()
                Return Text
            End Using
        Catch ex As Exception When Not TypeOf ex Is Net.WebException
            Return ""
        End Try
    End Function

    Private Sub IMPORTplaylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each i As WYKONAWCA In dane.wykonawcy
            If i.brakpozycji Then
                docelowyWYK = i
                Exit For
            End If
        Next
        For Each i As ALBUM In docelowyWYK.albumy
            If i.brakpozycji Then
                docelowyALB = i
                Exit For
            End If
        Next
        aktpath()
        ladujlistepl()
        akt.Enabled = True
    End Sub

    Private Sub JSONdeserialize()
        If nextpagetoken = "" Then
            tabela.Rows.Clear()
            ORIwyk.Clear()
            REFwyk.Clear()
            REFalb.Clear()
        End If
        Dim serial As JObject = JObject.Parse(input)
        Dim data As List(Of JToken) = serial.Children().ToList
        Dim output As String = ""
        nextpagetoken = ""

        For Each item As JProperty In data
            item.CreateReader()
            If item.Name = "error" Then
                addlog("ERROR: Serwis YouTube zwrócił komunikat błędu!")
                addlog("Szczegóły: [" & item.Value("code").ToString() & "] " & item.Value("message").ToString())
                Exit Sub
            End If
            If item.Name = "nextPageToken" Then nextpagetoken = item.Value.ToString().Trim()
            If item.Name = "items" Then
                For Each val As JObject In item.Values
                    'Debug.WriteLine("Title: {0}, Vid: {1}", val("snippet")("title"), val("contentDetails")("videoId"))
                    Dim s As String = val("snippet")("title").ToString()
                    Dim utw As String = ""
                    Dim splitwyk As String = ""
                    Dim wyk As WYKONAWCA = Nothing
                    Dim alb As ALBUM = Nothing
                    Dim match As Byte = 0
                    If s.Length > 0 Then
                        If s.IndexOf(" - ") >= 0 Then
                            Dim splits() As String = s.Split(New String() {" - "}, StringSplitOptions.None)
                            splits(0) = splits(0).Trim()
                            splits(1) = splits(1).Trim()
                            comparewyk(splits(0), wyk, match)
                            utw = splits(1)
                            splitwyk = splits(0)
                        Else
                            utw = s
                        End If
                        If wyk Is Nothing Then
                            For Each i As WYKONAWCA In dane.wykonawcy
                                If i.brakpozycji Then
                                    wyk = i
                                    Exit For
                                End If
                            Next
                        End If
                        For Each i As ALBUM In wyk.albumy
                            If i.brakpozycji Then
                                alb = i
                                Exit For
                            End If
                        Next
                        Dim compareinfo As String
                        If match = 0 Then
                            If splitwyk = "" Then
                                'brak wykonawcy w tytule
                                compareinfo = "Brak wykonawcy w tytule"
                                ORIwyk.Add("")
                            Else
                                'propozycja utworzenia
                                compareinfo = "Brak dopasowania (kliknij aby utworzyć '" & splitwyk & "')"
                                ORIwyk.Add(splitwyk)
                            End If
                        Else
                            'dopasowano wykonawce
                            compareinfo = "Znaleziono dopasowanie (" & match & "%)"
                            ORIwyk.Add("")
                        End If
                        REFwyk.Add(wyk)
                        REFalb.Add(alb)
                        tabela.Rows.Add({utw, val("contentDetails")("videoId").ToString(), compareinfo, wyk.nazwa, alb.nazwa, s})
                        addlog("Zaimportowano utwór o id: " & val("contentDetails")("videoId").ToString())
                        Thread.Sleep(100)
                    End If
                Next
            End If
        Next
        If nextpagetoken = "" Then
            addlog("Zakończono proces importu danych!")
        Else
            addlog("Pobieranie następnego pakietu danych...")
            postep = 2
        End If
    End Sub

    Private Sub radiodirect_CheckedChanged(sender As Object, e As EventArgs) Handles radiodirect.CheckedChanged
        If sender.Checked Then
            btnpath.Enabled = True
            lblpath.Enabled = True
        Else
            btnpath.Enabled = False
            lblpath.Enabled = False
        End If
    End Sub

    Private Sub aktpath()
        lblpath.Text = "> " & docelowyWYK.nazwa & " > " & docelowyALB.nazwa & " > ..."
        skrocstring(lblpath, 350, lblpath.Text)
    End Sub

    Private Sub btnpath_Click(sender As Object, e As EventArgs) Handles btnpath.Click
        Dim wybrWYK As WYKONAWCA = Nothing
        Dim wybrALB As ALBUM = Nothing
        selectform.laduj(Nothing, dane, True)
        wybrWYK = selectform.wynik
        selectform.Close()
        If wybrWYK Is Nothing Then
            MsgBox("Anulowano zmianę ścieżki!", MsgBoxStyle.Information, "YTMP")
            Exit Sub
        End If
        selectform.laduj(wybrWYK, dane, True)
        wybrALB = selectform.wynik
        selectform.Close()
        If wybrWYK Is Nothing Or wybrALB Is Nothing Then
            MsgBox("Anulowano zmianę ścieżki!", MsgBoxStyle.Information, "YTMP")
        Else
            docelowyWYK = wybrWYK
            docelowyALB = wybrALB
            aktpath()
        End If
    End Sub

    Private Sub tabela_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabela.CellClick
        Select Case e.ColumnIndex
            Case 2
                If Not ORIwyk(e.RowIndex) = "" Then
                    If MsgBox("Czy chcesz utworzyć nowego wykonawcę o nazwie """ & ORIwyk(e.RowIndex) & """?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
                        Dim nazwa As String = ORIwyk(e.RowIndex)
                        Dim nwyk As WYKONAWCA = New WYKONAWCA(nazwa)
                        dane.wykonawcy.Add(nwyk)
                        For i As Integer = 0 To tabela.Rows.Count - 1
                            If ORIwyk(i) = nazwa Then
                                REFwyk(i) = nwyk
                                REFalb(i) = nwyk.albumy(0)
                                tabela.Rows.Item(i).Cells.Item(2).Value = "Znaleziono dopasowanie (100%)"
                                tabela.Rows.Item(i).Cells.Item(3).Value = REFwyk(i).nazwa
                                tabela.Rows.Item(i).Cells.Item(4).Value = REFalb(i).nazwa
                                ORIwyk(i) = ""
                            End If
                        Next
                    End If
                End If
        End Select
    End Sub

    Private Sub tabela_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabela.CellDoubleClick
        Select Case e.ColumnIndex
            Case 0
                Dim r As String = tabela.Rows.Item(e.RowIndex).Cells.Item(e.ColumnIndex).Value
                tabela.Rows.Item(e.RowIndex).Cells.Item(e.ColumnIndex).Value = InputBox("Podaj tytuł utworu:", "YTMP", r)
                If tabela.Rows.Item(e.RowIndex).Cells.Item(e.ColumnIndex).Value = "" Then
                    tabela.Rows.Item(e.RowIndex).Cells.Item(e.ColumnIndex).Value = r
                End If
            Case 3
                selectform.laduj(Nothing, dane, True)
                If selectform.wynik IsNot Nothing Then
                    REFwyk(e.RowIndex) = selectform.wynik
                    For Each i As ALBUM In REFwyk(e.RowIndex).albumy
                        If i.brakpozycji Then
                            REFalb(e.RowIndex) = i
                            Exit For
                        End If
                    Next
                    tabela.Rows.Item(e.RowIndex).Cells.Item(e.ColumnIndex).Value = REFwyk(e.RowIndex).nazwa
                    tabela.Rows.Item(e.RowIndex).Cells.Item(e.ColumnIndex + 1).Value = REFalb(e.RowIndex).nazwa
                End If
                selectform.Close()
            Case 4
                selectform.laduj(REFwyk(e.RowIndex), dane, True)
                If selectform.wynik IsNot Nothing Then
                    REFalb(e.RowIndex) = selectform.wynik
                    tabela.Rows.Item(e.RowIndex).Cells.Item(e.ColumnIndex).Value = REFalb(e.RowIndex).nazwa
                End If
                selectform.Close()
        End Select
    End Sub

    Private Sub akt_Tick(sender As Object, e As EventArgs) Handles akt.Tick
        Select Case postep
            Case 0
                addlog("Odczyt identyfikatora playlisty...")
            Case 1
                addlog("ID: " & plid)
            Case 2
                If Not plid.Substring(0, 2) = "PL" Then
                    addlog("ERROR: Wybrana playlista jest prywatna i nie może zostać użyta!")
                    akt.Enabled = False
                Else
                    addlog("Łączenie z serwisem YouTube...")
                End If
            Case 3
                input = downloadpage("https://www.googleapis.com/youtube/v3/playlistItems?part=snippet%2CcontentDetails&maxResults=20&playlistId=" & plid & IIf(nextpagetoken = "", "", "&pageToken=" & nextpagetoken) & "&key=" & My.Resources.APIKEY)
                If input = "" Then
                    addlog("ERROR: Błąd połączenia z serwisem YouTube!")
                    akt.Enabled = False
                Else
                    addlog("Pomyślnie pobrano dane...")
                End If
            Case 4
                addlog("Trwa odczyt utworów...")
            Case 5
                JSONdeserialize()
            Case 6
                If tabela.Rows.Count > 0 Then
                    btnimport.Enabled = True
                    btndelete.Enabled = True
                End If
                btnanuluj.Enabled = True
                akt.Enabled = False
            Case 7

        End Select
        postep += 1
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If tabela.SelectedCells.Count = 0 Then Exit Sub
        Dim ind As Integer = tabela.SelectedCells.Item(0).RowIndex
        tabela.Rows.RemoveAt(ind)
        ORIwyk.RemoveAt(ind)
        REFwyk.RemoveAt(ind)
        REFalb.RemoveAt(ind)
        If tabela.Rows.Count = 0 Then
            btnimport.Enabled = False
            btndelete.Enabled = False
        End If
    End Sub

    Private Sub btnimport_Click(sender As Object, e As EventArgs) Handles btnimport.Click
        If tabela.Rows.Count = 0 Then
            btnimport.Enabled = False
            Exit Sub
        End If
        Dim lstutw As List(Of UTWOR) = New List(Of UTWOR)
        For Each row As DataGridViewRow In tabela.Rows
            Dim lp As Integer = row.Cells.Item(0).RowIndex
            Dim w As WYKONAWCA = Nothing
            Dim a As ALBUM = Nothing
            Dim t As String = ""
            Dim l As String = ""
            If radioauto.Checked Then
                w = REFwyk(lp)
                a = REFalb(lp)
            Else
                w = docelowyWYK
                a = docelowyALB
            End If
            t = row.Cells.Item("k1").Value
            l = row.Cells.Item("k2").Value
            If chkboxedit.Checked Then
                With MODutw
                    .txtname.Text = t
                    .lblid.Text = l
                    .docelowyWYK = w
                    .docelowyALB = a
                    .predefwykalb = True
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        lstutw.Add(.newutw)
                        addlog("Pomyślnie dodano utwór o id: " & l)
                    Else
                        addlog("Anulowano dodanie utworu o id: " & l)
                        If MsgBox("Anulowano dodanie jednej z pozycji. Anulować cały proces importu?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
                            addlog("Operacja importu została przerwana!")
                            Exit Sub
                        End If
                    End If
                    .Close()
                End With
            Else
                Dim n As UTWOR = New UTWOR(t, l, a, 0, 0)
                lstutw.Add(n)
                addlog("Pomyślnie dodano utwór o id: " & l)
            End If
            If chkboxpl.Checked AndAlso lstpl.SelectedIndex >= 0 Then
                For Each u As UTWOR In lstutw
                    REFpl(lstpl.SelectedIndex).dodajutwor(u)
                Next
            End If
        Next
        addlog("Zakończono proces importu utworów!")
        MsgBox("Import utworów zakończony!" & vbNewLine & "Pomyślnie: " & lstutw.Count & ", Anulowanych: " & (tabela.RowCount - lstutw.Count), MsgBoxStyle.Information, "YTMP")
    End Sub

    Private Sub ladujlistepl()
        REFpl.Clear()
        For Each i As PLAYLISTA In dane.playlisty
            REFpl.Add(i)
        Next
        REFpl.Sort(Function(x, y) x.nazwa.CompareTo(y.nazwa))
        lstpl.Items.Clear()
        For Each i As PLAYLISTA In REFpl
            lstpl.Items.Add(i.nazwa)
        Next
    End Sub

    Private Sub btnnewpl_Click(sender As Object, e As EventArgs) Handles btnnewpl.Click
        MODpl.ShowDialog()
        MODpl.Close()
        ladujlistepl()
    End Sub

    Private Sub chkboxpl_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxpl.CheckedChanged
        If chkboxpl.Checked Then
            lstpl.Enabled = True
            btnnewpl.Enabled = True
        Else
            lstpl.Enabled = False
            btnnewpl.Enabled = False
        End If
    End Sub

    Private Sub IMPORTplaylist_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        tabela.Size = New Size(tabela.Size.Width, Height - 340)
        GRzarzadzanie.Location = New Point(15, Height - 330)
        GRimport.Location = New Point(591, Height - 330)
        GRpostep.Location = New Point(15, Height - 230)
        GRopcje.Location = New Point(447, Height - 230)
    End Sub

    Private Sub btnanuluj_Click(sender As Object, e As EventArgs) Handles btnanuluj.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class