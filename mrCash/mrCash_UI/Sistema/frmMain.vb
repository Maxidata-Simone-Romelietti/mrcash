Imports mrCash_DAL
Imports System.IO
Imports System.Configuration

Public Class frmMain

    Private Autenticato As Boolean

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(0, 0)

        My.Application.ChangeUICulture("IT-it")
        My.Application.ChangeCulture("IT-it")
    End Sub
    Private Sub cmdAcquisto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcquisto.Click
        Using F As New frmRicercaAcquisti
            F.ShowDialog()
        End Using
    End Sub

    Private Sub cmdRicFor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRicFor.Click
        Using F As New frmRicercaFornitori
            F.ShowDialog()
        End Using
    End Sub

    Private Sub cmdProdotti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProdotti.Click
        Using F As New frmRicercaOggetti
            F.ShowDialog()
        End Using
    End Sub

    Private Sub cmdVendita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVendita.Click
        Using F As New frmRicercaVendite
            F.ShowDialog()
        End Using
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub cmdInventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInventario.Click
        creaTMP(False)
    End Sub

    Private Sub cmdResoconto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResoconto.Click
        creaTMP(True)
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If frmLogin.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub GeneraPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneraPasswordToolStripMenuItem.Click

        Dim F As New frmGeneraMD5
        F.ShowDialog()

    End Sub

    Private Sub ImportaAcquistiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportaAcquistiToolStripMenuItem.Click

        Dim F As New frmImportAcquisti
        F.ShowDialog()

    End Sub

    Private Sub ScansioniInventarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScansioniInventarioToolStripMenuItem.Click

        Dim F As New frmInventario
        F.Show()

    End Sub
End Class

