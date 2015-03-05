<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRicercaOggetti
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.OggettiDataGridView = New System.Windows.Forms.DataGridView()
        Me.OggettiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescrizioneTextBox = New System.Windows.Forms.TextBox()
        Me.OggettoTextBox1 = New System.Windows.Forms.TextBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.txtSeriale = New System.Windows.Forms.TextBox()
        Me.txtModello = New System.Windows.Forms.TextBox()
        Me.Codice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrizioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modello = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrezzoAcquistoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrezzoStimatoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrezzoVenditaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Transazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vendita_Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDOggettoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        DataLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.OggettiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OggettiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtModello)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.txtSeriale)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.cmbStatus)
        Me.Panel1.Controls.Add(Me.OggettoTextBox1)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(DataLabel)
        Me.Panel1.Controls.Add(Me.DescrizioneTextBox)
        Me.Panel1.Size = New System.Drawing.Size(923, 42)
        Me.Panel1.Controls.SetChildIndex(Me.DescrizioneTextBox, 0)
        Me.Panel1.Controls.SetChildIndex(DataLabel, 0)
        Me.Panel1.Controls.SetChildIndex(Label1, 0)
        Me.Panel1.Controls.SetChildIndex(Me.OggettoTextBox1, 0)
        Me.Panel1.Controls.SetChildIndex(Me.cmbStatus, 0)
        Me.Panel1.Controls.SetChildIndex(Label2, 0)
        Me.Panel1.Controls.SetChildIndex(Me.txtSeriale, 0)
        Me.Panel1.Controls.SetChildIndex(Label3, 0)
        Me.Panel1.Controls.SetChildIndex(Me.txtModello, 0)
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataLabel.Location = New System.Drawing.Point(3, 9)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(63, 13)
        DataLabel.TabIndex = 26
        DataLabel.Text = "Description:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(479, 9)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(44, 13)
        Label1.TabIndex = 28
        Label1.Text = "Object :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(348, 9)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(39, 13)
        Label2.TabIndex = 31
        Label2.Text = "Serial :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(213, 9)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(42, 13)
        Label3.TabIndex = 33
        Label3.Text = "Model :"
        '
        'OggettiDataGridView
        '
        Me.OggettiDataGridView.AllowUserToAddRows = False
        Me.OggettiDataGridView.AllowUserToDeleteRows = False
        Me.OggettiDataGridView.AutoGenerateColumns = False
        Me.OggettiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OggettiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codice, Me.DescrizioneDataGridViewTextBoxColumn, Me.Modello, Me.Serie, Me.PrezzoAcquistoDataGridViewTextBoxColumn, Me.PrezzoStimatoDataGridViewTextBoxColumn, Me.PrezzoVenditaDataGridViewTextBoxColumn, Me.Transazione, Me.Vendita_Data, Me.IDOggettoDataGridViewTextBoxColumn})
        Me.OggettiDataGridView.DataSource = Me.OggettiBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OggettiDataGridView.DefaultCellStyle = DataGridViewCellStyle5
        Me.OggettiDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OggettiDataGridView.Location = New System.Drawing.Point(0, 42)
        Me.OggettiDataGridView.MultiSelect = False
        Me.OggettiDataGridView.Name = "OggettiDataGridView"
        Me.OggettiDataGridView.ReadOnly = True
        Me.OggettiDataGridView.RowHeadersVisible = False
        Me.OggettiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.OggettiDataGridView.Size = New System.Drawing.Size(923, 524)
        Me.OggettiDataGridView.TabIndex = 0
        '
        'OggettiBindingSource
        '
        Me.OggettiBindingSource.DataSource = GetType(mrCash_DAL.Oggetti)
        '
        'DescrizioneTextBox
        '
        Me.DescrizioneTextBox.Location = New System.Drawing.Point(74, 9)
        Me.DescrizioneTextBox.Name = "DescrizioneTextBox"
        Me.DescrizioneTextBox.Size = New System.Drawing.Size(126, 20)
        Me.DescrizioneTextBox.TabIndex = 0
        '
        'OggettoTextBox1
        '
        Me.OggettoTextBox1.Location = New System.Drawing.Point(533, 9)
        Me.OggettoTextBox1.Name = "OggettoTextBox1"
        Me.OggettoTextBox1.Size = New System.Drawing.Size(55, 20)
        Me.OggettoTextBox1.TabIndex = 3
        '
        'cmbStatus
        '
        Me.cmbStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(594, 9)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(130, 21)
        Me.cmbStatus.TabIndex = 4
        '
        'txtSeriale
        '
        Me.txtSeriale.Location = New System.Drawing.Point(396, 9)
        Me.txtSeriale.Name = "txtSeriale"
        Me.txtSeriale.Size = New System.Drawing.Size(77, 20)
        Me.txtSeriale.TabIndex = 1
        '
        'txtModello
        '
        Me.txtModello.Location = New System.Drawing.Point(266, 9)
        Me.txtModello.Name = "txtModello"
        Me.txtModello.Size = New System.Drawing.Size(76, 20)
        Me.txtModello.TabIndex = 2
        '
        'Codice
        '
        Me.Codice.DataPropertyName = "Codice"
        Me.Codice.HeaderText = "Code"
        Me.Codice.Name = "Codice"
        Me.Codice.ReadOnly = True
        '
        'DescrizioneDataGridViewTextBoxColumn
        '
        Me.DescrizioneDataGridViewTextBoxColumn.DataPropertyName = "Descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescrizioneDataGridViewTextBoxColumn.Name = "DescrizioneDataGridViewTextBoxColumn"
        Me.DescrizioneDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescrizioneDataGridViewTextBoxColumn.Width = 300
        '
        'Modello
        '
        Me.Modello.DataPropertyName = "Modello"
        Me.Modello.HeaderText = "Model"
        Me.Modello.Name = "Modello"
        Me.Modello.ReadOnly = True
        '
        'Serie
        '
        Me.Serie.DataPropertyName = "Serie"
        Me.Serie.HeaderText = "Series"
        Me.Serie.Name = "Serie"
        Me.Serie.ReadOnly = True
        '
        'PrezzoAcquistoDataGridViewTextBoxColumn
        '
        Me.PrezzoAcquistoDataGridViewTextBoxColumn.DataPropertyName = "PrezzoAcquisto"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "0.00"
        Me.PrezzoAcquistoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.PrezzoAcquistoDataGridViewTextBoxColumn.HeaderText = "Bought at"
        Me.PrezzoAcquistoDataGridViewTextBoxColumn.Name = "PrezzoAcquistoDataGridViewTextBoxColumn"
        Me.PrezzoAcquistoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrezzoAcquistoDataGridViewTextBoxColumn.Width = 60
        '
        'PrezzoStimatoDataGridViewTextBoxColumn
        '
        Me.PrezzoStimatoDataGridViewTextBoxColumn.DataPropertyName = "PrezzoStimato"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "0.00"
        Me.PrezzoStimatoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.PrezzoStimatoDataGridViewTextBoxColumn.HeaderText = "Estimation"
        Me.PrezzoStimatoDataGridViewTextBoxColumn.Name = "PrezzoStimatoDataGridViewTextBoxColumn"
        Me.PrezzoStimatoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrezzoStimatoDataGridViewTextBoxColumn.Width = 60
        '
        'PrezzoVenditaDataGridViewTextBoxColumn
        '
        Me.PrezzoVenditaDataGridViewTextBoxColumn.DataPropertyName = "PrezzoVendita"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "0.00"
        Me.PrezzoVenditaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.PrezzoVenditaDataGridViewTextBoxColumn.HeaderText = "Sold at"
        Me.PrezzoVenditaDataGridViewTextBoxColumn.Name = "PrezzoVenditaDataGridViewTextBoxColumn"
        Me.PrezzoVenditaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrezzoVenditaDataGridViewTextBoxColumn.Width = 60
        '
        'Transazione
        '
        Me.Transazione.DataPropertyName = "Transazione_Acquisto"
        Me.Transazione.HeaderText = "Trans."
        Me.Transazione.Name = "Transazione"
        Me.Transazione.ReadOnly = True
        Me.Transazione.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Transazione.Width = 45
        '
        'Vendita_Data
        '
        Me.Vendita_Data.DataPropertyName = "Vendita_Data"
        DataGridViewCellStyle4.NullValue = "-"
        Me.Vendita_Data.DefaultCellStyle = DataGridViewCellStyle4
        Me.Vendita_Data.HeaderText = "Selling date"
        Me.Vendita_Data.Name = "Vendita_Data"
        Me.Vendita_Data.ReadOnly = True
        Me.Vendita_Data.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Vendita_Data.Width = 70
        '
        'IDOggettoDataGridViewTextBoxColumn
        '
        Me.IDOggettoDataGridViewTextBoxColumn.DataPropertyName = "IDOggetto"
        Me.IDOggettoDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDOggettoDataGridViewTextBoxColumn.Name = "IDOggettoDataGridViewTextBoxColumn"
        Me.IDOggettoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDOggettoDataGridViewTextBoxColumn.Width = 5
        '
        'frmRicercaOggetti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 566)
        Me.Controls.Add(Me.OggettiDataGridView)
        Me.Name = "frmRicercaOggetti"
        Me.Text = "Objects search"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.OggettiDataGridView, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.OggettiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OggettiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OggettiDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents OggettiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescrizioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OggettoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtSeriale As System.Windows.Forms.TextBox
    Friend WithEvents txtModello As System.Windows.Forms.TextBox
    Friend WithEvents Codice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescrizioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modello As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrezzoAcquistoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrezzoStimatoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrezzoVenditaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Transazione As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vendita_Data As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDOggettoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
