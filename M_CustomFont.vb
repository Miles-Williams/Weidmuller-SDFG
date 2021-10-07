Imports System.IO
Imports System.Reflection
Imports System.Drawing.Text
Imports System.Runtime.InteropServices

Module M_CustomFont
    Public Function LoadFont(Asm As Assembly, Name As String, Size As Integer, Style As FontStyle) As Font
        Using pfc As New PrivateFontCollection
            Dim Bytes() As Byte = GetFontData(Asm, Name)
            Dim Ptr As IntPtr = Marshal.AllocCoTaskMem(Bytes.Length)
            Marshal.Copy(Bytes, 0, Ptr, Bytes.Length)
            pfc.AddMemoryFont(Ptr, Bytes.Length)
            Marshal.FreeCoTaskMem(Ptr)
            Return New Font(pfc.Families(0), Size, Style)
        End Using
    End Function
    Public Function GetFontData(Asm As Assembly, Name As String) As Byte()
        Using Stream As Stream = Asm.GetManifestResourceStream(Name)
            If (Stream Is Nothing) Then Throw New Exception(String.Format("Unable to load font '{0}'", Name))
            Dim Buffer() As Byte = New Byte(CInt(Stream.Length - 1)) {}
            Stream.Read(Buffer, 0, CInt(Stream.Length))
            Return Buffer
        End Using
    End Function

    'Dim f As Font = LoadFont([GetType].Assembly, "Security_Declaration_Form_Generator.WM_Cond_wgl4_0.ttf", 14, FontStyle.Regular)
    'Dim f As Font = LoadFont(Reflection.Assembly.GetExecutingAssembly, "Security_Declaration_Form_Generator.WM_Cond_wgl4_0.ttf", 14, FontStyle.Regular)


    'Dim pfc as New PrivateFontCollection
    'Dim f As String = My.Resources.WeidFontFile
    'Me.pfc.AddFontFile(f)
    'Me.weidFont = New Font(Me.pfc.Families(0), 14)
    ''''''''''
    'Marshal.Copy(Me.Bytes, 0, Me.fontPtr, Me.Bytes.Length)
    'Me.pfc.AddMemoryFont(Me.fontPtr, Me.Bytes.Length)
    'Me.f = New Font(Me.pfc.Families(0), 14, FontStyle.Regular)

    ''''''''''

    'Dim fontPtr As IntPtr = Marshal.AllocCoTaskMem(Me.Bytes.Length)

    'Marshal.Copy(Me.Bytes, 0, fontPtr, Me.Bytes.Length)
    'Me.pfc.AddMemoryFont(fontPtr, Me.Bytes.Length)
    'Me.f = New Font(Me.pfc.Families(0), 14, FontStyle.Regular)

    ''''''

    'Dim asm As Assembly = Assembly.GetExecutingAssembly

    'Dim fontStream As Stream = asm.GetManifestResourceStream("Security_Declaration_Form_Generator.AmaticSC-Regular.ttf")

    'Dim fontBytes() As Byte = New Byte(CInt(fontStream.Length - 1)) {}

    'Dim fontPtr As IntPtr = Marshal.AllocCoTaskMem(fontBytes.Length)

    'fontStream.Read(fontBytes, 0, CInt(fontStream.Length))

    'Marshal.Copy(fontBytes, 0, fontPtr, fontBytes.Length)

    'Me.pfc.AddMemoryFont(fontPtr, fontBytes.Length)

    'Me.f = New Font(Me.pfc.Families(0), 14)

    ''''''''
    'Iterate through forms controls and set font where valid
    'ApplyControlsCustomFonts(Me, Me.f)
    'SetFormsCustomFont(Me, Me.pfc, g_FontResourceName, 14, FontStyle.Regular)

    'Private ReadOnly FontBytes() As Byte = GetFontData(Assembly.GetExecutingAssembly, "Security_Declaration_Form_Generator.AmaticSC-Regular.ttf")


    'Public Sub SetFormsCustomFont(parForm As Form,
    '                              ByRef parPfc As PrivateFontCollection,
    '                              parFontResourceName As String,
    '                              parSize As Integer,
    '                              parStyle As FontStyle)
    '    Dim weidFont As Font
    '    Dim FontBytes() As Byte = CType(My.Resources.ResourceManager.GetObject(parFontResourceName), Byte())
    '    Dim fontPtr As IntPtr = Marshal.AllocCoTaskMem(FontBytes.Length)
    '    Marshal.Copy(FontBytes, 0, fontPtr, FontBytes.Length)
    '    parPfc.AddMemoryFont(fontPtr, FontBytes.Length)
    '    weidFont = New Font(parPfc.Families(0), parSize, parStyle)
    '    ApplyControlsCustomFonts(parForm, weidFont)
    'End Sub
End Module
