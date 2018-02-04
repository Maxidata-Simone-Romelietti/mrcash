Imports mrCash_DAL

Public Class frmRicerca_Base
    Protected _Inversione As Boolean
    Protected _ColonnaOrdinante As String = ""
    Protected context As mrCash_DAL.MRCashEntities

    Private _Selezione As Boolean
    Public Property Selezione() As Boolean
        Get
            Return _Selezione
        End Get
        Set(ByVal value As Boolean)
            _Selezione = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        If IsInDesignMode() Then Exit Sub

        ' Add any initialization after the InitializeComponent() call.
        context = New mrCash_DAL.MRCashEntities()
    End Sub

    Private Sub frmRicerca_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        context.Dispose()
    End Sub

    Private Sub frmRicercaAcquisti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OP_Ricerca()
    End Sub

    Private Sub cmdNuovoAcquisti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuovo.Click
        OP_Nuovo()
    End Sub

    Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OP_Annulla()
    End Sub

    Private Sub cmdRicerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRicerca.Click
        OP_Ricerca()
    End Sub

    Protected Overridable Function OP_Nuovo() As Boolean
        Return True
    End Function

    Protected Overridable Function OP_Ricerca() As Boolean
        Return True
    End Function

    Protected Overridable Function OP_Annulla() As Boolean
        Me.Close()
        Return True
    End Function

    Public Shared Function IsInDesignMode() As Boolean

        Dim returnFlag As Boolean = False

#If DEBUG Then

        If (System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime) Then
            returnFlag = True
        ElseIf (Process.GetCurrentProcess().ProcessName.ToUpper().Equals("DEVENV")) Then
            returnFlag = True
        End If

#End If

        Return returnFlag

    End Function


End Class