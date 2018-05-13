Imports System.ComponentModel
Imports System.Threading

Public Class Form1

    Dim okej As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BWinstall.RunWorkerAsync()
    End Sub

    Private Sub addlog(ByVal txt As String)
        Invoke(Sub() txtlog.Text &= txt & vbNewLine)
        Invoke(Sub() txtlog.SelectionStart = txtlog.Text.Length - 1)
        Invoke(Sub() txtlog.ScrollToCaret())
    End Sub

    Private Sub gotoerr(ByVal msg As String)
        Invoke(Sub() btnclose.Enabled = True)
        If Not msg = "" Then addlog("ERROR: " & msg)
        If BWinstall.IsBusy Then BWinstall.CancelAsync()
    End Sub

    Private Sub BWinstall_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BWinstall.DoWork
        Dim timeoutloop As Integer = 0
        Thread.Sleep(500)
        addlog("Oczekiwanie na zamknięcie aplikacji YTMP...")
        timeoutloop = 0
        Do
            timeoutloop += 1
            Thread.Sleep(200)
            Dim p() As Process = Process.GetProcessesByName("YTMP")
            If p.Count = 0 Then Exit Do
            If timeoutloop > 25 Then
                gotoerr("przekroczono limit oczekiwania na zamknięcie aplikacji YTMP!")
                Exit Sub
            End If
        Loop
        addlog("Rozpoczynam instalację aktualizacji...")
        Thread.Sleep(800)
        Try
            dirscan(Application.StartupPath, "\..")
            If IO.File.Exists(Application.StartupPath & "\..\install.txt") Then IO.File.Delete(Application.StartupPath & "\..\install.txt")
            IO.File.WriteAllText(Application.StartupPath & "\..\install.txt", "ok")
        Catch ex As Exception
            gotoerr("błąd podczas kopiowania pliku!")
            Exit Sub
        End Try
        addlog("Aktualizacja została zainstalowana pomyślnie!")
        Invoke(Sub() btnclose.Text = "Uruchom YTMP")
        Invoke(Sub() btnclose.Enabled = True)
        Invoke(Sub() lbl1.Text = "Proces aktualizacji został ukończony")
        Invoke(Sub() lbl2.Text = "Możesz ponownie uruchomić YTMP")
        okej = True
    End Sub

    Private Sub dirscan(ByVal dir As String, ByVal dest As String)
        For Each d As String In IO.Directory.GetDirectories(dir)
            dirscan(d, dest & "\..")
        Next
        For Each f As String In IO.Directory.GetFiles(dir)
            Dim fi As IO.FileInfo = New IO.FileInfo(f)
            If dest = "\.." AndAlso fi.Name = "YTMP-AUTOUPDATER.exe" Then Continue For
            addlog("Kopiowanie pliku """ & dir.Replace(Application.StartupPath, "") & "\" & fi.Name & """")
            If Not IO.Directory.Exists(dir & dest & dir.Replace(Application.StartupPath, "")) Then IO.Directory.CreateDirectory(dir & dest & dir.Replace(Application.StartupPath, ""))
            If IO.File.Exists(dir & dest & dir.Replace(Application.StartupPath, "") & "\" & fi.Name) Then IO.File.Delete(dir & dest & dir.Replace(Application.StartupPath, "") & "\" & fi.Name)
            Thread.Sleep(150)
            IO.File.Copy(f, dir & dest & dir.Replace(Application.StartupPath, "") & "\" & fi.Name)
        Next
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        If okej Then
            If IO.File.Exists(Application.StartupPath & "\..\YTMP.exe") Then Process.Start(Application.StartupPath & "\..\YTMP.exe")
            End
        Else
            Close()
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If BWinstall.IsBusy Then
            If Not MsgBox("Czy chcesz przerwać aktualizację?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
                e.Cancel = True
            End If
        End If
    End Sub
End Class
