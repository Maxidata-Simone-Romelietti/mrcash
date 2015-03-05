<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRicerca_Base
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
        Me.cmdNuovo = New System.Windows.Forms.Button()
        Me.cmdRicerca = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdNuovo
        '
        Me.cmdNuovo.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdNuovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuovo.Location = New System.Drawing.Point(608, 0)
        Me.cmdNuovo.Name = "cmdNuovo"
        Me.cmdNuovo.Size = New System.Drawing.Size(92, 42)
        Me.cmdNuovo.TabIndex = 4
        Me.cmdNuovo.Text = "New"
        Me.cmdNuovo.UseVisualStyleBackColor = True
        '
        'cmdRicerca
        '
        Me.cmdRicerca.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdRicerca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRicerca.Location = New System.Drawing.Point(700, 0)
        Me.cmdRicerca.Name = "cmdRicerca"
        Me.cmdRicerca.Size = New System.Drawing.Size(92, 42)
        Me.cmdRicerca.TabIndex = 18
        Me.cmdRicerca.Text = "Search"
        Me.cmdRicerca.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdNuovo)
        Me.Panel1.Controls.Add(Me.cmdRicerca)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(792, 42)
        Me.Panel1.TabIndex = 19
        '
        'frmRicerca_Base
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmRicerca_Base"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdNuovo As System.Windows.Forms.Button
    Friend WithEvents cmdRicerca As System.Windows.Forms.Button
    Public WithEvents Panel1 As System.Windows.Forms.Panel
End Class
