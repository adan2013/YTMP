Public Class genraport

    Dim path As String = ""
    Dim ostformatcsv As Boolean = True
    Dim k As List(Of Byte) = New List(Of Byte)

    Private Sub genraport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstsep.SelectedIndex = 0
        lst1.SelectedIndex = 1
        lst2.SelectedIndex = 2
        lst3.SelectedIndex = 3
    End Sub

    Private Sub btnlokalny_Click(sender As Object, e As EventArgs) Handles btnlokalny.Click
        path = ""
        lblpath.Text = "Biblioteka lokalna"
    End Sub

    Private Sub btnzpliku_Click(sender As Object, e As EventArgs) Handles btnzpliku.Click
        opendialog.ShowDialog()
        If Not opendialog.FileName = "" Then
            path = opendialog.FileName
            lblpath.Text = opendialog.FileName
            lblpath.Text = New IO.FileInfo(opendialog.FileName).Name
        End If
    End Sub

    Private Sub btncb_Click(sender As Object, e As EventArgs) Handles btncb.Click
        Clipboard.SetText(txtpodglad.Text)
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If ostformatcsv Then savedialog.Filter = "Plik CSV (*.csv)|*.csv" Else savedialog.Filter = "Plik tekstowy (*.txt)|*.txt"
        savedialog.ShowDialog()
        If Not savedialog.FileName = "" Then IO.File.WriteAllText(savedialog.FileName, txtpodglad.Text)
    End Sub

    Private Sub btngen_Click(sender As Object, e As EventArgs) Handles btngen.Click
        k.Clear()
        If lst1.SelectedIndex > 0 Then k.Add(lst1.SelectedIndex)
        If lst2.SelectedIndex > 0 Then k.Add(lst2.SelectedIndex)
        If lst3.SelectedIndex > 0 Then k.Add(lst3.SelectedIndex)
        Dim mag As MAGAZYN = Nothing
        Dim l As List(Of String) = New List(Of String)
        Try
            If path = "" Then mag = dane Else mag = deserializuj(path)
        Catch ex As Exception
            MsgBox("Wystąpił błąd podczas odczytu pliku!", MsgBoxStyle.Critical, "YTMP")
        End Try
        If mag IsNot Nothing Then
            If radiocsv.Checked Then ostformatcsv = True Else ostformatcsv = False

            For Each w As WYKONAWCA In mag.wykonawcy
                For Each a As ALBUM In w.albumy
                    For Each u As UTWOR In a.utwory
                        If radiocsv.Checked Then
                            l.Add(getcontent(u, 0, True, True) & getcontent(u, 1, True, True) & getcontent(u, 2, False, True))
                        Else
                            l.Add(getcontent(u, 0, True, False) & getcontent(u, 1, True, False) & getcontent(u, 2, False, False))
                        End If
                    Next
                Next
            Next

            If chkboxalfabet.Checked Then l.Sort()
            txtpodglad.Text = ""
            For Each i As String In l
                txtpodglad.Text &= IIf(txtpodglad.Text = "", "", vbNewLine) & i
            Next
        End If
    End Sub

    Private Function getlstvar(ByVal nr As Byte) As Byte
        If nr >= k.Count Then
            Return 0
        Else
            Return k(nr)
        End If
    End Function

    Private Function getcontent(ByVal ob As UTWOR, ByVal nrlst As Byte, ByVal echosep As Boolean, ByVal csvchar As Boolean) As String
        Dim w As String = ""
        Select Case getlstvar(nrlst)
            Case 0
                Return ""
            Case 1
                w = IIf(chkboxutw.Checked, """" & IIf(radiocsv.Checked, """", ""), "") & ob.tytul & IIf(chkboxutw.Checked, """" & IIf(radiocsv.Checked, """", ""), "")
            Case 2
                w = ob.FKalbum.nazwa
                If chkboxalb.Checked And ob.FKalbum.brakpozycji Then w = ""
            Case 3
                w = ob.FKalbum.FKwykonawca.nazwa
                If chkboxwyk.Checked And ob.FKalbum.FKwykonawca.brakpozycji Then w = ""
        End Select
        If w.Length > 0 And csvchar Then w = """" & w & """"
        If w.Length > 0 And echosep And getlstvar(nrlst + 1) > 0 Then w &= IIf(radiocsv.Checked, ",", " " & lstsep.Text & " ")
        Return w
    End Function

    Private Sub radioopis_CheckedChanged(sender As Object, e As EventArgs) Handles radioopis.CheckedChanged
        lstsep.Enabled = sender.Checked
    End Sub
End Class