<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventario
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
        Me.components = New System.ComponentModel.Container
        Me.cmdElabora = New System.Windows.Forms.Button
        Me.txtData = New UltraDateTimePicker.UltraDateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.OggettiDataGridView = New System.Windows.Forms.DataGridView
        Me.OggettiMancantiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.OggettiVendutiPresentiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.CodiciSconosciutiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblAvviso = New System.Windows.Forms.Label
        Me.lblPosto = New System.Windows.Forms.Label
        Me.CodiceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Inventario_ControllerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodiceDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescrizioneDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescrizioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.txtData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OggettiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OggettiMancantiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OggettiVendutiPresentiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodiciSconosciutiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventario_ControllerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdElabora
        '
        Me.cmdElabora.Location = New System.Drawing.Point(166, 79)
        Me.cmdElabora.Name = "cmdElabora"
        Me.cmdElabora.Size = New System.Drawing.Size(110, 26)
        Me.cmdElabora.TabIndex = 0
        Me.cmdElabora.Text = "ELABORA"
        Me.cmdElabora.UseVisualStyleBackColor = True
        '
        'txtData
        '
        Me.txtData.CustomFormat = "dd / MM / yyyy"
        Me.txtData.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Inventario_ControllerBindingSource, "DataScansioni", True))
        Me.txtData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtData.Location = New System.Drawing.Point(15, 79)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(145, 26)
        Me.txtData.TabIndex = 39
        Me.txtData.Value = New Date(2011, 3, 27, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 13)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Scansioni effettuate in data"
        '
        'OggettiDataGridView
        '
        Me.OggettiDataGridView.AllowUserToAddRows = False
        Me.OggettiDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OggettiDataGridView.AutoGenerateColumns = False
        Me.OggettiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OggettiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodiceDataGridViewTextBoxColumn, Me.DescrizioneDataGridViewTextBoxColumn})
        Me.OggettiDataGridView.DataSource = Me.OggettiMancantiBindingSource
        Me.OggettiDataGridView.Location = New System.Drawing.Point(16, 131)
        Me.OggettiDataGridView.Name = "OggettiDataGridView"
        Me.OggettiDataGridView.RowHeadersVisible = False
        Me.OggettiDataGridView.Size = New System.Drawing.Size(368, 527)
        Me.OggettiDataGridView.TabIndex = 41
        '
        'OggettiMancantiBindingSource
        '
        Me.OggettiMancantiBindingSource.DataMember = "OggettiMancanti"
        Me.OggettiMancantiBindingSource.DataSource = Me.Inventario_ControllerBindingSource
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodiceDataGridViewTextBoxColumn2, Me.DescrizioneDataGridViewTextBoxColumn2})
        Me.DataGridView1.DataSource = Me.OggettiVendutiPresentiBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(474, 131)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(368, 527)
        Me.DataGridView1.TabIndex = 42
        '
        'OggettiVendutiPresentiBindingSource
        '
        Me.OggettiVendutiPresentiBindingSource.DataMember = "OggettiVendutiPresenti"
        Me.OggettiVendutiPresentiBindingSource.DataSource = Me.Inventario_ControllerBindingSource
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodiceDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.CodiciSconosciutiBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(474, 28)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(368, 77)
        Me.DataGridView2.TabIndex = 43
        '
        'CodiciSconosciutiBindingSource
        '
        Me.CodiciSconosciutiBindingSource.DataMember = "CodiciSconosciuti"
        Me.CodiciSconosciutiBindingSource.DataSource = Me.Inventario_ControllerBindingSource
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Oggetti disponibili mancanti"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(471, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Oggetti non disponibili ma presenti"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(471, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Codici sconosciuti"
        '
        'lblAvviso
        '
        Me.lblAvviso.AutoSize = True
        Me.lblAvviso.Location = New System.Drawing.Point(12, 12)
        Me.lblAvviso.Name = "lblAvviso"
        Me.lblAvviso.Size = New System.Drawing.Size(181, 13)
        Me.lblAvviso.TabIndex = 47
        Me.lblAvviso.Text = "Posizionare le scansioni nella cartella"
        '
        'lblPosto
        '
        Me.lblPosto.AutoSize = True
        Me.lblPosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosto.Location = New System.Drawing.Point(12, 28)
        Me.lblPosto.Name = "lblPosto"
        Me.lblPosto.Size = New System.Drawing.Size(15, 20)
        Me.lblPosto.TabIndex = 48
        Me.lblPosto.Text = "-"
        '
        'CodiceDataGridViewTextBoxColumn1
        '
        Me.CodiceDataGridViewTextBoxColumn1.DataPropertyName = "Codice"
        Me.CodiceDataGridViewTextBoxColumn1.HeaderText = "Codice"
        Me.CodiceDataGridViewTextBoxColumn1.Name = "CodiceDataGridViewTextBoxColumn1"
        '
        'Inventario_ControllerBindingSource
        '
        Me.Inventario_ControllerBindingSource.DataSource = GetType(mrCash_UI_eng.Inventario_Controller)
        '
        'CodiceDataGridViewTextBoxColumn2
        '
        Me.CodiceDataGridViewTextBoxColumn2.DataPropertyName = "Codice"
        Me.CodiceDataGridViewTextBoxColumn2.HeaderText = "Codice"
        Me.CodiceDataGridViewTextBoxColumn2.Name = "CodiceDataGridViewTextBoxColumn2"
        '
        'DescrizioneDataGridViewTextBoxColumn2
        '
        Me.DescrizioneDataGridViewTextBoxColumn2.DataPropertyName = "Descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn2.HeaderText = "Descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn2.Name = "DescrizioneDataGridViewTextBoxColumn2"
        '
        'CodiceDataGridViewTextBoxColumn
        '
        Me.CodiceDataGridViewTextBoxColumn.DataPropertyName = "Codice"
        Me.CodiceDataGridViewTextBoxColumn.HeaderText = "Codice"
        Me.CodiceDataGridViewTextBoxColumn.Name = "CodiceDataGridViewTextBoxColumn"
        '
        'DescrizioneDataGridViewTextBoxColumn
        '
        Me.DescrizioneDataGridViewTextBoxColumn.DataPropertyName = "Descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn.Name = "DescrizioneDataGridViewTextBoxColumn"
        '
        'frmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 670)
        Me.Controls.Add(Me.lblPosto)
        Me.Controls.Add(Me.lblAvviso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.OggettiDataGridView)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmdElabora)
        Me.Name = "frmInventario"
        Me.Text = "Inventario"
        CType(Me.txtData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OggettiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OggettiMancantiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OggettiVendutiPresentiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodiciSconosciutiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventario_ControllerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdElabora As System.Windows.Forms.Button
    Friend WithEvents txtData As UltraDateTimePicker.UltraDateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Inventario_ControllerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OggettiDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OggettiMancantiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OggettiVendutiPresentiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CodiciSconosciutiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CodiceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescrizioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodiceDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescrizioneDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodiceDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblAvviso As System.Windows.Forms.Label
    Friend WithEvents lblPosto As System.Windows.Forms.Label
End Class
