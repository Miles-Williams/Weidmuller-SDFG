Imports System.Drawing.Text
Imports System.Text

Public Class F_Message
    'Displayed while async task running so the user doesn't think the application has frozen
    Private ReadOnly pfc As New PrivateFontCollection

    Private weidFont As Font
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub F_Message_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = g_Icon
        Me.pfc.AddFontFile(My.Resources.WeidFontFile)
        Me.weidFont = New Font(Me.pfc.Families(0), 48)
        ApplyControlsCustomFonts(Me, Me.weidFont)
        CenterForm(Me)
    End Sub

    Private Sub F_Message_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Me.pfc.Dispose()
    End Sub

    Private Sub F_Message_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim i As Integer = 1
        Dim sb As New StringBuilder

        While Not g_Validated
            If i = 4 Then
                i = 1
                sb.Clear()
            End If
            sb.Append(".")
            lblValidating.Text = sb.ToString
            CenterControl(Me, lblValidating)
            Wait(900)
            i += 1
        End While

        g_Validated = False
        Close()
    End Sub

End Class