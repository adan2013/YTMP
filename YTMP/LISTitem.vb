Imports System.Drawing.Drawing2D
Public Class LISTitem

    Public Event SelectionChanged(sender As Object)

    Friend WithEvents tmrMouseLeave As New Timer With {.Interval = 10}

    Dim a1 As btn1action
    Dim a2 As btn2action
    Dim a3 As btn3action

#Region "Properties"

    Dim mMain As String = "[MainText]"
    Public Property MainText() As String
        Get
            Return mMain
        End Get
        Set(ByVal value As String)
            mMain = value
            'Refresh()
        End Set
    End Property

    Dim mSub1 As String = "SubText1"
    Public Property SubText1() As String
        Get
            Return mSub1
        End Get
        Set(ByVal value As String)
            mSub1 = value
            'Refresh()
        End Set
    End Property

    Dim mSub2 As String = "SubText2"
    Public Property SubText2() As String
        Get
            Return mSub2
        End Get
        Set(ByVal value As String)
            mSub2 = value
            'Refresh()
        End Set
    End Property

    Private mSelected As Boolean
    Public Property Selected() As Boolean
        Get
            Return mSelected
        End Get
        Set(ByVal value As Boolean)
            mSelected = value
            Refresh()
        End Set
    End Property

    Private mArrow As Boolean
    Public Property Arrow() As Boolean
        Get
            Return mArrow
        End Get
        Set(ByVal value As Boolean)
            mArrow = value
            'Refresh()
        End Set
    End Property

    Private mObj As Object
    Public Property Obj() As Object
        Get
            Return mObj
        End Get
        Set(ByVal value As Object)
            mObj = value
            generatebuttons()
            'Refresh()
        End Set
    End Property
#End Region

#Region "Mouse coding"

    Private Enum MouseCapture
        Outside
        Inside
    End Enum
    Private Enum ButtonState
        ButtonUp
        ButtonDown
        Disabled
    End Enum
    Dim bState As ButtonState
    Dim bMouse As MouseCapture

    Private Sub ListControlItem_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        If Selected = False Then
            Selected = True
            RaiseEvent SelectionChanged(Me)
            clickaction()
        End If
    End Sub

    Private Sub metroRadioGroup_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown ', rdButton.MouseDown
        bState = ButtonState.ButtonDown
        Refresh()
    End Sub

    Private Sub metroRadioGroup_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        bMouse = MouseCapture.Inside
        tmrMouseLeave.Start()
        Refresh()
    End Sub

    Private Sub metroRadioGroup_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp ', rdButton.MouseUp
        bState = ButtonState.ButtonUp
        Refresh()
    End Sub

    Private Sub tmrMouseLeave_Tick(sender As Object, e As EventArgs) Handles tmrMouseLeave.Tick
        Try
            Dim scrPT = Control.MousePosition
            Dim ctlPT As Point = Me.PointToClient(scrPT)
            If ctlPT.X < 0 Or ctlPT.Y < 0 Or ctlPT.X > Me.Width Or ctlPT.Y > Me.Height Then
                ' Stop timer
                tmrMouseLeave.Stop()
                bMouse = MouseCapture.Outside
                Refresh()
            Else
                bMouse = MouseCapture.Inside
            End If
        Catch ex As Exception
            tmrMouseLeave.Stop()
        End Try
    End Sub
#End Region

#Region "Painting"

    Private Sub Paint_DrawBackground(gfx As Graphics)
        '
        Dim rect As New Rectangle(0, 0, Width - 1, Height - 1)

        '/// Build a rounded rectangle
        Dim p As New GraphicsPath
        Const Roundness = 1
        p.StartFigure()
        p.AddArc(New Rectangle(rect.Left, rect.Top, Roundness, Roundness), 180, 90)
        p.AddLine(rect.Left + Roundness, 0, rect.Right - Roundness, 0)
        p.AddArc(New Rectangle(rect.Right - Roundness, 0, Roundness, Roundness), -90, 90)
        p.AddLine(rect.Right, Roundness, rect.Right, rect.Bottom - Roundness)
        p.AddArc(New Rectangle(rect.Right - Roundness, rect.Bottom - Roundness, Roundness, Roundness), 0, 90)
        p.AddLine(rect.Right - Roundness, rect.Bottom, rect.Left + Roundness, rect.Bottom)
        p.AddArc(New Rectangle(rect.Left, rect.Height - Roundness, Roundness, Roundness), 90, 90)
        p.CloseFigure()


        '/// Draw the background ///
        Dim ColorScheme As Color() = Nothing
        Dim brdr As SolidBrush = Nothing

        If bState = ButtonState.Disabled Then
            ' normal
            brdr = LISTcolors.DisabledBorder
            ColorScheme = LISTcolors.DisabledAllColor
        Else
            If mSelected Then
                ' Selected
                brdr = LISTcolors.SelectedBorder

                If bState = ButtonState.ButtonUp And bMouse = MouseCapture.Outside Then
                    ' normal
                    ColorScheme = LISTcolors.SelectedNormal

                ElseIf bState = ButtonState.ButtonUp And bMouse = MouseCapture.Inside Then
                    '  hover 
                    ColorScheme = LISTcolors.SelectedHover

                ElseIf bState = ButtonState.ButtonDown And bMouse = MouseCapture.Outside Then
                    ' no one cares!
                    Exit Sub
                ElseIf bState = ButtonState.ButtonDown And bMouse = MouseCapture.Inside Then
                    ' pressed
                    ColorScheme = LISTcolors.SelectedPressed
                End If

            Else
                ' Not selected
                brdr = LISTcolors.UnSelectedBorder

                If bState = ButtonState.ButtonUp And bMouse = MouseCapture.Outside Then
                    ' normal
                    brdr = LISTcolors.DisabledBorder
                    ColorScheme = LISTcolors.UnSelectedNormal

                ElseIf bState = ButtonState.ButtonUp And bMouse = MouseCapture.Inside Then
                    '  hover 
                    ColorScheme = LISTcolors.UnSelectedHover

                ElseIf bState = ButtonState.ButtonDown And bMouse = MouseCapture.Outside Then
                    ' no one cares!
                    Exit Sub
                ElseIf bState = ButtonState.ButtonDown And bMouse = MouseCapture.Inside Then
                    ' pressed
                    ColorScheme = LISTcolors.UnSelectedPressed
                End If

            End If
        End If

        ' Draw
        Dim b As LinearGradientBrush = New LinearGradientBrush(rect, Color.White, Color.Black, LinearGradientMode.Vertical)
        Dim blend As ColorBlend = New ColorBlend
        blend.Colors = ColorScheme
        blend.Positions = New Single() {0.0F, 0.1, 0.9F, 0.95F, 1.0F}
        b.InterpolationColors = blend
        gfx.FillPath(b, p)

        '// Draw border
        gfx.DrawPath(New Pen(brdr), p)

        '// Draw bottom border if Normal state (not hovered)
        If bMouse = MouseCapture.Outside Then
            rect = New Rectangle(rect.Left, Me.Height - 1, rect.Width, 1)
            b = New LinearGradientBrush(rect, Color.Blue, Color.Yellow, LinearGradientMode.Horizontal)
            blend = New ColorBlend
            blend.Colors = New Color() {Color.White, Color.LightGray, Color.White}
            blend.Positions = New Single() {0.0F, 0.5F, 1.0F}
            b.InterpolationColors = blend
            '
            gfx.FillRectangle(b, rect)
        End If
        showhidebuttons()
    End Sub

    Private Sub Paint_DrawButton(gfx As Graphics)

        Dim fnt As Font = Nothing
        Dim sz As SizeF = Nothing
        Dim layoutRect As RectangleF
        Dim SF As New StringFormat With {.Trimming = StringTrimming.EllipsisCharacter}
        Dim workingRect As New Rectangle(10, 0, Width - 10, Height)

        ' main text
        fnt = New Font(getFontFamily("Carlito"), 14)
        sz = gfx.MeasureString(mMain, fnt)
        layoutRect = New RectangleF(6, 4, workingRect.Width, sz.Height)
        gfx.DrawString(mMain, fnt, Brushes.Black, layoutRect, SF)

        ' sub text 1
        fnt = New Font(getFontFamily("Carlito"), 10)
        sz = gfx.MeasureString(mSub1, fnt)
        layoutRect = New RectangleF(6, 30, workingRect.Width, sz.Height)
        gfx.DrawString(mSub1, fnt, Brushes.Black, layoutRect, SF)

        ' sub text 2
        fnt = New Font(getFontFamily("Carlito"), 10)
        sz = gfx.MeasureString(mSub2, fnt)
        layoutRect = New RectangleF(6, 48, workingRect.Width, sz.Height)
        gfx.DrawString(mSub2, fnt, Brushes.Black, layoutRect, SF)

        'If mArrow Then
        '    gfx.DrawImage(My.Resources.arrow_menu, New Rectangle(Width - 20, Height / 2 - 8, 16, 16))
        'End If
    End Sub

    Private Sub PaintEvent(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim gfx = e.Graphics
        Paint_DrawBackground(gfx)
        Paint_DrawButton(gfx)
    End Sub
#End Region

#Region "Buttons"

    Enum btn1action
        none = 0
        direct = 1
        addpl = 2
    End Enum

    Enum btn2action
        none = 0
        move = 1
        edit = 2
        direct = 3
    End Enum

    Enum btn3action
        none = 0
        delete = 1
    End Enum

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Select Case a1
            Case btn1action.direct
                Dim u As UTWOR = Obj
                Form1.PATHalb = u.FKalbum
                Form1.PATHwyk = u.FKalbum.FKwykonawca
                selectedtab = 1
                Form1.ladujpanel()
            Case btn1action.addpl
                odtwarzane.dodajutwor(Obj)
                lbldodano.Visible = True
                tmrhidelbl.Enabled = True
        End Select
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Select Case a2
            Case btn2action.move
                If selectedtab = 0 Then
                    MODpozycja.ustaw(odtwarzane.utwory.Count, Form1.pnllista.getMyIndex(Me))
                    MODpozycja.ShowDialog()
                    odtwarzane.usunutwor(Obj)
                    odtwarzane.utwory.Insert(MODpozycja.wynik, Obj)
                Else
                    MODpozycja.ustaw(Form1.PATHpl.utwory.Count, Form1.pnllista.getMyIndex(Me))
                    MODpozycja.ShowDialog()
                    Form1.PATHpl.usunutwor(Obj)
                    Form1.PATHpl.utwory.Insert(MODpozycja.wynik, Obj)
                End If
            Case btn2action.edit
                If TypeOf Obj Is WYKONAWCA Then
                    If Obj.brakpozycji Then
                        MsgBox("Nie można edytować domyślnej pozycji!", MsgBoxStyle.Information, "YTMP")
                    Else
                        MODwyk.modyfikuj(Obj)
                        MODwyk.ShowDialog()
                        MODwyk.Close()
                        zapiszzmiany()
                    End If
                End If
                If TypeOf Obj Is ALBUM Then
                    If Obj.brakpozycji Then
                        MsgBox("Nie można edytować domyślnej pozycji!", MsgBoxStyle.Information, "YTMP")
                    Else
                        MODalb.modyfikuj(Obj)
                        MODalb.ShowDialog()
                        MODalb.Close()
                        zapiszzmiany()
                    End If
                End If
                If TypeOf Obj Is UTWOR Then
                    MODutw.modyfikuj(Obj)
                    MODutw.ShowDialog()
                    MODutw.Close()
                    zapiszzmiany()
                End If
                If TypeOf Obj Is PLAYLISTA Then
                    MODpl.modyfikuj(Obj)
                    MODpl.ShowDialog()
                    MODpl.Close()
                    zapiszzmiany()
                End If
            Case btn2action.direct
                Dim u As UTWOR = Obj
                With Form1
                    .PATHalb = u.FKalbum
                    .PATHwyk = u.FKalbum.FKwykonawca
                    .searchempty = True
                    .txtsearch.Text = "Szukaj..."
                    .txtsearch.ForeColor = Color.Gray
                    .pnllista.Focus()
                End With
        End Select
        Form1.ladujpanel()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Select Case a3
            Case btn3action.delete
                Select Case selectedtab
                    Case 0
                        odtwarzane.utwory.Remove(Obj)
                        Form1.ladujpanel()
                    Case 1
                        If TypeOf Obj Is WYKONAWCA Then
                            If MsgBox("Usunąć wykonawcę oraz wszystkie albumy i utwory należące do niego?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
                                Obj.usunmnie()
                                Form1.ladujpanel()
                                zapiszzmiany()
                            End If
                        End If
                        If TypeOf Obj Is ALBUM Then
                            If MsgBox("Usunąć album oraz wszystkie utwory należące do niego?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
                                Obj.usunmnie()
                                Form1.ladujpanel()
                                zapiszzmiany()
                            End If
                        End If
                        If TypeOf Obj Is UTWOR Then
                            If MsgBox("Usunąć utwór?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
                                Obj.usunmnie()
                                Form1.ladujpanel()
                                zapiszzmiany()
                            End If
                        End If
                    Case 2
                        If TypeOf Obj Is PLAYLISTA Then
                            If MsgBox("Usunąć całą playlistę?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
                                dane.playlisty.Remove(Obj)
                                Form1.ladujpanel()
                                zapiszzmiany()
                            End If
                        Else
                            Form1.PATHpl.usunutwor(Obj)
                            Form1.ladujpanel()
                            zapiszzmiany()
                        End If
                End Select
        End Select
    End Sub

    Private Sub showhidebuttons()
        If bMouse = MouseCapture.Inside Then
            If Not a1 = btn1action.none Then btn1.Visible = True
            If Not a2 = btn2action.none Then btn2.Visible = True
            If Not a3 = btn3action.none Then btn3.Visible = True
        Else
            If btn1.Visible Then btn1.Visible = False
            If btn2.Visible Then btn2.Visible = False
            If btn3.Visible Then btn3.Visible = False
        End If
    End Sub

    Private Sub generatebuttons()
        a1 = btn1action.none
        a2 = btn2action.none
        a3 = btn3action.none

        'button 1
        Select Case selectedtab
            Case 0
                a1 = btn1action.direct
                btn1.Image = My.Resources.grayFolder
            Case 1
                If TypeOf Obj Is UTWOR Then
                    a1 = btn1action.addpl
                    btn1.Image = My.Resources.grayAdd
                End If
            Case 2
                If TypeOf Obj Is UTWOR Then
                    a1 = btn1action.direct
                    btn1.Image = My.Resources.grayFolder
                End If
        End Select

        'button 2
        Select Case selectedtab
            Case 0
                a2 = btn2action.move
                btn2.Image = My.Resources.grayArrow
            Case 1
                If Form1.searchempty Then
                    a2 = btn2action.edit
                    btn2.Image = My.Resources.grayEdit
                Else
                    a2 = btn2action.direct
                    btn2.Image = My.Resources.grayFolder
                End If
            Case 2
                If TypeOf Obj Is UTWOR Then
                    a2 = btn2action.move
                    btn2.Image = My.Resources.grayArrow
                Else
                    a2 = btn2action.edit
                    btn2.Image = My.Resources.grayEdit
                End If
        End Select

        'button 3
        a3 = btn3action.delete
        btn3.Image = My.Resources.grayDelete
    End Sub

    Private Sub clickaction()
        If TypeOf Obj Is WYKONAWCA Then
            Form1.PATHwyk = Obj
            If dane.SEThidealbums Then
                For Each i As ALBUM In Obj.albumy
                    If i.brakpozycji Then
                        Form1.PATHalb = i
                        Exit For
                    End If
                Next
            End If
            Form1.ladujpanel()
        End If
        If TypeOf Obj Is ALBUM Then
            Form1.PATHalb = Obj
            Form1.ladujpanel()
        End If
        If TypeOf Obj Is UTWOR Then
            Form1.yt.odtworzteraz(Obj)
        End If
        If TypeOf Obj Is PLAYLISTA Then
            Form1.PATHpl = Obj
            Form1.ladujpanel()
        End If
    End Sub

    Private Sub btn1_MouseEnter(sender As Object, e As EventArgs) Handles btn1.MouseEnter
        Select Case a1
            Case btn1action.direct
                sender.Image = My.Resources.colorFolder
            Case btn1action.addpl
                sender.Image = My.Resources.colorAdd
        End Select
    End Sub

    Private Sub btn1_MouseLeave(sender As Object, e As EventArgs) Handles btn1.MouseLeave
        Select Case a1
            Case btn1action.direct
                sender.Image = My.Resources.grayFolder
            Case btn1action.addpl
                sender.Image = My.Resources.grayAdd
        End Select
    End Sub

    Private Sub btn2_MouseEnter(sender As Object, e As EventArgs) Handles btn2.MouseEnter
        Select Case a2
            Case btn2action.direct
                sender.Image = My.Resources.colorFolder
            Case btn2action.edit
                sender.Image = My.Resources.colorEdit
            Case btn2action.move
                sender.Image = My.Resources.colorArrow
        End Select
    End Sub

    Private Sub btn2_MouseLeave(sender As Object, e As EventArgs) Handles btn2.MouseLeave
        Select Case a2
            Case btn2action.direct
                sender.Image = My.Resources.grayFolder
            Case btn2action.edit
                sender.Image = My.Resources.grayEdit
            Case btn2action.move
                sender.Image = My.Resources.grayArrow
        End Select
    End Sub

    Private Sub btn3_MouseEnter(sender As Object, e As EventArgs) Handles btn3.MouseEnter
        Select Case a3
            Case btn3action.delete
                sender.Image = My.Resources.colorDelete
        End Select
    End Sub

    Private Sub btn3_MouseLeave(sender As Object, e As EventArgs) Handles btn3.MouseLeave
        Select Case a3
            Case btn3action.delete
                sender.Image = My.Resources.grayDelete
        End Select
    End Sub
#End Region

    Public Sub reload()
        Refresh()
    End Sub

    Private Sub tmrhidelbl_Tick(sender As Object, e As EventArgs) Handles tmrhidelbl.Tick
        lbldodano.Visible = False
        tmrhidelbl.Enabled = False
    End Sub
End Class
