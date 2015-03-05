Imports mrCash_DAL

Public Class Inventario_Controller

    Public ReadOnly Property Posto() As String
        Get
            Return "c:\Inventario"
        End Get
    End Property

    Private _OggettiMancanti As New List(Of Oggetti)
    Public ReadOnly Property OggettiMancanti() As List(Of Oggetti)
        Get
            Return _OggettiMancanti
        End Get
    End Property

    Private _OggettiVendutiPresenti As New List(Of Oggetti)
    Public ReadOnly Property OggettiVendutiPresenti() As List(Of Oggetti)
        Get
            Return _OggettiVendutiPresenti
        End Get
    End Property

    Private _CodiciSconosciuti As New List(Of Oggetti)
    Public ReadOnly Property CodiciSconosciuti() As List(Of Oggetti)
        Get
            Return _CodiciSconosciuti
        End Get
    End Property

    Private _DataScansioni As DateTime
    Public Property DataScansioni() As DateTime
        Get
            Return _DataScansioni
        End Get
        Set(ByVal value As DateTime)
            _DataScansioni = value
        End Set
    End Property

    Public Sub New()
        If Not My.Computer.FileSystem.DirectoryExists(POSTO) Then _
           My.Computer.FileSystem.CreateDirectory(POSTO)
    End Sub
    Public Sub Carica()

        OggettiMancanti.Clear()
        OggettiVendutiPresenti.Clear()
        CodiciSconosciuti.Clear()

        Dim Scansioni As New List(Of String)

        For Each F As String In My.Computer.FileSystem.GetFiles(Posto, FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
            For Each S As String In My.Computer.FileSystem.ReadAllText(F).Replace(vbLf, "").Split(ControlChars.Cr)
                If S.Trim <> "" Then Scansioni.Add(S)
            Next
        Next

        Dim context = New mrCash_DAL.MRCashEntities(ContextConnectionString)
        Dim qry = From f As Oggetti In context.Oggetti.Include("Vendite").Include("Acquisti") Select f

        For Each f In qry

            If f.Acquisti.Data > DataScansioni.Date Then

                ' Considera solo gli acquisti fino alla data

            ElseIf f.Vendite IsNot Nothing Or f.DataRottamazione IsNot Nothing Then

                ' Se venduto o distrutto non deve esserci
                If Scansioni.Contains(f.Codice) Then OggettiVendutiPresenti.Add(CopiaOggetto(f))

            Else

                ' Altrimenti deve esistere
                If Not Scansioni.Contains(f.Codice) Then OggettiMancanti.Add(CopiaOggetto(f))

            End If

            Scansioni.Remove(f.Codice)

        Next

        ' Eventuali Codici non presenti in archivio
        For Each S As String In Scansioni
            Dim N As New Oggetti With {.Codice = S}
            CodiciSconosciuti.Add(N)
        Next

        CodiciSconosciuti.Sort()
    End Sub

    Private Function CopiaOggetto(ByVal Origine As Oggetti) As Oggetti
        Dim X As New Oggetti With {.Codice = Origine.Codice, .Descrizione = Origine.Descrizione}
        X.Acquisti = New Acquisti
        Return X
    End Function

End Class
