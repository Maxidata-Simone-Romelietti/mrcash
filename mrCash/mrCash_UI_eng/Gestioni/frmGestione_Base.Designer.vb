<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestione_Base
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
        Me.cmdElimina = New System.Windows.Forms.Button()
        Me.cmdAnnulla = New System.Windows.Forms.Button()
        Me.cmdConferma = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdElimina
        '
        Me.cmdElimina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdElimina.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdElimina.Location = New System.Drawing.Point(12, 443)
        Me.cmdElimina.Name = "cmdElimina"
        Me.cmdElimina.Size = New System.Drawing.Size(92, 35)
        Me.cmdElimina.TabIndex = 9
        Me.cmdElimina.Text = "Delete"
        Me.cmdElimina.UseVisualStyleBackColor = True
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAnnulla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAnnulla.Location = New System.Drawing.Point(598, 443)
        Me.cmdAnnulla.Name = "cmdAnnulla"
        Me.cmdAnnulla.Size = New System.Drawing.Size(92, 35)
        Me.cmdAnnulla.TabIndex = 8
        Me.cmdAnnulla.Text = "Cancel"
        Me.cmdAnnulla.UseVisualStyleBackColor = True
        '
        'cmdConferma
        '
        Me.cmdConferma.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConferma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConferma.Location = New System.Drawing.Point(500, 443)
        Me.cmdConferma.Name = "cmdConferma"
        Me.cmdConferma.Size = New System.Drawing.Size(92, 35)
        Me.cmdConferma.TabIndex = 7
        Me.cmdConferma.Text = "Save"
        Me.cmdConferma.UseVisualStyleBackColor = True
        '
        'frmGestione_Base
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 490)
        Me.Controls.Add(Me.cmdElimina)
        Me.Controls.Add(Me.cmdAnnulla)
        Me.Controls.Add(Me.cmdConferma)
        Me.Name = "frmGestione_Base"
        Me.Text = "frmGestione_Base"
        Me.ResumeLayout(False)

    End Sub
    Protected Friend WithEvents cmdElimina As System.Windows.Forms.Button
    Protected Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
    Protected Friend WithEvents cmdConferma As System.Windows.Forms.Button
End Class
