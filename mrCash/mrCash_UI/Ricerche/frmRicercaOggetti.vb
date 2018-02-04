Imports mrCash_DAL

Public Class frmRicercaOggetti

    Private _IDOggetto As Integer
    Public Property IDOggetto() As Integer
        Get
            Return _IDOggetto
        End Get
        Set(ByVal value As Integer)
            _IDOggetto = value
        End Set
    End Property

    Protected Overrides Function OP_Ricerca() As Boolean
        Dim qry = From f As Oggetti In context.Oggetti.Include("Vendite").Include("Acquisti") Select f

        Select Case cmbStatus_Value
            Case EnumStatus.Tutti
                ' NOP 

            Case EnumStatus.Rottamati
                qry = qry.Where(Function(s) s.DataRottamazione IsNot Nothing)

            Case EnumStatus.Disponibili
                qry = qry.Where(Function(s) s.DataRottamazione Is Nothing _
                                        And s.Vendite Is Nothing)

            Case EnumStatus.Venduti
                qry = qry.Where(Function(s) s.DataRottamazione Is Nothing _
                                        And s.Vendite IsNot Nothing)

            Case EnumStatus.Rientrati
                qry = qry.Where(Function(s) s.DataRottamazione Is Nothing _
                                        And s.DataRientro IsNot Nothing _
                                        And s.DataRiconsegna Is Nothing)

            Case EnumStatus.Riconsegnati
                qry = qry.Where(Function(s) s.DataRottamazione Is Nothing _
                                        And s.DataRientro IsNot Nothing _
                                        And s.DataRiconsegna IsNot Nothing)


        End Select

        If DescrizioneTextBox.Text <> "" Then _
           qry = qry.Where(Function(s) s.Descrizione.Contains(DescrizioneTextBox.Text))

        If txtSeriale.Text <> "" Then _
           qry = qry.Where(Function(s) s.Serie.Contains(txtSeriale.Text))

        If txtModello.Text <> "" Then _
           qry = qry.Where(Function(s) s.Modello.Contains(txtModello.Text))

        If OggettoTextBox1.Text <> "" Then
            Dim c As String = OggettoTextBox1.Text.ToCodice
            qry = qry.Where(Function(s) s.Codice = c)
        End If

        Dim N As String = _ColonnaOrdinante.ToUpper
        If N = "CODICE" And _Inversione Then qry = From z In qry Order By z.Codice Descending
        If N = "CODICE" And Not _Inversione Then qry = From z In qry Order By z.Codice Ascending

        If N = "DESCRIZIONE" And _Inversione Then qry = From z In qry Order By z.Descrizione Descending
        If N = "DESCRIZIONE" And Not _Inversione Then qry = From z In qry Order By z.Descrizione Ascending

        If N = "SERIE" And _Inversione Then qry = From z In qry Order By z.Serie Descending
        If N = "SERIE" And Not _Inversione Then qry = From z In qry Order By z.Serie Ascending

        If N = "MODELLO" And _Inversione Then qry = From z In qry Order By z.Modello Descending
        If N = "MODELLO" And Not _Inversione Then qry = From z In qry Order By z.Modello Ascending

        If N = "PREZZOACQUISTO" And _Inversione Then qry = From z In qry Order By z.PrezzoAcquisto Descending
        If N = "PREZZOACQUISTO" And Not _Inversione Then qry = From z In qry Order By z.PrezzoAcquisto Ascending

        If N = "PREZZOVENDITA" And _Inversione Then qry = From z In qry Order By z.PrezzoVendita Descending
        If N = "PREZZOVENDITA" And Not _Inversione Then qry = From z In qry Order By z.PrezzoVendita Ascending

        If N = "PREZZOSTIMATO" And _Inversione Then qry = From z In qry Order By z.PrezzoStimato Descending
        If N = "PREZZOSTIMATO" And Not _Inversione Then qry = From z In qry Order By z.PrezzoStimato Ascending

        OggettiBindingSource.DataSource = qry.ToList
    End Function


    Private Sub OggettiDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles OggettiDataGridView.CellDoubleClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

        Dim X As Oggetti _
        = DirectCast(OggettiDataGridView.Rows(e.RowIndex).DataBoundItem, Oggetti)

        If Selezione Then
            _IDOggetto = X.IDOggetto
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
            Exit Sub
        End If

        ModificaRecord(X)

    End Sub

    Protected Overrides Function OP_Nuovo() As Boolean
        ' non si possono creare oggetti nuovi senza un'acquisto
        ' ModificaRecord(Nothing)
    End Function

    Private Sub cmbStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStatus.SelectedIndexChanged
        OP_Ricerca()
    End Sub

    Private Sub ModificaRecord(ByVal R As Oggetti)

        Using F As New frmOggetto

            F.ID = -1 : If R IsNot Nothing Then F.ID = R.IDOggetto

            Me.Visible = False
            F.ShowDialog()
            Me.Visible = True

            OP_Ricerca()

        End Using

    End Sub

    Private Sub frmRicercaOggetti_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmdNuovo.Visible = False

        cmbStatus.DataSource = [Enum].GetValues(GetType(EnumStatus))
        cmbStatus.SelectedItem = cmbStatus.Items(1)
    End Sub

    Private Sub OggettiDataGridView_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles OggettiDataGridView.CellFormatting

        Dim X As Oggetti _
        = DirectCast(OggettiDataGridView.Rows(e.RowIndex).DataBoundItem, Oggetti)

        If OggettiDataGridView.Columns(e.ColumnIndex) Is Codice Then _
           Tools.FormattoOggetti(context, X, sender, e)
    End Sub

    Private Sub DescrizioneTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescrizioneTextBox.TextChanged, OggettoTextBox1.TextChanged, txtSeriale.TextChanged, txtModello.TextChanged
        With DirectCast(sender, TextBox)

            If Len(.Text) >= 3 Or .Text = "" Then OP_Ricerca()

        End With
    End Sub

    Private ReadOnly Property cmbStatus_Value() As EnumStatus
        Get
            Return CType(cmbStatus.SelectedItem, EnumStatus)
        End Get
    End Property

    Private Sub OggettiDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles OggettiDataGridView.CellClick
        If e.RowIndex = -1 Then
            Dim NuovaColonnaOrd As String = OggettiDataGridView.Columns(e.ColumnIndex).DataPropertyName

            If _ColonnaOrdinante = NuovaColonnaOrd Then
                _Inversione = Not _Inversione
            Else
                _Inversione = False
                _ColonnaOrdinante = NuovaColonnaOrd
            End If

            OP_Ricerca()
        End If
    End Sub

End Class

Public Enum EnumStatus
    Tutti
    Disponibili
    Venduti
    Rientrati
    Riconsegnati
    Rottamati
End Enum

