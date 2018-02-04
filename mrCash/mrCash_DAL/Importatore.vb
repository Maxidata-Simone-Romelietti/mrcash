Imports mrCash_DAL
Imports System.Globalization

Namespace Data

    Public Class Importatore

        Dim CodiceCercato As String

        Private _Selezioni As New Selezioni
        Public Property Selezioni() As Selezioni
            Get
                Return _Selezioni
            End Get
            Set(ByVal value As Selezioni)
                _Selezioni = value
            End Set
        End Property

        Private _NumeroOggettiImportati As Integer
        Public ReadOnly Property NumeroOggettiImportati() As Integer
            Get
                Return _NumeroOggettiImportati
            End Get
        End Property

        Public Sub Importa_Acquisti(ByVal ContextConnectionString As String)
            Dim P() As String
            Dim SbErr As New System.Text.StringBuilder
            Dim culture = New CultureInfo(Selezioni.CulturaDate, True)

            _NumeroOggettiImportati = 0
            Using context As New MRCashEntities()

                Dim F_For As String = My.Computer.FileSystem.ReadAllText("c:\Importatore\Fornitori.txt").Replace(vbLf, "")
                Dim P_For() As String = F_For.Split(ControlChars.Cr)
                For Each r As String In P_For

                    If r <> "" Then
                        P = r.Split(ControlChars.Tab)
                        Dim N As New Fornitori
                        Try

                            N.Cognome = Left(P(1), 50)
                            N.Nome = Mid(P(1), 50)
                            N.Indirizzo = P(2)
                            N.Cap = P(3)
                            N.Citta = P(4)
                            DateTime.TryParse(P(5), culture, DateTimeStyles.None, N.DataNascita)
                            N.Telefono = P(6)
                            N.TipoDoc = Left(P(7), 10)
                            N.RifDoc = P(8)
                            DateTime.TryParse(P(9), culture, DateTimeStyles.None, N.DataRilascio)
                            N.Note = CInt(P(0).Trim).ToString

                            If N.DataNascita.Date.Year <= 1800 Then N.DataNascita = New DateTime(1900, 1, 1)
                            If N.DataRilascio.Date.Year <= 1800 Then N.DataRilascio = New DateTime(1900, 1, 1)

                            If N.DataNascita.Year = 1900 Or N.DataRilascio.Year = 1900 Then
                                SbErr.AppendLine(P(1))
                            End If
                            context.Fornitori.Add(N)
                            context.SaveChanges()

                        Catch ex As Exception
                            MsgBox(ex.Message & " - " & P(1))

                        End Try
                    End If

                Next

            End Using

            My.Computer.FileSystem.WriteAllText("c:\Importatore\Errori.txt", SbErr.ToString, False)


            Dim F_Ogg As String = My.Computer.FileSystem.ReadAllText("c:\Importatore\Oggetti.txt").Replace(vbLf, "")
            Dim P_Ogg() As String = F_Ogg.Split(ControlChars.Cr)

            Dim L_Ogg As New List(Of Integer)
            For Each r As String In P_Ogg
                If r <> "" Then L_Ogg.Add(Integer.Parse("0" & r))
            Next


            Dim F_Des As String = My.Computer.FileSystem.ReadAllText("c:\Importatore\Descrizioni.txt").Replace(vbLf, "")
            Dim P_Des() As String = F_Des.Split(ControlChars.Cr)

            Dim L_Des As New List(Of RigaDescrizione)
            For Each r As String In P_Des

                If r <> "" Then
                    P = r.Split(ControlChars.Tab)

                    Dim N As New RigaDescrizione
                    If P(0).Trim <> "" And Integer.TryParse(P(0), 0) Then
                        N.Codice = Integer.Parse("0" & P(0))
                        N.Descrizione = P(1)
                        N.Modello = P(2)
                        N.Serie = P(3)
                        N.PrezzoAcquisto = ParsaPrezzo(P(4))
                        N.Note = P(5)
                        N.Transazione = Integer.Parse("0" & P(6))
                        DateTime.TryParse(P(7), culture, DateTimeStyles.None, N.DataAcquisto)
                        N.IDFornitore = Integer.Parse(P(8))

                        L_Des.Add(N)
                    End If
                End If

            Next

            ' Ordino i prodotti per numero di transazione
            L_Des.Sort()

            Dim Scaricati As New List(Of Oggetti)

            Dim PrevTransazione As Integer = Integer.MinValue
            Dim AcqCorrente As Acquisti = Nothing

            Using context As New MRCashEntities()

                Dim NEGO = (From c As Fornitori In context.Fornitori Where c.IDFornitore = Selezioni.IDFornitoreAssoluto Select c).FirstOrDefault

                ' Carica il fornitore che va su tutti gli acquisti

                For Each Des In L_Des

                    If Des.Transazione <> PrevTransazione Then

                        Dim IDFor As String = Des.IDFornitore.ToString

                        Dim Fornitore As Fornitori _
                        = (From c As Fornitori In context.Fornitori Where c.Note = IDFor Select c).FirstOrDefault

                        If Fornitore Is Nothing Then Fornitore = NEGO

                        PrevTransazione = Des.Transazione

                        AcqCorrente = New Acquisti
                        AcqCorrente.Data = Des.DataAcquisto
                        AcqCorrente.Transazione = -Des.Transazione
                        AcqCorrente.Fornitori = Fornitore
                        context.Acquisti.Add(AcqCorrente)

                    End If


                    Dim X As Oggetti = New Oggetti
                    X.Codice = Des.Codice.ToString("00000")
                    X.PrezzoAcquisto = Des.PrezzoAcquisto
                    X.PrezzoStimato = Des.PrezzoAcquisto * 2
                    X.PrezzoVendita = 0
                    X.Descrizione = Des.Descrizione
                    X.Serie = Des.Serie
                    X.Modello = Des.Modello
                    X.Note = Des.Note

                    AcqCorrente.Oggetti.Add(X)

                    Try
                        context.SaveChanges()
                        _NumeroOggettiImportati += 1

                    Catch ex As Exception
                        MsgBox(ex.Message & " : " & X.IDOggetto & " " & AcqCorrente.Data.ToString("dd/MM/yyyy"))
                        DirectCast(context, System.Data.Entity.Infrastructure.IObjectContextAdapter).ObjectContext.DeleteObject(X)
                        context.SaveChanges()

                    End Try

                    ' salta gli oggetti che non sono in magazzino
                    If Not L_Ogg.Contains(Des.Codice) Then Scaricati.Add(X)

                Next

                ' Scarico finale degli oggetti non più in magazzino
                Dim Scarico As New Vendite
                context.Vendite.Add(Scarico)

                Scarico.Data = New DateTime(2010, 12, 31)
                For Each x As Oggetti In Scaricati
                    Scarico.Oggetti.Add(x)
                Next
                context.SaveChanges()

            End Using

        End Sub

        Private Function ParsaPrezzo(ByVal S As String) As Decimal
            Dim nInfo As NumberFormatInfo = DirectCast(CultureInfo.CurrentCulture.NumberFormat.Clone, NumberFormatInfo)
            nInfo.NumberDecimalSeparator = ","
            S = S.Replace(".", ",")
            Return Decimal.Parse(S, nInfo)
        End Function

        Public Class RigaDescrizione
            Implements IComparable

            Public Codice As Integer

            Public Descrizione As String = "-"

            Public Serie As String = "-"

            Public Modello As String = "-"

            Public Note As String = ""

            Public Transazione As Integer

            Public IDFornitore As Integer

            Public PrezzoAcquisto As Decimal

            Public DataAcquisto As New DateTime

            Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
                If Not TypeOf (obj) Is RigaDescrizione Then Return -1

                With DirectCast(obj, RigaDescrizione)

                    If Me.Transazione < .Transazione Then Return -1
                    If Me.Transazione > .Transazione Then Return 1

                    If Me.Codice < .Codice Then Return -1
                    If Me.Codice > .Codice Then Return 1

                End With

            End Function

        End Class

    End Class

    Public Class Selezioni

        Private _Cultura As String = "it-IT"
        Public Property CulturaDate() As String
            Get
                Return _Cultura
            End Get
            Set(ByVal value As String)
                _Cultura = value
            End Set
        End Property

        Private _IDFornitoreAssoluto As Integer = 2
        Public Property IDFornitoreAssoluto() As Integer
            Get
                Return _IDFornitoreAssoluto
            End Get
            Set(ByVal value As Integer)
                _IDFornitoreAssoluto = value
            End Set
        End Property

    End Class

End Namespace