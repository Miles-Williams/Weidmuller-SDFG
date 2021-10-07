<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_UserDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_UserDetails))
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblRetypePassword = New System.Windows.Forms.Label()
        Me.lblSIFPLabel = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtRetypePw = New System.Windows.Forms.TextBox()
        Me.btnSignaturePath = New System.Windows.Forms.Button()
        Me.lblSIFPValue = New System.Windows.Forms.Label()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.picSignature = New System.Windows.Forms.PictureBox()
        Me.grpSignature = New System.Windows.Forms.GroupBox()
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSignature.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(12, 9)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(54, 13)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "Full Name"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(12, 79)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(200, 9)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password"
        '
        'lblRetypePassword
        '
        Me.lblRetypePassword.AutoSize = True
        Me.lblRetypePassword.Location = New System.Drawing.Point(200, 79)
        Me.lblRetypePassword.Name = "lblRetypePassword"
        Me.lblRetypePassword.Size = New System.Drawing.Size(93, 13)
        Me.lblRetypePassword.TabIndex = 3
        Me.lblRetypePassword.Text = "Re-type Password"
        '
        'lblSIFPLabel
        '
        Me.lblSIFPLabel.AutoSize = True
        Me.lblSIFPLabel.Location = New System.Drawing.Point(6, 26)
        Me.lblSIFPLabel.Name = "lblSIFPLabel"
        Me.lblSIFPLabel.Size = New System.Drawing.Size(131, 13)
        Me.lblSIFPLabel.TabIndex = 4
        Me.lblSIFPLabel.Text = "Signature Image File Path:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(12, 33)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(168, 20)
        Me.txtFullName.TabIndex = 0
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(12, 103)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(168, 20)
        Me.txtUsername.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(200, 33)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(168, 20)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtRetypePw
        '
        Me.txtRetypePw.Location = New System.Drawing.Point(200, 103)
        Me.txtRetypePw.Name = "txtRetypePw"
        Me.txtRetypePw.Size = New System.Drawing.Size(168, 20)
        Me.txtRetypePw.TabIndex = 3
        Me.txtRetypePw.UseSystemPasswordChar = True
        '
        'btnSignaturePath
        '
        Me.btnSignaturePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignaturePath.Location = New System.Drawing.Point(188, 21)
        Me.btnSignaturePath.Name = "btnSignaturePath"
        Me.btnSignaturePath.Size = New System.Drawing.Size(162, 30)
        Me.btnSignaturePath.TabIndex = 0
        Me.btnSignaturePath.Text = "Select Signature File"
        Me.btnSignaturePath.UseVisualStyleBackColor = True
        '
        'lblSIFPValue
        '
        Me.lblSIFPValue.Location = New System.Drawing.Point(8, 58)
        Me.lblSIFPValue.Name = "lblSIFPValue"
        Me.lblSIFPValue.Size = New System.Drawing.Size(342, 46)
        Me.lblSIFPValue.TabIndex = 10
        '
        'btnProceed
        '
        Me.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProceed.Location = New System.Drawing.Point(102, 393)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(168, 30)
        Me.btnProceed.TabIndex = 5
        Me.btnProceed.Text = "Add New User"
        Me.btnProceed.UseVisualStyleBackColor = True
        '
        'picSignature
        '
        Me.picSignature.ErrorImage = Nothing
        Me.picSignature.Location = New System.Drawing.Point(28, 116)
        Me.picSignature.Name = "picSignature"
        Me.picSignature.Size = New System.Drawing.Size(300, 100)
        Me.picSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSignature.TabIndex = 12
        Me.picSignature.TabStop = False
        '
        'grpSignature
        '
        Me.grpSignature.Controls.Add(Me.lblSIFPLabel)
        Me.grpSignature.Controls.Add(Me.picSignature)
        Me.grpSignature.Controls.Add(Me.btnSignaturePath)
        Me.grpSignature.Controls.Add(Me.lblSIFPValue)
        Me.grpSignature.Location = New System.Drawing.Point(12, 149)
        Me.grpSignature.Name = "grpSignature"
        Me.grpSignature.Size = New System.Drawing.Size(356, 238)
        Me.grpSignature.TabIndex = 4
        Me.grpSignature.TabStop = False
        Me.grpSignature.Text = "Signature"
        '
        'F_UserDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 434)
        Me.Controls.Add(Me.grpSignature)
        Me.Controls.Add(Me.txtRetypePw)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.lblRetypePassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblFullName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_UserDetails"
        Me.Text = "Add User"
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSignature.ResumeLayout(False)
        Me.grpSignature.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFullName As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblRetypePassword As Label
    Friend WithEvents lblSIFPLabel As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtRetypePw As TextBox
    Friend WithEvents btnSignaturePath As Button
    Friend WithEvents lblSIFPValue As Label
    Friend WithEvents btnProceed As Button
    Friend WithEvents picSignature As PictureBox
    Friend WithEvents grpSignature As GroupBox
End Class
