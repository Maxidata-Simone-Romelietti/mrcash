<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRicercaVendite
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
        Me.components = New System.ComponentModel.Container
        Dim Label1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Fornitori = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VenditeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VenditeDataGridView = New System.Windows.Forms.DataGridView
        Me.VenditeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OggettoTextBox1 = New System.Windows.Forms.TextBox
        Me.IDVenditaColonna = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Totale = New System.Windows.Forms.DataGridViewTextBoxColumn
        Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.VenditeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VenditeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VenditeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.OggettoTextBox1)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.SetChildIndex(Label1, 0)
        Me.Panel1.Controls.SetChildIndex(Me.OggettoTextBox1, 0)
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(397, 12)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(48, 13)
        Label1.TabIndex = 28
        Label1.Text = "Oggetto:"
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
        'VenditeBindingSource
        '
        Me.VenditeBindingSource.DataSource = GetType(mrCash_DAL.Acquisti)
        '
        'VenditeDataGridView
        '
        Me.VenditeDataGridView.AllowUserToAddRows = False
        Me.VenditeDataGridView.AllowUserToDeleteRows = False
        Me.VenditeDataGridView.AutoGenerateColumns = False
        Me.VenditeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VenditeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDVenditaColonna, Me.DataDataGridViewTextBoxColumn, Me.Totale})
        Me.VenditeDataGridView.DataSource = Me.VenditeBindingSource1
        Me.VenditeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VenditeDataGridView.Location = New System.Drawing.Point(0, 42)
        Me.VenditeDataGridView.Name = "VenditeDataGridView"
        Me.VenditeDataGridView.ReadOnly = True
        Me.VenditeDataGridView.RowHeadersVisible = False
        Me.VenditeDataGridView.Size = New System.Drawing.Size(792, 524)
        Me.VenditeDataGridView.TabIndex = 22
        '
        'VenditeBindingSource1
        '
        Me.VenditeBindingSource1.DataSource = GetType(mrCash_DAL.Vendite)
        '
        'OggettoTextBox1
        '
        Me.OggettoTextBox1.Location = New System.Drawing.Point(451, 12)
        Me.OggettoTextBox1.Name = "OggettoTextBox1"
        Me.OggettoTextBox1.Size = New System.Drawing.Size(73, 20)
        Me.OggettoTextBox1.TabIndex = 29
        '
        'IDVenditaColonna
        '
        Me.IDVenditaColonna.DataPropertyName = "IDVendita"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft
        Me.IDVenditaColonna.DefaultCellStyle = DataGridViewCellStyle2
        Me.IDVenditaColonna.HeaderText = "IDVendita"
        Me.IDVenditaColonna.Name = "IDVenditaColonna"
        Me.IDVenditaColonna.ReadOnly = True
        Me.IDVenditaColonna.Visible = False
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "Data"
        DataGridViewCellStyle3.Format = "dd/MM/yyyy  HH:mm"
        Me.DataDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataDataGridViewTextBoxColumn.HeaderText = "Data"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        Me.DataDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Totale
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "0.00"
        Me.Totale.DefaultCellStyle = DataGridViewCellStyle4
        Me.Totale.HeaderText = "Totale"
        Me.Totale.Name = "Totale"
        Me.Totale.ReadOnly = True
        '
        'frmRicercaVendite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.VenditeDataGridView)
        Me.Name = "frmRicercaVendite"
        Me.Text = "Ricerca Vendite"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.VenditeDataGridView, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.VenditeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VenditeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VenditeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VenditeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fornitori As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenditeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FornitoriDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDAcquistoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OggettoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents VenditeBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents IDVenditaColonna As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Totale As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
