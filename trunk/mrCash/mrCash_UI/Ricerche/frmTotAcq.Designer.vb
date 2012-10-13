<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTotAcq
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
        Me.TotaliDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.TotaliDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TotaliDataGridView
        '
        Me.TotaliDataGridView.AllowUserToAddRows = False
        Me.TotaliDataGridView.AllowUserToDeleteRows = False
        Me.TotaliDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TotaliDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotaliDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TotaliDataGridView.Name = "TotaliDataGridView"
        Me.TotaliDataGridView.ReadOnly = True
        Me.TotaliDataGridView.RowHeadersVisible = False
        Me.TotaliDataGridView.Size = New System.Drawing.Size(286, 377)
        Me.TotaliDataGridView.TabIndex = 23
        '
        'frmTotAcq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 377)
        Me.Controls.Add(Me.TotaliDataGridView)
        Me.Name = "frmTotAcq"
        Me.Text = "Totale acquisti giornalieri"
        CType(Me.TotaliDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TotaliDataGridView As System.Windows.Forms.DataGridView
End Class
