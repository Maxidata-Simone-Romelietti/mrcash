Public Class Variabili

    Private Shared _ExcelConnectionString As String = ""
    Public Shared Property ExcelConnectionString() As String
        Get
            Return _ExcelConnectionString
        End Get
        Set(value As String)
            _ExcelConnectionString = value
        End Set
    End Property

    Private Shared _ContextConnectionString As String = ""
    Public Shared Property ContextConnectionString() As String
        Get
            Return _ContextConnectionString
        End Get
        Set(value As String)
            _ContextConnectionString = value
        End Set
    End Property

End Class
