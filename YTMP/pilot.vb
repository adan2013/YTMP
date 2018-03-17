Public Class pilot

    Dim windowdragmode As Boolean = False
    Dim dragcords As Point = New Point(0, 0)

    Private Sub belkapnl_MouseDown(sender As Object, e As MouseEventArgs) Handles belkapnl.MouseDown
        If e.Button = MouseButtons.Left Then
            windowdragmode = True
            dragcords = New Point(Cursor.Position.X - Left, Cursor.Position.Y - Top)
        End If
    End Sub

    Private Sub belkapnl_MouseUp(sender As Object, e As MouseEventArgs) Handles belkapnl.MouseUp
        If e.Button = MouseButtons.Left Then windowdragmode = False
    End Sub

    Private Sub belkapnl_MouseMove(sender As Object, e As MouseEventArgs) Handles belkapnl.MouseMove
        If windowdragmode Then
            Left = Cursor.Position.X - dragcords.X
            Top = Cursor.Position.Y - dragcords.Y
        End If
    End Sub

    Private Sub play0_MouseMove(sender As Object, e As MouseEventArgs) Handles play0.MouseMove, play1.MouseMove, back0.MouseMove, back1.MouseMove, next0.MouseMove, next1.MouseMove, mute0.MouseMove, mute1.MouseMove, voldn0.MouseMove, voldn1.MouseMove, volup0.MouseMove, volup1.MouseMove, rep1.MouseMove, ran1.MouseMove, player1.MouseMove
        sender.BackColor = Color.Yellow
    End Sub

    Private Sub play0_MouseLeave(sender As Object, e As EventArgs) Handles play0.MouseLeave, play1.MouseLeave, back0.MouseLeave, back1.MouseLeave, next0.MouseLeave, next1.MouseLeave, mute0.MouseLeave, mute1.MouseLeave, voldn0.MouseLeave, voldn1.MouseLeave, volup0.MouseLeave, volup1.MouseLeave, rep1.MouseLeave, ran1.MouseLeave, player1.MouseLeave
        Select Case sender.Name.SubString(0, 3)
            Case "mut"
                If Not dane.MODmute Then sender.BackColor = Color.WhiteSmoke
            Case "rep"
                If Not dane.MODrep Then sender.BackColor = Color.WhiteSmoke
            Case "ran"
                If Not dane.MODran Then sender.BackColor = Color.WhiteSmoke
            Case Else
                sender.BackColor = Color.WhiteSmoke
        End Select
    End Sub

    Private Sub pilot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.yt.state = YTAPI.YTstate.odtwarzanie Or Form1.yt.state = YTAPI.YTstate.buforowanie Then
            play0.Image = My.Resources.pause_24px
            play1.Image = My.Resources.pause_24px
        End If
        If dane.MODmute Then
            mute0.BackColor = Color.Yellow
            mute1.BackColor = Color.Yellow
        End If
        If dane.MODrep Then rep1.BackColor = Color.Yellow
        If dane.MODran Then ran1.BackColor = Color.Yellow
        lblvol.Text = dane.volume & "%"
    End Sub

    Public Sub aktualizacja()
        If Visible Then
            If Form1.yt.state = YTAPI.YTstate.odtwarzanie Or Form1.yt.state = YTAPI.YTstate.buforowanie Then
                play0.Image = My.Resources.pause_24px
                play1.Image = My.Resources.pause_24px
            Else
                play0.Image = My.Resources.play_24px
                play1.Image = My.Resources.play_24px
            End If
            If dane.MODmute Then
                mute0.BackColor = Color.Yellow
                mute1.BackColor = Color.Yellow
            Else
                mute0.BackColor = Color.WhiteSmoke
                mute1.BackColor = Color.WhiteSmoke
            End If
            If dane.MODrep Then
                rep1.BackColor = Color.Yellow
            Else
                rep1.BackColor = Color.WhiteSmoke
            End If
            If dane.MODran Then
                ran1.BackColor = Color.Yellow
            Else
                ran1.BackColor = Color.WhiteSmoke
            End If
            lblvol.Text = dane.volume & "%"
        End If
    End Sub

    Public Sub status(ByVal info As String, ByVal cur As Integer, ByVal dur As Integer)
        If Visible Then
            lbltime.Text = konwertujnaczas(cur) & "/" & konwertujnaczas(dur)
            lbltime.Location = New Point(441 - lbltime.Size.Width, lbltime.Location.Y)
            skrocstring(lblstan, 430 - lbltime.Size.Width, info)
        End If
    End Sub

    Private Function konwertujnaczas(ByVal wartosc As Integer) As String
        Dim s As String = wartosc \ 60
        If s.Length = 1 Then s = "0" & s
        s &= ":"
        s &= IIf(wartosc Mod 60 < 10, "0", "") & (wartosc Mod 60)
        Return s
    End Function

    Private Sub play0_Click(sender As Object, e As EventArgs) Handles play0.Click, play1.Click
        Form1.yt.playpause()
    End Sub

    Private Sub back0_Click(sender As Object, e As EventArgs) Handles back0.Click, back1.Click
        Form1.yt.poprzedniutwor()
    End Sub

    Private Sub next0_Click(sender As Object, e As EventArgs) Handles next0.Click, next1.Click
        Form1.yt.nastepnyutwor()
    End Sub

    Private Sub mute0_Click(sender As Object, e As EventArgs) Handles mute0.Click, mute1.Click
        dane.MODmute = Not dane.MODmute
        If dane.MODmute Then Form1.btnmute.BackColor = Color.Yellow Else Form1.btnmute.BackColor = Color.WhiteSmoke
        zapiszzmiany()
    End Sub

    Private Sub rep1_Click(sender As Object, e As EventArgs) Handles rep1.Click
        dane.MODrep = Not dane.MODrep
        If dane.MODrep Then Form1.btnrep.BackColor = Color.Yellow Else Form1.btnrep.BackColor = Color.WhiteSmoke
        zapiszzmiany()
    End Sub

    Private Sub ran1_Click(sender As Object, e As EventArgs) Handles ran1.Click
        dane.MODran = Not dane.MODran
        If dane.MODran Then Form1.btnran.BackColor = Color.Yellow Else Form1.btnran.BackColor = Color.WhiteSmoke
        zapiszzmiany()
    End Sub

    Private Sub player1_Click(sender As Object, e As EventArgs) Handles player1.Click
        If Form1.WindowState = FormWindowState.Minimized Then
            Form1.Show()
            Form1.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub voldn0_Click(sender As Object, e As EventArgs) Handles voldn0.Click, voldn1.Click
        If dane.volume >= 10 Then
            dane.volume -= 10
            Form1.pnlglosnosc.Size = New Size(dane.volume, Form1.pnlglosnosc.Size.Height)
            lblvol.Text = dane.volume & "%"
            zapiszzmiany()
        End If
    End Sub

    Private Sub volup0_Click(sender As Object, e As EventArgs) Handles volup0.Click, volup1.Click
        If dane.volume <= 90 Then
            dane.volume += 10
            Form1.pnlglosnosc.Size = New Size(dane.volume, Form1.pnlglosnosc.Size.Height)
            lblvol.Text = dane.volume & "%"
            zapiszzmiany()
        End If
    End Sub
End Class