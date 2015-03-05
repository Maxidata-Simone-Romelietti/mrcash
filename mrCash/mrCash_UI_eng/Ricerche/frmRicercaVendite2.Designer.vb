<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRicercaVendite2
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
        Dim Label1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Fornitori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OggettoTextBox1 = New System.Windows.Forms.TextBox()
        Me.VenditeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VenditeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElementHost2 = New System.Windows.Forms.Integration.ElementHost()
        Me.UsrCalendario1 = New mrCash_UI_eng.usrCalendario()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.VenditeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VenditeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'OggettoTextBox1
        '
        Me.OggettoTextBox1.Location = New System.Drawing.Point(451, 12)
        Me.OggettoTextBox1.Name = "OggettoTextBox1"
        Me.OggettoTextBox1.Size = New System.Drawing.Size(73, 20)
        Me.OggettoTextBox1.TabIndex = 29
        '
        'VenditeBindingSource
        '
        Me.VenditeBindingSource.DataSource = GetType(mrCash_DAL.Acquisti)
        '
        'VenditeBindingSource1
        '
        Me.VenditeBindingSource1.DataSource = GetType(mrCash_DAL.Vendite)
        '
        'ElementHost2
        '
        Me.ElementHost2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ElementHost2.Location = New System.Drawing.Point(2, 1)
        Me.ElementHost2.Name = "ElementHost2"
        Me.ElementHost2.Size = New System.Drawing.Size(787, 567)
        Me.ElementHost2.TabIndex = 24
        Me.ElementHost2.Text = "ElementHost2"
        Me.ElementHost2.Child = Me.UsrCalendario1
        '
        'frmRicercaVendite2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.ElementHost2)
        Me.Name = "frmRicercaVendite2"
        Me.Text = "Selling search"
        CType(Me.VenditeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VenditeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VenditeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fornitori As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FornitoriDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDAcquistoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OggettoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents VenditeBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ElementHost2 As System.Windows.Forms.Integration.ElementHost
    Friend UsrCalendario1 As mrCash_UI_eng.usrCalendario
End Class
