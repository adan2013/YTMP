Imports System.Drawing.Drawing2D
Public Class LISTitem
    Public Event SelectionChanged(sender As Object)

    Friend WithEvents tmrMouseLeave As New Timer With {.Interval = 10}

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
            'Refresh()
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

    Private mObj As Boolean
    Public Property Obj() As Boolean
        Get
            Return mObj
        End Get
        Set(ByVal value As Boolean)
            mObj = value
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

    Private Sub ListControlItem_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        If Selected = False Then
            Selected = True
            RaiseEvent SelectionChanged(Me)
        End If
    End Sub

    Private Sub metroRadioGroup_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown ', rdButton.MouseDown
        bState = ButtonState.ButtonDown
        Refresh()
    End Sub

    Private Sub metroRadioGroup_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        bMouse = MouseCapture.Inside
        tmrMouseLeave.Start()
        Refresh()
    End Sub

    Private Sub metroRadioGroup_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp ', rdButton.MouseUp
        bState = ButtonState.ButtonUp
        Refresh()
    End Sub

    Private Sub tmrMouseLeave_Tick(sender As System.Object, e As System.EventArgs) Handles tmrMouseLeave.Tick
        Dim scrPT = Control.MousePosition
        Dim ctlPT As Point = Me.PointToClient(scrPT)
        '
        If ctlPT.X < 0 Or ctlPT.Y < 0 Or ctlPT.X > Me.Width Or ctlPT.Y > Me.Height Then
            ' Stop timer
            tmrMouseLeave.Stop()
            bMouse = MouseCapture.Outside
            Refresh()
        Else
            bMouse = MouseCapture.Inside
        End If
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
    End Sub

    Private Sub Paint_DrawButton(gfx As Graphics)

        Dim fnt As Font = Nothing
        Dim sz As SizeF = Nothing
        Dim layoutRect As RectangleF
        Dim SF As New StringFormat With {.Trimming = StringTrimming.EllipsisCharacter}
        Dim workingRect As New Rectangle(10, 0, Width - 10, Height)

        ' main text
        fnt = New Font("Segoe UI Light", 14)
        sz = gfx.MeasureString(mMain, fnt)
        layoutRect = New RectangleF(6, 2, workingRect.Width, sz.Height)
        gfx.DrawString(mMain, fnt, Brushes.Black, layoutRect, SF)

        ' sub text 1
        fnt = New Font("Segoe UI Light", 10)
        sz = gfx.MeasureString(mSub1, fnt)
        layoutRect = New RectangleF(8, 30, workingRect.Width, sz.Height)
        gfx.DrawString(mSub1, fnt, Brushes.Black, layoutRect, SF)

        ' sub text 2
        fnt = New Font("Segoe UI Light", 10)
        sz = gfx.MeasureString(mSub2, fnt)
        layoutRect = New RectangleF(8, 48, workingRect.Width, sz.Height)
        gfx.DrawString(mSub2, fnt, Brushes.Black, layoutRect, SF)

        If mArrow Then
            gfx.DrawImage(My.Resources.arrow_menu, New Rectangle(Width - 20, Height / 2 - 8, 16, 16))
        End If
    End Sub

    Private Sub PaintEvent(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim gfx = e.Graphics
        Paint_DrawBackground(gfx)
        Paint_DrawButton(gfx)
    End Sub
#End Region

    Public Sub reload()
        Refresh()
    End Sub
End Class
