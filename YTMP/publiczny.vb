Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Module publiczny

    Public dane As MAGAZYN = New MAGAZYN()
    Public backupy As BACKUP = New BACKUP(Application.StartupPath)
    Public odtwarzane As PLAYLISTA = New PLAYLISTA("")

    Public Sub serializuj(ByRef obiekt As Object, ByVal path As String)
        Try
            If IO.File.Exists(path) Then IO.File.Delete(path)
            Dim fs As IO.FileStream = IO.File.Create(path)
            Dim bf As BinaryFormatter = New BinaryFormatter
            bf.Serialize(fs, obiekt)
            fs.Close()
        Catch ex As Exception
            MsgBox("Wystąpił błąd podczas zapisu danych!", MsgBoxStyle.Critical, "YTMP")
        End Try
    End Sub

    Public Function deserializuj(ByVal path As String) As Object
        If IO.File.Exists(path) Then
            Try
                Dim fs As IO.FileStream = IO.File.OpenRead(path)
                Dim bf As BinaryFormatter = New BinaryFormatter
                Dim wynik As Object = bf.Deserialize(fs)
                fs.Close()
                Return wynik
            Catch ex As Exception
                MsgBox("Wystąpił błąd podczas odczytu danych!", MsgBoxStyle.Critical, "YTMP")
            End Try
        Else
            MsgBox("Nie znaleziono pliku!", MsgBoxStyle.Critical, "YTMP")
        End If
        Return Nothing
    End Function

    Public Sub skrocstring(ByRef lbl As Label, ByVal maxsize As Integer, ByVal s As String)
        lbl.Text = s
        If lbl.Size.Width > maxsize Then
            lbl.Text &= "..."
            Do While lbl.Size.Width > maxsize And lbl.Text.Length >= 4
                lbl.Text = lbl.Text.Substring(0, lbl.Text.Length - 4) & "..."
            Loop
        End If
    End Sub

    Public Sub comparewyk(ByVal zrodlo As String, ByRef w As WYKONAWCA, ByRef m As Byte)
        Const progminzgodnosci As Byte = 60
        Dim topwyk As WYKONAWCA = Nothing
        Dim topzgodnosc As Byte = 0
        For Each i As WYKONAWCA In dane.wykonawcy
            If Not i.brakpozycji Then
                'Debug.WriteLine("WYNIK: 1:{0}, 2:{1}, p:{2}", zrodlo, i.nazwa, SimilarLevel(zrodlo, i.nazwa))
                Dim wyn As Byte = SimilarLevel(zrodlo, i.nazwa)
                If wyn > progminzgodnosci And wyn > topzgodnosc Then
                    topzgodnosc = wyn
                    topwyk = i
                End If
            End If
        Next
        w = topwyk
        m = topzgodnosc
    End Sub

    Public Function SimilarLevel(ByVal s1 As String, ByVal s2 As String) As Byte
        If s1 = s2 Then Return 100
        s1 = s1.ToLower().Trim()
        s2 = s2.ToLower().Trim()
        Dim initlen As Integer = s1.Length + s2.Length
        If initlen = 0 Then Return 0
        Dim cnt As Integer = 0
        Do
            Dim common As String = LongestCommonSubstring(s1, s2).Trim()
            If common = "" Then Exit Do
            'Debug.WriteLine("s1:{0}, s2:{1}, common:{2}", s1, s2, common)
            s1 = s1.Replace(common, "")
            s2 = s2.Replace(common, "")
            If common.Length = 1 Then cnt += 1 Else cnt += common.Length * 2
        Loop
        Return Math.Round(cnt * 100 / initlen, 0)
    End Function

    Public Function LongestCommonSubstring(str1 As String, str2 As String) As String
        Try
            Dim subStr As String = ""
            If String.IsNullOrEmpty(str1) OrElse String.IsNullOrEmpty(str2) Then Return ""

            If str1 = str2 Then
                Return str1
            Else
                str1 = str1.Replace(" ", "1")
                str2 = str2.Replace(" ", "2")
            End If

            Dim num As Integer(,) = New Integer(str1.Length - 1, str2.Length - 1) {}
            Dim maxlen As Integer = 0
            Dim lastSubsBegin As Integer = 0
            Dim subStrBuilder As New StringBuilder()

            For i As Integer = 0 To str1.Length - 1
                For j As Integer = 0 To str2.Length - 1
                    If str1(i) <> str2(j) Then
                        num(i, j) = 0
                    Else
                        If (i = 0) OrElse (j = 0) Then
                            num(i, j) = 1
                        Else
                            num(i, j) = 1 + num(i - 1, j - 1)
                        End If
                        If num(i, j) > maxlen Then
                            maxlen = num(i, j)
                            Dim thisSubsBegin As Integer = i - num(i, j) + 1
                            If lastSubsBegin = thisSubsBegin Then
                                subStrBuilder.Append(str1(i))
                            Else
                                lastSubsBegin = thisSubsBegin
                                subStrBuilder.Length = 0
                                subStrBuilder.Append(str1.Substring(lastSubsBegin, (i + 1) - lastSubsBegin))
                            End If
                        End If
                    End If
                Next
            Next
            subStr = subStrBuilder.ToString()
            Return subStr

        Catch e As Exception
            Return ""
        End Try
    End Function
End Module
