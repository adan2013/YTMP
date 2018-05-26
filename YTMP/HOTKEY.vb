Public Class HOTKEY

    'VARIABLES
    Dim listofhotkeys As List(Of HotKeysList) = New List(Of HotKeysList)
    Dim newid As Integer = 1
    Dim _isworking As Boolean = False
    Dim _targetform As Form = Nothing

    'EVENTS
    Public Event HotKeyDetected(ByVal tagname As String)

    'WINAPI
    Private Declare Function RegisterHotKey Lib "user32" (ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer
    Private Declare Function UnregisterHotKey Lib "user32" (ByVal hwnd As IntPtr, ByVal id As Integer) As Integer

    'CONSTANTS
    Public Const WM_HOTKEY As Integer = &H312

    'ENUMS
    Public Enum KeyModifier
        None = 0
        Alt = &H1
        Control = &H2
        Shift = &H4
        Winkey = &H8
    End Enum

#Region "PROPERTIES"

    Public ReadOnly Property isworking() As Boolean
        Get
            Return _isworking
        End Get
    End Property

    Public ReadOnly Property targetform() As Form
        Get
            Return _targetform
        End Get
    End Property
#End Region

#Region "CLASS HOTKEYSLIST"

    Public Class HotKeysList

        Public ReadOnly id As Integer
        Public tag As String
        Public key As Keys
        Public modifier As KeyModifier

        Public Sub New(ByVal idnumber As Integer)
            id = idnumber
        End Sub
    End Class
#End Region

#Region "CORE"

    Public Function startworking(ByRef target As Form) As Boolean
        If _isworking Then Return False
        _targetform = target
        turnONhotkeys()
        _isworking = True
        Return True
    End Function

    Public Function endworking() As Boolean
        If Not _isworking Then Return False
        turnOFFhotkeys()
        _isworking = False
        _targetform = Nothing
        Return True
    End Function

    Public Sub messagehook(ByRef data As Message)
        If _isworking AndAlso data.Msg = WM_HOTKEY Then
            For Each i As HotKeysList In listofhotkeys
                If i.id = data.WParam Then
                    RaiseEvent HotKeyDetected(i.tag)
                    Exit For
                End If
            Next
        End If
    End Sub

    Public Function getInfo() As String
        Return "biblioteka napisana w języku VB.NET do obsługi niskopoziomowych skrótych klawiaturowych, autor: adan2013"
    End Function

    Protected Overrides Sub Finalize()
        If _isworking Then Throw New Exception("HOTKEY: nastąpiła próba zakończenia działania aplikacji bez wczesnego odrejestrowania skrótów!")
        MyBase.Finalize()
    End Sub
#End Region

#Region "LIST OF HOTKEYS"

    Public Function addHotKey(ByVal tag As String, ByVal key As Keys, Optional ByVal modifier As KeyModifier = KeyModifier.None) As Boolean
        If Not _isworking Then Return False
        Dim existflag As Boolean = False
        For Each i As HotKeysList In listofhotkeys
            If i.tag = tag Then
                existflag = True
                Exit For
            End If
        Next
        If existflag Then
            Return False
        Else
            Dim n As HotKeysList = New HotKeysList(newid)
            n.tag = tag
            n.key = key
            n.modifier = modifier
            listofhotkeys.Add(n)
            newid += 1
            registersinglehotkey(n)
            Return True
        End If
    End Function

    Public Function modHotKey(ByVal tag As String, ByVal newkey As Keys, ByVal newmodifier As KeyModifier) As Boolean
        If Not _isworking Then Return False
        Dim m As HotKeysList = Nothing
        For Each i As HotKeysList In listofhotkeys
            If i.tag = tag Then
                m = i
                Exit For
            End If
        Next
        If m Is Nothing Then Return False
        unregistersinglehotkey(m)
        m.key = newkey
        m.modifier = newmodifier
        registersinglehotkey(m)
        Return True
    End Function

    Public Function deleteHotKey(ByVal tag As String) As Boolean
        If Not _isworking Then Return False
        Dim m As HotKeysList = Nothing
        For Each i As HotKeysList In listofhotkeys
            If i.tag = tag Then
                m = i
                Exit For
            End If
        Next
        If m Is Nothing Then Return False
        unregistersinglehotkey(m)
        listofhotkeys.Remove(m)
        Return True
    End Function

    Public Function deleteAllHotKeys() As Boolean
        If Not _isworking Then Return False
        turnOFFhotkeys()
        listofhotkeys.Clear()
        Return True
    End Function

    Public Function getHotKeys() As List(Of HotKeysList)
        Return listofhotkeys
    End Function
#End Region

#Region "REGISTRY OF HOTKEYS"

    Private Sub registersinglehotkey(ByRef obj As HotKeysList)
        RegisterHotKey(targetform.Handle, obj.id, obj.modifier, CType(obj.key, Integer))
    End Sub

    Private Sub unregistersinglehotkey(ByRef obj As HotKeysList)
        UnregisterHotKey(targetform.Handle, obj.id)
    End Sub

    Private Sub turnONhotkeys()
        For Each i As HotKeysList In listofhotkeys
            registersinglehotkey(i)
        Next
    End Sub

    Private Sub turnOFFhotkeys()
        For Each i As HotKeysList In listofhotkeys
            unregistersinglehotkey(i)
        Next
    End Sub
#End Region
End Class
