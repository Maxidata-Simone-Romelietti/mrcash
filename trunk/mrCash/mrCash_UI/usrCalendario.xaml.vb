Public Class usrCalendario

    Public WithEvents bUP As New System.Windows.Controls.Button With {.Content = "UP"}
    Public WithEvents bDN As New System.Windows.Controls.Button With {.Content = "DOWN"}

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

                Dim txt = base_data.ToString("dd/MM")
                Dim soldi = (From q In qry Where q.Data = base_data).FirstOrDefault
                If soldi IsNot Nothing Then txt += vbCrLf & soldi.Totale.ToString
                b.Content = txt

                Mygrd.Children.Add(b)
                If base_data = Now.Date Then b.Focus()

                base_data = base_data.AddDays(1)
            Next
        Next

        System.Windows.Controls.Grid.SetRow(bUP, 0)
        System.Windows.Controls.Grid.SetColumn(bUP, 7)
        System.Windows.Controls.Grid.SetRowSpan(bUP, 2)

        System.Windows.Controls.Grid.SetRow(bDN, 3)
        System.Windows.Controls.Grid.SetColumn(bDN, 7)
        System.Windows.Controls.Grid.SetRowSpan(bDN, 2)

        Mygrd.Children.Add(bUP)
        Mygrd.Children.Add(bDN)
    End Sub

    Private Sub bDN_Click(sender As Object, e As Windows.RoutedEventArgs) Handles bDN.Click
        inizio = inizio.AddDays(7) : Popola()
    End Sub

    Private Sub bUP_Click(sender As Object, e As Windows.RoutedEventArgs) Handles bUP.Click
        inizio = inizio.AddDays(-7) : Popola()
    End Sub

End Class
