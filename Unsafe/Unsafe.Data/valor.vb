Imports System.Net

Public Class valor

#Region " api - isBetween (int) "

    ''' <summary>
    ''' Test if a numeric value is between two other values, inclusive.
    ''' </summary>
    ''' <param name="TestValue">The value to test.</param>
    ''' <param name="Lowest">The lowest possible value.</param>
    ''' <param name="Highest">The highest possible value.</param>
    ''' <returns></returns>
    Public Shared Function isBetween(TestValue As Integer, Lowest As Integer, Highest As Integer) As Boolean
        ' is Lowest <= TestValue <= Hightest 
        Return Lowest <= TestValue AndAlso TestValue <= Highest
    End Function

#End Region

#Region " api - isIn (int) "

    ''' <summary>
    ''' Test if a numeric value is contained within a list of values.
    ''' </summary>
    ''' <param name="TestValue">The value to test.</param>
    ''' <param name="AllPossibleValues">This is an array (or ParamArray) of all possible values.</param>
    ''' <returns></returns>
    Public Shared Function isIn(TestValue As Integer, ParamArray AllPossibleValues() As Integer) As Boolean
        Return AllPossibleValues.Where(Function(x) x = TestValue).Count > 0
    End Function

#End Region

End Class
