Imports System.ComponentModel

<DefaultBindingProperty("Valore")> _
Public Class PrezzoTextBox
    Inherits TextBox

    Public Sub New()
        MyBase.new()

        Me.TextAlign = HorizontalAlignment.Right
    End Sub

    Protected Overrides Sub onKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyData = Keys.Oemcomma Then
            e.SuppressKeyPress = True
            SendKeys.Send(".")
        End If

    End Sub

    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar >= "0"c And e.KeyChar <= "9"c Then
            e.Handled = False

        ElseIf e.KeyChar = Chr(8) Then
            e.Handled = False

        ElseIf e.KeyChar = "."c And Not Me.Text.Contains(".") Then
            e.Handled = False

        ElseIf e.KeyChar = "-"c And Not Me.Text.Contains("-") Then
            e.Handled = False

        Else
            e.Handled = True

        End If
    End Sub

    Protected Overrides Sub OnValidating(ByVal e As System.ComponentModel.CancelEventArgs)
        Me.Text = Me.Text

        MyBase.OnValidating(e)
    End Sub

    Public Overrides Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            Dim N As Decimal

            If Decimal.TryParse(value, N) Then
                Me.Valore = N
            Else
                ' così risetta la text
                Me.Valore = Me.Valore
            End If

        End Set
    End Property

    Private _Valore As Decimal

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property Valore() As Decimal
        Get
            Return _Valore
        End Get
        Set(ByVal value As Decimal)
            _Valore = value
            MyBase.Text = _Valore.ToString(Format)
        End Set
    End Property

    Private _Format As String = "0.00"
    Public Property Format() As String
        Get
            Return _Format
        End Get
        Set(ByVal value As String)
            _Format = value
        End Set
    End Property

End Class
