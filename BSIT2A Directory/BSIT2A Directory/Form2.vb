Imports System.Data.OleDb
Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        con.Open()

        Dim daLogin As New OleDbDataAdapter("SELECT * FROM LoginInfo WHERE Username='" & txtUsername.Text & _
                                            "' AND Password='" & txtPassword.Text & "'", con)
        Dim dtLogin As New DataTable

        daLogin.Fill(dtLogin)

        'MessageBox.Show(dtLogin.Rows.Count.ToString())

        If dtLogin.Rows.Count > 0 Then
            Me.Hide()
            frmBSIT2ADirectory.Show()
        Else
            MessageBox.Show("Access denied.", "Log-in", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()
        End If
        con.Close()
    End Sub
End Class