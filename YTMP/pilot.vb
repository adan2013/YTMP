﻿Public Class pilot

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
        lbltime.Text = konwertujnaczas(cur) & "/" & konwertujnaczas(dur)
        lbltime.Location = New Point(441 - lbltime.Size.Width, lbltime.Location.Y)
        skrocstring(lblstan, 430 - lbltime.Size.Width, info)
    End Sub

    Private Function konwertujnaczas(ByVal wartosc As Integer) As String
        Dim s As String = wartosc \ 60
        If s.Length = 1 Then s = "0" & s
        s &= ":"
        s &= IIf(wartosc Mod 60 < 10, "0", "") & (wartosc Mod 60)
        Return s
    End Function
End Class