Imports mrCash_DAL

Public Class frmRicercaAcquisti

    Private _IDAcquisto As Integer
    Public Property IDAcquisto() As Integer
        Get
            Return _IDAcquisto
        End Get
        Set(ByVal value As Integer)
            _IDAcquisto = value
        End Set
    End Property

    Public Sub New()
        MyBase.new()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _Inversione = True
        _ColonnaOrdinante = "DATA"
    End Sub

    Protected Overrides Function OP_Ricerca() As Boolean

        Dim Cognome = CognomeTextBox1.Text
        Dim Nome = NomeTextBox1.Text
        Dim IDRicAcquisto = 0

        If OggettoTextBox1.Text <> "" Then
            Dim c As String = OggettoTextBox1.Text.ToCodice
            Dim oggetto = (From o As Oggetti In context.Oggetti.Include("Acquisti") Where o.Codice = c).FirstOrDefault
            If oggetto IsNot Nothing Then IDRicAcquisto = oggetto.Acquisti.IDAcquisto
        End If

        Dim qry = From Q As Acquisti In context.Acquisti.Include("Fornitori") _
                  Where (Cognome = "" Or Q.Fornitori.Cognome.Contains(Cognome)) _
                    And (Nome = "" Or Q.Fornitori.Nome.Contains(Nome)) _
                    And (IDRicAcquisto = 0 Or Q.IDAcquisto = IDRicAcquisto)

        Dim N As String = _ColonnaOrdinante.ToUpper
        If N = "DATA" And _Inversione Then qry = From z In qry Order By z.Data Descending
        If N = "DATA" And Not _Inversione Then qry = From z In qry Order By z.Data Ascending

        If N = "TRANSAZIONE" And _Inversione Then qry = From z In qry Order By z.Transazione Descending
        If N = "TRANSAZIONE" And Not _Inversione Then qry = From z In qry Order By z.Transazione Ascending

        AcquistiBindingSource.DataSource = qry


        ' Oggetti senza codice
        Dim TransazioniConCodiciMancanti = From o In context.Oggetti.Include("Acquisti") Where o.Codice = "" Select o.Acquisti
        Dim Distinti = (From x In TransazioniConCodiciMancanti Select CStr(x.Transazione)).Distinct

        lblWarning.Text = ""

        If Distinti.Count > 0 Then
            lblWarning.Text = "Transactions with missing codes : " & String.Join(" ", Distinti.ToArray)
        End If

    End Function

    Private Sub AcquistiDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AcquistiDataGridView.CellDoubleClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

        Dim X As Acquisti _
        = DirectCast(AcquistiDataGridView.Rows(e.RowIndex).DataBoundItem, Acquisti)

        If Selezione Then
            _IDAcquisto = X.IDAcquisto
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
            Exit Sub
        End If

        ModificaRecord(X)

    End Sub

    Protected Overrides Function OP_Nuovo() As Boolean
        ModificaRecord(Nothing)
    End Function

    Private Sub ModificaRecord(ByVal R As Acquisti)
        Dim Nuovo As Boolean = (R Is Nothing)

        Using F As New frmAcquisto

            If R IsNot Nothing Then F.ID = R.IDAcquisto

            Me.Visible = False
            Dim Ri As DialogResult = F.ShowDialog()
            Me.Visible = True

            OP_Ricerca()

        End Using

    End Sub

    Private Sub CognomeTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CognomeTextBox1.TextChanged, NomeTextBox1.TextChanged, OggettoTextBox1.TextChanged
        With DirectCast(sender, TextBox)

            If Len(.Text) >= 3 Or .Text = "" Then OP_Ricerca()

        End With
    End Sub

    Private Sub AcquistiDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AcquistiDataGridView.CellClick
        If e.RowIndex = -1 Then
            Dim NuovaColonnaOrd As String = AcquistiDataGridView.Columns(e.ColumnIndex).DataPropertyName

            If _ColonnaOrdinante = NuovaColonnaOrd Then
                _Inversione = Not _Inversione
            Else
                _Inversione = False
                _ColonnaOrdinante = NuovaColonnaOrd
            End If

            OP_Ricerca()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim fTot = New frmTotAcq
        fTot.ShowDialog()
    End Sub

End Class