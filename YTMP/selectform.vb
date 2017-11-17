Public Class selectform

    Dim mag As MAGAZYN = Nothing
    Dim searchempty As Boolean = True
    Dim referencje As List(Of Object) = New List(Of Object)
    Dim filtrWYK As WYKONAWCA = Nothing

    Public wynik As Object = Nothing

    Public Sub laduj(ByRef obiektWYK As WYKONAWCA, ByRef obiektMAG As MAGAZYN, ByVal newenabled As Boolean)
        filtrWYK = obiektWYK
        mag = obiektMAG
        If newenabled Then btnnowy.Enabled = True Else btnnowy.Enabled = False
        If filtrWYK Is Nothing Then
            lbltytul.Text = vbNewLine & "Wybierz wykonawcę:"
        Else
            lbltytul.Text = "Wybierz album wykonawcy" & vbNewLine & """" & filtrWYK.nazwa & """:"
        End If
        ShowDialog()
    End Sub

    Private Sub txtsearch_GotFocus(sender As Object, e As EventArgs) Handles txtsearch.GotFocus
        If searchempty Then
            searchempty = False
            txtsearch.Text = ""
            txtsearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtsearch_LostFocus(sender As Object, e As EventArgs) Handles txtsearch.LostFocus
        If Not searchempty And txtsearch.Text = "" Then
            searchempty = True
            txtsearch.Text = "Szukaj..."
            txtsearch.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub selectform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtsearch.Focus()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        pokaz()
    End Sub

    Private Sub pokaz()
        If mag Is Nothing Then Exit Sub
        Dim s As String = ""
        If Not searchempty Then s = txtsearch.Text.ToLower()
        referencje.Clear()
        If filtrWYK Is Nothing Then
            For Each w As WYKONAWCA In mag.wykonawcy
                If w.nazwa.ToLower() Like "*" & s & "*" Then
                    referencje.Add(w)
                End If
            Next
        Else
            For Each a As ALBUM In filtrWYK.albumy
                If a.nazwa.ToLower() Like "*" & s & "*" Then
                    referencje.Add(a)
                End If
            Next
        End If
        referencje.Sort(Function(x, y) x.nazwa.CompareTo(y.nazwa))
        lista.Items.Clear()
        For Each i As Object In referencje
            lista.Items.Add(i.nazwa)
        Next
        If lista.Items.Count > 0 Then lista.SelectedIndex = 0
    End Sub

    Private Sub lista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lista.SelectedIndexChanged
        If lista.SelectedIndex < 0 Then
            btnok.Enabled = False
        Else
            btnok.Enabled = True
        End If
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If lista.SelectedIndex >= 0 Then
            wynik = referencje(lista.SelectedIndex)
            DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub txtsearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnok_Click(btnok, New EventArgs())
        End If
    End Sub

    Private Sub lista_DoubleClick(sender As Object, e As EventArgs) Handles lista.DoubleClick
        btnok_Click(btnok, New EventArgs())
    End Sub

    Private Sub btnnowy_Click(sender As Object, e As EventArgs) Handles btnnowy.Click
        If filtrWYK Is Nothing Then
            'nowy wykonawca
            Dim starail As Integer = mag.wykonawcy.Count
            MODwyk.ShowDialog()
            MODwyk.Close()
            If mag.wykonawcy.Count > starail Then
                searchempty = False
                txtsearch.ForeColor = Color.Black
                txtsearch.Text = mag.wykonawcy(mag.wykonawcy.Count - 1).nazwa
            End If
            txtsearch.Focus()
        Else
            'nowy album wykonawcy z filtrWYK
            Dim starail As Integer = filtrWYK.albumy.Count
            MODalb.zablokujprzynaleznosc(filtrWYK)
            MODalb.ShowDialog()
            MODalb.Close()
            If filtrWYK.albumy.Count > starail Then
                searchempty = False
                txtsearch.ForeColor = Color.Black
                txtsearch.Text = filtrWYK.albumy(filtrWYK.albumy.Count - 1).nazwa
            End If
            txtsearch.Focus()
        End If
    End Sub
End Class