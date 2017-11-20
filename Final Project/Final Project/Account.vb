Public Class Account
    Private mNameOrUrl As String
    Private mUsername As String
    Private mPassword As String


    ''' Create a new account
    Public Sub New(ByVal mNameOrURL As String, ByVal mUsername As String, ByVal mPassword As String)
        Me.mNameOrUrl = mNameOrURL
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
            Return mUsername
        End Get
        Set(value As String)
            mUsername = value
        End Set
    End Property

    ''' Name/URL property
    Public Property NameOrUrl As String
        Get
            Return mNameOrUrl
        End Get
        Set(value As String)
            mNameOrUrl = value
        End Set
    End Property
End Class
