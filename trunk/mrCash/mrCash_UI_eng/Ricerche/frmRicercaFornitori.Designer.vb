<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRicercaFornitori
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
        Dim DataLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.FornitoriDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FornitoriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NomeTextBox1 = New System.Windows.Forms.TextBox
        Me.CognomeTextBox1 = New System.Windows.Forms.TextBox
        DataLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.FornitoriDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornitoriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(Me.NomeTextBox1)
        Me.Panel1.Controls.Add(DataLabel)
        Me.Panel1.Controls.Add(Me.CognomeTextBox1)
        Me.Panel1.TabIndex = 0
        Me.Panel1.Controls.SetChildIndex(Me.CognomeTextBox1, 0)
        Me.Panel1.Controls.SetChildIndex(DataLabel, 0)
        Me.Panel1.Controls.SetChildIndex(Me.NomeTextBox1, 0)
        Me.Panel1.Controls.SetChildIndex(Label1, 0)
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataLabel.Location = New System.Drawing.Point(3, 10)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(55, 13)
        DataLabel.TabIndex = 27
        DataLabel.Text = "Cognome:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(273, 10)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(38, 13)
        Label1.TabIndex = 29
        Label1.Text = "Nome:"
        '
        'FornitoriDataGridView
        '
        Me.FornitoriDataGridView.AllowUserToAddRows = False
        Me.FornitoriDataGridView.AllowUserToDeleteRows = False
        Me.FornitoriDataGridView.AutoGenerateColumns = False
        Me.FornitoriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FornitoriDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn1})
        Me.FornitoriDataGridView.DataSource = Me.FornitoriBindingSource
        Me.FornitoriDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FornitoriDataGridView.Location = New System.Drawing.Point(0, 42)
        Me.FornitoriDataGridView.Name = "FornitoriDataGridView"
        Me.FornitoriDataGridView.ReadOnly = True
        Me.FornitoriDataGridView.RowHeadersVisible = False
        Me.FornitoriDataGridView.Size = New System.Drawing.Size(792, 524)
        Me.FornitoriDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Cognome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cognome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nome"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Indirizzo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Indirizzo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Citta"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Città"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Provincia"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Prov."
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDFornitore"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'FornitoriBindingSource
        '
        Me.FornitoriBindingSource.DataSource = GetType(mrCash_DAL.Fornitori)
        '
        'NomeTextBox1
        '
        Me.NomeTextBox1.Location = New System.Drawing.Point(317, 10)
        Me.NomeTextBox1.Name = "NomeTextBox1"
        Me.NomeTextBox1.Size = New System.Drawing.Size(131, 20)
        Me.NomeTextBox1.TabIndex = 1
        '
        'CognomeTextBox1
        '
        Me.CognomeTextBox1.Location = New System.Drawing.Point(64, 10)
        Me.CognomeTextBox1.Name = "CognomeTextBox1"
        Me.CognomeTextBox1.Size = New System.Drawing.Size(143, 20)
        Me.CognomeTextBox1.TabIndex = 0
        '
        'frmRicercaFornitori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.FornitoriDataGridView)
        Me.Name = "frmRicercaFornitori"
        Me.Text = "Ricerca Fornitori"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.FornitoriDataGridView, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.FornitoriDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornitoriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FornitoriBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FornitoriDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CognomeTextBox1 As System.Windows.Forms.TextBox
End Class
