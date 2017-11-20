Public Class FormMain

    ''' Initialize the user interface
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    ''' Show the window for creating a new password
    Private Sub ToolStripButtonNewPassword_Click(sender As Object, e As EventArgs) Handles ToolStripButtonNewPassword.Click
        Dim formNewPassword As New FormNewOrUpdatePassword()

        If formNewPassword.ShowDialog() <> DialogResult.OK Then
            Exit Sub
        End If

        ' Add the new account
        Dim account As Account = formNewPassword.Account
        DataGridViewAccounts.Rows.Add(New Object() {account.NameOrUrl, account.Username})
    End Sub



End Class
