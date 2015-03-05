<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFornitore
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
        Dim IDFornitoreLabel As System.Windows.Forms.Label
        Dim CognomeLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim RifDocLabel As System.Windows.Forms.Label
        Dim CittaLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim IndirizzoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.IDFornitoreTextBox = New System.Windows.Forms.TextBox()
        Me.FornitoriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CognomeTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciaTextBox = New System.Windows.Forms.TextBox()
        Me.RifDocTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.IndirizzoTextBox = New System.Windows.Forms.TextBox()
        Me.txtCap = New System.Windows.Forms.TextBox()
        Me.CittaTextBox = New System.Windows.Forms.TextBox()
        Me.txtDataRilascio = New System.Windows.Forms.DateTimePicker()
        Me.txtDataNascita = New System.Windows.Forms.DateTimePicker()
        Me.NoteTextBox1 = New System.Windows.Forms.TextBox()
        Me.cmbTipoDoc = New System.Windows.Forms.ComboBox()
        IDFornitoreLabel = New System.Windows.Forms.Label()
        CognomeLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        RifDocLabel = New System.Windows.Forms.Label()
        CittaLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        IndirizzoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.FornitoriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdElimina
        '
        Me.cmdElimina.Location = New System.Drawing.Point(12, 402)
        Me.cmdElimina.TabIndex = 14
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Location = New System.Drawing.Point(588, 402)
        Me.cmdAnnulla.TabIndex = 13
        '
        'cmdConferma
        '
        Me.cmdConferma.Location = New System.Drawing.Point(490, 402)
        Me.cmdConferma.TabIndex = 12
        '
        'IDFornitoreLabel
        '
        IDFornitoreLabel.AutoSize = True
        IDFornitoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDFornitoreLabel.Location = New System.Drawing.Point(586, 6)
        IDFornitoreLabel.Name = "IDFornitoreLabel"
        IDFornitoreLabel.Size = New System.Drawing.Size(26, 20)
        IDFornitoreLabel.TabIndex = 25
        IDFornitoreLabel.Text = "ID"
        '
        'CognomeLabel
        '
        CognomeLabel.AutoSize = True
        CognomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CognomeLabel.Location = New System.Drawing.Point(8, 9)
        CognomeLabel.Name = "CognomeLabel"
        CognomeLabel.Size = New System.Drawing.Size(74, 20)
        CognomeLabel.TabIndex = 23
        CognomeLabel.Text = "Surname"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.Location = New System.Drawing.Point(345, 9)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(51, 20)
        NomeLabel.TabIndex = 24
        NomeLabel.Text = "Name"
        '
        'RifDocLabel
        '
        RifDocLabel.AutoSize = True
        RifDocLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RifDocLabel.Location = New System.Drawing.Point(247, 126)
        RifDocLabel.Name = "RifDocLabel"
        RifDocLabel.Size = New System.Drawing.Size(76, 20)
        RifDocLabel.TabIndex = 18
        RifDocLabel.Text = "Doc. type"
        '
        'CittaLabel
        '
        CittaLabel.AutoSize = True
        CittaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CittaLabel.Location = New System.Drawing.Point(345, 67)
        CittaLabel.Name = "CittaLabel"
        CittaLabel.Size = New System.Drawing.Size(166, 20)
        CittaLabel.TabIndex = 21
        CittaLabel.Text = "Zipcode / City / County"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.Location = New System.Drawing.Point(8, 195)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(84, 20)
        TelefonoLabel.TabIndex = 16
        TelefonoLabel.Text = "Telephone"
        '
        'IndirizzoLabel
        '
        IndirizzoLabel.AutoSize = True
        IndirizzoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IndirizzoLabel.Location = New System.Drawing.Point(8, 67)
        IndirizzoLabel.Name = "IndirizzoLabel"
        IndirizzoLabel.Size = New System.Drawing.Size(68, 20)
        IndirizzoLabel.TabIndex = 22
        IndirizzoLabel.Text = "Address"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(8, 126)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(97, 20)
        Label1.TabIndex = 17
        Label1.Text = "Date of birth"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(345, 126)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(109, 20)
        Label2.TabIndex = 19
        Label2.Text = "Document no."
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(531, 126)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(104, 20)
        Label3.TabIndex = 20
        Label3.Text = "Release date"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(8, 251)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(87, 20)
        Label4.TabIndex = 15
        Label4.Text = "Annotation"
        '
        'IDFornitoreTextBox
        '
        Me.IDFornitoreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornitoriBindingSource, "IDFornitore", True))
        Me.IDFornitoreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDFornitoreTextBox.Location = New System.Drawing.Point(618, 3)
        Me.IDFornitoreTextBox.Name = "IDFornitoreTextBox"
        Me.IDFornitoreTextBox.ReadOnly = True
        Me.IDFornitoreTextBox.Size = New System.Drawing.Size(62, 26)
        Me.IDFornitoreTextBox.TabIndex = 26
        '
        'FornitoriBindingSource
        '
        Me.FornitoriBindingSource.DataSource = GetType(mrCash_DAL.Fornitori)
        '
        'CognomeTextBox
        '
        Me.CognomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornitoriBindingSource, "Cognome", True))
        Me.CognomeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CognomeTextBox.Location = New System.Drawing.Point(12, 32)
        Me.CognomeTextBox.MaxLength = 50
        Me.CognomeTextBox.Name = "CognomeTextBox"
        Me.CognomeTextBox.Size = New System.Drawing.Size(331, 26)
        Me.CognomeTextBox.TabIndex = 0
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornitoriBindingSource, "Nome", True))
        Me.NomeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTextBox.Location = New System.Drawing.Point(349, 32)
        Me.NomeTextBox.MaxLength = 50
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(331, 26)
        Me.NomeTextBox.TabIndex = 1
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornitoriBindingSource, "Provincia", True))
        Me.ProvinciaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(645, 90)
        Me.ProvinciaTextBox.MaxLength = 2
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(35, 26)
        Me.ProvinciaTextBox.TabIndex = 5
        '
        'RifDocTextBox
        '
        Me.RifDocTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornitoriBindingSource, "Citta", True))
        Me.RifDocTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RifDocTextBox.Location = New System.Drawing.Point(413, 90)
        Me.RifDocTextBox.MaxLength = 50
        Me.RifDocTextBox.Name = "RifDocTextBox"
        Me.RifDocTextBox.Size = New System.Drawing.Size(226, 26)
        Me.RifDocTextBox.TabIndex = 4
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornitoriBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(12, 218)
        Me.TelefonoTextBox.MaxLength = 50
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(331, 26)
        Me.TelefonoTextBox.TabIndex = 10
        '
        'IndirizzoTextBox
        '
        Me.IndirizzoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornitoriBindingSource, "Indirizzo", True))
        Me.IndirizzoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndirizzoTextBox.Location = New System.Drawing.Point(12, 90)
        Me.IndirizzoTextBox.MaxLength = 100
        Me.IndirizzoTextBox.Name = "IndirizzoTextBox"
        Me.IndirizzoTextBox.Size = New System.Drawing.Size(331, 26)
        Me.IndirizzoTextBox.TabIndex = 2
        '
        'txtCap
        '
        Me.txtCap.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornitoriBindingSource, "Cap", True))
        Me.txtCap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCap.Location = New System.Drawing.Point(349, 90)
        Me.txtCap.MaxLength = 10
        Me.txtCap.Name = "txtCap"
        Me.txtCap.Size = New System.Drawing.Size(58, 26)
        Me.txtCap.TabIndex = 3
        '
        'CittaTextBox
        '
        Me.CittaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornitoriBindingSource, "RifDoc", True))
        Me.CittaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CittaTextBox.Location = New System.Drawing.Point(349, 149)
        Me.CittaTextBox.MaxLength = 50
        Me.CittaTextBox.Name = "CittaTextBox"
        Me.CittaTextBox.Size = New System.Drawing.Size(180, 26)
        Me.CittaTextBox.TabIndex = 8
        '
        'txtDataRilascio
        '
        Me.txtDataRilascio.CustomFormat = "dd / MM / yyyy"
        Me.txtDataRilascio.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FornitoriBindingSource, "DataRilascio", True))
        Me.txtDataRilascio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataRilascio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDataRilascio.Location = New System.Drawing.Point(535, 149)
        Me.txtDataRilascio.Name = "txtDataRilascio"
        Me.txtDataRilascio.Size = New System.Drawing.Size(145, 26)
        Me.txtDataRilascio.TabIndex = 9
        Me.txtDataRilascio.Value = New Date(1900, 1, 1, 15, 17, 0, 0)
        '
        'txtDataNascita
        '
        Me.txtDataNascita.CustomFormat = "dd / MM / yyyy"
        Me.txtDataNascita.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FornitoriBindingSource, "DataNascita", True))
        Me.txtDataNascita.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataNascita.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDataNascita.Location = New System.Drawing.Point(12, 149)
        Me.txtDataNascita.Name = "txtDataNascita"
        Me.txtDataNascita.Size = New System.Drawing.Size(145, 26)
        Me.txtDataNascita.TabIndex = 6
        Me.txtDataNascita.Value = New Date(1900, 1, 1, 15, 17, 0, 0)
        '
        'NoteTextBox1
        '
        Me.NoteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornitoriBindingSource, "Note", True))
        Me.NoteTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoteTextBox1.Location = New System.Drawing.Point(12, 274)
        Me.NoteTextBox1.MaxLength = 1000
        Me.NoteTextBox1.Multiline = True
        Me.NoteTextBox1.Name = "NoteTextBox1"
        Me.NoteTextBox1.Size = New System.Drawing.Size(668, 120)
        Me.NoteTextBox1.TabIndex = 11
        '
        'cmbTipoDoc
        '
        Me.cmbTipoDoc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornitoriBindingSource, "TipoDoc", True))
        Me.cmbTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoDoc.FormattingEnabled = True
        Me.cmbTipoDoc.Items.AddRange(New Object() {"C.E.", "C.I.", "PASS.", "PAT.", "PORTO"})
        Me.cmbTipoDoc.Location = New System.Drawing.Point(251, 149)
        Me.cmbTipoDoc.MaxLength = 10
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.Size = New System.Drawing.Size(92, 28)
        Me.cmbTipoDoc.TabIndex = 7
        '
        'frmFornitore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 449)
        Me.Controls.Add(Me.cmbTipoDoc)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.NoteTextBox1)
        Me.Controls.Add(Me.txtDataNascita)
        Me.Controls.Add(Me.txtDataRilascio)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtCap)
        Me.Controls.Add(IndirizzoLabel)
        Me.Controls.Add(Me.IndirizzoTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(CittaLabel)
        Me.Controls.Add(Me.CittaTextBox)
        Me.Controls.Add(RifDocLabel)
        Me.Controls.Add(Me.RifDocTextBox)
        Me.Controls.Add(Me.ProvinciaTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(CognomeLabel)
        Me.Controls.Add(Me.CognomeTextBox)
        Me.Controls.Add(IDFornitoreLabel)
        Me.Controls.Add(Me.IDFornitoreTextBox)
        Me.KeyPreview = True
        Me.Name = "frmFornitore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchaser"
        Me.Controls.SetChildIndex(Me.IDFornitoreTextBox, 0)
        Me.Controls.SetChildIndex(IDFornitoreLabel, 0)
        Me.Controls.SetChildIndex(Me.CognomeTextBox, 0)
        Me.Controls.SetChildIndex(CognomeLabel, 0)
        Me.Controls.SetChildIndex(Me.NomeTextBox, 0)
        Me.Controls.SetChildIndex(NomeLabel, 0)
        Me.Controls.SetChildIndex(Me.ProvinciaTextBox, 0)
        Me.Controls.SetChildIndex(Me.RifDocTextBox, 0)
        Me.Controls.SetChildIndex(RifDocLabel, 0)
        Me.Controls.SetChildIndex(Me.CittaTextBox, 0)
        Me.Controls.SetChildIndex(CittaLabel, 0)
        Me.Controls.SetChildIndex(Me.TelefonoTextBox, 0)
        Me.Controls.SetChildIndex(TelefonoLabel, 0)
        Me.Controls.SetChildIndex(Me.IndirizzoTextBox, 0)
        Me.Controls.SetChildIndex(IndirizzoLabel, 0)
        Me.Controls.SetChildIndex(Me.txtCap, 0)
        Me.Controls.SetChildIndex(Label1, 0)
        Me.Controls.SetChildIndex(Label2, 0)
        Me.Controls.SetChildIndex(Label3, 0)
        Me.Controls.SetChildIndex(Me.cmdConferma, 0)
        Me.Controls.SetChildIndex(Me.txtDataRilascio, 0)
        Me.Controls.SetChildIndex(Me.txtDataNascita, 0)
        Me.Controls.SetChildIndex(Me.cmdAnnulla, 0)
        Me.Controls.SetChildIndex(Me.NoteTextBox1, 0)
        Me.Controls.SetChildIndex(Me.cmdElimina, 0)
        Me.Controls.SetChildIndex(Label4, 0)
        Me.Controls.SetChildIndex(Me.cmbTipoDoc, 0)
        CType(Me.FornitoriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FornitoriBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IDFornitoreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CognomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProvinciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RifDocTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IndirizzoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtCap As System.Windows.Forms.TextBox
    Friend WithEvents CittaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtDataRilascio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDataNascita As System.Windows.Forms.DateTimePicker
    Friend WithEvents NoteTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipoDoc As System.Windows.Forms.ComboBox
End Class
