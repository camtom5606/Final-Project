Public Class FormNewOrUpdatePassword

    Private _account As Account
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
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
        End Set
    End Property

    ''' Create or update a password and perform user validation
    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        ' Perform validation
        Dim nameOrUrl As String = txtNameOrUrl.Text.Trim()
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' Either create or update
        If _account Is Nothing Then
            ' Create
            _account = New Account(nameOrUrl, username, password)
        Else
            ' Update
            _account.NameOrUrl = nameOrUrl
            _account.Username = username
            _account.Password = password
        End If

        ' Mark this window as successfully processed before closing
        DialogResult = DialogResult.OK
        Close()
    End Sub


End Class