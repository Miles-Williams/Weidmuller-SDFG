Imports System.ComponentModel
Imports System.Drawing.Text
Imports System.Text

Public Class F_Main

    Private ReadOnly pfc As New PrivateFontCollection

    Private weidFont As Font
    Private userValidated As Boolean

    Private AppState As C_State
    Private TempState As C_State
    Private ExcelData As C_ExcelData

    Private WithEvents ConfigurationForm As F_Configuration
    Private WithEvents LoginForm As F_Login
    Private WithEvents ValidateUserForm As F_Login
    Private WithEvents WinUserValidateForm As F_WinUserValidate

    Private Event AddConNumToList()
    Private Event RemoveConNumFromList()
    Private Event CreateConsignment()
    Private Event BothPrintersChkChanged()
    Private Event StickerChkChanged()
    Private Event PaperChkChanged()
    Private Event InternationalRdbChanged()
    Private Event DomesticRdbChanged()
    Private Event TollPrefixChkChanged()

    Public Sub New()
        InitializeComponent()
        InitializeIcon()
        Me.AppState = DeserializeState()
        If Me.AppState.VolatileState.CurrentUser Is Nothing Then
            Me.AppState.VolatileState.CurrentUser = New C_User("", "Guest", "", "")
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = g_Icon
        Me.pfc.AddFontFile(My.Resources.WeidFontFile)
        Me.weidFont = New Font(Me.pfc.Families(0), 14)
        ApplyControlsCustomFonts(Me, Me.weidFont)
        InitMainForm()
        CenterForm(Me)
    End Sub

    Private Sub F_Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        PrepareStateForClose(Me.AppState)
        SerializeState(Me.AppState)
    End Sub

    Private Sub F_Main_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Me.pfc.Dispose()
    End Sub

    Private Sub AddConsignmentBtn_Click(sender As Object, e As EventArgs) Handles btnAddConsignment.Click
        RaiseEvent AddConNumToList()
    End Sub

    Private Sub CreateConsignmentBtn_Click(sender As Object, e As EventArgs) Handles btnCreateConsignment.Click
        RaiseEvent CreateConsignment()
    End Sub

    Private Sub LoginTsb_Click(sender As Object, e As EventArgs) Handles tsbLogin.Click
        LoginForm = New F_Login(Me.AppState)
        LoginForm.ShowDialog(Me)
    End Sub

    Private Sub ConfigurationTsb_Click(sender As Object, e As EventArgs) Handles tsbConfiguration.Click
        Dim isDomain As String = Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName
        If isDomain = "" Then
            g_IsDomain = False
        Else
            g_IsDomain = True
        End If
        GetContextAsync(g_IsDomain)
        WinUserValidateForm = New F_WinUserValidate()
        WinUserValidateForm.ShowDialog(Me)
    End Sub

    Private Sub AboutTsb_Click(sender As Object, e As EventArgs) Handles tsbAbout.Click
        Dim sb = New StringBuilder()
        sb.AppendLine("Security Declaration Form Generator.")
        sb.AppendLine()
        sb.AppendLine("Version: 1.0.0")
        sb.AppendLine()
        sb.AppendLine("Copyright © Miles Williams 2020.")
        sb.AppendLine()
        sb.AppendLine("For Weidmüller Australia Pty Ltd.")
        sb.AppendLine()
        sb.Append("A tool for automating the process of generating, printing, and saving digitally signed PDF format")
        sb.Append(" ""Security Declaration Forms"" for use with the Department of Home Affairs - Known Consignor Scheme.")
        MsgBox(sb.ToString, MsgBoxStyle.ApplicationModal, "About")
    End Sub

    Private Sub BothPrintersChk_CheckedChanged(sender As Object, e As EventArgs) Handles chkBothPrinters.CheckedChanged
        RaiseEvent BothPrintersChkChanged()
    End Sub


    Private Sub StickerChk_CheckedChanged(sender As Object, e As EventArgs) Handles chkSticker.CheckedChanged
        RaiseEvent StickerChkChanged()
    End Sub

    Private Sub PaperChk_CheckedChanged(sender As Object, e As EventArgs) Handles chkPaper.CheckedChanged
        RaiseEvent PaperChkChanged()
    End Sub

    Private Sub RemoveConsignmentBtn_Click(sender As Object, e As EventArgs) Handles btnRemoveConsignment.Click
        RaiseEvent RemoveConNumFromList()
    End Sub

    Private Sub InternationalRdb_CheckedChanged(sender As Object, e As EventArgs) Handles rdbInternational.CheckedChanged
        RaiseEvent InternationalRdbChanged()
    End Sub

    Private Sub DomesticRdb_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDomestic.CheckedChanged
        RaiseEvent DomesticRdbChanged()
    End Sub

    Private Sub TollPrefixChk_CheckedChanged(sender As Object, e As EventArgs) Handles chkTollPrefix.CheckedChanged
        RaiseEvent TollPrefixChkChanged()
    End Sub

    Private Sub ContentsTxt_TextChanged(sender As Object, e As EventArgs) Handles txtContents.TextChanged
        Me.AppState.Contents = txtContents.Text
    End Sub

    Private Sub DefaultContentsBtn_Click(sender As Object, e As EventArgs) Handles btnDefaultContents.Click
        txtContents.Text = Me.AppState.Configuration.DefaultContents
    End Sub

    Private Sub ConsignmentsLst_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles lstConsignments.PreviewKeyDown
        If e.KeyCode = Keys.Delete Then RaiseEvent RemoveConNumFromList()
    End Sub

    Private Sub ConsignmentTxt_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtConsignment.PreviewKeyDown
        If e.Control = True And e.KeyCode = Keys.Enter Then
            RaiseEvent CreateConsignment()
        ElseIf e.KeyCode = Keys.Enter Then
            RaiseEvent AddConNumToList()
        End If
    End Sub

    Private Sub DefaultContentsBtn_MouseEnter(sender As Object, e As EventArgs) Handles btnDefaultContents.MouseEnter
        btnDefaultContents.ForeColor = g_WeidOrange
        btnDefaultContents.BackColor = Color.White
    End Sub

    Private Sub DefaultContentsBtn_MouseLeave(sender As Object, e As EventArgs) Handles btnDefaultContents.MouseLeave
        btnDefaultContents.ForeColor = Color.Black
        btnDefaultContents.BackColor = Color.White
    End Sub

    Private Sub DefaultContentsBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles btnDefaultContents.MouseDown
        If e.Button = MouseButtons.Left Then
            btnDefaultContents.ForeColor = Color.White
            btnDefaultContents.BackColor = g_WeidOrange
        End If
    End Sub

    Private Sub DefaultContentsBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles btnDefaultContents.MouseUp
        btnDefaultContents.ForeColor = g_WeidOrange
        btnDefaultContents.BackColor = Color.White
    End Sub

    Private Sub AddConsignmentBtn_MouseEnter(sender As Object, e As EventArgs) Handles btnAddConsignment.MouseEnter
        btnAddConsignment.ForeColor = g_WeidOrange
        btnAddConsignment.BackColor = Color.White
    End Sub

    Private Sub AddConsignmentBtn_MouseLeave(sender As Object, e As EventArgs) Handles btnAddConsignment.MouseLeave
        btnAddConsignment.ForeColor = Color.Black
        btnAddConsignment.BackColor = Color.White
    End Sub

    Private Sub AddConsignmentBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles btnAddConsignment.MouseDown
        If e.Button = MouseButtons.Left Then
            btnAddConsignment.ForeColor = Color.White
            btnAddConsignment.BackColor = g_WeidOrange
        End If
    End Sub

    Private Sub AddConsignmentBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles btnAddConsignment.MouseUp
        btnAddConsignment.ForeColor = g_WeidOrange
        btnAddConsignment.BackColor = Color.White
    End Sub

    Private Sub RemoveConsignmentBtn_MouseEnter(sender As Object, e As EventArgs) Handles btnRemoveConsignment.MouseEnter
        btnRemoveConsignment.ForeColor = g_WeidOrange
        btnRemoveConsignment.BackColor = Color.White
    End Sub

    Private Sub RemoveConsignmentBtn_MouseLeave(sender As Object, e As EventArgs) Handles btnRemoveConsignment.MouseLeave
        btnRemoveConsignment.ForeColor = Color.Black
        btnRemoveConsignment.BackColor = Color.White
    End Sub

    Private Sub RemoveConsignmentBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles btnRemoveConsignment.MouseDown
        If e.Button = MouseButtons.Left Then
            btnRemoveConsignment.ForeColor = Color.White
            btnRemoveConsignment.BackColor = g_WeidOrange
        End If
    End Sub

    Private Sub RemoveConsignmentBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles btnRemoveConsignment.MouseUp
        btnRemoveConsignment.ForeColor = g_WeidOrange
        btnRemoveConsignment.BackColor = Color.White
    End Sub

    Private Sub CreateConsignmentBtn_MouseEnter(sender As Object, e As EventArgs) Handles btnCreateConsignment.MouseEnter
        btnCreateConsignment.ForeColor = g_WeidOrange
        btnCreateConsignment.BackColor = Color.White
    End Sub

    Private Sub CreateConsignmentBtn_MouseLeave(sender As Object, e As EventArgs) Handles btnCreateConsignment.MouseLeave
        btnCreateConsignment.ForeColor = Color.Black
        btnCreateConsignment.BackColor = Color.White
    End Sub

    Private Sub CreateConsignmentBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles btnCreateConsignment.MouseDown
        If e.Button = MouseButtons.Left Then
            btnCreateConsignment.ForeColor = Color.White
            btnCreateConsignment.BackColor = g_WeidOrange
        End If
    End Sub

    Private Sub CreateConsignmentBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles btnCreateConsignment.MouseUp
        btnCreateConsignment.ForeColor = g_WeidOrange
        btnCreateConsignment.BackColor = Color.White
    End Sub

    'Custom Event Handlers

    'From child form events
    Private Sub EH_UserValidated() Handles ValidateUserForm.LoginSuccess
        Me.userValidated = True
    End Sub

    Private Sub EH_WinUserValidated() Handles WinUserValidateForm.WinUserValidated
        Me.TempState = GetCopyOfState(Me.AppState)
        ConfigurationForm = New F_Configuration(Me.TempState)
        ConfigurationForm.ShowDialog(Me)
    End Sub

    Private Sub EH_ConfigStateChanged() Handles ConfigurationForm.ConfigStateChanged
        MsgBox("Configuration saved.")
        Me.AppState = GetCopyOfState(Me.TempState)
        InitMainForm()
    End Sub
    Private Sub EH_LoginSuccess() Handles LoginForm.LoginSuccess
        MsgBox("Login Successful.")
        lblCurrentUsername.Text = Me.AppState.VolatileState.CurrentUser.Username
        txtIssuedBy.Text = Me.AppState.VolatileState.CurrentUser.FullName
        txtIssuedBy.Enabled = False
    End Sub

    'From internal events
    Private Sub EH_AddConNumToList() Handles Me.AddConNumToList
        Dim consignment As String = txtConsignment.Text
        If consignment <> "" Then
            If ContainsInvalidFilenameChars(consignment) Then
                MsgBox("Consignment number can not contain any of the following characters: " &
                       Environment.NewLine &
                       """ < > | ? \ / * :")
                GoTo Clear
            End If
            If chkTollPrefix.Checked Then consignment = "87750" & consignment
            lstConsignments.Items.Add(consignment)
        End If
Clear:
        txtConsignment.Clear()
        txtConsignment.Select()
    End Sub

    Private Sub EH_RemoveConNumFromList() Handles Me.RemoveConNumFromList
        lstConsignments.Items.Remove(lstConsignments.SelectedItem)
    End Sub

    Private Sub EH_CreateConsignment() Handles Me.CreateConsignment
        If lstConsignments.Items.Count <> 0 Then
            If Me.AppState.VolatileState.CurrentUser.Username = "Guest" Then Me.AppState.VolatileState.CurrentUser.FullName = txtIssuedBy.Text
            Me.AppState.VolatileState.FirstConNumber = CStr(lstConsignments.Items.Item(0))
            Me.AppState.VolatileState.ConNumbers = CreateConNumString(lstConsignments.Items)
            Me.AppState.PaperCopies = CInt(nudPaperCopies.Value)
            Me.AppState.StickerCopies = CInt(nudStickerCopies.Value)
            RunPreExcelInit(Me.AppState)
        End If
    End Sub

    Private Sub EH_BothPrintersChkChanged() Handles Me.BothPrintersChkChanged
        If chkBothPrinters.Checked = True Then
            chkPaper.Checked = False
            chkSticker.Checked = False
            chkPaper.Enabled = False
            chkSticker.Enabled = False
            nudPaperCopies.Enabled = True
            nudStickerCopies.Enabled = True
            Me.AppState.PrintMedium = E_PrintMedium.Both
        Else
            chkSticker.Enabled = True
            chkPaper.Enabled = True
            nudStickerCopies.Enabled = False
            nudPaperCopies.Enabled = False
            Me.AppState.PrintMedium = E_PrintMedium.None
        End If
    End Sub

    Private Sub EH_StickerChkChanged() Handles Me.StickerChkChanged
        If chkSticker.Checked = False And chkBothPrinters.Checked = False Then
            nudStickerCopies.Enabled = False
            Me.AppState.PrintMedium = E_PrintMedium.None
            Exit Sub
        End If

        If chkSticker.Checked = True Then
            If Me.AppState.Configuration.CurrentStickerPrinter = "" Then
                MsgBox("Please use the configuration utility to select a sticker printer.", Title:="No sticker printer.")
                chkSticker.Checked = False
                Exit Sub
            End If

            chkPaper.Checked = False
            nudStickerCopies.Enabled = True
            Me.AppState.PrintMedium = E_PrintMedium.Sticker
        End If
    End Sub

    Private Sub EH_PaperChkChanged() Handles Me.PaperChkChanged
        If chkPaper.Checked = False And chkBothPrinters.Checked = False Then
            nudPaperCopies.Enabled = False
            Me.AppState.PrintMedium = E_PrintMedium.None
            Exit Sub
        End If

        If chkPaper.Checked = True Then
            If Me.AppState.Configuration.CurrentPaperPrinter = "" Then
                MsgBox("Please use the configuration utility to select a paper printer.", Title:="No paper printer.")
                chkPaper.Checked = False
                Exit Sub
            End If

            chkSticker.Checked = False
            nudPaperCopies.Enabled = True
            Me.AppState.PrintMedium = E_PrintMedium.Paper
        End If
    End Sub

    Private Sub EH_InternationalRdbChanged() Handles Me.InternationalRdbChanged
        If rdbInternational.Checked = True Then
            chkTollPrefix.Checked = False
            chkTollPrefix.Enabled = False
            Me.AppState.CurrentDestination = E_Destination.International
        Else
            chkTollPrefix.Enabled = True
        End If
    End Sub

    Private Sub EH_DomesticRdbChanged() Handles Me.DomesticRdbChanged
        If rdbDomestic.Checked = True Then Me.AppState.CurrentDestination = E_Destination.Domestic
    End Sub

    Private Sub EH_TollPrefixChkChanged() Handles Me.TollPrefixChkChanged
        Me.AppState.AddTollPrefix = chkTollPrefix.Checked
    End Sub

    'Private Procedures
    Private Sub InitMainForm()
        With Me.AppState
            If .Configuration.DefaultsToInternational Then
                rdbInternational.Checked = True
            Else
                rdbDomestic.Checked = True
            End If

            Select Case .PrintMedium
                Case E_PrintMedium.Paper
                    chkPaper.Checked = True
                    nudPaperCopies.Enabled = True
                Case E_PrintMedium.Sticker
                    chkSticker.Checked = True
                    nudStickerCopies.Enabled = True
                Case E_PrintMedium.Both
                    chkBothPrinters.Checked = True
                    nudPaperCopies.Enabled = True
                    nudStickerCopies.Enabled = True
                Case E_PrintMedium.None
                    chkBothPrinters.Checked = False
                    chkPaper.Checked = False
                    chkSticker.Checked = False
                    nudPaperCopies.Enabled = False
                    nudStickerCopies.Enabled = False
                Case Else
                    chkBothPrinters.Checked = False
                    chkPaper.Checked = False
                    chkSticker.Checked = False
                    nudPaperCopies.Enabled = False
                    nudStickerCopies.Enabled = False
            End Select

            chkTollPrefix.Checked = .Configuration.TollPrefixDefault
            lblStickerPrinter.Text = .Configuration.CurrentStickerPrinter
            nudStickerCopies.Value = .Configuration.DefaultStickerCopies
            lblPaperPrinter.Text = .Configuration.CurrentPaperPrinter
            nudPaperCopies.Value = .Configuration.DefaultPaperCopies
            txtContents.Text = .Configuration.DefaultContents

            If .VolatileState.CurrentUser.Username = "Guest" Then
                lblCurrentUsername.Text = "You are currently logged in as a guest."
                txtIssuedBy.Text = ""
                txtIssuedBy.Enabled = True
            Else
                lblCurrentUsername.Text = .VolatileState.CurrentUser.Username
                txtIssuedBy.Text = .VolatileState.CurrentUser.FullName
            End If

            Icon = g_Icon
        End With
    End Sub

    Private Function CreateConNumString(ByVal parListItems As ListBox.ObjectCollection) As String
        Dim sb As New StringBuilder
        For Each item As String In parListItems
            sb.AppendLine(item)
        Next
        Return sb.ToString()
    End Function

    Public Sub RunPreExcelInit(parState As C_State)
        Me.userValidated = False
        If parState.VolatileState.CurrentUser.Username <> "Guest" Then
            ValidateUserForm = New F_Login(parState, True)
            ValidateUserForm.ShowDialog()
        Else
            Me.userValidated = True
        End If

        If Me.userValidated Then
            Me.ExcelData = New C_ExcelData(parState.Contents,
                                        parState.Configuration.KnownConsignorRef,
                                        parState.VolatileState.FirstConNumber,
                                        parState.VolatileState.ConNumbers,
                                        Date.Now(),
                                        parState.PaperCopies,
                                        parState.StickerCopies,
                                        parState.PrintMedium,
                                        parState.CurrentDestination,
                                        parState.Configuration.SaveDirectoryRoot,
                                        parState.Configuration.CurrentPaperPrinter,
                                        parState.Configuration.CurrentStickerPrinter,
                                        parState.VolatileState.CurrentUser.FullName,
                                        parState.VolatileState.CurrentUser.SigPath)

            PassToExcel(Me.ExcelData)

            If parState.VolatileState.CurrentUser.Username = "Guest" Then
                txtIssuedBy.Clear()
                parState.VolatileState.CurrentUser.FullName = ""
            End If

            lstConsignments.Items.Clear()
            txtConsignment.Clear()
            txtConsignment.Select()

        End If

    End Sub

End Class
