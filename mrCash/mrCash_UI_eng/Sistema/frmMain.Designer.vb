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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAcquisto
        '
        Me.cmdAcquisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAcquisto.Location = New System.Drawing.Point(12, 182)
        Me.cmdAcquisto.Name = "cmdAcquisto"
        Me.cmdAcquisto.Size = New System.Drawing.Size(230, 39)
        Me.cmdAcquisto.TabIndex = 0
        Me.cmdAcquisto.Text = "PURCHASING"
        Me.cmdAcquisto.UseVisualStyleBackColor = True
        '
        'cmdVendita
        '
        Me.cmdVendita.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVendita.Location = New System.Drawing.Point(248, 12)
        Me.cmdVendita.Name = "cmdVendita"
        Me.cmdVendita.Size = New System.Drawing.Size(230, 113)
        Me.cmdVendita.TabIndex = 1
        Me.cmdVendita.Text = "SELLING"
        Me.cmdVendita.UseVisualStyleBackColor = True
        '
        'cmdResoconto
        '
        Me.cmdResoconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResoconto.Location = New System.Drawing.Point(248, 370)
        Me.cmdResoconto.Name = "cmdResoconto"
        Me.cmdResoconto.Size = New System.Drawing.Size(230, 39)
        Me.cmdResoconto.TabIndex = 2
        Me.cmdResoconto.Text = "REPORT"
        Me.cmdResoconto.UseVisualStyleBackColor = True
        '
        'cmdInventario
        '
        Me.cmdInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInventario.Location = New System.Drawing.Point(12, 370)
        Me.cmdInventario.Name = "cmdInventario"
        Me.cmdInventario.Size = New System.Drawing.Size(230, 39)
        Me.cmdInventario.TabIndex = 3
        Me.cmdInventario.Text = "INVENTORY"
        Me.cmdInventario.UseVisualStyleBackColor = True
        '
        'cmdProdotti
        '
        Me.cmdProdotti.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProdotti.Location = New System.Drawing.Point(12, 274)
        Me.cmdProdotti.Name = "cmdProdotti"
        Me.cmdProdotti.Size = New System.Drawing.Size(230, 39)
        Me.cmdProdotti.TabIndex = 4
        Me.cmdProdotti.Text = "OBJECTS"
        Me.cmdProdotti.UseVisualStyleBackColor = True
        '
        'cmdRicFor
        '
        Me.cmdRicFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRicFor.Location = New System.Drawing.Point(248, 274)
        Me.cmdRicFor.Name = "cmdRicFor"
        Me.cmdRicFor.Size = New System.Drawing.Size(230, 39)
        Me.cmdRicFor.TabIndex = 5
        Me.cmdRicFor.Text = "SUPPLIERS"
        Me.cmdRicFor.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 457)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(466, 39)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "QUIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 526)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(489, 25)
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
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 22)
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
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(248, 182)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(230, 39)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "SELLING"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 347)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(466, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "FINE MESE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(466, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ARCHIVES"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(466, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "HISTORICAL ARCHIVES"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(12, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(230, 113)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "PURCHASING"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 551)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
        Me.Text = "WELCOME in MR. CASH"
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
