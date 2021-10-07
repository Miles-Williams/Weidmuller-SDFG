<Serializable()>
Public Class C_User
    Public Property FullName As String
    Public Property Username As String
    Public Property Salt As String
    Public Property HashedPw As String
    Public Property SigPath As String

    Public Sub New(parFullName As String,
                   parUsername As String,
                   parSalt As String,
                   parHashedPw As String,
                   Optional parSigPath As String = "")

        FullName = parFullName
        Username = parUsername
        Salt = parSalt
        HashedPw = parHashedPw
        SigPath = parSigPath

    End Sub

End Class
