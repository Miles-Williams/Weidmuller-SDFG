<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_WinUserValidate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_WinUserValidate))
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(16, 15)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(184, 58)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Please provide your Windows password:"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(12, 78)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(185, 20)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblNote
        '
        Me.lblNote.Location = New System.Drawing.Point(12, 185)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(185, 66)
        Me.lblNote.TabIndex = 6
        Me.lblNote.Text = "This may take a few seconds if you are on a slow network."
        Me.lblNote.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnValidate
        '
        Me.btnValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValidate.Location = New System.Drawing.Point(12, 134)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(185, 30)
        Me.btnValidate.TabIndex = 7
        Me.btnValidate.Text = "Validate"
        Me.btnValidate.UseVisualStyleBackColor = True
        '
        'F_WinUserValidate
        '
        Me.AcceptButton = Me.btnValidate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(209, 261)
        Me.Controls.Add(Me.btnValidate)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_WinUserValidate"
        Me.Text = "Validate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblNote As Label
    Friend WithEvents btnValidate As Button
End Class
