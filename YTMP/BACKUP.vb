<Serializable()>
Public Class BACKUP

    Const backupdir As String = "backup"
    Public init As String = ""

    Public kopie As List(Of strBACKUP) = New List(Of strBACKUP)

    <Serializable()>
    Public Structure strBACKUP
        Public data As Date
        Public nazwapliku As String
    End Structure

    Public Sub New(ByVal initdir As String)
        init = initdir
    End Sub

    Public Sub dodajkopie(ByRef obiekt As MAGAZYN)
        Dim nazwap As String = Now.Day & Now.Month & Now.Year & Now.Hour & Now.Minute & Now.Second & ".ytmp"
        If Not IO.Directory.Exists(init & "\" & backupdir) Then IO.Directory.CreateDirectory(init & "\" & backupdir)
        serializuj(obiekt, init & "\" & backupdir & "\" & nazwap)
        Dim nowy As strBACKUP
        nowy.data = Now
        nowy.nazwapliku = nazwap
        kopie.Add(nowy)
        If kopie.Count > 5 Then
            Dim zmodyfikowano As Boolean = False
            Do
                zmodyfikowano = False
                For Each i As strBACKUP In kopie
                    If IO.File.Exists(init & "\" & backupdir & "\" & i.nazwapliku) Then
                        If (Now - i.data).TotalHours > 48 Then
                            zmodyfikowano = True
                            Try
                                IO.File.Delete(init & "\" & backupdir & "\" & i.nazwapliku)
                            Catch ex As Exception

                            End Try
                            kopie.Remove(i)
                            Exit For
                        End If
                    Else
                        zmodyfikowano = True
                        kopie.Remove(i)
                        Exit For
                    End If
                Next
            Loop While zmodyfikowano
        End If
    End Sub

    Public Sub przywroc(ByVal poz As strBACKUP)
        If IO.File.Exists(init & "\" & backupdir & "\" & poz.nazwapliku) Then
            Try
                IO.File.Delete(init & "\magazyn.ytmp")
                IO.File.Copy(init & "\" & backupdir & "\" & poz.nazwapliku, init & "\magazyn.ytmp")
                MsgBox("Dane zostały przywrócone! Nastąpi teraz zamknięcie aplikacji...", MsgBoxStyle.Information, "YTMP")
                UNREGISTERHOTKEYS()
                End
            Catch ex As Exception
                MsgBox("Błąd przywracania kopii bezpieczeństwa!", MsgBoxStyle.Critical, "YTMP")
            End Try
        Else
            MsgBox("Błąd przywracania kopii bezpieczeństwa!" & vbNewLine & "Nie znaleziono pliku kopii! Możliwe że został już on usunięty", MsgBoxStyle.Critical, "YTMP")
        End If
    End Sub

    Public Sub usunwszystkie()
        Try
            If IO.Directory.Exists(init & "\" & backupdir) Then
                For Each i As String In IO.Directory.GetFiles(init & "\" & backupdir)
                    IO.File.Delete(i)
                Next
            End If
            kopie.Clear()
            serializuj(backupy, Application.StartupPath & "\" & "kopie.backup")
        Catch ex As Exception

        End Try
    End Sub
End Class
