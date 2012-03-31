<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPISTOLA
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
        Me.txtCodice = New System.Windows.Forms.TextBox
        Me.lblPath = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtCodice
        '
        Me.txtCodice.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodice.Location = New System.Drawing.Point(19, 93)
        Me.txtCodice.Name = "txtCodice"
        Me.txtCodice.Size = New System.Drawing.Size(388, 116)
        Me.txtCodice.TabIndex = 0
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPath.Location = New System.Drawing.Point(12, 43)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(131, 42)
        Me.lblPath.TabIndex = 1
        Me.lblPath.Text = "Label1"
        '
        'frmPISTOLA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 218)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.txtCodice)
        Me.Name = "frmPISTOLA"
        Me.Text = "Scansione codici"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodice As System.Windows.Forms.TextBox
    Friend WithEvents lblPath As System.Windows.Forms.Label

End Class
