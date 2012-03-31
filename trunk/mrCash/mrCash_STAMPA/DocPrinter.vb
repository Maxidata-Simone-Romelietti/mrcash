Imports System.Drawing
Imports System.Drawing.Printing

Public Class DocPrinter

    Protected FL As New Font("Arial", 8) ' Font Label
    Protected FD As New Font("Arial", 10, FontStyle.Bold) ' Font Dati
    Protected gr As Graphics
    Protected Pagina As Integer
    Protected PagineTotali As Integer

    Private Sub _Documento_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles _Documento.BeginPrint
        Pagina = 0
        PagineTotali = CalcolaPagineTotali()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles _Documento.PrintPage
        Pagina += 1

        gr = e.Graphics

        If My.Computer.Keyboard.AltKeyDown Then Griglia(gr)

        CostruisciPagina()

        e.HasMorePages = (Pagina < PagineTotali)
    End Sub

    Protected Overridable Sub CostruisciPagina()

    End Sub

    Protected WithEvents _Documento As New PrintDocument
    Public ReadOnly Property Documento() As PrintDocument
        Get
            Return _Documento
        End Get
    End Property

    Protected Sub dato(ByVal N As String, ByVal V As String, ByVal X As Integer, ByVal Y As Integer, Optional ByVal Distanza As Integer = -1)

        If Distanza = -1 Then
            Dim sF As SizeF = gr.MeasureString(N, FL)
            Distanza = sF.ToSize.Width + 10
        End If
        scritta(N, FL, Brushes.Black, X, Y)
        scritta(V, FD, Brushes.Black, X + Distanza, Y)

    End Sub

    Protected Sub nome(ByVal S As String, ByVal X As Integer, ByVal Y As Integer, Optional ByVal W As Integer = 0)
        scritta(S, FL, Brushes.Black, X, Y, W)
    End Sub

    Protected Sub valore(ByVal S As String, ByVal X As Integer, ByVal Y As Integer, Optional ByVal W As Integer = 0)
        scritta(S, FD, Brushes.Black, X, Y, W)
    End Sub

    Protected Sub scritta(ByVal S As String, ByVal F As Font, ByVal B As Brush, ByVal X As Integer, ByVal Y As Integer, Optional ByVal W As Integer = 0)
        If W <> 0 Then
            Dim R As New Rectangle(X, Y, W, 20)
            Dim SF As New StringFormat With {.Alignment = StringAlignment.Far}
            gr.DrawString(S, F, B, R, SF)
        Else
            gr.DrawString(S, F, B, X, Y)
        End If
    End Sub

    Protected Sub Griglia(ByVal gr As Graphics)

        Dim PA As RectangleF = Documento.DefaultPageSettings.PrintableArea
        gr.DrawRectangle(Pens.Blue, PA.X, PA.Y, PA.X + PA.Width, PA.Y + PA.Height)

        Dim P As Pen
        For x As Integer = 0 To 900 Step 10
            P = Pens.LightGray
            If x Mod 50 = 0 Then P = Pens.Green
            If x Mod 100 = 0 Then P = Pens.Red
            gr.DrawLine(P, x, PA.Y, x, PA.Y + PA.Height)
        Next

        For y As Integer = 0 To 900 Step 10
            P = Pens.LightGray
            If y Mod 50 = 0 Then P = Pens.Green
            If y Mod 100 = 0 Then P = Pens.Red
            gr.DrawLine(P, PA.X, y, PA.X + PA.Width, y)
        Next

    End Sub

    Protected Overridable Function CalcolaPagineTotali() As Integer
        Return 1
    End Function

End Class
