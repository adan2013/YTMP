Public Class newitemform

    Public Sub laduj(ByVal pref As Byte)
        btnW.BackColor = SystemColors.Control
        btnA.BackColor = SystemColors.Control
        btnU.BackColor = SystemColors.Control
        Select Case pref
            Case 1
                btnW.BackColor = Color.Orange
            Case 2
                btnA.BackColor = Color.Orange
            Case 3
                btnU.BackColor = Color.Orange
        End Select
        If dane.SEThidealbums Then btnA.Enabled = False Else btnA.Enabled = True
        ShowDialog()
    End Sub

    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        MODwyk.ShowDialog()
        MODwyk.Close()
        Close()
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        MODalb.ShowDialog()
        MODalb.Close()
        Close()
    End Sub

    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        Form1.WindowState = FormWindowState.Minimized
        If ytbrowser.Visible Then
            ytbrowser.WindowState = FormWindowState.Normal
            ytbrowser.Activate()
        Else
            ytbrowser.Show()
        End If
        Close()
    End Sub
End Class