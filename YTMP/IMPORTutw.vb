Public Class IMPORTutw

    Dim wyk As WYKONAWCA = Nothing
    Dim utw As String = ""
    Dim match As Byte = 0
    Dim doutworzenia As String = ""

    Private Sub IMPORTutw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.PATHwyk IsNot Nothing Then skrocstring(lblwyk2, 240, Form1.PATHwyk.nazwa)
        If Form1.PATHalb IsNot Nothing Then skrocstring(lblalb2, 240, Form1.PATHalb.nazwa)
        Dim s As String = ytbrowser.vname
        If s.Length > 0 Then
            If s.IndexOf(" - ") >= 0 Then
                Dim splits() As String = s.Split(New String() {" - "}, StringSplitOptions.None)
                splits(0) = splits(0).Trim()
                splits(1) = splits(1).Trim()
                comparewyk(splits(0), wyk, match)
                If wyk Is Nothing Then doutworzenia = splits(0)
                utw = splits(1)
            Else
                utw = s
            End If
        End If
        If wyk Is Nothing Then
            For Each i As WYKONAWCA In dane.wykonawcy
                If i.brakpozycji Then
                    wyk = i
                    Exit For
                End If
            Next
        End If
        If match = 0 Then
            If doutworzenia = "" Then
                lblmatch.Text = "Nie wykryto nazwy wykonawcy w tytule" & vbNewLine & "filmiku. Możesz dodać go później."
            Else
                lblmatch.Text = "Wykonawca nie został dopasowany" & vbNewLine & "lub jego nazwa znacząco się różniła."
            End If
        Else
            lblmatch.Text = "Wykonawca wybrany na podstawie podobieństwa" & vbNewLine & "wynoszącego " & match & "%"
        End If
        skrocstring(lblwyk1, 290, wyk.nazwa)
        skrocstring(lblutw1, 290, utw)
        If doutworzenia = "" Then
            Size = New Size(Size.Width, 370)
        Else
            Size = New Size(Size.Width, 490)
            lblnewwyk.Text = doutworzenia
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Form1.PATHwyk = wyk
        For Each i As ALBUM In wyk.albumy
            If i.brakpozycji Then
                Form1.PATHalb = i
                Exit For
            End If
        Next
        MODutw.lblid.Text = ytbrowser.vid
        MODutw.txtname.Text = utw
        MODutw.ShowDialog()
        MODutw.Close()
        Form1.ladujpanel()
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        MODutw.lblid.Text = ytbrowser.vid
        MODutw.ShowDialog()
        MODutw.Close()
        Form1.ladujpanel()
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnnewwyk_Click(sender As Object, e As EventArgs) Handles btnnewwyk.Click
        If Not doutworzenia = "" Then
            Dim nwyk As WYKONAWCA = New WYKONAWCA(doutworzenia)
            dane.wykonawcy.Add(nwyk)
            wyk = nwyk
            match = 100
            lblmatch.Text = "Wykonawca wybrany na podstawie podobieństwa" & vbNewLine & "wynoszącego " & match & "%"
            skrocstring(lblwyk1, 290, wyk.nazwa)
            Size = New Size(Size.Width, 370)
            doutworzenia = ""
            Form1.ladujpanel()
        End If
    End Sub
End Class