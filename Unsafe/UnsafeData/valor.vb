Imports System.Net

Public Class valor

#Region " api - isBetween (int) "

    Public Shared Function isBetween(TestValue As Integer, Lowest As Integer, Hightest As Integer) As Boolean
        ' is Lowest <= TestValue <= Hightest 
        Return Lowest <= TestValue AndAlso TestValue <= Hightest
    End Function

#End Region

#Region " api - isIn (int) "

    Public Shared Function isIn(TestValue As Integer, ParamArray AllPossibleValues() As Integer) As Boolean
        Return AllPossibleValues.Where(Function(x) x = TestValue).Count > 0
    End Function

#End Region

End Class
