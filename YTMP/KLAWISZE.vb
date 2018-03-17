<Serializable()>
Public Class KLAWISZE

    Public nazwa As String = ""
    Public CTRLmod As Boolean = False
    Public ALTmod As Boolean = False
    Public SHIFTmod As Boolean = False
    Public KEY As String = ""

    Public Sub New(ByVal INITnazwa As String)
        nazwa = INITnazwa
    End Sub

    Public Sub uruchom()
        Select Case nazwa
            Case "play/pause"
                Form1.yt.playpause()
            Case "poprzedni utwór"
                Form1.yt.poprzedniutwor()
            Case "następny utwór"
                Form1.yt.nastepnyutwor()
            Case "wycisz/odcisz"
                Form1.btnmute_Click(Form1.btnmute, New EventArgs())
            Case "zmniejsz głośność"
                If dane.volume >= 10 Then
                    dane.volume -= 10
                    Form1.pnlglosnosc.Size = New Size(dane.volume, Form1.pnlglosnosc.Size.Height)
                End If
                pilot.aktualizacja()
            Case "zwiększ głośność"
                If dane.volume <= 90 Then
                    dane.volume += 10
                    Form1.pnlglosnosc.Size = New Size(dane.volume, Form1.pnlglosnosc.Size.Height)
                End If
                pilot.aktualizacja()
        End Select
    End Sub
End Class
