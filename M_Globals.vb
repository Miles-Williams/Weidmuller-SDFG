Imports System.DirectoryServices.AccountManagement
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.Win32

Public Enum LogonType As Integer
    LOGON32_LOGON_INTERACTIVE = 2
    LOGON32_LOGON_NETWORK = 3
    LOGON32_LOGON_BATCH = 4
    LOGON32_LOGON_SERVICE = 5
    LOGON32_LOGON_UNLOCK = 7
    LOGON32_LOGON_NETWORK_CLEARTEXT = 8
    LOGON32_LOGON_NEW_CREDENTIALS = 9
End Enum
Public Enum E_Destination
    Domestic
    International
End Enum
Public Enum E_PrintMedium
    Paper
    Sticker
    Both
    None
End Enum

Module M_Globals
    Public g_context As PrincipalContext
    Public g_Icon As Icon
    Public g_Validated As Boolean
    Public g_IsDomain As Boolean
    Public g_WeidOrange As Color = Color.FromArgb(235, 140, 0)

    'Public Sub Main()
    '    Application.EnableVisualStyles()
    '    Application.SetCompatibleTextRenderingDefault(True)
    '    Application.Run(F_Main)
    'End Sub

    Public Sub ApplyControlsCustomFonts(parForm As Form, parFont As Font)
        For Each c As Control In parForm.Controls
            ApplyControlsCustomFontsRecursively(c, parFont)
        Next
    End Sub

    Private Sub ApplyControlsCustomFontsRecursively(parControl As Control, parFont As Font)
        Try
            If parControl.HasChildren Then
                For Each c As Control In parControl.Controls
                    ApplyControlsCustomFontsRecursively(c, parFont)
                Next
            End If

            If TypeOf parControl IsNot PictureBox Then
                parControl.Font = parFont
            End If
        Catch e As Exception
            MsgBox(e.ToString)
        End Try
    End Sub

    Public Function ContainsSpecialChars(s As String) As Boolean
        Return s.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?]".ToCharArray) <> -1
    End Function

    Public Function ContainsInvalidFilenameChars(s As String) As Boolean
        Return s.IndexOfAny("<>/\:*?|""".ToCharArray()) <> -1
    End Function

    Public Sub CenterForm(parForm As Form)
        parForm.Left = CInt((Screen.PrimaryScreen.Bounds.Width / 2) - (parForm.Width / 2))
        parForm.Top = CInt((Screen.PrimaryScreen.Bounds.Height / 2) - (parForm.Height / 2))
    End Sub

    Public Sub CenterControlHorizontally(parForm As Form, parControl As Control)
        parControl.Left = CInt((parForm.ClientSize.Width / 2) - (parControl.Width / 2))
    End Sub

    Public Sub CenterControl(parForm As Form, parControl As Control)
        parControl.Left = CInt((parForm.ClientSize.Width / 2) - (parControl.Width / 2))
        parControl.Top = CInt((parForm.ClientSize.Height / 2) - (parControl.Height / 2))
    End Sub

    Public Sub InitializeIcon()
        If UseLightIcon() Then
            g_Icon = My.Resources.WeidLogoLightGrey
        Else
            g_Icon = My.Resources.WeidLogo
        End If
    End Sub

    Private Function UseLightIcon() As Boolean
        'Calculate the "darkness" of the users Accent Color by checking the Desktop Window Manager
        'registry key. ColorPrevalence returns true if Accent Color is applied to title bars and window borders.
        'AccentColor returns an ABGR value which gets cast to a String of its Hex representation so that
        'the individual R, G, and B values can be plucked out and used in a formula to determine "darkness".
        Dim key As RegistryKey

        If IsPreWin8() Then GoTo ReturnFalse

        Try
            key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\DWM")

            Dim oAccentColor As Object = key.GetValue("AccentColor")
            If oAccentColor Is Nothing Then GoTo ReturnFalse

            Dim oColorPrevalance As Object = key.GetValue("ColorPrevalence")
            If oColorPrevalance Is Nothing Then GoTo ReturnFalse

            Dim s As String = Hex(oAccentColor).ToString()
            Dim rs As String = Mid(s, 7, 2)
            Dim gs As String = Mid(s, 5, 2)
            Dim bs As String = Mid(s, 3, 2)

            Dim r As Integer = Convert.ToInt32(rs, 16)
            Dim g As Integer = Convert.ToInt32(gs, 16)
            Dim b As Integer = Convert.ToInt32(bs, 16)

            Dim isDarkAccent As Boolean = ((5 * CInt(g)) + (2 * CInt(r)) + CInt(b)) <= 1024

            If CInt(oColorPrevalance) <> 0 Then
                If isDarkAccent Then Return True
            End If
        Catch e As Exception
            MsgBox(e.ToString)
        End Try

ReturnFalse:
        Return False
    End Function

    Private Function IsPreWin8() As Boolean
        Dim os As OperatingSystem = Environment.OSVersion
        Dim vs As Version = os.Version
        Dim major As Integer = vs.Major
        Dim minor As Integer = vs.Minor
        If major = 10 Then Return False
        If major = 6 Then
            If minor > 1 Then Return False
        End If
        Return True
    End Function

    Public Function DeserializeState() As C_State
        'Get saved State from .bin file or else a new State
        Dim AppState As New C_State
        If File.Exists(My.Resources.StateFileName) Then
            Dim fs As Stream = File.OpenRead(My.Resources.StateFileName)
            Dim deserializer As New BinaryFormatter
            AppState = CType(deserializer.Deserialize(fs), C_State)
            fs.Close()
        End If
        Return AppState
    End Function

    Public Sub SerializeState(parState As C_State)
        'Save State object to .bin file
        Dim fs As Stream = File.Create(My.Resources.StateFileName)
        Dim serializer As New BinaryFormatter
        serializer.Serialize(fs, parState)
        fs.Close()
    End Sub

    Public Function GetCopyOfState(parState As C_State) As C_State
        'Get a deep copy of the State object
        SerializeState(parState)
        Dim AppState As C_State = DeserializeState()
        Return AppState
    End Function

    Public Sub PrepareStateForClose(ByRef parState As C_State)
        'Clear values that should be volatile
        parState.VolatileState.CurrentUser = Nothing
        parState.VolatileState.FirstConNumber = ""
        parState.VolatileState.ConNumbers = ""
    End Sub

    Public Function GetSHA512String(ByVal parIn As String) As String
        Dim sha512 As SHA512 = SHA512.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(parIn)
        Dim hash As Byte() = sha512.ComputeHash(bytes)
        Dim sb As New StringBuilder()

        For i As Integer = 0 To hash.Length - 1
            sb.Append(hash(i).ToString("X2"))
        Next

        Return sb.ToString()
    End Function

    Public Function GetSaltString() As String
        'Get a random 16 byte string to use as a salt in a SHA
        Dim rng As New RNGCryptoServiceProvider
        Dim buffer(15) As Byte
        rng.GetBytes(buffer)
        Return Convert.ToBase64String(buffer)
    End Function

    Public Function GetHashedPw(ByVal parPw As String, parSalt As String) As String
        Return GetSHA512String(parPw & parSalt)
    End Function

    Public Async Sub GetContextAsync(parUseDomain As Boolean)
        If parUseDomain Then
            g_context = Await Task.Run(Function() New PrincipalContext(ContextType.Domain))
        Else
            g_context = Await Task.Run(Function() New PrincipalContext(ContextType.Machine))
        End If
    End Sub

    Public Sub Wait(ByVal parMilliseconds As Double, Optional ByRef parBreakCondition As Boolean = False)
        Dim waitUntil As Date
        waitUntil = Now.AddMilliseconds(parMilliseconds)
        Do Until Now > waitUntil
            If parBreakCondition Then Exit Do
            Application.DoEvents()
        Loop
    End Sub

End Module
