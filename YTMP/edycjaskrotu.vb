﻿Public Class edycjaskrotu

    Public wynik As KLAWISZE
    Dim msg As Boolean = False

    Private Sub edycjaskrotu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lbl As Label = New Label()
        With lbl
            .TextAlign = ContentAlignment.MiddleCenter
            .Font = New Font("Segoe UI", 9)
            .Text = "Przytrzymaj klawisze modyfikatorów (ctrl, alt, shift)," & vbNewLine & "a następnie wciśnij klawisz skrótu" & vbNewLine & vbNewLine & "Naciśnij ESC, aby anulować i usunąć skrót"
            .Location = New Point(0, 0)
            .Size = New Size(300, 120)
        End With
        Controls.Add(lbl)
    End Sub

    Public Sub odczyt(ByVal key As String)
        If msg Then Exit Sub
        If key = "Escape" Then
            DialogResult = DialogResult.Cancel
        Else
            wynik = New KLAWISZE("WYNIK")
            wynik.CTRLmod = My.Computer.Keyboard.CtrlKeyDown
            wynik.ALTmod = My.Computer.Keyboard.AltKeyDown
            wynik.SHIFTmod = My.Computer.Keyboard.ShiftKeyDown
            wynik.KEY = key
            Dim s As String = "Wykryto następujący skrót:" & vbNewLine & vbNewLine
            s &= IIf(wynik.CTRLmod, "CTRL + ", "")
            s &= IIf(wynik.ALTmod, "ALT + ", "")
            s &= IIf(wynik.SHIFTmod, "SHIFT + ", "")
            s &= wynik.KEY
            s &= vbNewLine & vbNewLine & "Zapisać skrót?"
            msg = True
            If MsgBox(s, MsgBoxStyle.Information + MsgBoxStyle.YesNo, "YTMP") = MsgBoxResult.Yes Then
                DialogResult = DialogResult.OK
            Else
                wynik = Nothing
            End If
            msg = False
        End If
    End Sub
End Class