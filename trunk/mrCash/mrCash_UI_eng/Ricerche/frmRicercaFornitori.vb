Imports mrCash_DAL

Public Class frmRicercaFornitori

    Private _IDFornitore As Integer
    Public Property IDFornitore() As Integer
        Get
            Return _IDFornitore
        End Get
        Set(ByVal value As Integer)
            _IDFornitore = value
        End Set
    End Property

    Protected Overrides Function OP_Ricerca() As Boolean
        Dim qry = From f As Fornitori In context.Fornitori Order By f.Cognome, f.Nome Select f

        If CognomeTextBox1.Text <> "" Then _
           qry = qry.Where(Function(f) f.Cognome.Contains(CognomeTextBox1.Text))

        If NomeTextBox1.Text <> "" Then _
           qry = qry.Where(Function(f) f.Nome.Contains(NomeTextBox1.Text))

        Dim N As String = _ColonnaOrdinante.ToUpper
        If N = "COGNOME" And _Inversione Then qry = From z In qry Order By z.Cognome Descending
        If N = "COGNOME" And Not _Inversione Then qry = From z In qry Order By z.Cognome Ascending

        If N = "NOME" And _Inversione Then qry = From z In qry Order By z.Nome Descending
        If N = "NOME" And Not _Inversione Then qry = From z In qry Order By z.Nome Ascending

        FornitoriBindingSource.DataSource = qry
    End Function

    Private Sub FornitoriDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles FornitoriDataGridView.CellDoubleClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

        Dim X As Fornitori _
        = DirectCast(FornitoriDataGridView.Rows(e.RowIndex).DataBoundItem, Fornitori)

        If Selezione Then
            _IDFornitore = X.IDFornitore
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
            Exit Sub
        End If

        ModificaRecord(X)

    End Sub

    Protected Overrides Function OP_Nuovo() As Boolean
        ModificaRecord(Nothing)
    End Function

    Private Sub ModificaRecord(ByVal R As Fornitori)

        Dim IsNuovo As Boolean = R Is Nothing

        Using F As New frmFornitore

            F.ID = -1 : If R IsNot Nothing Then F.ID = R.IDFornitore

            Me.Visible = False
            F.ShowDialog()
            Me.Visible = True

            If IsNuovo And F.DialogResult = Windows.Forms.DialogResult.OK Then

                ' Seleziona il fornitore che ho appena inserito ed esce
                _IDFornitore = F.IDFornitoreScelto
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
                Exit Sub

            Else
                OP_Ricerca()
            End If


        End Using

    End Sub

    Private Sub FornitoriDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles FornitoriDataGridView.CellClick
        If e.RowIndex = -1 Then
            Dim NuovaColonnaOrd As String = FornitoriDataGridView.Columns(e.ColumnIndex).DataPropertyName

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