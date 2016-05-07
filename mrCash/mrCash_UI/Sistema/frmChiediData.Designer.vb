<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChiediData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataLabel As System.Windows.Forms.Label
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        DataLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataLabel.Location = New System.Drawing.Point(6, 12)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(48, 20)
        DataLabel.TabIndex = 3
        DataLabel.Text = "Data:"
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.CustomFormat = "dd / MM / yyyy"
        Me.DataDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DataDateTimePicker.Location = New System.Drawing.Point(60, 12)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(183, 26)
        Me.DataDateTimePicker.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 42)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmChiediData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 111)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(DataLabel)
        Me.Controls.Add(Me.DataDateTimePicker)
        Me.Name = "frmChiediData"
        Me.Text = "Data inventario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataDateTimePicker As DateTimePicker
    Friend WithEvents Button1 As Button
End Class
