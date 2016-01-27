
Namespace trash

    Public Interface iValTester(Of T)

        Sub setValue(value As T)

        Function isValid() As Boolean

        Function validate() As T
        Function validate(ByVal [default] As T) As T



    End Interface

End Namespace


