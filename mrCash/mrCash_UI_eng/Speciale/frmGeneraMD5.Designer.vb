<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneraMD5
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
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtMD5 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(12, 12)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(407, 20)
        Me.txtPassword.TabIndex = 0
        '
        'txtMD5
        '
        Me.txtMD5.Location = New System.Drawing.Point(12, 38)
        Me.txtMD5.Name = "txtMD5"
        Me.txtMD5.ReadOnly = True
        Me.txtMD5.Size = New System.Drawing.Size(407, 20)
        Me.txtMD5.TabIndex = 1
        '
        'frmGeneraMD5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 79)
        Me.Controls.Add(Me.txtMD5)
        Me.Controls.Add(Me.txtPassword)
        Me.Name = "frmGeneraMD5"
        Me.Text = "Generazione MD5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtMD5 As System.Windows.Forms.TextBox
End Class
