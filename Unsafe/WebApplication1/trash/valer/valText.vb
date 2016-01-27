
Namespace trash


    Public Class valText
        Implements iValTester(Of String)

        Private unSafeValue As String = Nothing

        Public Sub setValue(value As String) Implements iValTester(Of String).setValue
            unSafeValue = value
        End Sub


        Public Function isValid() As Boolean Implements iValTester(Of String).isValid
            Return Not String.IsNullOrWhiteSpace(unSafeValue) _
                   AndAlso unSafeValue.Length < 50
        End Function


        Public Function validate() As String Implements iValTester(Of String).validate
            If isValid() Then
                Return unSafeValue
            Else
                Return Nothing
            End If
        End Function

        Public Function validate([default] As String) As String Implements iValTester(Of String).validate
            If isValid() Then
                Return unSafeValue
            Else
                Return [default]
            End If
        End Function

        Sub New()

        End Sub

    End Class

End Namespace