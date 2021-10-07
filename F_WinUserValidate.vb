Imports System.Drawing.Text

Public Class F_WinUserValidate

    Private ReadOnly pfc As New PrivateFontCollection

    Private weidFont As Font

    Public Event WinUserValidated()
    Private Event ValidateWinUser()
    Private Event EscapePressed(e As PreviewKeyDownEventArgs)

    Private Declare Auto Function LogonUser Lib "advapi32.dll" (ByVal lpszUsername As String, ByVal lpszDomain As String, ByVal lpszPassword As String, ByVal dwLogonType As LogonType, ByVal dwLogonProvider As Integer, ByRef phToken As IntPtr) As Integer
    Private Declare Auto Function CloseHandle Lib "kernel32.dll" (ByVal hObject As IntPtr) As Boolean

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub F_WinUserValidate_Load(sender As Object, e As EventArgs) Handles Me.Load
        Icon = g_Icon
        Me.pfc.AddFontFile(My.Resources.WeidFontFile)
        Me.weidFont = New Font(Me.pfc.Families(0), 14)
        ApplyControlsCustomFonts(Me, Me.weidFont)
        CenterControlHorizontally(Me, btnValidate)
        CenterForm(Me)
    End Sub

    Private Sub F_WinUserValidate_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Me.pfc.Dispose()
    End Sub

    Private Sub ValidateBtn_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        RaiseEvent ValidateWinUser()
    End Sub

    Private Sub ValidateBtn_MouseEnter(sender As Object, e As EventArgs) Handles btnValidate.MouseEnter
        btnValidate.ForeColor = g_WeidOrange
        btnValidate.BackColor = Color.White
    End Sub

    Private Sub ValidateBtn_MouseLeave(sender As Object, e As EventArgs) Handles btnValidate.MouseLeave
        btnValidate.ForeColor = Color.Black
        btnValidate.BackColor = Color.White
    End Sub

    Private Sub ValidateBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles btnValidate.MouseDown
        If e.Button = MouseButtons.Left Then
            btnValidate.ForeColor = Color.White
            btnValidate.BackColor = g_WeidOrange
        End If
    End Sub

    Private Sub ValidateBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles btnValidate.MouseUp
        btnValidate.ForeColor = Color.Black
        btnValidate.BackColor = Color.White
    End Sub

    Private Sub ValidateBtn_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles btnValidate.PreviewKeyDown
        RaiseEvent EscapePressed(e)
    End Sub

    Private Sub PasswordTxt_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtPassword.PreviewKeyDown
        RaiseEvent EscapePressed(e)
    End Sub

    'Custom Event Handlers
    Private Sub EH_EscapePressed(e As PreviewKeyDownEventArgs) Handles Me.EscapePressed
        If e.KeyCode = Keys.Escape Then Close()
    End Sub

    Private Async Sub EH_ValidateWinUser() Handles Me.ValidateWinUser
        Dim pw As String = txtPassword.Text
        Dim d As String = Environment.UserDomainName
        Dim un As String = Environment.UserName

        If pw = "" Then Exit Sub

        Dim validTask As Task(Of Boolean) = ValidateAsync(un, pw)

        Dim f As New F_Message
        f.ShowDialog()

        Dim valid As Boolean = Await validTask
        f.Close()

        If Not valid Then
            MsgBox("Incorrect password.")
            txtPassword.Clear()
            txtPassword.Select()
            Exit Sub
        End If

        RaiseEvent WinUserValidated()
        Close()
    End Sub

    'Private procedures
    Private Async Function ValidateAsync(parUn As String, parPw As String) As Task(Of Boolean)
        Dim b As Boolean
        If g_IsDomain Then
            b = Await Task.Run(Function() g_context.ValidateCredentials(parUn, parPw))
            g_Validated = True
        Else
            b = Await Task.Run(Function() IsAuthenticated(parUn, parPw))
        End If
        Return b
    End Function

    Private Function IsAuthenticated(ByVal Username As String, ByVal Password As String, Optional ByVal Domain As String = "") As Boolean
        Dim Token As New IntPtr
        LogonUser(Username, Domain, Password, LogonType.LOGON32_LOGON_INTERACTIVE, 0, Token)
        CloseHandle(Token)
        If Token.ToInt32 <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class