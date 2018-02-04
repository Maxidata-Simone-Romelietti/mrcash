Imports mrCash_DAL
Imports System.IO
Imports System.Configuration
Imports System
Imports System.Security.Cryptography
Imports System.Text
Imports System.Runtime.CompilerServices



Imports System.Collections.Generic
Imports System.Linq
Imports System.Collections
Imports System.Reflection


Module Tools

    Public ReadOnly Property ExcelConnectionString() As String
        Get
            Return mrCash_DAL.Variabili.ExcelConnectionString
        End Get
    End Property

    Public ReadOnly Property ContextConnectionString() As String
        Get
            Return mrCash_DAL.Variabili.ContextConnectionString
        End Get
    End Property

    Public Sub SettaConnessioni(ByVal password As String)
        password = password.ToLower
        Dim CS As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("MRCashEntities")
        mrCash_DAL.Variabili.ContextConnectionString = CS.ConnectionString.Replace("User ID=sa", "User ID=sa;Password=" & password)
        mrCash_DAL.Variabili.ExcelConnectionString = My.Settings.ConnessioneExcel.Replace("User ID=sa", "User ID=sa;Password=" & password)
    End Sub

    Public Sub AfterKeyDown(ByVal F As Form, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Dim C As Control = F.ActiveControl

            ' Non salto via per le multiline
            If TypeOf C Is TextBox AndAlso DirectCast(C, TextBox).Multiline Then Exit Sub

            If Not (TypeOf C Is DataGridView) Then SendKeys.Send("{TAB}")
        End If
    End Sub

    Public Sub FormattoOggetti(ByVal context As MRCashEntities, ByVal O As mrCash_DAL.Oggetti, ByVal sender As Object, ByRef e As DataGridViewCellFormattingEventArgs)
        If O Is Nothing Then Exit Sub

        'Dim qry = From Q As Oggetti In context.Oggetti.Include("Vendite").Where(Function(s) s.IDOggetto = O.IDOggetto) Select Q
        'If qry.Count > 0 Then

        '    With qry.First

        '        If qry.First IsNot Nothing _
        '        AndAlso .Vendite IsNot Nothing Then
        '            Dim c As DataGridView = DirectCast(sender, DataGridView)
        '            c.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
        '            c.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
        '            'CS.CellStyle.BackColor = Color.Red
        '        End If

        '    End With

        'End If

        If O.Vendite IsNot Nothing Then
            Dim c As DataGridView = DirectCast(sender, DataGridView)
            c.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
            c.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
            'CS.CellStyle.BackColor = Color.Red
        End If

    End Sub

    ' Hash an input string and return the hash as
    ' a 32 character hexadecimal string.
    Function getMd5Hash(ByVal input As String) As String
        ' Create a new instance of the MD5 object.
        Dim md5Hasher As MD5 = MD5.Create()

        ' Convert the input string to a byte array and compute the hash.
        Dim data As Byte() = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input.ToUpper))

        ' Create a new Stringbuilder to collect the bytes
        ' and create a string.
        Dim sBuilder As New StringBuilder()

        ' Loop through each byte of the hashed data 
        ' and format each one as a hexadecimal string.
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i

        ' Return the hexadecimal string.
        Return sBuilder.ToString()

    End Function

    ''' <summary>
    ''' Crea un file temporaneo readonly di tipo Excel con il file passato
    ''' </summary>
    Public Sub creaTMP(ByVal Margini As Boolean)
        Aggiorna_CNN()

        Dim F As String = My.Computer.FileSystem.GetTempFileName
        F = F.Replace(Path.GetExtension(F), ".XLS")

        If Margini Then
            My.Computer.FileSystem.WriteAllBytes(F, My.Resources.Margini, True)
        Else
            My.Computer.FileSystem.WriteAllBytes(F, My.Resources.Inventario, True)
        End If

        Dim FI As New FileInfo(F)
        FI.Attributes = FI.Attributes Or FileAttributes.ReadOnly
        Process.Start(F)

    End Sub

    ''' <summary>
    ''' Rigenero il file che serve ai fogli Excel di connettersi al DB
    ''' </summary>
    Private Sub Aggiorna_CNN()
        Dim F As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, "cnn.txt")
        My.Computer.FileSystem.WriteAllText(F, ExcelConnectionString, False, System.Text.Encoding.Default)
    End Sub

    Public Function ConfermaEliminazione(ByVal msg As String) As Boolean
        Return MsgBox(msg, MsgBoxStyle.YesNo, "CONFERMA CANCELLAZIONE") = MsgBoxResult.Yes
    End Function


End Module

Module Extensions

    <Extension()>
    Public Function SenzaOra(ByVal d As Date) As Date
        Return New Date(d.Year, d.Month, d.Day, 0, 0, 0)
    End Function

    <Extension()>
    Public Function ToCodice(ByVal S As String) As String
        Return Integer.Parse("0" + S.Trim).ToString("00000")
    End Function

    <Extension()>
    Public Function ToReal(ByVal S As String) As String
        If S Is Nothing Then Return "" Else Return S
    End Function

    <Extension()>
    Public Function ToReal(ByVal D As Decimal?) As Decimal
        If D Is Nothing Then Return 0D Else Return CDec(D)
    End Function

End Module
