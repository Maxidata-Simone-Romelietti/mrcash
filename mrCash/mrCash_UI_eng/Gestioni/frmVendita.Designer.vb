<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendita
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
        Me.components = New System.ComponentModel.Container()
        Dim DataLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.VenditeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.OggettiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OggettiDataGridView = New System.Windows.Forms.DataGridView()
        Me.txtCodice = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtTotale = New mrCash_UI_eng.PrezzoTextBox()
        Me.txtParziale = New mrCash_UI_eng.PrezzoTextBox()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RigaVendita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrezzoStimato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrezzoVendita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        DataLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.VenditeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OggettiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OggettiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdElimina
        '
        Me.cmdElimina.Location = New System.Drawing.Point(12, 405)
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Location = New System.Drawing.Point(693, 405)
        '
        'cmdConferma
        '
        Me.cmdConferma.Location = New System.Drawing.Point(595, 405)
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataLabel.Location = New System.Drawing.Point(12, 15)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(48, 20)
        DataLabel.TabIndex = 1
        DataLabel.Text = "Date:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(566, 17)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(121, 20)
        Label1.TabIndex = 19
        Label1.Text = "Scan a barcode"
        '
        'Label2
        '
        Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(374, 412)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(52, 20)
        Label2.TabIndex = 20
        Label2.Text = "Total :"
        '
        'Label3
        '
        Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(169, 412)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(77, 20)
        Label3.TabIndex = 22
        Label3.Text = "Subtotal :"
        '
        'VenditeBindingSource
        '
        Me.VenditeBindingSource.DataSource = GetType(mrCash_DAL.Vendite)
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.CustomFormat = "dd / MM / yyyy"
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VenditeBindingSource, "Data", True))
        Me.DataDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DataDateTimePicker.Location = New System.Drawing.Point(66, 12)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.DataDateTimePicker.TabIndex = 2
        '
        'OggettiBindingSource
        '
        Me.OggettiBindingSource.DataMember = "Oggetti"
        Me.OggettiBindingSource.DataSource = Me.VenditeBindingSource
        '
        'OggettiDataGridView
        '
        Me.OggettiDataGridView.AllowUserToAddRows = False
        Me.OggettiDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OggettiDataGridView.AutoGenerateColumns = False
        Me.OggettiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OggettiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.RigaVendita, Me.PrezzoStimato, Me.PrezzoVendita, Me.DataGridViewTextBoxColumn3, Me.Note})
        Me.OggettiDataGridView.DataSource = Me.OggettiBindingSource
        Me.OggettiDataGridView.Location = New System.Drawing.Point(12, 44)
        Me.OggettiDataGridView.Name = "OggettiDataGridView"
        Me.OggettiDataGridView.Size = New System.Drawing.Size(773, 355)
        Me.OggettiDataGridView.TabIndex = 1
        '
        'txtCodice
        '
        Me.txtCodice.Location = New System.Drawing.Point(693, 15)
        Me.txtCodice.Name = "txtCodice"
        Me.txtCodice.Size = New System.Drawing.Size(92, 20)
        Me.txtCodice.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(173, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 35)
        Me.Button1.TabIndex = 18
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtTotale
        '
        Me.txtTotale.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotale.Format = "0.00"
        Me.txtTotale.Location = New System.Drawing.Point(475, 409)
        Me.txtTotale.Name = "txtTotale"
        Me.txtTotale.ReadOnly = True
        Me.txtTotale.Size = New System.Drawing.Size(94, 26)
        Me.txtTotale.TabIndex = 21
        Me.txtTotale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtParziale
        '
        Me.txtParziale.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtParziale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParziale.Format = "0.00"
        Me.txtParziale.Location = New System.Drawing.Point(253, 409)
        Me.txtParziale.Name = "txtParziale"
        Me.txtParziale.ReadOnly = True
        Me.txtParziale.Size = New System.Drawing.Size(94, 26)
        Me.txtParziale.TabIndex = 23
        Me.txtParziale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Codice"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Barcode"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'RigaVendita
        '
        Me.RigaVendita.DataPropertyName = "RigaVendita"
        Me.RigaVendita.HeaderText = "RigaVendita"
        Me.RigaVendita.Name = "RigaVendita"
        Me.RigaVendita.Visible = False
        '
        'PrezzoStimato
        '
        Me.PrezzoStimato.DataPropertyName = "PrezzoStimato"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "0.00"
        Me.PrezzoStimato.DefaultCellStyle = DataGridViewCellStyle1
        Me.PrezzoStimato.HeaderText = "Ipotetico"
        Me.PrezzoStimato.Name = "PrezzoStimato"
        Me.PrezzoStimato.ReadOnly = True
        Me.PrezzoStimato.Visible = False
        Me.PrezzoStimato.Width = 60
        '
        'PrezzoVendita
        '
        Me.PrezzoVendita.DataPropertyName = "PrezzoVendita"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "0.00"
        Me.PrezzoVendita.DefaultCellStyle = DataGridViewCellStyle2
        Me.PrezzoVendita.HeaderText = "Price"
        Me.PrezzoVendita.Name = "PrezzoVendita"
        Me.PrezzoVendita.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Descrizione"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'Note
        '
        Me.Note.DataPropertyName = "Note"
        Me.Note.HeaderText = "Annotation"
        Me.Note.Name = "Note"
        Me.Note.ReadOnly = True
        Me.Note.Width = 150
        '
        'frmVendita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 452)
        Me.Controls.Add(Me.txtParziale)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.txtTotale)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtCodice)
        Me.Controls.Add(Me.OggettiDataGridView)
        Me.Controls.Add(DataLabel)
        Me.Controls.Add(Me.DataDateTimePicker)
        Me.Controls.Add(Me.Button1)
        Me.KeyPreview = True
        Me.Name = "frmVendita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sell"
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.DataDateTimePicker, 0)
        Me.Controls.SetChildIndex(DataLabel, 0)
        Me.Controls.SetChildIndex(Me.OggettiDataGridView, 0)
        Me.Controls.SetChildIndex(Me.txtCodice, 0)
        Me.Controls.SetChildIndex(Me.cmdConferma, 0)
        Me.Controls.SetChildIndex(Me.cmdAnnulla, 0)
        Me.Controls.SetChildIndex(Label1, 0)
        Me.Controls.SetChildIndex(Me.cmdElimina, 0)
        Me.Controls.SetChildIndex(Label2, 0)
        Me.Controls.SetChildIndex(Me.txtTotale, 0)
        Me.Controls.SetChildIndex(Label3, 0)
        Me.Controls.SetChildIndex(Me.txtParziale, 0)
        CType(Me.VenditeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OggettiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OggettiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VenditeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents OggettiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OggettiDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtCodice As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtTotale As mrCash_UI_eng.PrezzoTextBox
    Friend WithEvents txtParziale As mrCash_UI_eng.PrezzoTextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RigaVendita As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrezzoStimato As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrezzoVendita As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Note As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
