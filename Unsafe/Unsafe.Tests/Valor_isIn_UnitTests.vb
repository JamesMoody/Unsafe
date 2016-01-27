Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Unsafe.Data


<TestClass()> Public Class Valor_isIn_UnitTests


#Region " Valor_isIn_NormalUsage_WithParamArray "

    <TestMethod()> Public Sub Valor_isIn_NormalUsage_WithParamArray()
        Assert.IsTrue(valor.isIn(10, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20))
    End Sub

#End Region
#Region " Valor_isIn_NormalUsage_WithArray "

    <TestMethod()> Public Sub Valor_isIn_NormalUsage_WithArray()
        Assert.IsTrue(valor.isIn(10, TestValues.SequentialTestArray))
    End Sub

#End Region

#Region " Valor_isIn_AltUsage_WithList "

    <TestMethod()> Public Sub Valor_isIn_AltUsage_WithList()
        Dim TestList As New List(Of Integer)(TestValues.SequentialTestArray)

        Assert.IsTrue(valor.isIn(10, TestList.ToArray()))
    End Sub

#End Region
#Region " Valor_isIn_AltUsage_WithArrayInParam "

    <TestMethod()> Public Sub Valor_isIn_AltUsage_WithArrayInParam()
        Assert.IsTrue(valor.isIn(10, {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}))
    End Sub

#End Region

#Region " Valor_isIn_ValueTooLow "

    <TestMethod()> Public Sub Valor_isIn_ValueTooLow()
        Assert.IsFalse(valor.isIn(-10, TestValues.SequentialTestArray))
    End Sub

#End Region
#Region " Valor_isIn_ValueTooHigh "

    <TestMethod()> Public Sub Valor_isIn_ValueTooHigh()
        Assert.IsFalse(valor.isIn(100, TestValues.SequentialTestArray))
    End Sub

#End Region

#Region " Valor_isIn_ValueMinValue "

    <TestMethod()> Public Sub Valor_isIn_ValueMinValue()
        Assert.IsFalse(valor.isIn(Integer.MinValue, TestValues.SequentialTestArray))
    End Sub

#End Region
#Region " Valor_isIn_ValueMaxValue "

    <TestMethod()> Public Sub Valor_isIn_ValueMaxValue()
        Assert.IsFalse(valor.isIn(Integer.MaxValue, TestValues.SequentialTestArray))
    End Sub

#End Region

#Region " Valor_isIn_NonsequentialHasValue "

    <TestMethod()> Public Sub Valor_isIn_NonsequentialHasValue()
        Assert.IsTrue(valor.isIn(10, TestValues.EvenTestArray))
    End Sub

#End Region
#Region " Valor_isIn_NonsequentialMissingValue "

    <TestMethod()> Public Sub Valor_isIn_NonsequentialMissingValue()
        Assert.IsFalse(valor.isIn(11, TestValues.EvenTestArray))
    End Sub

#End Region

#Region " Valor_isIn_ReversedHasValue "

    <TestMethod()> Public Sub Valor_isIn_ReversedHasValue()
        Dim tmpArray(TestValues.EvenTestArray.Length - 1) As Integer
        TestValues.EvenTestArray.CopyTo(tmpArray, 0)
        Array.Reverse(tmpArray)

        Assert.IsTrue(valor.isIn(10, tmpArray))
    End Sub

#End Region
#Region " Valor_isIn_ReversedMissingValue "

    <TestMethod()> Public Sub Valor_isIn_ReversedMissingValue()
        Dim tmpArray(TestValues.EvenTestArray.Length - 1) As Integer
        TestValues.EvenTestArray.CopyTo(tmpArray, 0)
        Array.Reverse(tmpArray)

        Assert.IsFalse(valor.isIn(11, tmpArray))
    End Sub

#End Region

#Region " Valor_isIn_NoOrderHasValue "

    <TestMethod()> Public Sub Valor_isIn_NoOrderHasValue()
        Assert.IsTrue(valor.isIn(10, 5, 15, 10, 20, 0))
    End Sub

#End Region
#Region " Valor_isIn_NoOrderMissingValue "

    <TestMethod()> Public Sub Valor_isIn_NoOrderMissingValue()
        Assert.IsFalse(valor.isIn(11, 5, 15, 10, 20, 0))
    End Sub

#End Region

#Region " Valor_isIn_BadArrayParam_Missing "

    <TestMethod()> Public Sub Valor_isIn_BadArrayParam_Missing()
        Assert.IsFalse(valor.isIn(10))
    End Sub

#End Region
#Region " Valor_isIn_BadArrayParam_Empty "

    <TestMethod()> Public Sub Valor_isIn_BadArrayParam_Empty()
        Assert.IsFalse(valor.isIn(10, {}))
    End Sub

#End Region
#Region " Valor_isIn_BadArrayParam_Nothing "

    <TestMethod()> Public Sub Valor_isIn_BadArrayParam_Nothing()
        Try
            Dim result As Boolean = valor.isIn(10, Nothing)

            ' this should no be possible
            Assert.Fail("Expected Exception: ArgumentNullException")

        Catch ex As Exception
            Assert.IsTrue(TypeOf ex Is ArgumentNullException)
        End Try
    End Sub

#End Region

End Class
