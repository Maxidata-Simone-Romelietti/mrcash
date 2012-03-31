<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOggetto
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
        Dim Label7 As System.Windows.Forms.Label
        Me.CognomeTextBox1 = New System.Windows.Forms.TextBox
        Me.OggettiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New mrCash_UI.PrezzoTextBox
        Me.TextBox4 = New mrCash_UI.PrezzoTextBox
        Me.TextBox5 = New mrCash_UI.PrezzoTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtModello = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtSerie = New System.Windows.Forms.TextBox
        Me.DataDateTimePicker = New UltraDateTimePicker.UltraDateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New UltraDateTimePicker.UltraDateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New UltraDateTimePicker.UltraDateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.NoteTextBox1 = New System.Windows.Forms.TextBox
        Label7 = New System.Windows.Forms.Label
        CType(Me.OggettiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDateTimePicker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTimePicker2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdElimina
        '
        Me.cmdElimina.Location = New System.Drawing.Point(12, 370)
        Me.cmdElimina.Visible = False
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Location = New System.Drawing.Point(403, 370)
        '
        'cmdConferma
        '
        Me.cmdConferma.Location = New System.Drawing.Point(305, 370)
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(9, 247)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(43, 20)
        Label7.TabIndex = 44
        Label7.Text = "Note"
        '
        'CognomeTextBox1
        '
        Me.CognomeTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CognomeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OggettiBindingSource, "Descrizione", True))
        Me.CognomeTextBox1.Location = New System.Drawing.Point(93, 38)
        Me.CognomeTextBox1.Name = "CognomeTextBox1"
        Me.CognomeTextBox1.Size = New System.Drawing.Size(401, 20)
        Me.CognomeTextBox1.TabIndex = 1
        '
        'OggettiBindingSource
        '
        Me.OggettiBindingSource.DataSource = GetType(mrCash_DAL.Oggetti)
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OggettiBindingSource, "Codice", True))
        Me.TextBox1.Location = New System.Drawing.Point(93, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(112, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OggettiBindingSource, "IDOggetto", True))
        Me.TextBox2.Location = New System.Drawing.Point(451, 12)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(43, 20)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OggettiBindingSource, "PrezzoAcquisto", True))
        Me.TextBox3.Location = New System.Drawing.Point(81, 19)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(60, 20)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OggettiBindingSource, "PrezzoStimato", True))
        Me.TextBox4.Location = New System.Drawing.Point(81, 45)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(60, 20)
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OggettiBindingSource, "PrezzoVendita", True))
        Me.TextBox5.Location = New System.Drawing.Point(81, 71)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(60, 20)
        Me.TextBox5.TabIndex = 5
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Codice"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Descrizione"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(427, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Acquisto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Valutato"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Vendita reale"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Modello"
        '
        'txtModello
        '
        Me.txtModello.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OggettiBindingSource, "Modello", True))
        Me.txtModello.Location = New System.Drawing.Point(93, 64)
        Me.txtModello.Name = "txtModello"
        Me.txtModello.Size = New System.Drawing.Size(112, 20)
        Me.txtModello.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(322, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "N. di serie"
        '
        'txtSerie
        '
        Me.txtSerie.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSerie.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OggettiBindingSource, "Serie", True))
        Me.txtSerie.Location = New System.Drawing.Point(382, 64)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(112, 20)
        Me.txtSerie.TabIndex = 32
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.CustomFormat = "dd / MM / yyyy"
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OggettiBindingSource, "DataRientro", True))
        Me.DataDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DataDateTimePicker.Location = New System.Drawing.Point(81, 19)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(145, 26)
        Me.DataDateTimePicker.TabIndex = 34
        Me.DataDateTimePicker.Value = New Date(2010, 12, 5, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Rientro"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Riconsegna"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd / MM / yyyy"
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OggettiBindingSource, "DataRiconsegna", True))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(81, 51)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(145, 26)
        Me.DateTimePicker1.TabIndex = 37
        Me.DateTimePicker1.Value = New Date(2010, 12, 5, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 91)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Rottamazione"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd / MM / yyyy"
        Me.DateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OggettiBindingSource, "DataRottamazione", True))
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(81, 83)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(145, 26)
        Me.DateTimePicker2.TabIndex = 39
        Me.DateTimePicker2.Value = New Date(2010, 12, 5, 0, 0, 0, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(255, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 119)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(93, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(153, 104)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Prezzo"
        '
        'NoteTextBox1
        '
        Me.NoteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OggettiBindingSource, "Note", True))
        Me.NoteTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoteTextBox1.Location = New System.Drawing.Point(93, 244)
        Me.NoteTextBox1.Multiline = True
        Me.NoteTextBox1.Name = "NoteTextBox1"
        Me.NoteTextBox1.Size = New System.Drawing.Size(402, 120)
        Me.NoteTextBox1.TabIndex = 43
        '
        'frmOggetto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 417)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Me.NoteTextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtModello)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CognomeTextBox1)
        Me.KeyPreview = True
        Me.Name = "frmOggetto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Oggetto"
        Me.Controls.SetChildIndex(Me.CognomeTextBox1, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.TextBox2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtModello, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.txtSerie, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.cmdConferma, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.cmdAnnulla, 0)
        Me.Controls.SetChildIndex(Me.NoteTextBox1, 0)
        Me.Controls.SetChildIndex(Me.cmdElimina, 0)
        Me.Controls.SetChildIndex(Label7, 0)
        CType(Me.OggettiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDateTimePicker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTimePicker2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CognomeTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As PrezzoTextBox
    Friend WithEvents TextBox4 As PrezzoTextBox
    Friend WithEvents TextBox5 As PrezzoTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents OggettiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtModello As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents DataDateTimePicker As UltraDateTimePicker.UltraDateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As UltraDateTimePicker.UltraDateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As UltraDateTimePicker.UltraDateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents NoteTextBox1 As System.Windows.Forms.TextBox
End Class
