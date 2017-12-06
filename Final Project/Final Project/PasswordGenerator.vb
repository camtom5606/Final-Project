Public Class PasswordGenerator
    Private mLength As Integer
    Private mIncludeLowerAZ As Boolean
    Private mIncludeUpperAZ As Boolean
    Private mIncludeDigits As Boolean
    Private mIncludePunctuations As Boolean

    ''' Create a new password generator configured with settings
    Public Sub New(ByVal mLength As Integer, ByVal mIncludeLowerAZ As Boolean,
                   mIncludeUpperAZ As Boolean, ByVal mIncludeDigits As Boolean,
                   ByVal mIncludePunctuations As Boolean)
        Me.mLength = mLength
        Me.mIncludeLowerAZ = mIncludeLowerAZ
        Me.mIncludeUpperAZ = mIncludeUpperAZ
        Me.mIncludeDigits = mIncludeDigits
        Me.mIncludePunctuations = mIncludePunctuations
    End Sub

    ''' Generate a new password based on the given configurations
    Public Function GeneratePassword() As String
        Dim upperAlphabets As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim lowerAlphabets As String = "abcdefghijklmnopqrstuvwxyz"
        Dim digits As String = "0123456789"
        Dim punctuations As String = "!$@#"

        Dim i As Integer = 0
        Dim random As New Random()
        Dim password As String = ""

        ' Generate the password
        While i < mLength
            If mIncludeUpperAZ And random.Next(2) = 1 Then
                password = password & upperAlphabets(random.Next(upperAlphabets.Length))
                i += 1
            ElseIf mIncludeLowerAZ And random.Next(2) = 1 Then
                password = password & lowerAlphabets(random.Next(lowerAlphabets.Length))
                i += 1
            ElseIf mIncludeDigits And random.Next(2) = 1 Then
                password = password & digits(random.Next(digits.Length))
                i += 1
            ElseIf mIncludePunctuations And random.Next(2) = 1 Then
                password = password & punctuations(random.Next(punctuations.Length))
                i += 1
            End If
        End While

        Return password
    End Function
End Class

