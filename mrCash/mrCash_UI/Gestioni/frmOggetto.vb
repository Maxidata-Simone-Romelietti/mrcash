Imports mrCash_DAL
Imports System.Linq

Public Class frmOggetto

    Dim Dato As Oggetti

    Protected Overrides Sub OP_Load()
        ' Non si possono creare oggetti nuovi se non dagli acquisti
        'If Dato Is Nothing Then
        '    Dato = New Oggetti
        '    context.AddToOggetti(Dato)
        'End If

        Dim V = From Q In context.Oggetti Where Q.IDOggetto = ID
        Dato = V.First

        OggettiBindingSource.DataSource = Dato
    End Sub

    Protected Overrides Sub OP_ANNULLA()
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Protected Overrides Sub OP_CONFERMA()
        context.SaveChanges()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

End Class