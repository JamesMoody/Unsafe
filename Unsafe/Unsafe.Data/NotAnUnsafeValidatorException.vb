
Public Class NotAnUnsafeValidatorException
    Inherits Exception

    Private Const cnstMessage As String = "Given type doesn't inherit from UnsafeValidator."

    Public Overrides ReadOnly Property Message As String
        Get
            Return cnstMessage
        End Get
    End Property

End Class
