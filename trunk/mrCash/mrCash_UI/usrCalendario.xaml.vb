Public Class usrCalendario

    Private inizio As DateTime = New DateTime(2012, 10, 13)

    Public Sub Popola()

        Mygrd.Children.Clear()

        Dim base_data = inizio

        base_data = base_data.AddDays(1 - base_data.DayOfWeek)
        base_data = base_data.AddDays(-28)

        Dim qry As List(Of mrCash_DAL.V_Giornalieri)

        Using ctx = mrCash_DAL.MRCashEntities.Create

            Dim AData = base_data.AddDays(35)

            qry = (From Q In ctx.V_Giornalieri _
                   Where Q.Data >= base_data _
                   And Q.Data < AData).ToList
        End Using


        For r = 0 To 4
            For c = 0 To 6

                Dim b As New System.Windows.Controls.Button
                System.Windows.Controls.Grid.SetRow(b, r)
                System.Windows.Controls.Grid.SetColumn(b, c)

                Dim giorno = (From q In qry Where q.Data = base_data).FirstOrDefault
                If giorno Is Nothing Then
                    giorno = New mrCash_DAL.V_Giornalieri With {.Data = base_data}
                End If

                'b.Content = txt
                b.DataContext = giorno
                AddHandler b.Click, AddressOf Cliccato

                Mygrd.Children.Add(b)
                If base_data = Now.Date Then b.Focus()

                base_data = base_data.AddDays(1)
            Next
        Next

    End Sub

    Private Sub bDN_Click(sender As Object, e As Windows.RoutedEventArgs) Handles bDN.Click
        inizio = inizio.AddDays(7) : Popola()
    End Sub

    Private Sub bUP_Click(sender As Object, e As Windows.RoutedEventArgs) Handles bUP.Click
        inizio = inizio.AddDays(-7) : Popola()
    End Sub

    Private Sub Cliccato(sender As Object, e As Windows.RoutedEventArgs)
        Dim b = DirectCast(sender, System.Windows.Controls.Button)
        Dim R = DirectCast(b.DataContext, mrCash_DAL.V_Giornalieri)

        ' Controllo per non sbagliare a variare i giorni precedenti
        If R IsNot Nothing AndAlso R.Data < Now.Date Then
            If MsgBox("Si sta per variare la vendita di un giorno passato." & vbCrLf & vbCrLf & "Procedere con l'operazione ?", MsgBoxStyle.YesNo) <> MsgBoxResult.Yes _
               Then Exit Sub
        End If

        Using F As New frmVendita

            F.DataVendita = R.Data.Date

            F.ShowDialog()

            Popola()

        End Using

    End Sub
End Class
