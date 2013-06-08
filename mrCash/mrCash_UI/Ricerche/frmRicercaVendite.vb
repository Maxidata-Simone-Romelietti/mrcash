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

            Dim DataVendita As New DateTime
            If obj IsNot Nothing Then DataVendita = obj.Vendita_Data

            qry = qry.Where(Function(s) s.Data = DataVendita).ToList
        End If

        qry = (From z In qry Order By z.Data Descending).ToList

        VenditeBindingSource1.DataSource = (From z In qry Order By z.Data Descending).ToList

    End Function

    Private Sub VenditeDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VenditeDataGridView.CellDoubleClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

        Dim X = DirectCast(VenditeDataGridView.Rows(e.RowIndex).DataBoundItem, V_Giornalieri)

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

        Dim V = (From Q In context.V_Giornalieri Where Q.Data = Dso).FirstOrDefault
        ModificaRecord(V)

    End Function

    Private Sub ModificaRecord(ByVal R As V_Giornalieri)

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