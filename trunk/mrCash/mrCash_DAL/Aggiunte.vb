Imports System.ComponentModel

Partial Public Class Fornitori

    Public Sub New()
        Me.DataNascita = Now
        Me.DataRilascio = Now
    End Sub

    Public ReadOnly Property NomeCompleto() As String
        Get
            Return Cognome + " " + Nome + " - " + Citta
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return Me.NomeCompleto
    End Function

End Class

Partial Public Class Acquisti
    Public ReadOnly Property Fornitore_NomeCompleto() As String
        Get
            If Me.Fornitori Is Nothing Then Return ""
            Return Me.Fornitori.NomeCompleto
        End Get
    End Property

    Public ReadOnly Property Totale() As Decimal
        Get
            Return (Aggregate x In Me.Oggetti Into Sum(x.PrezzoAcquisto))
        End Get
    End Property

    Public ReadOnly Property Conteggio() As Integer
        Get
            Return Me.Oggetti.Count
        End Get
    End Property

End Class

Partial Public Class Oggetti
    Implements IComparable

    Public ReadOnly Property Codice_Numerico() As Integer
        Get
            Dim N As Integer
            Integer.TryParse(Me.Codice, N)
            Return N
        End Get
    End Property

    Public ReadOnly Property Transazione_Acquisto() As Integer
        Get
            If Me.Acquisti Is Nothing Then Return 0
            Return Me.Acquisti.Transazione
        End Get
    End Property

    Public ReadOnly Property Vendita_Data() As DateTime
        Get
            If Me.Vendite Is Nothing Then Return Nothing
            Return Me.Vendite.Data
        End Get
    End Property

    Public Function CompareTo(obj As Object) As Integer Implements System.IComparable.CompareTo
        If obj Is Nothing Then Return 1

        Dim e1 = DirectCast(obj, Oggetti)
        Dim e2 = DirectCast(Me, Oggetti)

        If e1.Codice_Numerico < e2.Codice_Numerico Then
            Return 1

        ElseIf e1.Codice_Numerico > e2.Codice_Numerico Then
            Return -1

        Else
            Return 0

        End If


    End Function
End Class

Partial Public Class Vendite

    Public Function TrovaCodice(ByVal context As MRCashEntities, ByVal X As String) As Oggetti

        Dim qry = From Q As Oggetti In context.Oggetti.Include("Vendite").Where(Function(s) s.Codice = X) Select Q

        If qry.Count = 1 Then

            Dim o As Oggetti = qry.First
            If o.Vendite Is Nothing Then
                Return o
            Else
                Throw New ApplicationException(String.Format("L'oggetto {0} risulta già venduto !", o.Descrizione))
            End If

        ElseIf qry.Count = 0 Then
            Throw New ApplicationException(String.Format("L'oggetto {0} non è stato trovato !", X))

        ElseIf qry.Count > 1 Then
            Dim S As String = "L'oggetto {0} compare {1} volte in archivio : non so quale scaricare !"
            Throw New ApplicationException(String.Format(S, X, qry.Count))

        End If

        Return Nothing
    End Function

    Public ReadOnly Property Totale() As Decimal
        Get
            Dim T As Decimal
            For Each o As Oggetti In Me.Oggetti
                T += o.PrezzoVendita
            Next
            Return T
        End Get
    End Property

    Public Function TentativiCodice(ByVal c As String) As List(Of String)
        Dim Numero As Integer = Integer.Parse("0" + c)

        Dim T As New List(Of String)
        For i As Integer = 6 To Numero.ToString.Length Step -1
            T.Add(Numero.ToString(New String("0"c, i)))
        Next

        Return T
    End Function

End Class

''' <summary>
''' Classe PEr ottenere EntityCollection Ordinabili
''' </summary>
''' <typeparam name="T"></typeparam>
''' <remarks></remarks>
Public Class LinqEntityBinding(Of T As System.Data.Objects.DataClasses.EntityObject)
    Inherits System.ComponentModel.BindingList(Of T)
    Public Sub New(ByVal context As System.Data.Objects.ObjectContext, ByVal collection As System.Data.Objects.DataClasses.EntityCollection(Of T), ByVal list As IList(Of T), ByVal EliminaSubito As Boolean)
        MyBase.New(list)
        _context = context
        _collection = collection
        _EliminaSubito = EliminaSubito
    End Sub
    Private _context As System.Data.Objects.ObjectContext
    Private _collection As System.Data.Objects.DataClasses.EntityCollection(Of T)
    Private _EliminaSubito As Boolean

    Protected Overrides Function AddNewCore() As Object
        Dim obj As Object = MyBase.AddNewCore()
        _collection.Add(DirectCast(obj, T))
        Return obj
    End Function

    ''' <summary>
    ''' Uso questa versione perche Add normale non era overridable
    ''' </summary>
    ''' <param name="item"></param>
    ''' <remarks></remarks>
    Public Sub AddCorretto(ByVal item As T)
        MyBase.Add(item)

        _collection.Add(item)
    End Sub

    Public Overrides Sub CancelNew(ByVal itemIndex As Integer)
        Dim obj As Object = Items(itemIndex)
        _collection.Remove(DirectCast(obj, T))
        If _EliminaSubito And DirectCast(obj, T).EntityState <> System.Data.EntityState.Detached Then
            _context.DeleteObject(obj)
        End If
        MyBase.CancelNew(itemIndex)
    End Sub

    Protected Overrides Sub RemoveItem(ByVal index As Integer)
        Dim obj As Object = Items(index)
        _collection.Remove(DirectCast(obj, T))
        If _EliminaSubito And DirectCast(obj, T).EntityState <> System.Data.EntityState.Detached Then
            _context.DeleteObject(obj)
        End If
        MyBase.RemoveItem(index)
    End Sub
End Class

Public Interface IRinumerabile
    Property Ordine() As Integer
End Interface
