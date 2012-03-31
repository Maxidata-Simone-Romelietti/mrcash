Imports mrCash_DAL
Imports System.Drawing
Imports System.Drawing.Printing

Public Class AcquistiPrinter
    Inherits DocPrinter

    Const RighePrimaPagina As Integer = 10
    Const RighePagina As Integer = 30

    Dim PA As RectangleF = _Documento.DefaultPageSettings.PrintableArea
    Dim Totale As Decimal
    Dim _A As Acquisti

    Public Sub New(ByVal A As Acquisti)
        _A = A
    End Sub

    Protected Overrides Sub CostruisciPagina()
        If Pagina = 1 Then
            stampaPrimaPagina()
        Else
            stampaAltrePagine()
        End If

        If PagineTotali > 1 Then _
           dato("Pag. ", String.Format("{0}/{1}", Pagina, PagineTotali), CInt(PA.Width) - 100, CInt(PA.Height) - 60)
    End Sub

    Private Sub StampaPrimaPAgina()

        _Documento.PrinterSettings.Copies = 2

        Totale = 0

        Dim fTITOLO As New Font("Times New Roman", 16, FontStyle.Bold)
        scritta("MISTER CASH", fTITOLO, Brushes.Red, 110, 100)
        scritta("Il tuo usato ... rivalutato!", fTITOLO, Brushes.Red, 75, 130)

        Dim s As String _
        = "Via Palestrina, 22" & vbCrLf _
        & "20124 Milano" & vbCrLf _
        & "Tel. 02/6705661" & vbCrLf _
        & "P.IVA 11078500151"

        Dim fRS As New Font("Times New Roman", 9, FontStyle.Bold)
        scritta(s, fRS, Brushes.Black, 400, 100)

        dato("Trattativa N.", _A.Transazione.ToString, 600, 250)
        dato("Il giorno", _A.Data.ToString("dd/MM/yyyy"), 50, 250)
        dato("alle ore", _A.Data.ToString("HH:mm"), 300, 250)

        With _A.Fornitori
            dato("Io sottoscritto/a", .Cognome + " " + .Nome, 50, 280)
            dato("Domiciliato/a in", .Indirizzo, 50, 310)
            dato("C.A.P.", .Cap, 50, 340)
            dato("Città", .Citta, 200, 340)
            dato("Tipo Documento", .TipoDoc, 50, 370)
            dato("N°", .RifDoc, 300, 370)
            dato("Rilasciato il", .DataRilascio.ToString("dd/MM/yyyy"), 500, 370)
            dato("Data di nascita", .DataNascita.ToString("dd/MM/yyyy"), 50, 400)
            dato("Tel.", .Telefono, 400, 400)
        End With

        Dim auto As String _
        = "AUTOCERTIFICAZIONE:" _
        & vbCrLf & "Con la sottoscrizione del presente documento, sotto la mia responsabilità, dichiaro:"
        valore(auto, 50, 450)

        auto _
        = "- Che i beni sotto elencati e ceduti alla International View S.r.l., sono di mia proprietà e non sono soggetti a vincoli di nessun genere" _
        & vbCrLf & "- Di essere maggiorenne" _
        & vbCrLf & "- Di vendervi i beni sotto indicati, per il prezzo accanto riportato" _
        & vbCrLf & "- Che le informazioni fornite circa la natura e lo stato del bene, sono esaustive e veritiere" _
        & vbCrLf & "- Che i beni sono di provenienza legale" _
        & vbCrLf & "- Che ai sensi dell'art.10 della legge n°675 del 1996 sulla ""Tutela delle persone rispetto al trattamento dei dati" _
        & vbCrLf & "  personali"" e successive modifiche, sono stato informato sulla procedura riguardo la raccolta dei propri dati personali" _
        & vbCrLf _
        & vbCrLf & "Il cliente prende così atto che la raccolta dei suddetti dati è finalizzata all'unico scopo di ottemperare alle disposizioni" _
        & vbCrLf & "di legge (Testo Unico Leggi di Pubblica Sicurezza) che impongono la raccolta dei dati personali in occasione di" _
        & vbCrLf & "qualsiasi transazione avente ad oggetto la compravendita di beni usati."
        nome(auto, 50, 490)

        Dim Y As Integer = 670
        IntestaRighe(Y)
        StampaRighe(0, RighePrimaPagina - 1, Y)


    End Sub

    Private Sub StampaAltrePagine()
        Dim Y As Integer = 50
        Dim Ini As Integer = RighePrimaPagina + (Pagina - 2) * RighePagina
        Dim Fin As Integer = Ini + RighePagina - 1

        IntestaRighe(Y)
        StampaRighe(Ini, Fin, Y)
    End Sub

    Private Sub IntestaRighe(ByVal Y As Integer)
        nome("DESCRIZIONE", 50, Y)
        nome("MODELLO", 300, Y)
        nome("N. DI SERIE", 500, Y)
        nome("PREZZO", 650, Y, 100)

        gr.DrawLine(Pens.Black, 40, Y + 20, PA.X + PA.Width - 40, Y + 20)
    End Sub

    Private Sub StampaRighe(ByVal Da As Integer, ByVal A As Integer, ByRef Y As Integer)

        ' ciclo delle righe da stampare
        For i As Integer = Da To A

            If i <= (_A.Oggetti.Count - 1) Then
                Y += 30
                StampaRiga(_A.Oggetti(i), Y)
            End If

        Next

        ' Riga dei totali
        If A >= _A.Oggetti.Count - 1 Then StampaPiedeReport(Y)

    End Sub

    Private Sub StampaRiga(ByVal R As Oggetti, ByVal Y As Integer)
        valore(R.Descrizione, 50, Y)
        valore(R.Modello, 300, Y)
        valore(R.Serie, 500, Y)
        valore(R.PrezzoAcquisto.ToString("0.00"), 650, Y, 100)

        Totale += R.PrezzoAcquisto
    End Sub

    Private Sub StampaPiedeReport(ByVal Y As Integer)

        Y += 40
        gr.DrawLine(Pens.Black, 40, Y - 10, PA.X + PA.Width - 40, Y - 10)
        dato("Totale pezzi : ", _A.Oggetti.Count.ToString, 50, Y)
        valore(Totale.ToString("0.00"), 650, Y, 100)

        Y += 40
        nome("Ai sensi dell'Art.1342 2°comma del Codice Civile, dichiaro di aver letto ed accettato le relative clausole di compravendita.", 40, Y)

        Y += 60
        nome("(Firma del cliente)", 40, Y)
        gr.DrawLine(Pens.Black, 40, Y, 240, Y)

        nome("(Firma del supervisore)", 400, Y)
        gr.DrawLine(Pens.Black, 400, Y, 640, Y)

    End Sub

    Protected Overrides Function CalcolaPagineTotali() As Integer
        Dim P As Integer = 1

        If _A.Oggetti.Count > RighePrimaPagina Then _
           P += CInt(Math.Ceiling((_A.Oggetti.Count - RighePrimaPagina) / RighePagina))

        Return P
    End Function
End Class
