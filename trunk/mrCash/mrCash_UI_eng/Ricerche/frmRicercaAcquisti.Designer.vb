<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRicercaAcquisti
    Inherits frmRicerca_Base

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
        Dim DataLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRicercaAcquisti))
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.Fornitori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcquistiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AcquistiDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Transazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fornitore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDAcquistoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CognomeTextBox1 = New System.Windows.Forms.TextBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.NomeTextBox1 = New System.Windows.Forms.TextBox()
        Me.OggettoTextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        DataLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.AcquistiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcquistiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.OggettoTextBox1)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(Me.NomeTextBox1)
        Me.Panel1.Controls.Add(DataLabel)
        Me.Panel1.Controls.Add(Me.CognomeTextBox1)
        Me.Panel1.Controls.SetChildIndex(Me.CognomeTextBox1, 0)
        Me.Panel1.Controls.SetChildIndex(DataLabel, 0)
        Me.Panel1.Controls.SetChildIndex(Me.NomeTextBox1, 0)
        Me.Panel1.Controls.SetChildIndex(Label1, 0)
        Me.Panel1.Controls.SetChildIndex(Me.OggettoTextBox1, 0)
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataLabel.Location = New System.Drawing.Point(12, 10)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(48, 13)
        DataLabel.TabIndex = 24
        DataLabel.Text = "Supplier:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(381, 10)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(41, 13)
        Label1.TabIndex = 26
        Label1.Text = "Object:"
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning.ForeColor = System.Drawing.Color.Red
        Me.lblWarning.Location = New System.Drawing.Point(3, 3)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(27, 20)
        Me.lblWarning.TabIndex = 25
        Me.lblWarning.Text = "---"
        '
        'Fornitori
        '
        Me.Fornitori.DataPropertyName = "Fornitori"
        Me.Fornitori.HeaderText = "Fornitori"
        Me.Fornitori.Name = "Fornitori"
        Me.Fornitori.ReadOnly = True
        Me.Fornitori.Width = 300
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDAcquisto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDAcquisto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Data"
        DataGridViewCellStyle1.Format = "dd / MM / yyyy   hh:mm"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn2.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'AcquistiBindingSource
        '
        Me.AcquistiBindingSource.DataSource = GetType(mrCash_DAL.Acquisti)
        '
        'AcquistiDataGridView
        '
        Me.AcquistiDataGridView.AllowUserToAddRows = False
        Me.AcquistiDataGridView.AllowUserToDeleteRows = False
        Me.AcquistiDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcquistiDataGridView.AutoGenerateColumns = False
        Me.AcquistiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AcquistiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AcquistiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataDataGridViewTextBoxColumn, Me.Transazione, Me.Fornitore, Me.IDAcquistoDataGridViewTextBoxColumn})
        Me.AcquistiDataGridView.DataSource = Me.AcquistiBindingSource
        Me.AcquistiDataGridView.Location = New System.Drawing.Point(0, 42)
        Me.AcquistiDataGridView.Name = "AcquistiDataGridView"
        Me.AcquistiDataGridView.ReadOnly = True
        Me.AcquistiDataGridView.RowHeadersVisible = False
        Me.AcquistiDataGridView.Size = New System.Drawing.Size(792, 499)
        Me.AcquistiDataGridView.TabIndex = 22
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "Data"
        DataGridViewCellStyle2.Format = "dd/MM/yyyy       HH:mm"
        Me.DataDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataDataGridViewTextBoxColumn.FillWeight = 20.0!
        Me.DataDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        Me.DataDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Transazione
        '
        Me.Transazione.DataPropertyName = "Transazione"
        Me.Transazione.FillWeight = 10.0!
        Me.Transazione.HeaderText = "Transaction"
        Me.Transazione.Name = "Transazione"
        Me.Transazione.ReadOnly = True
        '
        'Fornitore
        '
        Me.Fornitore.DataPropertyName = "Fornitore_NomeCompleto"
        Me.Fornitore.FillWeight = 68.0!
        Me.Fornitore.HeaderText = "Supplier"
        Me.Fornitore.Name = "Fornitore"
        Me.Fornitore.ReadOnly = True
        '
        'IDAcquistoDataGridViewTextBoxColumn
        '
        Me.IDAcquistoDataGridViewTextBoxColumn.DataPropertyName = "IDAcquisto"
        Me.IDAcquistoDataGridViewTextBoxColumn.FillWeight = 2.0!
        Me.IDAcquistoDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDAcquistoDataGridViewTextBoxColumn.Name = "IDAcquistoDataGridViewTextBoxColumn"
        Me.IDAcquistoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CognomeTextBox1
        '
        Me.CognomeTextBox1.Location = New System.Drawing.Point(69, 10)
        Me.CognomeTextBox1.Name = "CognomeTextBox1"
        Me.CognomeTextBox1.Size = New System.Drawing.Size(143, 20)
        Me.CognomeTextBox1.TabIndex = 23
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'NomeTextBox1
        '
        Me.NomeTextBox1.Location = New System.Drawing.Point(218, 10)
        Me.NomeTextBox1.Name = "NomeTextBox1"
        Me.NomeTextBox1.Size = New System.Drawing.Size(131, 20)
        Me.NomeTextBox1.TabIndex = 25
        '
        'OggettoTextBox1
        '
        Me.OggettoTextBox1.Location = New System.Drawing.Point(435, 10)
        Me.OggettoTextBox1.Name = "OggettoTextBox1"
        Me.OggettoTextBox1.Size = New System.Drawing.Size(73, 20)
        Me.OggettoTextBox1.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.lblWarning)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 541)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(792, 25)
        Me.Panel2.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(629, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 24)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "DAILY TOTALS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmRicercaAcquisti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.AcquistiDataGridView)
        Me.Name = "frmRicercaAcquisti"
        Me.Text = "Purchase search"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.AcquistiDataGridView, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AcquistiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcquistiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AcquistiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fornitori As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AcquistiDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FornitoriDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CognomeTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents NomeTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents OggettoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Transazione As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fornitore As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDAcquistoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
