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
        Using F As New frmVendita
            F.ShowDialog()
        End Using
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub cmdInventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInventario.Click
        'creaTMP(False)

        Dim f = New frmChiediData
        f.ShowDialog()
        CreaCSV(f.DataDateTimePicker.Value)
    End Sub

    Private Sub cmdResoconto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResoconto.Click
        creaTMP(True)
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If frmLogin.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using F As New frmRicercaVendite2
            F.ShowDialog()
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using F As New frmAcquisto
            F.ShowDialog()
        End Using
    End Sub

    Public Shared Function CodiciMancanti() As String
        ' Oggetti senza codice
        Using c = MRCashEntities.Create

            Dim TransazioniConCodiciMancanti = From o In c.Oggetti.Include("Acquisti") Where o.Codice = "" Select o.Acquisti
            Dim Distinti = (From x In TransazioniConCodiciMancanti Select CStr(x.Transazione)).Distinct

            Dim s = ""

            If Distinti.Count > 0 Then
                s = "Transazioni in cui mancano dei codici : " & String.Join(" ", Distinti.ToArray)
            End If

            Return s
        End Using
    End Function

    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        lblWarning.Text = CodiciMancanti()
    End Sub

    Private Sub CreaCSV(DataLimite As DateTime)
        Using c = MRCashEntities.Create

            Dim o1 = (From x In c.Oggetti.Include("Acquisti").Include("Vendite")).ToList

            Dim o = (From x In o1 Where x.DataRottamazione Is Nothing _
                                    And (x.Vendita_Data = Nothing Or x.Vendita_Data >= DataLimite) _
                                    And (x.Acquisti.Data <= DataLimite)
                                      ).ToList

            Dim sb As New System.Text.StringBuilder
            Dim l As New List(Of String)

            l.Add("Data")
            l.Add("Prezzo")
            l.Add("Codice")
            l.Add("Oggetto")
            sb.AppendLine(CreateCSVRow(l))

            For Each x In o
                l.Clear()
                l.Add(x.Acquisti.Data.ToString("dd/MM/yyyy"))
                l.Add(x.PrezzoAcquisto.ToString)
                l.Add(x.Codice)
                l.Add(x.Descrizione)


                sb.AppendLine(CreateCSVRow(l))
            Next

            Dim NomeFile = System.IO.Path.GetTempFileName().Replace(".tmp", ".csv")
            My.Computer.FileSystem.WriteAllText(NomeFile, sb.ToString, False, System.Text.Encoding.Default)
            Process.Start(NomeFile)
        End Using
    End Sub

    Function CreateCSVRow(strArray As List(Of String)) As String
        Const Separator = ";"c
        Dim csvCols As New List(Of String)
        Dim csvValue As String
        Dim needQuotes As Boolean
        For i As Integer = 0 To strArray.Count() - 1
            csvValue = strArray(i)
            needQuotes = (csvValue.IndexOf(",", StringComparison.InvariantCulture) >= 0 _
                          OrElse csvValue.IndexOf("""", StringComparison.InvariantCulture) >= 0 _
                          OrElse csvValue.IndexOf(vbCrLf, StringComparison.InvariantCulture) >= 0)
            csvValue = csvValue.Replace("""", """""")
            csvCols.Add(If(needQuotes, """" & csvValue & """", csvValue))
        Next
        Return String.Join(Separator, csvCols.ToArray())
    End Function

End Class

