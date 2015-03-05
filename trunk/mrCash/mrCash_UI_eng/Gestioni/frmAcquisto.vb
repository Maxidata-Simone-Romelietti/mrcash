Imports mrCash_DAL
Imports System.Linq
Imports System.Data.Objects.DataClasses

Public Class frmAcquisto

    Dim Dato As Acquisti
    Dim oggettiIniziali() As Oggetti
    Dim mem_PrzAcq As Decimal
    Dim Ordinatore As LinqEntityBinding(Of Oggetti)

    Protected Overrides Sub OP_LOAD()

        If ID = -1 Then
            Dato = New Acquisti
            context.AddToAcquisti(Dato)
        Else
            ' rileggo l' acquisto con inclusi gli oggetti
            Dim V = From Q As Acquisti In context.Acquisti.Include("Fornitori").Include("Oggetti") Where Q.IDAcquisto = ID
            Dato = V.First

        End If

        ' Ora di default
        If Dato.Data.Ticks = 0 Then _
           Dato.Data = Date.Now


        ' Propongo il numero di transazione
        If Dato.Transazione = 0 Then
            Dim N = From c As Acquisti In context.Acquisti Select c.Transazione
            If N.Count > 0 Then Dato.Transazione = N.Max
            Dato.Transazione += 1
        End If

        Ordinatore = New LinqEntityBinding(Of Oggetti)(context, Dato.Oggetti, Dato.Oggetti.OrderBy(Function(o) o.RigaAcquisto).ToList(), True)
        oggettiIniziali = Ordinatore.ToArray

        AcquistiBindingSource.DataSource = Dato
        OggettiBindingSource.DataSource = Ordinatore

        If Dato.Fornitori IsNot Nothing Then _
           FornitoriBindingSource.DataSource = Dato.Fornitori
    End Sub

    Protected Overrides Sub OP_ANNULLA()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Protected Overrides Sub OP_CONFERMA()

        If Not Salva() Then Exit Sub

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Protected Overrides Sub OP_ELIMINA()
        If Not ConfermaEliminazione("Confermi cancellazione di TUTTA la transazione ?") Then Exit Sub

        ' Cancello tutti gli oggetti
        For Each o As Oggetti In oggettiIniziali
            context.DeleteObject(o)
        Next

        ' cancello l'acquisto
        context.DeleteObject(Dato)
        context.SaveChanges()

        Me.DialogResult = Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub cmdRicerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRicerca.Click

        Using F As New frmRicercaFornitori
            F.Selezione = True

            If F.ShowDialog() = Windows.Forms.DialogResult.OK Then

                Dato.Fornitori _
                = (From c As Fornitori In context.Fornitori Where c.IDFornitore = F.IDFornitore Select c).First

                ' Visualizzo le note
                If Dato.Fornitori.Note.Trim <> "" Then MsgBox(Dato.Fornitori.Note)

                FornitoriBindingSource.DataSource = Dato.Fornitori

            End If

        End Using
    End Sub


    Private Sub OggettiDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles OggettiDataGridView.CellClick
        If e.RowIndex = -1 Or e.ColumnIndex = -1 Then Exit Sub

        ' Duplicazione della riga di vendita
        If OggettiDataGridView.Columns(e.ColumnIndex).Name.ToUpper = "COPIA" Then
            Dim S As String = InputBox("Quante copie della riga vuoi generare ?", "Generazione righe")
            Dim N As Integer = Integer.Parse("0" & S)


            Dim X As Oggetti _
            = DirectCast(OggettiDataGridView.Rows(e.RowIndex).DataBoundItem, Oggetti)


            For i As Integer = 1 To N
                Dim Y As Oggetti = New Oggetti
                Y.Descrizione = X.Descrizione
                Y.Modello = X.Modello
                Y.Serie = X.Serie
                Y.PrezzoAcquisto = X.PrezzoAcquisto
                Y.PrezzoStimato = X.PrezzoStimato

                Ordinatore.AddCorretto(Y)
            Next


            AggiornaTotale()
        End If
    End Sub

    Private Sub OggettiDataGridView_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles OggettiDataGridView.CellBeginEdit

        Dim X As Oggetti _
        = DirectCast(OggettiDataGridView.Rows(e.RowIndex).DataBoundItem, Oggetti)

        If OggettiDataGridView.Columns(e.ColumnIndex) Is PrezzoAcquisto Then mem_PrzAcq = X.PrezzoAcquisto

    End Sub

    Private Sub OggettiDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles OggettiDataGridView.CellEndEdit

        Dim X As Oggetti _
        = DirectCast(OggettiDataGridView.Rows(e.RowIndex).DataBoundItem, Oggetti)

        If OggettiDataGridView.Columns(e.ColumnIndex) Is PrezzoAcquisto Then

            If X.PrezzoAcquisto <> mem_PrzAcq Then X.PrezzoStimato = X.PrezzoAcquisto * 2

        ElseIf OggettiDataGridView.Columns(e.ColumnIndex) Is Codice Then

        End If

        AggiornaTotale()

    End Sub

    Private Sub OggettiDataGridView_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles OggettiDataGridView.CellFormatting

        Dim X As Oggetti _
        = DirectCast(OggettiDataGridView.Rows(e.RowIndex).DataBoundItem, Oggetti)

        If OggettiDataGridView.Columns(e.ColumnIndex) Is Codice Then _
            Tools.FormattoOggetti(context, X, sender, e)

    End Sub

    Private Sub cmdStampa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStampa.Click
        Stampa(Me.Dato)
    End Sub

    Private Sub OggettiDataGridView_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles OggettiDataGridView.CellValidating

        ' Evita il tentativo di push di un valore null nella entity
        Select Case OggettiDataGridView.Columns(e.ColumnIndex).DataPropertyName.ToUpper

            Case "DESCRIZIONE", "CODICE", "MODELLO", "SERIE"
                If CStr(e.FormattedValue) = "" Then _
                    OggettiDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""


        End Select

    End Sub

    Private Sub OggettiDataGridView_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles OggettiDataGridView.CellLeave
        AggiornaTotale()
    End Sub

    Private Sub OggettiDataGridView_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles OggettiDataGridView.RowsRemoved
        AggiornaTotale()
    End Sub

    Private Sub OggettiDataGridView_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles OggettiDataGridView.RowsAdded
        AggiornaTotale()
    End Sub

    ''' <summary>
    ''' Controllo che non ci siano codici doppi
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ConvalidaCodici() As Boolean
        Dim query = From o In Ordinatore Group o By o.Codice Into Count() Select Codice, Count

        Dim Doppi = From d In query Where d.Count > 1 And d.Codice.Trim <> "" Select d.Codice, d.Count

        Dim S As String = ""
        For Each x In Doppi
            S += vbCr + String.Format("{0}  ({1} volte)", x.Codice, x.Count)
        Next

        If Doppi.Count > 0 Then
            MsgBox("I seguenti codici compaiono ripetuti :" & S)
            Return False
        End If

        Return True
    End Function

    Private Sub FormattaCodici()

        ' formattazione a 5 cifre e rinumerazione
        Dim Riga As Integer
        For Each o As Oggetti In Ordinatore
            If o.Codice_Numerico > 0 Then o.Codice = o.Codice.ToCodice

            Riga += 1 : o.RigaAcquisto = Riga
        Next

    End Sub

    Public Sub AggiornaTotale()
        If Dato Is Nothing Then Exit Sub

        Dim T As Decimal
        Dim N As Integer
        For Each r As DataGridViewRow In OggettiDataGridView.Rows
            If CStr(r.Cells("DESCRIZIONE").Value) <> "" Then
                T += CDec(r.Cells("PrezzoAcquisto").Value)
                N += 1
            End If
        Next

        txtPezzi.Valore = N
        txtTotale.Valore = T
    End Sub

    Function Salva() As Boolean

        FormattaCodici()

        ' Fornitore obbligatorio
        If Dato.Fornitori Is Nothing Then
            cmdRicerca_Click(Me, EventArgs.Empty)
            Return False
        End If

        ' Codici Doppi
        If Not ConvalidaCodici() Then Return False


        Dim CodiciPresenti = From C As Oggetti In context.Oggetti Select C.IDOggetto, C.Codice


        ' DAti obbligatori
        Dim Valido As Boolean = True
        For Each o As Oggetti In Ordinatore

            Valido = Valido And (o.Descrizione.Trim <> "")
            If Not Valido Then
                MsgBox("Manca la descrizione per alcuni oggetti")
                Return False
            End If

            Valido = Valido And (o.PrezzoAcquisto <> 0)
            If Not Valido Then
                MsgBox("Manca il prezzo di acquisto per alcuni oggetti")
                Return False
            End If

            Dim X As Oggetti = o
            If X.Codice.Trim <> "" Then

                ' Oggetti con lo stesso codice mio ma che non sono il mio oggetto
                Dim Presenti _
                = From P In CodiciPresenti _
                Where P.IDOggetto <> X.IDOggetto _
                  And P.Codice = X.Codice

                If Presenti.Count > 0 Then
                    MsgBox("Il codice " & X.Codice & " è già presente in archivio.")
                    Return False
                End If

            End If
        Next




        ' cancella gli oggetti non più presenti
        For Each o As Oggetti In oggettiIniziali

            If Not Ordinatore.Contains(o) Then
                context.DeleteObject(o)
            End If

        Next
        context.SaveChanges()

        Return True
    End Function

    Private Sub Stampa(ByVal A As Acquisti)
        If Not Salva() Then Exit Sub

        Dim P As New mrCash_STAMPA.AcquistiPrinter(A)
        With PrintPreviewDialog1
            .Document = P.Documento
            .Width = Screen.PrimaryScreen.Bounds.Width
            .Height = Screen.PrimaryScreen.Bounds.Height
            .PrintPreviewControl.Zoom = 0.9
            .ShowDialog()
        End With

    End Sub

End Class