Public Class frmTotAcq

    Private Sub frmTotAcq_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Using context = New mrCash_DAL.MRCashEntities(ContextConnectionString)
            Dim dati = From x In context.Acquisti
                   Group By x.Data _
                   Into TotaleGiornaliero = Sum(x.Totale)
                   Select Data, TotaleGiornaliero
            TotaliDataGridView.DataSource = dati
        End Using

    End Sub
End Class