﻿Public Class LISTcontrol

    Public Event ItemClick(sender As Object, Index As Integer)

    Dim mLastSelected As LISTitem = Nothing

    Const heightitem As Integer = 70

    Public Sub Add(Text1 As String, Text2 As String, Text3 As String, Arrow As Boolean, Obj As Object)
        Dim c As New LISTitem
        With c
            ' Assign an auto generated name
            .Name = "item" & flp.Controls.Count + 1
            .Margin = New Padding(0)
            ' set properties
            .MainText = Text1
            .SubText1 = Text2
            .SubText2 = Text3
            .Arrow = Arrow
            .Obj = Obj
            .reload()
        End With
        ' To check when the selection is changed
        AddHandler c.SelectionChanged, AddressOf SelectionChanged
        AddHandler c.Click, AddressOf ItemClicked
        flp.Controls.Add(c)
        'SetupAnchors()
    End Sub

    Public Sub Remove(Index As Integer)
        Dim c As LISTitem = flp.Controls(Index)
        Remove(c.Name)  ' call the below sub
    End Sub

    Public Sub Remove(name As String)
        ' grab which control is being removed
        Dim c As LISTitem = flp.Controls(name)
        flp.Controls.Remove(c)
        ' remove the event hook
        RemoveHandler c.SelectionChanged, AddressOf SelectionChanged
        RemoveHandler c.Click, AddressOf ItemClicked
        ' now dispose off properly
        c.Dispose()
        'SetupAnchors()
    End Sub

    Public Sub Clear()
        flp.Controls.Clear()
        mLastSelected = Nothing
        'Do
        '    If flp.Controls.Count = 0 Then Exit Do
        '    Dim c As LISTitem = flp.Controls(0)
        '    flp.Controls.Remove(c)
        '    ' remove the event hook
        '    RemoveHandler c.SelectionChanged, AddressOf SelectionChanged
        '    RemoveHandler c.Click, AddressOf ItemClicked
        '    ' now dispose off properly
        '    c.Dispose()
        'Loop
        'mLastSelected = Nothing
    End Sub

    Public Function getMyIndex(ByRef item As LISTitem) As Integer
        Return flp.Controls.IndexOf(item)
    End Function

    Public ReadOnly Property Count() As Integer
        Get
            Return flp.Controls.Count
        End Get
    End Property

    'Private Sub SetupAnchors()
    '    If flp.Controls.Count > 0 Then
    '        For i = 0 To flp.Controls.Count - 1
    '            Dim c As Control = flp.Controls(i)
    '            If i = 0 Then
    '                ' Its the first control, all subsequent controls follow 
    '                ' the anchor behavior of this control.
    '                c.Anchor = AnchorStyles.Left + AnchorStyles.Top
    '                If flp.Controls.Count > 3 Then
    '                    c.Width = flp.Width - SystemInformation.VerticalScrollBarWidth
    '                Else
    '                    c.Width = flp.Width
    '                End If
    '            Else
    '                ' It is not the first control. Set its anchor to
    '                ' copy the width of the first control in the list.
    '                c.Anchor = AnchorStyles.Left + AnchorStyles.Right
    '            End If
    '        Next
    '    End If
    'End Sub

    Private Sub flp_Resize(sender As Object, e As EventArgs) Handles flp.Resize
        If flp.Controls.Count Then
            flp.Controls(0).Width = flp.Width - SystemInformation.VerticalScrollBarWidth
        End If
    End Sub

    Private Sub SelectionChanged(sender As Object)
        If mLastSelected IsNot Nothing Then
            mLastSelected.Selected = False
        End If
        mLastSelected = sender
    End Sub

    Private Sub ItemClicked(sender As Object, e As EventArgs)
        RaiseEvent ItemClick(Me, flp.Controls.IndexOfKey(sender.name))
    End Sub

    Public Sub turnOFF()
        flp.Visible = False
    End Sub

    Public Sub turnON()
        Dim newsize As Integer = flp.Width
        If heightitem * flp.Controls.Count > Height Then newsize -= SystemInformation.VerticalScrollBarWidth
        For Each i As Control In flp.Controls
            i.Width = newsize
        Next
        flp.Visible = True
    End Sub
End Class
