Imports mrCash_DAL

Public Class frmImportAcquisti

    Dim IMPO As New Data.Importatore

    Private Sub frmImportAcquisti_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SelezioniBindingSource.DataSource = IMPO.Selezioni
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If MsgBox("Conferma importazione acquisti ?", MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Attenzione") <> MsgBoxResult.Yes Then Exit Sub

        Try
            IMPO.Importa_Acquisti(ContextConnectionString)
            MsgBox("Importazione terminata.  Oggetti importati " & IMPO.NumeroOggettiImportati.ToString)

        Catch ex As Exception
            MsgBox("Problemi di importazione : " & ex.Message)

        End Try

    End Sub


End Class