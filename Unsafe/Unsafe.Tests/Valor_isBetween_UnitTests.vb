Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Unsafe.Data


<TestClass()> Public Class Valor_isBetween_UnitTests

#Region " Valor_isBetween_NormalUsage "

    <TestMethod()> Public Sub Valor_isBetween_NormalUsage()
        Assert.IsTrue(valor.isBetween(10, 0, 100))
    End Sub

#End Region

#Region " Valor_isBetween_ValueTooLow "

    <TestMethod()> Public Sub Valor_isBetween_ValueTooLow()
        Assert.IsFalse(valor.isBetween(-10, 0, 100))
    End Sub

#End Region
#Region " Valor_isBetween_ValueTooHigh "

    <TestMethod()> Public Sub Valor_isBetween_ValueTooHigh()
        Assert.IsFalse(valor.isBetween(1000, 0, 100))
    End Sub

#End Region

#Region " Valor_isBetween_HighLowReversed "

    <TestMethod()> Public Sub Valor_isBetween_HighLowReversed()
        Assert.IsFalse(valor.isBetween(10, 100, 0))
    End Sub

#End Region
#Region " Valor_isBetween_HighLowSame_ValueDifferent "

    <TestMethod()> Public Sub Valor_isBetween_HighLowSame_ValueDifferent()
        Assert.IsFalse(valor.isBetween(10, 0, 0))
    End Sub

#End Region
#Region " Valor_isBetween_HighLowValueSame "

    <TestMethod()> Public Sub Valor_isBetween_HighLowValueSame()
        Assert.IsTrue(valor.isBetween(10, 10, 10))
    End Sub

#End Region

#Region " Valor_isBetween_All_0s "

    <TestMethod()> Public Sub Valor_isBetween_All_0s()
        Assert.IsTrue(valor.isBetween(0, 0, 0))
    End Sub

#End Region
#Region " Valor_isBetween_All_MaxValue "

    <TestMethod()> Public Sub Valor_isBetween_All_MaxValue()
        Assert.IsTrue(valor.isBetween(Integer.MaxValue, Integer.MaxValue, Integer.MaxValue))
    End Sub

#End Region
#Region " Valor_isBetween_All_MinValue "

    <TestMethod()> Public Sub Valor_isBetween_All_MinValue()
        Assert.IsTrue(valor.isBetween(Integer.MinValue, Integer.MinValue, Integer.MinValue))
    End Sub

#End Region

#Region " Valor_isBetween_MaxRange "

    <TestMethod()> Public Sub Valor_isBetween_MaxRange()
        Assert.IsTrue(valor.isBetween(0, Integer.MinValue, Integer.MaxValue))
    End Sub

#End Region
#Region " Valor_isBetween_MaxRange_ValueHigh "

    <TestMethod()> Public Sub Valor_isBetween_MaxRange_ValueHigh()
        Assert.IsTrue(valor.isBetween(Integer.MaxValue, Integer.MinValue, Integer.MaxValue))
    End Sub

#End Region
#Region " Valor_isBetween_MaxRange_ValueLow "

    <TestMethod()> Public Sub Valor_isBetween_MaxRange_ValueLow()
        Assert.IsTrue(valor.isBetween(Integer.MinValue, Integer.MinValue, Integer.MaxValue))
    End Sub

#End Region


End Class