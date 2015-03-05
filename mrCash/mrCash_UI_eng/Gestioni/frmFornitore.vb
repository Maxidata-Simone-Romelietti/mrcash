Imports mrCash_DAL

Public Class frmFornitore

    Dim Dato As Fornitori

    Protected Overrides Sub OP_LOAD()

        If ID = -1 Then
            Dato = New Fornitori
            context.AddToFornitori(Dato)

            Dato.TipoDoc = "C.I."
        Else
            ' rileggo la vendita con inclusi gli oggetti
            Dim V = From Q In context.Fornitori Where Q.IDFornitore = ID
            Dato = V.First

        End If

        FornitoriBindingSource.DataSource = Dato
    End Sub

    Protected Overrides Sub OP_ANNULLA()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Protected Overrides Sub OP_CONFERMA()
        context.SaveChanges()

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Protected Overrides Sub OP_ELIMINA()
        If Not ConfermaEliminazione("Confermi cancellazione del fornitore ?") Then Exit Sub

        context.DeleteObject(Dato)
        Try
            context.SaveChanges()
            Me.DialogResult = Windows.Forms.DialogResult.No
            Me.Close()

        Catch ex As UpdateException
            MsgBox("Problemi incontrati durante la cancellazione." & vbCrLf & " Verificare che il fornitore non sia usato in alcun acquisto.", MsgBoxStyle.Exclamation)

        End Try
    End Sub

    Public ReadOnly Property IDFornitoreScelto() As Integer
        Get
            Return Dato.IDFornitore
        End Get
    End Property

End Class