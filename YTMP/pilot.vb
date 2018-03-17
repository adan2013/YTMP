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
End Class