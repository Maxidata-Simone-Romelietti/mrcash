Public Class frmGestione_Base

    Protected context As mrCash_DAL.MRCashEntities

    Private Sub frmGestione_Base_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Me.DesignMode Then _
           context = New mrCash_DAL.MRCashEntities()

        OP_LOAD()
    End Sub

    Private Sub frmGestione_Base_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        OP_KEYDOWN(Me, e)
    End Sub

    Private Sub cmdConferma_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdConferma.Click
        OP_CONFERMA()
    End Sub

    Private Sub cmdElimina_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdElimina.Click
        OP_ELIMINA()
    End Sub

    Private Sub cmdAnnulla_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
        OP_ANNULLA()
    End Sub

    Protected Overridable Sub OP_LOAD()

    End Sub

    Protected Overridable Sub OP_KEYDOWN(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Tools.AfterKeyDown(Me, e)
    End Sub

    Protected Overridable Sub OP_CONFERMA()

    End Sub

    Protected Overridable Sub OP_ANNULLA()

    End Sub

    Protected Overridable Sub OP_ELIMINA()

    End Sub

    Private _ID As Integer = -1
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property

End Class