<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Main))
        Me.btnCreateConsignment = New System.Windows.Forms.Button()
        Me.btnAddConsignment = New System.Windows.Forms.Button()
        Me.tspMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbLogin = New System.Windows.Forms.ToolStripButton()
        Me.tsbConfiguration = New System.Windows.Forms.ToolStripButton()
        Me.tsbAbout = New System.Windows.Forms.ToolStripButton()
        Me.txtConsignment = New System.Windows.Forms.TextBox()
        Me.lblConsignmentNumber = New System.Windows.Forms.Label()
        Me.lstConsignments = New System.Windows.Forms.ListBox()
        Me.lblCurrentlyLoggedInUser = New System.Windows.Forms.Label()
        Me.lblCurrentUsername = New System.Windows.Forms.Label()
        Me.rdbDomestic = New System.Windows.Forms.RadioButton()
        Me.rdbInternational = New System.Windows.Forms.RadioButton()
        Me.chkTollPrefix = New System.Windows.Forms.CheckBox()
        Me.chkSticker = New System.Windows.Forms.CheckBox()
        Me.chkPaper = New System.Windows.Forms.CheckBox()
        Me.chkBothPrinters = New System.Windows.Forms.CheckBox()
        Me.lblPaperPrinter = New System.Windows.Forms.Label()
        Me.lblStickerPrinter = New System.Windows.Forms.Label()
        Me.btnRemoveConsignment = New System.Windows.Forms.Button()
        Me.lblStickerCopies = New System.Windows.Forms.Label()
        Me.lblPaperCopies = New System.Windows.Forms.Label()
        Me.lblContents = New System.Windows.Forms.Label()
        Me.txtContents = New System.Windows.Forms.TextBox()
        Me.btnDefaultContents = New System.Windows.Forms.Button()
        Me.grpPrintingOptions = New System.Windows.Forms.GroupBox()
        Me.nudStickerCopies = New System.Windows.Forms.NumericUpDown()
        Me.nudPaperCopies = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpConsignment = New System.Windows.Forms.GroupBox()
        Me.txtIssuedBy = New System.Windows.Forms.TextBox()
        Me.lblIssuedBy = New System.Windows.Forms.Label()
        Me.tspMenu.SuspendLayout()
        Me.grpPrintingOptions.SuspendLayout()
        CType(Me.nudStickerCopies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPaperCopies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConsignment.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCreateConsignment
        '
        Me.btnCreateConsignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateConsignment.Location = New System.Drawing.Point(23, 306)
        Me.btnCreateConsignment.Name = "btnCreateConsignment"
        Me.btnCreateConsignment.Size = New System.Drawing.Size(155, 30)
        Me.btnCreateConsignment.TabIndex = 4
        Me.btnCreateConsignment.Text = "Create Consignment"
        Me.btnCreateConsignment.UseVisualStyleBackColor = True
        '
        'btnAddConsignment
        '
        Me.btnAddConsignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddConsignment.Location = New System.Drawing.Point(103, 227)
        Me.btnAddConsignment.Name = "btnAddConsignment"
        Me.btnAddConsignment.Size = New System.Drawing.Size(75, 30)
        Me.btnAddConsignment.TabIndex = 2
        Me.btnAddConsignment.Text = "Add"
        Me.btnAddConsignment.UseVisualStyleBackColor = True
        '
        'tspMenu
        '
        Me.tspMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tspMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbLogin, Me.tsbConfiguration, Me.tsbAbout})
        Me.tspMenu.Location = New System.Drawing.Point(0, 0)
        Me.tspMenu.Name = "tspMenu"
        Me.tspMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tspMenu.Size = New System.Drawing.Size(790, 25)
        Me.tspMenu.TabIndex = 0
        Me.tspMenu.TabStop = True
        '
        'tsbLogin
        '
        Me.tsbLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbLogin.ForeColor = System.Drawing.SystemColors.Window
        Me.tsbLogin.Image = CType(resources.GetObject("tsbLogin.Image"), System.Drawing.Image)
        Me.tsbLogin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLogin.Name = "tsbLogin"
        Me.tsbLogin.Size = New System.Drawing.Size(41, 22)
        Me.tsbLogin.Text = "Login"
        Me.tsbLogin.ToolTipText = "Click To Login"
        '
        'tsbConfiguration
        '
        Me.tsbConfiguration.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbConfiguration.ForeColor = System.Drawing.SystemColors.Window
        Me.tsbConfiguration.Image = CType(resources.GetObject("tsbConfiguration.Image"), System.Drawing.Image)
        Me.tsbConfiguration.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConfiguration.Name = "tsbConfiguration"
        Me.tsbConfiguration.Size = New System.Drawing.Size(85, 22)
        Me.tsbConfiguration.Text = "Configuration"
        Me.tsbConfiguration.ToolTipText = "Click To Open Configuration"
        '
        'tsbAbout
        '
        Me.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbAbout.ForeColor = System.Drawing.SystemColors.Window
        Me.tsbAbout.Image = CType(resources.GetObject("tsbAbout.Image"), System.Drawing.Image)
        Me.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAbout.Name = "tsbAbout"
        Me.tsbAbout.Size = New System.Drawing.Size(44, 22)
        Me.tsbAbout.Text = "About"
        '
        'txtConsignment
        '
        Me.txtConsignment.Location = New System.Drawing.Point(184, 187)
        Me.txtConsignment.Name = "txtConsignment"
        Me.txtConsignment.Size = New System.Drawing.Size(190, 20)
        Me.txtConsignment.TabIndex = 0
        '
        'lblConsignmentNumber
        '
        Me.lblConsignmentNumber.AutoSize = True
        Me.lblConsignmentNumber.Location = New System.Drawing.Point(10, 190)
        Me.lblConsignmentNumber.Name = "lblConsignmentNumber"
        Me.lblConsignmentNumber.Size = New System.Drawing.Size(111, 13)
        Me.lblConsignmentNumber.TabIndex = 5
        Me.lblConsignmentNumber.Text = "Consignment Number:"
        '
        'lstConsignments
        '
        Me.lstConsignments.FormattingEnabled = True
        Me.lstConsignments.Location = New System.Drawing.Point(184, 228)
        Me.lstConsignments.Name = "lstConsignments"
        Me.lstConsignments.Size = New System.Drawing.Size(190, 121)
        Me.lstConsignments.TabIndex = 1
        '
        'lblCurrentlyLoggedInUser
        '
        Me.lblCurrentlyLoggedInUser.AutoSize = True
        Me.lblCurrentlyLoggedInUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCurrentlyLoggedInUser.ForeColor = System.Drawing.SystemColors.Window
        Me.lblCurrentlyLoggedInUser.Location = New System.Drawing.Point(240, 3)
        Me.lblCurrentlyLoggedInUser.Name = "lblCurrentlyLoggedInUser"
        Me.lblCurrentlyLoggedInUser.Size = New System.Drawing.Size(120, 13)
        Me.lblCurrentlyLoggedInUser.TabIndex = 7
        Me.lblCurrentlyLoggedInUser.Text = "Currently logged in user:"
        Me.lblCurrentlyLoggedInUser.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblCurrentUsername
        '
        Me.lblCurrentUsername.AutoSize = True
        Me.lblCurrentUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCurrentUsername.ForeColor = System.Drawing.SystemColors.Window
        Me.lblCurrentUsername.Location = New System.Drawing.Point(400, 3)
        Me.lblCurrentUsername.Name = "lblCurrentUsername"
        Me.lblCurrentUsername.Size = New System.Drawing.Size(143, 13)
        Me.lblCurrentUsername.TabIndex = 8
        Me.lblCurrentUsername.Text = "<no user currently logged in>"
        Me.lblCurrentUsername.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'rdbDomestic
        '
        Me.rdbDomestic.AutoSize = True
        Me.rdbDomestic.Location = New System.Drawing.Point(10, 68)
        Me.rdbDomestic.Name = "rdbDomestic"
        Me.rdbDomestic.Size = New System.Drawing.Size(69, 17)
        Me.rdbDomestic.TabIndex = 5
        Me.rdbDomestic.TabStop = True
        Me.rdbDomestic.Text = "Domestic"
        Me.rdbDomestic.UseVisualStyleBackColor = True
        '
        'rdbInternational
        '
        Me.rdbInternational.AutoSize = True
        Me.rdbInternational.Location = New System.Drawing.Point(101, 68)
        Me.rdbInternational.Name = "rdbInternational"
        Me.rdbInternational.Size = New System.Drawing.Size(83, 17)
        Me.rdbInternational.TabIndex = 5
        Me.rdbInternational.TabStop = True
        Me.rdbInternational.Text = "International"
        Me.rdbInternational.UseVisualStyleBackColor = True
        '
        'chkTollPrefix
        '
        Me.chkTollPrefix.AutoSize = True
        Me.chkTollPrefix.Location = New System.Drawing.Point(10, 150)
        Me.chkTollPrefix.Name = "chkTollPrefix"
        Me.chkTollPrefix.Size = New System.Drawing.Size(110, 17)
        Me.chkTollPrefix.TabIndex = 8
        Me.chkTollPrefix.Text = "Toll prefix (87750)"
        Me.chkTollPrefix.UseVisualStyleBackColor = True
        '
        'chkSticker
        '
        Me.chkSticker.AutoSize = True
        Me.chkSticker.Location = New System.Drawing.Point(9, 30)
        Me.chkSticker.Name = "chkSticker"
        Me.chkSticker.Size = New System.Drawing.Size(144, 17)
        Me.chkSticker.TabIndex = 7
        Me.chkSticker.Text = "Print sticker using printer:"
        Me.chkSticker.UseVisualStyleBackColor = True
        '
        'chkPaper
        '
        Me.chkPaper.AutoSize = True
        Me.chkPaper.Location = New System.Drawing.Point(10, 150)
        Me.chkPaper.Name = "chkPaper"
        Me.chkPaper.Size = New System.Drawing.Size(155, 17)
        Me.chkPaper.TabIndex = 9
        Me.chkPaper.Text = "Print A4 sheet using printer:"
        Me.chkPaper.UseVisualStyleBackColor = True
        '
        'chkBothPrinters
        '
        Me.chkBothPrinters.AutoSize = True
        Me.chkBothPrinters.Location = New System.Drawing.Point(10, 270)
        Me.chkBothPrinters.Name = "chkBothPrinters"
        Me.chkBothPrinters.Size = New System.Drawing.Size(120, 17)
        Me.chkBothPrinters.TabIndex = 11
        Me.chkBothPrinters.Text = "Print to both printers"
        Me.chkBothPrinters.UseVisualStyleBackColor = True
        '
        'lblPaperPrinter
        '
        Me.lblPaperPrinter.AutoSize = True
        Me.lblPaperPrinter.Location = New System.Drawing.Point(10, 190)
        Me.lblPaperPrinter.Name = "lblPaperPrinter"
        Me.lblPaperPrinter.Size = New System.Drawing.Size(140, 13)
        Me.lblPaperPrinter.TabIndex = 14
        Me.lblPaperPrinter.Text = "<set printer in configuration>"
        '
        'lblStickerPrinter
        '
        Me.lblStickerPrinter.AutoSize = True
        Me.lblStickerPrinter.Location = New System.Drawing.Point(10, 70)
        Me.lblStickerPrinter.Name = "lblStickerPrinter"
        Me.lblStickerPrinter.Size = New System.Drawing.Size(140, 13)
        Me.lblStickerPrinter.TabIndex = 15
        Me.lblStickerPrinter.Text = "<set printer in configuration>"
        '
        'btnRemoveConsignment
        '
        Me.btnRemoveConsignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveConsignment.Location = New System.Drawing.Point(103, 266)
        Me.btnRemoveConsignment.Name = "btnRemoveConsignment"
        Me.btnRemoveConsignment.Size = New System.Drawing.Size(75, 30)
        Me.btnRemoveConsignment.TabIndex = 3
        Me.btnRemoveConsignment.Text = "Remove"
        Me.btnRemoveConsignment.UseVisualStyleBackColor = True
        '
        'lblStickerCopies
        '
        Me.lblStickerCopies.AutoSize = True
        Me.lblStickerCopies.Location = New System.Drawing.Point(10, 110)
        Me.lblStickerCopies.Name = "lblStickerCopies"
        Me.lblStickerCopies.Size = New System.Drawing.Size(107, 13)
        Me.lblStickerCopies.TabIndex = 18
        Me.lblStickerCopies.Text = "No. of sticker copies:"
        '
        'lblPaperCopies
        '
        Me.lblPaperCopies.AutoSize = True
        Me.lblPaperCopies.Location = New System.Drawing.Point(10, 230)
        Me.lblPaperCopies.Name = "lblPaperCopies"
        Me.lblPaperCopies.Size = New System.Drawing.Size(103, 13)
        Me.lblPaperCopies.TabIndex = 20
        Me.lblPaperCopies.Text = "No. of paper copies:"
        '
        'lblContents
        '
        Me.lblContents.AutoSize = True
        Me.lblContents.Location = New System.Drawing.Point(10, 110)
        Me.lblContents.Name = "lblContents"
        Me.lblContents.Size = New System.Drawing.Size(116, 13)
        Me.lblContents.TabIndex = 23
        Me.lblContents.Text = "Consignment Contents:"
        '
        'txtContents
        '
        Me.txtContents.Location = New System.Drawing.Point(184, 107)
        Me.txtContents.Multiline = True
        Me.txtContents.Name = "txtContents"
        Me.txtContents.Size = New System.Drawing.Size(190, 68)
        Me.txtContents.TabIndex = 7
        '
        'btnDefaultContents
        '
        Me.btnDefaultContents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDefaultContents.Location = New System.Drawing.Point(221, 65)
        Me.btnDefaultContents.Name = "btnDefaultContents"
        Me.btnDefaultContents.Size = New System.Drawing.Size(153, 30)
        Me.btnDefaultContents.TabIndex = 6
        Me.btnDefaultContents.Text = "Default Contents"
        Me.btnDefaultContents.UseVisualStyleBackColor = True
        '
        'grpPrintingOptions
        '
        Me.grpPrintingOptions.Controls.Add(Me.nudStickerCopies)
        Me.grpPrintingOptions.Controls.Add(Me.nudPaperCopies)
        Me.grpPrintingOptions.Controls.Add(Me.chkSticker)
        Me.grpPrintingOptions.Controls.Add(Me.lblPaperCopies)
        Me.grpPrintingOptions.Controls.Add(Me.chkPaper)
        Me.grpPrintingOptions.Controls.Add(Me.chkBothPrinters)
        Me.grpPrintingOptions.Controls.Add(Me.lblStickerCopies)
        Me.grpPrintingOptions.Controls.Add(Me.lblPaperPrinter)
        Me.grpPrintingOptions.Controls.Add(Me.lblStickerPrinter)
        Me.grpPrintingOptions.Location = New System.Drawing.Point(402, 35)
        Me.grpPrintingOptions.Name = "grpPrintingOptions"
        Me.grpPrintingOptions.Size = New System.Drawing.Size(376, 313)
        Me.grpPrintingOptions.TabIndex = 2
        Me.grpPrintingOptions.TabStop = False
        Me.grpPrintingOptions.Text = "Options"
        '
        'nudStickerCopies
        '
        Me.nudStickerCopies.Location = New System.Drawing.Point(159, 108)
        Me.nudStickerCopies.Name = "nudStickerCopies"
        Me.nudStickerCopies.Size = New System.Drawing.Size(55, 20)
        Me.nudStickerCopies.TabIndex = 25
        '
        'nudPaperCopies
        '
        Me.nudPaperCopies.Location = New System.Drawing.Point(159, 228)
        Me.nudPaperCopies.Name = "nudPaperCopies"
        Me.nudPaperCopies.Size = New System.Drawing.Size(55, 20)
        Me.nudPaperCopies.TabIndex = 26
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.Security_Declaration_Form_Generator.My.Resources.Resources.WeidmullerLogo_Full
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(615, 362)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'grpConsignment
        '
        Me.grpConsignment.Controls.Add(Me.txtIssuedBy)
        Me.grpConsignment.Controls.Add(Me.lblContents)
        Me.grpConsignment.Controls.Add(Me.btnCreateConsignment)
        Me.grpConsignment.Controls.Add(Me.lblIssuedBy)
        Me.grpConsignment.Controls.Add(Me.btnDefaultContents)
        Me.grpConsignment.Controls.Add(Me.chkTollPrefix)
        Me.grpConsignment.Controls.Add(Me.rdbInternational)
        Me.grpConsignment.Controls.Add(Me.rdbDomestic)
        Me.grpConsignment.Controls.Add(Me.lstConsignments)
        Me.grpConsignment.Controls.Add(Me.txtContents)
        Me.grpConsignment.Controls.Add(Me.btnAddConsignment)
        Me.grpConsignment.Controls.Add(Me.btnRemoveConsignment)
        Me.grpConsignment.Controls.Add(Me.lblConsignmentNumber)
        Me.grpConsignment.Controls.Add(Me.txtConsignment)
        Me.grpConsignment.Location = New System.Drawing.Point(12, 35)
        Me.grpConsignment.Name = "grpConsignment"
        Me.grpConsignment.Size = New System.Drawing.Size(380, 350)
        Me.grpConsignment.TabIndex = 1
        Me.grpConsignment.TabStop = False
        Me.grpConsignment.Text = "Consignment"
        '
        'txtIssuedBy
        '
        Me.txtIssuedBy.Location = New System.Drawing.Point(88, 27)
        Me.txtIssuedBy.Name = "txtIssuedBy"
        Me.txtIssuedBy.Size = New System.Drawing.Size(286, 20)
        Me.txtIssuedBy.TabIndex = 9
        '
        'lblIssuedBy
        '
        Me.lblIssuedBy.AutoSize = True
        Me.lblIssuedBy.Location = New System.Drawing.Point(10, 30)
        Me.lblIssuedBy.Name = "lblIssuedBy"
        Me.lblIssuedBy.Size = New System.Drawing.Size(56, 13)
        Me.lblIssuedBy.TabIndex = 21
        Me.lblIssuedBy.Text = "Issued By:"
        '
        'F_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(790, 397)
        Me.Controls.Add(Me.lblCurrentUsername)
        Me.Controls.Add(Me.grpConsignment)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpPrintingOptions)
        Me.Controls.Add(Me.lblCurrentlyLoggedInUser)
        Me.Controls.Add(Me.tspMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "F_Main"
        Me.Text = "SDF Generator"
        Me.tspMenu.ResumeLayout(False)
        Me.tspMenu.PerformLayout()
        Me.grpPrintingOptions.ResumeLayout(False)
        Me.grpPrintingOptions.PerformLayout()
        CType(Me.nudStickerCopies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPaperCopies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConsignment.ResumeLayout(False)
        Me.grpConsignment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreateConsignment As Button
    Friend WithEvents btnAddConsignment As Button
    Friend WithEvents tspMenu As ToolStrip
    Friend WithEvents txtConsignment As TextBox
    Friend WithEvents lblConsignmentNumber As Label
    Friend WithEvents lstConsignments As ListBox
    Friend WithEvents lblCurrentlyLoggedInUser As Label
    Friend WithEvents lblCurrentUsername As Label
    Friend WithEvents rdbDomestic As RadioButton
    Friend WithEvents rdbInternational As RadioButton
    Friend WithEvents tsbLogin As ToolStripButton
    Friend WithEvents tsbConfiguration As ToolStripButton
    Friend WithEvents chkTollPrefix As CheckBox
    Friend WithEvents chkSticker As CheckBox
    Friend WithEvents chkPaper As CheckBox
    Friend WithEvents chkBothPrinters As CheckBox
    Friend WithEvents lblPaperPrinter As Label
    Friend WithEvents lblStickerPrinter As Label
    Friend WithEvents btnRemoveConsignment As Button
    Friend WithEvents lblStickerCopies As Label
    Friend WithEvents lblPaperCopies As Label
    Friend WithEvents lblContents As Label
    Friend WithEvents txtContents As TextBox
    Friend WithEvents btnDefaultContents As Button
    Friend WithEvents grpPrintingOptions As GroupBox
    Friend WithEvents grpConsignment As GroupBox
    Friend WithEvents lblIssuedBy As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tsbAbout As ToolStripButton
    Friend WithEvents txtIssuedBy As TextBox
    Friend WithEvents nudStickerCopies As NumericUpDown
    Friend WithEvents nudPaperCopies As NumericUpDown
End Class
