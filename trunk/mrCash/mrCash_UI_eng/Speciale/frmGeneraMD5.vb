Public Class frmGeneraMD5

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        txtMD5.Text = getMd5Hash(txtPassword.Text)
    End Sub

End Class