Imports mrCash_DAL
Imports System.IO
Imports System.Configuration
Imports System
Imports System.Security.Cryptography
Imports System.Text
Imports System.Runtime.CompilerServices
Imports System.Collections.Generic
Imports System.Linq
Imports System.Data.Objects.DataClasses
Imports System.Collections
Imports System.Reflection

Public Class frmLogin

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then Verifica()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Verifica()
    End Sub

    Private Sub Verifica()
        Dim hash As String = getMd5Hash(TextBox1.Text)
        Dim X As String = My.Settings.Password

        'If hash = X Then
        SettaConnessioni(TextBox1.Text)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
        'Else
        'MsgBox("Password Errata")
        'End If
    End Sub

End Class