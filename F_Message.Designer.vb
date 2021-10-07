<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Message
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
        Me.lblValidating = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblValidating
        '
        Me.lblValidating.AutoSize = True
        Me.lblValidating.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidating.Location = New System.Drawing.Point(80, 9)
        Me.lblValidating.Name = "lblValidating"
        Me.lblValidating.Size = New System.Drawing.Size(37, 55)
        Me.lblValidating.TabIndex = 0
        Me.lblValidating.Text = "."
        Me.lblValidating.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'F_Message
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(194, 100)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblValidating)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Message"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Validating User..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblValidating As Label
End Class
