Imports System.Drawing.Text

Public Class F_UserDetails

    Private ReadOnly pfc As New PrivateFontCollection
    Private ReadOnly TempState As C_State

    Private weidFont As Font
    Private TempUser As C_User

    Public Event UserAdded()
    Public Event UserEdited()
    Private Event ProceedBtnClicked()

    Public Sub New(ByRef parState As C_State, Optional parUser As C_User = Nothing)
        InitializeComponent()
        Me.TempState = parState
        Me.TempUser = parUser
        If Not Me.TempUser Is Nothing Then InitFormForEdit()
    End Sub

    Private Sub UserDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        Icon = g_Icon
        Me.pfc.AddFontFile(My.Resources.WeidFontFile)
        Me.weidFont = New Font(Me.pfc.Families(0), 14)
        ApplyControlsCustomFonts(Me, Me.weidFont)
        CenterControlHorizontally(Me, btnProceed)
        CenterControlHorizontally(Me, picSignature)
    End Sub

    Private Sub F_UserDetails_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Me.pfc.Dispose()
    End Sub

    Private Sub ProceedBtn_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        RaiseEvent ProceedBtnClicked()
    End Sub

    Private Sub SignaturePathBtn_Click(sender As Object, e As EventArgs) Handles btnSignaturePath.Click
        Dim sigPath As String = GetSigPathFromUser()
        lblSIFPValue.Text = sigPath
        picSignature.ImageLocation = sigPath
        If sigPath <> "" Then picSignature.Load()
    End Sub

    Private Sub SignaturePathBtn_MouseEnter(sender As Object, e As EventArgs) Handles btnSignaturePath.MouseEnter
        btnSignaturePath.ForeColor = g_WeidOrange
        btnSignaturePath.BackColor = Color.White
    End Sub

    Private Sub SignaturePathBtn_MouseLeave(sender As Object, e As EventArgs) Handles btnSignaturePath.MouseLeave
        btnSignaturePath.ForeColor = Color.Black
        btnSignaturePath.BackColor = Color.White
    End Sub
    Private Sub SignaturePathBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSignaturePath.MouseDown
        If e.Button = MouseButtons.Left Then
            btnSignaturePath.ForeColor = Color.White
            btnSignaturePath.BackColor = g_WeidOrange
        End If
    End Sub
    Private Sub SignaturePathBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles btnSignaturePath.MouseUp
        btnSignaturePath.ForeColor = g_WeidOrange
        btnSignaturePath.BackColor = Color.White
    End Sub

    Private Sub ProceedBtn_MouseEnter(sender As Object, e As EventArgs) Handles btnProceed.MouseEnter
        btnProceed.ForeColor = g_WeidOrange
        btnProceed.BackColor = Color.White
    End Sub

    Private Sub ProceedBtn_MouseLeave(sender As Object, e As EventArgs) Handles btnProceed.MouseLeave
        btnProceed.ForeColor = Color.Black
        btnProceed.BackColor = Color.White
    End Sub
    Private Sub ProceedBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles btnProceed.MouseDown
        If e.Button = MouseButtons.Left Then
            btnProceed.ForeColor = Color.White
            btnProceed.BackColor = g_WeidOrange
        End If
    End Sub
    Private Sub ProceedBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles btnProceed.MouseUp
        btnProceed.ForeColor = g_WeidOrange
        btnProceed.BackColor = Color.White
    End Sub

    'Custom event handlers
    Private Sub EH_ProceedBtnClicked() Handles Me.ProceedBtnClicked
        If UserInfoValid() Then
            If Me.TempUser Is Nothing Then
                If UsernameAvailable(txtUsername.Text) Then
                    Me.TempUser = CreateNewUser()
                    Me.TempState.Users.Add(Me.TempUser)
                    Me.TempUser = Nothing
                    RaiseEvent UserAdded()
                Else
                    MsgBox("Username " & txtUsername.Text & " not available. Please choose another.")
                    txtUsername.Clear()
                    txtUsername.Select()
                    Exit Sub
                End If
            Else
                Me.TempUser.FullName = txtFullName.Text
                Me.TempUser.Salt = GetSaltString()
                Me.TempUser.HashedPw = GetHashedPw(txtPassword.Text, Me.TempUser.Salt)
                Me.TempUser.SigPath = lblSIFPValue.Text
                RaiseEvent UserEdited()
            End If
            Close()
        End If
    End Sub

    'Private procedures
    Private Sub InitFormForEdit()
        Text = "Edit User"
        txtFullName.Text = Me.TempUser.FullName
        txtUsername.Text = Me.TempUser.Username
        txtUsername.Enabled = False
        lblSIFPValue.Text = Me.TempUser.SigPath
        picSignature.ImageLocation = lblSIFPValue.Text
        btnProceed.Text = "Save User Details"
    End Sub

    Private Function UserInfoValid() As Boolean
        If txtFullName.Text = "" Then
            MsgBox("Enter users full name.")
            txtFullName.Select()
            Return False
        End If

        If txtUsername.Text = "" Then
            MsgBox("Enter username.")
            txtUsername.Select()
            Return False
        End If

        If txtPassword.Text = "" Then
            MsgBox("Enter a password.")
            txtPassword.Select()
            Return False
        End If

        If txtRetypePw.Text = "" Then
            MsgBox("Retype your password.")
            txtRetypePw.Select()
            Return False
        End If

        If txtPassword.Text <> txtRetypePw.Text Then
            MsgBox("Passwords do not match.")
            txtPassword.Clear()
            txtRetypePw.Clear()
            txtPassword.Select()
            Return False
        End If

        Return True
    End Function

    Private Function CreateNewUser() As C_User
        Dim fn As String = txtFullName.Text
        Dim un As String = txtUsername.Text
        Dim pw As String = txtPassword.Text
        Dim salt As String = GetSaltString()
        Dim hp As String = GetHashedPw(pw, salt)
        Dim sp As String = lblSIFPValue.Text

        Dim u As New C_User(fn, un, salt, hp, sp)
        Return u
    End Function

    Private Function UsernameAvailable(parUsername As String) As Boolean
        Dim u As C_User
        For Each u In Me.TempState.Users
            If parUsername = u.Username Then Return False
        Next
        Return True
    End Function

    Private Function GetSigPathFromUser() As String
        Dim fileName As String = ""
        Dim ofd As New OpenFileDialog()
        With ofd
            .Title = "Please select a signature image file."
            .Filter = "jpg (*.jpg)|*.jpg"
            .FilterIndex = 1
            .RestoreDirectory = True
        End With
        If ofd.ShowDialog() = DialogResult.OK Then
            fileName = ofd.FileName
        End If
        Return fileName
    End Function

End Class