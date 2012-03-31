Public Class frmInventario
    Private CNTR As New Inventario_Controller

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdElabora.Click
        CNTR.DataScansioni = CDate(txtData.Value)
        CNTR.Carica()

        OggettiMancantiBindingSource.DataSource = CNTR.OggettiMancanti
        OggettiVendutiPresentiBindingSource.DataSource = CNTR.OggettiVendutiPresenti
        CodiciSconosciutiBindingSource.DataSource = CNTR.CodiciSconosciuti
    End Sub

    Private Sub frmInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtData.Value = Now
        lblPosto.Text = CNTR.Posto
    End Sub

End Class