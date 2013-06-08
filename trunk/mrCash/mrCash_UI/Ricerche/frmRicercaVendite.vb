Imports mrCash_DAL

Public Class frmRicercaVendite
    Private _IDVendita As Integer
    Public Property IDVendita() As Integer
        Get
            Return _IDVendita
        End Get
        Set(ByVal value As Integer)
            _IDVendita = value
        End Set
    End Property

    Protected Overrides Function OP_Ricerca() As Boolean

        Dim qry = (From Q In context.V_Giornalieri).ToList

        ' Applica la where dell'oggetto
        If OggettoTextBox1.Text <> "" Then
            Dim c As String = OggettoTextBox1.Text.ToCodice
            Dim obj = (From o In context.Oggetti Where o.Codice = c).FirstOrDefault

            Dim IDVendita As Integer = -1
            If obj IsNot Nothing Then IDVendita = obj.RigaVendita

            qry = qry.Where(Function(s) s.IDVendita = IDVendita).ToList
        End If

        'qry = (From z In qry Order By z.Data Descending).ToList

        'VenditeBindingSource1.DataSource = (From z In qry Order By z.Data Descending).ToList

        'For Each r As DataGridViewRow In VenditeDataGridView.Rows
        '    Dim id As Integer = CInt(r.Cells("IDVenditaColonna").Value)
        '    Dim t As Decimal = CDec((From z In qry2 Where z.IDVendita = id Select z.Totale).FirstOrDefault)
        '    r.Cells("Totale").Value = t
        'Next
    End Function

    Private Sub VenditeDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VenditeDataGridView.CellDoubleClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

        Dim X As Vendite _
        = DirectCast(VenditeDataGridView.Rows(e.RowIndex).DataBoundItem, Vendite)

        If Selezione Then
            _IDVendita = X.IDVendita
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
            Exit Sub
        End If

        ModificaRecord(X)

    End Sub

    Protected Overrides Function OP_Nuovo() As Boolean
        Dim Dso As Date = Date.Now.SenzaOra

        Dim V = From Q As Vendite In context.Vendite.Where(Function(s) s.Data = Dso) Select Q

        Dim X As Vendite = Nothing

        If V.Count > 0 Then X = V.First

        ModificaRecord(X)

    End Function

    Private Sub ModificaRecord(ByVal R As Vendite)

        ' Controllo per non sbagliare a variare i giorni precedenti
        If R IsNot Nothing AndAlso R.Data < Now.Date Then
            If MsgBox("Si sta per variare la vendita di un giorno passato." & vbCrLf & vbCrLf & "Procedere con l'operazione ?", MsgBoxStyle.YesNo) <> MsgBoxResult.Yes _
               Then Exit Sub
        End If

        Using F As New frmVendita

            F.ID = -1 : If R IsNot Nothing Then F.ID = R.IDVendita

            Me.Visible = False
            F.ShowDialog()
            Me.Visible = True

            OP_Ricerca()

        End Using

    End Sub

    Private Sub DescrizioneTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OggettoTextBox1.TextChanged
        With DirectCast(sender, TextBox)

            If Len(.Text) >= 3 Or .Text = "" Then OP_Ricerca()

        End With
    End Sub

End Class