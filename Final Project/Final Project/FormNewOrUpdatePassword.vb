Imports System.Data.SQLite

Public Class FormNewOrUpdatePassword

    Private _account As Account
    Private _dbConnection As SQLiteConnection

    Public Sub New(ByVal _dbConnection As SQLiteConnection)

        ' This call is required by the designer.
        InitializeComponent()
        Me._dbConnection = _dbConnection
    End Sub

    ''' Account being updated or created
    Public Property Account As Account
        Get
            Return _account
        End Get
        Set(value As Account)
            _account = value
            txtNameOrUrl.Text = _account.NameOrUrl
            txtUsername.Text = _account.Username
            txtPassword.Text = _account.Password
            btnPassword.Text = "Update Password"

            txtNameOrUrl.ReadOnly = True
            txtUsername.ReadOnly = True
        End Set
    End Property

    ''' Create or update a password and perform user validation
    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        ' Perform validation
        Dim nameOrUrl As String = txtNameOrUrl.Text.Trim()
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If nameOrUrl = String.Empty Or username = String.Empty Or password = String.Empty Then
            MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Either create or update
        If _account Is Nothing Then
            ' Create
            _account = New Account(nameOrUrl, username, password)

            ' Insert the account to the database
            Try
                Dim sqlCommand As New SQLiteCommand("INSERT INTO account VALUES(@nameOrURL, @username, @password)", _dbConnection)
                sqlCommand.Parameters.Add("@nameOrURL", DbType.String).Value = nameOrUrl
                sqlCommand.Parameters.Add("@username", DbType.String).Value = username
                sqlCommand.Parameters.Add("@password", DbType.String).Value = password
                sqlCommand.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Unfortunately there is already an account associated to what you're attempting to add.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        Else
            ' Update the record
            Try
                Dim sqlCommand As New SQLiteCommand("UPDATE account SET password = @password WHERE nameOrURL = @nameOrURL AND username = @username", _dbConnection)
                sqlCommand.Parameters.Add("@password", DbType.String).Value = password
                sqlCommand.Parameters.Add("@nameOrURL", DbType.String).Value = _account.NameOrUrl
                sqlCommand.Parameters.Add("@username", DbType.String).Value = _account.Username
                sqlCommand.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Unfortunately there is already an account associated to what you're attempting to add.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            ' Update the object
            _account.Password = password
        End If

        ' Mark this window as successfully processed before closing
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        ' Not yet implemented
    End Sub
End Class