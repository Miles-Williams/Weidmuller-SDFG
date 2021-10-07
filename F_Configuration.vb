Imports System.Drawing.Printing
Imports System.Drawing.Text

Public Class F_Configuration

    Private ReadOnly pfc As New PrivateFontCollection

    Private weidFont As Font
    Private TempState As C_State

    Private WithEvents NewUserForm As F_UserDetails
    Private WithEvents EditUserForm As F_UserDetails

    Public Event ConfigStateChanged()
    Private Event UsersLstSelectionChanged()
    Private Event EditUserBtnClicked()
    Private Event DeleteUserBtnClicked()
    Private Event TollPrefixDefaultChkChanged()
    Private Event InternationalRbdChanged()

    Public Sub New(ByRef parState As C_State)
        InitializeComponent()
        Me.TempState = parState
    End Sub

    Private Sub Configuration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = g_Icon
        Me.pfc.AddFontFile(My.Resources.WeidFontFile)
        Me.weidFont = New Font(Me.pfc.Families(0), 14)
        ApplyControlsCustomFonts(Me, Me.weidFont)
        UpdateConfigForm()
        CenterForm(Me)
    End Sub

    Private Sub F_Configuration_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Me.pfc.Dispose()
    End Sub

    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        UpdateConfigState()
        RaiseEvent ConfigStateChanged()
        Close()
    End Sub

    Private Sub ApplyBtn_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        UpdateConfigState()
        RaiseEvent ConfigStateChanged()
    End Sub

    Private Sub AddUserBtn_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        NewUserForm = New F_UserDetails(Me.TempState)
        NewUserForm.ShowDialog(Me)
    End Sub

    Private Sub UsersLst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsers.SelectedIndexChanged
        RaiseEvent UsersLstSelectionChanged()
    End Sub

    Private Sub SaveDirectoryRoot_Click(sender As Object, e As EventArgs) Handles btnSaveDirectoryRoot.Click
        lblCurrentSaveDirectoryRoot.Text = GetUserSelectedFolder()
    End Sub

    Private Sub EditUserBtn_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click
        RaiseEvent EditUserBtnClicked()
    End Sub

    Private Sub DeleteUserBtn_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        RaiseEvent DeleteUserBtnClicked()
    End Sub

    Private Sub TollPrefixDefaultChk_CheckedChanged(sender As Object, e As EventArgs) Handles chkTollPrefixDefault.CheckedChanged
        RaiseEvent TollPrefixDefaultChkChanged()
    End Sub

    Private Sub InternationalRdb_CheckedChanged(sender As Object, e As EventArgs) Handles rdbInternational.CheckedChanged
        RaiseEvent InternationalRbdChanged()
    End Sub

    Private Sub SaveDirectoryRootBtn_MouseEnter(sender As Object, e As EventArgs) Handles btnSaveDirectoryRoot.MouseEnter
        btnSaveDirectoryRoot.ForeColor = g_WeidOrange
        btnSaveDirectoryRoot.BackColor = Color.White
    End Sub

    Private Sub SaveDirectoryRootBtn_MouseLeave(sender As Object, e As EventArgs) Handles btnSaveDirectoryRoot.MouseLeave
        btnSaveDirectoryRoot.ForeColor = Color.Black
        btnSaveDirectoryRoot.BackColor = Color.White
    End Sub

    Private Sub SaveDirectoryRootBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSaveDirectoryRoot.MouseDown
        If e.Button = MouseButtons.Left Then
            btnSaveDirectoryRoot.ForeColor = Color.White
            btnSaveDirectoryRoot.BackColor = g_WeidOrange
        End If
    End Sub

    Private Sub SaveDirectoryRootBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles btnSaveDirectoryRoot.MouseUp
        btnSaveDirectoryRoot.ForeColor = Color.Black
        btnSaveDirectoryRoot.BackColor = Color.White
    End Sub

    Private Sub AddUserBtn_MouseEnter(sender As Object, e As EventArgs) Handles btnAddUser.MouseEnter
        btnAddUser.ForeColor = g_WeidOrange
        btnAddUser.BackColor = Color.White
    End Sub

    Private Sub AddUserBtn_MouseLeave(sender As Object, e As EventArgs) Handles btnAddUser.MouseLeave
        btnAddUser.ForeColor = Color.Black
        btnAddUser.BackColor = Color.White
    End Sub

    Private Sub AddUserBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles btnAddUser.MouseDown
        If e.Button = MouseButtons.Left Then
            btnAddUser.ForeColor = Color.White
            btnAddUser.BackColor = g_WeidOrange
        End If
    End Sub

    Private Sub AddUserBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles btnAddUser.MouseUp
        btnAddUser.ForeColor = Color.Black
        btnAddUser.BackColor = Color.White
    End Sub

    Private Sub DeleteUserBtn_MouseEnter(sender As Object, e As EventArgs) Handles btnDeleteUser.MouseEnter
        btnDeleteUser.ForeColor = g_WeidOrange
        btnDeleteUser.BackColor = Color.White
    End Sub

    Private Sub DeleteUserBtn_MouseLeave(sender As Object, e As EventArgs) Handles btnDeleteUser.MouseLeave
        btnDeleteUser.ForeColor = Color.Black
        btnDeleteUser.BackColor = Color.White
    End Sub

    Private Sub DeleteUserBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles btnDeleteUser.MouseDown
        If e.Button = MouseButtons.Left Then
            btnDeleteUser.ForeColor = Color.White
            btnDeleteUser.BackColor = g_WeidOrange
        End If
    End Sub

    Private Sub DeleteUserBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles btnDeleteUser.MouseUp
        btnDeleteUser.ForeColor = Color.Black
        btnDeleteUser.BackColor = Color.White
    End Sub

    Private Sub EditUserBtn_MouseEnter(sender As Object, e As EventArgs) Handles btnEditUser.MouseEnter
        btnEditUser.ForeColor = g_WeidOrange
        btnEditUser.BackColor = Color.White
    End Sub

    Private Sub EditUserBtn_MouseLeave(sender As Object, e As EventArgs) Handles btnEditUser.MouseLeave
        btnEditUser.ForeColor = Color.Black
        btnEditUser.BackColor = Color.White
    End Sub

    Private Sub EditUserBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles btnEditUser.MouseDown
        If e.Button = MouseButtons.Left Then
            btnEditUser.ForeColor = Color.White
            btnEditUser.BackColor = g_WeidOrange
        End If
    End Sub

    Private Sub EditUserBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles btnEditUser.MouseUp
        btnEditUser.ForeColor = Color.Black
        btnEditUser.BackColor = Color.White
    End Sub

    Private Sub OkBtn_MouseEnter(sender As Object, e As EventArgs) Handles btnOk.MouseEnter
        btnOk.ForeColor = g_WeidOrange
        btnOk.BackColor = Color.White
    End Sub

    Private Sub OkBtn_MouseLeave(sender As Object, e As EventArgs) Handles btnOk.MouseLeave
        btnOk.ForeColor = Color.Black
        btnOk.BackColor = Color.White
    End Sub

    Private Sub OkBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles btnOk.MouseDown
        If e.Button = MouseButtons.Left Then
            btnOk.ForeColor = Color.White
            btnOk.BackColor = g_WeidOrange
        End If
    End Sub

    Private Sub OkBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles btnOk.MouseUp
        btnOk.ForeColor = Color.Black
        btnOk.BackColor = Color.White
    End Sub

    Private Sub ApplyBtn_MouseEnter(sender As Object, e As EventArgs) Handles btnApply.MouseEnter
        btnApply.ForeColor = g_WeidOrange
        btnApply.BackColor = Color.White
    End Sub

    Private Sub ApplyBtn_MouseLeave(sender As Object, e As EventArgs) Handles btnApply.MouseLeave
        btnApply.ForeColor = Color.Black
        btnApply.BackColor = Color.White
    End Sub

    Private Sub ApplyBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles btnApply.MouseDown
        If e.Button = MouseButtons.Left Then
            btnApply.ForeColor = Color.White
            btnApply.BackColor = g_WeidOrange
        End If
    End Sub

    Private Sub ApplyBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles btnApply.MouseUp
        btnApply.ForeColor = Color.Black
        btnApply.BackColor = Color.White
    End Sub

    Private Sub CancelBtn_MouseEnter(sender As Object, e As EventArgs) Handles btnCancel.MouseEnter
        btnCancel.ForeColor = g_WeidOrange
        btnCancel.BackColor = Color.White
    End Sub

    Private Sub CancelBtn_MouseLeave(sender As Object, e As EventArgs) Handles btnCancel.MouseLeave
        btnCancel.ForeColor = Color.Black
        btnCancel.BackColor = Color.White
    End Sub

    Private Sub CancelBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles btnCancel.MouseDown
        If e.Button = MouseButtons.Left Then
            btnCancel.ForeColor = Color.White
            btnCancel.BackColor = g_WeidOrange
        End If
    End Sub

    Private Sub CancelBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles btnCancel.MouseUp
        btnCancel.ForeColor = Color.Black
        btnCancel.BackColor = Color.White
    End Sub

    'Custom Event Handlers

    'From child form events
    Private Sub EH_UserAdded() Handles NewUserForm.UserAdded
        UpdateConfigForm()
    End Sub

    Private Sub EH_UserEdited() Handles EditUserForm.UserEdited
        UpdateConfigForm()
    End Sub

    'From internal events
    Private Sub EH_UsersLstSelectionChanged() Handles Me.UsersLstSelectionChanged
        If Not lstUsers.SelectedItem Is Nothing Then
            For Each u As C_User In Me.TempState.Users
                If u.FullName = lstUsers.SelectedItem.ToString() Then
                    picSignature.ImageLocation = u.SigPath
                    If u.SigPath <> "" Then picSignature.Load()
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub EH_EditUserBtnClicked() Handles Me.EditUserBtnClicked
        For Each u As C_User In Me.TempState.Users
            If u.FullName = lstUsers.SelectedItem.ToString() Then
                EditUserForm = New F_UserDetails(Me.TempState, u)
                EditUserForm.ShowDialog(Me)
                Exit For
            End If
        Next
    End Sub

    Private Sub EH_DeleteUserBtnClicked() Handles Me.DeleteUserBtnClicked
        For Each u As C_User In Me.TempState.Users
            If u.FullName = lstUsers.SelectedItem.ToString() Then
                lstUsers.Items.Remove(lstUsers.SelectedItem)
                Me.TempState.Users.Remove(u)
                picSignature.ImageLocation = ""
                Exit Sub
            End If
        Next
    End Sub

    Private Sub EH_TollPrefixDefaultChkChanged() Handles Me.TollPrefixDefaultChkChanged
        If chkTollPrefixDefault.Checked = True Then
            rdbInternational.Checked = False
            rdbDomestic.Checked = True
        End If
    End Sub

    Private Sub EH_InternationalRdbChanged() Handles Me.InternationalRbdChanged
        If rdbInternational.Checked = True Then chkTollPrefixDefault.Checked = False
    End Sub

    'Private Procedures

    Private Sub UpdateConfigForm()
        Dim sPrinter As String

        With Me.TempState
            cboPaperPrinter.Items.Clear()
            cboStickerPrinter.Items.Clear()

            For Each sPrinter In PrinterSettings.InstalledPrinters
                cboStickerPrinter.Items.Add(sPrinter)
                cboPaperPrinter.Items.Add(sPrinter)
            Next sPrinter

            cboStickerPrinter.Text = .Configuration.CurrentStickerPrinter
            cboPaperPrinter.Text = .Configuration.CurrentPaperPrinter
            lblCurrentSaveDirectoryRoot.Text = .Configuration.SaveDirectoryRoot
            chkTollPrefixDefault.Checked = .Configuration.TollPrefixDefault
            rdbDomestic.Checked = .Configuration.DefaultsToDomestic
            rdbInternational.Checked = .Configuration.DefaultsToInternational
            nudPaperCopies.Value = .Configuration.DefaultPaperCopies
            nudStickerCopies.Value = .Configuration.DefaultStickerCopies
            txtDefaultContents.Text = .Configuration.DefaultContents
            txtKnownConsignor.Text = .Configuration.KnownConsignorRef

            lstUsers.Items.Clear()

            For Each user As C_User In .Users
                lstUsers.Items.Add(user.FullName)
            Next

            picSignature.ImageLocation = ""
        End With
    End Sub

    Private Sub UpdateConfigState()
        With Me.TempState
            .Configuration.CurrentStickerPrinter = cboStickerPrinter.Text
            .Configuration.DefaultStickerCopies = CInt(nudStickerCopies.Value)
            .Configuration.CurrentPaperPrinter = cboPaperPrinter.Text
            .Configuration.DefaultPaperCopies = CInt(nudPaperCopies.Value)
            .Configuration.SaveDirectoryRoot = lblCurrentSaveDirectoryRoot.Text
            .Configuration.TollPrefixDefault = chkTollPrefixDefault.Checked
            .Configuration.DefaultsToDomestic = rdbDomestic.Checked
            .Configuration.DefaultsToInternational = rdbInternational.Checked
            .Configuration.DefaultContents = txtDefaultContents.Text
            .Configuration.KnownConsignorRef = txtKnownConsignor.Text
        End With
    End Sub

    Private Function GetUserSelectedFolder() As String
        Dim path As String = ""
        Dim fbd As New FolderBrowserDialog()

        If fbd.ShowDialog() = DialogResult.OK Then
            path = fbd.SelectedPath
        End If

        Return path
    End Function

End Class