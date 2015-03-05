<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcquisto
    Inherits frmGestione_Base

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
        Dim DataLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim lblpezzi As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcquisto))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.AcquistiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OggettiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OggettiDataGridView = New System.Windows.Forms.DataGridView
        Me.cmdRicerca = New System.Windows.Forms.Button
        Me.CognomeTextBox1 = New System.Windows.Forms.TextBox
        Me.FornitoriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.cmdStampa = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.PrezzoTextBox1 = New mrCash_UI_eng.PrezzoTextBox
        Me.txtTotale = New mrCash_UI_eng.PrezzoTextBox
        Me.txtPezzi = New mrCash_UI_eng.PrezzoTextBox
        Me.Descrizione = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Modello = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Serie = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrezzoAcquisto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrezzoStimato = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Codice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Copia = New System.Windows.Forms.DataGridViewButtonColumn
        DataLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        lblpezzi = New System.Windows.Forms.Label
        CType(Me.AcquistiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OggettiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OggettiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornitoriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdElimina
        '
        Me.cmdElimina.Location = New System.Drawing.Point(12, 454)
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Location = New System.Drawing.Point(741, 454)
        '
        'cmdConferma
        '
        Me.cmdConferma.Location = New System.Drawing.Point(643, 454)
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataLabel.Location = New System.Drawing.Point(12, 12)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(48, 20)
        DataLabel.TabIndex = 1
        DataLabel.Text = "Data:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(313, 12)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(53, 20)
        Label1.TabIndex = 10
        Label1.Text = "Trans."
        '
        'Label2
        '
        Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(344, 461)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(95, 20)
        Label2.TabIndex = 22
        Label2.Text = "Totale Euro:"
        '
        'lblpezzi
        '
        lblpezzi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        lblpezzi.AutoSize = True
        lblpezzi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblpezzi.Location = New System.Drawing.Point(187, 461)
        lblpezzi.Name = "lblpezzi"
        lblpezzi.Size = New System.Drawing.Size(51, 20)
        lblpezzi.TabIndex = 24
        lblpezzi.Text = "Pezzi:"
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.CustomFormat = "dd / MM / yyyy"
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AcquistiBindingSource, "Data", True))
        Me.DataDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DataDateTimePicker.Location = New System.Drawing.Point(66, 12)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(130, 26)
        Me.DataDateTimePicker.TabIndex = 0
        '
        'AcquistiBindingSource
        '
        Me.AcquistiBindingSource.DataSource = GetType(mrCash_DAL.Acquisti)
        '
        'OggettiBindingSource
        '
        Me.OggettiBindingSource.DataMember = "Oggetti"
        Me.OggettiBindingSource.DataSource = Me.AcquistiBindingSource
        '
        'OggettiDataGridView
        '
        Me.OggettiDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OggettiDataGridView.AutoGenerateColumns = False
        Me.OggettiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OggettiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Descrizione, Me.Modello, Me.Serie, Me.PrezzoAcquisto, Me.PrezzoStimato, Me.Codice, Me.Copia})
        Me.OggettiDataGridView.DataSource = Me.OggettiBindingSource
        Me.OggettiDataGridView.Location = New System.Drawing.Point(12, 44)
        Me.OggettiDataGridView.Name = "OggettiDataGridView"
        Me.OggettiDataGridView.Size = New System.Drawing.Size(821, 404)
        Me.OggettiDataGridView.TabIndex = 2
        '
        'cmdRicerca
        '
        Me.cmdRicerca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRicerca.Location = New System.Drawing.Point(806, 12)
        Me.cmdRicerca.Name = "cmdRicerca"
        Me.cmdRicerca.Size = New System.Drawing.Size(27, 26)
        Me.cmdRicerca.TabIndex = 3
        Me.cmdRicerca.Text = "..."
        Me.cmdRicerca.UseVisualStyleBackColor = True
        '
        'CognomeTextBox1
        '
        Me.CognomeTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CognomeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornitoriBindingSource, "NomeCompleto", True))
        Me.CognomeTextBox1.Location = New System.Drawing.Point(545, 12)
        Me.CognomeTextBox1.Name = "CognomeTextBox1"
        Me.CognomeTextBox1.ReadOnly = True
        Me.CognomeTextBox1.Size = New System.Drawing.Size(255, 20)
        Me.CognomeTextBox1.TabIndex = 1
        '
        'FornitoriBindingSource
        '
        Me.FornitoriBindingSource.DataSource = GetType(mrCash_DAL.Fornitori)
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
        'cmdStampa
        '
        Me.cmdStampa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdStampa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStampa.Location = New System.Drawing.Point(545, 454)
        Me.cmdStampa.Name = "cmdStampa"
        Me.cmdStampa.Size = New System.Drawing.Size(92, 35)
        Me.cmdStampa.TabIndex = 5
        Me.cmdStampa.Text = "Stampa"
        Me.cmdStampa.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "HH:mm"
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AcquistiBindingSource, "Data", True))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(202, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(76, 26)
        Me.DateTimePicker1.TabIndex = 7
        '
        'PrezzoTextBox1
        '
        Me.PrezzoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Valore", Me.AcquistiBindingSource, "Transazione", True))
        Me.PrezzoTextBox1.Format = "#"
        Me.PrezzoTextBox1.Location = New System.Drawing.Point(372, 12)
        Me.PrezzoTextBox1.Name = "PrezzoTextBox1"
        Me.PrezzoTextBox1.Size = New System.Drawing.Size(57, 20)
        Me.PrezzoTextBox1.TabIndex = 11
        Me.PrezzoTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotale
        '
        Me.txtTotale.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotale.Format = "0.00"
        Me.txtTotale.Location = New System.Drawing.Point(445, 458)
        Me.txtTotale.Name = "txtTotale"
        Me.txtTotale.ReadOnly = True
        Me.txtTotale.Size = New System.Drawing.Size(94, 26)
        Me.txtTotale.TabIndex = 23
        Me.txtTotale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPezzi
        '
        Me.txtPezzi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPezzi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPezzi.Format = "#"
        Me.txtPezzi.Location = New System.Drawing.Point(244, 458)
        Me.txtPezzi.Name = "txtPezzi"
        Me.txtPezzi.ReadOnly = True
        Me.txtPezzi.Size = New System.Drawing.Size(53, 26)
        Me.txtPezzi.TabIndex = 25
        Me.txtPezzi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Descrizione
        '
        Me.Descrizione.DataPropertyName = "Descrizione"
        Me.Descrizione.HeaderText = "Descrizione"
        Me.Descrizione.Name = "Descrizione"
        Me.Descrizione.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Descrizione.Width = 200
        '
        'Modello
        '
        Me.Modello.DataPropertyName = "Modello"
        Me.Modello.HeaderText = "Modello"
        Me.Modello.Name = "Modello"
        Me.Modello.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Serie
        '
        Me.Serie.DataPropertyName = "Serie"
        Me.Serie.HeaderText = "Serie"
        Me.Serie.Name = "Serie"
        Me.Serie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'PrezzoAcquisto
        '
        Me.PrezzoAcquisto.DataPropertyName = "PrezzoAcquisto"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "0.00"
        Me.PrezzoAcquisto.DefaultCellStyle = DataGridViewCellStyle1
        Me.PrezzoAcquisto.HeaderText = "Acquistato a"
        Me.PrezzoAcquisto.Name = "PrezzoAcquisto"
        Me.PrezzoAcquisto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PrezzoAcquisto.Width = 80
        '
        'PrezzoStimato
        '
        Me.PrezzoStimato.DataPropertyName = "PrezzoStimato"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "0.00"
        Me.PrezzoStimato.DefaultCellStyle = DataGridViewCellStyle2
        Me.PrezzoStimato.HeaderText = "Stimato"
        Me.PrezzoStimato.Name = "PrezzoStimato"
        Me.PrezzoStimato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PrezzoStimato.Width = 80
        '
        'Codice
        '
        Me.Codice.DataPropertyName = "Codice"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Codice.DefaultCellStyle = DataGridViewCellStyle3
        Me.Codice.HeaderText = "Codice"
        Me.Codice.Name = "Codice"
        Me.Codice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Codice.Width = 80
        '
        'Copia
        '
        Me.Copia.HeaderText = "Copia"
        Me.Copia.Name = "Copia"
        Me.Copia.ReadOnly = True
        Me.Copia.Width = 50
        '
        'frmAcquisto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 499)
        Me.Controls.Add(Me.txtPezzi)
        Me.Controls.Add(lblpezzi)
        Me.Controls.Add(Me.txtTotale)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.PrezzoTextBox1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cmdStampa)
        Me.Controls.Add(Me.CognomeTextBox1)
        Me.Controls.Add(Me.cmdRicerca)
        Me.Controls.Add(Me.OggettiDataGridView)
        Me.Controls.Add(DataLabel)
        Me.Controls.Add(Me.DataDateTimePicker)
        Me.KeyPreview = True
        Me.Name = "frmAcquisto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acquisto"
        Me.Controls.SetChildIndex(Me.DataDateTimePicker, 0)
        Me.Controls.SetChildIndex(DataLabel, 0)
        Me.Controls.SetChildIndex(Me.OggettiDataGridView, 0)
        Me.Controls.SetChildIndex(Me.cmdRicerca, 0)
        Me.Controls.SetChildIndex(Me.cmdConferma, 0)
        Me.Controls.SetChildIndex(Me.CognomeTextBox1, 0)
        Me.Controls.SetChildIndex(Me.cmdAnnulla, 0)
        Me.Controls.SetChildIndex(Me.cmdStampa, 0)
        Me.Controls.SetChildIndex(Me.cmdElimina, 0)
        Me.Controls.SetChildIndex(Me.DateTimePicker1, 0)
        Me.Controls.SetChildIndex(Label1, 0)
        Me.Controls.SetChildIndex(Me.PrezzoTextBox1, 0)
        Me.Controls.SetChildIndex(Label2, 0)
        Me.Controls.SetChildIndex(Me.txtTotale, 0)
        Me.Controls.SetChildIndex(lblpezzi, 0)
        Me.Controls.SetChildIndex(Me.txtPezzi, 0)
        CType(Me.AcquistiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OggettiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OggettiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornitoriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AcquistiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents OggettiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OggettiDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cmdRicerca As System.Windows.Forms.Button
    Friend WithEvents CognomeTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FornitoriBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents cmdStampa As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents PrezzoTextBox1 As mrCash_UI_eng.PrezzoTextBox
    Friend WithEvents txtTotale As mrCash_UI_eng.PrezzoTextBox
    Friend WithEvents txtPezzi As mrCash_UI_eng.PrezzoTextBox
    Friend WithEvents Descrizione As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modello As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrezzoAcquisto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrezzoStimato As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Copia As System.Windows.Forms.DataGridViewButtonColumn
End Class
