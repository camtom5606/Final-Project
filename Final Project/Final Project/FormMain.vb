Imports System.Data.SQLite

Public Class FormMain
    Private _dbConnection As SQLiteConnection

    ''' Initialize the user interface
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' Open a connection to the database
        _dbConnection = New SQLiteConnection("Data Source=" & Application.StartupPath & "\passwords.db")
        _dbConnection.Open()

        ' Create the tables if it does not exist
        Dim sqlCommand As New SQLiteCommand("CREATE TABLE IF NOT EXISTS account (nameOrURL VARCHAR(255) NOT NULL, username VARCHAR(255) NOT NULL, password VARCHAR(255) NOT NULL, PRIMARY KEY(nameOrURL, username))", _dbConnection)
        sqlCommand.ExecuteNonQuery()

        ' Select and display all accounts
        Dim dataAdapter As New SQLiteDataAdapter("SELECT nameOrURL, username FROM account", _dbConnection)
        Dim dataTable As New DataTable()
        dataAdapter.Fill(dataTable)

        For Each row As DataRow In dataTable.Rows
            Dim nameOrUrl As String = row("nameOrURL").ToString()
            Dim username As String = row("username").ToString()

            DataGridViewAccounts.Rows.Add(New Object() {nameOrUrl, username})
        Next
    End Sub

    ''' Show the window for creating a new password
    Private Sub ToolStripButtonNewPassword_Click(sender As Object, e As EventArgs) Handles ToolStripButtonNewPassword.Click
        Dim formNewPassword As New FormNewOrUpdatePassword(_dbConnection)

        If formNewPassword.ShowDialog() <> DialogResult.OK Then
            Exit Sub
        End If

        ' Add the new account
        Dim account As Account = formNewPassword.Account
        DataGridViewAccounts.Rows.Add(New Object() {account.NameOrUrl, account.Username})
    End Sub

    Private Sub DataGridViewAccounts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAccounts.CellContentClick
        If TypeOf DataGridViewAccounts.Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex >= 2 And e.ColumnIndex <= 4 Then
                ' Query the selected account
                Dim dataAdapter As New SQLiteDataAdapter("SELECT nameOrURL, username, password FROM account WHERE nameOrURL = @nameOrURL AND username = @username", _dbConnection)
                dataAdapter.SelectCommand.Parameters.Add("@nameOrURL", DbType.String).Value = DataGridViewAccounts.Rows(e.RowIndex).Cells(0).Value.ToString()
                dataAdapter.SelectCommand.Parameters.Add("@username", DbType.String).Value = DataGridViewAccounts.Rows(e.RowIndex).Cells(1).Value.ToString()

                Dim dataTable As New DataTable()
                dataAdapter.Fill(dataTable)

                Dim account As New Account(dataTable.Rows(0)("nameOrURL").ToString(), dataTable.Rows(0)("username").ToString(), dataTable.Rows(0)("password").ToString())

                If e.ColumnIndex = 2 Then
                    ' Copy password to clipboard
                    Clipboard.SetText(account.Password)
                    MessageBox.Show("Password copied to clipboard.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf e.ColumnIndex = 3 Then
                    ' Update password
                    Dim formUpdatePassword As New FormNewOrUpdatePassword(_dbConnection)
                    formUpdatePassword.Account = account

                    If formUpdatePassword.ShowDialog() <> DialogResult.OK Then
                        Exit Sub
                    End If
                ElseIf e.ColumnIndex = 4 Then
                    ' Delete password
                    If MessageBox.Show("Are you sure you want to delete this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                        Exit Sub
                    End If

                    Dim sqlCommand As New SQLiteCommand("DELETE FROM account WHERE nameOrURL = @nameOrURL AND username = @username", _dbConnection)
                    sqlCommand.Parameters.Add("@nameOrURL", DbType.String).Value = account.NameOrUrl
                    sqlCommand.Parameters.Add("@username", DbType.String).Value = account.Username
                    sqlCommand.ExecuteNonQuery()

                    DataGridViewAccounts.Rows.RemoveAt(e.RowIndex)
                End If
            End If
        End If
    End Sub

    ''' Search and filter the passwords
    Private Sub ToolStripButtonSearchPassword_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSearchPassword.Click
        Dim keyword As String = ToolStripTextBoxSearch.Text.Trim()

        If keyword = String.Empty Then
            Return
        End If

        ' Query the accounts that contains the keyword
        DataGridViewAccounts.Rows.Clear()

        Dim dataAdapter As New SQLiteDataAdapter("SELECT nameOrURL, username FROM account WHERE nameOrURL LIKE @keyword1 OR username LIKE @keyword2", _dbConnection)
        dataAdapter.SelectCommand.Parameters.Add("@keyword1", DbType.String).Value = "%" & keyword & "%"
        dataAdapter.SelectCommand.Parameters.Add("@keyword2", DbType.String).Value = "%" & keyword & "%"

        Dim dataTable As New DataTable()
        dataAdapter.Fill(dataTable)

        For Each row As DataRow In dataTable.Rows
            Dim nameOrUrl As String = row("nameOrURL").ToString()
            Dim username As String = row("username").ToString()

            DataGridViewAccounts.Rows.Add(New Object() {nameOrUrl, username})
        Next
    End Sub

    ''' Close connection from DB
    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _dbConnection.Close()
    End Sub

    ''' Display all accounts
    Private Sub ToolStripButtonShowAll_Click(sender As Object, e As EventArgs) Handles ToolStripButtonShowAll.Click
        DataGridViewAccounts.Rows.Clear()

        Dim dataAdapter As New SQLiteDataAdapter("SELECT nameOrURL, username FROM account", _dbConnection)
        Dim dataTable As New DataTable()
        dataAdapter.Fill(dataTable)

        For Each row As DataRow In dataTable.Rows
            Dim nameOrUrl As String = row("nameOrURL").ToString()
            Dim username As String = row("username").ToString()

            DataGridViewAccounts.Rows.Add(New Object() {nameOrUrl, username})
        Next
    End Sub

End Class
