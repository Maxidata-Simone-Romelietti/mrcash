Imports System
Imports System.IO
Imports System.Runtime.CompilerServices

Public Class frmPISTOLA

    Dim sw As StreamWriter
    Const POSTO As String = "c:\Inventario"

    Private Sub frmPISTOLA_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        If sw IsNot Nothing Then
            sw.Close()
            sw.Dispose()
        End If

    End Sub

    Private Sub frmPISTOLA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not My.Computer.FileSystem.DirectoryExists(POSTO) Then _
           My.Computer.FileSystem.CreateDirectory(POSTO)

        Dim Nomefile As String
        Dim GiaEsiste As Boolean
        Do

            If GiaEsiste Then _
               MsgBox("Il file esiste già ! Utilizzare un nome diverso")

            Nomefile = InputBox("Inserisci il nome del reparto")

            If Nomefile = "" Then Exit Do

            Nomefile = Nomefile & ".txt"
            Nomefile = Path.Combine(POSTO, Nomefile)
            GiaEsiste = My.Computer.FileSystem.FileExists(Nomefile)

        Loop Until Not GiaEsiste

        ' Se non ho un file selezionato esco dal programma
        If Nomefile = "" Then Environment.Exit(0)

        lblPath.Text = Nomefile
        sw = New StreamWriter(Nomefile)

    End Sub

    Private Sub txtCodice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodice.KeyDown
        Dim S As String = txtCodice.Text.Trim
        If e.KeyData = Keys.Enter Then
            sw.WriteLine(txtCodice.Text.ToCodice)
            Console.Beep(1000, 150)
            txtCodice.Text = ""

            e.Handled = True
        End If

        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If

    End Sub

End Class

Module StringExtensions

    <Extension()> _
    Public Function ToCodice(ByVal S As String) As String
        Return Integer.Parse("0" + S.Trim).ToString("00000")
    End Function

End Module