Class MainWindow 

    Private Sub Grid1_Loaded(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Grid1.Loaded
        mediaEL.LoadedBehavior = MediaState.Manual
        mediaEL.Source = New Uri(My.Settings.PathFilmato)
        mediaEL.Play()
    End Sub

    Private Sub mediaEL_MediaEnded(sender As Object, e As System.Windows.RoutedEventArgs) Handles mediaEL.MediaEnded
        Try
            Process.Start(My.Settings.PathProgramma)

        Catch ex As Exception
            MsgBox("Impossibile caricare il file : " & My.Settings.PathProgramma)

        Finally
            Me.Close()

        End Try

    End Sub

End Class
