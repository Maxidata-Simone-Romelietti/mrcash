Imports mrCash_DAL
Imports System.Linq
Imports System.Collections.ObjectModel

Public Class frmVendita

    Dim Dato As Vendite
    Dim Lista As New ObservableCollection(Of Oggetti)
    Dim MemTotale As Decimal

    Protected Overrides Sub OP_LOAD()

        Dato = (From Q As Vendite In context.Vendite.Include("Oggetti") _
                Where Q.Data = DataVendita).FirstOrDefault

        If Dato Is Nothing Then
            Dato = New Vendite With {.Data = DataVendita}
            context.Vendite.Add(Dato)
        End If

        If Dato.Data.Ticks = 0 Then _
           Dato.Data = Date.Now.Date

        Lista.Clear()
        For Each y In (From x In Dato.Oggetti).OrderBy(Function(o) o.RigaVendita).ToList
            Lista.Add(y)
        Next

        VenditeBindingSource.DataSource = Dato
        OggettiBindingSource.DataSource = Lista

        MemTotale = Dato.Totale
        AggiornaTotale()
    End Sub

    Protected Overrides Sub OP_KEYDOWN(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Me.ActiveControl Is txtCodice Then
            'non saltare
        Else
            MyBase.OP_KEYDOWN(Me, e)
        End If
    End Sub

    Protected Overrides Sub OP_ANNULLA()
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Protected Overrides Sub OP_CONFERMA()

        Dato.Data = Dato.Data.SenzaOra

        Dim Riga As Integer
        Dato.Oggetti.Clear()

        For Each o As Oggetti In Lista
            Riga += 1 : o.RigaVendita = Riga
            Dato.Oggetti.Add(o)
        Next
        context.SaveChanges()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Protected Overrides Sub OP_ELIMINA()
        If Not ConfermaEliminazione("Confermi cancellazione di TUTTA la vendita ?") Then Exit Sub

        context.Vendite.Remove(Dato)
        context.SaveChanges()

        Me.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub txtCodice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodice.KeyDown
        Dim S As String = txtCodice.Text.Trim
        If e.KeyData = Keys.Enter Then

            Try
                Dim N As Oggetti = Dato.TrovaCodice(context, txtCodice.Text.ToCodice)

                If N IsNot Nothing Then Lista.Add(N)

                AggiornaTotale()

                OggettiBindingSource.DataSource = Nothing
                OggettiBindingSource.DataSource = Lista

                With OggettiDataGridView
                    Dim lr = .Rows.GetLastRow(DataGridViewElementStates.None)
                    .CurrentCell = .Rows(lr).Cells("PrezzoVendita")
                    .Focus()
                End With

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            txtCodice.Text = ""

            e.Handled = True
        End If

    End Sub

    Public Sub AggiornaTotale()
        Dim tot = (From x In Lista Select x.PrezzoVendita).Sum
        txtTotale.Valore = tot
        txtParziale.Valore = tot - MemTotale
    End Sub

    Private Sub OggettiDataGridView_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles OggettiDataGridView.CellEndEdit
        AggiornaTotale()

        If OggettiDataGridView.Columns(e.ColumnIndex) Is PrezzoVendita Then txtCodice.Focus()
    End Sub

    Private Sub OggettiDataGridView_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles OggettiDataGridView.RowsRemoved
        AggiornaTotale()
    End Sub

    Private Sub FormattaCodici()

        ' formattazione a 5 cifre e rinumerazione
        Dim Riga As Integer
        For Each o As Oggetti In Lista
            Riga += 1 : o.RigaAcquisto = Riga
        Next

    End Sub

    Public Property DataVendita As Date = Now.Date

End Class

