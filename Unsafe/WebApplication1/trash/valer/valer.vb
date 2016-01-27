


Namespace trash


    Public Class valer

        Public Shared Function queryString(Of T As iValTester(Of String))(ByVal key As String) As T
            Dim unsafeVal As String = HttpContext.Current.Request.QueryString(key)
            'Dim tester As New T()



        End Function

    End Class



End Namespace