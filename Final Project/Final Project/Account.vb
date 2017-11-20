Public Class Account
    Private mNameOrURL As String
    Private mUsername As String
    Private mPassword As String

    ''' Create a new account
    Public Sub New(ByVal _nameOrURL As String, ByVal _username As String, ByVal _password As String)
        Me.mNameOrURL = mNameOrURL
        Me.mUsername = mUsername
        Me.mPassword = mPassword
    End Sub

    ''' Password property
    Public Property Password As String
        Get
            Return mPassword
        End Get
        Set(value As String)
            mPassword = value
        End Set
    End Property

    ''' Username property
    Public Property Username As String
        Get
            Return Musername
        End Get
        Set(value As String)
            Musername = value
        End Set
    End Property

    ''' Name/URL property
    Public Property NameOrUrl As String
        Get
            Return mNameOrURL
        End Get
        Set(value As String)
            mNameOrURL = value
        End Set
    End Property
End Class
