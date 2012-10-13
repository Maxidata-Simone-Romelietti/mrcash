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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TotaliDataGridView = New System.Windows.Forms.DataGridView()
        Me.V_AcquistiGiornalieriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotaleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TotaliDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_AcquistiGiornalieriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TotaliDataGridView
        '
        Me.TotaliDataGridView.AllowUserToAddRows = False
        Me.TotaliDataGridView.AllowUserToDeleteRows = False
        Me.TotaliDataGridView.AutoGenerateColumns = False
        Me.TotaliDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TotaliDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataDataGridViewTextBoxColumn, Me.TotaleDataGridViewTextBoxColumn})
        Me.TotaliDataGridView.DataSource = Me.V_AcquistiGiornalieriBindingSource
        Me.TotaliDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotaliDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TotaliDataGridView.Name = "TotaliDataGridView"
        Me.TotaliDataGridView.ReadOnly = True
        Me.TotaliDataGridView.RowHeadersVisible = False
        Me.TotaliDataGridView.Size = New System.Drawing.Size(286, 377)
        Me.TotaliDataGridView.TabIndex = 23
        '
        'V_AcquistiGiornalieriBindingSource
        '
        Me.V_AcquistiGiornalieriBindingSource.DataSource = GetType(mrCash_DAL.V_AcquistiGiornalieri)
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "Data"
        Me.DataDataGridViewTextBoxColumn.HeaderText = "Data"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        Me.DataDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotaleDataGridViewTextBoxColumn
        '
        Me.TotaleDataGridViewTextBoxColumn.DataPropertyName = "Totale"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "#.00"
        Me.TotaleDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.TotaleDataGridViewTextBoxColumn.HeaderText = "Totale"
        Me.TotaleDataGridViewTextBoxColumn.Name = "TotaleDataGridViewTextBoxColumn"
        Me.TotaleDataGridViewTextBoxColumn.ReadOnly = True
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
        CType(Me.V_AcquistiGiornalieriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TotaliDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents V_AcquistiGiornalieriBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotaleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
