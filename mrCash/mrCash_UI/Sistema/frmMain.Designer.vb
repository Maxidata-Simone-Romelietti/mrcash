<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cmdAcquisto = New System.Windows.Forms.Button()
        Me.cmdVendita = New System.Windows.Forms.Button()
        Me.cmdResoconto = New System.Windows.Forms.Button()
        Me.cmdInventario = New System.Windows.Forms.Button()
        Me.cmdProdotti = New System.Windows.Forms.Button()
        Me.cmdRicFor = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ScansioniInventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneraPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportaAcquistiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAcquisto
        '
        Me.cmdAcquisto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAcquisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAcquisto.Location = New System.Drawing.Point(12, 0)
        Me.cmdAcquisto.Name = "cmdAcquisto"
        Me.cmdAcquisto.Size = New System.Drawing.Size(106, 68)
        Me.cmdAcquisto.TabIndex = 0
        Me.cmdAcquisto.Text = "ACQUISTI"
        Me.cmdAcquisto.UseVisualStyleBackColor = True
        '
        'cmdVendita
        '
        Me.cmdVendita.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdVendita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVendita.Location = New System.Drawing.Point(124, 0)
        Me.cmdVendita.Name = "cmdVendita"
        Me.cmdVendita.Size = New System.Drawing.Size(106, 68)
        Me.cmdVendita.TabIndex = 1
        Me.cmdVendita.Text = "VENDITE"
        Me.cmdVendita.UseVisualStyleBackColor = True
        '
        'cmdResoconto
        '
        Me.cmdResoconto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdResoconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResoconto.Location = New System.Drawing.Point(683, 0)
        Me.cmdResoconto.Name = "cmdResoconto"
        Me.cmdResoconto.Size = New System.Drawing.Size(106, 68)
        Me.cmdResoconto.TabIndex = 2
        Me.cmdResoconto.Text = "RESOCONTO"
        Me.cmdResoconto.UseVisualStyleBackColor = True
        '
        'cmdInventario
        '
        Me.cmdInventario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInventario.Location = New System.Drawing.Point(571, 0)
        Me.cmdInventario.Name = "cmdInventario"
        Me.cmdInventario.Size = New System.Drawing.Size(106, 68)
        Me.cmdInventario.TabIndex = 3
        Me.cmdInventario.Text = "INVENTARIO"
        Me.cmdInventario.UseVisualStyleBackColor = True
        '
        'cmdProdotti
        '
        Me.cmdProdotti.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.cmdProdotti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProdotti.Location = New System.Drawing.Point(290, 0)
        Me.cmdProdotti.Name = "cmdProdotti"
        Me.cmdProdotti.Size = New System.Drawing.Size(106, 68)
        Me.cmdProdotti.TabIndex = 4
        Me.cmdProdotti.Text = "OGGETTI"
        Me.cmdProdotti.UseVisualStyleBackColor = True
        '
        'cmdRicFor
        '
        Me.cmdRicFor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.cmdRicFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRicFor.Location = New System.Drawing.Point(402, 0)
        Me.cmdRicFor.Name = "cmdRicFor"
        Me.cmdRicFor.Size = New System.Drawing.Size(106, 68)
        Me.cmdRicFor.TabIndex = 5
        Me.cmdRicFor.Text = "FORNITORI"
        Me.cmdRicFor.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(795, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 68)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "CHIUDI"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(903, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(30, 68)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScansioniInventarioToolStripMenuItem, Me.ToolStripMenuItem2, Me.GeneraPasswordToolStripMenuItem, Me.ImportaAcquistiToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(27, 20)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'ScansioniInventarioToolStripMenuItem
        '
        Me.ScansioniInventarioToolStripMenuItem.Name = "ScansioniInventarioToolStripMenuItem"
        Me.ScansioniInventarioToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ScansioniInventarioToolStripMenuItem.Text = "Scansioni Inventario"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(219, 22)
        Me.ToolStripMenuItem2.Text = "-----------------------------"
        '
        'GeneraPasswordToolStripMenuItem
        '
        Me.GeneraPasswordToolStripMenuItem.Name = "GeneraPasswordToolStripMenuItem"
        Me.GeneraPasswordToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.GeneraPasswordToolStripMenuItem.Text = "Genera Password"
        '
        'ImportaAcquistiToolStripMenuItem
        '
        Me.ImportaAcquistiToolStripMenuItem.Name = "ImportaAcquistiToolStripMenuItem"
        Me.ImportaAcquistiToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ImportaAcquistiToolStripMenuItem.Text = "Importa Acquisti"
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(236, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 68)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "VENDITE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 68)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdRicFor)
        Me.Controls.Add(Me.cmdProdotti)
        Me.Controls.Add(Me.cmdInventario)
        Me.Controls.Add(Me.cmdResoconto)
        Me.Controls.Add(Me.cmdVendita)
        Me.Controls.Add(Me.cmdAcquisto)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Mr. Cash"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAcquisto As System.Windows.Forms.Button
    Friend WithEvents cmdVendita As System.Windows.Forms.Button
    Friend WithEvents cmdResoconto As System.Windows.Forms.Button
    Friend WithEvents cmdInventario As System.Windows.Forms.Button
    Friend WithEvents cmdProdotti As System.Windows.Forms.Button
    Friend WithEvents cmdRicFor As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents GeneraPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportaAcquistiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScansioniInventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
