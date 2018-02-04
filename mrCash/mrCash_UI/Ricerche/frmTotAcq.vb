Public Class frmTotAcq

    Private Sub frmTotAcq_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Using context = New mrCash_DAL.MRCashEntities()
            Dim dati = (From x In context.V_AcquistiGiornalieri Order By x.Data Descending).ToList
            TotaliDataGridView.DataSource = dati
        End Using

    End Sub
End Class