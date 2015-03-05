Imports mrCash_DAL

Public Class frmRicercaVendite2


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

            'OP_Ricerca()

        End Using

    End Sub

    Private Sub DescrizioneTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OggettoTextBox1.TextChanged
        With DirectCast(sender, TextBox)

            'If Len(.Text) >= 3 Or .Text = "" Then OP_Ricerca()

        End With
    End Sub

    Private Sub frmRicercaVendite2_Load(sender As Object, e As EventArgs) Handles Me.Load
        DirectCast(ElementHost2.Child, usrCalendario).Popola()
    End Sub

End Class