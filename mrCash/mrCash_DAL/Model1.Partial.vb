Partial Public Class MRCashEntities
    Public Shared Function Create() As MRCashEntities
        Return New mrCash_DAL.MRCashEntities(Variabili.ContextConnectionString)
    End Function
End Class
