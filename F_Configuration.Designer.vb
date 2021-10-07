<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Configuration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Configuration))
        Me.grpPrinters = New System.Windows.Forms.GroupBox()
        Me.nudPaperCopies = New System.Windows.Forms.NumericUpDown()
        Me.nudStickerCopies = New System.Windows.Forms.NumericUpDown()
        Me.lblPaperCopies = New System.Windows.Forms.Label()
        Me.lblStickerCopies = New System.Windows.Forms.Label()
        Me.cboPaperPrinter = New System.Windows.Forms.ComboBox()
        Me.cboStickerPrinter = New System.Windows.Forms.ComboBox()
        Me.lblPaperPrinter = New System.Windows.Forms.Label()
        Me.lblStickerPrinter = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.picSignature = New System.Windows.Forms.PictureBox()
        Me.grpDefaultSettings = New System.Windows.Forms.GroupBox()
        Me.txtKnownConsignor = New System.Windows.Forms.TextBox()
        Me.lblKnownConsignor = New System.Windows.Forms.Label()
        Me.txtDefaultContents = New System.Windows.Forms.TextBox()
        Me.rdbInternational = New System.Windows.Forms.RadioButton()
        Me.btnSaveDirectoryRoot = New System.Windows.Forms.Button()
        Me.lblSaveDirectoryRoot = New System.Windows.Forms.Label()
        Me.lblDefaultContents = New System.Windows.Forms.Label()
        Me.rdbDomestic = New System.Windows.Forms.RadioButton()
        Me.lblCurrentSaveDirectoryRoot = New System.Windows.Forms.Label()
        Me.chkTollPrefixDefault = New System.Windows.Forms.CheckBox()
        Me.grpUsers = New System.Windows.Forms.GroupBox()
        Me.lstUsers = New System.Windows.Forms.ListBox()
        Me.btnEditUser = New System.Windows.Forms.Button()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.grpSignature = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpPrinters.SuspendLayout()
        CType(Me.nudPaperCopies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStickerCopies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDefaultSettings.SuspendLayout()
        Me.grpUsers.SuspendLayout()
        Me.grpSignature.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpPrinters
        '
        Me.grpPrinters.Controls.Add(Me.nudPaperCopies)
        Me.grpPrinters.Controls.Add(Me.nudStickerCopies)
        Me.grpPrinters.Controls.Add(Me.lblPaperCopies)
        Me.grpPrinters.Controls.Add(Me.lblStickerCopies)
        Me.grpPrinters.Controls.Add(Me.cboPaperPrinter)
        Me.grpPrinters.Controls.Add(Me.cboStickerPrinter)
        Me.grpPrinters.Controls.Add(Me.lblPaperPrinter)
        Me.grpPrinters.Controls.Add(Me.lblStickerPrinter)
        Me.grpPrinters.Location = New System.Drawing.Point(12, 12)
        Me.grpPrinters.Name = "grpPrinters"
        Me.grpPrinters.Size = New System.Drawing.Size(411, 176)
        Me.grpPrinters.TabIndex = 0
        Me.grpPrinters.TabStop = False
        Me.grpPrinters.Text = "Printers"
        '
        'nudPaperCopies
        '
        Me.nudPaperCopies.Location = New System.Drawing.Point(136, 133)
        Me.nudPaperCopies.Name = "nudPaperCopies"
        Me.nudPaperCopies.Size = New System.Drawing.Size(55, 20)
        Me.nudPaperCopies.TabIndex = 3
        '
        'nudStickerCopies
        '
        Me.nudStickerCopies.Location = New System.Drawing.Point(136, 65)
        Me.nudStickerCopies.Name = "nudStickerCopies"
        Me.nudStickerCopies.Size = New System.Drawing.Size(55, 20)
        Me.nudStickerCopies.TabIndex = 1
        '
        'lblPaperCopies
        '
        Me.lblPaperCopies.AutoSize = True
        Me.lblPaperCopies.Location = New System.Drawing.Point(6, 135)
        Me.lblPaperCopies.Name = "lblPaperCopies"
        Me.lblPaperCopies.Size = New System.Drawing.Size(73, 13)
        Me.lblPaperCopies.TabIndex = 7
        Me.lblPaperCopies.Text = "Paper Copies:"
        '
        'lblStickerCopies
        '
        Me.lblStickerCopies.AutoSize = True
        Me.lblStickerCopies.Location = New System.Drawing.Point(6, 67)
        Me.lblStickerCopies.Name = "lblStickerCopies"
        Me.lblStickerCopies.Size = New System.Drawing.Size(78, 13)
        Me.lblStickerCopies.TabIndex = 6
        Me.lblStickerCopies.Text = "Sticker Copies:"
        '
        'cboPaperPrinter
        '
        Me.cboPaperPrinter.FormattingEnabled = True
        Me.cboPaperPrinter.Location = New System.Drawing.Point(136, 98)
        Me.cboPaperPrinter.Name = "cboPaperPrinter"
        Me.cboPaperPrinter.Size = New System.Drawing.Size(269, 21)
        Me.cboPaperPrinter.TabIndex = 2
        '
        'cboStickerPrinter
        '
        Me.cboStickerPrinter.FormattingEnabled = True
        Me.cboStickerPrinter.Location = New System.Drawing.Point(136, 29)
        Me.cboStickerPrinter.Name = "cboStickerPrinter"
        Me.cboStickerPrinter.Size = New System.Drawing.Size(269, 21)
        Me.cboStickerPrinter.TabIndex = 0
        '
        'lblPaperPrinter
        '
        Me.lblPaperPrinter.AutoSize = True
        Me.lblPaperPrinter.Location = New System.Drawing.Point(6, 101)
        Me.lblPaperPrinter.Name = "lblPaperPrinter"
        Me.lblPaperPrinter.Size = New System.Drawing.Size(71, 13)
        Me.lblPaperPrinter.TabIndex = 3
        Me.lblPaperPrinter.Text = "Paper Printer:"
        '
        'lblStickerPrinter
        '
        Me.lblStickerPrinter.AutoSize = True
        Me.lblStickerPrinter.Location = New System.Drawing.Point(6, 32)
        Me.lblStickerPrinter.Name = "lblStickerPrinter"
        Me.lblStickerPrinter.Size = New System.Drawing.Size(76, 13)
        Me.lblStickerPrinter.TabIndex = 1
        Me.lblStickerPrinter.Text = "Sticker Printer:"
        '
        'btnOk
        '
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Location = New System.Drawing.Point(436, 357)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(106, 30)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(666, 357)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(106, 30)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.Location = New System.Drawing.Point(551, 357)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(106, 30)
        Me.btnApply.TabIndex = 4
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'picSignature
        '
        Me.picSignature.ErrorImage = Nothing
        Me.picSignature.Location = New System.Drawing.Point(18, 32)
        Me.picSignature.Name = "picSignature"
        Me.picSignature.Size = New System.Drawing.Size(300, 100)
        Me.picSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSignature.TabIndex = 4
        Me.picSignature.TabStop = False
        '
        'grpDefaultSettings
        '
        Me.grpDefaultSettings.Controls.Add(Me.txtKnownConsignor)
        Me.grpDefaultSettings.Controls.Add(Me.lblKnownConsignor)
        Me.grpDefaultSettings.Controls.Add(Me.txtDefaultContents)
        Me.grpDefaultSettings.Controls.Add(Me.rdbInternational)
        Me.grpDefaultSettings.Controls.Add(Me.btnSaveDirectoryRoot)
        Me.grpDefaultSettings.Controls.Add(Me.lblSaveDirectoryRoot)
        Me.grpDefaultSettings.Controls.Add(Me.lblDefaultContents)
        Me.grpDefaultSettings.Controls.Add(Me.rdbDomestic)
        Me.grpDefaultSettings.Controls.Add(Me.lblCurrentSaveDirectoryRoot)
        Me.grpDefaultSettings.Controls.Add(Me.chkTollPrefixDefault)
        Me.grpDefaultSettings.Location = New System.Drawing.Point(12, 194)
        Me.grpDefaultSettings.Name = "grpDefaultSettings"
        Me.grpDefaultSettings.Size = New System.Drawing.Size(411, 235)
        Me.grpDefaultSettings.TabIndex = 1
        Me.grpDefaultSettings.TabStop = False
        Me.grpDefaultSettings.Text = "Default Settings"
        '
        'txtKnownConsignor
        '
        Me.txtKnownConsignor.Location = New System.Drawing.Point(136, 192)
        Me.txtKnownConsignor.Name = "txtKnownConsignor"
        Me.txtKnownConsignor.Size = New System.Drawing.Size(269, 20)
        Me.txtKnownConsignor.TabIndex = 5
        '
        'lblKnownConsignor
        '
        Me.lblKnownConsignor.AutoSize = True
        Me.lblKnownConsignor.Location = New System.Drawing.Point(10, 195)
        Me.lblKnownConsignor.Name = "lblKnownConsignor"
        Me.lblKnownConsignor.Size = New System.Drawing.Size(93, 13)
        Me.lblKnownConsignor.TabIndex = 12
        Me.lblKnownConsignor.Text = "Known Consignor:"
        '
        'txtDefaultContents
        '
        Me.txtDefaultContents.Location = New System.Drawing.Point(136, 156)
        Me.txtDefaultContents.Name = "txtDefaultContents"
        Me.txtDefaultContents.Size = New System.Drawing.Size(269, 20)
        Me.txtDefaultContents.TabIndex = 4
        '
        'rdbInternational
        '
        Me.rdbInternational.AutoSize = True
        Me.rdbInternational.Location = New System.Drawing.Point(253, 115)
        Me.rdbInternational.Name = "rdbInternational"
        Me.rdbInternational.Size = New System.Drawing.Size(83, 17)
        Me.rdbInternational.TabIndex = 3
        Me.rdbInternational.TabStop = True
        Me.rdbInternational.Text = "International"
        Me.rdbInternational.UseVisualStyleBackColor = True
        '
        'btnSaveDirectoryRoot
        '
        Me.btnSaveDirectoryRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveDirectoryRoot.Location = New System.Drawing.Point(10, 80)
        Me.btnSaveDirectoryRoot.Name = "btnSaveDirectoryRoot"
        Me.btnSaveDirectoryRoot.Size = New System.Drawing.Size(103, 30)
        Me.btnSaveDirectoryRoot.TabIndex = 0
        Me.btnSaveDirectoryRoot.Text = "Change SDR"
        Me.btnSaveDirectoryRoot.UseVisualStyleBackColor = True
        '
        'lblSaveDirectoryRoot
        '
        Me.lblSaveDirectoryRoot.AutoSize = True
        Me.lblSaveDirectoryRoot.Location = New System.Drawing.Point(6, 26)
        Me.lblSaveDirectoryRoot.Name = "lblSaveDirectoryRoot"
        Me.lblSaveDirectoryRoot.Size = New System.Drawing.Size(106, 13)
        Me.lblSaveDirectoryRoot.TabIndex = 0
        Me.lblSaveDirectoryRoot.Text = "Save Directory Root:"
        '
        'lblDefaultContents
        '
        Me.lblDefaultContents.AutoSize = True
        Me.lblDefaultContents.Location = New System.Drawing.Point(10, 159)
        Me.lblDefaultContents.Name = "lblDefaultContents"
        Me.lblDefaultContents.Size = New System.Drawing.Size(89, 13)
        Me.lblDefaultContents.TabIndex = 10
        Me.lblDefaultContents.Text = "Default Contents:"
        '
        'rdbDomestic
        '
        Me.rdbDomestic.AutoSize = True
        Me.rdbDomestic.Location = New System.Drawing.Point(162, 115)
        Me.rdbDomestic.Name = "rdbDomestic"
        Me.rdbDomestic.Size = New System.Drawing.Size(69, 17)
        Me.rdbDomestic.TabIndex = 2
        Me.rdbDomestic.TabStop = True
        Me.rdbDomestic.Text = "Domestic"
        Me.rdbDomestic.UseVisualStyleBackColor = True
        '
        'lblCurrentSaveDirectoryRoot
        '
        Me.lblCurrentSaveDirectoryRoot.Location = New System.Drawing.Point(146, 25)
        Me.lblCurrentSaveDirectoryRoot.Name = "lblCurrentSaveDirectoryRoot"
        Me.lblCurrentSaveDirectoryRoot.Size = New System.Drawing.Size(208, 78)
        Me.lblCurrentSaveDirectoryRoot.TabIndex = 1
        Me.lblCurrentSaveDirectoryRoot.Text = "<select a directory to build the save file structure in>"
        '
        'chkTollPrefixDefault
        '
        Me.chkTollPrefixDefault.AutoSize = True
        Me.chkTollPrefixDefault.Location = New System.Drawing.Point(10, 116)
        Me.chkTollPrefixDefault.Name = "chkTollPrefixDefault"
        Me.chkTollPrefixDefault.Size = New System.Drawing.Size(94, 17)
        Me.chkTollPrefixDefault.TabIndex = 1
        Me.chkTollPrefixDefault.Text = "Use Toll Prefix"
        Me.chkTollPrefixDefault.UseVisualStyleBackColor = True
        '
        'grpUsers
        '
        Me.grpUsers.Controls.Add(Me.lstUsers)
        Me.grpUsers.Controls.Add(Me.btnEditUser)
        Me.grpUsers.Controls.Add(Me.btnDeleteUser)
        Me.grpUsers.Controls.Add(Me.btnAddUser)
        Me.grpUsers.Controls.Add(Me.grpSignature)
        Me.grpUsers.Location = New System.Drawing.Point(429, 12)
        Me.grpUsers.Name = "grpUsers"
        Me.grpUsers.Size = New System.Drawing.Size(349, 332)
        Me.grpUsers.TabIndex = 2
        Me.grpUsers.TabStop = False
        Me.grpUsers.Text = "Users"
        '
        'lstUsers
        '
        Me.lstUsers.FormattingEnabled = True
        Me.lstUsers.Location = New System.Drawing.Point(9, 30)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(203, 134)
        Me.lstUsers.TabIndex = 10
        '
        'btnEditUser
        '
        Me.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditUser.Location = New System.Drawing.Point(218, 130)
        Me.btnEditUser.Name = "btnEditUser"
        Me.btnEditUser.Size = New System.Drawing.Size(106, 30)
        Me.btnEditUser.TabIndex = 2
        Me.btnEditUser.Text = "Edit User"
        Me.btnEditUser.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteUser.Location = New System.Drawing.Point(218, 78)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(106, 30)
        Me.btnDeleteUser.TabIndex = 1
        Me.btnDeleteUser.Text = "Delete User"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'btnAddUser
        '
        Me.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUser.Location = New System.Drawing.Point(218, 30)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(106, 30)
        Me.btnAddUser.TabIndex = 0
        Me.btnAddUser.Text = "Add User"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'grpSignature
        '
        Me.grpSignature.Controls.Add(Me.picSignature)
        Me.grpSignature.Location = New System.Drawing.Point(6, 182)
        Me.grpSignature.Name = "grpSignature"
        Me.grpSignature.Size = New System.Drawing.Size(337, 144)
        Me.grpSignature.TabIndex = 4
        Me.grpSignature.TabStop = False
        Me.grpSignature.Text = "Signature"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.Security_Declaration_Form_Generator.My.Resources.Resources.WeidmullerLogo_Full
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(609, 402)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'F_Configuration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(790, 437)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpUsers)
        Me.Controls.Add(Me.grpDefaultSettings)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.grpPrinters)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Configuration"
        Me.Text = "Configuration"
        Me.grpPrinters.ResumeLayout(False)
        Me.grpPrinters.PerformLayout()
        CType(Me.nudPaperCopies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStickerCopies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDefaultSettings.ResumeLayout(False)
        Me.grpDefaultSettings.PerformLayout()
        Me.grpUsers.ResumeLayout(False)
        Me.grpSignature.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpPrinters As GroupBox
    Friend WithEvents lblStickerPrinter As Label
    Friend WithEvents cboStickerPrinter As ComboBox
    Friend WithEvents lblPaperPrinter As Label
    Friend WithEvents cboPaperPrinter As ComboBox
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnApply As Button
    Friend WithEvents picSignature As PictureBox
    Friend WithEvents grpDefaultSettings As GroupBox
    Friend WithEvents rdbInternational As RadioButton
    Friend WithEvents rdbDomestic As RadioButton
    Friend WithEvents chkTollPrefixDefault As CheckBox
    Friend WithEvents btnSaveDirectoryRoot As Button
    Friend WithEvents lblCurrentSaveDirectoryRoot As Label
    Friend WithEvents lblSaveDirectoryRoot As Label
    Friend WithEvents grpUsers As GroupBox
    Friend WithEvents grpSignature As GroupBox
    Friend WithEvents btnEditUser As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnAddUser As Button
    Friend WithEvents lblPaperCopies As Label
    Friend WithEvents lblStickerCopies As Label
    Friend WithEvents txtDefaultContents As TextBox
    Friend WithEvents lblDefaultContents As Label
    Friend WithEvents txtKnownConsignor As TextBox
    Friend WithEvents lblKnownConsignor As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents nudPaperCopies As NumericUpDown
    Friend WithEvents nudStickerCopies As NumericUpDown
    Friend WithEvents lstUsers As ListBox
End Class
